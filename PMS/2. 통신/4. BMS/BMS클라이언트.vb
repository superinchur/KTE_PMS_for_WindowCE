
Imports System
Imports System.Net
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data



Imports System.Text
Imports System.IO

Imports System.Net.Sockets
Imports System.Threading
Public Class BMS클라이언트

    ' Private MBmaster As ModbusTCP.Master = New Master(IPaddr, Port)
    Private data As Byte()

    Const IPaddr As String = "192.168.0.247"
    'Const IPaddr As String = "192.168.0.201"
    'Const IPaddr As String = "127.0.0.1"
    Const Port As String = "502"

    ' -----------------------------------------------
    ' Constants for access
    Private Const fctReadCoil As Byte = 1
    Private Const fctReadDiscreteInputs As Byte = 2
    Private Const fctReadHoldingRegister As Byte = 3
    Private Const fctReadInputRegister As Byte = 4
    Private Const fctWriteSingleCoil As Byte = 5
    Private Const fctWriteSingleRegister As Byte = 6
    Private Const fctWriteMultipleCoils As Byte = 15
    Private Const fctWriteMultipleRegister As Byte = 16
    Private Const fctReadWriteMultipleRegister As Byte = 23

#Region "정의"
    ''' <summary>Constant for exception illegal function.</summary>
    Public Const excIllegalFunction As Byte = 1
    ''' <summary>Constant for exception illegal data address.</summary>
    Public Const excIllegalDataAdr As Byte = 2
    ''' <summary>Constant for exception illegal data value.</summary>
    Public Const excIllegalDataVal As Byte = 3
    ''' <summary>Constant for exception slave device failure.</summary>
    Public Const excSlaveDeviceFailure As Byte = 4

    ''' <summary>Constant for exception acknowledge.</summary>
    Public Const excAck As Byte = 5

    ''' <summary>Constant for exception slave is busy/booting up.</summary>
    Public Const excSlaveIsBusy As Byte = 6

    ''' <summary>Constant for exception gate path unavailable.</summary>
    Public Const excGatePathUnavailable As Byte = 10

    ''' <summary>Constant for exception not connected.</summary>
    Public Const excExceptionNotConnected As Byte = 253

    ''' <summary>Constant for exception connection lost.</summary>
    Public Const excExceptionConnectionLost As Byte = 254

    ''' <summary>Constant for exception response timeout.</summary>
    Public Const excExceptionTimeout As Byte = 255

    ''' <summary>Constant for exception wrong offset.</summary>
    Private Const excExceptionOffset As Byte = 128

    ''' <summary>Constant for exception send failt.</summary>
    Private Const excSendFailt As Byte = 100

    ' ------------------------------------------------------------------------
    ' Private declarations
    Private Shared _timeout As Integer = 500

    Private Shared _refresh As Integer = 10

    Private Shared _connected As Boolean = False

    Private tcpAsyCl As Socket

    Private tcpAsyClBuffer() As Byte = New Byte((2048) - 1) {}

    Private tcpSynCl As Socket

    Private tcpSynClBuffer() As Byte = New Byte((2048) - 1) {}


    Dim writedata As Byte()
    Dim Length As Byte

    Dim heartbit As UShort

    Private btRecvBuffer(1024) As Byte
    Private nRecvBufferLength As Integer = 0
#End Region

    WithEvents Timer_Comm As New Windows.Forms.Timer

    ''' <summary>Response data event. This event is called when new data arrives</summary>
    Public Delegate Sub ResponseData(ByVal ids As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal data() As Byte)

    ''' <summary>Response data event. This event is called when new data arrives</summary>
    Public Event OnResponseData As ResponseData

    ''' <summary>Exception data event. This event is called when the data is incorrect</summary>
    Public Delegate Sub ExceptionData(ByVal ids As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal exception As Byte)

    ''' <summary>Exception data event. This event is called when the data is incorrect</summary>
    Public Event OnException As ExceptionData

    Public Sub ServiceStart()

        Timer_Comm.Enabled = False

        ' 서버를 시작시킨다.
        Try
            connect(IPaddr, Port)
            AddHandler OnResponseData, New ResponseData(AddressOf MBmaster_OnResponseData)
            AddHandler OnException, New ExceptionData(AddressOf MBmaster_OnException)


        Catch [error] As SystemException
            MessageBox.Show([error].Message)
        End Try

        현재BSC상태 = BSC상태.Connect
        Timer_Comm.Interval = 1000
        Timer_Comm.Enabled = True

    End Sub


    ' ------------------------------------------------------------------------
    ''' <summary>Start connection to slave.</summary>
    ''' <param name="ip">IP adress of modbus slave.</param>
    ''' <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
    Public Sub connect(ByVal ip As String, ByVal port As Integer)
        Try
            Me.tcpAsyCl = New Socket(IPAddress.Parse(ip).AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            Me.tcpAsyCl.Connect(New IPEndPoint(IPAddress.Parse(ip), port))
            _connected = True
        Catch err As System.IO.IOException
            _connected = False
            Throw
        End Try

    End Sub

    Private Sub Timer_Comm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Comm.Tick
        Timer_Comm.Enabled = False

        'Dim StartAddress As UShort = ReadStartAdr(num_Rack, num_Module)
        'Dim length As UShort = ReadLength(num_Rack, num_Module)
        Dim StartAddress As UShort
        Dim length As UShort

        ReDim writedata(6)
        Try
            StartAddress = 40000
            length = 27 * 2
            ReadHoldingRegister(3, StartAddress, length)
            ' Read Heartbit (읽어온다


            ' 읽어온 Heartbit를 Write 한다
            StartAddress = 44000

            If heartbit = 1 Then
                heartbit = 0
            Else
                heartbit = 1
            End If
            ' 44000 Controller HeartBeat
            writedata(0) = heartbit \ &H100
            writedata(1) = heartbit Mod &H100

            '44001
            Dim temp_BSCStatus As UShort = Set_BSCStatus()
            writedata(2) = temp_BSCStatus \ &H100
            writedata(3) = temp_BSCStatus Mod &H100

            '44002
            Dim temp_Req_Contactor As UShort = Set_BSC_Req_Contactor()
            writedata(4) = temp_Req_Contactor \ &H100
            writedata(5) = temp_Req_Contactor Mod &H100

            WriteMultipleRegister(StartAddress, writedata)


        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

        Timer_Comm.Enabled = True
    End Sub


    ' ------------------------------------------------------------------------
    ' Write asynchronous data
    Private Sub WriteAsyncData(ByVal write_data() As Byte, ByVal id As Integer)
        If ((Not (Me.tcpAsyCl) Is Nothing) _
                    AndAlso Me.tcpAsyCl.Connected) Then
            Try
                Me.tcpAsyCl.BeginSend(write_data, 0, write_data.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), Nothing)
                Me.tcpAsyCl.BeginReceive(Me.tcpAsyClBuffer, 0, Me.tcpAsyClBuffer.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Me.tcpAsyCl)
            Catch a As SystemException
                Me.CallException(id, write_data(6), write_data(7), excExceptionConnectionLost)
            End Try

        Else
            Me.CallException(id, write_data(6), write_data(7), excExceptionConnectionLost)
        End If

    End Sub
    ' ------------------------------------------------------------------------
    ' Write asynchronous data acknowledge
    Private Sub OnSend(ByVal result As System.IAsyncResult)
        If (result.IsCompleted = False) Then
            Me.CallException(65535, 255, 255, excSendFailt)
        End If

    End Sub

    ' ------------------------------------------------------------------------
    ' Write asynchronous data response
    Private Sub OnReceive(ByVal result As System.IAsyncResult)
        If (result.IsCompleted = False) Then
            Me.CallException(255, 255, 255, excExceptionConnectionLost)
        End If

        'Dim id As Integer = SwapUInt16(BitConverter.ToUInt16(Me.tcpAsyClBuffer, 0))
        Dim id As Integer = tcpAsyClBuffer(0) * 256 + tcpAsyClBuffer(1)
        Dim unit As Byte = Me.tcpAsyClBuffer(6)
        Dim func As Byte = Me.tcpAsyClBuffer(7)
        Dim data() As Byte
        ' ------------------------------------------------------------
        ' Write response data
        If ((func >= fctWriteSingleCoil) _
                    AndAlso (func <> fctReadWriteMultipleRegister)) Then
            data = New Byte((2) - 1) {}
            Array.Copy(Me.tcpAsyClBuffer, 10, data, 0, 2)
        End If

        ' ------------------------------------------------------------
        ' Read response data
        data = New Byte((Me.tcpAsyClBuffer(8)) - 1) {}
        Array.Copy(Me.tcpAsyClBuffer, 9, data, 0, Me.tcpAsyClBuffer(8))
        ' ------------------------------------------------------------
        ' Response data is slave exception
        If (func > excExceptionOffset) Then
            func = (func - excExceptionOffset)
            Me.CallException(id, unit, func, Me.tcpAsyClBuffer(8))
        End If

        ' ------------------------------------------------------------
        ' Response data is regular data
        ' If (Not (OnResponseData) Is Nothing) Then
        RaiseEvent OnResponseData(id, unit, func, data)
        'End If

    End Sub
   
    ' ------------------------------------------------------------------------
    ' Create modbus header for read action
    Private Function CreateReadHeader(ByVal id As UShort, ByVal unit As Byte, ByVal startAddress As UShort, ByVal length As UShort, ByVal func As Byte) As Byte()
        Dim data() As Byte = New Byte((12) - 1) {}
        Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
        data(0) = _id(1)
        ' Slave id high byte
        data(1) = _id(0)
        ' Slave id low byte
        data(5) = 6
        ' Message size
        data(6) = unit
        ' Slave address
        data(7) = func

        data(8) = startAddress \ &H100
        ' Start address
        data(9) = startAddress Mod &H100
        ' Start address
        ' Number of data to read
        data(10) = length \ &H100
        ' Number of data to read
        data(11) = length Mod &H100
        ' Number of data to read
        Return data
    End Function

    ' ------------------------------------------------------------------------
    ' Create modbus header for write action
    Private Function CreateWriteHeader(ByVal id As UShort, ByVal unit As Byte, ByVal startAddress As UShort, ByVal numData As UShort, ByVal numBytes As UShort, ByVal func As Byte) As Byte()
        Dim data() As Byte = New Byte(((numBytes + 11)) - 1) {}
        Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
        data(0) = _id(1)
        ' Slave id high byte
        data(1) = _id(0)
        ' Slave id low byte
        'Dim _size() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType((5 + numBytes), Short)), Short))
        data(4) = CType((5 + numBytes), Short) \ &H100
        ' Complete message size in bytes
        data(5) = CType((5 + numBytes), Short) Mod &H100
        ' Complete message size in bytes
        data(6) = unit
        ' Slave address
        data(7) = func
        ' Function code
        data(8) = startAddress \ &H100
        ' Start address
        data(9) = startAddress Mod &H100
        ' Start address
        If (func >= fctWriteMultipleCoils) Then
            data(10) = numData \ &H100
            ' Number of bytes
            data(11) = numData Mod &H100
            ' Number of bytes
            data(12) = CType((numBytes - 2), Byte)
        End If

        Return data
    End Function

    ' ------------------------------------------------------------------------
    ' Create modbus header for read/write action
    Private Function CreateReadWriteHeader(ByVal id As UShort, ByVal unit As Byte, ByVal startReadAddress As UShort, ByVal numRead As UShort, ByVal startWriteAddress As UShort, ByVal numWrite As UShort) As Byte()
        Dim data() As Byte = New Byte((((numWrite * 2) _
                    + 17)) - 1) {}
        Dim _id() As Byte = BitConverter.GetBytes(CType(id, Short))
        data(0) = _id(1)
        ' Slave id high byte
        data(1) = _id(0)
        ' Slave id low byte
        Dim _size() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType((11 _
                            + (numWrite * 2)), Short)), Short))
        data(4) = _size(0)
        ' Complete message size in bytes
        data(5) = _size(1)
        ' Complete message size in bytes
        data(6) = unit
        ' Slave address
        data(7) = fctReadWriteMultipleRegister
        ' Function code
        Dim _adr_read() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startReadAddress, Short)), Short))
        data(8) = _adr_read(0)
        ' Start read address
        data(9) = _adr_read(1)
        ' Start read address
        Dim _cnt_read() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(numRead, Short)), Short))
        data(10) = _cnt_read(0)
        ' Number of bytes to read
        data(11) = _cnt_read(1)
        ' Number of bytes to read
        Dim _adr_write() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(startWriteAddress, Short)), Short))
        data(12) = _adr_write(0)
        ' Start write address
        data(13) = _adr_write(1)
        ' Start write address
        Dim _cnt_write() As Byte = BitConverter.GetBytes(CType(IPAddress.HostToNetworkOrder(CType(numWrite, Short)), Short))
        data(14) = _cnt_write(0)
        ' Number of bytes to write
        data(15) = _cnt_write(1)
        ' Number of bytes to write
        data(16) = CType((numWrite * 2), Byte)
        Return data
    End Function

    Private Sub ReadHoldingRegister(ByVal ID As UShort, ByVal StartAddress As UShort, ByVal Length As UShort)

        Dim func As UShort = 3
        Dim Unit As Byte = 1

        WriteAsyncData(Me.CreateReadHeader(ID, Unit, StartAddress, Length, fctReadHoldingRegister), func)
    End Sub
    Private Sub ReadInputRegister(ByVal StartAddress As UShort, ByVal Length As UShort)
        Dim ID As UShort = 4
        Dim Unit As Byte = 1

        WriteAsyncData(CreateReadHeader(ID, Unit, StartAddress, Length, fctReadInputRegister), ID)
    End Sub

    Private Sub WriteMultipleRegister(ByVal StartAddress As UShort, ByRef data As Byte())
        Dim ID As UShort = 8
        Dim Unit As Byte = 1

        Dim numBytes As Integer = Convert.ToUInt16(data.Length)
        If ((numBytes Mod 2) _
                    > 0) Then
            numBytes = (numBytes + 1)
        End If

        Dim data2() As Byte
        data2 = Me.CreateWriteHeader(ID, Unit, StartAddress, Convert.ToUInt16((numBytes / 2)), Convert.ToUInt16((numBytes + 2)), fctWriteMultipleRegister)
        Array.Copy(data, 0, data2, 13, data.Length)
        Me.WriteAsyncData(data2, ID)

    End Sub
    Private Function GetData(ByVal num As Integer) As Byte()
        Dim word As Integer() = New Integer(num - 1) {}

        ' Num은 Length인건가

        Try
            'word(x) = Convert.ToInt16(ctrl.Text)
        Catch __unusedSystemException1__ As SystemException
            'word(x) = Convert.ToUInt16(ctrl.Text)
        End Try


        data = New Byte(num * 2 - 1) {}
        For x As Integer = 0 To num - 1
            Dim dat As Byte() = BitConverter.GetBytes(CShort(IPAddress.HostToNetworkOrder(CShort(word(x)))))

            data(x * 2) = dat(0)
            data(x * 2 + 1) = dat(1)
        Next

        Return data

    End Function


    Private Sub MBmaster_OnResponseData(ByVal ID As UShort, ByVal unit As Byte, ByVal func As Byte, ByVal values As Byte())

        'If Me.InvokeRequired Then
        'Me.BeginInvoke(New ResponseData(AddressOf MBmaster_OnResponseData), New Object() {ID, unit, func, values})
        'Return
        'End If

        If ID = &HFF Then
            Return
        End If

        Select Case ID
            Case 1
                data = values
                'heartbit = Convert.ToUInt16(values(1))

            Case 2

                data = values

            Case 3
                data = values
                'heartbit = Convert.ToUInt16(values(1))
                'Debug.WriteLine("ID3 is : " + data(1).ToString)
                ShowAs()
            Case 4
                'Read Input Register
                data = values
                Dim temp_value As UShort

                cBMS_Rack(num_Rack).Max_Cell_Voltage = Convert.ToDouble(data(0))
                temp_value = data(0) * 256 + data(1)
                ' If temp_value > 0 Then
                Debug.WriteLine("ID4 is : " + temp_value.ToString)
                ' End If
                ShowAs()
            Case 5

            Case 6

            Case 7

            Case 8
                ' Write 한거임

        End Select
    End Sub

    Private Sub MBmaster_OnException(ByVal id As UShort, ByVal unit As Byte, ByVal func As Byte, ByVal exception As Byte)
        ' ------------------------------------------------------------------
        'Seperate calling threads
        If Me.InvokeRequired Then
            Me.BeginInvoke(New ExceptionData(AddressOf MBmaster_OnException), New Object() {id, unit, func, exception})
            Return
        End If

        Dim exc As String = "Modbus says error: "
        Select Case exception
            Case excIllegalFunction
                exc += "Illegal function!"
            Case excIllegalDataAdr
                exc += "Illegal data adress!"
            Case excIllegalDataVal
                exc += "Illegal data value!"
            Case excSlaveDeviceFailure
                exc += "Slave device failure!"
            Case excAck
                exc += "Acknoledge!"
            Case excGatePathUnavailable
                exc += "Gateway path unavailbale!"
            Case excExceptionTimeout
                exc += "Slave timed out!"
            Case excExceptionConnectionLost
                exc += "Connection is lost!"
            Case excExceptionNotConnected
                exc += "Not connected!"
        End Select

        MessageBox.Show(exc, "Modbus slave exception")
    End Sub

    Private Sub ShowAs()
        Dim x As UShort

        Dim word As UShort() = New UShort(0) {}

        If data.Length < 2 Then Return
        word = New UShort(data.Length / 2 - 1) {}
        x = 0
        While x < data.Length
            word(x / 2) = data(x) * 256 + data(x + 1)
            x = x + 2
        End While

        Display(word)

    End Sub

    Private Function ReadStartAdr(ByVal nRack As UShort, ByVal nModule As UShort) As UShort

        Dim nStartAddress As UShort
        If BMS현재통신모드 = BMS통신모드정의.BankInfo Then
            nStartAddress = 0
        ElseIf BMS현재통신모드 = BMS통신모드정의.RackInfo Then
            nStartAddress = (379 * nRack) - 354
        ElseIf BMS현재통신모드 = BMS통신모드정의.ModuleInfo Then
            nStartAddress = (379 * nRack) + (9 * nModule) - 354
        End If

        Return nStartAddress

    End Function

    Private Function ReadLength(ByVal nRack As UShort, ByVal nModule As UShort) As UShort

        Dim nLength As UShort
        If BMS현재통신모드 = BMS통신모드정의.BankInfo Then
            nLength = 25
        ElseIf BMS현재통신모드 = BMS통신모드정의.RackInfo Then
            nLength = 19
        ElseIf BMS현재통신모드 = BMS통신모드정의.ModuleInfo Then
            nLength = 9
        End If

        Return nLength

    End Function

    Private Function Set_BSCStatus()
        Dim BSCStatus As UShort = 0

        Select Case 현재BSC상태
            Case BSC상태.Connect
                ' 추후 수정이 필요함
                현재BSC상태 = BSC상태.Initializing

            Case BSC상태.Initializing
                BSCStatus = SetBitmask(BSCStatus, 2, 1) ' Initializing
                현재BSC상태 = BSC상태.Normal ' 추후 수정 필요
            Case BSC상태.Normal
            Case BSC상태.Contactor_Open

                BSCStatus = SetBitmask(BSCStatus, 0, 0) ' Shutdown()
                BSCStatus = SetBitmask(BSCStatus, 1, 0) ' Shutdown()
        End Select

        'BSCStatus = SetBitmask(BSCStatus, 0, 0) ' None
        'BSCStatus = SetBitmask(BSCStatus, 1, 0) ' BMS not connected
        'BSCStatus = SetBitmask(BSCStatus, 2, 0) ' Initializing
        'BSCStatus = SetBitmask(BSCStatus, 3, 1) ' Normal
        'BSCStatus = SetBitmask(BSCStatus, 4, 0) ' NPS ( Normal Power Saving)
        'BSCStatus = SetBitmask(BSCStatus, 5, 0) ' Manual
        'BSCStatus = SetBitmask(BSCStatus, 6, 0) ' Emergency
        'BSCStatus = SetBitmask(BSCStatus, 7, 0) ' PPS(Protective Power Saving)


        Return BSCStatus
    End Function

    Private Function controller_status()
        Dim status As UShort

        status = SetBitmask(status, 1, 1)

        Return status
    End Function
    Private Function Set_BSC_Req_Contactor()
        Dim status As UShort
        Select Case 현재BSC상태
            Case BSC상태.Contactor_Close
                status = SetBitmask(status, 1, 1)
                현재BSC상태 = BSC상태.Normal ' 추후 수정 필요
            Case BSC상태.Contactor_Open1
                현재BSC상태 = BSC상태.Contactor_Open2 ' 추후 수정 필요
            Case BSC상태.Contactor_Open2
                status = SetBitmask(status, 0, 1)
                현재BSC상태 = BSC상태.Normal ' 추후 수정 필요
            Case Else
                status = SetBitmask(status, 1, 0)
                status = SetBitmask(status, 2, 0)
        End Select
        Return status
    End Function

    Private Function UShortToShort(ByVal vIn As Integer) As Short
        Dim vOut As Short
        If vIn > 32767 Then
            vOut = (vIn - 32768) * -1
        End If
        Return vOut
    End Function

    Private Sub Display(ByVal word() As UShort)


        cBMS.Bank_SOC = Convert.ToDouble(word(12)) / 10
        cBMS.Bank_SOH = Convert.ToDouble(word(13)) / 10
        cBMS.Bank_DC전압 = Convert.ToDouble(word(14)) / 10


        cBMS.Bank_DC전류 = Convert.ToDouble(Convert.ToInt16(word(15).ToString("X4"), 16)) / 10
        cBMS.Bank_충방전_전력_제한값 = Convert.ToDouble(word(14)) / 10
        cBMS.Bank내_Cell_최고_전압 = Convert.ToDouble(word(16)) / 1000
        cBMS.Bank내_Cell_최소_전압 = Convert.ToDouble(word(18)) / 1000
        cBMS.Bank내_Module_최고_온도 = Convert.ToDouble(Convert.ToInt16(word(20).ToString("X4"), 16))
        cBMS.Bank내_Module_최저_온도 = Convert.ToDouble(Convert.ToInt16(word(22).ToString("X4"), 16))
        cBMS.Bank_충방전_전력 = Convert.ToDouble(Convert.ToInt16(word(24).ToString("X4"), 16))

        If BMS현재통신모드 = BMS통신모드정의.BankInfo Then
        ElseIf BMS현재통신모드 = BMS통신모드정의.RackInfo Then
            cBMS_Rack(num_Rack).Rack_SOC = word(3)
            cBMS_Rack(num_Rack).Rack_SOH = word(4)
            cBMS_Rack(num_Rack).Rack_Voltage = word(5)
            cBMS_Rack(num_Rack).Rack_Current = Convert.ToInt16(word(6).ToString("X4"), 16)
            cBMS_Rack(num_Rack).Max_Cell_Voltage = word(7)
            cBMS_Rack(num_Rack).Max_Cell_Voltage_Position = word(8)
            cBMS_Rack(num_Rack).Min_Cell_Voltage = word(9)
            cBMS_Rack(num_Rack).Min_Cell_Voltage_Position = word(10)
            cBMS_Rack(num_Rack).Cell_Voltage_Gap = word(11)
            cBMS_Rack(num_Rack).Rack_Average_Cell_Voltage = word(12)
            cBMS_Rack(num_Rack).Max_Cell_Temperature = Convert.ToInt16(word(13).ToString("X4"), 16)
            cBMS_Rack(num_Rack).Max_Cell_Temperature_Position = word(14)
            cBMS_Rack(num_Rack).Min_Cell_Temperature = Convert.ToInt16(word(14).ToString("X4"), 16)
            cBMS_Rack(num_Rack).Min_Cell_Temperature_Position = word(15)
            cBMS_Rack(num_Rack).Cell_Temperature_Gap = word(16)
            cBMS_Rack(num_Rack).Rack_Average_Module_Temperature = word(17)
        ElseIf BMS현재통신모드 = BMS통신모드정의.ModuleInfo Then

            cBMS_Module(num_Rack, num_Module).Module_DC_Voltage = word(0)
            cBMS_Module(num_Rack, num_Module).Max_Cell_Voltage = word(1)
            cBMS_Module(num_Rack, num_Module).Min_Cell_Voltage = word(2)
            cBMS_Module(num_Rack, num_Module).Averge_Cell_Voltage = word(3)
            cBMS_Module(num_Rack, num_Module).Max_Min_Cell_Voltage_Location = word(4)
            cBMS_Module(num_Rack, num_Module).Average_Module_Temperature = Convert.ToInt16(word(5).ToString("X4"), 16)
            cBMS_Module(num_Rack, num_Module).Max_Module_Temperature = Convert.ToInt16(word(6).ToString("X4"), 16)
            cBMS_Module(num_Rack, num_Module).Min_Module_Temeperature = Convert.ToInt16(word(7).ToString("X4"), 16)
            cBMS_Module(num_Rack, num_Module).Max_Min_Module_Temperature_Location = word(8)
        Else

        End If

    End Sub

    Friend Sub CallException(ByVal id As Integer, ByVal unit As Byte, ByVal func As Byte, ByVal exception As Byte)
        If ((Me.tcpAsyCl Is Nothing) _
                    OrElse (Me.tcpSynCl Is Nothing)) Then
            Return
        End If

        If (exception = excExceptionConnectionLost) Then
            Me.tcpSynCl = Nothing
            Me.tcpAsyCl = Nothing
        End If

        'If (Not (OnException) Is Nothing) Then
        RaiseEvent OnException(id, unit, func, exception)
        'End If

    End Sub


    Friend Shared Function SwapUInt16(ByVal inValue As UInt16) As UInt16
        Return CType((((inValue And 65280) _
                    + 8) _
                    Or ((inValue And 255) _
                    + 8)), UInt16)
    End Function

End Class

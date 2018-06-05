
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
Public Class EPIC2500

    ' Private MBmaster As ModbusTCP.Master = New Master(IPaddr, Port)
    Private data As Byte()

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

    Public Sub ServiceStart(ByVal IPaddr As String, ByVal Port As String)

        Timer_Comm.Enabled = False

        ' 서버를 시작시킨다.
        Try
            connect(IPaddr, Port)
            AddHandler OnResponseData, New ResponseData(AddressOf MBmaster_OnResponseData)
            AddHandler OnException, New ExceptionData(AddressOf MBmaster_OnException)


        Catch [error] As SystemException
            'MessageBox.Show([error].Message)
            Debug.WriteLine([error].Message)
        End Try

        Timer_Comm.Interval = 5000
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
    Private tLastRecv As Date = DateAdd(DateInterval.Day, -1, Now)
    Public Function Connected() As Integer

        Dim tSpan As TimeSpan = Now - tLastRecv
        Dim nReturn As Integer = 0

        If tSpan.TotalSeconds <= 60 Then
            nReturn = 1
        End If

        Return nReturn
    End Function
    Private Sub Timer_Comm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Comm.Tick
        Timer_Comm.Enabled = False

        Dim StartAddress As UShort = 118
        Dim length As UShort = 2

        'Debug.WriteLine("num_Rack : " + num_Rack.ToString() + " num_Module : " + num_Module.ToString())
        Try
            ReadInputRegister(StartAddress, length)
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

        SetEMSBUFFER()
        ' 새로추가한 것들에 대해서 넣어볼까?
        '
    End Sub

    ' BMS 데이터를 EMS Buffer에 넣어주기 위한 함수
    ' 2018-02-12
    Private Sub SetEMSBUFFER()
        '42:
        MODBUS_EMS_BUFFER(42 * 2) = Convert.ToInt16(d사용모드_배터리_충전시최대전류) \ &H100
        MODBUS_EMS_BUFFER(42 * 2 + 1) = Convert.ToInt16(d사용모드_배터리_충전시최대전류) Mod &H100
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
        Dim Unit As Byte = 2

        WriteAsyncData(Me.CreateReadHeader(ID, Unit, StartAddress, Length, fctReadHoldingRegister), func)
    End Sub
    Private Sub ReadInputRegister(ByVal StartAddress As UShort, ByVal Length As UShort)
        Dim ID As UShort = 1
        Dim Unit As Byte = 2

        WriteAsyncData(CreateReadHeader(ID, Unit, StartAddress, Length, fctReadInputRegister), ID)
    End Sub

    Private Sub WriteMultipleRegister(ByVal StartAddress As UShort, ByRef data As Byte())
        Dim ID As UShort = 8
        Dim Unit As Byte = 2

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

        If Me.InvokeRequired Then
            Me.BeginInvoke(New ResponseData(AddressOf MBmaster_OnResponseData), New Object() {ID, unit, func, values})
            Return
        End If

        If ID = &HFF Then
            Return
        End If

        If ID > 0 Then
            tLastRecv = Now
        End If

        Select Case ID
            Case 1
                data = values
                ShowAs()

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
        Dim mysingle As Single() = New Single(0) {}
        If data.Length < 4 Then Return
        mysingle = New Single(data.Length / 4 - 1) {}
        x = 0
        While x < data.Length
            mysingle(x / 4) = BAToSingle(data, x / 4)
            x = x + 4
        End While

    End Sub

    Function BAToSingle(ByVal bytes() As Byte, ByVal index As Integer)
        Dim value As Single = BitConverter.ToSingle(bytes, index)
        BAToSingle = value
    End Function
    Private Sub Display(ByVal word() As UShort)

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

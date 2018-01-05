
Imports System
Imports System.Net
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports ModbusTCP



Public Class BMS클라이언트

    Private MBmaster As Master
    Private data As Byte()

    'Const IPaddr As String = "192.168.0.247"
    Const IPaddr As String = "127.0.0.1"
    Const Port As String = "502"

    Dim writedata As Byte()
    Dim Length As Byte

    Dim heartbit As UShort

    Private btRecvBuffer(1024) As Byte
    Private nRecvBufferLength As Integer = 0

    WithEvents Timer_Comm As New Windows.Forms.Timer




    Public Overloads Sub ServiceStart()

        Timer_Comm.Enabled = False

        ' 서버를 시작시킨다.
        Try
            MBmaster = New Master(IPaddr, Port)
            AddHandler MBmaster.OnResponseData, New ModbusTCP.Master.ResponseData(AddressOf MBmaster_OnResponseData)
            AddHandler MBmaster.OnException, New ModbusTCP.Master.ExceptionData(AddressOf MBmaster_OnException)


        Catch [error] As SystemException
            MessageBox.Show([error].Message)
        End Try

        현재BSC상태 = BSC상태.Connect
        Timer_Comm.Interval = 1000
        Timer_Comm.Enabled = True

    End Sub

    Private Sub Timer_Comm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Comm.Tick
        Timer_Comm.Enabled = False

        'Dim StartAddress As UShort = ReadStartAdr(num_Rack, num_Module)
        'Dim length As UShort = ReadLength(num_Rack, num_Module)
        Dim ID As UShort = 3
        Dim StartAddress As UShort
        Dim length As UShort

        ReDim writedata(12)
        Try
            StartAddress = 40000
            length = 6

            ReadHoldingRegister(ID, StartAddress, length)

            StartAddress = 40032
            length = 2
            ReadHoldingRegister(4, StartAddress, length)
            ' Read Heartbit (읽어온다

            ' 읽어온 Heartbit를 Write 한다
            StartAddress = 44000

            If heartbit = 1 Then
                heartbit = 0
            Else
                heartbit = 1
            End If


            If (현재BSC상태 = BSC상태.Contactor_Close) Or (현재BSC상태 = BSC상태.Contactor_Open1) Or (현재BSC상태 = BSC상태.Contactor_Open2) Then

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

                '44003~6
                writedata(6) = 0
                writedata(7) = 0
                writedata(8) = 0
                writedata(9) = 0
                writedata(10) = 0
                writedata(11) = 0

                WriteMultipleRegister(StartAddress, writedata)
            Else
                ' 44000 Controller HeartBeat
                writedata(0) = heartbit \ &H100
                writedata(1) = heartbit Mod &H100
                WriteMultipleRegister(StartAddress, writedata)
                Debug.WriteLine(현재BSC상태)
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

        Timer_Comm.Enabled = True
    End Sub


    Private Sub ReadHoldingRegister(ByVal ID As UShort, ByVal StartAddress As UShort, ByVal Length As UShort)

        Dim Unit As Byte = 1

        MBmaster.ReadHoldingRegister(ID, Unit, StartAddress, Length)
    End Sub
    Private Sub ReadInputRegister(ByVal StartAddress As UShort, ByVal Length As UShort)
        Dim ID As UShort = 4
        Dim Unit As Byte = 1

        MBmaster.ReadInputRegister(ID, Unit, StartAddress, Length)
    End Sub

    Private Sub WriteMultipleRegister(ByVal StartAddress As UShort, ByRef data As Byte())
        Dim ID As UShort = 8
        Dim Unit As Byte = 1

        MBmaster.WriteMultipleRegister(ID, Unit, StartAddress, data)
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

        If Me.InvokeRequired Then
            Me.BeginInvoke(New Master.ResponseData(AddressOf MBmaster_OnResponseData), New Object() {ID, unit, func, values})
            Return
        End If

        If ID = &HFF Then
            Return
        End If

        Select Case ID
            Case 1
                data = values
                'heartbit = Convert.ToUInt16(values(1))
                ShowAs()
            Case 2

                data = values
                ShowAs()
            Case 3
                data = values
                'heartbit = Convert.ToUInt16(values(1))
                Debug.WriteLine("ID3 is : " + data(1).ToString)
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

    Private Sub MBmaster_OnException(ByVal id As UShort, ByVal unit As Byte, ByVal [function] As Byte, ByVal exception As Byte)
        ' ------------------------------------------------------------------
        'Seperate calling threads
        If Me.InvokeRequired Then
            Me.BeginInvoke(New ModbusTCP.Master.ExceptionData(AddressOf MBmaster_OnException), New Object() {id, unit, [function], exception})
            Return
        End If

        Dim exc As String = "Modbus says error: "
        Select Case exception
            Case Master.excIllegalFunction
                exc += "Illegal function!"
            Case Master.excIllegalDataAdr
                exc += "Illegal data adress!"
            Case Master.excIllegalDataVal
                exc += "Illegal data value!"
            Case Master.excSlaveDeviceFailure
                exc += "Slave device failure!"
            Case Master.excAck
                exc += "Acknoledge!"
            Case Master.excGatePathUnavailable
                exc += "Gateway path unavailbale!"
            Case Master.excExceptionTimeout
                exc += "Slave timed out!"
            Case Master.excExceptionConnectionLost
                exc += "Connection is lost!"
            Case Master.excExceptionNotConnected
                exc += "Not connected!"
        End Select

        MessageBox.Show(exc, "Modbus slave exception")
    End Sub

    Private Sub ShowAs()
        Dim x As Integer

        Dim word As Integer() = New Integer(0) {}

        If data.Length < 2 Then Return
        word = New Integer(data.Length / 2 - 1) {}
        x = 0
        While x < data.Length
            word(x / 2) = data(x) * 256 + data(x + 1)
            x = x + 2
        End While

        ' Display(word)

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
            Case BSC상태.Contactor_Open1

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
        Select 현재BSC상태
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
    Private Sub Display(ByVal word() As Integer)

        If BMS현재통신모드 = BMS통신모드정의.BankInfo Then
            cBMS.Bank_SOC = word(10)
            cBMS.Bank_SOH = word(11)
            cBMS.Bank_DC전압 = word(12)
            cBMS.Bank_DC전류 = Convert.ToInt16(word(13).ToString("X4"), 16)
            cBMS.Bank_충방전_전력_제한값 = word(14)
            cBMS.Bank내_Cell_최고_전압 = word(16)
            cBMS.Bank내_Cell_최소_전압 = word(18)
            cBMS.Bank내_Module_최고_온도 = Convert.ToInt16(word(20).ToString("X4"), 16)
            cBMS.Bank내_Module_최저_온도 = Convert.ToInt16(word(22).ToString("X4"), 16)
            cBMS.Bank_충방전_전력 = Convert.ToInt16(word(24).ToString("X4"), 16)

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
End Class

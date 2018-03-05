Public Class BMS시리얼통신
    Public BMS_MODBUS_ADDRESS As Integer = 0
    Public BMS_MODBUS_COUNT As Integer = 6
    Private data As Byte()
    Private pCRC16 As New Crc16
    Private WithEvents Timer_Comm As New Windows.Forms.Timer
    Private WithEvents DeviceCommPort As New System.IO.Ports.SerialPort

    Public Event DataArrived(ByVal szComPort As String, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)

    Private tLastRecv As Date = DateAdd(DateInterval.Day, -1, Now)

    Public Overloads Sub ServiceStart()

        Timer_Comm.Enabled = False

        If DeviceCommPort.IsOpen = True Then
            DeviceCommPort.Close()
        End If

        DeviceCommPort.PortName = BMS_통신포트
        DeviceCommPort.BaudRate = 19200
        DeviceCommPort.Parity = IO.Ports.Parity.Even
        DeviceCommPort.DataBits = 8
        DeviceCommPort.StopBits = IO.Ports.StopBits.One
        'DeviceCommPort.RtsEnable = True

        Try
            DeviceCommPort.Open()

            Timer_Comm.Interval = BMS_통신주기
            Timer_Comm.Enabled = True

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

    End Sub

    Private btRecvBuffer(1024) As Byte
    Private nRecvBufferLength As Integer = 0

    Private Sub DeviceCommPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles DeviceCommPort.DataReceived

        Dim btData(1024) As Byte
        Dim nLength As Integer = DeviceCommPort.Read(btData, 0, btData.Length)

        'RaiseEvent DataArrived(DeviceCommPort.PortName, "RX", btData, nLength)


        Dim szRecvMsg As String = "RX : "
        For i As Integer = 0 To nLength - 1
            szRecvMsg &= String.Format("{0:X2} ", btData(i))
        Next
        Debug.WriteLine(szRecvMsg)

        If nRecvBufferLength + nLength > btRecvBuffer.Length Then
            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0
        End If

        Try

            For nCnt As Integer = 0 To nLength - 1
                If (nRecvBufferLength = 0 And btData(nCnt) = BMS_통신ID) Or nRecvBufferLength > 0 Then
                    btRecvBuffer(nRecvBufferLength) = btData(nCnt)
                    nRecvBufferLength += 1

                    ' 버퍼가 완성되면
                    If nRecvBufferLength >= 4 Then
                        Dim btRecvCommand As Byte = btRecvBuffer(1)
                        If btRecvCommand = &H4 Then
                            Dim btModbusWriteRegisterResponse As Byte()
                            ReDim btModbusWriteRegisterResponse(nRecvBufferLength - 3)

                            Array.Copy(btRecvBuffer, 1, btModbusWriteRegisterResponse, 0, nRecvBufferLength - 3)
                            Dim nDataCount As Integer = btRecvBuffer(2)

                            If nRecvBufferLength >= nDataCount + 5 Then

                                Dim shCheckSum As UShort = pCRC16.CalcCRC(btRecvBuffer, 0, nDataCount + 3)
                                Dim nCheckSum1 As Byte = shCheckSum Mod &H100
                                Dim nCheckSum2 As Byte = shCheckSum \ &H100

                                If nCheckSum1 = btRecvBuffer(nRecvBufferLength - 2) And nCheckSum2 = btRecvBuffer(nRecvBufferLength - 1) Then

                                    RaiseEvent DataArrived(DeviceCommPort.PortName, "RX", btRecvBuffer, nRecvBufferLength)

                                    tLastRecv = Now

                                    data = New Byte(nDataCount - 1) {}
                                    Dim nAddrESS As Integer = 0
                                    For i As Integer = 0 To nDataCount / 2 - 1
                                        'SetBMSModbusData((BMS_MODBUS_ADDRESS + nAddrESS, btRecvBuffer, 3 + i * 2, 2)
                                        data(2 * i) = btRecvBuffer(3 + i * 2)
                                        data(2 * i + 1) = btRecvBuffer(3 + i * 2 + 1)

                                        nAddrESS += 1
                                    Next
                                    ShowAs()
                                End If
                            End If

                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub ServiceStop()

        If Not DeviceCommPort Is Nothing Then
            If DeviceCommPort.IsOpen Then
                DeviceCommPort.Close()
            End If
        End If

        Timer_Comm.Enabled = False

    End Sub

    Private Sub Timer_Comm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Comm.Tick
        Timer_Comm.Enabled = False

        SendPollingData()

        Timer_Comm.Enabled = True
    End Sub

    Private Sub SendWriteRegister()

        Dim nWriteAddress As Integer = 0
        Dim nWriteData As Integer = 0

        Dim bReturn As Boolean = 제어대기열_가져오기(nWriteAddress, nWriteData)

        If bReturn = False Then Exit Sub


        Try

            Dim btData(32) As Byte
            Dim nData As Integer = 0

            btData(nData) = BMS_통신ID
            nData += 1

            btData(nData) = &H6
            nData += 1

            btData(nData) = nWriteAddress \ &H100
            nData += 1

            btData(nData) = nWriteAddress Mod &H100
            nData += 1

            btData(nData) = nWriteData \ &H100
            nData += 1

            btData(nData) = nWriteData Mod &H100
            nData += 1

            '<----------------------------------------------------------->
            '   Check Sum
            '<----------------------------------------------------------->

            Dim shCheckSum As UShort = pCRC16.CalcCRC(btData, 0, nData)

            btData(nData) = shCheckSum Mod &H100
            nData += 1

            btData(nData) = shCheckSum \ &H100
            nData += 1

            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0
            '<----------------------------------------------------------->
            '   Data Receive
            '<----------------------------------------------------------->
            Try
                RaiseEvent DataArrived(DeviceCommPort.PortName, "TX", btData, nData)
                DeviceCommPort.Write(btData, 0, nData)

                Dim szMsg As String = "TX :"
                For i As Integer = 0 To nData - 1
                    szMsg &= String.Format("{0:X2} ", btData(i))
                Next

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub SendPollingData()

        'BMS_MODBUS_ADDRESS += BMS_MODBUS_COUNT
        'If BMS_MODBUS_ADDRESS > 50 Then
        'BMS_MODBUS_ADDRESS = 0
        'End If
        BMS_MODBUS_ADDRESS = ReadStartAdr(num_Rack, num_Module)
        BMS_MODBUS_COUNT = ReadLength(num_Rack, num_Module)
        Try

            Dim btData(32) As Byte
            Dim nData As Integer = 0

            btData(nData) = BMS_통신ID
            nData += 1

            btData(nData) = &H4
            nData += 1

            btData(nData) = BMS_MODBUS_ADDRESS \ &H100
            nData += 1

            btData(nData) = BMS_MODBUS_ADDRESS Mod &H100
            nData += 1

            btData(nData) = BMS_MODBUS_COUNT \ &H100
            nData += 1

            btData(nData) = BMS_MODBUS_COUNT Mod &H100
            nData += 1


            Dim shCheckSum As UShort = pCRC16.CalcCRC(btData, 0, nData)

            btData(nData) = shCheckSum Mod &H100
            nData += 1

            btData(nData) = shCheckSum \ &H100
            nData += 1


            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0


            Try
                RaiseEvent DataArrived(DeviceCommPort.PortName, "TX", btData, nData)
                DeviceCommPort.Write(btData, 0, nData)

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Function Connected() As Integer

        Dim tSpan As TimeSpan = Now - tLastRecv
        Dim nReturn As Integer = 0

        If tSpan.TotalSeconds <= 30 Then
            nReturn = 1
        End If

        Return nReturn
    End Function


    Private Function ReadStartAdr(ByVal nRack As UShort, ByVal nModule As UShort) As UShort

        Dim nStartAddress As UShort
        If BMS현재통신모드 = BMS통신모드정의.BankInfo Then
            nStartAddress = 0
        ElseIf BMS현재통신모드 = BMS통신모드정의.RackInfo Then
            If nRack = 0 Then
            Else
                nStartAddress = (379 * nRack) - 354
            End If

        ElseIf BMS현재통신모드 = BMS통신모드정의.ModuleInfo Then
            If nRack = 0 Or nModule = 0 Then
            Else
                nStartAddress = (379 * nRack) + (9 * nModule) - 354
            End If

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

    Private Sub Display(ByVal word() As UShort)


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


Public Class PCS통신
    Public PCS_MODBUS_ADDRESS As Integer = 0
    ' 추후 수정 가능함
    Public PCS_MODBUS_COUNT As Integer = 6

    Public Priority_Read As Integer = 5
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

        DeviceCommPort.PortName = PCS_통신포트
        DeviceCommPort.BaudRate = 19200
        DeviceCommPort.Parity = IO.Ports.Parity.Even
        DeviceCommPort.DataBits = 8
        DeviceCommPort.StopBits = IO.Ports.StopBits.One
        'DeviceCommPort.RtsEnable = True

        Try
            DeviceCommPort.Open()

            Timer_Comm.Interval = PCS_통신주기
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
        'Debug.WriteLine(szRecvMsg)

        If nRecvBufferLength + nLength > btRecvBuffer.Length Then
            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0
        End If

        Try

            For nCnt As Integer = 0 To nLength - 1
                If (nRecvBufferLength = 0 And btData(nCnt) = PMS_통신ID) Or nRecvBufferLength > 0 Then
                    btRecvBuffer(nRecvBufferLength) = btData(nCnt)
                    nRecvBufferLength += 1

                    If nRecvBufferLength >= 4 Then
                        Dim btRecvCommand As Byte = btRecvBuffer(1)
                        If btRecvCommand = &H3 Then
                            Dim nDataCount As Integer = btRecvBuffer(2)

                            If nRecvBufferLength >= nDataCount + 5 Then

                                Dim shCheckSum As UShort = pCRC16.CalcCRC(btRecvBuffer, 0, nDataCount + 3)

                                Dim nCheckSum1 As Byte = shCheckSum Mod &H100
                                Dim nCheckSum2 As Byte = shCheckSum \ &H100

                                If nCheckSum1 = btRecvBuffer(nRecvBufferLength - 2) And nCheckSum2 = btRecvBuffer(nRecvBufferLength - 1) Then

                                    If DEBUG_COMM = True Then
                                        RaiseEvent DataArrived(DeviceCommPort.PortName, "RX", btRecvBuffer, nRecvBufferLength)
                                    End If


                                    tLastRecv = Now

                                    Dim nAddrESS As Integer = 0
                                    For i As Integer = 0 To nDataCount / 2 - 1
                                        SetModbusData(PCS_MODBUS_ADDRESS + nAddrESS, btRecvBuffer, 3 + i * 2, 2)
                                        nAddrESS += 1
                                    Next

                                End If
                            End If

                        ElseIf btRecvCommand = &H6 Then
                            If nRecvBufferLength = 8 Then

                                ' 제어응답 - 싱글
                                If DEBUG_COMM = True Then
                                    'Debug.WriteLine("btRecvBuffer : " + btData(1) + btData(2) + btData(3) + btData(4) + btData(5))
                                    'Debug.WriteLine("btRecvBuffer : " + btRecvBuffer(1) + btRecvBuffer(2) + btRecvBuffer(3) + btRecvBuffer(4) + btRecvBuffer(5))
                                End If

                                'Array.Copy(btRecvBuffer, 1, btModbusWriteRegisterResponse, 0, nRecvBufferLength - 3)
                                'nModbusWriteRegisterResponse = nRecvBufferLength - 3
                            End If

                            ElseIf btRecvCommand = &H10 Then
                                If nRecvBufferLength = 8 Then

                                    ' 제어응답 - 멀티

                                    'Array.Copy(btRecvBuffer, 1, btModbusWriteRegisterResponse, 0, nRecvBufferLength - 3)
                                    'nModbusWriteRegisterResponse = nRecvBufferLength - 3
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

        ' 매초 비교를 현재 BMS 데이터를 비교하고, 비교한 값과 달라지는게 있다면 제어대기열에 넣어서 Writing을 한다.
        BMS데이터비교()

        Priority_Read = Priority_Read + 1
        If Priority_Read > 4 Then
            Priority_Read = 1
        End If
        ' 
        If 제어대기열_대기수량() > 0 And Not Priority_Read = 1 Then
            SendWriteRegister()
        Else
            SendPollingData()
        End If
        'SendPollingData()
        Timer_Comm.Enabled = True
    End Sub

    'BMS데이터비교에서 Deadband를 사용하기 위해서 저장하는 시간 값.
    Private tLastSOC As Date
    Private tLastSOH As Date
    Private tLastStatus As Date

    Private Sub BMS데이터비교()

        ' 같다면 이전 상태아무런 동작을 하지 않지만, 다르다면 제어대기열 추가 이후, prev_값을 넣는다


        Dim tSpan As TimeSpan
        Dim Ondelay As Integer = 3

        '' Deadband를 넣어야함.
        '' On-Delay Off-Delay를 넣어야 함.

        If Not cBMS.prev_Bank_SOC = cBMS.Bank_SOC Then
            tSpan = Now - tLastSOC
            If tSpan.TotalSeconds <= Ondelay Then
                제어대기열_추가(PT_SOC, Convert.ToInt16(cBMS.Bank_SOC))
                cBMS.prev_Bank_SOC = cBMS.Bank_SOC
            Else
                ' Waiting until Deadband
            End If
        Else
            tLastSOC = Now
        End If

        If Not cBMS.prev_Bank_SOH = cBMS.Bank_SOH Then
            tSpan = Now - tLastSOH
            If tSpan.TotalSeconds <= Ondelay Then
                제어대기열_추가(PT_SOH, Convert.ToInt16(cBMS.Bank_SOH))
                cBMS.prev_Bank_SOH = cBMS.Bank_SOH
            Else
                ' Waiting until Deadband
            End If
            tLastSOH = Now
        End If

        Dim ushValue As UShort
        BMS경보값비교(cBMS.prev_Over_Current_Discharge_Warning, cBMS.Over_Current_Discharge_Warning, ushValue, 7)
        BMS경보값비교(cBMS.prev_Over_Current_Charge_Warning, cBMS.Over_Current_Charge_Warning, ushValue, 6)
        BMS경보값비교(cBMS.prev_Rack_Over_Voltage_Protection_Warning, cBMS.Rack_Over_Voltage_Protection_Warning, ushValue, 5)
        BMS경보값비교(cBMS.prev_Rack_Under_Voltage_Protection_Warning, cBMS.Rack_Under_Voltage_Protection_Warning, ushValue, 4)
        BMS경보값비교(cBMS.prev_Rack_Voltage_Imbalance_Warning, cBMS.Rack_Voltage_Imbalance_Warning, ushValue, 3)
        BMS경보값비교(cBMS.prev_Rack_Over_Temperature_Warning, cBMS.Rack_Over_Temperature_Warning, ushValue, 2)
        BMS경보값비교(cBMS.prev_Rack_Under_Temperature_Warning, cBMS.Rack_Under_Temperature_Warning, ushValue, 1)
        BMS경보값비교(cBMS.prev_Rack_Temperature_Imbalance_Warning, cBMS.Rack_Temperature_Imbalance_Warning, ushValue, 0)

        If Not ushValue = cBMS.prev_Bank_Status Then
            tSpan = Now - tLastStatus
            If tSpan.TotalSeconds <= Ondelay Then
                제어대기열_추가(PT_STS, ushValue)
                cBMS.prev_Bank_Status = ushValue
            Else
                ' Waiting until Deadband
            End If

        Else
            tLastStatus = Now
        End If

    End Sub

    Private Sub BMS경보값비교(ByRef prev_a As Boolean, ByVal a As Boolean, ByRef ushValue As Integer, ByVal nbit As Integer)
        Dim temp_flag As Integer = 0

        If Not prev_a = a Then
            temp_flag = a
            ushValue = SetBitmask(ushValue, nbit, temp_flag)

            prev_a = a
        End If
    End Sub

    Private Sub SendWriteRegister()

        Dim nWriteAddress As Integer = 0
        Dim nWriteData As Integer = 0

        Dim bReturn As Boolean = 제어대기열_가져오기(nWriteAddress, nWriteData)

        If bReturn = False Then Exit Sub


        Try

            Dim btData(64) As Byte
            Dim nData As Integer = 0

            btData(nData) = PMS_통신ID
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
                If DEBUG_COMM = True Then
                    RaiseEvent DataArrived(DeviceCommPort.PortName, "TX", btData, nData)
                End If
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

    Private Sub SendPollingData()

        PCS_MODBUS_ADDRESS += PCS_MODBUS_COUNT
        If PCS_MODBUS_ADDRESS > 50 Then
            PCS_MODBUS_ADDRESS = 0
        End If

        Try

            Dim btData(64) As Byte
            Dim nData As Integer = 0

            btData(nData) = PMS_통신ID
            nData += 1

            btData(nData) = &H3
            nData += 1

            btData(nData) = PCS_MODBUS_ADDRESS \ &H100
            nData += 1

            btData(nData) = PCS_MODBUS_ADDRESS Mod &H100
            nData += 1

            btData(nData) = PCS_MODBUS_COUNT \ &H100
            nData += 1

            btData(nData) = PCS_MODBUS_COUNT Mod &H100
            nData += 1


            Dim shCheckSum As UShort = pCRC16.CalcCRC(btData, 0, nData)

            btData(nData) = shCheckSum Mod &H100
            nData += 1

            btData(nData) = shCheckSum \ &H100
            nData += 1


            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0


            Try
                If DEBUG_COMM = True Then
                    RaiseEvent DataArrived(DeviceCommPort.PortName, "TX", btData, nData)
                End If
                'RaiseEvent DataArrived(DeviceCommPort.PortName, "TX", btData, nData)
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

        If tSpan.TotalSeconds <= 60 Then
            nReturn = 1
        End If

        Return nReturn
    End Function
End Class

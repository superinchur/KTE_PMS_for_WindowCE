Public Class BMS시리얼통신
    Public BMS_MODBUS_ADDRESS As Integer = 0
    Public BMS_MODBUS_COUNT As Integer = 6

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

                    If nRecvBufferLength >= 4 Then
                        Dim btRecvCommand As Byte = btRecvBuffer(1)
                        If btRecvCommand = &H3 Then
                            Dim nDataCount As Integer = btRecvBuffer(2)

                            If nRecvBufferLength >= nDataCount + 5 Then

                                Dim shCheckSum As UShort = pCRC16.CalcCRC(btRecvBuffer, 0, nDataCount + 3)

                                Dim nCheckSum1 As Byte = shCheckSum Mod &H100
                                Dim nCheckSum2 As Byte = shCheckSum \ &H100

                                If nCheckSum1 = btRecvBuffer(nRecvBufferLength - 2) And nCheckSum2 = btRecvBuffer(nRecvBufferLength - 1) Then

                                    RaiseEvent DataArrived(DeviceCommPort.PortName, "RX", btRecvBuffer, nRecvBufferLength)

                                    tLastRecv = Now

                                    Dim nAddrESS As Integer = 0
                                    For i As Integer = 0 To nDataCount / 2 - 1
                                        'Dim btValue As Byte = btRecvBuffer(3 + i)
                                        'ModbusData(nAddrESS) = btValue

                                        SetModbusData(BMS_MODBUS_ADDRESS + nAddrESS, btRecvBuffer, 3 + i * 2, 2)
                                        nAddrESS += 1
                                    Next

                                End If
                            End If
                        ElseIf btRecvCommand = &H4 Then
                            'Array.Copy(btRecvBuffer, 1, btModbusWriteRegisterResponse, 0, nRecvBufferLength - 3)


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

        If 제어대기열_대기수량() > 0 Then
            SendWriteRegister()
        Else
            SendPollingData()
        End If

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

        BMS_MODBUS_ADDRESS += BMS_MODBUS_COUNT
        If BMS_MODBUS_ADDRESS > 50 Then
            BMS_MODBUS_ADDRESS = 0
        End If

        Try

            Dim btData(32) As Byte
            Dim nData As Integer = 0

            btData(nData) = PMS_통신ID
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
        If nModule = 0 And nRack = 0 Then
            nStartAddress = 0
        ElseIf nModule = 0 And Not nRack = 0 Then
            nStartAddress = (379 * nRack) - 354
        Else
            nStartAddress = (379 * nRack) + (9 * nModule) - 354
        End If

        Return Convert.ToUInt16(nStartAddress)

    End Function

    Private Function ReadLength(ByVal nRack As UShort, ByVal nModule As UShort) As UShort

        Dim nLength As UShort
        If nModule = 0 And nRack = 0 Then
            nLength = 25
        ElseIf nModule = 0 And Not nRack = 0 Then
            nLength = 19
        Else
            nLength = 9
        End If

        Return Convert.ToUInt16(nLength)

    End Function
End Class


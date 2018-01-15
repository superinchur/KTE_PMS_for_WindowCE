Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class BMS통신차일드


    Public BMS_MODBUS_COUNT As Integer = 6
    Public BMS_MODBUS_ADDRESS As Integer = 0

    Private TCPFrameHeaderLength As Integer = 6
    Private TCPFrameHeaderData(TCPFrameHeaderLength) As Byte

    Private _ConnectStatus As Boolean = True
    Private pClientSocket As 비동기통신소켓 = Nothing

    Private WithEvents Timer_Comm As New Windows.Forms.Timer

    Private pCRC16 As New Crc16

    Private szIPAddrESS As String = ""
    Private nSocketPort As Integer = 0

    Private btRecvBuffer(4096) As Byte
    Private nRecvBuffer As Integer = 0

    Public tLastReceive As Date = Now



    Public Event DataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)

    Public Property ConnectStatus() As Boolean
        Get
            Return _ConnectStatus
        End Get
        Set(ByVal value As Boolean)
            _ConnectStatus = value
        End Set
    End Property


    Public Sub New(ByVal pSocket As Socket)

        pClientSocket = New 비동기통신소켓(pSocket)
        AddHandler pClientSocket.DataArrived, AddressOf OnDataArrived

        Timer_Comm.Interval = 1000
        Timer_Comm.Enabled = True
    End Sub

    Public Sub OnDataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        Try
            If nLength > 0 Then
                RaiseEvent DataArrived(szAddr, nPort, szMode, btData, nLength)
            End If
        Catch ex As Exception
            Debug.WriteLine("")
        End Try

        If nLength > 0 And szMode = "RX" Then

            Dim szRecvMsg As String = "BMS RX : "
            For i As Integer = 0 To nLength - 1
                szRecvMsg &= String.Format("{0:X2} ", btData(i))
            Next
            Debug.WriteLine(szRecvMsg)

            'btData는 통신Socket의 버퍼
            ' 받아온 데이터를 btRecvBuffer에 저장
            ' btRecvZBuffer가 원하는 량 만큼 찼을 경우 데이터를 파싱한다.
            Array.Copy(btData, 0, btRecvBuffer, nRecvBuffer, nLength)
            nRecvBuffer += nLength

            If nRecvBuffer > TCPFrameHeaderLength + 3 Then
                tLastReceive = Now

                '<------------------------------------------------
                'The Slave Address 
                '<------------------------------------------------
                Dim btFrameDeviceNo As Byte = btRecvBuffer(TCPFrameHeaderLength + 0)
                '<------------------------------------------------
                'The number of data bytes to follow (1 registers x 2 bytes each = 2 bytes)
                '<------------------------------------------------
                Dim btFrameCommand As Byte = btRecvBuffer(TCPFrameHeaderLength + 1)

                Dim btFrameData(4096) As Byte
                Dim nFrameLength As Integer = 0

                Array.Copy(btRecvBuffer, 0, TCPFrameHeaderData, 0, TCPFrameHeaderLength)

                nFrameLength = nRecvBuffer - TCPFrameHeaderLength
                Array.Copy(btRecvBuffer, TCPFrameHeaderLength, btFrameData, 0, nFrameLength)

                '<----------------------------------------------------------->
                '   Should be Changed
                '<----------------------------------------------------------->

                ' btFrameData가 진짜 데이터 부분
                If btFrameDeviceNo = BMS_통신ID Then

                    If btFrameCommand = &H4 Then
                        ' Read Input Registers

                        If nRecvBuffer >= TCPFrameHeaderLength + 6 Then

                            '<------------------------------------------------
                            'The Function Code 4 (read Analog Input Registers)
                            '<------------------------------------------------

                            '<------------------------------------------------
                            'The contents of register 30009
                            '<------------------------------------------------
                            Request_ReadInputRegister(btFrameData, nFrameLength)
                            '<------------------------------------------------
                            'The CRC (cyclic redundancy check).
                            '<------------------------------------------------

                            ' 데이터를 쪼개 받아야될 가능성이 있음
                            ' 일단 한번에 다 받는걸로 하자
                            ' 받아온 데이터를 파싱한다.

                            'Parsing
                        End If


                    Else
                        Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
                        nRecvBuffer = 0

                    End If
                Else
                    Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
                    nRecvBuffer = 0

                End If


            End If
        End If

    End Sub


    '받아온 데이터 Parsing
    Public Sub Arrange_Data(ByRef btFrameData() As Byte)

        cBMS.Over_Current_Discharge_Warning = MODBUS배열.bytetobit(btFrameData, 6, 7)
        cBMS.Over_Current_Charge_Warning = MODBUS배열.bytetobit(btFrameData, 6, 6)
        cBMS.Rack_Over_Voltage_Protection_Warning = MODBUS배열.bytetobit(btFrameData, 6, 5)
        cBMS.Rack_Under_Voltage_Protection_Warning = MODBUS배열.bytetobit(btFrameData, 6, 4)
        cBMS.Rack_Voltage_Imbalance_Warning = MODBUS배열.bytetobit(btFrameData, 6, 3)
        cBMS.Rack_Over_Temperature_Warning = MODBUS배열.bytetobit(btFrameData, 6, 2)
        cBMS.Rack_Under_Temperature_Warning = MODBUS배열.bytetobit(btFrameData, 6, 1)
        cBMS.Rack_Temperature_Imbalance_Warning = MODBUS배열.bytetobit(btFrameData, 6, 0)

        cBMS.Tray_Rack_Communication_Fault = MODBUS배열.bytetobit(btFrameData, 7, 12)
        cBMS.Fuse_positive_Fault_Status = MODBUS배열.bytetobit(btFrameData, 7, 11)
        cBMS.Fuse_negative_Fault_Status = MODBUS배열.bytetobit(btFrameData, 7, 10)
        cBMS.Discharge_Relay_negative_Fault_Status = MODBUS배열.bytetobit(btFrameData, 7, 9)
        cBMS.Charge_Relay_positive_Fault_Status = MODBUS배열.bytetobit(btFrameData, 7, 8)
        cBMS.Over_Current_Discharge_Fault = MODBUS배열.bytetobit(btFrameData, 7, 7)
        cBMS.Over_Current_Charge_Fault = MODBUS배열.bytetobit(btFrameData, 7, 6)
        cBMS.Rack_Over_Voltage_Protection_Fault = MODBUS배열.bytetobit(btFrameData, 7, 5)
        cBMS.Rack_Under_Voltage_Protection_Fault = MODBUS배열.bytetobit(btFrameData, 7, 4)
        cBMS.Rack_Voltage_Imbalance_Fault = MODBUS배열.bytetobit(btFrameData, 7, 3)
        cBMS.Rack_Over_Temperature_Fault = MODBUS배열.bytetobit(btFrameData, 7, 2)
        cBMS.Rack_Under_Temperature_Fault = MODBUS배열.bytetobit(btFrameData, 7, 1)
        cBMS.Rack_Temperature_Imbalance_Fault = MODBUS배열.bytetobit(btFrameData, 7, 0)

        cBMS.Rack2_to_Master_BMS_Communication_Status = MODBUS배열.bytetobit(btFrameData, 8, 1)
        cBMS.Rack1_to_Master_BMS_Communication_Status = MODBUS배열.bytetobit(btFrameData, 8, 0)

        cBMS.Rack_to_Master_BMS_Communication_Status = MODBUS배열.bytetobit(btFrameData, 9, 5)
        cBMS.Bank_Warning = MODBUS배열.bytetobit(btFrameData, 9, 4)
        cBMS.Bank_Fault = MODBUS배열.bytetobit(btFrameData, 9, 3)
        cBMS.Bank_Charge_status1 = MODBUS배열.bytetobit(btFrameData, 9, 2)
        cBMS.Bank_Charge_status0 = MODBUS배열.bytetobit(btFrameData, 9, 1)
        cBMS.Bank_RUN = MODBUS배열.bytetobit(btFrameData, 9, 0)

        cBMS.Bank_SOC = MODBUS배열.bytetoWord(btFrameData, 10) * 0.1
        cBMS.Bank_SOH = MODBUS배열.bytetoWord(btFrameData, 11) * 0.1
        cBMS.Bank_DC전압 = MODBUS배열.bytetoWord(btFrameData, 12) * 0.1
        cBMS.Bank_DC전류 = MODBUS배열.bytetoWord(btFrameData, 13) * 0.1
        cBMS.Bank_충방전_전력_제한값 = MODBUS배열.bytetoWord(btFrameData, 14) * 0.1
        cBMS.Bank내_Cell_최고_전압 = MODBUS배열.bytetoWord(btFrameData, 16) * 0.001
        cBMS.Bank내_Cell_최소_전압 = MODBUS배열.bytetoWord(btFrameData, 18) * 0.001
        cBMS.Bank내_Module_최고_온도 = MODBUS배열.bytetoWord(btFrameData, 20) * 0.1
        cBMS.Bank내_Module_최저_온도 = MODBUS배열.bytetoWord(btFrameData, 22) * 0.1
        cBMS.Bank_충방전_전력 = MODBUS배열.bytetoWord(btFrameData, 11) * 0.1 * 0.1

        Dim rack_offset
        For i = 1 To 5

            rack_offset = 354 * i - 329

            cBMS_Rack(i).Current_sensor_Charge = MODBUS배열.bytetobit(btFrameData, rack_offset + 0, 4) '25 - 4
            cBMS_Rack(i).Current_sensor_Discharge = MODBUS배열.bytetobit(btFrameData, rack_offset + 0, 3)  '25 - 3
            cBMS_Rack(i).Cell_balance_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 0, 2)       '25 - 2
            cBMS_Rack(i).Charge_Relay_positive_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 0, 1) ' 25 - 1
            cBMS_Rack(i).Discharge_Relay_negative_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 0, 0) ' 25 - 0

            cBMS_Rack(i).Over_Current_Discharge_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 7) ' 26 - 7
            cBMS_Rack(i).Over_Current_Charge_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 6) ' 26 - 6
            cBMS_Rack(i).Rack_Over_Voltage_Protection_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 5) ' 26 - 5
            cBMS_Rack(i).Rack_Under_Voltage_Protection_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 4) ' 26 - 4
            cBMS_Rack(i).Rack_Voltage_Imbalance_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 3) ' 26 - 3
            cBMS_Rack(i).Rack_Over_Temperature_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 2) ' 26 - 2
            cBMS_Rack(i).Rack_Under_Temperature_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 1) ' 26 - 1
            cBMS_Rack(i).Rack_Temperature_Imbalance_Warning = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 0) ' 26 - 0

            cBMS_Rack(i).TrayRack_Communication_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 12) ' 27 - 12
            cBMS_Rack(i).Fuse_positive_Fault_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 11) ' 27 - 11
            cBMS_Rack(i).Fuse_negative_Fault_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 10) ' 27 - 10
            cBMS_Rack(i).Discharge_Relay_negative_Fault_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 9) ' 27 - 9
            cBMS_Rack(i).Charge_Relay_positive_Fault_Status = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 8) ' 27 - 8
            cBMS_Rack(i).Over_Current_Discharge_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 7) ' 27 - 7
            cBMS_Rack(i).Over_Current_Charge_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 6) ' 27 - 6
            cBMS_Rack(i).Rack_Over_Voltage_Protection_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 5) ' 27 - 5
            cBMS_Rack(i).Rack_Under_Voltage_Protection_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 4) ' 27 - 4
            cBMS_Rack(i).Rack_Voltage_Imbalance_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 3) ' 27 - 3
            cBMS_Rack(i).Rack_Over_Temperature_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 2) ' 27 - 2
            cBMS_Rack(i).Rack_Under_Temperature_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 1) ' 27 - 1
            cBMS_Rack(i).Rack_Temperature_Imbalance_Fault = MODBUS배열.bytetobit(btFrameData, rack_offset + 1, 0) ' 27 - 0

            cBMS_Rack(i).Rack_SOC = MODBUS배열.bytetoWord(btFrameData, rack_offset + 2) * 0.1 ' 28 - 0.1 %
            cBMS_Rack(i).Rack_SOH = MODBUS배열.bytetoWord(btFrameData, rack_offset + 3) * 0.1 ' 29 - 0.1 %
            cBMS_Rack(i).Rack_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 4) * 0.1 ' 30 - 0.1 %
            cBMS_Rack(i).Rack_Current = MODBUS배열.bytetoWord(btFrameData, rack_offset + 5) * 0.1 ' 31 - 0.1 A
            cBMS_Rack(i).Max_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 6) * 1 ' 32 - 1 mv
            cBMS_Rack(i).Max_Cell_Voltage_Position = MODBUS배열.bytetoWord(btFrameData, rack_offset + 7) * 1 ' 33 - 1
            cBMS_Rack(i).Min_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 8) * 1 ' 34 - 1 mv
            cBMS_Rack(i).Min_Cell_Voltage_Position = MODBUS배열.bytetoWord(btFrameData, rack_offset + 9) * 1 ' 35 - 1
            cBMS_Rack(i).Cell_Voltage_Gap = MODBUS배열.bytetoWord(btFrameData, rack_offset + 10) * 1 ' 36 - 1 mv
            cBMS_Rack(i).Rack_Average_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 11) * 1 ' 37 - 1 mv
            cBMS_Rack(i).Max_Cell_Temperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 12) * 0.1 ' 38 - 0.1 C
            cBMS_Rack(i).Max_Cell_Temperature_Position = MODBUS배열.bytetoWord(btFrameData, rack_offset + 13) * 1 ' 39 - 1
            cBMS_Rack(i).Min_Cell_Temperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 14) * 0.1 ' 40 - 0.1 C
            cBMS_Rack(i).Min_Cell_Temperature_Position = MODBUS배열.bytetoWord(btFrameData, rack_offset + 15) * 1 ' 41 - 1
            cBMS_Rack(i).Cell_Temperature_Gap = MODBUS배열.bytetoWord(btFrameData, rack_offset + 16) * 1 ' 42 - 1
            cBMS_Rack(i).Rack_Average_Module_Temperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 17) * 1 ' 43 - 1

            Dim module_offset
            For j = 1 To 17
                module_offset = (j - 1) * 9
                cBMS_Module(i, j).Module_DC_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + module_offset + 18) ' 44 - 0
                cBMS_Module(i, j).Max_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 19) ' 45 - 0
                cBMS_Module(i, j).Min_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 20) ' 46 - 0
                cBMS_Module(i, j).Averge_Cell_Voltage = MODBUS배열.bytetoWord(btFrameData, rack_offset + 21) ' 47 - 0
                cBMS_Module(i, j).Max_Min_Cell_Voltage_Location = MODBUS배열.bytetoWord(btFrameData, rack_offset + 22) ' 48 - 0
                cBMS_Module(i, j).Average_Module_Temperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 23) ' 49 - 0
                cBMS_Module(i, j).Max_Module_Temperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 24) ' 50 - 0
                cBMS_Module(i, j).Min_Module_Temeperature = MODBUS배열.bytetoWord(btFrameData, rack_offset + 25) ' 51 - 0
                cBMS_Module(i, j).Max_Min_Module_Temperature_Location = MODBUS배열.bytetoWord(btFrameData, rack_offset + 26) ' 52 - 0
            Next
        Next

    End Sub

    Public Overloads Sub ServiceStop()

        _ConnectStatus = False

        Timer_Comm.Enabled = False

        If Not pClientSocket Is Nothing Then

            Try
                pClientSocket.sckDisconnect()

                RemoveHandler pClientSocket.DataArrived, AddressOf OnDataArrived

                pClientSocket.Close()

                pClientSocket = Nothing

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try
        End If

    End Sub

    Private nRecvBufferLength As Integer = 0

    Private Sub Request_ReadInputRegister(ByVal btRecv() As Byte, ByVal nRecv As Integer)

        'BMS_MODBUS_ADDRESS += PCS_MODBUS_COUNT
        'If PCS_MODBUS_ADDRESS > 50 Then
        '        PCS_MODBUS_ADDRESS = 0
        'End If

        Try
            Dim btData(32) As Byte
            Dim nData As Integer = 0
            '<------------------------------------------------
            'The Slave Address
            '<------------------------------------------------
            btData(nData) = BMS_통신ID
            nData += 1

            '<------------------------------------------------
            'The Function Code 4 (read Analog Input Registers)
            '<------------------------------------------------
            btData(nData) = &H3
            nData += 1

            ' BMS_MODBUS_COUNT를 설정해야함
            ' 현재 방안을 고려중임. 쪼개서 할껀데. 어느정도 쪼개서 해야하는지 감이 안옴.
            ' 만약 쪼개는걸 가정하면.
            ' 1안. 0~24 25~43
            ' 2안, 0~196 , 404~575, 783~954
            ' 3안, 0~954
            '<------------------------------------------------
            ' The Data Address of the first register requested.
            '<------------------------------------------------
            btData(nData) = BMS_MODBUS_ADDRESS \ &H100
            nData += 1

            btData(nData) = BMS_MODBUS_ADDRESS Mod &H100
            nData += 1

            '<------------------------------------------------
            ' The total number of registers requested.  
            '<------------------------------------------------
            btData(nData) = BMS_MODBUS_COUNT \ &H100
            nData += 1

            btData(nData) = BMS_MODBUS_COUNT Mod &H100
            nData += 1

            '<------------------------------------------------
            ' The CRC (cyclic redundancy check) for error checking.
            '<------------------------------------------------
            Dim shCheckSum As UShort = pCRC16.CalcCRC(btData, 0, nData)

            btData(nData) = shCheckSum Mod &H100
            nData += 1

            btData(nData) = shCheckSum \ &H100
            nData += 1


            Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
            nRecvBufferLength = 0

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub WriteDataFrame(ByVal btData() As Byte, ByVal nData As Integer)
        Dim btSendData(1024) As Byte
        Dim nSendData As Integer = 0

        Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)

        nRecvBuffer = 0

        If TCPFrameHeaderLength > 0 Then
            Array.Copy(TCPFrameHeaderData, 0, btSendData, 0, TCPFrameHeaderLength)

            nSendData += TCPFrameHeaderLength

            btSendData(nSendData - 2) = nData \ &H100
            btSendData(nSendData - 1) = nData Mod &H100
        End If

        Array.Copy(btData, 0, btSendData, nSendData, nData)
        nSendData += nData

        pClientSocket.sckSend(btSendData, nSendData)



        'Dim szRecvMsg As String = "EMS TX : "
        'For i As Integer = 0 To nSendData - 1
        '    szRecvMsg &= String.Format("{0:X2} ", btSendData(i))
        'Next
        'Debug.WriteLine(szRecvMsg)

    End Sub
    

End Class

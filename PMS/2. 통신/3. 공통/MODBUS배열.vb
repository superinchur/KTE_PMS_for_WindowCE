Module MODBUS배열

    Public EMS_MODBUS_ADDRESS As Integer = 0



    Public MODBUS_EMS_BUFFER(1024) As Byte
    Public MODBUS_BMS_BUFFER(1024) As Byte

    Private btDataMap(10240) As Byte

    Public Property ModbusData(ByVal nAddress As Integer) As Byte
        Get
            Return btDataMap(nAddress)
        End Get
        Set(ByVal value As Byte)
            btDataMap(nAddress) = value
        End Set
    End Property

    Private htModbusData As New Hashtable

    Public Function GetModbusData_Ushort(ByVal nAddress As Integer) As UShort

        Dim ushReturn As UShort = 0

        Dim btData() As Byte = htModbusData(nAddress)

        If Not btData Is Nothing Then
            If btData.Length = 2 Then
                ushReturn = btData(0) * &H100 + btData(1)
            End If
        End If

        Return ushReturn
    End Function

    Public Sub SetModbusData(ByVal nAddress As Integer, ByVal btData() As Byte, ByVal nOffset As Integer, Optional ByVal nSize As Integer = 2)

        Dim btTempData(1) As Byte
        Array.Copy(btData, nOffset, btTempData, 0, nSize)
        htModbusData(nAddress) = btTempData


        Dim nEMSAddress As Integer = nAddress
        Dim bUsedAddress As Boolean = True

        If PMS_통신ID = 1 Then
            Select Case nEMSAddress
                Case 30 ' BAT 전압
                    nEMSAddress = 51
                Case 29  ' BAT 전류
                    nEMSAddress = 52
                Case 28 ' BAT POWER
                    nEMSAddress = 53
                Case 5 ' INV U 상전압
                    nEMSAddress = 57
                Case 6 ' INV V 상전압
                    nEMSAddress = 58
                Case 7 ' INV W 상전압
                    nEMSAddress = 59
                Case 8 ' INV U 상전류
                    nEMSAddress = 60
                Case 9 ' INV V 상전류
                    nEMSAddress = 61
                Case 10 ' INV W 상전류
                    nEMSAddress = 62
                Case 4 ' 인버터전력
                    nEMSAddress = 63
                Case 11 ' GRID 역률D
                    nEMSAddress = 65
                Case 20 ' GRID 주파수
                    nEMSAddress = 66
                Case 35 ' INV STATUS
                    nEMSAddress = 77
                Case 36 ' GRID STATUS
                    nEMSAddress = 78
                Case 37 ' 전장 STATUS
                    nEMSAddress = 79
                Case 38 ' MODE STATUS
                    nEMSAddress = 80
                Case Else
                    bUsedAddress = False
            End Select

            'nEMSAddress += 1
        Else
            Select Case nEMSAddress
                Case 30 ' BAT 전압
                    nEMSAddress = 54
                Case 29  ' BAT 전류
                    nEMSAddress = 55
                Case 28 ' BAT POWER
                    nEMSAddress = 56
                Case 5 ' INV U 상전압
                    nEMSAddress = 67
                Case 6 ' INV V 상전압
                    nEMSAddress = 68
                Case 7 ' INV W 상전압
                    nEMSAddress = 69
                Case 8 ' INV U 상전류
                    nEMSAddress = 70
                Case 9 ' INV V 상전류
                    nEMSAddress = 71
                Case 10 ' INV W 상전류
                    nEMSAddress = 72
                Case 4 ' 인버터전력
                    nEMSAddress = 73
                Case 11 ' GRID 역률D
                    nEMSAddress = 75
                Case 20 ' GRID 주파수
                    nEMSAddress = 76
                Case 35 ' INV STATUS
                    nEMSAddress = 83
                Case 36 ' GRID STATUS
                    nEMSAddress = 84
                Case 37 ' 전장 STATUS
                    nEMSAddress = 85
                Case 38 ' MODE STATUS
                    nEMSAddress = 86
                Case Else
                    bUsedAddress = False
            End Select
        End If

        If bUsedAddress = True And (nEMSAddress <> 63 And nEMSAddress <> 64) And (nEMSAddress <> 73 And nEMSAddress <> 74) Then
            MODBUS_EMS_BUFFER(nEMSAddress * 2) = btTempData(0)
            MODBUS_EMS_BUFFER(nEMSAddress * 2 + 1) = btTempData(1)
        End If

        If nAddress = 4 Or nAddress = 11 Then

            Dim ushINVPower As UShort = GetModbusData_Ushort(PT_Inv_Power)
            Dim ushGridPF As UShort = GetModbusData_Ushort(PT_Grid_PF)
            Dim dINVPower As Double = ushINVPower * 0.1
            Dim nGridPF As Double = ushGridPF * 0.01


            Dim dPowerActive As Double = dINVPower * nGridPF * 10
            Dim ushPowerActive As UShort = CUShort(dPowerActive)

            If PMS_통신ID = 1 Then nEMSAddress = 63 Else nEMSAddress = 73
            MODBUS_EMS_BUFFER(nEMSAddress * 2) = ushPowerActive \ &H100
            MODBUS_EMS_BUFFER(nEMSAddress * 2 + 1) = ushPowerActive Mod &H100



            Dim dPowerReactive As Double = dINVPower * (1 - nGridPF) * 10
            Dim ushPowerReactive As UShort = CUShort(dPowerReactive)

            If PMS_통신ID = 1 Then nEMSAddress = 64 Else nEMSAddress = 74
            MODBUS_EMS_BUFFER(nEMSAddress * 2) = ushPowerReactive \ &H100
            MODBUS_EMS_BUFFER(nEMSAddress * 2 + 1) = ushPowerReactive Mod &H100

        End If

    End Sub

    'Public btModbusWriteRegister(1024) As Byte
    'Public nModbusWriteRegister As Integer

    'Public btModbusWriteRegisterResponse(1024) As Byte
    'Public nModbusWriteRegisterResponse As Integer


    Public Function bytetoWord(ByRef btdata() As Byte, ByVal nAddress As Integer) As UShort

        Dim ushReturn As UShort = 0

        ushReturn = btdata(nAddress * 2) * &H100 + btdata(nAddress * 2 + 1)


        Return ushReturn
    End Function


    Public Function bytetobit(ByRef btdata() As Byte, ByVal nAddress As Integer, ByVal position As Integer) As UShort

        Dim ushReturn As UShort = 0

        ushReturn = btdata(nAddress * 2) * &H100 + btdata(nAddress * 2 + 1)

        Return ushReturn >> position And 1

    End Function
End Module

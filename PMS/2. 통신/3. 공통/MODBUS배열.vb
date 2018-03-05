Module MODBUS배열

    Public EMS_MODBUS_ADDRESS As Integer = 0
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












































































ddress) = btTempData

        If nAddress = 4 Then

            Dim ushGridPF As UShort = GetModbusData_Ushort(PT_Grid_PF)
            Dim nGridPF As Double = ushGridPF * 0.01


            Dim ushINVPower As UShort = GetModbusData_Ushort(PT_Inv_Power)
            Dim dINVPower As Double = ushINVPower * 0.1
            Dim dPowerActive As Double = dINVPower * nGridPF * 10
            Dim ushPowerActive As UShort = CUShort(dPowerActive)

            MODBUS_EMS_BUFFER(nAddress * 2) = ushPowerActive \ &H100
            MODBUS_EMS_BUFFER(nAddress * 2 + 1) = ushPowerActive Mod &H100

            Dim dPowerReactive As Double = dINVPower * (1 - nGridPF) * 10
            Dim ushPowerReactive As UShort = CUShort(dPowerReactive)

            MODBUS_EMS_BUFFER(nAddress * 2) = ushPowerReactive \ &H100
            MODBUS_EMS_BUFFER(nAddress * 2 + 1) = ushPowerReactive Mod &H100
        Else
            MODBUS_EMS_BUFFER(2 * nAddress) = btTempData(0)
            MODBUS_EMS_BUFFER(2 * nAddress + 1) = btTempData(1)
        End If

    End Sub


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

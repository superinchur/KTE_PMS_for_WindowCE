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
        If nAddress < 128 Then
            ' 받아온 데이터를 PCS 버퍼에다가 저장
            htModbusData(nAddress) = btTempData

            ' 받아온 데이터를 EMS 버퍼에다가 저장
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

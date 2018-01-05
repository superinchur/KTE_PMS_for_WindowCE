Module 모듈_고장함수

    Public FAULT_CODE(,) As String = {{"35_0", "Battery Fuse 손상"}, {"35_1", "reserved"}, {"35_2", "DC Link Over-Current"}, {"35_3", "DC Link Over-Voltage"}, _
                        {"35_4", "INV Over-Currnet"}, {"35_5", "INV Over-Voltage"}, {"35_6", "상전류 불평형"}, {"35_7", "INV Stack Over-temp"}, _
                        {"35_8", "CON Stack Over-temp"}, {"35_9", "함체 내부 Over-temp"}, {"35_10", "Transfomer Over-temp"}, {"35_11", "Reator Over-temp"}, _
                        {"35_12", "INV_STACK_Fault"}, {"35_13", "Over_LOAD"}, {"35_14", "reserved"}, {"35_15", "reserved"}, _
                        {"36_0", "정전"}, {"36_1", "Grid Over-Voltage"}, {"36_2", "Grid Under-Voltage"}, {"36_3", "Over-Frequency"}, {"36_4", "Under-Frequency"}, _
                        {"36_5", "reserevd"}, {"36_6", "누설 전류"}, {"36_7", "reserved"}, {"36_8", "reserved"}, {"36_9", "reserved"}, {"36_10", "reserved"}, _
                        {"36_11", "reserved"}, {"36_12", "reserved"}, {"36_13", "reserved"}, {"36_14", "reserved"}, {"36_15", "reserved"}, _
                        {"37_0", "EMO"}, {"37_1", "Door A open"}, {"37_2", "Door B open"}, {"37_3", "Grid SPD 교체 필요"}, {"37_4", "Load SPD 교체 필요"}, _
                        {"37_5", "Grid CB open"}, {"37_6", "INV CB open"}, {"37_7", "INV MC open"}, {"37_8", "BAT CB open"}, {"37_9", "PV S/W open"}, _
                        {"37_10", "reserved"}, {"37_11", "reserved"}, {"37_12", "reserved"}, {"37_13", "reserved"}, {"37_14", "reserved"}, {"37_15", "reserved"}}


    Public FAULT_STATUS(255, 16, 2) As String

    Public Function GetFaultText(ByVal nFileNo As Integer, ByVal nBit As Integer) As String
        Dim szReturn As String = ""

        For i As Integer = 0 To FAULT_CODE.GetLength(0) - 1

            Dim szFileNo As String = FAULT_CODE(i, 0)

            If szFileNo = String.Format("{0}_{1}", nFileNo, nBit) Then
                szReturn = FAULT_CODE(i, 1)
                Exit For
            End If

        Next

        Return szReturn
    End Function

    Public htCurrentFault As New Hashtable

End Module

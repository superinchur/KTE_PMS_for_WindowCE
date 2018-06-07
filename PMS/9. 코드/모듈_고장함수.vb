Module 모듈_고장함수

    Public FAULT_CODE(,) As String = {{"46_0", "Black out"}, {"46_1", "Over frequency"}, {"46_2", "Under frequency"}, {"46_3", "Over Voltage"}, _
                        {"46_4", "Under Voltage"}, {"46_5", "Reserved"}, {"46_6", "Reserved"}, {"46_7", "Reserved"}, _
                        {"46_8", "Reserved"}, {"46_9", "Reserved"}, {"46_10", "Reserved"}, {"46_11", "Reserved"}, _
                        {"46_12", "Reserved"}, {"46_13", "Reserved"}, {"46_13", "Reserved"}, {"46_14", "Reserved"}, {"46_15", "Reserved"}, _
                        {"47_0", "INV_OVR"}, {"47_1", "INV_OCR"}, {"47_2", "GRID_OCR"}, {"47_3", "DC_OCR"}, {"47_4", "DC_UVR"}, {"47_5", "DC_OCR"}, _
                        {"47_6", "OT"}, {"47_7", "Door_Open_Fault"}, {"47_8", "PCS Comm Fault"}, {"47_9", "HW Fault"}}

    Public Samsung_BMS_FAULT_CODE(,) As String = {{"14_15", "Reserved"}, _
            {"14_14", "Reserved"}, _
            {"14_13", "Reserved"}, _
            {"14_12", "Reserved"}, _
            {"14_11", "Reserved"}, _
            {"14_10", "Reserved"}, _
            {"14_9", "Reserved"}, _
            {"14_8", "Reserved"}, _
            {"14_7", "Reserved"}, _
            {"14_6", "Reserved"}, _
            {"14_5", "Reserved"}, _
            {"14_4", "Reserved"}, _
            {"14_3", "Reserved"}, _
            {"14_2", "Reserved"}, _
            {"14_1", "Reserved"}, _
            {"14_0", "Additional Protection Fail"}, _
            {"15_15", "Cell dchg operation limit"}, _
            {"15_14", "Cell chg operation limit"}, _
            {"15_13", "Module pcb ot"}, _
            {"15_12", "Module pcb ut"}, _
            {"15_11", "Dcsw3_fail"}, _
            {"15_10", "Dcsw3_sensing_fail"}, _
            {"15_9", "Dcsw2_sensing_fail"}, _
            {"15_8", "Dcsw1_sensing_fail"}, _
            {"15_7", "Reserved"}, _
            {"15_6", "Reserved"}, _
            {"15_5", "Reserved"}, _
            {"15_4", "Reserved"}, _
            {"15_3", "Reserved"}, _
            {"15_2", "Reserved"}, _
            {"15_1", "Reserved"}, _
            {"15_0", "Reserved"}, _
            {"16_15", "Reserved"}, _
            {"16_14", "Reserved"}, _
            {"16_13", "Reserved"}, _
            {"16_12", "Reserved"}, _
            {"16_11", "Reserved"}, _
            {"16_10", "Reserved"}, _
            {"16_9", "Reserved"}, _
            {"16_8", "Reserved"}, _
            {"16_7", "Reserved"}, _
            {"16_6", "Reserved"}, _
            {"16_5", "Reserved"}, _
            {"16_4", "Reserved"}, _
            {"16_3", "Reserved"}, _
            {"16_2", "Reserved"}, _
            {"16_1", "Rack string I-imb"}, _
            {"16_0", "Rack string V-imb"}, _
            {"17_15", "Permanent uv"}, _
            {"17_14", "Rack fuse fail"}, _
            {"17_13", "Rack I sensor fail"}, _
            {"17_12", "Rack V sensing diff"}, _
            {"17_11", "Rack OV"}, _
            {"17_10", "Rack UV"}, _
            {"17_9", "Rack DchqOC"}, _
            {"17_8", "Rack ChgOC"}, _
            {"17_7", "R-S comm fail"}, _
            {"17_6", "R-M comm fail"}, _
            {"17_5", "Module T-imb"}, _
            {"17_4", "Module V-imb"}, _
            {"17_3", "Module OV"}, _
            {"17_2", "Module UV"}, _
            {"17_1", "Module OT"}, _
            {"17_0", "Module UT"}, _
            {"18_15", "Reserved"}, _
            {"18_14", "Reserved"}, _
            {"18_13", "Reserved"}, _
            {"18_12", "Reserved"}, _
            {"18_11", "Reserved"}, _
            {"18_10", "Reserved"}, _
            {"18_9", "Reserved"}, _
            {"18_8", "Reserved"}, _
            {"18_7", "Reserved"}, _
            {"18_6", "Reserved"}, _
            {"18_5", "Reserved"}, _
            {"18_4", "Reserved"}, _
            {"18_3", "Reserved"}, _
            {"18_2", "Reserved"}, _
            {"18_1", "Reserved"}, _
            {"18_0", "Additional Protection Fail"}, _
            {"19_15", "Cell dchg operation limit"}, _
            {"19_14", "Cell chg operation limit"}, _
            {"19_13", "Module pcb ot"}, _
            {"19_12", "Module pcb ut"}, _
            {"19_11", "Dcsw3_fail"}, _
            {"19_10", "Dcsw3_sensing_fail"}, _
            {"19_9", "Dcsw2_sensing_fail"}, _
            {"19_8", "Dcsw1_sensing_fail"}, _
            {"19_7", "Reserved"}, _
            {"19_6", "Reserved"}, _
            {"19_5", "Reserved"}, _
            {"19_4", "Reserved"}, _
            {"19_3", "Reserved"}, _
            {"19_2", "Reserved"}, _
            {"19_1", "Reserved"}, _
            {"19_0", "Reserved"}, _
            {"20_15", "Reserved"}, _
            {"20_14", "Reserved"}, _
            {"20_13", "Reserved"}, _
            {"20_12", "Reserved"}, _
            {"20_11", "Reserved"}, _
            {"20_10", "Reserved"}, _
            {"20_9", "Reserved"}, _
            {"20_8", "Reserved"}, _
            {"20_7", "Reserved"}, _
            {"20_6", "Reserved"}, _
            {"20_5", "Reserved"}, _
            {"20_4", "Reserved"}, _
            {"20_3", "Reserved"}, _
            {"20_2", "Reserved"}, _
            {"20_1", "Rack string I-imb"}, _
            {"20_0", "Rack string V-imb"}, _
            {"21_15", "Permanent uv"}, _
            {"21_14", "Rack fuse fail"}, _
            {"21_13", "Rack I sensor fail"}, _
            {"21_12", "Rack V sensing diff"}, _
            {"21_11", "Rack OV"}, _
            {"21_10", "Rack UV"}, _
            {"21_9", "Rack DchqOC"}, _
            {"21_8", "Rack ChgOC"}, _
            {"21_7", "R-S comm fail"}, _
            {"21_6", "R-M comm fail"}, _
            {"21_5", "Module T-imb"}, _
            {"21_4", "Module V-imb"}, _
            {"21_3", "Module OV"}, _
            {"21_2", "Module UV"}, _
            {"21_1", "Module OT"}, _
            {"21_0", "Module UT"}}

    Public FAULT_STATUS(255, 16, 2) As String

    Public BMS_FAULT_STATUS(255, 16, 2) As String

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

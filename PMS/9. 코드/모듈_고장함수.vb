﻿Module 모듈_고장함수

    Public FAULT_CODE(,) As String = {{"35_0", "Battery Fuse 손상"}, {"35_1", "reserved"}, {"35_2", "DC Link Over-Current"}, {"35_3", "DC Link Over-Voltage"}, _
                        {"35_4", "INV Over-Currnet"}, {"35_5", "INV Over-Voltage"}, {"35_6", "상전류 불평형"}, {"35_7", "INV Stack Over-temp"}, _
                        {"35_8", "CON Stack Over-temp"}, {"35_9", "함체 내부 Over-temp"}, {"35_10", "Transfomer Over-temp"}, {"35_11", "Reator Over-temp"}, _
                        {"35_12", "INV_STACK_Fault"}, {"35_13", "Over_LOAD"}, {"35_14", "reserved"}, {"35_15", "reserved"}, _
                        {"36_0", "정전"}, {"36_1", "Grid Over-Voltage"}, {"36_2", "Grid Under-Voltage"}, {"36_3", "Over-Frequency"}, {"36_4", "Under-Frequency"}, _
                        {"36_5", "reserevd"}, {"36_6", "누설 전류"}, {"36_7", "reserved"}, {"36_8", "reserved"}, {"36_9", "reserved"}, {"36_10", "reserved"}, _
                        {"36_11", "reserved"}, {"36_12", "reserved"}, {"36_13", "reserved"}, {"36_14", "reserved"}, {"36_15", "reserved"}, _
                        {"37_0", "EMO"}, {"37_1", "Door A open"}, {"37_2", "Door B open"}, {"37_3", "Grid SPD 교체 필요"}, {"37_4", "Load SPD 교체 필요"}, _
                        {"37_5", "Grid CB open"}, {"37_6", "INV CB open"}, {"37_7", "INV MC open"}, {"37_8", "BAT CB open"}, {"37_9", "PV S/W open"}, _
                        {"37_10", "reserved"}, {"37_11", "reserved"}, {"37_12", "reserved"}, {"37_13", "reserved"}, {"37_14", "reserved"}, {"37_15", "PCS COMM FAULT"}}

    Public BMS_FAULT_CODE(,) As String = {{"6_7", "Over Current Discharge Warning"}, _
        {"6_6", "Over Current Cahrge Warning"}, _
        {"6_5", "Rack Over Voltage Protection Warning"}, _
        {"6_4", "Rack Under Voltage Protection Warning"}, _
        {"6_3", "Rack Voltage Imbalance Warning"}, _
        {"6_2", "Rack Over Temperature Warning"}, _
        {"6_1", "Rack Under Temperature Warning"}, _
        {"6_0", "Rack Temperature Imbalance Warning"}, _
        {"7_11", "Tray-Rack Communication Fault"}, _
        {"7_10", "Over Current Cahrge Warning"}, _
        {"7_9", "Rack Over Voltage Protection Warning"}, _
        {"7_8", "Rack Under Voltage Protection Warning"}, _
        {"7_7", "Rack Voltage Imbalance Warning"}, _
        {"7_6", "Rack Over Temperature Warning"}, _
        {"7_5", "Rack Under Temperature Warning"}, _
        {"7_4", "Rack Temperature Imbalance Warning"}, _
        {"7_3", "Rack Voltage Imbalance Warning"}, _
        {"7_2", "Rack Over Temperature Warning"}, _
        {"7_1", "Rack Under Temperature Warning"}, _
        {"7_0", "Rack Temperature Imbalance Warning"}, _
        {"8_1", "Rack2 to Master BMS Communication Status"}, _
        {"8_0", "Rack1 to Master BMS Communication Status"}, _
        {"9_5", "Rack to Master BMS Communication Status"}, _
        {"9_4", "Bank Warning"}, _
        {"9_3", "Bank Fault"}, _
        {"9_2", "Bank Charge"}, _
        {"9_1", "Bank Discharge"}, _
        {"9_0", "Bank able to RUN"}, _
        {"25_10", "Rack #1 Alarm"}, _
        {"25_9", "Rack #1 Fault"}, _
        {"25_8", "Rack #1 RUN"}, _
        {"25_4", "Rack #1 Current sensor Charge"}, _
        {"25_3", "Rack #1 Current sensor Discharge"}, _
        {"25_2", "Rack #1 Cell balance Status"}, _
        {"25_1", "Rack #1 Charge Relay(+) Status"}, _
        {"25_0", "Rack #1 Discharge Relay(-) Status"}, _
        {"26_7", "Rack #1 Over Current Discharge Warning"}, _
        {"26_6", "Rack #1 Over Current Charge Warning"}, _
        {"26_5", "Rack #1 Over Voltage Protection Warning"}, _
        {"26_4", "Rack #1  Under Voltage Protection Warning"}, _
        {"26_3", "Rack #1 Voltage Imbalance Warning"}, _
        {"26_2", "Rack #1 Over Temperature Warning"}, _
        {"26_1", "Rack #1 Under Temperature Warning"}, _
        {"26_0", "Rack #1 Temperature Imbalance Warning"}, _
        {"27_12", "Rack #1 Tray-Rack Communication Fault"}, _
        {"27_11", "Rack #1 Fuse(+) Fault Status"}, _
        {"27_10", "Rack #1 Fuse(-) Fault Status"}, _
        {"27_9", "Rack #1 Discharge Relay(-) Fault Status"}, _
        {"27_8", "Rack #1 Charge Relay(+) Fault Status"}, _
        {"27_7", "Rack #1 Over Current Discharge Fault"}, _
        {"27_6", "Rack #1 Over Current Charge Fault"}, _
        {"27_5", "Rack #1 Rack Over Voltage Protection Fault"}, _
        {"27_4", "Rack #1 Rack Under Voltage Protection Fault"}, _
        {"27_3", "Rack #1 Rack Voltage Imbalance Fault"}, _
        {"27_2", "Rack #1 Rack Over Temperature Fault"}, _
        {"27_1", "Rack #1 Rack Under Temperature Fault"}, _
        {"27_0", "Rack #1 Rack Temperature Imbalance Fault"}, _
        {"404_10", "Rack #2 Alarm"}, _
        {"404_9", "Rack #2 Fault"}, _
        {"404_8", "Rack #2 RUN"}, _
        {"404_4", "Rack #2 Current sensor Charge"}, _
        {"404_3", "Rack #2 Current sensor Discharge"}, _
        {"404_2", "Rack #2 Cell balance Status"}, _
        {"404_1", "Rack #2 Charge Relay(+) Status"}, _
        {"404_0", "Rack #2 Discharge Relay(-) Status"}, _
        {"405_7", "Rack #2 Over Current Discharge Warning"}, _
        {"405_6", "Rack #2 Over Current Charge Warning"}, _
        {"405_5", "Rack #2 Over Voltage Protection Warning"}, _
        {"405_4", "Rack #2  Under Voltage Protection Warning"}, _
        {"405_3", "Rack #2 Voltage Imbalance Warning"}, _
        {"405_2", "Rack #2 Over Temperature Warning"}, _
        {"405_1", "Rack #2 Under Temperature Warning"}, _
        {"405_0", "Rack #2 Temperature Imbalance Warning"}, _
        {"406_12", "Rack #2 Tray-Rack Communication Fault"}, _
        {"406_11", "Rack #2 Fuse(+) Fault Status"}, _
        {"406_10", "Rack #2 Fuse(-) Fault Status"}, _
        {"406_9", "Rack #2 Discharge Relay(-) Fault Status"}, _
        {"406_8", "Rack #2 Charge Relay(+) Fault Status"}, _
        {"406_7", "Rack #2 Over Current Discharge Fault"}, _
        {"406_6", "Rack #2 Over Current Charge Fault"}, _
        {"406_5", "Rack #2 Rack Over Voltage Protection Fault"}, _
        {"406_4", "Rack #2 Rack Under Voltage Protection Fault"}, _
        {"406_3", "Rack #2 Rack Voltage Imbalance Fault"}, _
        {"406_2", "Rack #2 Rack Over Temperature Fault"}, _
        {"406_1", "Rack #2 Rack Under Temperature Fault"}, _
        {"406_0", "Rack #2 Rack Temperature Imbalance Fault"}, _
        {"783_10", "Rack #3 Alarm"}, _
        {"783_9", "Rack #3 Fault"}, _
        {"783_8", "Rack #3 RUN"}, _
        {"783_4", "Rack #3 Current sensor Charge"}, _
        {"783_3", "Rack #3 Current sensor Discharge"}, _
        {"783_2", "Rack #3 Cell balance Status"}, _
        {"783_1", "Rack #3 Charge Relay(+) Status"}, _
        {"783_0", "Rack #3 Discharge Relay(-) Status"}, _
        {"784_7", "Rack #3 Over Current Discharge Warning"}, _
        {"784_6", "Rack #3 Over Current Charge Warning"}, _
        {"784_5", "Rack #3 Over Voltage Protection Warning"}, _
        {"784_4", "Rack #3  Under Voltage Protection Warning"}, _
        {"784_3", "Rack #3 Voltage Imbalance Warning"}, _
        {"784_2", "Rack #3 Over Temperature Warning"}, _
        {"784_1", "Rack #3 Under Temperature Warning"}, _
        {"784_0", "Rack #3 Temperature Imbalance Warning"}, _
        {"785_12", "Rack #3 Tray-Rack Communication Fault"}, _
        {"785_11", "Rack #3 Fuse(+) Fault Status"}, _
        {"785_10", "Rack #3 Fuse(-) Fault Status"}, _
        {"785_9", "Rack #3 Discharge Relay(-) Fault Status"}, _
        {"785_8", "Rack #3 Charge Relay(+) Fault Status"}, _
        {"785_7", "Rack #3 Over Current Discharge Fault"}, _
        {"785_6", "Rack #3 Over Current Charge Fault"}, _
        {"785_5", "Rack #3 Rack Over Voltage Protection Fault"}, _
        {"785_4", "Rack #3 Rack Under Voltage Protection Fault"}, _
        {"785_3", "Rack #3 Rack Voltage Imbalance Fault"}, _
        {"785_2", "Rack #3 Rack Over Temperature Fault"}, _
        {"785_1", "Rack #3 Rack Under Temperature Fault"}, _
        {"785_0", "Rack #3 Rack Temperature Imbalance Fault"}}

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

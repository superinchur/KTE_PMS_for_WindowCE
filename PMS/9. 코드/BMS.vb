Structure Samsung_BMS

    ' 삼성배터리 버전의 Class
    Dim prev_Bank_SOC As Double                ' 10 - 0.1 %
    Dim prev_Bank_SOH As Double                   ' 11 - 0.1 %
    Dim prev_Bank_Status As UShort

    Dim Protocol_Version As UShort '0
    Dim System_Voltage As Double ' 1 0.1
    Dim System_Current As Short ' 2 Signed /256

    Dim System_SOC As Double  ' 3 Resolution  0.1
    Dim System_SOH As Double  ' 4 Resolution 0.1
    Dim System_Mode As UShort ' 5 
    Dim System_Max_Voltage As UShort ' 6
    Dim System_Min_Voltage As UShort ' 7
    Dim System_Max_Temp As Short  '8
    Dim System_Min_Temp As Short ' 9
    Dim Protection_Summary4 As UShort ' 14
    Dim Protection_Summary3 As UShort ' 15
    Dim Protection_Summary2 As UShort ' 16
    Dim Protection_Summary1 As UShort ' 17
    Dim Alarm_Summary4 As UShort ' 18
    Dim Alarm_Summary3 As UShort ' 19
    Dim Alarm_Summary2 As UShort ' 20
    Dim Alarm_Summary1 As UShort ' 21

    Dim Discharge_Current_Limit As UShort ' 22
    Dim Charge_Current_Limit As UShort ' 23
    Dim Watchdog_Response As Short ' 24

    Dim System_Heartbit As UShort ' 25
    Dim Connecting_Status As UShort ' 26

    Dim Service_Voltage As UShort ' 27
    Dim Service_SOC As UShort ' 28

    Dim Ambient_Temp As Double ' 30

    Dim System_Power As Double ' calculated

End Structure

Structure BMS

    Dim Over_Current_Discharge_Warning As Boolean           ' 6 - 7
    Dim Over_Current_Charge_Warning As Boolean       ' 6 - 6
    Dim Rack_Over_Voltage_Protection_Warning As Boolean     ' 6 - 5
    Dim Rack_Under_Voltage_Protection_Warning As Boolean  ' 6 - 4
    Dim Rack_Voltage_Imbalance_Warning As Boolean        ' 6 - 3
    Dim Rack_Over_Temperature_Warning As Boolean     ' 6 - 2
    Dim Rack_Under_Temperature_Warning As Boolean   ' 6 - 1
    Dim Rack_Temperature_Imbalance_Warning As Boolean      ' 6 - 0

    Dim prev_Over_Current_Discharge_Warning As Boolean           ' 6 - 7
    Dim prev_Over_Current_Charge_Warning As Boolean       ' 6 - 6
    Dim prev_Rack_Over_Voltage_Protection_Warning As Boolean     ' 6 - 5
    Dim prev_Rack_Under_Voltage_Protection_Warning As Boolean  ' 6 - 4
    Dim prev_Rack_Voltage_Imbalance_Warning As Boolean        ' 6 - 3
    Dim prev_Rack_Over_Temperature_Warning As Boolean     ' 6 - 2
    Dim prev_Rack_Under_Temperature_Warning As Boolean   ' 6 - 1
    Dim prev_Rack_Temperature_Imbalance_Warning As Boolean      ' 6 - 0


    Dim Tray_Rack_Communication_Fault As Boolean         ' 7 - 12
    Dim Fuse_positive_Fault_Status As Boolean       ' 7 - 11
    Dim Fuse_negative_Fault_Status As Boolean     ' 7 - 10
    Dim Discharge_Relay_negative_Fault_Status As Boolean   ' 7 - 9
    Dim Charge_Relay_positive_Fault_Status As Boolean   ' 7 - 8
    Dim Over_Current_Discharge_Fault As Boolean   ' 7 - 7
    Dim Over_Current_Charge_Fault As Boolean   ' 7 - 6
    Dim Rack_Over_Voltage_Protection_Fault As Boolean    ' 7 - 5
    Dim Rack_Under_Voltage_Protection_Fault As Boolean       ' 7 - 4
    Dim Rack_Voltage_Imbalance_Fault As Boolean    ' 7 - 3
    Dim Rack_Over_Temperature_Fault As Boolean     ' 7 - 2
    Dim Rack_Under_Temperature_Fault As Boolean    ' 7 - 1
    Dim Rack_Temperature_Imbalance_Fault As Boolean    ' 7 - 0

    Dim Rack2_to_Master_BMS_Communication_Status As Boolean  ' 8 - 1
    Dim Rack1_to_Master_BMS_Communication_Status As Boolean  ' 8 - 0
    Dim Rack_to_Master_BMS_Communication_Status As Boolean  ' 9 - 5
    Dim Bank_Warning As Boolean   ' 9 - 4
    Dim Bank_Fault As Boolean    ' 9 - 3
    Dim Bank_Charge_status1 As Boolean  ' 9 - 2 0b11 : Idle
    Dim Bank_Charge_status0 As Boolean  ' 9 - 1 0b01 : Charge 0b10 : Discharge
    Dim Bank_RUN As Boolean   ' 9 - 0

    Dim Bank_SOC As Double                ' 10 - 0.1 %
    Dim Bank_SOH As Double                   ' 11 - 0.1 %
    Dim Bank_DC전압 As Double             ' 12 - 0.1 V
    Dim Bank_DC전류 As Double              ' 13 - 0.1 A
    Dim Bank_충방전_전력_제한값 As Double           ' 14 - 0.1 A
    Dim Bank내_Cell_최고_전압 As Double        ' 16 - 0.001 V
    Dim Bank내_Cell_최소_전압 As Double     ' 18 - 0.001 V
    Dim Bank내_Module_최고_온도 As Double  ' 20 - 0.1 C
    Dim Bank내_Module_최저_온도 As Double     ' 22 - 0.1 C
    Dim Bank_충방전_전력 As Double       ' 24 - 0.1 kW

    Dim prev_Bank_SOC As Double                ' 10 - 0.1 %
    Dim prev_Bank_SOH As Double                   ' 11 - 0.1 %
    Dim prev_Bank_Status As UShort
    'public public Rack() As 클래스_BMS_Rack





End Structure

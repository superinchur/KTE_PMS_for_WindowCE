Structure BMS_Rack

    Dim Rack_Alarm As Boolean           '25 - 10
    Dim Rack_Fault As Boolean               '25 - 9
    Dim Rack_RUN As Boolean              '25 - 8
    Dim Current_sensor_Charge As Boolean          '25 - 4    
    Dim Current_sensor_Discharge As Boolean       '25 - 3
    Dim Cell_balance_Status As Boolean       '25 - 2
    Dim Charge_Relay_positive_Status As Boolean     '25 - 1
    Dim Discharge_Relay_negative_Status As Boolean     '25 - 0
    '
    Dim Over_Current_Discharge_Warning As Boolean      '26 - 7
    Dim Over_Current_Charge_Warning As Boolean      '26 - 6
    Dim Rack_Over_Voltage_Protection_Warning As Boolean  '26 - 5
    Dim Rack_Under_Voltage_Protection_Warning As Boolean  '26 - 4
    Dim Rack_Voltage_Imbalance_Warning As Boolean      '26 - 3
    Dim Rack_Over_Temperature_Warning As Boolean      '26 - 2
    Dim Rack_Under_Temperature_Warning As Boolean      '26 - 1
    Dim Rack_Temperature_Imbalance_Warning As Boolean  '26 - 0
    '
    Dim TrayRack_Communication_Fault As Boolean      '27 - 12
    Dim Fuse_positive_Fault_Status As Boolean        '27 - 11
    Dim Fuse_negative_Fault_Status As Boolean         '27 - 10
    Dim Discharge_Relay_negative_Fault_Status As Boolean  '27 - 9
    Dim Charge_Relay_positive_Fault_Status As Boolean  '27 - 8
    Dim Over_Current_Discharge_Fault As Boolean         '27 - 7
    Dim Over_Current_Charge_Fault As Boolean      '27 - 6
    Dim Rack_Over_Voltage_Protection_Fault As Boolean   '27 - 5
    Dim Rack_Under_Voltage_Protection_Fault As Boolean   '27 - 4
    Dim Rack_Voltage_Imbalance_Fault As Boolean        '27 - 3
    Dim Rack_Over_Temperature_Fault As Boolean       '27 - 2
    Dim Rack_Under_Temperature_Fault As Boolean      '27 - 1
    Dim Rack_Temperature_Imbalance_Fault As Boolean    '27 - 0

    Dim Rack_SOC As Double    '28
    Dim Rack_SOH As Double    '29
    Dim Rack_Voltage As Double   '30
    Dim Rack_Current As Double    '31
    Dim Max_Cell_Voltage As Double     '32
    Dim Max_Cell_Voltage_Position As Integer     '33
    Dim Min_Cell_Voltage As Double      '34
    Dim Min_Cell_Voltage_Position As Integer    '35
    Dim Cell_Voltage_Gap As Integer    '36
    Dim Rack_Average_Cell_Voltage As Integer             '37
    Dim Max_Cell_Temperature As Double           '38 scale 0.1
    Dim Max_Cell_Temperature_Position As Integer        '39
    Dim Min_Cell_Temperature As Double     '40 scale 0.1
    Dim Min_Cell_Temperature_Position As Integer      '41 
    Dim Cell_Temperature_Gap As Integer      '42
    Dim Rack_Average_Module_Temperature As Integer     '43



End Structure

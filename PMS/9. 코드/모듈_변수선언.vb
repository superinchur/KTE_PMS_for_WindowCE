Module 모듈_변수선언
    Public CONFIG_FILE As String = ""
    Public CONFIG_FILE1 As String = ""
    Public CONFIG_FILE2 As String = ""
    Public CONFIG_FILE3 As String = ""
    Public CONFIG_FILE4 As String = ""
    Public MODBUS_EMS_BUFFER(1024) As Byte

    Public EMS_수신포트 As Integer = 502
    Public BMS_수신포트 As Integer = 5020

    Public PCS_통신포트 As String = "COM2"
    Public PCS_통신주기 As Integer = 100

    Public BMS_통신포트 As String = "COM3"
    Public BMS_통신주기 As Integer = 500

    Public PMS_통신ID As Integer = 1
    Public BMS_통신ID As Integer = 1

    ' 겁나 중요해잉
    Public Enum BMS통신모드정의
        동작안함 = 0
        BankInfo = 1
        RackInfo = 2
        ModuleInfo = 3
    End Enum
    Public BMS현재통신모드 As Integer

    Public 설정변경_통신 As Boolean = False
    Public 설정변경_EMS As Boolean = False
    Public 설정변경_PCS As Boolean = False
    Public 설정변경_BMS As Boolean = False

    Public Const 인버터용량 As Integer = 99
    Public trigger_BMS As Boolean
    ' PCS MODBUS ADDRESS

    Public Const PT_INV_Control_Mode As Integer = 0
    Public Const PT_BAT_Power As Integer = 28


    Public Const PT_Constant_Current As Integer = 42
    Public Const PT_Constant_Voltage As Integer = 43
    Public Const PT_Grid_Active_Power As Integer = 44

    Public Const PT_SOC As Integer = 49
    Public Const PT_SOH As Integer = 50

    Public Const PT_STS As Integer = 52


    Public Const PT_Power_Active_Set As Integer = 1
    Public Const PT_Current_Battery_SOC_DATA As Integer = 2
    Public Const PT_Finish_Discharge_SOC_Level As Integer = 3
    Public Const PT_Finish_Charge_SOC_Level As Integer = 4
    Public Const PT_Start_charge_SOC_Level As Integer = 5
    Public Const PT_Peak_Cut_Start_Load_Power_Level As Integer = 6
    Public Const PT_Discharging_Max_Current As Integer = 7
    Public Const PT_Charging_Max_Current As Integer = 8
    Public Const PT_Active_Start_1 As Integer = 9
    Public Const PT_Active_End_1 As Integer = 10
    Public Const PT_Active_Start_2 As Integer = 11
    Public Const PT_Active_End_2 As Integer = 12
    Public Const PT_Active_Start_3 As Integer = 13
    Public Const PT_Active_End_3 As Integer = 14
    Public Const PT_Active_Start_4 As Integer = 15
    Public Const PT_Active_End_4 As Integer = 16

    Public Const PT_Grid_Freq As Integer = 37

    Public Const PT_GRID_R_Voltage As Integer = 30
    Public Const PT_GRID_S_Voltage As Integer = 31
    Public Const PT_GRID_T_Voltage As Integer = 32
    Public Const PT_GRID_R_Current As Integer = 33
    Public Const PT_GRID_S_Current As Integer = 34
    Public Const PT_GRID_T_Current As Integer = 35
    Public Const PT_GRID_POWER As Integer = 36
    Public Const PT_GRID_Frequency As Integer = 37

    Public Const PT_LOAD_R_Current As Integer = 41
    Public Const PT_LOAD_S_Current As Integer = 42
    Public Const PT_LOAD_T_Current As Integer = 43
    
    Public Const PT_LOAD_POWER As Integer = 44
    Public Const PT_INVERTER_POWER As Integer = 45

    Public Const PT_Grid_Status As Integer = 46
    Public Const PT_Fault_Status As Integer = 47
    Public Const PT_PCS_STANDBY As Integer = 48 ' 새로 추가된 항목

    Public Const Fault시배터리전압 As Integer = 49
    Public Const PT_Fault As Integer = 60
    Public Const PT_CONTROL_MODE As Integer = 61

    Public prev_PT_INV_Control_Mode As UShort = 0
    Public prev_PT_Power_Active_Set As UShort = 0
    Public prev_PT_Current_Battery_SOC_DATA As UShort = 0

    '180529 
    '이전에는 PCS에 각각 다른 곳에서 제어명령을 요청했다. 하지만 PCS의 응답을 신뢰할 수 없고, 응답시간이 길기때문에
    ' 현재 PCS의 데이터는 uPMS에서 저장하는 것을 우선으로하고, 혹시 모를 불일치를 검사하는 방향으로 수정하고자 함.
    Public control_PT_INV_Control_Mode As UShort = 0
    Public flag_control_PT_INV_Control_Mode_Changed As Boolean = False

    Public 현재사용모드 As 사용모드정의 = 사용모드정의.동작안함
    Public 현재사용모드_PMS의존모드 As Integer

    Public Enum 사용모드정의
        동작안함 = 0
        평상 = 1
        피크컷 = 2
        유효전력 = 3
        무효전력 = 4
        배터리충전 = 5
        배터리방전 = 6
    End Enum

    Public 현재사용모드_STANDBY As Boolean = False
    Public 현재사용모드_ESS모드 As Boolean = False
    Public 현재사용모드_배터리충전 As Boolean = False
    Public 현재사용모드_배터리방전 As Boolean = False
    Public 현재사용모드_배터리방전시간 As Boolean = False
    Public 현재사용모드_원격RESET확인중 As Boolean = False
    Public 현재사용모드_리모트모드 As Boolean = False

    Public 사용모드_피크컷시간(,) As Integer
    Public d사용모드_로드파워 As Double
    Public d사용모드_피크컷 As Double

    Public d사용모드_유효전력 As Double
    Public d사용모드_유효전력_이전값 As Double

    Public d사용모드_배터리_충전정지SOC As Double
    Public d사용모드_배터리_방전정지SOC As Double
    Public d사용모드_배터리_충전시작SOC As Double
    Public d사용모드_피크컷시작전력 As Double
    Public d사용모드_방전시최대전류값 As Double
    Public d사용모드_충전시최대전류값 As Double

    Public d사용모드_배터리_충전시최대전류 As Double
    Public d사용모드_배터리_방전시최대전류 As Double

    Public cBMS As New Samsung_BMS
    Public cBMS_Rack(1) As Samsung_BMS_Rack

    Public DEBUG_COMM As Boolean = 0
    Public Assertbit As Boolean

    Public qRecvFault As New Queue
    Public heartbit As Integer = 0

    'BMS데이터비교에서 Deadband를 사용하기 위해서 저장하는 시간 값.

    Public Control_BMS_Relay As UShort
    Public Control_BMS_Fault_Reset As UShort
    Public Control_BMS_WatchDog As UShort

    Public Control_Trigger_Relay As UShort
    Public Control_Trigger_Fault_Reset As UShort
    Public Control_Trigger_WatchDog As UShort


    Public isSDCard_Mode As Boolean = 0


    Public Enum BSC상태
        Connect = 1
        Initializing = 2
        Normal = 3
        Contactor_Close = 4
        Contactor_Open = 5
        Contactor_Open1 = 51
        Contactor_Open2 = 52
        DisconnectSwitch_Open = 6
        Reset = 7
        Restart = 8
        Sleep_Start = 9
        Sleep_Exit = 10
        Manual_Mode_enter = 11
        Manual_mode_Sequence = 12
        Manual_Mode_Exit = 13
        Warning = 11
        Fault = 12
    End Enum


    Public 현재BSC상태 As UShort
End Module

Module 모듈_변수선언
    Public CONFIG_FILE As String = ""

    Public EMS_수신포트 As Integer = 502
    Public BMS_수신포트 As Integer = 503

    Public PCS_통신포트 As String = "COM2"
    Public PCS_통신주기 As Integer = 100

    Public BMS_통신포트 As String = "COM3"
    Public BMS_통신주기 As Integer = 100

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
    Public Const PT_PV_Power As Integer = 1
    Public Const PT_PV_Voltage As Integer = 2
    Public Const PT_PV_Current As Integer = 3
    Public Const PT_Inv_Power As Integer = 4
    Public Const PT_V_Inv_U As Integer = 5
    Public Const PT_V_Inv_V As Integer = 6
    Public Const PT_V_Inv_W As Integer = 7
    Public Const PT_I_Inv_U As Integer = 8
    Public Const PT_I_Inv_V As Integer = 9
    Public Const PT_I_Inv_W As Integer = 10
    Public Const PT_Grid_PF As Integer = 11
    Public Const PT_Grid_In_Power As Integer = 12
    Public Const PT_Grid_Out_Power As Integer = 13
    Public Const PT_V_Grid_R As Integer = 14
    Public Const PT_V_Grid_S As Integer = 15
    Public Const PT_V_Grid_T As Integer = 16
    Public Const PT_I_Grid_R As Integer = 17
    Public Const PT_I_Grid_S As Integer = 18
    Public Const PT_I_Grid_T As Integer = 19
    Public Const PT_Grid_Freq As Integer = 20
    Public Const PT_Load_Power As Integer = 21
    Public Const PT_I_Load_R As Integer = 22
    Public Const PT_I_Load_S As Integer = 23
    Public Const PT_I_Load_T As Integer = 24
    Public Const PT_V_Load_R As Integer = 25
    Public Const PT_V_Load_S As Integer = 26
    Public Const PT_V_Load_T As Integer = 27
    Public Const PT_BAT_Power As Integer = 28
    Public Const PT_BAT_V As Integer = 29
    Public Const PT_BAT_I As Integer = 30
    Public Const PT_BAT_SOC As Integer = 31
    Public Const PT_BAT_SOH As Integer = 32
    Public Const PT_BAT_TEMP As Integer = 33
    Public Const PT_BAT_STS As Integer = 34
    Public Const PT_Inv_Status As Integer = 35
    Public Const PT_Grid_Status As Integer = 36
    Public Const PT_전장_Status As Integer = 37
    Public Const PT_MODE_Status As Integer = 38
    Public Const PT_OpFLAG_Status As Integer = 39
    Public Const PT_SOC_CHG_Start As Integer = 40
    Public Const PT_SOC_DCHG_FNSH As Integer = 41
    Public Const PT_Constant_Current As Integer = 42
    Public Const PT_Constant_Voltage As Integer = 43
    'Public Const PT_SOC_CHG_Start_off As Integer = 41
    'Public Const PT_SOC_DCHG_FNSH As Integer = 42
    'Public Const PT_SOC_DCHG_FNSH_OFF As Integer = 43
    Public Const PT_Grid_Active_Power As Integer = 44
    Public Const PT_Grid_Reactive_Power As Integer = 45
    Public Const PT_Pf_Set As Integer = 46
    Public Const PT_Fre_Set As Integer = 47
    Public Const PT_V_Inv_Set As Integer = 48

    Public Const PT_SOC As Integer = 49
    Public Const PT_SOH As Integer = 50
    Public Const PT_TEMP As Integer = 51
    Public Const PT_STS As Integer = 52

    'Public 현재사용모드 As 사용모드정의 = 사용모드정의.동작안함

    'Public Enum 사용모드정의
    '    동작안함 = 0
    '    평상 = 1
    '    피크컷 = 2
    '    유효전력 = 3
    '    무효전력 = 4
    '    배터리충전 = 5
    'End Enum

    Public 현재사용모드_피크컷동작 As Boolean = False
    Public 현재사용모드_유효전력 As Boolean = False
    Public 현재사용모드_무효전력 As Boolean = False
    Public 현재사용모드_배터리충전 As Boolean = False
    Public 현재사용모드_배터리방전 As Boolean = False
    Public 현재사용모드_배터리방전시간 As Boolean = False

    Public 현재사용모드_PCS방전강제종료 As Boolean = False
    Public 현재사용모드_PCS충전강제종료 As Boolean = False

    Public 사용모드_피크컷시간(,) As Integer
    Public d사용모드_로드파워 As Double
    Public d사용모드_피크컷 As Double

    Public d사용모드_유효전력 As Double
    Public d사용모드_무효전력 As Double

    Public d사용모드_배터리_충전정지SOC As Double
    Public d사용모드_배터리_방전정지SOC As Double
    Public d사용모드_배터리_충전정지전압 As Double
    Public d사용모드_배터리_방전정지전압 As Double
    Public d사용모드_배터리_충전시최대전류 As Double
    Public d사용모드_배터리_방전시최대전류 As Double


    Public cBMS As New BMS
    Public cBMS_Rack(5) As BMS_Rack
    Public cBMS_Module(4, 17) As BMS_Module

    Public num_Rack As Integer
    Public num_Module As Integer

    Public DEBUG_COMM As Boolean = 0
    Public Assertbit As Boolean

    Public qRecvFault As New Queue
    Public heartbit As Integer = 0

    'BMS데이터비교에서 Deadband를 사용하기 위해서 저장하는 시간 값.

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

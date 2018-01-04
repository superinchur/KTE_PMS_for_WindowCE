Public Class wnd서브화면1_메인


    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True

    End Sub

    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick
        타이머_상태.Enabled = False

        If Me.Visible = True Then
            상태표시()
        End If

        타이머_상태.Enabled = True
    End Sub

    Private 배터리이미지 As Integer = -1
    Private 배터리모드 As Integer = -1
    Private 그리드상태 As Integer = -1
    Private 로드상태 As Integer = -1

    'Private 최종사용모드 As 사용모드정의 = -1

    Private Sub 상태표시()
        ' -------------------------------------------------------------------------------------------------------
        ' 운전상태

        'If 최종사용모드 <> 현재사용모드 Then
        '    최종사용모드 = 현재사용모드

        '    Select Case 최종사용모드
        '        Case 사용모드정의.동작안함
        '            lbRunMode.Text = ""
        '            lbRunMode.Visible = False
        '        Case 사용모드정의.평상
        '            lbRunMode.Text = ""
        '            lbRunMode.Visible = False
        '        Case 사용모드정의.피크컷
        '            lbRunMode.Text = "피크컷 동작"
        '            lbRunMode.BackColor = Color.LightPink
        '            lbRunMode.Visible = True
        '        Case 사용모드정의.유효전력
        '            lbRunMode.Text = "유효전력 동작"
        '            lbRunMode.BackColor = Color.LightGreen
        '            lbRunMode.Visible = True
        '        Case 사용모드정의.무효전력
        '            lbRunMode.Text = "무효전력 동작"
        '            lbRunMode.BackColor = Color.LightGreen
        '            lbRunMode.Visible = True
        '        Case 사용모드정의.배터리충전
        '            lbRunMode.Text = "배터리 충전"
        '            lbRunMode.BackColor = Color.LightCyan
        '            lbRunMode.Visible = True
        '    End Select

        'End If

        Dim szCurrentStatus As String = ""
        If 현재사용모드_피크컷동작 = True Then
            szCurrentStatus = "피크컷 모드"
        Else
            If 현재사용모드_유효전력 = True Then
                szCurrentStatus = "유효전력 모드"
            End If

            If 현재사용모드_무효전력 = True Then
                If szCurrentStatus <> "" Then szCurrentStatus &= vbCrLf
                szCurrentStatus = "유효전력 모드"
            End If

            If 현재사용모드_배터리충전 = True Then
                If szCurrentStatus <> "" Then szCurrentStatus &= vbCrLf
                szCurrentStatus = "배터리 충전"
            End If
        End If
        
        If lbRunMode.Text <> szCurrentStatus Then
            If szCurrentStatus <> "" Then
                lbRunMode.Text = szCurrentStatus
                lbRunMode.BackColor = Color.LightGreen
                lbRunMode.Visible = True
            Else
                lbRunMode.Visible = False
            End If
        End If


        ' -------------------------------------------------------------------------------------------------------
        ' 배터리 상태 

        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)

        Dim nCharge As Integer = ushValue >> 4 And &H1
        Dim nDischarge As Integer = ushValue >> 5 And &H1

        Dim nOldStatus As Integer = 배터리모드
        Dim szValue As String = ""
        Dim ushTemp As UShort = GetModbusData_Ushort(PT_BAT_Power)
        Dim dValue As Double = ushTemp * 0.1

        If nCharge = 1 Then
            배터리모드 = 1
            szValue = String.Format("충전중 : {0:F1}kWh", dValue)
        ElseIf nDischarge = 1 Then
            배터리모드 = 2
            szValue = String.Format("방전중 : {0:F1}kWh", dValue)
        Else
            배터리모드 = 0
            szValue = "대기"
        End If

        ushTemp = GetModbusData_Ushort(PT_BAT_SOC)
        dValue = ushTemp * 0.01

        Dim nBatteryImage As Integer = 0
        If dValue >= 90 Then
            nBatteryImage = 6
        ElseIf dValue >= 70 Then
            nBatteryImage = 5
        ElseIf dValue >= 50 Then
            nBatteryImage = 4
        ElseIf dValue >= 30 Then
            nBatteryImage = 3
        ElseIf dValue >= 10 Then
            nBatteryImage = 2
        Else
            nBatteryImage = 1
        End If

        If nBatteryImage <> 배터리이미지 Then
            배터리이미지 = nBatteryImage

            Select Case 배터리이미지
                Case 1
                    pbBattery.Image = My.Resources.배터리_000
                    pbBattery.Invalidate()
                Case 2
                    pbBattery.Image = My.Resources.배터리_020
                    pbBattery.Invalidate()
                Case 3
                    pbBattery.Image = My.Resources.배터리_040
                    pbBattery.Invalidate()
                Case 4
                    pbBattery.Image = My.Resources.배터리_060
                    pbBattery.Invalidate()
                Case 5
                    pbBattery.Image = My.Resources.배터리_080
                    pbBattery.Invalidate()
                Case 6
                    pbBattery.Image = My.Resources.배터리_100
                    pbBattery.Invalidate()
            End Select
        End If

        If lbBattStatus.Text <> szValue Then
            lbBattStatus.Text = szValue
        End If

        szValue = String.Format("{0:F2}%", dValue)
        If lbBattPercent.Text <> szValue Then
            lbBattPercent.Text = szValue
        End If

        If nOldStatus <> 배터리모드 Then
            Select Case 배터리모드
                Case 0      ' 정지
                    ucScrollBattStatus.Arrow = ucScrollArrow.eArrow.Arrow_Stop

                    lbBattStatus.Text = ""
                    lbBattStatus.Invalidate()
                Case 1      ' 충전
                    ucScrollBattStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left
                Case 2      ' 방전
                    ucScrollBattStatus.Arrow = ucScrollArrow.eArrow.Arrow_Right
            End Select
        End If

        ' -------------------------------------------------------------------------------------------------------
        ' 그리드 상태 
        nOldStatus = 그리드상태
        Dim dGrid_In_Power As Double = GetModbusData_Ushort(PT_Grid_In_Power) * 0.1
        Dim dGrid_Out_Power As Double = GetModbusData_Ushort(PT_Grid_Out_Power) * 0.1

        If dGrid_In_Power > 0 And dGrid_Out_Power <= 0 Then
            그리드상태 = 1
            szValue = String.Format("{0:F1} kW", dGrid_In_Power)
        ElseIf dGrid_In_Power <= 0 And dGrid_Out_Power > 0 Then
            그리드상태 = 2
            szValue = String.Format("{0:F1} kW", dGrid_Out_Power)
        Else
            그리드상태 = 0
            szValue = ""
        End If

        If lbGridStatus.Text <> szValue Then
            lbGridStatus.Text = szValue
            lbGridStatus.Invalidate()
        End If

        If nOldStatus <> 그리드상태 Then
            Select Case 그리드상태
                Case 0
                    ' 중지
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Stop
                Case 1
                    ' 출력 전력
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left
                Case 2
                    ' 입력 전력
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Right

            End Select
        End If

        ' -------------------------------------------------------------------------------------------------------
        ' 부하 상태 
        Dim dLoadPower As Double = GetModbusData_Ushort(PT_Load_Power) * 0.1
        szValue = String.Format("{0:F1} kW", dLoadPower)

    End Sub

End Class

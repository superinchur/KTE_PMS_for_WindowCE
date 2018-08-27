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

            '180518 테스트

            Addr0.Text = Get_MODBUS_EMS_BUFFER(0).ToString
            Addr1.Text = Get_MODBUS_EMS_BUFFER(1).ToString
            Addr2.Text = Get_MODBUS_EMS_BUFFER(2).ToString
            lbcontrol_INV.Text = control_PT_INV_Control_Mode.ToString()
        End If

        타이머_상태.Enabled = True
    End Sub

    Private 배터리이미지 As Integer = -1
    Private 배터리모드 As Integer = -1
    Private 그리드상태 As Integer = -1
    Private 로드상태 As Integer = -1

    Private 최종사용모드 As 사용모드정의 = -1

    Private Sub 상태표시()
        ' -------------------------------------------------------------------------------------------------------
        ' 운전상태
        If 최종사용모드 <> 현재사용모드 Then
            최종사용모드 = 현재사용모드
            ' TODO : 이건 또 무엇인가... 최종사용모드의 값을 쓰는 항목이 없는데 이것이 왜 있는지 의문임
                Select 최종사용모드
                Case 사용모드정의.동작안함
                    lbRunMode.Text = ""
                    lbRunMode.Visible = False
                Case 사용모드정의.평상
                    lbRunMode.Text = ""
                    lbRunMode.Visible = False
                Case 사용모드정의.피크컷
                    lbRunMode.Text = "피크컷 동작"
                    lbRunMode.BackColor = Color.LightPink
                    lbRunMode.Visible = True
                Case 사용모드정의.배터리충전
                    lbRunMode.Text = "배터리 충전"
                    lbRunMode.BackColor = Color.LightCyan
                    lbRunMode.Visible = True
                Case 사용모드정의.배터리충전
                    lbRunMode.Text = "배터리 방전"
                    lbRunMode.BackColor = Color.LightGreen
                    lbRunMode.Visible = True
            End Select

        End If

        '180605 PCS STANDBY 모드일 경우에만 화면에 나타나도록 변경한다.
        Dim PCS_STANDBY As UShort = GetModbusData_Ushort(PT_PCS_STANDBY)
        If PCS_STANDBY And &H1 = True Then

            Dim szCurrentStatus As String = ""
            If 현재사용모드_ESS모드 = True Then
                szCurrentStatus = "태양광ESS 모드"

                If 현재사용모드_배터리충전 = True Then
                    If szCurrentStatus <> "" Then szCurrentStatus &= vbCrLf
                    szCurrentStatus = "태양광 모드 - 배터리 충전"
                End If

                If 현재사용모드_배터리방전 = True Then
                    If szCurrentStatus <> "" Then szCurrentStatus &= vbCrLf
                    szCurrentStatus = "태양광 모드 - 배터리 방전"
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
        Else
            lbRunMode.Visible = False
        End If

        ' -------------------------------------------------------------------------------------------------------
        ' 배터리 상태 
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        lbHeartBit.Text = cBMS.System_Heartbit.ToString

        Dim nCharge As Integer = ushValue >> 6 And &H1
        Dim nDischarge As Integer = ushValue >> 7 And &H1

        Dim nOldStatus As Integer = 배터리모드
        Dim szValue As String = ""

        'TODO : 왜 PCS에서 Battery Power를 받아오는가? 이는 수정되어야 함. 생각해보니까 그때 두개의 차이를 두기 위해서 했었음_ 

        Dim ushTemp As Short = cBMS.System_Current
        Dim dValue As Double = Convert.ToInt16(ushTemp.ToString("X4"), 16)

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

        dValue = cBMS.System_SOC

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

        szValue = String.Format("{0:F2}%", dValue)
        If lbBattPercent.Text <> szValue Then
            lbBattPercent.Text = szValue
        End If

        Dim lbBattStatusPower As Double = cBMS.System_Power
        szValue = String.Format("{0:F1} kW", lbBattStatusPower)
        If lbBattStatus.Text <> szValue Then
            lbBattStatus.Text = szValue
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

        Dim usPower As UShort = GetModbusData_Ushort(PT_INVERTER_POWER)
        Dim dPT_Inv_Power As Double = Convert.ToInt16(usPower.ToString("X4"), 16)

        szValue = String.Format("{0:F1} kW", dPT_Inv_Power)
        If lbGridStatus.Text <> szValue Then
            lbGridStatus.Text = szValue
            lbGridStatus.Invalidate()
        End If

        ' 사용전검사를 위해서 화살표 방향을 반대로 변경
        If nDischarge = 1 Then
            그리드상태 = 1
        ElseIf nCharge = 1 Then
            그리드상태 = 2
        Else
            그리드상태 = 0
        End If
        If nOldStatus <> 그리드상태 Then
            Select Case 그리드상태
                Case 0
                    ' 중지
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Stop
                Case 1
                    ' 출력 전력 ' 방전
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Right
                Case 2
                    ' 입력 전력 ' 충전
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left

            End Select
        End If

        ' -------------------------------------------------------------------------------------------------------
        ' 부하 상태 
        szValue = String.Format("{0:F1} kW", dPT_Inv_Power)

    End Sub

    Private Sub PageHeader1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub PageHeader4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btn로컬모드_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn로컬모드.Click
        If MsgBox("로컬모드로 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then
            현재사용모드_리모트모드 = False
        End If
    End Sub

    Private Sub btn리모트모드_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn리모트모드.Click
        If MsgBox("리모트모드로 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then
            현재사용모드_리모트모드 = True
        End If
    End Sub

    Private Sub Addr0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addr0.Click
        If MsgBox("값을 초기화하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then

            control_PT_INV_Control_Mode = 1
            MODBUS_EMS_BUFFER(0) = 0
            MODBUS_EMS_BUFFER(1) = 1
        End If
    End Sub

    Private Sub Addr1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addr1.Click
        If MsgBox("값을 초기화하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then

            MODBUS_EMS_BUFFER(2) = 0
            MODBUS_EMS_BUFFER(3) = 0
        End If
    End Sub

    Private Sub Addr2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addr2.Click
        If MsgBox("값을 초기화하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then

            MODBUS_EMS_BUFFER(4) = 0
            MODBUS_EMS_BUFFER(5) = 0
        End If
    End Sub
End Class

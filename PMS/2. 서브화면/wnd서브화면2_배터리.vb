Public Class wnd서브화면2_배터리

    Public Sub New()


        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        화면초기화()
        PageHeader1_Click(Nothing, EventArgs.Empty)

        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True
        InitKeyPad()
    End Sub

    Private Sub 화면초기화()

        Panel1.BackColor = Color.White
        Panel2.BackColor = Color.White
        Panel3.BackColor = Color.White
        Panel.BackColor = Color.White

        Panel1.Left = Panel.Left + 1
        Panel1.Top = Panel.Top + 1
        Panel1.Width = Panel.Width - 2
        Panel1.Height = Panel.Height - 2

        Panel2.Left = Panel1.Left + 1
        Panel2.Top = Panel1.Top + 1
        Panel2.Width = Panel1.Width - 2
        Panel2.Height = Panel1.Height - 2

        Panel3.Left = Panel1.Left + 1
        Panel3.Top = Panel1.Top + 1
        Panel3.Width = Panel1.Width - 2
        Panel3.Height = Panel1.Height - 2

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

    Private Sub 상태표시()

        ' -------------------------------------------------------------------------------------------------------
        ' 배터리 상태 
        '180518 배터리상태를 PCS에서 받아오는게 아니라 BMS에서 받아오는 것으로 변경한다.
        Dim ushValue As UShort = cBMS.System_Mode

        Dim nOldStatus As Integer = 배터리모드
        Dim dValue As Double = cBMS.System_SOC

        If ushValue >> 15 And &H1 Then
            배터리모드 = 1

            If lChargingStatus.Text <> "충전중" Then
                lChargingStatus.Text = "충전중"
            End If

        ElseIf ushValue >> 14 And &H1 Then
            배터리모드 = 2

            If lChargingStatus.Text <> "방전중" Then
                lChargingStatus.Text = "방전중"
            End If

        ElseIf ushValue >> 10 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "Offline" Then
                lChargingStatus.Text = "Offline"
            End If

        ElseIf ushValue >> 9 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "Idle" Then
                lChargingStatus.Text = "Idle"
            End If
        ElseIf ushValue >> 8 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "Ready" Then
                lChargingStatus.Text = "Ready"
            End If
        ElseIf ushValue >> 7 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "IS4" Then
                lChargingStatus.Text = "IS4"
            End If
        ElseIf ushValue >> 6 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "IS3" Then
                lChargingStatus.Text = "IS3"
            End If
        ElseIf ushValue >> 5 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "IS2" Then
                lChargingStatus.Text = "IS2"
            End If
        ElseIf ushValue >> 4 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "IS1" Then
                lChargingStatus.Text = "IS1"
            End If
        ElseIf ushValue >> 1 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "OC2" Then
                lChargingStatus.Text = "OC2"
            End If
        ElseIf ushValue >> 0 And &H1 Then
            배터리모드 = 0
            If lChargingStatus.Text <> "OC1" Then
                lChargingStatus.Text = "OC1"
            End If
        Else
            배터리모드 = 0

            If lChargingStatus.Text <> "Excp." Then
                lChargingStatus.Text = "Excp"
            End If
        End If


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


        Dim szValue As String = ""

        ' -----------------------------------------------------------------------------------
        ' 배터리 사용량

        If 배터리_당일_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당일_방전)
        ElseIf 배터리_당일_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_당일_방전 / 1000)
        ElseIf 배터리_당일_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당일_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Today.Text <> szValue Then
            lbBatteryDischarge_Today.Text = szValue
        End If

        If 배터리_당월_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당월_방전)
        ElseIf 배터리_당월_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_당월_방전 / 1000)
        ElseIf 배터리_당월_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당월_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Yesterday.Text <> szValue Then
            lbBatteryDischarge_Yesterday.Text = szValue
        End If

        If 배터리_누적_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_누적_방전)
        ElseIf 배터리_누적_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_누적_방전 / 1000)
        ElseIf 배터리_누적_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_누적_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Total.Text <> szValue Then
            lbBatteryDischarge_Total.Text = szValue
        End If


        If 배터리_당일_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당일_충전)
        ElseIf 배터리_당일_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_당일_충전 / 1000)
        ElseIf 배터리_당일_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당일_충전 / 1000 / 1000)
        End If
        If lbBatteryCharge_Today.Text <> szValue Then
            lbBatteryCharge_Today.Text = szValue
        End If

        If 배터리_당월_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당월_충전)
        ElseIf 배터리_당월_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_당월_충전 / 1000)
        ElseIf 배터리_당월_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당월_충전 / 1000 / 1000)
        End If

        If lbBatteryCharge_Yesterday.Text <> szValue Then
            lbBatteryCharge_Yesterday.Text = szValue
        End If

        If 배터리_누적_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_누적_충전)
        ElseIf 배터리_누적_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} MWh   ", 배터리_누적_충전 / 1000)
        ElseIf 배터리_누적_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_누적_충전 / 1000 / 1000)
        End If
        If lbBatteryCharge_Total.Text <> szValue Then
            lbBatteryCharge_Total.Text = szValue
        End If

        Try
            lSOC.Text = Convert.ToString(cBMS.System_SOC) + " %"
            lSOH.Text = Convert.ToString(cBMS.System_SOH) + " %"
            lPower.Text = Convert.ToString(cBMS.System_Power) + " kW"
            lVoltage.Text = Convert.ToString(cBMS.System_Voltage) + " V"
            lCurrent.Text = Convert.ToString(cBMS.System_Current) + " A"
            lTemperature.Text = Convert.ToString(cBMS.System_Max_Temp) + " °C"

            If Panel3.Visible = True Then
                lbResponse.Text = Convert.ToString(cBMS.Watchdog_Response)
            End If


        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try
    End Sub


    Private Sub PageHeader1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Click
        타이머_상태.Enabled = False
        PageHeader1.BorderSide_Bottom = False
        PageHeader1.BackColor = Color.White
        PageHeader1.Enabled = False
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False

        타이머_상태.Enabled = True
    End Sub

    Private Sub PageHeader2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader2.Click
        타이머_상태.Enabled = False
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = False
        PageHeader2.BackColor = Color.White
        PageHeader2.Enabled = False
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        타이머_상태.Enabled = True
    End Sub

    Private Sub PageHeader3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader3.Click
        타이머_상태.Enabled = False
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = False
        PageHeader3.BackColor = Color.White
        PageHeader3.Enabled = False
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()


        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        타이머_상태.Enabled = True
    End Sub


    Private Sub PageHeader4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader4.Click
        타이머_상태.Enabled = False
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = False
        PageHeader4.BackColor = Color.White
        PageHeader4.Enabled = False
        PageHeader4.Invalidate()

        BMS현재통신모드 = BMS통신모드정의.RackInfo

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False

        타이머_상태.Enabled = True
    End Sub

    Private Sub btn_Module_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        타이머_상태.Enabled = False
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

        BMS현재통신모드 = BMS통신모드정의.ModuleInfo
        타이머_상태.Enabled = True
    End Sub

    Private Sub Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel.Paint
        Dim pObj As Panel = sender

        Dim pPen As New Pen(Color.Gray, 1)

        e.Graphics.DrawLine(pPen, 0, 0, 0, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, pObj.Width - 1, 0, pObj.Width - 1, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, 0, pObj.Height - 1, pObj.Width - 1, pObj.Height - 1)

        e.Graphics.DrawLine(pPen, PageHeader4.Left + PageHeader4.Width - PageHeader1.Left, 0, pObj.Width - 1, 0)

    End Sub


    Private Sub VsLabel11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        trigger_BMS = True
    End Sub


    Private Sub BTN_Minor_Fault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Minor_Fault_On.Click
        Control_Trigger_Fault_Reset = 1
        Control_BMS_Fault_Reset = SetBitmask(Control_BMS_Fault_Reset, 6, 1)
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 4, 1)
    End Sub

    Private Sub BTN_Minor_Fault_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Minor_Fault_Off.Click
        Control_Trigger_Fault_Reset = 1
        Control_BMS_Fault_Reset = SetBitmask(Control_BMS_Fault_Reset, 6, 0)
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 4, 0)
    End Sub

    Private Sub BTN_Major_Fault_On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Major_Fault_On.Click
        Control_Trigger_Fault_Reset = 1
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 2, 1)
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 0, 1)
    End Sub

    Private Sub BTN_Major_Fault_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Major_Fault_Off.Click
        Control_Trigger_Fault_Reset = 1
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 2, 1)
        control_BMS_Fault_Reset = SetBitmask(control_BMS_Fault_Reset, 0, 1)
    End Sub

    Private Sub Gridon_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridon_on.Click
        Control_Trigger_Relay = 1
        Control_BMS_Relay = 5
    End Sub

    Private Sub GridOn_off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOn_off.Click
        Control_Trigger_Relay = 1
        Control_BMS_Relay = 3
    End Sub



    Private Sub lbWatchDog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbWatchDog.TextChanged
        Control_Trigger_WatchDog = 1
        Control_BMS_WatchDog = Convert.ToInt16(lbWatchDog.Text)

    End Sub
End Class

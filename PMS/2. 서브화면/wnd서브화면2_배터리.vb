Public Class wnd서브화면2_배터리

    Private num_Rack As Integer
    Private num_Module As Integer


    Public Sub New()


        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        화면초기화()
        PageHeader1_Click(Nothing, EventArgs.Empty)

        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True

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
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)

        Dim nCharge As Integer = ushValue >> 4 And &H1
        Dim nDischarge As Integer = ushValue >> 5 And &H1

        Dim nOldStatus As Integer = 배터리모드
        Dim ushTemp As UShort = GetModbusData_Ushort(PT_BAT_SOC)
        Dim dValue As Double = ushTemp * 0.01

        If nCharge = 1 Then
            배터리모드 = 1

            If lChargingStatus.Text <> "충전중" Then
                lChargingStatus.Text = "충전중"
            End If

        ElseIf nDischarge = 1 Then
            배터리모드 = 2

            If lChargingStatus.Text <> "방전중" Then
                lChargingStatus.Text = "방전중"
            End If

        Else
            배터리모드 = 0

            If lChargingStatus.Text <> "대기" Then
                lChargingStatus.Text = "대기"
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



        ' SOC
        Dim szValue As String = String.Format("{0:F2} %    ", dValue)
        If lSOC.Text <> szValue Then
            lSOC.Text = szValue
        End If

        ' SOH
        ushTemp = GetModbusData_Ushort(PT_BAT_SOH)
        dValue = ushTemp * 0.01
        szValue = String.Format("{0:F2} %    ", dValue)
        If lSOH.Text <> szValue Then
            lSOH.Text = szValue
        End If


        ' 전력
        ushTemp = GetModbusData_Ushort(PT_BAT_Power)
        dValue = ushTemp * 0.1
        szValue = String.Format("{0:F1} kW  ", dValue)
        If lPower.Text <> szValue Then
            lPower.Text = szValue
        End If



        ' 전압
        ushTemp = GetModbusData_Ushort(PT_BAT_V)
        dValue = ushTemp * 0.1
        szValue = String.Format("{0:F1} V    ", dValue)
        If lVoltage.Text <> szValue Then
            lVoltage.Text = szValue
        End If

        ' 전류
        ushTemp = GetModbusData_Ushort(PT_BAT_I)
        dValue = ushTemp * 0.1
        szValue = String.Format("{0:F1} A    ", dValue)
        If lCurrent.Text <> szValue Then
            lCurrent.Text = szValue
        End If


        ' 온도
        ushTemp = GetModbusData_Ushort(PT_BAT_TEMP)
        dValue = ushTemp * 0.1
        szValue = String.Format("{0:F1} ℃    ", dValue)
        If lTemperature.Text <> szValue Then
            lTemperature.Text = szValue
        End If


        ' -----------------------------------------------------------------------------------
        ' 배터리 사용량

        If 배터리_당일_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당일_방전)
        ElseIf 배터리_당일_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_당일_방전 / 1000)
        ElseIf 배터리_당일_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당일_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Today.Text <> szValue Then
            lbBatteryDischarge_Today.Text = szValue
        End If

        If 배터리_어제_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_어제_방전)
        ElseIf 배터리_당일_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_어제_방전 / 1000)
        ElseIf 배터리_당일_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_어제_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Yesterday.Text <> szValue Then
            lbBatteryDischarge_Yesterday.Text = szValue
        End If

        If 배터리_누적_방전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_누적_방전)
        ElseIf 배터리_당일_방전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_누적_방전 / 1000)
        ElseIf 배터리_당일_방전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_누적_방전 / 1000 / 1000)
        End If
        If lbBatteryDischarge_Total.Text <> szValue Then
            lbBatteryDischarge_Total.Text = szValue
        End If


        If 배터리_당일_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_당일_충전)
        ElseIf 배터리_당일_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_당일_충전 / 1000)
        ElseIf 배터리_당일_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_당일_충전 / 1000 / 1000)
        End If
        If lbBatteryCharge_Today.Text <> szValue Then
            lbBatteryCharge_Today.Text = szValue
        End If

        If 배터리_어제_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_어제_충전)
        ElseIf 배터리_당일_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_어제_충전 / 1000)
        ElseIf 배터리_당일_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_어제_충전 / 1000 / 1000)
        End If
        If lbBatteryCharge_Yesterday.Text <> szValue Then
            lbBatteryCharge_Yesterday.Text = szValue
        End If

        If 배터리_누적_충전 < 1000 Then
            szValue = String.Format("{0:F1} kWh   ", 배터리_누적_충전)
        ElseIf 배터리_당일_충전 < 1000 * 1000 Then
            szValue = String.Format("{0:F1} mWh   ", 배터리_누적_충전 / 1000)
        ElseIf 배터리_당일_충전 < 1000 * 1000 * 1000 Then
            szValue = String.Format("{0:F1} gWh   ", 배터리_누적_충전 / 1000 / 1000)
        End If
        If lbBatteryCharge_Total.Text <> szValue Then
            lbBatteryCharge_Total.Text = szValue
        End If

        lSOC.Text = String.Format("{0:F1} %   ", cBMS.Bank_SOC)
        lSOH.Text = String.Format("{0:F1} %   ", cBMS.Bank_SOH)

        lPower.Text = String.Format("{0:F1} %   ", cBMS.Bank_충방전_전력)

        lVoltage.Text = String.Format("{0:F1} V   ", cBMS.Bank_DC전압)
        lCurrent.Text = String.Format("{0:F1} A   ", cBMS.Bank_DC전류)

        l랙SOC.Text = String.Format("{0:F1} %   ", cBMS_Rack(num_Rack).Rack_SOC)
        l랙SOH.Text = String.Format("{0:F1} %   ", cBMS_Rack(num_Rack).Rack_SOH)
        l랙전압.Text = String.Format("{0:F1} V   ", cBMS_Rack(num_Rack).Rack_Voltage)
        l랙전류.Text = String.Format("{0:F1} A   ", cBMS_Rack(num_Rack).Rack_Current)
        lCell최대전압.Text = String.Format("{0:F1} V   ", cBMS_Rack(num_Rack).Max_Cell_Voltage)
        lCell최대전압위치.Text = String.Format("{0:F0} V   ", cBMS_Rack(num_Rack).Max_Cell_Voltage_Position)
        lCell최소전압.Text = String.Format("{0:F1} V   ", cBMS_Rack(num_Rack).Min_Cell_Voltage)
        lCell최소전압위치.Text = String.Format("{0:F0} V   ", cBMS_Rack(num_Rack).Min_Cell_Voltage_Position)
        lCell전압편차.Text = String.Format("{0:F1} V   ", cBMS_Rack(num_Rack).Cell_Voltage_Gap)
        lCell평균전압.Text = String.Format("{0:F1} V   ", cBMS_Rack(num_Rack).Rack_Average_Cell_Voltage)
        lCell최대온도.Text = String.Format("{0:F1} C   ", cBMS_Rack(num_Rack).Max_Cell_Temperature)
        lCell최대온도위치.Text = String.Format("{0:F0}   ", cBMS_Rack(num_Rack).Max_Cell_Temperature_Position)
        lCell최소온도.Text = String.Format("{0:F1} C   ", cBMS_Rack(num_Rack).Min_Cell_Temperature)
        lCell최소온도위치.Text = String.Format("{0:F0}   ", cBMS_Rack(num_Rack).Min_Cell_Temperature_Position)
        lCell온도편차.Text = String.Format("{0:F0}   ", cBMS_Rack(num_Rack).Cell_Temperature_Gap)
        l랙평균모듈온도.Text = String.Format("{0:F0}   ", cBMS_Rack(num_Rack).Rack_Average_Module_Temperature)
        '
        '        l모듈전압.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Module_DC_Voltage
        '        l모듈내Cell최대전압.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Max_Cell_Voltage
        '        l모듈내Cell최저전압.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Min_Cell_Voltage
        '        l모듈내Cell평균전압.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Averge_Cell_Voltage
        '        l최고최저셀전압위치.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Max_Min_Cell_Voltage_Location
        '        l모듈평균온도.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Average_Module_Temperature
        '        l모듈최고온도.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Max_Module_Temperature
        '        l모듈최저온도.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Min_Module_Temeperature
        '        l모듈최고최저온도위치.Text = BMS.Rack(num_Rack).BMS_Module(num_Module).Max_Min_Module_Temperature_Location
    End Sub


    Private Sub PageHeader1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Click
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

        num_Rack = 0

        btn_Module.Visible = False

        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False

    End Sub

    Private Sub PageHeader2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader2.Click
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

        num_Rack = 1

        btn_Module.Visible = True

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub PageHeader3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader3.Click
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

        num_Rack = 2
        btn_Module.Visible = True


        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub


    Private Sub PageHeader4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader4.Click
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

        num_Rack = 3
        btn_Module.Visible = True


        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False



    End Sub

    Private Sub btn_Module_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module.Click

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
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


    Private Sub btn_Module_clear()

        btn_Module1.BackColor = Color.WhiteSmoke
        btn_Module1.Enabled = True
        btn_Module1.Invalidate()


        btn_Module2.BackColor = Color.WhiteSmoke
        btn_Module2.Enabled = True
        btn_Module2.Invalidate()

        btn_Module3.BackColor = Color.WhiteSmoke
        btn_Module3.Enabled = True
        btn_Module3.Invalidate()

        btn_Module4.BackColor = Color.WhiteSmoke
        btn_Module4.Enabled = True
        btn_Module4.Invalidate()

        btn_Module5.BackColor = Color.WhiteSmoke
        btn_Module5.Enabled = True
        btn_Module5.Invalidate()

        btn_Module6.BackColor = Color.WhiteSmoke
        btn_Module6.Enabled = True
        btn_Module6.Invalidate()

        btn_Module7.BackColor = Color.WhiteSmoke
        btn_Module7.Enabled = True
        btn_Module7.Invalidate()

        btn_Module8.BackColor = Color.WhiteSmoke
        btn_Module8.Enabled = True
        btn_Module8.Invalidate()

        btn_Module9.BackColor = Color.WhiteSmoke
        btn_Module9.Enabled = True
        btn_Module9.Invalidate()

        btn_Module10.BackColor = Color.WhiteSmoke
        btn_Module10.Enabled = True
        btn_Module10.Invalidate()

        btn_Module11.BackColor = Color.WhiteSmoke
        btn_Module11.Enabled = True
        btn_Module11.Invalidate()

        btn_Module12.BackColor = Color.WhiteSmoke
        btn_Module12.Enabled = True
        btn_Module12.Invalidate()

        btn_Module13.BackColor = Color.WhiteSmoke
        btn_Module13.Enabled = True
        btn_Module13.Invalidate()

        btn_Module14.BackColor = Color.WhiteSmoke
        btn_Module14.Enabled = True
        btn_Module14.Invalidate()

        btn_Module15.BackColor = Color.WhiteSmoke
        btn_Module15.Enabled = True
        btn_Module15.Invalidate()

        btn_Module16.BackColor = Color.WhiteSmoke
        btn_Module16.Enabled = True
        btn_Module16.Invalidate()

        btn_Module17.BackColor = Color.WhiteSmoke
        btn_Module17.Enabled = True
        btn_Module17.Invalidate()
    End Sub

    Private Sub btn_Module1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module1.Click
        btn_Module_clear()
        btn_Module1.BackColor = Color.White
        btn_Module1.Enabled = False
        btn_Module1.Invalidate()

        num_Module = 1
    End Sub

    Private Sub btn_Module2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module2.Click
        btn_Module_clear()
        btn_Module2.BackColor = Color.White
        btn_Module2.Enabled = False
        btn_Module2.Invalidate()
        num_Module = 2
    End Sub

    Private Sub btn_Module3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module3.Click
        btn_Module_clear()
        btn_Module3.BackColor = Color.White
        btn_Module3.Enabled = False
        btn_Module3.Invalidate()
        num_Module = 3
    End Sub

    Private Sub btn_Module4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module4.Click
        btn_Module_clear()
        btn_Module4.BackColor = Color.White
        btn_Module4.Enabled = False
        btn_Module4.Invalidate()
        num_Module = 4
    End Sub

    Private Sub btn_Module5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module5.Click
        btn_Module_clear()
        btn_Module5.BackColor = Color.White
        btn_Module5.Enabled = False
        btn_Module5.Invalidate()
        num_Module = 5
    End Sub

    Private Sub btn_Module6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module6.Click
        btn_Module_clear()
        btn_Module6.BackColor = Color.White
        btn_Module6.Enabled = False
        btn_Module6.Invalidate()
        num_Module = 6
    End Sub

    Private Sub btn_Module7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module7.Click
        btn_Module_clear()
        btn_Module7.BackColor = Color.White
        btn_Module7.Enabled = False
        btn_Module7.Invalidate()
        num_Module = 7
    End Sub

    Private Sub btn_Module8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module8.Click
        btn_Module_clear()
        btn_Module8.BackColor = Color.White
        btn_Module8.Enabled = False
        btn_Module8.Invalidate()
        num_Module = 8
    End Sub

    Private Sub btn_Module9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module9.Click
        btn_Module_clear()
        btn_Module9.BackColor = Color.White
        btn_Module9.Enabled = False
        btn_Module9.Invalidate()
        num_Module = 9
    End Sub

    Private Sub btn_Module10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module10.Click
        btn_Module_clear()
        btn_Module10.BackColor = Color.White
        btn_Module10.Enabled = False
        btn_Module10.Invalidate()
        num_Module = 10
    End Sub

    Private Sub btn_Module11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module11.Click
        btn_Module_clear()
        btn_Module11.BackColor = Color.White
        btn_Module11.Enabled = False
        btn_Module11.Invalidate()
        num_Module = 11
    End Sub

    Private Sub btn_Module12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module12.Click
        btn_Module_clear()
        btn_Module12.BackColor = Color.White
        btn_Module12.Enabled = False
        btn_Module12.Invalidate()
        num_Module = 12
    End Sub

    Private Sub btn_Module13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module13.Click
        btn_Module_clear()
        btn_Module13.BackColor = Color.White
        btn_Module13.Enabled = False
        btn_Module13.Invalidate()
        num_Module = 13
    End Sub

    Private Sub btn_Module14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module14.Click
        btn_Module_clear()
        btn_Module14.BackColor = Color.White
        btn_Module14.Enabled = False
        btn_Module14.Invalidate()
        num_Module = 14
    End Sub

    Private Sub btn_Module15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module15.Click
        btn_Module_clear()
        btn_Module15.BackColor = Color.White
        btn_Module15.Enabled = False
        btn_Module15.Invalidate()
        num_Module = 15
    End Sub

    Private Sub btn_Module16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module16.Click
        btn_Module_clear()
        btn_Module16.BackColor = Color.White
        btn_Module16.Enabled = False
        btn_Module16.Invalidate()
        num_Module = 16
    End Sub

    Private Sub btn_Module17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Module17.Click
        btn_Module_clear()
        btn_Module17.BackColor = Color.White
        btn_Module17.Enabled = False
        btn_Module17.Invalidate()
        num_Module = 17
    End Sub



    Private Sub btn_None_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_None.Click
        현재BSC상태 = BSC상태.Normal

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        현재BSC상태 = BSC상태.Contactor_Close
    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click
        현재BSC상태 = BSC상태.Contactor_Open1
    End Sub
End Class

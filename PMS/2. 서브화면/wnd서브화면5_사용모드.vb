Public Class wnd서브화면5_사용모드

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

        pnlScreen1.BackColor = Color.White
        pnlScreen2.BackColor = Color.White
        pnlScreen3.BackColor = Color.White
        pnlScreen4.BackColor = Color.White

        pnlScreen1.Left = Panel1.Left + 1
        pnlScreen1.Top = Panel1.Top + 1
        pnlScreen1.Width = Panel1.Width - 2
        pnlScreen1.Height = Panel1.Height - 2

        pnlScreen2.Left = Panel1.Left + 1
        pnlScreen2.Top = Panel1.Top + 1
        pnlScreen2.Width = Panel1.Width - 2
        pnlScreen2.Height = Panel1.Height - 2

        pnlScreen3.Left = Panel1.Left + 1
        pnlScreen3.Top = Panel1.Top + 1
        pnlScreen3.Width = Panel1.Width - 2
        pnlScreen3.Height = Panel1.Height - 2

        pnlScreen4.Left = Panel1.Left + 1
        pnlScreen4.Top = Panel1.Top + 1
        pnlScreen4.Width = Panel1.Width - 2
        pnlScreen4.Height = Panel1.Height - 2

    End Sub

    Public Sub 설정값불러오기()


        피크컷시간_설정값불러오기()

        lbGridActivePower.Text = String.Format("{0:N01}", d사용모드_유효전력)  ' 유효전력

        lb방전종료SOC.Text = String.Format("{0:N0}", d사용모드_배터리_방전정지SOC)  ' 배터리_방전정지SOC
        lb충전정지SOC.Text = String.Format("{0:N0}", d사용모드_배터리_충전정지SOC)  ' 배터리_충전정지SOC
        lb피크컷시작전력.Text = String.Format("{0:N1}", d사용모드_피크컷시작전력)  ' 피크컷시작전력
        lb충전시작SOC.Text = String.Format("{0:N1}", d사용모드_배터리_충전시작SOC)  ' 배터리_충전시작SOC
        lb방전시최대전류값.Text = String.Format("{0:N1}", d사용모드_방전시최대전류값) ' 방전시최대전류값
        lb충전시최대전류값.Text = String.Format("{0:N1}", d사용모드_충전시최대전류값)  ' 충전시최대전류값

    End Sub

    Public Sub 피크컷시간_설정값불러오기()


        lbTime1StartHour.Text = 사용모드_피크컷시간(1, 1).ToString("00")  ' 피크컷시간1 - 시작 시
        lbTime1StartMin.Text = 사용모드_피크컷시간(1, 2).ToString("00")  ' 피크컷시간1 - 시작 분
        lbTime1EndHour.Text = 사용모드_피크컷시간(1, 3).ToString("00")  ' 피크컷시간1 - 종료 시
        lbTime1EndMin.Text = 사용모드_피크컷시간(1, 4).ToString("00")  ' 피크컷시간1 - 종료 분

        lbTime2StartHour.Text = 사용모드_피크컷시간(2, 1).ToString("00")  ' 피크컷시간2 - 시작 시
        lbTime2StartMin.Text = 사용모드_피크컷시간(2, 2).ToString("00")  ' 피크컷시간2 - 시작 분
        lbTime2EndHour.Text = 사용모드_피크컷시간(2, 3).ToString("00")  ' 피크컷시간2 - 종료 시
        lbTime2EndMin.Text = 사용모드_피크컷시간(2, 4).ToString("00")  ' 피크컷시간2 - 종료 분


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim pObj As Panel = sender

        Dim pPen As New Pen(Color.Gray, 1)

        e.Graphics.DrawLine(pPen, 0, 0, 0, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, pObj.Width - 1, 0, pObj.Width - 1, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, 0, pObj.Height - 1, pObj.Width - 1, pObj.Height - 1)

        e.Graphics.DrawLine(pPen, PageHeader4.Left + PageHeader4.Width - PageHeader1.Left, 0, pObj.Width - 1, 0)


    End Sub


    Private Sub PageHeader1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Click

        PageHeader1.BorderSide_Bottom = False
        PageHeader1.BackColor = Color.White
        PageHeader1.Enabled = False
        PageHeader1.Invalidate()


        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        pnlScreen1.Visible = True
        pnlScreen2.Visible = False
        pnlScreen3.Visible = False
        pnlScreen4.Visible = False

    End Sub

    Private Sub PageHeader2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        pnlScreen1.Visible = False
        pnlScreen2.Visible = True
        pnlScreen3.Visible = False
        pnlScreen4.Visible = False

    End Sub

    Private Sub PageHeader3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        pnlScreen1.Visible = False
        pnlScreen2.Visible = False
        pnlScreen3.Visible = True
        pnlScreen4.Visible = False

    End Sub

    Private Sub PageHeader4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader4.Click

        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader4.BorderSide_Bottom = False
        PageHeader4.BackColor = Color.White
        PageHeader4.Enabled = False
        PageHeader4.Invalidate()

        pnlScreen1.Visible = False
        pnlScreen2.Visible = False
        pnlScreen3.Visible = False
        pnlScreen4.Visible = True

    End Sub

    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick
        타이머_상태.Enabled = False

        If Me.Visible = True Then
            상태표시()
        End If

        타이머_상태.Enabled = True
    End Sub

    Private nCurrentGridActivePower As Integer = -1
    Private nCurrentGridReactivePower As Integer = -1
    Private Sub 상태표시()

        Dim temp_CurrentGridActivePower As Double

        ' 유효전력
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        Dim pArray As New BitArray(System.BitConverter.GetBytes(ushValue))

        temp_CurrentGridActivePower = GetModbusData_Ushort(PT_Grid_Active_Power) * 0.1
        lbCurrentGridActivePower.Text = String.Format("{0:F1}", temp_CurrentGridActivePower)

        ' 충전중, 방전중 상태 표시
        Dim nCharging As Integer = ushValue >> 6 And &H1
        Dim nDischarging As Integer = ushValue >> 7 And &H1

        If nCharging = 1 Then
            lbRunMode.Visible = True
            lbRunMode.Text = "배터리 충전시간"
        ElseIf nDischarging = 1 Then
            lbRunMode.Visible = True
            lbRunMode.Text = "배터리 방전시간"
        Else
            lbRunMode.Visible = False
        End If

    End Sub

    Private Sub VsPictureButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatteryCharging.Click

        If MsgBox("배터리 충/방전 설정을 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "배터리 설정 변경") = MsgBoxResult.Yes Then

            d사용모드_배터리_방전정지SOC = Val(lb방전종료SOC.Text)
            d사용모드_배터리_충전정지SOC = Val(lb충전정지SOC.Text)
            d사용모드_피크컷시작전력 = Val(lb피크컷시작전력.Text)
            d사용모드_배터리_충전시작SOC = Val(lb충전시작SOC.Text)
            d사용모드_배터리_충전시최대전류 = Val(lb방전시최대전류값.Text)
            d사용모드_배터리_방전시최대전류 = Val(lb충전시최대전류값.Text)
            d사용모드_방전시최대전류값 = Val(lb방전시최대전류값.Text)
            d사용모드_충전시최대전류값 = Val(lb충전시최대전류값.Text)

            Dim pINI As New IniFile(CONFIG_FILE)
            pINI.SetKeyValue("사용모드", "배터리방전중지SOC", d사용모드_배터리_방전정지SOC.ToString)
            pINI.SetKeyValue("사용모드", "배터리충전중지SOC", d사용모드_배터리_충전정지SOC.ToString)
            pINI.SetKeyValue("사용모드", "피크컷시작전력", d사용모드_피크컷시작전력.ToString)
            pINI.SetKeyValue("사용모드", "배터리충전정지전압", d사용모드_배터리_충전시작SOC.ToString)
            pINI.SetKeyValue("사용모드", "방전시최대전류값", d사용모드_방전시최대전류값.ToString)
            pINI.SetKeyValue("사용모드", "충전시최대전류값", d사용모드_충전시최대전류값.ToString)

            pINI.Save(CONFIG_FILE)
        End If

    End Sub

    Private Sub get_Mode(ByVal FILE)

        ' 피크컷 정보 설정
        ReDim 사용모드_피크컷시간(2, 4)

        If System.IO.File.Exists(FILE) = True Then
            Dim pINI As New IniFile(FILE)

            d사용모드_로드파워 = Val(pINI.GetKeyValue("사용모드", "로드파워") & "")
            d사용모드_피크컷 = Val(pINI.GetKeyValue("사용모드", "피크컷") & "")

            사용모드_피크컷시간(1, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작시") & "")  ' 피크컷시간1 - 시작 시
            사용모드_피크컷시간(1, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작분") & "")  ' 피크컷시간1 - 시작 분
            사용모드_피크컷시간(1, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료시") & "")  ' 피크컷시간1 - 종료 시
            사용모드_피크컷시간(1, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료분") & "")  ' 피크컷시간1 - 종료 분

            사용모드_피크컷시간(2, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작시") & "")  ' 피크컷시간2 - 시작 시
            사용모드_피크컷시간(2, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작분") & "")  ' 피크컷시간2 - 시작 분
            사용모드_피크컷시간(2, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료시") & "")  ' 피크컷시간2 - 종료 시
            사용모드_피크컷시간(2, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료분") & "")  ' 피크컷시간2 - 종료 분
        End If
    End Sub

    Private Sub btnTimeSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeakCutSet.Click

        If MsgBox("충/방전 시간 및 전력값을 설정을 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then

            Dim szTime1Start As String = String.Format("{0}:{1}", Val(lbTime1StartHour.Text).ToString("00"), Val(lbTime1StartMin.Text).ToString("00"))
            Dim szTime1End As String = String.Format("{0}:{1}", Val(lbTime1EndHour.Text).ToString("00"), Val(lbTime1EndMin.Text).ToString("00"))
            Dim szTime2Start As String = String.Format("{0}:{1}", Val(lbTime2StartHour.Text).ToString("00"), Val(lbTime2StartMin.Text).ToString("00"))
            Dim szTime2End As String = String.Format("{0}:{1}", Val(lbTime2EndHour.Text).ToString("00"), Val(lbTime2EndMin.Text).ToString("00"))

            Dim szCurrent As String = Format(Now, "HH:mm")

            사용모드_피크컷시간(1, 1) = Val(lbTime1StartHour.Text)  ' 피크컷시간1 - 시작 시
            사용모드_피크컷시간(1, 2) = Val(lbTime1StartMin.Text)  ' 피크컷시간1 - 시작 분
            사용모드_피크컷시간(1, 3) = Val(lbTime1EndHour.Text)  ' 피크컷시간1 - 종료 시
            사용모드_피크컷시간(1, 4) = Val(lbTime1EndMin.Text)  ' 피크컷시간1 - 종료 분

            사용모드_피크컷시간(2, 1) = Val(lbTime2StartHour.Text)  ' 피크컷시간2 - 시작 시
            사용모드_피크컷시간(2, 2) = Val(lbTime2StartMin.Text)  ' 피크컷시간2 - 시작 분
            사용모드_피크컷시간(2, 3) = Val(lbTime2EndHour.Text)  ' 피크컷시간2 - 종료 시
            사용모드_피크컷시간(2, 4) = Val(lbTime2EndMin.Text)  ' 피크컷시간2 - 종료 분
            d사용모드_유효전력 = Val(lbGridActivePower.Text)
            'TODO: Remote 모드가 아닐 경우에만 값을 쓴다.
            If 현재사용모드_리모트모드 = False Then
                제어대기열_추가(PT_Power_Active_Set, Val(lbGridActivePower.Text) * 10)
            End If

            Dim pINI As New IniFile(CONFIG_FILE)

            pINI.SetKeyValue("사용모드", "피크컷시간1_시작시", 사용모드_피크컷시간(1, 1).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_시작분", 사용모드_피크컷시간(1, 2).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_종료시", 사용모드_피크컷시간(1, 3).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_종료분", 사용모드_피크컷시간(1, 4).ToString("00"))

            pINI.SetKeyValue("사용모드", "피크컷시간2_시작시", 사용모드_피크컷시간(2, 1).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_시작분", 사용모드_피크컷시간(2, 2).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_종료시", 사용모드_피크컷시간(2, 3).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_종료분", 사용모드_피크컷시간(2, 4).ToString("00"))
            pINI.SetKeyValue("사용모드", "유효전력", d사용모드_유효전력.ToString())
            pINI.Save(CONFIG_FILE)
            'End If

        End If
    End Sub

    Private Sub vs직접입력모드_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

        If ushValue >> 4 And &H1 Then
            INV_Control_Mode_제어대기열_추가(4, 0)
        Else
            INV_Control_Mode_제어대기열_추가(4, 1)
        End If
    End Sub
End Class

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

        lbTime1StartHour.Text = 사용모드_피크컷시간(1, 1).ToString("00")  ' 피크컷시간1 - 시작 시
        lbTime1StartMin.Text = 사용모드_피크컷시간(1, 2).ToString("00")  ' 피크컷시간1 - 시작 분
        lbTime1EndHour.Text = 사용모드_피크컷시간(1, 3).ToString("00")  ' 피크컷시간1 - 종료 시
        lbTime1EndMin.Text = 사용모드_피크컷시간(1, 4).ToString("00")  ' 피크컷시간1 - 종료 분

        lbTime2StartHour.Text = 사용모드_피크컷시간(2, 1).ToString("00")  ' 피크컷시간2 - 시작 시
        lbTime2StartMin.Text = 사용모드_피크컷시간(2, 2).ToString("00")  ' 피크컷시간2 - 시작 분
        lbTime2EndHour.Text = 사용모드_피크컷시간(2, 3).ToString("00")  ' 피크컷시간2 - 종료 시
        lbTime2EndMin.Text = 사용모드_피크컷시간(2, 4).ToString("00")  ' 피크컷시간2 - 종료 분

        lbGridActivePower.Text = String.Format("{0:N0}", d사용모드_유효전력)  ' 유효전력
        lbGridReactivePower.Text = String.Format("{0:N01}", d사용모드_무효전력)  ' 무효전력

        lbBatteryFD.Text = String.Format("{0:N0}", d사용모드_배터리_방전정지SOC)  ' 방전 중지
        lbBatteryCS.Text = String.Format("{0:N0}", d사용모드_배터리_충전정지SOC)  ' 충전 시작
        lb방전정지전압.Text = String.Format("{0:N1}", d사용모드_배터리_방전정지전압)  ' 방전 중지
        lb충전정지전압.Text = String.Format("{0:N1}", d사용모드_배터리_충전정지전압)  ' 충전 시작
        lbBatteryCC.Text = String.Format("{0:N1}", d사용모드_배터리_충전시최대전류) ' 충전 전류
        lbBatteryCV.Text = String.Format("{0:N1}", d사용모드_배터리_방전시최대전류)  ' 충전 전압

        'Test
        VsLabel17.Text = cBMS.Bank_DC전압.ToString
        'VsLabel23.Text = cBMS.Bank_SOC.ToString

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
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)
        Dim pArray As New BitArray(System.BitConverter.GetBytes(ushValue))


        temp_CurrentGridActivePower = GetModbusData_Ushort(PT_Grid_Active_Power) * 0.1
        lbCurrentGridActivePower.Text = Format(temp_CurrentGridActivePower, "0.0")

        ' 유효전력
        Dim dPower As Double = Val(lbGridActivePower.Text & "") * 10
        If Not (GetModbusData_Ushort(PT_Grid_Active_Power) = dPower) Then

            If dPower > 0 Then
                '         제어대기열_추가(PT_Grid_Active_Power, dPower)
            End If
        End If

        ' 충전중, 방전중 상태 표시

        Dim nCharging As Integer = ushValue >> 4 And &H1
        Dim nDischarging As Integer = ushValue >> 5 And &H1

        If nCharging = 1 Then
            lbStatusCharging.Text = "충전중"
        Else
            lbStatusCharging.Text = "충전중X"
        End If

        If nDischarging = 1 Then
            lbStatusDisCharging.Text = "방전중"
        Else
            lbStatusDisCharging.Text = "방전중X"
        End If

    End Sub


    Private Sub btnPeakCutSet_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeakCutSet.Click
        ' 피크컷 설정

        If MsgBox("충/방전 설정을 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "피크컷 설정") = MsgBoxResult.Yes Then

            Dim szTime1Start As String = String.Format("{0}:{1}", Val(lbTime1StartHour.Text).ToString("00"), Val(lbTime1StartMin.Text).ToString("00"))
            Dim szTime1End As String = String.Format("{0}:{1}", Val(lbTime1EndHour.Text).ToString("00"), Val(lbTime1EndMin.Text).ToString("00"))
            Dim szTime2Start As String = String.Format("{0}:{1}", Val(lbTime2StartHour.Text).ToString("00"), Val(lbTime2StartMin.Text).ToString("00"))
            Dim szTime2End As String = String.Format("{0}:{1}", Val(lbTime2EndHour.Text).ToString("00"), Val(lbTime2EndMin.Text).ToString("00"))

            If szTime1Start > szTime1End Then
                MsgBox("시간설정1의 종료시간이 시작시간 이전입니다. 다시 설정하여 주십시오.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If szTime2Start > szTime2End Then
                MsgBox("시간설정2의 종료시간이 시작시간 이전입니다. 다시 설정하여 주십시오.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If szTime1Start < szTime2Start And szTime2Start < szTime1End Then
                MsgBox("시간설정2의 시작시간이 시간설정1의 시간과 겹칩니다. 다시 설정하여 주십시오.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If szTime1Start < szTime2End And szTime2End < szTime1End Then
                MsgBox("시간설정2의 종료시간이 시간설정1의 시간과 겹칩니다. 다시 설정하여 주십시오.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If


            사용모드_피크컷시간(1, 1) = Val(lbTime1StartHour.Text)  ' 피크컷시간1 - 시작 시
            사용모드_피크컷시간(1, 2) = Val(lbTime1StartMin.Text)  ' 피크컷시간1 - 시작 분
            사용모드_피크컷시간(1, 3) = Val(lbTime1EndHour.Text)  ' 피크컷시간1 - 종료 시
            사용모드_피크컷시간(1, 4) = Val(lbTime1EndMin.Text)  ' 피크컷시간1 - 종료 분

            사용모드_피크컷시간(2, 1) = Val(lbTime2StartHour.Text)  ' 피크컷시간2 - 시작 시
            사용모드_피크컷시간(2, 2) = Val(lbTime2StartMin.Text)  ' 피크컷시간2 - 시작 분
            사용모드_피크컷시간(2, 3) = Val(lbTime2EndHour.Text)  ' 피크컷시간2 - 종료 시
            사용모드_피크컷시간(2, 4) = Val(lbTime2EndMin.Text)  ' 피크컷시간2 - 종료 분

            d사용모드_유효전력 = Val(lbGridActivePower.Text)

            Dim pINI As New IniFile(CONFIG_FILE)

            pINI.SetKeyValue("사용모드", "로드파워", d사용모드_로드파워.ToString)
            pINI.SetKeyValue("사용모드", "피크컷", d사용모드_피크컷.ToString)

            pINI.SetKeyValue("사용모드", "피크컷시간1_시작시", 사용모드_피크컷시간(1, 1).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_시작분", 사용모드_피크컷시간(1, 2).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_종료시", 사용모드_피크컷시간(1, 3).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간1_종료분", 사용모드_피크컷시간(1, 4).ToString("00"))

            pINI.SetKeyValue("사용모드", "피크컷시간2_시작시", 사용모드_피크컷시간(2, 1).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_시작분", 사용모드_피크컷시간(2, 2).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_종료시", 사용모드_피크컷시간(2, 3).ToString("00"))
            pINI.SetKeyValue("사용모드", "피크컷시간2_종료분", 사용모드_피크컷시간(2, 4).ToString("00"))


            pINI.SetKeyValue("사용모드", "유효전력", d사용모드_유효전력.ToString)
            pINI.Save(CONFIG_FILE)

        End If

    End Sub

    Private Sub btnGridActivePower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim szTime1Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 1).ToString("00"), 사용모드_피크컷시간(1, 2).ToString("00"))
        Dim szTime1End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 3).ToString("00"), 사용모드_피크컷시간(1, 4).ToString("00"))
        Dim szTime2Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 1).ToString("00"), 사용모드_피크컷시간(2, 2).ToString("00"))
        Dim szTime2End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 3).ToString("00"), 사용모드_피크컷시간(2, 4).ToString("00"))

        Dim szCurrent As String = Format(Now, "HH:mm")
        Dim bPeakCutTime As Boolean = False
        If szTime1Start <= szCurrent And szCurrent < szTime1End Then
            bPeakCutTime = True
        ElseIf szTime2Start <= szCurrent And szCurrent < szTime2End Then
            bPeakCutTime = True
        End If

        If bPeakCutTime = True Then
            MsgBox("피크컷 동작 시작에는 설정을 변경 할 수 없습니다.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "알림")
        Else


        End If
    End Sub

    Private Sub btnGridReactivePower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridReactivePower.Click
        Dim szTime1Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 1).ToString("00"), 사용모드_피크컷시간(1, 2).ToString("00"))
        Dim szTime1End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 3).ToString("00"), 사용모드_피크컷시간(1, 4).ToString("00"))
        Dim szTime2Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 1).ToString("00"), 사용모드_피크컷시간(2, 2).ToString("00"))
        Dim szTime2End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 3).ToString("00"), 사용모드_피크컷시간(2, 4).ToString("00"))

        Dim szCurrent As String = Format(Now, "HH:mm")
        Dim bPeakCutTime As Boolean = False
        If szTime1Start <= szCurrent And szCurrent < szTime1End Then
            bPeakCutTime = True
        ElseIf szTime2Start <= szCurrent And szCurrent < szTime2End Then
            bPeakCutTime = True
        End If

        If bPeakCutTime = True Then
            MsgBox("피크컷 동작 시작에는 설정을 변경 할 수 없습니다.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "알림")
        Else
            Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)

            If btnGridReactivePower.Selected = False Then
                If MsgBox("무효전력 모드로 동작하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "무효전력모드") = MsgBoxResult.Yes Then

                    Dim dPower As Double = Val(lbGridReactivePower.Text & "") * 10
                    If dPower > 0 Then
                        제어대기열_추가(PT_Grid_Reactive_Power, dPower)

                        ushValue = SetBitmask(ushValue, 8, 0)
                        ushValue = SetBitmask(ushValue, 9, 1)
                        제어대기열_추가(PT_MODE_Status, ushValue)

                        d사용모드_무효전력 = dPower
                        Dim pINI As New IniFile(CONFIG_FILE)
                        pINI.SetKeyValue("사용모드", "무효전력", d사용모드_무효전력.ToString)
                        pINI.Save(CONFIG_FILE)
                    Else
                        ushValue = SetBitmask(ushValue, 9, 0)
                        제어대기열_추가(PT_MODE_Status, ushValue)

                        제어대기열_추가(PT_Grid_Reactive_Power, 0)
                    End If

                End If
            Else
                If MsgBox("무효전력 모드 동작을 취소하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "무효전력모드") = MsgBoxResult.Yes Then
                    ushValue = SetBitmask(ushValue, 9, 0)
                    제어대기열_추가(PT_MODE_Status, ushValue)

                    제어대기열_추가(PT_Grid_Reactive_Power, 0)
                End If
            End If
        End If

    End Sub

    Private Sub VsPictureButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatteryCharging.Click

        If MsgBox("배터리 충/방전 설정을 변경하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "배터리 설정 변경") = MsgBoxResult.Yes Then

            d사용모드_배터리_방전정지SOC = Val(lbBatteryFD.Text)
            d사용모드_배터리_충전정지SOC = Val(lbBatteryCS.Text)
            d사용모드_배터리_방전정지전압 = Val(lb방전정지전압.Text)
            d사용모드_배터리_충전정지전압 = Val(lb충전정지전압.Text)
            d사용모드_배터리_충전시최대전류 = Val(lbBatteryCC.Text)
            d사용모드_배터리_방전시최대전류 = Val(lbBatteryCV.Text)

            Dim pINI As New IniFile(CONFIG_FILE)
            pINI.SetKeyValue("사용모드", "배터리방전중지SOC", d사용모드_배터리_방전정지SOC.ToString)
            pINI.SetKeyValue("사용모드", "배터리충전중지SOC", d사용모드_배터리_충전정지SOC.ToString)
            pINI.SetKeyValue("사용모드", "배터리방전정지전압", (d사용모드_배터리_방전정지전압) * 10).ToString()
            pINI.SetKeyValue("사용모드", "배터리충전정지전압", (d사용모드_배터리_충전정지전압) * 10).ToString()
            pINI.SetKeyValue("사용모드", "배터리충전전류", d사용모드_배터리_충전시최대전류.ToString)
            pINI.SetKeyValue("사용모드", "배터리충전전압", d사용모드_배터리_방전시최대전류.ToString)
            pINI.Save(CONFIG_FILE)

        End If

    End Sub


    Private Sub VsLabel17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsLabel17.TextChanged
        cBMS.Bank_DC전압 = Val(VsLabel17.Text)
    End Sub

    Private Sub VsLabel23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cBMS.Bank_SOC = Val(VsLabel23.Text)
    End Sub
End Class

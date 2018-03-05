Public Class wnd서브화면3_수요관리

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

        For nYear As Integer = 2016 To Now.Year
            cbMonth_Year.Items.Add(String.Format("{0}년", nYear))
            cbYear_Year.Items.Add(String.Format("{0}년", nYear))
        Next
        For nMonth As Integer = 1 To 12
            cbMonth_Month.Items.Add(String.Format("{0}월", nMonth.ToString("00")))
        Next
        cbMonth_Year.SelectedItem = String.Format("{0}년", Now.Year.ToString)
        cbMonth_Month.SelectedItem = String.Format("{0}월", Now.Month.ToString("00"))

        cbYear_Year.SelectedItem = String.Format("{0}년", Now.Year.ToString)

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

        pnlScreen1.Visible = True
        pnlScreen2.Visible = False
        pnlScreen3.Visible = False
        pnlScreen4.Visible = False

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

        pnlScreen1.Visible = False
        pnlScreen2.Visible = True
        pnlScreen3.Visible = False
        pnlScreen4.Visible = False

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

        pnlScreen1.Visible = False
        pnlScreen2.Visible = False
        pnlScreen3.Visible = False
        pnlScreen4.Visible = True

    End Sub

#Region "상태표시"
    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick

        타이머_상태.Enabled = False

        If Me.Visible = True Then
            상태표시()
        End If

        타이머_상태.Enabled = True

    End Sub

    Private 그리드상태 As Integer = -1

    Private Sub 상태표시()

        Dim szValue As String = "-"
        Dim nOldStatus As Integer = 그리드상태
        'Dim dGrid_In_Power As Double = GetModbusData_Ushort(PT_grid_in_Power) * 0.1
        'Dim dGrid_Out_Power As Double = GetModbusData_Ushort(PT_grid_out_Power) * 0.1

        'If dGrid_In_Power > 0 And dGrid_Out_Power <= 0 Then
        '그리드상태 = 1
        'szValue = String.Format("{0:F1} kW", dGrid_In_Power)
        'ElseIf dGrid_In_Power <= 0 And dGrid_Out_Power > 0 Then
        '그리드상태 = 2
        ' szValue = String.Format("{0:F1} kW", dGrid_Out_Power)
        'Else
        '그리드상태 = 0
        'szValue = ""
        'End If


        If cBMS.Bank_충방전_전력 > 0 Then
            그리드상태 = 1
        ElseIf cBMS.Bank_충방전_전력 < 0 Then
            그리드상태 = 2
        Else
            그리드상태 = 0

        End If
        Dim dPT_Inv_Power As Double = GetModbusData_Ushort(PT_Inv_Power) * 0.1
        'Dim dPT_Inv_Power As Double = cBMS.Bank_충방전_전력
        szValue = String.Format("{0:F1} kW", dPT_Inv_Power)
        If lbGridStatus.Text <> szValue Then
            lbGridStatus.Text = szValue
            lbGridStatus.Invalidate()

            lbPower2.Text = szValue
            lbPower2.Invalidate()
        End If

        If nOldStatus <> 그리드상태 Then
            Select Case 그리드상태
                Case 0
                    ' 중지
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Stop
                Case 1
                    ' 입력 전력
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Right
                Case 2
                    ' 출력 전력
                    ucScrollGridStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left
            End Select
        End If

        Dim dValue As Double = GetModbusData_Ushort(PT_V_Grid_R) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage1.Text <> szValue Then lbVoltage1.Text = szValue

        dValue = GetModbusData_Ushort(PT_V_Grid_S) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage2.Text <> szValue Then lbVoltage2.Text = szValue

        dValue = GetModbusData_Ushort(PT_V_Grid_T) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage3.Text <> szValue Then lbVoltage3.Text = szValue


        dValue = GetModbusData_Ushort(PT_I_Grid_R) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent1.Text <> szValue Then lbCurrent1.Text = szValue

        dValue = GetModbusData_Ushort(PT_I_Grid_S) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent2.Text <> szValue Then lbCurrent2.Text = szValue

        dValue = GetModbusData_Ushort(PT_I_Grid_T) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent3.Text <> szValue Then lbCurrent3.Text = szValue

        dValue = GetModbusData_Ushort(PT_Grid_Freq) * 0.01
        szValue = String.Format("{0:F1} Hz", dValue)
        If lbFrequency.Text <> szValue Then lbFrequency.Text = szValue

    End Sub

#End Region

#Region "일일 수요관리"

    Private dtDayReport_Date As Date = Now
    Private nDayReport_MousePosX As Integer = 0
    Private nDayReport_MousePosY As Integer = 0

    Private Sub btnSearch_Day_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch_Day.Click
        nDayReport_MousePosX = 0
        nDayReport_MousePosY = 0

        dtDayReport_Date = DateTimePicker1.Value
        ReadHistoryDay()

        pnlGraphDay.Invalidate()
    End Sub

    Private Sub pnlGraphDay_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlGraphDay.MouseDown
        Debug.WriteLine(String.Format("{0} - {1}", MousePosition.X, MousePosition.Y))

        nDayReport_MousePosX = MousePosition.X - pnlGraphDay.Left
        nDayReport_MousePosY = MousePosition.Y - pnlGraphDay.Top
        pnlGraphDay.Invalidate()

    End Sub

    Private Sub pnlGraphDay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlGraphDay.Paint
        DrawGraph_Day(e.Graphics)
    End Sub

    Private Sub DrawGraph_Day(ByRef pGraphic As Graphics)

        lbStatus_Day_Grid.Text = "그리드"
        lbStatus_Day_Inverter.Text = "인버터"
        lbStatus_Day_Load.Text = "로드"

        Dim nCtrlWidth As Integer = pnlGraphDay.Width
        Dim nCtrlHeight As Integer = pnlGraphDay.Height

        Dim nMaxYRange As Integer = 200
        Dim nRowCount As Integer = 10

        If nMaxValue_Day <> 0 Then nMaxYRange = CInt(CDbl(nMaxValue_Day) * 1.1)

        nMaxYRange = nMaxYRange \ 50
        nMaxYRange = (nMaxYRange + 1) * 50

        Dim nHGap As Integer = 50
        Dim nVGap1 As Integer = 10
        Dim nVGap2 As Integer = 30

        Dim nTempHeight As Integer = nCtrlHeight - (nVGap1 + nVGap2)
        Dim nRowHeight As Integer = nTempHeight / nRowCount
        nCtrlHeight = nRowHeight * nRowCount

        Dim nTempWidth As Integer = nCtrlWidth - nHGap * 2
        Dim nColWidth As Integer = nTempWidth / 24
        nCtrlWidth = nColWidth * 24


        Dim nRowMin As Double = CDbl(nRowHeight) / CDbl(nMaxYRange / nRowCount)

        Dim nGraphWidth As Integer = nColWidth
        Dim nCellWidth As Integer = (nGraphWidth / 4 * 3) / 3
        Dim nLeftGap = (nGraphWidth - nCellWidth * 3) / 2




        pGraphic.FillRectangle(New SolidBrush(Color.White), 0, 0, pnlGraphDay.Width, pnlGraphDay.Height)

        Dim pRectGraph As New Rectangle(nHGap, nVGap1, nCtrlWidth, nCtrlHeight)

        For i As Integer = 1 To nRowCount - 1
            pGraphic.DrawLine(New Pen(Color.DarkGray, 1), nHGap, nVGap1 + nRowHeight * i, nHGap + nCtrlWidth, nVGap1 + nRowHeight * i)
        Next
        pGraphic.DrawRectangle(New Pen(Color.Black, 2), pRectGraph)

        For i As Integer = 0 To nRowCount

            Dim szText As String = (nMaxYRange / nRowCount) * (nRowCount - i)


            Dim pRect As New Rectangle(0, nVGap1 + nRowHeight * i + nRowHeight / 2, nHGap - 10, nRowHeight)
            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            ptF.X = pRect.Width - ptSize.Width


            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)


            pRect = New Rectangle(0, 0, nHGap - 10, nRowHeight)

            ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            ptF.X = nHGap + 10 + nCtrlWidth

            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)

        Next

        For i As Integer = 0 To 23
            Dim szText As String = i.ToString

            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nCtrlHeight + 10
            ptF.X = nHGap + nColWidth * i + nColWidth / 2
            ptF.X -= ptSize.Width / 2

            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)
        Next

        Dim clrBar() As Color = {Color.Red, Color.Green, Color.Blue}

        Dim pFont2 As New Font("Tahoma", 8, FontStyle.Regular)


        For nHour As Integer = 0 To 23

            Dim bSelected As Boolean = False

            If nDayReport_MousePosX > 0 And nDayReport_MousePosY > 0 Then

                If nHGap + nColWidth * nHour < nDayReport_MousePosX And nDayReport_MousePosX < nHGap + nColWidth * (nHour + 1) Then
                    bSelected = True
                    pGraphic.FillRectangle(New SolidBrush(Color.Yellow), nHGap + nColWidth * nHour, nVGap1 + 1, nColWidth, nCtrlHeight - 1)
                End If

            End If

            Dim dValueArray() As Double = htHistoryData_Day(nHour)

            If dValueArray IsNot Nothing Then
                For nCell As Integer = 0 To 2
                    Dim dValue As Double = 0

                    If nCell = 0 Then
                        ' GridIn + GridOut
                        dValue = dValueArray(0) + dValueArray(1)
                    ElseIf nCell = 1 Then
                        ' Inverter
                        dValue = dValueArray(2)
                    ElseIf nCell = 2 Then
                        ' Load
                        dValue = dValueArray(3)
                    End If

                    Dim nBarHeight As Integer = dValue * nRowMin
                    If nBarHeight > nCtrlHeight Then nBarHeight = nCtrlHeight

                    Dim nLeft As Integer = (nHGap + nColWidth * nHour) + nCellWidth * nCell + nLeftGap
                    Dim nTop As Integer = nVGap1 + nCtrlHeight - nBarHeight

                    pGraphic.FillRectangle(New SolidBrush(clrBar(nCell)), nLeft, nTop, nCellWidth, nBarHeight)
                Next

                If bSelected = True Then
                    lbStatus_Day_Grid.Text = String.Format("그리드 - {0:F1}kWh", dValueArray(0) + dValueArray(1))
                    lbStatus_Day_Inverter.Text = String.Format("인버터 - {0:F1}kWh", dValueArray(2))
                    lbStatus_Day_Load.Text = String.Format("로드 - {0:F1}kWh", dValueArray(3))
                End If
            End If
        Next

    End Sub

    Private htHistoryData_Day As New Hashtable
    Private nMaxValue_Day As Integer = 0

    Private Sub ReadHistoryDay()
        nMaxValue_Day = 0
        htHistoryData_Day.Clear()

        Dim szPath As String = String.Format("\Flash Disk\Run\History\{0}", dtDayReport_Date.Year)
        Dim szHistoryFile As String = ""
        szHistoryFile = String.Format("{0}\H{1}-{2}-{3}.csv", szPath, dtDayReport_Date.Year.ToString("0000"), dtDayReport_Date.Month.ToString("00"), dtDayReport_Date.Day.ToString("00"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Time" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Time" Then
                        Else

                            Dim szTime As String = szItems(0)
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))


                            Dim nHour As Integer = Val(szTime)

                            Dim dValue(3) As Double
                            dValue(0) = dGridIn
                            dValue(1) = dGridOut
                            dValue(2) = dInverter
                            dValue(3) = dLoad

                            htHistoryData_Day(nHour) = dValue

                            If nMaxValue_Day < dValue(0) + dValue(1) Then nMaxValue_Day = dValue(0) + dValue(1)
                            If nMaxValue_Day < dValue(2) Then nMaxValue_Day = dValue(2)
                            If nMaxValue_Day < dValue(3) Then nMaxValue_Day = dValue(3)

                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If
    End Sub

#End Region

#Region "월간 수요관리"

    Private nMonthReport_Year As Integer = Now.Year
    Private nMonthReport_Month As Integer = Now.Month
    Private nMonthReport_MousePosX As Integer = 0
    Private nMonthReport_MousePosY As Integer = 0

    Private Sub btnSearch_Month_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch_Month.Click

        nMonthReport_Year = Val(cbMonth_Year.SelectedItem & "")
        nMonthReport_Month = Val(cbMonth_Month.SelectedItem & "")
        nMonthReport_MousePosX = 0
        nMonthReport_MousePosY = 0

        ReadHistoryMonth()

        pnlGraphMonth.Invalidate()
    End Sub

    Private Sub pnlGraphMonth_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlGraphMonth.MouseDown
        nMonthReport_MousePosX = MousePosition.X - pnlGraphMonth.Left
        nMonthReport_MousePosY = MousePosition.Y - pnlGraphMonth.Top
        pnlGraphMonth.Invalidate()
    End Sub

    Private Sub pnlGraphMonth_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlGraphMonth.Paint
        DrawGraph_Month(e.Graphics)
    End Sub

    Private Sub DrawGraph_Month(ByRef pGraphic As Graphics)
        lbStatus_Month_Grid.Text = "그리드"
        lbStatus_Month_Inverter.Text = "인버터"
        lbStatus_Month_Load.Text = "로드"

        Dim nColumnCount As Integer = DateTime.DaysInMonth(nMonthReport_Year, nMonthReport_Month)
        Dim nCtrlWidth As Integer = pnlGraphMonth.Width
        Dim nCtrlHeight As Integer = pnlGraphMonth.Height

        Dim nMaxYRange As Integer = 25000 ' 125 * 6 * 31
        Dim nRowCount As Integer = 10

        If nMaxValue_Month <> 0 Then
            nMaxYRange = CInt(CDbl(nMaxValue_Month) * 1.1)
        End If

        nMaxYRange = nMaxYRange \ 100
        nMaxYRange = (nMaxYRange + 1) * 100

        nMaxYRange = nMaxYRange / 1000



        Dim nHGap As Integer = 50
        Dim nVGap1 As Integer = 10
        Dim nVGap2 As Integer = 30

        Dim nTempHeight As Integer = nCtrlHeight - (nVGap1 + nVGap2)
        Dim nRowHeight As Integer = nTempHeight / nRowCount
        nCtrlHeight = nRowHeight * nRowCount

        Dim nTempWidth As Integer = nCtrlWidth - nHGap - nHGap / 2 '* 2
        Dim nColWidth As Integer = nTempWidth / nColumnCount
        nCtrlWidth = nColWidth * nColumnCount


        Dim nRowMin As Double = CDbl(nRowHeight) / CDbl(nMaxYRange / nRowCount)

        Dim nGraphWidth As Integer = nColWidth
        Dim nCellWidth As Integer = (nGraphWidth / 4 * 3) / 3
        Dim nLeftGap = (nGraphWidth - nCellWidth * 3) / 2



        pGraphic.FillRectangle(New SolidBrush(Color.White), 0, 0, pnlGraphMonth.Width, pnlGraphMonth.Height)

        Dim pRectGraph As New Rectangle(nHGap, nVGap1, nCtrlWidth, nCtrlHeight)

        For i As Integer = 1 To nRowCount - 1
            pGraphic.DrawLine(New Pen(Color.DarkGray, 1), nHGap, nVGap1 + nRowHeight * i, nHGap + nCtrlWidth, nVGap1 + nRowHeight * i)
        Next
        pGraphic.DrawRectangle(New Pen(Color.Black, 2), pRectGraph)

        For i As Integer = 0 To nRowCount

            Dim szText As String = String.Format("{0:N1}", (nMaxYRange / nRowCount) * (nRowCount - i))

            Dim pRect As New Rectangle(0, nVGap1 + nRowHeight * i + nRowHeight / 2, nHGap - 10, nRowHeight)
            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            ptF.X = pRect.Width - ptSize.Width


            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)


            'pRect = New Rectangle(0, 0, nHGap - 10, nRowHeight)

            'ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            'ptF.X = nHGap + 10 + nCtrlWidth

            'pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)

        Next


        For nDay As Integer = 1 To nColumnCount
            Dim szText As String = nDay.ToString

            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nCtrlHeight + 10
            ptF.X = nHGap + nColWidth * (nDay - 1) + nColWidth / 2
            ptF.X -= ptSize.Width / 2

            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)
        Next


        Dim clrBar() As Color = {Color.Red, Color.Green, Color.Blue}

        Dim pFont2 As New Font("Tahoma", 8, FontStyle.Regular)


        For nDay As Integer = 1 To nColumnCount

            Dim bSelected As Boolean = False

            If nMonthReport_MousePosX > 0 And nMonthReport_MousePosY > 0 Then

                If nHGap + nColWidth * (nDay - 1) < nMonthReport_MousePosX And nMonthReport_MousePosX < nHGap + nColWidth * nDay Then
                    bSelected = True
                    pGraphic.FillRectangle(New SolidBrush(Color.Yellow), nHGap + nColWidth * (nDay - 1), nVGap1 + 1, nColWidth, nCtrlHeight - 1)
                End If

            End If


            Dim dValueArray() As Double = htHistoryData_Month(nDay)

            If dValueArray IsNot Nothing Then


                For nCell As Integer = 0 To 2
                    Dim dValue As Double = 0

                    If nCell = 0 Then
                        ' GridIn + GridOut
                        dValue = dValueArray(0) + dValueArray(1)
                    ElseIf nCell = 1 Then
                        ' Inverter
                        dValue = dValueArray(2)
                    ElseIf nCell = 2 Then
                        ' Load
                        dValue = dValueArray(3)
                    End If

                    dValue = dValue / 1000

                    Dim nBarHeight As Integer = dValue * nRowMin
                    If nBarHeight > nCtrlHeight Then nBarHeight = nCtrlHeight

                    Dim nLeft As Integer = (nHGap + nColWidth * (nDay - 1)) + nCellWidth * nCell + nLeftGap
                    Dim nTop As Integer = nVGap1 + nCtrlHeight - nBarHeight

                    pGraphic.FillRectangle(New SolidBrush(clrBar(nCell)), nLeft, nTop, nCellWidth, nBarHeight)
                Next

                If bSelected = True Then

                    If dValueArray(0) + dValueArray(1) < 1000 Then
                        lbStatus_Month_Grid.Text = String.Format("그리드 - {0:F1}kWh", dValueArray(0) + dValueArray(1))
                    ElseIf dValueArray(0) + dValueArray(1) < 1000 * 1000 Then
                        lbStatus_Month_Grid.Text = String.Format("그리드 - {0:F1}mWh", (dValueArray(0) + dValueArray(1)) / 1000)
                    ElseIf dValueArray(0) + dValueArray(1) < 1000 * 1000 * 1000 Then
                        lbStatus_Month_Grid.Text = String.Format("그리드 - {0:F1}gWh", (dValueArray(0) + dValueArray(1)) / 1000 / 1000)
                    End If

                    If dValueArray(2) < 1000 Then
                        lbStatus_Month_Inverter.Text = String.Format("인버터 - {0:F1}kWh", dValueArray(2))
                    ElseIf dValueArray(2) < 1000 * 1000 Then
                        lbStatus_Month_Inverter.Text = String.Format("인버터 - {0:F1}mWh", dValueArray(2) / 1000)
                    ElseIf dValueArray(2) < 1000 * 1000 * 1000 Then
                        lbStatus_Month_Inverter.Text = String.Format("인버터 - {0:F1}gWh", dValueArray(2) / 1000 / 1000)
                    End If

                    If dValueArray(3) < 1000 Then
                        lbStatus_Month_Load.Text = String.Format("로드 - {0:F1}kWh", dValueArray(3))
                    ElseIf dValueArray(3) < 1000 * 1000 Then
                        lbStatus_Month_Load.Text = String.Format("로드 - {0:F1}mWh", dValueArray(3) / 1000)
                    ElseIf dValueArray(3) < 1000 * 1000 * 1000 Then
                        lbStatus_Month_Load.Text = String.Format("로드 - {0:F1}gWh", dValueArray(3) / 1000 / 1000)
                    End If

                End If
            End If

        Next

    End Sub

    Private htHistoryData_Month As New Hashtable
    Private nMaxValue_Month As Integer = 0

    Private Sub ReadHistoryMonth()

        nMaxValue_Month = 0
        htHistoryData_Month.Clear()



        Dim szPath As String = String.Format("\Flash Disk\Run\History\{0}", nMonthReport_Year)
        Dim szHistoryFile As String = ""
        szHistoryFile = String.Format("{0}\H{1}-{2}.csv", szPath, nMonthReport_Year.ToString("0000"), nMonthReport_Month.ToString("00"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Day" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Day" Then
                        Else

                            Dim szDay As String = szItems(0)
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))


                            Dim nDay As Integer = Val(szDay)

                            Dim dValue(3) As Double
                            dValue(0) = dGridIn
                            dValue(1) = dGridOut
                            dValue(2) = dInverter
                            dValue(3) = dLoad

                            htHistoryData_Month(nDay) = dValue

                            If nMaxValue_Month < dValue(0) + dValue(1) Then nMaxValue_Month = dValue(0) + dValue(1)
                            If nMaxValue_Month < dValue(2) Then nMaxValue_Month = dValue(2)
                            If nMaxValue_Month < dValue(3) Then nMaxValue_Month = dValue(3)
                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If
    End Sub

#End Region


#Region "연간 수요관리"

    Private nYearReport_Year As Integer = Now.Year
    Private nYearReport_MousePosX As Integer = 0
    Private nYearReport_MousePosY As Integer = 0

    Private Sub btnSearch_Year_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch_Year.Click

        nYearReport_Year = Val(cbYear_Year.SelectedItem & "")
        nYearReport_MousePosX = 0
        nYearReport_MousePosY = 0

        ReadHistoryYear()

        pnlGraphYear.Invalidate()
    End Sub

    Private Sub pnlGraphYear_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlGraphYear.MouseDown

        nYearReport_MousePosX = MousePosition.X - pnlGraphYear.Left
        nYearReport_MousePosY = MousePosition.Y - pnlGraphYear.Top
        pnlGraphYear.Invalidate()


    End Sub

    Private Sub pnlGraphYear_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlGraphYear.Paint
        DrawGraph_Year(e.Graphics)
    End Sub

    Private Sub DrawGraph_Year(ByRef pGraphic As Graphics)
        lbStatus_Year_Grid.Text = "그리드"
        lbStatus_Year_Inverter.Text = "인버터"
        lbStatus_Year_Load.Text = "로드"


        Dim nColumnCount As Integer = 12
        Dim nCtrlWidth As Integer = pnlGraphMonth.Width
        Dim nCtrlHeight As Integer = pnlGraphMonth.Height

        Dim nMaxYRange As Integer = 280000  ' 125 * 6 * 31*12
        Dim nRowCount As Integer = 10

        If nMaxValue_Year <> 0 Then
            nMaxYRange = CInt(CDbl(nMaxValue_Year) * 1.1)
        End If

        nMaxYRange = nMaxYRange \ 1000
        nMaxYRange = (nMaxYRange + 1) * 1000

        nMaxYRange = nMaxYRange / 10000



        Dim nHGap As Integer = 50
        Dim nVGap1 As Integer = 10
        Dim nVGap2 As Integer = 30

        Dim nTempHeight As Integer = nCtrlHeight - (nVGap1 + nVGap2)
        Dim nRowHeight As Integer = nTempHeight / nRowCount
        nCtrlHeight = nRowHeight * nRowCount

        Dim nTempWidth As Integer = nCtrlWidth - nHGap - nHGap / 2 '* 2
        Dim nColWidth As Integer = nTempWidth / nColumnCount
        nCtrlWidth = nColWidth * nColumnCount



        Dim nRowMin As Double = CDbl(nRowHeight) / CDbl(nMaxYRange / nRowCount)

        Dim nGraphWidth As Integer = nColWidth
        Dim nCellWidth As Integer = (nGraphWidth / 4 * 3) / 3
        Dim nLeftGap = (nGraphWidth - nCellWidth * 3) / 2


        pGraphic.FillRectangle(New SolidBrush(Color.White), 0, 0, pnlGraphMonth.Width, pnlGraphMonth.Height)

        Dim pRectGraph As New Rectangle(nHGap, nVGap1, nCtrlWidth, nCtrlHeight)

        For i As Integer = 1 To nRowCount - 1
            pGraphic.DrawLine(New Pen(Color.DarkGray, 1), nHGap, nVGap1 + nRowHeight * i, nHGap + nCtrlWidth, nVGap1 + nRowHeight * i)
        Next
        pGraphic.DrawRectangle(New Pen(Color.Black, 2), pRectGraph)

        For i As Integer = 0 To nRowCount

            Dim szText As String = String.Format("{0:N1}", (nMaxYRange / nRowCount) * (nRowCount - i))


            Dim pRect As New Rectangle(0, nVGap1 + nRowHeight * i + nRowHeight / 2, nHGap - 10, nRowHeight)
            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            ptF.X = pRect.Width - ptSize.Width


            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)


            'pRect = New Rectangle(0, 0, nHGap - 10, nRowHeight)

            'ptF.Y = nVGap1 + nRowHeight * i - ptSize.Height / 2
            'ptF.X = nHGap + 10 + nCtrlWidth

            'pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)

        Next


        For nMonth As Integer = 1 To nColumnCount
            Dim szText As String = nMonth.ToString

            Dim ptSize As SizeF = pGraphic.MeasureString(szText, Font)

            Dim ptF As New Point
            ptF.Y = nVGap1 + nCtrlHeight + 10
            ptF.X = nHGap + nColWidth * (nMonth - 1) + nColWidth / 2
            ptF.X -= ptSize.Width / 2

            pGraphic.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)
        Next





        Dim clrBar() As Color = {Color.Red, Color.Green, Color.Blue}

        Dim pFont2 As New Font("Tahoma", 8, FontStyle.Regular)


        For nMonth As Integer = 1 To nColumnCount

            Dim bSelected As Boolean = False

            If nYearReport_MousePosX > 0 And nYearReport_MousePosY > 0 Then

                If nHGap + nColWidth * (nMonth - 1) < nYearReport_MousePosX And nYearReport_MousePosX < nHGap + nColWidth * nMonth Then
                    bSelected = True
                    pGraphic.FillRectangle(New SolidBrush(Color.Yellow), nHGap + nColWidth * (nMonth - 1), nVGap1 + 1, nColWidth, nCtrlHeight - 1)
                End If

            End If


            Dim dValueArray() As Double = htHistoryData_Year(nMonth)

            If dValueArray IsNot Nothing Then
                For nCell As Integer = 0 To 2
                    Dim dValue As Double = 0

                    If nCell = 0 Then
                        ' GridIn + GridOut
                        dValue = dValueArray(0) + dValueArray(1)
                    ElseIf nCell = 1 Then
                        ' Inverter
                        dValue = dValueArray(2)
                    ElseIf nCell = 2 Then
                        ' Load
                        dValue = dValueArray(3)
                    End If

                    Dim nBarHeight As Integer = dValue * nRowMin
                    If nBarHeight > nCtrlHeight Then nBarHeight = nCtrlHeight

                    Dim nLeft As Integer = (nHGap + nColWidth * (nMonth - 1)) + nCellWidth * nCell + nLeftGap
                    Dim nTop As Integer = nVGap1 + nCtrlHeight - nBarHeight

                    pGraphic.FillRectangle(New SolidBrush(clrBar(nCell)), nLeft, nTop, nCellWidth, nBarHeight)
                Next

                If bSelected = True Then

                    If dValueArray(0) + dValueArray(1) < 1000 Then
                        lbStatus_Year_Grid.Text = String.Format("그리드 - {0:F1}kWh", dValueArray(0) + dValueArray(1))
                    ElseIf dValueArray(0) + dValueArray(1) < 1000 * 1000 Then
                        lbStatus_Year_Grid.Text = String.Format("그리드 - {0:F1}mWh", (dValueArray(0) + dValueArray(1)) / 1000)
                    ElseIf dValueArray(0) + dValueArray(1) < 1000 * 1000 * 1000 Then
                        lbStatus_Year_Grid.Text = String.Format("그리드 - {0:F1}gWh", (dValueArray(0) + dValueArray(1)) / 1000 / 1000)
                    End If

                    If dValueArray(2) < 1000 Then
                        lbStatus_Year_Inverter.Text = String.Format("인버터 - {0:F1}kWh", dValueArray(2))
                    ElseIf dValueArray(2) < 1000 * 1000 Then
                        lbStatus_Year_Inverter.Text = String.Format("인버터 - {0:F1}mWh", dValueArray(2) / 1000)
                    ElseIf dValueArray(2) < 1000 * 1000 * 1000 Then
                        lbStatus_Year_Inverter.Text = String.Format("인버터 - {0:F1}gWh", dValueArray(2) / 1000 / 1000)
                    End If

                    If dValueArray(3) < 1000 Then
                        lbStatus_Year_Load.Text = String.Format("로드 - {0:F1}kWh", dValueArray(3))
                    ElseIf dValueArray(3) < 1000 * 1000 Then
                        lbStatus_Year_Load.Text = String.Format("로드 - {0:F1}mWh", dValueArray(3) / 1000)
                    ElseIf dValueArray(3) < 1000 * 1000 * 1000 Then
                        lbStatus_Year_Load.Text = String.Format("로드 - {0:F1}gWh", dValueArray(3) / 1000 / 1000)
                    End If

                End If
            End If
        Next
    End Sub

    Private htHistoryData_Year As New Hashtable
    Private nMaxValue_Year As Integer = 0

    Private Sub ReadHistoryYear()

        nMaxValue_Year = 0
        htHistoryData_Year.Clear()



        Dim szPath As String = String.Format("\Flash Disk\Run\History\{0}", nYearReport_Year)
        Dim szHistoryFile As String = ""
        szHistoryFile = String.Format("{0}\H{1}.csv", szPath, nYearReport_Year.ToString("0000"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Month" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Month" Then
                        Else

                            Dim szMonth As String = szItems(0)
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))


                            Dim nMonth As Integer = Val(szMonth)

                            Dim dValue(3) As Double
                            dValue(0) = dGridIn
                            dValue(1) = dGridOut
                            dValue(2) = dInverter
                            dValue(3) = dLoad

                            htHistoryData_Year(nMonth) = dValue

                            If nMaxValue_Year < dValue(0) + dValue(1) Then nMaxValue_Year = dValue(0) + dValue(1)
                            If nMaxValue_Year < dValue(2) Then nMaxValue_Year = dValue(2)
                            If nMaxValue_Year < dValue(3) Then nMaxValue_Year = dValue(3)
                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If
    End Sub

#End Region
     

End Class

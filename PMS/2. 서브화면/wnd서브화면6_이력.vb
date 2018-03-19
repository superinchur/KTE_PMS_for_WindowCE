Public Class wnd서브화면6_이력

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        화면초기화()
        PageHeader1_Click(Nothing, EventArgs.Empty)

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

    Public Sub InitScreen()
        DateTimePicker11.Value = Now
        DateTimePicker12.Value = Now
        ListView1.Items.Clear()

        DateTimePicker21.Value = Now
        DateTimePicker22.Value = Now
        ListView2.Items.Clear()

        DateTimePicker31.Value = Now
        DateTimePicker32.Value = Now
        ListView3.Items.Clear()

        DateTimePicker41.Value = Now
        DateTimePicker42.Value = Now
        ListView4.Items.Clear()

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
        pnlScreen1.BringToFront()
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
        pnlScreen2.BringToFront()
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
        pnlScreen3.BringToFront()
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
        pnlScreen4.BringToFront()

    End Sub

#Region "고장이력"

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        On Error Resume Next
        ListView1.Items.Clear()

        Dim szPath As String
        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\SD Card\FaultHistory"
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\Flash Disk\Run\FaultHistory"
            End If
        End If

        Dim szHistoryFile As String = ""

        Dim dtCurrent As Date = DateTimePicker11.Value
        While (dtCurrent <= DateTimePicker12.Value)

            szHistoryFile = String.Format("{0}\Inverter_{1}.csv", szPath, Format(dtCurrent, "yyyy-MM-dd"))

            ReadFaultFile(szHistoryFile, ListView1)

            dtCurrent = DateAdd(DateInterval.Day, 1, dtCurrent)
        End While

    End Sub

#End Region

#Region "정전이력"
    Private Sub btnSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch2.Click
        ListView2.Items.Clear()

        Dim szPath As String
        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\SD Card\FaultHistory"
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\Flash Disk\Run\FaultHistory"
            End If
        End If

        Dim szHistoryFile As String = ""

        Dim dtCurrent As Date = DateTimePicker21.Value
        While (dtCurrent <= DateTimePicker22.Value)

            szHistoryFile = String.Format("{0}\Grid_{1}.csv", szPath, Format(dtCurrent, "yyyy-MM-dd"))

            ReadFaultFile(szHistoryFile, ListView2)

            dtCurrent = DateAdd(DateInterval.Day, 1, dtCurrent)
        End While

    End Sub
#End Region

#Region "통신이력"
    Private Sub btnSearch3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch3.Click
        ListView3.Items.Clear()

        Dim szPath As String
        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\SD Card\FaultHistory"
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\Flash Disk\Run\FaultHistory"
            End If
        End If

        Dim szHistoryFile As String = ""

        Dim dtCurrent As Date = DateTimePicker31.Value
        While (dtCurrent <= DateTimePicker32.Value)

            szHistoryFile = String.Format("{0}\Comm_{1}.csv", szPath, Format(dtCurrent, "yyyy-MM-dd"))

            ReadFaultFile(szHistoryFile, ListView3)

            dtCurrent = DateAdd(DateInterval.Day, 1, dtCurrent)
        End While

    End Sub
#End Region

#Region "전장상태"
    Private Sub btnSearch4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch4.Click
        ListView4.Items.Clear()

        Dim szPath As String
        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\SD Card\FaultHistory"
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\Flash Disk\Run\FaultHistory"
            End If
        End If

        Dim szHistoryFile As String = ""

        Dim dtCurrent As Date = DateTimePicker41.Value
        While (dtCurrent <= DateTimePicker42.Value)

            szHistoryFile = String.Format("{0}\Status_{1}.csv", szPath, Format(dtCurrent, "yyyy-MM-dd"))

            ReadFaultFile(szHistoryFile, ListView4)

            dtCurrent = DateAdd(DateInterval.Day, 1, dtCurrent)
        End While

    End Sub
#End Region

    Private Sub ReadFaultFile(ByVal szFileName As String, ByRef pView As ListView)


        If System.IO.File.Exists(szFileName) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szFileName)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Date" And szItems(1) = "Time" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szFileName)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Date" Then
                        Else
                            If pView.Columns.Count = 5 Then

                                Dim pItem As New ListViewItem
                                pItem.Text = (pView.Items.Count + 1).ToString
                                pItem.SubItems.Add(szItems(0))
                                pItem.SubItems.Add(szItems(1))
                                pItem.SubItems.Add(szItems(3))
                                pItem.SubItems.Add(szItems(4))

                                Dim pItem2 As ListViewItem = pView.Items.Insert(0, pItem)

                            Else

                                Dim pItem As New ListViewItem
                                pItem.Text = (pView.Items.Count + 1).ToString
                                pItem.SubItems.Add(szItems(0))
                                pItem.SubItems.Add(szItems(1))
                                pItem.SubItems.Add(String.Format("0x{0:X2}", CInt(Val(szItems(2)))))
                                pItem.SubItems.Add(szItems(3))
                                pItem.SubItems.Add(szItems(4))

                                Dim pItem2 As ListViewItem = pView.Items.Insert(0, pItem)

                            End If

                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If

    End Sub

End Class

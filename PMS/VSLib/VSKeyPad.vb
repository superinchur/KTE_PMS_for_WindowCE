Public Class VSKeyPad

    Private Sub VSKeyPad_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), 0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.DrawRectangle(New Pen(Color.Gray), 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Public inTextBox As VSLabel = Nothing

    Public Sub InitControl(ByRef pTextBox As VSLabel)

        inTextBox = pTextBox
        lbKeyData.Text = inTextBox.Text
        If lbKeyData.Text = "0" Then lbKeyData.Text = ""
        If lbKeyData.Text = "00" Then lbKeyData.Text = ""

        Me.Visible = True
        lbKeyData.Invalidate()
        Me.Invalidate()

    End Sub

    Private Sub lbVSKeyPad_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbVSKeyPad0.MouseDown, lbVSKeyPad1.MouseDown, lbVSKeyPad2.MouseDown, lbVSKeyPad3.MouseDown, lbVSKeyPad4.MouseDown, lbVSKeyPad5.MouseDown, lbVSKeyPad6.MouseDown, lbVSKeyPad7.MouseDown, lbVSKeyPad8.MouseDown, lbVSKeyPad9.MouseDown
        Dim pButton As VSPictureButton = sender
        Dim szKey As String = pButton.Name.Replace("lbVSKeyPad", "")
        AppendChar(szKey)
    End Sub

    Private Sub lbVSKeyPadDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbVSKeyPadDot.MouseDown
        ' Dot
        AppendChar(".")
    End Sub

    Private Sub lbVSKeyPadBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbVSKeyPadBS.MouseDown
        ' Back

        If lbKeyData.Text = "" Then Exit Sub

        lbKeyData.Text = lbKeyData.Text.Substring(0, lbKeyData.Text.Length - 1)
        lbKeyData.Invalidate()

    End Sub

    Private Sub lbVSKeyPadOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbVSKeyPadOK.MouseDown
        ' OK

        If inTextBox.MinRange <> 0.0 = inTextBox.MaxRange <> 0.0 Then
            inTextBox.Text = lbKeyData.Text
            inTextBox.Invalidate()
            Visible = False
        Else

            Dim dValue As Double = Val(lbKeyData.Text)
            If inTextBox.MinRange <= dValue And dValue <= inTextBox.MaxRange Then
                inTextBox.Text = lbKeyData.Text
                inTextBox.Invalidate()
                Visible = False
            Else
                Dim szTemp As String = ""
                szTemp = String.Format("입력 범위는 {0}에서 {1}까지 입니다.", inTextBox.MinRange, inTextBox.MaxRange)
                MsgBox(szTemp, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "알림")
            End If
        End If

    End Sub

    Private Sub lbVSKeyPadCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbVSKeyPadCancel.MouseDown
        ' Cancel
        Visible = False
    End Sub

    Private Sub AppendChar(ByVal szInChar As String)
        lbKeyData.Text &= szInChar
        lbKeyData.Invalidate()
    End Sub

End Class

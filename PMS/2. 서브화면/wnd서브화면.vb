Public Class wnd서브화면
    Private pFocusLabel As VSLabel = Nothing
    Private clrOldLabel As Color = Color.White

    Private VsKeyPad1 As VSKeyPad = Nothing


    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub

    Public Sub InitKeyPad()

        SetOnKeyPad(Me)

    End Sub

    Public Sub SetOnKeyPad(ByVal CurrentControl As Control)

        For Each pObj In CurrentControl.Controls

            If TypeOf pObj Is VSLabel Then
                Dim pLabel As VSLabel = pObj
                'If pLabel.UseKeyPad = True Then
                AddHandler pLabel.Click, AddressOf KeyPadClick
                'End If
            ElseIf TypeOf pObj Is Panel Then
            SetOnKeyPad(pObj)
            End If

        Next

    End Sub


    Private Sub KeyPadClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim pTempCtrl As VSLabel = sender
        If pTempCtrl.UseKeyPad <> True Then Exit Sub


        If VsKeyPad1 Is Nothing Then
            VsKeyPad1 = New VSKeyPad
            VsKeyPad1.Parent = Me

            VsKeyPad1.Visible = False
        End If

        If VsKeyPad1.Visible = True Then
            VsKeyPad1.Visible = False
        End If

        If Not pFocusLabel Is Nothing Then
            pFocusLabel.BackColor = clrOldLabel
        End If

        pFocusLabel = sender
        clrOldLabel = pFocusLabel.BackColor

        pFocusLabel.BackColor = Color.Yellow

        If TypeOf pFocusLabel.Parent Is Panel Then
            Dim pPanel As Panel = pFocusLabel.Parent

            VsKeyPad1.Left = pPanel.Left + pFocusLabel.Left + pFocusLabel.Width + 5
            VsKeyPad1.Top = pPanel.Top + pFocusLabel.Top + pFocusLabel.Height + 5

            If pPanel.Top + pFocusLabel.Top > pPanel.Height - VsKeyPad1.Height - 5 Then
                VsKeyPad1.Top = (pPanel.Top + pFocusLabel.Top) - VsKeyPad1.Height - 5
            End If

            VsKeyPad1.Left = (Me.Width - VsKeyPad1.Width) / 2


        Else
            VsKeyPad1.Left = pFocusLabel.Left + pFocusLabel.Width + 5
            VsKeyPad1.Top = pFocusLabel.Top + pFocusLabel.Height + 5

            If pFocusLabel.Top > Me.Height - VsKeyPad1.Height - 5 Then
                VsKeyPad1.Top = pFocusLabel.Top - VsKeyPad1.Height - 5
            End If

            VsKeyPad1.Left = (Me.Width - VsKeyPad1.Width) / 2
        End If


        VsKeyPad1.InitControl(pFocusLabel)

        VsKeyPad1.Visible = True
        VsKeyPad1.BringToFront()
    End Sub

    Public Sub HideKeyPad()
        If Not VsKeyPad1 Is Nothing Then
            If VsKeyPad1.Visible = True Then
                VsKeyPad1.Visible = False
            End If
        End If

        If Not pFocusLabel Is Nothing Then
            pFocusLabel.BackColor = clrOldLabel
        End If
    End Sub
End Class
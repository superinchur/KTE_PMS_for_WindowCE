Public Class ucScrollArrow

    Enum eArrow
        Arrow_Stop = 0
        Arrow_Right = 1
        Arrow_Left = 2
    End Enum

    Private _Arrow As eArrow = eArrow.Arrow_Stop
    Public Property Arrow() As eArrow
        Get
            Return _Arrow
        End Get
        Set(ByVal value As eArrow)
            _Arrow = value

            If Arrow = eArrow.Arrow_Stop Then
                Timer_Scroll.Enabled = False
                pbArrowRight.Visible = False
                pbArrowLeft.Visible = False
            ElseIf Arrow = eArrow.Arrow_Right Then
                nArrowPos = 0
                pbArrowRight.Top = (Me.Height - pbArrowRight.Height) / 2

                pbArrowRight.Visible = True
                pbArrowLeft.Visible = False
                Timer_Scroll.Interval = 100
                Timer_Scroll.Enabled = True

            ElseIf Arrow = eArrow.Arrow_Left Then
                nArrowPos = 0

                pbArrowLeft.Top = (Me.Height - pbArrowRight.Height) / 2

                pbArrowRight.Visible = False
                pbArrowLeft.Visible = True
                Timer_Scroll.Interval = 100
                Timer_Scroll.Enabled = True

            End If

        End Set
    End Property

    Private nArrowPos As Integer = 0


    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        pbArrowLeft.Visible = False
        pbArrowRight.Visible = False
    End Sub

    Private Sub Timer_Scroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Scroll.Tick
        Timer_Scroll.Enabled = False

        If Arrow = eArrow.Arrow_Right Then
            If nArrowPos >= Me.Width - pbArrowRight.Width Then
                nArrowPos = 0
            End If

            pbArrowRight.Left = nArrowPos

            nArrowPos += 5
        ElseIf Arrow = eArrow.Arrow_Left Then
            If nArrowPos <= 0 Then
                nArrowPos = Me.Width - pbArrowLeft.Width
            End If

            pbArrowLeft.Left = nArrowPos

            nArrowPos -= 5
        End If

        Timer_Scroll.Enabled = True
    End Sub

End Class

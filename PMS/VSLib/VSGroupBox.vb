Public Class VSGroupBox
    Inherits Windows.Forms.Panel

    Private _HeaderText As String = ""
    Public Property HeaderText() As String
        Get
            Return _HeaderText
        End Get
        Set(ByVal value As String)
            _HeaderText = value
        End Set
    End Property

    Private _HeaderFont As New Font("굴림", 12, FontStyle.Regular)
    Public Property HeaderFont() As Font
        Get
            Return _HeaderFont
        End Get
        Set(ByVal value As Font)
            _HeaderFont = value
        End Set
    End Property

    Private Sub clsGroupBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        'Dim 판넬 As Panel = sender
        Using pPen As New System.Drawing.Pen(Color.Gray, 1)
            'e.Graphics.DrawRectangle(pPen, 0, 0, 판넬.Width - 1, 판넬.Height - 1)

            If HeaderText = "" Then
                e.Graphics.DrawLine(pPen, 0, 0, Me.Width - 1, 0)

                e.Graphics.DrawLine(pPen, 0, 0, 0, Me.Height - 1)
                e.Graphics.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)
                e.Graphics.DrawLine(pPen, Me.Width - 1, Me.Height - 1, Me.Width - 1, 0)
            Else

                Dim szText As String = String.Format(" {0} ", Me.HeaderText)

                Dim nMargin As Integer = 5
                Dim ptSizeTemp As SizeF = e.Graphics.MeasureString(szText, HeaderFont)
                Dim ptSize As New SizeF(ptSizeTemp.Width + nMargin * 2, ptSizeTemp.Height + nMargin * 2)

                e.Graphics.DrawLine(pPen, 0, nMargin, nMargin, 0)
                e.Graphics.DrawLine(pPen, nMargin, 0, ptSize.Width, 0)
                e.Graphics.DrawLine(pPen, ptSize.Width, 0, ptSize.Width, ptSize.Height)
                e.Graphics.DrawLine(pPen, ptSize.Width, ptSize.Height, Me.Width - 1, ptSize.Height)

                e.Graphics.DrawLine(pPen, 0, nMargin, 0, Me.Height - 1)
                e.Graphics.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)
                e.Graphics.DrawLine(pPen, Me.Width - 1, Me.Height - 1, Me.Width - 1, ptSize.Height)

                e.Graphics.DrawString(szText, HeaderFont, New SolidBrush(Color.Black), nMargin, nMargin)

            End If


        End Using

        'MyBase.OnPaint(e)

    End Sub
End Class

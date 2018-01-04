Public Class VSPictureButton
    Inherits Control

    Private backgroundImg As Image
    Private pressedImg As Image
    Private pressed As Boolean = False
    Private _selected As Boolean = False

    Public Property Selected() As Boolean
        Get
            Return _selected
        End Get
        Set(ByVal value As Boolean)
            _selected = value
            Invalidate()
        End Set
    End Property

    Private _BorderColor As Color = Color.Gray
    Public Property BorderColor() As Color
        Get
            Return _BorderColor
        End Get
        Set(ByVal value As Color)
            _BorderColor = value
        End Set
    End Property

    Private _BorderWidth As Integer = 2
    Public Property BorderWidth() As Integer
        Get
            Return _BorderWidth
        End Get
        Set(ByVal value As Integer)
            _BorderWidth = value
        End Set
    End Property

    Private _BorderSide_Left As Boolean = True
    Public Property BorderSide_Left() As Boolean
        Get
            Return _BorderSide_Left
        End Get
        Set(ByVal value As Boolean)
            _BorderSide_Left = value
        End Set
    End Property

    Private _BorderSide_Right As Boolean = True
    Public Property BorderSide_Right() As Boolean
        Get
            Return _BorderSide_Right
        End Get
        Set(ByVal value As Boolean)
            _BorderSide_Right = value
        End Set
    End Property

    Private _BorderSide_Top As Boolean = True
    Public Property BorderSide_Top() As Boolean
        Get
            Return _BorderSide_Top
        End Get
        Set(ByVal value As Boolean)
            _BorderSide_Top = value
        End Set
    End Property

    Private _BorderSide_Bottom As Boolean = True
    Public Property BorderSide_Bottom() As Boolean
        Get
            Return _BorderSide_Bottom
        End Get
        Set(ByVal value As Boolean)
            _BorderSide_Bottom = value
        End Set
    End Property

    ' Property for the background image to be drawn behind the button text.
    Public Property BackgroundImageValue() As Image
        Get
            Return Me.backgroundImg
        End Get
        Set(ByVal Value As Image)
            Me.backgroundImg = Value
            Invalidate()
        End Set
    End Property

    ' Property for the background image to be drawn behind the button text when
    ' the button is pressed.
    Public Property PressedImageValue() As Image
        Get
            Return Me.pressedImg
        End Get
        Set(ByVal Value As Image)
            Me.pressedImg = Value
            Invalidate()
        End Set
    End Property

    ' When the mouse button is pressed, set the "pressed" flag to true
    ' and ivalidate the form to cause a repaint.  The .NET Compact Framework
    ' sets the mouse capture automatically.
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        Me.pressed = True
        Me.Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    ' When the mouse is released, reset the "pressed" flag
    ' and invalidate to redraw the button in the unpressed state.
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        Me.pressed = False
        Me.Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

    Private bmMem As Bitmap = Nothing

    ' Override the OnPaint method to draw the background image and the text.
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If bmMem Is Nothing Then
            bmMem = New Bitmap(Me.Width, Me.Height)
        End If

        Try

            Dim g As Graphics = Graphics.FromImage(bmMem)

            g.FillRectangle(New SolidBrush(Me.BackColor), 0, 0, Me.Width, Me.Height)

            Try
                If Selected = False Then
                    If Me.pressed AndAlso (Me.pressedImg IsNot Nothing) Then
                        g.DrawImage(Me.pressedImg, 0, 0)
                    Else
                        g.DrawImage(Me.backgroundImg, 0, 0)
                    End If
                Else
                    If Me.pressed AndAlso (Me.backgroundImg IsNot Nothing) Then
                        g.DrawImage(Me.backgroundImg, 0, 0)
                    Else
                        g.DrawImage(Me.pressedImg, 0, 0)
                    End If
                End If

            Catch ex As Exception

            End Try



            ' Draw the text if there is any.
            If Me.Text.Length > 0 Then
                Dim size As SizeF = g.MeasureString(Me.Text, Me.Font)

                ' Center the text inside the client area of the PictureButton.
                g.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), (Me.ClientSize.Width - size.Width) / 2, (Me.ClientSize.Height - size.Height) / 2)
            End If

            ' Draw a border around the outside of the   
            ' control to look like Pocket PC buttons.
            'g.DrawRectangle(New Pen(Color.Gray), 0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
            If BorderWidth > 0 Then
                Dim pPen As New Pen(BorderColor, BorderWidth)
                If BorderSide_Left = True Then
                    g.DrawLine(pPen, 0, 0, 0, Me.Height - 1)
                End If

                If BorderSide_Right = True Then
                    g.DrawLine(pPen, Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)
                End If

                If BorderSide_Top = True Then
                    g.DrawLine(pPen, 0, 0, Me.Width - 1, 0)
                End If

                If BorderSide_Bottom = True Then
                    g.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)
                End If
            End If

            g.Dispose()
            e.Graphics.DrawImage(bmMem, 0, 0)

        Catch ex As Exception

        End Try

        MyBase.OnPaint(e)
    End Sub

    ' Create a bitmap object and fill it with the specified color.   
    ' To make it look like a custom image, draw an ellipse in it.
    Public Function MakeBitmap(ByVal ButtonColor As Color, ByVal width As Integer, ByVal height As Integer) As Bitmap

        Dim bmp As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.FillRectangle(New SolidBrush(ButtonColor), 0, 0, bmp.Width, bmp.Height)
        'g.DrawEllipse(New Pen(Color.LightGray), 3, 3, width - 6, height - 6)
        g.Dispose()

        Return bmp
    End Function
End Class

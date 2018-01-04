Public Class VSPictureBox
    Inherits Windows.Forms.Panel

    Private _Image As Image = Nothing
    Public Property BackImage() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            _Image = value
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

    Private Sub VSPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim g As Graphics = e.Graphics

        Dim thisRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim pPen As New Pen(BorderColor, BorderWidth)

        Dim pBrush As New SolidBrush(BorderColor)
        g.FillRectangle(pBrush, thisRect)
        g.DrawImage(BackImage, 0, 0)

        ''Draw Images with Transparency
        ''---------------------------------------------------------------------------
        '' Create a red and black bitmap to demonstrate transparency. 
        'Dim bmp As New Bitmap(Me.BackImage)
        'Dim g2 As Graphics = Graphics.FromImage(bmp)

        'g2.FillEllipse(New SolidBrush(Color.Red), 0, 0, bmp.Width, bmp.Width)
        'g2.DrawLine(New Pen(Color.Black), 0, 0, bmp.Width, bmp.Width)
        'g2.DrawLine(New Pen(Color.Black), bmp.Width, 0, 0, bmp.Width)
        'g2.Dispose()


        'Dim attr As New Imaging.ImageAttributes

        '' Set the transparency color key based on the upper-left pixel  
        '' of the image. 
        '' Uncomment the following line to make all black pixels transparent: 
        'attr.SetColorKey(bmp.GetPixel(0, 0), bmp.GetPixel(0, 0))

        '' Set the transparency color key based on a specified value. 
        '' Uncomment the following line to make all red pixels transparent: 
        '' attr.SetColorKey(Color.Red, Color.Red) 

        '' Draw the image using the image attributes. 
        'Dim dstRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        'e.Graphics.DrawImage(bmp, dstRect, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attr)



        If BorderWidth > 0 Then
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

    End Sub
End Class

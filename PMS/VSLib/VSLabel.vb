Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.VisualBasic

Public Class VSLabel

    Inherits Control

    Private _UseKeyPad As Boolean = False
    Public Property UseKeyPad() As Boolean
        Get
            Return _UseKeyPad
        End Get
        Set(ByVal value As Boolean)
            _UseKeyPad = value
        End Set
    End Property

    Private _MinRange As Double = 0.0
    Public Property MinRange() As Double
        Get
            Return _MinRange
        End Get
        Set(ByVal value As Double)
            _MinRange = value
        End Set
    End Property

    Private _MaxRange As Double = 0.0
    Public Property MaxRange() As Double
        Get
            Return _MaxRange
        End Get
        Set(ByVal value As Double)
            _MaxRange = value
        End Set
    End Property

    Private _Image As Image = Nothing
    Public Property BackImage() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            _Image = value
            Invalidate()
        End Set
    End Property

    Private _TextAlign As StringAlignment = StringAlignment.Center
    Public Property TextAlign() As StringAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As StringAlignment)
            _TextAlign = value
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

    Private _Password As Boolean = False
    Public Property IsPassword() As Boolean
        Get
            Return _Password
        End Get
        Set(ByVal value As Boolean)
            _Password = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Public Sub New()

    End Sub

    Private bmMem As Bitmap = Nothing

    Private Sub VSLabel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If bmMem Is Nothing Then
            bmMem = New Bitmap(Me.Width, Me.Height)
        End If


        Try

            'MyBase.OnPaint(e)

            Dim g As Graphics = Graphics.FromImage(bmMem)


            Dim ptSize As SizeF = g.MeasureString(Text, Font)

            Dim ptF As New Point
            ' Get the location to set the Text.
            Select Case _TextAlign

                Case StringAlignment.Center
                    ptF.Y = Convert.ToInt32(Me.Height / 2)
                    ptF.Y -= ptSize.Height / 2
                    ptF.X = Convert.ToInt32(Me.Width / 2)
                    ptF.X -= ptSize.Width / 2

                Case StringAlignment.Near
                    ptF.Y = Convert.ToInt32(Me.Height / 2)
                    ptF.Y -= ptSize.Height / 2
                    ptF.X = 0

                Case StringAlignment.Far
                    ptF.Y = Convert.ToInt32(Me.Height / 2)
                    ptF.Y -= ptSize.Height / 2
                    ptF.X = Me.Width
                    ptF.X -= ptSize.Width

            End Select

            g.FillRectangle(New SolidBrush(BackColor), 0, 0, Me.Width, Me.Height)

            Try
                If Not BackImage Is Nothing Then
                    g.DrawImage(BackImage, 0, 0)
                End If
            Catch ex As Exception
            End Try

            If IsPassword = True Then
                Dim szText As String = ""
                For i As Integer = 1 To Me.Text.Length
                    szText &= "*"
                Next
                g.DrawString(szText, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)
            Else
                g.DrawString(Me.Text, Font, New SolidBrush(Me.ForeColor), ptF.X, ptF.Y)
            End If

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
    End Sub

    'Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    '    'MyBase.OnPaintBackground(e) '이라인을제거하여기본적으로그려지는폼의형태를없앨수있습니다.
    'End Sub

End Class

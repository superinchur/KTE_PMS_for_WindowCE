<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ucScrollArrow
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucScrollArrow))
        Me.pbArrowRight = New System.Windows.Forms.PictureBox
        Me.pbArrowLeft = New System.Windows.Forms.PictureBox
        Me.Timer_Scroll = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'pbArrowRight
        '
        Me.pbArrowRight.Image = CType(resources.GetObject("pbArrowRight.Image"), System.Drawing.Image)
        Me.pbArrowRight.Location = New System.Drawing.Point(9, 2)
        Me.pbArrowRight.Name = "pbArrowRight"
        Me.pbArrowRight.Size = New System.Drawing.Size(31, 16)
        '
        'pbArrowLeft
        '
        Me.pbArrowLeft.Image = CType(resources.GetObject("pbArrowLeft.Image"), System.Drawing.Image)
        Me.pbArrowLeft.Location = New System.Drawing.Point(71, 3)
        Me.pbArrowLeft.Name = "pbArrowLeft"
        Me.pbArrowLeft.Size = New System.Drawing.Size(31, 16)
        '
        'Timer_Scroll
        '
        '
        'ucScrollArrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pbArrowLeft)
        Me.Controls.Add(Me.pbArrowRight)
        Me.Name = "ucScrollArrow"
        Me.Size = New System.Drawing.Size(150, 20)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbArrowRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbArrowLeft As System.Windows.Forms.PictureBox
    Friend WithEvents Timer_Scroll As System.Windows.Forms.Timer

End Class

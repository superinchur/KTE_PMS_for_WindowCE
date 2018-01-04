<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면8_고장
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
        Me.VsGroupBox1 = New PMS.VSGroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.VsGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VsGroupBox1
        '
        Me.VsGroupBox1.BackColor = System.Drawing.Color.White
        Me.VsGroupBox1.Controls.Add(Me.ListView1)
        Me.VsGroupBox1.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox1.HeaderText = "발생"
        Me.VsGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.VsGroupBox1.Name = "VsGroupBox1"
        Me.VsGroupBox1.Size = New System.Drawing.Size(794, 332)
        '
        'ListView1
        '
        Me.ListView1.Columns.Add(Me.ColumnHeader1)
        Me.ListView1.Columns.Add(Me.ColumnHeader2)
        Me.ListView1.Columns.Add(Me.ColumnHeader3)
        Me.ListView1.Columns.Add(Me.ColumnHeader5)
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(3, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(788, 294)
        Me.ListView1.TabIndex = 4
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "번호"
        Me.ColumnHeader1.Width = 60
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "날짜"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "시간"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "고장내용"
        Me.ColumnHeader5.Width = 500
        '
        'wnd서브화면8_고장
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.VsGroupBox1)
        Me.Name = "wnd서브화면8_고장"
        Me.Size = New System.Drawing.Size(800, 338)
        Me.VsGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VsGroupBox1 As PMS.VSGroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class

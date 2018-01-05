<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면1_메인
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면1_메인))
        Me.타이머_상태 = New System.Windows.Forms.Timer
        Me.pbBattery = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbRunMode = New PMS.VSLabel
        Me.ucScrollLoadStatus = New PMS.ucScrollArrow
        Me.ucScrollGridStatus = New PMS.ucScrollArrow
        Me.ucScrollBattStatus = New PMS.ucScrollArrow
        Me.lbBattPercent = New PMS.VSLabel
        Me.lbLoadStatus = New PMS.VSLabel
        Me.lbGridStatus = New PMS.VSLabel
        Me.lbBattStatus = New PMS.VSLabel
        Me.SuspendLayout()
        '
        '타이머_상태
        '
        '
        'pbBattery
        '
        Me.pbBattery.Image = CType(resources.GetObject("pbBattery.Image"), System.Drawing.Image)
        Me.pbBattery.Location = New System.Drawing.Point(97, 146)
        Me.pbBattery.Name = "pbBattery"
        Me.pbBattery.Size = New System.Drawing.Size(44, 76)
        Me.pbBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(356, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(654, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(654, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(464, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 2)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(464, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 2)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(171, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 2)
        '
        'lbRunMode
        '
        Me.lbRunMode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbRunMode.BorderColor = System.Drawing.Color.Gray
        Me.lbRunMode.BorderSide_Bottom = True
        Me.lbRunMode.BorderSide_Left = True
        Me.lbRunMode.BorderSide_Right = True
        Me.lbRunMode.BorderSide_Top = True
        Me.lbRunMode.BorderWidth = 1
        Me.lbRunMode.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbRunMode.ForeColor = System.Drawing.Color.Black
        Me.lbRunMode.Location = New System.Drawing.Point(250, 10)
        Me.lbRunMode.Name = "lbRunMode"
        Me.lbRunMode.Size = New System.Drawing.Size(300, 68)
        Me.lbRunMode.TabIndex = 33
        Me.lbRunMode.Text = "사용모드"
        Me.lbRunMode.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbRunMode.UseKeyPad = True
        '
        'ucScrollLoadStatus
        '
        Me.ucScrollLoadStatus.Location = New System.Drawing.Point(464, 230)
        Me.ucScrollLoadStatus.Name = "ucScrollLoadStatus"
        Me.ucScrollLoadStatus.Size = New System.Drawing.Size(150, 20)
        Me.ucScrollLoadStatus.TabIndex = 26
        '
        'ucScrollGridStatus
        '
        Me.ucScrollGridStatus.Location = New System.Drawing.Point(464, 121)
        Me.ucScrollGridStatus.Name = "ucScrollGridStatus"
        Me.ucScrollGridStatus.Size = New System.Drawing.Size(150, 20)
        Me.ucScrollGridStatus.TabIndex = 26
        '
        'ucScrollBattStatus
        '
        Me.ucScrollBattStatus.Location = New System.Drawing.Point(171, 193)
        Me.ucScrollBattStatus.Name = "ucScrollBattStatus"
        Me.ucScrollBattStatus.Size = New System.Drawing.Size(150, 20)
        Me.ucScrollBattStatus.TabIndex = 26
        '
        'lbBattPercent
        '
        Me.lbBattPercent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbBattPercent.BorderColor = System.Drawing.Color.Gray
        Me.lbBattPercent.BorderSide_Bottom = True
        Me.lbBattPercent.BorderSide_Left = True
        Me.lbBattPercent.BorderSide_Right = True
        Me.lbBattPercent.BorderSide_Top = True
        Me.lbBattPercent.BorderWidth = 1
        Me.lbBattPercent.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbBattPercent.ForeColor = System.Drawing.Color.Black
        Me.lbBattPercent.Location = New System.Drawing.Point(83, 228)
        Me.lbBattPercent.Name = "lbBattPercent"
        Me.lbBattPercent.Size = New System.Drawing.Size(73, 30)
        Me.lbBattPercent.TabIndex = 14
        Me.lbBattPercent.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBattPercent.UseKeyPad = True
        '
        'lbLoadStatus
        '
        Me.lbLoadStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbLoadStatus.BorderColor = System.Drawing.Color.Gray
        Me.lbLoadStatus.BorderSide_Bottom = True
        Me.lbLoadStatus.BorderSide_Left = True
        Me.lbLoadStatus.BorderSide_Right = True
        Me.lbLoadStatus.BorderSide_Top = True
        Me.lbLoadStatus.BorderWidth = 1
        Me.lbLoadStatus.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbLoadStatus.ForeColor = System.Drawing.Color.Black
        Me.lbLoadStatus.Location = New System.Drawing.Point(479, 256)
        Me.lbLoadStatus.Name = "lbLoadStatus"
        Me.lbLoadStatus.Size = New System.Drawing.Size(120, 30)
        Me.lbLoadStatus.TabIndex = 0
        Me.lbLoadStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbLoadStatus.UseKeyPad = True
        '
        'lbGridStatus
        '
        Me.lbGridStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbGridStatus.BorderColor = System.Drawing.Color.Gray
        Me.lbGridStatus.BorderSide_Bottom = True
        Me.lbGridStatus.BorderSide_Left = True
        Me.lbGridStatus.BorderSide_Right = True
        Me.lbGridStatus.BorderSide_Top = True
        Me.lbGridStatus.BorderWidth = 1
        Me.lbGridStatus.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbGridStatus.ForeColor = System.Drawing.Color.Black
        Me.lbGridStatus.Location = New System.Drawing.Point(479, 85)
        Me.lbGridStatus.Name = "lbGridStatus"
        Me.lbGridStatus.Size = New System.Drawing.Size(120, 30)
        Me.lbGridStatus.TabIndex = 1
        Me.lbGridStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbGridStatus.UseKeyPad = True
        '
        'lbBattStatus
        '
        Me.lbBattStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbBattStatus.BorderColor = System.Drawing.Color.Gray
        Me.lbBattStatus.BorderSide_Bottom = True
        Me.lbBattStatus.BorderSide_Left = True
        Me.lbBattStatus.BorderSide_Right = True
        Me.lbBattStatus.BorderSide_Top = True
        Me.lbBattStatus.BorderWidth = 1
        Me.lbBattStatus.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbBattStatus.ForeColor = System.Drawing.Color.Black
        Me.lbBattStatus.Location = New System.Drawing.Point(178, 219)
        Me.lbBattStatus.Name = "lbBattStatus"
        Me.lbBattStatus.Size = New System.Drawing.Size(137, 30)
        Me.lbBattStatus.TabIndex = 2
        Me.lbBattStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBattStatus.UseKeyPad = True
        '
        'wnd서브화면1_메인
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lbRunMode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ucScrollLoadStatus)
        Me.Controls.Add(Me.ucScrollGridStatus)
        Me.Controls.Add(Me.ucScrollBattStatus)
        Me.Controls.Add(Me.lbBattPercent)
        Me.Controls.Add(Me.lbLoadStatus)
        Me.Controls.Add(Me.lbGridStatus)
        Me.Controls.Add(Me.lbBattStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pbBattery)
        Me.Name = "wnd서브화면1_메인"
        Me.Size = New System.Drawing.Size(800, 338)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents pbBattery As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbBattStatus As PMS.VSLabel
    Friend WithEvents lbGridStatus As PMS.VSLabel
    Friend WithEvents lbLoadStatus As PMS.VSLabel
    Friend WithEvents lbBattPercent As PMS.VSLabel
    Friend WithEvents ucScrollBattStatus As PMS.ucScrollArrow
    Friend WithEvents ucScrollGridStatus As PMS.ucScrollArrow
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ucScrollLoadStatus As PMS.ucScrollArrow
    Friend WithEvents lbRunMode As PMS.VSLabel

End Class

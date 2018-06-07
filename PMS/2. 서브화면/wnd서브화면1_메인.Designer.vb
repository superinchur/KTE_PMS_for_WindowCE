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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbcontrol_INV = New PMS.VSLabel
        Me.VsLabel2 = New PMS.VSLabel
        Me.lbHeartBit = New PMS.VSLabel
        Me.Addr2 = New PMS.VSLabel
        Me.Addr1 = New PMS.VSLabel
        Me.Addr0 = New PMS.VSLabel
        Me.btn리모트모드 = New PMS.VSLabel
        Me.btn로컬모드 = New PMS.VSLabel
        Me.lbRunMode = New PMS.VSLabel
        Me.ucScrollGridStatus = New PMS.ucScrollArrow
        Me.ucScrollBattStatus = New PMS.ucScrollArrow
        Me.lbBattPercent = New PMS.VSLabel
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
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(656, 149)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(466, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 2)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(171, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 2)
        '
        'lbcontrol_INV
        '
        Me.lbcontrol_INV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbcontrol_INV.BorderColor = System.Drawing.Color.Gray
        Me.lbcontrol_INV.BorderSide_Bottom = True
        Me.lbcontrol_INV.BorderSide_Left = True
        Me.lbcontrol_INV.BorderSide_Right = True
        Me.lbcontrol_INV.BorderSide_Top = True
        Me.lbcontrol_INV.BorderWidth = 1
        Me.lbcontrol_INV.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbcontrol_INV.ForeColor = System.Drawing.Color.Black
        Me.lbcontrol_INV.Location = New System.Drawing.Point(21, 10)
        Me.lbcontrol_INV.Name = "lbcontrol_INV"
        Me.lbcontrol_INV.Size = New System.Drawing.Size(120, 30)
        Me.lbcontrol_INV.TabIndex = 51
        Me.lbcontrol_INV.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbcontrol_INV.UseKeyPad = True
        Me.lbcontrol_INV.Visible = False
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VsLabel2.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel2.BorderSide_Bottom = True
        Me.VsLabel2.BorderSide_Left = True
        Me.VsLabel2.BorderSide_Right = True
        Me.VsLabel2.BorderSide_Top = True
        Me.VsLabel2.BorderWidth = 1
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.ForeColor = System.Drawing.Color.Black
        Me.VsLabel2.Location = New System.Drawing.Point(48, 269)
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(120, 30)
        Me.VsLabel2.TabIndex = 50
        Me.VsLabel2.Text = "HeartBit"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel2.UseKeyPad = True
        '
        'lbHeartBit
        '
        Me.lbHeartBit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbHeartBit.BorderColor = System.Drawing.Color.Gray
        Me.lbHeartBit.BorderSide_Bottom = True
        Me.lbHeartBit.BorderSide_Left = True
        Me.lbHeartBit.BorderSide_Right = True
        Me.lbHeartBit.BorderSide_Top = True
        Me.lbHeartBit.BorderWidth = 1
        Me.lbHeartBit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbHeartBit.ForeColor = System.Drawing.Color.Black
        Me.lbHeartBit.Location = New System.Drawing.Point(48, 305)
        Me.lbHeartBit.Name = "lbHeartBit"
        Me.lbHeartBit.Size = New System.Drawing.Size(120, 30)
        Me.lbHeartBit.TabIndex = 49
        Me.lbHeartBit.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbHeartBit.UseKeyPad = True
        '
        'Addr2
        '
        Me.Addr2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Addr2.BorderColor = System.Drawing.Color.Gray
        Me.Addr2.BorderSide_Bottom = True
        Me.Addr2.BorderSide_Left = True
        Me.Addr2.BorderSide_Right = True
        Me.Addr2.BorderSide_Top = True
        Me.Addr2.BorderWidth = 1
        Me.Addr2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Addr2.ForeColor = System.Drawing.Color.Black
        Me.Addr2.Location = New System.Drawing.Point(677, 84)
        Me.Addr2.Name = "Addr2"
        Me.Addr2.Size = New System.Drawing.Size(120, 30)
        Me.Addr2.TabIndex = 43
        Me.Addr2.TextAlign = System.Drawing.StringAlignment.Center
        Me.Addr2.UseKeyPad = True
        Me.Addr2.Visible = False
        '
        'Addr1
        '
        Me.Addr1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Addr1.BorderColor = System.Drawing.Color.Gray
        Me.Addr1.BorderSide_Bottom = True
        Me.Addr1.BorderSide_Left = True
        Me.Addr1.BorderSide_Right = True
        Me.Addr1.BorderSide_Top = True
        Me.Addr1.BorderWidth = 1
        Me.Addr1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Addr1.ForeColor = System.Drawing.Color.Black
        Me.Addr1.Location = New System.Drawing.Point(677, 48)
        Me.Addr1.Name = "Addr1"
        Me.Addr1.Size = New System.Drawing.Size(120, 30)
        Me.Addr1.TabIndex = 42
        Me.Addr1.TextAlign = System.Drawing.StringAlignment.Center
        Me.Addr1.UseKeyPad = True
        Me.Addr1.Visible = False
        '
        'Addr0
        '
        Me.Addr0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Addr0.BorderColor = System.Drawing.Color.Gray
        Me.Addr0.BorderSide_Bottom = True
        Me.Addr0.BorderSide_Left = True
        Me.Addr0.BorderSide_Right = True
        Me.Addr0.BorderSide_Top = True
        Me.Addr0.BorderWidth = 1
        Me.Addr0.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Addr0.ForeColor = System.Drawing.Color.Black
        Me.Addr0.Location = New System.Drawing.Point(677, 10)
        Me.Addr0.Name = "Addr0"
        Me.Addr0.Size = New System.Drawing.Size(120, 30)
        Me.Addr0.TabIndex = 41
        Me.Addr0.TextAlign = System.Drawing.StringAlignment.Center
        Me.Addr0.UseKeyPad = True
        Me.Addr0.Visible = False
        '
        'btn리모트모드
        '
        Me.btn리모트모드.BackColor = System.Drawing.Color.LightGreen
        Me.btn리모트모드.BorderColor = System.Drawing.Color.Gray
        Me.btn리모트모드.BorderSide_Bottom = False
        Me.btn리모트모드.BorderSide_Left = False
        Me.btn리모트모드.BorderSide_Right = True
        Me.btn리모트모드.BorderSide_Top = True
        Me.btn리모트모드.BorderWidth = 1
        Me.btn리모트모드.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn리모트모드.Location = New System.Drawing.Point(632, 295)
        Me.btn리모트모드.Name = "btn리모트모드"
        Me.btn리모트모드.Size = New System.Drawing.Size(145, 40)
        Me.btn리모트모드.TabIndex = 40
        Me.btn리모트모드.Text = "Remote Mode"
        Me.btn리모트모드.TextAlign = System.Drawing.StringAlignment.Center
        '
        'btn로컬모드
        '
        Me.btn로컬모드.BackColor = System.Drawing.Color.LightGreen
        Me.btn로컬모드.BorderColor = System.Drawing.Color.Gray
        Me.btn로컬모드.BorderSide_Bottom = False
        Me.btn로컬모드.BorderSide_Left = True
        Me.btn로컬모드.BorderSide_Right = True
        Me.btn로컬모드.BorderSide_Top = True
        Me.btn로컬모드.BorderWidth = 1
        Me.btn로컬모드.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn로컬모드.Location = New System.Drawing.Point(472, 295)
        Me.btn로컬모드.Name = "btn로컬모드"
        Me.btn로컬모드.Size = New System.Drawing.Size(145, 40)
        Me.btn로컬모드.TabIndex = 39
        Me.btn로컬모드.Text = "Local Mode"
        Me.btn로컬모드.TextAlign = System.Drawing.StringAlignment.Center
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
        Me.lbRunMode.Location = New System.Drawing.Point(202, 10)
        Me.lbRunMode.Name = "lbRunMode"
        Me.lbRunMode.Size = New System.Drawing.Size(414, 68)
        Me.lbRunMode.TabIndex = 33
        Me.lbRunMode.Text = "사용모드"
        Me.lbRunMode.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbRunMode.UseKeyPad = True
        '
        'ucScrollGridStatus
        '
        Me.ucScrollGridStatus.Location = New System.Drawing.Point(466, 167)
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
        Me.lbGridStatus.Location = New System.Drawing.Point(481, 131)
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
        Me.Controls.Add(Me.lbcontrol_INV)
        Me.Controls.Add(Me.VsLabel2)
        Me.Controls.Add(Me.lbHeartBit)
        Me.Controls.Add(Me.Addr2)
        Me.Controls.Add(Me.Addr1)
        Me.Controls.Add(Me.Addr0)
        Me.Controls.Add(Me.btn리모트모드)
        Me.Controls.Add(Me.btn로컬모드)
        Me.Controls.Add(Me.lbRunMode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ucScrollGridStatus)
        Me.Controls.Add(Me.ucScrollBattStatus)
        Me.Controls.Add(Me.lbBattPercent)
        Me.Controls.Add(Me.lbGridStatus)
        Me.Controls.Add(Me.lbBattStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pbBattery)
        Me.Name = "wnd서브화면1_메인"
        Me.Size = New System.Drawing.Size(800, 338)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents pbBattery As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbBattStatus As PMS.VSLabel
    Friend WithEvents lbGridStatus As PMS.VSLabel
    Friend WithEvents lbBattPercent As PMS.VSLabel
    Friend WithEvents ucScrollBattStatus As PMS.ucScrollArrow
    Friend WithEvents ucScrollGridStatus As PMS.ucScrollArrow
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbRunMode As PMS.VSLabel
    Friend WithEvents btn리모트모드 As PMS.VSLabel
    Friend WithEvents btn로컬모드 As PMS.VSLabel
    Friend WithEvents Addr0 As PMS.VSLabel
    Friend WithEvents Addr1 As PMS.VSLabel
    Friend WithEvents Addr2 As PMS.VSLabel
    Friend WithEvents lbHeartBit As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents lbcontrol_INV As PMS.VSLabel

End Class

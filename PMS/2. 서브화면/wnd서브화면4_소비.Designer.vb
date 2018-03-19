<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면4_소비
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면4_소비))
        Me.Label1 = New System.Windows.Forms.Label
        Me.타이머_상태 = New System.Windows.Forms.Timer
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.VsLabel7 = New PMS.VSLabel
        Me.VsLabel6 = New PMS.VSLabel
        Me.lbCurrent3 = New PMS.VSLabel
        Me.lbVoltage3 = New PMS.VSLabel
        Me.lbCurrent2 = New PMS.VSLabel
        Me.lbVoltage2 = New PMS.VSLabel
        Me.lbCurrent1 = New PMS.VSLabel
        Me.lbVoltage1 = New PMS.VSLabel
        Me.VsLabel4 = New PMS.VSLabel
        Me.lbPower2 = New PMS.VSLabel
        Me.ucScrollLoadStatus = New PMS.ucScrollArrow
        Me.lbLoadStatus = New PMS.VSLabel
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 36)
        Me.Label1.Text = "소비"
        '
        '타이머_상태
        '
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(64, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 2)
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(33, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(258, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(64, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 10)
        '
        'VsLabel7
        '
        Me.VsLabel7.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel7.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel7.BorderSide_Bottom = True
        Me.VsLabel7.BorderSide_Left = True
        Me.VsLabel7.BorderSide_Right = True
        Me.VsLabel7.BorderSide_Top = True
        Me.VsLabel7.BorderWidth = 1
        Me.VsLabel7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel7.IsPassword = False
        Me.VsLabel7.Location = New System.Drawing.Point(371, 211)
        Me.VsLabel7.Name = "VsLabel7"
        Me.VsLabel7.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel7.TabIndex = 63
        Me.VsLabel7.Text = "전류"
        Me.VsLabel7.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel7.UseKeyPad = False
        '
        'VsLabel6
        '
        Me.VsLabel6.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel6.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel6.BorderSide_Bottom = True
        Me.VsLabel6.BorderSide_Left = True
        Me.VsLabel6.BorderSide_Right = True
        Me.VsLabel6.BorderSide_Top = True
        Me.VsLabel6.BorderWidth = 1
        Me.VsLabel6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel6.IsPassword = False
        Me.VsLabel6.Location = New System.Drawing.Point(371, 144)
        Me.VsLabel6.Name = "VsLabel6"
        Me.VsLabel6.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel6.TabIndex = 63
        Me.VsLabel6.Text = "전압"
        Me.VsLabel6.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel6.UseKeyPad = False
        '
        'lbCurrent3
        '
        Me.lbCurrent3.BackColor = System.Drawing.Color.White
        Me.lbCurrent3.BorderColor = System.Drawing.Color.DarkGray
        Me.lbCurrent3.BorderSide_Bottom = True
        Me.lbCurrent3.BorderSide_Left = True
        Me.lbCurrent3.BorderSide_Right = True
        Me.lbCurrent3.BorderSide_Top = True
        Me.lbCurrent3.BorderWidth = 1
        Me.lbCurrent3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbCurrent3.IsPassword = False
        Me.lbCurrent3.Location = New System.Drawing.Point(679, 211)
        Me.lbCurrent3.Name = "lbCurrent3"
        Me.lbCurrent3.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent3.TabIndex = 62
        Me.lbCurrent3.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbCurrent3.UseKeyPad = False
        '
        'lbVoltage3
        '
        Me.lbVoltage3.BackColor = System.Drawing.Color.White
        Me.lbVoltage3.BorderColor = System.Drawing.Color.DarkGray
        Me.lbVoltage3.BorderSide_Bottom = True
        Me.lbVoltage3.BorderSide_Left = True
        Me.lbVoltage3.BorderSide_Right = True
        Me.lbVoltage3.BorderSide_Top = True
        Me.lbVoltage3.BorderWidth = 1
        Me.lbVoltage3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbVoltage3.IsPassword = False
        Me.lbVoltage3.Location = New System.Drawing.Point(679, 144)
        Me.lbVoltage3.Name = "lbVoltage3"
        Me.lbVoltage3.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage3.TabIndex = 62
        Me.lbVoltage3.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbVoltage3.UseKeyPad = False
        '
        'lbCurrent2
        '
        Me.lbCurrent2.BackColor = System.Drawing.Color.White
        Me.lbCurrent2.BorderColor = System.Drawing.Color.DarkGray
        Me.lbCurrent2.BorderSide_Bottom = True
        Me.lbCurrent2.BorderSide_Left = True
        Me.lbCurrent2.BorderSide_Right = True
        Me.lbCurrent2.BorderSide_Top = True
        Me.lbCurrent2.BorderWidth = 1
        Me.lbCurrent2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbCurrent2.IsPassword = False
        Me.lbCurrent2.Location = New System.Drawing.Point(563, 211)
        Me.lbCurrent2.Name = "lbCurrent2"
        Me.lbCurrent2.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent2.TabIndex = 61
        Me.lbCurrent2.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbCurrent2.UseKeyPad = False
        '
        'lbVoltage2
        '
        Me.lbVoltage2.BackColor = System.Drawing.Color.White
        Me.lbVoltage2.BorderColor = System.Drawing.Color.DarkGray
        Me.lbVoltage2.BorderSide_Bottom = True
        Me.lbVoltage2.BorderSide_Left = True
        Me.lbVoltage2.BorderSide_Right = True
        Me.lbVoltage2.BorderSide_Top = True
        Me.lbVoltage2.BorderWidth = 1
        Me.lbVoltage2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbVoltage2.IsPassword = False
        Me.lbVoltage2.Location = New System.Drawing.Point(563, 144)
        Me.lbVoltage2.Name = "lbVoltage2"
        Me.lbVoltage2.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage2.TabIndex = 61
        Me.lbVoltage2.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbVoltage2.UseKeyPad = False
        '
        'lbCurrent1
        '
        Me.lbCurrent1.BackColor = System.Drawing.Color.White
        Me.lbCurrent1.BorderColor = System.Drawing.Color.DarkGray
        Me.lbCurrent1.BorderSide_Bottom = True
        Me.lbCurrent1.BorderSide_Left = True
        Me.lbCurrent1.BorderSide_Right = True
        Me.lbCurrent1.BorderSide_Top = True
        Me.lbCurrent1.BorderWidth = 1
        Me.lbCurrent1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbCurrent1.IsPassword = False
        Me.lbCurrent1.Location = New System.Drawing.Point(447, 211)
        Me.lbCurrent1.Name = "lbCurrent1"
        Me.lbCurrent1.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent1.TabIndex = 60
        Me.lbCurrent1.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbCurrent1.UseKeyPad = False
        '
        'lbVoltage1
        '
        Me.lbVoltage1.BackColor = System.Drawing.Color.White
        Me.lbVoltage1.BorderColor = System.Drawing.Color.DarkGray
        Me.lbVoltage1.BorderSide_Bottom = True
        Me.lbVoltage1.BorderSide_Left = True
        Me.lbVoltage1.BorderSide_Right = True
        Me.lbVoltage1.BorderSide_Top = True
        Me.lbVoltage1.BorderWidth = 1
        Me.lbVoltage1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbVoltage1.IsPassword = False
        Me.lbVoltage1.Location = New System.Drawing.Point(447, 144)
        Me.lbVoltage1.Name = "lbVoltage1"
        Me.lbVoltage1.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage1.TabIndex = 60
        Me.lbVoltage1.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbVoltage1.UseKeyPad = False
        '
        'VsLabel4
        '
        Me.VsLabel4.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel4.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel4.BorderSide_Bottom = True
        Me.VsLabel4.BorderSide_Left = True
        Me.VsLabel4.BorderSide_Right = True
        Me.VsLabel4.BorderSide_Top = True
        Me.VsLabel4.BorderWidth = 1
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.IsPassword = False
        Me.VsLabel4.Location = New System.Drawing.Point(371, 77)
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel4.TabIndex = 64
        Me.VsLabel4.Text = "전력"
        Me.VsLabel4.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel4.UseKeyPad = False
        '
        'lbPower2
        '
        Me.lbPower2.BackColor = System.Drawing.Color.White
        Me.lbPower2.BorderColor = System.Drawing.Color.DarkGray
        Me.lbPower2.BorderSide_Bottom = True
        Me.lbPower2.BorderSide_Left = True
        Me.lbPower2.BorderSide_Right = True
        Me.lbPower2.BorderSide_Top = True
        Me.lbPower2.BorderWidth = 1
        Me.lbPower2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbPower2.IsPassword = False
        Me.lbPower2.Location = New System.Drawing.Point(447, 77)
        Me.lbPower2.Name = "lbPower2"
        Me.lbPower2.Size = New System.Drawing.Size(110, 50)
        Me.lbPower2.TabIndex = 59
        Me.lbPower2.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbPower2.UseKeyPad = False
        '
        'ucScrollLoadStatus
        '
        Me.ucScrollLoadStatus.Location = New System.Drawing.Point(116, 162)
        Me.ucScrollLoadStatus.Name = "ucScrollLoadStatus"
        Me.ucScrollLoadStatus.Size = New System.Drawing.Size(120, 20)
        Me.ucScrollLoadStatus.TabIndex = 27
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
        Me.lbLoadStatus.Location = New System.Drawing.Point(116, 191)
        Me.lbLoadStatus.Name = "lbLoadStatus"
        Me.lbLoadStatus.Size = New System.Drawing.Size(120, 30)
        Me.lbLoadStatus.TabIndex = 5
        Me.lbLoadStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbLoadStatus.UseKeyPad = True
        '
        'wnd서브화면4_소비
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.VsLabel7)
        Me.Controls.Add(Me.VsLabel6)
        Me.Controls.Add(Me.lbCurrent3)
        Me.Controls.Add(Me.lbVoltage3)
        Me.Controls.Add(Me.lbCurrent2)
        Me.Controls.Add(Me.lbVoltage2)
        Me.Controls.Add(Me.lbCurrent1)
        Me.Controls.Add(Me.lbVoltage1)
        Me.Controls.Add(Me.VsLabel4)
        Me.Controls.Add(Me.lbPower2)
        Me.Controls.Add(Me.ucScrollLoadStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbLoadStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wnd서브화면4_소비"
        Me.Size = New System.Drawing.Size(800, 338)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents lbLoadStatus As PMS.VSLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ucScrollLoadStatus As PMS.ucScrollArrow
    Friend WithEvents VsLabel6 As PMS.VSLabel
    Friend WithEvents lbVoltage3 As PMS.VSLabel
    Friend WithEvents lbVoltage2 As PMS.VSLabel
    Friend WithEvents lbVoltage1 As PMS.VSLabel
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents lbPower2 As PMS.VSLabel
    Friend WithEvents lbCurrent1 As PMS.VSLabel
    Friend WithEvents lbCurrent3 As PMS.VSLabel
    Friend WithEvents VsLabel7 As PMS.VSLabel
    Friend WithEvents lbCurrent2 As PMS.VSLabel

End Class

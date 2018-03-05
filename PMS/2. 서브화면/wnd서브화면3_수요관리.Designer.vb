<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면3_수요관리
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면3_수요관리))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.타이머_상태 = New System.Windows.Forms.Timer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlScreen1 = New System.Windows.Forms.Panel
        Me.VsLabel7 = New PMS.VSLabel
        Me.VsLabel9 = New PMS.VSLabel
        Me.VsLabel6 = New PMS.VSLabel
        Me.lbCurrent3 = New PMS.VSLabel
        Me.lbVoltage3 = New PMS.VSLabel
        Me.lbCurrent2 = New PMS.VSLabel
        Me.lbVoltage2 = New PMS.VSLabel
        Me.lbFrequency = New PMS.VSLabel
        Me.lbCurrent1 = New PMS.VSLabel
        Me.lbVoltage1 = New PMS.VSLabel
        Me.VsLabel4 = New PMS.VSLabel
        Me.lbPower2 = New PMS.VSLabel
        Me.ucScrollGridStatus = New PMS.ucScrollArrow
        Me.lbGridStatus = New PMS.VSLabel
        Me.pnlScreen2 = New System.Windows.Forms.Panel
        Me.lbStatus_Day_Load = New PMS.VSLabel
        Me.VsLabel1 = New PMS.VSLabel
        Me.lbStatus_Day_Inverter = New PMS.VSLabel
        Me.btnSearch_Day = New PMS.VSPictureButton
        Me.lbStatus_Day_Grid = New PMS.VSLabel
        Me.pnlGraphDay = New System.Windows.Forms.Panel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.pnlScreen3 = New System.Windows.Forms.Panel
        Me.lbStatus_Month_Load = New PMS.VSLabel
        Me.lbStatus_Month_Inverter = New PMS.VSLabel
        Me.lbStatus_Month_Grid = New PMS.VSLabel
        Me.cbMonth_Month = New System.Windows.Forms.ComboBox
        Me.VsLabel2 = New PMS.VSLabel
        Me.cbMonth_Year = New System.Windows.Forms.ComboBox
        Me.btnSearch_Month = New PMS.VSPictureButton
        Me.pnlGraphMonth = New System.Windows.Forms.Panel
        Me.pnlScreen4 = New System.Windows.Forms.Panel
        Me.lbStatus_Year_Load = New PMS.VSLabel
        Me.lbStatus_Year_Inverter = New PMS.VSLabel
        Me.lbStatus_Year_Grid = New PMS.VSLabel
        Me.VsLabel3 = New PMS.VSLabel
        Me.cbYear_Year = New System.Windows.Forms.ComboBox
        Me.btnSearch_Year = New PMS.VSPictureButton
        Me.pnlGraphYear = New System.Windows.Forms.Panel
        Me.PageHeader4 = New PMS.VSLabel
        Me.PageHeader3 = New PMS.VSLabel
        Me.PageHeader2 = New PMS.VSLabel
        Me.PageHeader1 = New PMS.VSLabel
        Me.pnlScreen1.SuspendLayout()
        Me.pnlScreen2.SuspendLayout()
        Me.pnlScreen3.SuspendLayout()
        Me.pnlScreen4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(16, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(47, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 2)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(47, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 10)
        '
        '타이머_상태
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(10, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 276)
        '
        'pnlScreen1
        '
        Me.pnlScreen1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen1.Controls.Add(Me.VsLabel7)
        Me.pnlScreen1.Controls.Add(Me.VsLabel9)
        Me.pnlScreen1.Controls.Add(Me.VsLabel6)
        Me.pnlScreen1.Controls.Add(Me.lbCurrent3)
        Me.pnlScreen1.Controls.Add(Me.lbVoltage3)
        Me.pnlScreen1.Controls.Add(Me.lbCurrent2)
        Me.pnlScreen1.Controls.Add(Me.lbVoltage2)
        Me.pnlScreen1.Controls.Add(Me.lbFrequency)
        Me.pnlScreen1.Controls.Add(Me.lbCurrent1)
        Me.pnlScreen1.Controls.Add(Me.lbVoltage1)
        Me.pnlScreen1.Controls.Add(Me.VsLabel4)
        Me.pnlScreen1.Controls.Add(Me.lbPower2)
        Me.pnlScreen1.Controls.Add(Me.ucScrollGridStatus)
        Me.pnlScreen1.Controls.Add(Me.lbGridStatus)
        Me.pnlScreen1.Controls.Add(Me.PictureBox2)
        Me.pnlScreen1.Controls.Add(Me.PictureBox4)
        Me.pnlScreen1.Controls.Add(Me.Label3)
        Me.pnlScreen1.Controls.Add(Me.Label2)
        Me.pnlScreen1.Location = New System.Drawing.Point(10, 338)
        Me.pnlScreen1.Name = "pnlScreen1"
        Me.pnlScreen1.Size = New System.Drawing.Size(784, 283)
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
        Me.VsLabel7.Location = New System.Drawing.Point(352, 212)
        Me.VsLabel7.Name = "VsLabel7"
        Me.VsLabel7.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel7.TabIndex = 58
        Me.VsLabel7.Text = "주파수"
        Me.VsLabel7.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel7.UseKeyPad = False
        '
        'VsLabel9
        '
        Me.VsLabel9.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel9.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel9.BorderSide_Bottom = True
        Me.VsLabel9.BorderSide_Left = True
        Me.VsLabel9.BorderSide_Right = True
        Me.VsLabel9.BorderSide_Top = True
        Me.VsLabel9.BorderWidth = 1
        Me.VsLabel9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel9.IsPassword = False
        Me.VsLabel9.Location = New System.Drawing.Point(352, 148)
        Me.VsLabel9.Name = "VsLabel9"
        Me.VsLabel9.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel9.TabIndex = 58
        Me.VsLabel9.Text = "전류"
        Me.VsLabel9.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel9.UseKeyPad = False
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
        Me.VsLabel6.Location = New System.Drawing.Point(352, 84)
        Me.VsLabel6.Name = "VsLabel6"
        Me.VsLabel6.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel6.TabIndex = 58
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
        Me.lbCurrent3.Location = New System.Drawing.Point(660, 148)
        Me.lbCurrent3.Name = "lbCurrent3"
        Me.lbCurrent3.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent3.TabIndex = 57
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
        Me.lbVoltage3.Location = New System.Drawing.Point(660, 84)
        Me.lbVoltage3.Name = "lbVoltage3"
        Me.lbVoltage3.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage3.TabIndex = 57
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
        Me.lbCurrent2.Location = New System.Drawing.Point(544, 148)
        Me.lbCurrent2.Name = "lbCurrent2"
        Me.lbCurrent2.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent2.TabIndex = 57
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
        Me.lbVoltage2.Location = New System.Drawing.Point(544, 84)
        Me.lbVoltage2.Name = "lbVoltage2"
        Me.lbVoltage2.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage2.TabIndex = 57
        Me.lbVoltage2.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbVoltage2.UseKeyPad = False
        '
        'lbFrequency
        '
        Me.lbFrequency.BackColor = System.Drawing.Color.White
        Me.lbFrequency.BorderColor = System.Drawing.Color.DarkGray
        Me.lbFrequency.BorderSide_Bottom = True
        Me.lbFrequency.BorderSide_Left = True
        Me.lbFrequency.BorderSide_Right = True
        Me.lbFrequency.BorderSide_Top = True
        Me.lbFrequency.BorderWidth = 1
        Me.lbFrequency.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbFrequency.IsPassword = False
        Me.lbFrequency.Location = New System.Drawing.Point(428, 212)
        Me.lbFrequency.Name = "lbFrequency"
        Me.lbFrequency.Size = New System.Drawing.Size(110, 50)
        Me.lbFrequency.TabIndex = 57
        Me.lbFrequency.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbFrequency.UseKeyPad = False
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
        Me.lbCurrent1.Location = New System.Drawing.Point(428, 148)
        Me.lbCurrent1.Name = "lbCurrent1"
        Me.lbCurrent1.Size = New System.Drawing.Size(110, 50)
        Me.lbCurrent1.TabIndex = 57
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
        Me.lbVoltage1.Location = New System.Drawing.Point(428, 84)
        Me.lbVoltage1.Name = "lbVoltage1"
        Me.lbVoltage1.Size = New System.Drawing.Size(110, 50)
        Me.lbVoltage1.TabIndex = 57
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
        Me.VsLabel4.Location = New System.Drawing.Point(352, 20)
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(70, 50)
        Me.VsLabel4.TabIndex = 58
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
        Me.lbPower2.Location = New System.Drawing.Point(428, 20)
        Me.lbPower2.Name = "lbPower2"
        Me.lbPower2.Size = New System.Drawing.Size(110, 50)
        Me.lbPower2.TabIndex = 57
        Me.lbPower2.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbPower2.UseKeyPad = False
        '
        'ucScrollGridStatus
        '
        Me.ucScrollGridStatus.Location = New System.Drawing.Point(99, 135)
        Me.ucScrollGridStatus.Name = "ucScrollGridStatus"
        Me.ucScrollGridStatus.Size = New System.Drawing.Size(120, 20)
        Me.ucScrollGridStatus.TabIndex = 34
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
        Me.lbGridStatus.Location = New System.Drawing.Point(99, 91)
        Me.lbGridStatus.Name = "lbGridStatus"
        Me.lbGridStatus.Size = New System.Drawing.Size(120, 30)
        Me.lbGridStatus.TabIndex = 10
        Me.lbGridStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbGridStatus.UseKeyPad = True
        '
        'pnlScreen2
        '
        Me.pnlScreen2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen2.Controls.Add(Me.lbStatus_Day_Load)
        Me.pnlScreen2.Controls.Add(Me.VsLabel1)
        Me.pnlScreen2.Controls.Add(Me.lbStatus_Day_Inverter)
        Me.pnlScreen2.Controls.Add(Me.btnSearch_Day)
        Me.pnlScreen2.Controls.Add(Me.lbStatus_Day_Grid)
        Me.pnlScreen2.Controls.Add(Me.pnlGraphDay)
        Me.pnlScreen2.Controls.Add(Me.DateTimePicker1)
        Me.pnlScreen2.Location = New System.Drawing.Point(800, 338)
        Me.pnlScreen2.Name = "pnlScreen2"
        Me.pnlScreen2.Size = New System.Drawing.Size(784, 283)
        '
        'lbStatus_Day_Load
        '
        Me.lbStatus_Day_Load.BackColor = System.Drawing.Color.Blue
        Me.lbStatus_Day_Load.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Day_Load.BorderSide_Bottom = False
        Me.lbStatus_Day_Load.BorderSide_Left = False
        Me.lbStatus_Day_Load.BorderSide_Right = False
        Me.lbStatus_Day_Load.BorderSide_Top = False
        Me.lbStatus_Day_Load.BorderWidth = 0
        Me.lbStatus_Day_Load.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Day_Load.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Day_Load.IsPassword = False
        Me.lbStatus_Day_Load.Location = New System.Drawing.Point(652, 7)
        Me.lbStatus_Day_Load.Name = "lbStatus_Day_Load"
        Me.lbStatus_Day_Load.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Day_Load.TabIndex = 33
        Me.lbStatus_Day_Load.Text = "로드"
        Me.lbStatus_Day_Load.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Day_Load.UseKeyPad = False
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.White
        Me.VsLabel1.BorderColor = System.Drawing.Color.Black
        Me.VsLabel1.BorderSide_Bottom = False
        Me.VsLabel1.BorderSide_Left = False
        Me.VsLabel1.BorderSide_Right = False
        Me.VsLabel1.BorderSide_Top = False
        Me.VsLabel1.BorderWidth = 0
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.VsLabel1.IsPassword = False
        Me.VsLabel1.Location = New System.Drawing.Point(13, 9)
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(76, 20)
        Me.VsLabel1.TabIndex = 33
        Me.VsLabel1.Text = "일자선택 :"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Far
        Me.VsLabel1.UseKeyPad = False
        '
        'lbStatus_Day_Inverter
        '
        Me.lbStatus_Day_Inverter.BackColor = System.Drawing.Color.Green
        Me.lbStatus_Day_Inverter.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Day_Inverter.BorderSide_Bottom = False
        Me.lbStatus_Day_Inverter.BorderSide_Left = False
        Me.lbStatus_Day_Inverter.BorderSide_Right = False
        Me.lbStatus_Day_Inverter.BorderSide_Top = False
        Me.lbStatus_Day_Inverter.BorderWidth = 0
        Me.lbStatus_Day_Inverter.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Day_Inverter.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Day_Inverter.IsPassword = False
        Me.lbStatus_Day_Inverter.Location = New System.Drawing.Point(526, 7)
        Me.lbStatus_Day_Inverter.Name = "lbStatus_Day_Inverter"
        Me.lbStatus_Day_Inverter.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Day_Inverter.TabIndex = 33
        Me.lbStatus_Day_Inverter.Text = "인버터"
        Me.lbStatus_Day_Inverter.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Day_Inverter.UseKeyPad = False
        '
        'btnSearch_Day
        '
        Me.btnSearch_Day.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch_Day.BorderSide_Bottom = True
        Me.btnSearch_Day.BorderSide_Left = True
        Me.btnSearch_Day.BorderSide_Right = True
        Me.btnSearch_Day.BorderSide_Top = True
        Me.btnSearch_Day.BorderWidth = 1
        Me.btnSearch_Day.Location = New System.Drawing.Point(291, 7)
        Me.btnSearch_Day.Name = "btnSearch_Day"
        Me.btnSearch_Day.Selected = False
        Me.btnSearch_Day.Size = New System.Drawing.Size(93, 24)
        Me.btnSearch_Day.TabIndex = 3
        Me.btnSearch_Day.Text = "조회"
        '
        'lbStatus_Day_Grid
        '
        Me.lbStatus_Day_Grid.BackColor = System.Drawing.Color.Red
        Me.lbStatus_Day_Grid.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Day_Grid.BorderSide_Bottom = False
        Me.lbStatus_Day_Grid.BorderSide_Left = False
        Me.lbStatus_Day_Grid.BorderSide_Right = False
        Me.lbStatus_Day_Grid.BorderSide_Top = False
        Me.lbStatus_Day_Grid.BorderWidth = 0
        Me.lbStatus_Day_Grid.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Day_Grid.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Day_Grid.IsPassword = False
        Me.lbStatus_Day_Grid.Location = New System.Drawing.Point(400, 7)
        Me.lbStatus_Day_Grid.Name = "lbStatus_Day_Grid"
        Me.lbStatus_Day_Grid.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Day_Grid.TabIndex = 33
        Me.lbStatus_Day_Grid.Text = "그리드"
        Me.lbStatus_Day_Grid.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Day_Grid.UseKeyPad = False
        '
        'pnlGraphDay
        '
        Me.pnlGraphDay.BackColor = System.Drawing.Color.White
        Me.pnlGraphDay.Location = New System.Drawing.Point(13, 37)
        Me.pnlGraphDay.Name = "pnlGraphDay"
        Me.pnlGraphDay.Size = New System.Drawing.Size(759, 239)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(190, 24)
        Me.DateTimePicker1.TabIndex = 1
        '
        'pnlScreen3
        '
        Me.pnlScreen3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen3.Controls.Add(Me.lbStatus_Month_Load)
        Me.pnlScreen3.Controls.Add(Me.lbStatus_Month_Inverter)
        Me.pnlScreen3.Controls.Add(Me.lbStatus_Month_Grid)
        Me.pnlScreen3.Controls.Add(Me.cbMonth_Month)
        Me.pnlScreen3.Controls.Add(Me.VsLabel2)
        Me.pnlScreen3.Controls.Add(Me.cbMonth_Year)
        Me.pnlScreen3.Controls.Add(Me.btnSearch_Month)
        Me.pnlScreen3.Controls.Add(Me.pnlGraphMonth)
        Me.pnlScreen3.Location = New System.Drawing.Point(10, 627)
        Me.pnlScreen3.Name = "pnlScreen3"
        Me.pnlScreen3.Size = New System.Drawing.Size(784, 283)
        '
        'lbStatus_Month_Load
        '
        Me.lbStatus_Month_Load.BackColor = System.Drawing.Color.Blue
        Me.lbStatus_Month_Load.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Month_Load.BorderSide_Bottom = False
        Me.lbStatus_Month_Load.BorderSide_Left = False
        Me.lbStatus_Month_Load.BorderSide_Right = False
        Me.lbStatus_Month_Load.BorderSide_Top = False
        Me.lbStatus_Month_Load.BorderWidth = 0
        Me.lbStatus_Month_Load.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Month_Load.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Month_Load.IsPassword = False
        Me.lbStatus_Month_Load.Location = New System.Drawing.Point(652, 7)
        Me.lbStatus_Month_Load.Name = "lbStatus_Month_Load"
        Me.lbStatus_Month_Load.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Month_Load.TabIndex = 37
        Me.lbStatus_Month_Load.Text = "로드"
        Me.lbStatus_Month_Load.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Month_Load.UseKeyPad = False
        '
        'lbStatus_Month_Inverter
        '
        Me.lbStatus_Month_Inverter.BackColor = System.Drawing.Color.Green
        Me.lbStatus_Month_Inverter.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Month_Inverter.BorderSide_Bottom = False
        Me.lbStatus_Month_Inverter.BorderSide_Left = False
        Me.lbStatus_Month_Inverter.BorderSide_Right = False
        Me.lbStatus_Month_Inverter.BorderSide_Top = False
        Me.lbStatus_Month_Inverter.BorderWidth = 0
        Me.lbStatus_Month_Inverter.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Month_Inverter.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Month_Inverter.IsPassword = False
        Me.lbStatus_Month_Inverter.Location = New System.Drawing.Point(526, 7)
        Me.lbStatus_Month_Inverter.Name = "lbStatus_Month_Inverter"
        Me.lbStatus_Month_Inverter.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Month_Inverter.TabIndex = 36
        Me.lbStatus_Month_Inverter.Text = "인버터"
        Me.lbStatus_Month_Inverter.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Month_Inverter.UseKeyPad = False
        '
        'lbStatus_Month_Grid
        '
        Me.lbStatus_Month_Grid.BackColor = System.Drawing.Color.Red
        Me.lbStatus_Month_Grid.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Month_Grid.BorderSide_Bottom = False
        Me.lbStatus_Month_Grid.BorderSide_Left = False
        Me.lbStatus_Month_Grid.BorderSide_Right = False
        Me.lbStatus_Month_Grid.BorderSide_Top = False
        Me.lbStatus_Month_Grid.BorderWidth = 0
        Me.lbStatus_Month_Grid.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Month_Grid.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Month_Grid.IsPassword = False
        Me.lbStatus_Month_Grid.Location = New System.Drawing.Point(400, 7)
        Me.lbStatus_Month_Grid.Name = "lbStatus_Month_Grid"
        Me.lbStatus_Month_Grid.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Month_Grid.TabIndex = 35
        Me.lbStatus_Month_Grid.Text = "그리드"
        Me.lbStatus_Month_Grid.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Month_Grid.UseKeyPad = False
        '
        'cbMonth_Month
        '
        Me.cbMonth_Month.Location = New System.Drawing.Point(187, 8)
        Me.cbMonth_Month.Name = "cbMonth_Month"
        Me.cbMonth_Month.Size = New System.Drawing.Size(81, 23)
        Me.cbMonth_Month.TabIndex = 6
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.White
        Me.VsLabel2.BorderColor = System.Drawing.Color.Black
        Me.VsLabel2.BorderSide_Bottom = False
        Me.VsLabel2.BorderSide_Left = False
        Me.VsLabel2.BorderSide_Right = False
        Me.VsLabel2.BorderSide_Top = False
        Me.VsLabel2.BorderWidth = 0
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.VsLabel2.IsPassword = False
        Me.VsLabel2.Location = New System.Drawing.Point(13, 9)
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(76, 20)
        Me.VsLabel2.TabIndex = 34
        Me.VsLabel2.Text = "년월선택 :"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Far
        Me.VsLabel2.UseKeyPad = False
        '
        'cbMonth_Year
        '
        Me.cbMonth_Year.Location = New System.Drawing.Point(95, 8)
        Me.cbMonth_Year.Name = "cbMonth_Year"
        Me.cbMonth_Year.Size = New System.Drawing.Size(86, 23)
        Me.cbMonth_Year.TabIndex = 6
        '
        'btnSearch_Month
        '
        Me.btnSearch_Month.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch_Month.BorderSide_Bottom = True
        Me.btnSearch_Month.BorderSide_Left = True
        Me.btnSearch_Month.BorderSide_Right = True
        Me.btnSearch_Month.BorderSide_Top = True
        Me.btnSearch_Month.BorderWidth = 1
        Me.btnSearch_Month.Location = New System.Drawing.Point(274, 7)
        Me.btnSearch_Month.Name = "btnSearch_Month"
        Me.btnSearch_Month.Selected = False
        Me.btnSearch_Month.Size = New System.Drawing.Size(93, 24)
        Me.btnSearch_Month.TabIndex = 3
        Me.btnSearch_Month.Text = "조회"
        '
        'pnlGraphMonth
        '
        Me.pnlGraphMonth.BackColor = System.Drawing.Color.White
        Me.pnlGraphMonth.Location = New System.Drawing.Point(13, 37)
        Me.pnlGraphMonth.Name = "pnlGraphMonth"
        Me.pnlGraphMonth.Size = New System.Drawing.Size(759, 239)
        '
        'pnlScreen4
        '
        Me.pnlScreen4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen4.Controls.Add(Me.lbStatus_Year_Load)
        Me.pnlScreen4.Controls.Add(Me.lbStatus_Year_Inverter)
        Me.pnlScreen4.Controls.Add(Me.lbStatus_Year_Grid)
        Me.pnlScreen4.Controls.Add(Me.VsLabel3)
        Me.pnlScreen4.Controls.Add(Me.cbYear_Year)
        Me.pnlScreen4.Controls.Add(Me.btnSearch_Year)
        Me.pnlScreen4.Controls.Add(Me.pnlGraphYear)
        Me.pnlScreen4.Location = New System.Drawing.Point(800, 627)
        Me.pnlScreen4.Name = "pnlScreen4"
        Me.pnlScreen4.Size = New System.Drawing.Size(784, 283)
        '
        'lbStatus_Year_Load
        '
        Me.lbStatus_Year_Load.BackColor = System.Drawing.Color.Blue
        Me.lbStatus_Year_Load.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Year_Load.BorderSide_Bottom = False
        Me.lbStatus_Year_Load.BorderSide_Left = False
        Me.lbStatus_Year_Load.BorderSide_Right = False
        Me.lbStatus_Year_Load.BorderSide_Top = False
        Me.lbStatus_Year_Load.BorderWidth = 0
        Me.lbStatus_Year_Load.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Year_Load.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Year_Load.IsPassword = False
        Me.lbStatus_Year_Load.Location = New System.Drawing.Point(652, 7)
        Me.lbStatus_Year_Load.Name = "lbStatus_Year_Load"
        Me.lbStatus_Year_Load.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Year_Load.TabIndex = 38
        Me.lbStatus_Year_Load.Text = "로드"
        Me.lbStatus_Year_Load.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Year_Load.UseKeyPad = False
        '
        'lbStatus_Year_Inverter
        '
        Me.lbStatus_Year_Inverter.BackColor = System.Drawing.Color.Green
        Me.lbStatus_Year_Inverter.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Year_Inverter.BorderSide_Bottom = False
        Me.lbStatus_Year_Inverter.BorderSide_Left = False
        Me.lbStatus_Year_Inverter.BorderSide_Right = False
        Me.lbStatus_Year_Inverter.BorderSide_Top = False
        Me.lbStatus_Year_Inverter.BorderWidth = 0
        Me.lbStatus_Year_Inverter.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Year_Inverter.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Year_Inverter.IsPassword = False
        Me.lbStatus_Year_Inverter.Location = New System.Drawing.Point(526, 7)
        Me.lbStatus_Year_Inverter.Name = "lbStatus_Year_Inverter"
        Me.lbStatus_Year_Inverter.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Year_Inverter.TabIndex = 37
        Me.lbStatus_Year_Inverter.Text = "인버터"
        Me.lbStatus_Year_Inverter.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Year_Inverter.UseKeyPad = False
        '
        'lbStatus_Year_Grid
        '
        Me.lbStatus_Year_Grid.BackColor = System.Drawing.Color.Red
        Me.lbStatus_Year_Grid.BorderColor = System.Drawing.Color.Black
        Me.lbStatus_Year_Grid.BorderSide_Bottom = False
        Me.lbStatus_Year_Grid.BorderSide_Left = False
        Me.lbStatus_Year_Grid.BorderSide_Right = False
        Me.lbStatus_Year_Grid.BorderSide_Top = False
        Me.lbStatus_Year_Grid.BorderWidth = 0
        Me.lbStatus_Year_Grid.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lbStatus_Year_Grid.ForeColor = System.Drawing.Color.White
        Me.lbStatus_Year_Grid.IsPassword = False
        Me.lbStatus_Year_Grid.Location = New System.Drawing.Point(400, 7)
        Me.lbStatus_Year_Grid.Name = "lbStatus_Year_Grid"
        Me.lbStatus_Year_Grid.Size = New System.Drawing.Size(120, 25)
        Me.lbStatus_Year_Grid.TabIndex = 36
        Me.lbStatus_Year_Grid.Text = "그리드"
        Me.lbStatus_Year_Grid.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbStatus_Year_Grid.UseKeyPad = False
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.White
        Me.VsLabel3.BorderColor = System.Drawing.Color.Black
        Me.VsLabel3.BorderSide_Bottom = False
        Me.VsLabel3.BorderSide_Left = False
        Me.VsLabel3.BorderSide_Right = False
        Me.VsLabel3.BorderSide_Top = False
        Me.VsLabel3.BorderWidth = 0
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.VsLabel3.IsPassword = False
        Me.VsLabel3.Location = New System.Drawing.Point(13, 9)
        Me.VsLabel3.Name = "VsLabel3"
        Me.VsLabel3.Size = New System.Drawing.Size(76, 20)
        Me.VsLabel3.TabIndex = 35
        Me.VsLabel3.Text = "년도선택 :"
        Me.VsLabel3.TextAlign = System.Drawing.StringAlignment.Far
        Me.VsLabel3.UseKeyPad = False
        '
        'cbYear_Year
        '
        Me.cbYear_Year.Location = New System.Drawing.Point(95, 8)
        Me.cbYear_Year.Name = "cbYear_Year"
        Me.cbYear_Year.Size = New System.Drawing.Size(86, 23)
        Me.cbYear_Year.TabIndex = 7
        '
        'btnSearch_Year
        '
        Me.btnSearch_Year.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch_Year.BorderSide_Bottom = True
        Me.btnSearch_Year.BorderSide_Left = True
        Me.btnSearch_Year.BorderSide_Right = True
        Me.btnSearch_Year.BorderSide_Top = True
        Me.btnSearch_Year.BorderWidth = 1
        Me.btnSearch_Year.Location = New System.Drawing.Point(187, 7)
        Me.btnSearch_Year.Name = "btnSearch_Year"
        Me.btnSearch_Year.Selected = False
        Me.btnSearch_Year.Size = New System.Drawing.Size(93, 24)
        Me.btnSearch_Year.TabIndex = 3
        Me.btnSearch_Year.Text = "조회"
        '
        'pnlGraphYear
        '
        Me.pnlGraphYear.BackColor = System.Drawing.Color.White
        Me.pnlGraphYear.Location = New System.Drawing.Point(13, 37)
        Me.pnlGraphYear.Name = "pnlGraphYear"
        Me.pnlGraphYear.Size = New System.Drawing.Size(759, 239)
        '
        'PageHeader4
        '
        Me.PageHeader4.BackColor = System.Drawing.Color.White
        Me.PageHeader4.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader4.BorderSide_Bottom = False
        Me.PageHeader4.BorderSide_Left = False
        Me.PageHeader4.BorderSide_Right = True
        Me.PageHeader4.BorderSide_Top = True
        Me.PageHeader4.BorderWidth = 1
        Me.PageHeader4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader4.Location = New System.Drawing.Point(460, 10)
        Me.PageHeader4.Name = "PageHeader4"
        Me.PageHeader4.Size = New System.Drawing.Size(150, 40)
        Me.PageHeader4.TabIndex = 29
        Me.PageHeader4.Text = "연간 수요관리"
        Me.PageHeader4.TextAlign = System.Drawing.StringAlignment.Center
        '
        'PageHeader3
        '
        Me.PageHeader3.BackColor = System.Drawing.Color.White
        Me.PageHeader3.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader3.BorderSide_Bottom = False
        Me.PageHeader3.BorderSide_Left = False
        Me.PageHeader3.BorderSide_Right = True
        Me.PageHeader3.BorderSide_Top = True
        Me.PageHeader3.BorderWidth = 1
        Me.PageHeader3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader3.Location = New System.Drawing.Point(310, 10)
        Me.PageHeader3.Name = "PageHeader3"
        Me.PageHeader3.Size = New System.Drawing.Size(150, 40)
        Me.PageHeader3.TabIndex = 28
        Me.PageHeader3.Text = "월간 수요관리"
        Me.PageHeader3.TextAlign = System.Drawing.StringAlignment.Center
        '
        'PageHeader2
        '
        Me.PageHeader2.BackColor = System.Drawing.Color.White
        Me.PageHeader2.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader2.BorderSide_Bottom = False
        Me.PageHeader2.BorderSide_Left = False
        Me.PageHeader2.BorderSide_Right = True
        Me.PageHeader2.BorderSide_Top = True
        Me.PageHeader2.BorderWidth = 1
        Me.PageHeader2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader2.Location = New System.Drawing.Point(160, 10)
        Me.PageHeader2.Name = "PageHeader2"
        Me.PageHeader2.Size = New System.Drawing.Size(150, 40)
        Me.PageHeader2.TabIndex = 25
        Me.PageHeader2.Text = "일일 수요관리"
        Me.PageHeader2.TextAlign = System.Drawing.StringAlignment.Center
        '
        'PageHeader1
        '
        Me.PageHeader1.BackColor = System.Drawing.Color.White
        Me.PageHeader1.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader1.BorderSide_Bottom = False
        Me.PageHeader1.BorderSide_Left = True
        Me.PageHeader1.BorderSide_Right = True
        Me.PageHeader1.BorderSide_Top = True
        Me.PageHeader1.BorderWidth = 1
        Me.PageHeader1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader1.Location = New System.Drawing.Point(10, 10)
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Size = New System.Drawing.Size(150, 40)
        Me.PageHeader1.TabIndex = 26
        Me.PageHeader1.Text = "개 요"
        Me.PageHeader1.TextAlign = System.Drawing.StringAlignment.Center
        '
        'wnd서브화면3_수요관리
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlScreen4)
        Me.Controls.Add(Me.pnlScreen3)
        Me.Controls.Add(Me.PageHeader4)
        Me.Controls.Add(Me.PageHeader3)
        Me.Controls.Add(Me.pnlScreen2)
        Me.Controls.Add(Me.pnlScreen1)
        Me.Controls.Add(Me.PageHeader2)
        Me.Controls.Add(Me.PageHeader1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "wnd서브화면3_수요관리"
        Me.Size = New System.Drawing.Size(1700, 921)
        Me.pnlScreen1.ResumeLayout(False)
        Me.pnlScreen2.ResumeLayout(False)
        Me.pnlScreen3.ResumeLayout(False)
        Me.pnlScreen4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbGridStatus As PMS.VSLabel
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents PageHeader2 As PMS.VSLabel
    Friend WithEvents PageHeader1 As PMS.VSLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen1 As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlGraphDay As System.Windows.Forms.Panel
    Friend WithEvents btnSearch_Day As PMS.VSPictureButton
    Friend WithEvents PageHeader3 As PMS.VSLabel
    Friend WithEvents PageHeader4 As PMS.VSLabel
    Friend WithEvents pnlScreen3 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch_Month As PMS.VSPictureButton
    Friend WithEvents pnlGraphMonth As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen4 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch_Year As PMS.VSPictureButton
    Friend WithEvents pnlGraphYear As System.Windows.Forms.Panel
    Friend WithEvents cbMonth_Month As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonth_Year As System.Windows.Forms.ComboBox
    Friend WithEvents cbYear_Year As System.Windows.Forms.ComboBox
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents lbStatus_Day_Load As PMS.VSLabel
    Friend WithEvents lbStatus_Day_Inverter As PMS.VSLabel
    Friend WithEvents lbStatus_Day_Grid As PMS.VSLabel
    Friend WithEvents lbStatus_Month_Load As PMS.VSLabel
    Friend WithEvents lbStatus_Month_Inverter As PMS.VSLabel
    Friend WithEvents lbStatus_Month_Grid As PMS.VSLabel
    Friend WithEvents lbStatus_Year_Load As PMS.VSLabel
    Friend WithEvents lbStatus_Year_Inverter As PMS.VSLabel
    Friend WithEvents lbStatus_Year_Grid As PMS.VSLabel
    Friend WithEvents ucScrollGridStatus As PMS.ucScrollArrow
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents lbPower2 As PMS.VSLabel
    Friend WithEvents VsLabel6 As PMS.VSLabel
    Friend WithEvents lbVoltage3 As PMS.VSLabel
    Friend WithEvents lbVoltage2 As PMS.VSLabel
    Friend WithEvents lbVoltage1 As PMS.VSLabel
    Friend WithEvents VsLabel7 As PMS.VSLabel
    Friend WithEvents VsLabel9 As PMS.VSLabel
    Friend WithEvents lbCurrent3 As PMS.VSLabel
    Friend WithEvents lbCurrent2 As PMS.VSLabel
    Friend WithEvents lbFrequency As PMS.VSLabel
    Friend WithEvents lbCurrent1 As PMS.VSLabel

End Class

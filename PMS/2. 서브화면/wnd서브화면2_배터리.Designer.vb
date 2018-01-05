<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wnd서브화면2_배터리
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면2_배터리))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel = New System.Windows.Forms.Panel
        Me.BMS타이머_상태 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.VSaddress = New PMS.VSLabel
        Me.VSStatus = New PMS.VSLabel
        Me.VSmodule = New PMS.VSLabel
        Me.VSrack = New PMS.VSLabel
        Me.VsGroupBox1 = New PMS.VSGroupBox
        Me.VsLabel1 = New PMS.VSLabel
        Me.VsLabel4 = New PMS.VSLabel
        Me.pbBattery = New System.Windows.Forms.PictureBox
        Me.VsLabel7 = New PMS.VSLabel
        Me.lChargingStatus = New PMS.VSLabel
        Me.VsLabel3 = New PMS.VSLabel
        Me.lSOC = New PMS.VSLabel
        Me.VsLabel6 = New PMS.VSLabel
        Me.lSOH = New PMS.VSLabel
        Me.VsLabel2 = New PMS.VSLabel
        Me.lPower = New PMS.VSLabel
        Me.VsLabel5 = New PMS.VSLabel
        Me.lVoltage = New PMS.VSLabel
        Me.lTemperature = New PMS.VSLabel
        Me.lCurrent = New PMS.VSLabel
        Me.VsGroupBox2 = New PMS.VSGroupBox
        Me.VsLabel8 = New PMS.VSLabel
        Me.lbBatteryDischarge_Today = New PMS.VSLabel
        Me.VsLabel9 = New PMS.VSLabel
        Me.lbBatteryCharge_Today = New PMS.VSLabel
        Me.VsLabel13 = New PMS.VSLabel
        Me.lbBatteryDischarge_Yesterday = New PMS.VSLabel
        Me.VsLabel12 = New PMS.VSLabel
        Me.lbBatteryCharge_Yesterday = New PMS.VSLabel
        Me.VsLabel10 = New PMS.VSLabel
        Me.lbBatteryDischarge_Total = New PMS.VSLabel
        Me.lbBatteryCharge_Total = New PMS.VSLabel
        Me.btn_Close = New PMS.VSLabel
        Me.btn_Open = New PMS.VSLabel
        Me.btn_None = New PMS.VSLabel
        Me.VsLabel66 = New PMS.VSLabel
        Me.VsLabel61 = New PMS.VSLabel
        Me.lCell최대전압 = New PMS.VSLabel
        Me.VsLabel58 = New PMS.VSLabel
        Me.lCell최대전압위치 = New PMS.VSLabel
        Me.VsLabel53 = New PMS.VSLabel
        Me.lCell최소전압 = New PMS.VSLabel
        Me.VsLabel51 = New PMS.VSLabel
        Me.lCell최소전압위치 = New PMS.VSLabel
        Me.lCell전압편차 = New PMS.VSLabel
        Me.VsLabel30 = New PMS.VSLabel
        Me.VsLabel31 = New PMS.VSLabel
        Me.l랙SOC = New PMS.VSLabel
        Me.VsLabel34 = New PMS.VSLabel
        Me.lCell평균전압 = New PMS.VSLabel
        Me.l랙SOH = New PMS.VSLabel
        Me.l랙전류 = New PMS.VSLabel
        Me.VsLabel38 = New PMS.VSLabel
        Me.l랙전압 = New PMS.VSLabel
        Me.VsLabel14 = New PMS.VSLabel
        Me.VsLabel15 = New PMS.VSLabel
        Me.VsLabel16 = New PMS.VSLabel
        Me.l랙평균모듈온도 = New PMS.VSLabel
        Me.lCell최대온도 = New PMS.VSLabel
        Me.lCell온도편차 = New PMS.VSLabel
        Me.VsLabel17 = New PMS.VSLabel
        Me.VsLabel18 = New PMS.VSLabel
        Me.lCell최대온도위치 = New PMS.VSLabel
        Me.lCell최소온도위치 = New PMS.VSLabel
        Me.VsLabel19 = New PMS.VSLabel
        Me.VsLabel20 = New PMS.VSLabel
        Me.lCell최소온도 = New PMS.VSLabel
        Me.VsGroupBox3 = New PMS.VSGroupBox
        Me.VsLabel121 = New PMS.VSLabel
        Me.btn_Module17 = New PMS.VSLabel
        Me.btn_Module1 = New PMS.VSLabel
        Me.btn_Module16 = New PMS.VSLabel
        Me.btn_Module2 = New PMS.VSLabel
        Me.btn_Module13 = New PMS.VSLabel
        Me.btn_Module3 = New PMS.VSLabel
        Me.btn_Module15 = New PMS.VSLabel
        Me.btn_Module4 = New PMS.VSLabel
        Me.btn_Module12 = New PMS.VSLabel
        Me.btn_Module5 = New PMS.VSLabel
        Me.btn_Module14 = New PMS.VSLabel
        Me.btn_Module6 = New PMS.VSLabel
        Me.btn_Module11 = New PMS.VSLabel
        Me.btn_Module7 = New PMS.VSLabel
        Me.btn_Module10 = New PMS.VSLabel
        Me.btn_Module8 = New PMS.VSLabel
        Me.btn_Module9 = New PMS.VSLabel
        Me.VsGroupBox4 = New PMS.VSGroupBox
        Me.VsLabel40 = New PMS.VSLabel
        Me.VsLabel52 = New PMS.VSLabel
        Me.l모듈최고최저온도위치 = New PMS.VSLabel
        Me.VsLabel63 = New PMS.VSLabel
        Me.l모듈최저온도 = New PMS.VSLabel
        Me.l최고최저셀전압위치 = New PMS.VSLabel
        Me.VsLabel41 = New PMS.VSLabel
        Me.l모듈내Cell최대전압 = New PMS.VSLabel
        Me.VsLabel55 = New PMS.VSLabel
        Me.VsLabel48 = New PMS.VSLabel
        Me.l모듈내Cell최저전압 = New PMS.VSLabel
        Me.VsLabel56 = New PMS.VSLabel
        Me.VsLabel67 = New PMS.VSLabel
        Me.l모듈전압 = New PMS.VSLabel
        Me.VsLabel45 = New PMS.VSLabel
        Me.l모듈최고온도 = New PMS.VSLabel
        Me.l모듈평균온도 = New PMS.VSLabel
        Me.l모듈내Cell평균전압 = New PMS.VSLabel
        Me.VsLabel44 = New PMS.VSLabel
        Me.btn_Module = New PMS.VSLabel
        Me.PageHeader4 = New PMS.VSLabel
        Me.PageHeader2 = New PMS.VSLabel
        Me.PageHeader3 = New PMS.VSLabel
        Me.PageHeader1 = New PMS.VSLabel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.VsGroupBox1.SuspendLayout()
        CType(Me.pbBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VsGroupBox2.SuspendLayout()
        Me.VsGroupBox3.SuspendLayout()
        Me.VsGroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.VsGroupBox1)
        Me.Panel1.Controls.Add(Me.VsGroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(799, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 283)
        Me.Panel1.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btn_Close)
        Me.Panel2.Controls.Add(Me.btn_Open)
        Me.Panel2.Controls.Add(Me.btn_None)
        Me.Panel2.Controls.Add(Me.VsLabel66)
        Me.Panel2.Controls.Add(Me.VsLabel61)
        Me.Panel2.Controls.Add(Me.lCell최대전압)
        Me.Panel2.Controls.Add(Me.VsLabel58)
        Me.Panel2.Controls.Add(Me.lCell최대전압위치)
        Me.Panel2.Controls.Add(Me.VsLabel53)
        Me.Panel2.Controls.Add(Me.lCell최소전압)
        Me.Panel2.Controls.Add(Me.VsLabel51)
        Me.Panel2.Controls.Add(Me.lCell최소전압위치)
        Me.Panel2.Controls.Add(Me.lCell전압편차)
        Me.Panel2.Controls.Add(Me.VsLabel30)
        Me.Panel2.Controls.Add(Me.VsLabel31)
        Me.Panel2.Controls.Add(Me.l랙SOC)
        Me.Panel2.Controls.Add(Me.VsLabel34)
        Me.Panel2.Controls.Add(Me.lCell평균전압)
        Me.Panel2.Controls.Add(Me.l랙SOH)
        Me.Panel2.Controls.Add(Me.l랙전류)
        Me.Panel2.Controls.Add(Me.VsLabel38)
        Me.Panel2.Controls.Add(Me.l랙전압)
        Me.Panel2.Controls.Add(Me.VsLabel14)
        Me.Panel2.Controls.Add(Me.VsLabel15)
        Me.Panel2.Controls.Add(Me.VsLabel16)
        Me.Panel2.Controls.Add(Me.l랙평균모듈온도)
        Me.Panel2.Controls.Add(Me.lCell최대온도)
        Me.Panel2.Controls.Add(Me.lCell온도편차)
        Me.Panel2.Controls.Add(Me.VsLabel17)
        Me.Panel2.Controls.Add(Me.VsLabel18)
        Me.Panel2.Controls.Add(Me.lCell최대온도위치)
        Me.Panel2.Controls.Add(Me.lCell최소온도위치)
        Me.Panel2.Controls.Add(Me.VsLabel19)
        Me.Panel2.Controls.Add(Me.VsLabel20)
        Me.Panel2.Controls.Add(Me.lCell최소온도)
        Me.Panel2.Location = New System.Drawing.Point(9, 343)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 283)
        Me.Panel2.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.VsGroupBox3)
        Me.Panel3.Controls.Add(Me.VsGroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(799, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 276)
        Me.Panel3.TabIndex = 60
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel.Location = New System.Drawing.Point(9, 45)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(784, 276)
        Me.Panel.TabIndex = 58
        '
        'BMS타이머_상태
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(424, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 12)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Rack"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Module"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 12)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 12)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Address"
        '
        'VSaddress
        '
        Me.VSaddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VSaddress.BackImage = Nothing
        Me.VSaddress.BorderColor = System.Drawing.Color.DarkGray
        Me.VSaddress.BorderSide_Bottom = True
        Me.VSaddress.BorderSide_Left = True
        Me.VSaddress.BorderSide_Right = True
        Me.VSaddress.BorderSide_Top = True
        Me.VSaddress.BorderWidth = 1
        Me.VSaddress.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VSaddress.IsPassword = False
        Me.VSaddress.Location = New System.Drawing.Point(565, 15)
        Me.VSaddress.MaxRange = 0
        Me.VSaddress.MinRange = 0
        Me.VSaddress.Name = "VSaddress"
        Me.VSaddress.Size = New System.Drawing.Size(96, 30)
        Me.VSaddress.TabIndex = 111
        Me.VSaddress.Text = "#1"
        Me.VSaddress.TextAlign = System.Drawing.StringAlignment.Center
        Me.VSaddress.UseKeyPad = False
        '
        'VSStatus
        '
        Me.VSStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VSStatus.BackImage = Nothing
        Me.VSStatus.BorderColor = System.Drawing.Color.DarkGray
        Me.VSStatus.BorderSide_Bottom = True
        Me.VSStatus.BorderSide_Left = True
        Me.VSStatus.BorderSide_Right = True
        Me.VSStatus.BorderSide_Top = True
        Me.VSStatus.BorderWidth = 1
        Me.VSStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VSStatus.IsPassword = False
        Me.VSStatus.Location = New System.Drawing.Point(517, 15)
        Me.VSStatus.MaxRange = 0
        Me.VSStatus.MinRange = 0
        Me.VSStatus.Name = "VSStatus"
        Me.VSStatus.Size = New System.Drawing.Size(42, 30)
        Me.VSStatus.TabIndex = 107
        Me.VSStatus.Text = "#1"
        Me.VSStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.VSStatus.UseKeyPad = False
        '
        'VSmodule
        '
        Me.VSmodule.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VSmodule.BackImage = Nothing
        Me.VSmodule.BorderColor = System.Drawing.Color.DarkGray
        Me.VSmodule.BorderSide_Bottom = True
        Me.VSmodule.BorderSide_Left = True
        Me.VSmodule.BorderSide_Right = True
        Me.VSmodule.BorderSide_Top = True
        Me.VSmodule.BorderWidth = 1
        Me.VSmodule.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VSmodule.IsPassword = False
        Me.VSmodule.Location = New System.Drawing.Point(469, 15)
        Me.VSmodule.MaxRange = 0
        Me.VSmodule.MinRange = 0
        Me.VSmodule.Name = "VSmodule"
        Me.VSmodule.Size = New System.Drawing.Size(42, 30)
        Me.VSmodule.TabIndex = 106
        Me.VSmodule.Text = "#1"
        Me.VSmodule.TextAlign = System.Drawing.StringAlignment.Center
        Me.VSmodule.UseKeyPad = False
        '
        'VSrack
        '
        Me.VSrack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VSrack.BackImage = Nothing
        Me.VSrack.BorderColor = System.Drawing.Color.DarkGray
        Me.VSrack.BorderSide_Bottom = True
        Me.VSrack.BorderSide_Left = True
        Me.VSrack.BorderSide_Right = True
        Me.VSrack.BorderSide_Top = True
        Me.VSrack.BorderWidth = 1
        Me.VSrack.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VSrack.IsPassword = False
        Me.VSrack.Location = New System.Drawing.Point(421, 15)
        Me.VSrack.MaxRange = 0
        Me.VSrack.MinRange = 0
        Me.VSrack.Name = "VSrack"
        Me.VSrack.Size = New System.Drawing.Size(42, 30)
        Me.VSrack.TabIndex = 105
        Me.VSrack.Text = "#1"
        Me.VSrack.TextAlign = System.Drawing.StringAlignment.Center
        Me.VSrack.UseKeyPad = False
        '
        'VsGroupBox1
        '
        Me.VsGroupBox1.BackColor = System.Drawing.Color.White
        Me.VsGroupBox1.Controls.Add(Me.VsLabel1)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel4)
        Me.VsGroupBox1.Controls.Add(Me.pbBattery)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel7)
        Me.VsGroupBox1.Controls.Add(Me.lChargingStatus)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel3)
        Me.VsGroupBox1.Controls.Add(Me.lSOC)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel6)
        Me.VsGroupBox1.Controls.Add(Me.lSOH)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel2)
        Me.VsGroupBox1.Controls.Add(Me.lPower)
        Me.VsGroupBox1.Controls.Add(Me.VsLabel5)
        Me.VsGroupBox1.Controls.Add(Me.lVoltage)
        Me.VsGroupBox1.Controls.Add(Me.lTemperature)
        Me.VsGroupBox1.Controls.Add(Me.lCurrent)
        Me.VsGroupBox1.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox1.HeaderText = "배터리 상태"
        Me.VsGroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.VsGroupBox1.Name = "VsGroupBox1"
        Me.VsGroupBox1.Size = New System.Drawing.Size(319, 261)
        Me.VsGroupBox1.TabIndex = 0
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel1.BackImage = Nothing
        Me.VsLabel1.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel1.BorderSide_Bottom = True
        Me.VsLabel1.BorderSide_Left = True
        Me.VsLabel1.BorderSide_Right = True
        Me.VsLabel1.BorderSide_Top = True
        Me.VsLabel1.BorderWidth = 1
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.IsPassword = False
        Me.VsLabel1.Location = New System.Drawing.Point(14, 192)
        Me.VsLabel1.MaxRange = 0
        Me.VsLabel1.MinRange = 0
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(81, 30)
        Me.VsLabel1.TabIndex = 26
        Me.VsLabel1.Text = "상태"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel1.UseKeyPad = False
        '
        'VsLabel4
        '
        Me.VsLabel4.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel4.BackImage = Nothing
        Me.VsLabel4.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel4.BorderSide_Bottom = True
        Me.VsLabel4.BorderSide_Left = True
        Me.VsLabel4.BorderSide_Right = True
        Me.VsLabel4.BorderSide_Top = True
        Me.VsLabel4.BorderWidth = 1
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.IsPassword = False
        Me.VsLabel4.Location = New System.Drawing.Point(120, 120)
        Me.VsLabel4.MaxRange = 0
        Me.VsLabel4.MinRange = 0
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel4.TabIndex = 26
        Me.VsLabel4.Text = "전력"
        Me.VsLabel4.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel4.UseKeyPad = False
        '
        'pbBattery
        '
        Me.pbBattery.Image = CType(resources.GetObject("pbBattery.Image"), System.Drawing.Image)
        Me.pbBattery.Location = New System.Drawing.Point(27, 89)
        Me.pbBattery.Name = "pbBattery"
        Me.pbBattery.Size = New System.Drawing.Size(54, 86)
        Me.pbBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBattery.TabIndex = 27
        Me.pbBattery.TabStop = False
        '
        'VsLabel7
        '
        Me.VsLabel7.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel7.BackImage = Nothing
        Me.VsLabel7.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel7.BorderSide_Bottom = True
        Me.VsLabel7.BorderSide_Left = True
        Me.VsLabel7.BorderSide_Right = True
        Me.VsLabel7.BorderSide_Top = True
        Me.VsLabel7.BorderWidth = 1
        Me.VsLabel7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel7.IsPassword = False
        Me.VsLabel7.Location = New System.Drawing.Point(120, 228)
        Me.VsLabel7.MaxRange = 0
        Me.VsLabel7.MinRange = 0
        Me.VsLabel7.Name = "VsLabel7"
        Me.VsLabel7.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel7.TabIndex = 26
        Me.VsLabel7.Text = "온도"
        Me.VsLabel7.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel7.UseKeyPad = False
        '
        'lChargingStatus
        '
        Me.lChargingStatus.BackColor = System.Drawing.Color.White
        Me.lChargingStatus.BackImage = Nothing
        Me.lChargingStatus.BorderColor = System.Drawing.Color.DarkGray
        Me.lChargingStatus.BorderSide_Bottom = True
        Me.lChargingStatus.BorderSide_Left = True
        Me.lChargingStatus.BorderSide_Right = True
        Me.lChargingStatus.BorderSide_Top = True
        Me.lChargingStatus.BorderWidth = 1
        Me.lChargingStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lChargingStatus.IsPassword = False
        Me.lChargingStatus.Location = New System.Drawing.Point(14, 228)
        Me.lChargingStatus.MaxRange = 0
        Me.lChargingStatus.MinRange = 0
        Me.lChargingStatus.Name = "lChargingStatus"
        Me.lChargingStatus.Size = New System.Drawing.Size(81, 30)
        Me.lChargingStatus.TabIndex = 26
        Me.lChargingStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lChargingStatus.UseKeyPad = False
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel3.BackImage = Nothing
        Me.VsLabel3.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel3.BorderSide_Bottom = True
        Me.VsLabel3.BorderSide_Left = True
        Me.VsLabel3.BorderSide_Right = True
        Me.VsLabel3.BorderSide_Top = True
        Me.VsLabel3.BorderWidth = 1
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel3.IsPassword = False
        Me.VsLabel3.Location = New System.Drawing.Point(120, 84)
        Me.VsLabel3.MaxRange = 0
        Me.VsLabel3.MinRange = 0
        Me.VsLabel3.Name = "VsLabel3"
        Me.VsLabel3.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel3.TabIndex = 26
        Me.VsLabel3.Text = "SOH"
        Me.VsLabel3.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel3.UseKeyPad = False
        '
        'lSOC
        '
        Me.lSOC.BackColor = System.Drawing.Color.White
        Me.lSOC.BackImage = Nothing
        Me.lSOC.BorderColor = System.Drawing.Color.DarkGray
        Me.lSOC.BorderSide_Bottom = True
        Me.lSOC.BorderSide_Left = True
        Me.lSOC.BorderSide_Right = True
        Me.lSOC.BorderSide_Top = True
        Me.lSOC.BorderWidth = 1
        Me.lSOC.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lSOC.IsPassword = False
        Me.lSOC.Location = New System.Drawing.Point(188, 48)
        Me.lSOC.MaxRange = 0
        Me.lSOC.MinRange = 0
        Me.lSOC.Name = "lSOC"
        Me.lSOC.Size = New System.Drawing.Size(119, 30)
        Me.lSOC.TabIndex = 26
        Me.lSOC.TextAlign = System.Drawing.StringAlignment.Far
        Me.lSOC.UseKeyPad = False
        '
        'VsLabel6
        '
        Me.VsLabel6.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel6.BackImage = Nothing
        Me.VsLabel6.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel6.BorderSide_Bottom = True
        Me.VsLabel6.BorderSide_Left = True
        Me.VsLabel6.BorderSide_Right = True
        Me.VsLabel6.BorderSide_Top = True
        Me.VsLabel6.BorderWidth = 1
        Me.VsLabel6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel6.IsPassword = False
        Me.VsLabel6.Location = New System.Drawing.Point(120, 192)
        Me.VsLabel6.MaxRange = 0
        Me.VsLabel6.MinRange = 0
        Me.VsLabel6.Name = "VsLabel6"
        Me.VsLabel6.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel6.TabIndex = 26
        Me.VsLabel6.Text = "전류"
        Me.VsLabel6.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel6.UseKeyPad = False
        '
        'lSOH
        '
        Me.lSOH.BackColor = System.Drawing.Color.White
        Me.lSOH.BackImage = Nothing
        Me.lSOH.BorderColor = System.Drawing.Color.DarkGray
        Me.lSOH.BorderSide_Bottom = True
        Me.lSOH.BorderSide_Left = True
        Me.lSOH.BorderSide_Right = True
        Me.lSOH.BorderSide_Top = True
        Me.lSOH.BorderWidth = 1
        Me.lSOH.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lSOH.IsPassword = False
        Me.lSOH.Location = New System.Drawing.Point(188, 84)
        Me.lSOH.MaxRange = 0
        Me.lSOH.MinRange = 0
        Me.lSOH.Name = "lSOH"
        Me.lSOH.Size = New System.Drawing.Size(119, 30)
        Me.lSOH.TabIndex = 26
        Me.lSOH.TextAlign = System.Drawing.StringAlignment.Far
        Me.lSOH.UseKeyPad = False
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel2.BackImage = Nothing
        Me.VsLabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel2.BorderSide_Bottom = True
        Me.VsLabel2.BorderSide_Left = True
        Me.VsLabel2.BorderSide_Right = True
        Me.VsLabel2.BorderSide_Top = True
        Me.VsLabel2.BorderWidth = 1
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.IsPassword = False
        Me.VsLabel2.Location = New System.Drawing.Point(120, 48)
        Me.VsLabel2.MaxRange = 0
        Me.VsLabel2.MinRange = 0
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel2.TabIndex = 26
        Me.VsLabel2.Text = "SOC"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel2.UseKeyPad = False
        '
        'lPower
        '
        Me.lPower.BackColor = System.Drawing.Color.White
        Me.lPower.BackImage = Nothing
        Me.lPower.BorderColor = System.Drawing.Color.DarkGray
        Me.lPower.BorderSide_Bottom = True
        Me.lPower.BorderSide_Left = True
        Me.lPower.BorderSide_Right = True
        Me.lPower.BorderSide_Top = True
        Me.lPower.BorderWidth = 1
        Me.lPower.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lPower.IsPassword = False
        Me.lPower.Location = New System.Drawing.Point(188, 120)
        Me.lPower.MaxRange = 0
        Me.lPower.MinRange = 0
        Me.lPower.Name = "lPower"
        Me.lPower.Size = New System.Drawing.Size(119, 30)
        Me.lPower.TabIndex = 26
        Me.lPower.TextAlign = System.Drawing.StringAlignment.Far
        Me.lPower.UseKeyPad = False
        '
        'VsLabel5
        '
        Me.VsLabel5.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel5.BackImage = Nothing
        Me.VsLabel5.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel5.BorderSide_Bottom = True
        Me.VsLabel5.BorderSide_Left = True
        Me.VsLabel5.BorderSide_Right = True
        Me.VsLabel5.BorderSide_Top = True
        Me.VsLabel5.BorderWidth = 1
        Me.VsLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel5.IsPassword = False
        Me.VsLabel5.Location = New System.Drawing.Point(120, 156)
        Me.VsLabel5.MaxRange = 0
        Me.VsLabel5.MinRange = 0
        Me.VsLabel5.Name = "VsLabel5"
        Me.VsLabel5.Size = New System.Drawing.Size(62, 30)
        Me.VsLabel5.TabIndex = 26
        Me.VsLabel5.Text = "전압"
        Me.VsLabel5.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel5.UseKeyPad = False
        '
        'lVoltage
        '
        Me.lVoltage.BackColor = System.Drawing.Color.White
        Me.lVoltage.BackImage = Nothing
        Me.lVoltage.BorderColor = System.Drawing.Color.DarkGray
        Me.lVoltage.BorderSide_Bottom = True
        Me.lVoltage.BorderSide_Left = True
        Me.lVoltage.BorderSide_Right = True
        Me.lVoltage.BorderSide_Top = True
        Me.lVoltage.BorderWidth = 1
        Me.lVoltage.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lVoltage.IsPassword = False
        Me.lVoltage.Location = New System.Drawing.Point(188, 156)
        Me.lVoltage.MaxRange = 0
        Me.lVoltage.MinRange = 0
        Me.lVoltage.Name = "lVoltage"
        Me.lVoltage.Size = New System.Drawing.Size(119, 30)
        Me.lVoltage.TabIndex = 26
        Me.lVoltage.TextAlign = System.Drawing.StringAlignment.Far
        Me.lVoltage.UseKeyPad = False
        '
        'lTemperature
        '
        Me.lTemperature.BackColor = System.Drawing.Color.White
        Me.lTemperature.BackImage = Nothing
        Me.lTemperature.BorderColor = System.Drawing.Color.DarkGray
        Me.lTemperature.BorderSide_Bottom = True
        Me.lTemperature.BorderSide_Left = True
        Me.lTemperature.BorderSide_Right = True
        Me.lTemperature.BorderSide_Top = True
        Me.lTemperature.BorderWidth = 1
        Me.lTemperature.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lTemperature.IsPassword = False
        Me.lTemperature.Location = New System.Drawing.Point(188, 228)
        Me.lTemperature.MaxRange = 0
        Me.lTemperature.MinRange = 0
        Me.lTemperature.Name = "lTemperature"
        Me.lTemperature.Size = New System.Drawing.Size(119, 30)
        Me.lTemperature.TabIndex = 26
        Me.lTemperature.TextAlign = System.Drawing.StringAlignment.Far
        Me.lTemperature.UseKeyPad = False
        '
        'lCurrent
        '
        Me.lCurrent.BackColor = System.Drawing.Color.White
        Me.lCurrent.BackImage = Nothing
        Me.lCurrent.BorderColor = System.Drawing.Color.DarkGray
        Me.lCurrent.BorderSide_Bottom = True
        Me.lCurrent.BorderSide_Left = True
        Me.lCurrent.BorderSide_Right = True
        Me.lCurrent.BorderSide_Top = True
        Me.lCurrent.BorderWidth = 1
        Me.lCurrent.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCurrent.IsPassword = False
        Me.lCurrent.Location = New System.Drawing.Point(188, 192)
        Me.lCurrent.MaxRange = 0
        Me.lCurrent.MinRange = 0
        Me.lCurrent.Name = "lCurrent"
        Me.lCurrent.Size = New System.Drawing.Size(119, 30)
        Me.lCurrent.TabIndex = 26
        Me.lCurrent.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCurrent.UseKeyPad = False
        '
        'VsGroupBox2
        '
        Me.VsGroupBox2.BackColor = System.Drawing.Color.White
        Me.VsGroupBox2.Controls.Add(Me.VsLabel8)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryDischarge_Today)
        Me.VsGroupBox2.Controls.Add(Me.VsLabel9)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryCharge_Today)
        Me.VsGroupBox2.Controls.Add(Me.VsLabel13)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryDischarge_Yesterday)
        Me.VsGroupBox2.Controls.Add(Me.VsLabel12)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryCharge_Yesterday)
        Me.VsGroupBox2.Controls.Add(Me.VsLabel10)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryDischarge_Total)
        Me.VsGroupBox2.Controls.Add(Me.lbBatteryCharge_Total)
        Me.VsGroupBox2.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox2.HeaderText = "배터리 사용량"
        Me.VsGroupBox2.Location = New System.Drawing.Point(342, 12)
        Me.VsGroupBox2.Name = "VsGroupBox2"
        Me.VsGroupBox2.Size = New System.Drawing.Size(420, 261)
        Me.VsGroupBox2.TabIndex = 1
        '
        'VsLabel8
        '
        Me.VsLabel8.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel8.BackImage = Nothing
        Me.VsLabel8.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel8.BorderSide_Bottom = True
        Me.VsLabel8.BorderSide_Left = True
        Me.VsLabel8.BorderSide_Right = True
        Me.VsLabel8.BorderSide_Top = True
        Me.VsLabel8.BorderWidth = 1
        Me.VsLabel8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel8.IsPassword = False
        Me.VsLabel8.Location = New System.Drawing.Point(101, 68)
        Me.VsLabel8.MaxRange = 0
        Me.VsLabel8.MinRange = 0
        Me.VsLabel8.Name = "VsLabel8"
        Me.VsLabel8.Size = New System.Drawing.Size(149, 40)
        Me.VsLabel8.TabIndex = 26
        Me.VsLabel8.Text = "방  전"
        Me.VsLabel8.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel8.UseKeyPad = False
        '
        'lbBatteryDischarge_Today
        '
        Me.lbBatteryDischarge_Today.BackColor = System.Drawing.Color.White
        Me.lbBatteryDischarge_Today.BackImage = Nothing
        Me.lbBatteryDischarge_Today.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Today.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Today.BorderSide_Left = True
        Me.lbBatteryDischarge_Today.BorderSide_Right = True
        Me.lbBatteryDischarge_Today.BorderSide_Top = True
        Me.lbBatteryDischarge_Today.BorderWidth = 1
        Me.lbBatteryDischarge_Today.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Today.IsPassword = False
        Me.lbBatteryDischarge_Today.Location = New System.Drawing.Point(101, 113)
        Me.lbBatteryDischarge_Today.MaxRange = 0
        Me.lbBatteryDischarge_Today.MinRange = 0
        Me.lbBatteryDischarge_Today.Name = "lbBatteryDischarge_Today"
        Me.lbBatteryDischarge_Today.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Today.TabIndex = 26
        Me.lbBatteryDischarge_Today.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryDischarge_Today.UseKeyPad = False
        '
        'VsLabel9
        '
        Me.VsLabel9.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel9.BackImage = Nothing
        Me.VsLabel9.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel9.BorderSide_Bottom = True
        Me.VsLabel9.BorderSide_Left = True
        Me.VsLabel9.BorderSide_Right = True
        Me.VsLabel9.BorderSide_Top = True
        Me.VsLabel9.BorderWidth = 1
        Me.VsLabel9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel9.IsPassword = False
        Me.VsLabel9.Location = New System.Drawing.Point(256, 68)
        Me.VsLabel9.MaxRange = 0
        Me.VsLabel9.MinRange = 0
        Me.VsLabel9.Name = "VsLabel9"
        Me.VsLabel9.Size = New System.Drawing.Size(149, 40)
        Me.VsLabel9.TabIndex = 26
        Me.VsLabel9.Text = "충  전"
        Me.VsLabel9.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel9.UseKeyPad = False
        '
        'lbBatteryCharge_Today
        '
        Me.lbBatteryCharge_Today.BackColor = System.Drawing.Color.White
        Me.lbBatteryCharge_Today.BackImage = Nothing
        Me.lbBatteryCharge_Today.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Today.BorderSide_Bottom = True
        Me.lbBatteryCharge_Today.BorderSide_Left = True
        Me.lbBatteryCharge_Today.BorderSide_Right = True
        Me.lbBatteryCharge_Today.BorderSide_Top = True
        Me.lbBatteryCharge_Today.BorderWidth = 1
        Me.lbBatteryCharge_Today.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Today.IsPassword = False
        Me.lbBatteryCharge_Today.Location = New System.Drawing.Point(256, 113)
        Me.lbBatteryCharge_Today.MaxRange = 0
        Me.lbBatteryCharge_Today.MinRange = 0
        Me.lbBatteryCharge_Today.Name = "lbBatteryCharge_Today"
        Me.lbBatteryCharge_Today.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Today.TabIndex = 26
        Me.lbBatteryCharge_Today.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryCharge_Today.UseKeyPad = False
        '
        'VsLabel13
        '
        Me.VsLabel13.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel13.BackImage = Nothing
        Me.VsLabel13.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel13.BorderSide_Bottom = True
        Me.VsLabel13.BorderSide_Left = True
        Me.VsLabel13.BorderSide_Right = True
        Me.VsLabel13.BorderSide_Top = True
        Me.VsLabel13.BorderWidth = 1
        Me.VsLabel13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel13.IsPassword = False
        Me.VsLabel13.Location = New System.Drawing.Point(19, 205)
        Me.VsLabel13.MaxRange = 0
        Me.VsLabel13.MinRange = 0
        Me.VsLabel13.Name = "VsLabel13"
        Me.VsLabel13.Size = New System.Drawing.Size(76, 40)
        Me.VsLabel13.TabIndex = 26
        Me.VsLabel13.Text = "누계"
        Me.VsLabel13.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel13.UseKeyPad = False
        '
        'lbBatteryDischarge_Yesterday
        '
        Me.lbBatteryDischarge_Yesterday.BackColor = System.Drawing.Color.White
        Me.lbBatteryDischarge_Yesterday.BackImage = Nothing
        Me.lbBatteryDischarge_Yesterday.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Yesterday.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Left = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Right = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Top = True
        Me.lbBatteryDischarge_Yesterday.BorderWidth = 1
        Me.lbBatteryDischarge_Yesterday.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Yesterday.IsPassword = False
        Me.lbBatteryDischarge_Yesterday.Location = New System.Drawing.Point(101, 159)
        Me.lbBatteryDischarge_Yesterday.MaxRange = 0
        Me.lbBatteryDischarge_Yesterday.MinRange = 0
        Me.lbBatteryDischarge_Yesterday.Name = "lbBatteryDischarge_Yesterday"
        Me.lbBatteryDischarge_Yesterday.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Yesterday.TabIndex = 26
        Me.lbBatteryDischarge_Yesterday.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryDischarge_Yesterday.UseKeyPad = False
        '
        'VsLabel12
        '
        Me.VsLabel12.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel12.BackImage = Nothing
        Me.VsLabel12.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel12.BorderSide_Bottom = True
        Me.VsLabel12.BorderSide_Left = True
        Me.VsLabel12.BorderSide_Right = True
        Me.VsLabel12.BorderSide_Top = True
        Me.VsLabel12.BorderWidth = 1
        Me.VsLabel12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel12.IsPassword = False
        Me.VsLabel12.Location = New System.Drawing.Point(19, 159)
        Me.VsLabel12.MaxRange = 0
        Me.VsLabel12.MinRange = 0
        Me.VsLabel12.Name = "VsLabel12"
        Me.VsLabel12.Size = New System.Drawing.Size(76, 40)
        Me.VsLabel12.TabIndex = 26
        Me.VsLabel12.Text = "어제"
        Me.VsLabel12.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel12.UseKeyPad = False
        '
        'lbBatteryCharge_Yesterday
        '
        Me.lbBatteryCharge_Yesterday.BackColor = System.Drawing.Color.White
        Me.lbBatteryCharge_Yesterday.BackImage = Nothing
        Me.lbBatteryCharge_Yesterday.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Yesterday.BorderSide_Bottom = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Left = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Right = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Top = True
        Me.lbBatteryCharge_Yesterday.BorderWidth = 1
        Me.lbBatteryCharge_Yesterday.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Yesterday.IsPassword = False
        Me.lbBatteryCharge_Yesterday.Location = New System.Drawing.Point(256, 159)
        Me.lbBatteryCharge_Yesterday.MaxRange = 0
        Me.lbBatteryCharge_Yesterday.MinRange = 0
        Me.lbBatteryCharge_Yesterday.Name = "lbBatteryCharge_Yesterday"
        Me.lbBatteryCharge_Yesterday.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Yesterday.TabIndex = 26
        Me.lbBatteryCharge_Yesterday.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryCharge_Yesterday.UseKeyPad = False
        '
        'VsLabel10
        '
        Me.VsLabel10.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel10.BackImage = Nothing
        Me.VsLabel10.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel10.BorderSide_Bottom = True
        Me.VsLabel10.BorderSide_Left = True
        Me.VsLabel10.BorderSide_Right = True
        Me.VsLabel10.BorderSide_Top = True
        Me.VsLabel10.BorderWidth = 1
        Me.VsLabel10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel10.IsPassword = False
        Me.VsLabel10.Location = New System.Drawing.Point(19, 113)
        Me.VsLabel10.MaxRange = 0
        Me.VsLabel10.MinRange = 0
        Me.VsLabel10.Name = "VsLabel10"
        Me.VsLabel10.Size = New System.Drawing.Size(76, 40)
        Me.VsLabel10.TabIndex = 26
        Me.VsLabel10.Text = "오늘"
        Me.VsLabel10.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel10.UseKeyPad = False
        '
        'lbBatteryDischarge_Total
        '
        Me.lbBatteryDischarge_Total.BackColor = System.Drawing.Color.White
        Me.lbBatteryDischarge_Total.BackImage = Nothing
        Me.lbBatteryDischarge_Total.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Total.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Total.BorderSide_Left = True
        Me.lbBatteryDischarge_Total.BorderSide_Right = True
        Me.lbBatteryDischarge_Total.BorderSide_Top = True
        Me.lbBatteryDischarge_Total.BorderWidth = 1
        Me.lbBatteryDischarge_Total.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Total.IsPassword = False
        Me.lbBatteryDischarge_Total.Location = New System.Drawing.Point(101, 205)
        Me.lbBatteryDischarge_Total.MaxRange = 0
        Me.lbBatteryDischarge_Total.MinRange = 0
        Me.lbBatteryDischarge_Total.Name = "lbBatteryDischarge_Total"
        Me.lbBatteryDischarge_Total.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Total.TabIndex = 26
        Me.lbBatteryDischarge_Total.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryDischarge_Total.UseKeyPad = False
        '
        'lbBatteryCharge_Total
        '
        Me.lbBatteryCharge_Total.BackColor = System.Drawing.Color.White
        Me.lbBatteryCharge_Total.BackImage = Nothing
        Me.lbBatteryCharge_Total.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Total.BorderSide_Bottom = True
        Me.lbBatteryCharge_Total.BorderSide_Left = True
        Me.lbBatteryCharge_Total.BorderSide_Right = True
        Me.lbBatteryCharge_Total.BorderSide_Top = True
        Me.lbBatteryCharge_Total.BorderWidth = 1
        Me.lbBatteryCharge_Total.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Total.IsPassword = False
        Me.lbBatteryCharge_Total.Location = New System.Drawing.Point(256, 205)
        Me.lbBatteryCharge_Total.MaxRange = 0
        Me.lbBatteryCharge_Total.MinRange = 0
        Me.lbBatteryCharge_Total.Name = "lbBatteryCharge_Total"
        Me.lbBatteryCharge_Total.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Total.TabIndex = 26
        Me.lbBatteryCharge_Total.TextAlign = System.Drawing.StringAlignment.Far
        Me.lbBatteryCharge_Total.UseKeyPad = False
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Close.BackImage = Nothing
        Me.btn_Close.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Close.BorderSide_Bottom = True
        Me.btn_Close.BorderSide_Left = True
        Me.btn_Close.BorderSide_Right = True
        Me.btn_Close.BorderSide_Top = True
        Me.btn_Close.BorderWidth = 1
        Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Close.IsPassword = False
        Me.btn_Close.Location = New System.Drawing.Point(124, 217)
        Me.btn_Close.MaxRange = 0
        Me.btn_Close.MinRange = 0
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(80, 30)
        Me.btn_Close.TabIndex = 115
        Me.btn_Close.Text = "CLOSE"
        Me.btn_Close.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Close.UseKeyPad = False
        '
        'btn_Open
        '
        Me.btn_Open.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Open.BackImage = Nothing
        Me.btn_Open.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Open.BorderSide_Bottom = True
        Me.btn_Open.BorderSide_Left = True
        Me.btn_Open.BorderSide_Right = True
        Me.btn_Open.BorderSide_Top = True
        Me.btn_Open.BorderWidth = 1
        Me.btn_Open.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Open.IsPassword = False
        Me.btn_Open.Location = New System.Drawing.Point(124, 250)
        Me.btn_Open.MaxRange = 0
        Me.btn_Open.MinRange = 0
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(80, 30)
        Me.btn_Open.TabIndex = 114
        Me.btn_Open.Text = "OPEN"
        Me.btn_Open.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Open.UseKeyPad = False
        '
        'btn_None
        '
        Me.btn_None.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_None.BackImage = Nothing
        Me.btn_None.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_None.BorderSide_Bottom = True
        Me.btn_None.BorderSide_Left = True
        Me.btn_None.BorderSide_Right = True
        Me.btn_None.BorderSide_Top = True
        Me.btn_None.BorderWidth = 1
        Me.btn_None.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_None.IsPassword = False
        Me.btn_None.Location = New System.Drawing.Point(124, 184)
        Me.btn_None.MaxRange = 0
        Me.btn_None.MinRange = 0
        Me.btn_None.Name = "btn_None"
        Me.btn_None.Size = New System.Drawing.Size(80, 30)
        Me.btn_None.TabIndex = 113
        Me.btn_None.Text = "NONE"
        Me.btn_None.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_None.UseKeyPad = False
        '
        'VsLabel66
        '
        Me.VsLabel66.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel66.BackImage = Nothing
        Me.VsLabel66.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel66.BorderSide_Bottom = True
        Me.VsLabel66.BorderSide_Left = True
        Me.VsLabel66.BorderSide_Right = True
        Me.VsLabel66.BorderSide_Top = True
        Me.VsLabel66.BorderWidth = 1
        Me.VsLabel66.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel66.IsPassword = False
        Me.VsLabel66.Location = New System.Drawing.Point(259, 40)
        Me.VsLabel66.MaxRange = 0
        Me.VsLabel66.MinRange = 0
        Me.VsLabel66.Name = "VsLabel66"
        Me.VsLabel66.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel66.TabIndex = 67
        Me.VsLabel66.Text = "최대전압"
        Me.VsLabel66.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel66.UseKeyPad = False
        '
        'VsLabel61
        '
        Me.VsLabel61.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel61.BackImage = Nothing
        Me.VsLabel61.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel61.BorderSide_Bottom = True
        Me.VsLabel61.BorderSide_Left = True
        Me.VsLabel61.BorderSide_Right = True
        Me.VsLabel61.BorderSide_Top = True
        Me.VsLabel61.BorderWidth = 1
        Me.VsLabel61.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel61.IsPassword = False
        Me.VsLabel61.Location = New System.Drawing.Point(259, 76)
        Me.VsLabel61.MaxRange = 0
        Me.VsLabel61.MinRange = 0
        Me.VsLabel61.Name = "VsLabel61"
        Me.VsLabel61.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel61.TabIndex = 65
        Me.VsLabel61.Text = "최대전압 위치"
        Me.VsLabel61.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel61.UseKeyPad = False
        '
        'lCell최대전압
        '
        Me.lCell최대전압.BackColor = System.Drawing.Color.White
        Me.lCell최대전압.BackImage = Nothing
        Me.lCell최대전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대전압.BorderSide_Bottom = True
        Me.lCell최대전압.BorderSide_Left = True
        Me.lCell최대전압.BorderSide_Right = True
        Me.lCell최대전압.BorderSide_Top = True
        Me.lCell최대전압.BorderWidth = 1
        Me.lCell최대전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대전압.IsPassword = False
        Me.lCell최대전압.Location = New System.Drawing.Point(382, 40)
        Me.lCell최대전압.MaxRange = 0
        Me.lCell최대전압.MinRange = 0
        Me.lCell최대전압.Name = "lCell최대전압"
        Me.lCell최대전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대전압.TabIndex = 68
        Me.lCell최대전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최대전압.UseKeyPad = False
        '
        'VsLabel58
        '
        Me.VsLabel58.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel58.BackImage = Nothing
        Me.VsLabel58.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel58.BorderSide_Bottom = True
        Me.VsLabel58.BorderSide_Left = True
        Me.VsLabel58.BorderSide_Right = True
        Me.VsLabel58.BorderSide_Top = True
        Me.VsLabel58.BorderWidth = 1
        Me.VsLabel58.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel58.IsPassword = False
        Me.VsLabel58.Location = New System.Drawing.Point(259, 112)
        Me.VsLabel58.MaxRange = 0
        Me.VsLabel58.MinRange = 0
        Me.VsLabel58.Name = "VsLabel58"
        Me.VsLabel58.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel58.TabIndex = 63
        Me.VsLabel58.Text = "최소전압"
        Me.VsLabel58.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel58.UseKeyPad = False
        '
        'lCell최대전압위치
        '
        Me.lCell최대전압위치.BackColor = System.Drawing.Color.White
        Me.lCell최대전압위치.BackImage = Nothing
        Me.lCell최대전압위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대전압위치.BorderSide_Bottom = True
        Me.lCell최대전압위치.BorderSide_Left = True
        Me.lCell최대전압위치.BorderSide_Right = True
        Me.lCell최대전압위치.BorderSide_Top = True
        Me.lCell최대전압위치.BorderWidth = 1
        Me.lCell최대전압위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대전압위치.IsPassword = False
        Me.lCell최대전압위치.Location = New System.Drawing.Point(382, 76)
        Me.lCell최대전압위치.MaxRange = 0
        Me.lCell최대전압위치.MinRange = 0
        Me.lCell최대전압위치.Name = "lCell최대전압위치"
        Me.lCell최대전압위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대전압위치.TabIndex = 66
        Me.lCell최대전압위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최대전압위치.UseKeyPad = False
        '
        'VsLabel53
        '
        Me.VsLabel53.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel53.BackImage = Nothing
        Me.VsLabel53.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel53.BorderSide_Bottom = True
        Me.VsLabel53.BorderSide_Left = True
        Me.VsLabel53.BorderSide_Right = True
        Me.VsLabel53.BorderSide_Top = True
        Me.VsLabel53.BorderWidth = 1
        Me.VsLabel53.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel53.IsPassword = False
        Me.VsLabel53.Location = New System.Drawing.Point(259, 148)
        Me.VsLabel53.MaxRange = 0
        Me.VsLabel53.MinRange = 0
        Me.VsLabel53.Name = "VsLabel53"
        Me.VsLabel53.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel53.TabIndex = 61
        Me.VsLabel53.Text = "최소전압 위치"
        Me.VsLabel53.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel53.UseKeyPad = False
        '
        'lCell최소전압
        '
        Me.lCell최소전압.BackColor = System.Drawing.Color.White
        Me.lCell최소전압.BackImage = Nothing
        Me.lCell최소전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소전압.BorderSide_Bottom = True
        Me.lCell최소전압.BorderSide_Left = True
        Me.lCell최소전압.BorderSide_Right = True
        Me.lCell최소전압.BorderSide_Top = True
        Me.lCell최소전압.BorderWidth = 1
        Me.lCell최소전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소전압.IsPassword = False
        Me.lCell최소전압.Location = New System.Drawing.Point(382, 112)
        Me.lCell최소전압.MaxRange = 0
        Me.lCell최소전압.MinRange = 0
        Me.lCell최소전압.Name = "lCell최소전압"
        Me.lCell최소전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소전압.TabIndex = 64
        Me.lCell최소전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최소전압.UseKeyPad = False
        '
        'VsLabel51
        '
        Me.VsLabel51.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel51.BackImage = Nothing
        Me.VsLabel51.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel51.BorderSide_Bottom = True
        Me.VsLabel51.BorderSide_Left = True
        Me.VsLabel51.BorderSide_Right = True
        Me.VsLabel51.BorderSide_Top = True
        Me.VsLabel51.BorderWidth = 1
        Me.VsLabel51.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel51.IsPassword = False
        Me.VsLabel51.Location = New System.Drawing.Point(260, 184)
        Me.VsLabel51.MaxRange = 0
        Me.VsLabel51.MinRange = 0
        Me.VsLabel51.Name = "VsLabel51"
        Me.VsLabel51.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel51.TabIndex = 43
        Me.VsLabel51.Text = "전압 편차"
        Me.VsLabel51.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel51.UseKeyPad = False
        '
        'lCell최소전압위치
        '
        Me.lCell최소전압위치.BackColor = System.Drawing.Color.White
        Me.lCell최소전압위치.BackImage = Nothing
        Me.lCell최소전압위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소전압위치.BorderSide_Bottom = True
        Me.lCell최소전압위치.BorderSide_Left = True
        Me.lCell최소전압위치.BorderSide_Right = True
        Me.lCell최소전압위치.BorderSide_Top = True
        Me.lCell최소전압위치.BorderWidth = 1
        Me.lCell최소전압위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소전압위치.IsPassword = False
        Me.lCell최소전압위치.Location = New System.Drawing.Point(382, 148)
        Me.lCell최소전압위치.MaxRange = 0
        Me.lCell최소전압위치.MinRange = 0
        Me.lCell최소전압위치.Name = "lCell최소전압위치"
        Me.lCell최소전압위치.Size = New System.Drawing.Size(120, 30)
        Me.lCell최소전압위치.TabIndex = 62
        Me.lCell최소전압위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최소전압위치.UseKeyPad = False
        '
        'lCell전압편차
        '
        Me.lCell전압편차.BackColor = System.Drawing.Color.White
        Me.lCell전압편차.BackImage = Nothing
        Me.lCell전압편차.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell전압편차.BorderSide_Bottom = True
        Me.lCell전압편차.BorderSide_Left = True
        Me.lCell전압편차.BorderSide_Right = True
        Me.lCell전압편차.BorderSide_Top = True
        Me.lCell전압편차.BorderWidth = 1
        Me.lCell전압편차.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell전압편차.IsPassword = False
        Me.lCell전압편차.Location = New System.Drawing.Point(383, 184)
        Me.lCell전압편차.MaxRange = 0
        Me.lCell전압편차.MinRange = 0
        Me.lCell전압편차.Name = "lCell전압편차"
        Me.lCell전압편차.Size = New System.Drawing.Size(119, 30)
        Me.lCell전압편차.TabIndex = 60
        Me.lCell전압편차.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell전압편차.UseKeyPad = False
        '
        'VsLabel30
        '
        Me.VsLabel30.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel30.BackImage = Nothing
        Me.VsLabel30.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel30.BorderSide_Bottom = True
        Me.VsLabel30.BorderSide_Left = True
        Me.VsLabel30.BorderSide_Right = True
        Me.VsLabel30.BorderSide_Top = True
        Me.VsLabel30.BorderWidth = 1
        Me.VsLabel30.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel30.IsPassword = False
        Me.VsLabel30.Location = New System.Drawing.Point(20, 40)
        Me.VsLabel30.MaxRange = 0
        Me.VsLabel30.MinRange = 0
        Me.VsLabel30.Name = "VsLabel30"
        Me.VsLabel30.Size = New System.Drawing.Size(98, 30)
        Me.VsLabel30.TabIndex = 61
        Me.VsLabel30.Text = "랙 SOC"
        Me.VsLabel30.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel30.UseKeyPad = False
        '
        'VsLabel31
        '
        Me.VsLabel31.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel31.BackImage = Nothing
        Me.VsLabel31.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel31.BorderSide_Bottom = True
        Me.VsLabel31.BorderSide_Left = True
        Me.VsLabel31.BorderSide_Right = True
        Me.VsLabel31.BorderSide_Top = True
        Me.VsLabel31.BorderWidth = 1
        Me.VsLabel31.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel31.IsPassword = False
        Me.VsLabel31.Location = New System.Drawing.Point(20, 148)
        Me.VsLabel31.MaxRange = 0
        Me.VsLabel31.MinRange = 0
        Me.VsLabel31.Name = "VsLabel31"
        Me.VsLabel31.Size = New System.Drawing.Size(98, 30)
        Me.VsLabel31.TabIndex = 60
        Me.VsLabel31.Text = "랙 전류"
        Me.VsLabel31.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel31.UseKeyPad = False
        '
        'l랙SOC
        '
        Me.l랙SOC.BackColor = System.Drawing.Color.White
        Me.l랙SOC.BackImage = Nothing
        Me.l랙SOC.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙SOC.BorderSide_Bottom = True
        Me.l랙SOC.BorderSide_Left = True
        Me.l랙SOC.BorderSide_Right = True
        Me.l랙SOC.BorderSide_Top = True
        Me.l랙SOC.BorderWidth = 1
        Me.l랙SOC.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙SOC.IsPassword = False
        Me.l랙SOC.Location = New System.Drawing.Point(124, 40)
        Me.l랙SOC.MaxRange = 0
        Me.l랙SOC.MinRange = 0
        Me.l랙SOC.Name = "l랙SOC"
        Me.l랙SOC.Size = New System.Drawing.Size(119, 30)
        Me.l랙SOC.TabIndex = 62
        Me.l랙SOC.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙SOC.UseKeyPad = False
        '
        'VsLabel34
        '
        Me.VsLabel34.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel34.BackImage = Nothing
        Me.VsLabel34.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel34.BorderSide_Bottom = True
        Me.VsLabel34.BorderSide_Left = True
        Me.VsLabel34.BorderSide_Right = True
        Me.VsLabel34.BorderSide_Top = True
        Me.VsLabel34.BorderWidth = 1
        Me.VsLabel34.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel34.IsPassword = False
        Me.VsLabel34.Location = New System.Drawing.Point(20, 112)
        Me.VsLabel34.MaxRange = 0
        Me.VsLabel34.MinRange = 0
        Me.VsLabel34.Name = "VsLabel34"
        Me.VsLabel34.Size = New System.Drawing.Size(98, 30)
        Me.VsLabel34.TabIndex = 64
        Me.VsLabel34.Text = "랙 전압"
        Me.VsLabel34.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel34.UseKeyPad = False
        '
        'lCell평균전압
        '
        Me.lCell평균전압.BackColor = System.Drawing.Color.White
        Me.lCell평균전압.BackImage = Nothing
        Me.lCell평균전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell평균전압.BorderSide_Bottom = True
        Me.lCell평균전압.BorderSide_Left = True
        Me.lCell평균전압.BorderSide_Right = True
        Me.lCell평균전압.BorderSide_Top = True
        Me.lCell평균전압.BorderWidth = 1
        Me.lCell평균전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell평균전압.IsPassword = False
        Me.lCell평균전압.Location = New System.Drawing.Point(383, 220)
        Me.lCell평균전압.MaxRange = 0
        Me.lCell평균전압.MinRange = 0
        Me.lCell평균전압.Name = "lCell평균전압"
        Me.lCell평균전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell평균전압.TabIndex = 39
        Me.lCell평균전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell평균전압.UseKeyPad = False
        '
        'l랙SOH
        '
        Me.l랙SOH.BackColor = System.Drawing.Color.White
        Me.l랙SOH.BackImage = Nothing
        Me.l랙SOH.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙SOH.BorderSide_Bottom = True
        Me.l랙SOH.BorderSide_Left = True
        Me.l랙SOH.BorderSide_Right = True
        Me.l랙SOH.BorderSide_Top = True
        Me.l랙SOH.BorderWidth = 1
        Me.l랙SOH.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙SOH.IsPassword = False
        Me.l랙SOH.Location = New System.Drawing.Point(124, 76)
        Me.l랙SOH.MaxRange = 0
        Me.l랙SOH.MinRange = 0
        Me.l랙SOH.Name = "l랙SOH"
        Me.l랙SOH.Size = New System.Drawing.Size(119, 30)
        Me.l랙SOH.TabIndex = 63
        Me.l랙SOH.TextAlign = System.Drawing.StringAlignment.Far
        Me.l랙SOH.UseKeyPad = False
        '
        'l랙전류
        '
        Me.l랙전류.BackColor = System.Drawing.Color.White
        Me.l랙전류.BackImage = Nothing
        Me.l랙전류.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙전류.BorderSide_Bottom = True
        Me.l랙전류.BorderSide_Left = True
        Me.l랙전류.BorderSide_Right = True
        Me.l랙전류.BorderSide_Top = True
        Me.l랙전류.BorderWidth = 1
        Me.l랙전류.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙전류.IsPassword = False
        Me.l랙전류.Location = New System.Drawing.Point(124, 148)
        Me.l랙전류.MaxRange = 0
        Me.l랙전류.MinRange = 0
        Me.l랙전류.Name = "l랙전류"
        Me.l랙전류.Size = New System.Drawing.Size(119, 30)
        Me.l랙전류.TabIndex = 55
        Me.l랙전류.TextAlign = System.Drawing.StringAlignment.Far
        Me.l랙전류.UseKeyPad = False
        '
        'VsLabel38
        '
        Me.VsLabel38.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel38.BackImage = Nothing
        Me.VsLabel38.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel38.BorderSide_Bottom = True
        Me.VsLabel38.BorderSide_Left = True
        Me.VsLabel38.BorderSide_Right = True
        Me.VsLabel38.BorderSide_Top = True
        Me.VsLabel38.BorderWidth = 1
        Me.VsLabel38.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel38.IsPassword = False
        Me.VsLabel38.Location = New System.Drawing.Point(20, 76)
        Me.VsLabel38.MaxRange = 0
        Me.VsLabel38.MinRange = 0
        Me.VsLabel38.Name = "VsLabel38"
        Me.VsLabel38.Size = New System.Drawing.Size(98, 30)
        Me.VsLabel38.TabIndex = 56
        Me.VsLabel38.Text = "랙 SOH"
        Me.VsLabel38.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel38.UseKeyPad = False
        '
        'l랙전압
        '
        Me.l랙전압.BackColor = System.Drawing.Color.White
        Me.l랙전압.BackImage = Nothing
        Me.l랙전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙전압.BorderSide_Bottom = True
        Me.l랙전압.BorderSide_Left = True
        Me.l랙전압.BorderSide_Right = True
        Me.l랙전압.BorderSide_Top = True
        Me.l랙전압.BorderWidth = 1
        Me.l랙전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙전압.IsPassword = False
        Me.l랙전압.Location = New System.Drawing.Point(124, 112)
        Me.l랙전압.MaxRange = 0
        Me.l랙전압.MinRange = 0
        Me.l랙전압.Name = "l랙전압"
        Me.l랙전압.Size = New System.Drawing.Size(119, 30)
        Me.l랙전압.TabIndex = 57
        Me.l랙전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.l랙전압.UseKeyPad = False
        '
        'VsLabel14
        '
        Me.VsLabel14.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel14.BackImage = Nothing
        Me.VsLabel14.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel14.BorderSide_Bottom = True
        Me.VsLabel14.BorderSide_Left = True
        Me.VsLabel14.BorderSide_Right = True
        Me.VsLabel14.BorderSide_Top = True
        Me.VsLabel14.BorderWidth = 1
        Me.VsLabel14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel14.IsPassword = False
        Me.VsLabel14.Location = New System.Drawing.Point(260, 220)
        Me.VsLabel14.MaxRange = 0
        Me.VsLabel14.MinRange = 0
        Me.VsLabel14.Name = "VsLabel14"
        Me.VsLabel14.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel14.TabIndex = 42
        Me.VsLabel14.Text = "평균 전압"
        Me.VsLabel14.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel14.UseKeyPad = False
        '
        'VsLabel15
        '
        Me.VsLabel15.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel15.BackImage = Nothing
        Me.VsLabel15.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel15.BorderSide_Bottom = True
        Me.VsLabel15.BorderSide_Left = True
        Me.VsLabel15.BorderSide_Right = True
        Me.VsLabel15.BorderSide_Top = True
        Me.VsLabel15.BorderWidth = 1
        Me.VsLabel15.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel15.IsPassword = False
        Me.VsLabel15.Location = New System.Drawing.Point(507, 40)
        Me.VsLabel15.MaxRange = 0
        Me.VsLabel15.MinRange = 0
        Me.VsLabel15.Name = "VsLabel15"
        Me.VsLabel15.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel15.TabIndex = 36
        Me.VsLabel15.Text = "최대온도"
        Me.VsLabel15.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel15.UseKeyPad = False
        '
        'VsLabel16
        '
        Me.VsLabel16.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel16.BackImage = Nothing
        Me.VsLabel16.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel16.BorderSide_Bottom = True
        Me.VsLabel16.BorderSide_Left = True
        Me.VsLabel16.BorderSide_Right = True
        Me.VsLabel16.BorderSide_Top = True
        Me.VsLabel16.BorderWidth = 1
        Me.VsLabel16.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel16.IsPassword = False
        Me.VsLabel16.Location = New System.Drawing.Point(507, 148)
        Me.VsLabel16.MaxRange = 0
        Me.VsLabel16.MinRange = 0
        Me.VsLabel16.Name = "VsLabel16"
        Me.VsLabel16.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel16.TabIndex = 35
        Me.VsLabel16.Text = "최소온도 위치"
        Me.VsLabel16.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel16.UseKeyPad = False
        '
        'l랙평균모듈온도
        '
        Me.l랙평균모듈온도.BackColor = System.Drawing.Color.White
        Me.l랙평균모듈온도.BackImage = Nothing
        Me.l랙평균모듈온도.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙평균모듈온도.BorderSide_Bottom = True
        Me.l랙평균모듈온도.BorderSide_Left = True
        Me.l랙평균모듈온도.BorderSide_Right = True
        Me.l랙평균모듈온도.BorderSide_Top = True
        Me.l랙평균모듈온도.BorderWidth = 1
        Me.l랙평균모듈온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙평균모듈온도.IsPassword = False
        Me.l랙평균모듈온도.Location = New System.Drawing.Point(631, 220)
        Me.l랙평균모듈온도.MaxRange = 0
        Me.l랙평균모듈온도.MinRange = 0
        Me.l랙평균모듈온도.Name = "l랙평균모듈온도"
        Me.l랙평균모듈온도.Size = New System.Drawing.Size(119, 30)
        Me.l랙평균모듈온도.TabIndex = 31
        Me.l랙평균모듈온도.TextAlign = System.Drawing.StringAlignment.Far
        Me.l랙평균모듈온도.UseKeyPad = False
        '
        'lCell최대온도
        '
        Me.lCell최대온도.BackColor = System.Drawing.Color.White
        Me.lCell최대온도.BackImage = Nothing
        Me.lCell최대온도.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대온도.BorderSide_Bottom = True
        Me.lCell최대온도.BorderSide_Left = True
        Me.lCell최대온도.BorderSide_Right = True
        Me.lCell최대온도.BorderSide_Top = True
        Me.lCell최대온도.BorderWidth = 1
        Me.lCell최대온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대온도.IsPassword = False
        Me.lCell최대온도.Location = New System.Drawing.Point(631, 40)
        Me.lCell최대온도.MaxRange = 0
        Me.lCell최대온도.MinRange = 0
        Me.lCell최대온도.Name = "lCell최대온도"
        Me.lCell최대온도.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대온도.TabIndex = 37
        Me.lCell최대온도.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최대온도.UseKeyPad = False
        '
        'lCell온도편차
        '
        Me.lCell온도편차.BackColor = System.Drawing.Color.White
        Me.lCell온도편차.BackImage = Nothing
        Me.lCell온도편차.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell온도편차.BorderSide_Bottom = True
        Me.lCell온도편차.BorderSide_Left = True
        Me.lCell온도편차.BorderSide_Right = True
        Me.lCell온도편차.BorderSide_Top = True
        Me.lCell온도편차.BorderWidth = 1
        Me.lCell온도편차.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell온도편차.IsPassword = False
        Me.lCell온도편차.Location = New System.Drawing.Point(631, 184)
        Me.lCell온도편차.MaxRange = 0
        Me.lCell온도편차.MinRange = 0
        Me.lCell온도편차.Name = "lCell온도편차"
        Me.lCell온도편차.Size = New System.Drawing.Size(119, 30)
        Me.lCell온도편차.TabIndex = 33
        Me.lCell온도편차.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell온도편차.UseKeyPad = False
        '
        'VsLabel17
        '
        Me.VsLabel17.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel17.BackImage = Nothing
        Me.VsLabel17.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel17.BorderSide_Bottom = True
        Me.VsLabel17.BorderSide_Left = True
        Me.VsLabel17.BorderSide_Right = True
        Me.VsLabel17.BorderSide_Top = True
        Me.VsLabel17.BorderWidth = 1
        Me.VsLabel17.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel17.IsPassword = False
        Me.VsLabel17.Location = New System.Drawing.Point(507, 112)
        Me.VsLabel17.MaxRange = 0
        Me.VsLabel17.MinRange = 0
        Me.VsLabel17.Name = "VsLabel17"
        Me.VsLabel17.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel17.TabIndex = 40
        Me.VsLabel17.Text = "최소온도"
        Me.VsLabel17.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel17.UseKeyPad = False
        '
        'VsLabel18
        '
        Me.VsLabel18.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel18.BackImage = Nothing
        Me.VsLabel18.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel18.BorderSide_Bottom = True
        Me.VsLabel18.BorderSide_Left = True
        Me.VsLabel18.BorderSide_Right = True
        Me.VsLabel18.BorderSide_Top = True
        Me.VsLabel18.BorderWidth = 1
        Me.VsLabel18.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel18.IsPassword = False
        Me.VsLabel18.Location = New System.Drawing.Point(507, 184)
        Me.VsLabel18.MaxRange = 0
        Me.VsLabel18.MinRange = 0
        Me.VsLabel18.Name = "VsLabel18"
        Me.VsLabel18.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel18.TabIndex = 30
        Me.VsLabel18.Text = "온도 편차"
        Me.VsLabel18.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel18.UseKeyPad = False
        '
        'lCell최대온도위치
        '
        Me.lCell최대온도위치.BackColor = System.Drawing.Color.White
        Me.lCell최대온도위치.BackImage = Nothing
        Me.lCell최대온도위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대온도위치.BorderSide_Bottom = True
        Me.lCell최대온도위치.BorderSide_Left = True
        Me.lCell최대온도위치.BorderSide_Right = True
        Me.lCell최대온도위치.BorderSide_Top = True
        Me.lCell최대온도위치.BorderWidth = 1
        Me.lCell최대온도위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대온도위치.IsPassword = False
        Me.lCell최대온도위치.Location = New System.Drawing.Point(631, 76)
        Me.lCell최대온도위치.MaxRange = 0
        Me.lCell최대온도위치.MinRange = 0
        Me.lCell최대온도위치.Name = "lCell최대온도위치"
        Me.lCell최대온도위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대온도위치.TabIndex = 39
        Me.lCell최대온도위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최대온도위치.UseKeyPad = False
        '
        'lCell최소온도위치
        '
        Me.lCell최소온도위치.BackColor = System.Drawing.Color.White
        Me.lCell최소온도위치.BackImage = Nothing
        Me.lCell최소온도위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소온도위치.BorderSide_Bottom = True
        Me.lCell최소온도위치.BorderSide_Left = True
        Me.lCell최소온도위치.BorderSide_Right = True
        Me.lCell최소온도위치.BorderSide_Top = True
        Me.lCell최소온도위치.BorderWidth = 1
        Me.lCell최소온도위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소온도위치.IsPassword = False
        Me.lCell최소온도위치.Location = New System.Drawing.Point(631, 148)
        Me.lCell최소온도위치.MaxRange = 0
        Me.lCell최소온도위치.MinRange = 0
        Me.lCell최소온도위치.Name = "lCell최소온도위치"
        Me.lCell최소온도위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소온도위치.TabIndex = 27
        Me.lCell최소온도위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최소온도위치.UseKeyPad = False
        '
        'VsLabel19
        '
        Me.VsLabel19.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel19.BackImage = Nothing
        Me.VsLabel19.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel19.BorderSide_Bottom = True
        Me.VsLabel19.BorderSide_Left = True
        Me.VsLabel19.BorderSide_Right = True
        Me.VsLabel19.BorderSide_Top = True
        Me.VsLabel19.BorderWidth = 1
        Me.VsLabel19.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel19.IsPassword = False
        Me.VsLabel19.Location = New System.Drawing.Point(507, 220)
        Me.VsLabel19.MaxRange = 0
        Me.VsLabel19.MinRange = 0
        Me.VsLabel19.Name = "VsLabel19"
        Me.VsLabel19.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel19.TabIndex = 38
        Me.VsLabel19.Text = "평균 온도"
        Me.VsLabel19.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel19.UseKeyPad = False
        '
        'VsLabel20
        '
        Me.VsLabel20.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel20.BackImage = Nothing
        Me.VsLabel20.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel20.BorderSide_Bottom = True
        Me.VsLabel20.BorderSide_Left = True
        Me.VsLabel20.BorderSide_Right = True
        Me.VsLabel20.BorderSide_Top = True
        Me.VsLabel20.BorderWidth = 1
        Me.VsLabel20.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel20.IsPassword = False
        Me.VsLabel20.Location = New System.Drawing.Point(507, 76)
        Me.VsLabel20.MaxRange = 0
        Me.VsLabel20.MinRange = 0
        Me.VsLabel20.Name = "VsLabel20"
        Me.VsLabel20.Size = New System.Drawing.Size(118, 30)
        Me.VsLabel20.TabIndex = 28
        Me.VsLabel20.Text = "최대온도 위치"
        Me.VsLabel20.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel20.UseKeyPad = False
        '
        'lCell최소온도
        '
        Me.lCell최소온도.BackColor = System.Drawing.Color.White
        Me.lCell최소온도.BackImage = Nothing
        Me.lCell최소온도.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소온도.BorderSide_Bottom = True
        Me.lCell최소온도.BorderSide_Left = True
        Me.lCell최소온도.BorderSide_Right = True
        Me.lCell최소온도.BorderSide_Top = True
        Me.lCell최소온도.BorderWidth = 1
        Me.lCell최소온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소온도.IsPassword = False
        Me.lCell최소온도.Location = New System.Drawing.Point(631, 112)
        Me.lCell최소온도.MaxRange = 0
        Me.lCell최소온도.MinRange = 0
        Me.lCell최소온도.Name = "lCell최소온도"
        Me.lCell최소온도.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소온도.TabIndex = 29
        Me.lCell최소온도.TextAlign = System.Drawing.StringAlignment.Far
        Me.lCell최소온도.UseKeyPad = False
        '
        'VsGroupBox3
        '
        Me.VsGroupBox3.BackColor = System.Drawing.Color.White
        Me.VsGroupBox3.Controls.Add(Me.VsLabel121)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module17)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module1)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module16)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module2)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module13)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module3)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module15)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module4)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module12)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module5)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module14)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module6)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module11)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module7)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module10)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module8)
        Me.VsGroupBox3.Controls.Add(Me.btn_Module9)
        Me.VsGroupBox3.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox3.HeaderText = "배터리 사용량"
        Me.VsGroupBox3.Location = New System.Drawing.Point(31, 13)
        Me.VsGroupBox3.Name = "VsGroupBox3"
        Me.VsGroupBox3.Size = New System.Drawing.Size(255, 260)
        Me.VsGroupBox3.TabIndex = 0
        '
        'VsLabel121
        '
        Me.VsLabel121.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel121.BackImage = Nothing
        Me.VsLabel121.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel121.BorderSide_Bottom = True
        Me.VsLabel121.BorderSide_Left = True
        Me.VsLabel121.BorderSide_Right = True
        Me.VsLabel121.BorderSide_Top = True
        Me.VsLabel121.BorderWidth = 1
        Me.VsLabel121.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel121.IsPassword = False
        Me.VsLabel121.Location = New System.Drawing.Point(32, 43)
        Me.VsLabel121.MaxRange = 0
        Me.VsLabel121.MinRange = 0
        Me.VsLabel121.Name = "VsLabel121"
        Me.VsLabel121.Size = New System.Drawing.Size(190, 30)
        Me.VsLabel121.TabIndex = 87
        Me.VsLabel121.Text = "Module Info"
        Me.VsLabel121.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel121.UseKeyPad = False
        '
        'btn_Module17
        '
        Me.btn_Module17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module17.BackImage = Nothing
        Me.btn_Module17.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module17.BorderSide_Bottom = True
        Me.btn_Module17.BorderSide_Left = True
        Me.btn_Module17.BorderSide_Right = True
        Me.btn_Module17.BorderSide_Top = True
        Me.btn_Module17.BorderWidth = 1
        Me.btn_Module17.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module17.IsPassword = False
        Me.btn_Module17.Location = New System.Drawing.Point(32, 223)
        Me.btn_Module17.MaxRange = 0
        Me.btn_Module17.MinRange = 0
        Me.btn_Module17.Name = "btn_Module17"
        Me.btn_Module17.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module17.TabIndex = 104
        Me.btn_Module17.Text = "#17"
        Me.btn_Module17.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module17.UseKeyPad = False
        '
        'btn_Module1
        '
        Me.btn_Module1.BackColor = System.Drawing.Color.White
        Me.btn_Module1.BackImage = Nothing
        Me.btn_Module1.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module1.BorderSide_Bottom = True
        Me.btn_Module1.BorderSide_Left = True
        Me.btn_Module1.BorderSide_Right = True
        Me.btn_Module1.BorderSide_Top = True
        Me.btn_Module1.BorderWidth = 1
        Me.btn_Module1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module1.IsPassword = False
        Me.btn_Module1.Location = New System.Drawing.Point(32, 79)
        Me.btn_Module1.MaxRange = 0
        Me.btn_Module1.MinRange = 0
        Me.btn_Module1.Name = "btn_Module1"
        Me.btn_Module1.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module1.TabIndex = 88
        Me.btn_Module1.Text = "#1"
        Me.btn_Module1.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module1.UseKeyPad = False
        '
        'btn_Module16
        '
        Me.btn_Module16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module16.BackImage = Nothing
        Me.btn_Module16.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module16.BorderSide_Bottom = True
        Me.btn_Module16.BorderSide_Left = True
        Me.btn_Module16.BorderSide_Right = True
        Me.btn_Module16.BorderSide_Top = True
        Me.btn_Module16.BorderWidth = 1
        Me.btn_Module16.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module16.IsPassword = False
        Me.btn_Module16.Location = New System.Drawing.Point(180, 187)
        Me.btn_Module16.MaxRange = 0
        Me.btn_Module16.MinRange = 0
        Me.btn_Module16.Name = "btn_Module16"
        Me.btn_Module16.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module16.TabIndex = 103
        Me.btn_Module16.Text = "#16"
        Me.btn_Module16.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module16.UseKeyPad = False
        '
        'btn_Module2
        '
        Me.btn_Module2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module2.BackImage = Nothing
        Me.btn_Module2.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module2.BorderSide_Bottom = True
        Me.btn_Module2.BorderSide_Left = True
        Me.btn_Module2.BorderSide_Right = True
        Me.btn_Module2.BorderSide_Top = True
        Me.btn_Module2.BorderWidth = 1
        Me.btn_Module2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module2.IsPassword = False
        Me.btn_Module2.Location = New System.Drawing.Point(81, 79)
        Me.btn_Module2.MaxRange = 0
        Me.btn_Module2.MinRange = 0
        Me.btn_Module2.Name = "btn_Module2"
        Me.btn_Module2.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module2.TabIndex = 89
        Me.btn_Module2.Text = "#2"
        Me.btn_Module2.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module2.UseKeyPad = False
        '
        'btn_Module13
        '
        Me.btn_Module13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module13.BackImage = Nothing
        Me.btn_Module13.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module13.BorderSide_Bottom = True
        Me.btn_Module13.BorderSide_Left = True
        Me.btn_Module13.BorderSide_Right = True
        Me.btn_Module13.BorderSide_Top = True
        Me.btn_Module13.BorderWidth = 1
        Me.btn_Module13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module13.IsPassword = False
        Me.btn_Module13.Location = New System.Drawing.Point(32, 187)
        Me.btn_Module13.MaxRange = 0
        Me.btn_Module13.MinRange = 0
        Me.btn_Module13.Name = "btn_Module13"
        Me.btn_Module13.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module13.TabIndex = 100
        Me.btn_Module13.Text = "#13"
        Me.btn_Module13.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module13.UseKeyPad = False
        '
        'btn_Module3
        '
        Me.btn_Module3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module3.BackImage = Nothing
        Me.btn_Module3.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module3.BorderSide_Bottom = True
        Me.btn_Module3.BorderSide_Left = True
        Me.btn_Module3.BorderSide_Right = True
        Me.btn_Module3.BorderSide_Top = True
        Me.btn_Module3.BorderWidth = 1
        Me.btn_Module3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module3.IsPassword = False
        Me.btn_Module3.Location = New System.Drawing.Point(129, 79)
        Me.btn_Module3.MaxRange = 0
        Me.btn_Module3.MinRange = 0
        Me.btn_Module3.Name = "btn_Module3"
        Me.btn_Module3.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module3.TabIndex = 90
        Me.btn_Module3.Text = "#3"
        Me.btn_Module3.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module3.UseKeyPad = False
        '
        'btn_Module15
        '
        Me.btn_Module15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module15.BackImage = Nothing
        Me.btn_Module15.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module15.BorderSide_Bottom = True
        Me.btn_Module15.BorderSide_Left = True
        Me.btn_Module15.BorderSide_Right = True
        Me.btn_Module15.BorderSide_Top = True
        Me.btn_Module15.BorderWidth = 1
        Me.btn_Module15.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module15.IsPassword = False
        Me.btn_Module15.Location = New System.Drawing.Point(129, 187)
        Me.btn_Module15.MaxRange = 0
        Me.btn_Module15.MinRange = 0
        Me.btn_Module15.Name = "btn_Module15"
        Me.btn_Module15.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module15.TabIndex = 102
        Me.btn_Module15.Text = "#15"
        Me.btn_Module15.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module15.UseKeyPad = False
        '
        'btn_Module4
        '
        Me.btn_Module4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module4.BackImage = Nothing
        Me.btn_Module4.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module4.BorderSide_Bottom = True
        Me.btn_Module4.BorderSide_Left = True
        Me.btn_Module4.BorderSide_Right = True
        Me.btn_Module4.BorderSide_Top = True
        Me.btn_Module4.BorderWidth = 1
        Me.btn_Module4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module4.IsPassword = False
        Me.btn_Module4.Location = New System.Drawing.Point(180, 79)
        Me.btn_Module4.MaxRange = 0
        Me.btn_Module4.MinRange = 0
        Me.btn_Module4.Name = "btn_Module4"
        Me.btn_Module4.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module4.TabIndex = 91
        Me.btn_Module4.Text = "#4"
        Me.btn_Module4.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module4.UseKeyPad = False
        '
        'btn_Module12
        '
        Me.btn_Module12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module12.BackImage = Nothing
        Me.btn_Module12.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module12.BorderSide_Bottom = True
        Me.btn_Module12.BorderSide_Left = True
        Me.btn_Module12.BorderSide_Right = True
        Me.btn_Module12.BorderSide_Top = True
        Me.btn_Module12.BorderWidth = 1
        Me.btn_Module12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module12.IsPassword = False
        Me.btn_Module12.Location = New System.Drawing.Point(180, 151)
        Me.btn_Module12.MaxRange = 0
        Me.btn_Module12.MinRange = 0
        Me.btn_Module12.Name = "btn_Module12"
        Me.btn_Module12.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module12.TabIndex = 99
        Me.btn_Module12.Text = "#12"
        Me.btn_Module12.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module12.UseKeyPad = False
        '
        'btn_Module5
        '
        Me.btn_Module5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module5.BackImage = Nothing
        Me.btn_Module5.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module5.BorderSide_Bottom = True
        Me.btn_Module5.BorderSide_Left = True
        Me.btn_Module5.BorderSide_Right = True
        Me.btn_Module5.BorderSide_Top = True
        Me.btn_Module5.BorderWidth = 1
        Me.btn_Module5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module5.IsPassword = False
        Me.btn_Module5.Location = New System.Drawing.Point(32, 115)
        Me.btn_Module5.MaxRange = 0
        Me.btn_Module5.MinRange = 0
        Me.btn_Module5.Name = "btn_Module5"
        Me.btn_Module5.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module5.TabIndex = 92
        Me.btn_Module5.Text = "#5"
        Me.btn_Module5.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module5.UseKeyPad = False
        '
        'btn_Module14
        '
        Me.btn_Module14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module14.BackImage = Nothing
        Me.btn_Module14.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module14.BorderSide_Bottom = True
        Me.btn_Module14.BorderSide_Left = True
        Me.btn_Module14.BorderSide_Right = True
        Me.btn_Module14.BorderSide_Top = True
        Me.btn_Module14.BorderWidth = 1
        Me.btn_Module14.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module14.IsPassword = False
        Me.btn_Module14.Location = New System.Drawing.Point(81, 187)
        Me.btn_Module14.MaxRange = 0
        Me.btn_Module14.MinRange = 0
        Me.btn_Module14.Name = "btn_Module14"
        Me.btn_Module14.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module14.TabIndex = 101
        Me.btn_Module14.Text = "#14"
        Me.btn_Module14.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module14.UseKeyPad = False
        '
        'btn_Module6
        '
        Me.btn_Module6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module6.BackImage = Nothing
        Me.btn_Module6.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module6.BorderSide_Bottom = True
        Me.btn_Module6.BorderSide_Left = True
        Me.btn_Module6.BorderSide_Right = True
        Me.btn_Module6.BorderSide_Top = True
        Me.btn_Module6.BorderWidth = 1
        Me.btn_Module6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module6.IsPassword = False
        Me.btn_Module6.Location = New System.Drawing.Point(81, 115)
        Me.btn_Module6.MaxRange = 0
        Me.btn_Module6.MinRange = 0
        Me.btn_Module6.Name = "btn_Module6"
        Me.btn_Module6.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module6.TabIndex = 93
        Me.btn_Module6.Text = "#6"
        Me.btn_Module6.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module6.UseKeyPad = False
        '
        'btn_Module11
        '
        Me.btn_Module11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module11.BackImage = Nothing
        Me.btn_Module11.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module11.BorderSide_Bottom = True
        Me.btn_Module11.BorderSide_Left = True
        Me.btn_Module11.BorderSide_Right = True
        Me.btn_Module11.BorderSide_Top = True
        Me.btn_Module11.BorderWidth = 1
        Me.btn_Module11.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module11.IsPassword = False
        Me.btn_Module11.Location = New System.Drawing.Point(129, 151)
        Me.btn_Module11.MaxRange = 0
        Me.btn_Module11.MinRange = 0
        Me.btn_Module11.Name = "btn_Module11"
        Me.btn_Module11.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module11.TabIndex = 98
        Me.btn_Module11.Text = "#11"
        Me.btn_Module11.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module11.UseKeyPad = False
        '
        'btn_Module7
        '
        Me.btn_Module7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module7.BackImage = Nothing
        Me.btn_Module7.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module7.BorderSide_Bottom = True
        Me.btn_Module7.BorderSide_Left = True
        Me.btn_Module7.BorderSide_Right = True
        Me.btn_Module7.BorderSide_Top = True
        Me.btn_Module7.BorderWidth = 1
        Me.btn_Module7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module7.IsPassword = False
        Me.btn_Module7.Location = New System.Drawing.Point(129, 115)
        Me.btn_Module7.MaxRange = 0
        Me.btn_Module7.MinRange = 0
        Me.btn_Module7.Name = "btn_Module7"
        Me.btn_Module7.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module7.TabIndex = 94
        Me.btn_Module7.Text = "#7"
        Me.btn_Module7.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module7.UseKeyPad = False
        '
        'btn_Module10
        '
        Me.btn_Module10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module10.BackImage = Nothing
        Me.btn_Module10.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module10.BorderSide_Bottom = True
        Me.btn_Module10.BorderSide_Left = True
        Me.btn_Module10.BorderSide_Right = True
        Me.btn_Module10.BorderSide_Top = True
        Me.btn_Module10.BorderWidth = 1
        Me.btn_Module10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module10.IsPassword = False
        Me.btn_Module10.Location = New System.Drawing.Point(81, 151)
        Me.btn_Module10.MaxRange = 0
        Me.btn_Module10.MinRange = 0
        Me.btn_Module10.Name = "btn_Module10"
        Me.btn_Module10.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module10.TabIndex = 97
        Me.btn_Module10.Text = "#10"
        Me.btn_Module10.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module10.UseKeyPad = False
        '
        'btn_Module8
        '
        Me.btn_Module8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module8.BackImage = Nothing
        Me.btn_Module8.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module8.BorderSide_Bottom = True
        Me.btn_Module8.BorderSide_Left = True
        Me.btn_Module8.BorderSide_Right = True
        Me.btn_Module8.BorderSide_Top = True
        Me.btn_Module8.BorderWidth = 1
        Me.btn_Module8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module8.IsPassword = False
        Me.btn_Module8.Location = New System.Drawing.Point(180, 115)
        Me.btn_Module8.MaxRange = 0
        Me.btn_Module8.MinRange = 0
        Me.btn_Module8.Name = "btn_Module8"
        Me.btn_Module8.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module8.TabIndex = 95
        Me.btn_Module8.Text = "#8"
        Me.btn_Module8.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module8.UseKeyPad = False
        '
        'btn_Module9
        '
        Me.btn_Module9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Module9.BackImage = Nothing
        Me.btn_Module9.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Module9.BorderSide_Bottom = True
        Me.btn_Module9.BorderSide_Left = True
        Me.btn_Module9.BorderSide_Right = True
        Me.btn_Module9.BorderSide_Top = True
        Me.btn_Module9.BorderWidth = 1
        Me.btn_Module9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module9.IsPassword = False
        Me.btn_Module9.Location = New System.Drawing.Point(32, 151)
        Me.btn_Module9.MaxRange = 0
        Me.btn_Module9.MinRange = 0
        Me.btn_Module9.Name = "btn_Module9"
        Me.btn_Module9.Size = New System.Drawing.Size(42, 30)
        Me.btn_Module9.TabIndex = 96
        Me.btn_Module9.Text = "#9"
        Me.btn_Module9.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module9.UseKeyPad = False
        '
        'VsGroupBox4
        '
        Me.VsGroupBox4.BackColor = System.Drawing.Color.White
        Me.VsGroupBox4.Controls.Add(Me.VsLabel40)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel52)
        Me.VsGroupBox4.Controls.Add(Me.l모듈최고최저온도위치)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel63)
        Me.VsGroupBox4.Controls.Add(Me.l모듈최저온도)
        Me.VsGroupBox4.Controls.Add(Me.l최고최저셀전압위치)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel41)
        Me.VsGroupBox4.Controls.Add(Me.l모듈내Cell최대전압)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel55)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel48)
        Me.VsGroupBox4.Controls.Add(Me.l모듈내Cell최저전압)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel56)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel67)
        Me.VsGroupBox4.Controls.Add(Me.l모듈전압)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel45)
        Me.VsGroupBox4.Controls.Add(Me.l모듈최고온도)
        Me.VsGroupBox4.Controls.Add(Me.l모듈평균온도)
        Me.VsGroupBox4.Controls.Add(Me.l모듈내Cell평균전압)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel44)
        Me.VsGroupBox4.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox4.HeaderText = "배터리 사용량"
        Me.VsGroupBox4.Location = New System.Drawing.Point(310, 13)
        Me.VsGroupBox4.Name = "VsGroupBox4"
        Me.VsGroupBox4.Size = New System.Drawing.Size(452, 260)
        Me.VsGroupBox4.TabIndex = 1
        '
        'VsLabel40
        '
        Me.VsLabel40.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel40.BackImage = Nothing
        Me.VsLabel40.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel40.BorderSide_Bottom = True
        Me.VsLabel40.BorderSide_Left = True
        Me.VsLabel40.BorderSide_Right = True
        Me.VsLabel40.BorderSide_Top = True
        Me.VsLabel40.BorderWidth = 1
        Me.VsLabel40.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel40.IsPassword = False
        Me.VsLabel40.Location = New System.Drawing.Point(14, 43)
        Me.VsLabel40.MaxRange = 0
        Me.VsLabel40.MinRange = 0
        Me.VsLabel40.Name = "VsLabel40"
        Me.VsLabel40.Size = New System.Drawing.Size(423, 30)
        Me.VsLabel40.TabIndex = 107
        Me.VsLabel40.Text = "Module Info"
        Me.VsLabel40.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel40.UseKeyPad = False
        '
        'VsLabel52
        '
        Me.VsLabel52.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel52.BackImage = Nothing
        Me.VsLabel52.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel52.BorderSide_Bottom = True
        Me.VsLabel52.BorderSide_Left = True
        Me.VsLabel52.BorderSide_Right = True
        Me.VsLabel52.BorderSide_Top = True
        Me.VsLabel52.BorderWidth = 1
        Me.VsLabel52.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel52.IsPassword = False
        Me.VsLabel52.Location = New System.Drawing.Point(231, 151)
        Me.VsLabel52.MaxRange = 0
        Me.VsLabel52.MinRange = 0
        Me.VsLabel52.Name = "VsLabel52"
        Me.VsLabel52.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel52.TabIndex = 60
        Me.VsLabel52.Text = "최고온도"
        Me.VsLabel52.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel52.UseKeyPad = False
        '
        'l모듈최고최저온도위치
        '
        Me.l모듈최고최저온도위치.BackColor = System.Drawing.Color.White
        Me.l모듈최고최저온도위치.BackImage = Nothing
        Me.l모듈최고최저온도위치.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈최고최저온도위치.BorderSide_Bottom = True
        Me.l모듈최고최저온도위치.BorderSide_Left = True
        Me.l모듈최고최저온도위치.BorderSide_Right = True
        Me.l모듈최고최저온도위치.BorderSide_Top = True
        Me.l모듈최고최저온도위치.BorderWidth = 1
        Me.l모듈최고최저온도위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈최고최저온도위치.IsPassword = False
        Me.l모듈최고최저온도위치.Location = New System.Drawing.Point(318, 223)
        Me.l모듈최고최저온도위치.MaxRange = 0
        Me.l모듈최고최저온도위치.MinRange = 0
        Me.l모듈최고최저온도위치.Name = "l모듈최고최저온도위치"
        Me.l모듈최고최저온도위치.Size = New System.Drawing.Size(119, 30)
        Me.l모듈최고최저온도위치.TabIndex = 51
        Me.l모듈최고최저온도위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈최고최저온도위치.UseKeyPad = False
        '
        'VsLabel63
        '
        Me.VsLabel63.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel63.BackImage = Nothing
        Me.VsLabel63.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel63.BorderSide_Bottom = True
        Me.VsLabel63.BorderSide_Left = True
        Me.VsLabel63.BorderSide_Right = True
        Me.VsLabel63.BorderSide_Top = True
        Me.VsLabel63.BorderWidth = 1
        Me.VsLabel63.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel63.IsPassword = False
        Me.VsLabel63.Location = New System.Drawing.Point(14, 223)
        Me.VsLabel63.MaxRange = 0
        Me.VsLabel63.MinRange = 0
        Me.VsLabel63.Name = "VsLabel63"
        Me.VsLabel63.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel63.TabIndex = 42
        Me.VsLabel63.Text = "전압 위치"
        Me.VsLabel63.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel63.UseKeyPad = False
        '
        'l모듈최저온도
        '
        Me.l모듈최저온도.BackColor = System.Drawing.Color.White
        Me.l모듈최저온도.BackImage = Nothing
        Me.l모듈최저온도.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈최저온도.BorderSide_Bottom = True
        Me.l모듈최저온도.BorderSide_Left = True
        Me.l모듈최저온도.BorderSide_Right = True
        Me.l모듈최저온도.BorderSide_Top = True
        Me.l모듈최저온도.BorderWidth = 1
        Me.l모듈최저온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈최저온도.IsPassword = False
        Me.l모듈최저온도.Location = New System.Drawing.Point(318, 187)
        Me.l모듈최저온도.MaxRange = 0
        Me.l모듈최저온도.MinRange = 0
        Me.l모듈최저온도.Name = "l모듈최저온도"
        Me.l모듈최저온도.Size = New System.Drawing.Size(119, 30)
        Me.l모듈최저온도.TabIndex = 59
        Me.l모듈최저온도.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈최저온도.UseKeyPad = False
        '
        'l최고최저셀전압위치
        '
        Me.l최고최저셀전압위치.BackColor = System.Drawing.Color.White
        Me.l최고최저셀전압위치.BackImage = Nothing
        Me.l최고최저셀전압위치.BorderColor = System.Drawing.Color.DarkGray
        Me.l최고최저셀전압위치.BorderSide_Bottom = True
        Me.l최고최저셀전압위치.BorderSide_Left = True
        Me.l최고최저셀전압위치.BorderSide_Right = True
        Me.l최고최저셀전압위치.BorderSide_Top = True
        Me.l최고최저셀전압위치.BorderWidth = 1
        Me.l최고최저셀전압위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l최고최저셀전압위치.IsPassword = False
        Me.l최고최저셀전압위치.Location = New System.Drawing.Point(102, 223)
        Me.l최고최저셀전압위치.MaxRange = 0
        Me.l최고최저셀전압위치.MinRange = 0
        Me.l최고최저셀전압위치.Name = "l최고최저셀전압위치"
        Me.l최고최저셀전압위치.Size = New System.Drawing.Size(119, 30)
        Me.l최고최저셀전압위치.TabIndex = 39
        Me.l최고최저셀전압위치.TextAlign = System.Drawing.StringAlignment.Far
        Me.l최고최저셀전압위치.UseKeyPad = False
        '
        'VsLabel41
        '
        Me.VsLabel41.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel41.BackImage = Nothing
        Me.VsLabel41.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel41.BorderSide_Bottom = True
        Me.VsLabel41.BorderSide_Left = True
        Me.VsLabel41.BorderSide_Right = True
        Me.VsLabel41.BorderSide_Top = True
        Me.VsLabel41.BorderWidth = 1
        Me.VsLabel41.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel41.IsPassword = False
        Me.VsLabel41.Location = New System.Drawing.Point(14, 151)
        Me.VsLabel41.MaxRange = 0
        Me.VsLabel41.MinRange = 0
        Me.VsLabel41.Name = "VsLabel41"
        Me.VsLabel41.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel41.TabIndex = 46
        Me.VsLabel41.Text = "최저 전압"
        Me.VsLabel41.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel41.UseKeyPad = False
        '
        'l모듈내Cell최대전압
        '
        Me.l모듈내Cell최대전압.BackColor = System.Drawing.Color.White
        Me.l모듈내Cell최대전압.BackImage = Nothing
        Me.l모듈내Cell최대전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈내Cell최대전압.BorderSide_Bottom = True
        Me.l모듈내Cell최대전압.BorderSide_Left = True
        Me.l모듈내Cell최대전압.BorderSide_Right = True
        Me.l모듈내Cell최대전압.BorderSide_Top = True
        Me.l모듈내Cell최대전압.BorderWidth = 1
        Me.l모듈내Cell최대전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈내Cell최대전압.IsPassword = False
        Me.l모듈내Cell최대전압.Location = New System.Drawing.Point(102, 115)
        Me.l모듈내Cell최대전압.MaxRange = 0
        Me.l모듈내Cell최대전압.MinRange = 0
        Me.l모듈내Cell최대전압.Name = "l모듈내Cell최대전압"
        Me.l모듈내Cell최대전압.Size = New System.Drawing.Size(119, 30)
        Me.l모듈내Cell최대전압.TabIndex = 43
        Me.l모듈내Cell최대전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈내Cell최대전압.UseKeyPad = False
        '
        'VsLabel55
        '
        Me.VsLabel55.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel55.BackImage = Nothing
        Me.VsLabel55.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel55.BorderSide_Bottom = True
        Me.VsLabel55.BorderSide_Left = True
        Me.VsLabel55.BorderSide_Right = True
        Me.VsLabel55.BorderSide_Top = True
        Me.VsLabel55.BorderWidth = 1
        Me.VsLabel55.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel55.IsPassword = False
        Me.VsLabel55.Location = New System.Drawing.Point(231, 115)
        Me.VsLabel55.MaxRange = 0
        Me.VsLabel55.MinRange = 0
        Me.VsLabel55.Name = "VsLabel55"
        Me.VsLabel55.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel55.TabIndex = 64
        Me.VsLabel55.Text = "평균온도"
        Me.VsLabel55.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel55.UseKeyPad = False
        '
        'VsLabel48
        '
        Me.VsLabel48.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel48.BackImage = Nothing
        Me.VsLabel48.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel48.BorderSide_Bottom = True
        Me.VsLabel48.BorderSide_Left = True
        Me.VsLabel48.BorderSide_Right = True
        Me.VsLabel48.BorderSide_Top = True
        Me.VsLabel48.BorderWidth = 1
        Me.VsLabel48.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel48.IsPassword = False
        Me.VsLabel48.Location = New System.Drawing.Point(14, 79)
        Me.VsLabel48.MaxRange = 0
        Me.VsLabel48.MinRange = 0
        Me.VsLabel48.Name = "VsLabel48"
        Me.VsLabel48.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel48.TabIndex = 42
        Me.VsLabel48.Text = "전압"
        Me.VsLabel48.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel48.UseKeyPad = False
        '
        'l모듈내Cell최저전압
        '
        Me.l모듈내Cell최저전압.BackColor = System.Drawing.Color.White
        Me.l모듈내Cell최저전압.BackImage = Nothing
        Me.l모듈내Cell최저전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈내Cell최저전압.BorderSide_Bottom = True
        Me.l모듈내Cell최저전압.BorderSide_Left = True
        Me.l모듈내Cell최저전압.BorderSide_Right = True
        Me.l모듈내Cell최저전압.BorderSide_Top = True
        Me.l모듈내Cell최저전압.BorderWidth = 1
        Me.l모듈내Cell최저전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈내Cell최저전압.IsPassword = False
        Me.l모듈내Cell최저전압.Location = New System.Drawing.Point(102, 151)
        Me.l모듈내Cell최저전압.MaxRange = 0
        Me.l모듈내Cell최저전압.MinRange = 0
        Me.l모듈내Cell최저전압.Name = "l모듈내Cell최저전압"
        Me.l모듈내Cell최저전압.Size = New System.Drawing.Size(119, 30)
        Me.l모듈내Cell최저전압.TabIndex = 41
        Me.l모듈내Cell최저전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈내Cell최저전압.UseKeyPad = False
        '
        'VsLabel56
        '
        Me.VsLabel56.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel56.BackImage = Nothing
        Me.VsLabel56.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel56.BorderSide_Bottom = True
        Me.VsLabel56.BorderSide_Left = True
        Me.VsLabel56.BorderSide_Right = True
        Me.VsLabel56.BorderSide_Top = True
        Me.VsLabel56.BorderWidth = 1
        Me.VsLabel56.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel56.IsPassword = False
        Me.VsLabel56.Location = New System.Drawing.Point(231, 187)
        Me.VsLabel56.MaxRange = 0
        Me.VsLabel56.MinRange = 0
        Me.VsLabel56.Name = "VsLabel56"
        Me.VsLabel56.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel56.TabIndex = 58
        Me.VsLabel56.Text = "최저온도"
        Me.VsLabel56.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel56.UseKeyPad = False
        '
        'VsLabel67
        '
        Me.VsLabel67.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel67.BackImage = Nothing
        Me.VsLabel67.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel67.BorderSide_Bottom = True
        Me.VsLabel67.BorderSide_Left = True
        Me.VsLabel67.BorderSide_Right = True
        Me.VsLabel67.BorderSide_Top = True
        Me.VsLabel67.BorderWidth = 1
        Me.VsLabel67.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel67.IsPassword = False
        Me.VsLabel67.Location = New System.Drawing.Point(231, 223)
        Me.VsLabel67.MaxRange = 0
        Me.VsLabel67.MinRange = 0
        Me.VsLabel67.Name = "VsLabel67"
        Me.VsLabel67.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel67.TabIndex = 56
        Me.VsLabel67.Text = "온도위치"
        Me.VsLabel67.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel67.UseKeyPad = False
        '
        'l모듈전압
        '
        Me.l모듈전압.BackColor = System.Drawing.Color.White
        Me.l모듈전압.BackImage = Nothing
        Me.l모듈전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈전압.BorderSide_Bottom = True
        Me.l모듈전압.BorderSide_Left = True
        Me.l모듈전압.BorderSide_Right = True
        Me.l모듈전압.BorderSide_Top = True
        Me.l모듈전압.BorderWidth = 1
        Me.l모듈전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈전압.IsPassword = False
        Me.l모듈전압.Location = New System.Drawing.Point(102, 79)
        Me.l모듈전압.MaxRange = 0
        Me.l모듈전압.MinRange = 0
        Me.l모듈전압.Name = "l모듈전압"
        Me.l모듈전압.Size = New System.Drawing.Size(335, 30)
        Me.l모듈전압.TabIndex = 49
        Me.l모듈전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈전압.UseKeyPad = False
        '
        'VsLabel45
        '
        Me.VsLabel45.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel45.BackImage = Nothing
        Me.VsLabel45.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel45.BorderSide_Bottom = True
        Me.VsLabel45.BorderSide_Left = True
        Me.VsLabel45.BorderSide_Right = True
        Me.VsLabel45.BorderSide_Top = True
        Me.VsLabel45.BorderWidth = 1
        Me.VsLabel45.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel45.IsPassword = False
        Me.VsLabel45.Location = New System.Drawing.Point(14, 187)
        Me.VsLabel45.MaxRange = 0
        Me.VsLabel45.MinRange = 0
        Me.VsLabel45.Name = "VsLabel45"
        Me.VsLabel45.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel45.TabIndex = 44
        Me.VsLabel45.Text = "평균 전압"
        Me.VsLabel45.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel45.UseKeyPad = False
        '
        'l모듈최고온도
        '
        Me.l모듈최고온도.BackColor = System.Drawing.Color.White
        Me.l모듈최고온도.BackImage = Nothing
        Me.l모듈최고온도.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈최고온도.BorderSide_Bottom = True
        Me.l모듈최고온도.BorderSide_Left = True
        Me.l모듈최고온도.BorderSide_Right = True
        Me.l모듈최고온도.BorderSide_Top = True
        Me.l모듈최고온도.BorderWidth = 1
        Me.l모듈최고온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈최고온도.IsPassword = False
        Me.l모듈최고온도.Location = New System.Drawing.Point(318, 151)
        Me.l모듈최고온도.MaxRange = 0
        Me.l모듈최고온도.MinRange = 0
        Me.l모듈최고온도.Name = "l모듈최고온도"
        Me.l모듈최고온도.Size = New System.Drawing.Size(119, 30)
        Me.l모듈최고온도.TabIndex = 54
        Me.l모듈최고온도.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈최고온도.UseKeyPad = False
        '
        'l모듈평균온도
        '
        Me.l모듈평균온도.BackColor = System.Drawing.Color.White
        Me.l모듈평균온도.BackImage = Nothing
        Me.l모듈평균온도.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈평균온도.BorderSide_Bottom = True
        Me.l모듈평균온도.BorderSide_Left = True
        Me.l모듈평균온도.BorderSide_Right = True
        Me.l모듈평균온도.BorderSide_Top = True
        Me.l모듈평균온도.BorderWidth = 1
        Me.l모듈평균온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈평균온도.IsPassword = False
        Me.l모듈평균온도.Location = New System.Drawing.Point(318, 115)
        Me.l모듈평균온도.MaxRange = 0
        Me.l모듈평균온도.MinRange = 0
        Me.l모듈평균온도.Name = "l모듈평균온도"
        Me.l모듈평균온도.Size = New System.Drawing.Size(119, 30)
        Me.l모듈평균온도.TabIndex = 57
        Me.l모듈평균온도.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈평균온도.UseKeyPad = False
        '
        'l모듈내Cell평균전압
        '
        Me.l모듈내Cell평균전압.BackColor = System.Drawing.Color.White
        Me.l모듈내Cell평균전압.BackImage = Nothing
        Me.l모듈내Cell평균전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l모듈내Cell평균전압.BorderSide_Bottom = True
        Me.l모듈내Cell평균전압.BorderSide_Left = True
        Me.l모듈내Cell평균전압.BorderSide_Right = True
        Me.l모듈내Cell평균전압.BorderSide_Top = True
        Me.l모듈내Cell평균전압.BorderWidth = 1
        Me.l모듈내Cell평균전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l모듈내Cell평균전압.IsPassword = False
        Me.l모듈내Cell평균전압.Location = New System.Drawing.Point(102, 187)
        Me.l모듈내Cell평균전압.MaxRange = 0
        Me.l모듈내Cell평균전압.MinRange = 0
        Me.l모듈내Cell평균전압.Name = "l모듈내Cell평균전압"
        Me.l모듈내Cell평균전압.Size = New System.Drawing.Size(119, 30)
        Me.l모듈내Cell평균전압.TabIndex = 45
        Me.l모듈내Cell평균전압.TextAlign = System.Drawing.StringAlignment.Far
        Me.l모듈내Cell평균전압.UseKeyPad = False
        '
        'VsLabel44
        '
        Me.VsLabel44.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel44.BackImage = Nothing
        Me.VsLabel44.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel44.BorderSide_Bottom = True
        Me.VsLabel44.BorderSide_Left = True
        Me.VsLabel44.BorderSide_Right = True
        Me.VsLabel44.BorderSide_Top = True
        Me.VsLabel44.BorderWidth = 1
        Me.VsLabel44.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel44.IsPassword = False
        Me.VsLabel44.Location = New System.Drawing.Point(14, 115)
        Me.VsLabel44.MaxRange = 0
        Me.VsLabel44.MinRange = 0
        Me.VsLabel44.Name = "VsLabel44"
        Me.VsLabel44.Size = New System.Drawing.Size(82, 30)
        Me.VsLabel44.TabIndex = 50
        Me.VsLabel44.Text = "최대 전압"
        Me.VsLabel44.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel44.UseKeyPad = False
        '
        'btn_Module
        '
        Me.btn_Module.BackColor = System.Drawing.Color.White
        Me.btn_Module.BackImage = Nothing
        Me.btn_Module.BorderColor = System.Drawing.Color.Gray
        Me.btn_Module.BorderSide_Bottom = True
        Me.btn_Module.BorderSide_Left = True
        Me.btn_Module.BorderSide_Right = True
        Me.btn_Module.BorderSide_Top = True
        Me.btn_Module.BorderWidth = 1
        Me.btn_Module.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Module.IsPassword = False
        Me.btn_Module.Location = New System.Drawing.Point(667, 5)
        Me.btn_Module.MaxRange = 0
        Me.btn_Module.MinRange = 0
        Me.btn_Module.Name = "btn_Module"
        Me.btn_Module.Size = New System.Drawing.Size(100, 40)
        Me.btn_Module.TabIndex = 57
        Me.btn_Module.Text = "Module"
        Me.btn_Module.TextAlign = System.Drawing.StringAlignment.Center
        Me.btn_Module.UseKeyPad = False
        '
        'PageHeader4
        '
        Me.PageHeader4.BackColor = System.Drawing.Color.White
        Me.PageHeader4.BackImage = Nothing
        Me.PageHeader4.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader4.BorderSide_Bottom = False
        Me.PageHeader4.BorderSide_Left = False
        Me.PageHeader4.BorderSide_Right = True
        Me.PageHeader4.BorderSide_Top = True
        Me.PageHeader4.BorderWidth = 1
        Me.PageHeader4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader4.IsPassword = False
        Me.PageHeader4.Location = New System.Drawing.Point(309, 5)
        Me.PageHeader4.MaxRange = 0
        Me.PageHeader4.MinRange = 0
        Me.PageHeader4.Name = "PageHeader4"
        Me.PageHeader4.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader4.TabIndex = 56
        Me.PageHeader4.Text = "Rack#3"
        Me.PageHeader4.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader4.UseKeyPad = False
        '
        'PageHeader2
        '
        Me.PageHeader2.BackColor = System.Drawing.Color.White
        Me.PageHeader2.BackImage = Nothing
        Me.PageHeader2.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader2.BorderSide_Bottom = False
        Me.PageHeader2.BorderSide_Left = False
        Me.PageHeader2.BorderSide_Right = True
        Me.PageHeader2.BorderSide_Top = True
        Me.PageHeader2.BorderWidth = 1
        Me.PageHeader2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader2.IsPassword = False
        Me.PageHeader2.Location = New System.Drawing.Point(109, 5)
        Me.PageHeader2.MaxRange = 0
        Me.PageHeader2.MinRange = 0
        Me.PageHeader2.Name = "PageHeader2"
        Me.PageHeader2.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader2.TabIndex = 54
        Me.PageHeader2.Text = "Rack#1"
        Me.PageHeader2.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader2.UseKeyPad = False
        '
        'PageHeader3
        '
        Me.PageHeader3.BackColor = System.Drawing.Color.White
        Me.PageHeader3.BackImage = Nothing
        Me.PageHeader3.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader3.BorderSide_Bottom = False
        Me.PageHeader3.BorderSide_Left = False
        Me.PageHeader3.BorderSide_Right = True
        Me.PageHeader3.BorderSide_Top = True
        Me.PageHeader3.BorderWidth = 1
        Me.PageHeader3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader3.IsPassword = False
        Me.PageHeader3.Location = New System.Drawing.Point(209, 5)
        Me.PageHeader3.MaxRange = 0
        Me.PageHeader3.MinRange = 0
        Me.PageHeader3.Name = "PageHeader3"
        Me.PageHeader3.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader3.TabIndex = 55
        Me.PageHeader3.Text = "Rack#2"
        Me.PageHeader3.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader3.UseKeyPad = False
        '
        'PageHeader1
        '
        Me.PageHeader1.BackColor = System.Drawing.Color.White
        Me.PageHeader1.BackImage = Nothing
        Me.PageHeader1.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader1.BorderSide_Bottom = False
        Me.PageHeader1.BorderSide_Left = True
        Me.PageHeader1.BorderSide_Right = True
        Me.PageHeader1.BorderSide_Top = True
        Me.PageHeader1.BorderWidth = 1
        Me.PageHeader1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader1.IsPassword = False
        Me.PageHeader1.Location = New System.Drawing.Point(9, 5)
        Me.PageHeader1.MaxRange = 0
        Me.PageHeader1.MinRange = 0
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader1.TabIndex = 53
        Me.PageHeader1.Text = "Bank"
        Me.PageHeader1.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader1.UseKeyPad = False
        '
        'wnd서브화면2_배터리
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VSaddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VSStatus)
        Me.Controls.Add(Me.VSmodule)
        Me.Controls.Add(Me.VSrack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.btn_Module)
        Me.Controls.Add(Me.PageHeader4)
        Me.Controls.Add(Me.PageHeader2)
        Me.Controls.Add(Me.PageHeader3)
        Me.Controls.Add(Me.PageHeader1)
        Me.Name = "wnd서브화면2_배터리"
        Me.Size = New System.Drawing.Size(1612, 900)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.VsGroupBox1.ResumeLayout(False)
        CType(Me.pbBattery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VsGroupBox2.ResumeLayout(False)
        Me.VsGroupBox3.ResumeLayout(False)
        Me.VsGroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VsLabel66 As PMS.VSLabel
    Friend WithEvents VsLabel7 As PMS.VSLabel
    Friend WithEvents VsLabel8 As PMS.VSLabel
    Friend WithEvents lChargingStatus As PMS.VSLabel
    Friend WithEvents VsGroupBox2 As PMS.VSGroupBox
    Friend WithEvents lbBatteryDischarge_Today As PMS.VSLabel
    Friend WithEvents VsLabel9 As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Today As PMS.VSLabel
    Friend WithEvents VsLabel13 As PMS.VSLabel
    Friend WithEvents lbBatteryDischarge_Yesterday As PMS.VSLabel
    Friend WithEvents VsLabel12 As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Yesterday As PMS.VSLabel
    Friend WithEvents VsLabel10 As PMS.VSLabel
    Friend WithEvents lbBatteryDischarge_Total As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Total As PMS.VSLabel
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents VsLabel40 As PMS.VSLabel
    Friend WithEvents VsLabel52 As PMS.VSLabel
    Friend WithEvents pbBattery As System.Windows.Forms.PictureBox
    Friend WithEvents l모듈최고최저온도위치 As PMS.VSLabel
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents VsLabel63 As PMS.VSLabel
    Friend WithEvents l모듈최저온도 As PMS.VSLabel
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents l최고최저셀전압위치 As PMS.VSLabel
    Friend WithEvents VsLabel41 As PMS.VSLabel
    Friend WithEvents VsLabel19 As PMS.VSLabel
    Friend WithEvents l모듈내Cell최대전압 As PMS.VSLabel
    Friend WithEvents VsLabel55 As PMS.VSLabel
    Friend WithEvents VsLabel48 As PMS.VSLabel
    Friend WithEvents l모듈내Cell최저전압 As PMS.VSLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VsGroupBox1 As PMS.VSGroupBox
    Friend WithEvents lSOC As PMS.VSLabel
    Friend WithEvents VsLabel6 As PMS.VSLabel
    Friend WithEvents lSOH As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents lPower As PMS.VSLabel
    Friend WithEvents VsLabel5 As PMS.VSLabel
    Friend WithEvents lVoltage As PMS.VSLabel
    Friend WithEvents lTemperature As PMS.VSLabel
    Friend WithEvents lCurrent As PMS.VSLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents VsLabel61 As PMS.VSLabel
    Friend WithEvents lCell최대전압 As PMS.VSLabel
    Friend WithEvents VsLabel58 As PMS.VSLabel
    Friend WithEvents lCell최대전압위치 As PMS.VSLabel
    Friend WithEvents VsLabel53 As PMS.VSLabel
    Friend WithEvents lCell최소전압 As PMS.VSLabel
    Friend WithEvents VsLabel51 As PMS.VSLabel
    Friend WithEvents lCell최소전압위치 As PMS.VSLabel
    Friend WithEvents lCell전압편차 As PMS.VSLabel
    Friend WithEvents VsLabel30 As PMS.VSLabel
    Friend WithEvents VsLabel31 As PMS.VSLabel
    Friend WithEvents l랙SOC As PMS.VSLabel
    Friend WithEvents VsLabel34 As PMS.VSLabel
    Friend WithEvents lCell평균전압 As PMS.VSLabel
    Friend WithEvents l랙SOH As PMS.VSLabel
    Friend WithEvents l랙전류 As PMS.VSLabel
    Friend WithEvents VsLabel38 As PMS.VSLabel
    Friend WithEvents l랙전압 As PMS.VSLabel
    Friend WithEvents VsLabel14 As PMS.VSLabel
    Friend WithEvents VsLabel15 As PMS.VSLabel
    Friend WithEvents VsLabel16 As PMS.VSLabel
    Friend WithEvents l랙평균모듈온도 As PMS.VSLabel
    Friend WithEvents lCell최대온도 As PMS.VSLabel
    Friend WithEvents lCell온도편차 As PMS.VSLabel
    Friend WithEvents VsLabel17 As PMS.VSLabel
    Friend WithEvents VsLabel18 As PMS.VSLabel
    Friend WithEvents lCell최대온도위치 As PMS.VSLabel
    Friend WithEvents lCell최소온도위치 As PMS.VSLabel
    Friend WithEvents VsLabel20 As PMS.VSLabel
    Friend WithEvents lCell최소온도 As PMS.VSLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents VsGroupBox3 As PMS.VSGroupBox
    Friend WithEvents VsLabel121 As PMS.VSLabel
    Friend WithEvents btn_Module17 As PMS.VSLabel
    Friend WithEvents btn_Module1 As PMS.VSLabel
    Friend WithEvents btn_Module16 As PMS.VSLabel
    Friend WithEvents btn_Module2 As PMS.VSLabel
    Friend WithEvents btn_Module13 As PMS.VSLabel
    Friend WithEvents btn_Module3 As PMS.VSLabel
    Friend WithEvents btn_Module15 As PMS.VSLabel
    Friend WithEvents btn_Module4 As PMS.VSLabel
    Friend WithEvents btn_Module12 As PMS.VSLabel
    Friend WithEvents btn_Module5 As PMS.VSLabel
    Friend WithEvents btn_Module14 As PMS.VSLabel
    Friend WithEvents btn_Module6 As PMS.VSLabel
    Friend WithEvents btn_Module11 As PMS.VSLabel
    Friend WithEvents btn_Module7 As PMS.VSLabel
    Friend WithEvents btn_Module10 As PMS.VSLabel
    Friend WithEvents btn_Module8 As PMS.VSLabel
    Friend WithEvents btn_Module9 As PMS.VSLabel
    Friend WithEvents VsGroupBox4 As PMS.VSGroupBox
    Friend WithEvents VsLabel56 As PMS.VSLabel
    Friend WithEvents VsLabel67 As PMS.VSLabel
    Friend WithEvents l모듈전압 As PMS.VSLabel
    Friend WithEvents VsLabel45 As PMS.VSLabel
    Friend WithEvents l모듈최고온도 As PMS.VSLabel
    Friend WithEvents l모듈평균온도 As PMS.VSLabel
    Friend WithEvents l모듈내Cell평균전압 As PMS.VSLabel
    Friend WithEvents VsLabel44 As PMS.VSLabel
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents btn_Module As PMS.VSLabel
    Friend WithEvents PageHeader4 As PMS.VSLabel
    Friend WithEvents PageHeader2 As PMS.VSLabel
    Friend WithEvents PageHeader3 As PMS.VSLabel
    Friend WithEvents PageHeader1 As PMS.VSLabel
    Friend WithEvents BMS타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents VSrack As PMS.VSLabel
    Friend WithEvents VSmodule As PMS.VSLabel
    Friend WithEvents VSStatus As PMS.VSLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VSaddress As PMS.VSLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_None As PMS.VSLabel
    Friend WithEvents btn_Close As PMS.VSLabel
    Friend WithEvents btn_Open As PMS.VSLabel

End Class

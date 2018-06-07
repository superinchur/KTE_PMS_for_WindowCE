<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면2_배터리
    'Inherits System.Windows.Forms.UserControl
    Inherits wnd서브화면

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면2_배터리))
        Me.타이머_상태 = New System.Windows.Forms.Timer
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbWatchDog = New PMS.VSLabel
        Me.lbResponse = New PMS.VSLabel
        Me.VsLabel33 = New PMS.VSLabel
        Me.VsLabel22 = New PMS.VSLabel
        Me.VsGroupBox3 = New PMS.VSGroupBox
        Me.BTN_Major_Fault_Off = New PMS.VSLabel
        Me.BTN_Major_Fault_On = New PMS.VSLabel
        Me.BTN_Minor_Fault_Off = New PMS.VSLabel
        Me.BTN_Minor_Fault_On = New PMS.VSLabel
        Me.VsLabel21 = New PMS.VSLabel
        Me.VsLabel26 = New PMS.VSLabel
        Me.VsLabel32 = New PMS.VSLabel
        Me.VsGroupBox4 = New PMS.VSGroupBox
        Me.GridOn_off = New PMS.VSLabel
        Me.Gridon_on = New PMS.VSLabel
        Me.VsLabel40 = New PMS.VSLabel
        Me.VsLabel41 = New PMS.VSLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.VsLabel66 = New PMS.VSLabel
        Me.VsLabel61 = New PMS.VSLabel
        Me.lCell최대전압 = New PMS.VSLabel
        Me.VsLabel58 = New PMS.VSLabel
        Me.lCell최대전압위치 = New PMS.VSLabel
        Me.VsLabel53 = New PMS.VSLabel
        Me.lCell최소전압 = New PMS.VSLabel
        Me.lCell최소전압위치 = New PMS.VSLabel
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
        Me.VsLabel17 = New PMS.VSLabel
        Me.lCell최대온도위치 = New PMS.VSLabel
        Me.lCell최소온도위치 = New PMS.VSLabel
        Me.VsLabel19 = New PMS.VSLabel
        Me.VsLabel20 = New PMS.VSLabel
        Me.lCell최소온도 = New PMS.VSLabel
        Me.Panel1 = New System.Windows.Forms.Panel
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
        Me.Panel = New System.Windows.Forms.Panel
        Me.PageHeader4 = New PMS.VSLabel
        Me.PageHeader3 = New PMS.VSLabel
        Me.PageHeader2 = New PMS.VSLabel
        Me.PageHeader1 = New PMS.VSLabel
        Me.Panel3.SuspendLayout()
        Me.VsGroupBox3.SuspendLayout()
        Me.VsGroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.VsGroupBox1.SuspendLayout()
        Me.VsGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '타이머_상태
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.lbWatchDog)
        Me.Panel3.Controls.Add(Me.lbResponse)
        Me.Panel3.Controls.Add(Me.VsLabel33)
        Me.Panel3.Controls.Add(Me.VsLabel22)
        Me.Panel3.Controls.Add(Me.VsGroupBox3)
        Me.Panel3.Controls.Add(Me.VsGroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(10, 624)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 283)
        '
        'lbWatchDog
        '
        Me.lbWatchDog.BackColor = System.Drawing.Color.White
        Me.lbWatchDog.BorderColor = System.Drawing.Color.Gray
        Me.lbWatchDog.BorderSide_Bottom = True
        Me.lbWatchDog.BorderSide_Left = True
        Me.lbWatchDog.BorderSide_Right = True
        Me.lbWatchDog.BorderSide_Top = True
        Me.lbWatchDog.BorderWidth = 1
        Me.lbWatchDog.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbWatchDog.IsPassword = False
        Me.lbWatchDog.Location = New System.Drawing.Point(254, 179)
        Me.lbWatchDog.MaxRange = 1000
        Me.lbWatchDog.MinRange = 0
        Me.lbWatchDog.Name = "lbWatchDog"
        Me.lbWatchDog.Size = New System.Drawing.Size(77, 40)
        Me.lbWatchDog.TabIndex = 114
        Me.lbWatchDog.Text = "10"
        Me.lbWatchDog.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbWatchDog.UseKeyPad = True
        '
        'lbResponse
        '
        Me.lbResponse.BackColor = System.Drawing.Color.White
        Me.lbResponse.BorderColor = System.Drawing.Color.Gray
        Me.lbResponse.BorderSide_Bottom = True
        Me.lbResponse.BorderSide_Left = True
        Me.lbResponse.BorderSide_Right = True
        Me.lbResponse.BorderSide_Top = True
        Me.lbResponse.BorderWidth = 1
        Me.lbResponse.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbResponse.IsPassword = False
        Me.lbResponse.Location = New System.Drawing.Point(254, 225)
        Me.lbResponse.MaxRange = 100
        Me.lbResponse.MinRange = 0
        Me.lbResponse.Name = "lbResponse"
        Me.lbResponse.Size = New System.Drawing.Size(77, 40)
        Me.lbResponse.TabIndex = 115
        Me.lbResponse.Text = "10"
        Me.lbResponse.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbResponse.UseKeyPad = True
        '
        'VsLabel33
        '
        Me.VsLabel33.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel33.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel33.BorderSide_Bottom = True
        Me.VsLabel33.BorderSide_Left = True
        Me.VsLabel33.BorderSide_Right = True
        Me.VsLabel33.BorderSide_Top = True
        Me.VsLabel33.BorderWidth = 1
        Me.VsLabel33.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel33.IsPassword = False
        Me.VsLabel33.Location = New System.Drawing.Point(49, 225)
        Me.VsLabel33.Name = "VsLabel33"
        Me.VsLabel33.Size = New System.Drawing.Size(199, 40)
        Me.VsLabel33.TabIndex = 117
        Me.VsLabel33.Text = "Response"
        Me.VsLabel33.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel33.UseKeyPad = False
        '
        'VsLabel22
        '
        Me.VsLabel22.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel22.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel22.BorderSide_Bottom = True
        Me.VsLabel22.BorderSide_Left = True
        Me.VsLabel22.BorderSide_Right = True
        Me.VsLabel22.BorderSide_Top = True
        Me.VsLabel22.BorderWidth = 1
        Me.VsLabel22.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel22.IsPassword = False
        Me.VsLabel22.Location = New System.Drawing.Point(49, 179)
        Me.VsLabel22.Name = "VsLabel22"
        Me.VsLabel22.Size = New System.Drawing.Size(199, 40)
        Me.VsLabel22.TabIndex = 116
        Me.VsLabel22.Text = "Watchdog"
        Me.VsLabel22.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel22.UseKeyPad = False
        '
        'VsGroupBox3
        '
        Me.VsGroupBox3.BackColor = System.Drawing.Color.White
        Me.VsGroupBox3.Controls.Add(Me.BTN_Major_Fault_Off)
        Me.VsGroupBox3.Controls.Add(Me.BTN_Major_Fault_On)
        Me.VsGroupBox3.Controls.Add(Me.BTN_Minor_Fault_Off)
        Me.VsGroupBox3.Controls.Add(Me.BTN_Minor_Fault_On)
        Me.VsGroupBox3.Controls.Add(Me.VsLabel21)
        Me.VsGroupBox3.Controls.Add(Me.VsLabel26)
        Me.VsGroupBox3.Controls.Add(Me.VsLabel32)
        Me.VsGroupBox3.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox3.HeaderText = "배터리경보해제"
        Me.VsGroupBox3.Location = New System.Drawing.Point(10, 15)
        Me.VsGroupBox3.Name = "VsGroupBox3"
        Me.VsGroupBox3.Size = New System.Drawing.Size(369, 155)
        '
        'BTN_Major_Fault_Off
        '
        Me.BTN_Major_Fault_Off.BackColor = System.Drawing.Color.White
        Me.BTN_Major_Fault_Off.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Major_Fault_Off.BorderSide_Bottom = True
        Me.BTN_Major_Fault_Off.BorderSide_Left = True
        Me.BTN_Major_Fault_Off.BorderSide_Right = True
        Me.BTN_Major_Fault_Off.BorderSide_Top = True
        Me.BTN_Major_Fault_Off.BorderWidth = 1
        Me.BTN_Major_Fault_Off.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Major_Fault_Off.IsPassword = False
        Me.BTN_Major_Fault_Off.Location = New System.Drawing.Point(283, 109)
        Me.BTN_Major_Fault_Off.Name = "BTN_Major_Fault_Off"
        Me.BTN_Major_Fault_Off.Size = New System.Drawing.Size(57, 30)
        Me.BTN_Major_Fault_Off.TabIndex = 117
        Me.BTN_Major_Fault_Off.Text = "Off"
        Me.BTN_Major_Fault_Off.TextAlign = System.Drawing.StringAlignment.Center
        Me.BTN_Major_Fault_Off.UseKeyPad = False
        '
        'BTN_Major_Fault_On
        '
        Me.BTN_Major_Fault_On.BackColor = System.Drawing.Color.White
        Me.BTN_Major_Fault_On.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Major_Fault_On.BorderSide_Bottom = True
        Me.BTN_Major_Fault_On.BorderSide_Left = True
        Me.BTN_Major_Fault_On.BorderSide_Right = True
        Me.BTN_Major_Fault_On.BorderSide_Top = True
        Me.BTN_Major_Fault_On.BorderWidth = 1
        Me.BTN_Major_Fault_On.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Major_Fault_On.IsPassword = False
        Me.BTN_Major_Fault_On.Location = New System.Drawing.Point(220, 109)
        Me.BTN_Major_Fault_On.Name = "BTN_Major_Fault_On"
        Me.BTN_Major_Fault_On.Size = New System.Drawing.Size(57, 30)
        Me.BTN_Major_Fault_On.TabIndex = 116
        Me.BTN_Major_Fault_On.Text = "On"
        Me.BTN_Major_Fault_On.TextAlign = System.Drawing.StringAlignment.Center
        Me.BTN_Major_Fault_On.UseKeyPad = False
        '
        'BTN_Minor_Fault_Off
        '
        Me.BTN_Minor_Fault_Off.BackColor = System.Drawing.Color.White
        Me.BTN_Minor_Fault_Off.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Minor_Fault_Off.BorderSide_Bottom = True
        Me.BTN_Minor_Fault_Off.BorderSide_Left = True
        Me.BTN_Minor_Fault_Off.BorderSide_Right = True
        Me.BTN_Minor_Fault_Off.BorderSide_Top = True
        Me.BTN_Minor_Fault_Off.BorderWidth = 1
        Me.BTN_Minor_Fault_Off.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Minor_Fault_Off.IsPassword = False
        Me.BTN_Minor_Fault_Off.Location = New System.Drawing.Point(283, 73)
        Me.BTN_Minor_Fault_Off.Name = "BTN_Minor_Fault_Off"
        Me.BTN_Minor_Fault_Off.Size = New System.Drawing.Size(57, 30)
        Me.BTN_Minor_Fault_Off.TabIndex = 115
        Me.BTN_Minor_Fault_Off.Text = "Off"
        Me.BTN_Minor_Fault_Off.TextAlign = System.Drawing.StringAlignment.Center
        Me.BTN_Minor_Fault_Off.UseKeyPad = False
        '
        'BTN_Minor_Fault_On
        '
        Me.BTN_Minor_Fault_On.BackColor = System.Drawing.Color.White
        Me.BTN_Minor_Fault_On.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Minor_Fault_On.BorderSide_Bottom = True
        Me.BTN_Minor_Fault_On.BorderSide_Left = True
        Me.BTN_Minor_Fault_On.BorderSide_Right = True
        Me.BTN_Minor_Fault_On.BorderSide_Top = True
        Me.BTN_Minor_Fault_On.BorderWidth = 1
        Me.BTN_Minor_Fault_On.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Minor_Fault_On.IsPassword = False
        Me.BTN_Minor_Fault_On.Location = New System.Drawing.Point(220, 73)
        Me.BTN_Minor_Fault_On.Name = "BTN_Minor_Fault_On"
        Me.BTN_Minor_Fault_On.Size = New System.Drawing.Size(57, 30)
        Me.BTN_Minor_Fault_On.TabIndex = 114
        Me.BTN_Minor_Fault_On.Text = "On"
        Me.BTN_Minor_Fault_On.TextAlign = System.Drawing.StringAlignment.Center
        Me.BTN_Minor_Fault_On.UseKeyPad = False
        '
        'VsLabel21
        '
        Me.VsLabel21.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel21.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel21.BorderSide_Bottom = True
        Me.VsLabel21.BorderSide_Left = True
        Me.VsLabel21.BorderSide_Right = True
        Me.VsLabel21.BorderSide_Top = True
        Me.VsLabel21.BorderWidth = 1
        Me.VsLabel21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel21.IsPassword = False
        Me.VsLabel21.Location = New System.Drawing.Point(29, 33)
        Me.VsLabel21.Name = "VsLabel21"
        Me.VsLabel21.Size = New System.Drawing.Size(310, 30)
        Me.VsLabel21.TabIndex = 118
        Me.VsLabel21.Text = "All Fault Reset Command"
        Me.VsLabel21.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel21.UseKeyPad = False
        '
        'VsLabel26
        '
        Me.VsLabel26.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel26.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel26.BorderSide_Bottom = True
        Me.VsLabel26.BorderSide_Left = True
        Me.VsLabel26.BorderSide_Right = True
        Me.VsLabel26.BorderSide_Top = True
        Me.VsLabel26.BorderWidth = 1
        Me.VsLabel26.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel26.IsPassword = False
        Me.VsLabel26.Location = New System.Drawing.Point(29, 73)
        Me.VsLabel26.Name = "VsLabel26"
        Me.VsLabel26.Size = New System.Drawing.Size(185, 30)
        Me.VsLabel26.TabIndex = 110
        Me.VsLabel26.Text = "Minor Fault"
        Me.VsLabel26.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel26.UseKeyPad = False
        '
        'VsLabel32
        '
        Me.VsLabel32.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel32.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel32.BorderSide_Bottom = True
        Me.VsLabel32.BorderSide_Left = True
        Me.VsLabel32.BorderSide_Right = True
        Me.VsLabel32.BorderSide_Top = True
        Me.VsLabel32.BorderWidth = 1
        Me.VsLabel32.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel32.IsPassword = False
        Me.VsLabel32.Location = New System.Drawing.Point(29, 109)
        Me.VsLabel32.Name = "VsLabel32"
        Me.VsLabel32.Size = New System.Drawing.Size(185, 30)
        Me.VsLabel32.TabIndex = 117
        Me.VsLabel32.Text = "Major Fault"
        Me.VsLabel32.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel32.UseKeyPad = False
        '
        'VsGroupBox4
        '
        Me.VsGroupBox4.BackColor = System.Drawing.Color.White
        Me.VsGroupBox4.Controls.Add(Me.GridOn_off)
        Me.VsGroupBox4.Controls.Add(Me.Gridon_on)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel40)
        Me.VsGroupBox4.Controls.Add(Me.VsLabel41)
        Me.VsGroupBox4.HeaderFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsGroupBox4.HeaderText = "배터리 제어"
        Me.VsGroupBox4.Location = New System.Drawing.Point(385, 15)
        Me.VsGroupBox4.Name = "VsGroupBox4"
        Me.VsGroupBox4.Size = New System.Drawing.Size(357, 260)
        '
        'GridOn_off
        '
        Me.GridOn_off.BackColor = System.Drawing.Color.White
        Me.GridOn_off.BorderColor = System.Drawing.Color.DarkGray
        Me.GridOn_off.BorderSide_Bottom = True
        Me.GridOn_off.BorderSide_Left = True
        Me.GridOn_off.BorderSide_Right = True
        Me.GridOn_off.BorderSide_Top = True
        Me.GridOn_off.BorderWidth = 1
        Me.GridOn_off.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GridOn_off.IsPassword = False
        Me.GridOn_off.Location = New System.Drawing.Point(280, 73)
        Me.GridOn_off.Name = "GridOn_off"
        Me.GridOn_off.Size = New System.Drawing.Size(56, 30)
        Me.GridOn_off.TabIndex = 109
        Me.GridOn_off.Text = "Off"
        Me.GridOn_off.TextAlign = System.Drawing.StringAlignment.Center
        Me.GridOn_off.UseKeyPad = False
        '
        'Gridon_on
        '
        Me.Gridon_on.BackColor = System.Drawing.Color.White
        Me.Gridon_on.BorderColor = System.Drawing.Color.DarkGray
        Me.Gridon_on.BorderSide_Bottom = True
        Me.Gridon_on.BorderSide_Left = True
        Me.Gridon_on.BorderSide_Right = True
        Me.Gridon_on.BorderSide_Top = True
        Me.Gridon_on.BorderWidth = 1
        Me.Gridon_on.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Gridon_on.IsPassword = False
        Me.Gridon_on.Location = New System.Drawing.Point(217, 73)
        Me.Gridon_on.Name = "Gridon_on"
        Me.Gridon_on.Size = New System.Drawing.Size(56, 30)
        Me.Gridon_on.TabIndex = 108
        Me.Gridon_on.Text = "On"
        Me.Gridon_on.TextAlign = System.Drawing.StringAlignment.Center
        Me.Gridon_on.UseKeyPad = False
        '
        'VsLabel40
        '
        Me.VsLabel40.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel40.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel40.BorderSide_Bottom = True
        Me.VsLabel40.BorderSide_Left = True
        Me.VsLabel40.BorderSide_Right = True
        Me.VsLabel40.BorderSide_Top = True
        Me.VsLabel40.BorderWidth = 1
        Me.VsLabel40.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel40.IsPassword = False
        Me.VsLabel40.Location = New System.Drawing.Point(26, 33)
        Me.VsLabel40.Name = "VsLabel40"
        Me.VsLabel40.Size = New System.Drawing.Size(310, 30)
        Me.VsLabel40.TabIndex = 107
        Me.VsLabel40.Text = "All Switch Control Command"
        Me.VsLabel40.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel40.UseKeyPad = False
        '
        'VsLabel41
        '
        Me.VsLabel41.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel41.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel41.BorderSide_Bottom = True
        Me.VsLabel41.BorderSide_Left = True
        Me.VsLabel41.BorderSide_Right = True
        Me.VsLabel41.BorderSide_Top = True
        Me.VsLabel41.BorderWidth = 1
        Me.VsLabel41.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel41.IsPassword = False
        Me.VsLabel41.Location = New System.Drawing.Point(26, 73)
        Me.VsLabel41.Name = "VsLabel41"
        Me.VsLabel41.Size = New System.Drawing.Size(185, 30)
        Me.VsLabel41.TabIndex = 46
        Me.VsLabel41.Text = "Grid On"
        Me.VsLabel41.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel41.UseKeyPad = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.VsLabel66)
        Me.Panel2.Controls.Add(Me.VsLabel61)
        Me.Panel2.Controls.Add(Me.lCell최대전압)
        Me.Panel2.Controls.Add(Me.VsLabel58)
        Me.Panel2.Controls.Add(Me.lCell최대전압위치)
        Me.Panel2.Controls.Add(Me.VsLabel53)
        Me.Panel2.Controls.Add(Me.lCell최소전압)
        Me.Panel2.Controls.Add(Me.lCell최소전압위치)
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
        Me.Panel2.Controls.Add(Me.VsLabel17)
        Me.Panel2.Controls.Add(Me.lCell최대온도위치)
        Me.Panel2.Controls.Add(Me.lCell최소온도위치)
        Me.Panel2.Controls.Add(Me.VsLabel19)
        Me.Panel2.Controls.Add(Me.VsLabel20)
        Me.Panel2.Controls.Add(Me.lCell최소온도)
        Me.Panel2.Location = New System.Drawing.Point(10, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 283)
        '
        'VsLabel66
        '
        Me.VsLabel66.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel66.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel66.BorderSide_Bottom = True
        Me.VsLabel66.BorderSide_Left = True
        Me.VsLabel66.BorderSide_Right = True
        Me.VsLabel66.BorderSide_Top = True
        Me.VsLabel66.BorderWidth = 1
        Me.VsLabel66.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel66.IsPassword = False
        Me.VsLabel66.Location = New System.Drawing.Point(270, 40)
        Me.VsLabel66.Name = "VsLabel66"
        Me.VsLabel66.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel66.TabIndex = 67
        Me.VsLabel66.Text = "최대전압"
        Me.VsLabel66.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel66.UseKeyPad = False
        '
        'VsLabel61
        '
        Me.VsLabel61.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel61.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel61.BorderSide_Bottom = True
        Me.VsLabel61.BorderSide_Left = True
        Me.VsLabel61.BorderSide_Right = True
        Me.VsLabel61.BorderSide_Top = True
        Me.VsLabel61.BorderWidth = 1
        Me.VsLabel61.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel61.IsPassword = False
        Me.VsLabel61.Location = New System.Drawing.Point(270, 76)
        Me.VsLabel61.Name = "VsLabel61"
        Me.VsLabel61.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel61.TabIndex = 65
        Me.VsLabel61.Text = "최대전압 위치"
        Me.VsLabel61.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel61.UseKeyPad = False
        '
        'lCell최대전압
        '
        Me.lCell최대전압.BackColor = System.Drawing.Color.White
        Me.lCell최대전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대전압.BorderSide_Bottom = True
        Me.lCell최대전압.BorderSide_Left = True
        Me.lCell최대전압.BorderSide_Right = True
        Me.lCell최대전압.BorderSide_Top = True
        Me.lCell최대전압.BorderWidth = 1
        Me.lCell최대전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대전압.IsPassword = False
        Me.lCell최대전압.Location = New System.Drawing.Point(394, 40)
        Me.lCell최대전압.Name = "lCell최대전압"
        Me.lCell최대전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대전압.TabIndex = 68
        Me.lCell최대전압.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최대전압.UseKeyPad = False
        '
        'VsLabel58
        '
        Me.VsLabel58.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel58.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel58.BorderSide_Bottom = True
        Me.VsLabel58.BorderSide_Left = True
        Me.VsLabel58.BorderSide_Right = True
        Me.VsLabel58.BorderSide_Top = True
        Me.VsLabel58.BorderWidth = 1
        Me.VsLabel58.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel58.IsPassword = False
        Me.VsLabel58.Location = New System.Drawing.Point(270, 112)
        Me.VsLabel58.Name = "VsLabel58"
        Me.VsLabel58.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel58.TabIndex = 63
        Me.VsLabel58.Text = "최소전압"
        Me.VsLabel58.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel58.UseKeyPad = False
        '
        'lCell최대전압위치
        '
        Me.lCell최대전압위치.BackColor = System.Drawing.Color.White
        Me.lCell최대전압위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대전압위치.BorderSide_Bottom = True
        Me.lCell최대전압위치.BorderSide_Left = True
        Me.lCell최대전압위치.BorderSide_Right = True
        Me.lCell최대전압위치.BorderSide_Top = True
        Me.lCell최대전압위치.BorderWidth = 1
        Me.lCell최대전압위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대전압위치.IsPassword = False
        Me.lCell최대전압위치.Location = New System.Drawing.Point(394, 76)
        Me.lCell최대전압위치.Name = "lCell최대전압위치"
        Me.lCell최대전압위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대전압위치.TabIndex = 66
        Me.lCell최대전압위치.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최대전압위치.UseKeyPad = False
        '
        'VsLabel53
        '
        Me.VsLabel53.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel53.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel53.BorderSide_Bottom = True
        Me.VsLabel53.BorderSide_Left = True
        Me.VsLabel53.BorderSide_Right = True
        Me.VsLabel53.BorderSide_Top = True
        Me.VsLabel53.BorderWidth = 1
        Me.VsLabel53.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel53.IsPassword = False
        Me.VsLabel53.Location = New System.Drawing.Point(270, 148)
        Me.VsLabel53.Name = "VsLabel53"
        Me.VsLabel53.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel53.TabIndex = 61
        Me.VsLabel53.Text = "최소전압 위치"
        Me.VsLabel53.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel53.UseKeyPad = False
        '
        'lCell최소전압
        '
        Me.lCell최소전압.BackColor = System.Drawing.Color.White
        Me.lCell최소전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소전압.BorderSide_Bottom = True
        Me.lCell최소전압.BorderSide_Left = True
        Me.lCell최소전압.BorderSide_Right = True
        Me.lCell최소전압.BorderSide_Top = True
        Me.lCell최소전압.BorderWidth = 1
        Me.lCell최소전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소전압.IsPassword = False
        Me.lCell최소전압.Location = New System.Drawing.Point(394, 112)
        Me.lCell최소전압.Name = "lCell최소전압"
        Me.lCell최소전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소전압.TabIndex = 64
        Me.lCell최소전압.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최소전압.UseKeyPad = False
        '
        'lCell최소전압위치
        '
        Me.lCell최소전압위치.BackColor = System.Drawing.Color.White
        Me.lCell최소전압위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소전압위치.BorderSide_Bottom = True
        Me.lCell최소전압위치.BorderSide_Left = True
        Me.lCell최소전압위치.BorderSide_Right = True
        Me.lCell최소전압위치.BorderSide_Top = True
        Me.lCell최소전압위치.BorderWidth = 1
        Me.lCell최소전압위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소전압위치.IsPassword = False
        Me.lCell최소전압위치.Location = New System.Drawing.Point(394, 148)
        Me.lCell최소전압위치.Name = "lCell최소전압위치"
        Me.lCell최소전압위치.Size = New System.Drawing.Size(120, 30)
        Me.lCell최소전압위치.TabIndex = 62
        Me.lCell최소전압위치.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최소전압위치.UseKeyPad = False
        '
        'VsLabel30
        '
        Me.VsLabel30.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel30.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel30.BorderSide_Bottom = True
        Me.VsLabel30.BorderSide_Left = True
        Me.VsLabel30.BorderSide_Right = True
        Me.VsLabel30.BorderSide_Top = True
        Me.VsLabel30.BorderWidth = 1
        Me.VsLabel30.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel30.IsPassword = False
        Me.VsLabel30.Location = New System.Drawing.Point(33, 40)
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
        Me.VsLabel31.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel31.BorderSide_Bottom = True
        Me.VsLabel31.BorderSide_Left = True
        Me.VsLabel31.BorderSide_Right = True
        Me.VsLabel31.BorderSide_Top = True
        Me.VsLabel31.BorderWidth = 1
        Me.VsLabel31.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel31.IsPassword = False
        Me.VsLabel31.Location = New System.Drawing.Point(33, 148)
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
        Me.l랙SOC.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙SOC.BorderSide_Bottom = True
        Me.l랙SOC.BorderSide_Left = True
        Me.l랙SOC.BorderSide_Right = True
        Me.l랙SOC.BorderSide_Top = True
        Me.l랙SOC.BorderWidth = 1
        Me.l랙SOC.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙SOC.IsPassword = False
        Me.l랙SOC.Location = New System.Drawing.Point(137, 40)
        Me.l랙SOC.Name = "l랙SOC"
        Me.l랙SOC.Size = New System.Drawing.Size(119, 30)
        Me.l랙SOC.TabIndex = 62
        Me.l랙SOC.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙SOC.UseKeyPad = False
        '
        'VsLabel34
        '
        Me.VsLabel34.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel34.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel34.BorderSide_Bottom = True
        Me.VsLabel34.BorderSide_Left = True
        Me.VsLabel34.BorderSide_Right = True
        Me.VsLabel34.BorderSide_Top = True
        Me.VsLabel34.BorderWidth = 1
        Me.VsLabel34.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel34.IsPassword = False
        Me.VsLabel34.Location = New System.Drawing.Point(33, 112)
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
        Me.lCell평균전압.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell평균전압.BorderSide_Bottom = True
        Me.lCell평균전압.BorderSide_Left = True
        Me.lCell평균전압.BorderSide_Right = True
        Me.lCell평균전압.BorderSide_Top = True
        Me.lCell평균전압.BorderWidth = 1
        Me.lCell평균전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell평균전압.IsPassword = False
        Me.lCell평균전압.Location = New System.Drawing.Point(395, 220)
        Me.lCell평균전압.Name = "lCell평균전압"
        Me.lCell평균전압.Size = New System.Drawing.Size(119, 30)
        Me.lCell평균전압.TabIndex = 39
        Me.lCell평균전압.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell평균전압.UseKeyPad = False
        '
        'l랙SOH
        '
        Me.l랙SOH.BackColor = System.Drawing.Color.White
        Me.l랙SOH.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙SOH.BorderSide_Bottom = True
        Me.l랙SOH.BorderSide_Left = True
        Me.l랙SOH.BorderSide_Right = True
        Me.l랙SOH.BorderSide_Top = True
        Me.l랙SOH.BorderWidth = 1
        Me.l랙SOH.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙SOH.IsPassword = False
        Me.l랙SOH.Location = New System.Drawing.Point(137, 76)
        Me.l랙SOH.Name = "l랙SOH"
        Me.l랙SOH.Size = New System.Drawing.Size(119, 30)
        Me.l랙SOH.TabIndex = 63
        Me.l랙SOH.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙SOH.UseKeyPad = False
        '
        'l랙전류
        '
        Me.l랙전류.BackColor = System.Drawing.Color.White
        Me.l랙전류.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙전류.BorderSide_Bottom = True
        Me.l랙전류.BorderSide_Left = True
        Me.l랙전류.BorderSide_Right = True
        Me.l랙전류.BorderSide_Top = True
        Me.l랙전류.BorderWidth = 1
        Me.l랙전류.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙전류.IsPassword = False
        Me.l랙전류.Location = New System.Drawing.Point(137, 148)
        Me.l랙전류.Name = "l랙전류"
        Me.l랙전류.Size = New System.Drawing.Size(119, 30)
        Me.l랙전류.TabIndex = 55
        Me.l랙전류.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙전류.UseKeyPad = False
        '
        'VsLabel38
        '
        Me.VsLabel38.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel38.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel38.BorderSide_Bottom = True
        Me.VsLabel38.BorderSide_Left = True
        Me.VsLabel38.BorderSide_Right = True
        Me.VsLabel38.BorderSide_Top = True
        Me.VsLabel38.BorderWidth = 1
        Me.VsLabel38.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel38.IsPassword = False
        Me.VsLabel38.Location = New System.Drawing.Point(33, 76)
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
        Me.l랙전압.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙전압.BorderSide_Bottom = True
        Me.l랙전압.BorderSide_Left = True
        Me.l랙전압.BorderSide_Right = True
        Me.l랙전압.BorderSide_Top = True
        Me.l랙전압.BorderWidth = 1
        Me.l랙전압.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙전압.IsPassword = False
        Me.l랙전압.Location = New System.Drawing.Point(137, 112)
        Me.l랙전압.Name = "l랙전압"
        Me.l랙전압.Size = New System.Drawing.Size(119, 30)
        Me.l랙전압.TabIndex = 57
        Me.l랙전압.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙전압.UseKeyPad = False
        '
        'VsLabel14
        '
        Me.VsLabel14.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel14.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel14.BorderSide_Bottom = True
        Me.VsLabel14.BorderSide_Left = True
        Me.VsLabel14.BorderSide_Right = True
        Me.VsLabel14.BorderSide_Top = True
        Me.VsLabel14.BorderWidth = 1
        Me.VsLabel14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel14.IsPassword = False
        Me.VsLabel14.Location = New System.Drawing.Point(271, 220)
        Me.VsLabel14.Name = "VsLabel14"
        Me.VsLabel14.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel14.TabIndex = 42
        Me.VsLabel14.Text = "평균 전압"
        Me.VsLabel14.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel14.UseKeyPad = False
        '
        'VsLabel15
        '
        Me.VsLabel15.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel15.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel15.BorderSide_Bottom = True
        Me.VsLabel15.BorderSide_Left = True
        Me.VsLabel15.BorderSide_Right = True
        Me.VsLabel15.BorderSide_Top = True
        Me.VsLabel15.BorderWidth = 1
        Me.VsLabel15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel15.IsPassword = False
        Me.VsLabel15.Location = New System.Drawing.Point(519, 40)
        Me.VsLabel15.Name = "VsLabel15"
        Me.VsLabel15.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel15.TabIndex = 36
        Me.VsLabel15.Text = "최대온도"
        Me.VsLabel15.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel15.UseKeyPad = False
        '
        'VsLabel16
        '
        Me.VsLabel16.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel16.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel16.BorderSide_Bottom = True
        Me.VsLabel16.BorderSide_Left = True
        Me.VsLabel16.BorderSide_Right = True
        Me.VsLabel16.BorderSide_Top = True
        Me.VsLabel16.BorderWidth = 1
        Me.VsLabel16.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel16.IsPassword = False
        Me.VsLabel16.Location = New System.Drawing.Point(519, 148)
        Me.VsLabel16.Name = "VsLabel16"
        Me.VsLabel16.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel16.TabIndex = 35
        Me.VsLabel16.Text = "최소온도 위치"
        Me.VsLabel16.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel16.UseKeyPad = False
        '
        'l랙평균모듈온도
        '
        Me.l랙평균모듈온도.BackColor = System.Drawing.Color.White
        Me.l랙평균모듈온도.BorderColor = System.Drawing.Color.DarkGray
        Me.l랙평균모듈온도.BorderSide_Bottom = True
        Me.l랙평균모듈온도.BorderSide_Left = True
        Me.l랙평균모듈온도.BorderSide_Right = True
        Me.l랙평균모듈온도.BorderSide_Top = True
        Me.l랙평균모듈온도.BorderWidth = 1
        Me.l랙평균모듈온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.l랙평균모듈온도.IsPassword = False
        Me.l랙평균모듈온도.Location = New System.Drawing.Point(639, 220)
        Me.l랙평균모듈온도.Name = "l랙평균모듈온도"
        Me.l랙평균모듈온도.Size = New System.Drawing.Size(119, 30)
        Me.l랙평균모듈온도.TabIndex = 31
        Me.l랙평균모듈온도.TextAlign = System.Drawing.StringAlignment.Center
        Me.l랙평균모듈온도.UseKeyPad = False
        '
        'lCell최대온도
        '
        Me.lCell최대온도.BackColor = System.Drawing.Color.White
        Me.lCell최대온도.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대온도.BorderSide_Bottom = True
        Me.lCell최대온도.BorderSide_Left = True
        Me.lCell최대온도.BorderSide_Right = True
        Me.lCell최대온도.BorderSide_Top = True
        Me.lCell최대온도.BorderWidth = 1
        Me.lCell최대온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대온도.IsPassword = False
        Me.lCell최대온도.Location = New System.Drawing.Point(639, 40)
        Me.lCell최대온도.Name = "lCell최대온도"
        Me.lCell최대온도.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대온도.TabIndex = 37
        Me.lCell최대온도.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최대온도.UseKeyPad = False
        '
        'VsLabel17
        '
        Me.VsLabel17.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel17.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel17.BorderSide_Bottom = True
        Me.VsLabel17.BorderSide_Left = True
        Me.VsLabel17.BorderSide_Right = True
        Me.VsLabel17.BorderSide_Top = True
        Me.VsLabel17.BorderWidth = 1
        Me.VsLabel17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel17.IsPassword = False
        Me.VsLabel17.Location = New System.Drawing.Point(519, 112)
        Me.VsLabel17.Name = "VsLabel17"
        Me.VsLabel17.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel17.TabIndex = 40
        Me.VsLabel17.Text = "최소온도"
        Me.VsLabel17.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel17.UseKeyPad = False
        '
        'lCell최대온도위치
        '
        Me.lCell최대온도위치.BackColor = System.Drawing.Color.White
        Me.lCell최대온도위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최대온도위치.BorderSide_Bottom = True
        Me.lCell최대온도위치.BorderSide_Left = True
        Me.lCell최대온도위치.BorderSide_Right = True
        Me.lCell최대온도위치.BorderSide_Top = True
        Me.lCell최대온도위치.BorderWidth = 1
        Me.lCell최대온도위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최대온도위치.IsPassword = False
        Me.lCell최대온도위치.Location = New System.Drawing.Point(639, 76)
        Me.lCell최대온도위치.Name = "lCell최대온도위치"
        Me.lCell최대온도위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최대온도위치.TabIndex = 39
        Me.lCell최대온도위치.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최대온도위치.UseKeyPad = False
        '
        'lCell최소온도위치
        '
        Me.lCell최소온도위치.BackColor = System.Drawing.Color.White
        Me.lCell최소온도위치.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소온도위치.BorderSide_Bottom = True
        Me.lCell최소온도위치.BorderSide_Left = True
        Me.lCell최소온도위치.BorderSide_Right = True
        Me.lCell최소온도위치.BorderSide_Top = True
        Me.lCell최소온도위치.BorderWidth = 1
        Me.lCell최소온도위치.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소온도위치.IsPassword = False
        Me.lCell최소온도위치.Location = New System.Drawing.Point(639, 148)
        Me.lCell최소온도위치.Name = "lCell최소온도위치"
        Me.lCell최소온도위치.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소온도위치.TabIndex = 27
        Me.lCell최소온도위치.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최소온도위치.UseKeyPad = False
        '
        'VsLabel19
        '
        Me.VsLabel19.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel19.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel19.BorderSide_Bottom = True
        Me.VsLabel19.BorderSide_Left = True
        Me.VsLabel19.BorderSide_Right = True
        Me.VsLabel19.BorderSide_Top = True
        Me.VsLabel19.BorderWidth = 1
        Me.VsLabel19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel19.IsPassword = False
        Me.VsLabel19.Location = New System.Drawing.Point(519, 220)
        Me.VsLabel19.Name = "VsLabel19"
        Me.VsLabel19.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel19.TabIndex = 38
        Me.VsLabel19.Text = "평균 온도"
        Me.VsLabel19.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel19.UseKeyPad = False
        '
        'VsLabel20
        '
        Me.VsLabel20.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel20.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel20.BorderSide_Bottom = True
        Me.VsLabel20.BorderSide_Left = True
        Me.VsLabel20.BorderSide_Right = True
        Me.VsLabel20.BorderSide_Top = True
        Me.VsLabel20.BorderWidth = 1
        Me.VsLabel20.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel20.IsPassword = False
        Me.VsLabel20.Location = New System.Drawing.Point(519, 76)
        Me.VsLabel20.Name = "VsLabel20"
        Me.VsLabel20.Size = New System.Drawing.Size(115, 30)
        Me.VsLabel20.TabIndex = 28
        Me.VsLabel20.Text = "최대온도 위치"
        Me.VsLabel20.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel20.UseKeyPad = False
        '
        'lCell최소온도
        '
        Me.lCell최소온도.BackColor = System.Drawing.Color.White
        Me.lCell최소온도.BorderColor = System.Drawing.Color.DarkGray
        Me.lCell최소온도.BorderSide_Bottom = True
        Me.lCell최소온도.BorderSide_Left = True
        Me.lCell최소온도.BorderSide_Right = True
        Me.lCell최소온도.BorderSide_Top = True
        Me.lCell최소온도.BorderWidth = 1
        Me.lCell최소온도.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCell최소온도.IsPassword = False
        Me.lCell최소온도.Location = New System.Drawing.Point(639, 112)
        Me.lCell최소온도.Name = "lCell최소온도"
        Me.lCell최소온도.Size = New System.Drawing.Size(119, 30)
        Me.lCell최소온도.TabIndex = 29
        Me.lCell최소온도.TextAlign = System.Drawing.StringAlignment.Center
        Me.lCell최소온도.UseKeyPad = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.VsGroupBox1)
        Me.Panel1.Controls.Add(Me.VsGroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(802, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 283)
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
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel1.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel1.BorderSide_Bottom = True
        Me.VsLabel1.BorderSide_Left = True
        Me.VsLabel1.BorderSide_Right = True
        Me.VsLabel1.BorderSide_Top = True
        Me.VsLabel1.BorderWidth = 1
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.IsPassword = False
        Me.VsLabel1.Location = New System.Drawing.Point(14, 192)
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
        Me.VsLabel4.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel4.BorderSide_Bottom = True
        Me.VsLabel4.BorderSide_Left = True
        Me.VsLabel4.BorderSide_Right = True
        Me.VsLabel4.BorderSide_Top = True
        Me.VsLabel4.BorderWidth = 1
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.IsPassword = False
        Me.VsLabel4.Location = New System.Drawing.Point(120, 120)
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
        Me.VsLabel7.Location = New System.Drawing.Point(120, 228)
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
        Me.lChargingStatus.BorderColor = System.Drawing.Color.DarkGray
        Me.lChargingStatus.BorderSide_Bottom = True
        Me.lChargingStatus.BorderSide_Left = True
        Me.lChargingStatus.BorderSide_Right = True
        Me.lChargingStatus.BorderSide_Top = True
        Me.lChargingStatus.BorderWidth = 1
        Me.lChargingStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lChargingStatus.IsPassword = False
        Me.lChargingStatus.Location = New System.Drawing.Point(14, 228)
        Me.lChargingStatus.Name = "lChargingStatus"
        Me.lChargingStatus.Size = New System.Drawing.Size(81, 30)
        Me.lChargingStatus.TabIndex = 26
        Me.lChargingStatus.TextAlign = System.Drawing.StringAlignment.Center
        Me.lChargingStatus.UseKeyPad = False
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel3.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel3.BorderSide_Bottom = True
        Me.VsLabel3.BorderSide_Left = True
        Me.VsLabel3.BorderSide_Right = True
        Me.VsLabel3.BorderSide_Top = True
        Me.VsLabel3.BorderWidth = 1
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel3.IsPassword = False
        Me.VsLabel3.Location = New System.Drawing.Point(120, 84)
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
        Me.lSOC.BorderColor = System.Drawing.Color.DarkGray
        Me.lSOC.BorderSide_Bottom = True
        Me.lSOC.BorderSide_Left = True
        Me.lSOC.BorderSide_Right = True
        Me.lSOC.BorderSide_Top = True
        Me.lSOC.BorderWidth = 1
        Me.lSOC.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lSOC.IsPassword = False
        Me.lSOC.Location = New System.Drawing.Point(188, 48)
        Me.lSOC.Name = "lSOC"
        Me.lSOC.Size = New System.Drawing.Size(119, 30)
        Me.lSOC.TabIndex = 26
        Me.lSOC.TextAlign = System.Drawing.StringAlignment.Center
        Me.lSOC.UseKeyPad = False
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
        Me.VsLabel6.Location = New System.Drawing.Point(120, 192)
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
        Me.lSOH.BorderColor = System.Drawing.Color.DarkGray
        Me.lSOH.BorderSide_Bottom = True
        Me.lSOH.BorderSide_Left = True
        Me.lSOH.BorderSide_Right = True
        Me.lSOH.BorderSide_Top = True
        Me.lSOH.BorderWidth = 1
        Me.lSOH.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lSOH.IsPassword = False
        Me.lSOH.Location = New System.Drawing.Point(188, 84)
        Me.lSOH.Name = "lSOH"
        Me.lSOH.Size = New System.Drawing.Size(119, 30)
        Me.lSOH.TabIndex = 26
        Me.lSOH.TextAlign = System.Drawing.StringAlignment.Center
        Me.lSOH.UseKeyPad = False
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel2.BorderSide_Bottom = True
        Me.VsLabel2.BorderSide_Left = True
        Me.VsLabel2.BorderSide_Right = True
        Me.VsLabel2.BorderSide_Top = True
        Me.VsLabel2.BorderWidth = 1
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.IsPassword = False
        Me.VsLabel2.Location = New System.Drawing.Point(120, 48)
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
        Me.lPower.BorderColor = System.Drawing.Color.DarkGray
        Me.lPower.BorderSide_Bottom = True
        Me.lPower.BorderSide_Left = True
        Me.lPower.BorderSide_Right = True
        Me.lPower.BorderSide_Top = True
        Me.lPower.BorderWidth = 1
        Me.lPower.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lPower.IsPassword = False
        Me.lPower.Location = New System.Drawing.Point(188, 120)
        Me.lPower.Name = "lPower"
        Me.lPower.Size = New System.Drawing.Size(119, 30)
        Me.lPower.TabIndex = 26
        Me.lPower.TextAlign = System.Drawing.StringAlignment.Center
        Me.lPower.UseKeyPad = False
        '
        'VsLabel5
        '
        Me.VsLabel5.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel5.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel5.BorderSide_Bottom = True
        Me.VsLabel5.BorderSide_Left = True
        Me.VsLabel5.BorderSide_Right = True
        Me.VsLabel5.BorderSide_Top = True
        Me.VsLabel5.BorderWidth = 1
        Me.VsLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel5.IsPassword = False
        Me.VsLabel5.Location = New System.Drawing.Point(120, 156)
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
        Me.lVoltage.BorderColor = System.Drawing.Color.DarkGray
        Me.lVoltage.BorderSide_Bottom = True
        Me.lVoltage.BorderSide_Left = True
        Me.lVoltage.BorderSide_Right = True
        Me.lVoltage.BorderSide_Top = True
        Me.lVoltage.BorderWidth = 1
        Me.lVoltage.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lVoltage.IsPassword = False
        Me.lVoltage.Location = New System.Drawing.Point(188, 156)
        Me.lVoltage.Name = "lVoltage"
        Me.lVoltage.Size = New System.Drawing.Size(119, 30)
        Me.lVoltage.TabIndex = 26
        Me.lVoltage.TextAlign = System.Drawing.StringAlignment.Center
        Me.lVoltage.UseKeyPad = False
        '
        'lTemperature
        '
        Me.lTemperature.BackColor = System.Drawing.Color.White
        Me.lTemperature.BorderColor = System.Drawing.Color.DarkGray
        Me.lTemperature.BorderSide_Bottom = True
        Me.lTemperature.BorderSide_Left = True
        Me.lTemperature.BorderSide_Right = True
        Me.lTemperature.BorderSide_Top = True
        Me.lTemperature.BorderWidth = 1
        Me.lTemperature.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lTemperature.IsPassword = False
        Me.lTemperature.Location = New System.Drawing.Point(188, 228)
        Me.lTemperature.Name = "lTemperature"
        Me.lTemperature.Size = New System.Drawing.Size(119, 30)
        Me.lTemperature.TabIndex = 26
        Me.lTemperature.TextAlign = System.Drawing.StringAlignment.Center
        Me.lTemperature.UseKeyPad = False
        '
        'lCurrent
        '
        Me.lCurrent.BackColor = System.Drawing.Color.White
        Me.lCurrent.BorderColor = System.Drawing.Color.DarkGray
        Me.lCurrent.BorderSide_Bottom = True
        Me.lCurrent.BorderSide_Left = True
        Me.lCurrent.BorderSide_Right = True
        Me.lCurrent.BorderSide_Top = True
        Me.lCurrent.BorderWidth = 1
        Me.lCurrent.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lCurrent.IsPassword = False
        Me.lCurrent.Location = New System.Drawing.Point(188, 192)
        Me.lCurrent.Name = "lCurrent"
        Me.lCurrent.Size = New System.Drawing.Size(119, 30)
        Me.lCurrent.TabIndex = 26
        Me.lCurrent.TextAlign = System.Drawing.StringAlignment.Center
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
        '
        'VsLabel8
        '
        Me.VsLabel8.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel8.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel8.BorderSide_Bottom = True
        Me.VsLabel8.BorderSide_Left = True
        Me.VsLabel8.BorderSide_Right = True
        Me.VsLabel8.BorderSide_Top = True
        Me.VsLabel8.BorderWidth = 1
        Me.VsLabel8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel8.IsPassword = False
        Me.VsLabel8.Location = New System.Drawing.Point(101, 68)
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
        Me.lbBatteryDischarge_Today.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Today.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Today.BorderSide_Left = True
        Me.lbBatteryDischarge_Today.BorderSide_Right = True
        Me.lbBatteryDischarge_Today.BorderSide_Top = True
        Me.lbBatteryDischarge_Today.BorderWidth = 1
        Me.lbBatteryDischarge_Today.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Today.IsPassword = False
        Me.lbBatteryDischarge_Today.Location = New System.Drawing.Point(101, 113)
        Me.lbBatteryDischarge_Today.Name = "lbBatteryDischarge_Today"
        Me.lbBatteryDischarge_Today.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Today.TabIndex = 26
        Me.lbBatteryDischarge_Today.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryDischarge_Today.UseKeyPad = False
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
        Me.VsLabel9.Location = New System.Drawing.Point(256, 68)
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
        Me.lbBatteryCharge_Today.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Today.BorderSide_Bottom = True
        Me.lbBatteryCharge_Today.BorderSide_Left = True
        Me.lbBatteryCharge_Today.BorderSide_Right = True
        Me.lbBatteryCharge_Today.BorderSide_Top = True
        Me.lbBatteryCharge_Today.BorderWidth = 1
        Me.lbBatteryCharge_Today.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Today.IsPassword = False
        Me.lbBatteryCharge_Today.Location = New System.Drawing.Point(256, 113)
        Me.lbBatteryCharge_Today.Name = "lbBatteryCharge_Today"
        Me.lbBatteryCharge_Today.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Today.TabIndex = 26
        Me.lbBatteryCharge_Today.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCharge_Today.UseKeyPad = False
        '
        'VsLabel13
        '
        Me.VsLabel13.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel13.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel13.BorderSide_Bottom = True
        Me.VsLabel13.BorderSide_Left = True
        Me.VsLabel13.BorderSide_Right = True
        Me.VsLabel13.BorderSide_Top = True
        Me.VsLabel13.BorderWidth = 1
        Me.VsLabel13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel13.IsPassword = False
        Me.VsLabel13.Location = New System.Drawing.Point(19, 205)
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
        Me.lbBatteryDischarge_Yesterday.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Yesterday.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Left = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Right = True
        Me.lbBatteryDischarge_Yesterday.BorderSide_Top = True
        Me.lbBatteryDischarge_Yesterday.BorderWidth = 1
        Me.lbBatteryDischarge_Yesterday.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Yesterday.IsPassword = False
        Me.lbBatteryDischarge_Yesterday.Location = New System.Drawing.Point(101, 159)
        Me.lbBatteryDischarge_Yesterday.Name = "lbBatteryDischarge_Yesterday"
        Me.lbBatteryDischarge_Yesterday.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Yesterday.TabIndex = 26
        Me.lbBatteryDischarge_Yesterday.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryDischarge_Yesterday.UseKeyPad = False
        '
        'VsLabel12
        '
        Me.VsLabel12.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel12.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel12.BorderSide_Bottom = True
        Me.VsLabel12.BorderSide_Left = True
        Me.VsLabel12.BorderSide_Right = True
        Me.VsLabel12.BorderSide_Top = True
        Me.VsLabel12.BorderWidth = 1
        Me.VsLabel12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel12.IsPassword = False
        Me.VsLabel12.Location = New System.Drawing.Point(19, 159)
        Me.VsLabel12.Name = "VsLabel12"
        Me.VsLabel12.Size = New System.Drawing.Size(76, 40)
        Me.VsLabel12.TabIndex = 26
        Me.VsLabel12.Text = "당월"
        Me.VsLabel12.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel12.UseKeyPad = False
        '
        'lbBatteryCharge_Yesterday
        '
        Me.lbBatteryCharge_Yesterday.BackColor = System.Drawing.Color.White
        Me.lbBatteryCharge_Yesterday.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Yesterday.BorderSide_Bottom = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Left = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Right = True
        Me.lbBatteryCharge_Yesterday.BorderSide_Top = True
        Me.lbBatteryCharge_Yesterday.BorderWidth = 1
        Me.lbBatteryCharge_Yesterday.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Yesterday.IsPassword = False
        Me.lbBatteryCharge_Yesterday.Location = New System.Drawing.Point(256, 159)
        Me.lbBatteryCharge_Yesterday.Name = "lbBatteryCharge_Yesterday"
        Me.lbBatteryCharge_Yesterday.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Yesterday.TabIndex = 26
        Me.lbBatteryCharge_Yesterday.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCharge_Yesterday.UseKeyPad = False
        '
        'VsLabel10
        '
        Me.VsLabel10.BackColor = System.Drawing.Color.LightGray
        Me.VsLabel10.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel10.BorderSide_Bottom = True
        Me.VsLabel10.BorderSide_Left = True
        Me.VsLabel10.BorderSide_Right = True
        Me.VsLabel10.BorderSide_Top = True
        Me.VsLabel10.BorderWidth = 1
        Me.VsLabel10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel10.IsPassword = False
        Me.VsLabel10.Location = New System.Drawing.Point(19, 113)
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
        Me.lbBatteryDischarge_Total.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryDischarge_Total.BorderSide_Bottom = True
        Me.lbBatteryDischarge_Total.BorderSide_Left = True
        Me.lbBatteryDischarge_Total.BorderSide_Right = True
        Me.lbBatteryDischarge_Total.BorderSide_Top = True
        Me.lbBatteryDischarge_Total.BorderWidth = 1
        Me.lbBatteryDischarge_Total.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryDischarge_Total.IsPassword = False
        Me.lbBatteryDischarge_Total.Location = New System.Drawing.Point(101, 205)
        Me.lbBatteryDischarge_Total.Name = "lbBatteryDischarge_Total"
        Me.lbBatteryDischarge_Total.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryDischarge_Total.TabIndex = 26
        Me.lbBatteryDischarge_Total.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryDischarge_Total.UseKeyPad = False
        '
        'lbBatteryCharge_Total
        '
        Me.lbBatteryCharge_Total.BackColor = System.Drawing.Color.White
        Me.lbBatteryCharge_Total.BorderColor = System.Drawing.Color.DarkGray
        Me.lbBatteryCharge_Total.BorderSide_Bottom = True
        Me.lbBatteryCharge_Total.BorderSide_Left = True
        Me.lbBatteryCharge_Total.BorderSide_Right = True
        Me.lbBatteryCharge_Total.BorderSide_Top = True
        Me.lbBatteryCharge_Total.BorderWidth = 1
        Me.lbBatteryCharge_Total.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCharge_Total.IsPassword = False
        Me.lbBatteryCharge_Total.Location = New System.Drawing.Point(256, 205)
        Me.lbBatteryCharge_Total.Name = "lbBatteryCharge_Total"
        Me.lbBatteryCharge_Total.Size = New System.Drawing.Size(149, 40)
        Me.lbBatteryCharge_Total.TabIndex = 26
        Me.lbBatteryCharge_Total.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCharge_Total.UseKeyPad = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel.Location = New System.Drawing.Point(10, 49)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(784, 276)
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
        Me.PageHeader4.Location = New System.Drawing.Point(329, 3)
        Me.PageHeader4.Name = "PageHeader4"
        Me.PageHeader4.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader4.TabIndex = 23
        Me.PageHeader4.Text = "Rack#3"
        Me.PageHeader4.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader4.Visible = False
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
        Me.PageHeader3.Location = New System.Drawing.Point(223, 3)
        Me.PageHeader3.Name = "PageHeader3"
        Me.PageHeader3.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader3.TabIndex = 21
        Me.PageHeader3.Text = "String2"
        Me.PageHeader3.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader3.Visible = False
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
        Me.PageHeader2.Location = New System.Drawing.Point(110, 10)
        Me.PageHeader2.Name = "PageHeader2"
        Me.PageHeader2.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader2.TabIndex = 20
        Me.PageHeader2.Text = "Rack#1"
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
        Me.PageHeader1.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader1.TabIndex = 19
        Me.PageHeader1.Text = "Bank"
        Me.PageHeader1.TextAlign = System.Drawing.StringAlignment.Center
        '
        'wnd서브화면2_배터리
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PageHeader4)
        Me.Controls.Add(Me.PageHeader3)
        Me.Controls.Add(Me.PageHeader2)
        Me.Controls.Add(Me.PageHeader1)
        Me.Controls.Add(Me.Panel)
        Me.Name = "wnd서브화면2_배터리"
        Me.Size = New System.Drawing.Size(1600, 1338)
        Me.Panel3.ResumeLayout(False)
        Me.VsGroupBox3.ResumeLayout(False)
        Me.VsGroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.VsGroupBox1.ResumeLayout(False)
        Me.VsGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents VsGroupBox3 As PMS.VSGroupBox
    Friend WithEvents VsGroupBox4 As PMS.VSGroupBox
    Friend WithEvents VsLabel40 As PMS.VSLabel
    Friend WithEvents VsLabel41 As PMS.VSLabel
    Friend WithEvents PageHeader3 As PMS.VSLabel
    Friend WithEvents PageHeader2 As PMS.VSLabel
    Friend WithEvents PageHeader1 As PMS.VSLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents VsLabel66 As PMS.VSLabel
    Friend WithEvents VsLabel61 As PMS.VSLabel
    Friend WithEvents lCell최대전압 As PMS.VSLabel
    Friend WithEvents VsLabel58 As PMS.VSLabel
    Friend WithEvents lCell최대전압위치 As PMS.VSLabel
    Friend WithEvents VsLabel53 As PMS.VSLabel
    Friend WithEvents lCell최소전압 As PMS.VSLabel
    Friend WithEvents lCell최소전압위치 As PMS.VSLabel
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
    Friend WithEvents VsLabel17 As PMS.VSLabel
    Friend WithEvents lCell최대온도위치 As PMS.VSLabel
    Friend WithEvents lCell최소온도위치 As PMS.VSLabel
    Friend WithEvents VsLabel19 As PMS.VSLabel
    Friend WithEvents VsLabel20 As PMS.VSLabel
    Friend WithEvents lCell최소온도 As PMS.VSLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VsGroupBox1 As PMS.VSGroupBox
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents pbBattery As System.Windows.Forms.PictureBox
    Friend WithEvents VsLabel7 As PMS.VSLabel
    Friend WithEvents lChargingStatus As PMS.VSLabel
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents lSOC As PMS.VSLabel
    Friend WithEvents VsLabel6 As PMS.VSLabel
    Friend WithEvents lSOH As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents lPower As PMS.VSLabel
    Friend WithEvents VsLabel5 As PMS.VSLabel
    Friend WithEvents lVoltage As PMS.VSLabel
    Friend WithEvents lTemperature As PMS.VSLabel
    Friend WithEvents lCurrent As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Total As PMS.VSLabel
    Friend WithEvents lbBatteryDischarge_Total As PMS.VSLabel
    Friend WithEvents VsLabel10 As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Yesterday As PMS.VSLabel
    Friend WithEvents VsLabel12 As PMS.VSLabel
    Friend WithEvents lbBatteryDischarge_Yesterday As PMS.VSLabel
    Friend WithEvents VsLabel13 As PMS.VSLabel
    Friend WithEvents lbBatteryCharge_Today As PMS.VSLabel
    Friend WithEvents VsLabel9 As PMS.VSLabel
    Friend WithEvents lbBatteryDischarge_Today As PMS.VSLabel
    Friend WithEvents VsLabel8 As PMS.VSLabel
    Friend WithEvents VsGroupBox2 As PMS.VSGroupBox
    Friend WithEvents PageHeader4 As PMS.VSLabel
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents BTN_Minor_Fault_On As PMS.VSLabel
    Friend WithEvents VsLabel21 As PMS.VSLabel
    Friend WithEvents VsLabel26 As PMS.VSLabel
    Friend WithEvents VsLabel32 As PMS.VSLabel
    Friend WithEvents BTN_Major_Fault_Off As PMS.VSLabel
    Friend WithEvents BTN_Major_Fault_On As PMS.VSLabel
    Friend WithEvents BTN_Minor_Fault_Off As PMS.VSLabel
    Friend WithEvents GridOn_off As PMS.VSLabel
    Friend WithEvents Gridon_on As PMS.VSLabel
    Friend WithEvents lbWatchDog As PMS.VSLabel
    Friend WithEvents lbResponse As PMS.VSLabel
    Friend WithEvents VsLabel33 As PMS.VSLabel
    Friend WithEvents VsLabel22 As PMS.VSLabel

End Class

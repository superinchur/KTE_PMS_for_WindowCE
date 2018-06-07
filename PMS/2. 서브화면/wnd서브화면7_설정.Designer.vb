<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면7_설정
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
        Me.SmartConfigs1 = New SmartX.SmartConfigs
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlDateTime = New System.Windows.Forms.Panel
        Me.btnDateTimeSave = New PMS.VSPictureButton
        Me.lbDateTimeSecond = New PMS.VSLabel
        Me.lbDateTimeMinute = New PMS.VSLabel
        Me.lbDateTimeHour = New PMS.VSLabel
        Me.lbDateTimeDay = New PMS.VSLabel
        Me.lbDateTimeMonth = New PMS.VSLabel
        Me.lbDateTimeYear = New PMS.VSLabel
        Me.VsLabel11 = New PMS.VSLabel
        Me.VsLabel21 = New PMS.VSLabel
        Me.VsLabel20 = New PMS.VSLabel
        Me.VsLabel18 = New PMS.VSLabel
        Me.VsLabel17 = New PMS.VSLabel
        Me.VsLabel12 = New PMS.VSLabel
        Me.pnlComm = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbPCS통신포트 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbPCS통신주기 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.btnCommSave = New PMS.VSPictureButton
        Me.lbCommEMSPort = New PMS.VSLabel
        Me.pnlScreen = New System.Windows.Forms.Panel
        Me.VsPictureButton3 = New PMS.VSPictureButton
        Me.VsPictureButton2 = New PMS.VSPictureButton
        Me.VsPictureButton1 = New PMS.VSPictureButton
        Me.pnlNetwork = New System.Windows.Forms.Panel
        Me.btnNetworkSave = New PMS.VSPictureButton
        Me.lbNetworkDNS = New PMS.VSLabel
        Me.lbNetworkGateway = New PMS.VSLabel
        Me.lbNetworkSubnet = New PMS.VSLabel
        Me.lbNetworkIPAddress = New PMS.VSLabel
        Me.VsLabel6 = New PMS.VSLabel
        Me.VsLabel3 = New PMS.VSLabel
        Me.VsLabel2 = New PMS.VSLabel
        Me.VsLabel1 = New PMS.VSLabel
        Me.rbNetworkStatic = New System.Windows.Forms.RadioButton
        Me.rbNetworkDHCP = New System.Windows.Forms.RadioButton
        Me.PageHeader4 = New PMS.VSLabel
        Me.PageHeader3 = New PMS.VSLabel
        Me.PageHeader2 = New PMS.VSLabel
        Me.PageHeader1 = New PMS.VSLabel
        Me.PageHeader5 = New PMS.VSLabel
        Me.PageHeader6 = New PMS.VSLabel
        Me.pnlInformation = New System.Windows.Forms.Panel
        Me.VsLabel14 = New PMS.VSLabel
        Me.VsLabel13 = New PMS.VSLabel
        Me.VsLabel7 = New PMS.VSLabel
        Me.VsLabel10 = New PMS.VSLabel
        Me.VsLabel9 = New PMS.VSLabel
        Me.VsLabel8 = New PMS.VSLabel
        Me.VsLabel4 = New PMS.VSLabel
        Me.VsLabel5 = New PMS.VSLabel
        Me.pnlLanguage = New System.Windows.Forms.Panel
        Me.pnlDateTime.SuspendLayout()
        Me.pnlComm.SuspendLayout()
        Me.pnlScreen.SuspendLayout()
        Me.pnlNetwork.SuspendLayout()
        Me.pnlInformation.SuspendLayout()
        Me.pnlLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(10, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 283)
        '
        'pnlDateTime
        '
        Me.pnlDateTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDateTime.Controls.Add(Me.btnDateTimeSave)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeSecond)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeMinute)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeHour)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeDay)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeMonth)
        Me.pnlDateTime.Controls.Add(Me.lbDateTimeYear)
        Me.pnlDateTime.Controls.Add(Me.VsLabel11)
        Me.pnlDateTime.Controls.Add(Me.VsLabel21)
        Me.pnlDateTime.Controls.Add(Me.VsLabel20)
        Me.pnlDateTime.Controls.Add(Me.VsLabel18)
        Me.pnlDateTime.Controls.Add(Me.VsLabel17)
        Me.pnlDateTime.Controls.Add(Me.VsLabel12)
        Me.pnlDateTime.Location = New System.Drawing.Point(800, 49)
        Me.pnlDateTime.Name = "pnlDateTime"
        Me.pnlDateTime.Size = New System.Drawing.Size(784, 283)
        '
        'btnDateTimeSave
        '
        Me.btnDateTimeSave.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDateTimeSave.BorderSide_Bottom = True
        Me.btnDateTimeSave.BorderSide_Left = True
        Me.btnDateTimeSave.BorderSide_Right = True
        Me.btnDateTimeSave.BorderSide_Top = True
        Me.btnDateTimeSave.BorderWidth = 1
        Me.btnDateTimeSave.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnDateTimeSave.Location = New System.Drawing.Point(506, 181)
        Me.btnDateTimeSave.Name = "btnDateTimeSave"
        Me.btnDateTimeSave.Selected = False
        Me.btnDateTimeSave.Size = New System.Drawing.Size(100, 40)
        Me.btnDateTimeSave.TabIndex = 6
        Me.btnDateTimeSave.Text = "적용"
        '
        'lbDateTimeSecond
        '
        Me.lbDateTimeSecond.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeSecond.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeSecond.BorderSide_Bottom = True
        Me.lbDateTimeSecond.BorderSide_Left = True
        Me.lbDateTimeSecond.BorderSide_Right = True
        Me.lbDateTimeSecond.BorderSide_Top = True
        Me.lbDateTimeSecond.BorderWidth = 1
        Me.lbDateTimeSecond.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeSecond.Location = New System.Drawing.Point(546, 121)
        Me.lbDateTimeSecond.MaxRange = 59
        Me.lbDateTimeSecond.MinRange = 0
        Me.lbDateTimeSecond.Name = "lbDateTimeSecond"
        Me.lbDateTimeSecond.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeSecond.TabIndex = 6
        Me.lbDateTimeSecond.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeSecond.UseKeyPad = True
        '
        'lbDateTimeMinute
        '
        Me.lbDateTimeMinute.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeMinute.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeMinute.BorderSide_Bottom = True
        Me.lbDateTimeMinute.BorderSide_Left = True
        Me.lbDateTimeMinute.BorderSide_Right = True
        Me.lbDateTimeMinute.BorderSide_Top = True
        Me.lbDateTimeMinute.BorderWidth = 1
        Me.lbDateTimeMinute.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeMinute.Location = New System.Drawing.Point(437, 121)
        Me.lbDateTimeMinute.MaxRange = 59
        Me.lbDateTimeMinute.MinRange = 0
        Me.lbDateTimeMinute.Name = "lbDateTimeMinute"
        Me.lbDateTimeMinute.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeMinute.TabIndex = 6
        Me.lbDateTimeMinute.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeMinute.UseKeyPad = True
        '
        'lbDateTimeHour
        '
        Me.lbDateTimeHour.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeHour.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeHour.BorderSide_Bottom = True
        Me.lbDateTimeHour.BorderSide_Left = True
        Me.lbDateTimeHour.BorderSide_Right = True
        Me.lbDateTimeHour.BorderSide_Top = True
        Me.lbDateTimeHour.BorderWidth = 1
        Me.lbDateTimeHour.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeHour.Location = New System.Drawing.Point(328, 121)
        Me.lbDateTimeHour.MaxRange = 23
        Me.lbDateTimeHour.MinRange = 0
        Me.lbDateTimeHour.Name = "lbDateTimeHour"
        Me.lbDateTimeHour.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeHour.TabIndex = 6
        Me.lbDateTimeHour.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeHour.UseKeyPad = True
        '
        'lbDateTimeDay
        '
        Me.lbDateTimeDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeDay.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeDay.BorderSide_Bottom = True
        Me.lbDateTimeDay.BorderSide_Left = True
        Me.lbDateTimeDay.BorderSide_Right = True
        Me.lbDateTimeDay.BorderSide_Top = True
        Me.lbDateTimeDay.BorderWidth = 1
        Me.lbDateTimeDay.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeDay.Location = New System.Drawing.Point(546, 61)
        Me.lbDateTimeDay.MaxRange = 31
        Me.lbDateTimeDay.MinRange = 1
        Me.lbDateTimeDay.Name = "lbDateTimeDay"
        Me.lbDateTimeDay.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeDay.TabIndex = 7
        Me.lbDateTimeDay.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeDay.UseKeyPad = True
        '
        'lbDateTimeMonth
        '
        Me.lbDateTimeMonth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeMonth.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeMonth.BorderSide_Bottom = True
        Me.lbDateTimeMonth.BorderSide_Left = True
        Me.lbDateTimeMonth.BorderSide_Right = True
        Me.lbDateTimeMonth.BorderSide_Top = True
        Me.lbDateTimeMonth.BorderWidth = 1
        Me.lbDateTimeMonth.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeMonth.Location = New System.Drawing.Point(437, 61)
        Me.lbDateTimeMonth.MaxRange = 12
        Me.lbDateTimeMonth.MinRange = 1
        Me.lbDateTimeMonth.Name = "lbDateTimeMonth"
        Me.lbDateTimeMonth.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeMonth.TabIndex = 7
        Me.lbDateTimeMonth.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeMonth.UseKeyPad = True
        '
        'lbDateTimeYear
        '
        Me.lbDateTimeYear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbDateTimeYear.BorderColor = System.Drawing.Color.Gray
        Me.lbDateTimeYear.BorderSide_Bottom = True
        Me.lbDateTimeYear.BorderSide_Left = True
        Me.lbDateTimeYear.BorderSide_Right = True
        Me.lbDateTimeYear.BorderSide_Top = True
        Me.lbDateTimeYear.BorderWidth = 1
        Me.lbDateTimeYear.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbDateTimeYear.Location = New System.Drawing.Point(328, 61)
        Me.lbDateTimeYear.MaxRange = 2099
        Me.lbDateTimeYear.MinRange = 2016
        Me.lbDateTimeYear.Name = "lbDateTimeYear"
        Me.lbDateTimeYear.Size = New System.Drawing.Size(60, 35)
        Me.lbDateTimeYear.TabIndex = 7
        Me.lbDateTimeYear.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbDateTimeYear.UseKeyPad = True
        '
        'VsLabel11
        '
        Me.VsLabel11.BackColor = System.Drawing.Color.White
        Me.VsLabel11.BorderWidth = 0
        Me.VsLabel11.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel11.Location = New System.Drawing.Point(179, 121)
        Me.VsLabel11.Name = "VsLabel11"
        Me.VsLabel11.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel11.TabIndex = 4
        Me.VsLabel11.Text = "시    간 :"
        Me.VsLabel11.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel21
        '
        Me.VsLabel21.BackColor = System.Drawing.Color.White
        Me.VsLabel21.BorderWidth = 0
        Me.VsLabel21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel21.Location = New System.Drawing.Point(503, 121)
        Me.VsLabel21.Name = "VsLabel21"
        Me.VsLabel21.Size = New System.Drawing.Size(37, 35)
        Me.VsLabel21.TabIndex = 5
        Me.VsLabel21.Text = ":"
        Me.VsLabel21.TextAlign = System.Drawing.StringAlignment.Center
        '
        'VsLabel20
        '
        Me.VsLabel20.BackColor = System.Drawing.Color.White
        Me.VsLabel20.BorderWidth = 0
        Me.VsLabel20.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel20.Location = New System.Drawing.Point(394, 121)
        Me.VsLabel20.Name = "VsLabel20"
        Me.VsLabel20.Size = New System.Drawing.Size(37, 35)
        Me.VsLabel20.TabIndex = 5
        Me.VsLabel20.Text = ":"
        Me.VsLabel20.TextAlign = System.Drawing.StringAlignment.Center
        '
        'VsLabel18
        '
        Me.VsLabel18.BackColor = System.Drawing.Color.White
        Me.VsLabel18.BorderWidth = 0
        Me.VsLabel18.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel18.Location = New System.Drawing.Point(503, 61)
        Me.VsLabel18.Name = "VsLabel18"
        Me.VsLabel18.Size = New System.Drawing.Size(37, 35)
        Me.VsLabel18.TabIndex = 5
        Me.VsLabel18.Text = "-"
        Me.VsLabel18.TextAlign = System.Drawing.StringAlignment.Center
        '
        'VsLabel17
        '
        Me.VsLabel17.BackColor = System.Drawing.Color.White
        Me.VsLabel17.BorderWidth = 0
        Me.VsLabel17.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel17.Location = New System.Drawing.Point(394, 61)
        Me.VsLabel17.Name = "VsLabel17"
        Me.VsLabel17.Size = New System.Drawing.Size(37, 35)
        Me.VsLabel17.TabIndex = 5
        Me.VsLabel17.Text = "-"
        Me.VsLabel17.TextAlign = System.Drawing.StringAlignment.Center
        '
        'VsLabel12
        '
        Me.VsLabel12.BackColor = System.Drawing.Color.White
        Me.VsLabel12.BorderWidth = 0
        Me.VsLabel12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel12.Location = New System.Drawing.Point(179, 61)
        Me.VsLabel12.Name = "VsLabel12"
        Me.VsLabel12.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel12.TabIndex = 5
        Me.VsLabel12.Text = "날    짜 :"
        Me.VsLabel12.TextAlign = System.Drawing.StringAlignment.Far
        '
        'pnlComm
        '
        Me.pnlComm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlComm.Controls.Add(Me.Label3)
        Me.pnlComm.Controls.Add(Me.RadioButton1)
        Me.pnlComm.Controls.Add(Me.Label4)
        Me.pnlComm.Controls.Add(Me.cbPCS통신포트)
        Me.pnlComm.Controls.Add(Me.Label10)
        Me.pnlComm.Controls.Add(Me.cbPCS통신주기)
        Me.pnlComm.Controls.Add(Me.Label2)
        Me.pnlComm.Controls.Add(Me.Label5)
        Me.pnlComm.Controls.Add(Me.RadioButton2)
        Me.pnlComm.Controls.Add(Me.btnCommSave)
        Me.pnlComm.Controls.Add(Me.lbCommEMSPort)
        Me.pnlComm.Location = New System.Drawing.Point(10, 338)
        Me.pnlComm.Name = "pnlComm"
        Me.pnlComm.Size = New System.Drawing.Size(784, 283)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(253, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.Text = "PCS 통신포트 :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.Location = New System.Drawing.Point(408, 219)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 20)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.Text = "1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(253, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.Text = "PCS 통신주기 :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbPCS통신포트
        '
        Me.cbPCS통신포트.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cbPCS통신포트.Location = New System.Drawing.Point(400, 120)
        Me.cbPCS통신포트.Name = "cbPCS통신포트"
        Me.cbPCS통신포트.Size = New System.Drawing.Size(85, 29)
        Me.cbPCS통신포트.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(253, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.Text = "EMS 수신포트 :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbPCS통신주기
        '
        Me.cbPCS통신주기.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cbPCS통신주기.Location = New System.Drawing.Point(400, 163)
        Me.cbPCS통신주기.Name = "cbPCS통신주기"
        Me.cbPCS통신주기.Size = New System.Drawing.Size(85, 29)
        Me.cbPCS통신주기.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(261, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.Text = "PMS ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(491, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.Text = "ms"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.Location = New System.Drawing.Point(454, 219)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 20)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.TabStop = False
        Me.RadioButton2.Text = "2"
        '
        'btnCommSave
        '
        Me.btnCommSave.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCommSave.BorderSide_Bottom = True
        Me.btnCommSave.BorderSide_Left = True
        Me.btnCommSave.BorderSide_Right = True
        Me.btnCommSave.BorderSide_Top = True
        Me.btnCommSave.BorderWidth = 1
        Me.btnCommSave.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnCommSave.Location = New System.Drawing.Point(521, 221)
        Me.btnCommSave.Name = "btnCommSave"
        Me.btnCommSave.Selected = False
        Me.btnCommSave.Size = New System.Drawing.Size(100, 40)
        Me.btnCommSave.TabIndex = 26
        Me.btnCommSave.Text = "적용"
        '
        'lbCommEMSPort
        '
        Me.lbCommEMSPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbCommEMSPort.BorderColor = System.Drawing.Color.Gray
        Me.lbCommEMSPort.BorderSide_Bottom = True
        Me.lbCommEMSPort.BorderSide_Left = True
        Me.lbCommEMSPort.BorderSide_Right = True
        Me.lbCommEMSPort.BorderSide_Top = True
        Me.lbCommEMSPort.BorderWidth = 1
        Me.lbCommEMSPort.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbCommEMSPort.Location = New System.Drawing.Point(400, 60)
        Me.lbCommEMSPort.MaxRange = 65535
        Me.lbCommEMSPort.MinRange = 0
        Me.lbCommEMSPort.Name = "lbCommEMSPort"
        Me.lbCommEMSPort.Size = New System.Drawing.Size(94, 35)
        Me.lbCommEMSPort.TabIndex = 1
        Me.lbCommEMSPort.Text = "IP 주소 :"
        Me.lbCommEMSPort.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbCommEMSPort.UseKeyPad = True
        '
        'pnlScreen
        '
        Me.pnlScreen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen.Controls.Add(Me.VsPictureButton3)
        Me.pnlScreen.Controls.Add(Me.VsPictureButton2)
        Me.pnlScreen.Controls.Add(Me.VsPictureButton1)
        Me.pnlScreen.Location = New System.Drawing.Point(10, 627)
        Me.pnlScreen.Name = "pnlScreen"
        Me.pnlScreen.Size = New System.Drawing.Size(784, 283)
        '
        'VsPictureButton3
        '
        Me.VsPictureButton3.BorderColor = System.Drawing.Color.DarkGray
        Me.VsPictureButton3.BorderSide_Bottom = True
        Me.VsPictureButton3.BorderSide_Left = True
        Me.VsPictureButton3.BorderSide_Right = True
        Me.VsPictureButton3.BorderSide_Top = True
        Me.VsPictureButton3.BorderWidth = 1
        Me.VsPictureButton3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.VsPictureButton3.Location = New System.Drawing.Point(240, 199)
        Me.VsPictureButton3.Name = "VsPictureButton3"
        Me.VsPictureButton3.Selected = False
        Me.VsPictureButton3.Size = New System.Drawing.Size(300, 50)
        Me.VsPictureButton3.TabIndex = 8
        Me.VsPictureButton3.Text = "프로그램 종료"
        '
        'VsPictureButton2
        '
        Me.VsPictureButton2.BorderColor = System.Drawing.Color.DarkGray
        Me.VsPictureButton2.BorderSide_Bottom = True
        Me.VsPictureButton2.BorderSide_Left = True
        Me.VsPictureButton2.BorderSide_Right = True
        Me.VsPictureButton2.BorderSide_Top = True
        Me.VsPictureButton2.BorderWidth = 1
        Me.VsPictureButton2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.VsPictureButton2.Location = New System.Drawing.Point(240, 115)
        Me.VsPictureButton2.Name = "VsPictureButton2"
        Me.VsPictureButton2.Selected = False
        Me.VsPictureButton2.Size = New System.Drawing.Size(300, 50)
        Me.VsPictureButton2.TabIndex = 7
        Me.VsPictureButton2.Text = "터치스크린 좌표 보정"
        '
        'VsPictureButton1
        '
        Me.VsPictureButton1.BorderColor = System.Drawing.Color.DarkGray
        Me.VsPictureButton1.BorderSide_Bottom = True
        Me.VsPictureButton1.BorderSide_Left = True
        Me.VsPictureButton1.BorderSide_Right = True
        Me.VsPictureButton1.BorderSide_Top = True
        Me.VsPictureButton1.BorderWidth = 1
        Me.VsPictureButton1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.VsPictureButton1.Location = New System.Drawing.Point(240, 32)
        Me.VsPictureButton1.Name = "VsPictureButton1"
        Me.VsPictureButton1.Selected = False
        Me.VsPictureButton1.Size = New System.Drawing.Size(300, 50)
        Me.VsPictureButton1.TabIndex = 7
        Me.VsPictureButton1.Text = "조명 설정"
        '
        'pnlNetwork
        '
        Me.pnlNetwork.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlNetwork.Controls.Add(Me.btnNetworkSave)
        Me.pnlNetwork.Controls.Add(Me.lbNetworkDNS)
        Me.pnlNetwork.Controls.Add(Me.lbNetworkGateway)
        Me.pnlNetwork.Controls.Add(Me.lbNetworkSubnet)
        Me.pnlNetwork.Controls.Add(Me.lbNetworkIPAddress)
        Me.pnlNetwork.Controls.Add(Me.VsLabel6)
        Me.pnlNetwork.Controls.Add(Me.VsLabel3)
        Me.pnlNetwork.Controls.Add(Me.VsLabel2)
        Me.pnlNetwork.Controls.Add(Me.VsLabel1)
        Me.pnlNetwork.Controls.Add(Me.rbNetworkStatic)
        Me.pnlNetwork.Controls.Add(Me.rbNetworkDHCP)
        Me.pnlNetwork.Location = New System.Drawing.Point(800, 338)
        Me.pnlNetwork.Name = "pnlNetwork"
        Me.pnlNetwork.Size = New System.Drawing.Size(784, 283)
        '
        'btnNetworkSave
        '
        Me.btnNetworkSave.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNetworkSave.BorderSide_Bottom = True
        Me.btnNetworkSave.BorderSide_Left = True
        Me.btnNetworkSave.BorderSide_Right = True
        Me.btnNetworkSave.BorderSide_Top = True
        Me.btnNetworkSave.BorderWidth = 1
        Me.btnNetworkSave.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnNetworkSave.Location = New System.Drawing.Point(487, 221)
        Me.btnNetworkSave.Name = "btnNetworkSave"
        Me.btnNetworkSave.Selected = False
        Me.btnNetworkSave.Size = New System.Drawing.Size(100, 40)
        Me.btnNetworkSave.TabIndex = 6
        Me.btnNetworkSave.Text = "적용"
        Me.btnNetworkSave.Visible = False
        '
        'lbNetworkDNS
        '
        Me.lbNetworkDNS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbNetworkDNS.BorderColor = System.Drawing.Color.Gray
        Me.lbNetworkDNS.BorderSide_Bottom = True
        Me.lbNetworkDNS.BorderSide_Left = True
        Me.lbNetworkDNS.BorderSide_Right = True
        Me.lbNetworkDNS.BorderSide_Top = True
        Me.lbNetworkDNS.BorderWidth = 1
        Me.lbNetworkDNS.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbNetworkDNS.Location = New System.Drawing.Point(347, 180)
        Me.lbNetworkDNS.Name = "lbNetworkDNS"
        Me.lbNetworkDNS.Size = New System.Drawing.Size(240, 35)
        Me.lbNetworkDNS.TabIndex = 4
        Me.lbNetworkDNS.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbNetworkDNS.UseKeyPad = True
        '
        'lbNetworkGateway
        '
        Me.lbNetworkGateway.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbNetworkGateway.BorderColor = System.Drawing.Color.Gray
        Me.lbNetworkGateway.BorderSide_Bottom = True
        Me.lbNetworkGateway.BorderSide_Left = True
        Me.lbNetworkGateway.BorderSide_Right = True
        Me.lbNetworkGateway.BorderSide_Top = True
        Me.lbNetworkGateway.BorderWidth = 1
        Me.lbNetworkGateway.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbNetworkGateway.Location = New System.Drawing.Point(347, 139)
        Me.lbNetworkGateway.Name = "lbNetworkGateway"
        Me.lbNetworkGateway.Size = New System.Drawing.Size(240, 35)
        Me.lbNetworkGateway.TabIndex = 5
        Me.lbNetworkGateway.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbNetworkGateway.UseKeyPad = True
        '
        'lbNetworkSubnet
        '
        Me.lbNetworkSubnet.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbNetworkSubnet.BorderColor = System.Drawing.Color.Gray
        Me.lbNetworkSubnet.BorderSide_Bottom = True
        Me.lbNetworkSubnet.BorderSide_Left = True
        Me.lbNetworkSubnet.BorderSide_Right = True
        Me.lbNetworkSubnet.BorderSide_Top = True
        Me.lbNetworkSubnet.BorderWidth = 1
        Me.lbNetworkSubnet.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbNetworkSubnet.Location = New System.Drawing.Point(347, 98)
        Me.lbNetworkSubnet.Name = "lbNetworkSubnet"
        Me.lbNetworkSubnet.Size = New System.Drawing.Size(240, 35)
        Me.lbNetworkSubnet.TabIndex = 2
        Me.lbNetworkSubnet.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbNetworkSubnet.UseKeyPad = True
        '
        'lbNetworkIPAddress
        '
        Me.lbNetworkIPAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbNetworkIPAddress.BorderColor = System.Drawing.Color.Gray
        Me.lbNetworkIPAddress.BorderSide_Bottom = True
        Me.lbNetworkIPAddress.BorderSide_Left = True
        Me.lbNetworkIPAddress.BorderSide_Right = True
        Me.lbNetworkIPAddress.BorderSide_Top = True
        Me.lbNetworkIPAddress.BorderWidth = 1
        Me.lbNetworkIPAddress.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbNetworkIPAddress.Location = New System.Drawing.Point(347, 57)
        Me.lbNetworkIPAddress.Name = "lbNetworkIPAddress"
        Me.lbNetworkIPAddress.Size = New System.Drawing.Size(240, 35)
        Me.lbNetworkIPAddress.TabIndex = 3
        Me.lbNetworkIPAddress.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbNetworkIPAddress.UseKeyPad = True
        '
        'VsLabel6
        '
        Me.VsLabel6.BackColor = System.Drawing.Color.White
        Me.VsLabel6.BorderWidth = 0
        Me.VsLabel6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel6.Location = New System.Drawing.Point(198, 180)
        Me.VsLabel6.Name = "VsLabel6"
        Me.VsLabel6.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel6.TabIndex = 1
        Me.VsLabel6.Text = "DNS 서버 :"
        Me.VsLabel6.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.White
        Me.VsLabel3.BorderWidth = 0
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel3.Location = New System.Drawing.Point(198, 139)
        Me.VsLabel3.Name = "VsLabel3"
        Me.VsLabel3.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel3.TabIndex = 1
        Me.VsLabel3.Text = "게이트웨이 :"
        Me.VsLabel3.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.White
        Me.VsLabel2.BorderWidth = 0
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.Location = New System.Drawing.Point(198, 98)
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel2.TabIndex = 1
        Me.VsLabel2.Text = "서브넷마스크 :"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.White
        Me.VsLabel1.BorderWidth = 0
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.Location = New System.Drawing.Point(198, 57)
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel1.TabIndex = 1
        Me.VsLabel1.Text = "IP 주소 :"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Far
        '
        'rbNetworkStatic
        '
        Me.rbNetworkStatic.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.rbNetworkStatic.Location = New System.Drawing.Point(450, 22)
        Me.rbNetworkStatic.Name = "rbNetworkStatic"
        Me.rbNetworkStatic.Size = New System.Drawing.Size(180, 20)
        Me.rbNetworkStatic.TabIndex = 0
        Me.rbNetworkStatic.Text = "고정 IP 주소 사용"
        Me.rbNetworkStatic.Visible = False
        '
        'rbNetworkDHCP
        '
        Me.rbNetworkDHCP.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.rbNetworkDHCP.Location = New System.Drawing.Point(155, 22)
        Me.rbNetworkDHCP.Name = "rbNetworkDHCP"
        Me.rbNetworkDHCP.Size = New System.Drawing.Size(219, 20)
        Me.rbNetworkDHCP.TabIndex = 0
        Me.rbNetworkDHCP.Text = "자동으로 IP 주소 받기"
        Me.rbNetworkDHCP.Visible = False
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
        Me.PageHeader4.Location = New System.Drawing.Point(310, 10)
        Me.PageHeader4.Name = "PageHeader4"
        Me.PageHeader4.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader4.TabIndex = 11
        Me.PageHeader4.Text = "스크린"
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
        Me.PageHeader3.Location = New System.Drawing.Point(210, 10)
        Me.PageHeader3.Name = "PageHeader3"
        Me.PageHeader3.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader3.TabIndex = 11
        Me.PageHeader3.Text = "네트워크"
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
        Me.PageHeader2.Location = New System.Drawing.Point(110, 10)
        Me.PageHeader2.Name = "PageHeader2"
        Me.PageHeader2.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader2.TabIndex = 11
        Me.PageHeader2.Text = "통신설정"
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
        Me.PageHeader1.TabIndex = 11
        Me.PageHeader1.Text = "날짜/시간"
        Me.PageHeader1.TextAlign = System.Drawing.StringAlignment.Center
        '
        'PageHeader5
        '
        Me.PageHeader5.BackColor = System.Drawing.Color.White
        Me.PageHeader5.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader5.BorderSide_Bottom = False
        Me.PageHeader5.BorderSide_Left = False
        Me.PageHeader5.BorderSide_Right = True
        Me.PageHeader5.BorderSide_Top = True
        Me.PageHeader5.BorderWidth = 1
        Me.PageHeader5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader5.Location = New System.Drawing.Point(410, 10)
        Me.PageHeader5.Name = "PageHeader5"
        Me.PageHeader5.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader5.TabIndex = 13
        Me.PageHeader5.Text = "언어"
        Me.PageHeader5.TextAlign = System.Drawing.StringAlignment.Center
        '
        'PageHeader6
        '
        Me.PageHeader6.BackColor = System.Drawing.Color.White
        Me.PageHeader6.BorderColor = System.Drawing.Color.Gray
        Me.PageHeader6.BorderSide_Bottom = False
        Me.PageHeader6.BorderSide_Left = False
        Me.PageHeader6.BorderSide_Right = True
        Me.PageHeader6.BorderSide_Top = True
        Me.PageHeader6.BorderWidth = 1
        Me.PageHeader6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PageHeader6.Location = New System.Drawing.Point(510, 10)
        Me.PageHeader6.Name = "PageHeader6"
        Me.PageHeader6.Size = New System.Drawing.Size(100, 40)
        Me.PageHeader6.TabIndex = 19
        Me.PageHeader6.Text = "제품정보"
        Me.PageHeader6.TextAlign = System.Drawing.StringAlignment.Center
        '
        'pnlInformation
        '
        Me.pnlInformation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlInformation.Controls.Add(Me.VsLabel14)
        Me.pnlInformation.Controls.Add(Me.VsLabel13)
        Me.pnlInformation.Controls.Add(Me.VsLabel7)
        Me.pnlInformation.Controls.Add(Me.VsLabel10)
        Me.pnlInformation.Controls.Add(Me.VsLabel9)
        Me.pnlInformation.Controls.Add(Me.VsLabel8)
        Me.pnlInformation.Location = New System.Drawing.Point(10, 916)
        Me.pnlInformation.Name = "pnlInformation"
        Me.pnlInformation.Size = New System.Drawing.Size(784, 283)
        '
        'VsLabel14
        '
        Me.VsLabel14.BackColor = System.Drawing.Color.White
        Me.VsLabel14.BorderWidth = 0
        Me.VsLabel14.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel14.Location = New System.Drawing.Point(434, 165)
        Me.VsLabel14.Name = "VsLabel14"
        Me.VsLabel14.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel14.TabIndex = 1
        Me.VsLabel14.Text = "123456789"
        Me.VsLabel14.TextAlign = System.Drawing.StringAlignment.Near
        '
        'VsLabel13
        '
        Me.VsLabel13.BackColor = System.Drawing.Color.White
        Me.VsLabel13.BorderWidth = 0
        Me.VsLabel13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel13.Location = New System.Drawing.Point(434, 124)
        Me.VsLabel13.Name = "VsLabel13"
        Me.VsLabel13.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel13.TabIndex = 1
        Me.VsLabel13.Text = "1.0.0.0"
        Me.VsLabel13.TextAlign = System.Drawing.StringAlignment.Near
        '
        'VsLabel7
        '
        Me.VsLabel7.BackColor = System.Drawing.Color.White
        Me.VsLabel7.BorderWidth = 0
        Me.VsLabel7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel7.Location = New System.Drawing.Point(434, 83)
        Me.VsLabel7.Name = "VsLabel7"
        Me.VsLabel7.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel7.TabIndex = 1
        Me.VsLabel7.Text = "1.0.0.0"
        Me.VsLabel7.TextAlign = System.Drawing.StringAlignment.Near
        '
        'VsLabel10
        '
        Me.VsLabel10.BackColor = System.Drawing.Color.White
        Me.VsLabel10.BorderWidth = 0
        Me.VsLabel10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel10.Location = New System.Drawing.Point(208, 165)
        Me.VsLabel10.Name = "VsLabel10"
        Me.VsLabel10.Size = New System.Drawing.Size(220, 35)
        Me.VsLabel10.TabIndex = 1
        Me.VsLabel10.Text = "Product Serial No :"
        Me.VsLabel10.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel9
        '
        Me.VsLabel9.BackColor = System.Drawing.Color.White
        Me.VsLabel9.BorderWidth = 0
        Me.VsLabel9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel9.Location = New System.Drawing.Point(208, 124)
        Me.VsLabel9.Name = "VsLabel9"
        Me.VsLabel9.Size = New System.Drawing.Size(220, 35)
        Me.VsLabel9.TabIndex = 1
        Me.VsLabel9.Text = "PMS Program Version :"
        Me.VsLabel9.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel8
        '
        Me.VsLabel8.BackColor = System.Drawing.Color.White
        Me.VsLabel8.BorderWidth = 0
        Me.VsLabel8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel8.Location = New System.Drawing.Point(208, 83)
        Me.VsLabel8.Name = "VsLabel8"
        Me.VsLabel8.Size = New System.Drawing.Size(220, 35)
        Me.VsLabel8.TabIndex = 1
        Me.VsLabel8.Text = "PCS Program Version :"
        Me.VsLabel8.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel4
        '
        Me.VsLabel4.BackColor = System.Drawing.Color.White
        Me.VsLabel4.BorderWidth = 0
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.Location = New System.Drawing.Point(211, 115)
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(246, 35)
        Me.VsLabel4.TabIndex = 1
        Me.VsLabel4.Text = "사용언어 : "
        Me.VsLabel4.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel5
        '
        Me.VsLabel5.BackColor = System.Drawing.Color.White
        Me.VsLabel5.BorderWidth = 0
        Me.VsLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel5.Location = New System.Drawing.Point(463, 115)
        Me.VsLabel5.Name = "VsLabel5"
        Me.VsLabel5.Size = New System.Drawing.Size(143, 35)
        Me.VsLabel5.TabIndex = 1
        Me.VsLabel5.Text = "한국어"
        Me.VsLabel5.TextAlign = System.Drawing.StringAlignment.Near
        '
        'pnlLanguage
        '
        Me.pnlLanguage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLanguage.Controls.Add(Me.VsLabel5)
        Me.pnlLanguage.Controls.Add(Me.VsLabel4)
        Me.pnlLanguage.Location = New System.Drawing.Point(800, 627)
        Me.pnlLanguage.Name = "pnlLanguage"
        Me.pnlLanguage.Size = New System.Drawing.Size(784, 283)
        '
        'wnd서브화면7_설정
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlInformation)
        Me.Controls.Add(Me.PageHeader6)
        Me.Controls.Add(Me.pnlLanguage)
        Me.Controls.Add(Me.PageHeader5)
        Me.Controls.Add(Me.pnlNetwork)
        Me.Controls.Add(Me.pnlScreen)
        Me.Controls.Add(Me.pnlComm)
        Me.Controls.Add(Me.pnlDateTime)
        Me.Controls.Add(Me.PageHeader4)
        Me.Controls.Add(Me.PageHeader3)
        Me.Controls.Add(Me.PageHeader2)
        Me.Controls.Add(Me.PageHeader1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "wnd서브화면7_설정"
        Me.Size = New System.Drawing.Size(1603, 2000)
        Me.pnlDateTime.ResumeLayout(False)
        Me.pnlComm.ResumeLayout(False)
        Me.pnlScreen.ResumeLayout(False)
        Me.pnlNetwork.ResumeLayout(False)
        Me.pnlInformation.ResumeLayout(False)
        Me.pnlLanguage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cbPCS통신주기 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbPCS통신포트 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SmartConfigs1 As SmartX.SmartConfigs
    Friend WithEvents PageHeader1 As PMS.VSLabel
    Friend WithEvents PageHeader2 As PMS.VSLabel
    Friend WithEvents PageHeader3 As PMS.VSLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlDateTime As System.Windows.Forms.Panel
    Friend WithEvents pnlComm As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen As System.Windows.Forms.Panel
    Friend WithEvents PageHeader4 As PMS.VSLabel
    Friend WithEvents pnlNetwork As System.Windows.Forms.Panel
    Friend WithEvents rbNetworkStatic As System.Windows.Forms.RadioButton
    Friend WithEvents rbNetworkDHCP As System.Windows.Forms.RadioButton
    Friend WithEvents VsLabel6 As PMS.VSLabel
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents lbNetworkDNS As PMS.VSLabel
    Friend WithEvents lbNetworkGateway As PMS.VSLabel
    Friend WithEvents lbNetworkSubnet As PMS.VSLabel
    Friend WithEvents lbNetworkIPAddress As PMS.VSLabel
    Friend WithEvents lbDateTimeHour As PMS.VSLabel
    Friend WithEvents lbDateTimeYear As PMS.VSLabel
    Friend WithEvents VsLabel11 As PMS.VSLabel
    Friend WithEvents VsLabel12 As PMS.VSLabel
    Friend WithEvents btnNetworkSave As PMS.VSPictureButton
    Friend WithEvents btnDateTimeSave As PMS.VSPictureButton
    Friend WithEvents btnCommSave As PMS.VSPictureButton
    Friend WithEvents lbCommEMSPort As PMS.VSLabel
    Friend WithEvents lbDateTimeSecond As PMS.VSLabel
    Friend WithEvents lbDateTimeMinute As PMS.VSLabel
    Friend WithEvents lbDateTimeDay As PMS.VSLabel
    Friend WithEvents lbDateTimeMonth As PMS.VSLabel
    Friend WithEvents VsLabel21 As PMS.VSLabel
    Friend WithEvents VsLabel20 As PMS.VSLabel
    Friend WithEvents VsLabel18 As PMS.VSLabel
    Friend WithEvents VsLabel17 As PMS.VSLabel
    Friend WithEvents PageHeader5 As PMS.VSLabel
    Friend WithEvents VsPictureButton2 As PMS.VSPictureButton
    Friend WithEvents VsPictureButton1 As PMS.VSPictureButton
    Friend WithEvents PageHeader6 As PMS.VSLabel
    Friend WithEvents pnlInformation As System.Windows.Forms.Panel
    Friend WithEvents VsLabel7 As PMS.VSLabel
    Friend WithEvents VsLabel10 As PMS.VSLabel
    Friend WithEvents VsLabel9 As PMS.VSLabel
    Friend WithEvents VsLabel8 As PMS.VSLabel
    Friend WithEvents VsLabel14 As PMS.VSLabel
    Friend WithEvents VsLabel13 As PMS.VSLabel
    Friend WithEvents VsPictureButton3 As PMS.VSPictureButton
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents VsLabel5 As PMS.VSLabel
    Friend WithEvents pnlLanguage As System.Windows.Forms.Panel

End Class

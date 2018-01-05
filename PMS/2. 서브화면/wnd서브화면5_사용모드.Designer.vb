<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class wnd서브화면5_사용모드
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wnd서브화면5_사용모드))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlScreen1 = New System.Windows.Forms.Panel
        Me.btnPeakCutSet = New PMS.VSPictureButton
        Me.VsLabel15 = New PMS.VSLabel
        Me.VsLabel14 = New PMS.VSLabel
        Me.VsLabel5 = New PMS.VSLabel
        Me.VsLabel29 = New PMS.VSLabel
        Me.VsLabel19 = New PMS.VSLabel
        Me.VsLabel28 = New PMS.VSLabel
        Me.VsLabel22 = New PMS.VSLabel
        Me.VsLabel27 = New PMS.VSLabel
        Me.VsLabel18 = New PMS.VSLabel
        Me.lbTime2EndMin = New PMS.VSLabel
        Me.lbTime1EndMin = New PMS.VSLabel
        Me.lbTime2StartMin = New PMS.VSLabel
        Me.lbTime1StartMin = New PMS.VSLabel
        Me.lbTime2EndHour = New PMS.VSLabel
        Me.lbTime1EndHour = New PMS.VSLabel
        Me.lbTime2StartHour = New PMS.VSLabel
        Me.lbTime1StartHour = New PMS.VSLabel
        Me.VsLabel11 = New PMS.VSLabel
        Me.lbPeakCut = New PMS.VSLabel
        Me.VsLabel2 = New PMS.VSLabel
        Me.VsLabel10 = New PMS.VSLabel
        Me.lbLoadPower = New PMS.VSLabel
        Me.VsLabel1 = New PMS.VSLabel
        Me.VsLabel13 = New PMS.VSLabel
        Me.lbBatteryCS = New PMS.VSLabel
        Me.VsLabel4 = New PMS.VSLabel
        Me.VsLabel12 = New PMS.VSLabel
        Me.lbBatteryFD = New PMS.VSLabel
        Me.VsLabel3 = New PMS.VSLabel
        Me.pnlScreen2 = New System.Windows.Forms.Panel
        Me.btnGridActivePower = New PMS.VSPictureButton
        Me.VsLabel30 = New PMS.VSLabel
        Me.lbGridActivePower = New PMS.VSLabel
        Me.VsLabel32 = New PMS.VSLabel
        Me.pnlScreen3 = New System.Windows.Forms.Panel
        Me.btnGridReactivePower = New PMS.VSPictureButton
        Me.VsLabel33 = New PMS.VSLabel
        Me.lbGridReactivePower = New PMS.VSLabel
        Me.VsLabel35 = New PMS.VSLabel
        Me.타이머_상태 = New System.Windows.Forms.Timer(Me.components)
        Me.PageHeader3 = New PMS.VSLabel
        Me.PageHeader2 = New PMS.VSLabel
        Me.PageHeader1 = New PMS.VSLabel
        Me.PageHeader4 = New PMS.VSLabel
        Me.pnlScreen4 = New System.Windows.Forms.Panel
        Me.btnBatteryCharging = New PMS.VSPictureButton
        Me.VsLabel39 = New PMS.VSLabel
        Me.lbBatteryCV = New PMS.VSLabel
        Me.VsLabel36 = New PMS.VSLabel
        Me.lbBatteryCC = New PMS.VSLabel
        Me.VsLabel37 = New PMS.VSLabel
        Me.VsLabel31 = New PMS.VSLabel
        Me.pnlScreen1.SuspendLayout()
        Me.pnlScreen2.SuspendLayout()
        Me.pnlScreen3.SuspendLayout()
        Me.pnlScreen4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(8, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 283)
        Me.Panel1.TabIndex = 0
        '
        'pnlScreen1
        '
        Me.pnlScreen1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen1.Controls.Add(Me.btnPeakCutSet)
        Me.pnlScreen1.Controls.Add(Me.VsLabel15)
        Me.pnlScreen1.Controls.Add(Me.VsLabel14)
        Me.pnlScreen1.Controls.Add(Me.VsLabel5)
        Me.pnlScreen1.Controls.Add(Me.VsLabel29)
        Me.pnlScreen1.Controls.Add(Me.VsLabel19)
        Me.pnlScreen1.Controls.Add(Me.VsLabel28)
        Me.pnlScreen1.Controls.Add(Me.VsLabel22)
        Me.pnlScreen1.Controls.Add(Me.VsLabel27)
        Me.pnlScreen1.Controls.Add(Me.VsLabel18)
        Me.pnlScreen1.Controls.Add(Me.lbTime2EndMin)
        Me.pnlScreen1.Controls.Add(Me.lbTime1EndMin)
        Me.pnlScreen1.Controls.Add(Me.lbTime2StartMin)
        Me.pnlScreen1.Controls.Add(Me.lbTime1StartMin)
        Me.pnlScreen1.Controls.Add(Me.lbTime2EndHour)
        Me.pnlScreen1.Controls.Add(Me.lbTime1EndHour)
        Me.pnlScreen1.Controls.Add(Me.lbTime2StartHour)
        Me.pnlScreen1.Controls.Add(Me.lbTime1StartHour)
        Me.pnlScreen1.Controls.Add(Me.VsLabel11)
        Me.pnlScreen1.Controls.Add(Me.lbPeakCut)
        Me.pnlScreen1.Controls.Add(Me.VsLabel2)
        Me.pnlScreen1.Controls.Add(Me.VsLabel10)
        Me.pnlScreen1.Controls.Add(Me.lbLoadPower)
        Me.pnlScreen1.Controls.Add(Me.VsLabel1)
        Me.pnlScreen1.Location = New System.Drawing.Point(798, 47)
        Me.pnlScreen1.Name = "pnlScreen1"
        Me.pnlScreen1.Size = New System.Drawing.Size(784, 283)
        Me.pnlScreen1.TabIndex = 38
        '
        'btnPeakCutSet
        '
        Me.btnPeakCutSet.BackColor = System.Drawing.Color.Blue
        Me.btnPeakCutSet.BackgroundImageValue = CType(resources.GetObject("btnPeakCutSet.BackgroundImageValue"), System.Drawing.Image)
        Me.btnPeakCutSet.BorderColor = System.Drawing.Color.Gray
        Me.btnPeakCutSet.BorderSide_Bottom = True
        Me.btnPeakCutSet.BorderSide_Left = True
        Me.btnPeakCutSet.BorderSide_Right = True
        Me.btnPeakCutSet.BorderSide_Top = True
        Me.btnPeakCutSet.BorderWidth = 1
        Me.btnPeakCutSet.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnPeakCutSet.ForeColor = System.Drawing.Color.White
        Me.btnPeakCutSet.Location = New System.Drawing.Point(590, 195)
        Me.btnPeakCutSet.Name = "btnPeakCutSet"
        Me.btnPeakCutSet.PressedImageValue = CType(resources.GetObject("btnPeakCutSet.PressedImageValue"), System.Drawing.Image)
        Me.btnPeakCutSet.Selected = False
        Me.btnPeakCutSet.Size = New System.Drawing.Size(160, 50)
        Me.btnPeakCutSet.TabIndex = 34
        Me.btnPeakCutSet.Text = "적용"
        '
        'VsLabel15
        '
        Me.VsLabel15.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel15.BackImage = Nothing
        Me.VsLabel15.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel15.BorderSide_Bottom = True
        Me.VsLabel15.BorderSide_Left = True
        Me.VsLabel15.BorderSide_Right = True
        Me.VsLabel15.BorderSide_Top = True
        Me.VsLabel15.BorderWidth = 1
        Me.VsLabel15.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel15.IsPassword = False
        Me.VsLabel15.Location = New System.Drawing.Point(430, 134)
        Me.VsLabel15.MaxRange = 0
        Me.VsLabel15.MinRange = 0
        Me.VsLabel15.Name = "VsLabel15"
        Me.VsLabel15.Size = New System.Drawing.Size(60, 40)
        Me.VsLabel15.TabIndex = 27
        Me.VsLabel15.Text = "2차"
        Me.VsLabel15.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel15.UseKeyPad = False
        '
        'VsLabel14
        '
        Me.VsLabel14.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel14.BackImage = Nothing
        Me.VsLabel14.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel14.BorderSide_Bottom = True
        Me.VsLabel14.BorderSide_Left = True
        Me.VsLabel14.BorderSide_Right = True
        Me.VsLabel14.BorderSide_Top = True
        Me.VsLabel14.BorderWidth = 1
        Me.VsLabel14.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel14.IsPassword = False
        Me.VsLabel14.Location = New System.Drawing.Point(430, 88)
        Me.VsLabel14.MaxRange = 0
        Me.VsLabel14.MinRange = 0
        Me.VsLabel14.Name = "VsLabel14"
        Me.VsLabel14.Size = New System.Drawing.Size(60, 40)
        Me.VsLabel14.TabIndex = 27
        Me.VsLabel14.Text = "1차"
        Me.VsLabel14.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel14.UseKeyPad = False
        '
        'VsLabel5
        '
        Me.VsLabel5.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel5.BackImage = Nothing
        Me.VsLabel5.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel5.BorderSide_Bottom = True
        Me.VsLabel5.BorderSide_Left = True
        Me.VsLabel5.BorderSide_Right = True
        Me.VsLabel5.BorderSide_Top = True
        Me.VsLabel5.BorderWidth = 1
        Me.VsLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel5.IsPassword = False
        Me.VsLabel5.Location = New System.Drawing.Point(302, 88)
        Me.VsLabel5.MaxRange = 0
        Me.VsLabel5.MinRange = 0
        Me.VsLabel5.Name = "VsLabel5"
        Me.VsLabel5.Size = New System.Drawing.Size(124, 86)
        Me.VsLabel5.TabIndex = 27
        Me.VsLabel5.Text = "설정 시간"
        Me.VsLabel5.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel5.UseKeyPad = False
        '
        'VsLabel29
        '
        Me.VsLabel29.BackColor = System.Drawing.Color.White
        Me.VsLabel29.BackImage = Nothing
        Me.VsLabel29.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel29.BorderSide_Bottom = True
        Me.VsLabel29.BorderSide_Left = True
        Me.VsLabel29.BorderSide_Right = True
        Me.VsLabel29.BorderSide_Top = True
        Me.VsLabel29.BorderWidth = 0
        Me.VsLabel29.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel29.IsPassword = False
        Me.VsLabel29.Location = New System.Drawing.Point(608, 134)
        Me.VsLabel29.MaxRange = 0
        Me.VsLabel29.MinRange = 0
        Me.VsLabel29.Name = "VsLabel29"
        Me.VsLabel29.Size = New System.Drawing.Size(30, 40)
        Me.VsLabel29.TabIndex = 27
        Me.VsLabel29.Text = "∼"
        Me.VsLabel29.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel29.UseKeyPad = False
        '
        'VsLabel19
        '
        Me.VsLabel19.BackColor = System.Drawing.Color.White
        Me.VsLabel19.BackImage = Nothing
        Me.VsLabel19.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel19.BorderSide_Bottom = True
        Me.VsLabel19.BorderSide_Left = True
        Me.VsLabel19.BorderSide_Right = True
        Me.VsLabel19.BorderSide_Top = True
        Me.VsLabel19.BorderWidth = 0
        Me.VsLabel19.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel19.IsPassword = False
        Me.VsLabel19.Location = New System.Drawing.Point(608, 88)
        Me.VsLabel19.MaxRange = 0
        Me.VsLabel19.MinRange = 0
        Me.VsLabel19.Name = "VsLabel19"
        Me.VsLabel19.Size = New System.Drawing.Size(30, 40)
        Me.VsLabel19.TabIndex = 27
        Me.VsLabel19.Text = "∼"
        Me.VsLabel19.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel19.UseKeyPad = False
        '
        'VsLabel28
        '
        Me.VsLabel28.BackColor = System.Drawing.Color.White
        Me.VsLabel28.BackImage = Nothing
        Me.VsLabel28.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel28.BorderSide_Bottom = True
        Me.VsLabel28.BorderSide_Left = True
        Me.VsLabel28.BorderSide_Right = True
        Me.VsLabel28.BorderSide_Top = True
        Me.VsLabel28.BorderWidth = 0
        Me.VsLabel28.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel28.IsPassword = False
        Me.VsLabel28.Location = New System.Drawing.Point(690, 134)
        Me.VsLabel28.MaxRange = 0
        Me.VsLabel28.MinRange = 0
        Me.VsLabel28.Name = "VsLabel28"
        Me.VsLabel28.Size = New System.Drawing.Size(13, 40)
        Me.VsLabel28.TabIndex = 27
        Me.VsLabel28.Text = ":"
        Me.VsLabel28.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel28.UseKeyPad = False
        '
        'VsLabel22
        '
        Me.VsLabel22.BackColor = System.Drawing.Color.White
        Me.VsLabel22.BackImage = Nothing
        Me.VsLabel22.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel22.BorderSide_Bottom = True
        Me.VsLabel22.BorderSide_Left = True
        Me.VsLabel22.BorderSide_Right = True
        Me.VsLabel22.BorderSide_Top = True
        Me.VsLabel22.BorderWidth = 0
        Me.VsLabel22.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel22.IsPassword = False
        Me.VsLabel22.Location = New System.Drawing.Point(690, 88)
        Me.VsLabel22.MaxRange = 0
        Me.VsLabel22.MinRange = 0
        Me.VsLabel22.Name = "VsLabel22"
        Me.VsLabel22.Size = New System.Drawing.Size(13, 40)
        Me.VsLabel22.TabIndex = 27
        Me.VsLabel22.Text = ":"
        Me.VsLabel22.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel22.UseKeyPad = False
        '
        'VsLabel27
        '
        Me.VsLabel27.BackColor = System.Drawing.Color.White
        Me.VsLabel27.BackImage = Nothing
        Me.VsLabel27.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel27.BorderSide_Bottom = True
        Me.VsLabel27.BorderSide_Left = True
        Me.VsLabel27.BorderSide_Right = True
        Me.VsLabel27.BorderSide_Top = True
        Me.VsLabel27.BorderWidth = 0
        Me.VsLabel27.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel27.IsPassword = False
        Me.VsLabel27.Location = New System.Drawing.Point(542, 134)
        Me.VsLabel27.MaxRange = 0
        Me.VsLabel27.MinRange = 0
        Me.VsLabel27.Name = "VsLabel27"
        Me.VsLabel27.Size = New System.Drawing.Size(13, 40)
        Me.VsLabel27.TabIndex = 27
        Me.VsLabel27.Text = ":"
        Me.VsLabel27.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel27.UseKeyPad = False
        '
        'VsLabel18
        '
        Me.VsLabel18.BackColor = System.Drawing.Color.White
        Me.VsLabel18.BackImage = Nothing
        Me.VsLabel18.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel18.BorderSide_Bottom = True
        Me.VsLabel18.BorderSide_Left = True
        Me.VsLabel18.BorderSide_Right = True
        Me.VsLabel18.BorderSide_Top = True
        Me.VsLabel18.BorderWidth = 0
        Me.VsLabel18.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel18.IsPassword = False
        Me.VsLabel18.Location = New System.Drawing.Point(542, 88)
        Me.VsLabel18.MaxRange = 0
        Me.VsLabel18.MinRange = 0
        Me.VsLabel18.Name = "VsLabel18"
        Me.VsLabel18.Size = New System.Drawing.Size(13, 40)
        Me.VsLabel18.TabIndex = 27
        Me.VsLabel18.Text = ":"
        Me.VsLabel18.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel18.UseKeyPad = False
        '
        'lbTime2EndMin
        '
        Me.lbTime2EndMin.BackColor = System.Drawing.Color.White
        Me.lbTime2EndMin.BackImage = Nothing
        Me.lbTime2EndMin.BorderColor = System.Drawing.Color.Gray
        Me.lbTime2EndMin.BorderSide_Bottom = True
        Me.lbTime2EndMin.BorderSide_Left = True
        Me.lbTime2EndMin.BorderSide_Right = True
        Me.lbTime2EndMin.BorderSide_Top = True
        Me.lbTime2EndMin.BorderWidth = 1
        Me.lbTime2EndMin.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime2EndMin.IsPassword = False
        Me.lbTime2EndMin.Location = New System.Drawing.Point(709, 134)
        Me.lbTime2EndMin.MaxRange = 59
        Me.lbTime2EndMin.MinRange = 0
        Me.lbTime2EndMin.Name = "lbTime2EndMin"
        Me.lbTime2EndMin.Size = New System.Drawing.Size(41, 40)
        Me.lbTime2EndMin.TabIndex = 27
        Me.lbTime2EndMin.Text = "00"
        Me.lbTime2EndMin.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime2EndMin.UseKeyPad = True
        '
        'lbTime1EndMin
        '
        Me.lbTime1EndMin.BackColor = System.Drawing.Color.White
        Me.lbTime1EndMin.BackImage = Nothing
        Me.lbTime1EndMin.BorderColor = System.Drawing.Color.Gray
        Me.lbTime1EndMin.BorderSide_Bottom = True
        Me.lbTime1EndMin.BorderSide_Left = True
        Me.lbTime1EndMin.BorderSide_Right = True
        Me.lbTime1EndMin.BorderSide_Top = True
        Me.lbTime1EndMin.BorderWidth = 1
        Me.lbTime1EndMin.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime1EndMin.IsPassword = False
        Me.lbTime1EndMin.Location = New System.Drawing.Point(709, 88)
        Me.lbTime1EndMin.MaxRange = 59
        Me.lbTime1EndMin.MinRange = 0
        Me.lbTime1EndMin.Name = "lbTime1EndMin"
        Me.lbTime1EndMin.Size = New System.Drawing.Size(41, 40)
        Me.lbTime1EndMin.TabIndex = 27
        Me.lbTime1EndMin.Text = "00"
        Me.lbTime1EndMin.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime1EndMin.UseKeyPad = True
        '
        'lbTime2StartMin
        '
        Me.lbTime2StartMin.BackColor = System.Drawing.Color.White
        Me.lbTime2StartMin.BackImage = Nothing
        Me.lbTime2StartMin.BorderColor = System.Drawing.Color.Gray
        Me.lbTime2StartMin.BorderSide_Bottom = True
        Me.lbTime2StartMin.BorderSide_Left = True
        Me.lbTime2StartMin.BorderSide_Right = True
        Me.lbTime2StartMin.BorderSide_Top = True
        Me.lbTime2StartMin.BorderWidth = 1
        Me.lbTime2StartMin.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime2StartMin.IsPassword = False
        Me.lbTime2StartMin.Location = New System.Drawing.Point(561, 134)
        Me.lbTime2StartMin.MaxRange = 59
        Me.lbTime2StartMin.MinRange = 0
        Me.lbTime2StartMin.Name = "lbTime2StartMin"
        Me.lbTime2StartMin.Size = New System.Drawing.Size(41, 40)
        Me.lbTime2StartMin.TabIndex = 27
        Me.lbTime2StartMin.Text = "00"
        Me.lbTime2StartMin.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime2StartMin.UseKeyPad = True
        '
        'lbTime1StartMin
        '
        Me.lbTime1StartMin.BackColor = System.Drawing.Color.White
        Me.lbTime1StartMin.BackImage = Nothing
        Me.lbTime1StartMin.BorderColor = System.Drawing.Color.Gray
        Me.lbTime1StartMin.BorderSide_Bottom = True
        Me.lbTime1StartMin.BorderSide_Left = True
        Me.lbTime1StartMin.BorderSide_Right = True
        Me.lbTime1StartMin.BorderSide_Top = True
        Me.lbTime1StartMin.BorderWidth = 1
        Me.lbTime1StartMin.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime1StartMin.IsPassword = False
        Me.lbTime1StartMin.Location = New System.Drawing.Point(561, 88)
        Me.lbTime1StartMin.MaxRange = 59
        Me.lbTime1StartMin.MinRange = 0
        Me.lbTime1StartMin.Name = "lbTime1StartMin"
        Me.lbTime1StartMin.Size = New System.Drawing.Size(41, 40)
        Me.lbTime1StartMin.TabIndex = 27
        Me.lbTime1StartMin.Text = "00"
        Me.lbTime1StartMin.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime1StartMin.UseKeyPad = True
        '
        'lbTime2EndHour
        '
        Me.lbTime2EndHour.BackColor = System.Drawing.Color.White
        Me.lbTime2EndHour.BackImage = Nothing
        Me.lbTime2EndHour.BorderColor = System.Drawing.Color.Gray
        Me.lbTime2EndHour.BorderSide_Bottom = True
        Me.lbTime2EndHour.BorderSide_Left = True
        Me.lbTime2EndHour.BorderSide_Right = True
        Me.lbTime2EndHour.BorderSide_Top = True
        Me.lbTime2EndHour.BorderWidth = 1
        Me.lbTime2EndHour.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime2EndHour.IsPassword = False
        Me.lbTime2EndHour.Location = New System.Drawing.Point(644, 134)
        Me.lbTime2EndHour.MaxRange = 23
        Me.lbTime2EndHour.MinRange = 0
        Me.lbTime2EndHour.Name = "lbTime2EndHour"
        Me.lbTime2EndHour.Size = New System.Drawing.Size(41, 40)
        Me.lbTime2EndHour.TabIndex = 27
        Me.lbTime2EndHour.Text = "00"
        Me.lbTime2EndHour.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime2EndHour.UseKeyPad = True
        '
        'lbTime1EndHour
        '
        Me.lbTime1EndHour.BackColor = System.Drawing.Color.White
        Me.lbTime1EndHour.BackImage = Nothing
        Me.lbTime1EndHour.BorderColor = System.Drawing.Color.Gray
        Me.lbTime1EndHour.BorderSide_Bottom = True
        Me.lbTime1EndHour.BorderSide_Left = True
        Me.lbTime1EndHour.BorderSide_Right = True
        Me.lbTime1EndHour.BorderSide_Top = True
        Me.lbTime1EndHour.BorderWidth = 1
        Me.lbTime1EndHour.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime1EndHour.IsPassword = False
        Me.lbTime1EndHour.Location = New System.Drawing.Point(644, 88)
        Me.lbTime1EndHour.MaxRange = 23
        Me.lbTime1EndHour.MinRange = 0
        Me.lbTime1EndHour.Name = "lbTime1EndHour"
        Me.lbTime1EndHour.Size = New System.Drawing.Size(41, 40)
        Me.lbTime1EndHour.TabIndex = 27
        Me.lbTime1EndHour.Text = "00"
        Me.lbTime1EndHour.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime1EndHour.UseKeyPad = True
        '
        'lbTime2StartHour
        '
        Me.lbTime2StartHour.BackColor = System.Drawing.Color.White
        Me.lbTime2StartHour.BackImage = Nothing
        Me.lbTime2StartHour.BorderColor = System.Drawing.Color.Gray
        Me.lbTime2StartHour.BorderSide_Bottom = True
        Me.lbTime2StartHour.BorderSide_Left = True
        Me.lbTime2StartHour.BorderSide_Right = True
        Me.lbTime2StartHour.BorderSide_Top = True
        Me.lbTime2StartHour.BorderWidth = 1
        Me.lbTime2StartHour.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime2StartHour.IsPassword = False
        Me.lbTime2StartHour.Location = New System.Drawing.Point(496, 134)
        Me.lbTime2StartHour.MaxRange = 23
        Me.lbTime2StartHour.MinRange = 0
        Me.lbTime2StartHour.Name = "lbTime2StartHour"
        Me.lbTime2StartHour.Size = New System.Drawing.Size(41, 40)
        Me.lbTime2StartHour.TabIndex = 27
        Me.lbTime2StartHour.Text = "00"
        Me.lbTime2StartHour.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime2StartHour.UseKeyPad = True
        '
        'lbTime1StartHour
        '
        Me.lbTime1StartHour.BackColor = System.Drawing.Color.White
        Me.lbTime1StartHour.BackImage = Nothing
        Me.lbTime1StartHour.BorderColor = System.Drawing.Color.Gray
        Me.lbTime1StartHour.BorderSide_Bottom = True
        Me.lbTime1StartHour.BorderSide_Left = True
        Me.lbTime1StartHour.BorderSide_Right = True
        Me.lbTime1StartHour.BorderSide_Top = True
        Me.lbTime1StartHour.BorderWidth = 1
        Me.lbTime1StartHour.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbTime1StartHour.IsPassword = False
        Me.lbTime1StartHour.Location = New System.Drawing.Point(496, 88)
        Me.lbTime1StartHour.MaxRange = 23
        Me.lbTime1StartHour.MinRange = 0
        Me.lbTime1StartHour.Name = "lbTime1StartHour"
        Me.lbTime1StartHour.Size = New System.Drawing.Size(41, 40)
        Me.lbTime1StartHour.TabIndex = 27
        Me.lbTime1StartHour.Text = "00"
        Me.lbTime1StartHour.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbTime1StartHour.UseKeyPad = True
        '
        'VsLabel11
        '
        Me.VsLabel11.BackColor = System.Drawing.Color.White
        Me.VsLabel11.BackImage = Nothing
        Me.VsLabel11.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel11.BorderSide_Bottom = True
        Me.VsLabel11.BorderSide_Left = True
        Me.VsLabel11.BorderSide_Right = True
        Me.VsLabel11.BorderSide_Top = True
        Me.VsLabel11.BorderWidth = 0
        Me.VsLabel11.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel11.IsPassword = False
        Me.VsLabel11.Location = New System.Drawing.Point(224, 155)
        Me.VsLabel11.MaxRange = 0
        Me.VsLabel11.MinRange = 0
        Me.VsLabel11.Name = "VsLabel11"
        Me.VsLabel11.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel11.TabIndex = 27
        Me.VsLabel11.Text = "%"
        Me.VsLabel11.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel11.UseKeyPad = False
        '
        'lbPeakCut
        '
        Me.lbPeakCut.BackColor = System.Drawing.Color.White
        Me.lbPeakCut.BackImage = Nothing
        Me.lbPeakCut.BorderColor = System.Drawing.Color.Gray
        Me.lbPeakCut.BorderSide_Bottom = True
        Me.lbPeakCut.BorderSide_Left = True
        Me.lbPeakCut.BorderSide_Right = True
        Me.lbPeakCut.BorderSide_Top = True
        Me.lbPeakCut.BorderWidth = 1
        Me.lbPeakCut.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbPeakCut.IsPassword = False
        Me.lbPeakCut.Location = New System.Drawing.Point(160, 155)
        Me.lbPeakCut.MaxRange = 100
        Me.lbPeakCut.MinRange = 0
        Me.lbPeakCut.Name = "lbPeakCut"
        Me.lbPeakCut.Size = New System.Drawing.Size(58, 40)
        Me.lbPeakCut.TabIndex = 27
        Me.lbPeakCut.Text = "10"
        Me.lbPeakCut.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbPeakCut.UseKeyPad = True
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel2.BackImage = Nothing
        Me.VsLabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel2.BorderSide_Bottom = True
        Me.VsLabel2.BorderSide_Left = True
        Me.VsLabel2.BorderSide_Right = True
        Me.VsLabel2.BorderSide_Top = True
        Me.VsLabel2.BorderWidth = 1
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.IsPassword = False
        Me.VsLabel2.Location = New System.Drawing.Point(30, 155)
        Me.VsLabel2.MaxRange = 0
        Me.VsLabel2.MinRange = 0
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel2.TabIndex = 27
        Me.VsLabel2.Text = "피크컷"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel2.UseKeyPad = False
        '
        'VsLabel10
        '
        Me.VsLabel10.BackColor = System.Drawing.Color.White
        Me.VsLabel10.BackImage = Nothing
        Me.VsLabel10.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel10.BorderSide_Bottom = True
        Me.VsLabel10.BorderSide_Left = True
        Me.VsLabel10.BorderSide_Right = True
        Me.VsLabel10.BorderSide_Top = True
        Me.VsLabel10.BorderWidth = 0
        Me.VsLabel10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel10.IsPassword = False
        Me.VsLabel10.Location = New System.Drawing.Point(224, 88)
        Me.VsLabel10.MaxRange = 0
        Me.VsLabel10.MinRange = 0
        Me.VsLabel10.Name = "VsLabel10"
        Me.VsLabel10.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel10.TabIndex = 27
        Me.VsLabel10.Text = "%"
        Me.VsLabel10.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel10.UseKeyPad = False
        '
        'lbLoadPower
        '
        Me.lbLoadPower.BackColor = System.Drawing.Color.White
        Me.lbLoadPower.BackImage = Nothing
        Me.lbLoadPower.BorderColor = System.Drawing.Color.Gray
        Me.lbLoadPower.BorderSide_Bottom = True
        Me.lbLoadPower.BorderSide_Left = True
        Me.lbLoadPower.BorderSide_Right = True
        Me.lbLoadPower.BorderSide_Top = True
        Me.lbLoadPower.BorderWidth = 1
        Me.lbLoadPower.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbLoadPower.IsPassword = False
        Me.lbLoadPower.Location = New System.Drawing.Point(160, 88)
        Me.lbLoadPower.MaxRange = 100
        Me.lbLoadPower.MinRange = 0
        Me.lbLoadPower.Name = "lbLoadPower"
        Me.lbLoadPower.Size = New System.Drawing.Size(58, 40)
        Me.lbLoadPower.TabIndex = 27
        Me.lbLoadPower.Text = "10"
        Me.lbLoadPower.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbLoadPower.UseKeyPad = True
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel1.BackImage = Nothing
        Me.VsLabel1.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel1.BorderSide_Bottom = True
        Me.VsLabel1.BorderSide_Left = True
        Me.VsLabel1.BorderSide_Right = True
        Me.VsLabel1.BorderSide_Top = True
        Me.VsLabel1.BorderWidth = 1
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.IsPassword = False
        Me.VsLabel1.Location = New System.Drawing.Point(30, 88)
        Me.VsLabel1.MaxRange = 0
        Me.VsLabel1.MinRange = 0
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel1.TabIndex = 27
        Me.VsLabel1.Text = "로드 파워"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel1.UseKeyPad = False
        '
        'VsLabel13
        '
        Me.VsLabel13.BackColor = System.Drawing.Color.White
        Me.VsLabel13.BackImage = Nothing
        Me.VsLabel13.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel13.BorderSide_Bottom = True
        Me.VsLabel13.BorderSide_Left = True
        Me.VsLabel13.BorderSide_Right = True
        Me.VsLabel13.BorderSide_Top = True
        Me.VsLabel13.BorderWidth = 0
        Me.VsLabel13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel13.IsPassword = False
        Me.VsLabel13.Location = New System.Drawing.Point(359, 90)
        Me.VsLabel13.MaxRange = 0
        Me.VsLabel13.MinRange = 0
        Me.VsLabel13.Name = "VsLabel13"
        Me.VsLabel13.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel13.TabIndex = 27
        Me.VsLabel13.Text = "%"
        Me.VsLabel13.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel13.UseKeyPad = False
        '
        'lbBatteryCS
        '
        Me.lbBatteryCS.BackColor = System.Drawing.Color.White
        Me.lbBatteryCS.BackImage = Nothing
        Me.lbBatteryCS.BorderColor = System.Drawing.Color.Gray
        Me.lbBatteryCS.BorderSide_Bottom = True
        Me.lbBatteryCS.BorderSide_Left = True
        Me.lbBatteryCS.BorderSide_Right = True
        Me.lbBatteryCS.BorderSide_Top = True
        Me.lbBatteryCS.BorderWidth = 1
        Me.lbBatteryCS.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCS.IsPassword = False
        Me.lbBatteryCS.Location = New System.Drawing.Point(295, 90)
        Me.lbBatteryCS.MaxRange = 100
        Me.lbBatteryCS.MinRange = 0
        Me.lbBatteryCS.Name = "lbBatteryCS"
        Me.lbBatteryCS.Size = New System.Drawing.Size(58, 40)
        Me.lbBatteryCS.TabIndex = 27
        Me.lbBatteryCS.Text = "10"
        Me.lbBatteryCS.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCS.UseKeyPad = True
        '
        'VsLabel4
        '
        Me.VsLabel4.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel4.BackImage = Nothing
        Me.VsLabel4.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel4.BorderSide_Bottom = True
        Me.VsLabel4.BorderSide_Left = True
        Me.VsLabel4.BorderSide_Right = True
        Me.VsLabel4.BorderSide_Top = True
        Me.VsLabel4.BorderWidth = 1
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.IsPassword = False
        Me.VsLabel4.Location = New System.Drawing.Point(165, 90)
        Me.VsLabel4.MaxRange = 0
        Me.VsLabel4.MinRange = 0
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel4.TabIndex = 27
        Me.VsLabel4.Text = "충전 시작"
        Me.VsLabel4.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel4.UseKeyPad = False
        '
        'VsLabel12
        '
        Me.VsLabel12.BackColor = System.Drawing.Color.White
        Me.VsLabel12.BackImage = Nothing
        Me.VsLabel12.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel12.BorderSide_Bottom = True
        Me.VsLabel12.BorderSide_Left = True
        Me.VsLabel12.BorderSide_Right = True
        Me.VsLabel12.BorderSide_Top = True
        Me.VsLabel12.BorderWidth = 0
        Me.VsLabel12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel12.IsPassword = False
        Me.VsLabel12.Location = New System.Drawing.Point(359, 27)
        Me.VsLabel12.MaxRange = 0
        Me.VsLabel12.MinRange = 0
        Me.VsLabel12.Name = "VsLabel12"
        Me.VsLabel12.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel12.TabIndex = 27
        Me.VsLabel12.Text = "%"
        Me.VsLabel12.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel12.UseKeyPad = False
        '
        'lbBatteryFD
        '
        Me.lbBatteryFD.BackColor = System.Drawing.Color.White
        Me.lbBatteryFD.BackImage = Nothing
        Me.lbBatteryFD.BorderColor = System.Drawing.Color.Gray
        Me.lbBatteryFD.BorderSide_Bottom = True
        Me.lbBatteryFD.BorderSide_Left = True
        Me.lbBatteryFD.BorderSide_Right = True
        Me.lbBatteryFD.BorderSide_Top = True
        Me.lbBatteryFD.BorderWidth = 1
        Me.lbBatteryFD.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryFD.IsPassword = False
        Me.lbBatteryFD.Location = New System.Drawing.Point(295, 27)
        Me.lbBatteryFD.MaxRange = 100
        Me.lbBatteryFD.MinRange = 0
        Me.lbBatteryFD.Name = "lbBatteryFD"
        Me.lbBatteryFD.Size = New System.Drawing.Size(58, 40)
        Me.lbBatteryFD.TabIndex = 27
        Me.lbBatteryFD.Text = "10"
        Me.lbBatteryFD.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryFD.UseKeyPad = True
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel3.BackImage = Nothing
        Me.VsLabel3.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel3.BorderSide_Bottom = True
        Me.VsLabel3.BorderSide_Left = True
        Me.VsLabel3.BorderSide_Right = True
        Me.VsLabel3.BorderSide_Top = True
        Me.VsLabel3.BorderWidth = 1
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel3.IsPassword = False
        Me.VsLabel3.Location = New System.Drawing.Point(165, 27)
        Me.VsLabel3.MaxRange = 0
        Me.VsLabel3.MinRange = 0
        Me.VsLabel3.Name = "VsLabel3"
        Me.VsLabel3.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel3.TabIndex = 27
        Me.VsLabel3.Text = "방전 중지"
        Me.VsLabel3.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel3.UseKeyPad = False
        '
        'pnlScreen2
        '
        Me.pnlScreen2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen2.Controls.Add(Me.btnGridActivePower)
        Me.pnlScreen2.Controls.Add(Me.VsLabel30)
        Me.pnlScreen2.Controls.Add(Me.lbGridActivePower)
        Me.pnlScreen2.Controls.Add(Me.VsLabel32)
        Me.pnlScreen2.Location = New System.Drawing.Point(8, 336)
        Me.pnlScreen2.Name = "pnlScreen2"
        Me.pnlScreen2.Size = New System.Drawing.Size(784, 283)
        Me.pnlScreen2.TabIndex = 37
        '
        'btnGridActivePower
        '
        Me.btnGridActivePower.BackColor = System.Drawing.Color.White
        Me.btnGridActivePower.BackgroundImageValue = CType(resources.GetObject("btnGridActivePower.BackgroundImageValue"), System.Drawing.Image)
        Me.btnGridActivePower.BorderColor = System.Drawing.Color.Black
        Me.btnGridActivePower.BorderSide_Bottom = False
        Me.btnGridActivePower.BorderSide_Left = False
        Me.btnGridActivePower.BorderSide_Right = False
        Me.btnGridActivePower.BorderSide_Top = False
        Me.btnGridActivePower.BorderWidth = 0
        Me.btnGridActivePower.Location = New System.Drawing.Point(485, 112)
        Me.btnGridActivePower.Name = "btnGridActivePower"
        Me.btnGridActivePower.PressedImageValue = CType(resources.GetObject("btnGridActivePower.PressedImageValue"), System.Drawing.Image)
        Me.btnGridActivePower.Selected = False
        Me.btnGridActivePower.Size = New System.Drawing.Size(135, 58)
        Me.btnGridActivePower.TabIndex = 28
        '
        'VsLabel30
        '
        Me.VsLabel30.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel30.BackImage = Nothing
        Me.VsLabel30.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel30.BorderSide_Bottom = True
        Me.VsLabel30.BorderSide_Left = True
        Me.VsLabel30.BorderSide_Right = True
        Me.VsLabel30.BorderSide_Top = True
        Me.VsLabel30.BorderWidth = 1
        Me.VsLabel30.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel30.IsPassword = False
        Me.VsLabel30.Location = New System.Drawing.Point(165, 121)
        Me.VsLabel30.MaxRange = 0
        Me.VsLabel30.MinRange = 0
        Me.VsLabel30.Name = "VsLabel30"
        Me.VsLabel30.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel30.TabIndex = 27
        Me.VsLabel30.Text = "유효전력"
        Me.VsLabel30.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel30.UseKeyPad = False
        '
        'lbGridActivePower
        '
        Me.lbGridActivePower.BackColor = System.Drawing.Color.White
        Me.lbGridActivePower.BackImage = Nothing
        Me.lbGridActivePower.BorderColor = System.Drawing.Color.Gray
        Me.lbGridActivePower.BorderSide_Bottom = True
        Me.lbGridActivePower.BorderSide_Left = True
        Me.lbGridActivePower.BorderSide_Right = True
        Me.lbGridActivePower.BorderSide_Top = True
        Me.lbGridActivePower.BorderWidth = 1
        Me.lbGridActivePower.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbGridActivePower.IsPassword = False
        Me.lbGridActivePower.Location = New System.Drawing.Point(295, 121)
        Me.lbGridActivePower.MaxRange = 200
        Me.lbGridActivePower.MinRange = 0
        Me.lbGridActivePower.Name = "lbGridActivePower"
        Me.lbGridActivePower.Size = New System.Drawing.Size(100, 40)
        Me.lbGridActivePower.TabIndex = 27
        Me.lbGridActivePower.Text = "10"
        Me.lbGridActivePower.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbGridActivePower.UseKeyPad = True
        '
        'VsLabel32
        '
        Me.VsLabel32.BackColor = System.Drawing.Color.White
        Me.VsLabel32.BackImage = Nothing
        Me.VsLabel32.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel32.BorderSide_Bottom = True
        Me.VsLabel32.BorderSide_Left = True
        Me.VsLabel32.BorderSide_Right = True
        Me.VsLabel32.BorderSide_Top = True
        Me.VsLabel32.BorderWidth = 0
        Me.VsLabel32.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel32.IsPassword = False
        Me.VsLabel32.Location = New System.Drawing.Point(401, 121)
        Me.VsLabel32.MaxRange = 0
        Me.VsLabel32.MinRange = 0
        Me.VsLabel32.Name = "VsLabel32"
        Me.VsLabel32.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel32.TabIndex = 27
        Me.VsLabel32.Text = "kW"
        Me.VsLabel32.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel32.UseKeyPad = False
        '
        'pnlScreen3
        '
        Me.pnlScreen3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen3.Controls.Add(Me.btnGridReactivePower)
        Me.pnlScreen3.Controls.Add(Me.VsLabel33)
        Me.pnlScreen3.Controls.Add(Me.lbGridReactivePower)
        Me.pnlScreen3.Controls.Add(Me.VsLabel35)
        Me.pnlScreen3.Location = New System.Drawing.Point(798, 336)
        Me.pnlScreen3.Name = "pnlScreen3"
        Me.pnlScreen3.Size = New System.Drawing.Size(784, 283)
        Me.pnlScreen3.TabIndex = 36
        '
        'btnGridReactivePower
        '
        Me.btnGridReactivePower.BackColor = System.Drawing.Color.White
        Me.btnGridReactivePower.BackgroundImageValue = CType(resources.GetObject("btnGridReactivePower.BackgroundImageValue"), System.Drawing.Image)
        Me.btnGridReactivePower.BorderColor = System.Drawing.Color.Black
        Me.btnGridReactivePower.BorderSide_Bottom = False
        Me.btnGridReactivePower.BorderSide_Left = False
        Me.btnGridReactivePower.BorderSide_Right = False
        Me.btnGridReactivePower.BorderSide_Top = False
        Me.btnGridReactivePower.BorderWidth = 0
        Me.btnGridReactivePower.Location = New System.Drawing.Point(485, 112)
        Me.btnGridReactivePower.Name = "btnGridReactivePower"
        Me.btnGridReactivePower.PressedImageValue = CType(resources.GetObject("btnGridReactivePower.PressedImageValue"), System.Drawing.Image)
        Me.btnGridReactivePower.Selected = False
        Me.btnGridReactivePower.Size = New System.Drawing.Size(135, 58)
        Me.btnGridReactivePower.TabIndex = 32
        '
        'VsLabel33
        '
        Me.VsLabel33.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel33.BackImage = Nothing
        Me.VsLabel33.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel33.BorderSide_Bottom = True
        Me.VsLabel33.BorderSide_Left = True
        Me.VsLabel33.BorderSide_Right = True
        Me.VsLabel33.BorderSide_Top = True
        Me.VsLabel33.BorderWidth = 1
        Me.VsLabel33.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel33.IsPassword = False
        Me.VsLabel33.Location = New System.Drawing.Point(165, 121)
        Me.VsLabel33.MaxRange = 0
        Me.VsLabel33.MinRange = 0
        Me.VsLabel33.Name = "VsLabel33"
        Me.VsLabel33.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel33.TabIndex = 31
        Me.VsLabel33.Text = "무효전력"
        Me.VsLabel33.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel33.UseKeyPad = False
        '
        'lbGridReactivePower
        '
        Me.lbGridReactivePower.BackColor = System.Drawing.Color.White
        Me.lbGridReactivePower.BackImage = Nothing
        Me.lbGridReactivePower.BorderColor = System.Drawing.Color.Gray
        Me.lbGridReactivePower.BorderSide_Bottom = True
        Me.lbGridReactivePower.BorderSide_Left = True
        Me.lbGridReactivePower.BorderSide_Right = True
        Me.lbGridReactivePower.BorderSide_Top = True
        Me.lbGridReactivePower.BorderWidth = 1
        Me.lbGridReactivePower.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbGridReactivePower.IsPassword = False
        Me.lbGridReactivePower.Location = New System.Drawing.Point(295, 121)
        Me.lbGridReactivePower.MaxRange = 200
        Me.lbGridReactivePower.MinRange = 0
        Me.lbGridReactivePower.Name = "lbGridReactivePower"
        Me.lbGridReactivePower.Size = New System.Drawing.Size(100, 40)
        Me.lbGridReactivePower.TabIndex = 29
        Me.lbGridReactivePower.Text = "10"
        Me.lbGridReactivePower.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbGridReactivePower.UseKeyPad = True
        '
        'VsLabel35
        '
        Me.VsLabel35.BackColor = System.Drawing.Color.White
        Me.VsLabel35.BackImage = Nothing
        Me.VsLabel35.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel35.BorderSide_Bottom = True
        Me.VsLabel35.BorderSide_Left = True
        Me.VsLabel35.BorderSide_Right = True
        Me.VsLabel35.BorderSide_Top = True
        Me.VsLabel35.BorderWidth = 0
        Me.VsLabel35.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel35.IsPassword = False
        Me.VsLabel35.Location = New System.Drawing.Point(401, 121)
        Me.VsLabel35.MaxRange = 0
        Me.VsLabel35.MinRange = 0
        Me.VsLabel35.Name = "VsLabel35"
        Me.VsLabel35.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel35.TabIndex = 30
        Me.VsLabel35.Text = "kW"
        Me.VsLabel35.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel35.UseKeyPad = False
        '
        '타이머_상태
        '
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
        Me.PageHeader3.Location = New System.Drawing.Point(266, 8)
        Me.PageHeader3.MaxRange = 0
        Me.PageHeader3.MinRange = 0
        Me.PageHeader3.Name = "PageHeader3"
        Me.PageHeader3.Size = New System.Drawing.Size(129, 40)
        Me.PageHeader3.TabIndex = 33
        Me.PageHeader3.Text = "무효 전력"
        Me.PageHeader3.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader3.UseKeyPad = False
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
        Me.PageHeader2.Location = New System.Drawing.Point(137, 8)
        Me.PageHeader2.MaxRange = 0
        Me.PageHeader2.MinRange = 0
        Me.PageHeader2.Name = "PageHeader2"
        Me.PageHeader2.Size = New System.Drawing.Size(129, 40)
        Me.PageHeader2.TabIndex = 31
        Me.PageHeader2.Text = "유효 전력"
        Me.PageHeader2.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader2.UseKeyPad = False
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
        Me.PageHeader1.Location = New System.Drawing.Point(8, 8)
        Me.PageHeader1.MaxRange = 0
        Me.PageHeader1.MinRange = 0
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Size = New System.Drawing.Size(129, 40)
        Me.PageHeader1.TabIndex = 32
        Me.PageHeader1.Text = "피크 컷"
        Me.PageHeader1.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader1.UseKeyPad = False
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
        Me.PageHeader4.Location = New System.Drawing.Point(395, 8)
        Me.PageHeader4.MaxRange = 0
        Me.PageHeader4.MinRange = 0
        Me.PageHeader4.Name = "PageHeader4"
        Me.PageHeader4.Size = New System.Drawing.Size(129, 40)
        Me.PageHeader4.TabIndex = 35
        Me.PageHeader4.Text = "배터리"
        Me.PageHeader4.TextAlign = System.Drawing.StringAlignment.Center
        Me.PageHeader4.UseKeyPad = False
        '
        'pnlScreen4
        '
        Me.pnlScreen4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScreen4.Controls.Add(Me.btnBatteryCharging)
        Me.pnlScreen4.Controls.Add(Me.VsLabel3)
        Me.pnlScreen4.Controls.Add(Me.lbBatteryFD)
        Me.pnlScreen4.Controls.Add(Me.VsLabel12)
        Me.pnlScreen4.Controls.Add(Me.VsLabel39)
        Me.pnlScreen4.Controls.Add(Me.lbBatteryCV)
        Me.pnlScreen4.Controls.Add(Me.VsLabel36)
        Me.pnlScreen4.Controls.Add(Me.lbBatteryCC)
        Me.pnlScreen4.Controls.Add(Me.VsLabel37)
        Me.pnlScreen4.Controls.Add(Me.VsLabel4)
        Me.pnlScreen4.Controls.Add(Me.VsLabel31)
        Me.pnlScreen4.Controls.Add(Me.lbBatteryCS)
        Me.pnlScreen4.Controls.Add(Me.VsLabel13)
        Me.pnlScreen4.Location = New System.Drawing.Point(8, 625)
        Me.pnlScreen4.Name = "pnlScreen4"
        Me.pnlScreen4.Size = New System.Drawing.Size(784, 283)
        Me.pnlScreen4.TabIndex = 1
        '
        'btnBatteryCharging
        '
        Me.btnBatteryCharging.BackColor = System.Drawing.Color.Blue
        Me.btnBatteryCharging.BackgroundImageValue = CType(resources.GetObject("btnBatteryCharging.BackgroundImageValue"), System.Drawing.Image)
        Me.btnBatteryCharging.BorderColor = System.Drawing.Color.Gray
        Me.btnBatteryCharging.BorderSide_Bottom = True
        Me.btnBatteryCharging.BorderSide_Left = True
        Me.btnBatteryCharging.BorderSide_Right = True
        Me.btnBatteryCharging.BorderSide_Top = True
        Me.btnBatteryCharging.BorderWidth = 1
        Me.btnBatteryCharging.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatteryCharging.ForeColor = System.Drawing.Color.White
        Me.btnBatteryCharging.Location = New System.Drawing.Point(485, 116)
        Me.btnBatteryCharging.Name = "btnBatteryCharging"
        Me.btnBatteryCharging.PressedImageValue = CType(resources.GetObject("btnBatteryCharging.PressedImageValue"), System.Drawing.Image)
        Me.btnBatteryCharging.Selected = False
        Me.btnBatteryCharging.Size = New System.Drawing.Size(160, 50)
        Me.btnBatteryCharging.TabIndex = 35
        Me.btnBatteryCharging.Text = "적용"
        '
        'VsLabel39
        '
        Me.VsLabel39.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel39.BackImage = Nothing
        Me.VsLabel39.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel39.BorderSide_Bottom = True
        Me.VsLabel39.BorderSide_Left = True
        Me.VsLabel39.BorderSide_Right = True
        Me.VsLabel39.BorderSide_Top = True
        Me.VsLabel39.BorderWidth = 1
        Me.VsLabel39.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel39.IsPassword = False
        Me.VsLabel39.Location = New System.Drawing.Point(165, 216)
        Me.VsLabel39.MaxRange = 0
        Me.VsLabel39.MinRange = 0
        Me.VsLabel39.Name = "VsLabel39"
        Me.VsLabel39.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel39.TabIndex = 27
        Me.VsLabel39.Text = "충전 전압"
        Me.VsLabel39.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel39.UseKeyPad = False
        '
        'lbBatteryCV
        '
        Me.lbBatteryCV.BackColor = System.Drawing.Color.White
        Me.lbBatteryCV.BackImage = Nothing
        Me.lbBatteryCV.BorderColor = System.Drawing.Color.Gray
        Me.lbBatteryCV.BorderSide_Bottom = True
        Me.lbBatteryCV.BorderSide_Left = True
        Me.lbBatteryCV.BorderSide_Right = True
        Me.lbBatteryCV.BorderSide_Top = True
        Me.lbBatteryCV.BorderWidth = 1
        Me.lbBatteryCV.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCV.IsPassword = False
        Me.lbBatteryCV.Location = New System.Drawing.Point(295, 216)
        Me.lbBatteryCV.MaxRange = 1000
        Me.lbBatteryCV.MinRange = 0
        Me.lbBatteryCV.Name = "lbBatteryCV"
        Me.lbBatteryCV.Size = New System.Drawing.Size(58, 40)
        Me.lbBatteryCV.TabIndex = 27
        Me.lbBatteryCV.Text = "10"
        Me.lbBatteryCV.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCV.UseKeyPad = True
        '
        'VsLabel36
        '
        Me.VsLabel36.BackColor = System.Drawing.Color.LightGreen
        Me.VsLabel36.BackImage = Nothing
        Me.VsLabel36.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel36.BorderSide_Bottom = True
        Me.VsLabel36.BorderSide_Left = True
        Me.VsLabel36.BorderSide_Right = True
        Me.VsLabel36.BorderSide_Top = True
        Me.VsLabel36.BorderWidth = 1
        Me.VsLabel36.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel36.IsPassword = False
        Me.VsLabel36.Location = New System.Drawing.Point(165, 153)
        Me.VsLabel36.MaxRange = 0
        Me.VsLabel36.MinRange = 0
        Me.VsLabel36.Name = "VsLabel36"
        Me.VsLabel36.Size = New System.Drawing.Size(124, 40)
        Me.VsLabel36.TabIndex = 27
        Me.VsLabel36.Text = "충전 전류"
        Me.VsLabel36.TextAlign = System.Drawing.StringAlignment.Center
        Me.VsLabel36.UseKeyPad = False
        '
        'lbBatteryCC
        '
        Me.lbBatteryCC.BackColor = System.Drawing.Color.White
        Me.lbBatteryCC.BackImage = Nothing
        Me.lbBatteryCC.BorderColor = System.Drawing.Color.Gray
        Me.lbBatteryCC.BorderSide_Bottom = True
        Me.lbBatteryCC.BorderSide_Left = True
        Me.lbBatteryCC.BorderSide_Right = True
        Me.lbBatteryCC.BorderSide_Top = True
        Me.lbBatteryCC.BorderWidth = 1
        Me.lbBatteryCC.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbBatteryCC.IsPassword = False
        Me.lbBatteryCC.Location = New System.Drawing.Point(295, 153)
        Me.lbBatteryCC.MaxRange = 100
        Me.lbBatteryCC.MinRange = 0
        Me.lbBatteryCC.Name = "lbBatteryCC"
        Me.lbBatteryCC.Size = New System.Drawing.Size(58, 40)
        Me.lbBatteryCC.TabIndex = 27
        Me.lbBatteryCC.Text = "10"
        Me.lbBatteryCC.TextAlign = System.Drawing.StringAlignment.Center
        Me.lbBatteryCC.UseKeyPad = True
        '
        'VsLabel37
        '
        Me.VsLabel37.BackColor = System.Drawing.Color.White
        Me.VsLabel37.BackImage = Nothing
        Me.VsLabel37.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel37.BorderSide_Bottom = True
        Me.VsLabel37.BorderSide_Left = True
        Me.VsLabel37.BorderSide_Right = True
        Me.VsLabel37.BorderSide_Top = True
        Me.VsLabel37.BorderWidth = 0
        Me.VsLabel37.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel37.IsPassword = False
        Me.VsLabel37.Location = New System.Drawing.Point(359, 216)
        Me.VsLabel37.MaxRange = 0
        Me.VsLabel37.MinRange = 0
        Me.VsLabel37.Name = "VsLabel37"
        Me.VsLabel37.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel37.TabIndex = 27
        Me.VsLabel37.Text = "V"
        Me.VsLabel37.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel37.UseKeyPad = False
        '
        'VsLabel31
        '
        Me.VsLabel31.BackColor = System.Drawing.Color.White
        Me.VsLabel31.BackImage = Nothing
        Me.VsLabel31.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel31.BorderSide_Bottom = True
        Me.VsLabel31.BorderSide_Left = True
        Me.VsLabel31.BorderSide_Right = True
        Me.VsLabel31.BorderSide_Top = True
        Me.VsLabel31.BorderWidth = 0
        Me.VsLabel31.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel31.IsPassword = False
        Me.VsLabel31.Location = New System.Drawing.Point(359, 153)
        Me.VsLabel31.MaxRange = 0
        Me.VsLabel31.MinRange = 0
        Me.VsLabel31.Name = "VsLabel31"
        Me.VsLabel31.Size = New System.Drawing.Size(58, 40)
        Me.VsLabel31.TabIndex = 27
        Me.VsLabel31.Text = "A"
        Me.VsLabel31.TextAlign = System.Drawing.StringAlignment.Near
        Me.VsLabel31.UseKeyPad = False
        '
        'wnd서브화면5_사용모드
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlScreen4)
        Me.Controls.Add(Me.PageHeader4)
        Me.Controls.Add(Me.pnlScreen3)
        Me.Controls.Add(Me.pnlScreen2)
        Me.Controls.Add(Me.pnlScreen1)
        Me.Controls.Add(Me.PageHeader3)
        Me.Controls.Add(Me.PageHeader2)
        Me.Controls.Add(Me.PageHeader1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "wnd서브화면5_사용모드"
        Me.Size = New System.Drawing.Size(1592, 914)
        Me.pnlScreen1.ResumeLayout(False)
        Me.pnlScreen2.ResumeLayout(False)
        Me.pnlScreen3.ResumeLayout(False)
        Me.pnlScreen4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PageHeader3 As PMS.VSLabel
    Friend WithEvents PageHeader2 As PMS.VSLabel
    Friend WithEvents PageHeader1 As PMS.VSLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen1 As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen2 As System.Windows.Forms.Panel
    Friend WithEvents pnlScreen3 As System.Windows.Forms.Panel
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents VsLabel5 As PMS.VSLabel
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents VsLabel13 As PMS.VSLabel
    Friend WithEvents lbBatteryCS As PMS.VSLabel
    Friend WithEvents VsLabel12 As PMS.VSLabel
    Friend WithEvents lbBatteryFD As PMS.VSLabel
    Friend WithEvents VsLabel11 As PMS.VSLabel
    Friend WithEvents lbPeakCut As PMS.VSLabel
    Friend WithEvents VsLabel10 As PMS.VSLabel
    Friend WithEvents lbLoadPower As PMS.VSLabel
    Friend WithEvents VsLabel15 As PMS.VSLabel
    Friend WithEvents VsLabel14 As PMS.VSLabel
    Friend WithEvents VsLabel29 As PMS.VSLabel
    Friend WithEvents VsLabel19 As PMS.VSLabel
    Friend WithEvents VsLabel28 As PMS.VSLabel
    Friend WithEvents VsLabel22 As PMS.VSLabel
    Friend WithEvents VsLabel27 As PMS.VSLabel
    Friend WithEvents VsLabel18 As PMS.VSLabel
    Friend WithEvents lbTime2EndMin As PMS.VSLabel
    Friend WithEvents lbTime1EndMin As PMS.VSLabel
    Friend WithEvents lbTime2StartMin As PMS.VSLabel
    Friend WithEvents lbTime1StartMin As PMS.VSLabel
    Friend WithEvents lbTime2EndHour As PMS.VSLabel
    Friend WithEvents lbTime1EndHour As PMS.VSLabel
    Friend WithEvents lbTime2StartHour As PMS.VSLabel
    Friend WithEvents lbTime1StartHour As PMS.VSLabel
    Friend WithEvents VsLabel30 As PMS.VSLabel
    Friend WithEvents lbGridActivePower As PMS.VSLabel
    Friend WithEvents VsLabel32 As PMS.VSLabel
    Friend WithEvents btnGridActivePower As PMS.VSPictureButton
    Friend WithEvents btnGridReactivePower As PMS.VSPictureButton
    Friend WithEvents VsLabel33 As PMS.VSLabel
    Friend WithEvents lbGridReactivePower As PMS.VSLabel
    Friend WithEvents VsLabel35 As PMS.VSLabel
    Friend WithEvents PageHeader4 As PMS.VSLabel
    Friend WithEvents pnlScreen4 As System.Windows.Forms.Panel
    Friend WithEvents VsLabel39 As PMS.VSLabel
    Friend WithEvents lbBatteryCV As PMS.VSLabel
    Friend WithEvents VsLabel36 As PMS.VSLabel
    Friend WithEvents lbBatteryCC As PMS.VSLabel
    Friend WithEvents VsLabel37 As PMS.VSLabel
    Friend WithEvents VsLabel31 As PMS.VSLabel
    Friend WithEvents btnPeakCutSet As PMS.VSPictureButton
    Friend WithEvents btnBatteryCharging As PMS.VSPictureButton

End Class

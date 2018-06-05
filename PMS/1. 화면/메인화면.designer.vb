<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class 메인화면
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(메인화면))
        Me.타이머_상태 = New System.Windows.Forms.Timer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.VsPictureButton8 = New PMS.VSPictureButton
        Me.버튼_화면전환_설정 = New PMS.VSPictureButton
        Me.버튼_화면전환_이력 = New PMS.VSPictureButton
        Me.버튼_화면전환_사용모드 = New PMS.VSPictureButton
        Me.버튼_화면전환_소비 = New PMS.VSPictureButton
        Me.버튼_화면전환_수요관리 = New PMS.VSPictureButton
        Me.버튼_화면전환_배터리 = New PMS.VSPictureButton
        Me.버튼_화면전환_메인 = New PMS.VSPictureButton
        Me.판넬_통신상태 = New System.Windows.Forms.Panel
        Me.VsLabel4 = New PMS.VSLabel
        Me.VsLabel5 = New PMS.VSLabel
        Me.pbMETER = New System.Windows.Forms.PictureBox
        Me.pbBMS = New System.Windows.Forms.PictureBox
        Me.VsLabel2 = New PMS.VSLabel
        Me.VsLabel1 = New PMS.VSLabel
        Me.pbEMS = New System.Windows.Forms.PictureBox
        Me.pbPCS = New System.Windows.Forms.PictureBox
        Me.라벨_시스템시간 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlWorkArea = New System.Windows.Forms.Panel
        Me.Uc서브화면8_고장1 = New PMS.wnd서브화면8_고장
        Me.Uc서브화면6_이력1 = New PMS.wnd서브화면6_이력
        Me.Uc서브화면5_사용모드1 = New PMS.wnd서브화면5_사용모드
        Me.Uc서브화면4_소비1 = New PMS.wnd서브화면4_소비
        Me.Uc서브화면3_수요관리1 = New PMS.wnd서브화면3_수요관리
        Me.Uc서브화면7_설정1 = New PMS.wnd서브화면7_설정
        Me.Uc서브화면2_배터리1 = New PMS.wnd서브화면2_배터리
        Me.Uc서브화면1_메인1 = New PMS.wnd서브화면1_메인
        Me.SmartConfigs1 = New SmartX.SmartConfigs
        Me.SmartRemote1 = New SmartX.SmartRemote(Me.components)
        Me.SmartWatchDog1 = New SmartX.SmartWatchDog
        Me.타이머_통신상태 = New System.Windows.Forms.Timer
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.화면_고장 = New System.Windows.Forms.Panel
        Me.VsPictureButton1 = New PMS.VSPictureButton
        Me.VsLabel3 = New PMS.VSLabel
        Me.SerialPort_Debug = New System.IO.Ports.SerialPort(Me.components)
        Me.타이머_사용모드 = New System.Windows.Forms.Timer
        Me.Panel1.SuspendLayout()
        Me.판넬_통신상태.SuspendLayout()
        Me.pnlWorkArea.SuspendLayout()
        Me.화면_고장.SuspendLayout()
        Me.SuspendLayout()
        '
        '타이머_상태
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VsPictureButton8)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_설정)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_이력)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_사용모드)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_소비)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_수요관리)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_배터리)
        Me.Panel1.Controls.Add(Me.버튼_화면전환_메인)
        Me.Panel1.Controls.Add(Me.판넬_통신상태)
        Me.Panel1.Controls.Add(Me.pnlWorkArea)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 480)
        '
        'VsPictureButton8
        '
        Me.VsPictureButton8.BackgroundImageValue = CType(resources.GetObject("VsPictureButton8.BackgroundImageValue"), System.Drawing.Image)
        Me.VsPictureButton8.BorderColor = System.Drawing.Color.Gray
        Me.VsPictureButton8.BorderSide_Bottom = False
        Me.VsPictureButton8.BorderSide_Left = False
        Me.VsPictureButton8.BorderSide_Right = False
        Me.VsPictureButton8.BorderSide_Top = False
        Me.VsPictureButton8.BorderWidth = 0
        Me.VsPictureButton8.Location = New System.Drawing.Point(700, 377)
        Me.VsPictureButton8.Name = "VsPictureButton8"
        Me.VsPictureButton8.PressedImageValue = CType(resources.GetObject("VsPictureButton8.PressedImageValue"), System.Drawing.Image)
        Me.VsPictureButton8.Selected = False
        Me.VsPictureButton8.Size = New System.Drawing.Size(100, 102)
        Me.VsPictureButton8.TabIndex = 9
        '
        '버튼_화면전환_설정
        '
        Me.버튼_화면전환_설정.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_설정.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_설정.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_설정.BorderSide_Bottom = False
        Me.버튼_화면전환_설정.BorderSide_Left = False
        Me.버튼_화면전환_설정.BorderSide_Right = False
        Me.버튼_화면전환_설정.BorderSide_Top = False
        Me.버튼_화면전환_설정.BorderWidth = 0
        Me.버튼_화면전환_설정.Location = New System.Drawing.Point(600, 377)
        Me.버튼_화면전환_설정.Name = "버튼_화면전환_설정"
        Me.버튼_화면전환_설정.PressedImageValue = CType(resources.GetObject("버튼_화면전환_설정.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_설정.Selected = False
        Me.버튼_화면전환_설정.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_설정.TabIndex = 8
        '
        '버튼_화면전환_이력
        '
        Me.버튼_화면전환_이력.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_이력.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_이력.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_이력.BorderSide_Bottom = False
        Me.버튼_화면전환_이력.BorderSide_Left = False
        Me.버튼_화면전환_이력.BorderSide_Right = False
        Me.버튼_화면전환_이력.BorderSide_Top = False
        Me.버튼_화면전환_이력.BorderWidth = 0
        Me.버튼_화면전환_이력.Location = New System.Drawing.Point(500, 377)
        Me.버튼_화면전환_이력.Name = "버튼_화면전환_이력"
        Me.버튼_화면전환_이력.PressedImageValue = CType(resources.GetObject("버튼_화면전환_이력.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_이력.Selected = False
        Me.버튼_화면전환_이력.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_이력.TabIndex = 7
        '
        '버튼_화면전환_사용모드
        '
        Me.버튼_화면전환_사용모드.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_사용모드.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_사용모드.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_사용모드.BorderSide_Bottom = False
        Me.버튼_화면전환_사용모드.BorderSide_Left = False
        Me.버튼_화면전환_사용모드.BorderSide_Right = False
        Me.버튼_화면전환_사용모드.BorderSide_Top = False
        Me.버튼_화면전환_사용모드.BorderWidth = 0
        Me.버튼_화면전환_사용모드.Location = New System.Drawing.Point(400, 377)
        Me.버튼_화면전환_사용모드.Name = "버튼_화면전환_사용모드"
        Me.버튼_화면전환_사용모드.PressedImageValue = CType(resources.GetObject("버튼_화면전환_사용모드.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_사용모드.Selected = False
        Me.버튼_화면전환_사용모드.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_사용모드.TabIndex = 6
        '
        '버튼_화면전환_소비
        '
        Me.버튼_화면전환_소비.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_소비.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_소비.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_소비.BorderSide_Bottom = False
        Me.버튼_화면전환_소비.BorderSide_Left = False
        Me.버튼_화면전환_소비.BorderSide_Right = False
        Me.버튼_화면전환_소비.BorderSide_Top = False
        Me.버튼_화면전환_소비.BorderWidth = 0
        Me.버튼_화면전환_소비.Location = New System.Drawing.Point(300, 377)
        Me.버튼_화면전환_소비.Name = "버튼_화면전환_소비"
        Me.버튼_화면전환_소비.PressedImageValue = CType(resources.GetObject("버튼_화면전환_소비.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_소비.Selected = False
        Me.버튼_화면전환_소비.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_소비.TabIndex = 5
        '
        '버튼_화면전환_수요관리
        '
        Me.버튼_화면전환_수요관리.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_수요관리.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_수요관리.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_수요관리.BorderSide_Bottom = False
        Me.버튼_화면전환_수요관리.BorderSide_Left = False
        Me.버튼_화면전환_수요관리.BorderSide_Right = False
        Me.버튼_화면전환_수요관리.BorderSide_Top = False
        Me.버튼_화면전환_수요관리.BorderWidth = 0
        Me.버튼_화면전환_수요관리.Location = New System.Drawing.Point(200, 377)
        Me.버튼_화면전환_수요관리.Name = "버튼_화면전환_수요관리"
        Me.버튼_화면전환_수요관리.PressedImageValue = CType(resources.GetObject("버튼_화면전환_수요관리.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_수요관리.Selected = False
        Me.버튼_화면전환_수요관리.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_수요관리.TabIndex = 4
        '
        '버튼_화면전환_배터리
        '
        Me.버튼_화면전환_배터리.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_배터리.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_배터리.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_배터리.BorderSide_Bottom = False
        Me.버튼_화면전환_배터리.BorderSide_Left = False
        Me.버튼_화면전환_배터리.BorderSide_Right = False
        Me.버튼_화면전환_배터리.BorderSide_Top = False
        Me.버튼_화면전환_배터리.BorderWidth = 0
        Me.버튼_화면전환_배터리.Location = New System.Drawing.Point(100, 377)
        Me.버튼_화면전환_배터리.Name = "버튼_화면전환_배터리"
        Me.버튼_화면전환_배터리.PressedImageValue = CType(resources.GetObject("버튼_화면전환_배터리.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_배터리.Selected = False
        Me.버튼_화면전환_배터리.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_배터리.TabIndex = 3
        '
        '버튼_화면전환_메인
        '
        Me.버튼_화면전환_메인.BackgroundImageValue = CType(resources.GetObject("버튼_화면전환_메인.BackgroundImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_메인.BorderColor = System.Drawing.Color.Gray
        Me.버튼_화면전환_메인.BorderSide_Bottom = False
        Me.버튼_화면전환_메인.BorderSide_Left = False
        Me.버튼_화면전환_메인.BorderSide_Right = False
        Me.버튼_화면전환_메인.BorderSide_Top = False
        Me.버튼_화면전환_메인.BorderWidth = 0
        Me.버튼_화면전환_메인.Location = New System.Drawing.Point(0, 377)
        Me.버튼_화면전환_메인.Name = "버튼_화면전환_메인"
        Me.버튼_화면전환_메인.PressedImageValue = CType(resources.GetObject("버튼_화면전환_메인.PressedImageValue"), System.Drawing.Image)
        Me.버튼_화면전환_메인.Selected = False
        Me.버튼_화면전환_메인.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_메인.TabIndex = 3
        '
        '판넬_통신상태
        '
        Me.판넬_통신상태.BackColor = System.Drawing.Color.White
        Me.판넬_통신상태.Controls.Add(Me.VsLabel4)
        Me.판넬_통신상태.Controls.Add(Me.VsLabel5)
        Me.판넬_통신상태.Controls.Add(Me.pbMETER)
        Me.판넬_통신상태.Controls.Add(Me.pbBMS)
        Me.판넬_통신상태.Controls.Add(Me.VsLabel2)
        Me.판넬_통신상태.Controls.Add(Me.VsLabel1)
        Me.판넬_통신상태.Controls.Add(Me.pbEMS)
        Me.판넬_통신상태.Controls.Add(Me.pbPCS)
        Me.판넬_통신상태.Controls.Add(Me.라벨_시스템시간)
        Me.판넬_통신상태.Controls.Add(Me.Label1)
        Me.판넬_통신상태.Location = New System.Drawing.Point(0, 0)
        Me.판넬_통신상태.Name = "판넬_통신상태"
        Me.판넬_통신상태.Size = New System.Drawing.Size(800, 40)
        '
        'VsLabel4
        '
        Me.VsLabel4.BackColor = System.Drawing.Color.White
        Me.VsLabel4.BorderWidth = 0
        Me.VsLabel4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel4.Location = New System.Drawing.Point(570, 2)
        Me.VsLabel4.Name = "VsLabel4"
        Me.VsLabel4.Size = New System.Drawing.Size(87, 34)
        Me.VsLabel4.TabIndex = 9
        Me.VsLabel4.Text = "METER :"
        Me.VsLabel4.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel5
        '
        Me.VsLabel5.BackColor = System.Drawing.Color.White
        Me.VsLabel5.BorderWidth = 0
        Me.VsLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel5.Location = New System.Drawing.Point(213, 2)
        Me.VsLabel5.Name = "VsLabel5"
        Me.VsLabel5.Size = New System.Drawing.Size(59, 34)
        Me.VsLabel5.TabIndex = 3
        Me.VsLabel5.Text = "BMS :"
        Me.VsLabel5.TextAlign = System.Drawing.StringAlignment.Far
        '
        'pbMETER
        '
        Me.pbMETER.Image = CType(resources.GetObject("pbMETER.Image"), System.Drawing.Image)
        Me.pbMETER.Location = New System.Drawing.Point(663, 2)
        Me.pbMETER.Name = "pbMETER"
        Me.pbMETER.Size = New System.Drawing.Size(47, 34)
        Me.pbMETER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'pbBMS
        '
        Me.pbBMS.Image = CType(resources.GetObject("pbBMS.Image"), System.Drawing.Image)
        Me.pbBMS.Location = New System.Drawing.Point(278, 2)
        Me.pbBMS.Name = "pbBMS"
        Me.pbBMS.Size = New System.Drawing.Size(47, 34)
        Me.pbBMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.White
        Me.VsLabel2.BorderWidth = 0
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.Location = New System.Drawing.Point(452, 3)
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(59, 34)
        Me.VsLabel2.TabIndex = 0
        Me.VsLabel2.Text = " EMS :"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Far
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.White
        Me.VsLabel1.BorderWidth = 0
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.Location = New System.Drawing.Point(334, 3)
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(59, 34)
        Me.VsLabel1.TabIndex = 1
        Me.VsLabel1.Text = "PCS :"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Far
        '
        'pbEMS
        '
        Me.pbEMS.Image = CType(resources.GetObject("pbEMS.Image"), System.Drawing.Image)
        Me.pbEMS.Location = New System.Drawing.Point(517, 3)
        Me.pbEMS.Name = "pbEMS"
        Me.pbEMS.Size = New System.Drawing.Size(47, 34)
        Me.pbEMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'pbPCS
        '
        Me.pbPCS.Image = CType(resources.GetObject("pbPCS.Image"), System.Drawing.Image)
        Me.pbPCS.Location = New System.Drawing.Point(399, 3)
        Me.pbPCS.Name = "pbPCS"
        Me.pbPCS.Size = New System.Drawing.Size(47, 34)
        Me.pbPCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        '라벨_시스템시간
        '
        Me.라벨_시스템시간.Location = New System.Drawing.Point(692, 5)
        Me.라벨_시스템시간.Name = "라벨_시스템시간"
        Me.라벨_시스템시간.Size = New System.Drawing.Size(105, 31)
        Me.라벨_시스템시간.Text = "오후 4:33:48"
        Me.라벨_시스템시간.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 31)
        Me.Label1.Text = "GBESS-99K"
        '
        'pnlWorkArea
        '
        Me.pnlWorkArea.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면8_고장1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면6_이력1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면5_사용모드1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면4_소비1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면3_수요관리1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면7_설정1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면2_배터리1)
        Me.pnlWorkArea.Controls.Add(Me.Uc서브화면1_메인1)
        Me.pnlWorkArea.Location = New System.Drawing.Point(0, 40)
        Me.pnlWorkArea.Name = "pnlWorkArea"
        Me.pnlWorkArea.Size = New System.Drawing.Size(800, 338)
        '
        'Uc서브화면8_고장1
        '
        Me.Uc서브화면8_고장1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면8_고장1.Location = New System.Drawing.Point(440, 158)
        Me.Uc서브화면8_고장1.Name = "Uc서브화면8_고장1"
        Me.Uc서브화면8_고장1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면8_고장1.TabIndex = 7
        '
        'Uc서브화면6_이력1
        '
        Me.Uc서브화면6_이력1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면6_이력1.Location = New System.Drawing.Point(160, 158)
        Me.Uc서브화면6_이력1.Name = "Uc서브화면6_이력1"
        Me.Uc서브화면6_이력1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면6_이력1.TabIndex = 6
        '
        'Uc서브화면5_사용모드1
        '
        Me.Uc서브화면5_사용모드1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면5_사용모드1.Location = New System.Drawing.Point(20, 158)
        Me.Uc서브화면5_사용모드1.Name = "Uc서브화면5_사용모드1"
        Me.Uc서브화면5_사용모드1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면5_사용모드1.TabIndex = 5
        '
        'Uc서브화면4_소비1
        '
        Me.Uc서브화면4_소비1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면4_소비1.Location = New System.Drawing.Point(440, 27)
        Me.Uc서브화면4_소비1.Name = "Uc서브화면4_소비1"
        Me.Uc서브화면4_소비1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면4_소비1.TabIndex = 4
        '
        'Uc서브화면3_수요관리1
        '
        Me.Uc서브화면3_수요관리1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면3_수요관리1.Location = New System.Drawing.Point(300, 27)
        Me.Uc서브화면3_수요관리1.Name = "Uc서브화면3_수요관리1"
        Me.Uc서브화면3_수요관리1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면3_수요관리1.TabIndex = 3
        '
        'Uc서브화면7_설정1
        '
        Me.Uc서브화면7_설정1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면7_설정1.Location = New System.Drawing.Point(300, 158)
        Me.Uc서브화면7_설정1.Name = "Uc서브화면7_설정1"
        Me.Uc서브화면7_설정1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면7_설정1.TabIndex = 2
        '
        'Uc서브화면2_배터리1
        '
        Me.Uc서브화면2_배터리1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면2_배터리1.Location = New System.Drawing.Point(160, 27)
        Me.Uc서브화면2_배터리1.Name = "Uc서브화면2_배터리1"
        Me.Uc서브화면2_배터리1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면2_배터리1.TabIndex = 1
        '
        'Uc서브화면1_메인1
        '
        Me.Uc서브화면1_메인1.BackColor = System.Drawing.Color.White
        Me.Uc서브화면1_메인1.Location = New System.Drawing.Point(20, 27)
        Me.Uc서브화면1_메인1.Name = "Uc서브화면1_메인1"
        Me.Uc서브화면1_메인1.Size = New System.Drawing.Size(100, 100)
        Me.Uc서브화면1_메인1.TabIndex = 0
        '
        'SmartRemote1
        '
        Me.SmartRemote1.AdminPassword = "12345"
        Me.SmartRemote1.ErrorMsgBoxShow = True
        Me.SmartRemote1.GuestPassword = "11111"
        Me.SmartRemote1.RefreshIntervalTime = 500
        Me.SmartRemote1.TCPPortNo = 7070
        '
        'SmartWatchDog1
        '
        Me.SmartWatchDog1.DebugMode = False
        Me.SmartWatchDog1.RebootInterval = CType(0, Long)
        '
        '타이머_통신상태
        '
        '
        'ListView1
        '
        Me.ListView1.Columns.Add(Me.ColumnHeader1)
        Me.ListView1.Columns.Add(Me.ColumnHeader2)
        Me.ListView1.Columns.Add(Me.ColumnHeader3)
        Me.ListView1.Columns.Add(Me.ColumnHeader4)
        Me.ListView1.Columns.Add(Me.ColumnHeader5)
        Me.ListView1.Columns.Add(Me.ColumnHeader6)
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(3, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(744, 356)
        Me.ListView1.TabIndex = 3
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
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CODE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 60
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "고장내용"
        Me.ColumnHeader5.Width = 320
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "상태"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        '화면_고장
        '
        Me.화면_고장.BackColor = System.Drawing.Color.WhiteSmoke
        Me.화면_고장.Controls.Add(Me.ListView1)
        Me.화면_고장.Controls.Add(Me.VsPictureButton1)
        Me.화면_고장.Controls.Add(Me.VsLabel3)
        Me.화면_고장.Location = New System.Drawing.Point(823, 5)
        Me.화면_고장.Name = "화면_고장"
        Me.화면_고장.Size = New System.Drawing.Size(750, 440)
        '
        'VsPictureButton1
        '
        Me.VsPictureButton1.BorderColor = System.Drawing.Color.Gray
        Me.VsPictureButton1.BorderSide_Bottom = True
        Me.VsPictureButton1.BorderSide_Left = True
        Me.VsPictureButton1.BorderSide_Right = True
        Me.VsPictureButton1.BorderSide_Top = True
        Me.VsPictureButton1.BorderWidth = 1
        Me.VsPictureButton1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsPictureButton1.Location = New System.Drawing.Point(306, 402)
        Me.VsPictureButton1.Name = "VsPictureButton1"
        Me.VsPictureButton1.Size = New System.Drawing.Size(138, 30)
        Me.VsPictureButton1.TabIndex = 2
        Me.VsPictureButton1.Text = "확인"
        '
        'VsLabel3
        '
        Me.VsLabel3.BackColor = System.Drawing.Color.Red
        Me.VsLabel3.BorderColor = System.Drawing.Color.DarkGray
        Me.VsLabel3.BorderSide_Bottom = True
        Me.VsLabel3.BorderSide_Left = True
        Me.VsLabel3.BorderSide_Right = True
        Me.VsLabel3.BorderSide_Top = True
        Me.VsLabel3.BorderWidth = 1
        Me.VsLabel3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel3.ForeColor = System.Drawing.Color.White
        Me.VsLabel3.Location = New System.Drawing.Point(3, 3)
        Me.VsLabel3.Name = "VsLabel3"
        Me.VsLabel3.Size = New System.Drawing.Size(744, 31)
        Me.VsLabel3.TabIndex = 1
        Me.VsLabel3.Text = "고장 발생 현황"
        Me.VsLabel3.TextAlign = System.Drawing.StringAlignment.Center
        '
        'SerialPort_Debug
        '
        '
        '타이머_사용모드
        '
        Me.타이머_사용모드.Interval = 2000
        '
        '메인화면
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1556, 510)
        Me.Controls.Add(Me.화면_고장)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "메인화면"
        Me.Text = "PMS"
        Me.Panel1.ResumeLayout(False)
        Me.판넬_통신상태.ResumeLayout(False)
        Me.pnlWorkArea.ResumeLayout(False)
        Me.화면_고장.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlWorkArea As System.Windows.Forms.Panel
    Friend WithEvents Uc서브화면2_배터리1 As PMS.wnd서브화면2_배터리
    Friend WithEvents Uc서브화면1_메인1 As PMS.wnd서브화면1_메인
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents 라벨_시스템시간 As System.Windows.Forms.Label
    Friend WithEvents SmartConfigs1 As SmartX.SmartConfigs
    Friend WithEvents SmartRemote1 As SmartX.SmartRemote
    Private WithEvents SmartWatchDog1 As SmartX.SmartWatchDog
    Friend WithEvents Uc서브화면7_설정1 As PMS.wnd서브화면7_설정
    Friend WithEvents pbEMS As System.Windows.Forms.PictureBox
    Friend WithEvents pbPCS As System.Windows.Forms.PictureBox
    Friend WithEvents 타이머_통신상태 As System.Windows.Forms.Timer
    Friend WithEvents Uc서브화면8_고장1 As PMS.wnd서브화면8_고장
    Friend WithEvents Uc서브화면6_이력1 As PMS.wnd서브화면6_이력
    Friend WithEvents Uc서브화면5_사용모드1 As PMS.wnd서브화면5_사용모드
    Friend WithEvents Uc서브화면4_소비1 As PMS.wnd서브화면4_소비
    Friend WithEvents Uc서브화면3_수요관리1 As PMS.wnd서브화면3_수요관리
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents 판넬_통신상태 As System.Windows.Forms.Panel
    Friend WithEvents 버튼_화면전환_메인 As PMS.VSPictureButton
    Friend WithEvents VsPictureButton8 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_설정 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_이력 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_사용모드 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_소비 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_수요관리 As PMS.VSPictureButton
    Friend WithEvents 버튼_화면전환_배터리 As PMS.VSPictureButton
    Friend WithEvents VsPictureButton1 As PMS.VSPictureButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents VsLabel3 As PMS.VSLabel
    Friend WithEvents 화면_고장 As System.Windows.Forms.Panel
    Friend WithEvents SerialPort_Debug As System.IO.Ports.SerialPort
    Friend WithEvents 타이머_사용모드 As System.Windows.Forms.Timer
    Friend WithEvents VsLabel5 As PMS.VSLabel
    Friend WithEvents pbBMS As System.Windows.Forms.PictureBox
    Friend WithEvents VsLabel4 As PMS.VSLabel
    Friend WithEvents pbMETER As System.Windows.Forms.PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 메인화면
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(메인화면))
        Me.판넬_통신상태 = New System.Windows.Forms.Panel
        Me.VsLabel2 = New PMS.VSLabel
        Me.VsLabel1 = New PMS.VSLabel
        Me.pbEMS = New System.Windows.Forms.PictureBox
        Me.pbPCS = New System.Windows.Forms.PictureBox
        Me.라벨_시스템시간 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Wnd서브화면8_고장1 = New PMS.wnd서브화면8_고장
        Me.Wnd서브화면6_이력1 = New PMS.wnd서브화면6_이력
        Me.Wnd서브화면5_사용모드1 = New PMS.wnd서브화면5_사용모드
        Me.Wnd서브화면4_소비1 = New PMS.wnd서브화면4_소비
        Me.Wnd서브화면3_수요관리1 = New PMS.wnd서브화면3_수요관리
        Me.Wnd서브화면2_배터리1 = New PMS.wnd서브화면2_배터리
        Me.Wnd서브화면7_설정1 = New PMS.wnd서브화면7_설정
        Me.Wnd서브화면1_메인1 = New PMS.wnd서브화면1_메인
        Me.타이머_상태 = New System.Windows.Forms.Timer(Me.components)
        Me.타이머_통신상태 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort_Debug = New System.IO.Ports.SerialPort(Me.components)
        Me.타이머_사용모드 = New System.Windows.Forms.Timer(Me.components)
        Me.SmartWatchDog1 = New SmartX.SmartWatchDog
        Me.SmartRemote1 = New SmartX.SmartRemote(Me.components)
        Me.SmartConfigs1 = New SmartX.SmartConfigs
        Me.VsPictureButton8 = New System.Windows.Forms.Button
        Me.버튼_화면전환_설정 = New System.Windows.Forms.Button
        Me.버튼_화면전환_이력 = New System.Windows.Forms.Button
        Me.버튼_화면전환_사용모드 = New System.Windows.Forms.Button
        Me.버튼_화면전환_소비 = New System.Windows.Forms.Button
        Me.버튼_화면전환_수요관리 = New System.Windows.Forms.Button
        Me.버튼_화면전환_배터리 = New System.Windows.Forms.Button
        Me.버튼_화면전환_메인 = New System.Windows.Forms.Button
        Me.판넬_통신상태.SuspendLayout()
        CType(Me.pbEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '판넬_통신상태
        '
        Me.판넬_통신상태.BackColor = System.Drawing.Color.White
        Me.판넬_통신상태.Controls.Add(Me.VsLabel2)
        Me.판넬_통신상태.Controls.Add(Me.VsLabel1)
        Me.판넬_통신상태.Controls.Add(Me.pbEMS)
        Me.판넬_통신상태.Controls.Add(Me.pbPCS)
        Me.판넬_통신상태.Controls.Add(Me.라벨_시스템시간)
        Me.판넬_통신상태.Controls.Add(Me.Label1)
        Me.판넬_통신상태.Location = New System.Drawing.Point(2, 3)
        Me.판넬_통신상태.Name = "판넬_통신상태"
        Me.판넬_통신상태.Size = New System.Drawing.Size(800, 40)
        Me.판넬_통신상태.TabIndex = 1
        '
        'VsLabel2
        '
        Me.VsLabel2.BackColor = System.Drawing.Color.White
        Me.VsLabel2.BackImage = Nothing
        Me.VsLabel2.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel2.BorderSide_Bottom = True
        Me.VsLabel2.BorderSide_Left = True
        Me.VsLabel2.BorderSide_Right = True
        Me.VsLabel2.BorderSide_Top = True
        Me.VsLabel2.BorderWidth = 0
        Me.VsLabel2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel2.IsPassword = False
        Me.VsLabel2.Location = New System.Drawing.Point(575, 3)
        Me.VsLabel2.MaxRange = 0
        Me.VsLabel2.MinRange = 0
        Me.VsLabel2.Name = "VsLabel2"
        Me.VsLabel2.Size = New System.Drawing.Size(59, 34)
        Me.VsLabel2.TabIndex = 0
        Me.VsLabel2.Text = " EMS :"
        Me.VsLabel2.TextAlign = System.Drawing.StringAlignment.Far
        Me.VsLabel2.UseKeyPad = False
        '
        'VsLabel1
        '
        Me.VsLabel1.BackColor = System.Drawing.Color.White
        Me.VsLabel1.BackImage = Nothing
        Me.VsLabel1.BorderColor = System.Drawing.Color.Gray
        Me.VsLabel1.BorderSide_Bottom = True
        Me.VsLabel1.BorderSide_Left = True
        Me.VsLabel1.BorderSide_Right = True
        Me.VsLabel1.BorderSide_Top = True
        Me.VsLabel1.BorderWidth = 0
        Me.VsLabel1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VsLabel1.IsPassword = False
        Me.VsLabel1.Location = New System.Drawing.Point(457, 3)
        Me.VsLabel1.MaxRange = 0
        Me.VsLabel1.MinRange = 0
        Me.VsLabel1.Name = "VsLabel1"
        Me.VsLabel1.Size = New System.Drawing.Size(59, 34)
        Me.VsLabel1.TabIndex = 1
        Me.VsLabel1.Text = "PCS :"
        Me.VsLabel1.TextAlign = System.Drawing.StringAlignment.Far
        Me.VsLabel1.UseKeyPad = False
        '
        'pbEMS
        '
        Me.pbEMS.Image = CType(resources.GetObject("pbEMS.Image"), System.Drawing.Image)
        Me.pbEMS.Location = New System.Drawing.Point(640, 3)
        Me.pbEMS.Name = "pbEMS"
        Me.pbEMS.Size = New System.Drawing.Size(47, 34)
        Me.pbEMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbEMS.TabIndex = 2
        Me.pbEMS.TabStop = False
        '
        'pbPCS
        '
        Me.pbPCS.Image = CType(resources.GetObject("pbPCS.Image"), System.Drawing.Image)
        Me.pbPCS.Location = New System.Drawing.Point(522, 3)
        Me.pbPCS.Name = "pbPCS"
        Me.pbPCS.Size = New System.Drawing.Size(47, 34)
        Me.pbPCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbPCS.TabIndex = 3
        Me.pbPCS.TabStop = False
        '
        '라벨_시스템시간
        '
        Me.라벨_시스템시간.Location = New System.Drawing.Point(692, 5)
        Me.라벨_시스템시간.Name = "라벨_시스템시간"
        Me.라벨_시스템시간.Size = New System.Drawing.Size(105, 31)
        Me.라벨_시스템시간.TabIndex = 4
        Me.라벨_시스템시간.Text = "오후 4:33:48"
        Me.라벨_시스템시간.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EB-ESS125K"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Wnd서브화면8_고장1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면6_이력1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면5_사용모드1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면4_소비1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면3_수요관리1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면2_배터리1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면7_설정1)
        Me.Panel1.Controls.Add(Me.Wnd서브화면1_메인1)
        Me.Panel1.Location = New System.Drawing.Point(2, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 338)
        Me.Panel1.TabIndex = 2
        '
        'Wnd서브화면8_고장1
        '
        Me.Wnd서브화면8_고장1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면8_고장1.Location = New System.Drawing.Point(447, 169)
        Me.Wnd서브화면8_고장1.Name = "Wnd서브화면8_고장1"
        Me.Wnd서브화면8_고장1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면8_고장1.TabIndex = 7
        '
        'Wnd서브화면6_이력1
        '
        Me.Wnd서브화면6_이력1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면6_이력1.Location = New System.Drawing.Point(161, 169)
        Me.Wnd서브화면6_이력1.Name = "Wnd서브화면6_이력1"
        Me.Wnd서브화면6_이력1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면6_이력1.TabIndex = 6
        '
        'Wnd서브화면5_사용모드1
        '
        Me.Wnd서브화면5_사용모드1.AutoScroll = True
        Me.Wnd서브화면5_사용모드1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면5_사용모드1.Location = New System.Drawing.Point(26, 169)
        Me.Wnd서브화면5_사용모드1.Name = "Wnd서브화면5_사용모드1"
        Me.Wnd서브화면5_사용모드1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면5_사용모드1.TabIndex = 5
        '
        'Wnd서브화면4_소비1
        '
        Me.Wnd서브화면4_소비1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면4_소비1.Location = New System.Drawing.Point(447, 38)
        Me.Wnd서브화면4_소비1.Name = "Wnd서브화면4_소비1"
        Me.Wnd서브화면4_소비1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면4_소비1.TabIndex = 4
        '
        'Wnd서브화면3_수요관리1
        '
        Me.Wnd서브화면3_수요관리1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면3_수요관리1.Location = New System.Drawing.Point(298, 38)
        Me.Wnd서브화면3_수요관리1.Name = "Wnd서브화면3_수요관리1"
        Me.Wnd서브화면3_수요관리1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면3_수요관리1.TabIndex = 3
        '
        'Wnd서브화면2_배터리1
        '
        Me.Wnd서브화면2_배터리1.Location = New System.Drawing.Point(161, 38)
        Me.Wnd서브화면2_배터리1.Name = "Wnd서브화면2_배터리1"
        Me.Wnd서브화면2_배터리1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면2_배터리1.TabIndex = 2
        '
        'Wnd서브화면7_설정1
        '
        Me.Wnd서브화면7_설정1.AutoScroll = True
        Me.Wnd서브화면7_설정1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면7_설정1.Location = New System.Drawing.Point(298, 169)
        Me.Wnd서브화면7_설정1.Name = "Wnd서브화면7_설정1"
        Me.Wnd서브화면7_설정1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면7_설정1.TabIndex = 1
        '
        'Wnd서브화면1_메인1
        '
        Me.Wnd서브화면1_메인1.BackColor = System.Drawing.Color.White
        Me.Wnd서브화면1_메인1.Location = New System.Drawing.Point(26, 38)
        Me.Wnd서브화면1_메인1.Name = "Wnd서브화면1_메인1"
        Me.Wnd서브화면1_메인1.Size = New System.Drawing.Size(100, 100)
        Me.Wnd서브화면1_메인1.TabIndex = 0
        '
        '타이머_상태
        '
        '
        '타이머_통신상태
        '
        '
        'SerialPort_Debug
        '
        '
        '타이머_사용모드
        '
        '
        'SmartWatchDog1
        '
        Me.SmartWatchDog1.DebugMode = False
        Me.SmartWatchDog1.RebootInterval = CType(0, Long)
        '
        'SmartRemote1
        '
        Me.SmartRemote1.AdminPassword = "12345"
        Me.SmartRemote1.ErrorMsgBoxShow = True
        Me.SmartRemote1.GuestPassword = "11111"
        Me.SmartRemote1.RefreshIntervalTime = 500
        Me.SmartRemote1.TCPPortNo = 7070
        '
        'VsPictureButton8
        '
        Me.VsPictureButton8.Location = New System.Drawing.Point(704, 381)
        Me.VsPictureButton8.Name = "VsPictureButton8"
        Me.VsPictureButton8.Size = New System.Drawing.Size(100, 102)
        Me.VsPictureButton8.TabIndex = 10
        Me.VsPictureButton8.Text = "Button8"
        Me.VsPictureButton8.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_설정
        '
        Me.버튼_화면전환_설정.Location = New System.Drawing.Point(603, 381)
        Me.버튼_화면전환_설정.Name = "버튼_화면전환_설정"
        Me.버튼_화면전환_설정.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_설정.TabIndex = 9
        Me.버튼_화면전환_설정.Text = "Button7"
        Me.버튼_화면전환_설정.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_이력
        '
        Me.버튼_화면전환_이력.Location = New System.Drawing.Point(503, 381)
        Me.버튼_화면전환_이력.Name = "버튼_화면전환_이력"
        Me.버튼_화면전환_이력.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_이력.TabIndex = 8
        Me.버튼_화면전환_이력.Text = "Button6"
        Me.버튼_화면전환_이력.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_사용모드
        '
        Me.버튼_화면전환_사용모드.Location = New System.Drawing.Point(402, 381)
        Me.버튼_화면전환_사용모드.Name = "버튼_화면전환_사용모드"
        Me.버튼_화면전환_사용모드.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_사용모드.TabIndex = 7
        Me.버튼_화면전환_사용모드.Text = "Button5"
        Me.버튼_화면전환_사용모드.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_소비
        '
        Me.버튼_화면전환_소비.Location = New System.Drawing.Point(302, 381)
        Me.버튼_화면전환_소비.Name = "버튼_화면전환_소비"
        Me.버튼_화면전환_소비.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_소비.TabIndex = 6
        Me.버튼_화면전환_소비.Text = "Button4"
        Me.버튼_화면전환_소비.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_수요관리
        '
        Me.버튼_화면전환_수요관리.Location = New System.Drawing.Point(202, 381)
        Me.버튼_화면전환_수요관리.Name = "버튼_화면전환_수요관리"
        Me.버튼_화면전환_수요관리.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_수요관리.TabIndex = 5
        Me.버튼_화면전환_수요관리.Text = "Button3"
        Me.버튼_화면전환_수요관리.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_배터리
        '
        Me.버튼_화면전환_배터리.Location = New System.Drawing.Point(102, 381)
        Me.버튼_화면전환_배터리.Name = "버튼_화면전환_배터리"
        Me.버튼_화면전환_배터리.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_배터리.TabIndex = 4
        Me.버튼_화면전환_배터리.Text = "Button2"
        Me.버튼_화면전환_배터리.UseVisualStyleBackColor = True
        '
        '버튼_화면전환_메인
        '
        Me.버튼_화면전환_메인.Location = New System.Drawing.Point(2, 381)
        Me.버튼_화면전환_메인.Name = "버튼_화면전환_메인"
        Me.버튼_화면전환_메인.Size = New System.Drawing.Size(100, 102)
        Me.버튼_화면전환_메인.TabIndex = 3
        Me.버튼_화면전환_메인.Text = "Button1"
        Me.버튼_화면전환_메인.UseVisualStyleBackColor = True
        '
        '메인화면
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 486)
        Me.Controls.Add(Me.VsPictureButton8)
        Me.Controls.Add(Me.버튼_화면전환_설정)
        Me.Controls.Add(Me.버튼_화면전환_이력)
        Me.Controls.Add(Me.버튼_화면전환_사용모드)
        Me.Controls.Add(Me.버튼_화면전환_소비)
        Me.Controls.Add(Me.버튼_화면전환_수요관리)
        Me.Controls.Add(Me.버튼_화면전환_배터리)
        Me.Controls.Add(Me.버튼_화면전환_메인)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.판넬_통신상태)
        Me.Name = "메인화면"
        Me.Text = "메인화면"
        Me.판넬_통신상태.ResumeLayout(False)
        CType(Me.pbEMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VsLabel2 As PMS.VSLabel
    Friend WithEvents VsLabel1 As PMS.VSLabel
    Friend WithEvents 판넬_통신상태 As System.Windows.Forms.Panel
    Friend WithEvents pbEMS As System.Windows.Forms.PictureBox
    Friend WithEvents pbPCS As System.Windows.Forms.PictureBox
    Friend WithEvents 라벨_시스템시간 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Wnd서브화면1_메인1 As PMS.wnd서브화면1_메인
    Friend WithEvents Wnd서브화면7_설정1 As PMS.wnd서브화면7_설정
    Friend WithEvents Wnd서브화면2_배터리1 As PMS.wnd서브화면2_배터리
    Friend WithEvents Wnd서브화면3_수요관리1 As PMS.wnd서브화면3_수요관리
    Friend WithEvents Wnd서브화면4_소비1 As PMS.wnd서브화면4_소비
    Friend WithEvents Wnd서브화면5_사용모드1 As PMS.wnd서브화면5_사용모드
    Friend WithEvents Wnd서브화면6_이력1 As PMS.wnd서브화면6_이력
    Friend WithEvents Wnd서브화면8_고장1 As PMS.wnd서브화면8_고장
    Friend WithEvents 타이머_상태 As System.Windows.Forms.Timer
    Friend WithEvents 타이머_통신상태 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort_Debug As System.IO.Ports.SerialPort
    Friend WithEvents 타이머_사용모드 As System.Windows.Forms.Timer
    Private WithEvents SmartWatchDog1 As SmartX.SmartWatchDog
    Friend WithEvents SmartRemote1 As SmartX.SmartRemote
    Friend WithEvents SmartConfigs1 As SmartX.SmartConfigs
    Friend WithEvents VsPictureButton8 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_설정 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_이력 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_사용모드 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_소비 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_수요관리 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_배터리 As System.Windows.Forms.Button
    Friend WithEvents 버튼_화면전환_메인 As System.Windows.Forms.Button
End Class

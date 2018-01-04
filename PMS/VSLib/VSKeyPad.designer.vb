<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VSKeyPad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSKeyPad))
        Me.lbKeyData = New PMS.VSLabel
        Me.lbVSKeyPadCancel = New PMS.VSPictureButton
        Me.lbVSKeyPadOK = New PMS.VSPictureButton
        Me.lbVSKeyPadBS = New PMS.VSPictureButton
        Me.lbVSKeyPadDot = New PMS.VSPictureButton
        Me.lbVSKeyPad0 = New PMS.VSPictureButton
        Me.lbVSKeyPad9 = New PMS.VSPictureButton
        Me.lbVSKeyPad8 = New PMS.VSPictureButton
        Me.lbVSKeyPad7 = New PMS.VSPictureButton
        Me.lbVSKeyPad6 = New PMS.VSPictureButton
        Me.lbVSKeyPad5 = New PMS.VSPictureButton
        Me.lbVSKeyPad4 = New PMS.VSPictureButton
        Me.lbVSKeyPad3 = New PMS.VSPictureButton
        Me.lbVSKeyPad2 = New PMS.VSPictureButton
        Me.lbVSKeyPad1 = New PMS.VSPictureButton
        Me.SuspendLayout()
        '
        'lbKeyData
        '
        Me.lbKeyData.BackColor = System.Drawing.Color.White
        Me.lbKeyData.BorderColor = System.Drawing.Color.Gray
        Me.lbKeyData.BorderSide_Bottom = True
        Me.lbKeyData.BorderSide_Left = True
        Me.lbKeyData.BorderSide_Right = True
        Me.lbKeyData.BorderSide_Top = True
        Me.lbKeyData.BorderWidth = 1
        Me.lbKeyData.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbKeyData.Location = New System.Drawing.Point(8, 7)
        Me.lbKeyData.Name = "lbKeyData"
        Me.lbKeyData.Size = New System.Drawing.Size(218, 50)
        Me.lbKeyData.TabIndex = 0
        Me.lbKeyData.Text = "0"
        Me.lbKeyData.TextAlign = System.Drawing.StringAlignment.Center
        '
        'lbVSKeyPadCancel
        '
        Me.lbVSKeyPadCancel.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPadCancel.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadCancel.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPadCancel.BorderSide_Bottom = True
        Me.lbVSKeyPadCancel.BorderSide_Left = True
        Me.lbVSKeyPadCancel.BorderSide_Right = True
        Me.lbVSKeyPadCancel.BorderSide_Top = True
        Me.lbVSKeyPadCancel.BorderWidth = 0
        Me.lbVSKeyPadCancel.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPadCancel.Location = New System.Drawing.Point(456, 63)
        Me.lbVSKeyPadCancel.Name = "lbVSKeyPadCancel"
        Me.lbVSKeyPadCancel.PressedImageValue = CType(resources.GetObject("lbVSKeyPadCancel.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadCancel.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPadCancel.TabIndex = 14
        '
        'lbVSKeyPadOK
        '
        Me.lbVSKeyPadOK.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPadOK.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadOK.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPadOK.BorderSide_Bottom = True
        Me.lbVSKeyPadOK.BorderSide_Left = True
        Me.lbVSKeyPadOK.BorderSide_Right = True
        Me.lbVSKeyPadOK.BorderSide_Top = True
        Me.lbVSKeyPadOK.BorderWidth = 0
        Me.lbVSKeyPadOK.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPadOK.Location = New System.Drawing.Point(400, 63)
        Me.lbVSKeyPadOK.Name = "lbVSKeyPadOK"
        Me.lbVSKeyPadOK.PressedImageValue = CType(resources.GetObject("lbVSKeyPadOK.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadOK.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPadOK.TabIndex = 13
        '
        'lbVSKeyPadBS
        '
        Me.lbVSKeyPadBS.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPadBS.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadBS.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPadBS.BorderSide_Bottom = True
        Me.lbVSKeyPadBS.BorderSide_Left = True
        Me.lbVSKeyPadBS.BorderSide_Right = True
        Me.lbVSKeyPadBS.BorderSide_Top = True
        Me.lbVSKeyPadBS.BorderWidth = 0
        Me.lbVSKeyPadBS.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPadBS.Location = New System.Drawing.Point(344, 63)
        Me.lbVSKeyPadBS.Name = "lbVSKeyPadBS"
        Me.lbVSKeyPadBS.PressedImageValue = CType(resources.GetObject("lbVSKeyPadBS.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadBS.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPadBS.TabIndex = 12
        '
        'lbVSKeyPadDot
        '
        Me.lbVSKeyPadDot.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPadDot.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadDot.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPadDot.BorderSide_Bottom = True
        Me.lbVSKeyPadDot.BorderSide_Left = True
        Me.lbVSKeyPadDot.BorderSide_Right = True
        Me.lbVSKeyPadDot.BorderSide_Top = True
        Me.lbVSKeyPadDot.BorderWidth = 0
        Me.lbVSKeyPadDot.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPadDot.Location = New System.Drawing.Point(288, 63)
        Me.lbVSKeyPadDot.Name = "lbVSKeyPadDot"
        Me.lbVSKeyPadDot.PressedImageValue = CType(resources.GetObject("lbVSKeyPadDot.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPadDot.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPadDot.TabIndex = 11
        '
        'lbVSKeyPad0
        '
        Me.lbVSKeyPad0.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad0.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad0.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad0.BorderSide_Bottom = True
        Me.lbVSKeyPad0.BorderSide_Left = True
        Me.lbVSKeyPad0.BorderSide_Right = True
        Me.lbVSKeyPad0.BorderSide_Top = True
        Me.lbVSKeyPad0.BorderWidth = 0
        Me.lbVSKeyPad0.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad0.Location = New System.Drawing.Point(232, 63)
        Me.lbVSKeyPad0.Name = "lbVSKeyPad0"
        Me.lbVSKeyPad0.PressedImageValue = CType(resources.GetObject("lbVSKeyPad0.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad0.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad0.TabIndex = 10
        '
        'lbVSKeyPad9
        '
        Me.lbVSKeyPad9.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad9.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad9.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad9.BorderSide_Bottom = True
        Me.lbVSKeyPad9.BorderSide_Left = True
        Me.lbVSKeyPad9.BorderSide_Right = True
        Me.lbVSKeyPad9.BorderSide_Top = True
        Me.lbVSKeyPad9.BorderWidth = 0
        Me.lbVSKeyPad9.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad9.Location = New System.Drawing.Point(176, 63)
        Me.lbVSKeyPad9.Name = "lbVSKeyPad9"
        Me.lbVSKeyPad9.PressedImageValue = CType(resources.GetObject("lbVSKeyPad9.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad9.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad9.TabIndex = 9
        '
        'lbVSKeyPad8
        '
        Me.lbVSKeyPad8.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad8.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad8.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad8.BorderSide_Bottom = True
        Me.lbVSKeyPad8.BorderSide_Left = True
        Me.lbVSKeyPad8.BorderSide_Right = True
        Me.lbVSKeyPad8.BorderSide_Top = True
        Me.lbVSKeyPad8.BorderWidth = 0
        Me.lbVSKeyPad8.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad8.Location = New System.Drawing.Point(120, 63)
        Me.lbVSKeyPad8.Name = "lbVSKeyPad8"
        Me.lbVSKeyPad8.PressedImageValue = CType(resources.GetObject("lbVSKeyPad8.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad8.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad8.TabIndex = 8
        '
        'lbVSKeyPad7
        '
        Me.lbVSKeyPad7.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad7.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad7.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad7.BorderSide_Bottom = True
        Me.lbVSKeyPad7.BorderSide_Left = True
        Me.lbVSKeyPad7.BorderSide_Right = True
        Me.lbVSKeyPad7.BorderSide_Top = True
        Me.lbVSKeyPad7.BorderWidth = 0
        Me.lbVSKeyPad7.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad7.Location = New System.Drawing.Point(64, 63)
        Me.lbVSKeyPad7.Name = "lbVSKeyPad7"
        Me.lbVSKeyPad7.PressedImageValue = CType(resources.GetObject("lbVSKeyPad7.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad7.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad7.TabIndex = 7
        '
        'lbVSKeyPad6
        '
        Me.lbVSKeyPad6.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad6.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad6.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad6.BorderSide_Bottom = True
        Me.lbVSKeyPad6.BorderSide_Left = True
        Me.lbVSKeyPad6.BorderSide_Right = True
        Me.lbVSKeyPad6.BorderSide_Top = True
        Me.lbVSKeyPad6.BorderWidth = 0
        Me.lbVSKeyPad6.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad6.Location = New System.Drawing.Point(8, 63)
        Me.lbVSKeyPad6.Name = "lbVSKeyPad6"
        Me.lbVSKeyPad6.PressedImageValue = CType(resources.GetObject("lbVSKeyPad6.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad6.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad6.TabIndex = 6
        '
        'lbVSKeyPad5
        '
        Me.lbVSKeyPad5.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad5.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad5.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad5.BorderSide_Bottom = True
        Me.lbVSKeyPad5.BorderSide_Left = True
        Me.lbVSKeyPad5.BorderSide_Right = True
        Me.lbVSKeyPad5.BorderSide_Top = True
        Me.lbVSKeyPad5.BorderWidth = 0
        Me.lbVSKeyPad5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad5.Location = New System.Drawing.Point(456, 7)
        Me.lbVSKeyPad5.Name = "lbVSKeyPad5"
        Me.lbVSKeyPad5.PressedImageValue = CType(resources.GetObject("lbVSKeyPad5.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad5.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad5.TabIndex = 5
        '
        'lbVSKeyPad4
        '
        Me.lbVSKeyPad4.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad4.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad4.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad4.BorderSide_Bottom = True
        Me.lbVSKeyPad4.BorderSide_Left = True
        Me.lbVSKeyPad4.BorderSide_Right = True
        Me.lbVSKeyPad4.BorderSide_Top = True
        Me.lbVSKeyPad4.BorderWidth = 0
        Me.lbVSKeyPad4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad4.Location = New System.Drawing.Point(400, 7)
        Me.lbVSKeyPad4.Name = "lbVSKeyPad4"
        Me.lbVSKeyPad4.PressedImageValue = CType(resources.GetObject("lbVSKeyPad4.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad4.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad4.TabIndex = 4
        '
        'lbVSKeyPad3
        '
        Me.lbVSKeyPad3.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad3.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad3.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad3.BorderSide_Bottom = True
        Me.lbVSKeyPad3.BorderSide_Left = True
        Me.lbVSKeyPad3.BorderSide_Right = True
        Me.lbVSKeyPad3.BorderSide_Top = True
        Me.lbVSKeyPad3.BorderWidth = 0
        Me.lbVSKeyPad3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad3.Location = New System.Drawing.Point(344, 7)
        Me.lbVSKeyPad3.Name = "lbVSKeyPad3"
        Me.lbVSKeyPad3.PressedImageValue = CType(resources.GetObject("lbVSKeyPad3.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad3.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad3.TabIndex = 3
        '
        'lbVSKeyPad2
        '
        Me.lbVSKeyPad2.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad2.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad2.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad2.BorderSide_Bottom = True
        Me.lbVSKeyPad2.BorderSide_Left = True
        Me.lbVSKeyPad2.BorderSide_Right = True
        Me.lbVSKeyPad2.BorderSide_Top = True
        Me.lbVSKeyPad2.BorderWidth = 0
        Me.lbVSKeyPad2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad2.Location = New System.Drawing.Point(288, 7)
        Me.lbVSKeyPad2.Name = "lbVSKeyPad2"
        Me.lbVSKeyPad2.PressedImageValue = CType(resources.GetObject("lbVSKeyPad2.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad2.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad2.TabIndex = 2
        '
        'lbVSKeyPad1
        '
        Me.lbVSKeyPad1.BackgroundImageValue = CType(resources.GetObject("lbVSKeyPad1.BackgroundImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad1.BorderColor = System.Drawing.Color.Gray
        Me.lbVSKeyPad1.BorderSide_Bottom = True
        Me.lbVSKeyPad1.BorderSide_Left = True
        Me.lbVSKeyPad1.BorderSide_Right = True
        Me.lbVSKeyPad1.BorderSide_Top = True
        Me.lbVSKeyPad1.BorderWidth = 0
        Me.lbVSKeyPad1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbVSKeyPad1.Location = New System.Drawing.Point(232, 7)
        Me.lbVSKeyPad1.Name = "lbVSKeyPad1"
        Me.lbVSKeyPad1.PressedImageValue = CType(resources.GetObject("lbVSKeyPad1.PressedImageValue"), System.Drawing.Image)
        Me.lbVSKeyPad1.Size = New System.Drawing.Size(50, 50)
        Me.lbVSKeyPad1.TabIndex = 1
        '
        'VSKeyPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lbKeyData)
        Me.Controls.Add(Me.lbVSKeyPadCancel)
        Me.Controls.Add(Me.lbVSKeyPadOK)
        Me.Controls.Add(Me.lbVSKeyPadBS)
        Me.Controls.Add(Me.lbVSKeyPadDot)
        Me.Controls.Add(Me.lbVSKeyPad0)
        Me.Controls.Add(Me.lbVSKeyPad9)
        Me.Controls.Add(Me.lbVSKeyPad8)
        Me.Controls.Add(Me.lbVSKeyPad7)
        Me.Controls.Add(Me.lbVSKeyPad6)
        Me.Controls.Add(Me.lbVSKeyPad5)
        Me.Controls.Add(Me.lbVSKeyPad4)
        Me.Controls.Add(Me.lbVSKeyPad3)
        Me.Controls.Add(Me.lbVSKeyPad2)
        Me.Controls.Add(Me.lbVSKeyPad1)
        Me.Name = "VSKeyPad"
        Me.Size = New System.Drawing.Size(515, 120)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbVSKeyPad1 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad2 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad3 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad4 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad5 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad6 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad7 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad8 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad9 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPad0 As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPadOK As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPadCancel As PMS.VSPictureButton
    Friend WithEvents lbVSKeyPadBS As PMS.VSPictureButton
    Friend WithEvents lbKeyData As PMS.VSLabel
    Friend WithEvents lbVSKeyPadDot As PMS.VSPictureButton

End Class

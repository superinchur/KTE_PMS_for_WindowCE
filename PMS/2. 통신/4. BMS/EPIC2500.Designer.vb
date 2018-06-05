<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EPIC2500
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.label1 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.btnWriteSingleCoil = New System.Windows.Forms.Button
        Me.btnReadInpReg = New System.Windows.Forms.Button
        Me.btnReadHoldReg = New System.Windows.Forms.Button
        Me.btnReadDisInp = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.btnReadCoils = New System.Windows.Forms.Button
        Me.txtStartAdress = New System.Windows.Forms.TextBox
        Me.radWord = New System.Windows.Forms.RadioButton
        Me.label4 = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.btnWriteMultipleReg = New System.Windows.Forms.Button
        Me.btnWriteMultipleCoils = New System.Windows.Forms.Button
        Me.btnWriteSingleReg = New System.Windows.Forms.Button
        Me.radBytes = New System.Windows.Forms.RadioButton
        Me.radBits = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(71, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 15)
        Me.label1.Text = "IP Address"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(187, 29)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(104, 30)
        Me.btnConnect.TabIndex = 30
        Me.btnConnect.Text = "Connect"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(55, 30)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(104, 23)
        Me.txtIP.TabIndex = 29
        Me.txtIP.Text = "127.0.0.1"
        '
        'btnWriteSingleCoil
        '
        Me.btnWriteSingleCoil.Location = New System.Drawing.Point(564, 30)
        Me.btnWriteSingleCoil.Name = "btnWriteSingleCoil"
        Me.btnWriteSingleCoil.Size = New System.Drawing.Size(104, 37)
        Me.btnWriteSingleCoil.TabIndex = 37
        Me.btnWriteSingleCoil.Text = "Write single coil"
        '
        'btnReadInpReg
        '
        Me.btnReadInpReg.Location = New System.Drawing.Point(444, 82)
        Me.btnReadInpReg.Name = "btnReadInpReg"
        Me.btnReadInpReg.Size = New System.Drawing.Size(104, 38)
        Me.btnReadInpReg.TabIndex = 36
        Me.btnReadInpReg.Text = "Read input register"
        '
        'btnReadHoldReg
        '
        Me.btnReadHoldReg.Location = New System.Drawing.Point(444, 30)
        Me.btnReadHoldReg.Name = "btnReadHoldReg"
        Me.btnReadHoldReg.Size = New System.Drawing.Size(104, 37)
        Me.btnReadHoldReg.TabIndex = 35
        Me.btnReadHoldReg.Text = "Read holding register"
        '
        'btnReadDisInp
        '
        Me.btnReadDisInp.Location = New System.Drawing.Point(324, 82)
        Me.btnReadDisInp.Name = "btnReadDisInp"
        Me.btnReadDisInp.Size = New System.Drawing.Size(104, 38)
        Me.btnReadDisInp.TabIndex = 34
        Me.btnReadDisInp.Text = "Read discrete inputs"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(5, 132)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(88, 15)
        Me.label3.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(99, 132)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(60, 23)
        Me.txtSize.TabIndex = 33
        Me.txtSize.Text = "32"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(5, 105)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 15)
        Me.label2.Text = "Start Adress"
        '
        'btnReadCoils
        '
        Me.btnReadCoils.Location = New System.Drawing.Point(324, 30)
        Me.btnReadCoils.Name = "btnReadCoils"
        Me.btnReadCoils.Size = New System.Drawing.Size(104, 37)
        Me.btnReadCoils.TabIndex = 31
        Me.btnReadCoils.Text = "Read coils"
        '
        'txtStartAdress
        '
        Me.txtStartAdress.Location = New System.Drawing.Point(99, 103)
        Me.txtStartAdress.Name = "txtStartAdress"
        Me.txtStartAdress.Size = New System.Drawing.Size(60, 23)
        Me.txtStartAdress.TabIndex = 32
        Me.txtStartAdress.Text = "40000"
        '
        'radWord
        '
        Me.radWord.Location = New System.Drawing.Point(187, 125)
        Me.radWord.Name = "radWord"
        Me.radWord.Size = New System.Drawing.Size(80, 22)
        Me.radWord.TabIndex = 28
        Me.radWord.Text = "Word"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(5, 75)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 15)
        Me.label4.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(99, 75)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(60, 23)
        Me.txtUnit.TabIndex = 44
        Me.txtUnit.Text = "1"
        '
        'btnWriteMultipleReg
        '
        Me.btnWriteMultipleReg.Location = New System.Drawing.Point(684, 82)
        Me.btnWriteMultipleReg.Name = "btnWriteMultipleReg"
        Me.btnWriteMultipleReg.Size = New System.Drawing.Size(104, 38)
        Me.btnWriteMultipleReg.TabIndex = 43
        Me.btnWriteMultipleReg.Text = "Write multiple register"
        '
        'btnWriteMultipleCoils
        '
        Me.btnWriteMultipleCoils.Location = New System.Drawing.Point(684, 30)
        Me.btnWriteMultipleCoils.Name = "btnWriteMultipleCoils"
        Me.btnWriteMultipleCoils.Size = New System.Drawing.Size(104, 37)
        Me.btnWriteMultipleCoils.TabIndex = 42
        Me.btnWriteMultipleCoils.Text = "Write multiple coils"
        '
        'btnWriteSingleReg
        '
        Me.btnWriteSingleReg.Location = New System.Drawing.Point(564, 82)
        Me.btnWriteSingleReg.Name = "btnWriteSingleReg"
        Me.btnWriteSingleReg.Size = New System.Drawing.Size(104, 38)
        Me.btnWriteSingleReg.TabIndex = 39
        Me.btnWriteSingleReg.Text = "Write single register"
        '
        'radBytes
        '
        Me.radBytes.Location = New System.Drawing.Point(187, 103)
        Me.radBytes.Name = "radBytes"
        Me.radBytes.Size = New System.Drawing.Size(80, 22)
        Me.radBytes.TabIndex = 27
        Me.radBytes.Text = "Bytes"
        '
        'radBits
        '
        Me.radBits.Location = New System.Drawing.Point(187, 81)
        Me.radBits.Name = "radBits"
        Me.radBits.Size = New System.Drawing.Size(80, 22)
        Me.radBits.TabIndex = 25
        Me.radBits.Text = "Bits"
        '
        'BMS클라이언트
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(860, 616)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.btnWriteSingleCoil)
        Me.Controls.Add(Me.btnReadInpReg)
        Me.Controls.Add(Me.btnReadHoldReg)
        Me.Controls.Add(Me.btnReadDisInp)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnReadCoils)
        Me.Controls.Add(Me.txtStartAdress)
        Me.Controls.Add(Me.radWord)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.btnWriteMultipleReg)
        Me.Controls.Add(Me.btnWriteMultipleCoils)
        Me.Controls.Add(Me.btnWriteSingleReg)
        Me.Controls.Add(Me.radBytes)
        Me.Controls.Add(Me.radBits)
        Me.Menu = Me.mainMenu1
        Me.Name = "BMS클라이언트"
        Me.Text = "BMS클라이언트"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents txtIP As System.Windows.Forms.TextBox
    Private WithEvents btnWriteSingleCoil As System.Windows.Forms.Button
    Private WithEvents btnReadInpReg As System.Windows.Forms.Button
    Private WithEvents btnReadHoldReg As System.Windows.Forms.Button
    Private WithEvents btnReadDisInp As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtSize As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnReadCoils As System.Windows.Forms.Button
    Private WithEvents txtStartAdress As System.Windows.Forms.TextBox
    Private WithEvents radWord As System.Windows.Forms.RadioButton
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtUnit As System.Windows.Forms.TextBox
    Private WithEvents btnWriteMultipleReg As System.Windows.Forms.Button
    Private WithEvents btnWriteMultipleCoils As System.Windows.Forms.Button
    Private WithEvents btnWriteSingleReg As System.Windows.Forms.Button
    Private WithEvents radBytes As System.Windows.Forms.RadioButton
    Private WithEvents radBits As System.Windows.Forms.RadioButton
End Class

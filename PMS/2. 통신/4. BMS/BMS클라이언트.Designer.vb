<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMS클라이언트
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
        Me.grpStart = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.grpExchange = New System.Windows.Forms.GroupBox
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.btnWriteMultipleReg = New System.Windows.Forms.Button
        Me.btnWriteMultipleCoils = New System.Windows.Forms.Button
        Me.btnWriteSingleReg = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radWord = New System.Windows.Forms.RadioButton
        Me.radBytes = New System.Windows.Forms.RadioButton
        Me.radBits = New System.Windows.Forms.RadioButton
        Me.btnWriteSingleCoil = New System.Windows.Forms.Button
        Me.btnReadInpReg = New System.Windows.Forms.Button
        Me.btnReadHoldReg = New System.Windows.Forms.Button
        Me.btnReadDisInp = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.txtStartAdress = New System.Windows.Forms.TextBox
        Me.btnReadCoils = New System.Windows.Forms.Button
        Me.grpData = New System.Windows.Forms.GroupBox
        Me.grpStart.SuspendLayout()
        Me.grpExchange.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStart
        '
        Me.grpStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStart.Controls.Add(Me.label1)
        Me.grpStart.Controls.Add(Me.btnConnect)
        Me.grpStart.Controls.Add(Me.txtIP)
        Me.grpStart.Location = New System.Drawing.Point(12, 12)
        Me.grpStart.Name = "grpStart"
        Me.grpStart.Size = New System.Drawing.Size(805, 59)
        Me.grpStart.TabIndex = 17
        Me.grpStart.TabStop = False
        Me.grpStart.Text = "Start communication"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 15)
        Me.label1.TabIndex = 7
        Me.label1.Text = "IP Address"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(224, 23)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(104, 30)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(112, 27)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(104, 21)
        Me.txtIP.TabIndex = 5
        Me.txtIP.Text = "127.0.0.1"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 15)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Unit"
        '
        'grpExchange
        '
        Me.grpExchange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExchange.Controls.Add(Me.label4)
        Me.grpExchange.Controls.Add(Me.txtUnit)
        Me.grpExchange.Controls.Add(Me.btnWriteMultipleReg)
        Me.grpExchange.Controls.Add(Me.btnWriteMultipleCoils)
        Me.grpExchange.Controls.Add(Me.btnWriteSingleReg)
        Me.grpExchange.Controls.Add(Me.groupBox1)
        Me.grpExchange.Controls.Add(Me.btnWriteSingleCoil)
        Me.grpExchange.Controls.Add(Me.btnReadInpReg)
        Me.grpExchange.Controls.Add(Me.btnReadHoldReg)
        Me.grpExchange.Controls.Add(Me.btnReadDisInp)
        Me.grpExchange.Controls.Add(Me.label3)
        Me.grpExchange.Controls.Add(Me.txtSize)
        Me.grpExchange.Controls.Add(Me.label2)
        Me.grpExchange.Controls.Add(Me.txtStartAdress)
        Me.grpExchange.Controls.Add(Me.btnReadCoils)
        Me.grpExchange.Location = New System.Drawing.Point(12, 78)
        Me.grpExchange.Name = "grpExchange"
        Me.grpExchange.Size = New System.Drawing.Size(805, 127)
        Me.grpExchange.TabIndex = 18
        Me.grpExchange.TabStop = False
        Me.grpExchange.Text = "Data exhange"
        Me.grpExchange.Visible = False
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(104, 27)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(60, 21)
        Me.txtUnit.TabIndex = 24
        Me.txtUnit.Text = "1"
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnWriteMultipleReg
        '
        Me.btnWriteMultipleReg.Location = New System.Drawing.Point(688, 82)
        Me.btnWriteMultipleReg.Name = "btnWriteMultipleReg"
        Me.btnWriteMultipleReg.Size = New System.Drawing.Size(104, 38)
        Me.btnWriteMultipleReg.TabIndex = 23
        Me.btnWriteMultipleReg.Text = "Write multiple register"
        '
        'btnWriteMultipleCoils
        '
        Me.btnWriteMultipleCoils.Location = New System.Drawing.Point(688, 30)
        Me.btnWriteMultipleCoils.Name = "btnWriteMultipleCoils"
        Me.btnWriteMultipleCoils.Size = New System.Drawing.Size(104, 37)
        Me.btnWriteMultipleCoils.TabIndex = 22
        Me.btnWriteMultipleCoils.Text = "Write multiple coils"
        '
        'btnWriteSingleReg
        '
        Me.btnWriteSingleReg.Location = New System.Drawing.Point(568, 82)
        Me.btnWriteSingleReg.Name = "btnWriteSingleReg"
        Me.btnWriteSingleReg.Size = New System.Drawing.Size(104, 38)
        Me.btnWriteSingleReg.TabIndex = 21
        Me.btnWriteSingleReg.Text = "Write single register"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radWord)
        Me.groupBox1.Controls.Add(Me.radBytes)
        Me.groupBox1.Controls.Add(Me.radBits)
        Me.groupBox1.Location = New System.Drawing.Point(192, 23)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(104, 97)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Show as"
        '
        'radWord
        '
        Me.radWord.Location = New System.Drawing.Point(16, 67)
        Me.radWord.Name = "radWord"
        Me.radWord.Size = New System.Drawing.Size(80, 22)
        Me.radWord.TabIndex = 2
        Me.radWord.Text = "Word"
        '
        'radBytes
        '
        Me.radBytes.Location = New System.Drawing.Point(16, 45)
        Me.radBytes.Name = "radBytes"
        Me.radBytes.Size = New System.Drawing.Size(80, 22)
        Me.radBytes.TabIndex = 1
        Me.radBytes.Text = "Bytes"
        '
        'radBits
        '
        Me.radBits.Location = New System.Drawing.Point(16, 23)
        Me.radBits.Name = "radBits"
        Me.radBits.Size = New System.Drawing.Size(80, 22)
        Me.radBits.TabIndex = 0
        Me.radBits.Text = "Bits"
        '
        'btnWriteSingleCoil
        '
        Me.btnWriteSingleCoil.Location = New System.Drawing.Point(568, 30)
        Me.btnWriteSingleCoil.Name = "btnWriteSingleCoil"
        Me.btnWriteSingleCoil.Size = New System.Drawing.Size(104, 37)
        Me.btnWriteSingleCoil.TabIndex = 19
        Me.btnWriteSingleCoil.Text = "Write single coil"
        '
        'btnReadInpReg
        '
        Me.btnReadInpReg.Location = New System.Drawing.Point(448, 82)
        Me.btnReadInpReg.Name = "btnReadInpReg"
        Me.btnReadInpReg.Size = New System.Drawing.Size(104, 38)
        Me.btnReadInpReg.TabIndex = 18
        Me.btnReadInpReg.Text = "Read input register"
        '
        'btnReadHoldReg
        '
        Me.btnReadHoldReg.Location = New System.Drawing.Point(448, 30)
        Me.btnReadHoldReg.Name = "btnReadHoldReg"
        Me.btnReadHoldReg.Size = New System.Drawing.Size(104, 37)
        Me.btnReadHoldReg.TabIndex = 17
        Me.btnReadHoldReg.Text = "Read holding register"
        '
        'btnReadDisInp
        '
        Me.btnReadDisInp.Location = New System.Drawing.Point(328, 82)
        Me.btnReadDisInp.Name = "btnReadDisInp"
        Me.btnReadDisInp.Size = New System.Drawing.Size(104, 38)
        Me.btnReadDisInp.TabIndex = 16
        Me.btnReadDisInp.Text = "Read discrete inputs"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(88, 15)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(104, 84)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(60, 21)
        Me.txtSize.TabIndex = 14
        Me.txtSize.Text = "32"
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 15)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Start Adress"
        '
        'txtStartAdress
        '
        Me.txtStartAdress.Location = New System.Drawing.Point(104, 55)
        Me.txtStartAdress.Name = "txtStartAdress"
        Me.txtStartAdress.Size = New System.Drawing.Size(60, 21)
        Me.txtStartAdress.TabIndex = 12
        Me.txtStartAdress.Text = "40000"
        Me.txtStartAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReadCoils
        '
        Me.btnReadCoils.Location = New System.Drawing.Point(328, 30)
        Me.btnReadCoils.Name = "btnReadCoils"
        Me.btnReadCoils.Size = New System.Drawing.Size(104, 37)
        Me.btnReadCoils.TabIndex = 11
        Me.btnReadCoils.Text = "Read coils"
        '
        'grpData
        '
        Me.grpData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpData.Location = New System.Drawing.Point(12, 213)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(805, 281)
        Me.grpData.TabIndex = 16
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        Me.grpData.Visible = False
        '
        'BMS클라이언트
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 629)
        Me.Controls.Add(Me.grpStart)
        Me.Controls.Add(Me.grpExchange)
        Me.Controls.Add(Me.grpData)
        Me.Name = "BMS클라이언트"
        Me.Text = "BMS클라이언트"
        Me.grpStart.ResumeLayout(False)
        Me.grpStart.PerformLayout()
        Me.grpExchange.ResumeLayout(False)
        Me.grpExchange.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grpStart As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents txtIP As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents grpExchange As System.Windows.Forms.GroupBox
    Private WithEvents txtUnit As System.Windows.Forms.TextBox
    Private WithEvents btnWriteMultipleReg As System.Windows.Forms.Button
    Private WithEvents btnWriteMultipleCoils As System.Windows.Forms.Button
    Private WithEvents btnWriteSingleReg As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents radWord As System.Windows.Forms.RadioButton
    Private WithEvents radBytes As System.Windows.Forms.RadioButton
    Private WithEvents radBits As System.Windows.Forms.RadioButton
    Private WithEvents btnWriteSingleCoil As System.Windows.Forms.Button
    Private WithEvents btnReadInpReg As System.Windows.Forms.Button
    Private WithEvents btnReadHoldReg As System.Windows.Forms.Button
    Private WithEvents btnReadDisInp As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtSize As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtStartAdress As System.Windows.Forms.TextBox
    Private WithEvents btnReadCoils As System.Windows.Forms.Button
    Private WithEvents grpData As System.Windows.Forms.GroupBox
End Class

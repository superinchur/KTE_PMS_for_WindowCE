Imports System.Net
Imports System.IO
Imports Microsoft.Win32

Public Class wnd서브화면7_설정

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Me.Width = 800
        Me.Height = 338

        초기화_옵션()

        InitKeyPad()

    End Sub


    Private 그리드상태 As Integer = -1


    Private Sub 초기화_옵션()

        ' ---------------------------------------------------------------------------------------
        ' 시스템 시리얼 포트
        cbPCS통신포트.Items.Clear()

        Dim 시스템시리얼포트() As String = System.IO.Ports.SerialPort.GetPortNames

        Dim 시리얼포트배열 As New ArrayList
        For Each 포트번호 In 시스템시리얼포트

            Dim 포트명칭 As Integer = Val(포트번호.Replace("COM", "") & "")
            시리얼포트배열.Add(포트명칭)

        Next

        시리얼포트배열.Sort()

        For i As Integer = 0 To 시리얼포트배열.Count - 1
            cbPCS통신포트.Items.Add(String.Format("COM{0}", 시리얼포트배열(i)))
            'cbBMS통신포트.Items.Add(String.Format("COM{0}", 시리얼포트배열(i)))
        Next

        If cbPCS통신포트.Items.Count > 0 Then
            cbPCS통신포트.SelectedIndex = 0
        End If

        ' ---------------------------------------------------------------------------------------
        ' 통신주기
        cbPCS통신주기.Items.Add("100")
        cbPCS통신주기.Items.Add("200")
        cbPCS통신주기.Items.Add("300")
        cbPCS통신주기.Items.Add("400")
        cbPCS통신주기.Items.Add("500")
        cbPCS통신주기.Items.Add("1000")
        cbPCS통신주기.Items.Add("1500")
        cbPCS통신주기.Items.Add("2000")
        cbPCS통신주기.Items.Add("2500")
        cbPCS통신주기.Items.Add("3000")
        cbPCS통신주기.Items.Add("3500")
        cbPCS통신주기.Items.Add("4000")
        cbPCS통신주기.Items.Add("4500")
        cbPCS통신주기.Items.Add("5000")
        cbPCS통신주기.SelectedIndex = 0

        Panel1.BackColor = Color.White

        pnlDateTime.BackColor = Color.White
        pnlComm.BackColor = Color.White
        pnlNetwork.BackColor = Color.White
        pnlScreen.BackColor = Color.White
        pnlLanguage.BackColor = Color.White
        pnlInformation.BackColor = Color.White

        pnlDateTime.Left = Panel1.Left + 1
        pnlDateTime.Top = Panel1.Top + 1
        pnlDateTime.Width = Panel1.Width - 2
        pnlDateTime.Height = Panel1.Height - 2

        pnlComm.Left = Panel1.Left + 1
        pnlComm.Top = Panel1.Top + 1
        pnlComm.Width = Panel1.Width - 2
        pnlComm.Height = Panel1.Height - 2

        pnlNetwork.Left = Panel1.Left + 1
        pnlNetwork.Top = Panel1.Top + 1
        pnlNetwork.Width = Panel1.Width - 2
        pnlNetwork.Height = Panel1.Height - 2

        pnlScreen.Left = Panel1.Left + 1
        pnlScreen.Top = Panel1.Top + 1
        pnlScreen.Width = Panel1.Width - 2
        pnlScreen.Height = Panel1.Height - 2

        pnlLanguage.Left = Panel1.Left + 1
        pnlLanguage.Top = Panel1.Top + 1
        pnlLanguage.Width = Panel1.Width - 2
        pnlLanguage.Height = Panel1.Height - 2

        pnlInformation.Left = Panel1.Left + 1
        pnlInformation.Top = Panel1.Top + 1
        pnlInformation.Width = Panel1.Width - 2
        pnlInformation.Height = Panel1.Height - 2

    End Sub

    Private Sub 화면_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim g As Graphics = e.Graphics

        Dim thisRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim pPen As New Pen(메인화면.버튼_화면전환_메인.BorderColor, 메인화면.버튼_화면전환_메인.BorderWidth)
        g.DrawLine(pPen, Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)

        g.DrawLine(pPen, 0, 0, Me.Width - 1, 0)

        g.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)

    End Sub



    Private Sub IPAddressCheck()
        Dim mKeyName As String = "Comm\CS89001\Parms\Tcpip"
        Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(mKeyName, False)

        If regKey IsNot Nothing Then

            For Each szKeyName As String In regKey.GetValueNames

                Dim pKeyValue = regKey.GetValue(szKeyName)

                If TypeOf pKeyValue Is Integer Then

                ElseIf TypeOf pKeyValue Is String Then

                ElseIf TypeOf pKeyValue Is Array Then

                End If

            Next


            ';Manually configure an IPv4 Address 
            '[HKEY_LOCAL_MACHINE\Comm\<Adapter Name>\Parms\Tcpip]
            '"DefaultGateway"=REG_MULTI_SZ:<IP address of the default gateway>
            '"EnableDhcp"=REG_DWORD:0
            '"DNS"=REG_MULTI_SZ:<IP address of the DNS name server>.  
            '"Domain"=REG_SZ:<the domain name that is used by the network to which the device is connected> 
            '"IPAddress"=REG_MULTI_SZ:<IP address of the device> 
            '"SubnetMask"=REG_MULTI_SZ:<the subnet masks to be used with the IP interfaces bound to the adapter>.


        End If

    End Sub

    Public Sub InitScreen()
        VsLabel1_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub VsLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Click
        PageHeader1.BorderSide_Bottom = False
        PageHeader1.BackColor = Color.White
        PageHeader1.Enabled = False
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = True
        PageHeader5.BackColor = Color.WhiteSmoke
        PageHeader5.Enabled = True
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = True
        PageHeader6.BackColor = Color.WhiteSmoke
        PageHeader6.Enabled = True
        PageHeader6.Invalidate()

        pnlComm.Visible = False
        pnlNetwork.Visible = False
        pnlScreen.Visible = False
        pnlLanguage.Visible = False
        pnlInformation.Visible = False
        pnlDateTime.Visible = True
        pnlDateTime.BringToFront()


        Dim tCurrent As Date = Now
        lbDateTimeYear.Text = tCurrent.Year.ToString
        lbDateTimeMonth.Text = tCurrent.Month.ToString
        lbDateTimeDay.Text = tCurrent.Day.ToString
        lbDateTimeHour.Text = tCurrent.Hour.ToString
        lbDateTimeMinute.Text = tCurrent.Minute.ToString
        lbDateTimeSecond.Text = tCurrent.Second.ToString

    End Sub

    Private Sub VsLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader2.Click
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = False
        PageHeader2.BackColor = Color.White
        PageHeader2.Enabled = False
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = True
        PageHeader5.BackColor = Color.WhiteSmoke
        PageHeader5.Enabled = True
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = True
        PageHeader6.BackColor = Color.WhiteSmoke
        PageHeader6.Enabled = True
        PageHeader6.Invalidate()

        pnlDateTime.Visible = False
        pnlNetwork.Visible = False
        pnlScreen.Visible = False
        pnlLanguage.Visible = False
        pnlInformation.Visible = False
        pnlComm.Visible = True
        pnlComm.BringToFront()

        ' 통신
        lbCommEMSPort.Text = EMS_수신포트.ToString

        If PMS_통신ID = 1 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        cbPCS통신포트.SelectedItem = PCS_통신포트
        cbPCS통신주기.SelectedItem = PCS_통신주기.ToString
    End Sub

    Private Sub VsLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader3.Click
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = False
        PageHeader3.BackColor = Color.White
        PageHeader3.Enabled = False
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = True
        PageHeader5.BackColor = Color.WhiteSmoke
        PageHeader5.Enabled = True
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = True
        PageHeader6.BackColor = Color.WhiteSmoke
        PageHeader6.Enabled = True
        PageHeader6.Invalidate()

        pnlDateTime.Visible = False
        pnlComm.Visible = False
        pnlScreen.Visible = False
        pnlLanguage.Visible = False
        pnlInformation.Visible = False
        pnlNetwork.Visible = True
        pnlNetwork.BringToFront()

        LoadNetworkStatus()

    End Sub

    Private Sub VsLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader4.Click
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = False
        PageHeader4.BackColor = Color.White
        PageHeader4.Enabled = False
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = True
        PageHeader5.BackColor = Color.WhiteSmoke
        PageHeader5.Enabled = True
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = True
        PageHeader6.BackColor = Color.WhiteSmoke
        PageHeader6.Enabled = True
        PageHeader6.Invalidate()

        pnlDateTime.Visible = False
        pnlComm.Visible = False
        pnlNetwork.Visible = False
        pnlLanguage.Visible = False
        pnlInformation.Visible = False
        pnlScreen.Visible = True
        pnlScreen.BringToFront()

    End Sub


    Private Sub PageHeader5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader5.Click
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = False
        PageHeader5.BackColor = Color.White
        PageHeader5.Enabled = False
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = True
        PageHeader6.BackColor = Color.WhiteSmoke
        PageHeader6.Enabled = True
        PageHeader6.Invalidate()

        pnlDateTime.Visible = False
        pnlComm.Visible = False
        pnlNetwork.Visible = False
        pnlScreen.Visible = False
        pnlInformation.Visible = False
        pnlLanguage.Visible = True
        pnlLanguage.BringToFront()

    End Sub

    Private Sub PageHeader6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader6.Click
        PageHeader1.BorderSide_Bottom = True
        PageHeader1.BackColor = Color.WhiteSmoke
        PageHeader1.Enabled = True
        PageHeader1.Invalidate()

        PageHeader2.BorderSide_Bottom = True
        PageHeader2.BackColor = Color.WhiteSmoke
        PageHeader2.Enabled = True
        PageHeader2.Invalidate()

        PageHeader3.BorderSide_Bottom = True
        PageHeader3.BackColor = Color.WhiteSmoke
        PageHeader3.Enabled = True
        PageHeader3.Invalidate()

        PageHeader4.BorderSide_Bottom = True
        PageHeader4.BackColor = Color.WhiteSmoke
        PageHeader4.Enabled = True
        PageHeader4.Invalidate()

        PageHeader5.BorderSide_Bottom = True
        PageHeader5.BackColor = Color.WhiteSmoke
        PageHeader5.Enabled = True
        PageHeader5.Invalidate()

        PageHeader6.BorderSide_Bottom = False
        PageHeader6.BackColor = Color.White
        PageHeader6.Enabled = False
        PageHeader6.Invalidate()

        pnlDateTime.Visible = False
        pnlComm.Visible = False
        pnlNetwork.Visible = False
        pnlScreen.Visible = False
        pnlLanguage.Visible = False
        pnlInformation.Visible = True
        pnlInformation.BringToFront()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

        Dim pObj As Panel = sender

        Dim pPen As New Pen(Color.Gray, 1)

        e.Graphics.DrawLine(pPen, 0, 0, 0, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, pObj.Width - 1, 0, pObj.Width - 1, pObj.Height - 1)
        e.Graphics.DrawLine(pPen, 0, pObj.Height - 1, pObj.Width - 1, pObj.Height - 1)

        e.Graphics.DrawLine(pPen, PageHeader3.Left + PageHeader3.Width - PageHeader1.Left, 0, pObj.Width - 1, 0)

    End Sub



#Region "날짜/시간"

    Private Sub btnDateTimeSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateTimeSave.Click
        Dim nYear As Integer = Val(lbDateTimeYear.Text)
        Dim nMonth As Integer = Val(lbDateTimeMonth.Text)
        Dim nDay As Integer = Val(lbDateTimeDay.Text)
        Dim nHour As Integer = Val(lbDateTimeHour.Text)
        Dim nMinute As Integer = Val(lbDateTimeMinute.Text)
        Dim nSecond As Integer = Val(lbDateTimeSecond.Text)

        'Dim st As New SYSTEMTIME


        If nYear < 2000 Or nYear > 2050 Then nYear = Now.Year
        If nMonth < 1 Or nMonth > 12 Then nMonth = Now.Month
        If nDay < 1 Or nDay > 31 Then nDay = Now.Day

        If nHour < 0 Or nHour > 23 Then nHour = Now.Hour
        If nMinute < 0 Or nMinute > 59 Then nMinute = Now.Minute
        If nSecond < 0 Or nSecond > 59 Then nSecond = Now.Second

        Dim date2 As System.DateTime
        date2 = New DateTime(nYear, nMonth, nDay, nHour, nMinute, nSecond)
        SmartConfigs1.ControlPanel.SetSystemDateTime(date2)
        SmartConfigs1.RegistryAllSave()

    End Sub

#End Region

#Region "통신"

    Private Sub btnCommSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommSave.Click
        If MsgBox("변경 내용을 적용하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "옵션") <> MsgBoxResult.Yes Then Exit Sub


        If EMS_수신포트 <> Val(lbCommEMSPort.Text) Then
            EMS_수신포트 = Val(lbCommEMSPort.Text)
            설정변경_EMS = True
        End If

        If PCS_통신포트 <> cbPCS통신포트.SelectedItem & "" Then
            PCS_통신포트 = cbPCS통신포트.SelectedItem & ""
            설정변경_PCS = True
        End If

        If PCS_통신주기 <> Val(cbPCS통신주기.SelectedItem & "") Then
            PCS_통신주기 = Val(cbPCS통신주기.SelectedItem & "")
            설정변경_PCS = True
        End If


        If PCS_통신주기 <> Val(cbPCS통신주기.SelectedItem & "") Then
            PCS_통신주기 = Val(cbPCS통신주기.SelectedItem & "")
            설정변경_PCS = True
        End If

        If RadioButton1.Checked = True Then
            PMS_통신ID = 1
        Else
            PMS_통신ID = 2
        End If

        Dim pINI As New IniFile(CONFIG_FILE)

        pINI.SetKeyValue("EMS", "수신포트", EMS_수신포트.ToString)

        pINI.SetKeyValue("PMS", "통신ID", PMS_통신ID.ToString)

        pINI.SetKeyValue("PCS", "통신포트", PCS_통신포트)
        pINI.SetKeyValue("PCS", "통신주기", PCS_통신주기.ToString)


        pINI.SetKeyValue("BMS", "통신포트", BMS_통신포트)
        pINI.SetKeyValue("BMS", "통신주기", BMS_통신주기.ToString)
        pINI.Save(CONFIG_FILE)

        If 설정변경_EMS = True Or 설정변경_PCS = True Then
            설정변경_통신 = True
        End If
    End Sub

#End Region

#Region "네트워크"
    Private Sub LoadNetworkStatus()

        'Dim mKeyName As String = "Comm\CS89001\Parms\Tcpip"
        'Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(mKeyName, False)

        'If regKey IsNot Nothing Then

        '    Dim nEnableDHCP = regKey.GetValue("EnableDHCP")

        '    If nEnableDHCP = 1 Then
        '        rbNetworkDHCP.Checked = True

        '        Dim szIPAddress() As String = regKey.GetValue("DhcpIPAddress")
        '        Dim szSubnetMask() As String = regKey.GetValue("DhcpSubnetMask")
        '        Dim szGateway() As String = regKey.GetValue("DhcpDefaultGateway")
        '        Dim szDNS() As String = regKey.GetValue("DhcpDNS")

        '        If Not szIPAddress Is Nothing Then lbNetworkIPAddress.Text = szIPAddress(0)
        '        If Not szSubnetMask Is Nothing Then lbNetworkSubnet.Text = szSubnetMask(0)
        '        If Not szGateway Is Nothing Then lbNetworkGateway.Text = szGateway(0)
        '        If Not szDNS Is Nothing Then lbNetworkDNS.Text = szDNS(0)

        '        lbNetworkIPAddress.BackColor = Color.Gray
        '        lbNetworkSubnet.BackColor = Color.Gray
        '        lbNetworkGateway.BackColor = Color.Gray
        '        lbNetworkDNS.BackColor = Color.Gray

        '        lbNetworkIPAddress.Invalidate()
        '        lbNetworkSubnet.Invalidate()
        '        lbNetworkGateway.Invalidate()
        '        lbNetworkDNS.Invalidate()

        '    Else
        '        rbNetworkStatic.Checked = True


        '        Dim szIPAddress As String = ""
        '        Dim szSubnetMask As String = ""
        '        Dim szGateway As String = ""
        '        Dim szDNS As String = ""

        '        Dim bLoadNetworkInfo As Boolean = False
        '        Try

        '            Dim szTempIPAddress() As String = regKey.GetValue("IPAddress")
        '            Dim szTempSubnetMask() As String = regKey.GetValue("SubnetMask")
        '            Dim szTempGateway() As String = regKey.GetValue("DefaultGateway")
        '            Dim szTempDNS() As String = regKey.GetValue("DNS")

        '            szIPAddress = szTempIPAddress(0)
        '            szSubnetMask = szTempSubnetMask(0)
        '            szGateway = szTempGateway(0)
        '            szDNS = szTempDNS(0)

        '            bLoadNetworkInfo = True
        '        Catch ex As Exception
        '        End Try


        '        If bLoadNetworkInfo = False Then
        '            Try

        '                Dim szTempIPAddress As String = regKey.GetValue("IPAddress")
        '                Dim szTempSubnetMask As String = regKey.GetValue("SubnetMask")
        '                Dim szTempGateway As String = regKey.GetValue("DefaultGateway")
        '                Dim szTempDNS As String = regKey.GetValue("DNS")

        '                szIPAddress = szTempIPAddress
        '                szSubnetMask = szTempSubnetMask
        '                szGateway = szTempGateway
        '                szDNS = szTempDNS

        '                bLoadNetworkInfo = True

        '            Catch ex As Exception

        '            End Try
        '        End If


        '        lbNetworkIPAddress.Text = szIPAddress
        '        lbNetworkSubnet.Text = szSubnetMask
        '        lbNetworkGateway.Text = szGateway
        '        lbNetworkDNS.Text = szDNS


        '        lbNetworkIPAddress.BackColor = Color.WhiteSmoke
        '        lbNetworkSubnet.BackColor = Color.WhiteSmoke
        '        lbNetworkGateway.BackColor = Color.WhiteSmoke
        '        lbNetworkDNS.BackColor = Color.WhiteSmoke

        '        lbNetworkIPAddress.Invalidate()
        '        lbNetworkSubnet.Invalidate()
        '        lbNetworkGateway.Invalidate()
        '        lbNetworkDNS.Invalidate()

        '        End If

        'End If

        rbNetworkDHCP.Checked = IIf((SmartConfigs1.IPSettings.DHCPEnable = 0), False, True)

        Try

            '고정IP던지 DHCP던지 불러와야하는 부분
            lbNetworkIPAddress.Text = SmartConfigs1.IPSettings.DeviceIP
            lbNetworkGateway.Text = SmartConfigs1.IPSettings.GateWay
            lbNetworkSubnet.Text = SmartConfigs1.IPSettings.SubNetMask

            'IEC가 고정IP인 경우 IEC에 설정된 DNS와 WINS를 불러온다.
            'IEC가 DHCP인 경우 IEC의 DNS와 WINS 값을 불러오지 않는다.
            If (SmartConfigs1.IPSettings.DHCPEnable = 0) Then
                lbNetworkDNS.Text = SmartConfigs1.IPSettings.PrimaryDNS
            End If

        Catch ex As Exception
            rbNetworkDHCP.Checked = True

            btnNetworkSave_Click(btnNetworkSave, EventArgs.Empty)
        End Try

    End Sub

    Private Sub rbNetworkDHCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNetworkDHCP.CheckedChanged
        HideKeyPad()

        lbNetworkIPAddress.BackColor = Color.Gray
        lbNetworkSubnet.BackColor = Color.Gray
        lbNetworkGateway.BackColor = Color.Gray
        lbNetworkDNS.BackColor = Color.Gray

        lbNetworkIPAddress.Invalidate()
        lbNetworkSubnet.Invalidate()
        lbNetworkGateway.Invalidate()
        lbNetworkDNS.Invalidate()

        lbNetworkIPAddress.UseKeyPad = False
        lbNetworkSubnet.UseKeyPad = False
        lbNetworkGateway.UseKeyPad = False
        lbNetworkDNS.UseKeyPad = False


    End Sub

    Private Sub rbNetworkStatic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNetworkStatic.CheckedChanged

        lbNetworkIPAddress.BackColor = Color.WhiteSmoke
        lbNetworkSubnet.BackColor = Color.WhiteSmoke
        lbNetworkGateway.BackColor = Color.WhiteSmoke
        lbNetworkDNS.BackColor = Color.WhiteSmoke

        lbNetworkIPAddress.Invalidate()
        lbNetworkSubnet.Invalidate()
        lbNetworkGateway.Invalidate()
        lbNetworkDNS.Invalidate()

        lbNetworkIPAddress.UseKeyPad = True
        lbNetworkSubnet.UseKeyPad = True
        lbNetworkGateway.UseKeyPad = True
        lbNetworkDNS.UseKeyPad = True

    End Sub

    Private Sub btnNetworkSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetworkSave.Click
      
        'Try
        '    If rbNetworkDHCP.Checked = True Then
        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "EnableDHCP", 1)

        '    Else
        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "EnableDHCP", 0)

        '        Dim szIPAddress As String = lbNetworkIPAddress.Text
        '        Dim szSubnetMask As String = lbNetworkSubnet.Text
        '        Dim szGateway As String = lbNetworkGateway.Text
        '        Dim szDNS As String = lbNetworkDNS.Text

        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "IPAddress", szIPAddress)
        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "SubnetMask", szSubnetMask)
        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "DefaultGateway", szGateway)
        '        Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\CS89001\Parms\Tcpip", "DNS", szDNS)


        '    End If

        '    If MsgBox("설정이 변경되었습니다." & vbCrLf & "재시작 하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "확인") = MsgBoxResult.Yes Then
        '        SmartConfigs1.Powers.ReBoot()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


        ' 설정된 IP관련 주소 저장 하기 
        SmartConfigs1.IPSettings.DHCPEnable = IIf((rbNetworkDHCP.Checked = True), 1, 0)

        '고정IP로 IEC를 셋팅하는경우
        If (rbNetworkDHCP.Checked = False) Then
            SmartConfigs1.IPSettings.DeviceIP = lbNetworkIPAddress.Text
            SmartConfigs1.IPSettings.GateWay = lbNetworkGateway.Text
            SmartConfigs1.IPSettings.SubNetMask = lbNetworkSubnet.Text

            SmartConfigs1.IPSettings.PrimaryDNS = lbNetworkDNS.Text
            SmartConfigs1.IPSettings.PrimaryWINS = ""
            SmartConfigs1.IPSettings.SecondaryDNS = "168.126.63.2"
            SmartConfigs1.IPSettings.SecondaryWINS = ""
        End If

        ' 레지스트리에 저장하기. 시스템을 다시시작 할 경우 설정된 IP관련 주소 유지됨
        SmartConfigs1.IPSettings.Save()

        ' 변경된 IP주소값을 적용하기 위해 Network Driver를 Rebind 처리 합니다.
        SmartConfigs1.IPSettings.SetApply()

    End Sub

#End Region

#Region "업데이트"

    '    Private Sub btnUpdateSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateSave.Click

    '        If MsgBox("업데이트를 진행하시겠습니까?" & vbCrLf & "업데이트 완료 후 프로그램을 재시작 합니다.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "확인") = MsgBoxResult.Yes Then

    '            Application.DoEvents()

    '            Cursor.Current = Cursors.WaitCursor

    '            Dim szFilePath As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
    '            Dim szCurrentPath As String = System.IO.Path.GetDirectoryName(szFilePath)


    '            Dim szPath As String = String.Format("{0}\Upgrade", szCurrentPath)
    '            Dim bPathCheck As Boolean = System.IO.Directory.Exists(szPath)

    '            If bPathCheck = False Then
    '                System.IO.Directory.CreateDirectory(szPath)
    '            End If

    '            bPathCheck = System.IO.Directory.Exists(szPath)


    '            Try
    '                Dim szOldFiles() As String = System.IO.Directory.GetFiles(szPath)
    '                For Each szOldFile As String In szOldFiles
    '                    System.IO.File.Delete(szOldFile)
    '                Next
    '            Catch ex As Exception
    '                Debug.WriteLine(ex.ToString)
    '            End Try


    '            Dim alFileList As ArrayList = GetFileList()


    '            For nFile As Integer = 0 To alFileList.Count - 1
    '                Dim szFileName As String = "   " & alFileList.Item(nFile)

    '                szFileName = szFileName.Trim
    '                Dim szURL As String = String.Format("http://versystem.iptime.org:8000/VersionUpdate/{0}/{1}/{2}/{3}", UPDATECOMPANY, UPDATEPROGRAM, UPDATEPROJECT, szFileName)
    '                Dim szLocalFile As String = String.Format("{0}\{1}", szPath, szFileName)

    '                DownloadFile(szURL, szLocalFile)

    '                Dim szDstFile As String = String.Format("{0}\{1}", szCurrentPath, szFileName)
    '                Dim szTempFile As String = String.Format("{0}\{1}_OLDFILE", szCurrentPath, szFileName)

    '                If System.IO.File.Exists(szTempFile) = True Then
    '                    System.IO.File.Delete(szTempFile)
    '                End If

    '                If System.IO.File.Exists(szDstFile) = True Then
    '                    System.IO.File.Move(szDstFile, szTempFile)
    '                End If

    '                If System.IO.File.Exists(szLocalFile) = True Then
    '                    System.IO.File.Copy(szLocalFile, szDstFile)
    '                End If

    '            Next

    '            SmartConfigs1.Powers.ReBoot()

    '        End If

    '    End Sub


    'Private UPDATECOMPANY As String = "EPS"
    'Private UPDATEPROGRAM As String = "PMS"
    'Private UPDATEPROJECT As String = "Project_1606001"


    'Private Function GetFileList() As ArrayList
    '    Dim alFileList As New ArrayList

    '    Try

    '        Dim szURL As String = String.Format("http://versystem.iptime.org:8000/VersionUpdate/{0}/{1}/{2}/FileList.txt", UPDATECOMPANY, UPDATEPROGRAM, UPDATEPROJECT)

    '        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create(szURL)
    '        httpRequest.Credentials = CredentialCache.DefaultCredentials

    '        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()

    '        Dim dataStream As System.IO.Stream = httpResponse.GetResponseStream()

    '        Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(dataStream)

    '        Dim forecastData As String = streamReader.ReadToEnd()

    '        streamReader.Close()
    '        httpResponse.Close()

    '        Dim szFiles() As String = forecastData.Split(vbCrLf)

    '        For Each szFileName As String In szFiles
    '            alFileList.Add(szFileName.Trim)
    '        Next
    '    Catch ex As Exception

    '    End Try

    '    Return alFileList
    'End Function

    'Private Function DownloadFile(ByVal url As String, ByVal filename As String) As Boolean
    '    Dim request As HttpWebRequest = WebRequest.Create(url)
    '    request.Timeout = 10000
    '    request.ReadWriteTimeout = 10000

    '    Try

    '        Dim nTotal As Integer = 0
    '        Using response As HttpWebResponse = request.GetResponse()
    '            Using receiveStream As Stream = response.GetResponseStream()
    '                Dim nFileSize As Integer = response.ContentLength
    '                Using recvFIle As Stream = File.OpenWrite(filename)
    '                    Dim buffer(8 * 1024) As Byte
    '                    Dim len As Integer = 0
    '                    While True
    '                        len = receiveStream.Read(buffer, 0, buffer.Length)
    '                        If len <= 0 Then Exit While

    '                        recvFIle.Write(buffer, 0, len)
    '                        nTotal += len

    '                        UpdateDownloadState(total, Size)
    '                    End While

    '                End Using
    '            End Using
    '        End Using

    '    Catch ex As Exception
    '        Debug.WriteLine(ex.ToString)
    '    End Try

    'End Function
#End Region

#Region "스크린"

    Private Sub VsPictureButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton1.Click
        SmartConfigs1.Display.BacklightControlDialogBox()
        SmartConfigs1.RegistryAllSave()
    End Sub

    Private Sub VsPictureButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton2.Click
        SmartConfigs1.ControlPanel.TouchCalibration()
        SmartConfigs1.RegistryAllSave()
    End Sub

#End Region

#Region "언어"

#End Region


    Private Sub pnlDateTime_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlDateTime.GotFocus

    End Sub

    Private Sub Label7_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbBMS통신주기_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VsPictureButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton3.Click
        If MsgBox("프로그램을 종료 하시겠습니까?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "알림") = MsgBoxResult.Yes Then
            Application.Exit()


        End If
    End Sub

End Class

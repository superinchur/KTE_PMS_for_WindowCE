Imports System.Net
Imports System.IO

Public Class 메인화면
    Private pHistorySave As New 클래스_이력저장

    Private nComm_PCS As Integer = 0
    Private nComm_PCS_Image As Integer = 0

    Private nComm_EMS As Integer = 0
    Private nComm_EMS_Image As Integer = 0


    Private nCurrentMenu As Integer = 0
    Private pProcessVNC As Process = Nothing

    Private qRecvFault As New Queue


    Declare Function FindWindow Lib "coredll.dll" (ByVal className As String, ByVal windowName As String) As Integer
    Declare Function ShowWindow Lib "coredll.dll" (ByVal hWnd As Integer, ByVal nCmdShow As Integer) As Integer
    Declare Function EnableWindow Lib "coredll.dll" (ByVal hwnd As Integer, ByVal bEnable As Boolean) As Integer

    Private Sub 메인화면_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Dim hWnd As Integer
        'hWnd = FindWindow("HHTaskBar".ToCharArray(), Nothing)
        'EnableWindow(hWnd, True)
        'ShowWindow(hWnd, 1)

    End Sub


    Public Sub New()

        Try

            ' 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent()

            ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim hWnd As Integer

        'SmartConfigs1.Display.SystemFontClearType = False

        '        hWnd = FindWindow("HHTaskBar".ToCharArray(), Nothing)
        'EnableWindow(hWnd, False)
        'ShowWindow(hWnd, 0)


        'SmartWatchDog1.RebootInterval = 30
        'SmartWatchDog1.Start()


        'FormBorderStyle = Windows.Forms.FormBorderStyle.None

        cBMS_Rack(1).Rack_SOC = 100

        Me.Width = 800
        Me.Height = 480
        Me.Left = 0
        Me.Top = 0

        '화면_고장.Visible = False

        시스템초기화()

        '타이머_상태.Interval = 1
        '타이머_상태.Enabled = True

        Panel1.BackColor = Color.White
        'pnlWorkArea.BackColor = Panel1.BackColor

        통신시작()

        Wnd서브화면1_메인1.Visible = False
        Wnd서브화면2_배터리1.Visible = False
        Wnd서브화면3_수요관리1.Visible = False
        Wnd서브화면4_소비1.Visible = False
        Wnd서브화면5_사용모드1.Visible = False
        Wnd서브화면6_이력1.Visible = False
        Wnd서브화면7_설정1.Visible = False
        Wnd서브화면8_고장1.Visible = False


        SetButtonStatus(1)

        Try
            If PCS_통신포트 = "COM2" Then
                SerialPort_Debug.PortName = "COM3"
            Else
                SerialPort_Debug.PortName = "COM2"
            End If
            SerialPort_Debug.BaudRate = 57600
            SerialPort_Debug.Parity = IO.Ports.Parity.None
            SerialPort_Debug.DataBits = 8
            SerialPort_Debug.StopBits = IO.Ports.StopBits.One

            Try
                SerialPort_Debug.Open()
            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub 시스템초기화()


        Dim szFilePath As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
        Dim szPath As String = System.IO.Path.GetDirectoryName(szFilePath)

        CONFIG_FILE = String.Format("{0}\pms.ini", szPath)

        MsgBox(CONFIG_FILE)

        
        If System.IO.File.Exists(CONFIG_FILE) = True Then
            Dim pINI As New IniFile(CONFIG_FILE)

            EMS_수신포트 = Val(pINI.GetKeyValue("EMS", "수신포트") & "")
            PMS_통신ID = Val(pINI.GetKeyValue("PMS", "통신ID") & "")
            PCS_통신포트 = pINI.GetKeyValue("PCS", "통신포트") & ""
            PCS_통신주기 = Val(pINI.GetKeyValue("PCS", "통신주기") & "")
        Else
            EMS_수신포트 = 502
            PMS_통신ID = 1
            PCS_통신포트 = "COM2"
            PCS_통신주기 = 500
        End If

        If EMS_수신포트 = 0 Then EMS_수신포트 = 502
        If PMS_통신ID = 0 Then PMS_통신ID = 1
        If PCS_통신포트 = "" Then PCS_통신포트 = "COM2"
        If PCS_통신주기 = 0 Then PCS_통신주기 = 500

        ' 스마트리모트 실행
        SmartRemote1.Start()

        타이머_통신상태.Enabled = False
        타이머_통신상태.Interval = 500
        타이머_통신상태.Enabled = True


        ' 피크컷 정보 설정
        ReDim 사용모드_피크컷시간(2, 4)

        If System.IO.File.Exists(CONFIG_FILE) = True Then
            Dim pINI As New IniFile(CONFIG_FILE)

            사용모드_로드파워 = Val(pINI.GetKeyValue("사용모드", "로드파워") & "")
            사용모드_피크컷 = Val(pINI.GetKeyValue("사용모드", "피크컷") & "")

            사용모드_피크컷시간(1, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작시") & "")  ' 피크컷시간1 - 시작 시
            사용모드_피크컷시간(1, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작분") & "")  ' 피크컷시간1 - 시작 분
            사용모드_피크컷시간(1, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료시") & "")  ' 피크컷시간1 - 종료 시
            사용모드_피크컷시간(1, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료분") & "")  ' 피크컷시간1 - 종료 분

            사용모드_피크컷시간(2, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작시") & "")  ' 피크컷시간2 - 시작 시
            사용모드_피크컷시간(2, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작분") & "")  ' 피크컷시간2 - 시작 분
            사용모드_피크컷시간(2, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료시") & "")  ' 피크컷시간2 - 종료 시
            사용모드_피크컷시간(2, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료분") & "")  ' 피크컷시간2 - 종료 분

            사용모드_유효전력 = Val(pINI.GetKeyValue("사용모드", "유효전력") & "")
            사용모드_무효전력 = Val(pINI.GetKeyValue("사용모드", "무효전력") & "")

            사용모드_배터리_충전시작 = Val(pINI.GetKeyValue("사용모드", "배터리충전시작") & "")
            사용모드_배터리_방전중지 = Val(pINI.GetKeyValue("사용모드", "배터리방전중지") & "")
            사용모드_배터리_충전전류 = Val(pINI.GetKeyValue("사용모드", "배터리충전전류") & "")
            사용모드_배터리_충전전압 = Val(pINI.GetKeyValue("사용모드", "배터리충전전압") & "")

            사용모드_로드파워 = ""
            사용모드_피크컷 = ""

            사용모드_피크컷시간(1, 1) = ""
            사용모드_피크컷시간(1, 2) = ""
            사용모드_피크컷시간(1, 3) = ""
            사용모드_피크컷시간(1, 4) = ""

            사용모드_피크컷시간(2, 1) = ""
            사용모드_피크컷시간(2, 2) = ""
            사용모드_피크컷시간(2, 3) = ""
            사용모드_피크컷시간(2, 4) = ""

            사용모드_유효전력 = ""
            사용모드_무효전력 = ""

            사용모드_배터리_충전시작 = ""
            사용모드_배터리_방전중지 = ""
            사용모드_배터리_충전전류 = ""
            사용모드_배터리_충전전압 = ""
        End If

        '배터리사용량_초기화()


    End Sub

    Private tLastCheckHour As Integer = -1
    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick

    End Sub

    Private Sub 판넬_기본_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim 판넬 As Panel = sender
        Using pPen As New System.Drawing.Pen(Color.Gray, 1)
            e.Graphics.DrawRectangle(pPen, 0, 0, 판넬.Width - 1, 판넬.Height - 1)
        End Using
    End Sub


#Region "통신"
    Private EMS수신서버 As EMS통신서버 = Nothing
    Private PCS통신 As PCS통신 = Nothing
    Private BMS클라이언트 As BMS클라이언트 = Nothing

    Private Sub 통신시작()
        'EMS수신서버 = New EMS통신서버
        'AddHandler EMS수신서버.DataArrived, AddressOf EMS_DataArrived

        PCS통신 = New PCS통신
        AddHandler PCS통신.DataArrived, AddressOf PCS_DataArrived

        BMS클라이언트 = New BMS클라이언트
        'AddHandler BMS클라이언트.DataArrived, AddressOf BMS_DataArrived

        'EMS_통신시작()
        PCS_통신시작()
        BMS_통신시작()

        타이머_사용모드.Interval = 1000
        타이머_사용모드.Enabled = True
    End Sub

    Public Sub EMS_DataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        Dim szMessage As String = String.Format("[{0}] {1} : ", Format(Now, "HH:mm:ss"), szMode)
        For i As Integer = 0 To nLength - 1
            szMessage &= String.Format("{0:X2} ", btData(i))
        Next

        EMS_DataDisplay(szMode, szMessage)


    End Sub

    Private nStatus_Step_EMS As Integer = 0

    Delegate Sub EMS_DataDisplayCallback(ByVal szMode As String, ByVal szMessage As String)
    Private Sub EMS_DataDisplay(ByVal szMode As String, ByVal szMessage As String)
        If Me.InvokeRequired Then
            Dim d As New EMS_DataDisplayCallback(AddressOf EMS_DataDisplay)
            Me.Invoke(d, New Object() {szMode, szMessage})
        Else
            If SerialPort_Debug.IsOpen = True And bDebug_EMS Then
                SerialPort_Debug.Write(vbCrLf)
                SerialPort_Debug.Write("EMS => " & szMessage)
            End If

        End If
    End Sub

    Public Sub PCS_DataArrived(ByVal szComPort As String, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        Dim szMessage As String = String.Format("[{0}] {1} : ", Format(Now, "HH:mm:ss"), szMode)
        For i As Integer = 0 To nLength - 1
            szMessage &= String.Format("{0:X2} ", btData(i))
        Next

        PCS_DataDisplay(szMode, szMessage)

        Debug.WriteLine(szMessage)



    End Sub

    Private nStatus_Step_PCS As Integer = 0

    Delegate Sub PCS_DataDisplayCallback(ByVal szMode As String, ByVal szMessage As String)
    Private Sub PCS_DataDisplay(ByVal szMode As String, ByVal szMessage As String)
        If Me.InvokeRequired Then
            Dim d As New PCS_DataDisplayCallback(AddressOf PCS_DataDisplay)
            Me.Invoke(d, New Object() {szMode, szMessage})
        Else

            If SerialPort_Debug.IsOpen = True And bDebug_PCS Then
                SerialPort_Debug.Write(vbCrLf)
                SerialPort_Debug.Write("PCS => " & szMessage)
            End If

            If szMode = "RX" Then
                nStatus_Step_PCS += 1
                If nStatus_Step_PCS > 5 Then
                    nStatus_Step_PCS = 1
                End If

                For nFileNo As Integer = 35 To 37
                    Dim ushValue As UShort = GetModbusData_Ushort(nFileNo)

                    For nBit As Integer = 0 To 15
                        Dim nStatus As Integer = ushValue >> nBit And &H1

                        If Val(FAULT_STATUS(nFileNo, nBit, 0) & "") <> nStatus Then

                            Dim szFaultCode As String = String.Format("{0}_{1}", nFileNo, nBit)

                            '화면_고장
                            Dim szFaultText As String = GetFaultText(nFileNo, nBit)

                            Dim tCurrent As Date = Now

                            If nStatus = 0 Then
                                ' 해제
                                FAULT_STATUS(nFileNo, nBit, 0) = nStatus.ToString
                                FAULT_STATUS(nFileNo, nBit, 1) = ""

                                Dim szFault As String = String.Format("{0}|{1}|{2}|{3}|{4}", Format(tCurrent, "yyyy-MM-dd"), Format(tCurrent, "hh:mm:ss"), nFileNo, String.Format("[0x{0:X2}] {1}", nBit, szFaultText), "해제")
                                qRecvFault.Enqueue(szFault)

                                htCurrentFault(szFaultCode) = ""

                            Else
                                ' 발생

                                FAULT_STATUS(nFileNo, nBit, 0) = nStatus.ToString
                                FAULT_STATUS(nFileNo, nBit, 1) = Format(Now, "yyyy-MM-dd HH:mm:ss")

                                Dim szFault As String = String.Format("{0}|{1}|{2}|{3}|{4}", Format(tCurrent, "yyyy-MM-dd"), Format(tCurrent, "hh:mm:ss"), nFileNo, String.Format("[0x{0:X2}] {1}", nBit, szFaultText), "발생")
                                qRecvFault.Enqueue(szFault)

                                szFault = String.Format("{0}|{1}|{2}", Format(tCurrent, "yyyy-MM-dd"), Format(tCurrent, "hh:mm:ss"), szFaultText)
                                htCurrentFault(szFaultCode) = szFault

                            End If

                        End If
                    Next
                Next
            End If
        End If
    End Sub


    Private Sub EMS_통신시작()
        EMS수신서버.ServiceStart()
    End Sub

    Private Sub PCS_통신시작()
        PCS통신.ServiceStart()
    End Sub

    Private Sub BMS_통신시작()
        BMS클라이언트.ServiceStart()
    End Sub
    Private Sub 판넬_통신상태_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles 판넬_통신상태.Paint
        Dim 판넬 As Panel = sender
        Using pPen As New System.Drawing.Pen(Color.Gray, 1)
            e.Graphics.DrawRectangle(pPen, 0, 0, 판넬.Width - 1, 판넬.Height - 1)
        End Using
    End Sub
#End Region


    Private Sub SetButtonStatus(ByVal nSelect As Integer)

        Select Case nCurrentMenu
            Case 1
                버튼_화면전환_메인.Enabled = True
                Wnd서브화면1_메인1.Visible = False
            Case 2
                버튼_화면전환_배터리.Enabled = True
                Wnd서브화면2_배터리1.Visible = False
            Case 3
                버튼_화면전환_수요관리.Enabled = True
                Wnd서브화면3_수요관리1.Visible = False
            Case 4
                버튼_화면전환_소비.Enabled = True
                Wnd서브화면4_소비1.Visible = False
            Case 5
                버튼_화면전환_사용모드.Enabled = True
                Wnd서브화면5_사용모드1.Visible = False
            Case 6
                버튼_화면전환_이력.Enabled = True
                Wnd서브화면6_이력1.Visible = False
            Case 7
                버튼_화면전환_설정.Enabled = True
                Wnd서브화면7_설정1.Visible = False
            Case 8
                VsPictureButton8.Enabled = True
                Wnd서브화면8_고장1.Visible = False
            Case 21

                Wnd서브화면8_고장1.Visible = False


        End Select

        nCurrentMenu = nSelect

        Select Case nCurrentMenu
            Case 1
                버튼_화면전환_메인.Enabled = False

                Wnd서브화면1_메인1.Visible = True
                If Wnd서브화면1_메인1.Dock <> DockStyle.Fill Then
                    Wnd서브화면1_메인1.Dock = DockStyle.Fill
                End If
            Case 2
                버튼_화면전환_배터리.Enabled = False

                Wnd서브화면2_배터리1.Visible = True
                If Wnd서브화면2_배터리1.Dock <> DockStyle.Fill Then
                    Wnd서브화면2_배터리1.Dock = DockStyle.Fill
                End If
            Case 3
                버튼_화면전환_수요관리.Enabled = False

                Wnd서브화면3_수요관리1.Visible = True
                If Wnd서브화면3_수요관리1.Dock <> DockStyle.Fill Then
                    Wnd서브화면3_수요관리1.Dock = DockStyle.Fill
                End If
            Case 4
                버튼_화면전환_소비.Enabled = False

                Wnd서브화면4_소비1.Visible = True
                If Wnd서브화면4_소비1.Dock <> DockStyle.Fill Then
                    Wnd서브화면4_소비1.Dock = DockStyle.Fill
                End If
            Case 5
                버튼_화면전환_사용모드.Enabled = False

                Wnd서브화면5_사용모드1.Visible = True
                'Wnd서브화면5_사용모드1.설정값불러오기()
                If Wnd서브화면5_사용모드1.Dock <> DockStyle.Fill Then
                    Wnd서브화면5_사용모드1.Dock = DockStyle.Fill
                End If
            Case 6
                버튼_화면전환_이력.Enabled = False

                Wnd서브화면6_이력1.Visible = True
                If Wnd서브화면6_이력1.Dock <> DockStyle.Fill Then
                    Wnd서브화면6_이력1.Dock = DockStyle.Fill
                End If

                Wnd서브화면6_이력1.InitScreen()

            Case 7
                버튼_화면전환_설정.Enabled = False

                Wnd서브화면7_설정1.Visible = True
                If Wnd서브화면7_설정1.Dock <> DockStyle.Fill Then
                    Wnd서브화면7_설정1.Dock = DockStyle.Fill
                End If
                Wnd서브화면7_설정1.InitScreen()

            Case 8
                VsPictureButton8.Enabled = False

                Wnd서브화면8_고장1.Visible = True
                If Wnd서브화면8_고장1.Dock <> DockStyle.Fill Then
                    Wnd서브화면8_고장1.Dock = DockStyle.Fill
                End If

                Wnd서브화면8_고장1.LoadCurrentFault()
        End Select
    End Sub

    Private Sub SmartWatchDog1_OnTimeOutEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmartWatchDog1.OnTimeOutEvent
        '' 시스템을 다시 시작하기 전에 로그파일에 정보를 기록합니다.
        Try
            'pHistory.ControlEventSave("오류", "WATCHDOG", "처리 되지 않은 예외로 시스템 다시 시작")
        Catch exp As Exception
            Debug.WriteLine(exp.ToString())
        End Try
    End Sub

    Private Sub 타이머_통신상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_통신상태.Tick

    End Sub

    Private Sub VsPictureButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_메인.Click
        SetButtonStatus(1)
    End Sub

    Private Sub VsPictureButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_배터리.Click
        'SmartConfigs1.Display.BacklightControl(SmartX.CDisplay.OnOff.OFF)
        BMS현재통신모드 = BMS통신모드정의.BankInfo

        SetButtonStatus(2)
    End Sub

    Private Sub VsPictureButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_수요관리.Click
        SetButtonStatus(3)
    End Sub

    Private Sub VsPictureButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_소비.Click
        SetButtonStatus(4)
    End Sub

    Private Sub VsPictureButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_사용모드.Click
        SetButtonStatus(5)
    End Sub

    Private Sub VsPictureButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_이력.Click
        SetButtonStatus(6)
    End Sub

    Private Sub VsPictureButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_설정.Click
        SetButtonStatus(7)
    End Sub

    Private Sub VsPictureButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton8.Click
        SetButtonStatus(8)
    End Sub

    'Private Sub 화면_고장_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles 화면_고장.Paint

    'e.Graphics.DrawRectangle(New Pen(Color.Gray, 1), 0, 0, 화면_고장.Width - 1, 화면_고장.Height - 1)
    'e.Graphics.DrawRectangle(New Pen(Color.Green, 1), 1, 1, 화면_고장.Width - 2, 화면_고장.Height - 2)

    'End Sub

    'Private Sub VsPictureButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton1.Click
    'ListView1.Items.Clear()
    '        화면_고장.Visible = False
    '    End Sub

    Private bDebug_EMS As Boolean = False
    Private bDebug_PCS As Boolean = False

    Private Sub SerialPort_Debug_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_Debug.DataReceived

    End Sub

    Private nRunModeCheck As Integer = -1
    Private Sub 타이머_사용모드_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_사용모드.Tick

    End Sub
End Class

Imports System.Net
Imports System.IO

Public Class 메인화면
    Private pHistorySave As New 클래스_이력저장

    Private nComm_PCS As Integer = 0
    Private nComm_PCS_Image As Integer = 0

    Private nComm_EMS As Integer = 0
    Private nComm_EMS_Image As Integer = 0


    Private nComm_BMS As Integer = 0
    Private nComm_BMS_Image As Integer = 0

    Private nCurrentMenu As Integer = 0
    Private pProcessVNC As Process = Nothing


    Private flag_PCS_CommFault As Boolean = False
    Declare Function FindWindow Lib "coredll.dll" (ByVal className As String, ByVal windowName As String) As Integer
    Declare Function ShowWindow Lib "coredll.dll" (ByVal hWnd As Integer, ByVal nCmdShow As Integer) As Integer
    Declare Function EnableWindow Lib "coredll.dll" (ByVal hwnd As Integer, ByVal bEnable As Boolean) As Integer

    Private Sub 메인화면_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim hWnd As Integer
        hWnd = FindWindow("HHTaskBar".ToCharArray(), Nothing)
        EnableWindow(hWnd, True)
        ShowWindow(hWnd, 1)
    End Sub

    Public Sub New()
        Try
            ' 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent()
            ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        화면초기화()
        시스템초기화()
        통신시작()

        SetButtonStatus(1)
    End Sub

    Private Sub 화면초기화()
        Dim hWnd As Integer

        SmartConfigs1.Display.SystemFontClearType = False

        hWnd = FindWindow("HHTaskBar".ToCharArray(), Nothing)
        EnableWindow(hWnd, False)
        ShowWindow(hWnd, 0)

        SmartWatchDog1.RebootInterval = 30
        SmartWatchDog1.Start()

        FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.Width = 800
        Me.Height = 480
        Me.Left = 0
        Me.Top = 0

        화면_고장.Visible = False
        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True

        Panel1.BackColor = Color.White
        pnlWorkArea.BackColor = Panel1.BackColor

        Uc서브화면1_메인1.Visible = False
        Uc서브화면2_배터리1.Visible = False
        Uc서브화면3_수요관리1.Visible = False
        Uc서브화면4_소비1.Visible = False
        Uc서브화면5_사용모드1.Visible = False
        Uc서브화면6_이력1.Visible = False
        Uc서브화면7_설정1.Visible = False
        Uc서브화면8_고장1.Visible = False


    End Sub
    Private Sub 시스템초기화()
        
        Dim szFilePath As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
        Dim szPath As String = System.IO.Path.GetDirectoryName(szFilePath)

        CONFIG_FILE = String.Format("{0}\pms.ini", szPath)
        CONFIG_FILE1 = String.Format("{0}\pms1.ini", szPath)
        CONFIG_FILE2 = String.Format("{0}\pms2.ini", szPath)
        CONFIG_FILE3 = String.Format("{0}\pms3.ini", szPath)
        CONFIG_FILE4 = String.Format("{0}\pms4.ini", szPath)

        num_Module = 1
        num_Rack = 1
        'MsgBox(CONFIG_FILE)
        ' 변수 초기화

        If System.IO.File.Exists(CONFIG_FILE) = True Then
            Dim pINI As New IniFile(CONFIG_FILE)

            EMS_수신포트 = Val(pINI.GetKeyValue("EMS", "수신포트") & "")
            PMS_통신ID = Val(pINI.GetKeyValue("PMS", "통신ID") & "")
            PCS_통신포트 = pINI.GetKeyValue("PCS", "통신포트") & ""
            PCS_통신주기 = Val(pINI.GetKeyValue("PCS", "통신주기") & "")
        Else
            EMS_수신포트 = 503
            PMS_통신ID = 1
            PCS_통신포트 = "COM2"
            PCS_통신주기 = 500
        End If

        If EMS_수신포트 = 0 Then EMS_수신포트 = 503
        If PMS_통신ID = 0 Then PMS_통신ID = 1
        If PCS_통신포트 = "" Then PCS_통신포트 = "COM2"
        If PCS_통신주기 = 0 Then PCS_통신주기 = 500

        ' 스마트리모트 실행
        SmartRemote1.Start()

        타이머_통신상태.Enabled = False
        타이머_통신상태.Interval = 500
        타이머_통신상태.Enabled = True

        ' 피크컷 정보 설정

        isSDCard_Mode = System.IO.Directory.Exists("\SD Card")

        Try
            ReDim 사용모드_피크컷시간(2, 4)
            If System.IO.File.Exists(CONFIG_FILE) = True Then
                Dim pINI As New IniFile(CONFIG_FILE)

                d사용모드_로드파워 = Val(pINI.GetKeyValue("사용모드", "로드파워") & "")
                d사용모드_피크컷 = Val(pINI.GetKeyValue("사용모드", "피크컷") & "")

                사용모드_피크컷시간(1, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작시") & "")  ' 피크컷시간1 - 시작 시
                사용모드_피크컷시간(1, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_시작분") & "")  ' 피크컷시간1 - 시작 분
                사용모드_피크컷시간(1, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료시") & "")  ' 피크컷시간1 - 종료 시
                사용모드_피크컷시간(1, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간1_종료분") & "")  ' 피크컷시간1 - 종료 분

                사용모드_피크컷시간(2, 1) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작시") & "")  ' 피크컷시간2 - 시작 시
                사용모드_피크컷시간(2, 2) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_시작분") & "")  ' 피크컷시간2 - 시작 분
                사용모드_피크컷시간(2, 3) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료시") & "")  ' 피크컷시간2 - 종료 시
                사용모드_피크컷시간(2, 4) = Val(pINI.GetKeyValue("사용모드", "피크컷시간2_종료분") & "")  ' 피크컷시간2 - 종료 분

                d사용모드_충전유효전력 = Val(pINI.GetKeyValue("사용모드", "충전유효전력") & "")
                d사용모드_방전유효전력 = Val(pINI.GetKeyValue("사용모드", "방전유효전력") & "")
                'd사용모드_무효전력 = Val(pINI.GetKeyValue("사용모드", "무효전력") & "")

                d사용모드_배터리_충전정지SOC = Val(pINI.GetKeyValue("사용모드", "배터리충전중지SOC") & "")
                d사용모드_배터리_방전정지SOC = Val(pINI.GetKeyValue("사용모드", "배터리방전중지SOC") & "")

                d사용모드_배터리_충전정지전압 = Val(pINI.GetKeyValue("사용모드", "배터리충전정지전압") & "") * 0.1
                d사용모드_배터리_방전정지전압 = Val(pINI.GetKeyValue("사용모드", "배터리방전정지전압") & "") * 0.1

                d사용모드_배터리_충전시최대전류 = Val(pINI.GetKeyValue("사용모드", "배터리충전전류") & "")
                d사용모드_배터리_방전시최대전류 = Val(pINI.GetKeyValue("사용모드", "배터리충전전압") & "")
            End If

        Catch ex As Exception

        End Try
        Try
            배터리사용량_초기화()
        Catch ex As Exception

        End Try

    End Sub

    Private tLastCheckHour As Integer = -1
    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick
        타이머_상태.Enabled = False
        타이머_상태.Interval = 1000

        '현재 시스템이 동작중임을 알려주는 Heartbit
        ' Heartbit가 멈춘다면, 시스템이 정지된 것,
        ' 또한 시작 시 실행해야 할 항목들을 위해서 사용된다.
        '1~11은 시스템의 시작
        heartbit = heartbit + 1
        If heartbit > 30000 Then
            heartbit = 12
        End If

        ' 라벨 시간 설정
        Dim 현재시간 As Date = Now
        라벨_시스템시간.Text = String.Format("{0}{1}{2}", Format(현재시간, "tt h:mm:ss"), vbCrLf, Format(현재시간, "yyyy-MM-dd"))

        ' 매 시간마다 Garbage Collector 실행
        If tLastCheckHour <> Now.Hour Then
            tLastCheckHour = Now.Hour
            GC.Collect()
        End If

        통신재시작()
        pHistorySave.HistorySave()
        경보전시()
        타이머_상태.Enabled = True
    End Sub

    Private Sub 통신재시작()
        ' 재시작을 위한 구문
        If 설정변경_통신 = True Then

            If 설정변경_EMS = True Then
                설정변경_EMS = False

                EMS_통신시작()
            End If

            If 설정변경_PCS = True Then
                설정변경_PCS = False
                PCS_통신시작()
            End If

            If 설정변경_BMS = True Then
                설정변경_BMS = False
                BMS_통신시작()
            End If

            설정변경_통신 = False
        End If
    End Sub
    Private Sub 경보전시()
        If qRecvFault.Count > 0 Then

            While qRecvFault.Count > 0

                Dim szFaultData As String = qRecvFault.Dequeue
                Dim szFault() As String = szFaultData.Split("|")

                Dim pItem As New ListViewItem
                pItem.Text = (ListView1.Items.Count + 1).ToString
                pItem.SubItems.Add(szFault(0))
                pItem.SubItems.Add(szFault(1))
                pItem.SubItems.Add(String.Format("0x{0:X2}", CInt(Val(szFault(2)))))
                pItem.SubItems.Add(szFault(3))
                pItem.SubItems.Add(szFault(4))

                Dim pItem2 As ListViewItem = ListView1.Items.Add(pItem)

                pHistorySave.FaultSave(szFault(0), szFault(1), szFault(2), szFault(3), szFault(4))

                Application.DoEvents()
            End While

            If 화면_고장.Visible = False Then
                화면_고장.Visible = False
                화면_고장.Left = (Me.Width - 화면_고장.Width) / 2
                화면_고장.Top = (Me.Height - 화면_고장.Height) / 2
                화면_고장.Visible = True
                화면_고장.BringToFront()
            End If
        End If
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
    Private BMS통신 As BMS클라이언트 = Nothing
    Private Sub 통신시작()
        EMS수신서버 = New EMS통신서버
        AddHandler EMS수신서버.DataArrived, AddressOf EMS_DataArrived

        PCS통신 = New PCS통신
        AddHandler PCS통신.DataArrived, AddressOf PCS_DataArrived


        BMS통신 = New BMS클라이언트

        EMS_통신시작()
        PCS_통신시작()
        BMS_통신시작()

        타이머_사용모드.Interval = 2000
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

        'PCS_DataDisplay(szMode, szMessage)
        For nFileNo As Integer = 35 To 37
            Dim ushValue As UShort = GetModbusData_Ushort(nFileNo)

            For nBit As Integer = 0 To 15
                Dim nStatus As Integer = ushValue >> nBit And &H1
                If Val(FAULT_STATUS(nFileNo, nBit, 0) & "") <> nStatus Then
                    경보발생및해제(nStatus, nFileNo, nBit)
                End If
            Next
        Next
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
                            경보발생및해제(nStatus, nFileNo, nBit)
                        End If
                    Next
                Next
            End If
        End If
    End Sub


    Public Sub BMS_DataArrived(ByVal szComPort As String, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        Dim szMessage As String = String.Format("[{0}] {1} : ", Format(Now, "HH:mm:ss"), szMode)
        For i As Integer = 0 To nLength - 1
            szMessage &= String.Format("{0:X2} ", btData(i))
        Next
        'BMS_DataDisplay(szMode, szMessage)
        Debug.WriteLine(szMessage)
    End Sub

    Private Sub EMS_통신시작()
        EMS수신서버.ServiceStart()
    End Sub
    Private Sub PCS_통신시작()
        PCS통신.ServiceStart()
    End Sub
    Private Sub BMS_통신시작()
        BMS통신.ServiceStart()
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
                버튼_화면전환_메인.Selected = False
                Uc서브화면1_메인1.Visible = False
            Case 2
                버튼_화면전환_배터리.Enabled = True
                버튼_화면전환_배터리.Selected = False
                Uc서브화면2_배터리1.Visible = False
            Case 3
                버튼_화면전환_수요관리.Enabled = True
                버튼_화면전환_수요관리.Selected = False
                Uc서브화면3_수요관리1.Visible = False
            Case 4
                버튼_화면전환_소비.Enabled = True
                버튼_화면전환_소비.Selected = False
                Uc서브화면4_소비1.Visible = False
            Case 5
                버튼_화면전환_사용모드.Enabled = True
                버튼_화면전환_사용모드.Selected = False
                Uc서브화면5_사용모드1.Visible = False
            Case 6
                버튼_화면전환_이력.Enabled = True
                버튼_화면전환_이력.Selected = False
                Uc서브화면6_이력1.Visible = False
            Case 7
                버튼_화면전환_설정.Enabled = True
                버튼_화면전환_설정.Selected = False
                Uc서브화면7_설정1.Visible = False
            Case 8
                VsPictureButton8.Enabled = True
                VsPictureButton8.Selected = False
                Uc서브화면8_고장1.Visible = False
            Case 21
                Uc서브화면8_고장1.Visible = False
        End Select

        nCurrentMenu = nSelect

        Select Case nCurrentMenu
            Case 1
                버튼_화면전환_메인.Enabled = False
                버튼_화면전환_메인.Selected = True

                Uc서브화면1_메인1.Visible = True
                If Uc서브화면1_메인1.Dock <> DockStyle.Fill Then
                    Uc서브화면1_메인1.Dock = DockStyle.Fill
                End If
            Case 2
                버튼_화면전환_배터리.Enabled = False
                버튼_화면전환_배터리.Selected = True

                Uc서브화면2_배터리1.Visible = True
                If Uc서브화면2_배터리1.Dock <> DockStyle.Fill Then
                    Uc서브화면2_배터리1.Dock = DockStyle.Fill
                End If
            Case 3
                버튼_화면전환_수요관리.Enabled = False
                버튼_화면전환_수요관리.Selected = True

                Uc서브화면3_수요관리1.Visible = True
                If Uc서브화면3_수요관리1.Dock <> DockStyle.Fill Then
                    Uc서브화면3_수요관리1.Dock = DockStyle.Fill
                End If
            Case 4
                버튼_화면전환_소비.Enabled = False
                버튼_화면전환_소비.Selected = True

                Uc서브화면4_소비1.Visible = True
                If Uc서브화면4_소비1.Dock <> DockStyle.Fill Then
                    Uc서브화면4_소비1.Dock = DockStyle.Fill
                End If
            Case 5
                버튼_화면전환_사용모드.Enabled = False
                버튼_화면전환_사용모드.Selected = True

                Uc서브화면5_사용모드1.Visible = True
                Uc서브화면5_사용모드1.설정값불러오기()
                If Uc서브화면5_사용모드1.Dock <> DockStyle.Fill Then
                    Uc서브화면5_사용모드1.Dock = DockStyle.Fill
                End If
            Case 6
                버튼_화면전환_이력.Enabled = False
                버튼_화면전환_이력.Selected = True

                Uc서브화면6_이력1.Visible = True
                If Uc서브화면6_이력1.Dock <> DockStyle.Fill Then
                    Uc서브화면6_이력1.Dock = DockStyle.Fill
                End If

                Uc서브화면6_이력1.InitScreen()

            Case 7
                버튼_화면전환_설정.Enabled = False
                버튼_화면전환_설정.Selected = True

                Uc서브화면7_설정1.Visible = True
                If Uc서브화면7_설정1.Dock <> DockStyle.Fill Then
                    Uc서브화면7_설정1.Dock = DockStyle.Fill
                End If
                Uc서브화면7_설정1.InitScreen()

            Case 8
                VsPictureButton8.Enabled = False
                VsPictureButton8.Selected = True

                Uc서브화면8_고장1.Visible = True
                If Uc서브화면8_고장1.Dock <> DockStyle.Fill Then
                    Uc서브화면8_고장1.Dock = DockStyle.Fill
                End If

                Uc서브화면8_고장1.LoadCurrentFault()
        End Select
    End Sub

    Private Sub SmartWatchDog1_OnTimeOutEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmartWatchDog1.OnTimeOutEvent
        '' 시스템을 다시 시작하기 전에 로그파일에 정보를 기록합니다.
        Try
            'pHistorySave.Contro()
            'pHistory.ControlEventSave("오류", "WATCHDOG", "처리 되지 않은 예외로 시스템 다시 시작")
        Catch exp As Exception
            Debug.WriteLine(exp.ToString())
        End Try
    End Sub

    Private Sub 타이머_통신상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_통신상태.Tick
        타이머_통신상태.Enabled = False

        Dim nCurrentImage As Integer = nComm_PCS_Image
        If PCS통신.Connected > 0 Then
            nCurrentImage = 2
            If flag_PCS_CommFault = True Then
                PCS_CommFault(0)
                flag_PCS_CommFault = False
            End If
        Else
            nCurrentImage = 1
            If Not flag_PCS_CommFault = True Then
                flag_PCS_CommFault = True
                PCS_CommFault(1)
            End If
        End If

        If nCurrentImage <> nComm_PCS_Image Then
            nComm_PCS_Image = nCurrentImage

            Select Case nComm_PCS_Image
                Case 1
                    pbPCS.Image = My.Resources.단선_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "PCS 통신", "단선")
                Case 2
                    pbPCS.Image = My.Resources.연결_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "PCS 통신", "연결")
            End Select
        End If


        nCurrentImage = nComm_EMS_Image
        If EMS수신서버.Connected > 0 Then
            nCurrentImage = 2
        Else
            nCurrentImage = 1
        End If
        If nCurrentImage <> nComm_EMS_Image Then
            nComm_EMS_Image = nCurrentImage

            Select Case nComm_EMS_Image
                Case 1
                    pbEMS.Image = My.Resources.단선_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "EMS 통신", "단선")
                Case 2
                    pbEMS.Image = My.Resources.연결_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "EMS 통신", "연결")
            End Select
        End If


        nCurrentImage = nComm_BMS_Image
        If BMS통신.Connected() > 0 Then
            nCurrentImage = 2
        Else
            nCurrentImage = 1
        End If

        If nCurrentImage <> nComm_BMS_Image Then
            nComm_BMS_Image = nCurrentImage

            Select Case nComm_BMS_Image
                Case 1
                    pbBMS.Image = My.Resources.단선_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "BMS 통신", "단선")
                Case 2
                    pbBMS.Image = My.Resources.연결_32
                    pHistorySave.FaultSave(Format(Now, "yyyy-MM-dd"), Format(Now, "HH:mm:ss"), "0", "BMS 통신", "연결")
            End Select
        End If



        타이머_통신상태.Interval = BMS_통신주기
        타이머_통신상태.Enabled = True

    End Sub

    Private Sub VsPictureButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_메인.Click
        SetButtonStatus(1)
    End Sub

    Private Sub VsPictureButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 버튼_화면전환_배터리.Click
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

    Private Sub 화면_고장_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles 화면_고장.Paint

        e.Graphics.DrawRectangle(New Pen(Color.Gray, 1), 0, 0, 화면_고장.Width - 1, 화면_고장.Height - 1)
        e.Graphics.DrawRectangle(New Pen(Color.Green, 1), 1, 1, 화면_고장.Width - 2, 화면_고장.Height - 2)

    End Sub

    Private Sub VsPictureButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VsPictureButton1.Click
        ListView1.Items.Clear()
        화면_고장.Visible = False
    End Sub

    Private bDebug_EMS As Boolean = False
    Private bDebug_PCS As Boolean = False
    Private bDebug_BMS As Boolean = False

    Private Sub SerialPort_Debug_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_Debug.DataReceived

        Dim btRecv As Byte = SerialPort_Debug.ReadByte

        If btRecv = Asc("E") Or btRecv = Asc("e") Then
            If bDebug_EMS = True Then
                bDebug_EMS = False
            Else
                bDebug_EMS = True
            End If
        ElseIf btRecv = Asc("P") Or btRecv = Asc("p") Then
            If bDebug_PCS = True Then
                bDebug_PCS = False
            Else
                bDebug_PCS = True
            End If
        ElseIf btRecv = Asc("R") Or btRecv = Asc("r") Then
            SmartConfigs1.Powers.ReBoot()
        End If

    End Sub

    Private nRunModeCheck As Integer = -1
    Private Sub 타이머_사용모드_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_사용모드.Tick
        타이머_사용모드.Enabled = False


        Dim nCurrent As Integer = Now.Second
        Dim deadbandSOC As Integer = 3
        Dim deadbandVolt As Integer = 10


        If nCurrent <> nRunModeCheck Then ' And nCurrent Mod 5 = 0 Then
            ' 사용모드 확인
            현재사용모드확인() ' 현재의 상태값을 상태비트에 저장한다.

            If 현재사용모드_배터리방전시간 = True Then
                Dim ushOPFlag As UShort = GetModbusData_Ushort(PT_OpFLAG_Status)

                ' 해당 상태에 들어서면 자동으로 제어 명령을 내 보낸다.
                ' 방전시작, 충전시작 상태
                ' 방전중지 
                ' SOC가 방전중지보다 보다 같거나 낮으면 방전 중지.

                ' 현재 시간이 안맞는데도 충전중이라면 충전을 꺼야한다
                If 현재사용모드_배터리충전 = True Then
                    배터리충전취소()
                ElseIf 현재사용모드_배터리충전 = False Then
                    Dim dBATT_SOC As Double = cBMS.Bank_SOC
                    Dim dBATT_DC전압 As Double = cBMS.Bank_DC전압
                    If dBATT_SOC <= d사용모드_배터리_방전정지SOC And dBATT_DC전압 <= d사용모드_배터리_방전정지전압 Then
                        ' SOC가 배터리 방전정지값 보다 작거나 같다면 방전을 중지해야한다.
                        If 현재사용모드_배터리방전 = True Then
                            ' 계속 방전중이라면 방전을 취소하고
                            배터리방전취소()

                        ElseIf 현재사용모드_배터리방전 = False Then
                            ' Nothing to do
                        End If
                    ElseIf dBATT_SOC > d사용모드_배터리_방전정지SOC + deadbandSOC And dBATT_DC전압 > d사용모드_배터리_방전정지전압 + deadbandVolt Then

                        ' SOC가 배터리 방전 정지보다 크다면 방전을 계속 실시해야한다.
                        ' 방전중이 아니라면 방전 요청을 지속적으로 보낸다..
                        If 현재사용모드_배터리방전 = True Then
                            ' Nothing to do
                        ElseIf 현재사용모드_배터리방전 = False Then
                            If 현재사용모드_PCS방전강제종료 = False Then
                                배터리방전시작()
                            End If
                        End If
                    End If
                End If

            ElseIf 현재사용모드_배터리충전시간 = True Then

                ' 배터리 충/방전 확인 비트
                Dim dBATT_SOC As Double = cBMS.Bank_SOC
                Dim dBATT_DC전압 As Double = cBMS.Bank_DC전압
                Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)

                If 현재사용모드_배터리방전 = True Then
                    배터리방전취소()
                ElseIf 현재사용모드_배터리방전 = False Then
                    If dBATT_SOC < d사용모드_배터리_충전정지SOC And dBATT_DC전압 < d사용모드_배터리_충전정지전압 Then
                        If 현재사용모드_배터리충전 = True Then
                            ' 배터리가 정상적으로 충전중이라면 더이상 명령을 내릴 필요가 없으니 아무일도 하지 않는다.
                            ' nothing to do
                        ElseIf 현재사용모드_배터리충전 = False Then
                            If 현재사용모드_PCS충전강제종료 = False Then
                                배터리충전시작()
                            End If
                        End If

                    ElseIf dBATT_SOC >= d사용모드_배터리_충전정지SOC And dBATT_DC전압 >= d사용모드_배터리_충전정지전압 Then
                        '현재 SOC값이 사용모드_배터리_충전정지보다 클 경우
                        If 현재사용모드_배터리충전 = True Then
                            ' 충전 정지를 한다.
                            배터리충전취소()
                        ElseIf 현재사용모드_배터리충전 = False Then
                            ' 충전 정상적으로 충전 정지중이라면 더이상 명령을 내릴 필요가 없으니 아무일도 하지 않는다
                            ' nothing to do
                        End If
                    End If
                End If
            End If

            ' C-Rate가 맞지 않을 경우에 주기적으로 값을 비교한 후, 전송한다.
            If Not Convert.ToUInt16(d사용모드_배터리_충전시최대전류) = GetModbusData_Ushort(PT_Constant_Current) Then
                If Assertbit Then
                    Debug.WriteLine("사용모드_배터리_충전시CRate : " + GetModbusData_Ushort(PT_Constant_Current).ToString())
                End If
                충전시최대전류값설정(d사용모드_배터리_충전시최대전류)
            End If

            If Not Convert.ToUInt16(d사용모드_배터리_방전시최대전류) = GetModbusData_Ushort(PT_Constant_Voltage) Then
                If Assertbit Then
                    Debug.WriteLine("사용모드_배터리_방전시CRate : " + GetModbusData_Ushort(PT_Constant_Voltage).ToString())
                End If
                방전시최대전류값설정(d사용모드_배터리_방전시최대전류)

            End If
            '<-----------------------------------------------------------------------------------------------------------
            Dim dBattVoltageofPCS As Double = cBMS.Bank_DC전압
            '<-----------------------------------------------------------------------------------------------------------
            If 현재사용모드_배터리충전 = True Then
                충전시유효전력설정(dBattVoltageofPCS)
            ElseIf 현재사용모드_배터리방전 = True Then
                방전시유효전력설정(dBattVoltageofPCS)
            End If
        End If

        타이머_사용모드.Enabled = True
    End Sub

    Private Sub VsLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub PCS_CommFault(ByVal nStatus As Integer)
        '<---------------------------------------
        ' PCS Fault를 위한 강제 지정
        Dim nFileNo As Integer = 37
        Dim nBit As Integer = 15
        '<---------------------------------------
        경보발생및해제(nStatus, nFileNo, nBit)
        
    End Sub

    Public fault As Integer = 0

    Private Sub pbBMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBMS.Click


    End Sub
End Class


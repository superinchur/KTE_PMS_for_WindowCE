Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports System.IO

Public Class EMS통신서버

    Private alClientList As New ArrayList

    Private pListenSocket As Socket
    Private nMaxListen As Integer = 500

    Private WithEvents Timer_Comm As New Windows.Forms.Timer

    Public Event DataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
    Public Sub OnDataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        'RaiseEvent DataArrived(szAddr, nPort, szMode, btData, nLength)
    End Sub

    Public Overloads Sub ServiceStart()

        Timer_Comm.Enabled = False

        If Not alClientList Is Nothing Then
            ServiceStop()
        End If

        ' 서버를 시작시킨다.
        Try
            Dim ipep As IPEndPoint = New IPEndPoint(IPAddress.Any, EMS_수신포트)
            pListenSocket = New System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            pListenSocket.Bind(ipep)
            pListenSocket.Listen(nMaxListen)

            '메시지소켓그룹 = New 소켓그룹  ' 클라이언크 그룹으로 사용할 변수을 만들어 준다.
            '생성폼.메시지로그("수신 서버 시작") ' 
            '스레드 풀로 기능 변경함.

            Dim objCallBack As New WaitCallback(AddressOf AcceptClient)
            ThreadPool.QueueUserWorkItem(objCallBack)
        Catch ex As Exception
        End Try


        alClientList = New ArrayList

        Timer_Comm.Interval = 1000
        Timer_Comm.Enabled = True
    End Sub

    Private Sub AcceptClient(ByVal state As Object)
        Try
            While True
                Dim client As Socket = pListenSocket.Accept   ' 서버에 접속이 들어오면 클라이언트소켓을 생성하고
                Dim ip As IPEndPoint = CType(client.RemoteEndPoint, IPEndPoint)  ' 연결아이피를 세팅하여

                If client.Connected Then ' 소켓이 연결되어 있다면 
                    Dim pDevice As EMS통신차일드 = New EMS통신차일드(client)
                    AddHandler pDevice.DataArrived, AddressOf OnDataArrived
                    alClientList.Add(pDevice)
                End If
            End While

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub ServiceStop()
        Timer_Comm.Enabled = False

        If Not pListenSocket Is Nothing Then
            pListenSocket.Close()
            pListenSocket = Nothing
        End If

        If Not alClientList Is Nothing Then
            For nCnt As Integer = 0 To alClientList.Count - 1
                Try

                    Dim pObj As EMS통신차일드 = alClientList.Item(nCnt)
                    pObj.ServiceStop()
                    pObj = Nothing

                Catch ex As Exception
                    Debug.WriteLine(ex.ToString)
                End Try
            Next

            alClientList.Clear()
        End If

    End Sub

    Private Sub Timer_Comm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Comm.Tick
        Timer_Comm.Enabled = False

        Try
            ' Connect Status 상태 확인
            For nCnt As Integer = 0 To alClientList.Count - 1
                Dim pObj As EMS통신차일드 = alClientList.Item(nCnt)

                If pObj.ConnectStatus = True Then

                    Dim spTerm As TimeSpan = Now - pObj.tLastReceive
                    If spTerm.TotalSeconds > 30 Then
                        pObj.ConnectStatus = False
                    End If
                    ' 만약 Connect Status 상태 시 연결되어 있지 않다면 Service Stop
                ElseIf pObj.ConnectStatus = False Then
                    Try
                        alClientList.Remove(pObj)

                        pObj.ServiceStop()
                        pObj = Nothing

                        Exit For
                    Catch ex As Exception
                        Debug.WriteLine(ex.ToString)
                    End Try
                End If

            Next

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

        Timer_Comm.Enabled = True
    End Sub

    Public Function Connected() As Integer
        Return alClientList.Count
    End Function

End Class

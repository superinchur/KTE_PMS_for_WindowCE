Imports System.Net.Sockets
Imports System.Net
Imports System.Threading


Public Class 비동기통신소켓
    Public Event Connected(ByVal sender As 비동기통신소켓)
    Public Event DisConnected(ByVal sender As 비동기통신소켓)
    Public Event DataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
    Public Event DataSendComplete(ByVal PacketSize As Long)

    Public client As Net.Sockets.Socket = Nothing
    Public buffer(1024) As Byte

    Public szRemoteAddrESS As String = ""
    Public nRemotePort As Integer = 0

    Public Sub New()

    End Sub

    Public Sub New(ByVal AcceptSocket As Socket)
        client = AcceptSocket

        client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, New AsyncCallback(AddressOf sckArrived), Nothing)

    End Sub

    Public Sub sckDisconnect()
        Try
            If client.Connected = True Then
                client.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            'Debug.Print(String.Format("Target : {0}/{1}", szRemoteAddrESS, nRemotePort) & vbCrLf & ex.ToString)

            '            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub sckSend(ByVal Data() As Byte, ByVal idx As Long)
        Try
            Dim szAddress As String = IPAddress.Parse(CType(client.RemoteEndPoint, IPEndPoint).Address.ToString()).ToString
            Dim nPort As Integer = CType(client.RemoteEndPoint, IPEndPoint).Port
            RaiseEvent DataArrived(szAddress, nPort, "TX", Data, idx)

            client.BeginSend(Data, 0, idx, SocketFlags.None, New AsyncCallback(AddressOf sckSendComplete), Nothing)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub sckSendComplete(ByVal Rs As IAsyncResult)

        Try
            Dim SentPacketSize As Long
            'TODO :: PacketSize는 보낸 패킷의 크기입니다.
            SentPacketSize = client.EndSend(Rs)

            RaiseEvent DataSendComplete(SentPacketSize)

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub sckArrived(ByVal Rs As IAsyncResult)

        Try
            Dim szAddress As String = IPAddress.Parse(CType(client.RemoteEndPoint, IPEndPoint).Address.ToString()).ToString
            Dim nPort As Integer = CType(client.RemoteEndPoint, IPEndPoint).Port

            If client.Connected = True Then
                Try

                    Dim PacketSize As Long
                    PacketSize = client.EndReceive(Rs)
                    'TODO :: Buffer에 데이터가 저장되며 PacketSize는 패킷의 크기입니다.

                    If PacketSize > 0 Then
                        RaiseEvent DataArrived(szAddress, nPort, "RX", buffer, PacketSize)

                        client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, New AsyncCallback(AddressOf sckArrived), Nothing)
                    Else
                        Debug.WriteLine("")
                    End If


                Catch ex As Exception
                    Debug.WriteLine(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub Close()

        Try
            client.Close()

        Catch ex As Exception

        End Try

        Try
            client = Nothing

        Catch ex As Exception

        End Try
    End Sub


End Class


Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class EMS통신차일드

    Private TCPFrameHeaderLength As Integer = 6
    Private TCPFrameHeaderData(TCPFrameHeaderLength) As Byte

    Private _ConnectStatus As Boolean = True
    Private pClientSocket As 비동기통신소켓 = Nothing

    Private WithEvents Timer_Comm As New Windows.Forms.Timer

    Private szIPAddrESS As String = ""
    Private nSocketPort As Integer = 0

    Private btRecvBuffer(1024) As Byte
    Private nRecvBuffer As Integer = 0

    Public tLastReceive As Date = Now

    Public Event DataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)

    Public Property ConnectStatus() As Boolean
        Get
            Return _ConnectStatus
        End Get
        Set(ByVal value As Boolean)
            _ConnectStatus = value
        End Set
    End Property


    Public Sub New(ByVal pSocket As Socket)

        pClientSocket = New 비동기통신소켓(pSocket)
        AddHandler pClientSocket.DataArrived, AddressOf OnDataArrived

        Timer_Comm.Interval = 1000
        Timer_Comm.Enabled = True
    End Sub

    Public Sub OnDataArrived(ByVal szAddr As String, ByVal nPort As Integer, ByVal szMode As String, ByVal btData() As Byte, ByVal nLength As Integer)
        Try
            If nLength > 0 Then
                RaiseEvent DataArrived(szAddr, nPort, szMode, btData, nLength)
            End If
        Catch ex As Exception
            Debug.WriteLine("")
        End Try

        If nLength > 0 And szMode = "RX" Then

            Dim szRecvMsg As String = "EMS RX : "
            For i As Integer = 0 To nLength - 1
                szRecvMsg &= String.Format("{0:X2} ", btData(i))
            Next
            Debug.WriteLine(szRecvMsg)


            Array.Copy(btData, 0, btRecvBuffer, nRecvBuffer, nLength)
            nRecvBuffer += nLength

            If nRecvBuffer > TCPFrameHeaderLength + 3 Then
                tLastReceive = Now

                Dim btFrameDeviceNo As Byte = btRecvBuffer(TCPFrameHeaderLength + 0)
                Dim btFrameCommand As Byte = btRecvBuffer(TCPFrameHeaderLength + 1)

                Dim btFrameData(1024) As Byte
                Dim nFrameLength As Integer = 0

                Array.Copy(btRecvBuffer, 0, TCPFrameHeaderData, 0, TCPFrameHeaderLength)

                nFrameLength = nRecvBuffer - TCPFrameHeaderLength
                Array.Copy(btRecvBuffer, TCPFrameHeaderLength, btFrameData, 0, nFrameLength)

                If btFrameDeviceNo = PMS_통신ID Then

                    If btFrameCommand = &H3 Then
                        ' 데이터 요구

                        If nRecvBuffer >= TCPFrameHeaderLength + 6 Then
                            DataProcPCS(btFrameData, nFrameLength)
                        End If

                    ElseIf btFrameCommand = &H6 Then
                        ' 단일 제어 명령

                        If nRecvBuffer >= TCPFrameHeaderLength + 6 Then
                            ' REMOTE 모드일 떄는 막아야한다

                            WriteSingleRegister(btFrameData, nFrameLength)
                    End If

                        '현재 사용하지 않음
                        'ElseIf btFrameCommand = &H10 Then
                        '    ' 복수 제어 명령 
                        '    If nRecvBuffer >= TCPFrameHeaderLength + 7 Then
                        'Dim nDataCount As Integer = btRecvBuffer(6)
                        '
                        'If nRecvBuffer >= TCPFrameHeaderLength + 7 + nDataCount Then
                        '
                        '    'WriteMultiRegister(btFrameData, nFrameLength)
                        '
                        'End If
                    Else
                        Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
                        nRecvBuffer = 0

                    End If
                Else
                    Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
                    nRecvBuffer = 0

                End If


            End If
        End If

    End Sub

    Public Overloads Sub ServiceStop()

        _ConnectStatus = False

        Timer_Comm.Enabled = False

        If Not pClientSocket Is Nothing Then

            Try
                pClientSocket.sckDisconnect()

                RemoveHandler pClientSocket.DataArrived, AddressOf OnDataArrived

                pClientSocket.Close()

                pClientSocket = Nothing

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub DataProcPCS(ByVal btRecv() As Byte, ByVal nRecv As Integer)

        Try
            Dim btFrameDeviceNo As Byte = btRecv(0)
            Dim btFrameCommand As Byte = btRecv(1)

            Dim nAddrESS As Integer = btRecv(2) * &H100 + btRecv(3)
            Dim nDataCount As Integer = btRecv(4) * &H100 + btRecv(5)

            EMS_MODBUS_ADDRESS = nAddrESS

            Dim btSendData(1024) As Byte
            Dim nSendData As Integer = 0

            btSendData(nSendData) = PMS_통신ID
            nSendData += 1

            btSendData(nSendData) = btFrameCommand
            nSendData += 1

            btSendData(nSendData) = nDataCount * 2
            nSendData += 1

            Array.Copy(MODBUS_EMS_BUFFER, nAddrESS * 2, btSendData, nSendData, nDataCount * 2)
            nSendData += nDataCount * 2

            WriteDataFrame(btSendData, nSendData)

        Catch ex As Exception
            Debug.WriteLine("")
        End Try
    End Sub

    Private Sub WriteSingleRegister(ByVal btData() As Byte, ByVal nData As Integer)

        Dim nAddress As Integer = btData(2) * &H100 + btData(3)
        Dim nWriteData As Integer = btData(4) * &H100 + btData(5)

        If nAddress < 512 Then

            If 현재사용모드_리모트모드 = False Then
                If nAddress >= 0 And nAddress <= 2 Then
                    WriteDataFrame(btData, nData)
                    Exit Sub
                End If
                else
            End If
            MODBUS_EMS_BUFFER(2 * nAddress) = btData(4)
            MODBUS_EMS_BUFFER(2 * nAddress + 1) = btData(5)
        End If

        WriteDataFrame(btData, nData)

    End Sub

    Private Sub WriteMultiRegister(ByVal btData() As Byte, ByVal nData As Integer)

        ' 사용하지 않는 함수
        'Dim nAddress As Integer = btData(2) * &H100 + btData(3)
        'Dim nDataCount As Integer = btData(4) * &H100 + btData(5)
        'Dim nDataByte As Integer = btData(6)

        'Dim nWriteData As Integer = btData(7) * &H100 + btData(8)


        'If nAddress < 100 Then
        'MODBUS_EMS_BUFFER(2 * nAddress) = btData(7)
        'MODBUS_EMS_BUFFER(2 * nAddress + 1) = btData(8)
        '제어대기열_추가(nAddress, nWriteData)
        'End If

        'WriteDataFrame(btData, nData)

    End Sub


    Private Sub WriteDataFrame(ByVal btData() As Byte, ByVal nData As Integer)
        Dim btSendData(1024) As Byte
        Dim nSendData As Integer = 0

        Array.Clear(btRecvBuffer, 0, btRecvBuffer.Length)
        nRecvBuffer = 0

        If TCPFrameHeaderLength > 0 Then
            Array.Copy(TCPFrameHeaderData, 0, btSendData, 0, TCPFrameHeaderLength)
            nSendData += TCPFrameHeaderLength

            btSendData(nSendData - 2) = nData \ &H100
            btSendData(nSendData - 1) = nData Mod &H100
        End If

        Array.Copy(btData, 0, btSendData, nSendData, nData)
        nSendData += nData

        pClientSocket.sckSend(btSendData, nSendData)

    End Sub
End Class

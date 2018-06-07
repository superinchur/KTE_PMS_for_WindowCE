Module 모듈_제어대기열

    Private q제어대기열 As New Queue
    Private q제어대기열길이 As Integer = 0

    Public Sub 제어대기열_추가(ByVal nAddress As Integer, ByVal nData As Integer)

        Dim btData() As Integer = {nAddress, nData}

        q제어대기열.Enqueue(btData)

    End Sub

    Public Function 제어대기열_가져오기(ByRef nAddress As Integer, ByRef nData As Integer) As Boolean
        Dim bReturn As Boolean = False

        If q제어대기열.Count > 0 Then
            Try
                Dim btData() As Integer = q제어대기열.Dequeue

                nAddress = btData(0)
                nData = btData(1)

                bReturn = True

            Catch ex As Exception

            End Try
        End If

        Return bReturn
    End Function

    Public Function 제어대기열_대기수량() As Integer
        Return q제어대기열.Count
    End Function

End Module

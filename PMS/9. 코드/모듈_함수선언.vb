Module 모듈_함수선언

    Public Function FindControl(ByVal ControlName As String, ByVal CurrentControl As Control) As Control
        Dim ctr As Control

        For Each ctr In CurrentControl.Controls
            If ctr.Name = ControlName Then
                Return ctr
            Else
                ctr = FindControl(ControlName, ctr)
                If Not ctr Is Nothing Then
                    Return ctr
                End If
            End If
        Next ctr

        Return Nothing
    End Function

    Public Function SetBitmask(ByVal ushValue As UShort, ByVal nOffset As Integer, ByVal nValue As Integer) As UShort
        Dim ushReturn As UShort = 0

        For i As Integer = 0 To 15
            If i = nOffset Then
                If nValue = 1 Then
                    ushReturn = ushReturn Or (2 ^ i)
                End If
            Else
                If (ushValue >> i And &H1) = 1 Then
                    ushReturn = ushReturn Or (2 ^ i)
                End If
            End If
        Next

        Return ushReturn
    End Function
End Module

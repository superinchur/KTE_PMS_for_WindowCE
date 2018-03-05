Module 모듈_배터리사용량



    Public Sub 배터리사용량_초기화()
        Dim nStartYear As Integer = 2017

        Dim tCurrent As Date = Now

        Dim szPath As String = ""
        Dim szHistoryFile As String = ""

        ' 전월까지의 누적
        For nYear As Integer = nStartYear To tCurrent.Year

            szPath = String.Format("\Flash Disk\Run\History\{0}", nYear)
            szHistoryFile = String.Format("{0}\H{1}.csv", szPath, nYear.ToString("0000"))
            If System.IO.File.Exists(szHistoryFile) = True Then
                Dim bMatch As Boolean = False
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Month" And szItems(1) = "BatteryCharge" Then
                            bMatch = True
                        End If

                        Exit While
                    End While
                    txtReader.Close()
                End Using

                If bMatch = True Then
                    Using txtReader As New System.IO.StreamReader(szHistoryFile)
                        While True
                            Dim szReadLine As String = txtReader.ReadLine()
                            If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                            Dim szItems() As String = szReadLine.Split(",")
                            If szItems(0) = "Month" Then
                            Else

                                Dim nMonth As String = Val(szItems(0) & "")
                                Dim dBatteryCharge As Double = Val(szItems(1))
                                Dim dBatteryDischarge As Double = Val(szItems(2))
                                Dim dGridIn As Double = Val(szItems(3))
                                Dim dGridOut As Double = Val(szItems(4))
                                Dim dInverter As Double = Val(szItems(5))
                                Dim dLoad As Double = Val(szItems(6))

                                If nYear < tCurrent.Year Then
                                    배터리_누적_충전 += dBatteryCharge
                                    배터리_누적_방전 += dBatteryDischarge
                                ElseIf nYear = tCurrent.Year And nMonth < tCurrent.Month Then
                                    배터리_누적_충전 += dBatteryCharge
                                    배터리_누적_방전 += dBatteryDischarge
                                End If
                                

                            End If

                        End While
                        txtReader.Close()
                    End Using
                End If
            End If

        Next

        ' 당월 누적
        szPath = String.Format("\Flash Disk\Run\History\{0}", tCurrent.Year)
        szHistoryFile = String.Format("{0}\H{1}-{2}.csv", szPath, tCurrent.Year.ToString("0000"), tCurrent.Month.ToString("00"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Day" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Day" Then
                        Else

                            Dim nDay As Integer = Val(szItems(0) & "")
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))

                            If nDay < tCurrent.Day Then
                                배터리_당월_충전 += dBatteryCharge
                                배터리_당월_방전 += dBatteryDischarge

                                배터리_누적_충전 += dBatteryCharge
                                배터리_누적_방전 += dBatteryDischarge
                            End If

                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If

        ' 전일
        Dim dtYesterday As Date = DateAdd(DateInterval.Day, -1, tCurrent)

        szPath = String.Format("\Flash Disk\Run\History\{0}", dtYesterday.Year)
        szHistoryFile = String.Format("{0}\H{1}-{2}-{3}.csv", szPath, dtYesterday.Year.ToString("0000"), dtYesterday.Month.ToString("00"), dtYesterday.Day.ToString("00"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Time" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Time" Then
                        Else

                            Dim szTime As String = szItems(0)
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))


                            Dim nHour As Integer = Val(szTime)

                            배터리_어제_충전 += dBatteryCharge
                            배터리_어제_방전 += dBatteryDischarge

                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If

        ' 당일
        szPath = String.Format("\Flash Disk\Run\History\{0}", tCurrent.Year)
        szHistoryFile = String.Format("{0}\H{1}-{2}-{3}.csv", szPath, tCurrent.Year.ToString("0000"), tCurrent.Month.ToString("00"), tCurrent.Day.ToString("00"))
        If System.IO.File.Exists(szHistoryFile) = True Then
            Dim bMatch As Boolean = False
            Using txtReader As New System.IO.StreamReader(szHistoryFile)
                While True
                    Dim szReadLine As String = txtReader.ReadLine()
                    If szReadLine = "" Or szReadLine Is Nothing Then Exit While


                    Dim szItems() As String = szReadLine.Split(",")
                    If szItems(0) = "Time" And szItems(1) = "BatteryCharge" Then
                        bMatch = True
                    End If

                    Exit While
                End While
                txtReader.Close()
            End Using

            If bMatch = True Then
                Using txtReader As New System.IO.StreamReader(szHistoryFile)
                    While True
                        Dim szReadLine As String = txtReader.ReadLine()
                        If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                        Dim szItems() As String = szReadLine.Split(",")
                        If szItems(0) = "Time" Then
                        Else

                            Dim szTime As String = szItems(0)
                            Dim dBatteryCharge As Double = Val(szItems(1))
                            Dim dBatteryDischarge As Double = Val(szItems(2))
                            Dim dGridIn As Double = Val(szItems(3))
                            Dim dGridOut As Double = Val(szItems(4))
                            Dim dInverter As Double = Val(szItems(5))
                            Dim dLoad As Double = Val(szItems(6))


                            Dim nHour As Integer = Val(szTime)
                            If nHour < tCurrent.Hour Then
                                배터리_당일_충전 += dBatteryCharge
                                배터리_당일_방전 += dBatteryDischarge

                                배터리_당월_충전 += dBatteryCharge
                                배터리_당월_방전 += dBatteryDischarge

                                배터리_누적_충전 += dBatteryCharge
                                배터리_누적_방전 += dBatteryDischarge
                            End If

                        End If

                    End While
                    txtReader.Close()
                End Using
            End If
        End If

    
    End Sub


End Module

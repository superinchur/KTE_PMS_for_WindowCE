Public Class 클래스_이력저장

#If DEBUG Then
    Private tLastSaveHour As Integer = -1
#Else
    Private tLastSaveHour As Integer = Now.Hour
#End If

    Private Structure stHistoryItem

        Dim dBattPowerCharge As Double
        Dim dBattPowerDischarge As Double

        Dim dGridInPower As Double
        Dim dGridOutPower As Double
        Dim dInverterPower As Double
        Dim dLoadPower As Double

    End Structure

    Private Structure stHistory
        Dim nYear As Integer
        Dim nMonth As Integer
        Dim nDay As Integer
        Dim nHour As Integer
        Dim nMinute As Integer

        Dim pHistory_Hour As ArrayList
    End Structure


    Private pHistoryData As New stHistory


    Public Sub HistorySave()
        Dim tCurrent As Date = Now
        Dim szHistoryFile As String = ""

        Dim bPathCheck As Boolean = 0
        Dim szPath As String

        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\History") = False Then
                Exit Sub
            Else
                szPath = String.Format("\SD Card\History\{0}", tCurrent.Year)
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\History") = False Then
                Exit Sub
            Else
                szPath = String.Format("\Flash Disk\Run\History\{0}", tCurrent.Year)
            End If
        End If



        bPathCheck = System.IO.Directory.Exists(szPath)

        If bPathCheck = False Then System.IO.Directory.CreateDirectory(szPath)
        bPathCheck = System.IO.Directory.Exists(szPath)

        If bPathCheck = False Then Exit Sub

        If pHistoryData.nYear = 0 Then

            pHistoryData.nYear = tCurrent.Year
            pHistoryData.nMonth = tCurrent.Month
            pHistoryData.nDay = tCurrent.Day
            pHistoryData.nHour = tCurrent.Hour
            pHistoryData.nMinute = tCurrent.Minute

            pHistoryData.pHistory_Hour = New ArrayList

        End If


        If pHistoryData.nHour <> tCurrent.Hour Then

            Dim pResult As New stHistoryItem

            For Each pItem As stHistoryItem In pHistoryData.pHistory_Hour
                pResult.dBattPowerCharge += pItem.dBattPowerCharge
                pResult.dBattPowerDischarge += pItem.dBattPowerDischarge

                pResult.dGridInPower += pItem.dGridInPower
                pResult.dGridOutPower += pItem.dGridOutPower
                pResult.dInverterPower += pItem.dInverterPower
                pResult.dLoadPower += pItem.dLoadPower
            Next

            pResult.dBattPowerCharge = pResult.dBattPowerCharge / pHistoryData.pHistory_Hour.Count
            pResult.dBattPowerDischarge = pResult.dBattPowerDischarge / pHistoryData.pHistory_Hour.Count
            pResult.dGridInPower = pResult.dGridInPower / pHistoryData.pHistory_Hour.Count
            pResult.dGridOutPower = pResult.dGridOutPower / pHistoryData.pHistory_Hour.Count
            pResult.dInverterPower = pResult.dInverterPower / pHistoryData.pHistory_Hour.Count
            pResult.dLoadPower = pResult.dLoadPower / pHistoryData.pHistory_Hour.Count

            pHistoryData.pHistory_Hour.Clear()

            Try

                szHistoryFile = String.Format("{0}\H{1}-{2}-{3}.csv", szPath, pHistoryData.nYear.ToString("0000"), pHistoryData.nMonth.ToString("00"), pHistoryData.nDay.ToString("00"))
                Dim bFIleCheck As Boolean = System.IO.File.Exists(szHistoryFile)

                Dim pWriter As New System.IO.StreamWriter(szHistoryFile, True, System.Text.Encoding.UTF8)

                If bFIleCheck = False Then
                    Dim szColumnTitle As String = "Time,BatteryCharge,BatteryDischarge,GridIn,GridOut,Inverter,Load"
                    pWriter.WriteLine(szColumnTitle)
                End If

                Dim szColumnData As String = pHistoryData.nHour.ToString("00")
                szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerCharge)
                szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerDischarge)
                szColumnData &= String.Format(",{0:F1}", pResult.dGridInPower)
                szColumnData &= String.Format(",{0:F1}", pResult.dGridOutPower)
                szColumnData &= String.Format(",{0:F1}", pResult.dInverterPower)
                szColumnData &= String.Format(",{0:F1}", pResult.dLoadPower)

                pWriter.WriteLine(szColumnData)

                pWriter.Close()

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try


            배터리_당일_충전 += pResult.dBattPowerCharge
            배터리_당일_방전 += pResult.dBattPowerDischarge

            배터리_누적_충전 += pResult.dBattPowerCharge
            배터리_누적_방전 += pResult.dBattPowerDischarge

        End If


        If pHistoryData.nDay <> tCurrent.Day Then
            Try



                szHistoryFile = String.Format("{0}\H{1}-{2}-{3}.csv", szPath, pHistoryData.nYear.ToString("0000"), pHistoryData.nMonth.ToString("00"), pHistoryData.nDay.ToString("00"))

                If System.IO.File.Exists(szHistoryFile) = True Then

                    Dim bMatch As Boolean = False
                    Using txtReader As New System.IO.StreamReader(szHistoryFile)
                        While True
                            Dim szReadLine As String = txtReader.ReadLine()
                            If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                            Dim szItems() As String = szReadLine.Split(",")
                            If szItems(0) = "Time" And szItems(1) = "BatteryCharge" And szItems(2) = "BatteryDischarge" And szItems(3) = "GridIn" And szItems(4) = "GridOut" And szItems(5) = "Inverter" And szItems(6) = "Load" Then
                                bMatch = True
                            End If
                            Exit While
                        End While
                        txtReader.Close()
                    End Using

                    If bMatch = True Then

                        Dim pHistory_Day As New ArrayList


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

                                    Dim pItem As New stHistoryItem

                                    pItem.dBattPowerCharge = dBatteryCharge
                                    pItem.dBattPowerDischarge = dBatteryDischarge
                                    pItem.dGridInPower = dGridIn
                                    pItem.dGridOutPower = dGridOut
                                    pItem.dInverterPower = dInverter
                                    pItem.dLoadPower = dLoad

                                    pHistory_Day.Add(pItem)

                                End If

                            End While
                            txtReader.Close()
                        End Using


                        Dim pResult As New stHistoryItem

                        For Each pItem As stHistoryItem In pHistory_Day
                            pResult.dBattPowerCharge += pItem.dBattPowerCharge
                            pResult.dBattPowerDischarge += pItem.dBattPowerDischarge
                            pResult.dGridInPower += pItem.dGridInPower
                            pResult.dGridOutPower += pItem.dGridOutPower
                            pResult.dInverterPower += pItem.dInverterPower
                            pResult.dLoadPower += pItem.dLoadPower
                        Next

                        Try

                            szHistoryFile = String.Format("{0}\H{1}-{2}.csv", szPath, pHistoryData.nYear.ToString("0000"), pHistoryData.nMonth.ToString("00"))
                            Dim bFIleCheck As Boolean = System.IO.File.Exists(szHistoryFile)

                            Dim pWriter As New System.IO.StreamWriter(szHistoryFile, True, System.Text.Encoding.UTF8)

                            If bFIleCheck = False Then
                                Dim szColumnTitle As String = "Day,BatteryCharge,BatteryDischarge,GridIn,GridOut,Inverter,Load"
                                pWriter.WriteLine(szColumnTitle)
                            End If

                            Dim szColumnData As String = pHistoryData.nDay.ToString("00")
                            szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerCharge)
                            szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerDischarge)
                            szColumnData &= String.Format(",{0:F1}", pResult.dGridInPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dGridOutPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dInverterPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dLoadPower)

                            pWriter.WriteLine(szColumnData)

                            pWriter.Close()

                        Catch ex As Exception
                            Debug.WriteLine(ex.ToString)
                        End Try

                    End If

                End If

                배터리_어제_충전 = 배터리_당일_충전
                배터리_당일_충전 = 0

                배터리_어제_방전 = 배터리_당일_방전
                배터리_당일_방전 = 0

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try

        End If

        If pHistoryData.nMonth <> tCurrent.Month Then
            Try



                szHistoryFile = String.Format("{0}\H{1}-{2}.csv", szPath, pHistoryData.nYear.ToString("0000"), pHistoryData.nMonth.ToString("00"))

                If System.IO.File.Exists(szHistoryFile) = True Then

                    Dim bMatch As Boolean = False
                    Using txtReader As New System.IO.StreamReader(szHistoryFile)
                        While True
                            Dim szReadLine As String = txtReader.ReadLine()
                            If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                            Dim szItems() As String = szReadLine.Split(",")
                            If szItems(0) = "Day" And szItems(1) = "BatteryCharge" And szItems(2) = "BatteryDischarge" And szItems(3) = "GridIn" And szItems(4) = "GridOut" And szItems(5) = "Inverter" And szItems(6) = "Load" Then
                                bMatch = True
                            End If
                            Exit While
                        End While
                        txtReader.Close()
                    End Using

                    If bMatch = True Then

                        Dim pHistory_Month As New ArrayList
                        Using txtReader As New System.IO.StreamReader(szHistoryFile)
                            While True
                                Dim szReadLine As String = txtReader.ReadLine()
                                If szReadLine = "" Or szReadLine Is Nothing Then Exit While

                                Dim szItems() As String = szReadLine.Split(",")
                                If szItems(0) = "Day" Then
                                Else

                                    Dim szTime As String = szItems(0)
                                    Dim dBatteryCharge As Double = Val(szItems(1))
                                    Dim dBatteryDischarge As Double = Val(szItems(2))
                                    Dim dGridIn As Double = Val(szItems(3))
                                    Dim dGridOut As Double = Val(szItems(4))
                                    Dim dInverter As Double = Val(szItems(5))
                                    Dim dLoad As Double = Val(szItems(6))

                                    Dim pItem As New stHistoryItem

                                    pItem.dBattPowerCharge = dBatteryCharge
                                    pItem.dBattPowerDischarge = dBatteryDischarge
                                    pItem.dGridInPower = dGridIn
                                    pItem.dGridOutPower = dGridOut
                                    pItem.dInverterPower = dInverter
                                    pItem.dLoadPower = dLoad

                                    pHistory_Month.Add(pItem)

                                End If

                            End While
                            txtReader.Close()
                        End Using

                        Dim pResult As New stHistoryItem

                        For Each pItem As stHistoryItem In pHistory_Month
                            pResult.dBattPowerCharge += pItem.dBattPowerCharge
                            pResult.dBattPowerDischarge += pItem.dBattPowerDischarge
                            pResult.dGridInPower += pItem.dGridInPower
                            pResult.dGridOutPower += pItem.dGridOutPower
                            pResult.dInverterPower += pItem.dInverterPower
                            pResult.dLoadPower += pItem.dLoadPower
                        Next

                        Try

                            szHistoryFile = String.Format("{0}\H{1}.csv", szPath, pHistoryData.nYear.ToString("0000"))
                            Dim bFIleCheck As Boolean = System.IO.File.Exists(szHistoryFile)

                            Dim pWriter As New System.IO.StreamWriter(szHistoryFile, True, System.Text.Encoding.UTF8)

                            If bFIleCheck = False Then
                                Dim szColumnTitle As String = "Month,BatteryCharge,BatteryDischarge,GridIn,GridOut,Inverter,Load"
                                pWriter.WriteLine(szColumnTitle)
                            End If

                            Dim szColumnData As String = pHistoryData.nMonth.ToString("00")
                            szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerCharge)
                            szColumnData &= String.Format(",{0:F1}", pResult.dBattPowerDischarge)
                            szColumnData &= String.Format(",{0:F1}", pResult.dGridInPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dGridOutPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dInverterPower)
                            szColumnData &= String.Format(",{0:F1}", pResult.dLoadPower)

                            pWriter.WriteLine(szColumnData)

                            pWriter.Close()

                        Catch ex As Exception
                            Debug.WriteLine(ex.ToString)
                        End Try

                    End If

                End If

            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try

        End If


        If pHistoryData.nMinute <> tCurrent.Minute And tCurrent.Second Mod 10 = 0 Then

            Dim pItem As New stHistoryItem


            Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)

            Dim nCharge As Integer = ushValue >> 4 And &H1
            Dim nDischarge As Integer = ushValue >> 5 And &H1

            Dim ushTemp As UShort = 0
            Dim dTemp As Double = 0
            If nCharge = 1 Then
                'ushTemp = GetModbusData_Ushort(PT_BAT_Power)
                ushTemp = GetModbusData_Ushort(PT_Inv_Power)
                dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
                pItem.dBattPowerCharge = dTemp * 0.1 * -1
                pItem.dBattPowerDischarge = 0
            ElseIf nDischarge = 1 Then
                ' ushTemp = GetModbusData_Ushort(PT_BAT_Power)
                ushTemp = GetModbusData_Ushort(PT_Inv_Power)
                dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
                pItem.dBattPowerCharge = 0
                pItem.dBattPowerDischarge = dTemp * 0.1
            Else
                pItem.dBattPowerCharge = 0
                pItem.dBattPowerDischarge = 0
            End If

            ushTemp = GetModbusData_Ushort(PT_Inv_Power)
            dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
            pItem.dGridInPower = dTemp * 0.1

            ushTemp = GetModbusData_Ushort(PT_Inv_Power)
            dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
            pItem.dGridOutPower = dTemp * 0.1

            ushTemp = GetModbusData_Ushort(PT_Inv_Power)
            dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
            pItem.dInverterPower = dTemp * 0.1

            ushTemp = GetModbusData_Ushort(PT_Inv_Power)
            dTemp = Convert.ToInt16(ushTemp.ToString("X4"), 16)
            pItem.dLoadPower = dTemp * 0.1

            pHistoryData.pHistory_Hour.Add(pItem)

        End If

        pHistoryData.nYear = tCurrent.Year
        pHistoryData.nMonth = tCurrent.Month
        pHistoryData.nDay = tCurrent.Day
        pHistoryData.nHour = tCurrent.Hour
        pHistoryData.nMinute = tCurrent.Minute


        Set_MODBUS_EMS_BUFFER(62, 배터리_당일_충전 * 10)
        Set_MODBUS_EMS_BUFFER(63, 배터리_당일_방전 * 10)
        Set_MODBUS_EMS_BUFFER(64, 배터리_당월_충전 * 10)
        Set_MODBUS_EMS_BUFFER(65, 배터리_당월_방전 * 10)
        Set_MODBUS_EMS_BUFFER(66, 배터리_누적_충전 / 1000 / 1000 * 100)
        Set_MODBUS_EMS_BUFFER(67, 배터리_누적_방전 / 1000 / 1000 * 100)

    End Sub

    Public Sub FaultSave(ByVal szEventDate As String, ByVal szEventTime As String, ByVal szFileNo As String, ByVal szEventText As String, ByVal szStatus As String)

        Dim nFileNo As Integer = szFileNo

        Dim szPath As String

        If isSDCard_Mode = True Then
            If PathCheck("\SD Card\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\SD Card\FaultHistory"
            End If
        Else '  isSDCard_Mode = False
            If PathCheck("\Flash Disk\Run\FaultHistory") = False Then
                Exit Sub
            Else
                szPath = "\Flash Disk\Run\FaultHistory"
            End If
        End If
        Try

            Dim szHistoryFile As String = ""

            If nFileNo = 35 Then
                ' 고장이력
                szHistoryFile = String.Format("{0}\Inverter_{1}.csv", szPath, szEventDate)
            ElseIf nFileNo = 36 Then
                ' 정전이력
                szHistoryFile = String.Format("{0}\Grid_{1}.csv", szPath, szEventDate)
            ElseIf nFileNo = 37 Then
                ' 전장상태
                szHistoryFile = String.Format("{0}\Status_{1}.csv", szPath, szEventDate)
            ElseIf nFileNo = 0 Then
                ' 통신이력
                szHistoryFile = String.Format("{0}\Comm_{1}.csv", szPath, szEventDate)
            End If

            Dim bFIleCheck As Boolean = System.IO.File.Exists(szHistoryFile)


            Dim pWriter As System.IO.StreamWriter = Nothing
            pWriter = New System.IO.StreamWriter(szHistoryFile, True, System.Text.Encoding.UTF8)

            If bFIleCheck = False Then

                Dim szColumnTitle As String = "Date,Time,Code,EventText,Status"

                pWriter.WriteLine(szColumnTitle)
            End If

            Dim szColumnData As String = String.Format("{0},{1},{2},{3},{4}", szEventDate, szEventTime, nFileNo, szEventText, szStatus)

            pWriter.WriteLine(szColumnData)

            pWriter.Close()

        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Sub


End Class

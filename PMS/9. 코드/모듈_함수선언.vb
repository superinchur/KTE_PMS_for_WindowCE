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

    Public Sub 배터리충전시작()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)
        ushValue = SetBitmask(ushValue, 4, 1)
        제어대기열_추가(PT_MODE_Status, ushValue)
    End Sub
    Public Sub 배터리충전취소()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)
        ushValue = SetBitmask(ushValue, 4, 0)
        제어대기열_추가(PT_MODE_Status, ushValue)
    End Sub

    Public Sub 배터리방전취소()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)
        ushValue = SetBitmask(ushValue, 5, 0)
        제어대기열_추가(PT_MODE_Status, ushValue)
    End Sub
    Public Sub 배터리방전시작()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_MODE_Status)
        ushValue = SetBitmask(ushValue, 5, 1)
        제어대기열_추가(PT_MODE_Status, ushValue)
    End Sub

    Public Sub 충전시최대전류값설정(ByVal 사용모드_배터리_충전시최대전류)
        제어대기열_추가(PT_Constant_Current, Convert.ToUInt16(사용모드_배터리_충전시최대전류))
    End Sub

    Public Sub 방전시최대전류값설정(ByVal 사용모드_배터리_방전시최대전류)
        제어대기열_추가(PT_Constant_Voltage, Convert.ToUInt16(사용모드_배터리_방전시최대전류))
    End Sub

    Public Sub 충전시유효전력설정(ByVal dBattVoltageofPCS)
        Dim d최종_유효전력 As Double ' kw
        '                                                                        전류              X       전압               / kW
        Dim d배터리_충전시최대전력 As Double = (d사용모드_배터리_충전시최대전류 * dBattVoltageofPCS) / 1000

        If d배터리_충전시최대전력 < d사용모드_유효전력 Then
            ' 유효전력을 낮춰줘야함
            d최종_유효전력 = d배터리_충전시최대전력
        Else
            d최종_유효전력 = d사용모드_유효전력
        End If

        Dim rawvalue As UShort = GetModbusData_Ushort(PT_Grid_Active_Power)
        Dim minvalue As UShort = rawvalue * (1 - 0.1)
        Dim maxvalue As UShort = rawvalue * (1 + 0.1)

        ' 5% 정도의 오차는 감안해서 5% 이내로 움직일 때만 요청을 보내도록 한다.

        If minvalue >= d최종_유효전력 Or d최종_유효전력 >= maxvalue Then
            If d최종_유효전력 > 0 Then
                제어대기열_추가(PT_Grid_Active_Power, d최종_유효전력 * 10)
                Set_MODBUS_EMS_BUFFER(44, d최종_유효전력 * 10)
            End If
        End If
    End Sub

    Public Sub 방전시유효전력설정(ByVal dBattVoltageofPCS)
        Dim d최종_유효전력 As Double ' kw
        '                                                                        전류              X       전압               / kW
        Dim d배터리_방전시최대전력 As Double = (d사용모드_배터리_방전시최대전류 * dBattVoltageofPCS) / 1000

        If d배터리_방전시최대전력 < d사용모드_유효전력 Then
            ' 유효전력을 낮춰줘야함
            d최종_유효전력 = d배터리_방전시최대전력
        Else
            d최종_유효전력 = d사용모드_유효전력
        End If

        Dim rawvalue As UShort = GetModbusData_Ushort(PT_Grid_Active_Power)
        Dim minvalue As UShort = rawvalue * (1 - 0.1)
        Dim maxvalue As UShort = rawvalue * (1 + 0.1)

        If Not (GetModbusData_Ushort(PT_Grid_Active_Power) = d최종_유효전력) Then

            If Not (minvalue >= d최종_유효전력 And d최종_유효전력 <= maxvalue) Then
                제어대기열_추가(PT_Grid_Active_Power, d최종_유효전력 * 10)
                Set_MODBUS_EMS_BUFFER(44, d최종_유효전력 * 10)
            End If
        End If
    End Sub

    Public Sub 현재사용모드확인()
        Dim ushModeStatus As UShort = GetModbusData_Ushort(PT_MODE_Status)

        If ushModeStatus >> 4 And &H1 Then
            현재사용모드_배터리충전 = True
        Else
            현재사용모드_배터리충전 = False
        End If

        If ushModeStatus >> 5 And &H1 Then
            현재사용모드_배터리방전 = True
        Else
            현재사용모드_배터리방전 = False
        End If

        If ushModeStatus >> 5 And &H1 Then
            현재사용모드_PCS방전강제종료 = True
        Else
            현재사용모드_PCS방전강제종료 = False
        End If

        If ushModeStatus >> 6 And &H1 Then
            현재사용모드_PCS충전강제종료 = True
        Else
            현재사용모드_PCS충전강제종료 = False
        End If

        Dim szTime1Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 1).ToString("00"), 사용모드_피크컷시간(1, 2).ToString("00"))
        Dim szTime1End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 3).ToString("00"), 사용모드_피크컷시간(1, 4).ToString("00"))
        Dim szTime2Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 1).ToString("00"), 사용모드_피크컷시간(2, 2).ToString("00"))
        Dim szTime2End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 3).ToString("00"), 사용모드_피크컷시간(2, 4).ToString("00"))

        Dim szCurrent As String = Format(Now, "HH:mm")
        Dim bDischargingTime As Boolean = False

        '' 24시간 넘어가는것을 하기 위해서 And 에서 Or로 변경 ' 180306
        If (szTime1Start > szTime1End) And (szTime1Start <= szCurrent Or szCurrent < szTime1End) Then
            현재사용모드_배터리방전시간 = True
        ElseIf (szTime1Start < szTime1End) And (szTime1Start <= szCurrent And szCurrent < szTime1End) Then
            현재사용모드_배터리방전시간 = True
        ElseIf (szTime2Start > szTime2End) And (szTime2Start <= szCurrent Or szCurrent < szTime2End) Then
            현재사용모드_배터리방전시간 = True
        ElseIf (szTime2Start < szTime2End) And (szTime2Start <= szCurrent And szCurrent < szTime2End) Then
            현재사용모드_배터리방전시간 = True
        Else
            현재사용모드_배터리방전시간 = False
        End If
    End Sub

    Public Sub 경보발생및해제(ByVal nStatus, ByVal nFileNo, ByVal nBit)
        ' heartbit가 동작중에는 flag_PCS_COMMFAULT Flag를 설정시키기 때문에 
        ' Heartbit가 동작중에는 초기화 하는것이 필요하다. Heartbit가 11이 됨으로 부터 정상적인 PCS Alarm 발생을 시작
        If heartbit <= 11 Then
            Exit Sub
        End If
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
    End Sub

    Public Sub Set_MODBUS_EMS_BUFFER(ByVal address, ByVal val)

        '' Buffer Overflow를 막기위한 항목
        If address < 512 Then
            MODBUS_EMS_BUFFER(address * 2) = Convert.ToInt16(val) \ &H100
            MODBUS_EMS_BUFFER(address * 2 + 1) = Convert.ToInt16(val) Mod &H100
        End If
        
    End Sub

    Function PathCheck(ByVal directory)

        Dim szPath As String = directory
        Dim bPathCheck As Boolean = System.IO.Directory.Exists(szPath)

        If bPathCheck = False Then System.IO.Directory.CreateDirectory(szPath)
        ' SDCard가 인식이 되지 않으면, Flash Disk에 넣도록 수정한다.
        PathCheck = System.IO.Directory.Exists(szPath)
    End Function
End Module

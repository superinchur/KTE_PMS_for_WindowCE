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

#Region "KTEuPMS_180503_추가본"

    Public Sub 초기시퀀스()
        INV_Control_Mode_제어대기열_추가(0, 1)
    End Sub

    Public Sub 원격RESET()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_Fault)

        If (ushValue >> 5 And &H7) = 7 Then
            ' H/W Fault, 현장 확인 해야함. 새로운 Alarm 새로 만들어야 함.
        Else
            Dim ushValue1 As UShort = GetModbusData_Ushort(PT_PCS_STANDBY)
            Dim ushValue2 As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

            If (ushValue1 And &H1) And (ushValue2 >> 7 And &H1) Then
                ' nothing to do
            Else
                Dim ushValue3 As UShort = SetBitmask(ushValue, 7, 1)
                제어대기열_추가(PT_Fault, ushValue3)
            End If

        End If
    End Sub

    Public Sub 원격RESET_확인()
        Dim ushValue1 As UShort = GetModbusData_Ushort(PT_PCS_STANDBY)
        Dim ushValue2 As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

        If (ushValue1 And &H1) And (ushValue2 >> 7 And &H1) Then
            ' nothing to do
        Else
            Dim ushValue As UShort = SetBitmask(ushValue, 7, 1)
            제어대기열_추가(PT_Fault, ushValue)
        End If
    End Sub

    Public Sub KTE피크컷동작()
        Dim deadbandSOC As Integer = 3

        ' 배터리 충/방전 확인 비트
        Dim dBATT_SOC As Double = cBMS.System_SOC
        Dim ushPT_Fault As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

        'STANDBY가 1이라면 RESET한다.
        Dim PCS_STANDBY As UShort = GetModbusData_Ushort(PT_PCS_STANDBY)
        If PCS_STANDBY And &H1 = True Then
            ' RESET 한다
            INV_Control_Mode_제어대기열_추가(8, 0)
        End If


        '일반모드
        If 현재사용모드_배터리방전시간 = True Then
            If dBATT_SOC > d사용모드_배터리_방전정지SOC Then
                If ushPT_Fault >> 7 And &H1 Then
                    ' do nothing
                Else
                    INV_Control_Mode_제어대기열_추가(0, 1)
                    INV_Control_Mode_제어대기열_추가(2, 1)
                    INV_Control_Mode_제어대기열_추가(6, 0)
                    INV_Control_Mode_제어대기열_추가(7, 1)
                End If
            Else
                INV_Control_Mode_제어대기열_추가(0, 1)
                INV_Control_Mode_제어대기열_추가(2, 0)
                INV_Control_Mode_제어대기열_추가(6, 0)
                INV_Control_Mode_제어대기열_추가(7, 0)
            End If
        ElseIf 현재사용모드_배터리방전시간 = False Then
            If dBATT_SOC < d사용모드_배터리_충전정지SOC Then
                If ushPT_Fault >> 6 And &H1 Then
                    ' do nothing
                Else
                    INV_Control_Mode_제어대기열_추가(0, 1)
                    INV_Control_Mode_제어대기열_추가(2, 1)
                    INV_Control_Mode_제어대기열_추가(6, 1)
                    INV_Control_Mode_제어대기열_추가(7, 0)
                End If

            Else
                INV_Control_Mode_제어대기열_추가(0, 1)
                INV_Control_Mode_제어대기열_추가(2, 0)
                INV_Control_Mode_제어대기열_추가(6, 0)
                INV_Control_Mode_제어대기열_추가(7, 0)
            End If
        End If

        If Not d사용모드_유효전력_이전값 = d사용모드_유효전력 Then
            제어대기열_추가(PT_Power_Active_Set, d사용모드_유효전력 * 10)
        End If
        d사용모드_유효전력_이전값 = d사용모드_유효전력
    End Sub
#End Region


    Public Sub 배터리충전시작()
        INV_Control_Mode_제어대기열_추가(4, 1)
    End Sub
    Public Sub 배터리충전취소()
        INV_Control_Mode_제어대기열_추가(4, 0)
    End Sub

    Public Sub 배터리방전취소()
        INV_Control_Mode_제어대기열_추가(5, 0)
    End Sub
    Public Sub 배터리방전시작()
        INV_Control_Mode_제어대기열_추가(5, 1)
    End Sub

    Public Sub 현재사용모드확인()
        Dim ushModeStatus As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

        If ushModeStatus >> 0 And &H1 Then
            현재사용모드_STANDBY = True
        Else
            현재사용모드_STANDBY = False
        End If

        If ushModeStatus >> 3 And &H1 Then
            현재사용모드_ESS모드 = True
        Else
            현재사용모드_ESS모드 = False
        End If

        If ushModeStatus >> 6 And &H1 Then
            현재사용모드_배터리충전 = True
        Else
            현재사용모드_배터리충전 = False
        End If

        If ushModeStatus >> 7 And &H1 Then
            현재사용모드_배터리방전 = True
        Else
            현재사용모드_배터리방전 = False
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

    Public Sub PCS_Fault_처리_프로시져()
        'PCS_DataDisplay(szMode, szMessage)
        ' 46~47 에러 하기 (PCS쪽 Fault)
        For nFileNo As Integer = 46 To 47
            Dim ushValue As UShort = GetModbusData_Ushort(nFileNo)

            For nBit As Integer = 0 To 15
                Dim nStatus As Integer = ushValue >> nBit And &H1
                If Val(FAULT_STATUS(nFileNo, nBit, 0) & "") <> nStatus Then
                    경보발생및해제(nStatus, nFileNo, nBit)
                End If
            Next
        Next
    End Sub

    Public Sub BMS_Fault_처리_프로시져()
        ' 14~15 에러 하기 (BMS쪽 Fault)
        For nFileNo As Integer = 14 To 22
            Dim ushValue As UShort
            For nBit As Integer = 0 To 15
                If nFileNo = 14 Then
                    ushValue = cBMS.Protection_Summary4
                ElseIf nFileNo = 15 Then
                    ushValue = cBMS.Protection_Summary3
                ElseIf nFileNo = 16 Then
                    ushValue = cBMS.Protection_Summary2
                ElseIf nFileNo = 17 Then
                    ushValue = cBMS.Protection_Summary1
                ElseIf nFileNo = 18 Then
                    ushValue = cBMS.Alarm_Summary4
                ElseIf nFileNo = 19 Then
                    ushValue = cBMS.Alarm_Summary3
                ElseIf nFileNo = 20 Then
                    ushValue = cBMS.Alarm_Summary2
                ElseIf nFileNo = 21 Then
                    ushValue = cBMS.Alarm_Summary1
                End If

                Dim nStatus As Integer = ushValue >> nBit And &H1
                If Val(FAULT_STATUS(nFileNo, nBit, 0) & "") <> nStatus Then
                    경보발생및해제(nStatus, nFileNo, nBit)
                End If
            Next
        Next
    End Sub
    Public Sub Set_MODBUS_EMS_BUFFER(ByVal address, ByVal val)

        '' Buffer Overflow를 막기위한 항목
        If address < 512 Then
            MODBUS_EMS_BUFFER(address * 2) = Convert.ToInt16(val) \ &H100
            MODBUS_EMS_BUFFER(address * 2 + 1) = Convert.ToInt16(val) Mod &H100
        End If

    End Sub

    Public Function Get_MODBUS_EMS_BUFFER(ByVal address) As UShort

        '' Buffer Overflow를 막기위한 항목
        If address < 512 Then
            Get_MODBUS_EMS_BUFFER = MODBUS_EMS_BUFFER(address * 2) * 256 + MODBUS_EMS_BUFFER(address * 2 + 1)
        End If

    End Function

    Function PathCheck(ByVal directory)

        Dim szPath As String = directory
        Dim bPathCheck As Boolean = System.IO.Directory.Exists(szPath)

        If bPathCheck = False Then System.IO.Directory.CreateDirectory(szPath)
        ' SDCard가 인식이 되지 않으면, Flash Disk에 넣도록 수정한다.
        PathCheck = System.IO.Directory.Exists(szPath)
    End Function

    Sub 리모트모드수행()
        Dim current_PT_INV_Control_Mode As UShort = 0
        Dim current_PT_Power_Active_Set As UShort = 0
        Dim current_PT_Current_Battery_SOC_DATA As UShort = 0

        current_PT_INV_Control_Mode = Get_MODBUS_EMS_BUFFER(0)
        current_PT_Power_Active_Set = Get_MODBUS_EMS_BUFFER(1)
        current_PT_Current_Battery_SOC_DATA = Get_MODBUS_EMS_BUFFER(2)

        If Not prev_PT_INV_Control_Mode = current_PT_INV_Control_Mode Then
            ' nothing to do
            제어대기열_추가(PT_INV_Control_Mode, current_PT_INV_Control_Mode)
        End If

        If Not prev_PT_Power_Active_Set = current_PT_Power_Active_Set Then
            ' nothing to do
            제어대기열_추가(PT_Power_Active_Set, current_PT_Power_Active_Set)

        End If

        If Not prev_PT_Current_Battery_SOC_DATA = current_PT_Current_Battery_SOC_DATA Then
            ' nothing to do
            제어대기열_추가(PT_Current_Battery_SOC_DATA, current_PT_Current_Battery_SOC_DATA)

        End If
        '현재값을 이전값으로 갱신한다.
        prev_PT_INV_Control_Mode = current_PT_INV_Control_Mode
        '현재값을 이전값으로 갱신한다.
        prev_PT_Power_Active_Set = current_PT_Power_Active_Set
        '현재값을 이전값으로 갱신한다.
        prev_PT_Current_Battery_SOC_DATA = current_PT_Current_Battery_SOC_DATA
    End Sub

    Sub INV_Control_Mode_제어대기열_추가(ByVal nOffset As Integer, ByVal nValue As Integer)
        Dim temp_control_PT_INV_Control_Mode As UShort
        '180518
        'control_PT_INV_Control_Mode를 연산하고, 그 값과, 현재 값이 일치 하는지 하지 않는지 확인한다.
        ' 일치하지 않는다면 Changed되었다는 Flag를 Set한다.
        temp_control_PT_INV_Control_Mode = SetBitmask(control_PT_INV_Control_Mode, nOffset, nValue)
        If Not control_PT_INV_Control_Mode = temp_control_PT_INV_Control_Mode Then
            flag_control_PT_INV_Control_Mode_Changed = True
            control_PT_INV_Control_Mode = temp_control_PT_INV_Control_Mode
        End If
    End Sub

    Sub INV_Control_Mode_로컬제어요청수행()
        '180518 
        'Flag가 Change 되었음을 인식한다면 PCS의 제어대기열에 추가한다.
        ' 이후 Flag를 다시 초기화한다.
        If flag_control_PT_INV_Control_Mode_Changed = True Then
            제어대기열_추가(PT_INV_Control_Mode, control_PT_INV_Control_Mode)
            flag_control_PT_INV_Control_Mode_Changed = False
        End If

    End Sub

End Module

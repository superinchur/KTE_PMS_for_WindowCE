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
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        If ushValue And &H1 Then
            ' nothing to do
        Else
            ushValue = SetBitmask(ushValue, 0, 1)
            제어대기열_추가(PT_INV_Control_Mode, ushValue)
        End If
    End Sub

    Public Sub 원격RESET()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_Fault)

        If (ushValue >> 5 And &H7) = 7 Then
            ' H/W Fault, 현장 확인 해야함. 새로운 Alarm 새로 만들어야 함.
        Else
            Dim ushValue1 As UShort = GetModbusData_Ushort(PT_PCS_STANDBY)
            Dim ushValue2 As UShort = GetModbusData_Ushort(PT_Fault)

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
        Dim ushValue2 As UShort = GetModbusData_Ushort(PT_Fault)

        If (ushValue1 And &H1) And (ushValue2 >> 7 And &H1) Then
            ' nothing to do
        Else
            Dim ushValue As UShort = SetBitmask(ushValue, 7, 1)
            제어대기열_추가(PT_Fault, ushValue)
        End If
    End Sub

    Public Sub 나주피크컷동작()

        Dim nCurrent As Integer = Now.Second
        Dim deadbandSOC As Integer = 3
        Dim deadbandVolt As Integer = 5
        If 현재사용모드_배터리방전시간 = True Then

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
                If dBATT_SOC <= d사용모드_배터리_방전정지SOC Then
                    ' SOC가 배터리 방전정지값 보다 작거나 같다면 방전을 중지해야한다.
                    If 현재사용모드_배터리방전 = True Then
                        ' 계속 방전중이라면 방전을 취소하고
                        배터리방전취소()

                    ElseIf 현재사용모드_배터리방전 = False Then
                        ' Nothing to do
                    End If
                ElseIf dBATT_SOC > d사용모드_배터리_방전정지SOC + deadbandSOC Then

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

            If 현재사용모드_배터리방전 = True Then
                배터리방전취소()
            ElseIf 현재사용모드_배터리방전 = False Then
                If dBATT_SOC < d사용모드_배터리_충전정지SOC Then
                    If 현재사용모드_배터리충전 = True Then
                        ' 배터리가 정상적으로 충전중이라면 더이상 명령을 내릴 필요가 없으니 아무일도 하지 않는다.
                        ' nothing to do
                    ElseIf 현재사용모드_배터리충전 = False Then
                        If 현재사용모드_PCS충전강제종료 = False Then
                            배터리충전시작()
                        End If
                    End If

                ElseIf dBATT_SOC >= d사용모드_배터리_충전정지SOC Then
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

        Else
            If 현재사용모드_배터리충전 = True Then
                배터리충전취소()
            End If
            If 현재사용모드_배터리방전 = True Then
                배터리방전취소()
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
    End Sub

    Dim prev_mode As UShort ' 1이면 충전 2면 방전

    Public Sub 모드변경확인()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ' 충전중, 방전중 상태 표시
        Dim nCharging As Integer = ushValue >> 6 And &H1
        Dim nDischarging As Integer = ushValue >> 7 And &H1

        Dim current_mode As UShort

        If nCharging Then
            current_mode = 1
        ElseIf nDischarging Then
            current_mode = 2
        Else
            current_mode = 0
        End If

        If (current_mode = 0) And Not (prev_mode = 0) Then
            INV_Control_Mode_제어대기열_추가(9, 1)
        ElseIf Not (current_mode = 0) And (prev_mode = 0) Then
            INV_Control_Mode_제어대기열_추가(9, 0)
        ElseIf Not prev_mode = current_mode Then
            ushValue = SetBitmask(ushValue, 9, 1)
            제어대기열_추가(PT_INV_Control_Mode, ushValue)
            ushValue = SetBitmask(ushValue, 9, 0)
            제어대기열_추가(PT_INV_Control_Mode, ushValue)
        End If
        prev_mode = current_mode
    End Sub
#End Region


    Public Sub 배터리충전시작()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 6, 1)
        ushValue = SetBitmask(ushValue, 3, 1)

        제어대기열_추가(PT_INV_Control_Mode, ushValue)
    End Sub
    Public Sub 배터리충전취소()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 6, 0)
        제어대기열_추가(PT_INV_Control_Mode, ushValue)
    End Sub

    Public Sub 배터리방전취소()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 7, 0)
        제어대기열_추가(PT_INV_Control_Mode, ushValue)
    End Sub
    Public Sub 배터리방전시작()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 7, 1)
        ushValue = SetBitmask(ushValue, 3, 1)

        제어대기열_추가(PT_INV_Control_Mode, ushValue)
    End Sub

    Public Sub 피크컷취소()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 2, 0)
        제어대기열_추가(PT_INV_Control_Mode, ushValue)
    End Sub
    Public Sub 피크컷시작()
        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        ushValue = SetBitmask(ushValue, 2, 1)
        제어대기열_추가(PT_INV_Control_Mode, ushValue)
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

        ' 74.0 // 20.0
        If d배터리_충전시최대전력 < d사용모드_유효전력 Then
            ' 유효전력을 낮춰줘야함
            d최종_유효전력 = d배터리_충전시최대전력
        Else
            d최종_유효전력 = d사용모드_유효전력
        End If

        Dim rawvalue As Double = GetModbusData_Ushort(PT_Grid_Active_Power) * 0.1
        Dim minvalue As Double = rawvalue * 0.9
        Dim maxvalue As Double = rawvalue * 1.1

        ' 5% 정도의 오차는 감안해서 5% 이내로 움직일 때만 요청을 보내도록 한다.

        '20
        If minvalue >= d최종_유효전력 Or d최종_유효전력 >= maxvalue Then
            If d최종_유효전력 > 0 Then
                제어대기열_추가(PT_Grid_Active_Power, Convert.ToInt16(d최종_유효전력 * 10))
                '/Set_MODBUS_EMS_BUFFER(44, Convert.ToInt16(d최종_유효전력 * 10))
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

        Dim rawvalue As Double = GetModbusData_Ushort(PT_Grid_Active_Power) * 0.1
        Dim minvalue As Double = rawvalue * (1 - 0.1)
        Dim maxvalue As Double = rawvalue * (1 + 0.1)

        If Not (rawvalue = d최종_유효전력) Then

            ' Offset
            If Not (minvalue <= d최종_유효전력 And d최종_유효전력 <= maxvalue) Then
                제어대기열_추가(PT_Grid_Active_Power, Convert.ToInt16(d최종_유효전력 * 10))
                'Set_MODBUS_EMS_BUFFER(44, Convert.ToInt16(d최종_유효전력 * 10))
            End If
        End If
    End Sub

    Public Sub 현재사용모드확인()
        Dim ushModeStatus As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)

        If ushModeStatus >> 7 And &H1 Then
            현재사용모드_배터리방전 = True
        Else
            현재사용모드_배터리방전 = False
        End If
        If ushModeStatus >> 6 And &H1 Then
            현재사용모드_배터리충전 = True
        Else
            현재사용모드_배터리충전 = False
        End If
        Dim szTime1Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 1).ToString("00"), 사용모드_피크컷시간(1, 2).ToString("00"))
        Dim szTime1End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(1, 3).ToString("00"), 사용모드_피크컷시간(1, 4).ToString("00"))
        Dim szTime2Start As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 1).ToString("00"), 사용모드_피크컷시간(2, 2).ToString("00"))
        Dim szTime2End As String = String.Format("{0}:{1}", 사용모드_피크컷시간(2, 3).ToString("00"), 사용모드_피크컷시간(2, 4).ToString("00"))

        Dim szCurrent As String = Format(Now, "HH:mm")
        Dim bDischargingTime As Boolean = False

        '' 24시간 넘어가는것을 하기 위해서 And 에서 Or로 변경 ' 180306
        ' 1이 충전시간
        If (szTime1Start > szTime1End) And (szTime1Start <= szCurrent Or szCurrent < szTime1End) Then
            현재사용모드_배터리충전시간 = True
            현재사용모드_배터리방전시간 = False
        ElseIf (szTime1Start < szTime1End) And (szTime1Start <= szCurrent And szCurrent < szTime1End) Then
            현재사용모드_배터리충전시간 = True
            현재사용모드_배터리방전시간 = False
        ElseIf (szTime2Start > szTime2End) And (szTime2Start <= szCurrent Or szCurrent < szTime2End) Then
            현재사용모드_배터리방전시간 = True
            현재사용모드_배터리충전시간 = False
        ElseIf (szTime2Start < szTime2End) And (szTime2Start <= szCurrent And szCurrent < szTime2End) Then
            현재사용모드_배터리방전시간 = True
            현재사용모드_배터리충전시간 = False
        Else
            현재사용모드_배터리방전시간 = False
            현재사용모드_배터리충전시간 = False
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

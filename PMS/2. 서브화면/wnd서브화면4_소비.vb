Public Class wnd서브화면4_소비

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Label1.Visible = False


        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True



    End Sub

    Private Sub 화면_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim g As Graphics = e.Graphics

        Dim thisRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim pPen As New Pen(메인화면.버튼_화면전환_메인.BorderColor, 메인화면.버튼_화면전환_메인.BorderWidth)

        g.DrawLine(pPen, Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)

        g.DrawLine(pPen, 0, 0, Me.Width - 1, 0)

        g.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)

    End Sub


    Private Sub 타이머_상태_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 타이머_상태.Tick

        타이머_상태.Enabled = False

        If Me.Visible = True Then
            상태표시()
        End If

        타이머_상태.Enabled = True

    End Sub

    Private 그리드상태 As Integer = -1

    Private Sub 상태표시()

        ' 부하 상태 

        Dim usPower As UShort = GetModbusData_Ushort(PT_INVERTER_POWER)
        ' UShort -> Short로 변환하기 위한 항목 Convert.ToInt16(usPower.ToString("X4"), 16)
        Dim dLoadPower As Double = Convert.ToInt16(usPower.ToString("X4"), 16)

        Dim ushValue As UShort = GetModbusData_Ushort(PT_CONTROL_MODE)
        Dim nCharge As Integer = ushValue >> 6 And &H1
        Dim nDischarge As Integer = ushValue >> 7 And &H1

        Dim szValue As String = String.Format("{0:F1} kW", dLoadPower)

        If lbLoadStatus.Text <> szValue Then
            lbLoadStatus.Text = szValue
            lbLoadStatus.Invalidate()

            lbPower2.Text = szValue

            '180529 
            ' 사용전 검사를 위해서 dLoadPower를 0 이상으로 변경
            If nDischarge = 1 Then
                ucScrollLoadStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left
            Else
                ucScrollLoadStatus.Arrow = ucScrollArrow.eArrow.Arrow_Stop
            End If

            lbPower2.Invalidate()
        End If

        Dim dValue As Double = GetModbusData_Ushort(PT_GRID_R_Voltage)
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage1.Text <> szValue Then lbVoltage1.Text = szValue

        dValue = GetModbusData_Ushort(PT_GRID_S_Voltage)
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage2.Text <> szValue Then lbVoltage2.Text = szValue

        dValue = GetModbusData_Ushort(PT_GRID_T_Voltage)
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage3.Text <> szValue Then lbVoltage3.Text = szValue

        ' 180529 사용자검사를 위해서 잘 나오는 전류값으로 변경
        ' 사용전 검사를 위해서 dLoadPower를 0 이상으로 변경
        ushValue = GetModbusData_Ushort(PT_GRID_R_Current)
        szValue = String.Format("{0:F1} A", Convert.ToInt16(ushValue.ToString("X4"), 16))
        If lbCurrent1.Text <> szValue Then lbCurrent1.Text = szValue

        ushValue = GetModbusData_Ushort(PT_GRID_S_Current)
        szValue = String.Format("{0:F1} A", Convert.ToInt16(ushValue.ToString("X4"), 16))
        If lbCurrent2.Text <> szValue Then lbCurrent2.Text = szValue

        ushValue = GetModbusData_Ushort(PT_GRID_T_Current)
        szValue = String.Format("{0:F1} A", Convert.ToInt16(ushValue.ToString("X4"), 16))
        If lbCurrent3.Text <> szValue Then lbCurrent3.Text = szValue

    End Sub

End Class

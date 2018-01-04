Public Class wnd서브화면4_소비

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Label1.Visible = False


        타이머_상태.Interval = 1000
        타이머_상태.Enabled = True

        ucScrollLoadStatus.Arrow = ucScrollArrow.eArrow.Arrow_Left

    End Sub

    Private Sub 화면_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        'Dim g As Graphics = e.Graphics

        'Dim thisRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        'Dim pPen As New Pen(메인화면.버튼_화면전환_메인.BorderColor, 메인화면.버튼_화면전환_메인.BorderWidth)

        'g.DrawLine(pPen, Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)

        'g.DrawLine(pPen, 0, 0, Me.Width - 1, 0)

        'g.DrawLine(pPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)

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
        Dim dLoadPower As Double = GetModbusData_Ushort(PT_load_Power) * 0.1
        Dim szValue As String = String.Format("{0:F1} kW", dLoadPower)

        If lbLoadStatus.Text <> szValue Then
            lbLoadStatus.Text = szValue
            lbLoadStatus.Invalidate()

            lbPower2.Text = szValue
            lbPower2.Invalidate()
        End If



        Dim dValue As Double = GetModbusData_Ushort(PT_V_load_R) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage1.Text <> szValue Then lbVoltage1.Text = szValue

        dValue = GetModbusData_Ushort(PT_V_load_S) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage2.Text <> szValue Then lbVoltage2.Text = szValue

        dValue = GetModbusData_Ushort(PT_V_load_T) * 0.1
        szValue = String.Format("{0:F1} V", dValue)
        If lbVoltage3.Text <> szValue Then lbVoltage3.Text = szValue


        dValue = GetModbusData_Ushort(PT_I_load_R) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent1.Text <> szValue Then lbCurrent1.Text = szValue

        dValue = GetModbusData_Ushort(PT_I_load_S) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent2.Text <> szValue Then lbCurrent2.Text = szValue

        dValue = GetModbusData_Ushort(PT_I_load_T) * 0.1
        szValue = String.Format("{0:F1} A", dValue)
        If lbCurrent3.Text <> szValue Then lbCurrent3.Text = szValue

    End Sub

End Class

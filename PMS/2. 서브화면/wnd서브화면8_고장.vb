Public Class wnd서브화면8_고장

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub

    Private Sub 화면_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    End Sub

    Public Sub LoadCurrentFault()
        ListView1.Items.Clear()

        Dim alFault As New ArrayList

        For Each pDir As System.Collections.DictionaryEntry In htCurrentFault
            Dim szFault As String = pDir.Value & ""
            If szFault <> "" Then
                alFault.Add(pDir.Value)
            End If
        Next

        alFault.Sort()

        For Each szFaultData As String In alFault
            Dim szFault() As String = szFaultData.Split("|")

            Dim pItem As New ListViewItem
            pItem.Text = (ListView1.Items.Count + 1).ToString
            pItem.SubItems.Add(szFault(0))
            pItem.SubItems.Add(szFault(1))
            pItem.SubItems.Add(szFault(2))

            Dim pItem2 As ListViewItem = ListView1.Items.Add(pItem)

            Application.DoEvents()
        Next

    End Sub
End Class

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports PMS

'''<summary>
'''이 클래스는 BMS클라이언트Test에 대한 테스트 클래스로서
'''BMS클라이언트Test 단위 테스트를 모두 포함합니다.
'''</summary>
<TestClass()> _
Public Class BMS클라이언트Test


    Private testContextInstance As TestContext

    '''<summary>
    '''현재 테스트 실행에 대한 정보 및 기능을
    '''제공하는 테스트 컨텍스트를 가져오거나 설정합니다.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "추가 테스트 특성"
    '
    '테스트를 작성할 때 다음 추가 특성을 사용할 수 있습니다.
    '
    'ClassInitialize를 사용하여 클래스의 첫 번째 테스트를 실행하기 전에 코드를 실행합니다.
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'ClassCleanup을 사용하여 클래스의 테스트를 모두 실행한 후에 코드를 실행합니다.
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'TestInitialize를 사용하여 각 테스트를 실행하기 전에 코드를 실행합니다.
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'TestCleanup을 사용하여 각 테스트를 실행한 후에 코드를 실행합니다.
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Display 테스트
    '''</summary>
    <TestMethod(), _
     DeploymentItem("PMS.exe")> _
    Public Sub DisplayTest()
        Dim target As BMS클라이언트_Accessor = New BMS클라이언트_Accessor ' TODO: 적절한 값으로 초기화합니다.
        Dim word() As UShort = Nothing ' TODO: 적절한 값으로 초기화합니다.
        target.Display(word)
        'TODO: asd 

        Assert.Inconclusive("값을 반환하지 않는 메서드는 확인할 수 없습니다.")
    End Sub
End Class

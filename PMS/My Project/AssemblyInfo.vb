Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' 어셈블리의 일반 정보는 다음 특성 집합을 통해 제어됩니다.
' 어셈블리와 관련된 정보를 수정하려면
' 이 특성 값을 변경하십시오.

' 어셈블리 특성 값을 검토합니다.

<Assembly: AssemblyTitle("EB-ESS99K")> 
<Assembly: AssemblyDescription("EB-ESS125K")> 
<Assembly: AssemblyCompany("EPS")> 
<Assembly: AssemblyProduct("EB-ESS99K")> 
<Assembly: AssemblyCopyright("Copyright ©  EPS 2016")> 
<Assembly: AssemblyTrademark("")>

<Assembly: CLSCompliant(True)>

<Assembly: ComVisible(False)>

'이 프로젝트가 COM에 노출되는 경우 다음 GUID는 typelib의 ID를 나타냅니다.
<Assembly: Guid("077c5ce0-f83e-426e-8c2b-9f8225c54420")>

' 어셈블리의 버전 정보는 다음 네 가지 값으로 구성됩니다.
'
'      주 버전
'      부 버전
'      빌드 번호
'      수정 버전
'
' 모든 값을 지정하거나 아래와 같이 '*'를 사용하여 빌드 번호 및 수정 버전이 자동으로
' 지정되도록 할 수 있습니다.
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.4.0")> 

'아래 특성은 FxCop 경고 "CA2232 : Microsoft.Usage : 어셈블리에 STAThreadAttribute를 추가하십시오."를 표시하지 않기 위해 사용되는데
' 이는 장치 응용 프로그램이 STA 스레드를 지원하지 않기 때문입니다.
<Assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")>

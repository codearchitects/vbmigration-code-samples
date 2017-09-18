' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module SystemAPI

	Friend Structure OSVERSIONINFO
	
		Public dwOSVersionInfoSize As Integer
		Public dwMajorVersion As Integer
		Public dwMinorVersion As Integer
		Public dwBuildNumber As Integer
		Public dwPlatformId As Integer
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=128)> _
		Private m_szCSDVersion As String
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			m_szCSDVersion = VB6FixedString.GetEmptyBuffer(128)
		End Sub
	
	#End Region

		Public Property szCSDVersion() As String
			Get
				Return VB6FixedString.Truncate(m_szCSDVersion, 128, ControlChars.NullChar)
			End Get
			Set(ByVal value As String)
				m_szCSDVersion = VB6FixedString.Truncate(value, 128)
			End Set
		End Property
	End Structure

	Private Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Integer) As Integer
	Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Integer) As Integer
	Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Integer, ByVal lpBuffer As String) As Integer
	Private Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	Private Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
	Private Declare Function GetVersion Lib "kernel32" () As Integer
	Private Declare Function GetVersionEx Lib "kernel32" Alias "GetVersionExA" (ByRef lpVersionInformation As OSVERSIONINFO) As Integer
	
	' The Windows directory.
	
	Public Function WindowsDirectory() As String
		Dim buffer As New VB6FixedString(512)
		Dim length As Integer
		length = GetWindowsDirectory(buffer.Value, Len6(buffer.Value))
		Return VB.Left(buffer.Value, length)
	End Function

	' The System directory
	
	Public Function SystemDirectory() As String
		Dim buffer As New VB6FixedString(512)
		Dim length As Integer
		length = GetSystemDirectory(buffer.Value, Len6(buffer.Value))
		Return VB.Left(buffer.Value, length)
	End Function

	' the Temp directory
	
	Public Function TemporaryDirectory() As String
		Dim buffer As New VB6FixedString(512)
		Dim length As Integer
		length = GetTempPath(Len6(buffer.Value), buffer.Value)
		Return VB.Left(buffer.Value, length)
	End Function

	' The user's name
	
	Public Function UserName() As String
		Dim buffer As New VB6FixedString(512)
		Dim length As Integer
		If GetUserName(buffer.Value, Len6(buffer.Value)) Then 
			length = InStr(buffer.Value, ControlChars.NullChar) - 1
			Return VB.Left(buffer.Value, length)
		End If
	End Function

	' The name of the computer
	
	Public ReadOnly Property ComputerName() As String
		Get
			Dim buffer As New VB6FixedString(512)
			Dim length As Integer
			length = Len6(buffer.Value)
			If GetComputerName(buffer.Value, length) Then 
				' returns non-zero if successful, and modifies the length argument
				Return VB.Left(buffer.Value, length)
			End If
	 	End Get
	End Property

	' Return True if running under Windows NT, False if running under Win9x.
	
	Public Function WindowsNT() As Boolean
		' Running under NT if the sign bit is off.
		Return (GetVersion() >= 0)
	End Function

	' Windows version as a string.
	
	Public Function WindowsVersion() As String
		Dim os As New OSVERSIONINFO(True)
		Dim ver As String = ""
		' The function expects the UDT size in its first element.
		os.dwOSVersionInfoSize = Len6(os)
		GetVersionEx(os)
		Return os.dwMajorVersion & "." & VB.Right("0" & Format6(os.dwMinorVersion), 2)
	End Function

	' Windows Build number.
	
	Public Function WindowsBuildNumber() As Integer
		Dim os As New OSVERSIONINFO(True)
		Dim ver As String = ""
		' The function expects the UDT size in its first element.
		os.dwOSVersionInfoSize = Len6(os)
		GetVersionEx(os)
		Return os.dwBuildNumber
	End Function

End Module

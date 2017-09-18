' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmAbout

	' Reg Key Security Options...
	Private Const KEY_ALL_ACCESS As Integer = &H2003FI

	' Reg Key ROOT Types...
	Private Const HKEY_LOCAL_MACHINE As Integer = &H80000002I
	Private Const ERROR_SUCCESS As Short = 0
	Private Const REG_SZ As Short = 1
	' Unicode nul terminated string
	Private Const REG_DWORD As Short = 4
	' 32-bit number

	Private Const gREGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"
	Private Const gREGVALSYSINFOLOC As String = "MSINFO"
	Private Const gREGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
	Private Const gREGVALSYSINFO As String = "PATH"

	Private Declare Function RegOpenKeyEx Lib "advapi32" Alias "RegOpenKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
	
	Private Sub Form_Load() Handles MyBase.Load
		lblVersion.Caption = "Version " & App6.Major & "." & App6.Minor & "." & App6.Revision
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		lblTitle.Caption = App6.Title
	End Sub

	Private Sub cmdSysInfo_Click() Handles cmdSysInfo.Click
		Call StartSysInfo()
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Public Sub StartSysInfo()
		On Error GoTo SysInfoErr 
		
		Dim rc As Integer
		Dim SysInfoPath As String = ""

		' Try To Get System Info Program Path\Name From Registry...
		If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFO, gREGVALSYSINFO, SysInfoPath) Then 
			' Try To Get System Info Program Path Only From Registry...
		ElseIf GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFOLOC, gREGVALSYSINFOLOC, SysInfoPath) Then 
			' Validate Existance Of Known 32 Bit File Version
			If (Dir6(SysInfoPath & "\MSINFO32.EXE") <> "") Then 
				SysInfoPath = SysInfoPath & "\MSINFO32.EXE"

				' Error - File Can Not Be Found...
			Else
				GoTo SysInfoErr
			End If
			' Error - Registry Entry Can Not Be Found...
		Else
			GoTo SysInfoErr
		End If

		Call Shell(SysInfoPath, AppWinStyle.NormalFocus)

		Exit Sub
SysInfoErr:
		MsgBox6("System Information Is Unavailable At This Time", MsgBoxStyle.DefaultButton1)
	End Sub

	Public Function GetKeyValue(ByRef KeyRoot As Integer, ByRef KeyName As String, ByRef SubKeyRef As String, ByRef KeyVal As String) As Boolean
		Dim i As Integer ' Loop Counter
		Dim rc As Integer ' Return Code
		Dim hKey As Integer ' Handle To An Open Registry Key
		Dim hDepth As Integer '
		Dim KeyValType As Integer ' Data Type Of A Registry Key
		Dim tmpVal As String = "" ' Tempory Storage For A Registry Key Value
		Dim KeyValSize As Integer ' Size Of Registry Key Variable
		'------------------------------------------------------------
		' Open RegKey Under KeyRoot {HKEY_LOCAL_MACHINE...}
		'------------------------------------------------------------
		rc = RegOpenKeyEx(KeyRoot, KeyName, 0, KEY_ALL_ACCESS, hKey) ' Open Registry Key

		If (rc <> ERROR_SUCCESS) Then  GoTo GetKeyError ' Handle Error...

		tmpVal = String6(1024, 0) ' Allocate Variable Space
		KeyValSize = 1024 ' Mark Variable Size

		'------------------------------------------------------------
		' Retrieve Registry Key Value...
		'------------------------------------------------------------
		rc = RegQueryValueEx(hKey, SubKeyRef, 0, KeyValType, tmpVal, KeyValSize) ' Get/Create Key Value

		If (rc <> ERROR_SUCCESS) Then  GoTo GetKeyError ' Handle Errors

		If (Asc(Mid(tmpVal, KeyValSize, 1)) = 0) Then  ' Win95 Adds Null Terminated String...
			tmpVal = VB.Left(tmpVal, KeyValSize - 1) ' Null Found, Extract From String
			 Else ' WinNT Does NOT Null Terminate String...
			tmpVal = VB.Left(tmpVal, KeyValSize) ' Null Not Found, Extract String Only
		End If
		'------------------------------------------------------------
		' Determine Key Value Type For Conversion...
		'------------------------------------------------------------
		Select Case KeyValType ' Search Data Types...
		Case REG_SZ ' String Registry Key Data Type
			KeyVal = tmpVal ' Copy String Value
		Case REG_DWORD ' Double Word Registry Key Data Type
			For i = Len6(tmpVal) To 1 Step -1 ' Convert Each Bit
				KeyVal &= Hex(Asc(Mid(tmpVal, i, 1))) ' Build Value Char. By Char.
			Next
			KeyVal = Format6("&h" & KeyVal) ' Convert Double Word To String
		End Select

		GetKeyValue = True ' Return Success
		rc = RegCloseKey(hKey) ' Close Registry Key
		Exit Function ' Exit

GetKeyError:
		' Cleanup After An Error Has Occured...
		KeyVal = "" ' Set Return Val To Empty String
		GetKeyValue = False ' Return Failure
		rc = RegCloseKey(hKey) ' Close Registry Key
	End Function

End Class

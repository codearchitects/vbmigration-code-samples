' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module Module1

	'For INI read/write
	' IGNORED: Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
	Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	' IGNORED: Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long
	Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
	' UPGRADE_INFO (#0501): The 'GetKeyState' member isn't used anywhere in current application.
	Public Declare Function GetKeyState Lib "user32" (ByVal NVirtKey As Short) As Short
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	' UPGRADE_INFO (#0501): The 'ReleaseCapture' member isn't used anywhere in current application.
	Public Declare Function ReleaseCapture Lib "user32" () As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowPos' unamanged method with the following .NET member(s): System.Windows.Forms.Form.BringToFront, System.Windows.Forms.Form.Enabled, System.Windows.Forms.Form.SendToBack, System.Windows.Forms.Form.SetBounds, System.Windows.Forms.Form.TopMost, System.Windows.Forms.Form.Visible
	Public Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
	
	Public Const HWND_NOTOPMOST As Short = -2
	Public Const HWND_TOPMOST As Short = -1
	Public Const SWP_NOMOVE As Short = &H2S
	Public Const SWP_NOSIZE As Short = &H1S
	Public Const Flags As Integer = SWP_NOMOVE Or SWP_NOSIZE
	
	'Global lRegion As Long
	
	Public MODULE_PATH As String = "" '// Add diffrent sets of pictures
	Public HAND_SPEED As Double
	Public INIFILE As String = ""
	Public LOOP_IT As Integer
	Public STOPED As Boolean
	
	Public Const DEFAULT_MOD_PATH As String = "\sign\"
	Public Const APP_NAME As String = "Options"
	
	'
	'---------------
	'   INI keys are:
	'   HandSpeed
	'   ModPath
	'   Loop
	'
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	<STAThread()> _
	Public Sub Main()
		'//////////////////////////////////
		'// LETS START THIS PUPPY UP :)
		'//////////////
		If InitializeFormChaining6() Then Exit Sub
		
		Dim rIni As String = ""
		Dim rIni1 As String = ""
		Dim rIni2 As String = ""
		
		STOPED = True '// Hand sign stoped
		
		MainFrm.Show() '// And then display it.

		'// Now we load options from ini file
		'// If non found then show options
		'// window and set ini  to defaults.
		
		INIFILE = App6.Path & "\TypeNsign.ini" '// Set INI file path
		
		rIni = GetFromINI(APP_NAME, "HandSpeed", INIFILE)
		rIni1 = GetFromINI(APP_NAME, "Loop", INIFILE)
		rIni2 = GetFromINI(APP_NAME, "ModPath", INIFILE)
		
		If rIni = "" Or rIni1 = "" Or rIni2 = "" Then  '// No ini file found
			HAND_SPEED = 15 '// Then set defaults
			MODULE_PATH = App6.Path & DEFAULT_MOD_PATH
			LOOP_IT = 1
			
			With OptionsFrm '// Set and Show Options Menu
				.Slider1.Value = Val(HAND_SPEED)
				.LocationTxt.Text = Trim(MODULE_PATH & "Hands.mod")
				.ChkLoop.Value = LOOP_IT
				.Show()
			End With
			
			 Else '// Else load defaults from ini file
			HAND_SPEED = Val(rIni)
			MODULE_PATH = rIni2
			
			If rIni1 = "1" Then  '// Set Loop varible
				LOOP_IT = 1
			Else
				LOOP_IT = 0
			End If
			
		End If
		
	End Sub
	
	'//////////////////////////////////
	
	Public Sub WebPage(ByRef Address As String)
	' UPGRADE_INFO (#0501): The 'WebPage' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'Address' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'///////////////////////////////////
		'// Open a webpage in the default browser
		'/////////
		
		On Error GoTo error_RENAMED 
		Dim ret As Double = Shell("Start.exe " & Address, AppWinStyle.NormalFocus)
		Exit Sub
error_RENAMED:
		MsgBox6(Err.Description, MsgBoxStyle.Exclamation, "Error")
		
	End Sub
	
	Public Sub ExecuteFile(ByRef FilePath As String)
	' UPGRADE_INFO (#0501): The 'ExecuteFile' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'FilePath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'//////////
		'// Open a file in notepad
		'//     [ExecuteFile("someFile.txt")]
		'//////
		On Error GoTo error_RENAMED 
		Dim ret As Double = Shell("rundll32.exe url.dll, FileProtocolHandler " & FilePath, AppWinStyle.NormalFocus)
		Exit Sub
error_RENAMED:
		MsgBox6(Err.Description, MsgBoxStyle.Exclamation, "Error")
		
	End Sub
	
	Public Sub CenterForm(ByRef Who As VB6Form)
	' UPGRADE_INFO (#0501): The 'CenterForm' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'Who' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		On  Error Resume Next 
		
		Who.Left = (Screen6.Width - Who.Width) / 2
		Who.Top = (Screen6.Height - Who.Height) / 2
		
	End Sub
	
	Public Sub Ontop(ByRef FormName As VB6Form)
	' UPGRADE_INFO (#0551): The 'FormName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		On Error Resume Next 
		Call SetWindowPos(FormName.hWnd, HWND_TOPMOST, 0%, 0%, 0%, 0%, Flags)
		
	End Sub
	
	Public Sub NotOntop(ByRef FormName As VB6Form)
	' UPGRADE_INFO (#0551): The 'FormName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		On Error Resume Next 
		Call SetWindowPos(FormName.hWnd, HWND_NOTOPMOST, 0%, 0%, 0%, 0%, Flags)
		
	End Sub
	
	Public Function GetFromINI(ByRef Section As String, ByVal Key As String, ByRef Directory As String) As String
	' UPGRADE_INFO (#0551): The 'Section' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Directory' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		Dim strBuffer As String = String6(750, Chr6(0))
		Key = LCase(Key)
		' UPGRADE_WARNING (#0384): Using the 'GetPrivateProfileString' Windows API method as an argument to the 'Left' function might result in an string filled with spaces. Please split the next line in two statements.
		' UPGRADE NOTE: : WAS GetFromINI$ = Left(strBuffer, GetPrivateProfileString(Section$, ByVal Key$, "", strBuffer, Len(strBuffer), Directory$))
		Dim length As Short = GetPrivateProfileString(Section, Key, "", strBuffer, Len6(strBuffer), Directory)
		Return VB.Left(strBuffer, length)
		
	End Function
	
	Public Sub WriteToINI(ByRef Section As String, ByVal Key As String, ByVal KeyValue As String, ByRef Directory As String)
	' UPGRADE_INFO (#0551): The 'Section' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Directory' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		Call WritePrivateProfileString(Section, UCase(Key), KeyValue, Directory)
		
	End Sub

End Module

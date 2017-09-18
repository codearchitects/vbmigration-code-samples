Attribute VB_Name = "Module1"
Option Explicit

'For INI read/write
Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long
Public Declare Function GetKeyState Lib "user32" (ByVal NVirtKey%) As Integer
Public Declare Function ReleaseCapture Lib "user32" () As Long
Public Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Public Const HWND_NOTOPMOST = -2
Public Const HWND_TOPMOST = -1
Public Const SWP_NOMOVE = &H2
Public Const SWP_NOSIZE = &H1
Public Const Flags = SWP_NOMOVE Or SWP_NOSIZE

'Global lRegion As Long

Public MODULE_PATH As String '// Add diffrent sets of pictures
Public HAND_SPEED As Double
Public INIFILE As String
Public LOOP_IT As Long
Public STOPED As Boolean

Public Const DEFAULT_MOD_PATH = "\sign\"
Public Const APP_NAME = "Options"

'
'---------------
'   INI keys are::
'   HandSpeed
'   ModPath
'   Loop
'

Sub Main()
'//////////////////////////////////
'// LETS START THIS PUPPY UP :)
'//////////////
Dim rIni As String, rIni1 As String, rIni2 As String

    STOPED = True                       '// Hand sign stoped
    
    MainFrm.Show                        '// And then display it.
    
    
    '// Now we load options from ini file
    '// If non found then show options
    '// window and set ini  to defaults.
    
        INIFILE$ = App.Path & "\TypeNsign.ini"  '// Set INI file path
        
        rIni$ = GetFromINI(APP_NAME$, "HandSpeed", INIFILE$)
        rIni1$ = GetFromINI(APP_NAME$, "Loop", INIFILE$)
        rIni2$ = GetFromINI(APP_NAME$, "ModPath", INIFILE$)
    
        If rIni$ = "" Or rIni1$ = "" Or rIni2$ = "" Then    '// No ini file found
            HAND_SPEED = 15                                 '// Then set defaults
            MODULE_PATH$ = App.Path & DEFAULT_MOD_PATH$
            LOOP_IT = 1
            
            With OptionsFrm                 '// Set and Show Options Menu
                .Slider1.Value = Val(HAND_SPEED)
                .LocationTxt.Text = Trim(MODULE_PATH$ & "Hands.mod")
                .ChkLoop.Value = LOOP_IT
                .Show
            End With

        Else                                '// Else load defaults from ini file
            HAND_SPEED = Val(rIni$)
            MODULE_PATH$ = rIni2$
            
            If rIni1 = "1" Then             '// Set Loop varible
                LOOP_IT = 1
            Else
                LOOP_IT = 0
            End If
            
        End If
       
End Sub
'//////////////////////////////////

Public Sub WebPage(Address As String)
'///////////////////////////////////
'// Open a webpage in the default browser
'/////////

    On Error GoTo error
    Dim ret As Double
    ret = Shell("Start.exe " & Address, vbNormalFocus)
    Exit Sub
error:      MsgBox Err.Description, vbExclamation, "Error"

End Sub
Public Sub ExecuteFile(FilePath As String)
'//////////
'// Open a file in notepad
'//     [ExecuteFile("someFile.txt")]
'//////
    On Error GoTo error
    Dim ret As Double
    ret = Shell("rundll32.exe url.dll, FileProtocolHandler " & FilePath$, vbNormalFocus)
    Exit Sub
error:      MsgBox Err.Description, vbExclamation, "Error"

End Sub
Sub CenterForm(Who As Form)

    On Local Error Resume Next
    
    Who.Left = (Screen.Width - Who.Width) / 2
    Who.Top = (Screen.Height - Who.Height) / 2

End Sub
Public Sub Ontop(FormName As Form)
    
    On Error Resume Next
    Call SetWindowPos(FormName.hWnd, HWND_TOPMOST, 0&, 0&, 0&, 0&, Flags)

End Sub
Public Sub NotOntop(FormName As Form)

    On Error Resume Next
    Call SetWindowPos(FormName.hWnd, HWND_NOTOPMOST, 0&, 0&, 0&, 0&, Flags)

End Sub
Public Function GetFromINI(Section As String, ByVal Key As String, Directory As String) As String

    Dim strBuffer As String
    strBuffer = String(750, Chr(0))
    Key$ = LCase$(Key$)
    GetFromINI$ = Left(strBuffer, GetPrivateProfileString(Section$, ByVal Key$, "", strBuffer, Len(strBuffer), Directory$))
       
End Function
Public Sub WriteToINI(Section As String, ByVal Key As String, ByVal KeyValue As String, Directory As String)

    Call WritePrivateProfileString(Section$, UCase$(Key$), KeyValue$, Directory$)
       
End Sub



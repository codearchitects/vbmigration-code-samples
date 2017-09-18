Attribute VB_Name = "MRecModule"
Option Explicit

Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
Public Declare Function ReleaseCapture Lib "user32" () As Long
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Public Const rsRecording = "Recording"
Public Const rsPlaying = "Playing"
Public Const rsIdle = "Idle"

Public RecorderState As String
Public MotionData As New Collection
Public SaveData As Boolean

' Form drag function        '
Public Sub EasyMove(frm As Form)
  If frm.WindowState <> vbMaximized Then
    ReleaseCapture
    SendMessage frm.hwnd, &HA1, 2, 0&
  End If
End Sub

' Set Window in Foreground 4ever    '
Public Sub SetWindowInFore(frm As Form, ByVal SetInFore As Boolean)
  If SetInFore Then
    'Fenster immer im Vordergrund
    Call SetWindowPos(frm.hwnd, -1, 0, 0, 0, 0, 3)
  Else
    'Fenster im Normalzustand
    Call SetWindowPos(frm.hwnd, -2, 0, 0, 0, 0, 3)
  End If
End Sub
  
' Sleep (Pause in Seconds)      '
Private Sub Sleep(ByVal Seconds As Double)
   Dim Tmr As Double
   Tmr = Timer + Seconds
   Do: DoEvents
   Loop While Tmr > Timer
End Sub

' Start Recording         '
Public Sub StartRecording()
  If RecorderState = rsPlaying Then Exit Sub
  If RecorderState = rsRecording Then
    RecorderState = rsIdle
  Else
    RecorderState = rsRecording
  End If
End Sub

' Start Playing           '
Public Sub StartPlaying()
  If RecorderState = rsRecording Then Exit Sub
  If RecorderState = rsPlaying Then
    RecorderState = rsIdle
  Else
    RecorderState = rsPlaying
  End If
End Sub

' Application path    '
Public Function ApplPath() As String
  Dim Temp As String
  Temp = App.Path
  If Right(Temp, 1) <> "\" Then Temp = Temp & "\"
  ApplPath = Temp
End Function

' Add new Motion      '
Public Sub AddMotion(x As Long, y As Long, T As Double, A As String)
  MotionData.Add A & "," & x & "," & y & "," & T
  SaveData = True
End Sub

Public Sub SaveDataToFile()
  Dim FName As String, ff As Long, i As Long, DNSF As Boolean
  If SaveData And MotionData.Count Then
    frmMain.comDlg.FileName = ""
    frmMain.comDlg.ShowSave
    FName = frmMain.comDlg.FileName
    If Len(Dir(FName)) Then
      If MsgBox("File already exists. Do you want to overwrite old File?", _
          vbYesNo + vbQuestion, "Save anyway?") = vbNo Then DNSF = True
    End If
    If Not DNSF Then
      On Local Error Resume Next
      ff = FreeFile
      Open FName For Output As ff
      Print #ff, "[MouseMotionFile]"
      For i = 1 To MotionData.Count
        If Err Then Exit For
        Print #ff, MotionData.Item(i)
      Next i
      If Err Then
        Err.Clear
        MsgBox "MouseRecorder has failed to save Data!" & vbCrLf & "Error: " & _
               Err.Number & vbCrLf & "  " & Err.Description, vbCritical, "Error!"
      Else
        SaveData = False
      End If
      Close ff
    End If
  End If
End Sub

Public Sub LoadDataFromFile(ByVal FName As String)
  Dim ff As Long, Markl As String
  SaveDataToFile
  If MotionData.Count Then
    Do Until MotionData.Count = 0
      MotionData.Remove 1
    Loop
  End If
  On Local Error Resume Next
  ff = FreeFile
  Open FName For Input As ff
  Line Input #ff, Markl
  If Markl = "[MouseMotionFile]" Then
    Do Until EOF(ff)
      Line Input #ff, Markl
      MotionData.Add Markl
      DoEvents
    Loop
  End If
  Close ff
End Sub

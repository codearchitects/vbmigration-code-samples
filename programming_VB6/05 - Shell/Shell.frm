VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Shell Demo"
   ClientHeight    =   4035
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7935
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4035
   ScaleWidth      =   7935
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Left            =   6600
      Top             =   2040
   End
   Begin VB.Frame Frame2 
      Caption         =   "Wait for termination "
      Height          =   1575
      Left            =   120
      TabIndex        =   7
      Top             =   2160
      Width           =   5655
      Begin VB.OptionButton optWait 
         Caption         =   "&Wait until Notepad ends"
         Height          =   255
         Index           =   2
         Left            =   360
         TabIndex        =   10
         Top             =   1080
         Width           =   4575
      End
      Begin VB.OptionButton optWait 
         Caption         =   "&Signal when Notepad ends"
         Height          =   255
         Index           =   1
         Left            =   360
         TabIndex        =   9
         Top             =   720
         Width           =   4575
      End
      Begin VB.OptionButton optWait 
         Caption         =   "&Don't wait"
         Height          =   255
         Index           =   0
         Left            =   360
         TabIndex        =   8
         Top             =   360
         Value           =   -1  'True
         Width           =   4575
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Contents"
      Height          =   1815
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   5655
      Begin VB.TextBox txtFilename 
         Height          =   375
         Left            =   360
         TabIndex        =   6
         Top             =   1080
         Width           =   4455
      End
      Begin VB.CommandButton cmdBrowse 
         Caption         =   "..."
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4800
         TabIndex        =   5
         Top             =   1080
         Width           =   495
      End
      Begin VB.OptionButton optContents 
         Caption         =   "This &File"
         Height          =   255
         Index           =   1
         Left            =   360
         TabIndex        =   4
         Top             =   720
         Width           =   3615
      End
      Begin VB.OptionButton optContents 
         Caption         =   "&Clipboard"
         Height          =   255
         Index           =   0
         Left            =   360
         TabIndex        =   3
         Top             =   360
         Value           =   -1  'True
         Width           =   3615
      End
   End
   Begin VB.CheckBox chkMaximized 
      Caption         =   "&Maximized"
      Height          =   255
      Left            =   6000
      TabIndex        =   1
      Top             =   1080
      Width           =   1455
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   7200
      Top             =   3120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdNotepad 
      Caption         =   "Run &Notepad"
      Height          =   615
      Left            =   6000
      TabIndex        =   0
      Top             =   240
      Width           =   1695
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##DisableMessage 0354

' the taskId of the shelled Notepad (a module level variable)
Dim taskId As Long

' load a file name into the txtFileName textbox control
Private Sub cmdBrowse_Click()
    With CommonDialog1
        .DialogTitle = "Select a TXT file"
        .Filter = "All files|*.*|Text Files (*.txt)|*.txt"
        .FilterIndex = 2
        .Flags = cdlOFNFileMustExist
        .ShowOpen
        txtFilename.Text = .FileName
        If Len(txtFilename.Text) Then optContents(1) = True
    End With
End Sub

' run Notepad with current settings
Private Sub cmdNotepad_Click()
    ' run Notepad in regular or maximized window
    If optContents(0) Then
        ' run Notepad with no file
        taskId = Shell("notepad", IIf(chkMaximized.Value, vbMaximizedFocus, vbNormalFocus))
        ' ensure it has the focus, send a Paste command
        AppActivate taskId
        SendKeys "^V", True
    Else
        ' runt Notepad on the selected file
        taskId = Shell("notepad " & txtFilename, IIf(chkMaximized.Value, vbMaximizedFocus, vbNormalFocus))
    End If
    
    If optWait(1) Then
        ' activate the timer that will poll for process termination
        Timer1.Interval = 250
    ElseIf optWait(2) Then
        ' wait until the process returns
        DoEvents
        Do
            ' you can do whatever you want while polling Notepad every second
            Beep
        Loop While WaitForProcess(taskId, 1000)
        ' replacing the above line with this one will block the VB program
        ' WaitForProcess taskId
    End If
End Sub

' check if the process has terminated every 250 ms.

Private Sub Timer1_Timer()
    If taskId = 0 Then Exit Sub

    If WaitForProcess(taskId, 0) = False Then
        ' disable the timer
        Timer1.Interval = 0
        taskId = 0
        ' inform the user that something happened
        MsgBox "Notepad has been closed", vbInformation
    End If
End Sub


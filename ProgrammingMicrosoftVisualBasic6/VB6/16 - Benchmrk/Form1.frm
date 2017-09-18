VERSION 5.00
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   Caption         =   "Benchmarks"
   ClientHeight    =   6315
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6660
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
   ScaleHeight     =   6315
   ScaleWidth      =   6660
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCreate 
      Caption         =   "Create"
      Height          =   615
      Left            =   4920
      TabIndex        =   9
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear Form"
      Height          =   615
      Left            =   4920
      TabIndex        =   8
      Top             =   960
      Width           =   1575
   End
   Begin VB.CommandButton cmdPublicClass 
      Caption         =   "Public Class"
      Height          =   615
      Left            =   4920
      TabIndex        =   7
      Top             =   4440
      Width           =   1575
   End
   Begin VB.CommandButton cmdPublicRoutine 
      Caption         =   "Public Routine"
      Height          =   615
      Left            =   4920
      TabIndex        =   6
      Top             =   3240
      Width           =   1575
   End
   Begin VB.CommandButton cmdPrivateRoutine 
      Caption         =   "Private Routine"
      Height          =   615
      Left            =   4920
      TabIndex        =   5
      Top             =   2640
      Width           =   1575
   End
   Begin VB.CommandButton cmdPrivateClass 
      Caption         =   "Private Class"
      Height          =   615
      Left            =   4920
      TabIndex        =   4
      Top             =   3840
      Width           =   1575
   End
   Begin VB.TextBox txtTimes 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   4920
      TabIndex        =   3
      Text            =   "1000"
      Top             =   360
      Width           =   1455
   End
   Begin VB.CommandButton cmdExeServer 
      Caption         =   "EXE Server"
      Height          =   615
      Left            =   4920
      TabIndex        =   1
      Top             =   5640
      Width           =   1575
   End
   Begin VB.CommandButton cmdDLLServer 
      Caption         =   "DLL Server"
      Height          =   615
      Left            =   4920
      TabIndex        =   0
      Top             =   5040
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "# of Iterations"
      Height          =   375
      Left            =   4920
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DisableMessage 0551

Private Sub cmdClear_Click()
    Cls
End Sub

Private Sub cmdCreate_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    Print "Testing Object Creation..."
    
    ReDim objects(NumTimes) As Routines
    t = Timer
    For i = 1 To NumTimes
        Set objects(i) = New Routines
    Next
    Print "Private class (New): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects2(NumTimes) As Routines2
    t = Timer
    For i = 1 To NumTimes
        Set objects2(i) = New Routines2
    Next
    Print "Public class (New): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects2(NumTimes) As Routines2
    t = Timer
    For i = 1 To NumTimes
        Set objects2(i) = CreateObject("Benchmrk.Routines2")
    Next
    Print "Public class (CreateObject): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects3(NumTimes) As TestDLL.Routines
    t = Timer
    For i = 1 To NumTimes
        Set objects3(i) = New TestDLL.Routines
    Next
    Print "DLL class (New): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects3(NumTimes) As TestDLL.Routines
    t = Timer
    For i = 1 To NumTimes
        Set objects3(i) = CreateObject("TestDLL.Routines")
    Next
    Print "DLL class (CreateObject): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects4(NumTimes) As TestEXE.Routines
    t = Timer
    For i = 1 To NumTimes
        Set objects4(i) = New TestEXE.Routines
    Next
    Print "EXE class (New): " & Format$(Timer - t, "##0.00") & " secs."

    ReDim objects4(NumTimes) As TestEXE.Routines
    t = Timer
    For i = 1 To NumTimes
        Set objects4(i) = CreateObject("TestEXE.Routines")
    Next
    Print "EXE class (CreateObject): " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"
    
End Sub

Private Sub cmdPrivateRoutine_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    Print "Testing Private Routines..."
    
    t = Timer
    For i = 1 To NumTimes
        NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"

End Sub


Private Sub cmdPublicRoutine_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    Print "Testing Public routines..."
    
    t = Timer
    For i = 1 To NumTimes
        Procs.NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        Procs.ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        Procs.ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        Procs.ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        Procs.ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"
End Sub

Private Sub cmdPrivateClass_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    ' Create the component now, so that creation time doesn't
    ' affect benchmarks
    Dim x As Routines
    Set x = New Routines
    
    Print "Testing Private Class..."
    
    t = Timer
    For i = 1 To NumTimes
        x.NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"
End Sub

Private Sub cmdPublicClass_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    ' Create the component now, so that creation time doesn't
    ' affect benchmarks
    Dim x As Routines2
    Set x = New Routines2
    
    Print "Testing Private Class..."
    
    t = Timer
    For i = 1 To NumTimes
        x.NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"

End Sub

Private Sub cmdDLLServer_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
    
    ' Create the component now, so that creation time doesn't
    ' affect benchmarks
    Dim x As TestDLL.Routines
    Set x = New TestDLL.Routines
    
    Print "Testing DLL Server..."
    
    t = Timer
    For i = 1 To NumTimes
        x.NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"
    
End Sub

Private Sub cmdEXEServer_Click()
    Dim t As Single, i As Long, s As String
    Dim NumTimes As Long
    
    NumTimes = CLng(txtTimes)
    s = Space$(1024)
   
    ' Create the component now, so that creation time doesn't
    ' affect benchmarks
    Dim x As TestEXE.Routines
    Set x = New TestEXE.Routines
    
    Print "Testing EXE server..."
    
    t = Timer
    For i = 1 To NumTimes
        x.NoArgs
    Next
    Print "No arguments: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValArg i
    Next
    Print "One ByVal Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefArg i
    Next
    Print "One ByRef Long: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByValString s
    Next
    Print "One ByVal String: " & Format$(Timer - t, "##0.00") & " secs."
    
    t = Timer
    For i = 1 To NumTimes
        x.ByRefString s
    Next
    Print "One ByRef String: " & Format$(Timer - t, "##0.00") & " secs."
    Print "-------------------------"

End Sub


Sub NoArgs()
    '
End Sub

Sub ByRefArg(x As Long)
    '
End Sub

Sub ByValArg(ByVal x As Long)
    '
End Sub

Sub ByRefString(x As String)
    '
End Sub

Sub ByValString(ByVal x As String)
    '
End Sub







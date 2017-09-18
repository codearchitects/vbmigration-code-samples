VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "CFileOp Class Demo"
   ClientHeight    =   5775
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10155
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
   ScaleHeight     =   5775
   ScaleWidth      =   10155
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   240
      TabIndex        =   17
      Top             =   4200
      Width           =   1335
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "&Move"
      Height          =   375
      Left            =   240
      TabIndex        =   16
      Top             =   3720
      Width           =   1335
   End
   Begin VB.Frame Frame2 
      Caption         =   "Options "
      Height          =   855
      Left            =   3960
      TabIndex        =   13
      Top             =   2040
      Width           =   5895
      Begin VB.CheckBox chkProgress 
         Caption         =   "Show &Progress Bar"
         Height          =   255
         Left            =   2640
         TabIndex        =   15
         Top             =   360
         Value           =   1  'Checked
         Width           =   2775
      End
      Begin VB.CheckBox chkConfirm 
         Caption         =   "C&onfirm Each File"
         Height          =   255
         Left            =   240
         TabIndex        =   14
         Top             =   360
         Value           =   1  'Checked
         Width           =   2055
      End
   End
   Begin VB.PictureBox picStatus 
      Align           =   2  'Align Bottom
      AutoRedraw      =   -1  'True
      Height          =   375
      Left            =   0
      ScaleHeight     =   315
      ScaleWidth      =   10095
      TabIndex        =   12
      Top             =   5400
      Width           =   10155
   End
   Begin VB.TextBox txtExclude 
      Height          =   375
      Left            =   240
      TabIndex        =   10
      Top             =   1440
      Width           =   3495
   End
   Begin VB.ListBox lstFiles 
      Height          =   1500
      Left            =   5640
      Sorted          =   -1  'True
      TabIndex        =   9
      Top             =   480
      Width           =   4215
   End
   Begin VB.TextBox txtDestPath 
      Height          =   375
      Left            =   1680
      TabIndex        =   7
      Text            =   "c:\Windows\Temp"
      Top             =   3480
      Width           =   3615
   End
   Begin VB.CommandButton cmdCopy 
      Caption         =   "&Copy"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   3240
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      Caption         =   "Attributes"
      Height          =   855
      Left            =   240
      TabIndex        =   3
      Top             =   2040
      Width           =   3495
      Begin VB.CheckBox chkSystem 
         Caption         =   "&System"
         Height          =   255
         Left            =   1560
         TabIndex        =   5
         Top             =   360
         Width           =   1575
      End
      Begin VB.CheckBox chkHidden 
         Caption         =   "&Hidden"
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   360
         Width           =   1575
      End
   End
   Begin VB.CommandButton cmdParse 
      Caption         =   "&Parse"
      Height          =   375
      Left            =   3960
      TabIndex        =   2
      Top             =   480
      Width           =   1335
   End
   Begin VB.TextBox txtFilespec 
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   480
      Width           =   3495
   End
   Begin VB.Label Label3 
      Caption         =   "E&xclude File Spec"
      Height          =   255
      Left            =   240
      TabIndex        =   11
      Top             =   1200
      Width           =   3015
   End
   Begin VB.Label Label2 
      Caption         =   "&Destination Path"
      Height          =   255
      Left            =   1680
      TabIndex        =   8
      Top             =   3240
      Width           =   3015
   End
   Begin VB.Label Label1 
      Caption         =   "&FileSpec (includes path)"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3015
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'--------------------------------------------------
' Client demo form for CFileOp class - definitive version
'--------------------------------------------------

Option Explicit

'##project:DefaultMemberSupport False
'##project:DisableMessages CodeAnalysis

Dim WithEvents Fop As CFileOp
Attribute Fop.VB_VarHelpID = -1

' this gathers all the filespec that exclude files
Dim ExcludeItems() As String

Private Sub Form_Load()
    ' withevents objects can't be autoinstancing
    Set Fop = New CFileOp
End Sub

Private Sub txtExclude_Change()
    ' reset the internal file list, so that new Parsing events are fired
    Fop.FileSpec = ""
End Sub

Private Sub txtFilespec_Change()
    ' don't enable buttons unless you can use them
    cmdParse.Enabled = (txtFilespec <> "")
End Sub

Private Sub txtDestPath_Change()
    ' don't enable buttons unless you can use them
    cmdCopy.Enabled = (txtDestPath <> "")
End Sub

Private Sub cmdParse_Click()
    ' add to the listbox, show how many files match
    Dim File As Variant
    lstFiles.Clear
    InitFOP
    For Each File In Fop.Filenames
        lstFiles.AddItem File
    Next
    picStatus.Cls
    picStatus.Print "Found " & Fop.Filenames.Count & " files.";
End Sub

Private Sub cmdCopy_Click()
    ' all errors are treated in the FOP_Error procedure
    On Error Resume Next
    InitFOP
    Fop.Copy txtDestPath
    picStatus.Cls
End Sub

Private Sub cmdMove_Click()
    ' all errors are treated in the FOP_Error procedure
    On Error Resume Next
    InitFOP
    Fop.Move txtDestPath
    picStatus.Cls
End Sub

Private Sub cmdDelete_Click()
    ' all errors are treated in the FOP_Error procedure
    On Error Resume Next
    InitFOP
    Fop.Delete
    picStatus.Cls
End Sub


Private Sub InitFOP()
    ' a useful routine shared by many procedures in the form
    Fop.FileSpec = txtFilespec
    Fop.Attributes = IIf(chkHidden, vbHidden, 0) + IIf(chkSystem, vbSystem, 0)
    ' create the ExcludeItems array here to save time later
    ExcludeItems() = Split(txtExclude, ";")
End Sub

'-------------------------------------
' Trapping events from CFileOp class
'-------------------------------------

Private Sub Fop_Parsing(File As String, Cancel As Boolean)
    Dim filename As String, i As Integer
    ' GetFilename is an handy method exposed by CFileOp
    filename = Fop.GetFileName(File)
    For i = LBound(ExcludeItems) To UBound(ExcludeItems)
        If LCase$(filename) Like LCase$(ExcludeItems(i)) Then
            Cancel = True
            Exit Sub
        End If
    Next
End Sub

Private Sub Fop_FileCopyComplete(File As String, DestPath As String)
    picStatus.Cls
    picStatus.Print "Copied file " & File & " ==> " & DestPath;
End Sub

Private Sub Fop_WillCopyFile(File As String, DestPath As String, _
    Action As ActionConstants)
        If chkConfirm = vbUnchecked Then Exit Sub
        Dim ok As Integer
        ok = MsgBox("Copying file " & File & " to " & DestPath & vbCr _
            & "Click YES to proceed, NO to skip, CANCEL to abort", _
            vbYesNoCancel + vbInformation)
        Select Case ok
            Case vbYes: Action = foContinue
            Case vbNo: Action = foSkip
            Case vbCancel: Action = foAbort
        End Select
End Sub

Private Sub Fop_WillMoveFile(File As String, DestPath As String, _
    Action As ActionConstants)
        If chkConfirm = vbUnchecked Then Exit Sub
        Dim ok As Integer
        ok = MsgBox("Moving file " & File & " to " & DestPath & vbCr _
            & "Click YES to proceed, NO to skip, CANCEL to abort", _
            vbYesNoCancel + vbInformation)
        Select Case ok
            Case vbYes: Action = foContinue
            Case vbNo: Action = foSkip
            Case vbCancel: Action = foAbort
        End Select
End Sub

Private Sub Fop_WillDeleteFile(File As String, _
    Action As ActionConstants)
        If chkConfirm = vbUnchecked Then Exit Sub
        Dim ok As Integer
        ok = MsgBox("Deleting file " & File & vbCr _
            & "Click YES to proceed, NO to skip, CANCEL to abort", _
            vbYesNoCancel + vbInformation)
        Select Case ok
            Case vbYes: Action = foContinue
            Case vbNo: Action = foSkip
            Case vbCancel: Action = foAbort
        End Select
End Sub



Private Sub Fop_Error(OpName As String, File As String, File2 As String, _
    ErrCode As Integer, ErrMessage As String, Action As ActionConstants)
        If ErrCode = 76 Then
            MsgBox ErrMessage, vbCritical
            Action = foAbort
        End If
End Sub

Private Sub Fop_ProgressPercent(Percent As Integer)
    If chkProgress Then ShowProgress picStatus, Percent
End Sub

' a reusable routines that prints a progres bar and a percentage
' onto a PictureBox control

Private Sub ShowProgress(pic As PictureBox, Percent As Integer, _
    Optional Color As Long = vbBlue)
        pic.Cls
        pic.Line (0, 0)-(pic.ScaleWidth * Percent / 100, pic.ScaleHeight), Color, BF
        pic.CurrentX = (pic.ScaleWidth - pic.TextWidth(CStr(Percent) & " %")) / 2
        pic.CurrentY = (pic.ScaleHeight - pic.TextHeight("%")) / 2
        pic.Print CStr(Percent) & " %";
End Sub










VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Animation Control Demo"
   ClientHeight    =   4410
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9555
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
   ScaleHeight     =   4410
   ScaleWidth      =   9555
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdStop 
      Caption         =   "&Stop"
      Enabled         =   0   'False
      Height          =   375
      Left            =   7920
      TabIndex        =   12
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtTimes 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   1320
      TabIndex        =   11
      Top             =   720
      Width           =   855
   End
   Begin VB.TextBox txtToFrame 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   5520
      TabIndex        =   9
      Top             =   720
      Width           =   855
   End
   Begin VB.TextBox txtFromFrame 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   3720
      TabIndex        =   7
      Top             =   720
      Width           =   855
   End
   Begin VB.CommandButton cmdBackColor 
      Caption         =   "Back&Color"
      Height          =   375
      Left            =   6480
      TabIndex        =   5
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton cmdPlay 
      Caption         =   "&Play"
      Enabled         =   0   'False
      Height          =   375
      Left            =   7920
      TabIndex        =   4
      Top             =   240
      Width           =   1215
   End
   Begin VB.CommandButton cmdBrowse 
      Caption         =   "&Browse"
      Height          =   375
      Left            =   6480
      TabIndex        =   3
      Top             =   240
      Width           =   1215
   End
   Begin VB.TextBox txtFilename 
      Height          =   375
      Left            =   1320
      TabIndex        =   2
      Top             =   240
      Width           =   5175
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   7440
      Top             =   960
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComCtl2.Animation Animation1 
      Height          =   2895
      Left            =   240
      TabIndex        =   0
      Top             =   1200
      Width           =   6855
      _ExtentX        =   12091
      _ExtentY        =   5106
      _Version        =   393216
      Center          =   -1  'True
      FullWidth       =   457
      FullHeight      =   193
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      Caption         =   "Times"
      Height          =   375
      Left            =   120
      TabIndex        =   10
      Top             =   720
      Width           =   1095
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      Caption         =   "ToFrame"
      Height          =   375
      Left            =   4440
      TabIndex        =   8
      Top             =   720
      Width           =   1095
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      Caption         =   "FromFrame"
      Height          =   375
      Left            =   2520
      TabIndex        =   6
      Top             =   720
      Width           =   1095
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "AVI File:"
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' smart resize of the Animation control.

Private Sub Form_Resize()
    On Error Resume Next
    Animation1.Width = ScaleWidth - Animation1.Left
    Animation1.Height = ScaleHeight - Animation1.Top - Animation1.Left
End Sub

' Enable the Play button only if a file has been specified.

Private Sub txtFilename_Change()
    cmdPlay.Enabled = (txtFilename <> "")
End Sub

' Select an AVI file.

Private Sub cmdBrowse_Click()
    With CommonDialog1
        .Filter = "All files|*.*|AVI files|*.avi"
        .FilterIndex = 2
        .FileName = txtFilename
        .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
        .ShowOpen
        If Len(.FileName) Then txtFilename = .FileName
    End With
End Sub

' Select a BackColor for the Animation control.

Private Sub cmdBackColor_Click()
    With CommonDialog1
        .Color = Animation1.BackColor
        .ShowColor
        Animation1.BackColor = .Color
    End With
End Sub

' Play the AVI file

Private Sub cmdPlay_Click()
    Dim numTimes As Long, fromFrame As Long, toFrame As Long
    On Error GoTo ErrorHandler
    
    ' Open the AVI file (trap any error).
    Animation1.AutoPlay = False
    Animation1.Open txtFilename
    ' Build default arguments, if needed.
    If Len(txtTimes) Then numTimes = CLng(txtTimes) Else numTimes = -1
    If Len(txtFromFrame) Then fromFrame = CLng(txtFromFrame) Else fromFrame = 0
    If Len(txtToFrame) Then toFrame = CLng(txtToFrame) Else toFrame = -1
    ' Start the animation.
    Animation1.Play numTimes, fromFrame, toFrame
    
    If numTimes < 0 Then cmdPlay.Enabled = False
    cmdStop.Enabled = True
    Exit Sub
    
ErrorHandler:
    MsgBox Err.Description, vbExclamation
    
End Sub

' Stop the animation.

Private Sub cmdStop_Click()
    Animation1.Stop
    cmdPlay.Enabled = True
    cmdStop.Enabled = False
End Sub



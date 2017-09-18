VERSION 5.00
Begin VB.Form frmLog 
   Caption         =   "Log"
   ClientHeight    =   4455
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6885
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
   ScaleHeight     =   4455
   ScaleWidth      =   6885
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkActive 
      Caption         =   "&Active"
      Height          =   255
      Left            =   5640
      TabIndex        =   2
      Top             =   720
      Value           =   1  'Checked
      Width           =   1095
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "&Clear"
      Height          =   495
      Left            =   5640
      TabIndex        =   1
      Top             =   120
      Width           =   1095
   End
   Begin VB.TextBox txtLog 
      Height          =   2775
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Top             =   120
      Width           =   5295
   End
End
Attribute VB_Name = "frmLog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Sub LogEvent(LogText As String)
    If chkActive.Value = vbChecked Then
        With txtLog
            .SelStart = Len(.Text)
            .SelText = LogText & vbCrLf
        End With
    End If
End Sub

Private Sub cmdClear_Click()
    txtLog.Text = ""
End Sub

Private Sub Form_Resize()
    ' Some intelligent resizing
    cmdClear.Left = ScaleWidth - 100 - cmdClear.Width
    chkActive.Left = cmdClear.Left
    With txtLog
        .Move .Left, .Top, cmdClear.Left - .Left * 2, ScaleHeight - .Top * 2
    End With
End Sub



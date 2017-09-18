VERSION 5.00
Begin VB.Form frmQuick 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " ATOMIX Auto Typing"
   ClientHeight    =   5115
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6975
   ControlBox      =   0   'False
   Icon            =   "frmQuick.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5115
   ScaleWidth      =   6975
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.ComboBox cmbSpeed 
      Height          =   315
      Left            =   120
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   4680
      Width           =   1095
   End
   Begin VB.TextBox txtQuick 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Fixedsys"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   4095
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Top             =   480
      Width           =   6735
   End
   Begin VB.CommandButton cmdClose 
      Cancel          =   -1  'True
      Caption         =   "&Close"
      Height          =   375
      Left            =   5640
      TabIndex        =   4
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton cmdClipBoard 
      Caption         =   "&Get Clipboard"
      Height          =   375
      Left            =   3000
      TabIndex        =   2
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton cmdStart 
      Caption         =   "&Start"
      Height          =   375
      Left            =   4320
      TabIndex        =   3
      Top             =   4680
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "ATOMIX will only process letters, numbers, spaces, + and -, and ignore all other characters!"
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   6735
   End
End
Attribute VB_Name = "frmQuick"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private pblnQuickChanged As Boolean
Private Sub cmdClipBoard_Click()
'copy clipboard to textbox
Dim rtv As Integer
If pblnQuickChanged = True Then
    rtv = MsgBox("Do You want to delete the current text?", vbYesNo + vbQuestion, " Get Clipboard")
    If rtv = vbNo Then Exit Sub
    End If
On Error Resume Next
Me.txtQuick.Text = Clipboard.GetText
End Sub

Private Sub cmdClose_Click()
Me.Hide
End Sub

Private Sub Form_Activate()
Me.txtQuick.SetFocus
End Sub

Private Sub Form_Load()
'init combo box speeds
Me.cmbSpeed.AddItem "Slow"
Me.cmbSpeed.AddItem "Normal"
Me.cmbSpeed.AddItem "Fast"
Me.cmbSpeed.ListIndex = 1
End Sub

Private Sub txtQuick_Change()
pblnQuickChanged = True
End Sub

Private Sub cmdStart_Click()
Me.Hide
Me.Refresh
Call AutoTyping
End Sub



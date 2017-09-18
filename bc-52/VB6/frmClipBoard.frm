VERSION 5.00
Begin VB.Form frmClipBoard 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   " ATOMIX Smart Clipboard"
   ClientHeight    =   5010
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7230
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5010
   ScaleWidth      =   7230
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.TextBox txtFormat 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   4215
      Left            =   2400
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   6
      Top             =   240
      Width           =   4695
   End
   Begin VB.Frame Frame2 
      Caption         =   "Source"
      Height          =   4335
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   2175
      Begin VB.CommandButton cmdApply 
         Caption         =   "Apply &New Groups"
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   1320
         Width           =   1935
      End
      Begin VB.TextBox txtLF 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFFFF&
         ForeColor       =   &H00000000&
         Height          =   285
         Left            =   175
         MaxLength       =   2
         TabIndex        =   4
         Text            =   "5"
         Top             =   960
         Width           =   375
      End
      Begin VB.OptionButton optOutput 
         Caption         =   "Machine &Output"
         Height          =   255
         Left            =   360
         TabIndex        =   2
         Top             =   360
         Width           =   1695
      End
      Begin VB.OptionButton optInput 
         Caption         =   "Typed &Input"
         Height          =   255
         Left            =   360
         TabIndex        =   3
         Top             =   650
         Width           =   1695
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Groups per line"
         Height          =   255
         Left            =   645
         TabIndex        =   8
         Top             =   1020
         Width           =   1455
      End
   End
   Begin VB.CommandButton cmdOK 
      BackColor       =   &H00C0C0C0&
      Caption         =   "&To Clipboard"
      Height          =   375
      Left            =   4560
      TabIndex        =   0
      Top             =   4560
      Width           =   1215
   End
   Begin VB.CommandButton cmdCancel 
      BackColor       =   &H00C0C0C0&
      Cancel          =   -1  'True
      Caption         =   "&Close"
      Height          =   375
      Left            =   5880
      TabIndex        =   1
      Top             =   4560
      Width           =   1215
   End
End
Attribute VB_Name = "frmClipBoard"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private strClipText As String

Private Sub cmdApply_Click()
Call ApplyFormat
Me.txtFormat.Text = strClipText
End Sub

Private Sub Form_Activate()
Me.cmdOK.SetFocus
Call ApplyFormat
Me.txtFormat.Text = strClipText
End Sub

Private Sub Form_Load()
Me.optOutput.Value = True
End Sub

Private Sub cmdCancel_Click()
Me.Hide
End Sub

Private Sub cmdOk_Click()
On Error Resume Next
Clipboard.Clear
Clipboard.SetText Me.txtFormat.Text
Me.Hide
End Sub

Private Sub ApplyFormat()
'apply new format
On Error Resume Next
If gstrClipInput = "" Then
    strClipText = ""
    Exit Sub
    End If
'enable/disable groups
If gblnLastEncodeText = True And Me.optInput.Value = True Then
    Me.cmdApply.Enabled = False
    Me.txtLF.Enabled = False
ElseIf gblnLastEncodeText = True And Me.optInput.Value = False Then
    Me.cmdApply.Enabled = True
    Me.txtLF.Enabled = True
ElseIf gblnLastEncodeText = False And Me.optInput.Value = True Then
    Me.cmdApply.Enabled = True
    Me.txtLF.Enabled = True
ElseIf gblnLastEncodeText = False And Me.optInput.Value = False Then
    Me.cmdApply.Enabled = False
    Me.txtLF.Enabled = False
End If


Screen.MousePointer = 11
'check wath to copy
If Me.optInput.Value = True Then
    'show input
    strClipText = gstrClipInput
    If gblnLastEncodeText = True Then
        'cipher mode, input is clear text
        strClipText = gstrClipInput
        Else
        'decipher mode, input is code
        strClipText = MakeGroups(gstrClipInput)
        End If
    Else
    'show output
    strClipText = gstrClipOutput
    If gblnLastEncodeText = True Then
        'cipher mode, output is code
        strClipText = MakeGroups(gstrClipOutput)
        Else
        strClipText = gstrClipOutput
        'decipher mode, output is clear text
        End If
    End If
Me.txtFormat.Text = strClipText
Screen.MousePointer = 0
End Sub


Private Function MakeGroups(aText As String) As String

Dim k As Long
Dim strTmp As String
Dim Groups As Integer
Dim G As Integer

Me.txtLF.Enabled = True
Me.txtLF.BackColor = &HFFFFFF

strTmp = ""
Groups = 1
G = 1
For k = 1 To Len(aText)
    G = G + 1
    strTmp = strTmp & Mid(aText, k, 1)
    If G = 6 Then
        G = 1
        strTmp = strTmp & " "
        Groups = Groups + 1
        If Groups = Val(Me.txtLF) + 1 Then strTmp = strTmp & vbCrLf: Groups = 1
    End If
Next k
MakeGroups = strTmp
End Function

Private Sub optInput_Click()
Call ApplyFormat
End Sub

Private Sub optOutput_Click()
Call ApplyFormat
End Sub

Private Sub txtLF_KeyPress(KeyAscii As Integer)
'limit input groups to figures
Select Case KeyAscii
Case 8, 9
    Exit Sub
Case Is < 48, Is > 57
    KeyAscii = 0
End Select
End Sub

Private Sub txtLF_GotFocus()
Me.txtLF.SelStart = 0
Me.txtLF.SelLength = Len(Me.txtLF.Text)
End Sub





VERSION 5.00
Begin VB.Form frmKeySheet 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   " ATOMIX Settings"
   ClientHeight    =   5370
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   6015
   ControlBox      =   0   'False
   Icon            =   "frmKeySheet.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5370
   ScaleWidth      =   6015
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   4695
      Left            =   120
      ScaleHeight     =   4665
      ScaleWidth      =   5745
      TabIndex        =   2
      Top             =   120
      Width           =   5775
      Begin VB.Label lblText 
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
         Height          =   4455
         Left            =   120
         TabIndex        =   3
         Top             =   120
         Width           =   5415
      End
   End
   Begin VB.CommandButton cmdCopy 
      Caption         =   "Copy &To Clipboard"
      Height          =   375
      Left            =   2760
      TabIndex        =   1
      Top             =   4920
      Width           =   1815
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   4680
      TabIndex        =   0
      Top             =   4920
      Width           =   1215
   End
End
Attribute VB_Name = "frmKeySheet"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdClose_Click()
Me.Hide
End Sub

Private Sub cmdCopy_Click()
On Error Resume Next
Clipboard.Clear
Clipboard.SetText Me.lblText.Caption
End Sub

Private Sub Form_Activate()
Dim k As Integer
Dim j As Integer
Dim tmp As String
Dim strLine As String
Dim strKeyText As String
strLine = "---------------------------------------------"
strKeyText = strLine & vbCrLf & "             ATOMIX KEY SETTINGS" & vbCrLf & strLine & vbCrLf

' rotors and pins
tmp = ""
For k = 8 To 1 Step -1
    tmp = tmp & Chr(64 + gintUsedRotNr(k)) & ": "
    For j = 1 To 38
        If Mid(gstrUsedPins(k), j, 1) = "0" Then tmp = tmp & WireToString(j) '& " "
    Next
tmp = tmp & vbCrLf
Next
strKeyText = strKeyText & tmp & strLine & vbCrLf

' keyblock
For k = 1 To 5
tmp = ""
    For j = k To (k + 35) Step 5
        If j > 38 Then Exit For
        tmp = tmp & WireToString(j) & " " & Mid(gstrKeyBlock, j, 1) & "   "
    Next
    strKeyText = strKeyText & Trim(tmp) & vbCrLf
Next
Me.lblText.Caption = strKeyText & strLine
End Sub


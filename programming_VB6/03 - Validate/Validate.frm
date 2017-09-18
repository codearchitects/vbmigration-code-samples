VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Validate / CausesValidation Demo"
   ClientHeight    =   2760
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   5370
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
   ScaleHeight     =   2760
   ScaleWidth      =   5370
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdHelp 
      Caption         =   "&Help"
      CausesValidation=   0   'False
      Height          =   495
      Left            =   3240
      TabIndex        =   6
      Top             =   1680
      Width           =   1335
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      CausesValidation=   0   'False
      Height          =   495
      Left            =   3240
      TabIndex        =   5
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   495
      Left            =   3240
      TabIndex        =   4
      Top             =   480
      Width           =   1335
   End
   Begin VB.TextBox txtNumeric 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   1680
      Width           =   2175
   End
   Begin VB.TextBox txtRequired 
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   600
      Width           =   2175
   End
   Begin VB.Label Label2 
      Caption         =   "&Value in range [1-1000]"
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   1320
      Width           =   2175
   End
   Begin VB.Label Label1 
      Caption         =   "&Required Field"
      Height          =   375
      Left            =   360
      TabIndex        =   1
      Top             =   240
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdOK_Click()
    ' this causes validation
    Unload Me
End Sub

Private Sub cmdCancel_Click()
    ' this doesn't cause validation
    Unload Me
End Sub

Private Sub cmdHelp_Click()
    MsgBox "Help pressed (no validation)", vbInformation
End Sub

Private Sub txtRequired_Validate(Cancel As Boolean)
    ' check that field is not null
    If txtRequired.Text = "" Then
        MsgBox "Please enter something here", vbExclamation
        Cancel = True
    End If
End Sub

Private Sub txtNumeric_Validate(Cancel As Boolean)
    If Not IsNumeric(txtNumeric.Text) Then
        Cancel = True
    ElseIf CDbl(txtNumeric.Text) < 1 Or CDbl(txtNumeric.Text) > 1000 Then
        Cancel = True
    End If
    If Cancel Then
        MsgBox "Please enter a number in range [1-1000]", vbExclamation
    End If
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    ' you can't close this form without validating the current field
    If UnloadMode = vbFormControlMenu Then
        On Error Resume Next
        '##ctrl.SetType Object
        Dim ctrl As Control
        ' give the focus to each control on the form
        ' then validate it
        For Each ctrl In Controls
            Err.Clear
            ctrl.SetFocus
            If Err = 0 Then
                ' don't check controls that can't receive the focus
                ValidateControls
                If Err = 380 Then
                    Cancel = True
                    Exit Sub
                End If
            End If
        Next
    End If
End Sub






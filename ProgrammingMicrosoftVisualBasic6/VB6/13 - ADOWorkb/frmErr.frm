VERSION 5.00
Begin VB.Form frmErrors 
   Caption         =   "Errors Collection"
   ClientHeight    =   2880
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6480
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
   ScaleHeight     =   2880
   ScaleWidth      =   6480
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdRefresh 
      Caption         =   "Refresh"
      Default         =   -1  'True
      Height          =   495
      Left            =   2400
      TabIndex        =   1
      Top             =   2280
      Width           =   1215
   End
   Begin VB.TextBox txtErrors 
      Height          =   2055
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Top             =   120
      Width           =   6135
   End
End
Attribute VB_Name = "frmErrors"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public cn As ADODB.Connection

Private Sub cmdRefresh_Click()
    RefreshErrors
End Sub

Private Sub Form_Load()
    RefreshErrors
End Sub

Sub RefreshErrors()
    Dim error As ADODB.error, tmp As String
    
    For Each error In cn.Errors
        tmp = tmp & error.NativeError & " """ & error.Description & """ (" & error.Source & ")" & vbCrLf
    Next
    txtErrors.Text = tmp
    txtErrors.SelStart = 0
End Sub

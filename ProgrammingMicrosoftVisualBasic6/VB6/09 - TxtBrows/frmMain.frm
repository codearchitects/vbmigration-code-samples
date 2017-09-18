VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmMain 
   Caption         =   "Text Browser Demo"
   ClientHeight    =   1650
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5910
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
   ScaleHeight     =   1650
   ScaleWidth      =   5910
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShow 
      Caption         =   "&Show File"
      Default         =   -1  'True
      Height          =   375
      Left            =   3960
      TabIndex        =   2
      Top             =   960
      Width           =   1095
   End
   Begin VB.CommandButton cmdBrowser 
      Caption         =   "&Browse"
      Height          =   375
      Left            =   3960
      TabIndex        =   1
      Top             =   360
      Width           =   1095
   End
   Begin VB.TextBox txtFilename 
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   360
      Width           =   3735
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   720
      Top             =   960
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label1 
      Caption         =   "Text File Name:"
      Height          =   255
      Left            =   240
      TabIndex        =   3
      Top             =   120
      Width           =   2415
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdBrowser_Click()
    On Error Resume Next
    
    With CommonDialog1
        .CancelError = True
        .Filename = txtFilename
        .Filter = "All files|*.*|Text Files (*.txt)|*.txt"
        .FilterIndex = 2
        .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
        .ShowOpen
        If Err = 0 Then
            txtFilename = .Filename
        End If
    End With
End Sub

Private Sub cmdShow_Click()
    Dim TextBrowser As New frmTextBrowser
    TextBrowser.Filename = txtFilename
    ' show the form, making it a child form of this one
    TextBrowser.Show , Me
End Sub


VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
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
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdTest 
      Caption         =   "Test"
      Height          =   615
      Left            =   1920
      TabIndex        =   2
      Top             =   1800
      Width           =   1695
   End
   Begin VB.TextBox txtServerName 
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   600
      Width           =   3735
   End
   Begin VB.Label Label1 
      Caption         =   "Server Name (leave blank for default)"
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdTest_Click()
    On Error GoTo ErrorHandler
    
    Dim x As RemoteSvr.TestClass
    
    If txtServerName <> "" Then
        Set x = CreateObject("RemoteSvr.TestClass", txtServerName)
    Else
        Set x = CreateObject("RemoteSvr.TestClass")
    End If
    MsgBox "x.SquareRoot(9) = " & x.SquareRoot(9), vbInformation
    Exit Sub

ErrorHandler:
    MsgBox Err.Description, vbCritical, "Error #" & Err
    
End Sub

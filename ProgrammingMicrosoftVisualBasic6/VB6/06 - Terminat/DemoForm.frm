VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3735
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7470
   LinkTopic       =   "Form1"
   ScaleHeight     =   3735
   ScaleWidth      =   7470
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "Open a temp file"
      Height          =   495
      Left            =   120
      TabIndex        =   3
      Top             =   960
      Width           =   1575
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Set Mouse Pointer"
      Height          =   495
      Left            =   120
      TabIndex        =   2
      Top             =   1680
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   3255
      Left            =   1920
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   1
      Top             =   240
      Width           =   5055
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Open a file"
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   1575
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'## AddDataFile test.txt
'## AutoDispose Force
'##project:DisableMessage 0354
'##project:DisableMessage 0364
'##project:DisableMessages CodeAnalysis

' demo for the CFile Class

Private Sub Command1_Click()
    Dim f As New CFile
    ' this file should be in the C:\ root directory
    f.OpenFile "test.txt", omInput
    ' read the file
    Text1.Text = Input$(LOF(f.Handle), f.Handle)
    ' no need to close it before exiting the procedure
End Sub

Private Sub Command2_Click()
    Dim f As New CTempFile
    ' open a temporary file (real world apps should
    f.OpenFile "C:", , omOutput
    
    ' do whatever you want with your file
    Print #f.Handle, Text1.Text
    
    MsgBox "Temporary file " & f.Filename & " has been created" & vbCr _
        & "Press OK to close and delete it"
    ' don't need to explicitly close or delete it before exiting
End Sub

Private Sub Command3_Click()
    Dim m As New CMouse
    m.SetPointer
    MsgBox "Click OK to exit this procedure"
    ' no need to restore the mouse pointer
End Sub



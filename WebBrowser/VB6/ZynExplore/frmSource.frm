VERSION 5.00
Begin VB.Form frmSource 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Source"
   ClientHeight    =   8205
   ClientLeft      =   5175
   ClientTop       =   3780
   ClientWidth     =   9285
   Icon            =   "frmSource.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8205
   ScaleWidth      =   9285
   Begin VB.TextBox text1 
      BeginProperty Font 
         Name            =   "Lucida Console"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   7335
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   1
      Text            =   "frmSource.frx":164A
      Top             =   120
      Width           =   9015
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Close"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3960
      TabIndex        =   0
      Top             =   7560
      Width           =   1095
   End
End
Attribute VB_Name = "frmSource"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
    Unload Me
End Sub

Private Sub Form_Load()
On Error Resume Next
'this will view the source
Dim objDocument  As HTMLDocument
Set objDocument = frmMain.WebBrowser1.Document
    Text1.Text = objDocument.body.innerHTML
End Sub

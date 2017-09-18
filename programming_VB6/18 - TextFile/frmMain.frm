VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "TextFileDataSource Demo - Main"
   ClientHeight    =   1935
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4155
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form3"
   ScaleHeight     =   1935
   ScaleWidth      =   4155
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "New View"
      Height          =   1095
      Left            =   240
      TabIndex        =   2
      Top             =   0
      Width           =   3735
      Begin VB.OptionButton Option1 
         Caption         =   "&Keep the same DataSource"
         Height          =   375
         Index           =   0
         Left            =   240
         TabIndex        =   3
         Top             =   240
         Value           =   -1  'True
         Width           =   3015
      End
      Begin VB.OptionButton Option1 
         Caption         =   "&Use a different DataSource"
         Height          =   495
         Index           =   1
         Left            =   240
         TabIndex        =   4
         Top             =   480
         Width           =   3015
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Table View"
      Height          =   615
      Left            =   2400
      TabIndex        =   1
      Top             =   1200
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Record View"
      Height          =   615
      Left            =   240
      TabIndex        =   0
      Top             =   1200
      Width           =   1575
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

'##project:DefaultMemberSupport False
'##project:DisableMessage 0501
'##AddDataFile Publishers.dat
'##AddDataFile A.dat

' Modify this constant to match your directory structure
'Const DATABASE_DIRECTORY = "D:\Projects_NET20\VBMigrator\SamplesVB6\ProgrammingVB6 Book\17 - TextFile"
Const DATABASE_DIRECTORY = ""

' this serves to share data sources between forms.
'##MyData.AutoNew true
Public MyData As New TextFileDataSource

Private Sub Command1_Dummy()
    ' dummy event
End Sub

Private Sub Form_Dummy()
    ' dummy initializer
End Sub

Private Sub Command1_Click()
    'Err.Raise 999, , "Fuffa"
    
    Dim frm As New frmRecord
    Set frm.MyData = GetDataSource
    frm.Show , Me
End Sub

Private Sub Command2_Click()
    Dim frm As New frmTable
    Set frm.MyData = GetDataSource
    frm.Show , Me
End Sub

Private Function GetDataSource() As TextFileDataSource
    If Option1(1) Then
        Set MyData = New TextFileDataSource
    End If
    MyData.FilePath = DATABASE_DIRECTORY
    Set GetDataSource = MyData
End Function




VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "ADO Object Model Demo"
   ClientHeight    =   1065
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5970
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
   ScaleHeight     =   1065
   ScaleWidth      =   5970
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCreateRecordset 
      Caption         =   "Create a &Recordset"
      Height          =   615
      Left            =   4080
      TabIndex        =   2
      Top             =   240
      Width           =   1695
   End
   Begin VB.CommandButton cmdCreateCommand 
      Caption         =   "Create a C&ommand"
      Height          =   615
      Left            =   2160
      TabIndex        =   1
      Top             =   240
      Width           =   1695
   End
   Begin VB.CommandButton cmdCreateConnection 
      Caption         =   "Create a &Connection"
      Height          =   615
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1695
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DisableMessages CodeAnalysis
'##project:DefaultMemberSupport False

Private Sub cmdCreateConnection_Click()
    Dim frm As New frmConnection
    Set frm.cn = New ADODB.Connection
    frm.Show , Me
End Sub

Private Sub cmdCreateRecordset_Click()
    Dim frm As New frmRecordset
    Set frm.rs = New ADODB.Recordset
    frm.Show , Me
End Sub

Private Sub cmdCreateCommand_Click()
    Dim frm As New frmCommand
    Set frm.cmd = New ADODB.Command
    frm.Show , Me
End Sub




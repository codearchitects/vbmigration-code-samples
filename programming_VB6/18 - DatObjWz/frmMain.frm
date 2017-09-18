VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Data Object Wizard Demo"
   ClientHeight    =   1005
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4260
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
   ScaleHeight     =   1005
   ScaleWidth      =   4260
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDataGrid 
      Caption         =   "Data Grid"
      Height          =   615
      Left            =   2160
      TabIndex        =   1
      Top             =   120
      Width           =   1695
   End
   Begin VB.CommandButton cmdSingleRecord 
      Caption         =   "Single Record"
      Height          =   615
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1695
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:UseByVal Yes
'##project:DisableMessage 0501


Private Sub cmdDataGrid_Click()
    frmGrid.Show
End Sub

Private Sub cmdSingleRecord_Click()
    frmRecord.Show
End Sub



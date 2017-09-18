VERSION 5.00
Begin VB.Form frmRecord 
   Caption         =   "DataEnvironment Demo"
   ClientHeight    =   4395
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5445
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
   ScaleHeight     =   4395
   ScaleWidth      =   5445
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShowGrid 
      Caption         =   "Show Grid"
      Height          =   495
      Left            =   3960
      TabIndex        =   20
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "Next"
      Height          =   495
      Left            =   1800
      TabIndex        =   19
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdPrevious 
      Caption         =   "Previous"
      Height          =   495
      Left            =   600
      TabIndex        =   18
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CheckBox chkcontract 
      DataField       =   "contract"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   285
      Left            =   1920
      TabIndex        =   17
      Top             =   3285
      Width           =   330
   End
   Begin VB.TextBox txtzip 
      DataField       =   "zip"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   15
      Top             =   2895
      Width           =   825
   End
   Begin VB.TextBox txtstate 
      DataField       =   "state"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   13
      Top             =   2520
      Width           =   450
   End
   Begin VB.TextBox txtcity 
      DataField       =   "city"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   11
      Top             =   2145
      Width           =   3300
   End
   Begin VB.TextBox txtaddress 
      DataField       =   "address"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   9
      Top             =   1755
      Width           =   3375
   End
   Begin VB.TextBox txtphone 
      DataField       =   "phone"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   7
      Top             =   1380
      Width           =   1980
   End
   Begin VB.TextBox txtau_fname 
      DataField       =   "au_fname"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   5
      Top             =   1005
      Width           =   3300
   End
   Begin VB.TextBox txtau_lname 
      DataField       =   "au_lname"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   3
      Top             =   615
      Width           =   3375
   End
   Begin VB.TextBox txtau_id 
      DataField       =   "au_id"
      DataMember      =   "authors"
      DataSource      =   "DataEnvironment1"
      Height          =   360
      Left            =   1845
      TabIndex        =   1
      Top             =   240
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "contract:"
      Height          =   255
      Index           =   8
      Left            =   0
      TabIndex        =   16
      Top             =   3330
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "zip:"
      Height          =   255
      Index           =   7
      Left            =   0
      TabIndex        =   14
      Top             =   2940
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "state:"
      Height          =   255
      Index           =   6
      Left            =   0
      TabIndex        =   12
      Top             =   2565
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "city:"
      Height          =   255
      Index           =   5
      Left            =   0
      TabIndex        =   10
      Top             =   2190
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "address:"
      Height          =   255
      Index           =   4
      Left            =   0
      TabIndex        =   8
      Top             =   1800
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "phone:"
      Height          =   255
      Index           =   3
      Left            =   0
      TabIndex        =   6
      Top             =   1425
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "au_fname:"
      Height          =   255
      Index           =   2
      Left            =   0
      TabIndex        =   4
      Top             =   1050
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "au_lname:"
      Height          =   255
      Index           =   1
      Left            =   0
      TabIndex        =   2
      Top             =   660
      Width           =   1815
   End
   Begin VB.Label lblFieldLabel 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "au_id:"
      Height          =   255
      Index           =   0
      Left            =   0
      TabIndex        =   0
      Top             =   285
      Width           =   1815
   End
End
Attribute VB_Name = "frmRecord"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdNext_Click()
    DataEnvironment1.rsauthors.MoveNext
End Sub

Private Sub cmdPrevious_Click()
    DataEnvironment1.rsauthors.MovePrevious
End Sub

Private Sub cmdShowGrid_Click()
    frmGrid.Show
End Sub

Private Sub Form_Load()
    If (DataEnvironment1.Connection1.State And adStateOpen) = 0 Then
        MsgBox "Unable to open the connection", vbCritical
    End If
End Sub

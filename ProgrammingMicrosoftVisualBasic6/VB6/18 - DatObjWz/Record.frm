VERSION 5.00
Begin VB.Form frmRecord 
   Caption         =   "Data Object Wizard Demo - Single Record"
   ClientHeight    =   5250
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5175
   LinkTopic       =   "Form1"
   ScaleHeight     =   5250
   ScaleWidth      =   5175
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   4080
      TabIndex        =   5
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "&Update"
      Height          =   375
      Left            =   3120
      TabIndex        =   4
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdAddNew 
      Caption         =   "&Add New"
      Height          =   375
      Left            =   2160
      TabIndex        =   3
      Top             =   4800
      Width           =   975
   End
   Begin Project1.uctProductsSingleRecord uctProductsSingleRecord1 
      Height          =   4455
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   4695
      _ExtentX        =   9128
      _ExtentY        =   7858
      ManualInitialize=   0   'False
      SaveMode        =   1
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next"
      Height          =   375
      Left            =   1080
      TabIndex        =   1
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdPrevious 
      Caption         =   "&Previous"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   4800
      Width           =   975
   End
End
Attribute VB_Name = "frmRecord"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdPrevious_Click()
    uctProductsSingleRecord1.MovePrevious
End Sub

Private Sub cmdNext_Click()
    uctProductsSingleRecord1.MoveNext
End Sub

Private Sub cmdAddNew_Click()
    uctProductsSingleRecord1.AddRecord
End Sub

Private Sub cmdUpdate_Click()
    uctProductsSingleRecord1.Update
End Sub

Private Sub cmdDelete_Click()
    uctProductsSingleRecord1.Delete
End Sub



VERSION 5.00
Begin VB.Form frmExit 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   " Exit ATOMIX"
   ClientHeight    =   1860
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6900
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1860
   ScaleWidth      =   6900
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   5520
      TabIndex        =   3
      Top             =   1320
      Width           =   1215
   End
   Begin VB.CommandButton cmdErase 
      Caption         =   "&Erase All"
      Height          =   375
      Left            =   4200
      TabIndex        =   2
      Top             =   1320
      Width           =   1215
   End
   Begin VB.CommandButton cmdKeep 
      Caption         =   "&Keep Startup Settings"
      Height          =   375
      Left            =   2160
      TabIndex        =   1
      Top             =   1320
      Width           =   1935
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save Current Settings"
      Default         =   -1  'True
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image Image1 
      Height          =   480
      Left            =   120
      Picture         =   "frmExit.frx":0000
      Stretch         =   -1  'True
      Top             =   240
      Width           =   480
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   855
      Left            =   720
      TabIndex        =   4
      Top             =   240
      Width           =   6015
   End
End
Attribute VB_Name = "frmExit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCancel_Click()
gstrExitVal = "cancel"
Me.Hide
End Sub

Private Sub cmdErase_Click()
gstrExitVal = "erase"
Me.Hide
End Sub

Private Sub cmdKeep_Click()
gstrExitVal = "keep"
Me.Hide
End Sub

Private Sub cmdSave_Click()
gstrExitVal = "save"
Me.Hide
End Sub

Private Sub Form_Activate()
Me.cmdSave.SetFocus
End Sub

Private Sub Form_Load()
Me.Label1.Caption = "You are about to exit the ATOMIX Simulator." & vbCrLf & vbCrLf & "Do you want to save the current machine settings?"
End Sub

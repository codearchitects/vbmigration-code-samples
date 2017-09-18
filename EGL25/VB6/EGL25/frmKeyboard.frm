VERSION 5.00
Begin VB.Form frmKeyboard 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Keyboard"
   ClientHeight    =   2295
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5325
   Icon            =   "frmKeyboard.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2295
   ScaleWidth      =   5325
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame fraKeyBoard 
      Caption         =   "Keyboard"
      Height          =   1575
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   5055
      Begin VB.Label Label20 
         Caption         =   $"frmKeyboard.frx":000C
         Height          =   1215
         Left            =   120
         TabIndex        =   7
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label21 
         Caption         =   $"frmKeyboard.frx":0044
         Height          =   1215
         Left            =   720
         TabIndex        =   6
         Top             =   240
         Width           =   975
      End
      Begin VB.Label Label22 
         Caption         =   $"frmKeyboard.frx":008E
         Height          =   1215
         Left            =   1800
         TabIndex        =   5
         Top             =   240
         Width           =   255
      End
      Begin VB.Label Label23 
         Caption         =   $"frmKeyboard.frx":00A2
         Height          =   1215
         Left            =   2040
         TabIndex        =   4
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label24 
         Caption         =   $"frmKeyboard.frx":00F8
         Height          =   1215
         Left            =   3240
         TabIndex        =   3
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label25 
         Caption         =   $"frmKeyboard.frx":0114
         Height          =   1215
         Left            =   3840
         TabIndex        =   2
         Top             =   240
         Width           =   1095
      End
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   3960
      TabIndex        =   0
      Top             =   1800
      Width           =   1215
   End
End
Attribute VB_Name = "frmKeyboard"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

Private Sub OKButton_Click()
    
    Unload Me

End Sub

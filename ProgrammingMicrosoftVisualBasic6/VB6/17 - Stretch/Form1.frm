VERSION 5.00
Object = "*\AStretch.vbp"
Begin VB.Form Form1 
   Caption         =   "Stretcher Demo"
   ClientHeight    =   6750
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10725
   LinkTopic       =   "Form1"
   ScaleHeight     =   6750
   ScaleWidth      =   10725
   StartUpPosition =   3  'Windows Default
   Begin StretchCtl.Stretcher Stretcher1 
      Height          =   6375
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   10095
      _extentx        =   17806
      _extenty        =   11245
      borderstyle     =   1
      Begin VB.CommandButton Command2 
         Caption         =   "Command2"
         Height          =   672
         Left            =   7628
         TabIndex        =   10
         Top             =   3261
         Width           =   1797
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Command1"
         Height          =   672
         Left            =   4491
         TabIndex        =   9
         Top             =   2858
         Width           =   1797
      End
      Begin VB.Frame Frame2 
         Caption         =   "Frame2"
         Height          =   1653
         Left            =   2848
         TabIndex        =   6
         Top             =   989
         Width           =   4636
         Begin VB.OptionButton Option2 
            Caption         =   "Option2"
            Height          =   464
            Left            =   588
            TabIndex        =   8
            Top             =   1031
            Width           =   2983
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   464
            Left            =   548
            TabIndex        =   7
            Top             =   442
            Width           =   3163
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Frame1"
         Height          =   2007
         Left            =   248
         TabIndex        =   2
         Top             =   995
         Width           =   2489
         Begin VB.CheckBox Check3 
            Caption         =   "Check3"
            Height          =   355
            Left            =   244
            TabIndex        =   5
            Top             =   1370
            Width           =   1837
         End
         Begin VB.CheckBox Check2 
            Caption         =   "Check2"
            Height          =   355
            Left            =   244
            TabIndex        =   4
            Top             =   872
            Width           =   1716
         End
         Begin VB.CheckBox Check1 
            Caption         =   "Check1"
            Height          =   355
            Left            =   257
            TabIndex        =   3
            Top             =   374
            Width           =   1716
         End
      End
      Begin VB.TextBox Text1 
         Height          =   448
         Left            =   240
         TabIndex        =   1
         Text            =   "Text1"
         Top             =   360
         Width           =   6327
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


VERSION 5.00
Begin VB.Form frmProperties 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Properties"
   ClientHeight    =   2250
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4305
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2250
   ScaleWidth      =   4305
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Statistiche 
      Caption         =   "Statistics"
      Height          =   1965
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   2505
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Paragraphs:"
         Height          =   195
         Index           =   0
         Left            =   180
         TabIndex        =   9
         Top             =   330
         Width           =   855
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Lines:"
         Height          =   195
         Index           =   1
         Left            =   180
         TabIndex        =   8
         Top             =   690
         Width           =   420
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Words:"
         Height          =   195
         Index           =   2
         Left            =   180
         TabIndex        =   7
         Top             =   1050
         Width           =   510
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Characters:"
         Height          =   195
         Index           =   3
         Left            =   180
         TabIndex        =   6
         Top             =   1440
         Width           =   810
      End
      Begin VB.Label lblParagraphs 
         Alignment       =   1  'Right Justify
         Height          =   315
         Left            =   1470
         TabIndex        =   5
         Top             =   330
         Width           =   915
      End
      Begin VB.Label lblLines 
         Alignment       =   1  'Right Justify
         Height          =   315
         Left            =   1470
         TabIndex        =   4
         Top             =   705
         Width           =   915
      End
      Begin VB.Label lblWords 
         Alignment       =   1  'Right Justify
         Height          =   315
         Left            =   1470
         TabIndex        =   3
         Top             =   1065
         Width           =   915
      End
      Begin VB.Label lblChars 
         Alignment       =   1  'Right Justify
         Height          =   315
         Left            =   1470
         TabIndex        =   2
         Top             =   1440
         Width           =   915
      End
   End
   Begin VB.CommandButton Command1 
      Cancel          =   -1  'True
      Caption         =   "&OK"
      Height          =   375
      Left            =   3000
      TabIndex        =   0
      Top             =   240
      Width           =   1035
   End
End
Attribute VB_Name = "frmProperties"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click()
    Unload Me
End Sub

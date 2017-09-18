VERSION 5.00
Object = "*\AOptButn.vbp"
Begin VB.Form Form1 
   BackColor       =   &H00C0FFFF&
   Caption         =   "Form1"
   ClientHeight    =   3765
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7770
   LinkTopic       =   "Form1"
   ScaleHeight     =   3765
   ScaleWidth      =   7770
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Picture1 
      BorderStyle     =   0  'None
      Height          =   2895
      Left            =   240
      OLEDropMode     =   1  'Manual
      Picture         =   "Form1.frx":0000
      ScaleHeight     =   2895
      ScaleWidth      =   4335
      TabIndex        =   0
      Top             =   240
      Width           =   4335
      Begin OptBtn.ShapeBtn ShapeBtn1 
         Height          =   375
         Index           =   0
         Left            =   3120
         TabIndex        =   1
         Top             =   360
         Width           =   615
         _extentx        =   1085
         _extenty        =   661
         font            =   "Form1.frx":12E2
         falsecolor      =   14737632
         truecolor       =   255
      End
      Begin OptBtn.ShapeBtn ShapeBtn1 
         Height          =   375
         Index           =   1
         Left            =   3120
         TabIndex        =   2
         Top             =   1200
         Width           =   615
         _extentx        =   1085
         _extenty        =   661
         font            =   "Form1.frx":130E
         falsecolor      =   14737632
         truecolor       =   65535
      End
      Begin OptBtn.ShapeBtn ShapeBtn1 
         Height          =   375
         Index           =   2
         Left            =   3120
         TabIndex        =   3
         Top             =   2160
         Width           =   615
         _extentx        =   1085
         _extenty        =   661
         font            =   "Form1.frx":133A
         falsecolor      =   14737632
         truecolor       =   49152
         value           =   -1
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


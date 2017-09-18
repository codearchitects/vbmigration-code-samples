VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About SUPER MASTER MIND"
   ClientHeight    =   2910
   ClientLeft      =   2340
   ClientTop       =   1935
   ClientWidth     =   5100
   ClipControls    =   0   'False
   Icon            =   "frmAbout.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   2008.534
   ScaleMode       =   0  'User
   ScaleWidth      =   4789.164
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox picIcon 
      AutoSize        =   -1  'True
      ClipControls    =   0   'False
      Height          =   540
      Left            =   360
      Picture         =   "frmAbout.frx":030A
      ScaleHeight     =   337.12
      ScaleMode       =   0  'User
      ScaleWidth      =   337.12
      TabIndex        =   1
      Top             =   240
      Width           =   540
   End
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   585
      Left            =   1440
      TabIndex        =   0
      Top             =   2160
      Width           =   1980
   End
   Begin VB.Label Label4 
      Caption         =   "2005"
      Height          =   255
      Left            =   2520
      TabIndex        =   4
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label Label3 
      Caption         =   "By Vettolani Alberto"
      Height          =   255
      Left            =   2040
      TabIndex        =   3
      Top             =   840
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "SUPER MASTER MIND 1.0.0"
      Height          =   255
      Left            =   1680
      TabIndex        =   2
      Top             =   240
      Width           =   2415
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderStyle     =   6  'Inside Solid
      Index           =   1
      X1              =   0
      X2              =   4648.307
      Y1              =   1325.218
      Y2              =   1325.218
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdOK_Click()
Unload Me
End Sub


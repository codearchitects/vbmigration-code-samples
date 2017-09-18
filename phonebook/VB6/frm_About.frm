VERSION 5.00
Begin VB.Form frm_About 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About Phone Book"
   ClientHeight    =   1470
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4680
   Icon            =   "frm_About.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1470
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btn_OK 
      Caption         =   "OK"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3713
      TabIndex        =   0
      Top             =   488
      Width           =   615
   End
   Begin VB.Label lbl_About 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Phone Book Version 2.0 Copyroght(c) 2001 by Arbie Sarkissian"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   720
      Left            =   1260
      TabIndex        =   1
      Top             =   375
      Width           =   1995
      WordWrap        =   -1  'True
   End
   Begin VB.Image img_About 
      Height          =   480
      Left            =   353
      Picture         =   "frm_About.frx":08CA
      Top             =   495
      Width           =   480
   End
End
Attribute VB_Name = "frm_About"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btn_OK_Click()
    Unload frm_About
End Sub

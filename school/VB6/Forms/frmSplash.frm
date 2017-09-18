VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4455
   ClientLeft      =   225
   ClientTop       =   1380
   ClientWidth     =   6240
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmSplash.frx":000C
   ScaleHeight     =   4455
   ScaleWidth      =   6240
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00000000&
      BorderStyle     =   0  'None
      Height          =   375
      Left            =   0
      ScaleHeight     =   375
      ScaleWidth      =   6255
      TabIndex        =   0
      Top             =   4080
      Width           =   6255
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Copyright © NaparanSoft, 2004. All Rights Reserved."
         ForeColor       =   &H00FFFFFF&
         Height          =   375
         Left            =   2040
         TabIndex        =   1
         Top             =   75
         Width           =   4095
      End
   End
   Begin VB.Image Image1 
      Height          =   960
      Left            =   5040
      Picture         =   "frmSplash.frx":7B1A
      Top             =   240
      Width           =   960
   End
   Begin VB.Shape Shape1 
      BorderWidth     =   2
      Height          =   4455
      Left            =   0
      Top             =   0
      Width           =   6255
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------------------------------
'All codes are copyright by Philip V. Naparan 2004
'
'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
'E-mail Address: philipnaparan@yahoo.com
'Contact #: 639186443161
'----------------------------------------------------------------------------------------------------



Private Sub Form_Click()
Unload Me
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
Unload Me
End Sub


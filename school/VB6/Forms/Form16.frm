VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomct2.ocx"
Begin VB.Form Form16 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calendar"
   ClientHeight    =   2715
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   2940
   Icon            =   "Form16.frx":0000
   LinkTopic       =   "Form16"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   2715
   ScaleWidth      =   2940
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   2700
      TabIndex        =   1
      Top             =   2520
      Width           =   2700
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   2
         Top             =   10
         Width           =   8895
      End
   End
   Begin MSComCtl2.MonthView MonthView1 
      Height          =   2370
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2700
      _ExtentX        =   4763
      _ExtentY        =   4180
      _Version        =   393216
      ForeColor       =   -2147483630
      BackColor       =   -2147483633
      Appearance      =   1
      StartOfWeek     =   43319297
      TitleBackColor  =   33023
      TitleForeColor  =   16777215
      CurrentDate     =   38064
   End
End
Attribute VB_Name = "Form16"
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
Private Sub Form_Load()
Call use_pos(Me)

MonthView1.Value = Date
End Sub

Private Sub Form_Unload(Cancel As Integer)
Call save_pos(Me)
End Sub

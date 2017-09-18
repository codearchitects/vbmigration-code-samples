VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "comctl32.ocx"
Begin VB.Form Splash 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   4545
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   6000
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4545
   ScaleWidth      =   6000
   StartUpPosition =   2  'CenterScreen
   Begin ComctlLib.ProgressBar Progress 
      Height          =   255
      Left            =   360
      TabIndex        =   4
      Top             =   3960
      Width           =   5535
      _ExtentX        =   9763
      _ExtentY        =   450
      _Version        =   327682
      Appearance      =   0
   End
   Begin VB.Timer Timer1 
      Left            =   5280
      Top             =   3480
   End
   Begin VB.Label Label5 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Loading........"
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   360
      TabIndex        =   5
      Top             =   4320
      Width           =   930
   End
   Begin VB.Label Label4 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "gerbert_p@yahoo.com"
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   2160
      TabIndex        =   3
      Top             =   3360
      Width           =   1620
   End
   Begin VB.Label Label3 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   480
      TabIndex        =   2
      Top             =   3840
      Width           =   45
   End
   Begin VB.Label Label2 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Copyright (g) by: Gerbert S. Pagtama"
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   1560
      TabIndex        =   1
      Top             =   3120
      Width           =   2580
   End
   Begin VB.Label Label1 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Loading........"
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   1320
      TabIndex        =   0
      Top             =   4320
      Width           =   930
   End
   Begin VB.Image Image1 
      Height          =   4575
      Left            =   0
      Picture         =   "Splash.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6015
   End
End
Attribute VB_Name = "Splash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Time_Open As Byte

Private Sub Form_Load()
 Timer1.interval = 1
  Time_Open = 0
End Sub

Private Sub FrmAbout_Click()
 Unload Me
End Sub

Private Sub Timer1_Timer()
  Label1.Caption = Time_Open & "%"
 If Time_Open < 100 Then
    Time_Open = Time_Open + 1
    ElseIf Time_Open = 100 Then
           Unload Me
           frmshowfnt.Show
           Timer1.interval = 0
           Timer1.Enabled = False
 End If
 Progress.Value = Time_Open
End Sub


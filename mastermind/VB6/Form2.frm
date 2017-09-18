VERSION 5.00
Begin VB.Form Form2 
   BackColor       =   &H8000000D&
   Caption         =   "VITTORIA"
   ClientHeight    =   5040
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10140
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "Form2.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5040
   ScaleWidth      =   10140
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer2 
      Interval        =   60000
      Left            =   7080
      Top             =   4560
   End
   Begin VB.Timer Timer1 
      Interval        =   350
      Left            =   6240
      Top             =   4440
   End
   Begin VB.Label DisableControl 
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   4560
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.Label NuovaPart 
      Height          =   375
      Left            =   840
      TabIndex        =   1
      Top             =   4560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackColor       =   &H8000000D&
      BackStyle       =   0  'Transparent
      Caption         =   "    HAI VINTO!!!!!"
      BeginProperty Font 
         Name            =   "Zurich BlkEx BT"
         Size            =   90
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9975
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public Sub DisableControl_Click()
Form1.LabTent1_1.Enabled = False
Form1.LabTent1_2.Enabled = False
Form1.LabTent1_3.Enabled = False
Form1.LabTent1_4.Enabled = False
Form1.LabTent1_5.Enabled = False

Form1.LabTent2_1.Enabled = False
Form1.LabTent2_2.Enabled = False
Form1.LabTent2_3.Enabled = False
Form1.LabTent2_4.Enabled = False
Form1.LabTent2_5.Enabled = False

Form1.LabTent3_1.Enabled = False
Form1.LabTent3_2.Enabled = False
Form1.LabTent3_3.Enabled = False
Form1.LabTent3_4.Enabled = False
Form1.LabTent3_5.Enabled = False

Form1.LabTent4_1.Enabled = False
Form1.LabTent4_2.Enabled = False
Form1.LabTent4_3.Enabled = False
Form1.LabTent4_4.Enabled = False
Form1.LabTent4_5.Enabled = False

Form1.LabTent5_1.Enabled = False
Form1.LabTent5_2.Enabled = False
Form1.LabTent5_3.Enabled = False
Form1.LabTent5_4.Enabled = False
Form1.LabTent5_5.Enabled = False

Form1.LabTent6_1.Enabled = False
Form1.LabTent6_2.Enabled = False
Form1.LabTent6_3.Enabled = False
Form1.LabTent6_4.Enabled = False
Form1.LabTent6_5.Enabled = False

Form1.LabTent7_1.Enabled = False
Form1.LabTent7_2.Enabled = False
Form1.LabTent7_3.Enabled = False
Form1.LabTent7_4.Enabled = False
Form1.LabTent7_5.Enabled = False

Form1.LabTent8_1.Enabled = False
Form1.LabTent8_2.Enabled = False
Form1.LabTent8_3.Enabled = False
Form1.LabTent8_4.Enabled = False
Form1.LabTent8_5.Enabled = False

Form1.LabTent9_1.Enabled = False
Form1.LabTent9_2.Enabled = False
Form1.LabTent9_3.Enabled = False
Form1.LabTent9_4.Enabled = False
Form1.LabTent9_5.Enabled = False

Form1.LabTent10_1.Enabled = False
Form1.LabTent10_2.Enabled = False
Form1.LabTent10_3.Enabled = False
Form1.LabTent10_4.Enabled = False
Form1.LabTent10_5.Enabled = False

Form1.LabTent11_1.Enabled = False
Form1.LabTent11_2.Enabled = False
Form1.LabTent11_3.Enabled = False
Form1.LabTent11_4.Enabled = False
Form1.LabTent11_5.Enabled = False

Form1.LabTent12_1.Enabled = False
Form1.LabTent12_2.Enabled = False
Form1.LabTent12_3.Enabled = False
Form1.LabTent12_4.Enabled = False
Form1.LabTent12_5.Enabled = False

Form1.Command1.Visible = False
Form1.Command2.Visible = False
Form1.Command3.Visible = False
Form1.Command4.Visible = False
Form1.Command5.Visible = False
Form1.Command6.Visible = False
Form1.Command7.Visible = False
Form1.Command8.Visible = False
Form1.Command9.Visible = False
Form1.Command10.Visible = False
Form1.Command11.Visible = False
Form1.Command12.Visible = False
End Sub

Private Sub Form_Click()
Form1.Show
Unload Me
NuovaPart_Click
End Sub

Private Sub Form_Load()
Form1.Hide
End Sub

Private Sub Label1_Click()
Form1.Show
Unload Me
NuovaPart_Click
End Sub

Public Sub NuovaPart_Click()
Dim Risposta As Integer
Risposta = MsgBox("Aprire una nuova partita?", vbQuestion + vbYesNo, "Nuova partita")
If Risposta = vbYes Then
   Form1.New_Click
Else
   DisableControl_Click
End If
End Sub

Private Sub Timer1_Timer()
If Label1.Visible = True Then
   Label1.Visible = False
Else
   Label1.Visible = True
End If
End Sub

Private Sub Timer2_Timer()
Form1.Show
Unload Me
NuovaPart_Click
End Sub

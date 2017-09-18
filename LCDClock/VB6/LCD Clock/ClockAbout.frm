VERSION 5.00
Begin VB.Form AboutFrm 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "About"
   ClientHeight    =   5175
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5280
   Icon            =   "ClockAbout.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5175
   ScaleWidth      =   5280
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox Check1 
      Caption         =   "Check1"
      Height          =   180
      Left            =   1695
      TabIndex        =   2
      Top             =   4230
      Value           =   1  'Checked
      Width           =   195
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Close"
      Height          =   330
      Left            =   2055
      TabIndex        =   0
      Top             =   4650
      Width           =   1155
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "Created by Michael Margold"
      Height          =   240
      Left            =   60
      TabIndex        =   5
      Top             =   3495
      Width           =   5175
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "LCD Clock v1.14"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   360
      Left            =   60
      TabIndex        =   4
      Top             =   3000
      Width           =   5175
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "    Show Help On Start Up"
      Height          =   240
      Left            =   60
      TabIndex        =   3
      Top             =   4215
      Width           =   5175
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      Caption         =   "http://www.soft-collection.com"
      ForeColor       =   &H00FF0000&
      Height          =   225
      Left            =   60
      MouseIcon       =   "ClockAbout.frx":0CCA
      MousePointer    =   99  'Custom
      TabIndex        =   1
      Top             =   3840
      Width           =   5175
   End
   Begin VB.Image Image1 
      Height          =   2895
      Left            =   0
      Picture         =   "ClockAbout.frx":0E1C
      Top             =   0
      Width           =   5280
   End
End
Attribute VB_Name = "AboutFrm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Function Link(ByVal URL As String) As Long
  Link = ShellExecute(0&, vbNullString, URL, vbNullString, vbNullString, vbNormalFocus)
End Function
Private Sub Check1_Click()
  MainFrm.ShowAbout = Check1.Value
  MainFrm.SaveSettings
End Sub
Private Sub Command1_Click()
  Me.Hide
End Sub
Private Sub Label1_Click()
  Call Link(Label1.Caption)
End Sub

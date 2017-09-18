VERSION 5.00
Object = "{C51591A7-9119-11D2-BAC5-0080C8F21830}#1.0#0"; "SuperTim.ocx"
Begin VB.Form Form1 
   Caption         =   "SuperTimer demo"
   ClientHeight    =   2505
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3510
   LinkTopic       =   "Form1"
   ScaleHeight     =   2505
   ScaleWidth      =   3510
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   840
      Top             =   2280
   End
   Begin VB.Frame Frame1 
      Caption         =   "Notification method"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   3255
      Begin VB.OptionButton Option1 
         Caption         =   "&Events"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   3
         Top             =   720
         Value           =   -1  'True
         Width           =   1695
      End
      Begin VB.OptionButton Option1 
         Caption         =   "&CallBack"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   2
         Top             =   360
         Width           =   1695
      End
   End
   Begin SuperTimerOCX.SuperTimer SuperTimer1 
      Left            =   2760
      Top             =   1320
      _ExtentX        =   741
      _ExtentY        =   741
      Interval        =   1000
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Show MsgBox"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   1800
      Width           =   1575
   End
   Begin VB.Label lblCount 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1680
      TabIndex        =   4
      Top             =   1800
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False

Implements ISuperTimerCBK

Private Sub Command1_Click()
    Dim InterpretedMode As Boolean
    Debug.Assert SetVariable(InterpretedMode, True)
    
    If Option1(0) Then
        MsgBox "MsgBox never block events", vbInformation
    ElseIf InterpretedMode Then
        MsgBox "MsgBox blocks events in interpreted programs!", vbInformation
    Else
        MsgBox "MsgBox don't block events in compiled programs!", vbInformation
    End If
End Sub

Private Function SetVariable(variable As Variant, value As Variant) As Variant
    variable = value
    SetVariable = value
End Function

Private Sub ISuperTimerCBK_Timer()
    lblCount = CLng(lblCount) + 1
End Sub

Private Sub Option1_Click(Index As Integer)
    Set SuperTimer1.Owner = IIf(Index = 0, Me, Nothing)
End Sub

Private Sub SuperTimer1_Timer()
    lblCount = CLng(lblCount) + 1
End Sub



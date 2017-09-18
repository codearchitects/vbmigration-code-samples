VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "Mscomct2.ocx"
Begin VB.Form frmFlatScrolBar 
   Caption         =   "FlatScrollBar Control Demo"
   ClientHeight    =   4215
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5295
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4215
   ScaleWidth      =   5295
   StartUpPosition =   3  'Windows Default
   Begin MSComCtl2.FlatScrollBar FlatScrollBar2 
      Height          =   3015
      Left            =   360
      TabIndex        =   1
      Top             =   480
      Width           =   375
      _ExtentX        =   661
      _ExtentY        =   5318
      _Version        =   393216
      Appearance      =   2
      LargeChange     =   16
      Max             =   256
      Orientation     =   1245184
   End
   Begin MSComCtl2.FlatScrollBar FlatScrollBar1 
      Height          =   375
      Left            =   1440
      TabIndex        =   0
      Top             =   720
      Width           =   3015
      _ExtentX        =   5318
      _ExtentY        =   661
      _Version        =   393216
      Appearance      =   0
      Arrows          =   65536
      LargeChange     =   16
      Max             =   256
      Orientation     =   1245185
   End
   Begin VB.Label Label1 
      Caption         =   "Orientation = cc2OrientationVertical"
      Height          =   375
      Index           =   3
      Left            =   360
      TabIndex        =   5
      Top             =   3840
      Width           =   3495
   End
   Begin VB.Label Label1 
      Caption         =   "Appearance = fsbTrack3D"
      Height          =   375
      Index           =   2
      Left            =   360
      TabIndex        =   4
      Top             =   3600
      Width           =   2535
   End
   Begin VB.Label Label1 
      Caption         =   "Orientation = cc2OrientationHorizontal"
      Height          =   375
      Index           =   1
      Left            =   1440
      TabIndex        =   3
      Top             =   360
      Width           =   3495
   End
   Begin VB.Label Label1 
      Caption         =   "Appearance = fsb3D"
      Height          =   375
      Index           =   0
      Left            =   1440
      TabIndex        =   2
      Top             =   120
      Width           =   2535
   End
End
Attribute VB_Name = "frmFlatScrolBar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub FlatScrollBar1_Change()
    ' Selectively disable one arrow, if necessary.
    If FlatScrollBar1.Value = FlatScrollBar1.Min Then
        FlatScrollBar1.Arrows = cc2RightDown
    ElseIf FlatScrollBar1.Value = FlatScrollBar1.Max Then
        FlatScrollBar1.Arrows = cc2LeftUp
    Else
        FlatScrollBar1.Arrows = cc2Both
    End If
    
    Debug.Print "Change Hor = " & FlatScrollBar1
End Sub

Private Sub FlatScrollBar1_Scroll()
    Debug.Print "Scroll Hor = " & FlatScrollBar1
End Sub

Private Sub FlatScrollBar2_Change()
    ' Selectively disable one arrow, if necessary.
    If FlatScrollBar2.Value = FlatScrollBar2.Min Then
        FlatScrollBar2.Arrows = cc2RightDown
    ElseIf FlatScrollBar2.Value = FlatScrollBar2.Max Then
        FlatScrollBar2.Arrows = cc2LeftUp
    Else
        FlatScrollBar2.Arrows = cc2Both
    End If
    Debug.Print "Change Ver = " & FlatScrollBar2
End Sub

Private Sub FlatScrollBar2_Scroll()
    Debug.Print "Scroll Ver = " & FlatScrollBar2
End Sub

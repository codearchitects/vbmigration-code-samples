VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Pick - A - Color"
   ClientHeight    =   4005
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5820
   LinkTopic       =   "Form1"
   ScaleHeight     =   4005
   ScaleWidth      =   5820
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   375
      Left            =   120
      TabIndex        =   12
      Top             =   1680
      Width           =   255
   End
   Begin VB.Frame Frame1 
      Caption         =   "Value"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2055
      Left            =   2640
      TabIndex        =   7
      Top             =   1560
      Width           =   2895
      Begin VB.CommandButton cmdCopy 
         Caption         =   "&Copy"
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
         Left            =   1440
         TabIndex        =   11
         Top             =   1560
         Width           =   1215
      End
      Begin VB.OptionButton optRGB 
         Caption         =   "optRGB"
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
         Left            =   240
         TabIndex        =   10
         Top             =   1200
         Width           =   2415
      End
      Begin VB.OptionButton optHex 
         Caption         =   "optHex"
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
         Left            =   240
         TabIndex        =   9
         Top             =   840
         Width           =   2415
      End
      Begin VB.OptionButton optDecimal 
         Caption         =   "optDecimal"
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
         Left            =   240
         TabIndex        =   8
         Top             =   480
         Value           =   -1  'True
         Width           =   2415
      End
   End
   Begin VB.PictureBox picTest 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   1095
      Left            =   2640
      ScaleHeight     =   1065
      ScaleWidth      =   2865
      TabIndex        =   6
      Top             =   240
      Width           =   2895
   End
   Begin VB.VScrollBar vsbBlue 
      Height          =   2655
      LargeChange     =   16
      Left            =   1800
      Max             =   0
      Min             =   255
      TabIndex        =   2
      Top             =   840
      Width           =   375
   End
   Begin VB.VScrollBar vsbGreen 
      Height          =   2655
      LargeChange     =   16
      Left            =   1200
      Max             =   0
      Min             =   255
      TabIndex        =   1
      Top             =   840
      Width           =   375
   End
   Begin VB.VScrollBar vsbRed 
      Height          =   2655
      LargeChange     =   16
      Left            =   600
      Max             =   0
      Min             =   255
      TabIndex        =   0
      Top             =   840
      Width           =   375
   End
   Begin VB.Label lblBlue 
      Alignment       =   2  'Center
      BackColor       =   &H00FF0000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3375
      Left            =   1680
      TabIndex        =   5
      Top             =   240
      Width           =   615
   End
   Begin VB.Label lblGreen 
      Alignment       =   2  'Center
      BackColor       =   &H0000FF00&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3375
      Left            =   1080
      TabIndex        =   4
      Top             =   240
      Width           =   615
   End
   Begin VB.Label lblRed 
      Alignment       =   2  'Center
      BackColor       =   &H000000FF&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3375
      Left            =   480
      TabIndex        =   3
      Top             =   240
      Width           =   615
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    ShowColor
End Sub

Private Sub vsbRed_Change()
    ShowColor
End Sub

Private Sub vsbRed_Scroll()
    ShowColor
End Sub

Private Sub vsbGreen_Change()
    ShowColor
End Sub

Private Sub vsbGreen_Scroll()
    ShowColor
End Sub

Private Sub vsbBlue_Change()
    ShowColor
End Sub

Private Sub vsbBlue_Scroll()
    ShowColor
End Sub

Private Sub ShowColor()
    Dim colorValue As Long
    colorValue = RGB(vsbRed, vsbGreen, vsbBlue)
    
    lblRed = vsbRed.Value
    lblGreen = vsbGreen.Value
    lblBlue = vsbBlue.Value
    
    optDecimal.Caption = "Dec: " & colorValue
    optHex.Caption = "Hex: " & Hex$(colorValue)
    optRGB.Caption = "RGB: " & vsbRed & "," & vsbGreen & "," & vsbBlue
    
    picTest.BackColor = colorValue
End Sub

Private Sub cmdCopy_Click()
    Dim colorValue As Long
    colorValue = RGB(vsbRed, vsbGreen, vsbBlue)
    Clipboard.Clear
    
    If optDecimal.Value Then
        Clipboard.SetText colorValue
    ElseIf optHex.Value Then
        Clipboard.SetText "&H" & Hex$(colorValue)
    ElseIf optRGB.Value Then
        Clipboard.SetText "RGB(" & vsbRed & "," & vsbGreen & "," & vsbBlue & ")"
    End If
End Sub



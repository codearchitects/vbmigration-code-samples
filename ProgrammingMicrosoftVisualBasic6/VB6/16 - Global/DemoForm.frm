VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3720
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4650
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
   ScaleHeight     =   3720
   ScaleWidth      =   4650
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdText 
      Caption         =   "FilterNumber (""12a4"")"
      Height          =   615
      Index           =   3
      Left            =   2760
      TabIndex        =   3
      Top             =   2760
      Width           =   1455
   End
   Begin VB.CommandButton cmdText 
      Caption         =   "PI"
      Height          =   615
      Index           =   2
      Left            =   2760
      TabIndex        =   2
      Top             =   1920
      Width           =   1455
   End
   Begin VB.CommandButton cmdText 
      Caption         =   "Bin(123)"
      Height          =   615
      Index           =   1
      Left            =   2760
      TabIndex        =   1
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton cmdText 
      Caption         =   "Max(10,20)"
      Height          =   615
      Index           =   0
      Left            =   2760
      TabIndex        =   0
      Top             =   360
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Just a few test to demonstrate how GlobalMultiUse classes work

Private Sub cmdText_Click(Index As Integer)
    Select Case Index
        Case 0
            Print Max(10, 20)
        Case 1
            Print Bin(123)
        Case 2
            Print Pi
        Case 3
            Print filternumber("12a4", False)
    End Select
End Sub


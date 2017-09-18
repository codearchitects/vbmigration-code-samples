VERSION 5.00
Begin VB.Form frmRectangle 
   Caption         =   "Rectangle Demo"
   ClientHeight    =   1950
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7710
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   11.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   1950
   ScaleWidth      =   7710
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtArea 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4868
      TabIndex        =   8
      Top             =   1155
      Width           =   2655
   End
   Begin VB.TextBox txtPerimeter 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4868
      TabIndex        =   6
      Top             =   435
      Width           =   2655
   End
   Begin VB.CommandButton cmdEvaluate 
      Caption         =   "&Evaluate"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3188
      TabIndex        =   4
      Top             =   435
      Width           =   1335
   End
   Begin VB.TextBox txtHeight 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   188
      TabIndex        =   3
      Top             =   1200
      Width           =   2655
   End
   Begin VB.TextBox txtWidth 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   188
      TabIndex        =   1
      Top             =   435
      Width           =   2655
   End
   Begin VB.Label lblArea 
      Caption         =   "&Area"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4875
      TabIndex        =   7
      Top             =   915
      Width           =   1335
   End
   Begin VB.Label lblPerimeter 
      Caption         =   "&Perimeter"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4875
      TabIndex        =   5
      Top             =   195
      Width           =   1335
   End
   Begin VB.Label lblHeight 
      Caption         =   "&Height"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   195
      TabIndex        =   2
      Top             =   960
      Width           =   1335
   End
   Begin VB.Label lblWidth 
      Caption         =   "&Width"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   195
      TabIndex        =   0
      Top             =   195
      Width           =   1335
   End
End
Attribute VB_Name = "frmRectangle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdEvaluate_Click()
    ' declare two floating point variables
    Dim reWidth As Double, reHeight As Double
    On Error GoTo WrongValues
    
    ' extract values from input textbox controls
    reWidth = CDbl(txtWidth.Text)
    reHeight = CDbl(txtHeight.Text)
    ' ensure that they are positive values
    If reWidth <= 0 Or reHeight <= 0 Then GoTo WrongValues
    ' evaluate results and assign to output textboxes
    txtPerimeter.Text = CStr((reWidth + reHeight) * 2)
    txtArea.Text = CStr(reWidth * reHeight)
    Exit Sub

WrongValues:
    MsgBox "Please enter valid Width and Height values", vbExclamation
    
End Sub

Private Sub txtWidth_Change()
    ' clear results, that are now invalid
    txtPerimeter.Text = ""
    txtArea.Text = ""
End Sub

Private Sub txtHeight_Change()
    ' clear results, that are now invalid
    txtPerimeter.Text = ""
    txtArea.Text = ""
End Sub



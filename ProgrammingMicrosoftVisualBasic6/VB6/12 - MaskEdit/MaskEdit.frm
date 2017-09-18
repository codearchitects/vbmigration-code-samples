VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "msmask32.ocx"
Begin VB.Form Form1 
   Caption         =   "MaskedEdit Control Demo"
   ClientHeight    =   3555
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7575
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
   ScaleHeight     =   3555
   ScaleWidth      =   7575
   StartUpPosition =   3  'Windows Default
   Begin MSMask.MaskEdBox mebPhone 
      Height          =   495
      Left            =   360
      TabIndex        =   0
      Top             =   480
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   873
      _Version        =   393216
      MaxLength       =   13
      Mask            =   "(###)###-####"
      PromptChar      =   "_"
   End
   Begin MSMask.MaskEdBox mebCreditCard 
      Height          =   495
      Left            =   360
      TabIndex        =   2
      Top             =   1440
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   873
      _Version        =   393216
      MaxLength       =   19
      Mask            =   "#### #### #### ####"
      PromptChar      =   "_"
   End
   Begin MSMask.MaskEdBox mebDate 
      Height          =   495
      Left            =   3720
      TabIndex        =   4
      Top             =   480
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   873
      _Version        =   393216
      MaxLength       =   8
      Format          =   "mmmm dd, yyyy"
      Mask            =   "##/##/##"
      PromptChar      =   "_"
   End
   Begin MSMask.MaskEdBox mebDecNumber 
      Height          =   495
      Left            =   3720
      TabIndex        =   6
      Top             =   1440
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   873
      _Version        =   393216
      Format          =   "#,##0.00;(#,##0.00);zero;null"
      PromptChar      =   "_"
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   3120
      Width           =   3135
   End
   Begin VB.Label Label2 
      Caption         =   "Decimal numbers with different formats"
      Height          =   255
      Index           =   2
      Left            =   3720
      TabIndex        =   7
      Top             =   1080
      Width           =   3495
   End
   Begin VB.Label Label2 
      Caption         =   "Date (long format on exit)"
      Height          =   255
      Index           =   1
      Left            =   3720
      TabIndex        =   5
      Top             =   120
      Width           =   3135
   End
   Begin VB.Label Label2 
      Caption         =   "Credit Card Number"
      Height          =   255
      Index           =   0
      Left            =   360
      TabIndex        =   3
      Top             =   1080
      Width           =   2055
   End
   Begin VB.Label Label1 
      Caption         =   "Phone Number"
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   120
      Width           =   2055
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit



Private Sub Form_Resize()
    Dim i As Integer, b As Boolean
    
    i = Abs(b)
    

    lblStatus.Move 0, ScaleHeight - lblStatus.Height, ScaleWidth, lblStatus.Height
End Sub

Private Sub mebDecNumber_KeyPress(KeyAscii As Integer)
    ' Since we don't have a Mask, we must manually filter out invalid characters
    Select Case KeyAscii
        Case 0 To 31, 48 To 57, Asc(","), Asc("-")
        Case Else
            lblStatus = "'" & Chr$(KeyAscii) & "' is an invalid character"
            Beep
            KeyAscii = 0
    End Select
End Sub

Private Sub mebPhone_ValidationError(InvalidText As String, StartPosition As Integer)
    lblStatus = "'" & Mid$(InvalidText, StartPosition + 1, 1) & "' is an invalid character"
End Sub



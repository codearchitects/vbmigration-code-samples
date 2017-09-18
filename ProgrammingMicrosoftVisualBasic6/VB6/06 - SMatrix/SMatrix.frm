VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "CSparseMatrixSym"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   2040
      TabIndex        =   1
      Top             =   1320
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "CSparseMatrix"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   2040
      TabIndex        =   0
      Top             =   480
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DisableMessage 0354
'##project:DisableMessage 0364


Option Explicit

Private Sub Command1_Click()

    ' create a CSparseMatrix object
    Dim mat As CSparseMatrix
    Set mat = New CSparseMatrix
    
    ' start assigning values
    mat(10, 20) = 123
    mat(12, 14) = 456
    mat(23, 88) = 0      ' this doesn't really do anything
    
    Print mat(10, 20)
    Print mat(12, 14)
    Print mat(14, 16)    ' this print zero

End Sub

Private Sub Command2_Click()

    ' create a CSparseMatrixSym object
    Dim mat As CSparseMatrixSym
    Set mat = New CSparseMatrixSym
    ' set a default value for missing items
    mat.DefaultValue = 0
    
    ' start assigning values
    mat("Rome", "Milan") = 550
    mat("Rome", "Florence") = 250
    mat("Rome", "Rome") = 0          ' this isn't even stored
    
    ' retrieve them
    Print mat("Rome", "Milan")
    Print mat("Milan", "Rome")       ' this works too
    Print mat("Milan", "Florence")   ' this prints 0

End Sub


VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Polymorphism in Action"
   ClientHeight    =   5715
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   8595
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
   ScaleHeight     =   5715
   ScaleWidth      =   8595
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdZoom 
      Caption         =   "Reduce"
      Height          =   495
      Index           =   1
      Left            =   7320
      TabIndex        =   7
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton cmdZoom 
      Caption         =   "Enlarge"
      Height          =   495
      Index           =   0
      Left            =   7320
      TabIndex        =   6
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CommandButton cmdMove 
      Height          =   375
      Index           =   3
      Left            =   8040
      Picture         =   "Form1.frx":0000
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   2400
      Width           =   375
   End
   Begin VB.CommandButton cmdMove 
      Height          =   375
      Index           =   2
      Left            =   7320
      Picture         =   "Form1.frx":0442
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   2400
      Width           =   375
   End
   Begin VB.CommandButton cmdMove 
      Height          =   375
      Index           =   1
      Left            =   7680
      Picture         =   "Form1.frx":0884
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   2760
      Width           =   375
   End
   Begin VB.CommandButton cmdMove 
      Height          =   375
      Index           =   0
      Left            =   7680
      Picture         =   "Form1.frx":0CC6
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   2040
      Width           =   375
   End
   Begin VB.CommandButton cmdRedraw 
      Caption         =   "&Redraw"
      Default         =   -1  'True
      Height          =   495
      Left            =   7200
      TabIndex        =   1
      Top             =   120
      Width           =   1215
   End
   Begin VB.PictureBox picView 
      Height          =   5415
      Left            =   120
      ScaleHeight     =   5355
      ScaleWidth      =   6795
      TabIndex        =   0
      Top             =   120
      Width           =   6855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
' this is a module level variable
Dim Figures As Collection

'##project:DefaultMemberSupport TRUE

'##project:DisableMessages CodeAnalysis

Private Sub Form_Load()
    CreateFigures
End Sub

Private Sub cmdRedraw_Click()
    RedrawFigures
End Sub

' create a set of figures
Private Sub CreateFigures()
    Set Figures = New Collection
    Figures.Add New_CRectangle(1000, 500, 1400, 1200, , vbRed)
    Figures.Add New_CRectangle(4000, 500, 1400, 1200, , vbCyan)
    Figures.Add New_CEllipse(2500, 2000, 1400, 1200, , vbGreen)
    Figures.Add New_CEllipse(3500, 3000, 2500, 2000, , vbYellow)
    Figures.Add New_CSquare(1000, 3600, 1400, , vbBlack)
    Figures.Add New_CSquare(1100, 3700, 1400, , vbWhite)
    Figures.Add New_CLine(2400, 1100, 4000, 1100, vbBlue)
    Figures.Add New_CLine(1700, 1700, 1700, 4000, vbBlue)
    Figures.Add New_CLine(1700, 4000, 3500, 4000, vbBlue)
End Sub

' redraw the contents in Figures
Sub RedrawFigures()
    Dim shape As IShape
    picView.Cls
    For Each shape In Figures
        shape.Draw picView
    Next
End Sub

Private Sub cmdMove_Click(Index As Integer)
    Dim shape As IShape
    For Each shape In Figures
        Select Case Index
            Case 0: shape.Move 0, -100    ' up
            Case 1: shape.Move 0, 100     ' down
            Case 2: shape.Move -100, 0    ' left
            Case 3: shape.Move 100, 0     ' right
        End Select
    Next
    RedrawFigures
End Sub

Private Sub cmdZoom_Click(Index As Integer)
    Dim shape As IShape
    For Each shape In Figures
        If Index = 0 Then
            shape.Zoom 1.1          ' enlarge
        Else
            shape.Zoom 0.9          ' reduce
        End If
    Next
    RedrawFigures
End Sub



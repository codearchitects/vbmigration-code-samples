VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form DemoSlider 
   Caption         =   "Slider Control Demo"
   ClientHeight    =   5760
   ClientLeft      =   2010
   ClientTop       =   1920
   ClientWidth     =   6660
   LinkTopic       =   "Form1"
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   5760
   ScaleWidth      =   6660
   Begin MSComctlLib.Slider Slider1 
      Height          =   4695
      Index           =   1
      Left            =   240
      TabIndex        =   2
      Top             =   480
      Width           =   375
      _ExtentX        =   661
      _ExtentY        =   8281
      _Version        =   393216
      Orientation     =   1
   End
   Begin MSComctlLib.Slider Slider1 
      Height          =   375
      Index           =   0
      Left            =   600
      TabIndex        =   1
      Top             =   120
      Width           =   5775
      _ExtentX        =   10186
      _ExtentY        =   661
      _Version        =   393216
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H0080FF80&
      Height          =   4452
      Left            =   720
      ScaleHeight     =   4395
      ScaleWidth      =   5475
      TabIndex        =   0
      Top             =   600
      Width           =   5532
   End
   Begin VB.Label Label1 
      Caption         =   "Use the sliders to move the intersection point. Press SHIFT to enter SelectRange mode and draw a rectangle."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   720
      TabIndex        =   3
      Top             =   5160
      Width           =   5655
   End
End
Attribute VB_Name = "DemoSlider"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private StartSelection(0 To 1) As Single

Private Sub Form_Load()

    ' this is the horizontal slider
    Slider1(0).Min = 0
    Slider1(0).Max = Picture1.ScaleWidth
    Slider1(0).TickFrequency = Slider1(0).Max / 20
    Slider1(0).Value = Slider1(0).Max / 2
    
    ' this is the vertical slider
    Slider1(1).Min = 0
    Slider1(1).Max = Picture1.ScaleHeight
    Slider1(1).TickFrequency = Slider1(1).Max / 20
    Slider1(1).Value = Slider1(1).Max / 2
    
    Show
    RepaintPicture

End Sub

Private Sub Slider1_MouseDown(index As Integer, Button As Integer, Shift As Integer, x As Single, y As Single)
    ' if the shift key is being pressed, enter Select Range mode
    If Shift = vbShiftMask Then
        Slider1(index).SelectRange = True
        Slider1(index).SelLength = 0
        StartSelection(index) = Slider1(index).Value
    Else
        Slider1(index).SelectRange = False
    End If
End Sub

Private Sub Slider1_Scroll(index As Integer)
    ' show the current value as a tooltip text
    If index = 0 Then
        Slider1(index).Text = "X = " & Slider1(index).Value
    Else
        Slider1(index).Text = "Y = " & Slider1(index).Value
    End If
    
    If Slider1(index).SelectRange Then
        ' if the indicator is being moved in SelectRange mode, you must
        ' discern between two cases
        If Slider1(index).Value > StartSelection(index) Then
            Slider1(index).SelStart = StartSelection(index)
            Slider1(index).SelLength = Slider1(index).Value - StartSelection(index)
        Else
            Slider1(index).SelStart = Slider1(index).Value
            Slider1(index).SelLength = StartSelection(index) - Slider1(index).Value
        End If
    End If

    Call RepaintPicture

End Sub

Public Sub RepaintPicture()
    Dim startPos(0 To 1) As Single, endPos(0 To 1) As Single
    Dim x1 As Single, y1 As Single, x2 As Single, y2 As Single
    Dim index As Integer
    
    ' because controls belong to an array, we may use a For-Next
    ' loop to repeat the same group of statements
    For index = 0 To 1
        startPos(index) = Slider1(index).Value
        endPos(index) = Slider1(index).Value
        If Slider1(index).SelectRange Then
            If Slider1(index).SelStart < Slider1(index).Value Then
                startPos(index) = Slider1(index).SelStart
            Else
                endPos(index) = Slider1(index).Value + Slider1(index).SelLength
            End If
        End If
    Next
    
    ' we finally have the coordinates of the rectangle
    x1 = startPos(0): x2 = endPos(0)
    y1 = startPos(1): y2 = endPos(1)
    ' redraw everything
    Picture1.Cls
    Picture1.Line (0, 0)-(x1, y1)
    Picture1.Line (Picture1.ScaleWidth, 0)-(x2, y1)
    Picture1.Line (x1, y1)-(x2, y2), QBColor(4), BF
    Picture1.Line (0, Picture1.ScaleHeight)-(x1, y2)
    Picture1.Line (Picture1.ScaleWidth, Picture1.ScaleHeight)-(x2, y2)
End Sub

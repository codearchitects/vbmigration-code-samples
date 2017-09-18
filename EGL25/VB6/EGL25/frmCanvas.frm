VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmCanvas 
   AutoRedraw      =   -1  'True
   Caption         =   "EGL24"
   ClientHeight    =   9645
   ClientLeft      =   60
   ClientTop       =   750
   ClientWidth     =   15240
   DrawStyle       =   6  'Inside Solid
   FillStyle       =   7  'Diagonal Cross
   Icon            =   "frmCanvas.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   643
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   1016
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox picCarry 
      BorderStyle     =   0  'None
      Height          =   9015
      Left            =   12120
      ScaleHeight     =   9015
      ScaleWidth      =   3495
      TabIndex        =   1
      Top             =   0
      Width           =   3495
      Begin VB.Frame fraLight 
         Caption         =   "Light"
         Height          =   1335
         Left            =   0
         TabIndex        =   64
         Top             =   6120
         Width           =   3375
         Begin VB.TextBox txtLight 
            Height          =   285
            Index           =   0
            Left            =   120
            TabIndex        =   70
            Tag             =   "Light X"
            Text            =   "0"
            Top             =   480
            Width           =   600
         End
         Begin VB.TextBox txtLight 
            Height          =   285
            Index           =   1
            Left            =   720
            TabIndex        =   69
            Tag             =   "Light Y"
            Text            =   "300"
            Top             =   480
            Width           =   600
         End
         Begin VB.TextBox txtLight 
            Height          =   285
            Index           =   2
            Left            =   1320
            TabIndex        =   68
            Tag             =   "Light Z"
            Text            =   "300"
            Top             =   480
            Width           =   600
         End
         Begin VB.CommandButton cmdApply 
            Caption         =   "Apply"
            Height          =   375
            Left            =   2040
            TabIndex        =   67
            Top             =   360
            Width           =   1095
         End
         Begin VB.OptionButton optLoc 
            Caption         =   "Place"
            Height          =   255
            Index           =   0
            Left            =   1320
            TabIndex        =   66
            Top             =   960
            Value           =   -1  'True
            Width           =   735
         End
         Begin VB.OptionButton optLoc 
            Caption         =   "Satellite"
            Height          =   255
            Index           =   1
            Left            =   2160
            TabIndex        =   65
            Top             =   960
            Width           =   975
         End
         Begin VB.Label lblLX 
            Caption         =   "X"
            Height          =   255
            Left            =   300
            TabIndex        =   74
            Top             =   240
            Width           =   200
         End
         Begin VB.Label lblLY 
            Caption         =   "Y"
            Height          =   255
            Left            =   900
            TabIndex        =   73
            Top             =   240
            Width           =   200
         End
         Begin VB.Label lblLZ 
            Caption         =   "Z"
            Height          =   255
            Left            =   1500
            TabIndex        =   72
            Top             =   240
            Width           =   200
         End
         Begin VB.Label Label13 
            Caption         =   "Light Location"
            Height          =   255
            Left            =   120
            TabIndex        =   71
            Top             =   960
            Width           =   1095
         End
      End
      Begin VB.Frame fraPosition 
         Caption         =   "Position"
         Height          =   1575
         Left            =   0
         TabIndex        =   48
         Top             =   0
         Width           =   3375
         Begin VB.Label Label5 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "X"
            Height          =   255
            Left            =   120
            TabIndex        =   63
            Top             =   480
            Width           =   300
         End
         Begin VB.Label Label6 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Y"
            Height          =   255
            Left            =   120
            TabIndex        =   62
            Top             =   720
            Width           =   300
         End
         Begin VB.Label Label7 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Z"
            Height          =   255
            Left            =   120
            TabIndex        =   61
            Top             =   960
            Width           =   300
         End
         Begin VB.Label Label16 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Translation"
            Height          =   255
            Left            =   480
            TabIndex        =   60
            Top             =   240
            Width           =   900
         End
         Begin VB.Label Label17 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Rotation"
            Height          =   255
            Left            =   1440
            TabIndex        =   59
            Top             =   240
            Width           =   900
         End
         Begin VB.Label Label18 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Scale"
            Height          =   255
            Left            =   2400
            TabIndex        =   58
            Top             =   240
            Width           =   900
         End
         Begin VB.Label lblTz 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "t"
            Height          =   255
            Left            =   480
            TabIndex        =   57
            Top             =   960
            Width           =   900
         End
         Begin VB.Label lblTy 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "t"
            Height          =   255
            Left            =   480
            TabIndex        =   56
            Top             =   720
            Width           =   900
         End
         Begin VB.Label lblTx 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "t"
            Height          =   255
            Left            =   480
            TabIndex        =   55
            Top             =   480
            Width           =   900
         End
         Begin VB.Label lblRz 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "r"
            Height          =   255
            Left            =   1440
            TabIndex        =   54
            Top             =   960
            Width           =   900
         End
         Begin VB.Label lblRy 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "r"
            Height          =   255
            Left            =   1440
            TabIndex        =   53
            Top             =   720
            Width           =   900
         End
         Begin VB.Label lblRx 
            Alignment       =   1  'Right Justify
            BorderStyle     =   1  'Fixed Single
            Caption         =   "r"
            Height          =   255
            Left            =   1440
            TabIndex        =   52
            Top             =   480
            Width           =   900
         End
         Begin VB.Label lblS 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "s"
            Height          =   255
            Left            =   2400
            TabIndex        =   51
            Top             =   480
            Width           =   900
         End
         Begin VB.Label lblFPS 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "fps"
            Height          =   255
            Left            =   2400
            TabIndex        =   50
            Top             =   960
            Width           =   900
         End
         Begin VB.Label Label15 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "FPS"
            Height          =   255
            Left            =   2400
            TabIndex        =   49
            Top             =   720
            Width           =   900
         End
      End
      Begin VB.Frame fraProperties 
         Caption         =   "Face Properties"
         Height          =   1575
         Left            =   0
         TabIndex        =   34
         Top             =   4440
         Width           =   3375
         Begin VB.CheckBox chkShow 
            Caption         =   "Show"
            Height          =   255
            Left            =   120
            TabIndex        =   36
            Top             =   360
            Width           =   855
         End
         Begin VB.HScrollBar scrFaces 
            Height          =   255
            LargeChange     =   10
            Left            =   1080
            Max             =   255
            TabIndex        =   35
            Top             =   360
            Width           =   1230
         End
         Begin VB.Label Label8 
            Alignment       =   2  'Center
            Caption         =   "A:"
            Height          =   240
            Left            =   120
            TabIndex        =   47
            Top             =   720
            Width           =   300
         End
         Begin VB.Label Label9 
            Alignment       =   2  'Center
            Caption         =   "B:"
            Height          =   240
            Left            =   120
            TabIndex        =   46
            Top             =   960
            Width           =   300
         End
         Begin VB.Label Label10 
            Alignment       =   2  'Center
            Caption         =   "C:"
            Height          =   240
            Left            =   120
            TabIndex        =   45
            Top             =   1200
            Width           =   300
         End
         Begin VB.Label lblB 
            Caption         =   "No"
            Height          =   240
            Left            =   480
            TabIndex        =   44
            Top             =   960
            Width           =   750
         End
         Begin VB.Label lblA 
            Caption         =   "No"
            Height          =   240
            Left            =   480
            TabIndex        =   43
            Top             =   720
            Width           =   750
         End
         Begin VB.Label Label11 
            Alignment       =   1  'Right Justify
            Caption         =   "Faces Num.:"
            Height          =   255
            Left            =   1320
            TabIndex        =   42
            Top             =   720
            Width           =   975
         End
         Begin VB.Label Label12 
            Alignment       =   1  'Right Justify
            Caption         =   "Visible Faces:"
            Height          =   255
            Left            =   1320
            TabIndex        =   41
            Top             =   960
            Width           =   975
         End
         Begin VB.Label lblFacesNum 
            Caption         =   "-"
            Height          =   255
            Left            =   2400
            TabIndex        =   40
            Top             =   720
            Width           =   795
         End
         Begin VB.Label lblFacesNumV 
            Caption         =   "-"
            Height          =   255
            Left            =   2400
            TabIndex        =   39
            Top             =   960
            Width           =   795
         End
         Begin VB.Label lblFaces 
            Caption         =   "-"
            Height          =   255
            Left            =   2400
            TabIndex        =   38
            Top             =   360
            Width           =   795
         End
         Begin VB.Label lblC 
            Caption         =   "No"
            Height          =   240
            Left            =   480
            TabIndex        =   37
            Top             =   1200
            Width           =   750
         End
      End
      Begin VB.Frame fraAnimation 
         Caption         =   "Animation"
         Height          =   1335
         Left            =   0
         TabIndex        =   19
         Top             =   7560
         Width           =   3375
         Begin VB.TextBox txtTrans 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   0
            Left            =   480
            TabIndex        =   27
            Text            =   "0"
            Top             =   480
            Width           =   900
         End
         Begin VB.TextBox txtRot 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   0
            Left            =   1440
            TabIndex        =   26
            Text            =   "0"
            Top             =   480
            Width           =   900
         End
         Begin VB.TextBox txtSpeed 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   2400
            TabIndex        =   25
            Text            =   "0"
            Top             =   480
            Width           =   900
         End
         Begin VB.CheckBox chkAnimation 
            Caption         =   "Start"
            Height          =   255
            Left            =   2520
            TabIndex        =   24
            Top             =   960
            Width           =   735
         End
         Begin VB.TextBox txtTrans 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   1
            Left            =   480
            TabIndex        =   23
            Text            =   "0"
            Top             =   720
            Width           =   900
         End
         Begin VB.TextBox txtRot 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   1
            Left            =   1440
            TabIndex        =   22
            Text            =   "0"
            Top             =   720
            Width           =   900
         End
         Begin VB.TextBox txtTrans 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   2
            Left            =   480
            TabIndex        =   21
            Text            =   "0"
            Top             =   960
            Width           =   900
         End
         Begin VB.TextBox txtRot 
            Alignment       =   2  'Center
            Height          =   285
            Index           =   2
            Left            =   1440
            TabIndex        =   20
            Text            =   "0"
            Top             =   960
            Width           =   900
         End
         Begin VB.Label Label28 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Speed"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2400
            TabIndex        =   33
            Top             =   240
            Width           =   900
         End
         Begin VB.Label Label29 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Rotation"
            Height          =   255
            Left            =   1440
            TabIndex        =   32
            Top             =   240
            Width           =   900
         End
         Begin VB.Label Label30 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Translation"
            Height          =   255
            Left            =   480
            TabIndex        =   31
            Top             =   240
            Width           =   900
         End
         Begin VB.Label Label31 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Z"
            Height          =   255
            Left            =   120
            TabIndex        =   30
            Top             =   960
            Width           =   300
         End
         Begin VB.Label Label32 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "Y"
            Height          =   255
            Left            =   120
            TabIndex        =   29
            Top             =   720
            Width           =   300
         End
         Begin VB.Label Label33 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "X"
            Height          =   255
            Left            =   120
            TabIndex        =   28
            Top             =   480
            Width           =   300
         End
      End
      Begin VB.Frame fraColor 
         Caption         =   "Color"
         Height          =   2655
         Left            =   0
         TabIndex        =   2
         Top             =   1680
         Width           =   3375
         Begin VB.CommandButton cmdRandom 
            Caption         =   "Random"
            Height          =   375
            Left            =   1920
            TabIndex        =   10
            Top             =   1680
            Width           =   1095
         End
         Begin VB.HScrollBar scrRed 
            Height          =   255
            LargeChange     =   5
            Left            =   1680
            Max             =   255
            TabIndex        =   9
            Top             =   360
            Width           =   1000
         End
         Begin VB.HScrollBar scrGreen 
            Height          =   255
            LargeChange     =   5
            Left            =   1680
            Max             =   255
            TabIndex        =   8
            Top             =   600
            Width           =   1000
         End
         Begin VB.HScrollBar scrBlue 
            Height          =   255
            LargeChange     =   5
            Left            =   1680
            Max             =   255
            TabIndex        =   7
            Top             =   840
            Width           =   1000
         End
         Begin VB.CommandButton cmdSelect 
            Caption         =   "Select"
            Height          =   375
            Left            =   1920
            TabIndex        =   6
            Top             =   2160
            Width           =   1095
         End
         Begin VB.HScrollBar scrLuminance 
            Height          =   255
            LargeChange     =   2
            Left            =   1680
            Max             =   100
            TabIndex        =   5
            Top             =   1200
            Value           =   50
            Width           =   1000
         End
         Begin VB.OptionButton optColor 
            Caption         =   "Color"
            Height          =   255
            Index           =   0
            Left            =   360
            TabIndex        =   4
            Top             =   1560
            Width           =   1215
         End
         Begin VB.OptionButton optColor 
            Caption         =   "Gray"
            Height          =   255
            Index           =   1
            Left            =   360
            TabIndex        =   3
            Top             =   1920
            Width           =   1215
         End
         Begin VB.Label lblRGBA 
            Caption         =   "-"
            Height          =   255
            Index           =   2
            Left            =   2760
            TabIndex        =   18
            Top             =   840
            Width           =   375
         End
         Begin VB.Label lblRGBA 
            Caption         =   "-"
            Height          =   255
            Index           =   1
            Left            =   2760
            TabIndex        =   17
            Top             =   600
            Width           =   375
         End
         Begin VB.Label lblRGBA 
            Caption         =   "-"
            Height          =   255
            Index           =   0
            Left            =   2760
            TabIndex        =   16
            Top             =   360
            Width           =   375
         End
         Begin VB.Label Label26 
            Caption         =   "Blue"
            Height          =   255
            Left            =   240
            TabIndex        =   15
            Top             =   840
            Width           =   495
         End
         Begin VB.Label Label27 
            Caption         =   "Green"
            Height          =   255
            Left            =   240
            TabIndex        =   14
            Top             =   600
            Width           =   495
         End
         Begin VB.Label Label34 
            Caption         =   "Red"
            Height          =   255
            Left            =   240
            TabIndex        =   13
            Top             =   360
            Width           =   495
         End
         Begin VB.Label Label1 
            Caption         =   "Luminance"
            Height          =   255
            Left            =   240
            TabIndex        =   12
            Top             =   1200
            Width           =   1215
         End
         Begin VB.Label lblRGBA 
            Caption         =   "-"
            Height          =   255
            Index           =   3
            Left            =   2760
            TabIndex        =   11
            Top             =   1200
            Width           =   375
         End
      End
   End
   Begin VB.PictureBox picCanvas 
      BackColor       =   &H00808080&
      ForeColor       =   &H00808080&
      Height          =   9600
      Left            =   0
      ScaleHeight     =   636
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   796
      TabIndex        =   0
      Top             =   0
      Width           =   12000
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   840
      Top             =   11760
   End
   Begin MSComDlg.CommonDialog cdiLoad 
      Left            =   240
      Top             =   11760
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuOpen 
         Caption         =   "&Open"
         Shortcut        =   ^O
      End
      Begin VB.Menu tire1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&Render"
      Begin VB.Menu mnuRender 
         Caption         =   "Dot"
         Index           =   0
      End
      Begin VB.Menu mnuRender 
         Caption         =   "Dot(Culled)"
         Index           =   1
      End
      Begin VB.Menu mnuRender 
         Caption         =   "Wireframe"
         Index           =   2
      End
      Begin VB.Menu mnuRender 
         Caption         =   "Hidden"
         Index           =   3
      End
      Begin VB.Menu mnuRender 
         Caption         =   "Solid"
         Index           =   4
      End
      Begin VB.Menu mnuRender 
         Caption         =   "SolidFrame"
         Index           =   5
      End
      Begin VB.Menu tire 
         Caption         =   "-"
      End
      Begin VB.Menu mnuShade 
         Caption         =   "Shade"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mnuKeyboard 
         Caption         =   "&Keyboard"
      End
   End
End
Attribute VB_Name = "frmCanvas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim FPS As Integer

Private Sub chkShow_Click()
    
    With chkShow
        scrFaces.Enabled = .Value
        RO.Show = .Value
    End With

End Sub

Private Sub cmdApply_Click()
    
    If IsNumeric(txtLight(0).Text) And _
       IsNumeric(txtLight(1).Text) And _
       IsNumeric(txtLight(2).Text) Then
           Light = VectorSet(CSng(txtLight(0).Text), _
                             CSng(txtLight(1).Text), _
                             CSng(txtLight(2).Text))
           Light = VectorNormalize(Light)
    End If

End Sub

Private Sub Form_Resize()

If Me.ScaleWidth - picCarry.Width - 5 > 5 Then
    picCanvas.Move 0, 0, Me.ScaleWidth - picCarry.Width - 5, Me.ScaleHeight
    picCarry.Move picCanvas.ScaleWidth + 10, 5
    HalfWidth = picCanvas.ScaleWidth / 2
    HalfHeight = picCanvas.ScaleHeight / 2
    Call TerminateDC
    Call InitializeDC(picCanvas)
End If

End Sub

Private Sub Form_Unload(Cancel As Integer)

    Call TerminateDC
    End

End Sub

Private Sub mnuExit_Click()
    
     Unload Me
    
End Sub

Private Sub mnuKeyboard_Click()
    
    frmKeyboard.Show vbModeless, frmCanvas

End Sub

Private Sub mnuOpen_Click()

    Call LoadPart
    
End Sub

Private Sub mnuRender_Click(Index As Integer)
    
    Dim i As Integer
    
    RO.RType = Index
    RO.Hidden = IIf(RO.RType = Dot Or RO.RType = Wireframe, False, True)
    For i = 0 To mnuRender.Count - 1
        mnuRender(i).Checked = IIf(i = Index, True, False)
    Next
    
    
End Sub

Private Sub mnuShade_Click()
    
    mnuShade.Checked = Not mnuShade.Checked
    RO.Shade = mnuShade.Checked

End Sub

Private Sub optColor_Click(Index As Integer)

    If Index = 0 Then
        RO.tColor = ColorSet(scrRed.Value, scrGreen.Value, scrBlue.Value)
    Else
        RO.tColor = ColorGray(scrRed.Value, scrGreen.Value, scrBlue.Value)
    End If

End Sub

Private Sub optLoc_Click(Index As Integer)

    RO.LightOrbit = IIf(Index = 1, True, False)

End Sub

Private Sub picCanvas_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)

    If Button = vbLeftButton Then
        txtLight(0).Text = X - (picCanvas.ScaleWidth / 2)
        txtLight(1).Text = -Y + (picCanvas.ScaleHeight / 2)
    End If
    Call cmdApply_Click

End Sub

Private Sub picCanvas_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)

    If Button = vbRightButton Then PopupMenu mnuView

End Sub

Private Sub scrRed_Change()

    Call UpdateROColor(ColorSet(scrRed.Value, RO.tColor.G, RO.tColor.B))

End Sub

Private Sub scrRed_Scroll()

    Call UpdateROColor(ColorSet(scrRed.Value, RO.tColor.G, RO.tColor.B))

End Sub

Private Sub scrGreen_Change()

    Call UpdateROColor(ColorSet(RO.tColor.R, scrGreen.Value, RO.tColor.B))

End Sub

Private Sub scrGreen_Scroll()

    Call UpdateROColor(ColorSet(RO.tColor.R, scrGreen.Value, RO.tColor.B))

End Sub

Private Sub scrBlue_Change()

    Call UpdateROColor(ColorSet(RO.tColor.R, RO.tColor.G, scrBlue.Value))

End Sub

Private Sub scrBlue_Scroll()

    Call UpdateROColor(ColorSet(RO.tColor.R, RO.tColor.G, scrBlue.Value))

End Sub

Private Sub scrFaces_Change()
    
    lblFaces.Caption = scrFaces.Value
    RO.ShowIndex = scrFaces.Value

End Sub

Private Sub scrFaces_Scroll()

    lblFaces.Caption = scrFaces.Value
    RO.ShowIndex = scrFaces.Value

End Sub

Private Sub scrLuminance_Change()
    
    RO.Luminance = scrLuminance.Value

End Sub

Private Sub scrLuminance_Scroll()

    RO.Luminance = scrLuminance.Value

End Sub

Private Sub Timer1_Timer()
    
    lblFPS.Caption = FPS
    FPS = 0

End Sub

Private Sub Form_Load()
    
    Call InitializeDC(picCanvas)
    Call SetIdentity
    Call chkShow_Click
    Call mnuRender_Click(4)
    Call mnuShade_Click
'    chkShow.Value = vbUnchecked
    chkShow.Enabled = False
    scrFaces.Enabled = False
    optColor(0).Value = True
    Camera.X = 0
    Camera.Y = 0
    Camera.Z = 1
    
End Sub


Private Sub cmdRandom_Click()

    Call UpdateROColor(ColorRandom)

End Sub

Private Sub cmdSelect_Click()

    cdiLoad.ShowColor
    If cdiLoad.Color <> 0 Then
        Call UpdateROColor(ColorLongToRGB(cdiLoad.Color))
    End If

End Sub

Private Sub UpdateROColor(C As ColorRGB)

    RO.tColor = C
    optColor(0).Value = True
    scrRed.Value = RO.tColor.R
    scrGreen.Value = RO.tColor.G
    scrBlue.Value = RO.tColor.B

End Sub

Private Sub LoadPart()
    
    On Error Resume Next
    With cdiLoad
        .Filter = "EGL part file|*.prt"
'        .InitDir = App.Path + "\objects\"
        .FileName = ""
        .ShowOpen
        If .FileName = "" Then Exit Sub
        Call LoadObject(.FileName)
    End With
    
    Dim PosMatrix As Matrix
    Dim i As Long
    
    With ObjPart
        optLoc(0).Value = True
        chkShow.Enabled = True
        chkShow.Value = vbUnchecked
        Call UpdateROColor(ColorSet(.Color.R, .Color.G, .Color.B))
        lblFacesNum.Caption = .NumFaces
        Me.Caption = .Caption & " - EGL"
        scrFaces.Max = .NumFaces
        cmdApply_Click
        RO.Luminance = scrLuminance.Value
        
        Do
            Call UpdatePartPos
            
            PosMatrix = WorldMatrix
            
            For i = 0 To .NumVertices
                .VerticesT(i) = MatrixMultVector(PosMatrix, .Vertices(i))
                .VerticesT(i) = VectorScale(.VerticesT(i), .Scale)
                .ScreenCoord(i).X = .VerticesT(i).X + HalfWidth
                .ScreenCoord(i).Y = -.VerticesT(i).Y + HalfHeight
            Next i
                        
            For i = 0 To .NumFaces
                .NormalT(i) = MatrixMultVector(PosMatrix, .Normal(i))
            Next
            
            If optLoc(0).Value Then
                LightT = Light
            Else
                LightT = MatrixMultVector(PosMatrix, Light)
            End If
            
            Call Render(picCanvas)
            lblTx.Caption = .Position.X
            lblTy.Caption = .Position.Y
            lblTz.Caption = .Position.Z
            lblRx.Caption = .Direction.X
            lblRy.Caption = .Direction.Y
            lblRz.Caption = .Direction.Z
            lblS.Caption = .Scale
            lblRGBA(0).Caption = scrRed.Value
            lblRGBA(1).Caption = scrGreen.Value
            lblRGBA(2).Caption = scrBlue.Value
            lblRGBA(3).Caption = scrLuminance.Value
            lblFacesNumV.Caption = UBound(ObjPart.FaceV)
            FPS = FPS + 1
            DoEvents
        Loop
    End With
    
End Sub

'Private Sub UpdateLabels()

'    Dim idx As Integer
'    Dim point As POINTAPI
'
'    With ObjPart
'        If chkShow.Value Then
'                lblFaces.Caption = scrFaces.Value
'                lblA.Caption = .Faces(scrFaces.Value).A
'                lblB.Caption = .Faces(scrFaces.Value).B
'                lblC.Caption = .Faces(scrFaces.Value).C
''                labA.Caption = lblA.Caption
''                labB.Caption = lblB.Caption
''                labC.Caption = lblC.Caption
''                point.X = .VerticesT(lblA.Caption).X
''                point.Y = -.VerticesT(lblA.Caption).Y
''                labA.Move point.X, point.Y
''                point.X = .VerticesT(lblB.Caption).X
''                point.Y = -.VerticesT(lblB.Caption).Y
''                labB.Move point.X, point.Y
''                point.X = .VerticesT(lblC.Caption).X
''                point.Y = -.VerticesT(lblC.Caption).Y
''                labC.Move point.X, point.Y
'        End If
        
'    End With

'End Sub

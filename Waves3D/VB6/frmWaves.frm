VERSION 5.00
Begin VB.Form frmWaves 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Waves"
   ClientHeight    =   7275
   ClientLeft      =   2865
   ClientTop       =   1905
   ClientWidth     =   8130
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   18
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   7275
   ScaleWidth      =   8130
   Begin VB.TextBox txtCounter 
      Alignment       =   2  'Center
      BackColor       =   &H80000008&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   192
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000009&
      Height          =   3615
      Left            =   360
      TabIndex        =   4
      Top             =   120
      Visible         =   0   'False
      Width           =   7455
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7200
      TabIndex        =   3
      Top             =   6600
      Width           =   615
   End
   Begin VB.CommandButton cmdDisplay 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Run"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   6600
      Width           =   1455
   End
   Begin VB.CommandButton cmdCreate 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Create"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2400
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   6600
      Width           =   1575
   End
   Begin VB.PictureBox Pict 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   6135
      Left            =   240
      ScaleHeight     =   405
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   509
      TabIndex        =   0
      Top             =   0
      Width           =   7695
   End
   Begin VB.Label lblCounter 
      Alignment       =   2  'Center
      BackColor       =   &H80000008&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   2415
      Left            =   360
      TabIndex        =   5
      Top             =   3720
      Visible         =   0   'False
      Width           =   7455
      WordWrap        =   -1  'True
   End
   Begin VB.Image SurfaceImage 
      Height          =   735
      Index           =   1
      Left            =   240
      Top             =   6360
      Visible         =   0   'False
      Width           =   855
   End
End
Attribute VB_Name = "frmWaves"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const EyeR = 10#
Const EyeTheta = PI * 0.2
Const EyePhi = PI * 0.1

Const FocusX = 0#
Const FocusY = 0#
Const FocusZ = 0#

Dim Projector(1 To 4, 1 To 4) As Single

Dim ThePicture As objPicture
Dim TheGrid As ObjGrid3D
Dim Running As Integer
' Draw the surface.
Private Sub DrawData(pic As Object)
Dim x As Single
Dim y As Single
Dim z As Single
Dim S(1 To 4, 1 To 4) As Single
Dim t(1 To 4, 1 To 4) As Single
Dim ST(1 To 4, 1 To 4) As Single
Dim PST(1 To 4, 1 To 4) As Single

    
    On Error Resume Next
    
    ' Scale and translate so it looks OK in pixels.
    m3Scale S, 35, -35, 1
    m3Translate t, 230, 175, 0
    m3MatMultiplyFull ST, S, t
    m3MatMultiplyFull PST, Projector, ST
    
    ' Transform the points.
    ThePicture.ApplyFull PST

    ' Display the data.
    pic.Cls
    ThePicture.Draw pic, EyeR
    pic.Refresh
End Sub




Private Sub CmdDisplay_Click()
    Pict.Visible = True
    If Running Then
        cmdDisplay.Caption = "Stopped"
        cmdDisplay.Enabled = False
        Running = False
    Else
        Running = True
        cmdDisplay.Caption = "Stop"
        ShowFrames
        cmdDisplay.Caption = "Run"
        cmdDisplay.Enabled = True
    End If
End Sub

Private Sub cmdExit_Click()
If cmdDisplay.Caption = "Stop" Then
   MsgBox "Stop the Function first !", vbInformation, "Waves"
   Exit Sub
Else
   Unload Me
End If
End Sub

Private Sub Form_Load()
Dim i As Integer

    ' Initialize the projection transformation.
    m3PProject Projector, m3Perspective, EyeR, EyePhi, EyeTheta, FocusX, FocusY, FocusZ, 0, 1, 0
    
    ' Load empty image controls for later reproduction of saved image transformation
    For i = 2 To 20
        Load SurfaceImage(i)
    Next i
    
    cmdDisplay.Enabled = False
End Sub


Sub CmdCreate_click()
cmdDisplay.Enabled = True
lblCounter.Visible = True
txtCounter.Visible = True
Pict.Visible = False
Const PI_10 = PI / 10
Const xmin = -5
Const Zmin = -5
Const dx = 0.3
Const dz = 0.3
Const NumX = -2 * xmin / dx
Const NumZ = -2 * Zmin / dz
Const Amp = 0.25

Dim num As Integer
Dim offset As Single
Dim i As Integer
Dim j As Integer
Dim x As Single
Dim y As Single
Dim z As Single
Dim D As Single

    MousePointer = vbHourglass
    Refresh
    'Save 20 positions of grid(net) as images
    For num = 1 To 20
        Dim count As Integer
        count = (20 - num) \ 2
        lblCounter.Caption = vbCrLf & "Loading ... "
        txtCounter.Text = count
        Set ThePicture = New objPicture
        Set TheGrid = New ObjGrid3D
        TheGrid.SetBounds xmin, dx, NumX, Zmin, dz, NumZ
        ThePicture.objects.Add TheGrid
        
        offset = num * PI_10
        x = xmin
        For i = 1 To NumX
            z = Zmin
            For j = 1 To NumZ
                D = Sqr(x * x + z * z)
                
                'This is a Function that can be modified , You can test various
                'formulas and even ,( I think it is possible ) to get data from Db and
                'set the function to show graphical ( 3D ) report.
                'If you perform testing , take care about OVERFLOW error
                y = Amp * Sin(3 * D - offset)
                
                TheGrid.SetValue x, y, z
                z = z + dz
                
            Next j
                        
            x = x + dx
        Next i
   
        ' Display the data.
        DrawData Pict
        
        ' Save the bitmap for later.
        SurfaceImage(num).Picture = Pict.Image
        DoEvents
    
    Next num
    txtCounter.Visible = False
    lblCounter.Visible = False
    Pict.Visible = True
    cmdCreate.Enabled = False
    cmdDisplay.Enabled = True
    cmdDisplay.Default = True
    MousePointer = vbDefault
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    End
End Sub

' Show the images.
Private Sub ShowFrames()
Const ms_per_frame = 50
Static num As Integer
Dim next_time As Long

    Do While Running
        num = num + 1
        If num > 20 Then num = 1
        next_time = GetTickCount() + ms_per_frame
        Pict.Picture = SurfaceImage(num).Picture
        DoEvents
        WaitTill next_time
    Loop
End Sub





VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "StatusBar Demo"
   ClientHeight    =   3465
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8340
   LinkTopic       =   "Form1"
   ScaleHeight     =   3465
   ScaleWidth      =   8340
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdProgress 
      Caption         =   "Show a progress bar"
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
      Left            =   240
      TabIndex        =   5
      Top             =   1200
      Width           =   2175
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   255
      Left            =   2640
      TabIndex        =   4
      Top             =   1080
      Visible         =   0   'False
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
      _Version        =   393216
      Appearance      =   1
   End
   Begin VB.TextBox Text1 
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
      Left            =   4080
      TabIndex        =   3
      Top             =   1920
      Width           =   3975
   End
   Begin VB.CommandButton cmdCreate 
      Caption         =   "Create a new Panel"
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
      Left            =   240
      TabIndex        =   1
      Top             =   360
      Width           =   2175
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   500
      Left            =   2760
      Top             =   1680
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   3090
      Width           =   8340
      _ExtentX        =   14711
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   7
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   3528
            MinWidth        =   3528
            Picture         =   "StatuBar.frx":0000
            Text            =   "Click to edit text"
            TextSave        =   "Click to edit text"
            Object.Tag             =   "Editable"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   6
            AutoSize        =   1
            Picture         =   "StatuBar.frx":0452
            TextSave        =   "03-Oct-2007"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            Picture         =   "StatuBar.frx":05EC
            TextSave        =   "6:29 PM"
         EndProperty
         BeginProperty Panel4 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   1
            Enabled         =   0   'False
            Object.Width           =   1411
            MinWidth        =   1411
            TextSave        =   "CAPS"
         EndProperty
         BeginProperty Panel5 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   2
            AutoSize        =   2
            Object.Width           =   1402
            MinWidth        =   1411
            TextSave        =   "NUM"
         EndProperty
         BeginProperty Panel6 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   4
            AutoSize        =   2
            Enabled         =   0   'False
            Object.Width           =   1402
            MinWidth        =   1411
            TextSave        =   "SCRL"
         EndProperty
         BeginProperty Panel7 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   3
            Enabled         =   0   'False
            TextSave        =   "INS"
         EndProperty
      EndProperty
   End
   Begin VB.Image Image1 
      Height          =   375
      Left            =   720
      Top             =   2280
      Width           =   615
   End
   Begin VB.Label Label1 
      Caption         =   "Toggle the state of lock keys by double-clicking on the corresponding Panel, then check the result in this textbox:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   4080
      TabIndex        =   2
      Top             =   1080
      Width           =   4215
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   7
      Left            =   7800
      Picture         =   "StatuBar.frx":0A3E
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   6
      Left            =   7080
      Picture         =   "StatuBar.frx":0E80
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   5
      Left            =   6360
      Picture         =   "StatuBar.frx":12C2
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   4
      Left            =   5640
      Picture         =   "StatuBar.frx":1704
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   3
      Left            =   4920
      Picture         =   "StatuBar.frx":1B46
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   2
      Left            =   4200
      Picture         =   "StatuBar.frx":1F88
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   1
      Left            =   3480
      Picture         =   "StatuBar.frx":23CA
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image imgMoon 
      Height          =   480
      Index           =   0
      Left            =   2760
      Picture         =   "StatuBar.frx":280C
      Top             =   360
      Visible         =   0   'False
      Width           =   480
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function GetKeyboardState Lib "user32" (pbKeyState As Byte) As Long
Private Declare Function SetKeyboardState Lib "user32" (lppbKeyState As Byte) As Long

Dim Animation As Boolean

Private Sub cmdCreate_Click()
    ' dynamically create a new Panel
    With StatusBar1.Panels.Add(1, "moon", "Click to start animation", sbrText, imgMoon(0))
        .Alignment = sbrCenter
        .AutoSize = sbrContents
        .Tag = "Animated"
    End With
    cmdCreate.Enabled = False
End Sub

Private Sub StatusBar1_PanelClick(ByVal Panel As MSComctlLib.Panel)
    Select Case Panel.Tag
        Case "Editable"
            Dim s As String
            s = InputBox("Enter a new text for this panel", , Panel.Text)
            If Len(s) Then Panel.Text = s
        Case "Animated"
            Animation = Not Animation
            Timer1.Enabled = Animation
            Panel.Text = "Click to " & IIf(Animation, "stop", "start") & " animation"
    End Select
End Sub

Private Sub StatusBar1_PanelDblClick(ByVal Panel As MSComctlLib.Panel)
    Select Case Panel.Style
        Case sbrCaps
            ToggleKey vbKeyCapital
        Case sbrNum
            ToggleKey vbKeyNumlock
        Case sbrScrl
            ToggleKey vbKeyScrollLock
        Case sbrIns
            ToggleKey vbKeyInsert
    End Select
    StatusBar1.Refresh
    Text1.SetFocus
End Sub

Sub ToggleKey(vKey As KeyCodeConstants)
    Dim keys(255) As Byte
    ' read the current state of the keyboard
    GetKeyboardState keys(0)
    ' toggle bit 0 of the virtual key we're interested in
    keys(vKey) = keys(vKey) Xor 1
    ' enforce the new keyboard state
    SetKeyboardState keys(0)
End Sub

Private Sub Timer1_Timer()
    Static n As Integer
    ' show the next image
    StatusBar1.Panels("moon").Picture = imgMoon(n).Picture
    n = (n + 1) Mod 8
End Sub

Private Sub cmdProgress_Click()
    Dim v As Single
    
    MoveProgressBarIntoPanel ProgressBar1, StatusBar1, 1
    
    ' let the progress bar grow
    For v = 1 To 100 Step 0.1
        ProgressBar1.value = v
        DoEvents
    Next
    
    ' restore original state
    ProgressBar1.Visible = False
    StatusBar1.Panels(1).Bevel = sbrInset
End Sub

Private Sub MoveProgressBarIntoPanel(pb As ProgressBar, sb As StatusBar, pnlIndex As Integer)
    Dim deltaY As Single, pnl As Panel, y As Single
    
    ' account for two pixels around each panel
    deltaY = ScaleY(2, vbPixels, vbTwips)
    Set pnl = sb.Panels(pnlIndex)
    pnl.Bevel = sbrNoBevel
    ' It is necessary to evaluate the Y coordinate in this way because
    ' if this routine is invoked from Form_Resize you can't rely on
    ' the StatusBar's or Panel's Top property, which still has to be updated.
    y = ScaleHeight - sb.Height
    
    ' Move the progress bar in position, and in front of the status bar.
    pb.Move pnl.Left, y + deltaY, pnl.Width, StatusBar1.Height - deltaY
    pb.Visible = True
    pb.ZOrder
End Sub

Private Sub Form_Resize()
    ' If the progress bar is visible, you need to move it when
    ' the form is resized.
    If ProgressBar1.Visible Then
        MoveProgressBarIntoPanel ProgressBar1, StatusBar1, 1
    End If
End Sub




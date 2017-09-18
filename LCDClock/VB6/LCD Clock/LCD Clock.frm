VERSION 5.00
Begin VB.Form MainFrm 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   1035
   ClientLeft      =   150
   ClientTop       =   435
   ClientWidth     =   5670
   Icon            =   "LCD Clock.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   69
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   378
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer2 
      Interval        =   100
      Left            =   5355
      Top             =   1785
   End
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   4785
      Top             =   1785
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   20
      Left            =   4515
      Picture         =   "LCD Clock.frx":0CCA
      ToolTipText     =   "Exit"
      Top             =   0
      Width           =   150
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   19
      Left            =   0
      Picture         =   "LCD Clock.frx":11EC
      ToolTipText     =   "Hide For 10 Seconds"
      Top             =   0
      Width           =   180
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   18
      Left            =   3345
      Picture         =   "LCD Clock.frx":17AA
      ToolTipText     =   "Help"
      Top             =   0
      Width           =   150
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   17
      Left            =   2685
      Picture         =   "LCD Clock.frx":1CCC
      ToolTipText     =   "Swap Day And Month"
      Top             =   0
      Width           =   150
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   16
      Left            =   1920
      Picture         =   "LCD Clock.frx":21EE
      ToolTipText     =   "Move"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   15
      Left            =   1305
      Picture         =   "LCD Clock.frx":2A1C
      Top             =   0
      Width           =   105
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   14
      Left            =   690
      Picture         =   "LCD Clock.frx":2E06
      Top             =   0
      Width           =   105
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   13
      Left            =   4260
      ToolTipText     =   "Year"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   12
      Left            =   4005
      ToolTipText     =   "Year"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   11
      Left            =   3750
      ToolTipText     =   "Year"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   10
      Left            =   3495
      ToolTipText     =   "Year"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   9
      Left            =   3090
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   8
      Left            =   2835
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   7
      Left            =   2430
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   6
      Left            =   2175
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   5
      Left            =   1665
      ToolTipText     =   "Second"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   4
      Left            =   1410
      ToolTipText     =   "Second"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   3
      Left            =   1050
      ToolTipText     =   "Minute"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   2
      Left            =   795
      ToolTipText     =   "Minute"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   1
      Left            =   435
      ToolTipText     =   "Hour"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image2 
      Height          =   585
      Index           =   0
      Left            =   180
      ToolTipText     =   "Hour"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   0
      Left            =   900
      Picture         =   "LCD Clock.frx":31F0
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   1
      Left            =   1230
      Picture         =   "LCD Clock.frx":3A1E
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   2
      Left            =   1590
      Picture         =   "LCD Clock.frx":424C
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   3
      Left            =   1950
      Picture         =   "LCD Clock.frx":4A7A
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   4
      Left            =   2310
      Picture         =   "LCD Clock.frx":52A8
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   5
      Left            =   2670
      Picture         =   "LCD Clock.frx":5AD6
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   6
      Left            =   3030
      Picture         =   "LCD Clock.frx":6304
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   7
      Left            =   3390
      Picture         =   "LCD Clock.frx":6B32
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   8
      Left            =   3750
      Picture         =   "LCD Clock.frx":7360
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Image Image1 
      Height          =   585
      Index           =   9
      Left            =   4110
      Picture         =   "LCD Clock.frx":7B8E
      Top             =   1695
      Visible         =   0   'False
      Width           =   255
   End
End
Attribute VB_Name = "MainFrm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Lastx As Long
Dim Lasty As Long
Dim Saveleft As Long
Dim Savetop As Long
Dim DelayCounter As Long
Dim Amer_Euro As Boolean
Dim TopMost As Boolean
Dim Startup As Boolean
Public ShowAbout As Long

Const LWA_COLORKEY = &H1
Const GWL_EXSTYLE = (-20)
Const WS_EX_LAYERED = &H80000
Const BM_SETSTATE = &HF3

Const HWND_TOPMOST = -1
Const HWND_NOTOPMOST = -2
Const SWP_NOSIZE = &H1
Const SWP_NOMOVE = &H2
Const SWP_NOACTIVATE = &H10
Const SWP_SHOWWINDOW = &H40

Private Declare Sub SetWindowPos Lib "User32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long)
Private Declare Function GetWindowLong Lib "User32" Alias "GetWindowLongA" (ByVal hWnd As Long, ByVal nIndex As Long) As Long
Private Declare Function SetWindowLong Lib "User32" Alias "SetWindowLongA" (ByVal hWnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Private Declare Function ReleaseCapture Lib "user32.dll" () As Long
Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function SetLayeredWindowAttributes Lib "user32.dll" (ByVal hWnd As Long, ByVal crKey As Long, ByVal bAlpha As Byte, ByVal dwFlags As Long) As Long

Private Sub Form_Load()
  Dim Ret As Long
  Dim CLR As Long
  CLR = RGB(255, 255, 255) 'this color is the color that will be transparent
  'Set the window style to 'Layered'
  Ret = GetWindowLong(Me.hWnd, GWL_EXSTYLE)
  Ret = Ret Or WS_EX_LAYERED
  SetWindowLong Me.hWnd, GWL_EXSTYLE, Ret
  'Set the opacity of the layered window to 128
  SetLayeredWindowAttributes Me.hWnd, CLR, 0, LWA_COLORKEY
  'Load Settings from registery
  LoadSettings
  'Set these settings
  Me.Left = Saveleft
  Me.Top = Savetop
  SetTopMost
  SetStartUp
  AboutFrm.Check1.Value = ShowAbout
  If ShowAbout Then AboutFrm.Show
End Sub
Private Sub Image2_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
  Select Case Index
    Case 14
      Startup = Not Startup
      SetStartUp
    Case 15
      TopMost = Not TopMost
      SetTopMost
      SaveSettings
    Case 16
      Lastx = X
      Lasty = Y
    Case 17
      Amer_Euro = Not Amer_Euro
      SaveSettings
    Case 18
      AboutFrm.Show
    Case 19
      Me.Hide
      DelayCounter = 0
      Timer2.Interval = 100
    Case 20
      End
  End Select
End Sub
Private Sub Image2_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
  Select Case Index
    Case 16
      If Button = 1 Then
        Me.Left = Me.Left + (X - Lastx)
        Me.Top = Me.Top + (Y - Lasty)
      End If
  End Select
End Sub
Private Sub Image2_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
  SaveSettings
End Sub
Private Sub Timer1_Timer()
  Image2(0) = Image1(Mid$(Time$, 1, 1))
  Image2(1) = Image1(Mid$(Time$, 2, 1))
  Image2(2) = Image1(Mid$(Time$, 4, 1))
  Image2(3) = Image1(Mid$(Time$, 5, 1))
  Image2(4) = Image1(Mid$(Time$, 7, 1))
  Image2(5) = Image1(Mid$(Time$, 8, 1))
  If Amer_Euro Then
    Image2(6) = Image1(Mid$(Date$, 1, 1))
    Image2(6).ToolTipText = "Month"
    Image2(7) = Image1(Mid$(Date$, 2, 1))
    Image2(7).ToolTipText = "Month"
    Image2(8) = Image1(Mid$(Date$, 4, 1))
    Image2(8).ToolTipText = "Day"
    Image2(9) = Image1(Mid$(Date$, 5, 1))
    Image2(9).ToolTipText = "Day"
  Else
    Image2(8) = Image1(Mid$(Date$, 1, 1))
    Image2(8).ToolTipText = "Month"
    Image2(9) = Image1(Mid$(Date$, 2, 1))
    Image2(9).ToolTipText = "Month"
    Image2(6) = Image1(Mid$(Date$, 4, 1))
    Image2(6).ToolTipText = "Day"
    Image2(7) = Image1(Mid$(Date$, 5, 1))
    Image2(7).ToolTipText = "Day"
  End If
  Image2(10) = Image1(Mid$(Date$, 7, 1))
  Image2(11) = Image1(Mid$(Date$, 8, 1))
  Image2(12) = Image1(Mid$(Date$, 9, 1))
  Image2(13) = Image1(Mid$(Date$, 10, 1))
End Sub
Private Sub SetStartUp()
  If (Startup) Then
    Image2(14).ToolTipText = "Run Manually"
    SaveString HKEY_LOCAL_MACHINE, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "LCD Clock", App.Path & "\" & App.EXEName & ".exe"
    SaveSettings
  Else
    Image2(14).ToolTipText = "Run When Windows Starts Up"
    SaveString HKEY_LOCAL_MACHINE, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "LCD Clock", "<NonRun>"
    SaveSettings
  End If
End Sub
Private Sub SetTopMost()
  If TopMost Then
    SetWindowPos Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE
    Image2(15).ToolTipText = "Make Not Always On Top"
  Else
    SetWindowPos Me.hWnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE
    Image2(15).ToolTipText = "Make Always On Top"
  End If
End Sub
Private Sub LoadSettings()
  Saveleft = GetSetting("LCD Clock", "Settings", "Left", 0)
  Savetop = GetSetting("LCD Clock", "Settings", "Top", 0)
  Amer_Euro = GetSetting("LCD Clock", "Settings", "AmerEuro", True)
  TopMost = GetSetting("LCD Clock", "Settings", "TopMost", True)
  Startup = GetSetting("LCD Clock", "Settings", "Startup", False)
  ShowAbout = GetSetting("LCD Clock", "Settings", "ShowAbout", 1)
End Sub
Public Sub SaveSettings()
  Call SaveSetting("LCD Clock", "Settings", "Left", Me.Left)
  Call SaveSetting("LCD Clock", "Settings", "Top", Me.Top)
  Call SaveSetting("LCD Clock", "Settings", "AmerEuro", Amer_Euro)
  Call SaveSetting("LCD Clock", "Settings", "TopMost", TopMost)
  Call SaveSetting("LCD Clock", "Settings", "Startup", Startup)
  Call SaveSetting("LCD Clock", "Settings", "ShowAbout", ShowAbout)
End Sub
Private Sub Timer2_Timer()
  DelayCounter = DelayCounter + 1
  If DelayCounter >= 100 Then
     Me.Show
     Timer2.Interval = 0
  End If
End Sub

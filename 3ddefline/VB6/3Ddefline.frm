VERSION 5.00
Object = "{0E59F1D2-1FBE-11D0-8FF2-00A0D10038BC}#1.0#0"; "msscript.ocx"
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00000000&
   Caption         =   "3D Graphics"
   ClientHeight    =   8670
   ClientLeft      =   60
   ClientTop       =   630
   ClientWidth     =   10770
   Icon            =   "3Ddefline.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   8670
   ScaleWidth      =   10770
   Begin MSScriptControlCtl.ScriptControl ScriptControl 
      Left            =   5040
      Top             =   4080
      _ExtentX        =   1005
      _ExtentY        =   1005
      AllowUI         =   -1  'True
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   4238
      Picture         =   "3Ddefline.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "Move to the Left"
      Top             =   7680
      Width           =   855
   End
   Begin VB.TextBox txtFunction 
      Height          =   330
      Left            =   4545
      TabIndex        =   0
      Text            =   "sin (x) * sin(y)"
      ToolTipText     =   "Write here the function"
      Top             =   0
      Width           =   2160
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   8
      Left            =   5678
      Picture         =   "3Ddefline.frx":05E7
      Style           =   1  'Graphical
      TabIndex        =   9
      ToolTipText     =   "Rotate to the Right"
      Top             =   8160
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   6
      Left            =   6518
      Picture         =   "3Ddefline.frx":0A89
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "Tight axis"
      Top             =   7680
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   10
      Left            =   6518
      Picture         =   "3Ddefline.frx":0EB8
      Style           =   1  'Graphical
      TabIndex        =   10
      ToolTipText     =   "Zoom Out"
      Top             =   8160
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Index           =   4
      Left            =   5078
      Picture         =   "3Ddefline.frx":1305
      Style           =   1  'Graphical
      TabIndex        =   8
      ToolTipText     =   "Move Down"
      Top             =   7920
      Width           =   615
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   7
      Left            =   4238
      Picture         =   "3Ddefline.frx":1629
      Style           =   1  'Graphical
      TabIndex        =   7
      ToolTipText     =   "Rotate to the Left"
      Top             =   8160
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   5678
      Picture         =   "3Ddefline.frx":1AE1
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "Move to the Right"
      Top             =   7680
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   3398
      Picture         =   "3Ddefline.frx":1DC1
      Style           =   1  'Graphical
      TabIndex        =   1
      ToolTipText     =   "Expand axis"
      Top             =   7680
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   9
      Left            =   3398
      Picture         =   "3Ddefline.frx":219B
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "Zoom In"
      Top             =   8160
      Width           =   855
   End
   Begin VB.CommandButton cmdControls 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Index           =   3
      Left            =   5078
      Picture         =   "3Ddefline.frx":25F9
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "Move Up"
      Top             =   7200
      Width           =   615
   End
   Begin VB.Label lblFunction 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00000000&
      Caption         =   "Z ( X , Y ) ="
      ForeColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   3600
      TabIndex        =   11
      Top             =   45
      Width           =   915
   End
   Begin VB.Menu mnuGeneral 
      Caption         =   "General"
      Begin VB.Menu mnuRisolution 
         Caption         =   "&Risolution"
         Begin VB.Menu mnuChangeRisolution 
            Caption         =   "Pluss"
            Index           =   1
            Shortcut        =   ^P
         End
         Begin VB.Menu mnuChangeRisolution 
            Caption         =   "Less"
            Index           =   2
            Shortcut        =   ^L
         End
      End
      Begin VB.Menu mnuPoint 
         Caption         =   "&Point"
         Begin VB.Menu mnuSetPoint 
            Caption         =   "Put"
            Index           =   1
         End
         Begin VB.Menu mnuSetPoint 
            Caption         =   "Evaluate"
            Index           =   2
         End
      End
      Begin VB.Menu mnuViewFrom 
         Caption         =   "&View from .."
         Begin VB.Menu mnuChangeView 
            Caption         =   "Front"
            Index           =   1
            Shortcut        =   ^F
         End
         Begin VB.Menu mnuChangeView 
            Caption         =   "Right"
            Index           =   2
            Shortcut        =   ^R
         End
         Begin VB.Menu mnuChangeView 
            Caption         =   "Reinitialize"
            Index           =   3
         End
      End
      Begin VB.Menu mnuPlane 
         Caption         =   "P&lane"
         Begin VB.Menu mnuDrawPlane 
            Caption         =   "XY"
            Index           =   1
         End
         Begin VB.Menu mnuDrawPlane 
            Caption         =   "ZX"
            Index           =   2
         End
         Begin VB.Menu mnuDrawPlane 
            Caption         =   "ZY"
            Index           =   3
         End
      End
      Begin VB.Menu mnuInterval 
         Caption         =   "&Interval"
      End
      Begin VB.Menu mnuRefresh 
         Caption         =   "R&efresh"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim dx, dy, lx, j, rs, rsbase As Integer
Dim p, xmx, ymx, xc, yc, y, xj, yj, zj, xx, yy, zz As Single
Dim xpj, ypj, xp1j, yp1j, a, b, cosa, sina, cosp, sinp, x, z, zl, xp, xpl, yp, ypl As Double
Dim xl, yl, xlx, yly, xl1, yl1, xlx1, yly1, ycosa, ysina, ycosp, ysinp, xp1, yp1 As Double
'math constants
Const e# = 2.718281828
Const pg# = 3.14159265358979
'******************************************************************************
'*     Name: 3Ddefline (compiled on Visual Basic 6)                           *
'*  Version: 1.0 (4 June 2002)                                                *
'*  Project: 3Ddefline.vbp (Visual Basic Project)                             *
'*           3Ddefline.frm (Visual Basic Form)                                *
'*           3ddefline.exe (Exe file)                                         *
'*  Purpose: This program allow you to study the 3D functions of the          *
'*           type z = f(x,y); the draw can be rotated and moved.              *
'*           You can also draw some section plans, increase the drawing       *
'*           precision and expand or decrease the function area.              *
'*     Type: Freeware (if you use this code or part of this, please           *
'*           mention the author: this is the only restriction)                *
'*   Author: Picinotti Duccio (Duke)                                          *
'*           Loc.Poggio di Sopra, 23 Subbiano (AR) Italy                      *
'*           If you want some explanation of this code please contact me at:  *
'*   E-mail: picinotti.duccio@tin.it                                          *
'* Homepage: http://www.catenaia.cjb.net                                      *
'******************************************************************************
Public Sub AddFunction()
  'add function defined in the TextBox to the VBcode with the MS ScriptControl
  Dim strFunction As String
  strFunction = "Function f(x, y)" & vbCrLf & _
                "  f = " & txtFunction & vbCrLf & _
                "End Function"
  ScriptControl.AddCode strFunction
End Sub
Private Sub Axis()
  'draw the 3D Axis in the Form
  'ymx = scale the height of the Form
  ymx = (3 / 4) * xmx
  '(xc,yc) = center of the form
  xc = xmx / 2 + dx
  yc = ymx / 2 + dy
  'scale the form from (xmx,ymx)=upperleft corner to (0,0)=downright corner
  Scale (xmx, ymx)-(0, 0)
  'define some value used forward
  cosa = Cos(a): sina = Sin(a)
  cosp = Cos(b - a): sinp = Sin(b - a)
  'cancel the Form
  Cls
  'draw the 3D-axis
  Line (xc, yc)-(xc, ymx), QBColor(12)
  Line (xc, yc)-(xc - xmx * cosa, yc - xmx * sina), QBColor(12)
  Line (xc, yc)-(xc + xmx * cosp, yc - xmx * sinp), QBColor(12)
  'set the color of the axis label
  ForeColor = QBColor(15)
  'print the axis label near the axis
  For j = 1 To ymx
    PSet (xc - j * cosa, yc - j * sina), QBColor(9)
    Print j
    PSet (xc + j * cosp, yc - j * sinp), QBColor(9)
    Print j
    PSet (xc, yc + j), QBColor(9)
    Print j
  Next j
  'print in the upperleft corner the angles from the axis
  CurrentX = xmx
  CurrentY = ymx
  Print "a="; Int((a * 180) / pg); "°"
  CurrentX = xmx
  CurrentY = ymx - (xmx / 32)
  Print "b="; Int(180 - ((b * 180) / pg)); "°"
  DrawFunction
End Sub
Private Sub DrawFunction()
  'draw the function in the Form
  On Error GoTo Errore:
  Dim x, y As Single
  'p = precision, distance from two lines
  p = lx / rs
  'draw the iso-level lines: it draws line from the previous point to the
  'point evaluated at the moment
  'it use ScriptControl.Run for evaluate the function added before
  For y = -lx To lx Step 0.5
    ycosp = xc + y * cosp
    ycosa = xc - y * cosa
    ysinp = yc - y * sinp
    ysina = yc - y * sina
    For x = -lx To lx Step p
      xp = -x * cosa + ycosp
      xp1 = -(x + p) * cosa + ycosp
      yp = -x * sina + ysinp + ScriptControl.Run("f", x, y)
      yp1 = -(x + p) * sina + ysinp + ScriptControl.Run("f", x + p, y)
      xl = ycosa + x * cosp
      xl1 = ycosa + (x + p) * cosp
      yl = ysina - x * sinp + ScriptControl.Run("f", y, x)
      yl1 = ysina - (x + p) * sinp + ScriptControl.Run("f", y, x + p)
      'draw line from the previous point to the point evaluated now
      Line (xp, yp)-(xp1, yp1), QBColor(10)
      Line (xl, yl)-(xl1, yl1), QBColor(10)
    Next x
  Next y
  Exit Sub
Errore:
  'if there is an error evaluating the function (as a division by 0)...
  Resume Next
End Sub
Private Sub mnuInterval_Click()
  'increase or decrease the drawing interval
  lx = InputBox("lx < (x,y) < lx", "Drawing interval", "1", 3000, 1000)
  Axis
End Sub
Private Sub cmdControls_Click(Index As Integer)
  'control the drawing view
  Select Case Index
    Case 1
      'move to the Left
      dx = dx - xmx / 8
    Case 2
      'move to the Right
      dx = dx + xmx / 8
    Case 3
      'move up
      dy = dy - xmx / 8
    Case 4
      'move down
      dy = dy + xmx / 8
    Case 5
      'expand the angle between the X-axis an Y-axis
      b = b - pg / 12
    Case 6
      'tight the angle between the X-axis an Y-axis
      b = b + pg / 12
    Case 7
      'rotate to the Left
      a = a - pg / 12
    Case 8
      'rotate to the Right
      a = a + pg / 12
    Case 9
      'zoom In
      xmx = xmx / 1.5
    Case 10
      'zoom Out
      xmx = xmx * 1.5
  End Select
  'restore normal resolution
  rs = rsbase
  'draw Axis
  Axis
End Sub
Private Sub Form_Load()
  'initialize variables
  'xmx = scale the Width of the Form
  xmx = 16
  'a = angle (in degrees) from the Horizontal line to the X-axis
  a = 30
  'angle in radiants
  a = (a * pg) / 180
  'b = 180° - [angle (in degrees) from the X-axis to the Y-axis]
  b = 60
  'angle in radiants
  b = (b * pg) / 180
  'lx = interval of the drawing
  lx = 4
  'rs = resolution of drawing
  rs = 100
  'rsbase = normal resolution of drawing
  rsbase = 20
  'write the function specificated in the TextBox with MS ScriptControl
  AddFunction
End Sub
Private Sub Form_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
  'show the Popup menù when the right mouse button is clicked
  If Button = 2 Then PopupMenu mnuGeneral, 4
End Sub
Private Sub Form_Resize()
  'located the controls in the Form
  Dim i As Integer
  'rescale the form to the initial value to locate controls
  Scale
  'center all controls in the Form
  lblFunction.Left = (Me.ScaleWidth - (txtFunction.Width + lblFunction.Width)) / 2
  txtFunction.Left = lblFunction.Left + lblFunction.Width
  cmdControls(4).Left = (Me.ScaleWidth - cmdControls(4).Width) / 2
  cmdControls(3).Left = cmdControls(4).Left
  cmdControls(7).Left = cmdControls(4).Left - cmdControls(7).Width
  cmdControls(1).Left = cmdControls(7).Left
  cmdControls(8).Left = cmdControls(4).Left + cmdControls(4).Width
  cmdControls(2).Left = cmdControls(8).Left
  cmdControls(9).Left = cmdControls(7).Left - cmdControls(9).Width
  cmdControls(5).Left = cmdControls(9).Left
  cmdControls(10).Left = cmdControls(8).Left + cmdControls(8).Width
  cmdControls(6).Left = cmdControls(10).Left
  'locate all controls to the down of the Form
  cmdControls(4).Top = Me.ScaleHeight - cmdControls(4).Height
  cmdControls(3).Top = cmdControls(4).Top - cmdControls(3).Height
  For i = 1 To 10
    Select Case i
      Case 7, 8, 9, 10: cmdControls(i).Top = Me.ScaleHeight - cmdControls(9).Height
      Case 1, 2, 5, 6: cmdControls(i).Top = Me.ScaleHeight - 2 * cmdControls(9).Height
    End Select
  Next i
  'draw Axis
  Axis
End Sub
Private Sub Form_Unload(Cancel As Integer)
  'end the application
  Unload Me
End Sub
Private Sub mnuChangeRisolution_Click(Index As Integer)
  'increase or decrease drawing resolution
  If Index = 1 Then
    'increase the resolution if it isn't so big (rs=500)
    If rs < 500 Then rs = rs * 2
  Else
    'decrease the resolution if it isn't so small (rs=10)
    If rs > 10 Then rs = rs / 2
  End If
  Axis
End Sub
Private Sub mnuDrawPlane_Click(Index As Integer)
  'draw some reference planes
  Select Case Index
    Case 1
      'draw a XY plane
      zz = InputBox("Z=", "Plane XY", "0", 3000, 2000)
      For y = -lx To lx Step 0.5
        xl = xc + y * cosp + lx * cosa
        xl1 = xl - 2 * lx * cosa
        xlx = xc - y * cosa - lx * cosp
        xlx1 = xlx + 2 * lx * cosp
        yl = yc - y * sinp + zz + lx * sina
        yl1 = yl - 2 * lx * sina
        yly = yc - y * sina + zz + lx * sinp
        yly1 = yly - 2 * lx * sinp
        Line (xl, yl)-(xl1, yl1), QBColor(13)
        Line (xlx, yly)-(xlx1, yly1), QBColor(13)
      Next y
    Case 2
      'draw a ZX plane
      yy = InputBox("Y=", "Plane ZX", "0", 3000, 2000)
      For j = lx To -lx Step -0.5
        xl = xc - yy * cosa + j * cosp
        yl = yc - yy * sina - j * sinp + lx
        yl1 = yl - 2 * lx
        Line (xl, yl)-(xl, yl1), QBColor(13)
      Next j
    Case 3
      'draw a ZY plane
      xx = InputBox("X=", "Plane ZY", "0", 3000, 2000)
      xl = xc - lx * cosa + xx * cosp
      xl1 = xl + 2 * lx * cosa
      For z = lx To -lx Step -0.5
        yl = yc - lx * sina - xx * sinp + z
        yl1 = yl + 2 * lx * sina
        Line (xl, yl)-(xl1, yl1), QBColor(13)
      Next z
      For y = lx To -lx Step -0.5
        xl = xc - y * cosa + xx * cosp
        xl1 = xl
        yl = yc - y * sina + xx * sinp + lx
        yl1 = yl - 2 * lx
        Line (xl, yl)-(xl1, yl1), QBColor(13)
      Next y
  End Select
End Sub
Private Sub mnuSetPoint_Click(Index As Integer)
  'draw or evaluate a point of the function
  On Error GoTo Errors:
  If Index = 1 Then
    'draw a point in the Form
    xj = InputBox("X=", "Draw point", "0", 3000, 1000)
    yj = InputBox("Y=", "Draw point", "0", 3000, 1000)
    zj = InputBox("Z=", "Draw point", "0", 3000, 1000)
    xpj = xc - yj * cosa
    xp1j = xpj + xj * cosp
    ypj = yc - yj * sina
    yp1j = ypj - xj * sinp
    Line (xpj, ypj)-(xp1j, yp1j), QBColor(11)
    Line (xp1j, yp1j)-(xp1j, yp1j + zj), QBColor(11)
  Else
    'evaluate a point of function
    xj = InputBox("X=", "Evaluate point", "0", 3000, 1000)
    yj = InputBox("Y=", "Evaluate point", "0", 3000, 1000)
    zj = ScriptControl.Run("f", xj, yj)
    MsgBox "Z(" & xj & "," & yj & ")=" & zj, , "Evaluate point"
  End If
  Exit Sub
Errors:
  'if the function causes a error (as a division by 0....)
  MsgBox "Evaluating error", 0, "Attention!"
End Sub
Private Sub mnuRefresh_Click()
  'refresh the draw
  Axis
End Sub
Private Sub mnuChangeView_Click(Index As Integer)
  'change the view of draw: from Left, Right...
  Select Case Index
    Case 1
      'view from Left
      a = pg
      b = pg
    Case 2
      'view from Right
      a = 0
      b = pg
    Case 3
      'restore the initial view
      dx = 0
      dy = 0
      Form_Load
  End Select
  'draw Axis
  Axis
End Sub
Private Sub txtFunction_GotFocus()
  'select the text in the TextBox when it receives the focus
  txtFunction.SelStart = 0
  txtFunction.SelLength = Len(txtFunction)
End Sub
Private Sub txtFunction_KeyPress(KeyAscii As Integer)
  'draw the function if "Enter" is pressed in the TextBox
  If KeyAscii = 13 Then
    AddFunction
    Axis
  End If
End Sub

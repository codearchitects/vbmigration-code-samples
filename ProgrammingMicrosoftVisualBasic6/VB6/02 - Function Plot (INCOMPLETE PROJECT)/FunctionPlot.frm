VERSION 5.00
Object = "{0E59F1D2-1FBE-11D0-8FF2-00A0D10038BC}#1.0#0"; "MSSCRIPT.OCX"
Begin VB.Form Form1 
   Caption         =   "Custom Graphic Scale Demo"
   ClientHeight    =   4620
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8550
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4620
   ScaleWidth      =   8550
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdFunction 
      Caption         =   "Set Function"
      Height          =   495
      Left            =   6720
      TabIndex        =   0
      Top             =   3840
      Width           =   1575
   End
   Begin MSScriptControlCtl.ScriptControl ScriptControl1 
      Left            =   600
      Top             =   3240
      _ExtentX        =   1005
      _ExtentY        =   1005
      AllowUI         =   -1  'True
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Fun As New frmFunction

Private Sub Form_Resize()
    ' set a custom graphic coordinate system, so that
    ' the visible viewport corresponds to constants above
    ScaleLeft = Fun.XMin
    ScaleTop = Fun.YMax
    ScaleWidth = Fun.XMax - Fun.XMin
    ScaleHeight = -(Fun.YMax - Fun.YMin)
    ' force a Paint event
    Refresh
End Sub

Private Sub Form_Paint()
    Dim X As Single, Y As Single
        
    ' start with a blank canvas
    Cls
    ForeColor = vbBlack
    
    ' explain what is being displayed
    CurrentX = ScaleLeft
    CurrentY = ScaleTop
    Print Fun.FunctionText
    CurrentX = ScaleLeft
    Print "X-interval: [" & Fun.XMin & "," & Fun.XMax & "]"
    CurrentX = ScaleLeft
    Print "Y-range: [" & Fun.YMin & "," & Fun.YMax & "]"
    
    ' draw X and Y axis
    Line (Fun.XMin, 0)-(Fun.XMax, 0)
    Line (0, Fun.YMin)-(0, Fun.YMax)
    
    ' plot a math function
    ForeColor = vbRed
    For X = Fun.XMin To Fun.XMax Step Fun.XStep
        Y = ScriptControl1.Run("Y", X)
        PSet (X, Y)
    Next
    
End Sub

Private Sub cmdFunction_Click()
    Fun.Show vbModal
    
    With ScriptControl1
        .Reset
        .Language = "VBScript"
        .AddCode "Function Y(x)" & vbCrLf _
            & Fun.FunctionText & vbCrLf _
            & "End Function"
    End With
            
    
    
End Sub



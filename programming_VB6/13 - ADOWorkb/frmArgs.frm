VERSION 5.00
Begin VB.Form frmArguments 
   Caption         =   "Get Arguments"
   ClientHeight    =   4305
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6555
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
   ScaleHeight     =   4305
   ScaleWidth      =   6555
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3840
      TabIndex        =   16
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdRun 
      Caption         =   "&Run"
      Default         =   -1  'True
      Height          =   375
      Left            =   2040
      TabIndex        =   15
      Top             =   3840
      Width           =   1215
   End
   Begin VB.CheckBox chkMissing 
      Caption         =   "Missing"
      Height          =   240
      Index           =   4
      Left            =   2040
      TabIndex        =   14
      Top             =   3000
      Width           =   2655
   End
   Begin VB.TextBox txtArgument 
      Height          =   375
      Index           =   4
      Left            =   2040
      TabIndex        =   13
      Top             =   3240
      Width           =   4335
   End
   Begin VB.CheckBox chkMissing 
      Caption         =   "Missing"
      Height          =   240
      Index           =   3
      Left            =   2040
      TabIndex        =   11
      Top             =   2280
      Width           =   2655
   End
   Begin VB.TextBox txtArgument 
      Height          =   375
      Index           =   3
      Left            =   2040
      TabIndex        =   10
      Top             =   2520
      Width           =   4335
   End
   Begin VB.CheckBox chkMissing 
      Caption         =   "Missing"
      Height          =   240
      Index           =   2
      Left            =   2040
      TabIndex        =   8
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txtArgument 
      Height          =   375
      Index           =   2
      Left            =   2040
      TabIndex        =   7
      Top             =   1800
      Width           =   4335
   End
   Begin VB.CheckBox chkMissing 
      Caption         =   "Missing"
      Height          =   240
      Index           =   1
      Left            =   2040
      TabIndex        =   5
      Top             =   840
      Width           =   2655
   End
   Begin VB.TextBox txtArgument 
      Height          =   375
      Index           =   1
      Left            =   2040
      TabIndex        =   4
      Top             =   1080
      Width           =   4335
   End
   Begin VB.CheckBox chkMissing 
      Caption         =   "Missing"
      Height          =   240
      Index           =   0
      Left            =   2040
      TabIndex        =   2
      Top             =   120
      Width           =   2655
   End
   Begin VB.TextBox txtArgument 
      Height          =   375
      Index           =   0
      Left            =   2040
      TabIndex        =   1
      Top             =   360
      Width           =   4335
   End
   Begin VB.Label lblArgName 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Arg1"
      Height          =   375
      Index           =   4
      Left            =   120
      TabIndex        =   12
      Top             =   3240
      Width           =   1935
   End
   Begin VB.Label lblArgName 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Arg1"
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   9
      Top             =   2520
      Width           =   1935
   End
   Begin VB.Label lblArgName 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Arg1"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   6
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Label lblArgName 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Arg1"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   3
      Top             =   1080
      Width           =   1935
   End
   Begin VB.Label lblArgName 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Arg1"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   1935
   End
End
Attribute VB_Name = "frmArguments"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private ArgInfo(5) As Variant
Private ArgCount As Integer

Private RunPressed As Boolean

' Display the dialog, return True if RUN button is clicked.
' Values of arguments are returned in the args() array.
' Expects the name of values - if an argument name is preceded
' by a "@" character, it is considered as an optional argument
' Fields are initialized with the values in args()

Function GetArgValues(MethodName As String, args() As Variant, ParamArray argNames() As Variant) As Boolean
    Dim index As Integer, ArgCount As Integer
    
    ArgCount = UBound(argNames)
    
    For index = 0 To ArgCount
        If Left$(argNames(index), 1) = "@" Then
            lblArgName(index) = Mid$(argNames(index), 2)
            chkMissing(index) = vbChecked
            txtArgument(index).Enabled = False
            txtArgument(index).BackColor = vbInactiveBorder
        Else
            lblArgName(index) = argNames(index)
            chkMissing(index).Visible = False
        End If
        If Not IsEmpty(args(index)) Then
            txtArgument(index) = args(index)
        End If
    Next
    
    If ArgCount < lblArgName.UBound Then
    
        For index = ArgCount + 1 To lblArgName.UBound
            lblArgName(index).Visible = False
            txtArgument(index).Visible = False
            chkMissing(index).Visible = False
        Next
    
        cmdRun.Top = lblArgName(ArgCount + 1).Top
        cmdCancel.Top = lblArgName(ArgCount + 1).Top
        Me.Height = cmdRun.Top + cmdRun.Height + 600
    End If
    
    If Len(MethodName) Then
        Caption = Caption & " - " & MethodName
    End If
       
    Me.Show vbModal
    
    If RunPressed Then
        For index = 0 To ArgCount
            If chkMissing(index) = vbUnchecked Then
                args(index) = txtArgument(index).Text
            Else
                args(index) = IsMissingValue
            End If
        Next
        ' return True to indicate that RUN was clicked
        GetArgValues = True
    End If
    
    Unload Me

End Function

Private Sub chkMissing_Click(index As Integer)
    If chkMissing(index).Value Then
        txtArgument(index).Enabled = False
        txtArgument(index).BackColor = vbInactiveBorder
    Else
        txtArgument(index).Enabled = True
        txtArgument(index).BackColor = vbWindowBackground
    End If
End Sub

Private Sub cmdCancel_Click()
    Hide
End Sub

Private Sub cmdRun_Click()
    RunPressed = True
    Hide
End Sub

Private Function IsMissingValue(Optional dontPassThis As Variant) As Variant
    IsMissingValue = dontPassThis
End Function



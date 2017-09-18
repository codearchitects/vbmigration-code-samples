VERSION 5.00
Begin VB.Form frmCalcu 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calculator"
   ClientHeight    =   3630
   ClientLeft      =   150
   ClientTop       =   435
   ClientWidth     =   3840
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3630
   ScaleWidth      =   3840
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdCancel 
      Caption         =   "CE"
      Height          =   495
      Index           =   2
      Left            =   1800
      TabIndex        =   27
      Top             =   600
      Width           =   855
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "C"
      Height          =   495
      Index           =   1
      Left            =   2760
      TabIndex        =   26
      Top             =   600
      Width           =   855
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Back"
      Height          =   495
      Index           =   0
      Left            =   720
      TabIndex        =   25
      Top             =   600
      Width           =   975
   End
   Begin VB.CommandButton cmdEqual 
      Caption         =   "="
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3120
      TabIndex        =   0
      Top             =   3000
      Width           =   495
   End
   Begin VB.CommandButton cmdFunction 
      Caption         =   "Sqrt"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   3120
      TabIndex        =   24
      Top             =   1200
      Width           =   495
   End
   Begin VB.CommandButton cmdFunction 
      Caption         =   "%"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   3120
      TabIndex        =   23
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton cmdFunction 
      Caption         =   "1/X"
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
      Left            =   3120
      TabIndex        =   22
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton cmdFunction 
      Caption         =   "+/-"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   1920
      TabIndex        =   21
      Top             =   3000
      Width           =   495
   End
   Begin VB.CommandButton cmdDot 
      Caption         =   "."
      BeginProperty Font 
         Name            =   "System"
         Size            =   19.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1320
      TabIndex        =   20
      Top             =   3000
      Width           =   495
   End
   Begin VB.CommandButton cmdMemory 
      Caption         =   "MR"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   120
      TabIndex        =   19
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton cmdMemory 
      Caption         =   "MS"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   120
      TabIndex        =   18
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton cmdMemory 
      Caption         =   "M+"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   120
      TabIndex        =   17
      Top             =   3000
      Width           =   495
   End
   Begin VB.CommandButton cmdMemory 
      Caption         =   "MC"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   120
      TabIndex        =   16
      Top             =   1200
      Width           =   495
   End
   Begin VB.TextBox txtDisplay 
      Alignment       =   1  'Right Justify
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
      Left            =   120
      Locked          =   -1  'True
      TabIndex        =   15
      Text            =   "0"
      Top             =   120
      Width           =   3495
   End
   Begin VB.CommandButton operator 
      Caption         =   "*"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   2520
      TabIndex        =   14
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton operator 
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   2520
      TabIndex        =   13
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton operator 
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   2520
      TabIndex        =   12
      Top             =   3000
      Width           =   495
   End
   Begin VB.CommandButton operator 
      Caption         =   "/"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   2520
      TabIndex        =   11
      Top             =   1200
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   9
      Left            =   1920
      TabIndex        =   10
      Top             =   1200
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   8
      Left            =   1320
      TabIndex        =   9
      Top             =   1200
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   7
      Left            =   720
      TabIndex        =   8
      Top             =   1200
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   6
      Left            =   1920
      TabIndex        =   7
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   1320
      TabIndex        =   6
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   720
      TabIndex        =   5
      Top             =   1800
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   1920
      TabIndex        =   4
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   1320
      TabIndex        =   3
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   720
      TabIndex        =   2
      Top             =   2400
      Width           =   495
   End
   Begin VB.CommandButton numero 
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   720
      TabIndex        =   1
      Top             =   3000
      Width           =   495
   End
   Begin VB.Label lblMem 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   28
      Top             =   600
      Width           =   495
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "Edit"
      Begin VB.Menu mnuCopy 
         Caption         =   "Copy"
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuPaste 
         Caption         =   "Paste"
         Shortcut        =   ^P
      End
   End
End
Attribute VB_Name = "frmCalcu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim tama As Boolean
Dim firstnum As Double
Dim secondnum As Double
Dim sign As String
Dim memory As Double
Dim memrelease As Boolean

Private Sub cmdCancel_Click(Index As Integer)
Select Case Index
    Case 0
        'if any other button has been click
        'except for the numbers
        'dont do anything
        If tama = True Then Exit Sub
        'make sure that the last number be equal to 0
        If Len(txtDisplay.Text) = 1 Then
            txtDisplay.Text = "0"
            cmdEqual.SetFocus
             Exit Sub
        End If
        'erase the last inputed number
        On Error Resume Next
       txtDisplay.Text = Mid(txtDisplay.Text, 1, Len(txtDisplay.Text) - 1)
       cmdEqual.SetFocus
    Case 1
    'make firstnum and secondnum equal to 0
    'so that every operation will be equal to 0
        firstnum = 0
        secondnum = 0
        txtDisplay.Text = "0"
        cmdEqual.SetFocus
    Case 2
    'clear display and set text to 0
        txtDisplay.Text = "0"
        cmdEqual.SetFocus
End Select
cmdEqual.SetFocus


End Sub

Private Sub cmdDot_Click()

'determine if period is already present
If tama = False Then 'equal sign was not click
    'already present exit
    If InStr(txtDisplay.Text, ".") Then
    cmdEqual.SetFocus
    Exit Sub
    End If
    'not present append
    cmdEqual.SetFocus
    txtDisplay.Text = txtDisplay.Text + cmdDot.Caption
ElseIf tama = True Then 'equal sign was click
    txtDisplay.Text = "0."
    tama = False
    cmdEqual.SetFocus
End If
cmdEqual.SetFocus
End Sub

Private Sub cmdEqual_Click()
Dim answer As Double
secondnum = Val(txtDisplay.Text) 'store the second variable
On Error GoTo errhandler
'perform operation
If sign = "+" Then answer = firstnum + secondnum
If sign = "-" Then answer = firstnum - secondnum
If sign = "*" Then answer = firstnum * secondnum
If sign = "/" And secondnum <> 0 Then answer = firstnum / secondnum
txtDisplay.Text = answer
tama = True
firstnum = answer
Exit Sub
errhandler:
txtDisplay.Text = "Error"
MsgBox Err.Description, vbCritical, "Operation Aborted"
tama = True
End Sub

Private Sub cmdEqual_KeyPress(KeyAscii As Integer)
'this is for the operator
For x = 0 To 3
    If Chr(KeyAscii) = operator(x).Caption Then
        operator(x).SetFocus
        operator_Click (x)
    End If
Next x

'this is for the period
If Chr(KeyAscii) = "." Then
    cmdDot.SetFocus
    cmdDot_Click
End If

'this is for the numbers
If Left(txtDisplay.Text, 1) = "0" Then
    'if there is already a period
    If InStr(txtDisplay.Text, ".") Then
        'append digits and exit so that
        'it wont append twice
        For i = 48 To 57
            'simulate a press of numbers
            If KeyAscii = i Then 'ascii = 0 to 9
                numero(Chr(KeyAscii)).SetFocus
                numero_Click (Chr(KeyAscii))
                Exit Sub
            End If
        Next
    Else
        'else dont put anything
        txtDisplay.Text = ""
    End If
End If
'simulate a press of numbers
For i = 48 To 57 'ascii = 0 to 9
            If KeyAscii = i Then
                numero(Chr(KeyAscii)).SetFocus
                numero_Click (Chr(KeyAscii))
                Exit Sub
            End If
        Next

'this is for the cancel
If Val(KeyAscii) = &H8 Then
    cmdCancel(0).SetFocus
    cmdCancel_Click (0)
End If


End Sub

Private Sub cmdFunction_Click(Index As Integer)
Select Case Index
    Case 0 'case positve to negative
        txtDisplay.Text = -Val(txtDisplay.Text)
    Case 1 'case 1/x
        If Val(txtDisplay.Text) <> 0 Then _
        txtDisplay.Text = 1 / Val(txtDisplay.Text)
    Case 2 'case percentage
         txtDisplay.Text = firstnum * Val("." & txtDisplay.Text)
    Case 3 ' case squareroot
        If Val(txtDisplay.Text) = 0 Then
            txtDisplay.Text = "Error"
            Exit Sub
        Else
            txtDisplay.Text = Sqr(Val(txtDisplay.Text))
        End If
End Select
End Sub

Private Sub cmdMemory_Click(Index As Integer)
Select Case Index
    Case 0 ' clear memory (MC)
        memory = 0
        lblMem.Caption = ""
    Case 1 ' add number to memory (M+)
        If txtDisplay.Text = "0" Then Exit Sub
        memory = memory + Val(txtDisplay.Text)
        lblMem.Caption = "M"
    Case 2 ' get value of memory (MC)
        If txtDisplay.Text = "0" Then Exit Sub
        'if operator are click release value of memory
        If memrelease = True Then
            lblMem.Caption = ""
            memory = 0
        'if numbers are click get value of memory
        ElseIf memrelease = False Then
            lblMem.Caption = "M"
            memory = txtDisplay.Text
        End If
    Case 3 'get value of memory (MR)
        txtDisplay.Text = memory
End Select
End Sub

Private Sub numero_Click(Index As Integer)
memrelease = False 'toggle the memory
If tama Then 'toggle the answer
    txtDisplay.Text = ""
    tama = False
End If
'determine if the first digit is zero
If Left(txtDisplay.Text, 1) = "0" Then
    'if there is already a period
    If InStr(txtDisplay.Text, ".") Then
        'append digits and exit so that
        'it wont append twice
        txtDisplay.Text = txtDisplay.Text + numero(Index).Caption
        cmdEqual.SetFocus
        Exit Sub
    Else
        'else dont put anything
        txtDisplay.Text = ""
        cmdEqual.SetFocus
    End If
End If
'if first digit is zero
'erase 0 and append digits
    txtDisplay.Text = txtDisplay.Text + numero(Index).Caption
    cmdEqual.SetFocus
End Sub



Private Sub operator_Click(Index As Integer)
memrelease = True 'toggle memory
firstnum = Val(txtDisplay.Text) 'store value txtdisplay.text to variable
'store operations to variable
Select Case Index
    Case 0
        sign = "/"
    Case 1
        sign = "+"
    Case 2
        sign = "-"
    Case 3
        sign = "*"
End Select
tama = True 'toggle answer
cmdEqual.SetFocus
End Sub


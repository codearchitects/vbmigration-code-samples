VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Form1 
   Caption         =   "DateTimePicker Control Demo"
   ClientHeight    =   3510
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7815
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
   ScaleHeight     =   3510
   ScaleWidth      =   7815
   StartUpPosition =   3  'Windows Default
   Begin MSComCtl2.DTPicker DTPicker3 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   1680
      Width           =   3375
      _ExtentX        =   5953
      _ExtentY        =   661
      _Version        =   393216
      CustomFormat    =   "MMM - yyyy"
      Format          =   54067202
      CurrentDate     =   36105.0833333333
   End
   Begin MSComCtl2.DTPicker DTPicker2 
      Height          =   375
      Left            =   4080
      TabIndex        =   1
      Top             =   600
      Width           =   3375
      _ExtentX        =   5953
      _ExtentY        =   661
      _Version        =   393216
      CheckBox        =   -1  'True
      Format          =   54067201
      UpDown          =   -1  'True
      CurrentDate     =   36105
   End
   Begin MSComCtl2.DTPicker DTPicker1 
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   600
      Width           =   3375
      _ExtentX        =   5953
      _ExtentY        =   661
      _Version        =   393216
      Format          =   54067200
      CurrentDate     =   36105
   End
   Begin MSComCtl2.DTPicker DTPicker4 
      Height          =   375
      Left            =   4080
      TabIndex        =   6
      Top             =   1680
      Width           =   3375
      _ExtentX        =   5953
      _ExtentY        =   661
      _Version        =   393216
      CustomFormat    =   "'Date is' dddd MMM d, yyy"
      Format          =   54067203
      CurrentDate     =   36105
   End
   Begin MSComCtl2.DTPicker DTPicker5 
      Height          =   375
      Left            =   360
      TabIndex        =   8
      Top             =   2760
      Width           =   7095
      _ExtentX        =   12515
      _ExtentY        =   661
      _Version        =   393216
      CustomFormat    =   "MMM d, yyy '(week 'XX')' XXX"
      Format          =   54067203
      CurrentDate     =   36105
   End
   Begin VB.Label Label1 
      Caption         =   "DTPicker with a two callback fields"
      Height          =   255
      Index           =   4
      Left            =   360
      TabIndex        =   9
      Top             =   2400
      Width           =   3975
   End
   Begin VB.Label Label1 
      Caption         =   "DTPicker with a time value"
      Height          =   255
      Index           =   3
      Left            =   360
      TabIndex        =   7
      Top             =   1320
      Width           =   3495
   End
   Begin VB.Label Label1 
      Caption         =   "DTPicker with a custom format"
      Height          =   255
      Index           =   2
      Left            =   4080
      TabIndex        =   5
      Top             =   1320
      Width           =   3975
   End
   Begin VB.Label Label1 
      Caption         =   "DTPicker with checkbox and spin buttons"
      Height          =   255
      Index           =   1
      Left            =   4080
      TabIndex        =   4
      Top             =   240
      Width           =   3975
   End
   Begin VB.Label Label1 
      Caption         =   "DTPicker with a drop-down calendar"
      Height          =   255
      Index           =   0
      Left            =   360
      TabIndex        =   3
      Top             =   240
      Width           =   3975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##DefaultMemberSupport False

'## DTPicker1.WriteProperty Format, 0
'## DTPicker2.WriteProperty Format, 1
'## DTPicker3.WriteProperty Format, 2
'## DTPicker4.WriteProperty Format, 3
'## DTPicker5.WriteProperty Format, 3


' Return the maximum size of each callback field.

Private Sub DTPicker5_FormatSize(ByVal CallbackField As String, Size As Integer)
    Select Case CallbackField
        Case "XX"
            ' The number of weeks since January 1st (max 2 digits)
            Size = 2
        Case "XXX"
            ' The name of a holiday, if any
            Size = 12
    End Select
End Sub

Private Sub DTPicker5_Format(ByVal CallbackField As String, FormattedString As String)
    Select Case CallbackField
        Case "XX"
            ' The number of weeks since January 1st (max 3 digits)
            FormattedString = DateDiff("ww", DateSerial(DTPicker5.Year, 1, 1), DTPicker5.Value) + 1
        Case "XXX"
            ' The name of a holiday, if any
            If DTPicker5.Month = 12 And DTPicker5.Day = 25 Then
                FormattedString = "Christmas"
            Else
                ' Deal here with other holidays.
            End If
    End Select
End Sub

' Move to the previous/next week when the Up/Down key is pressed.

Private Sub DTPicker5_CallbackKeyDown(ByVal KeyCode As Integer, ByVal Shift As Integer, ByVal CallbackField As String, CallbackDate As Date)
    If CallbackField = "XX" Then
        If KeyCode = vbKeyUp Then
            CallbackDate = DTPicker5.Value + 7
        ElseIf KeyCode = vbKeyDown Then
            CallbackDate = DTPicker5.Value - 7
        End If
    Else
        ' no keyboard support for the Holiday field
    End If
End Sub





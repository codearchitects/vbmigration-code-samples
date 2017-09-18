VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "ArrayDataSource demo"
   ClientHeight    =   4350
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5460
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
   ScaleHeight     =   4350
   ScaleWidth      =   5460
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdMove 
      Caption         =   "Show Data"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   8
      Left            =   3960
      TabIndex        =   14
      Top             =   3600
      Width           =   1335
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Goto Bookmark"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   7
      Left            =   2040
      TabIndex        =   13
      Top             =   3600
      Width           =   1815
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Set Bookmark"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   6
      Left            =   240
      TabIndex        =   12
      Top             =   3600
      Width           =   1815
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Delete"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   4320
      TabIndex        =   11
      Top             =   2880
      Width           =   975
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Add"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   3360
      TabIndex        =   10
      Top             =   2880
      Width           =   975
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">>"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   2400
      TabIndex        =   9
      Top             =   2880
      Width           =   735
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   1680
      TabIndex        =   8
      Top             =   2880
      Width           =   735
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   960
      TabIndex        =   7
      Top             =   2880
      Width           =   735
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "<<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   240
      TabIndex        =   6
      Top             =   2880
      Width           =   735
   End
   Begin VB.TextBox txtID 
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   480
      Width           =   1215
   End
   Begin VB.TextBox txtDepartment 
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   2160
      Width           =   5055
   End
   Begin VB.TextBox txtName 
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   1320
      Width           =   5055
   End
   Begin VB.Label Label3 
      Caption         =   "&ID"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   2175
   End
   Begin VB.Label Label2 
      Caption         =   "&Department"
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   1920
      Width           =   2175
   End
   Begin VB.Label Label1 
      Caption         =   "&Name"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   1080
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:UseByVal Yes
'##project:DisableMessage 0501


Public MyData As New ArrayDataSource

Dim Bookmark As Variant


Private Sub Form_Load()
    ' Create the Fields array.
    ReDim Fields(0 To 2) As String
    Fields(0) = "ID"
    Fields(1) = "Name"
    Fields(2) = "Department"
    
    ' Create the Values array.
    ReDim Values(0 To 3, 0 To 2) As String
    SetArrayRow Values(), 0, 104, "Christine Johnson", "Marketing"
    SetArrayRow Values(), 1, 101, "John Smith", "Sales"
    SetArrayRow Values(), 2, 102, "Anne Robertson", "Sales"
    SetArrayRow Values(), 3, 103, "Robert Johnson", "Marketing"
    
    MyData.SetArray Values, Fields
    MyData.EOFAction = adsEOFActionAddnew
    
    ' Bind the controls
    Set txtID.DataSource = MyData
    txtID.DataField = "ID"
    Set txtName.DataSource = MyData
    txtName.DataField = "Name"
    Set txtDepartment.DataSource = MyData
    txtDepartment.DataField = "Department"
    
End Sub

Private Sub SetArrayRow(arr As Variant, row As Long, ParamArray Items() As Variant)
    Dim i As Long, j As Long
    For i = LBound(arr, 2) To UBound(arr, 2)
        arr(row, i) = Items(j)
        j = j + 1
    Next
End Sub

Private Sub cmdMove_Click(Index As Integer)
    Select Case Index
        Case 0
            If CheckFields Then MyData.MoveFirst
        Case 1
            If CheckFields Then MyData.MovePrevious
        Case 2
            If CheckFields Then MyData.MoveNext
        Case 3
            If CheckFields Then MyData.MoveLast
        Case 4
            If CheckFields Then MyData.AddNew
        Case 5
            MyData.Delete
        Case 6
            Bookmark = MyData.Bookmark
        Case 7
            If CheckFields Then Me.MyData.Bookmark = Bookmark
        Case 8
            ShowData
    End Select
End Sub

' Returns True if all the fields have been filled.

Function CheckFields() As Boolean
    If MyData.BOF Or MyData.EOF Then
        ' no need to check values in this case
        CheckFields = True
    Else
        CheckFields = (txtID <> "") And (txtName <> "") And (txtDepartment <> "")
        If Not CheckFields Then
            MsgBox "Please fill all the fields", vbExclamation
        End If
    End If
End Function

Private Sub ShowData()
    ReDim Values(0, 0) As String
    Dim row As Long, col As Long, msg As String
    
    Values = MyData.GetArray(True)
    For row = 0 To UBound(Values)
        For col = 0 To UBound(Values, 2)
            msg = msg & Values(row, col) & ","
        Next
        ' Drop trailing comma, add a carriage return.
        msg = Left$(msg, Len(msg) - 1) & vbCrLf
    Next
    
    MsgBox msg
End Sub

VERSION 5.00
Begin VB.Form Form8 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Option"
   ClientHeight    =   4530
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4350
   Icon            =   "Form8.frx":0000
   LinkTopic       =   "Form8"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   4530
   ScaleWidth      =   4350
   Begin VB.CommandButton Command3 
      Caption         =   "&Reset"
      Height          =   350
      Left            =   120
      TabIndex        =   7
      Top             =   4080
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Search Option"
      Height          =   3855
      Left            =   120
      TabIndex        =   10
      Top             =   120
      Width           =   4095
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   240
         TabIndex        =   6
         Top             =   3360
         Width           =   3615
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   240
         TabIndex        =   5
         Top             =   2760
         Width           =   3615
      End
      Begin VB.CheckBox Check5 
         Caption         =   "Show Old Student"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   2040
         Width           =   2775
      End
      Begin VB.CheckBox Check4 
         Caption         =   "Show New Student"
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Top             =   1680
         Width           =   2775
      End
      Begin VB.CheckBox Check3 
         Caption         =   "Show Female Student"
         Height          =   375
         Left            =   240
         TabIndex        =   1
         Top             =   840
         Width           =   2775
      End
      Begin VB.CheckBox Check2 
         Caption         =   "Show Male Student"
         Height          =   375
         Left            =   240
         TabIndex        =   0
         Top             =   480
         Width           =   2775
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Show Drop Student"
         Height          =   375
         Left            =   240
         TabIndex        =   2
         Top             =   1320
         Width           =   2775
      End
      Begin VB.Label Label1 
         Caption         =   "Section"
         Height          =   255
         Left            =   240
         TabIndex        =   12
         Top             =   3120
         Width           =   2295
      End
      Begin VB.Label Label3 
         Caption         =   "Level"
         Height          =   255
         Left            =   240
         TabIndex        =   11
         Top             =   2520
         Width           =   2295
      End
      Begin VB.Image Image1 
         Height          =   480
         Left            =   3360
         Picture         =   "Form8.frx":038A
         Top             =   360
         Width           =   480
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&View"
      Default         =   -1  'True
      Height          =   350
      Left            =   1920
      TabIndex        =   8
      Top             =   4080
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   3240
      TabIndex        =   9
      Top             =   4080
      Width           =   975
   End
End
Attribute VB_Name = "Form8"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------------------------------
'All codes are copyright by Philip V. Naparan 2004
'
'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
'E-mail Address: philipnaparan@yahoo.com
'Contact #: 639186443161
'----------------------------------------------------------------------------------------------------
Option Explicit


'--------------------------------------
'Create variable to connect to DB
'--------------------------------------
Dim rs1 As New ADODB.Recordset
Dim rs2 As New ADODB.Recordset
'--------------------------------------
'End-Create variable to connect to DB
'--------------------------------------

Private Sub Combo1_Click()
If Combo1.Text = "" Then Exit Sub
rs2.Filter = "LevelName ='" & Combo1.Text & "'"
Call fill_combo(Combo2, rs2)
End Sub

Private Sub Command1_Click()
Dim sql As String
'--------------------------------------
'Begin filtering of records
'--------------------------------------
If Check2.Value = 0 And Check3.Value = 0 Then
    sql = "Sex ='None'"
ElseIf Check2.Value <> Check3.Value Then
    If Check2.Value = 1 Then sql = "Sex = 'Male'"
    If Check3.Value = 1 Then sql = "Sex = 'Female'"
End If

If sql = "" Then
    If Not Combo1.Text = "" Then sql = "LevelName = '" & Combo1.Text & "'"
    If Not Combo2.Text = "" Then sql = sql & " And SectionName = '" & Combo2.Text & "'"
Else
    If Not Combo1.Text = "" Then sql = sql & " And LevelName = '" & Combo1.Text & "'"
    If Not Combo2.Text = "" Then sql = sql & " And SectionName = '" & Combo2.Text & "'"
End If

If Check1.Value = 0 And Check4.Value = 0 And Check5.Value = 0 Then
    If sql <> "" Then
        sql = sql & " And Status = 'None'"
    Else
        sql = "Status = 'None'"
    End If
ElseIf Check1.Value <> Check4.Value Or Check1.Value <> Check5.Value Or Check4.Value <> Check5.Value Then
    If Check1.Value = 1 Then
        If sql <> "" Then
            sql = sql & " And Status = 'Drop'"
        Else
            sql = "Status = 'Drop'"
        End If
    Else
        If sql <> "" Then
            sql = sql & " And Status <> 'Drop'"
        Else
            sql = "Status <> 'Drop'"
        End If
    End If
    If Check4.Value <> Check5.Value Then '///////////////////////////////////////
    If Check4.Value = 1 Then
        If sql <> "" Then
            If Check1.Value = 1 Then
                sql = sql & " Or Status = 'New'"
            Else
                sql = sql & " And Status = 'New'"
            End If
        Else
            sql = sql & "Status = 'New'"
        End If
    End If

    If Check5.Value = 1 Then
        If sql <> "" Then
            If Check1.Value = 1 Or Check4.Value = 1 Then
                sql = sql & " Or Status = 'Old'"
            Else
                sql = sql & " And Status = 'Old'"
            End If
        Else
            sql = sql & "Status = 'Old'"
        End If
    End If
    End If '///////////////////////////////////////
End If

rs_stud.Filter = sql
'--------------------------------------
'Save settings to variable
'--------------------------------------
sds = Check1.Value
sms = Check2.Value
sfs = Check3.Value
sns = Check4.Value
sos = Check5.Value
'--------------------------------------
'End-Clear variable
'--------------------------------------
sql = ""
'--------------------------------------
'Load search result
'--------------------------------------
Form1.fill_rec
Me.MousePointer = vbDefault
Unload Me
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Combo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Combo2_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Command3_Click()
Check1.Value = 0
Check2.Value = 1
Check3.Value = 1
Check4.Value = 1
Check5.Value = 1

Combo1.Text = ""
Combo2.Text = ""

rs1.Requery
rs2.Filter = adFilterNone '[ You can use also .Filter="" ]
rs2.Requery

Call fill_combo(Combo1, rs1)
Call fill_combo(Combo2, rs2)
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Check1.Value = sds
Check2.Value = sms
Check3.Value = sfs
Check4.Value = sns
Check5.Value = sos

'--------------------------------------
'Set the variables
'--------------------------------------
Call set_rec_getData(rs1, cn, "Select tblLevel.* From tblLevel Order by LevelName Asc")
Call set_rec_getData(rs2, cn, "Select qrySections.* From qrySections Order by SectionName Asc")
'--------------------------------------
'End-Set the variables
'--------------------------------------

'--------------------------------------
'Fill Combo control
'--------------------------------------
Call fill_combo(Combo1, rs1)
Call fill_combo(Combo2, rs2)
'--------------------------------------
'End-Fill Combo control
'--------------------------------------
End Sub

Private Sub Form_Unload(Cancel As Integer)
Form1.Enabled = True

'--------------------------------------
'Clear variable
'--------------------------------------
Set rs1 = Nothing
Set rs2 = Nothing
'--------------------------------------
'End-Clear variable
'--------------------------------------

Call save_pos(Me)
End Sub
Sub fill_combo(ByRef sCombo As ComboBox, ByRef sRS As ADODB.Recordset)
sCombo.Clear
If sRS.RecordCount < 1 Then Exit Sub
sRS.MoveFirst
Do While Not sRS.EOF
    sCombo.AddItem sRS.Fields(1)
    sRS.MoveNext
Loop
sRS.MoveFirst
End Sub

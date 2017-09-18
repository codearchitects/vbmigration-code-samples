VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "Mscomct2.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "MonthView Control Demo"
   ClientHeight    =   5520
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8070
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
   ScaleHeight     =   5520
   ScaleWidth      =   8070
   StartUpPosition =   3  'Windows Default
   Begin MSComCtl2.MonthView MonthView1 
      DataField       =   "BirthDate"
      Height          =   2820
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   3825
      _ExtentX        =   6747
      _ExtentY        =   4974
      _Version        =   393216
      ForeColor       =   -2147483630
      BackColor       =   65280
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      MonthBackColor  =   -2147483624
      ShowWeekNumbers =   -1  'True
      StartOfWeek     =   24838145
      TitleBackColor  =   -2147483647
      TitleForeColor  =   -2147483634
      TrailingForeColor=   255
      CurrentDate     =   36090
   End
   Begin VB.CheckBox chkMultiSelect 
      Caption         =   "Allow &Multiple Selections"
      Height          =   375
      Left            =   4200
      TabIndex        =   12
      Top             =   1080
      Width           =   3735
   End
   Begin VB.TextBox txtDate 
      Height          =   420
      Left            =   4080
      OLEDropMode     =   2  'Automatic
      TabIndex        =   9
      Top             =   2160
      Width           =   3855
   End
   Begin VB.CheckBox chkMarkHolidays 
      Caption         =   "Automatically mark &holidays"
      Height          =   375
      Left            =   4200
      TabIndex        =   8
      Top             =   720
      Value           =   1  'Checked
      Width           =   3735
   End
   Begin VB.CommandButton cmdMark 
      Caption         =   "&Mark Fridays"
      Height          =   495
      Left            =   6360
      TabIndex        =   7
      Top             =   120
      Width           =   1575
   End
   Begin VB.CommandButton cmdTile 
      Caption         =   "&Tile Control"
      Height          =   495
      Left            =   4920
      TabIndex        =   5
      Top             =   120
      Width           =   1335
   End
   Begin VB.CommandButton cmdFont 
      Caption         =   "Set &Font"
      Height          =   495
      Left            =   3480
      TabIndex        =   4
      Top             =   120
      Width           =   1335
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   3960
      Top             =   4200
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdTryMe 
      Caption         =   "&Try me"
      Height          =   615
      Left            =   4920
      TabIndex        =   3
      Top             =   4080
      Width           =   1575
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next Month"
      Height          =   495
      Left            =   1800
      TabIndex        =   2
      Top             =   120
      Width           =   1575
   End
   Begin VB.CommandButton cmdPrev 
      Caption         =   "&Prev Month"
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Height          =   495
      Left            =   120
      TabIndex        =   11
      Top             =   3600
      Width           =   3855
   End
   Begin VB.Label Label2 
      Caption         =   "Use right button to drag-and-drop a date to this textbox"
      Height          =   615
      Left            =   4080
      TabIndex        =   10
      Top             =   1440
      Width           =   3735
   End
   Begin VB.Label Label1 
      Caption         =   "This is the only button in the form that reacts to clicks even when the focus is on the MonthView control."
      Height          =   1215
      Left            =   4200
      TabIndex        =   6
      Top             =   2760
      Width           =   3135
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' This variable is used by the TryMe button.
Dim MousePressed As Boolean
' This variable is used during drag-and-drop.
Dim DraggedDate As Date

Private Sub chkMultiSelect_Click()
    MonthView1.MultiSelect = chkMultiSelect.Value
    cmdPrev.Enabled = Not MonthView1.MultiSelect
    cmdNext.Enabled = Not MonthView1.MultiSelect
End Sub

Private Sub cmdFont_Click()
    With CommonDialog1
        .FontName = MonthView1.Font.Name
        .FontSize = MonthView1.Font.Size
        .FontBold = MonthView1.Font.Bold
        .FontItalic = MonthView1.Font.Italic
        .FontUnderline = MonthView1.Font.Underline
        .FontStrikethru = MonthView1.Font.Strikethrough
        .Flags = cdlCFScreenFonts
        .ShowFont
        MonthView1.Font.Name = .FontName
        MonthView1.Font.Size = .FontSize
        MonthView1.Font.Bold = .FontBold
        MonthView1.Font.Italic = .FontItalic
        MonthView1.Font.Underline = .FontUnderline
        MonthView1.Font.Strikethrough = .FontStrikethru
    End With
        
        
End Sub

Private Sub cmdMark_Click()
    Dim i As Integer
    On Error GoTo ExitRoutine
    For i = 1 To 366
        If Weekday(MonthView1.VisibleDays(i)) = vbFriday Then
            MonthView1.DayBold(MonthView1.VisibleDays(i)) = True
        End If
    Next
ExitRoutine:
End Sub

Private Sub cmdPrev_Click()
    If MonthView1.Month > 1 Then
        MonthView1.Month = MonthView1.Month - 1
    Else
        MonthView1.Month = 12
        MonthView1.Year = MonthView1.Year - 1
    End If
End Sub

Private Sub cmdNext_Click()
    If MonthView1.Month < 12 Then
        MonthView1.Month = MonthView1.Month + 1
    Else
        MonthView1.Month = 1
        MonthView1.Year = MonthView1.Year + 1
    End If
End Sub

Private Sub cmdTile_Click()
    ' find the best value for MonthRows and MonthColumns
    Dim rows As Integer, cols As Integer
    Dim wi As Single, he As Single
    
    For rows = 6 To 1 Step -1
        For cols = 12 \ rows To 1 Step -1
            MonthView1.ComputeControlSize rows, cols, wi, he
            If wi <= ScaleWidth - MonthView1.Left And he < ScaleHeight - MonthView1.Top Then
                MonthView1.MonthRows = rows
                MonthView1.MonthColumns = cols
                Exit Sub
            End If
        Next
    Next
End Sub


Private Sub MonthView1_DateDblClick(ByVal DateDblClicked As Date)
    Dim descr As String
    descr = InputBox("Enter a description for day " & FormatDateTime(DateDblClicked, vbLongDate))
End Sub

Private Sub MonthView1_DblClick()
    Debug.Print "DblClick"
End Sub

' Show the name of the control's area under the mouse cursor.

Private Sub MonthView1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim areaName As String
    Select Case MonthView1.HitTest(X, Y, 0)
        Case mvwCalendarBack
            areaName = "mvwCalendarBack"
        Case mvwCalendarDate
            areaName = "mvwCalendarDate"
        Case mvwCalendarDateNext
            areaName = "mvwCalendarDateNext"
        Case mvwCalendarDatePrev
            areaName = "mvwCalendarDatePrev"
        Case mvwCalendarDay
            areaName = "mvwCalendarDay"
        Case mvwCalendarWeekNum
            areaName = "mvwCalendarWeekNum"
        Case mvwNoWhere
            areaName = "mvwNoWhere"
        Case mvwTitleBack
            areaName = "mvwTitleBack"
        Case mvwTitleBtnNext
            areaName = "mvwTitleBtnNext"
        Case mvwTitleBtnPrev
            areaName = "mvwTitleBtnPrev"
        Case mvwTitleMonth
            areaName = "mvwTitleMonth"
        Case mvwTitleYear
            areaName = "mvwTitleYear"
        Case mvwTodayLink
            areaName = "mvwTodayLink"
    End Select
    lblStatus = "HitTest() = " & areaName
End Sub

' Start a drag and drop operation.

Private Sub MonthView1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' Exit if the right button isn't clicked.
    If Button <> vbRightButton Then Exit Sub
    ' Exit if mouse isn't over a valid date
    If MonthView1.HitTest(X, Y, DraggedDate) = mvwCalendarDay Then Exit Sub
    ' Now DraggedDate contains the date to be dragged
    ' and we can start the drag operation
    MonthView1.OLEDrag
End Sub

Private Sub MonthView1_OLEStartDrag(Data As MSComCtl2.DataObject, AllowedEffects As Long)
    ' When this event fires DraggedDate contain a valid date
    Data.SetData Format(DraggedDate, "long date")
    AllowedEffects = vbDropEffectCopy
End Sub

' Refuse any selection that includes a Sunday or a Saturday.
' NOTE: it apparently works only if the user has selected
' at least three days (bug?)

Private Sub MonthView1_SelChange(ByVal StartDate As Date, _
    ByVal EndDate As Date, Cancel As Boolean)
    Dim d As Date
    For d = StartDate To EndDate
        If Weekday(d) = vbSunday Or Weekday(d) = vbSaturday Then
            Cancel = True
            Exit For
        End If
    Next
End Sub

Sub MonthView1_GetDayBold(ByVal StartDate As Date, _
    ByVal Count As Integer, State() As Boolean)
    
    ' exit if marking holidays has been disabled
    If chkMarkHolidays.Value = vbUnchecked Then Exit Sub
    
    Dim i As Long, d As Date
    d = StartDate
    For i = 0 To Count - 1
        If Weekday(d) = vbSunday Then
            ' mark all Sundays
            State(i) = True
        ElseIf Month(d) = 12 And Day(d) = 25 Then
            ' Xmas time
            State(i) = True
        Else
            ' deal here with other holidays ...
        End If
        d = d + 1
    Next
End Sub



Private Sub cmdTryMe_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    MousePressed = True
    DoSomething
End Sub

Private Sub cmdTryMe_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    MousePressed = False
End Sub

Private Sub cmdTryMe_Click()
    If Not MousePressed Then DoSomething
End Sub

Private Sub DoSomething()
    MsgBox "Button has been clicked!"
End Sub



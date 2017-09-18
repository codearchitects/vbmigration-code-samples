VERSION 5.00
Begin VB.Form frmCalendar 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calendar"
   ClientHeight    =   4305
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4530
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4305
   ScaleWidth      =   4530
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdNextYear 
      Caption         =   ">>"
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
      TabIndex        =   8
      TabStop         =   0   'False
      Top             =   0
      Width           =   375
   End
   Begin VB.CommandButton cmdPrevYear 
      Caption         =   "<<"
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
      TabIndex        =   7
      TabStop         =   0   'False
      Top             =   0
      Width           =   375
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1200
      TabIndex        =   5
      Top             =   3840
      Width           =   975
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2400
      TabIndex        =   6
      Top             =   3840
      Width           =   975
   End
   Begin VB.OptionButton optDay 
      Height          =   495
      Index           =   0
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   840
      Width           =   615
   End
   Begin VB.CommandButton cmdNextMonth 
      Caption         =   ">"
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
      Left            =   3720
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   0
      Width           =   375
   End
   Begin VB.CommandButton cmdPrevMonth 
      Caption         =   "<"
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
      Left            =   480
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   0
      Width           =   375
   End
   Begin VB.Label lblCurrentMonth 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   1
      Top             =   0
      Width           =   2895
   End
   Begin VB.Label lblWeekDay 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   615
   End
End
Attribute VB_Name = "frmCalendar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' ------------------------------------------------------------------------
' Copyright © 1998 Francesco Balena.
' ------------------------------------------------------------------------

Event DateChanged(newDate As Date)
Event Unload(CancelPressed As Boolean)

Option Explicit

' the caption of the form
Public DialogTitle As String

' this is set to True if the Cancel button was clicked
Public CancelPressed As Boolean

' set the next property to True if you wish that
' Saturdays are colored in Red
Public SaturdayIsHoliday As Boolean

' this property states which is the first day of the week
' (1 = Sunday, 2 = Monday, etc) - the default is Sunday
Private m_FirstDayOfWeek As Integer
' the current year, month and day
Private m_Year As Integer
Private m_Month As Integer
Private m_Day As Integer

' this is the index of the button corresponding to the
' first day of the month currently showed (evaluated in ShowMonth)
Private firstDayIndex As Integer

' read or set the first day of the week

Property Get FirstDayOfWeek() As VbDayOfWeek
    FirstDayOfWeek = m_FirstDayOfWeek
End Property

Property Let FirstDayOfWeek(ByVal newValue As VbDayOfWeek)
    ' only accept values in proper range
    If newValue < 1 And newValue > 7 Then
        Err.Raise 5, TypeName(Me), "Illegal value for this property"
    End If
    m_FirstDayOfWeek = newValue
End Property

' read the current year, month and day (read-only)

Property Get Year() As Integer
    Year = m_Year
End Property

Property Get Month() As Integer
    Month = m_Month
End Property

Property Get Day() As Integer
    Day = m_Day
End Property

' the current date serial

Property Get SelectedDate() As Date
    SelectedDate = DateValue(DateSerial(m_Year, m_Month, m_Day))
End Property

Property Let SelectedDate(newValue As Date)
    ' note that we need to specify that we are referring to VBA functions
    ShowMonth VBA.Year(newValue), VBA.Month(newValue), VBA.Day(newValue)
End Property

Private Sub Form_Initialize()
    FirstDayOfWeek = vbSunday
    DialogTitle = "Calendar"
End Sub

Private Sub Form_Load()
    ' fill the area with all the option buttons
    Dim i As Long, lblIndex As Integer
    
    Me.caption = DialogTitle
    
    ' create the row of weekday names
    For i = 1 To 6
        Load lblWeekDay(i)
        lblWeekDay(i).Left = lblWeekDay(0).Left + i * lblWeekDay(0).Width
        lblWeekDay(i).Visible = True
    Next
    
    ' set their caption and forecolor
    For i = 0 To 6
        ' find the index of the label that corresponds to
        ' a given week day
        lblIndex = (i + 8 - m_FirstDayOfWeek) Mod 7
        ' the next line fills the caption with a 3-char abbreviation
        ' of the weekday, and keeps localization into account
        ' (NOTE: Jan 5, 1997 was Sunday)
        lblWeekDay(lblIndex).caption = StrConv(Format$(DateSerial(1997, 1, 5 + i), "ddd"), vbProperCase)
        If i = 0 Or (i = 6 And SaturdayIsHoliday) Then
            lblWeekDay(lblIndex).ForeColor = vbRed
        Else
            lblWeekDay(lblIndex).ForeColor = vbBlack
        End If
    Next
    
    ' six rows of seven buttons each
    For i = 0 To 6 * 7 - 1
        If i > 0 Then Load optDay(i)
        optDay(i).Move optDay(0).Left + (i Mod 7) * optDay(0).Width, _
            optDay(0).Top + (i \ 7) * optDay(0).Height
        optDay(i).Visible = True
        ' buttons have the same forecolor of the corresponding label
        optDay(i).ForeColor = lblWeekDay(i Mod 7).ForeColor
    Next
    
End Sub

Sub ShowMonth(ByVal newYear As Integer, ByVal newMonth As Integer, Optional ByVal newDay As Integer)
    Dim i As Integer, optIndex As Integer
    Dim firstDay As Integer, daysInMonth As Integer
    
    ' shows month and year in the upper label
    ' this statement works under any locale
    lblCurrentMonth.caption = StrConv(Format$(DateSerial(newYear, newMonth, 1), "mmmm yyyy"), vbProperCase)
    
    firstDay = Weekday(DateSerial(newYear, newMonth, 1))
    daysInMonth = DateSerial(newYear, newMonth + 1, 1) - DateSerial(newYear, newMonth, 1)
    
    ' set the public properties
    m_Year = newYear
    m_Month = newMonth
    If newDay = 0 Then newDay = m_Day
    If newDay < 1 Then
        m_Day = 1
    ElseIf newDay > daysInMonth Then
        m_Day = daysInMonth
    Else
        m_Day = newDay
    End If
    
    ' the first row of buttons may contain some invisible option buttons
    Do Until ((optIndex + m_FirstDayOfWeek) Mod 7) = (firstDay Mod 7)
        optDay(optIndex).Visible = False
        optDay(optIndex).caption = ""
        optIndex = optIndex + 1
    Loop
    
    ' remember the index of the first valid button
    firstDayIndex = optIndex
    
    ' then come a number of visible option buttons
    For i = 1 To daysInMonth
        optDay(optIndex).caption = i
        optDay(optIndex).Visible = True
        ' highlight the day or not
        If i = m_Day Then
            optDay(optIndex).Value = True
        Else
            optDay(optIndex).Value = False
        End If
        optIndex = optIndex + 1
    Next
    
    ' followed by other disabled buttons
    Do Until optIndex > optDay.UBound
        optDay(optIndex).Visible = False
        optIndex = optIndex + 1
    Loop
    
End Sub

Private Sub cmdPrevMonth_Click()
    If m_Month > 1 Then
        ShowMonth m_Year, m_Month - 1
    Else
        ShowMonth m_Year - 1, 12
    End If
    cmdOK.SetFocus
End Sub

Private Sub cmdNextMonth_Click()
    If m_Month < 12 Then
        ShowMonth m_Year, m_Month + 1
    Else
        ShowMonth m_Year + 1, 1
    End If
    cmdOK.SetFocus
End Sub

Private Sub cmdPrevYear_Click()
    ShowMonth m_Year - 1, m_Month
    cmdOK.SetFocus
End Sub

Private Sub cmdNextYear_Click()
    ShowMonth m_Year + 1, m_Month
    cmdOK.SetFocus
End Sub

Private Sub cmdOK_Click()
    Unload Me
End Sub

Private Sub cmdCancel_Click()
    CancelPressed = True
    Unload Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' notify the client that this form is being unloaded
    ' and explain it why
    
    Hide
    RaiseEvent Unload(CancelPressed)
End Sub

Private Sub optDay_Click(Index As Integer)
    ' set the Day property
    m_Day = Index - firstDayIndex + 1
    ' inform the client code that a new date has been selected
    RaiseEvent DateChanged(SelectedDate)
End Sub

Private Sub optDay_DblClick(Index As Integer)
    ' a double-click on a date selects it
    Call cmdOK_Click
End Sub

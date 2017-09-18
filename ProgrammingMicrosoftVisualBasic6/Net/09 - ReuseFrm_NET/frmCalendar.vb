' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmCalendar

	' ------------------------------------------------------------------------
	' Copyright © 1998 Francesco Balena.
	' ------------------------------------------------------------------------
	
	Public Event DateChanged(ByRef newDate As Date)
	Public Shadows Event Unload(ByRef CancelPressed As Boolean)

	' the caption of the form
	Public DialogTitle As String = ""
	
	' this is set to True if the Cancel button was clicked
	Public CancelPressed As Boolean
	
	' set the next property to True if you wish that
	' Saturdays are colored in Red
	Public SaturdayIsHoliday As Boolean
	
	' this property states which is the first day of the week
	' (1 = Sunday, 2 = Monday, etc) - the default is Sunday
	Private m_FirstDayOfWeek As Short
	' the current year, month and day
	Private m_Year As Short
	Private m_Month As Short
	Private m_Day As Short
	
	' this is the index of the button corresponding to the
	' first day of the month currently showed (evaluated in ShowMonth)
	Private firstDayIndex As Short
	
	' read or set the first day of the week

	Public Property FirstDayOfWeek() As FirstDayOfWeek
		Get
			Return m_FirstDayOfWeek
	 	End Get
		Set(ByVal newValue As FirstDayOfWeek)
			' only accept values in proper range
			If newValue < 1 And newValue > 7 Then 
				Err.Raise(5, TypeName6(Me), "Illegal value for this property")
			End If
			m_FirstDayOfWeek = newValue
	 	End Set
	End Property

	' read the current year, month and day (read-only)
	
	Public ReadOnly Property Year() As Short
		Get
			Return m_Year
	 	End Get
	End Property

	Public ReadOnly Property Month() As Short
		Get
			Return m_Month
	 	End Get
	End Property

	Public ReadOnly Property Day() As Short
		Get
			Return m_Day
	 	End Get
	End Property

	' the current date serial

	Public Property SelectedDate() As Date
		Get
			Return DateValue(DateSerial(m_Year, m_Month, m_Day))
	 	End Get
		Set(ByVal newValue As Date)
			' note that we need to specify that we are referring to VBA functions
			ShowMonth(VB.Year(newValue), VB.Month(newValue), VB.Day(newValue))
	 	End Set
	End Property

	Protected Overrides Sub Form_Initialize_VB6()
		FirstDayOfWeek = FirstDayOfWeek.Sunday
		DialogTitle = "Calendar"
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' fill the area with all the option buttons
		Dim i As Integer
		Dim lblIndex As Short
		
		Me.Caption = DialogTitle
		
		' create the row of weekday names
		For i = 1 To 6
			lblWeekDay.Load(i)
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
			lblWeekDay(lblIndex).Caption = StrConv6(Format6(DateSerial(1997, 1, 5 + i), "ddd"), VBA.VbStrConv.vbProperCase)
			If i = 0 Or (i = 6 And SaturdayIsHoliday) Then 
				lblWeekDay(lblIndex).ForeColor = Color.Red 
			Else
				lblWeekDay(lblIndex).ForeColor = Color.Black 
			End If
		Next
		
		' six rows of seven buttons each
		For i = 0 To 6 * 7 - 1
			If i > 0 Then  optDay.Load(i)
			optDay(i).Move(optDay(0).Left + (i Mod 7) * optDay(0).Width, optDay(0).Top + (i \ 7) * optDay(0).Height)
			optDay(i).Visible = True
			' buttons have the same forecolor of the corresponding label
			optDay(i).ForeColor = lblWeekDay(i Mod 7).ForeColor
		Next
		
	End Sub

	Public Sub ShowMonth(ByVal newYear As Short, ByVal newMonth As Short, Optional ByVal newDay As Short = 0)
		Dim i As Short
		Dim optIndex As Short
		Dim firstDay As Short
		Dim daysInMonth As Short
		
		' shows month and year in the upper label
		' this statement works under any locale
		lblCurrentMonth.Caption = StrConv6(Format6(DateSerial(newYear, newMonth, 1), "mmmm yyyy"), VBA.VbStrConv.vbProperCase)
		
		firstDay = Weekday(DateSerial(newYear, newMonth, 1))
		daysInMonth = DateToDouble6(DateSerial(newYear, newMonth + 1, 1)) - DateToDouble6(DateSerial(newYear, newMonth, 1))
		
		' set the public properties
		m_Year = newYear
		m_Month = newMonth
		If newDay = 0 Then  newDay = m_Day
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
			optDay(optIndex).Caption = ""
			optIndex += 1
		Loop
		
		' remember the index of the first valid button
		firstDayIndex = optIndex
		
		' then come a number of visible option buttons
		For i = 1 To daysInMonth
			optDay(optIndex).Caption = i
			optDay(optIndex).Visible = True
			' highlight the day or not
			If i = m_Day Then 
				optDay(optIndex).Value = True
			Else
				optDay(optIndex).Value = False
			End If
			optIndex += 1
		Next
		
		' followed by other disabled buttons
		Do Until optIndex > optDay.UBound()
			optDay(optIndex).Visible = False
			optIndex += 1
		Loop
		
	End Sub

	Private Sub cmdPrevMonth_Click() Handles cmdPrevMonth.Click
		If m_Month > 1 Then 
			ShowMonth(m_Year, m_Month - 1)
		Else
			ShowMonth(m_Year - 1, 12)
		End If
		cmdOK.SetFocus()
	End Sub

	Private Sub cmdNextMonth_Click() Handles cmdNextMonth.Click
		If m_Month < 12 Then 
			ShowMonth(m_Year, m_Month + 1)
		Else
			ShowMonth(m_Year + 1, 1)
		End If
		cmdOK.SetFocus()
	End Sub

	Private Sub cmdPrevYear_Click() Handles cmdPrevYear.Click
		ShowMonth(m_Year - 1, m_Month)
		cmdOK.SetFocus()
	End Sub

	Private Sub cmdNextYear_Click() Handles cmdNextYear.Click
		ShowMonth(m_Year + 1, m_Month)
		cmdOK.SetFocus()
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		CancelPressed = True
		Unload6(Me)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' notify the client that this form is being unloaded
		' and explain it why
		
		Hide()
		RaiseEvent Unload(CancelPressed)
	End Sub

	Private Sub optDay_Click(ByRef Index As Short)
		' set the Day property
		m_Day = Index - firstDayIndex + 1
		' inform the client code that a new date has been selected
		RaiseEvent DateChanged(SelectedDate)
	End Sub

	Private Sub optDay_DblClick(ByRef Index As Short)
		' a double-click on a date selects it
		Call cmdOK_Click()
	End Sub

End Class

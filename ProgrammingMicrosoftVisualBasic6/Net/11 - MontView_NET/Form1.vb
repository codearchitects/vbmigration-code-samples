' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'DAO' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	' This variable is used by the TryMe button.
	Private MousePressed As Boolean
	' This variable is used during drag-and-drop.
	Private DraggedDate As Date
	
	Private Sub chkMultiSelect_Click() Handles chkMultiSelect.Click
		MonthView1.MultiSelect = chkMultiSelect.Value
		cmdPrev.Enabled = Not MonthView1.MultiSelect
		cmdNext.Enabled = Not MonthView1.MultiSelect
	End Sub

	Private Sub cmdFont_Click() Handles cmdFont.Click
		With CommonDialog1
			.FontName = MonthView1.Font.Name
			.FontSize = MonthView1.Font.Size
			.FontBold = MonthView1.Font.Bold
			.FontItalic = MonthView1.Font.Italic
			.FontUnderline = MonthView1.Font.Underline
			.FontStrikeThru = MonthView1.Font.Strikeout
			.Flags = MSComDlg.FontsConstants.cdlCFScreenFonts
			.ShowFont()
			FontChangeName6(MonthView1.Font, .FontName)
			FontChangeSize6(MonthView1.Font, .FontSize)
			FontChangeBold6(MonthView1.Font, .FontBold)
			FontChangeItalic6(MonthView1.Font, .FontItalic)
			FontChangeUnderline6(MonthView1.Font, .FontUnderline)
			FontChangeStrikeout6(MonthView1.Font, .FontStrikeThru)
		End With

	End Sub

	Private Sub cmdMark_Click() Handles cmdMark.Click
		Dim i As Short
		On Error GoTo ExitRoutine 
		For i = 1 To 366
			If Weekday(MonthView1.VisibleDays(i)) = FirstDayOfWeek.Friday Then 
				MonthView1.DayBold(MonthView1.VisibleDays(i)) = True
			End If
		Next
ExitRoutine:
	End Sub

	Private Sub cmdPrev_Click() Handles cmdPrev.Click
		If MonthView1.Month > 1 Then 
			MonthView1.Month -= 1
		Else
			MonthView1.Month = 12
			MonthView1.Year -= 1
		End If
	End Sub

	Private Sub cmdNext_Click() Handles cmdNext.Click
		If MonthView1.Month < 12 Then 
			MonthView1.Month += 1
		Else
			MonthView1.Month = 1
			MonthView1.Year += 1
		End If
	End Sub

	Private Sub cmdTile_Click() Handles cmdTile.Click
		' find the best value for MonthRows and MonthColumns
		Dim rows As Short
		Dim cols As Short
		Dim wi As Single
		Dim he As Single
		
		For rows = 6 To 1 Step -1
			For cols = 12 \ rows To 1 Step -1
				MonthView1.ComputeControlSize(rows, cols, wi, he)
				If wi <= ScaleWidth - MonthView1.Left And he < ScaleHeight - MonthView1.Top Then 
					MonthView1.MonthRows = rows
					MonthView1.MonthColumns = cols
					Exit Sub
				End If
			Next
		Next
	End Sub

	Private Sub MonthView1_DateDblClick(ByVal DateDblClicked As Date) Handles MonthView1.DateDblClick
		Dim descr As String = InputBox6("Enter a description for day " & FormatDateTime(DateDblClicked, DateFormat.LongDate))
	End Sub

	Private Sub MonthView1_DblClick() Handles MonthView1.DblClick
		Debug.WriteLine("DblClick")
	End Sub

	' Show the name of the control's area under the mouse cursor.
	
	Private Sub MonthView1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MonthView1.MouseMove
		Dim areaName As String = ""
		Select Case MonthView1.HitTest(X, Y, DoubleToDate6(0))
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarBack
			areaName = "mvwCalendarBack"
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarDate
			areaName = "mvwCalendarDate"
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarDateNext
			areaName = "mvwCalendarDateNext"
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarDatePrev
			areaName = "mvwCalendarDatePrev"
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarDay
			areaName = "mvwCalendarDay"
		Case MSComCtl2.MonthViewHitTestAreas.mvwCalendarWeekNum
			areaName = "mvwCalendarWeekNum"
		Case MSComCtl2.MonthViewHitTestAreas.mvwNoWhere
			areaName = "mvwNoWhere"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTitleBack
			areaName = "mvwTitleBack"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTitleBtnNext
			areaName = "mvwTitleBtnNext"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTitleBtnPrev
			areaName = "mvwTitleBtnPrev"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTitleMonth
			areaName = "mvwTitleMonth"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTitleYear
			areaName = "mvwTitleYear"
		Case MSComCtl2.MonthViewHitTestAreas.mvwTodayLink
			areaName = "mvwTodayLink"
		End Select
		lblStatus.Caption = "HitTest() = " & areaName
	End Sub

	' Start a drag and drop operation.
	
	Private Sub MonthView1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MonthView1.MouseDown
		' Exit if the right button isn't clicked.
		If Button <> VBRUN.MouseButtonConstants.vbRightButton Then  Exit Sub
		' Exit if mouse isn't over a valid date
		If MonthView1.HitTest(X, Y, DraggedDate) = MSComCtl2.MonthViewHitTestAreas.mvwCalendarDay Then  Exit Sub
		' Now DraggedDate contains the date to be dragged
		' and we can start the drag operation
		MonthView1.OLEDrag()
	End Sub

	Private Sub MonthView1_OLEStartDrag(ByRef Data As VB6DataObject, ByRef AllowedEffects As Integer) Handles MonthView1.OLEStartDrag
		' When this event fires DraggedDate contain a valid date
		Data.SetData(Format6(DraggedDate, "long date"))
		AllowedEffects = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
	End Sub

	' Refuse any selection that includes a Sunday or a Saturday.
	' NOTE: it apparently works only if the user has selected
	' at least three days (bug?)
	
	Private Sub MonthView1_SelChange(ByVal StartDate As Date, ByVal EndDate As Date, ByRef Cancel As Boolean) Handles MonthView1.SelChange
		Dim d As Date
		For d_Alias As Double = DateToDouble6(StartDate) To DateToDouble6(EndDate)
			d = DoubleToDate6(d_Alias)
			If Weekday(d) = FirstDayOfWeek.Sunday Or Weekday(d) = FirstDayOfWeek.Saturday Then 
				Cancel = True
				Exit For
			End If
		Next
	End Sub

	Public Sub MonthView1_GetDayBold(ByVal StartDate As Date, ByVal Count As Short, ByRef State() As Boolean) Handles MonthView1.GetDayBold
		
		' exit if marking holidays has been disabled
		If chkMarkHolidays.Value = VBRUN.CheckBoxConstants.vbUnchecked Then  Exit Sub
		
		Dim i As Integer
		Dim d As Date
		d = StartDate
		For i = 0 To Count - 1
			If Weekday(d) = FirstDayOfWeek.Sunday Then 
				' mark all Sundays
				State(i) = True
			ElseIf Month(d) = 12 And VB.Day(d) = 25 Then 
				' Xmas time
				State(i) = True
			Else
				' deal here with other holidays ...
			End If
			d = DoubleToDate6(DateToDouble6(d) + 1)
		Next
	End Sub

	Private Sub cmdTryMe_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles cmdTryMe.MouseDown
		MousePressed = True
		DoSomething()
	End Sub

	Private Sub cmdTryMe_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles cmdTryMe.MouseUp
		MousePressed = False
	End Sub

	Private Sub cmdTryMe_Click() Handles cmdTryMe.Click
		If Not MousePressed Then  DoSomething()
	End Sub

	Private Sub DoSomething()
		MsgBox6("Button has been clicked!")
	End Sub

End Class

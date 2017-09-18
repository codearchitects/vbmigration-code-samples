' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	' this will let us receive events from the FrmCalendar module
	Private WithEvents Calendar As frmCalendar
	Private Sub cmdOptionsOne_Click() Handles cmdOptionsOne.Click
		Dim frm As New frmOptions
		
		frm.DialogTitle = "Options One"
		frm.AddFrame("F1", "First Group")
		frm.AddOption("O1", "&1. First", True)
		frm.AddOption("O2", "&2. Second")
		frm.AddOption("O3", "&3. Third")
		
		frm.AddFrame("F2", "Second Group")
		frm.AddOption("O4", "&4. Fourth", True)
		frm.AddOption("O5", "&5. Fifth")
		frm.AddOption("O6", "&6. Sixth")
		frm.AddCheck("C1", "&7. Check one", CShort(True))
		frm.AddCheck("C2", "&8. Check two")
		
		frm.Show(VBRUN.FormShowConstants.vbModal)
		
		If frm.CancelPressed Then 
			MsgBox6("Command canceled", MsgBoxStyle.Information)
		Else
			MsgBox6("Option button in first frame: " & frm.Value("F1") & ControlChars.Cr & "Option button in second frame: " & frm.Value("F2") & ControlChars.Cr & "First checkbox : " & frm.Value("C1") & ControlChars.Cr & "Second checkbox: " & frm.Value("c2") & ControlChars.Cr, MsgBoxStyle.Information, "Result of Options form")
		End If
	End Sub

	Private Sub cmdOptionsTwo_Click() Handles cmdOptionsTwo.Click
		Dim frm As New frmOptions
		
		frm.DialogTitle = "Options Two"
		frm.AddFrame("F1", "First Group")
		frm.AddCheck("C1", "&1. Check one", CShort(True))
		frm.AddCheck("C2", "&2. Check two")
		
		frm.AddFrame("F2", "Second Group")
		frm.AddOption("O1", "&3. First", True)
		frm.AddOption("O2", "&4. Second")
		
		frm.AddFrame("F3", "Third Group")
		frm.AddOption("O3", "&5. Third", True)
		frm.AddOption("O4", "&6. Fourth")
		frm.AddOption("O5", "&7. Fifth")
		
		frm.Show(VBRUN.FormShowConstants.vbModal)
		
		If frm.CancelPressed Then 
			MsgBox6("Command canceled", MsgBoxStyle.Information)
		Else
			MsgBox6("First checkbox : " & frm.Value("C1") & ControlChars.Cr & "Second checkbox: " & frm.Value("C2") & ControlChars.Cr & "Option button in second frame: " & frm.Value("F2") & ControlChars.Cr & "Option button in third frame: " & frm.Value("F3") & ControlChars.Cr, MsgBoxStyle.Information, "Result of Options form")
		End If
		
	End Sub

	Private Sub cmdCalendar_Click() Handles cmdCalendar.Click
		Calendar = New frmCalendar()
		Load6(Calendar)
		
		With Calendar
			.FirstDayOfWeek = FirstDayOfWeek.Monday
			.SaturdayIsHoliday = True
			.ShowMonth(1997, 8, 15)
			.Show()
		End With
	End Sub

	' this event fires when a new date has been
	' selected in the calendar form
	
	Private Sub Calendar_DateChanged(ByRef newDate As Date) Handles Calendar.DateChanged
		lblStatus.Caption = Format6(newDate, "Long Date")
	End Sub

	' this event fires when the calendar is being closed
	
	Private Sub Calendar_Unload(ByRef CancelPressed As Boolean) Handles Calendar.Unload
		lblStatus.Caption = ""
		If CancelPressed Then 
			MsgBox6("Command canceled", MsgBoxStyle.Information)
		Else
			MsgBox6("Selected date: " & Format6(Calendar.SelectedDate, "Long Date"), MsgBoxStyle.Information)
		End If
		' we don't need this any longer
		Calendar = Nothing
	End Sub

End Class

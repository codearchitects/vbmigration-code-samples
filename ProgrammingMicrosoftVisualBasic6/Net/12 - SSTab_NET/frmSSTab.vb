' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSSTab

	' Add a new tab.
	
	Private Sub cmdAddTab_Click() Handles cmdAddTab.Click
		Dim lbl As VB6Label = Nothing
		Dim txt As VB6TextBox = Nothing
		
		' Create a new tab, make it current.
		SSTab1.Tabs += 1
		SSTab1.Tab = SSTab1.Tabs - 1
		SSTab1.TabCaption(SSTab1.Tab) = "Tab #" & SSTab1.Tabs
		
		' Add a Label and a TextBox control on the new tab.
		lbl = Controls6.Add("VB.Label", "NewLabel" & SSTab1.Tabs)
		lbl.Container = SSTab1
		lbl.Caption = "A new Label"
		lbl.Move(400, 600)
		lbl.Visible = True
		
		txt = Controls6.Add("VB.Textbox", "NewTextBox" & SSTab1.Tabs)
		txt.Container = SSTab1
		txt.Text = "A new TextBox"
		txt.Move(400, 900, 1800, 400)
		txt.Visible = True
		
		txt.SetFocus()
		
	End Sub

	' Validate the tab that is being abandoned.
	
	Private Sub SSTab1_Click(ByRef PreviousTab As Short) Handles SSTab1.Click
		Static Cancel As Boolean
		Static msg As String
		' Avoid recursive calls
		If Cancel Then  Exit Sub
		
		Select Case PreviousTab
		Case 0
			If txtRequired.Text = "" Then 
				txtRequired.SetFocus()
				msg = "Enter a value in this field"
				Cancel = True
			End If
		Case 1
			If Not IsNumeric6(txtNumeric.Text) Then 
				txtNumeric.SetFocus()
				msg = "Enter a number in this field"
				Cancel = True
			End If
		Case 2
			' No validation for this tab.
		End Select
		
		If Cancel Then 
			' Restore previous tab (this fires another Click event).
			SSTab1.Tab = PreviousTab
			' Show the error message
			If Len6(msg) Then  MsgBox6(msg, MsgBoxStyle.Exclamation)
			' Accept future Click events.
			Cancel = False
		Else
			' Input focus management
			ChangeTab(SSTab1)
		End If
		
	End Sub

End Class

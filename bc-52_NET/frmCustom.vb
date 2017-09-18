' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmCustom

	Private Sub Form_Load() Handles MyBase.Load
		Dim k As Short
		Dim j As Short
		Dim tmp As String = ""
		
		For k = 1 To 12
			For j = 1 To Len6(W_textLabel(k))
				If Mid(W_textLabel(k), j, 1) <> "." Then 
					Me.cmbLabel(k).AddItem(Mid(W_textLabel(k), j, 1))
				Else
					Me.cmbLabel(k).AddItem(Format6(j, "00"))
				End If
			Next
		Next
		For k = 1 To 26
			Me.cmbSpace.AddItem(Chr6(k + 64))
		Next
		For k = 2 To 6
			For j = 1 To 32
				Me.cmbBar(k).AddItem(Format6(j, "00"))
			Next
		Next
		
		For k = 2 To 6
			For j = 1 To 4
				Me.cmbStep(k).AddItem(Format6(j, "0"))
			Next
		Next
		
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Dim k As Short
		Me.cmdCancel.SetFocus()
		
		If gblnCxType = True Then 
			Me.optCX52.Value = True
		Else
			Me.optC52.Value = True
		End If
		
		For k = 1 To 12
			Me.cmbLabel(k).ListIndex = gintLabelView(k) - 1
		Next
		If gblnCipherBars = True Then 
			Me.chkCipherBars.Value = 1
		Else
			Me.chkCipherBars.Value = 0
		End If
		If gblnHoldPins = True Then 
			Me.chkHoldPins.Value = 1
		Else
			Me.chkHoldPins.Value = 0
		End If
		Me.cmbSpace.ListIndex = Asc(gstrSpaceLetter) - 65
		
		For k = 1 To 32
			If gintAdvanceBar(k) <> 0 Then 
				Me.cmbBar(gintAdvanceBar(k)).ListIndex = k - 1
			End If
		Next
		
		For k = 2 To 6
			Me.cmbStep(k).ListIndex = gintBarStepping(k) - 1
		Next
		
		If gblnFastRun = True Then 
			Me.chkSpeed.Value = 1
		Else
			Me.chkSpeed.Value = 0
		End If
		
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		'save settings to regestry
		Dim k As Short
		Dim j As Short
		Dim tmp As String = ""
		
		'check for double advance bars
		For k = 2 To 6
			For j = k + 1 To 6
				If Me.cmbBar(k).ListIndex = Me.cmbBar(j).ListIndex Then 
					MsgBox6("Please select different bar numbers for each wheel!", MsgBoxStyle.Critical)
					Exit Sub
				End If
			Next
		Next

		For k = 1 To 12
			j = Me.cmbLabel(k).ListIndex
			gintLabelView(k) = j + 1
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'tmp' variable as a StringBuilder6 object.
			tmp = tmp & Format6(j + 1, "00")
		Next
		
		'set advance bars
		For k = 1 To 32
			gintAdvanceBar(k) = 0
		Next
		For k = 2 To 6
			j = Me.cmbBar(k).ListIndex + 1
			gintAdvanceBar(j) = k
			tmp &= Format6(j, "00")
		Next
		
		If Me.chkCipherBars.Value = 1 Then 
			tmp &= "1"
			gblnCipherBars = True
		Else
			tmp &= "0"
			gblnCipherBars = False
		End If
		
		If Me.chkHoldPins.Value = 1 Then 
			tmp &= "1"
			gblnHoldPins = True
		Else
			tmp &= "0"
			gblnHoldPins = False
		End If
		
		If Me.optCX52.Value = True Then 
			If gblnCxType = False Then  Call SetCX52wheels()
			gblnCxType = True
			tmp &= "1"
		Else
			If gblnCxType = True Then  Call SetC52wheels()
			gblnCxType = False
			tmp &= "0"
		End If
		
		gstrSpaceLetter = Me.cmbSpace.Text
		tmp &= Me.cmbSpace.Text
		
		For k = 2 To 6
			gintBarStepping(k) = Me.cmbStep(k).ListIndex + 1
			tmp &= Format6(gintBarStepping(k), "0")
		Next
		
		gblnFastRun = Me.chkSpeed.Value
		
		If Me.chkSpeed.Value = 0 Then 
			gblnFastRun = False
		Else
			gblnFastRun = True
		End If
		SaveSetting(App6.EXEName, "config", "fastrun", Trim(Str6(Me.chkSpeed.Value)))
		
		gstrMachineSetup = tmp
		
		SaveSetting(App6.EXEName, "config", "setup", gstrMachineSetup)
		Me.Hide()
		For k = 1 To 6
			Call SetWheelView(k)
		Next
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		Me.Hide()
	End Sub

	Private Sub cmdDefault_Click() Handles cmdDefault.Click
		Dim k As Short
		For k = 1 To 12
			gintLabelView(k) = Val(Mid(DefaultSetup, (k * 2) - 1, 2))
			Me.cmbLabel(k).ListIndex = gintLabelView(k) - 1
		Next
		For k = 2 To 6
			Me.cmbBar(k).ListIndex = k - 2
		Next
		
		For k = 2 To 6
			Me.cmbStep(k).ListIndex = 0
		Next
		
		Me.chkCipherBars.Value = 0
		Me.chkHoldPins.Value = 1
		Me.cmbSpace.ListIndex = 23
		Me.optC52.Value = True
		Me.chkSpeed.Value = 0
		
	End Sub

End Class

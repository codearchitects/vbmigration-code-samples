' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmKey

	Private tPin(6) As String
	Private tLug(32) As String
	Private tSel(6) As Short
	
	Private outPin As String = ""
	Private outSel As Short
	
	Private boxPin(12) As String
	Private oldChange As Boolean
	
	Private tLugPos As Short
	Private Const colRed As Integer = &H8080FFI
	Private Const colWhite As Integer = &HFFFFFFI
	
	Private Sub Form_Activate() Handles MyBase.Activate
		Dim k As Short
		
		oldChange = gblnKeyHasChanged
		
		With Me
			.Caption = "BC-52 Key - " & CutFilePath(gstrkeyFile)
			For k = 0 To 47
				Me.lblPin(k).Visible = False
			Next
			Me.lblColor.Visible = False
			Me.lblWheelOut.Visible = False
			Me.lblClear.Visible = False
			Me.lblPrompt.Visible = True
			Me.lblPrompt.Caption = "Select wheel from BC-52 to remove it" & ControlChars.CrLf & "or select wheel in box"
			Me.lblBox.Caption = "Wheel Selection Box"
			Me.lblC52.Caption = "BC-52"
			
			'show/hide selection box
			If gblnCxType = True Then 
				.picWheelBox.Visible = False
				.lblPrompt.Caption = "Select wheel from CX-52 to extract it" & ControlChars.CrLf & "and adjust the pins"
				.lblC52.Caption = "CX-52"
			Else
				.picWheelBox.Visible = True
				.lblPrompt.Caption = "Select wheel from C-52 to remove it"
				.lblC52.Caption = "C-52"
			End If
			
			'show wheel setup
			'transferr setup to tmp arrays
			For k = 1 To 6
				.lblWheelSet(k).Caption = Len6(Wpin(k))
				tPin(k) = Wpin(k)
				tSel(k) = Wsel(k)
			Next
			'clear used rotors in box
			For k = 1 To 12
				.lblWheelInBox(k).Visible = True
			Next
			For k = 1 To 6
				.lblWheelInBox(Wsel(k)).Visible = False
			Next
			
			Me.lblPrompt.Visible = True
			outSel = 0
			'transfer bars
			For k = 1 To 32
				tLug(k) = BLug(k)
			Next
			
			Me.VScroll1.Value = 1
			'set first bar
			Call SetBarView(1)
			
		End With
	End Sub

	Private Sub lblClear_Click() Handles lblClear.Click
		Dim k As Short
		Dim retval As String = MsgBox6("Clear all pins on wheel " & Trim(Str6(Len6(outPin))) & "?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question)
		If retval = MsgBoxResult.Cancel Then  Exit Sub
		outPin = String6(Len6(outPin), "0")
		For k = 1 To Len6(outPin)
			Me.lblPin(k).BackColor = FromOleColor6(colWhite)
		Next
		gblnKeyHasChanged = True
	End Sub

	Private Sub lblWheelSet_Click(ByRef Index As Short)
		'click on wheel in BC-52
		
		Dim k As Short
		Dim tmp As String = ""
		
		gblnKeyHasChanged = True
		If tSel(Index) <> 0 And outSel = 0 Then 
			'pull out wheel
			outPin = tPin(Index)
			outSel = tSel(Index)
			'clear wheel in c52
			tPin(Index) = ""
			tSel(Index) = 0
			Me.lblWheelSet(Index).Caption = ""
			Me.lblWheelOut.Caption = "Wheel " & Trim(Str6(Len6(outPin)))
			Me.lblWheelOut.Visible = True
			'show pins
			Me.lblColor.Visible = True
			Me.lblPin(0).Visible = True 'dummy
			Me.lblClear.Visible = True
			For k = 1 To Len6(outPin)
				Me.lblPin(k).Visible = True
				'pin on/off
				If Mid(outPin, k, 1) = "1" Then 
					Me.lblPin(k).BackColor = FromOleColor6(colRed)
				Else
					Me.lblPin(k).BackColor = FromOleColor6(colWhite)
				End If
			Next
			Me.lblPrompt.Visible = False
			Me.lblBox.Caption = "Click here to put wheel in box"
			If gblnCxType = True Then 
				Me.lblC52.Caption = "Click free place to insert wheel in CX-52"
			Else
				Me.lblC52.Caption = "Click free place to insert wheel in C-52"
			End If
		ElseIf tSel(Index) = 0 And outSel <> 0 Then 
			'put wheel in BC-52
			tPin(Index) = outPin
			tSel(Index) = outSel
			Me.lblWheelSet(Index).Caption = Trim(Str6(Len6(outPin)))
			'clear wheel out
			outPin = ""
			outSel = 0
			For k = 0 To 47
				Me.lblPin(k).Visible = False
			Next
			Me.lblColor.Visible = False
			Me.lblWheelOut.Visible = False
			Me.lblClear.Visible = False
			Me.lblPrompt.Visible = True
			If gblnCxType = True Then 
				Me.lblPrompt.Caption = "Select wheel from CX-52 to extract it" & ControlChars.CrLf & "and adjust the pins"
				Me.lblC52.Caption = "CX-52"
			Else
				Me.lblPrompt.Caption = "Select wheel from C-52 to remove it" & ControlChars.CrLf & "or select wheel in box"
				Me.lblC52.Caption = "C-52"
			End If
			Me.lblBox.Caption = "Wheel Selection Box"
		End If
	End Sub

	Private Sub lblWheelInBox_Click(ByRef Index As Short)
		'click on wheel in box
		Dim k As Short
		Dim tmp As String = ""
		
		gblnKeyHasChanged = True
		If outSel = 0 Then 
			'get wheel from box
			outPin = boxPin(Index)
			If outPin = "" Then  outPin = String6(Len6(W_textLabel(Index)), "0")
			outSel = Index
			'clear wheel in box
			boxPin(Index) = ""
			Me.lblWheelInBox(Index).Visible = False
			Me.lblWheelOut.Caption = "Wheel " & Trim(Str6(Len6(outPin)))
			Me.lblWheelOut.Visible = True
			'show pins
			Me.lblColor.Visible = True
			Me.lblPin(0).Visible = True 'dummy
			Me.lblClear.Visible = True
			For k = 1 To Len6(outPin)
				Me.lblPin(k).Visible = True
				'pin on/off
				If Mid(outPin, k, 1) = "1" Then 
					Me.lblPin(k).BackColor = FromOleColor6(colRed)
				Else
					Me.lblPin(k).BackColor = FromOleColor6(colWhite)
				End If
			Next
			Me.lblPrompt.Visible = False
			Me.lblBox.Caption = "Click here to put wheel in box"
			Me.lblC52.Caption = "Click free place to insert wheel in C-52"
		End If
	End Sub

	Private Sub picWheelBox_Click() Handles picWheelBox.Click
		If outSel = 0 Then  Exit Sub
		'put  rotor in box
		Dim k As Short = W_len(Len6(outPin))
		boxPin(k) = outPin
		Me.lblWheelInBox(k).Visible = True
		'clear wheel out
		outPin = ""
		outSel = 0
		For k = 0 To 47
			Me.lblPin(k).Visible = False
		Next
		Me.lblColor.Visible = False
		Me.lblWheelOut.Visible = False
		Me.lblClear.Visible = False
		Me.lblPrompt.Visible = True
		Me.lblBox.Caption = "Wheel Selection Box"
		
		If gblnCxType = True Then 
			Me.lblPrompt.Caption = "Select wheel from CX-52 to remove it" & ControlChars.CrLf & "or select wheel in box"
			Me.lblC52.Caption = "CX-52"
		Else
			Me.lblPrompt.Caption = "Select wheel from C-52 to remove it" & ControlChars.CrLf & "or select wheel in box"
			Me.lblC52.Caption = "C-52"
		End If
	End Sub

	Private Sub lblBox_Click() Handles lblBox.Click
		Call picWheelBox_Click()
	End Sub

	Private Sub lblPin_Click(ByRef Index As Short)
		gblnKeyHasChanged = True
		'click on pin
		If Mid(outPin, Index, 1) = "0" Then 
			'set pin
			Mid(outPin, Index, 1) = "1"
			Me.lblPin(Index).BackColor = FromOleColor6(colRed)
		Else
			'clear pin
			Mid(outPin, Index, 1) = "0"
			Me.lblPin(Index).BackColor = FromOleColor6(colWhite)
		End If
	End Sub

	Private Sub lblLug_Click(ByRef Index As Short)
		'set lug
		If Index = 0 Then  Exit Sub
		If Mid(tLug(tLugPos), Index, 1) = "0" Then 
			'set lug
			Mid(tLug(tLugPos), Index, 1) = "1"
			Me.lblLug(Index).BackColor = FromOleColor6(colRed)
		Else
			'clear pin
			Mid(tLug(tLugPos), Index, 1) = "0"
			Me.lblLug(Index).BackColor = FromOleColor6(colWhite)
		End If
		gblnKeyHasChanged = True
	End Sub

	Private Sub SetBarView(ByVal bar As Short)
		Dim k As Short
		'set view from bars
		Me.lblLug(0).Caption = "Bar " & Trim(Str6(bar))
		For k = 1 To 6
			If Mid(tLug(tLugPos), k, 1) = "0" Then 
				Me.lblLug(k).BackColor = FromOleColor6(colWhite)
			Else
				Me.lblLug(k).BackColor = FromOleColor6(colRed)
			End If
		Next
		k = gintAdvanceBar(bar)
		If k <> 0 Then 
			Me.lblLugMsg.Caption = "Bar " & Trim(Str6(bar)) & " is used for moving wheel " & Str6(Str6(k))
			If gintBarStepping(k) = 1 Then 
				Me.lblLugMsg.Caption = Me.lblLugMsg.Caption & ControlChars.CrLf & "Wheel " & Str6(Str6(k)) & " moves if this bar is activated"
			ElseIf gintBarStepping(k) = 2 Then 
				Me.lblLugMsg.Caption = Me.lblLugMsg.Caption & ControlChars.CrLf & "Wheel " & Str6(Str6(k)) & " moves if this bar is not activated"
			ElseIf gintBarStepping(k) = 3 Then 
				Me.lblLugMsg.Caption = Me.lblLugMsg.Caption & ControlChars.CrLf & "Wheel " & Str6(Str6(k)) & " always moves!"
			ElseIf gintBarStepping(k) = 4 Then 
				Me.lblLugMsg.Caption = Me.lblLugMsg.Caption & ControlChars.CrLf & "Wheel " & Str6(Str6(k)) & " will never move!"
			End If
			If gblnCipherBars = True Then  Me.lblLugMsg.Caption = Me.lblLugMsg.Caption & ControlChars.CrLf & "This bar is also used for ciphering"
		Else
			Me.lblLugMsg.Caption = ""
		End If
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Dim k As Short
		'check for empty wheels
		For k = 1 To 6
			If tPin(k) = "" Then 
				MsgBox6("Please insert 6 wheels in BC-52", MsgBoxStyle.Critical)
				Exit Sub
			End If
		Next
		'validate settings
		'transfer tmps to effective sheels
		For k = 1 To 6
			Wpin(k) = tPin(k)
			Wmax(k) = Len6(Wpin(k))
			Wsel(k) = tSel(k)
			Wpos(k) = 1
		Next
		Call CreateLabels()
		Call resetAllWheels()
		
		For k = 1 To 6
			SetWheelView((k))
		Next
		'bars
		For k = 1 To 32
			BLug(k) = tLug(k)
		Next
		
		For k = 0 To 47
			Me.lblPin(k).Visible = False
		Next
		Me.lblColor.Visible = False
		Me.lblWheelOut.Visible = False
		Me.lblClear.Visible = False
		Me.lblPrompt.Visible = True
		Me.lblPrompt.Caption = "Select wheel from BC-52 to remove it" & ControlChars.CrLf & "or select wheel in box"
		Me.lblBox.Caption = "Wheel Selection Box"
		Me.lblC52.Caption = "BC-52"
		
		'If gblnKeyHasChanged = True Then gstrkeyFile = "Untitled"
		
		Me.Hide()
		
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		gblnKeyHasChanged = oldChange
		Me.Hide()
	End Sub

	Private Sub VScroll1_Change() Handles VScroll1.Change
		tLugPos = Me.VScroll1.Value
		Call SetBarView(tLugPos)
	End Sub

End Class

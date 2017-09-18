' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmKeySheet

	Private Sub cmdClose_Click() Handles cmdClose.Click
		Me.Hide()
	End Sub

	Private Sub cmdCopy_Click() Handles cmdCopy.Click
		On Error Resume Next 
		Clipboard6.Clear()
		Clipboard6.SetText(Me.txtKey.Text)
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Dim k As Short
		Dim j As Short
		Dim pMax As Short
		Dim tmp As String = ""
		Dim pin As String = ""
		Dim strLine As String = ""
		Dim strKeyText As String = ""
		
		Me.Caption = "BC-52 Key - " & CutFilePath(gstrkeyFile)
		
		'
		strLine = "----------------------------------" & ControlChars.CrLf
		
		tmp = strLine & "        BC-52 KEY SETTINGS " & ControlChars.CrLf & strLine
		
		For k = 1 To 6
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'tmp' variable as a StringBuilder6 object.
			tmp = tmp & Format6(Wmax(k), "00") & " "
		Next
		
		tmp = tmp & " NR  1 2 3 4 5 6" & ControlChars.CrLf & strLine
		
		'get max pins
		For k = 1 To 6
			If Wmax(k) > pMax Then  pMax = Wmax(k)
		Next
		
		For k = 1 To pMax
			
			For j = 1 To 6
				'read pins
				If k <= Wmax(j) Then 
					pin = Mid(Wpin(j), k, 1)
					If pin = "1" Then 
						tmp = tmp & Format6(k, "00") & " "
					Else
						tmp = tmp & "-- "
					End If
				Else
					tmp &= "   "
				End If
			Next
			
			tmp = tmp & " " & Format6(k, "00") & "  "
			
			'read lugs
			If k < 33 Then 
				For j = 1 To 6
					pin = Mid(BLug(k), j, 1)
					If pin = "1" Then 
						tmp = tmp & Trim(Val(j)) & " "
					Else
						tmp = tmp & "- "
					End If
				Next
			End If
			
			tmp &= ControlChars.CrLf
			
		Next
		
		tmp &= strLine
		
		Me.txtKey.Text = tmp
	End Sub

End Class

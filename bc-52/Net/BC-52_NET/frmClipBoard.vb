' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmClipBoard

	Private strClipText As String = ""
	
	Private Sub chkGroups_Click()
		Call ApplyFormat()
	End Sub

	Private Sub cmdApply_Click() Handles cmdApply.Click
		Call ApplyFormat()
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Me.cmdOK.SetFocus()
		Call ApplyFormat()
		Me.txtFormat.Text = strClipText
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Me.optOutput.Value = True
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		Me.Hide()
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		On Error Resume Next 
		Clipboard6.Clear()
		Clipboard6.SetText(Me.txtFormat.Text)
		Me.Hide()
	End Sub

	Private Sub ApplyFormat()
		'apply new format
		On Error Resume Next 
		
		If Me.optInput.Value = True Then 
			strClipText = gstrInput
			If gblnModeCipher = True Then 
				strClipText = strClipText
				Me.txtLF.Enabled = True
				Me.txtLF.BackColor = Color.Silver 
			Else
				strClipText = MakeGroups(strClipText)
				Me.txtLF.Enabled = True
				Me.txtLF.BackColor = Color.White 
			End If
		Else
			strClipText = gstrOutput
			If gblnModeCipher = True Then 
				Me.txtLF.Enabled = True
				Me.txtLF.BackColor = Color.White 
				strClipText = MakeGroups(strClipText)
			Else
				Me.txtLF.Enabled = True
				Me.txtLF.BackColor = Color.Silver 
				strClipText = strClipText
			End If
		End If
		
		Me.txtFormat.Text = strClipText
		
	End Sub

	Private Function MakeGroups(ByVal aText As String) As String
		
		Dim k As Integer
		Dim strTmp As String = ""
		Dim Groups As Short = 1
		Dim G As Short = 1
		
		Me.txtLF.Enabled = True
		Me.txtLF.BackColor = Color.White 
		
		For k = 1 To Len6(aText)
			G += 1
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'strTmp' variable as a StringBuilder6 object.
			strTmp &= Mid(aText, k, 1)
			If G = 6 Then 
				G = 1
				strTmp &= " "
				Groups += 1
				If Groups = Val(Me.txtLF.Text) + 1 Then  strTmp &= ControlChars.CrLf: Groups = 1
			End If
		Next
		Return strTmp
	End Function

	Private Sub optInput_Click() Handles optInput.Click
		Call ApplyFormat()
	End Sub

	Private Sub optOutput_Click() Handles optOutput.Click
		Call ApplyFormat()
	End Sub

	Private Sub txtLF_KeyPress(ByRef KeyAscii As Short) Handles txtLF.KeyPress
		'limit input groups to figures
		Select Case KeyAscii
		Case 8, 9
			Exit Sub
		Case Is < 48, Is > 57
			KeyAscii = 0
		End Select
	End Sub

	Private Sub txtLF_GotFocus() Handles txtLF.GotFocus
		Me.txtLF.SelStart = 0
		Me.txtLF.SelLength = Len6(Me.txtLF.Text)
	End Sub

End Class

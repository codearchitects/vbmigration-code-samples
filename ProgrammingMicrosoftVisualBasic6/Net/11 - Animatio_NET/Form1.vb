' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' smart resize of the Animation control.
	
	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		Animation1.Width = ScaleWidth - Animation1.Left
		Animation1.Height = ScaleHeight - Animation1.Top - Animation1.Left
	End Sub

	' Enable the Play button only if a file has been specified.
	
	Private Sub txtFilename_Change() Handles txtFilename.Change
		cmdPlay.Enabled = (txtFilename.Text <> "")
	End Sub

	' Select an AVI file.
	
	Private Sub cmdBrowse_Click() Handles cmdBrowse.Click
		With CommonDialog1
			.Filter = "All files|*.*|AVI files|*.avi"
			.FilterIndex = 2
			.FileName = txtFilename.Text
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
			.ShowOpen()
			If Len6(.FileName) Then  txtFilename.Text = .FileName
		End With
	End Sub

	' Select a BackColor for the Animation control.
	
	Private Sub cmdBackColor_Click() Handles cmdBackColor.Click
		With CommonDialog1
			.Color = Animation1.BackColor
			.ShowColor()
			Animation1.BackColor = .Color
		End With
	End Sub

	' Play the AVI file
	
	Private Sub cmdPlay_Click() Handles cmdPlay.Click
		Dim numTimes As Integer
		Dim fromFrame As Integer
		Dim toFrame As Integer
		On Error GoTo ErrorHandler 
		
		' Open the AVI file (trap any error).
		Animation1.AutoPlay = False
		Animation1.Open(txtFilename.Text)
		' Build default arguments, if needed.
		If Len6(txtTimes.Text) Then  numTimes = CInt(txtTimes.Text) Else numTimes = -1
		If Len6(txtFromFrame.Text) Then  fromFrame = CInt(txtFromFrame.Text) Else fromFrame = 0
		If Len6(txtToFrame.Text) Then  toFrame = CInt(txtToFrame.Text) Else toFrame = -1
		' Start the animation.
		Animation1.Play(numTimes, fromFrame, toFrame)
		
		If numTimes < 0 Then  cmdPlay.Enabled = False
		cmdStop.Enabled = True
		Exit Sub
		
ErrorHandler:
		MsgBox6(Err.Description, MsgBoxStyle.Exclamation)
		
	End Sub

	' Stop the animation.
	
	Private Sub cmdStop_Click() Handles cmdStop.Click
		Animation1.Stop()
		cmdPlay.Enabled = True
		cmdStop.Enabled = False
	End Sub

End Class

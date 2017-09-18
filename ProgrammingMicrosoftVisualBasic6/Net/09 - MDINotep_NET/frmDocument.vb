' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDocument

	' this is True if the contents of the editor has been modified
	Public IsDirty As Boolean
	
	Private m_FileName As String = ""

	Public Property Filename() As String
		Get
			Return m_FileName
	 	End Get
		Set(ByVal newValue As String)
			m_FileName = newValue
			' show the filename on the form's Caption
			Caption = IIf(newValue = "", "Untitled", newValue)
	 	End Set
	End Property

	Private Sub Form_Resize() Handles MyBase.Resize
		txtEditor.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Dim answer As Short
		If IsDirty Then 
			answer = MsgBox6("This document has been modified. " & ControlChars.Cr & "Do you want to save it?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information)
			Select Case answer
			Case MsgBoxResult.No
				' do nothing: the form will unload without saving data
			Case MsgBoxResult.Yes
				' delegate to a procedure in the main MDI form
				frmMainMDI.SaveToFile(Filename)
			Case MsgBoxResult.Cancel
				' refuse to unload the form
				Cancel = CShort(True)
			End Select
		End If
	End Sub

	Private Sub txtEditor_Change() Handles txtEditor.Change
		IsDirty = True
	End Sub

End Class

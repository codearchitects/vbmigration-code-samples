' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' demo for the CFile Class
	
	Private Sub Command1_Click() Handles Command1.Click
		Dim f As New CFile
		Try
		
		' this file should be in the C:\ root directory
		f.OpenFile("test.txt", OpenModeConstants.omInput)
		' read the file
		Text1.Text = FileInputString6(f.Handle, LOF6(f.Handle))
		' no need to close it before exiting the procedure
		Finally
			' Clean up all disposable variables
			SetNothing6(f)
		End Try
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Dim f As New CTempFile
		Try
		
		' open a temporary file (real world apps should
		f.OpenFile("C:", , OpenModeConstants.omOutput)
		
		' do whatever you want with your file
		FilePrintLine6(f.Handle, Text1.Text)
		
		MsgBox6("Temporary file " & f.Filename & " has been created" & ControlChars.Cr & "Press OK to close and delete it")
		' don't need to explicitly close or delete it before exiting
		Finally
			' Clean up all disposable variables
			SetNothing6(f)
		End Try
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Dim m As New CMouse
		Try
		
		m.SetPointer()
		MsgBox6("Click OK to exit this procedure")
		' no need to restore the mouse pointer
		Finally
			' Clean up all disposable variables
			SetNothing6(m)
		End Try
	End Sub

End Class

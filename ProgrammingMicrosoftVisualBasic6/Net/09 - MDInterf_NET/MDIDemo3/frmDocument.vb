' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDocument

	' True if the contents of the document has been modified
	Public IsDirty As Boolean
	
	' the name of the file associated to this document
	Private m_Filename As String = ""

	Public Property Filename() As String
		Get
			Return m_Filename
	 	End Get
		Set(ByVal newValue As String)
			m_Filename = newValue
			Caption = IIf(newValue = "", "(untitled)", newValue)
	 	End Set
	End Property

	' read-only properties
	
	Public ReadOnly Property IsEmpty() As Boolean
		Get
			Return (txtText.Text = "")
	 	End Get
	End Property

	Public ReadOnly Property CanSave() As Boolean
		Get
			Return IsDirty
	 	End Get
	End Property

	Public ReadOnly Property CanCopy() As Boolean
		Get
			Return (txtText.SelLength > 0)
	 	End Get
	End Property

	Public ReadOnly Property CanCut() As Boolean
		Get
			Return (txtText.SelLength > 0)
	 	End Get
	End Property

	Public ReadOnly Property CanPaste() As Boolean
		Get
			Return (Clipboard6.GetText() <> "")
	 	End Get
	End Property

	Public ReadOnly Property CanPrint() As Boolean
		Get
			Return (txtText.Text <> "")
	 	End Get
	End Property

	' Public Methods
	
	Public Sub Copy()
		Clipboard6.SetText(txtText.SelText)
	End Sub

	Public Sub Cut()
		Clipboard6.SetText(txtText.SelText)
		txtText.SelText = ""
	End Sub

	Public Sub Paste()
		txtText.SelText = Clipboard6.GetText()
	End Sub

	Public Sub PrintDoc()
		Printer6.NewPage()
		Printer6.PrintLine(txtText.Text)
		Printer6.EndDoc()
	End Sub

	Public Sub LoadFile(ByVal newFile As String)
		Dim fnum As Short
		On Error GoTo LoadFile_Error 
		
		If newFile = "" Then  Exit Sub
		
		fnum = FreeFile6()
		FileOpen6(fnum, newFile, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		txtText.Text = FileInputString6(fnum, LOF6(fnum))
		FileClose6(fnum)
		
		' show the new caption
		Filename = newFile
		IsDirty = False
		Exit Sub
		
LoadFile_Error:
		MsgBox6("Error while opening file: " & newFile, MsgBoxStyle.Critical)
		
	End Sub

	Public Sub SaveFile(ByVal newFile As String)
		Dim fnum As Short
		On Error GoTo SaveFile_Error 
		
		If newFile = "" Then  Exit Sub
		
		fnum = FreeFile6()
		FileOpen6(fnum, newFile, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		FilePrintLine6(fnum, txtText.Text)
		FileClose6(fnum)
		
		' show the new caption
		Filename = newFile
		IsDirty = False
		Exit Sub
		
SaveFile_Error:
		MsgBox6("Error while writing file: " & newFile, MsgBoxStyle.Critical)
		
	End Sub

	Public Function AskFilename(ByVal saveFlag As Boolean) As Object
		' ask a filename for this document
		' saveFlag is False for Open, True for Save
		CommonDialog1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
		CommonDialog1.FilterIndex = 2
		If saveFlag Then 
			CommonDialog1.ShowSave()
		Else
			CommonDialog1.ShowOpen()
		End If
		Return CommonDialog1.FileName
		
	End Function

	Private Sub Form_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		' ask to confirm or save, if data has been modified
		Dim answer As Short
		
		' do nothing if data is not modified
		If Not IsDirty Then  Exit Sub
		
		answer = MsgBox6("The text in this window has been modified." & ControlChars.Cr & "Do you wish to save it?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, Me.Caption)
		Select Case answer
		Case MsgBoxResult.No
			Exit Sub
		Case MsgBoxResult.Cancel
			Cancel = CShort(True)
			Exit Sub
		Case MsgBoxResult.Yes
			If m_Filename = "" Then 
				m_Filename = AskFilename(True)
				If m_Filename = "" Then 
					Cancel = CShort(True)
					Exit Sub
				End If
			End If
			SaveFile(m_Filename)
		End Select
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		txtText.Move(0, 0, ScaleWidth, ScaleHeight)
		' force the redraw of the caption
		Filename = m_Filename
	End Sub

	Private Sub txtText_Change() Handles txtText.Change
		' set the IsDirty flag
		IsDirty = True
	End Sub

End Class

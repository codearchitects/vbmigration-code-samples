' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDocument2

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
			If newValue = "" Then 
				Caption = "(no name)"
			Else
				Caption = newValue
			End If
	 	End Set
	End Property

	' read-only properties
	
	Public ReadOnly Property IsEmpty() As Boolean
		Get
			Return (picBitmap.Picture Is Nothing)
	 	End Get
	End Property

	Public ReadOnly Property CanSave() As Boolean
		Get
			Return IsDirty
	 	End Get
	End Property

	Public ReadOnly Property CanCopy() As Boolean
		Get
			Return Not IsEmpty
	 	End Get
	End Property

	Public ReadOnly Property CanCut() As Boolean
		Get
			Return Not IsEmpty
	 	End Get
	End Property

	Public ReadOnly Property CanPaste() As Boolean
		Get
			Return Not (Clipboard6.GetData() Is Nothing)
	 	End Get
	End Property

	Public ReadOnly Property CanPrint() As Boolean
		Get
			Return Not IsEmpty
	 	End Get
	End Property

	' Public Methods
	
	Public Sub Copy()
		Clipboard6.SetData(picBitmap.Picture)
	End Sub

	Public Sub Cut()
		Clipboard6.SetData(picBitmap.Picture)
		picBitmap.Picture = Nothing
	End Sub

	Public Sub Paste()
		picBitmap.Picture = Clipboard6.GetData()
		IsDirty = True
	End Sub

	Public Sub PrintDoc()
		Printer6.NewPage()
		Printer6.PaintPicture(picBitmap.Picture, 0, 0)
		Printer6.EndDoc()
	End Sub

	Public Sub LoadFile(ByVal newFile As String)
		Dim fnum As Short
		On Error GoTo LoadFile_Error 
		
		If newFile = "" Then  Exit Sub
		
		picBitmap.Picture = LoadPicture6(newFile)
		
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
		
		' UPGRADE_WARNING (#1094): The SavePicture method isn't fully supported. The SavePicture6 replacement method always saves the image in BMP format.
		SavePicture6(picBitmap.Image, newFile)
		
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
		If saveFlag Then 
			CommonDialog1.Filter = "All Files (*.*)|*.*|Bitmaps (*.bmp)|*.bmp"
		Else
			CommonDialog1.Filter = "All Files (*.*)|*.*|All picture files|*.bmp;*.dib;*.wmf;*.emf;*.gif;*.jpg|" & "Bitmaps (*.bmp;*.dib)|*.bmp;*.dib|Metafiles (*.wmf;*.emf)|*.wmf;*.emf|" & "GIF Files (*.gif)|*.gif|JPEG Files (*.jpg)|*.jpg"
		End If
		
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
		
		answer = MsgBox6("The picture in this window has been modified." & ControlChars.Cr & "Do you wish to save it?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, Me.Caption)
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
		picBitmap.Move(0, 0, ScaleWidth, ScaleHeight)
		' force the redraw of the caption
		Filename = m_Filename
	End Sub

End Class

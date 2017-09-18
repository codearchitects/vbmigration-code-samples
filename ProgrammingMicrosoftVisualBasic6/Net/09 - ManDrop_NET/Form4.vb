' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form4

	' note that in the original API declaration - as reported by the API viewer -
	' this function is declared As Long. However, because the SetData method only
	' accept Integer formats we need to declare it as Integer, otherwise an
	' overflow error will occur
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegisterClipboardFormat' unamanged method with the following .NET member(s): System.Windows.Forms.DataFormats.GetFormat
	Private Declare Function RegisterClipboardFormat Lib "user32" Alias "RegisterClipboardFormatA" (ByVal lpString As String) As Short
	
	Private CustomFormat As Short
	Private Dragging As Short ' 1=copying, 2=moving
	
	Private Sub Form_Load() Handles MyBase.Load
		' register a custom clipboard format
		CustomFormat = RegisterClipboardFormat("PersonalData")
	End Sub

	Private Sub imgDrag_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles imgDrag.MouseDown
		If Button = 2 Then 
			Dragging = IIf(Shift And VBRUN.ShiftConstants.vbCtrlMask, 1, 2)
			imgDrag.OLEDrag()
		End If
	End Sub

	Private Sub imgDrag_OLEStartDrag(ByRef Data As VB6DataObject, ByRef AllowedEffects As Integer) Handles imgDrag.OLEStartDrag
		' signal that we are moving data in proprietary format
		Data.SetData(, CustomFormat)
		AllowedEffects = IIf(Dragging = 1, VBRUN.OLEDropEffectConstants.vbDropEffectCopy, VBRUN.OLEDropEffectConstants.vbDropEffectMove)
	End Sub

	Private Sub imgDrag_OLESetData(ByRef Data As VB6DataObject, ByRef DataFormat As Short) Handles imgDrag.OLESetData
		' build a long string made up of field contents
		Dim i As Short
		Dim text As String = ""
		Dim bytes() As Byte
		For i = 0 To txtField.UBound()
			If i > 0 Then  text &= ControlChars.NullChar
			text &= txtField(i).Text
		Next
		' move to an array the byte, then assign to DataObject
		bytes = StringToByteArray6(text)
		Data.SetData(bytes, CustomFormat)
	End Sub

	Private Sub imgDrag_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single, ByRef State As Short) Handles imgDrag.OLEDragOver
		If Dragging Or Data.GetFormat(CustomFormat) = False Then 
			' prevent from dropping on this same form
			Effect = 0
		End If
	End Sub

	Private Sub imgDrag_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles imgDrag.OLEDragDrop
		Dim bytes() As Byte
		Dim text() As String
		Dim i As Short
		
		' get the data
		bytes = Data.GetData(CustomFormat)
		' retrieve individual values, and assign to fields
		text = Split(CStr(ByteArrayToString6(bytes)), ControlChars.NullChar)
		For i = 0 To txtField.UBound()
			txtField(i).Text = text(i)
		Next
	End Sub

	Private Sub imgDrag_OLECompleteDrag(ByRef Effect As Integer) Handles imgDrag.OLECompleteDrag
		Dim i As Short
		If Dragging = 2 Then 
			'this was a move command
			For i = 0 To txtField.UBound()
				txtField(i).Text = ""
			Next
		End If
		' prepare for another drag (or drop) command
		Dragging = 0
	End Sub

End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form3

	Private Sub Drive1_Change() Handles Drive1.Change
		Dir1.Path = Drive1.List(Drive1.ListIndex)
	End Sub

	Private Sub Dir1_Change() Handles Dir1.Change
		File1.Path = Dir1.List(Dir1.ListIndex)
	End Sub

	Private Sub File1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles File1.MouseDown
		If Button = 2 Then  File1.OLEDrag()
	End Sub

	Private Sub File1_OLEStartDrag(ByRef Data As VB6DataObject, ByRef AllowedEffects As Integer) Handles File1.OLEStartDrag
		Dim i As Short
		Dim path As String = ""
		path = File1.Path & IIf(VB.Right(File1.Path, 1) <> "\", "\", "")
		
		' add all selected files
		Data.Files.Clear()
		For i = 0 To File1.ListCount - 1
			If File1.Selected(i) Then 
				Data.Files.Add(path & File1.List(i))
			End If
		Next
		
		If Data.Files.Count Then 
			' only if we actually added files
			Data.SetData(, VBRUN.ClipBoardConstants.vbCFFiles)
			AllowedEffects = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
		End If
	End Sub

End Class

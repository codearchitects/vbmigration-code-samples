' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const MNU_EDITUNDO As Short = 0
	Private Const MNU_EDITCUT As Short = 2
	Private Const MNU_EDITCOPY As Short = 3
	Private Const MNU_EDITPASTE As Short = 4
	Private Const MNU_EDITCLEAR As Short = 6
	Private Const MNU_EDITSELECTALL As Short = 7
	
	Private Sub Form_Resize() Handles MyBase.Resize
		Text1.Move(0, 0, ScaleWidth / 2, ScaleHeight / 2)
		RichTextBox1.Move(0, ScaleHeight / 2, ScaleWidth / 2, ScaleHeight / 2)
		Picture1.Move(ScaleWidth / 2, 0, ScaleWidth / 2, ScaleHeight)
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		Unload6(Me)
	End Sub

	' enable/disable items in the Edit menu
	
	Private Sub mnuEdit_Click() Handles mnuEdit.Click
		Dim supSelText As Boolean
		Dim supPicture As Boolean
		
		On Error Resume Next 
		
		' disable all menu items here
		mnuEditItem(MNU_EDITUNDO).Enabled = False
		mnuEditItem(MNU_EDITCUT).Enabled = False
		mnuEditItem(MNU_EDITCOPY).Enabled = False
		mnuEditItem(MNU_EDITPASTE).Enabled = False
		mnuEditItem(MNU_EDITCLEAR).Enabled = False
		mnuEditItem(MNU_EDITSELECTALL).Enabled = False
		
		' check which properties are supported by the active control
		supSelText = Len6(ActiveControl.SelText) >= 0
		supPicture = (ActiveControl.Picture Is Nothing) Or True
		' if no property is supported, exit right now
		If (supSelText Or supPicture) = 0 Then  Exit Sub
		
		' process the Cut menu
		If supSelText Then 
			mnuEditItem(MNU_EDITCUT).Enabled = Len6(ActiveControl.SelText)
		Else
			mnuEditItem(MNU_EDITCUT).Enabled = Not (ActiveControl.Picture Is Nothing)
		End If
		
		' the Copy menu command is similar to Cut
		mnuEditItem(MNU_EDITCOPY).Enabled = mnuEditItem(MNU_EDITCUT).Enabled
		
		' process the Paste menu
		If supSelText Then 
			mnuEditItem(MNU_EDITPASTE).Enabled = Clipboard6.GetFormat(VBRUN.ClipBoardConstants.vbCFText)
		Else
			mnuEditItem(MNU_EDITPASTE).Enabled = Clipboard6.GetFormat(VBRUN.ClipBoardConstants.vbCFBitmap) Or Clipboard6.GetFormat(VBRUN.ClipBoardConstants.vbCFMetafile)
		End If
		
		' process the Clear command
		If supSelText Then 
			mnuEditItem(MNU_EDITCLEAR).Enabled = Len6(ActiveControl.SelText)
		Else
			mnuEditItem(MNU_EDITCLEAR).Enabled = Not (ActiveControl.Picture Is Nothing)
		End If
		
		' process the SelectAll command
		If supSelText Then 
			mnuEditItem(MNU_EDITSELECTALL).Enabled = Len6(ActiveControl.Text)
		End If
	End Sub

	Private Sub mnuEditItem_Click(ByRef Index As Short)
		Dim supSelText As Boolean
		Dim supSelRTF As Boolean
		Dim supPicture As Boolean
		
		On Error Resume Next 
		
		' check which properties are supported by the active control
		supSelText = Len6(ActiveControl.SelText) >= 0
		supSelRTF = Len6(ActiveControl.SelRTF) >= 0
		supPicture = (ActiveControl.Picture Is Nothing) Or True
		' if no property is supported, exit right now
		If (supSelText Or supSelRTF Or supPicture) = 0 Then  Exit Sub
		Err.Clear()
		
		Select Case Index
		Case MNU_EDITUNDO
			' this menu item isn't used in this demo program
		Case MNU_EDITCUT
			If supSelText Then 
				Clipboard6.Clear()
				If supSelRTF Then 
					' if it also supports SelText, cut it too
					Clipboard6.SetText(ActiveControl.SelRTF, VBRUN.ClipBoardConstants.vbCFRTF)
				End If
				Clipboard6.SetText(ActiveControl.SelText)
				ActiveControl.SelText = ""
			Else
				Clipboard6.SetData(ActiveControl.Picture)
				ActiveControl.Picture = Nothing
			End If
		Case MNU_EDITCOPY
			' similar to Cut, but the current selection isn't deleted
			If supSelText Then 
				Clipboard6.Clear()
				If supSelRTF Then 
					' if it also supports SelText, cut it too
					Clipboard6.SetText(ActiveControl.SelRTF, VBRUN.ClipBoardConstants.vbCFRTF)
				End If
				Clipboard6.SetText(ActiveControl.SelText)
			Else
				Clipboard6.SetData(ActiveControl.Picture)
			End If
		Case MNU_EDITPASTE
			If supSelRTF And Clipboard6.GetFormat(VBRUN.ClipBoardConstants.vbCFRTF) Then 
				' paste RTF text if possible
				ActiveControl.SelRTF = Clipboard6.GetText(VBRUN.ClipBoardConstants.vbCFText)
			ElseIf supSelText Then 
				' else, paste regular text
				ActiveControl.SelText = Clipboard6.GetText(VBRUN.ClipBoardConstants.vbCFText)
			ElseIf Clipboard6.GetFormat(VBRUN.ClipBoardConstants.vbCFBitmap) Then 
				' first, try with bitmap data
				ActiveControl.Picture = Clipboard6.GetData(VBRUN.ClipBoardConstants.vbCFBitmap)
			Else
				' else, try with metafile data
				ActiveControl.Picture = Clipboard6.GetData(VBRUN.ClipBoardConstants.vbCFMetafile)
			End If
		Case MNU_EDITCLEAR
			If supSelText Then 
				ActiveControl.SelText = ""
			Else
				ActiveControl.Picture = Nothing
			End If
		Case MNU_EDITSELECTALL
			If supSelText Then 
				ActiveControl.SelStart = 0
				ActiveControl.SelLength = Len6(ActiveControl.Text)
			End If
		End Select
	End Sub

	Private Sub Picture1_GotFocus() Handles Picture1.GotFocus
		Debug.WriteLine("GotFocus")
	End Sub

	Private Sub Picture1_LostFocus() Handles Picture1.LostFocus
		Debug.WriteLine("LostFocus")
	End Sub

End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmCoolbar

	#Region "Unsupported controls"
	
		' UPGRADE_ISSUE (#02C8): Controls of type ComCtl3.CoolBar aren't supported. This control was replaced by a dummy variable to make the VB.NET compiler happy
	Friend CoolBar1 As Object
	
	#End Region

	' Load the name of screen fonts into the Combo box.
	
	Private Sub Form_Load() Handles MyBase.Load
		
		' Put the Toolbar Wrapper controls in the Coolbar band
		TransTBWrapper1.Container = CoolBar1
		CoolBar1.Bands(1).Child = TransTBWrapper1
		' Put the toolbar into the toolbar wrapper
		TransTBWrapper1.Toolbar = Toolbar1
		
		Dim i As Short
		' UPGRADE_WARNING (#80D4): This property returns the number of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
		For i = 0 To Screen6.FontCount - 1
			' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
			cboFonts.AddItem(Screen6.Fonts(i))
			' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
			If Screen6.Fonts(i) = FontName Then  cboFonts.ListIndex = i
		Next
	End Sub

	' Resize the PictureBox when the form resizes.
	
	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'CoolBar1.Height'. Consider using the GetDefaultMember6 helper method.
		Picture1.Move(0, CoolBar1.Height, ScaleWidth, ScaleHeight - CoolBar1.Height)
	End Sub

	' Resize and move the PictureBox when the Coolbar's height changes.
	
	Private Sub CoolBar1_HeightChanged(ByVal NewHeight As Single)
		Picture1.Move(0, NewHeight, ScaleWidth, ScaleHeight - NewHeight)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' it is VERY important to set the wrapper's Toolbar property
		' to Nothing before the form is unloaded
		CoolBar1.Visible = False
		TransTBWrapper1.Toolbar = Nothing
	End Sub

	' Resize the controls inside the PictureBox when the latter is resized.
	
	Private Sub Picture1_Resize() Handles Picture1.Resize
		On Error Resume Next 
		Label1.Move(0, 0, Picture1.ScaleWidth, Label1.Height)
		Text1.Move(0, Label1.Height, Picture1.ScaleWidth, Picture1.ScaleHeight - Label1.Height)
	End Sub

	' Add a new Band object with a ComboBox inside it
	
	Private Sub cmdAddBand_Click() Handles cmdAddBand.Click
		' First, create a new ComboBox. Note how the Bands' Count
		' Property is used to assign a unique name to the control.
		Dim cb As VB6ComboBox = Controls6.Add("VB.ComboBox", "Combo" & CoolBar1.Bands.Count)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'CoolBar1.Bands.Count'. Consider using the GetDefaultMember6 helper method.
		' Make the ComboBox a child of the Coolbar control.
		cb.Container = CoolBar1
		' Create a new Band object.
		CoolBar1.Bands.Add(, , cb.Name, , , cb)
		
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal Button As VB6Button) Handles Toolbar1.ButtonClick
		On Error Resume Next 
		Select Case Button.Key
		Case "New"
			'ToDo: Add 'New' button code.
			MsgBox6("Add 'New' button code.")
		Case "Open"
			'ToDo: Add 'Open' button code.
			MsgBox6("Add 'Open' button code.")
		Case "Save"
			'ToDo: Add 'Save' button code.
			MsgBox6("Add 'Save' button code.")
		Case "Print"
			'ToDo: Add 'Print' button code.
			MsgBox6("Add 'Print' button code.")
		Case "Find"
			'ToDo: Add 'Find' button code.
			MsgBox6("Add 'Find' button code.")
		Case "Undo"
			'ToDo: Add 'Undo' button code.
			MsgBox6("Add 'Undo' button code.")
		Case "Redo"
			'ToDo: Add 'Redo' button code.
			MsgBox6("Add 'Redo' button code.")
		Case "Bold"
			'ToDo: Add 'Bold' button code.
			MsgBox6("Add 'Bold' button code.")
		Case "Italic"
			'ToDo: Add 'Italic' button code.
			MsgBox6("Add 'Italic' button code.")
		Case "Underline"
			'ToDo: Add 'Underline' button code.
			MsgBox6("Add 'Underline' button code.")
		End Select
	End Sub

End Class

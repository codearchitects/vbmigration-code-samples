' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Fun As New Object
	
	Private Sub Form_Resize() Handles MyBase.Resize
		' set a custom graphic coordinate system, so that
		' the visible viewport corresponds to constants above
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMin'. Consider using the GetDefaultMember6 helper method.
		ScaleLeft = Fun.XMin
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMax'. Consider using the GetDefaultMember6 helper method.
		ScaleTop = Fun.YMax
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMax'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMin'. Consider using the GetDefaultMember6 helper method.
		ScaleWidth = Fun.XMax - Fun.XMin
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMax'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMin'. Consider using the GetDefaultMember6 helper method.
		ScaleHeight = -(Fun.YMax - Fun.YMin)
		' force a Paint event
		Refresh()
	End Sub

	Private Sub Form_Paint() Handles MyBase.Paint
		Dim X As Single
		Dim Y As Single
		
		' start with a blank canvas
		Cls()
		ForeColor = Color.Black 
		
		' explain what is being displayed
		CurrentX = ScaleLeft
		CurrentY = ScaleTop
		PrintLine(Fun.FunctionText)
		CurrentX = ScaleLeft
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMin'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMax'. Consider using the GetDefaultMember6 helper method.
		PrintLine("X-interval: [" & Fun.XMin & "," & Fun.XMax & "]")
		CurrentX = ScaleLeft
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMin'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMax'. Consider using the GetDefaultMember6 helper method.
		PrintLine("Y-range: [" & Fun.YMin & "," & Fun.YMax & "]")
		
		' draw X and Y axis
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMin'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.XMax'. Consider using the GetDefaultMember6 helper method.
		Line(VBRUN.GraphicsOptions.None, Fun.XMin, 0, Fun.XMax, 0)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.YMin'. Consider using the GetDefaultMember6 helper method.
		Line(VBRUN.GraphicsOptions.None, 0, Fun.YMin, 0, Fun.YMax)
		
		' plot a math function
		ForeColor = Color.Red 
		For X = Fun.XMin To Fun.XMax Step Fun.XStep
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl1.Run("Y", X)'. Consider using the GetDefaultMember6 helper method.
			Y = ScriptControl1.Run("Y", X)
			PSet(VBRUN.GraphicsOptions.None, X, Y)
		Next
		
	End Sub

	Private Sub cmdFunction_Click() Handles cmdFunction.Click
		Fun.Show(VBRUN.FormShowConstants.vbModal)
		
		With ScriptControl1
			.Reset
			.Language = "VBScript"
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Fun.FunctionText'. Consider using the GetDefaultMember6 helper method.
			.AddCode("Function Y(x)" & ControlChars.CrLf & Fun.FunctionText & ControlChars.CrLf & "End Function")
		End With

	End Sub

End Class

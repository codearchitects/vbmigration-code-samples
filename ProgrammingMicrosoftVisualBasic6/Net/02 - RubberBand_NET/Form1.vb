' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private X1 As Single
	Private X2 As Single
	Private Y1 As Single
	Private Y2 As Single
	' true if we are dragging a rectangle
	Private dragging As Boolean
	
	Private Sub Form_Load() Handles MyBase.Load
		' rubber-banding works particularly well
		' on a black background
		BackColor = Color.Black 
	End Sub

	Private Sub Form_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseDown
		If Button And 3 Then 
			dragging = True
			' remember starting coordinates
			X1 = X
			Y1 = Y
			X2 = X
			Y2 = Y
			' select a  random color
			ForeColor = FromOleColor6(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
			' select a random width
			DrawWidth = Rnd() * 3 + 1
			' draw the very first rectangle, in Xor mode
			' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
			DrawMode = VBRUN.DrawModeConstants.vbXorPen
			Line(VBRUN.GraphicsOptions.Box, X1, Y1, X2, Y2)
			If Button = 2 Then 
				' filled rectangles
				FillStyle = VBRUN.FillStyleConstants.vbFSSolid
				FillColor = ForeColor
			End If
		End If
	End Sub

	Private Sub Form_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseMove
		If dragging Then 
			' delete old rectangle
			' (repeat the same command in Xor mode)
			Line(VBRUN.GraphicsOptions.Box, X1, Y1, X2, Y2)
			' redraw to new coordinates
			X2 = X
			Y2 = Y
			Line(VBRUN.GraphicsOptions.Box, X1, Y1, X2, Y2)
		End If
	End Sub

	Private Sub Form_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseUp
		If dragging Then 
			dragging = False
			' draw the definitive rectable
			' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
			DrawMode = VBRUN.DrawModeConstants.vbCopyPen
			Line(VBRUN.GraphicsOptions.Box, X1, Y1, X, Y)
			FillStyle = VBRUN.FillStyleConstants.vbFSTransparent
		End If
	End Sub

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Dim dx, dy, lx, j, rs, rsbase As System.Int32
	
	Dim p, xmx, ymx, xc, yc, y, xj, yj, zj, xx, yy, zz As System.Single
	
	Dim xpj, ypj, xp1j, yp1j, a, b, cosa, sina, cosp, sinp, x, z, zl, xp, xpl, yp, ypl As System.Double
	
	Dim xl, yl, xlx, yly, xl1, yl1, xlx1, yly1, ycosa, ysina, ycosp, ysinp, xp1, yp1 As System.Double
	'math constants
	Private Const e As Double = 2.718281828
	Private Const pg As Double = 3.14159265358979
	'******************************************************************************
	'*     Name: 3Ddefline (compiled on Visual Basic 6)                           *
	'*  Version: 1.0 (4 June 2002)                                                *
	'*  Project: 3Ddefline.vbp (Visual Basic Project)                             *
	'*           3Ddefline.frm (Visual Basic Form)                                *
	'*           3ddefline.exe (Exe file)                                         *
	'*  Purpose: This program allow you to study the 3D functions of the          *
	'*           type z = f(x,y); the draw can be rotated and moved.              *
	'*           You can also draw some section plans, increase the drawing       *
	'*           precision and expand or decrease the function area.              *
	'*     Type: Freeware (if you use this code or part of this, please           *
	'*           mention the author: this is the only restriction)                *
	'*   Author: Picinotti Duccio (Duke)                                          *
	'*           Loc.Poggio di Sopra, 23 Subbiano (AR) Italy                      *
	'*           If you want some explanation of this code please contact me at:  *
	'*   E-mail: picinotti.duccio@tin.it                                          *
	'* Homepage: http://www.catenaia.cjb.net                                      *
	'******************************************************************************
	Public Sub AddFunction()
		'add function defined in the TextBox to the VBcode with the MS ScriptControl
		Dim strFunction As String = "Function f(x, y)" & ControlChars.CrLf & "  f = " & txtFunction.Text & ControlChars.CrLf & "End Function"
		ScriptControl.AddCode(strFunction)
	End Sub
	
	Private Sub Axis()
		'draw the 3D Axis in the Form
		'ymx = scale the height of the Form
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ymx'. Consider using the SetDefaultMember6 helper method.
		ymx = (3 / 4) * xmx
		'(xc,yc) = center of the form
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xc'. Consider using the SetDefaultMember6 helper method.
		xc = xmx / 2 + dx
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dy'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yc'. Consider using the SetDefaultMember6 helper method.
		yc = ymx / 2 + dy
		'scale the form from (xmx,ymx)=upperleft corner to (0,0)=downright corner
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		Scale(xmx, ymx, 0, 0)
		'define some value used forward
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'a'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cosa'. Consider using the SetDefaultMember6 helper method.
		cosa = Math.Cos(a): ' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'a'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sina'. Consider using the SetDefaultMember6 helper method.
		sina = Math.Sin(a)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'b'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'a'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cosp'. Consider using the SetDefaultMember6 helper method.
		cosp = Math.Cos(b - a): ' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'b'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'a'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sinp'. Consider using the SetDefaultMember6 helper method.
		sinp = Math.Sin(b - a)
		'cancel the Form
		Cls()
		'draw the 3D-axis
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		Line(VBRUN.GraphicsOptions.None, xc, yc, xc, ymx, QBColor(12))
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
		Line(VBRUN.GraphicsOptions.None, xc, yc, xc - xmx * cosa, yc - xmx * sina, QBColor(12))
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
		Line(VBRUN.GraphicsOptions.None, xc, yc, xc + xmx * cosp, yc - xmx * sinp, QBColor(12))
		'set the color of the axis label
		ForeColor = FromOleColor6(QBColor(15))
		'print the axis label near the axis
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		For j = 1 To ymx
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
			PSet(VBRUN.GraphicsOptions.None, xc - j * cosa, yc - j * sina, QBColor(9))
			PrintLine(j)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
			PSet(VBRUN.GraphicsOptions.None, xc + j * cosp, yc - j * sinp, QBColor(9))
			PrintLine(j)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
			PSet(VBRUN.GraphicsOptions.None, xc, yc + j, QBColor(9))
			PrintLine(j)
		Next
		'print in the upperleft corner the angles from the axis
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		CurrentX = xmx
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		CurrentY = ymx
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'a'. Consider using the GetDefaultMember6 helper method.
		PrintLine("a=", Int((a * 180) / pg), "°")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		CurrentX = xmx
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ymx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
		CurrentY = ymx - (xmx / 32)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'b'. Consider using the GetDefaultMember6 helper method.
		PrintLine("b=", Int(180 - ((b * 180) / pg)), "°")
		DrawFunction()
	End Sub
	
	Private Sub DrawFunction()
		'draw the function in the Form
		On Error GoTo Errore 
		Dim x, y As System.Single
		'p = precision, distance from two lines
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'p'. Consider using the SetDefaultMember6 helper method.
		p = lx / rs
		'draw the iso-level lines: it draws line from the previous point to the
		'point evaluated at the moment
		'it use ScriptControl.Run for evaluate the function added before
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
		For y = -lx To lx Step 0.5
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ycosp'. Consider using the SetDefaultMember6 helper method.
			ycosp = xc + y * cosp
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ycosa'. Consider using the SetDefaultMember6 helper method.
			ycosa = xc - y * cosa
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ysinp'. Consider using the SetDefaultMember6 helper method.
			ysinp = yc - y * sinp
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ysina'. Consider using the SetDefaultMember6 helper method.
			ysina = yc - y * sina
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'p'. Consider using the GetDefaultMember6 helper method.
			For x = -lx To lx Step p
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ycosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xp'. Consider using the SetDefaultMember6 helper method.
				xp = -x * cosa + ycosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ycosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xp1'. Consider using the SetDefaultMember6 helper method.
				xp1 = -(x + p) * cosa + ycosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ysinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl.Run("f", x, y)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yp'. Consider using the SetDefaultMember6 helper method.
				yp = -x * sina + ysinp + ScriptControl.Run("f", x, y)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ysinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'p'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl.Run("f", x + p, y)'. Consider using the GetDefaultMember6 helper method.
				yp1 = -(x + p) * sina + ysinp + ScriptControl.Run("f", x + p, y)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ycosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl'. Consider using the SetDefaultMember6 helper method.
				xl = ycosa + x * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ycosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl1'. Consider using the SetDefaultMember6 helper method.
				xl1 = ycosa + (x + p) * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ysina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl.Run("f", y, x)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl'. Consider using the SetDefaultMember6 helper method.
				yl = ysina - x * sinp + ScriptControl.Run("f", y, x)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ysina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'p'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl.Run("f", y, x + p)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl1'. Consider using the SetDefaultMember6 helper method.
				yl1 = ysina - (x + p) * sinp + ScriptControl.Run("f", y, x + p)
				'draw line from the previous point to the point evaluated now
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xp1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xp, yp, xp1, yp1, QBColor(10))
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl1'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xl, yl, xl1, yl1, QBColor(10))
			Next
		Next
		Exit Sub
Errore:
		'if there is an error evaluating the function (as a division by 0)...
		Resume Next 
	End Sub
	
	Private Sub mnuInterval_Click() Handles mnuInterval.Click
		'increase or decrease the drawing interval
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'lx'. Consider using the SetDefaultMember6 helper method.
		lx = InputBox6("lx < (x,y) < lx", "Drawing interval", "1", 3000, 1000)
		Axis()
	End Sub
	
	Private Sub cmdControls_Click(ByRef Index As Short)
		'control the drawing view
		Select Case Index
		Case 1
			'move to the Left
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dx'. Consider using the SetDefaultMember6 helper method.
			dx = dx - xmx / 8
		Case 2
			'move to the Right
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dx'. Consider using the SetDefaultMember6 helper method.
			dx = dx + xmx / 8
		Case 3
			'move up
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dy'. Consider using the SetDefaultMember6 helper method.
			dy = dy - xmx / 8
		Case 4
			'move down
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xmx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dy'. Consider using the SetDefaultMember6 helper method.
			dy = dy + xmx / 8
		Case 5
			'expand the angle between the X-axis an Y-axis
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
			b = b - pg / 12
		Case 6
			'tight the angle between the X-axis an Y-axis
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
			b = b + pg / 12
		Case 7
			'rotate to the Left
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
			a = a - pg / 12
		Case 8
			'rotate to the Right
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
			a = a + pg / 12
		Case 9
			'zoom In
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xmx'. Consider using the SetDefaultMember6 helper method.
			xmx /= 1.5
		Case 10
			'zoom Out
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xmx'. Consider using the SetDefaultMember6 helper method.
			xmx *= 1.5
		End Select
		'restore normal resolution
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'rs'. Consider using the SetDefaultMember6 helper method.
		rs = rsbase
		'draw Axis
		Axis()
	End Sub
	
	Private Sub Form_Load() Handles MyBase.Load
		'initialize variables
		'xmx = scale the Width of the Form
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xmx'. Consider using the SetDefaultMember6 helper method.
		xmx = 16
		'a = angle (in degrees) from the Horizontal line to the X-axis
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
		a = 30
		'angle in radiants
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
		a = (a * pg) / 180
		'b = 180° - [angle (in degrees) from the X-axis to the Y-axis]
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
		b = 60
		'angle in radiants
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
		b = (b * pg) / 180
		'lx = interval of the drawing
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'lx'. Consider using the SetDefaultMember6 helper method.
		lx = 4
		'rs = resolution of drawing
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'rs'. Consider using the SetDefaultMember6 helper method.
		rs = 100
		'rsbase = normal resolution of drawing
		rsbase = 20
		'write the function specificated in the TextBox with MS ScriptControl
		AddFunction()
	End Sub
	
	Private Sub Form_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles MyBase.MouseDown
		'show the Popup menù when the right mouse button is clicked
		If Button = 2 Then  PopupMenu(mnuGeneral, 4)
	End Sub
	
	Private Sub Form_Resize() Handles MyBase.Resize
		'located the controls in the Form
		Dim i As Short
		'rescale the form to the initial value to locate controls
		Scale()
		'center all controls in the Form
		lblFunction.Left = (Me.ScaleWidth - (txtFunction.Width + lblFunction.Width)) / 2
		txtFunction.Left = lblFunction.Left + lblFunction.Width
		cmdControls(4).Left = (Me.ScaleWidth - cmdControls(4).Width) / 2
		cmdControls(3).Left = cmdControls(4).Left
		cmdControls(7).Left = cmdControls(4).Left - cmdControls(7).Width
		cmdControls(1).Left = cmdControls(7).Left
		cmdControls(8).Left = cmdControls(4).Left + cmdControls(4).Width
		cmdControls(2).Left = cmdControls(8).Left
		cmdControls(9).Left = cmdControls(7).Left - cmdControls(9).Width
		cmdControls(5).Left = cmdControls(9).Left
		cmdControls(10).Left = cmdControls(8).Left + cmdControls(8).Width
		cmdControls(6).Left = cmdControls(10).Left
		'locate all controls to the down of the Form
		cmdControls(4).Top = Me.ScaleHeight - cmdControls(4).Height
		cmdControls(3).Top = cmdControls(4).Top - cmdControls(3).Height
		For i = 1 To 10
			Select Case i
			Case 7, 8, 9, 10: cmdControls(i).Top = Me.ScaleHeight - cmdControls(9).Height
			Case 1, 2, 5, 6: cmdControls(i).Top = Me.ScaleHeight - 2 * cmdControls(9).Height
			End Select
		Next
		'draw Axis
		Axis()
	End Sub
	
	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		'end the application
		Unload6(Me)
	End Sub
	
	Private Sub mnuChangeRisolution_Click(ByRef Index As Short)
		'increase or decrease drawing resolution
		If Index = 1 Then 
			'increase the resolution if it isn't so big (rs=500)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'rs'. Consider using the SetDefaultMember6 helper method.
			If rs < 500 Then  rs *= 2
		Else
			'decrease the resolution if it isn't so small (rs=10)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'rs'. Consider using the SetDefaultMember6 helper method.
			If rs > 10 Then  rs /= 2
		End If
		Axis()
	End Sub
	
	Private Sub mnuDrawPlane_Click(ByRef Index As Short)
		'draw some reference planes
		Select Case Index
		Case 1
			'draw a XY plane
			zz = InputBox6("Z=", "Plane XY", "0", 3000, 2000)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			For y = -lx To lx Step 0.5
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl'. Consider using the SetDefaultMember6 helper method.
				xl = xc + y * cosp + lx * cosa
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl1'. Consider using the SetDefaultMember6 helper method.
				xl1 = xl - 2 * lx * cosa
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xlx'. Consider using the SetDefaultMember6 helper method.
				xlx = xc - y * cosa - lx * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xlx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xlx1'. Consider using the SetDefaultMember6 helper method.
				xlx1 = xlx + 2 * lx * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl'. Consider using the SetDefaultMember6 helper method.
				yl = yc - y * sinp + zz + lx * sina
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl1'. Consider using the SetDefaultMember6 helper method.
				yl1 = yl - 2 * lx * sina
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yly'. Consider using the SetDefaultMember6 helper method.
				yly = yc - y * sina + zz + lx * sinp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yly'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yly1'. Consider using the SetDefaultMember6 helper method.
				yly1 = yly - 2 * lx * sinp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl1'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xl, yl, xl1, yl1, QBColor(13))
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xlx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yly'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xlx1'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yly1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xlx, yly, xlx1, yly1, QBColor(13))
			Next
		Case 2
			'draw a ZX plane
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yy'. Consider using the SetDefaultMember6 helper method.
			yy = InputBox6("Y=", "Plane ZX", "0", 3000, 2000)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			For j = lx To -lx Step -0.5
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yy'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl'. Consider using the SetDefaultMember6 helper method.
				xl = xc - yy * cosa + j * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yy'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'j'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl'. Consider using the SetDefaultMember6 helper method.
				yl = yc - yy * sina - j * sinp + lx
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl1'. Consider using the SetDefaultMember6 helper method.
				yl1 = yl - 2 * lx
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xl, yl, xl, yl1, QBColor(13))
			Next
		Case 3
			'draw a ZY plane
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xx'. Consider using the SetDefaultMember6 helper method.
			xx = InputBox6("X=", "Plane ZY", "0", 3000, 2000)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl'. Consider using the SetDefaultMember6 helper method.
			xl = xc - lx * cosa + xx * cosp
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl1'. Consider using the SetDefaultMember6 helper method.
			xl1 = xl + 2 * lx * cosa
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			For z = lx To -lx Step -0.5
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl'. Consider using the SetDefaultMember6 helper method.
				yl = yc - lx * sina - xx * sinp + z
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl1'. Consider using the SetDefaultMember6 helper method.
				yl1 = yl + 2 * lx * sina
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl1'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xl, yl, xl1, yl1, QBColor(13))
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
			For y = lx To -lx Step -0.5
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl'. Consider using the SetDefaultMember6 helper method.
				xl = xc - y * cosa + xx * cosp
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xl1'. Consider using the SetDefaultMember6 helper method.
				xl1 = xl
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl'. Consider using the SetDefaultMember6 helper method.
				yl = yc - y * sina + xx * sinp + lx
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lx'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yl1'. Consider using the SetDefaultMember6 helper method.
				yl1 = yl - 2 * lx
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xl1'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yl1'. Consider using the GetDefaultMember6 helper method.
				Line(VBRUN.GraphicsOptions.None, xl, yl, xl1, yl1, QBColor(13))
			Next
		End Select
	End Sub
	
	Private Sub mnuSetPoint_Click(ByRef Index As Short)
		'draw or evaluate a point of the function
		On Error GoTo Errors 
		If Index = 1 Then 
			'draw a point in the Form
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xj'. Consider using the SetDefaultMember6 helper method.
			xj = InputBox6("X=", "Draw point", "0", 3000, 1000)
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yj'. Consider using the SetDefaultMember6 helper method.
			yj = InputBox6("Y=", "Draw point", "0", 3000, 1000)
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'zj'. Consider using the SetDefaultMember6 helper method.
			zj = InputBox6("Z=", "Draw point", "0", 3000, 1000)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosa'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xpj'. Consider using the SetDefaultMember6 helper method.
			xpj = xc - yj * cosa
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xpj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cosp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xp1j'. Consider using the SetDefaultMember6 helper method.
			xp1j = xpj + xj * cosp
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yc'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sina'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'ypj'. Consider using the SetDefaultMember6 helper method.
			ypj = yc - yj * sina
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ypj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sinp'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yp1j'. Consider using the SetDefaultMember6 helper method.
			yp1j = ypj - xj * sinp
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xpj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ypj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xp1j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yp1j'. Consider using the GetDefaultMember6 helper method.
			Line(VBRUN.GraphicsOptions.None, xpj, ypj, xp1j, yp1j, QBColor(11))
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xp1j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yp1j'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zj'. Consider using the GetDefaultMember6 helper method.
			Line(VBRUN.GraphicsOptions.None, xp1j, yp1j, xp1j, yp1j + zj, QBColor(11))
		Else
			'evaluate a point of function
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xj'. Consider using the SetDefaultMember6 helper method.
			xj = InputBox6("X=", "Evaluate point", "0", 3000, 1000)
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'yj'. Consider using the SetDefaultMember6 helper method.
			yj = InputBox6("Y=", "Evaluate point", "0", 3000, 1000)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ScriptControl.Run("f", xj, yj)'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'zj'. Consider using the SetDefaultMember6 helper method.
			zj = ScriptControl.Run("f", xj, yj)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'yj'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zj'. Consider using the GetDefaultMember6 helper method.
			MsgBox6("Z(" & xj & "," & yj & ")=" & zj, , "Evaluate point")
		End If
		Exit Sub
Errors:
		'if the function causes a error (as a division by 0....)
		MsgBox6("Evaluating error", 0, "Attention!")
	End Sub
	
	Private Sub mnuRefresh_Click() Handles mnuRefresh.Click
		'refresh the draw
		Axis()
	End Sub
	
	Private Sub mnuChangeView_Click(ByRef Index As Short)
		'change the view of draw: from Left, Right...
		Select Case Index
		Case 1
			'view from Left
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
			a = pg
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
			b = pg
		Case 2
			'view from Right
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'a'. Consider using the SetDefaultMember6 helper method.
			a = 0
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'b'. Consider using the SetDefaultMember6 helper method.
			b = pg
		Case 3
			'restore the initial view
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dx'. Consider using the SetDefaultMember6 helper method.
			dx = 0
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'dy'. Consider using the SetDefaultMember6 helper method.
			dy = 0
			Form_Load()
		End Select
		'draw Axis
		Axis()
	End Sub
	
	Private Sub txtFunction_GotFocus() Handles txtFunction.GotFocus
		'select the text in the TextBox when it receives the focus
		txtFunction.SelStart = 0
		txtFunction.SelLength = Len6(txtFunction.Text)
	End Sub
	
	Private Sub txtFunction_KeyPress(ByRef KeyAscii As Short) Handles txtFunction.KeyPress
		'draw the function if "Enter" is pressed in the TextBox
		If KeyAscii = 13 Then 
			AddFunction()
			Axis()
		End If
	End Sub

End Class

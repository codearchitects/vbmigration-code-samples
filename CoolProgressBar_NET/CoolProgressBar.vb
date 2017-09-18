' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports CodeArchitects.VB6Library.Events

Friend Class CoolProgressBar

	'
	'(Cool Progress Bar by Jotaf98) ____________________
	' ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
	' Read "Readme.txt" for more details.
	'
	'
	'(Contact - E-mail: jotaf98@hotmail.com) ___________
	' ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
	'

	'Default Property Values
	Private Const m_def_Orientation As Short = 0
	Private Const m_def_Value As Short = 100
	Private Const m_def_Min As Short = 0
	Private Const m_def_Max As Short = 100
	Private Const m_def_Color2 As Integer = 16777215
	Private Const m_def_Color1 As Integer = 16711680
	'Property Variables
	Private m_Orientation As Short
	Private m_Value As Short
	Private m_Min As Short
	Private m_Max As Short
	Private m_Color2 As Integer
	Private m_Color1 As Integer
	'Event Declarations
	Public Shadows Event Click As VB6EventHandler 
	Public Shadows Event DblClick As VB6EventHandler 
	Public Shadows Event MouseDown As VB6MouseEventHandler 
	Public Shadows Event MouseMove As VB6MouseEventHandler 
	Public Shadows Event MouseUp As VB6MouseEventHandler 
	'APIs
	
	'Draws a pixel (used to draw the grad effect)
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetPixelV' unamanged method with the following .NET member(s): System.Drawing.Bitmap.SetPixel(
	Private Declare Function SetPixelV Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal crColor As Integer) As Integer
	
	'After drawing the grad to the backbuffer, StretchBlt
	'will stretch it to fit the control (still in the
	'backbuffer)
	' UPGRADE_INFO (#0531): You can replace calls to the 'StretchBlt' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawImage
	Private Declare Function StretchBlt Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByVal dwRop As Integer) As Integer
	
	'Then, when it's needed, copy it to the control using
	'BitBlt
	' UPGRADE_INFO (#0531): You can replace calls to the 'BitBlt' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawImage
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer

	'If the grad has already been drawn or not
	Private GradDone As Boolean
	
	'The Alpha - the translucency level between the
	'first color and the second color.
	Private Alpha As Short
	
	'First color's RGB values
	Private bc_Red1 As Byte
	Private bc_Green1 As Byte
	Private bc_Blue1 As Byte
	
	'Second color's RGB values
	Private bc_Red2 As Byte
	Private bc_Green2 As Byte
	Private bc_Blue2 As Byte
	
	'Final RGB values
	Private bc_RedF As Short
	Private bc_GreenF As Short
	Private bc_BlueF As Short
	
	'When figuring out the bar's width/height based on
	'Max, Min and Value, it will be stored here.
	Private TempSize As Short

		
	''' <summary>
	''' Returns/sets the background color used to display text and graphics in an object.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets the background color used to display text and graphics in an object.")> _
	Public Shadows Property BackColor() As System.Drawing.Color
	' UPGRADE_INFO (#0501): The 'BackColor' member isn't used anywhere in current application.
		Get
			Return MyBase.BackColor
	 	End Get
		Set(ByVal New_BackColor As System.Drawing.Color)
			MyBase.BackColor = New_BackColor
			
			'Also set the backbuffer's color
			picBackbuffer.BackColor = New_BackColor
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint the control
			UserControl_Paint()
			
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets a value that determines whether an object can respond to user-generated events.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets a value that determines whether an object can respond to user-generated events.")> _
	Public Shadows Property Enabled() As Boolean
	' UPGRADE_INFO (#0501): The 'Enabled' member isn't used anywhere in current application.
		Get
			Return MyBase.Enabled
	 	End Get
		Set(ByVal New_Enabled As Boolean)
			MyBase.Enabled = New_Enabled
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets the border style for an object.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets the border style for an object.")> _
	Public Shadows Property BorderStyle() As Short
	' UPGRADE_INFO (#0501): The 'BorderStyle' member isn't used anywhere in current application.
		Get
			Return MyBase.BorderStyle
	 	End Get
		Set(ByVal New_BorderStyle As Short)
			MyBase.BorderStyle = New_BorderStyle
	 	End Set
	End Property

		''' <summary>
	''' Forces a complete repaint of a object.
	''' </summary>
	<System.ComponentModel.Description("Forces a complete repaint of a object.")> _
	Public Shadows Sub Refresh()
	' UPGRADE_INFO (#0501): The 'Refresh' member isn't used anywhere in current application.
		MyBase.Refresh()
	End Sub

	Private Sub UserControl_Click() Handles MyBase.Click
		VB6EventDispatcher.Raise(Me, "Click")
	End Sub

	Private Sub UserControl_DblClick() Handles MyBase.DblClick
		VB6EventDispatcher.Raise(Me, "DblClick")
	End Sub

	Private Sub UserControl_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles MyBase.MouseDown
		VB6MouseEventDispatcher.Raise(Me, "MouseDown", Button, Shift, x, y)
	End Sub

	Private Sub UserControl_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles MyBase.MouseMove
		VB6MouseEventDispatcher.Raise(Me, "MouseMove", Button, Shift, x, y)
	End Sub

	Private Sub UserControl_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles MyBase.MouseUp
		VB6MouseEventDispatcher.Raise(Me, "MouseUp", Button, Shift, x, y)
	End Sub

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=10,0,0,16777215
	
	''' <summary>
	''' This is the second color in the gradient effect.
	''' </summary>
	<System.ComponentModel.Description("This is the second color in the gradient effect.")> _
	Public Property Color2() As System.Drawing.Color
		Get
			Return FromOleColor6(m_Color2)
	 	End Get
		Set(ByVal New_Color2 As System.Drawing.Color)
			m_Color2 = ToOleColor6(New_Color2)
			
			'Convert the new color to RGB
			ConvertToRGB()
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint the control
			UserControl_Paint()
			
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=10,0,0,16711680
	
	''' <summary>
	''' This is the first color in the gradient effect.
	''' </summary>
	<System.ComponentModel.Description("This is the first color in the gradient effect.")> _
	Public Property Color1() As System.Drawing.Color
		Get
			Return FromOleColor6(m_Color1)
	 	End Get
		Set(ByVal New_Color1 As System.Drawing.Color)
			m_Color1 = ToOleColor6(New_Color1)
			
			'Convert the new color to RGB
			ConvertToRGB()
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint the control
			UserControl_Paint()
			
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=7,0,0,0
	
	Public Property Orientation() As Short
	' UPGRADE_INFO (#0501): The 'Orientation' member isn't used anywhere in current application.
		Get
			Return m_Orientation
	 	End Get
		Set(ByVal New_Orientation As Short)
			m_Orientation = New_Orientation
			
			'Only accept 0 (Horizontal) or 1 (Vertical)
			If m_Orientation <> 0 And m_Orientation <> 1 Then 
				m_Orientation = 0
			End If
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint the control
			UserControl_Paint()
			
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=7,0,0,100
	
	Public Property Value() As Short
		Get
			Return m_Value
	 	End Get
		Set(ByVal New_Value As Short)
			m_Value = New_Value
			
			'Can't have a value greater than max or smaller than min
			If m_Value > m_Max Then  m_Value = m_Max
			If m_Value < m_Min Then  m_Value = m_Min
			
			
			'Repaint
			UserControl_Paint()
	 	End Set
	End Property

	'Initialize Properties for User Control
	Protected Overrides Sub UserControl_InitProperties()
		m_Color2 = m_def_Color2
		m_Color1 = m_def_Color1
		m_Min = m_def_Min
		m_Max = m_def_Max
		m_Orientation = m_def_Orientation
		m_Value = m_def_Value
	End Sub

	'Load property values from storage
	Protected Overrides Sub UserControl_ReadProperties(ByRef PropBag As VB6PropertyBag)
		
		MyBase.BackColor = FromOleColor6(PropBag.ReadProperty("BackColor", &H8000000F))
		MyBase.Enabled = PropBag.ReadProperty("Enabled", True)
		MyBase.BorderStyle = PropBag.ReadProperty("BorderStyle", 0)
		m_Color2 = PropBag.ReadProperty("Color2", m_def_Color2)
		m_Color1 = PropBag.ReadProperty("Color1", m_def_Color1)
		m_Min = PropBag.ReadProperty("Min", m_def_Min)
		m_Max = PropBag.ReadProperty("Max", m_def_Max)
		m_Orientation = PropBag.ReadProperty("Orientation", m_def_Orientation)
		m_Value = PropBag.ReadProperty("Value", m_def_Value)
	End Sub

	Private Sub UserControl_Resize() Handles MyBase.Resize
		If Not GradDone Then  Exit Sub
		
		'Redraw the grad effect
		DrawGrad()
		
		'Repaint the control
		UserControl_Paint()
	End Sub

	Protected Overrides Sub UserControl_Initialize_VB6()
		'This will fix a really weird bug - try
		'commenting these lines and creating a
		'progress bar by double-clicking its
		'icon to see what I mean!
		MyBase.Width += 60
		MyBase.Height = 255
	End Sub

	'Write property values to storage
	Protected Overrides Sub UserControl_WriteProperties(ByRef PropBag As VB6PropertyBag)
		
		Call PropBag.WriteProperty("BackColor", ToOleColor6(MyBase.BackColor), &H8000000F)
		Call PropBag.WriteProperty("Enabled", MyBase.Enabled, True)
		Call PropBag.WriteProperty("BorderStyle", MyBase.BorderStyle, 0)
		Call PropBag.WriteProperty("Color2", m_Color2, m_def_Color2)
		Call PropBag.WriteProperty("Color1", m_Color1, m_def_Color1)
		Call PropBag.WriteProperty("Min", m_Min, m_def_Min)
		Call PropBag.WriteProperty("Max", m_Max, m_def_Max)
		Call PropBag.WriteProperty("Orientation", m_Orientation, m_def_Orientation)
		Call PropBag.WriteProperty("Value", m_Value, m_def_Value)
	End Sub

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=7,0,0,0
	
	Public Property Min() As Short
		Get
			Return m_Min
	 	End Get
		Set(ByVal New_Min As Short)
			m_Min = New_Min
			
			'Can't use a Min greater or equal to Max!
			If m_Min >= m_Max Then 
				MsgBox6("""Min"" must be smaller than ""Max"".", , "Error")
				m_Min = m_Max - 1
			End If
			
			'If the Value is smaller than Min, set it to Min
			If m_Value < m_Min Then 
				m_Value = m_Min
			End If
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint
			UserControl_Paint()
			
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=7,0,0,100
	
	Public Property Max() As Short
		Get
			Return m_Max
	 	End Get
		Set(ByVal New_Max As Short)
			m_Max = New_Max
			
			'Can't use a Max smaller or equal to Min!
			If m_Max <= m_Min Then 
				MsgBox6("""Max"" must be greater than ""Min"".", , "Error")
				m_Max = m_Min + 1
			End If
			
			'If the Value is greater than Max, set it to Max
			If m_Value > m_Max Then 
				m_Value = m_Max
			End If
			
			'Redraw the grad effect
			DrawGrad()
			
			'Repaint
			UserControl_Paint()
			
	 	End Set
	End Property

	'This is the most important sub - it draws the control
	Private Sub UserControl_Paint() Handles MyBase.Paint
		'If the grad is not already drawn, draw it
		If GradDone = False Then  DrawGrad()
		
		'Calculate TempSize horizontally or vertically, depending
		'on the Orientation property
		If m_Orientation = 0 Then  '<Horizontal>
			'This will get the width of the bar based on the value
			TempSize = ScaleWidth / (m_Max - m_Min) * m_Value
			
			'Clear the control and copy the grad to it, according to
			'the new width of the bar
			Cls()
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			BitBlt(hDC, 0, 0, TempSize, ScaleHeight, picBackbuffer.hDC, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
		ElseIf m_Orientation = 1 Then  '<Vertical>
			'This will get the height of the bar based on the value
			TempSize = ScaleHeight / (m_Max - m_Min) * (m_Max - m_Value)
			
			'Clear the control and copy the grad to it, according to
			'the new width of the bar
			Cls()
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			BitBlt(hDC, 0, TempSize, ScaleWidth, ScaleHeight - TempSize, picBackbuffer.hDC, 0, TempSize, VBRUN.RasterOpConstants.vbSrcCopy)
		End If
		
		picBackbuffer.ReleaseHdc()
	End Sub

	'Will draw the grad effect to picBackbuffer so whenever
	'we need to draw the bar, we just copy the part we need
	'from it
	Private Sub DrawGrad()
		'Counter
		Dim i As Short
		
		'Convert the colors to RGB
		ConvertToRGB()
		
		'Resize the backbuffer to make sure the bar fits in it
		picBackbuffer.Move(0, 0, ScaleWidth, ScaleHeight)
		
		'Draw horizontally or vertically, depending on the
		'Orientation property
		If m_Orientation = 0 Then  '<Horizontal>
			'Loop trough all possible grad colors
			For i = 0 To 255
				'Set the Alpha to the current counter value
				Alpha = i
				
				'Blend the colors
				BlendColors()
				
				'Draw the new pixel
				' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
				SetPixelV(picBackbuffer.hDC, i, 0, RGB(bc_RedF, bc_GreenF, bc_BlueF))
			Next
			
			'Stretch the tiny line we have drawn to fit the
			'control
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			StretchBlt(picBackbuffer.hDC, 0, 0, ScaleWidth, ScaleHeight, picBackbuffer.hDC, 0, 0, 255, 1, VBRUN.RasterOpConstants.vbSrcCopy)
		ElseIf m_Orientation = 1 Then  '<Vertical>
			'Loop trough all possible grad colors
			For i = 0 To 255
				'Set the Alpha to [255 - the current counter
				'value] (this will make it so Color1 is at
				'the bottom and Color2 at the top)
				Alpha = 255 - i
				
				'Blend the colors
				BlendColors()
				
				'Draw the new pixel
				' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
				SetPixelV(picBackbuffer.hDC, 0, i, RGB(bc_RedF, bc_GreenF, bc_BlueF))
			Next
			
			'Stretch the tiny line we have drawn to fit the
			'control
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			StretchBlt(picBackbuffer.hDC, 0, 0, ScaleWidth, ScaleHeight, picBackbuffer.hDC, 0, 0, 1, 255, VBRUN.RasterOpConstants.vbSrcCopy)
		End If
		picBackbuffer.ReleaseHdc()
		
		'Grad done
		GradDone = True
	End Sub

	'
	'(Functions for the grad effect) ___________________
	' ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
	'
	
	'Gets a grad between 2 colors (the results now are in
	'"bc_[Red/Green/Blue]F")
	Private Sub BlendColors()
		'Find the difference between Red 1 and Red 2.
		If bc_Red2 > bc_Red1 Then 
			bc_RedF = bc_Red2 - bc_Red1
		Else
			bc_RedF = bc_Red1 - bc_Red2
			bc_RedF = -bc_RedF
		End If
		
		'This is the core function for Red
		bc_RedF = bc_RedF / 256 * Alpha + bc_Red1
		
		'Find the difference between Green 1 and Green 2.
		If bc_Green2 > bc_Green1 Then 
			bc_GreenF = bc_Green2 - bc_Green1
		Else
			bc_GreenF = bc_Green1 - bc_Green2
			bc_GreenF = -bc_GreenF
		End If
		
		'This is the core function for Green
		bc_GreenF = bc_GreenF / 256 * Alpha + bc_Green1
		
		'Find the difference between Blue 1 and Blue 2.
		If bc_Blue2 > bc_Blue1 Then 
			bc_BlueF = bc_Blue2 - bc_Blue1
		Else
			bc_BlueF = bc_Blue1 - bc_Blue2
			bc_BlueF = -bc_BlueF
		End If
		
		'This is the core function for Blue
		bc_BlueF = bc_BlueF / 256 * Alpha + bc_Blue1
	End Sub

	'Converts the Long colors to RGB values
	Private Sub ConvertToRGB()
		bc_Red1 = m_Color1 And 255
		bc_Green1 = (m_Color1 And 65280) \ 256
		bc_Blue1 = (m_Color1 And 16711680) \ 65535
		
		bc_Red2 = m_Color2 And 255
		bc_Green2 = (m_Color2 And 65280) \ 256
		bc_Blue2 = (m_Color2 And 16711680) \ 65535
	End Sub

End Class

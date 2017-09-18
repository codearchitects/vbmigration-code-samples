' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure POINTAPI

' UPGRADE_INFO (#0501): The 'POINTAPI' member isn't used anywhere in current application.
	Public x As Integer
	Public y As Integer
End Structure

Friend Structure Size

	Public cx As Integer
	Public cy As Integer
End Structure

Friend Structure TEXTMETRIC

	Public tmHeight As Integer
	Public tmAscent As Integer
	Public tmDescent As Integer
	Public tmInternalLeading As Integer
	Public tmExternalLeading As Integer
	Public tmAveCharWidth As Integer
	Public tmMaxCharWidth As Integer
	Public tmWeight As Integer
	Public tmOverhang As Integer
	Public tmDigitizedAspectX As Integer
	Public tmDigitizedAspectY As Integer
	Public tmFirstChar As Byte
	Public tmLastChar As Byte
	Public tmDefaultChar As Byte
	Public tmBreakChar As Byte
	Public tmItalic As Byte
	Public tmUnderlined As Byte
	Public tmStruckOut As Byte
	Public tmPitchAndFamily As Byte
	Public tmCharSet As Byte
End Structure

Friend Structure MEMORYSTATUS

' UPGRADE_INFO (#0501): The 'MEMORYSTATUS' member isn't used anywhere in current application.
	Public dwLength As Integer
	Public dwMemoryLoad As Integer
	Public dwTotalPhys As Integer
	Public dwAvailPhys As Integer
	Public dwTotalPageFile As Integer
	Public dwAvailPageFile As Integer
	Public dwTotalVirtual As Integer
	Public dwAvailVirtual As Integer
End Structure

Friend Structure BBAR_INFO

	Public szReadText As String
	Public szAdDigit As String
	Public szDigit As String
	Public szBarCaption As String
	Public tiFaceName As String
	Public szSymbology As Integer
	Public lalign As Integer
	Public ltxtdisp As Integer
	Public nsize As Integer
	Public lstyle As Integer
	Public lheight As Integer
	Public lLeft As Integer
	Public lTop As Integer
	Public lWidth As Integer
	Public lExtra As Integer
	Public lR1 As Integer
	Public lR2 As Integer
	Public lRetWidth As Integer
	Public lRetHeight As Integer
	Public lRotation As Integer
	Public crFore As Integer
	Public crBack As Integer
	Public TextColor As Integer
	Public lShowCheck As Integer
End Structure

Friend Structure RET_VAL

	Public lnRtheight As Integer
	Public lnRtWidth As Integer
End Structure

Friend Structure RECT

	Public Left As Integer
	Public Top As Integer
	Public Right As Integer
	Public Bottom As Integer
End Structure

Friend Module Special128

	'---------------------------------------------------------------------------------------
	' Module    : Special128
	' DateTime  : 10/4/2002 18:28
	' Author    : Joyprakash saikia
	' Purpose   :  this Module Consist of all functions required to
	'               print a barCode 128.
	'---------------------------------------------------------------------------------------
	
	Public Const LF_FACESIZE As Short = 30
	' UPGRADE_INFO (#0501): The 'str3' member isn't used anywhere in current application.
	Public str3 As String = ""
	' UPGRADE_INFO (#0501): The 'bld' member isn't used anywhere in current application.
	Public bld As Short
	' UPGRADE_INFO (#0501): The 'itl' member isn't used anywhere in current application.
	Public itl As Short
	' UPGRADE_INFO (#0501): The 'strk' member isn't used anywhere in current application.
	Public strk As Short
	' UPGRADE_INFO (#0501): The 'und' member isn't used anywhere in current application.
	Public und As Short
	Public j As Short
	Public sp As Short
	Public bar As BBAR_INFO
	' UPGRADE_INFO (#0501): The 'RetVal' member isn't used anywhere in current application.
	Public RetVal As RET_VAL
	Private Dl As Integer
	Private Th As Integer
	Private textdisp As String = ""
	Friend Structure LOGFONT
	
		Public lfHeight As Integer
		Public lfWidth As Integer
		Public lfEscapement As Integer
		Public lfOrientation As Integer
		Public lfWeight As Integer
		Public lfItalic As Byte
		Public lfUnderline As Byte
		Public lfStrikeOut As Byte
		Public lfCharSet As Byte
		Public lfOutPrecision As Byte
		Public lfClipPrecision As Byte
		Public lfQuality As Byte
		Public lfPitchAndFamily As Byte
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=(LF_FACESIZE + 1 - (0)))> _
		Public lfFaceName() As Byte
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			ReDim lfFaceName(LF_FACESIZE)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As LOGFONT
			Dim copy As LOGFONT = Me
			copy.lfFaceName = Me.lfFaceName.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure
	
	'*******************************************************************************************
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetRect' unamanged method with the following .NET member(s): System.Drawing.Rectangle.FromLTRB
	Declare Function SetRect Lib "user32" (ByRef lpRect As RECT, ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Declare Function SetTextCharacterExtra Lib "gdi32" (ByVal hDc As Integer, ByVal nCharExtra As Integer) As Integer
	Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetTextMetrics' unamanged method with the following .NET member(s): System.Drawing.Font
	Declare Function GetTextMetrics Lib "gdi32" Alias "GetTextMetricsA" (ByVal hDc As Integer, ByRef lpMetrics As TEXTMETRIC) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetStockObject' unamanged method with the following .NET member(s): System.Drawing.Brushes, System.Drawing.Pens
	Declare Function GetStockObject Lib "gdi32" (ByVal nIndex As Integer) As Integer
	Declare Function SelectObject Lib "gdi32" (ByVal hDc As Integer, ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDeviceCaps' unamanged method with the following .NET member(s): System.Drawing.Graphics , System.Drawing.Printing.PrinterSettings, System.Management
	Declare Function GetDeviceCaps Lib "gdi32" (ByVal hDc As Integer, ByVal nIndex As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetTextExtentPoint32' unamanged method with the following .NET member(s): System.Drawing.Graphics.MeasureString
	Declare Function GetTextExtentPoint32 Lib "gdi32" Alias "GetTextExtentPoint32A" (ByVal hDc As Integer, ByVal lpsz As String, ByVal cbString As Integer, ByRef lpSize As Size) As Integer
	Declare Function MulDiv Lib "kernel32" (ByVal nNumber As Integer, ByVal nNumerator As Integer, ByVal nDenominator As Integer) As Integer
	Declare Function CreateFontIndirect Lib "gdi32" Alias "CreateFontIndirectA" (ByRef lpLogFont As LOGFONT) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreateHatchBrush' unamanged method with the following .NET member(s): System.Drawing.Drawing2D.HatchBrush constructor
	' UPGRADE_INFO (#0501): The 'CreateHatchBrush' member isn't used anywhere in current application.
	Declare Function CreateHatchBrush Lib "gdi32" (ByVal nIndex As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreatePen' unamanged method with the following .NET member(s): System.Drawing.Pen constructor
	Declare Function CreatePen Lib "gdi32" (ByVal nPenStyle As Integer, ByVal nWidth As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreateSolidBrush' unamanged method with the following .NET member(s): System.Drawing.SolidBrush constructor
	Declare Function CreateSolidBrush Lib "gdi32" (ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'LineTo' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawLine
	' UPGRADE_INFO (#0501): The 'LineTo' member isn't used anywhere in current application.
	Declare Function LineTo Lib "gdi32" (ByVal hDc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'MoveToEx' member isn't used anywhere in current application.
	Declare Function MoveToEx Lib "gdi32" (ByVal hDc As Integer, ByVal x As Integer, ByVal y As Integer, ByRef lpPoint As POINTAPI) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RECTANGLE' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawRectangle, System.Drawing.Graphics.FillRectangle
	Declare Function RECTANGLE Lib "gdi32" Alias "Rectangle" (ByVal hDc As Integer, ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RoundRect' unamanged method with the following .NET member(s): System.Drawing.Drawing2D.GraphicsPath.AddLines, System.Drawing.Pen.LineJoin = System.Drawing.Pen.LineJoin.Round, System.Drawing.Graphics.DrawPath, System.Drawing.Graphics.FillPath
	' UPGRADE_INFO (#0501): The 'RoundRect' member isn't used anywhere in current application.
	Declare Function RoundRect Lib "gdi32" (ByVal hDc As Integer, ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'RestoreDC' member isn't used anywhere in current application.
	Declare Function RestoreDC Lib "gdi32" (ByVal hDc As Integer, ByVal nSavedDC As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'SaveDC' member isn't used anywhere in current application.
	Declare Function SaveDC Lib "gdi32" (ByVal hDc As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetMapMode' unamanged method with the following .NET member(s): System.Drawing.Graphics.PageUnit
	' UPGRADE_INFO (#0501): The 'SetMapMode' member isn't used anywhere in current application.
	Declare Function SetMapMode Lib "gdi32" (ByVal hDc As Integer, ByVal nMapMode As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'SetViewportExtEx' member isn't used anywhere in current application.
	Declare Function SetViewportExtEx Lib "gdi32" (ByVal hDc As Integer, ByVal nX As Integer, ByVal nY As Integer, ByRef lpSize As Size) As Integer
	' UPGRADE_INFO (#0501): The 'SetViewportOrgEx' member isn't used anywhere in current application.
	Declare Function SetViewportOrgEx Lib "gdi32" (ByVal hDc As Integer, ByVal nX As Integer, ByVal nY As Integer, ByRef lpPoint As POINTAPI) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowOrgEx' unamanged method with the following .NET member(s): System.Drawing.Graphics.TranslateTransform
	' UPGRADE_INFO (#0501): The 'SetWindowOrgEx' member isn't used anywhere in current application.
	Declare Function SetWindowOrgEx Lib "gdi32" (ByVal hDc As Integer, ByVal nX As Integer, ByVal nY As Integer, ByRef lpPoint As POINTAPI) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowExtEx' unamanged method with the following .NET member(s): System.Drawing.Graphics.PageScale
	' UPGRADE_INFO (#0501): The 'SetWindowExtEx' member isn't used anywhere in current application.
	Declare Function SetWindowExtEx Lib "gdi32" (ByVal hDc As Integer, ByVal nX As Integer, ByVal nY As Integer, ByRef lpSize As Size) As Integer
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetBkMode' unamanged method with the following .NET member(s): System.Windows.Forms.Form.SetStyle(System.Windows.Forms.ControlStyles.Opaque, System.Boolean)
	Public Declare Function SetBkMode Lib "gdi32" (ByVal ln As Integer, ByVal nBkMode As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetBkColor' unamanged method with the following .NET member(s): System.Windows.Forms.Form.BackColor
	' UPGRADE_INFO (#0501): The 'SetBkColor' member isn't used anywhere in current application.
	Public Declare Function SetBkColor Lib "gdi32" (ByVal ln As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetTextColor' unamanged method with the following .NET member(s): System.Drawing.Brushes, System.Drawing.SolidBrush.SolidBrush(Color)
	Public Declare Function SetTextColor Lib "gdi32" (ByVal ln As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'DrawText' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawString
	Public Declare Function DrawText Lib "user32" Alias "DrawTextA" (ByVal ln As Integer, ByVal lpStr As String, ByVal nCount As Integer, ByRef lpRect As RECT, ByVal wFormat As Integer) As Integer
	
	' UPGRADE_INFO (#0501): The 'DT_BOTTOM' member isn't used anywhere in current application.
	Public Const DT_BOTTOM As Short = &H8S
	Public Const DT_CALCRECT As Short = &H400S
	Public Const DT_SINGLELINE As Short = &H1S
	Public Const DT_CENTER As Short = &H1S
	Public Const DT_LEFT As Short = &H0S
	Public Const DT_RIGHT As Short = &H2S
	' UPGRADE_INFO (#0501): The 'DT_TOP' member isn't used anywhere in current application.
	Public Const DT_TOP As Short = &H0S
	' UPGRADE_INFO (#0501): The 'DT_VCENTER' member isn't used anywhere in current application.
	Public Const DT_VCENTER As Short = &H4S
	Public Const TRANSPARENT As Short = 1
	' UPGRADE_INFO (#0501): The 'OPAQUE' member isn't used anywhere in current application.
	Public Const OPAQUE As Short = 2
	Public Const NULL_BRUSH As Short = 5
	Public Const NULL_PEN As Short = 8
	Public Const BLACK_PEN As Short = 7
	Public Const WHITE_BRUSH As Short = 0
	' UPGRADE_INFO (#0501): The 'WHITE_PEN' member isn't used anywhere in current application.
	Public Const WHITE_PEN As Short = 6
	Public Const PS_SOLID As Short = 0

	Public Function Ret_Width_Height(ByRef bar As BBAR_INFO, ByVal ln As Integer) As RET_VAL
		
		'//######################################################
		'    //PARAMETERS AND THIER MEANING
		'    //a=LEFT
		'    //b=TOP
		'    //hgt=Height og the Barcode
		'    //width=width of the thin Barcode in pixel
		'    //r1=ratio of the thick barcode and thin barcode
		'    //str=Value of the barcode
		'    //align=alignment ofthe text i.e 1=left,2=center,3=right,4=justify
		'    //textdisp= text position with respect to barcode i.e 2=TOP or 1=BOTTOM
		'    //extra=distance of the text from the barcode
		'    //ln=device context of the out put device
		'//######################################################
		Dim r2 As Integer
		Dim r1 As Integer = 1
		Dim a As Integer
		Dim b As Integer
		Dim hgt As Integer
		Dim Width As Integer
		Dim extra As Integer
		Dim str As String = ""
		Dim align As String = ""
		Dim textdisp As String = ""
		Dim str2 As String = ""
		Dim RetVal As RET_VAL
		Dim nfnt As Integer
		'   //#######################################################
		'   //ASSIGNING VALUE FROM THE STRUCTURE
		'   //#########################################################
		a = bar.lLeft
		b = bar.lTop
		hgt = bar.lheight
		Width = bar.lWidth
		r2 = bar.lR1
		r2 = 1
		str = bar.szReadText
		'//ASSIGNING THE VALUES FOR THE ALIGNMENT AND TEXT DISPLAY POSITION
		Select Case (bar.lalign)
		Case 1: align = "LEFT"
		Case 2: align = "CENTER"
		Case 3: align = "RIGHT"
		Case 4: align = "JUSTIFY"
		Case Else: align = "CENTER"
		End Select
		
		If (bar.ltxtdisp = 1) Then 
			textdisp = "BOTTOM"
		ElseIf (bar.ltxtdisp = 2) Then 
			textdisp = "TOP"
		Else
			textdisp = "BOTTOM"
		End If
		extra = bar.lExtra
		
		' //#########################################################
		str2 = str
		Dim x As Integer
		Dim wd As Integer
		Dim w As Integer
		Dim sum As Integer
		' UPGRADE_INFO (#0561): The 'a1' symbol was defined without an explicit "As" clause.
		Dim a1 As Object = Nothing
		Dim rect1 As RECT
		a1 = a
		Dim lf As New LOGFONT(True)
		'//*****************************************************************
		Dim hDc As Integer = ln
		'///////CREATING FONT OF CHOICE//////////////
		'////////////SETTING THE ANGLE OF ROTATION///
		If (bar.lRotation = 1) Then 
			lf.lfEscapement = 900
		End If
		If (bar.lRotation = 2) Then 
			lf.lfEscapement = 1800
		End If
		If (bar.lRotation = 0) Then 
			lf.lfEscapement = 3600
		End If
		If (bar.lRotation = 3) Then 
			lf.lfEscapement = 2700
		End If
		'/////////////////////////////////////////////////
		
		' //////FOR LOGFONT ASSIGNMENT//////
		Dim ByteArrayLimit As Integer
		Dim X1 As Short
		Dim TempByteArray() As Byte
		TempByteArray = StringToByteArray6(StrConv6(bar.tiFaceName & Chr6(0), VBA.VbStrConv.vbFromUnicode))
		ByteArrayLimit = UBound6(TempByteArray)
		For X1 = 0 To ByteArrayLimit
			lf.lfFaceName(X1) = TempByteArray(X1)
		Next

		' /////////////////////////////////////////////////
		Dim py As Short
		If ((bar.lRotation = 2) Or (bar.lRotation = 0)) Then 
			py = GetDeviceCaps(hDc, 90)
		Else
			py = GetDeviceCaps(hDc, 88)
		End If
		
		If (bar.nsize > 0) Then 
			'The MulDiv function multiplies two 32-bit values and then
			'divides the 64-bit result by a third 32-bit value.
			'The return value is rounded up or down to the nearest integer.
			lf.lfHeight = -MulDiv(bar.nsize, py, 72)
		Else
			lf.lfHeight = bar.nsize
		End If
		
		Select Case (bar.lstyle)
		Case 15
			lf.lfItalic = 255
			lf.lfWeight = 700
			lf.lfUnderline = 1
			lf.lfStrikeOut = 1
		Case 14
			lf.lfItalic = 255
			lf.lfWeight = 400
			lf.lfUnderline = 1
			lf.lfStrikeOut = 1
		Case 13
			lf.lfItalic = 0
			lf.lfWeight = 700
			lf.lfUnderline = 1
			lf.lfStrikeOut = 1
		Case 12
			lf.lfItalic = 0
			lf.lfWeight = 400
			lf.lfUnderline = 1
			lf.lfStrikeOut = 1
		Case 11
			lf.lfItalic = 255
			lf.lfWeight = 700
			lf.lfUnderline = 0
			lf.lfStrikeOut = 1
		Case 10
			lf.lfItalic = 255
			lf.lfWeight = 400
			lf.lfUnderline = 0
			lf.lfStrikeOut = 1
		Case 9
			lf.lfItalic = 0
			lf.lfWeight = 700
			lf.lfUnderline = 0
			lf.lfStrikeOut = 1
		Case 8
			lf.lfItalic = 0
			lf.lfWeight = 400
			lf.lfUnderline = 0
			lf.lfStrikeOut = 1
		Case 7
			lf.lfItalic = 255
			lf.lfWeight = 700
			lf.lfUnderline = 1
			lf.lfStrikeOut = 0
		Case 6
			lf.lfItalic = 255
			lf.lfWeight = 400
			lf.lfUnderline = 1
			lf.lfStrikeOut = 0
		Case 5
			lf.lfItalic = 0
			lf.lfWeight = 700
			lf.lfUnderline = 1
			lf.lfStrikeOut = 0
		Case 4
			lf.lfItalic = 0
			lf.lfWeight = 400
			lf.lfUnderline = 1
			lf.lfStrikeOut = 0
		Case 3
			lf.lfItalic = 255
			lf.lfWeight = 700
			lf.lfUnderline = 0
			lf.lfStrikeOut = 0
		Case 2
			lf.lfItalic = 255
			lf.lfWeight = 400
			lf.lfUnderline = 0
			lf.lfStrikeOut = 0
		Case 1
			lf.lfItalic = 0
			lf.lfWeight = 700
			lf.lfUnderline = 0
			lf.lfStrikeOut = 0
		Case 0
			lf.lfItalic = 0
			lf.lfWeight = 400
			lf.lfUnderline = 0
			lf.lfStrikeOut = 0
		End Select
		'////OTHER VALUES//////
		lf.lfCharSet = 0
		lf.lfClipPrecision = 2
		lf.lfOutPrecision = 3
		lf.lfPitchAndFamily = 2
		lf.lfQuality = 1
		lf.lfWidth = 0
		'////////////CREATING BRUSH PEN FOR BACK& FORE COLOR////////
		'lf.lfFaceName = bar.tiFaceName
		nfnt = CreateFontIndirect(lf)
		Dl = SelectObject(hDc, GetStockObject(NULL_BRUSH))
		Dl = SelectObject(hDc, GetStockObject(NULL_PEN))
		Dl = SetTextColor(hDc, RGB(255, 255, 255))
		Dl = SetBkMode(hDc, TRANSPARENT)
		'//*************************************************************************8
		'//####################  ASSIGNING THE LRFT TOP CO-ORDINATE
		Dim tm As TEXTMETRIC
		Dl = GetTextMetrics(hDc, tm)
		Th = tm.tmHeight + tm.tmExternalLeading
		' UPGRADE_INFO (#0501): The 'temp' member isn't used anywhere in current application.
		Dim temp As String = ""
		Dim len1 As Short
		' UPGRADE_INFO (#0501): The 't' member isn't used anywhere in current application.
		Dim t As Short
		Dim st As String = ""
		Dim ch As String = ""
		Dim change As String = ""
		Dim t1 As String = ""
		Dim t2 As String = ""
		Dim t3 As String = ""
		Dim chk As Short
		Dim aln As Integer
		If (bar.lRotation = 0) Then 
			If (Not ((textdisp = "BOTTOM") And (bar.szBarCaption = ""))) Then 
				rect1.Left = a
				rect1.Top = b
				rect1.Bottom = b + Th + extra
				b = b + (Th + extra)
				x = a
			Else
				x = a '//LEFT
			End If
			'//######################## ASSIGNING VALUE FOR THE WIDTH ####################
			len1 = Len6(str)
			If (len1 <> 0) Then  'if length<>0
				If (Width < 1) Then 
					w = 1
					wd = 1
				Else
					w = Width
					wd = Width
				End If
				'//######################Start Character ################################
				
				Dl = RECTANGLE(hDc, x, b, x + wd * (r1), b + hgt)
				x = x + wd * (4 * r1)
				Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
				x = x + wd * 2 * r1
				Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
				x = x + wd * 5 * r2
				sum = sum + 94 * 1
				'//##########################################################################
				str = str2
				change = "n"
				t2 = (-55): t3 = (-54): t1 = (-68)
				chk = 2
				For j = 0 To (Len6(str) - 1)
					ch = Mid(str, j + 1, 1)
					st = ""
					
					If (st = "00") Or (ch = Chr6(32)) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r1, b + hgt)
						x = x + w * (3 * r1)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 2 * (r2 + r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						
						sum = sum + 0 * chk
					End If
					
					If ((st = "01") Or (ch = "!")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r2 * 2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 1 * chk
					End If
					If ((st = "02") Or (ch = Chr6(34))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 2 * (r2 + r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 2 * (r2 + r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 2 * chk
					End If
					
					If ((st = "03") Or (ch = "#")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						
						sum = sum + 3 * chk
					End If
					If ((st = "04") Or (ch = "$")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 4 * chk
					End If
					If ((st = "05") Or (ch = "%")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 5 * chk
					End If
					If ((st = "06") Or (ch = "&")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						
						sum = sum + 6 * chk
					End If
					If ((st = "07") Or (ch = Chr6(39))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						
						sum = sum + 7 * chk
					End If
					If ((st = "08") Or (ch = "(")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						
						sum = sum + 8 * chk
					End If
					If ((st = "09") Or (ch = ")")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 9 * chk
					End If
					If ((st = "10") Or (ch = "*")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						
						sum = sum + 10 * chk
					End If
					If ((st = "11") Or (ch = "+")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						
						sum = sum + 11 * chk
					End If
					If ((st = "12") Or (ch = ",")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * r2 * 2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 12 * chk
					End If
					If ((st = "13") Or (ch = "-")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 13 * chk
					End If
					If ((st = "14") Or (ch = ".")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 14 * chk
					End If
					If ((st = "15") Or (ch = "/")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 15 * chk
					End If
					If ((st = "16") Or (ch = Chr6(48))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 16 * chk
					End If
					If ((st = "17") Or (ch = Chr6(49))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 17 * chk
					End If
					If ((st = "18") Or (ch = Chr6(50))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						sum = sum + 18 * chk
					End If
					If ((st = "19") Or (ch = Chr6(51))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 19 * chk
					End If
					If ((st = "20") Or (ch = Chr6(52))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 20 * chk
					End If
					If ((st = "21") Or (ch = Chr6(53))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 21 * chk
					End If
					If ((st = "22") Or (ch = Chr6(54))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 22 * chk
					End If
					If ((st = "23") Or (ch = Chr6(55))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 23 * chk
					End If
					If ((st = "24") Or (ch = Chr6(56))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 24 * chk
					End If
					
					If ((st = "25") Or (ch = Chr6(57))) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * (r1 + r2), b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
						x = x + w * (r2 + r2)
						sum = sum + 25 * chk
					End If
					
					If ((st = "26") Or (ch = ":")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 26 * chk
					End If
					
					If ((st = "27") Or (ch = ";")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 27 * chk
					End If
					If ((st = "28") Or (ch = "<")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 28 * chk
					End If
					If ((st = "29") Or (ch = "=")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						sum = sum + 29 * chk
					End If
					If ((st = "30") Or (ch = ">")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 30 * chk
					End If
					If ((st = "31") Or (ch = "?")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 31 * chk
					End If
					
					If ((st = "32") Or (ch = "@")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 32 * chk
					End If
					If ((st = "33") Or (ch = "A")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 33 * chk
					End If
					If ((st = "34") Or (ch = "B")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 34 * chk
					End If
					If ((st = "35") Or (ch = "C")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 35 * chk
					End If
					If ((st = "36") Or (ch = "D")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 36 * chk
					End If
					If ((st = "37") Or (ch = "E")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 37 * chk
					End If
					If ((st = "38") Or (ch = "F")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						sum = sum + 38 * chk
					End If
					If ((st = "39") Or (ch = "G")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 39 * chk
					End If
					If ((st = "40") Or (ch = "H")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 40 * chk
					End If
					If ((st = "41") Or (ch = "I")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						sum = sum + 41 * chk
					End If
					If ((st = "42") Or (ch = "J")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 6 * r2
						sum = sum + 42 * chk
					End If
					If ((st = "43") Or (ch = "K")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 43 * chk
					End If
					If ((st = "44") Or (ch = "L")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 44 * chk
					End If
					If ((st = "45") Or (ch = "M")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						sum = sum + 45 * chk
					End If
					If ((st = "46") Or (ch = "N")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 46 * chk
					End If
					If ((st = "47") Or (ch = "O")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 47 * chk
					End If
					If ((st = "48") Or (ch = "P")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						sum = sum + 48 * chk
					End If
					If ((st = "49") Or (ch = "Q")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 49 * chk
					End If
					If ((st = "50") Or (ch = "R")) Then 
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						sum = sum + 50 * chk
					End If
					If ((st = "51") Or (ch = "S")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 51 * chk
						
					End If
					If ((st = "52") Or (ch = "T")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 52 * chk
						
					End If
					If ((st = "53") Or (ch = "U")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 53 * chk
						
					End If
					If ((st = "54") Or (ch = "V")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 54 * chk
						
					End If
					If ((st = "55") Or (ch = "W")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 55 * chk
						
					End If
					If ((st = "56") Or (ch = "X")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 56 * chk
						
					End If
					If ((st = "57") Or (ch = "Y")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 57 * chk
						
					End If
					If ((st = "58") Or (ch = "Z")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 58 * chk
						
					End If
					If ((st = "59") Or (ch = "[")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 59 * chk
						
					End If
					If ((st = "60") Or (ch = "\")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 60 * chk
						
					End If
					If ((st = "61") Or (ch = "]")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 61 * chk
						
					End If
					If ((st = "62") Or (ch = "^")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 62 * chk
						
					End If
					If ((st = "63") Or (ch = "_")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						sum = sum + 63 * chk
						
					End If
					If ((st = "64") Or (ch = Chr6(0))) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 64 * chk
						
					End If
					If ((st = "65") Or (ch = Chr6(1)) Or (ch = "a")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						sum = sum + 65 * chk
						
					End If
					If ((st = "66") Or (ch = Chr6(2)) Or (ch = "b")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 66 * chk
						
					End If
					If ((st = "67") Or (ch = Chr6(3)) Or (ch = "c")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 67 * chk
						
					End If
					If ((st = "68") Or (ch = Chr6(4)) Or (ch = "d")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 68 * chk
						
					End If
					If ((st = "69") Or (ch = Chr6(5)) Or (ch = "e")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 69 * chk
						
					End If
					If ((st = "70") Or (ch = Chr6(6)) Or (ch = "f")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 70 * chk
						
					End If
					If ((st = "71") Or (ch = Chr6(7)) Or (ch = "g")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 71 * chk
						
					End If
					If ((st = "72") Or (ch = Chr6(8)) Or (ch = "h")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 72 * chk
						
					End If
					If ((st = "73") Or (ch = Chr6(9)) Or (ch = "i")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 73 * chk
						
					End If
					If ((st = "74") Or (ch = Chr6(10)) Or (ch = "j")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 74 * chk
						
					End If
					If ((st = "75") Or (ch = Chr6(11)) Or (ch = "k")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 75 * chk
						
					End If
					If ((st = "76") Or (ch = Chr6(12)) Or (ch = "l")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 76 * chk
						
					End If
					If ((st = "77") Or (ch = Chr6(13)) Or (ch = "m")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 77 * chk
						
					End If
					If ((st = "78") Or (ch = Chr6(14)) Or (ch = "n")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 78 * chk
						
					End If
					If ((st = "79") Or (ch = Chr6(15)) Or (ch = "o")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 79 * chk
						
					End If
					If ((st = "80") Or (ch = Chr6(16)) Or (ch = "p")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						sum = sum + 80 * chk
						
					End If
					If ((st = "81") Or (ch = Chr6(17)) Or (ch = "q")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						sum = sum + 81 * chk
						
					End If
					If ((st = "82") Or (ch = Chr6(18)) Or (ch = "r")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 82 * chk
						
					End If
					If ((st = "83") Or (ch = Chr6(19)) Or (ch = "s")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 83 * chk
						
					End If
					If ((st = "84") Or (ch = Chr6(20)) Or (ch = "t")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 84 * chk
						
					End If
					If ((st = "85") Or (ch = Chr6(21)) Or (ch = "u")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 85 * chk
						
					End If
					If ((st = "86") Or (ch = Chr6(22)) Or (ch = "v")) Then 
						
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 86 * chk
						
					End If
					If ((st = "87") Or (ch = Chr6(23)) Or (ch = "w")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 87 * chk
						
					End If
					If ((st = "88") Or (ch = Chr6(24)) Or (ch = "x")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 88 * chk
						
					End If
					If ((st = "89") Or (ch = Chr6(25)) Or (ch = "y")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 89 * chk
						
					End If
					If ((st = "90") Or (ch = Chr6(26)) Or (ch = "z")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 90 * chk
						
					End If
					If ((st = "91") Or (ch = Chr6(27)) Or (ch = "{")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						sum = sum + 91 * chk
						
					End If
					If ((st = "92") Or (ch = Chr6(28)) Or (ch = "|")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						sum = sum + 92 * chk
						
					End If
					If ((st = "93") Or (ch = Chr6(29)) Or (ch = "}")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 93 * chk
						
					End If
					If ((st = "94") Or (ch = Chr6(30)) Or (ch = "~")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 94 * chk
						
					End If
					If ((st = "95") Or (ch = Chr6(31))) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 95 * chk
						
					End If
					If ((st = "96") Or (ch = "-77")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 96 * chk
						
					End If
					If ((st = "97") Or (ch = "-78")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 97 * chk
						
					End If
					If ((st = "98") Or (ch = "-53")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						sum = sum + 98 * chk
						
					End If
					
					If ((st = "99") Or (ch = "-54")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 99 * chk
					End If
					If ((st = "100") Or (ch = "-55")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 100 * chk
					End If
					If ((st = "101") Or (ch = "-68")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						sum = sum + 101 * chk
					End If
					If ((st = "102") Or (ch = "-71")) Then 
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						sum = sum + 102 * chk
					End If
					chk += 1
				Next
				If bar.lShowCheck = 1 Then 
					'//################ CHECK CHARACTER VALUE ################
					sum = (sum Mod 103)
					'//########################################################################
					'//DRAWING THE CHECK CHARACTER
					'//###################################################################
					Select Case (sum)
					Case 0
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 1
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 3
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 4
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 5
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 6
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 7
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
						x = x + w * 3 * r2
					Case 8
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 9
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 10
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 11
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 12
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * r2 * 2
						Dl = RECTANGLE(hDc, x, b, x + w * r2 * 2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 13
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 14
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 15
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 16
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 17
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 18
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
					Case 19
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 20
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 21
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 22
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 23
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 24
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 25
						Dl = RECTANGLE(hDc, x, b, x + w * (r1 + r2), b + hgt)
						x = x + w * (r1 + 2 * r2)
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
						x = x + w * (r2 + r2)
					Case 26
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 27
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 28
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
					Case 29
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
					Case 30
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 31
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 32
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 33
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 34
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 35
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 36
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 37
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 38
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
					Case 39
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 40
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
					Case 41
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
					Case 42
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 6 * r2
					Case 43
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 44
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 45
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
					Case 46
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 47
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 48
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
					Case 49
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 50
						Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
						x = x + w * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
						x = x + w * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
						x = x + w * 4 * r2
					Case 51
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
					Case 52
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 53
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
					Case 54
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 55
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 56
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 57
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
					Case 58
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 59
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 60
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 61
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 62
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 63
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
					Case 64
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
					Case 65
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
					Case 66
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 67
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
					Case 68
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 69
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
					Case 70
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 71
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
					Case 72
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 73
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 74
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 75
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 76
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 5 * r2
					Case 77
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 78
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 79
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 80
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
					Case 81
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
					Case 82
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 83
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 84
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 85
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 86
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 87
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
					Case 88
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 6 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 89
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 90
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 91
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
						x = x + wd * 3 * r2
					Case 92
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
					Case 93
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 94
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 95
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
					Case 96
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 7 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 97
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
					Case 98
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
					Case 99
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 100
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
					Case 101
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
					Case 102
						Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
						x = x + wd * 5 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
						x = x + wd * 2 * r2
						Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
						x = x + wd * 4 * r2
					End Select
				End If
				'Stop character(~)
				'################################################
				Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
				x = x + wd * 4 * r2
				Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
				x = x + wd * 2 * r2
				Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
				x = x + wd * 5 * r2
				Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
				'##################################################
				x = x + wd * 2 * r2
				If ((bar.szBarCaption <> "")) Then 
					If ((textdisp = "TOP")) Then 
						rect1.Right = x
					Else
						Dl = SetRect(rect1, a1, b + hgt + extra, x, b + (hgt + Th + extra))
					End If
					If ((align = "LEFT")) Then  aln = DT_LEFT
					
					If ((align = "RIGHT")) Then  aln = DT_RIGHT
					
					If ((align = "CENTER")) Then  aln = DT_CENTER
					
					'dl = SetTextColor(hdc, bar.crBack)
					If ((align = "JUSTIFY")) Then 
						Dl = Len6(str2)
						sp = rect1.Right - rect1.Left
						sp /= Dl
						'Dim tm As TEXTMETRIC
						Dl = GetTextMetrics(hDc, tm)
						Dl = tm.tmAveCharWidth
						sp -= Dl
						Dl = SetTextCharacterExtra(hDc, sp)
						Dl = DrawText(hDc, bar.szBarCaption, -1, rect1, DT_CENTER Or DT_SINGLELINE)
					Else
						'dl = DrawText(hdc, bar.szBarCaption, -1, rect1, aln Or DT_SINGLELINE)
					End If
					If (bar.ltxtdisp = 1) Then  'BOTTOM
						RetVal.lnRtheight = bar.lheight + bar.lExtra + ((-1) * lf.lfHeight)
						 Else 'TOP
						RetVal.lnRtheight = bar.lheight + bar.lExtra + ((-1) * lf.lfHeight) + tm.tmExternalLeading
					End If
					RetVal.lnRtWidth = rect1.Right - rect1.Left
					 Else 'if  no caption
					RetVal.lnRtheight = bar.lheight
					RetVal.lnRtWidth = x - bar.lLeft
				End If
			End If 'if len=0
			
		End If 'if rotation=0
		
		'dl = SelectObject(hdc, GetStockObject(NULL_BRUSH))
		'dl=Rectangle(hdc,rct.left ,rct.top ,rct.right ,rct.bottom )
		Dl = SelectObject(hDc, GetStockObject(WHITE_BRUSH))
		Dl = SelectObject(hDc, GetStockObject(BLACK_PEN))
		Dl = DeleteObject(nfnt)
		Return RetVal
	End Function

	Public Function Special_128b(ByRef br As BBAR_INFO, ByVal ln As Integer) As Integer
		
		'---------------------------------------------------------------------------------------
		' Procedure : Special_128b
		' DateTime  : 10/4/2002
		' Author    : JoyPrakash
		' Purpose   : Entry point of barcode Generation Process
		'            Returns 1 on success , 0 on Failure
		'---------------------------------------------------------------------------------------
		'
		'CHECKING FOR THE EMPTY VALUES
		Dim bar As BBAR_INFO
		' UPGRADE_INFO (#0561): The 'align' symbol was defined without an explicit "As" clause.
		Dim align As Object = Nothing
		Dim er_no As Integer = 0
		Dim str As String = ""
		Dim hDc As Integer = ln

		bar = br
		If (bar.lWidth <= 0) Then 
			er_no = 54541
		ElseIf (bar.lheight <= 0) Then 
			er_no = 54542
			' ElseIf (TextOut(hdc, 0, 0, "", 1) = 0) Then
			'    er_no = 54540
		ElseIf (Not (bar.lalign >= 1 And bar.lalign <= 4)) Then 
			er_no = 54546
		ElseIf (bar.nsize <= 0) Then 
			er_no = 54544
		ElseIf (bar.tiFaceName = "") Then 
			er_no = 54544
		ElseIf (Not (bar.lstyle >= 0 And bar.lstyle <= 15)) Then 
			er_no = 54544
		ElseIf (Not (bar.lRotation >= 0 And bar.lRotation <= 3)) Then 
			er_no = 54544
		ElseIf (bar.szSymbology <> 16) Then 
			er_no = 54543
		ElseIf (Not (bar.ltxtdisp = 1 Or bar.ltxtdisp = 2)) Then 
			er_no = 54547
		End If
		'%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		Rem checking for the 128b characters
		Dim cnt As Integer
		Dim ich As String = ""
		If bar.szReadText <> "" Then 
			For cnt = 1 To Len6(bar.szReadText)
				ich = Mid(bar.szReadText, cnt, 1)
				If (Not (ich = "~" Or ich = "`" Or ich = "!" Or ich = "@" Or ich = "#" Or ich = "$" Or ich = "%" Or ich = "^" Or ich = "&" Or ich = "*" Or ich = "(" Or ich = ")" Or ich = "_" Or ich = "-" Or ich = "+" Or ich = "=" Or ich = "\" Or ich = "|" Or ich = "}" Or ich = "]" Or ich = "{" Or ich = "[" Or ich = ":" Or ich = ";" Or ich = "'" Or ich = Chr6(34) Or ich = "<" Or ich = ">" Or ich = "," Or ich = "." Or ich = "?" Or ich = "/" Or (Asc(ich) >= 48 And Asc(ich) <= 57) Or (Asc(ich) >= 65 And Asc(ich) <= 90) Or (Asc(ich) >= 97 And Asc(ich) <= 122) Or ich = Chr6(32) Or ich = Chr6(127) Or ich = Chr6(16) Or ich = Chr6(188) Or ich = Chr6(185) Or ich = Chr6(178) Or ich = Chr6(179) Or ich = "code c" Or ich = "code a")) Then 
					er_no = 54548
					Exit For
				End If
			Next
		End If
		Rem #############################################
		Dim nfnt As Integer
		Dim nbr As Integer
		Dim obr As Integer
		Dim npn As Integer
		Dim rct As RECT
		Dim rtval As RET_VAL
		Dim r2 As Integer
		Dim r1 As Integer
		Dim a As Integer
		Dim b As Integer
		Dim hgt As Integer
		Dim Width As Integer
		Dim extra As Integer
		Dim str2 As String = ""
		Dim x As Integer
		Dim wd As Integer
		Dim w As Integer
		Dim sum As Integer
		Dim a1 As Integer
		Dim ofnt As Integer
		Dim rect1 As RECT
		Dim lf As New LOGFONT(True)
		Dim ByteArrayLimit As Integer
		Dim X1 As Short
		Dim TempByteArray() As Byte
		Dim py As Short
		Dim tm As TEXTMETRIC
		Dim lstr As String = ""
		Dim sz As Size
		Dim temp As String = ""
		Dim ch As String = ""
		Dim change As String = ""
		Dim t1 As String = ""
		Dim t2 As String = ""
		Dim t3 As String = ""
		Dim chk As Short
		Dim aln As Short
		If ((bar.szReadText <> "") And er_no = 0) Then 
			rtval = Ret_Width_Height(bar, hDc)
			
			rct.Left = bar.lLeft
			rct.Top = bar.lTop
			rct.Right = rct.Left + rtval.lnRtWidth
			'rct.bottom=rct.top+rtval.lnRtheight
			'######################################################
			'PARAMETERS AND THIER MEANING
			'a=LEFT
			'b=TOP
			'hgt=Height og the Barcode
			'width=width of the thin Barcode in pixel
			'r1=ratio of the thick barcode and thin barcode
			'str=Value of the barcode
			'align=alignment ofthe text i.e 1=left,2=center,3=right,4=justify
			'textdisp= text position with respect to barcode i.e 2=TOP or 1=BOTTOM
			'extra=distance of the text from the barcode
			'ln=device context of the out put device
			'######################################################
			'#######################################################
			'ASSIGNING VALUE FROM THE STRUCTURE
			'#########################################################
			a = bar.lLeft
			b = bar.lTop
			hgt = bar.lheight
			Width = bar.lWidth
			r2 = bar.lR1
			r2 = 1
			r1 = 1
			str = bar.szReadText
			
			'ASSIGNING THE VALUES FOR THE ALIGNMENT AND TEXT DISPLAY POSITION
			Select Case (bar.lalign)
			Case 1: align = "LEFT"
			Case 2: align = "CENTER"
			Case 3: align = "RIGHT"
			Case 4: align = "JUSTIFY"
			Case Else: align = "CENTER"
			End Select
			
			If (bar.ltxtdisp = 1) Then 
				textdisp = "BOTTOM"
			ElseIf (bar.ltxtdisp = 2) Then 
				textdisp = "TOP"
			Else
				textdisp = "BOTTOM"
			End If
			extra = bar.lExtra
			'#########################################################
			str2 = str
			a1 = a
			
			'*****************************************************************

			'        ///////CREATING FONT OF CHOICE//////////////
			'       ////////////SETTING THE ANGLE OF ROTATION///
			If (bar.lRotation = 1) Then 
				lf.lfEscapement = 900
			End If
			
			If (bar.lRotation = 2) Then 
				lf.lfEscapement = 1800
			End If
			If (bar.lRotation = 0) Then 
				lf.lfEscapement = 3600
			End If
			
			If (bar.lRotation = 3) Then 
				lf.lfEscapement = 2700
			End If

			'/////////////////////////////////////////////////
			
			' //////FOR LOGFONT ASSIGNMENT//////
			TempByteArray = StringToByteArray6(StrConv6(bar.tiFaceName & Chr6(0), VBA.VbStrConv.vbFromUnicode))
			ByteArrayLimit = UBound6(TempByteArray)
			For X1 = 0 To ByteArrayLimit
				lf.lfFaceName(X1) = TempByteArray(X1)
			Next
			'lf.lfFaceName = bar.tiFaceName
			'// lstrcpy(lf.lfFaceName,"Arial")
			
			'/////////////////////////////////////////////////
			If ((bar.lRotation = 2) Or (bar.lRotation = 0)) Then 
				py = GetDeviceCaps(hDc, 90)
			Else
				py = GetDeviceCaps(hDc, 88)
			End If
			
			If (bar.nsize > 0) Then 
				lf.lfHeight = -MulDiv(bar.nsize, py, 72)
			Else
				lf.lfHeight = bar.nsize
			End If
			Select Case (bar.lstyle)
			Case 15
				lf.lfItalic = 255
				lf.lfWeight = 700
				lf.lfUnderline = 1
				lf.lfStrikeOut = 1
			Case 14
				lf.lfItalic = 255
				lf.lfWeight = 400
				lf.lfUnderline = 1
				lf.lfStrikeOut = 1
			Case 13
				lf.lfItalic = 0
				lf.lfWeight = 700
				lf.lfUnderline = 1
				lf.lfStrikeOut = 1
			Case 12
				lf.lfItalic = 0
				lf.lfWeight = 400
				lf.lfUnderline = 1
				lf.lfStrikeOut = 1
			Case 11
				lf.lfItalic = 255
				lf.lfWeight = 700
				lf.lfUnderline = 0
				lf.lfStrikeOut = 1
			Case 10
				lf.lfItalic = 255
				lf.lfWeight = 400
				lf.lfUnderline = 0
				lf.lfStrikeOut = 1
			Case 9
				lf.lfItalic = 0
				lf.lfWeight = 700
				lf.lfUnderline = 0
				lf.lfStrikeOut = 1
			Case 8
				lf.lfItalic = 0
				lf.lfWeight = 400
				lf.lfUnderline = 0
				lf.lfStrikeOut = 1
			Case 7
				lf.lfItalic = 255
				lf.lfWeight = 700
				lf.lfUnderline = 1
				lf.lfStrikeOut = 0
			Case 6
				lf.lfItalic = 255
				lf.lfWeight = 400
				lf.lfUnderline = 1
				lf.lfStrikeOut = 0
			Case 5
				lf.lfItalic = 0
				lf.lfWeight = 700
				lf.lfUnderline = 1
				lf.lfStrikeOut = 0
			Case 4
				lf.lfItalic = 0
				lf.lfWeight = 400
				lf.lfUnderline = 1
				lf.lfStrikeOut = 0
			Case 3
				lf.lfItalic = 255
				lf.lfWeight = 700
				lf.lfUnderline = 0
				lf.lfStrikeOut = 0
			Case 2
				lf.lfItalic = 255
				lf.lfWeight = 400
				lf.lfUnderline = 0
				lf.lfStrikeOut = 0
			Case 1
				lf.lfItalic = 0
				lf.lfWeight = 700
				lf.lfUnderline = 0
				lf.lfStrikeOut = 0
			Case 0
				lf.lfItalic = 0
				lf.lfWeight = 400
				lf.lfUnderline = 0
				lf.lfStrikeOut = 0
			End Select
			'////OTHER VALUES//////
			lf.lfCharSet = 0
			lf.lfClipPrecision = 2
			lf.lfOutPrecision = 3
			lf.lfPitchAndFamily = 2
			lf.lfQuality = 1
			lf.lfWidth = 0
			'lf.lfFaceName = bar.tiFaceName
			nfnt = CreateFontIndirect(lf)
			ofnt = SelectObject(hDc, nfnt)
			'//CALCULATING THE dl=Rectangle POSITION
			Dl = GetTextMetrics(hDc, tm)
			'//lstr= new char[strlen(bar->szBarCaption )+1]
			lstr = bar.szBarCaption
			If ((lstr <> "")) Then 
				If (GetTextExtentPoint32(hDc, lstr, Len6(lstr), sz) = 1) Then 
					If (sz.cx > rtval.lnRtWidth) Then 
						rct.Left = bar.lLeft
						rct.Right = bar.lLeft + sz.cx + 2 * tm.tmInternalLeading
						a = a + (sz.cx - rtval.lnRtWidth) / 2
					End If
					If (bar.ltxtdisp = 1) Then 
						rct.Bottom = bar.lTop + bar.lheight + bar.lExtra + tm.tmHeight + 2
					Else
						rct.Bottom = bar.lTop + bar.lheight + bar.lExtra + sz.cy + 2
					End If
				End If
			Else
				rct.Right = a + rtval.lnRtWidth
				rct.Left = a
				rct.Top = b
				rct.Bottom = b + rtval.lnRtheight + 1
			End If
			'   //DRAWING THE BACK GROUND dl=Rectangle
			obr = CreateSolidBrush(bar.crBack)
			Dl = SelectObject(hDc, obr)
			Dl = SelectObject(hDc, GetStockObject(NULL_PEN))
			Dl = RECTANGLE(hDc, rct.Left, rct.Top, rct.Right + 2, rct.Bottom)
			Dl = SelectObject(hDc, GetStockObject(BLACK_PEN))
			Dl = SelectObject(hDc, GetStockObject(WHITE_BRUSH))
			Dl = DeleteObject(obr)
			'//#####################################################
			'          ////////////CREATING BRUSH PEN FOR BACK& FORE COLOR////////
			nbr = CreateSolidBrush(bar.crFore)
			npn = CreatePen(PS_SOLID, 1, bar.crFore)
			'///////////////////////////////////////////////////////////
			
			Dl = SelectObject(hDc, nbr)
			Dl = SelectObject(hDc, npn)
			Dl = SetTextColor(hDc, bar.TextColor)
			Dl = SetBkMode(hDc, TRANSPARENT)
			'//*************************************************************************8
			'//####################  ASSIGNING THE LEFT TOP CO-ORDINATE

			Th = tm.tmHeight + tm.tmExternalLeading
			If (bar.lRotation = 0) Then 
				If ((textdisp = "TOP") And (bar.szBarCaption <> "")) Then 
					If (sz.cx > rtval.lnRtWidth) Then 
						rect1.Left = rct.Left
						rect1.Right = bar.lLeft + sz.cx + tm.tmInternalLeading
					Else
						rect1.Left = a
						rect1.Right = rct.Right
					End If
					rect1.Top = b
					rect1.Bottom = b + sz.cy + extra
					b = b + (sz.cy + extra + 1) 'top
					If (sz.cx > rtval.lnRtWidth) Then 
						x = rct.Left + ((rct.Right - rct.Left) - rtval.lnRtWidth) / 2
					Else
						x = a 'LEFT
					End If
				Else
					If (sz.cx > rtval.lnRtWidth) Then 
						x = rct.Left + ((rct.Right - rct.Left) - rtval.lnRtWidth) / 2
					Else
						x = a 'LEFT
					End If
				End If
				temp = ""
				'//######################## ASSIGNING VALUE FOR THE WIDTH ####################
				len1 = Len6(str)
				If (len1 <> 0) Then 
					If (Width < 1) Then 
						w = 1
						wd = 1
					Else
						w = Width
						wd = Width
					End If
					'//######################Start Character ################################
					
					Dl = RECTANGLE(hDc, x, b, x + wd * (r1), b + hgt)
					x = x + wd * (4 * r1)
					Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
					x = x + wd * 2 * r1
					Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
					x = x + wd * 5 * r2
					sum = sum + 94 * 1
					'//##########################################################################
					t = 0
					str = str2
					change = "n"
					t2 = "-55": t3 = "-54": t1 = "-68"
					chk = 2
					For j = 0 To Len6(str) - 1
						ch = Mid(str, j + 1, 1)
						st = ""
						
						If (st = "00") Or (ch = Chr6(32)) Then  'space
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r1, b + hgt)
							x = x + w * (3 * r1)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 2 * (r2 + r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							
							sum = sum + 0 * chk
						End If
						
						If ((st = "01") Or (ch = "!")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r2 * 2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 1 * chk
						End If
						If ((st = "02") Or (ch = Chr6(34))) Then  'for "
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 2 * (r2 + r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 2 * (r2 + r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 2 * chk
						End If
						
						If ((st = "03") Or (ch = "#")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							
							sum = sum + 3 * chk
						End If
						If ((st = "04") Or (ch = "$")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 4 * chk
						End If
						If ((st = "05") Or (ch = "%")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 5 * chk
						End If
						If ((st = "06") Or (ch = "&")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							
							sum = sum + 6 * chk
						End If
						If ((st = "07") Or (ch = "'")) Then  'single quote
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							
							sum = sum + 7 * chk
						End If
						If ((st = "08") Or (ch = "(")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							
							sum = sum + 8 * chk
						End If
						If ((st = "09") Or (ch = ")")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 9 * chk
						End If
						If ((st = "10") Or (ch = "*")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							
							sum = sum + 10 * chk
						End If
						If ((st = "11") Or (ch = "+")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							
							sum = sum + 11 * chk
						End If
						If ((st = "12") Or (ch = ",")) Then  'comma
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * r2 * 2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 12 * chk
						End If
						If ((st = "13") Or (ch = "-")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 13 * chk
						End If
						If ((st = "14") Or (ch = ".")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 14 * chk
						End If
						If ((st = "15") Or (ch = "/")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 15 * chk
						End If
						If ((st = "16") Or (ch = Chr6(48))) Then  '0
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 16 * chk
						End If
						If ((st = "17") Or (ch = Chr6(49))) Then  '1
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 17 * chk
						End If
						If ((st = "18") Or (ch = Chr6(50))) Then  '2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							sum = sum + 18 * chk
						End If
						If ((st = "19") Or (ch = Chr6(51))) Then  '3
							Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 19 * chk
						End If
						If ((st = "20") Or (ch = Chr6(52))) Then  '4
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 20 * chk
						End If
						If ((st = "21") Or (ch = Chr6(53))) Then  '5
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 21 * chk
						End If
						If ((st = "22") Or (ch = Chr6(54))) Then  '6
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 22 * chk
						End If
						If ((st = "23") Or (ch = Chr6(55))) Then  '7
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 23 * chk
						End If
						If ((st = "24") Or (ch = Chr6(56))) Then  '8
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 24 * chk
						End If
						
						If ((st = "25") Or (ch = Chr6(57))) Then  '9
							Dl = RECTANGLE(hDc, x, b, x + w * (r1 + r2), b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
							x = x + w * (r2 + r2)
							sum = sum + 25 * chk
						End If
						
						If ((st = "26") Or (ch = ":")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 26 * chk
						End If
						
						If ((st = "27") Or (ch = ";")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 27 * chk
						End If
						If ((st = "28") Or (ch = "<")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 28 * chk
						End If
						If ((st = "29") Or (ch = "=")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							sum = sum + 29 * chk
						End If
						If ((st = "30") Or (ch = ">")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 30 * chk
						End If
						If ((st = "31") Or (ch = "?")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 31 * chk
						End If
						
						If ((st = "32") Or (ch = "@")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 32 * chk
						End If
						If ((st = "33") Or (ch = "A")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 33 * chk
						End If
						If ((st = "34") Or (ch = "B")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 34 * chk
						End If
						If ((st = "35") Or (ch = "C")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 35 * chk
						End If
						If ((st = "36") Or (ch = "D")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 36 * chk
						End If
						If ((st = "37") Or (ch = "E")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 37 * chk
						End If
						If ((st = "38") Or (ch = "F")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							sum = sum + 38 * chk
						End If
						If ((st = "39") Or (ch = "G")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 39 * chk
						End If
						If ((st = "40") Or (ch = "H")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 40 * chk
						End If
						If ((st = "41") Or (ch = "I")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							sum = sum + 41 * chk
						End If
						If ((st = "42") Or (ch = "J")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 6 * r2
							sum = sum + 42 * chk
						End If
						If ((st = "43") Or (ch = "K")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 43 * chk
						End If
						If ((st = "44") Or (ch = "L")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 44 * chk
						End If
						If ((st = "45") Or (ch = "M")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							sum = sum + 45 * chk
						End If
						If ((st = "46") Or (ch = "N")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 46 * chk
						End If
						If ((st = "47") Or (ch = "O")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 47 * chk
						End If
						If ((st = "48") Or (ch = "P")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							sum = sum + 48 * chk
						End If
						If ((st = "49") Or (ch = "Q")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 49 * chk
						End If
						If ((st = "50") Or (ch = "R")) Then 
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							sum = sum + 50 * chk
						End If
						If ((st = "51") Or (ch = "S")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 51 * chk
							
						End If
						If ((st = "52") Or (ch = "T")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 52 * chk
							
						End If
						If ((st = "53") Or (ch = "U")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 53 * chk
							
						End If
						If ((st = "54") Or (ch = "V")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 54 * chk
							
						End If
						If ((st = "55") Or (ch = "W")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 55 * chk
							
						End If
						If ((st = "56") Or (ch = "X")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 56 * chk
							
						End If
						If ((st = "57") Or (ch = "Y")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 57 * chk
							
						End If
						If ((st = "58") Or (ch = "Z")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 58 * chk
							
						End If
						If ((st = "59") Or (ch = "[")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 59 * chk
							
						End If
						If ((st = "60") Or (ch = "\")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 60 * chk
							
						End If
						If ((st = "61") Or (ch = "]")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 61 * chk
							
						End If
						If ((st = "62") Or (ch = "^")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 62 * chk
							
						End If
						If ((st = "63") Or (ch = "_")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							sum = sum + 63 * chk
							
						End If
						If ((st = "64") Or (ch = "`")) Then  'ACCENT
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 64 * chk
							
						End If
						If ((st = "65") Or (ch = Chr6(1)) Or (ch = "a")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							sum = sum + 65 * chk
							
						End If
						If ((st = "66") Or (ch = Chr6(2)) Or (ch = "b")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 66 * chk
							
						End If
						If ((st = "67") Or (ch = Chr6(3)) Or (ch = "c")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 67 * chk
							
						End If
						If ((st = "68") Or (ch = Chr6(4)) Or (ch = "d")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 68 * chk
							
						End If
						If ((st = "69") Or (ch = Chr6(5)) Or (ch = "e")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 69 * chk
							
						End If
						If ((st = "70") Or (ch = Chr6(6)) Or (ch = "f")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 70 * chk
							
						End If
						If ((st = "71") Or (ch = Chr6(7)) Or (ch = "g")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 71 * chk
							
						End If
						If ((st = "72") Or (ch = Chr6(8)) Or (ch = "h")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 72 * chk
							
						End If
						If ((st = "73") Or (ch = Chr6(9)) Or (ch = "i")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 73 * chk
							
						End If
						If ((st = "74") Or (ch = Chr6(10)) Or (ch = "j")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 74 * chk
							
						End If
						If ((st = "75") Or (ch = Chr6(11)) Or (ch = "k")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 75 * chk
							
						End If
						If ((st = "76") Or (ch = Chr6(12)) Or (ch = "l")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 76 * chk
							
						End If
						If ((st = "77") Or (ch = Chr6(13)) Or (ch = "m")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 77 * chk
							
						End If
						If ((st = "78") Or (ch = Chr6(14)) Or (ch = "n")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 78 * chk
							
						End If
						If ((st = "79") Or (ch = Chr6(15)) Or (ch = "o")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 79 * chk
							
						End If
						If ((st = "80") Or (ch = Chr6(16)) Or (ch = "p")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							sum = sum + 80 * chk
							
						End If
						If ((st = "81") Or (ch = Chr6(17)) Or (ch = "q")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							sum = sum + 81 * chk
							
						End If
						If ((st = "82") Or (ch = Chr6(18)) Or (ch = "r")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 82 * chk
							
						End If
						If ((st = "83") Or (ch = Chr6(19)) Or (ch = "s")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 83 * chk
							
						End If
						If ((st = "84") Or (ch = Chr6(20)) Or (ch = "t")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 84 * chk
							
						End If
						If ((st = "85") Or (ch = Chr6(21)) Or (ch = "u")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 85 * chk
							
						End If
						If ((st = "86") Or (ch = Chr6(22)) Or (ch = "v")) Then 
							
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 86 * chk
							
						End If
						If ((st = "87") Or (ch = Chr6(23)) Or (ch = "w")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 87 * chk
							
						End If
						If ((st = "88") Or (ch = Chr6(24)) Or (ch = "x")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 88 * chk
							
						End If
						If ((st = "89") Or (ch = Chr6(25)) Or (ch = "y")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 89 * chk
							
						End If
						If ((st = "90") Or (ch = Chr6(26)) Or (ch = "z")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 90 * chk
							
						End If
						If ((st = "91") Or (ch = Chr6(27)) Or (ch = "{")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							sum = sum + 91 * chk
							
						End If
						If ((st = "92") Or (ch = Chr6(28)) Or (ch = "|")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							sum = sum + 92 * chk
							
						End If
						If ((st = "93") Or (ch = Chr6(29)) Or (ch = "}")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 93 * chk
							
						End If
						If ((st = "94") Or (ch = Chr6(30)) Or (ch = "~")) Then 
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 94 * chk
							
						End If
						If ((st = "95") Or (ch = Chr6(127))) Then  'DEL
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 95 * chk
							
						End If
						If ((st = "96") Or (ch = "-77") Or (ch = Chr6(179))) Then  'FNC3
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 96 * chk
							
						End If
						If ((st = "97") Or (ch = "-78") Or (ch = Chr6(178))) Then  'FNC2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 97 * chk
							
						End If
						If ((st = "98") Or (ch = "-53") Or (ch = Chr6(16))) Then  'SHIFT
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							sum = sum + 98 * chk
							
						End If
						
						If ((st = "99") Or (ch = "-54")) Then  'CODE C
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 99 * chk
						End If
						If ((st = "100") Or (ch = "-55") Or (ch = Chr6(188))) Then  'FNC 4
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 100 * chk
						End If
						If ((st = "101") Or (ch = "-68")) Then  'CODE A
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							sum = sum + 101 * chk
						End If
						If ((st = "102") Or (ch = "-71") Or (ch = Chr6(185))) Then  'FNC1
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							sum = sum + 102 * chk
						End If
						chk += 1
					Next
					If bar.lShowCheck = 1 Then 
						'//################ CHECK CHARACTER VALUE ################
						sum = (sum Mod 103)
						'//########################################################################
						'//DRAWING THE CHECK CHARACTER
						'//###################################################################
						Select Case (sum)
						Case 0
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 1
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 3
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 4
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 5
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 6
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 7
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
							x = x + w * 3 * r2
						Case 8
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 9
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 10
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 11
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 12
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * r2 * 2
							Dl = RECTANGLE(hDc, x, b, x + w * r2 * 2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 13
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 14
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 15
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 16
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 17
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 18
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
						Case 19
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 20
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 21
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 22
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 23
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 24
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 25
							Dl = RECTANGLE(hDc, x, b, x + w * (r1 + r2), b + hgt)
							x = x + w * (r1 + 2 * r2)
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r2, b + hgt)
							x = x + w * (r2 + r2)
						Case 26
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 27
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 28
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
						Case 29
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
						Case 30
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 31
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 32
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 33
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 34
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 35
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 36
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 37
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 38
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
						Case 39
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 40
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
						Case 41
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
						Case 42
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 6 * r2
						Case 43
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 44
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 45
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
						Case 46
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 47
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 48
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
						Case 49
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 50
							Dl = RECTANGLE(hDc, x, b, x + w * 2 * r2, b + hgt)
							x = x + w * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * r1, b + hgt)
							x = x + w * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + w * 3 * r2, b + hgt)
							x = x + w * 4 * r2
						Case 51
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
						Case 52
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 53
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
						Case 54
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 55
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 56
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 57
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
						Case 58
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 59
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 60
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 61
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 62
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 63
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
						Case 64
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
						Case 65
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
						Case 66
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 67
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
						Case 68
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 69
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
						Case 70
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 71
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
						Case 72
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 73
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 74
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 75
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 76
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 5 * r2
						Case 77
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 78
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 79
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 80
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
						Case 81
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
						Case 82
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 83
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 84
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 85
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 86
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 87
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
						Case 88
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 6 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 89
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 90
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 91
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
							x = x + wd * 3 * r2
						Case 92
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
						Case 93
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 94
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 95
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
						Case 96
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 7 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 97
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
						Case 98
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
						Case 99
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 100
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
						Case 101
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
						Case 102
							Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
							x = x + wd * 5 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
							x = x + wd * 2 * r2
							Dl = RECTANGLE(hDc, x, b, x + wd * 3 * r2, b + hgt)
							x = x + wd * 4 * r2
						End Select
					End If
					'Stop character(~)
					'################################################
					Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
					x = x + wd * 4 * r2
					Dl = RECTANGLE(hDc, x, b, x + wd * r1, b + hgt)
					x = x + wd * 2 * r2
					Dl = RECTANGLE(hDc, x, b, x + wd * 4 * r2, b + hgt)
					x = x + wd * 5 * r2
					Dl = RECTANGLE(hDc, x, b, x + wd * 2 * r2, b + hgt)
					'##################################################
					x = x + wd * 2 * r2
					
					If (bar.szBarCaption <> "") Then 
						If (textdisp = "BOTTOM") Then 
							If (sz.cx > rtval.lnRtWidth) Then 
								Dl = SetRect(rect1, a1, b + hgt + extra, (a1 + sz.cx + 2 * tm.tmInternalLeading), b + (hgt + sz.cy + extra))
							Else
								Dl = SetRect(rect1, a1, b + hgt + extra, x, b + (hgt + sz.cy + extra))
							End If
						End If
						If ((align = "LEFT")) Then  aln = DT_LEFT
						
						If ((align = "RIGHT")) Then  aln = DT_RIGHT
						If (align = "CENTER") Then  aln = DT_CENTER
						
						Dl = SetTextColor(hDc, bar.TextColor)
						If ((align = "JUSTIFY")) Then 
							Dl = Len6(str2)
							sp = rect1.Right - rect1.Left
							sp /= Dl
							'Dim tm As TEXTMETRIC
							Dl = GetTextMetrics(hDc, tm)
							Dl = tm.tmAveCharWidth
							sp -= Dl
							Dl = SetTextCharacterExtra(hDc, sp)
							Dl = DrawText(hDc, str2, -1, rect1, DT_CALCRECT Or DT_SINGLELINE)
							Dl = DrawText(hDc, str2, -1, rect1, DT_CENTER Or DT_SINGLELINE)
						Else
							Dl = DrawText(hDc, bar.szBarCaption, Len6(bar.szBarCaption), rect1, aln Or DT_SINGLELINE)
						End If
					End If
				End If
				bar.lRetHeight = (rct.Bottom - rct.Top)
				bar.lRetWidth = (rct.Right - rct.Left)
				br = bar
			End If
			Dl = SelectObject(hDc, ofn)
			Dl = SelectObject(hDc, GetStockObject(NULL_BRUSH))
			Dl = SelectObject(hDc, GetStockObject(BLACK_PEN))
			Dl = DeleteObject(nbr)
			Dl = DeleteObject(nfnt)
			Dl = DeleteObject(npn)
			Dl = DeleteObject(obr)
			Dl = DeleteObject(ofn)
			Return 0
		Else
			Return er_no
		End If
	End Function
	
	Public Function ErrSpecial_128bMessage(ByVal er_no As Integer) As String
		Dim msgstr As String = ""
		Select Case (er_no)
		Case 54540
			msgstr = "Error(54540):Invalid Device Context specified."
		Case 54541
			msgstr = "Error(54541):Invalid Width specified."
		Case 54542
			msgstr = "Error(54542):Invalid Height specified."
		Case 54543
			msgstr = "Error(54543):Unknown Symbology encountered."
		Case 54544
			msgstr = "Error(54544):An Error occured while creating Font."
		Case 54545
			msgstr = "Error(54545):Out Of Memory."
		Case 54546
			msgstr = "Error(54546):Invalid Caption alignment specified"
		Case 54547
			msgstr = "Error(54547):Invalid Caption display position specified."
		Case 54548
			msgstr = "Error(54548):Illegal character for this symbology specified."
		Case Else
			msgstr = ""
		End Select
		Return msgstr
	End Function

End Module

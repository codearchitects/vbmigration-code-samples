' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module2

	'' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' THIS ROUTINE HAS BEEN TAKEN BY MSDN Knowledge Base, Article Q146022
	'
	'' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	
	Friend Structure Rect
	
		Public Left As Integer
		Public Top As Integer
		Public Right As Integer
		Public Bottom As Integer
	End Structure

	Friend Structure CharRange
	
		Public cpMin As Integer ' First character of range (0 for start of doc)
		Public cpMax As Integer ' Last character of range (-1 for end of doc)
	End Structure

	Friend Structure FormatRange
	
		Public hdc As Integer ' Actual DC to draw on
		Public hdcTarget As Integer ' Target DC for determining text formatting
		Public rc As Rect ' Region of the DC to draw to (in twips)
		Public rcPage As Rect ' Region of the entire DC (page size) (in twips)
		Public chrg As CharRange ' Range of text to draw (see above declaration)
	End Structure

	Private Const WM_USER As Integer = &H400I
	Private Const EM_FORMATRANGE As Integer = WM_USER + 57
	Private Const PHYSICALOFFSETX As Integer = 112
	Private Const PHYSICALOFFSETY As Integer = 113
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDeviceCaps' unamanged method with the following .NET member(s): System.Drawing.Graphics , System.Drawing.Printing.PrinterSettings, System.Management
	Private Declare Function GetDeviceCaps Lib "gdi32" (ByVal hdc As Integer, ByVal nIndex As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' IGNORED: Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA"  (ByVal hWnd As Long, ByVal msg As Long, ByVal wp As Long,  lp As Any) As Long
	Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal msg As Integer, ByVal wp As Integer, ByRef lp As FormatRange) As Integer
	Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal msg As Integer, ByVal wp As Integer, ByVal lp As Integer) As Integer

	'' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' PrintRTF - Prints the contents of a RichTextBox control using the
	'            provided margins
	'
	' RTF - A RichTextBox control to print
	'
	' LeftMarginWidth - Width of desired left margin in twips
	'
	' TopMarginHeight - Height of desired top margin in twips
	'
	' RightMarginWidth - Width of desired right margin in twips
	'
	' BottomMarginHeight - Height of desired bottom margin in twips
	'
	' Notes - If you are also using WYSIWYG_RTF() on the provided RTF
	'         parameter you should specify the same LeftMarginWidth and
	'         RightMarginWidth that you used to call WYSIWYG_RTF()
	'' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	
	Public Sub PrintRTF(ByRef RTF As VB6RichTextBox, ByRef LeftMarginWidth As Integer, ByRef TopMarginHeight As Object, ByRef RightMarginWidth As Object, ByRef BottomMarginHeight As Object)
	' UPGRADE_INFO (#0551): The 'RTF' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'LeftMarginWidth' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0561): The 'TopMarginHeight' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'TopMarginHeight' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0561): The 'RightMarginWidth' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'RightMarginWidth' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0561): The 'BottomMarginHeight' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'BottomMarginHeight' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim LeftOffset As Integer
		Dim TopOffset As Integer
		Dim LeftMargin As Integer
		Dim TopMargin As Integer
		Dim RightMargin As Integer
		Dim BottomMargin As Integer
		Dim fr As FormatRange
		Dim rcDrawTo As Rect
		Dim rcPage As Rect
		Dim TextLength As Integer
		Dim NextCharPosition As Integer
		Dim r As Integer
		
		' Start a print job to get a valid Printer.hDC
		Printer6.PrintLine(Space(1))
		Printer6.ScaleMode = VBRUN.ScaleModeConstants.vbTwips
		
		' Get the offsett to the printable area on the page in twips
		LeftOffset = Printer6.ScaleX(GetDeviceCaps(Printer6.hDC, PHYSICALOFFSETX), VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		TopOffset = Printer6.ScaleY(GetDeviceCaps(Printer6.hDC, PHYSICALOFFSETY), VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		
		' Calculate the Left, Top, Right, and Bottom margins
		LeftMargin = LeftMarginWidth - LeftOffset
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'TopMarginHeight'. Consider using the GetDefaultMember6 helper method.
		TopMargin = TopMarginHeight - TopOffset
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RightMarginWidth'. Consider using the GetDefaultMember6 helper method.
		RightMargin = (Printer6.Width - RightMarginWidth) - LeftOffset
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'BottomMarginHeight'. Consider using the GetDefaultMember6 helper method.
		BottomMargin = (Printer6.Height - BottomMarginHeight) - TopOffset
		
		' Set printable area rect
		rcPage.Left = 0
		rcPage.Top = 0
		rcPage.Right = Printer6.ScaleWidth
		rcPage.Bottom = Printer6.ScaleHeight
		
		' Set rect in which to print (relative to printable area)
		rcDrawTo.Left = LeftMargin
		rcDrawTo.Top = TopMargin
		rcDrawTo.Right = RightMargin
		rcDrawTo.Bottom = BottomMargin
		
		' Set up the print instructions
		fr.hdc = Printer6.hDC ' Use the same DC for measuring and rendering
		fr.hdcTarget = Printer6.hDC ' Point at printer hDC
		fr.rc = rcDrawTo ' Indicate the area on page to draw to
		fr.rcPage = rcPage ' Indicate entire size of page
		fr.chrg.cpMin = 0 ' Indicate start of text through
		fr.chrg.cpMax = -1 ' end of the text
		
		' Get length of text in RTF
		TextLength = Len6(RTF.Text)
		
		' Loop printing each page until done
		Do
			' Print the page by sending EM_FORMATRANGE message
			NextCharPosition = SendMessage(RTF.hWnd, EM_FORMATRANGE, CShort(True), fr)
			If NextCharPosition >= TextLength Then  Exit Do 'If done then exit
			fr.chrg.cpMin = NextCharPosition ' Starting position for next page
			Printer6.NewPage() ' Move on to next page
		Loop
		
		' Commit the print job
		Printer6.EndDoc()
		
		' Allow the RTF to free up memory
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'CInt(0)' argument. Consider creating an overload of the Declare statement.
		r = SendMessage(RTF.hWnd, EM_FORMATRANGE, CShort(False), CInt(0))
	End Sub

End Module

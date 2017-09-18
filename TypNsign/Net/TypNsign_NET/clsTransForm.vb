' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0581): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.
' UPGRADE_INFO (#0581): The 'ADODB' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class clsTransForm

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	' User32
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowRgn' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Region
	' UPGRADE_INFO (#0511): The 'SetWindowRgn' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	' UPGRADE_INFO (#0511): The 'ReleaseCapture' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Sub ReleaseCapture Lib "user32" ()
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' UPGRADE_INFO (#0511): The 'SendMessage' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetWindowDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.FromHwnd(Windows.Forms.Control.Handle), System.Windows.Forms.Control.CreateGraphics.GetHdc, System.Windows.Forms.PaintEventArgs.Graphics.GetHdc
	' UPGRADE_INFO (#0501): The 'GetWindowDC' member isn't used anywhere in current application.
	Private Declare Function GetWindowDC Lib "user32" (ByVal hWnd As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.ReleaseHdc
	' UPGRADE_INFO (#0511): The 'ReleaseDC' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function ReleaseDC Lib "user32" (ByVal hWnd As Integer, ByVal hDC As Integer) As Integer
	
	' gdi32
	' UPGRADE_INFO (#0511): The 'CreateRectRgn' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CombineRgn' unamanged method with the following .NET member(s): System.Drawing.Region.Clone, System.Drawing.Region.Exclude, System.Drawing.Region.Intersect, System.Drawing.Region.Union, System.Drawing.Region.Xor
	' UPGRADE_INFO (#0511): The 'CombineRgn' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
	' UPGRADE_INFO (#0511): The 'DeleteObject' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetRegionData' unamanged method with the following .NET member(s): System.Drawing.Region.GetRegionData
	' UPGRADE_INFO (#0511): The 'GetRegionData' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Long, ByVal dwCount As Long, lpRgnData As Any) As Long
	Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Integer, ByVal dwCount As Integer, ByVal lpRgnData As Integer) As Integer
	Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Integer, ByVal dwCount As Integer, ByRef lpRgnData As Byte) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ExtCreateRegion' unamanged method with the following .NET member(s): System.Drawing.Region.Transform
	' UPGRADE_INFO (#0511): The 'ExtCreateRegion' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Private Declare Function ExtCreateRegion Lib "gdi32" (lpXform As Any, ByVal nCount As Long, lpRgnData As Any) As Long
	Private Declare Function ExtCreateRegion Lib "gdi32" (ByVal lpXform As Integer, ByVal nCount As Integer, ByRef lpRgnData As Byte) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetPixel' unamanged method with the following .NET member(s): System.Drawing.Bitmap.GetPixel
	' UPGRADE_INFO (#0511): The 'GetPixel' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function GetPixel Lib "gdi32" (ByVal hDC As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
	' UPGRADE_INFO (#0511): The 'CreateCompatibleDC' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hDC As Integer) As Integer
	' UPGRADE_INFO (#0511): The 'SelectObject' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function SelectObject Lib "gdi32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetObject' unamanged method with the following .NET member(s): System.Drawing.Bitmap , System.Drawing.Brush , System.Drawing.Font , System.Drawing.Pen 
	' UPGRADE_INFO (#0511): The 'GetObject' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Private Declare Function GetObject Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Long, ByVal nCount As Long, lpObject As Any) As Long
	Private Declare Function GetObject Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Integer, ByVal nCount As Integer, ByRef lpObject As clsTransForm.BITMAP) As Integer
	' UPGRADE_INFO (#0511): The 'DeleteDC' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function DeleteDC Lib "gdi32" (ByVal hDC As Integer) As Integer
	
	Friend Structure BITMAP
	
	' UPGRADE_INFO (#0511): The 'BITMAP' member is referenced only by members that haven't found to be used in the current project/solution.
		Public bmType As Integer
		Public bmWidth As Integer
		Public bmHeight As Integer
		Public bmWidthBytes As Integer
		Public bmPlanes As Short
		Public bmBitsPixel As Short
		Public bmBits As Integer
	End Structure

	' UPGRADE_INFO (#0511): The 'CurRgn' member is referenced only by members that haven't found to be used in the current project/solution.
	Private CurRgn As Integer
	' UPGRADE_INFO (#0501): The 'TempRgn' member isn't used anywhere in current application.
	Private TempRgn As Integer
	' UPGRADE_INFO (#0511): The 'objName1' member is referenced only by members that haven't found to be used in the current project/solution.
	Private objName1 As Object
	
	' UPGRADE_INFO (#0501): The 'RGN_DIFF' member isn't used anywhere in current application.
	Private Const RGN_DIFF As Short = 4
	' UPGRADE_INFO (#0511): The 'WM_NCLBUTTONDOWN' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const WM_NCLBUTTONDOWN As Short = &HA1S
	' UPGRADE_INFO (#0511): The 'HTCAPTION' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const HTCAPTION As Short = 2
	
	' UPGRADE_INFO (#0501): The 'lngHeight' member isn't used anywhere in current application.
	Private lngHeight As Integer
	' UPGRADE_INFO (#0501): The 'lngWidth' member isn't used anywhere in current application.
	Private lngWidth As Integer 'height and width of object

	Public Sub SetRegion(ByRef Objct As Object, ByRef Colr As Integer, Optional ByRef FileName As String = Nothing)
	' UPGRADE_INFO (#0501): The 'SetRegion' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'Objct' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Colr' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'FileName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_INFO (#0561): The 'fso' symbol was defined without an explicit "As" clause.
		Dim fso As Object = Nothing
		Dim Exists As Boolean
		
		' //Check to see if FileName is a file
		fso = CreateObject6("Scripting.FileSystemObject")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'fso.fileexists(FileName)'. Consider using the GetDefaultMember6 helper method.
		Exists = fso.fileexists(FileName) '// Returns true if file exists
		
		objName1 = Objct
		
		'// Free the memory allocated by the previous Region
		If CurRgn Then  DeleteObject(CurRgn)
		If (Exists = True) Then  '// If file there, load it
			CurRgn = LoadRegionDataFromFile(FileName)
			 Else '// Else, make new transparent
			'// form and save it for next use...
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName1.Picture'. Consider using the GetDefaultMember6 helper method.
			CurRgn = GetBitmapRegion(objName1.Picture, Colr)
			
			'// If no name entered, don't bother writing it to HD
			'// This is for testing purposes, since no need to for see
			'// coding errors and this isn't user controled
			If FileName <> Nothing Then 
				Call SaveRegionDataToFile(FileName)
			End If
			
		End If
		
		'// Set the Forms new Region
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName1.hWnd'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 's'. Consider using the SetDefaultMember6 helper method.
		s = SetWindowRgn(objName1.hWnd, CurRgn, True)
		
		'// release the DC.
		'// Does not hurt the form even though you got its DC from VB.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName1.hWnd'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'lngHDC'. Consider using the GetDefaultMember6 helper method.
		ReleaseDC(objName1.hWnd, lngHDC)
		
	End Sub

	Private Function GetBitmapRegion(ByRef cPicture As Image, ByRef cTransparent As Integer) As Object
	' UPGRADE_INFO (#0511): The 'GetBitmapRegion' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0561): The 'GetBitmapRegion' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'cPicture' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'cTransparent' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'///////////////////////////////////
		'// SET PICTURE AS TRANSPARENT OBJECT
		'//////////
		Dim hRgn As Integer
		Dim tRgn As Integer
		Dim x As Integer
		Dim y As Integer
		Dim X0 As Integer
		Dim hDC As Integer
		Dim BM As clsTransForm.BITMAP
		'
		'Create a new memory DC, where we will scan the picture
		hDC = CreateCompatibleDC(0)
		If hDC Then 
			'
			'Let the new DC select the Picture
			SelectObject(hDC, GetPictureHandle6(cPicture))
			'
			'Get the Picture dimensions and create a new rectangular
			'region
			GetObject(GetPictureHandle6(cPicture), Len6(BM), BM)
			hRgn = CreateRectRgn(0, 0, BM.bmWidth, BM.bmHeight)
			'
			'Start scanning the picture from top to bottom

			'//////////////////////////
			With frmSplash '// This brings up frmsplash
				.Show() '// If program is run for the first
				.Bar1.Min = 0 '// time
				.Bar1.Max = BM.bmHeight
			End With
			'//////////////////////////

			For y = 0 To BM.bmHeight
				For x = 0 To BM.bmWidth
					'
					'Scan a line of non transparent pixels
					While x <= BM.bmWidth And GetPixel(hDC, x, y) <> cTransparent
						x += 1
					End While
					'
					'Mark the start of a line of transparent pixels
					X0 = x
					'
					'Scan a line of transparent pixels
					While x <= BM.bmWidth And GetPixel(hDC, x, y) = cTransparent
						x += 1
					End While
					'
					'Create a new Region that corresponds to the row of
					'Transparent pixels and then remove it from the main
					'Region
					If X0 < x Then 
						tRgn = CreateRectRgn(X0, y, x, y + 1)
						CombineRgn(hRgn, hRgn, tRgn, 4)
						'
						'Free the memory used by the new temporary Region
						DeleteObject(tRgn)
					End If
				Next
				
				'///////////////////////////
				frmSplash.Bar1.Value = y
				DoEvents6()
				'//////////////////////////
				
			Next
			'
			'Return the memory address to the shaped region
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'GetBitmapRegion'. Consider using the SetDefaultMember6 helper method.
			GetBitmapRegion = hRgn
			
			'//////////////////////////////
			Unload6(frmSplash)
			'//////////////////////////////
			
		End If
		'
		'Free memory by deleting the created DC
		DeleteDC(hDC)
		
	End Function
	
	Public Sub DragForm(ByRef hWnd As Integer, ByRef intButton As Short)
	' UPGRADE_INFO (#0501): The 'DragForm' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'hWnd' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'intButton' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		On Error Resume Next 
		
		If intButton = VBRUN.MouseButtonConstants.vbLeftButton Then 
			'Move the borderless form...
			ReleaseCapture()
			SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0)
		End If
		
	End Sub
	
	Private Sub SaveRegionDataToFile(ByVal sPath As String)
	' UPGRADE_INFO (#0511): The 'SaveRegionDataToFile' member is referenced only by members that haven't found to be used in the current project/solution.
		'this sub was pulled from www.vbaccelerator.com
		Dim iFile As Integer
		Dim nBytes As Integer
		Dim b() As Byte
		
		On Error GoTo ErrorHandler  ' Out of memory
		
		nBytes = GetRegionData(CurRgn, 0, 0%)
		If nBytes > 0 Then 
			ReDim b(nBytes - 1)
			If nBytes = GetRegionData(CurRgn, nBytes, b(0)) Then 
				On Error Resume Next  ' Attempt to kill file
				Kill(sPath)
				On Error GoTo ErrorHandler  ' Error handler checks for file error
				iFile = FreeFile6()
				FileOpen6(iFile, sPath, OpenMode.Binary, OpenAccess.Write, OpenShare.LockRead, -1)
				FilePut6(iFile, b)
				FileClose6(iFile)
			Else
				Err.Raise(vbObjectError + 512 + 2001, "TransForm", "Unable to get region data in SaveRegionDataToFile")
			End If
		Else
			Err.Raise(vbObjectError + 512 + 2002, "TransForm", "Unable to determine size of region in SaveRegionDataToFile")
		End If
		
		Exit Sub
		
ErrorHandler:
		Dim lErr As Integer
		Dim sErr As String = ""
		lErr = Err.Number: sErr = Err.Description
		If iFile > 0 Then 
			FileClose6(iFile)
		End If
		Err.Raise(lErr, "TransForm", sErr)
		Exit Sub
		
	End Sub

	Private Function LoadRegionDataFromFile(ByVal sFileName As String) As Integer
	' UPGRADE_INFO (#0511): The 'LoadRegionDataFromFile' member is referenced only by members that haven't found to be used in the current project/solution.
		'this sub was pulled from www.vbaccelerator.com
		Dim iFile As Integer
		Dim b() As Byte
		Dim dwCount As Integer
		On Error GoTo ErrorHandler 
		
		iFile = FreeFile6()
		FileOpen6(iFile, sFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockWrite, -1)
		ReDim b(LOF6(iFile) - 1)
		FileGet6(iFile, b)
		FileClose6(iFile)
		
		dwCount = UBound6(b) - LBound6(b) + 1
		Return ExtCreateRegion(0%, dwCount, b(0))
		
		Exit Function
		
ErrorHandler:
		Dim lErr As Integer
		Dim sErr As String = ""
		lErr = Err.Number: sErr = Err.Description
		If iFile > 0 Then 
			FileClose6(iFile)
		End If
		Err.Raise(lErr, App6.EXEName & ".cDIBSectionRegion", sErr)
		Exit Function
	End Function

End Class

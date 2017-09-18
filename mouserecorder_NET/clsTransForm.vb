' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class clsTransForm

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'Doug Gaede
	'version 3.0.0
	'December 28, 2000
	'----------------------------------------------------
	'Notes
	'See the attached README.txt file.
	'----------------------------------------------------
	'You are free to use, modify and distribute this code.
	
	'This class causes a Form, PictureBox, CommandButton,
	'CheckBox or OptionButton to become shaped depending on the picture
	'that is assigned to the Picture property.  One color in the picture
	'will become the transparent color, depending on the color values passed to ShapeMe.
	'The DragForm sub allows the user to drag a form that doesn't have a title bar.
	
	'Note that you MUST set certain properties for each object manually.
	'See the notes in the code below to find out which and what values.
	'I set as many as I could in code, but some can not
	'because they are read-only at runtime.
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetPixel' unamanged method with the following .NET member(s): System.Drawing.Bitmap.GetPixel
	Private Declare Function GetPixel Lib "gdi32" (ByVal hDC As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowRgn' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Region
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
	Private Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CombineRgn' unamanged method with the following .NET member(s): System.Drawing.Region.Clone, System.Drawing.Region.Exclude, System.Drawing.Region.Intersect, System.Drawing.Region.Union, System.Drawing.Region.Xor
	Private Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	Private Declare Sub ReleaseCapture Lib "user32" ()
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetWindowDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.FromHwnd(Windows.Forms.Control.Handle), System.Windows.Forms.Control.CreateGraphics.GetHdc, System.Windows.Forms.PaintEventArgs.Graphics.GetHdc
	Private Declare Function GetWindowDC Lib "user32" (ByVal hwnd As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.ReleaseHdc
	Private Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Integer, ByVal hDC As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetRegionData' unamanged method with the following .NET member(s): System.Drawing.Region.GetRegionData
	' IGNORED: Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Long, ByVal dwCount As Long, lpRgnData As Any) As Long
	Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Integer, ByVal dwCount As Integer, ByVal lpRgnData As Integer) As Integer
	Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Integer, ByVal dwCount As Integer, ByRef lpRgnData As Byte) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ExtCreateRegion' unamanged method with the following .NET member(s): System.Drawing.Region.Transform
	' IGNORED: Private Declare Function ExtCreateRegion Lib "gdi32" (lpXform As Any, ByVal nCount As Long, lpRgnData As Any) As Long
	Private Declare Function ExtCreateRegion Lib "gdi32" (ByVal lpXform As Integer, ByVal nCount As Integer, ByRef lpRgnData As Byte) As Integer
	
	Private Const RGN_DIFF As Short = 4
	
	Private CurRgn As Integer
	Private TempRgn As Integer ' Region variables
	
	'For dragging the form
	Private Const WM_NCLBUTTONDOWN As Short = &HA1S
	Private Const HTCAPTION As Short = 2
	
	'these next 2 variables are used in the ShapeMe sub, but are declared here so the code in the Initialize... subs works
	Private objName As Object 'the object that will be worked on
	Private lngHeight As Integer
	Private lngWidth As Integer 'height and width of object
	
	Public Sub ShapeMe(ByRef Name As Object, ByRef Color As Integer, Optional ByRef Load As Boolean = True, Optional ByRef FileName As String = Nothing)
		
		'Name = a Form or PictureBox name.
		'Color = the color to convert to transparent (easiest to use RGB function to pass in this value)
		
		Dim x As Integer
		Dim y As Integer 'points on form
		Dim booMiddleOfSet As Boolean 'used during the gathering of transparent points in ShapeMe
		Dim colPoints As Collection = New Collection() 'this will hold all usrPoints
		Dim Z As Object = Nothing 'used during iteration through collection
		Dim lngTransY As Integer 'these 3 variables hold each point that will be made transparent
		Dim lngTransStartX As Integer
		Dim lngTransEndX As Integer
		Dim intStoreScaleMode As Short 'stores the commandbutton's form's scalemode
		Dim lngHDC As Integer 'the hDC property of the object
		
		'set this so it can be used in the Initialization routine
		objName = Name
		
		'gather all points that need to be made transparent
		If TypeOf objName Is VB6Form Then  'check to see if this is a form and use GetPixel function which is a little faster than VB's Point
			
			'don't forget to set the Picture to a picture, BorderStyle = None settings manually
			'you CAN set Picture in your code since it isn't read-only at runtime
			InitializeForFormOrPictureBox()
			
			If FileName <> Nothing And Load = True Then  'load region data from file
				LoadRegionDataFromFile(FileName)
				
				 Else 'do it the hard way
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName.hDC'. Consider using the GetDefaultMember6 helper method.
				lngHDC = objName.hDC 'device context for object, used in GetPixel.  GetDC does not work for a form (?) so must use VB's hwnd property
				booMiddleOfSet = False
				For y = 0 To lngHeight ' Go through each column of pixels on form
					lngTransY = y
					For x = 0 To lngWidth ' Go through each line of pixels on form
						If GetPixel(lngHDC, x, y) = Color Then  ' If the pixel's color is the transparency color, record it
							If booMiddleOfSet = False Then 
								lngTransStartX = x
								lngTransEndX = x
								booMiddleOfSet = True
							Else
								lngTransEndX = x
							End If 'booMiddleOfSet = False
						Else
							If booMiddleOfSet Then 
								colPoints.Add(Array6(lngTransY, lngTransStartX, lngTransEndX))
								booMiddleOfSet = False
							End If 'booMiddleOfSet = True
						End If 'GetPixel(lngHDC, X, Y) = Color
					Next
				Next
				'create base region to draw to; used below
				CurRgn = CreateRectRgn(0, 0, lngWidth, lngHeight)
			End If 'load region data from file
			
		ElseIf TypeOf objName Is VB6PictureBox Then  'if a PictureBox then use Point function; a little slower but works when GetPixel doesn't
			
			'don't forget to set the Picture to a picture, BorderStyle = None settings manually
			'you CAN set Picture in your code since it isn't read-only at runtime
			InitializeForFormOrPictureBox()
			
			If FileName <> Nothing And Load = True Then  'load region data from file
				LoadRegionDataFromFile(FileName)
				
				 Else 'do it the hard way
				'don't need a DC since we don't use GetPixel here
				booMiddleOfSet = False
				For y = 0 To lngHeight ' Go through each column of pixels on form
					lngTransY = y
					For x = 0 To lngWidth ' Go through each line of pixels on form
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName.Point(x, y)'. Consider using the GetDefaultMember6 helper method.
						If objName.Point(x, y) = Color Then 
							If booMiddleOfSet = False Then 
								lngTransStartX = x
								lngTransEndX = x
								booMiddleOfSet = True
							Else
								lngTransEndX = x
							End If 'booMiddleOfSet = False
						Else
							If booMiddleOfSet Then 
								colPoints.Add(Array6(lngTransY, lngTransStartX, lngTransEndX))
								booMiddleOfSet = False
							End If 'booMiddleOfSet = True
						End If 'Name.Point(X, Y) = Color
					Next
				Next
				'create base region to draw to; used below
				CurRgn = CreateRectRgn(0, 0, lngWidth, lngHeight)
			End If 'load region data from file
			
		ElseIf TypeOf objName Is VB6CommandButton Or TypeOf objName Is VB6OptionButton Or TypeOf objName Is VB6CheckBox Then  'check to see if this is a button
			
			'don't forget to set Picture and DownPicture to pictures, and Style = Graphical settings manually
			'you CAN set the picture properties in your code since they aren't read-only at runtime
			'I tried moving this initialization to a separate sub, but the buttons didn't draw correctly...don't know why
			'initialization
			With objName
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Parent.ScaleMode'. Consider using the GetDefaultMember6 helper method.
				intStoreScaleMode = .Parent.ScaleMode 'store it to set it back when done so you don't mess with the programmer's mind
				.Parent.ScaleMode = 3 'the button's form's scalemode must = pixel
				.Caption = "" 'you can remove this line if you really want a caption, but it does weird things
				.BackColor = Color 'necessary
				.Refresh 'necessary
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.hwnd'. Consider using the GetDefaultMember6 helper method.
				lngHDC = GetWindowDC(.hwnd) 'device context (DC) for object.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Height'. Consider using the GetDefaultMember6 helper method.
				lngHeight = .Height 'faster to use a variable
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Width'. Consider using the GetDefaultMember6 helper method.
				lngWidth = .Width 'faster to use a variable
			End With
			
			If FileName <> Nothing And Load = True Then  'load region data from file
				LoadRegionDataFromFile(FileName)
				
				 Else 'do it the hard way
				booMiddleOfSet = False
				For y = 0 To lngHeight ' Go through each column of pixels on form
					lngTransY = y
					For x = 0 To lngWidth ' Go through each line of pixels on form
						If GetPixel(lngHDC, x, y) = Color Then  ' If the pixel's color is the transparency color, record it
							If booMiddleOfSet = False Then 
								lngTransStartX = x
								lngTransEndX = x
								booMiddleOfSet = True
							Else
								lngTransEndX = x
							End If 'booMiddleOfSet = False
						Else
							If booMiddleOfSet Then 
								colPoints.Add(Array6(lngTransY, lngTransStartX, lngTransEndX))
								booMiddleOfSet = False
							End If 'booMiddleOfSet = True
						End If 'GetPixel(lngHDC, X, Y) = Color
					Next
				Next
				'create base region to draw to; used below
				CurRgn = CreateRectRgn(2, 2, lngWidth - 2, lngHeight - 2)
			End If 'load region data from file
			
		Else 'not a supported object
			Err.Raise(vbObjectError + 512 + 2000, "TransForm", "Must pass in the name of a Form, PictureBox, CommandButton, CheckBox or OptionButton.  TransForm ShapeMe method failed.")
			Exit Sub
		End If 'test for each object
		
		If FileName <> Nothing And Load = True Then  'we loaded the region data from a file so...
			'do nothing
		Else
			'create the transparent areas
			For Each Z In colPoints
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Z(1)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Z(2)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Z(0)'. Consider using the GetDefaultMember6 helper method.
				TempRgn = CreateRectRgn(Z(1), Z(0), Z(2) + 1, Z(0) + 1) ' Create a temporary pixel region for this pixel
				CombineRgn(CurRgn, CurRgn, TempRgn, RGN_DIFF) ' Combine temp pixel region with base region using RGN_DIFF to extract the pixel and make it transparent
				DeleteObject((TempRgn)) ' Delete the temporary region and free resources
			Next
		End If
		
		If FileName <> Nothing And Load = False Then  'save the region data to a file
			SaveRegionDataToFile(FileName)
		End If
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName.hwnd'. Consider using the GetDefaultMember6 helper method.
		SetWindowRgn(objName.hwnd, CurRgn, True) ' Finally set the windows region to the final product
		'I do not use DeleteObject on the CurRgn, going with the advice in Dan Appleman's book
		'once set to a Window using SetWindowRgn, do not delete the region.
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objName.hwnd'. Consider using the GetDefaultMember6 helper method.
		ReleaseDC(objName.hwnd, lngHDC) 'release the DC.  Does not hurt the form even though you got its DC from VB.
		
		'final cleanup if a commandbutton
		If TypeOf objName Is VB6CommandButton Then 
			objName.Parent.ScaleMode = intStoreScaleMode 'set it back
		End If
		
		colPoints = Nothing
		
	End Sub
	
	Public Sub DragForm(ByRef hwnd As Integer, ByRef intButton As Short)
		
		On Error Resume Next 
		
		If intButton = VBRUN.MouseButtonConstants.vbLeftButton Then 
			'Move the borderless form...
			ReleaseCapture()
			SendMessage(hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0)
		End If
		
	End Sub

	Private Sub InitializeForFormOrPictureBox()
		'initialization for form or picturebox
		With objName
			.AutoRedraw = True 'object must have this setting
			.ScaleMode = 3 'object must have this setting
			.ClipControls = False 'supposedly improves drawing performance.  Haven't seen it but doesn't hurt.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.ScaleHeight'. Consider using the GetDefaultMember6 helper method.
			lngHeight = .ScaleHeight 'faster to use a variable
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.ScaleWidth'. Consider using the GetDefaultMember6 helper method.
			lngWidth = .ScaleWidth 'faster to use a variable
		End With
		
	End Sub

	Private Sub SaveRegionDataToFile(ByVal sPath As String)
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

	Private Sub LoadRegionDataFromFile(ByVal sFileName As String)
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
		CurRgn = ExtCreateRegion(0%, dwCount, b(0))
		
		Exit Sub
		
ErrorHandler:
		Dim lErr As Integer
		Dim sErr As String = ""
		lErr = Err.Number: sErr = Err.Description
		If iFile > 0 Then 
			FileClose6(iFile)
		End If
		Err.Raise(lErr, App6.EXEName & ".cDIBSectionRegion", sErr)
		Exit Sub
	End Sub

End Class

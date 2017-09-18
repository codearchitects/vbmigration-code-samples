' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class GIF

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'---------------------------------------------------------------------------------------
	' Module    : GIF
	' DateTime  : 9/11/2002 14:28
	' Author    : Arkadiy  Olovyannikov (ark@fesma.ru)
	' Revision: : By Joyprakash Saikia
	' Purpose   : Class to Convert BMP to GIF
	'             The Credit goes to Arkadiy (the Creator)
	'             I've made small changes to it .
	'             Description or Comments are added
	'---------------------------------------------------------------------------------------
	
	' Class for Saving VB StdPicture object (BMP) in GIF format
	'
	''GIF' and 'Graphics Interchange Format' are trademarks of Compuserve,
	' Inc., an H&R  Block Company.

	'============BITMAP STAFF========================
	Friend Structure RGBTRIPLE
		Implements IVB6FileGetPut
	
		Public rgbRed As Byte
		Public rgbGreen As Byte
		Public rgbBlue As Byte
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As RGBTRIPLE
			Try
				FileGet6(fileNumber, struct.rgbRed)
				FileGet6(fileNumber, struct.rgbGreen)
				FileGet6(fileNumber, struct.rgbBlue)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.rgbRed)
			FilePut6(fileNumber, Me.rgbGreen)
			FilePut6(fileNumber, Me.rgbBlue)
		End Sub
	
	#End Region
	
	End Structure

	Friend Structure RGBQUAD
	
		Public rgbBlue As Byte
		Public rgbGreen As Byte
		Public rgbRed As Byte
		Public rgbReserved As Byte
	End Structure

	Friend Structure BITMAPINFOHEADER
	 '40 bytes
		Public biSize As Integer
		Public biWidth As Integer
		Public biHeight As Integer
		Public biPlanes As Short
		Public biBitCount As Short
		Public biCompression As Integer
		Public biSizeImage As Integer
		Public biXPelsPerMeter As Integer
		Public biYPelsPerMeter As Integer
		Public biClrUsed As Integer
		Public biClrImportant As Integer
	End Structure

	Friend Structure BITMAPINFO256
	
		Public bmiHeader As GIF.BITMAPINFOHEADER
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=256)> _
		Public bmiColors() As GIF.RGBQUAD
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			ReDim bmiColors(255)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As BITMAPINFO256
			Dim copy As BITMAPINFO256 = Me
			copy.bmiColors = Me.bmiColors.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure

	Friend Structure BITMAP
	 '14 bytes
		Public bmType As Integer
		Public bmWidth As Integer
		Public bmHeight As Integer
		Public bmWidthBytes As Integer
		Public bmPlanes As Short
		Public bmBitsPixel As Short
		Public bmBits As Integer
	End Structure

	Private Const BI_RGB As Integer = 0&
	
	' IGNORED: Private Declare Function CreateDCAsNull Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, lpDeviceName As Any, lpOutput As Any, lpInitData As Any) As Long
	Private Declare Function CreateDCAsNull Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, ByVal lpDeviceName As Integer, ByVal lpOutput As Integer, ByVal lpInitData As Integer) As Integer
	Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hDc As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetObjectAPI' unamanged method with the following .NET member(s): System.Drawing.Bitmap , System.Drawing.Brush , System.Drawing.Font , System.Drawing.Pen 
	' IGNORED: Private Declare Function GetObjectAPI Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Long, ByVal nCount As Long, lpObject As Any) As Long
	Private Declare Function GetObjectAPI Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Integer, ByVal nCount As Integer, ByRef lpObject As GIF.BITMAP) As Integer
	Private Declare Function SelectObject Lib "gdi32" (ByVal hDc As Integer, ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'BitBlt' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawImage
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
	Private Declare Function DeleteDC Lib "gdi32" (ByVal hDc As Integer) As Integer
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDIBits' unamanged method with the following .NET member(s): System.Drawing.Bitmap.LockBits
	' IGNORED: Private Declare Function GetDIBits Lib "gdi32" (ByVal aHDC As Long, ByVal hBitmap As Long, ByVal nStartScan As Long, ByVal nNumScans As Long, lpBits As Any, lpBI As BITMAPINFO256, ByVal wUsage As Long) As Long
	Private Declare Function GetDIBits Lib "gdi32" (ByVal aHDC As Integer, ByVal hBitmap As Integer, ByVal nStartScan As Integer, ByVal nNumScans As Integer, ByRef lpBits As Byte, ByRef lpBI As GIF.BITMAPINFO256, ByVal wUsage As Integer) As Integer
	Private Declare Function CreateDIBSection256 Lib "gdi32" Alias "CreateDIBSection" (ByVal hDc As Integer, ByRef pBitmapInfo As GIF.BITMAPINFO256, ByVal un As Integer, ByRef lplpVoid As Integer, ByVal handle As Integer, ByVal dw As Integer) As Integer
	Private Const DIB_RGB_COLORS As Short = 0
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetFileAttributes' unamanged method with the following .NET member(s): System.IO.Directory.GetAttributes, System.IO.File.GetAttributes, System.IO.FileSystemInfo.Attributes
	Private Declare Function GetFileAttributes Lib "kernel32" Alias "GetFileAttributesA" (ByVal lpFileName As String) As Integer
	'============================GIF STAFF================
	
	Friend Structure GifScreenDescriptor
		Implements IVB6FileGetPut
	
		Public logical_screen_width As Short
		Public logical_screen_height As Short
		Public Flags As Byte
		Public background_color_index As Byte
		Public pixel_aspect_ratio As Byte
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As GifScreenDescriptor
			Try
				FileGet6(fileNumber, struct.logical_screen_width)
				FileGet6(fileNumber, struct.logical_screen_height)
				FileGet6(fileNumber, struct.Flags)
				FileGet6(fileNumber, struct.background_color_index)
				FileGet6(fileNumber, struct.pixel_aspect_ratio)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.logical_screen_width)
			FilePut6(fileNumber, Me.logical_screen_height)
			FilePut6(fileNumber, Me.Flags)
			FilePut6(fileNumber, Me.background_color_index)
			FilePut6(fileNumber, Me.pixel_aspect_ratio)
		End Sub
	
	#End Region
	
	End Structure

	Friend Structure GifImageDescriptor
		Implements IVB6FileGetPut
	
		Public Left As Short
		Public Top As Short
		Public Width As Short
		Public Height As Short
		Public Format As Byte 'ImageFormat
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As GifImageDescriptor
			Try
				FileGet6(fileNumber, struct.Left)
				FileGet6(fileNumber, struct.Top)
				FileGet6(fileNumber, struct.Width)
				FileGet6(fileNumber, struct.Height)
				FileGet6(fileNumber, struct.Format)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.Left)
			FilePut6(fileNumber, Me.Top)
			FilePut6(fileNumber, Me.Width)
			FilePut6(fileNumber, Me.Height)
			FilePut6(fileNumber, Me.Format)
		End Sub
	
	#End Region
	
	End Structure
	
	'========Added by Wolfgang Goetz for transparent GIFs=====
	Friend Structure CONTROLBLOCK
		Implements IVB6FileGetPut
	 '(April 8., 2002 --> Wolfgang Goetz)
		Public Blocksize As Byte
		Public Flags As Byte
		Public Delay As Short
		Public TransParent_Color As Byte
		Public Terminator As Byte
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As CONTROLBLOCK
			Try
				FileGet6(fileNumber, struct.Blocksize)
				FileGet6(fileNumber, struct.Flags)
				FileGet6(fileNumber, struct.Delay)
				FileGet6(fileNumber, struct.TransParent_Color)
				FileGet6(fileNumber, struct.Terminator)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.Blocksize)
			FilePut6(fileNumber, Me.Flags)
			FilePut6(fileNumber, Me.Delay)
			FilePut6(fileNumber, Me.TransParent_Color)
			FilePut6(fileNumber, Me.Terminator)
		End Sub
	
	#End Region
	
	End Structure
	
	Private Const GIF89a As String = "GIF89a"
	Private Const CtrlIntro As Byte = &H21
	Private Const CtrlLabel As Byte = &HF9
	'========================================================
	Private Const GIF87a As String = "GIF87a"
	
	Private Const GifTerminator As Byte = &H3B
	Private Const ImageSeparator As Byte = &H2C
	Private Const CHAR_BIT As Short = 8
	Private Const CodeSize As Byte = 9
	Private Const ClearCode As Short = 256
	Private Const EndCode As Short = 257
	Private Const FirstCode As Short = 258
	Private Const LastCode As Short = 511
	Private Const MAX_CODE As Short = LastCode - FirstCode
	
	Private colTable As New Collection
	Private fn As Short
	Private gifPalette(255) As GIF.RGBTRIPLE
	Private bit_position As Short
	Private code_count As Short
	Private data_buffer(255) As Byte
	Private aPower2(31) As Integer
	Private picWidth As Integer
	Private picHeight As Integer
	Private IsBusy As Boolean
	Public Event Progress(ByVal Percents As Short)
	
	Public Function SaveGIF(ByVal pic As Image, ByVal sFileName As String, Optional ByVal hDc As Integer = 0, Optional ByVal UseTrans As Boolean = False, Optional ByVal TransColor As Integer = 0) As Boolean
		'---------------------------------------------------------------------------------------
		' Procedure : SaveGIF
		' Purpose   : Main Entry point of the Class
		' Arguments
		'                UseTrans --> Used to to Save the GIF as Transperent (default is False)
		'                TransColor-> This RGB value is used while 'UseTrans' is set to true,
		'                             i.e., the Transperent Color of a transperent Gif
		'---------------------------------------------------------------------------------------
		'
		
		If IsBusy Then  Exit Function 'it is needed In Case of Do Events is used
		Dim scr As GIF.GifScreenDescriptor
		Dim im As GIF.GifImageDescriptor
		Dim bi As New GIF.BITMAPINFO256(True)
		Dim bm As GIF.BITMAP
		Dim hDCScn As Integer
		Dim OldObj As Integer
		Dim Src_hDc As Integer
		Dim hDib256 As Integer
		Dim hDC256 As Integer
		Dim OldObj256 As Integer
		Dim buf(,) As Byte
		Dim data As Byte
		Dim TransIndex As Byte
		Dim i As Integer
		Dim j As Integer
		Dim clr As Integer
		Dim bFound As Boolean
		Dim intCode As Short
		Dim nCount As Short
		Dim sPrefix As String = ""
		Dim [sByte] As String = ""
		' UPGRADE_INFO (#0501): The 'tempPic' member isn't used anywhere in current application.
		Dim tempPic As Image = Nothing
		IsBusy = True
		'get image size and allocate buffer memory
		Call GetObjectAPI(GetPictureHandle6(pic), Len6(bm), bm)
		picWidth = bm.bmWidth
		picHeight = bm.bmHeight
		ReDim buf(CInt(((picWidth + 3) \ 4) * 4), picHeight)
		'Prepare DC for paintings
		hDCScn = CreateDCAsNull("DISPLAY", 0%, 0%, 0%)
		hDC256 = CreateCompatibleDC(hDCScn)
		If hDc = 0 Then 
			Src_hDc = CreateCompatibleDC(hDCScn)
			OldObj = SelectObject(Src_hDc, GetPictureHandle6(pic))
		Else
			Src_hDc = hDc
		End If
		DeleteDC(hDCScn)
		
		'Since GIF works only with 256 colors, reduce color depth to 256
		'This sample use simpliest HalfTone palette to reduce color depth
		'If you want advanced color manipulation with web-safe palettes or
		'optimal palette with the specified number of colors using octree
		'quantisation, visit http://vbaccelerator.com/codelib/gfx/octree.htm
		
		If bm.bmBitsPixel <> 8 Then  hDib256 = CreateDib256(hDC256, bi) 'Create DC with 256
		If hDib256 <> 0 Then 
			OldObj256 = SelectObject(hDC256, hDib256)
			Call BitBlt(hDC256, 0, 0, picWidth, picHeight, Src_hDc, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
			For i = 0 To picHeight - 1
				Call GetDIBits(hDC256, hDib256, i, 1, buf(0, picHeight - i), bi, 0)
			Next
		Else
			'Put the Header of the File
			With bi.bmiHeader
				.biSize = Len6(bi.bmiHeader)
				.biWidth = picWidth
				.biHeight = picHeight
				.biPlanes = 1
				.biBitCount = 8
				.biCompression = BI_RGB
			End With
			For i = 0 To picHeight - 1
				Call GetDIBits(Src_hDc, GetPictureHandle6(pic), i, 1, buf(0, picHeight - i), bi, 0)
			Next
		End If
		'Fill gif file info
		For i = 0 To 255 'RGB Patterns
			gifPalette(i).rgbBlue = bi.bmiColors(i).rgbBlue
			gifPalette(i).rgbGreen = bi.bmiColors(i).rgbGreen
			gifPalette(i).rgbRed = bi.bmiColors(i).rgbRed
			If Not bFound Then 
				clr = RGB(gifPalette(i).rgbRed, gifPalette(i).rgbGreen, gifPalette(i).rgbBlue)
				If clr = TransColor Then 
					TransIndex = i: bFound = True
				End If
			End If
		Next
		
		scr.background_color_index = 0
		scr.Flags = &HF7 '256-color gif with global color map
		scr.pixel_aspect_ratio = 0
		
		im.Format = &H7 'GlobalNonInterlaced
		im.Height = picHeight
		im.Width = picWidth
		' If the File Exists then Automatically Overwrite
		If FileExists(sFileName) Then  Kill(sFileName)
		
		fn = FreeFile6()
		FileOpen6(fn, sFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1)
		'Write GIF header and header info
		If UseTrans = True Then 
			FilePut6(fn, GIF89a)
		Else
			FilePut6(fn, GIF87a)
		End If
		FilePut6(fn, scr)
		FilePut6(fn, gifPalette)
		'(April 8., 2002 --> Wolfgang Goetz)
		Dim cb As GIF.CONTROLBLOCK
		If UseTrans = True Then 
			FilePut6(fn, CtrlIntro)
			FilePut6(fn, CtrlLabel)
			cb.Blocksize = 4 'Always 4
			cb.Flags = 9 'Packed = 00001001 (If Bit 0 = 1: Use Transparency)
			cb.Delay = 0
			cb.TransParent_Color = TransIndex
			cb.Terminator = 0 'Always 0
			FilePut6(fn, cb)
		End If
		FilePut6(fn, ImageSeparator)
		FilePut6(fn, im)
		data = CodeSize - 1
		FilePut6(fn, data)
		data_buffer(0) = 0
		bit_position = CHAR_BIT
		'Process pixels data using LZW/GIF compression
		For i = 1 To picHeight
			Reinitialize()
			sPrefix = ""
			intCode = buf(0, i)
			On Error Resume Next 
			For j = 1 To picWidth - 1
				[sByte] = MyFormat(buf(j, i))
				' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'sPrefix' variable as a StringBuilder6 object.
				sPrefix &= [sByte]
				intCode = colTable.Item(sPrefix)
				If Err.Number <> 0 Then  'Prefix wasn't in collection - save it and output code
					nCount = colTable.Count()
					If nCount = MAX_CODE Then  Reinitialize()
					colTable.Add(nCount + FirstCode, sPrefix)
					OutputBits(intCode, CodeSize)
					sPrefix = [sByte]
					intCode = buf(j, i)
					Err.Clear()
				End If
			Next
			OutputBits(intCode, CodeSize)
			If i Mod 10 = 0 Then 
				RaiseEvent Progress(i * 100 / picHeight)
				DoEvents6()
			End If
		Next
		
		OutputCode((EndCode))
		For i = 0 To data_buffer(0)
			FilePut6(fn, data_buffer(i))
		Next
		data = 0
		FilePut6(fn, data)
		FilePut6(fn, GifTerminator)
		FileClose6(fn)
		Erase6(buf)
		If hDc = 0 Then 
			SelectObject(Src_hDc, OldObj)
			DeleteDC(Src_hDc)
		End If
		SelectObject(hDC256, OldObj256)
		DeleteObject(hDib256)
		DeleteDC(hDC256)
		SaveGIF = True
		IsBusy = False
	End Function

	Private Sub OutputBits(ByVal Value As Short, ByVal count As Short)
		'---------------------------------------------------------------------------------------
		' Procedure : OutputBits
		' Purpose   :  Put the Output Bit after Compression to DATABUFFER
		'---------------------------------------------------------------------------------------
		'
		
		Dim i As Short
		Dim bit As Short
		Do While i < count
			If bit_position = CHAR_BIT Then 
				If data_buffer(0) = 255 Then 
					FilePut6(fn, data_buffer)
					data_buffer(0) = 1
				Else
					data_buffer(0) += 1
				End If
				data_buffer(data_buffer(0)) = 0
				bit_position = 0
			End If
			bit = Math.Sign(Power2(i) And Value)
			If bit > 0 Then  data_buffer(data_buffer(0)) = Power2(bit_position) Or data_buffer(data_buffer(0))
			i += 1: bit_position += 1
		Loop
	End Sub

	Private Sub OutputCode(ByVal code As Short)
		'---------------------------------------------------------------------------------------
		' Procedure : OutputCode
		' Purpose   : To Create Output for Clear Code beyond 256
		'---------------------------------------------------------------------------------------
		'
		
		code_count += 1
		If code_count > LastCode Then 
			code_count = FirstCode
			Call OutputBits(ClearCode, CodeSize)
			ClearTable() 'Erase and recreate the Color Table
		End If
		Call OutputBits(code, CodeSize)
	End Sub

	Private Sub ClearTable()
		colTable = Nothing
		colTable = New Collection()
	End Sub

	Private Sub Reinitialize()
		ClearTable()
		Call OutputBits(ClearCode, CodeSize)
	End Sub

	Private Function FileExists(ByVal strPathName As String) As Boolean
		Dim af As Integer = GetFileAttributes(strPathName)
		Return (af <> -1)
	End Function

	Private Function Power2(ByVal i As Short) As Integer
		If aPower2(0) = 0 Then 
			aPower2(0) = &H1%
			aPower2(1) = &H2%
			aPower2(2) = &H4%
			aPower2(3) = &H8%
			aPower2(4) = &H10%
			aPower2(5) = &H20%
			aPower2(6) = &H40%
			aPower2(7) = &H80%
			aPower2(8) = &H100%
			aPower2(9) = &H200%
			aPower2(10) = &H400%
			aPower2(11) = &H800%
			aPower2(12) = &H1000%
			aPower2(13) = &H2000%
			aPower2(14) = &H4000%
			aPower2(15) = &H8000%
			aPower2(16) = &H10000
			aPower2(17) = &H20000
			aPower2(18) = &H40000
			aPower2(19) = &H80000
			aPower2(20) = &H100000
			aPower2(21) = &H200000
			aPower2(22) = &H400000
			aPower2(23) = &H800000
			aPower2(24) = &H1000000
			aPower2(25) = &H2000000
			aPower2(26) = &H4000000
			aPower2(27) = &H8000000
			aPower2(28) = &H10000000
			aPower2(29) = &H20000000
			aPower2(30) = &H40000000
			aPower2(31) = &H80000000
		End If
		Return aPower2(i)
	End Function

	Private Function MyFormat(ByVal s As String) As String
		Return VB.Right("00" & s, 3)
	End Function

	Private Function CreateDib256(ByVal h_Dc As Integer, ByRef bi As GIF.BITMAPINFO256) As Integer
		'---------------------------------------------------------------------------------------
		' Procedure : CreateDib256
		' Purpose   :creates a DIB that applications can write to directly.
		'             Here it is restricted to 256 color
		'            The function gives you a pointer to the location of the bitmap bit
		'            values.
		'---------------------------------------------------------------------------------------
		'
		
		Dim lScanSize As Integer
		Dim lptr As Integer
		Dim lIndex As Integer
		Dim r As Integer
		Dim g As Integer
		Dim b As Integer
		Dim rA As Integer
		Dim gA As Integer
		Dim bA As Integer
		With bi.bmiHeader
			.biSize = Len6(bi.bmiHeader)
			.biWidth = picWidth
			.biHeight = picHeight
			.biPlanes = 1
			.biBitCount = 8
			.biCompression = BI_RGB
			lScanSize = (picWidth + picWidth Mod 4)
			.biSizeImage = lScanSize * picHeight
		End With
		' Halftone 256 colour palette
		For b = 0 To &H100 Step &H40
			If b = &H100 Then 
				bA = b - 1
			Else
				bA = b
			End If
			For g = 0 To &H100 Step &H40
				If g = &H100 Then 
					gA = g - 1
				Else
					gA = g
				End If
				For r = 0 To &H100 Step &H40
					If r = &H100 Then 
						rA = r - 1
					Else
						rA = r
					End If
					With bi.bmiColors(lIndex)
						.rgbRed = rA: .rgbGreen = gA: .rgbBlue = bA
					End With
					lIndex += 1
				Next
			Next
		Next
		Return CreateDIBSection256(h_Dc, bi, DIB_RGB_COLORS, lptr, 0, 0)
	End Function

End Class

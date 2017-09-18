' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Public Enum RenderType 'Render tipi
	Dot 'Nokta
	Dothidden 'Görünen yüzeylerin noktalarý
	Wireframe 'Tel kafes
	Hidden 'Görünen yüzeyler kullanýlýyor
	Solid 'Katý model
	SolidFrame 'Katý model ile wireframe birlikte
End Enum

Friend Module modRender

	'CreatePen(nPenStyle)
	Private Const PS_SOLID As Short = 0
	'  _______
	' UPGRADE_INFO (#0501): The 'PS_DASH' member isn't used anywhere in current application.
	Private Const PS_DASH As Short = 1
	'  -------
	' UPGRADE_INFO (#0501): The 'PS_DOT' member isn't used anywhere in current application.
	Private Const PS_DOT As Short = 2
	'  .......
	' UPGRADE_INFO (#0501): The 'PS_DASHDOT' member isn't used anywhere in current application.
	Private Const PS_DASHDOT As Short = 3
	'  _._._._
	' UPGRADE_INFO (#0501): The 'PS_DASHDOTDOT' member isn't used anywhere in current application.
	Private Const PS_DASHDOTDOT As Short = 4
	'  _.._.._
	' UPGRADE_INFO (#0501): The 'PS_NULL' member isn't used anywhere in current application.
	Private Const PS_NULL As Short = 5
	' UPGRADE_INFO (#0501): The 'PS_INSIDEFRAME' member isn't used anywhere in current application.
	Private Const PS_INSIDEFRAME As Short = 6

	Friend Structure RenderOption
	
		Public RType As RenderType
		Public tColor As ColorRGB
		Public Luminance As Short
		Public Hidden As Boolean
		Public Shade As Boolean
		Public LightOrbit As Boolean
		Public Show As Boolean
		Public ShowIndex As Short
	End Structure

	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.FromHwnd(Windows.Forms.Control.Handle), System.Drawing.Printing.PrintPageEventArgs.Graphics, System.Windows.Forms.PaintEventArgs.Graphics, System.Drawing.Graphics.GetHdc
	' UPGRADE_INFO (#0501): The 'GetDC' member isn't used anywhere in current application.
	Private Declare Function GetDC Lib "user32" (ByVal hwnd As Integer) As Integer
	Private Declare Function CreateCompatibleBitmap Lib "gdi32" (ByVal hdc As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
	Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hdc As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.ReleaseHdc
	' UPGRADE_INFO (#0501): The 'ReleaseDC' member isn't used anywhere in current application.
	Private Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Integer, ByVal hdc As Integer) As Integer
	Private Declare Function DeleteDC Lib "gdi32" (ByVal hdc As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'BitBlt' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawImage
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetBkColor' unamanged method with the following .NET member(s): System.Windows.Forms.Form.BackColor
	' UPGRADE_INFO (#0501): The 'SetBkColor' member isn't used anywhere in current application.
	Private Declare Function SetBkColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreatePen' unamanged method with the following .NET member(s): System.Drawing.Pen constructor
	Private Declare Function CreatePen Lib "gdi32" (ByVal nPenStyle As Integer, ByVal nWidth As Integer, ByVal crColor As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreateSolidBrush' unamanged method with the following .NET member(s): System.Drawing.SolidBrush constructor
	Private Declare Function CreateSolidBrush Lib "gdi32" (ByVal crColor As Integer) As Integer
	Private Declare Function SelectObject Lib "gdi32" (ByVal hdc As Integer, ByVal hObject As Integer) As Integer
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'Polygon' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawPolygon, System.Drawing.Graphics.FillPolygon
	Private Declare Function Polygon Lib "gdi32" (ByVal hdc As Integer, ByRef lpPoint As POINTAPI, ByVal nCount As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetPixel' unamanged method with the following .NET member(s): System.Drawing.Bitmap.SetPixel
	Private Declare Function SetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal crColor As Integer) As Integer
	Private Declare Function MoveToEx Lib "gdi32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer, ByRef lpPoint As POINTAPI) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'LineTo' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawLine
	Private Declare Function LineTo Lib "gdi32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
	
	'Private Declare Function SetPolyFillMode Lib "gdi32" (ByVal hdc As Long, ByVal nPolyFillMode As Long) As Long
	'Private Declare Function Rectangle Lib "gdi32" (ByVal hdc As Long, ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
	
	Public BackBuffer As Integer
	Public BackBitmap As Integer
	Public oldBackBitmap As Integer
	
	Public RO As RenderOption
	Public HalfWidth As Integer
	Public HalfHeight As Integer
	
	'Public MyViewWidth As Single
	'Public MyViewHeight As Single
	
	Public Sub InitializeDC(ByVal Canvas As VB6PictureBox)
		
		With Canvas
			.ScaleMode = 3
			.AutoRedraw = False
			.Visible = True
			.FillStyle = VBRUN.DrawStyleConstants.vbSolid 'vbTransparent '
			' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
			.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
			.DrawStyle = VBRUN.DrawStyleConstants.vbSolid
			'        MyViewWidth = .ScaleWidth
			'        MyViewHeight = .ScaleHeight
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			BackBuffer = CreateCompatibleDC(.hDC)
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			BackBitmap = CreateCompatibleBitmap(.hDC, .ScaleWidth, .ScaleHeight)
			'        BackBitmap = CreateCompatibleBitmap(.hdc, MyViewWidth, MyViewHeight)
			
			oldBackBitmap = SelectObject(BackBuffer, BackBitmap)
		End With
		
	End Sub

	Public Sub TerminateDC()
		
		DeleteDC(BackBuffer)
		DeleteObject(BackBitmap)
		
	End Sub

	'------------------------------------------------
	'Sub: Render
	'RType(Render tipine) göre görüntü oluþturuluyor.
	'------------------------------------------------
	
	Public Sub Render(ByVal Canvas As VB6PictureBox)
		
		Dim i As Short
		Dim iV As Short
		
		DoEvents6()
		'    SetPolyFillMode BackBuffer, 2
		With ObjPart
			If RO.Hidden Then 
				If ShortVisibleFaces() > -1 Then 
					For i = 0 To UBound6(.FaceV)
						iV = .FaceV(i).iVisible
						Call Draw(iV, Canvas)
					Next
				End If
			Else
				For i = 0 To .NumFaces
					Call Draw(i, Canvas)
				Next
			End If
		End With
		
		' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
		BitBlt(Canvas.hDC, 0, 0, Canvas.ScaleWidth, Canvas.ScaleHeight, BackBuffer, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
		BitBlt(BackBuffer, 0, 0, Canvas.ScaleWidth, Canvas.ScaleHeight, BackBuffer, 0, 0, VBRUN.DrawModeConstants.vbBlackness)
		
	End Sub

	'------------------------------------------------
	'Sub:Draw
	'i(index) ile belirlenen yüzey rt ye göre çizdiriliyor.
	'------------------------------------------------
	
	Private Sub Draw(ByVal i As Short, ByVal Canvas As VB6PictureBox)
		
		Dim idx As Short
		Dim tmp(2) As POINTAPI
		' UPGRADE_INFO (#0501): The 'Result' member isn't used anywhere in current application.
		Dim Result As Integer
		Dim L As Single
		Dim PartColor As ColorRGB
		Dim lngColor As Integer
		
		Dim BrushSelect As Integer
		Dim PenSelect As Integer
		
		If RO.Shade Then 
			L = VectorDot(ObjPart.NormalT(i), LightT)
			If L < 0 Then  L = 0
			PartColor = ColorScale(RO.tColor, L)
		Else
			PartColor = RO.tColor
		End If
		
		If i = RO.ShowIndex And RO.Show Then  PartColor = ColorInvert(PartColor)
		lngColor = ColorRGBToLong(ColorPlus(PartColor, RO.Luminance))
		
		With ObjPart
			tmp(0) = .ScreenCoord(.Faces(i).A)
			tmp(1) = .ScreenCoord(.Faces(i).B)
			tmp(2) = .ScreenCoord(.Faces(i).C)
		End With
		
		Select Case RO.RType
		Case RenderType.Wireframe
			PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
			DrawTriangle(BackBuffer, tmp)
		Case RenderType.Hidden
			PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
			BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(0)) 'Canvas.BackColor))
			Polygon(BackBuffer, tmp(0), 3)
		Case RenderType.Solid
			PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
			BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(lngColor))
			Polygon(BackBuffer, tmp(0), 3)
		Case RenderType.SolidFrame
			DeleteObject(SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, 0))) 'Canvas.BackColor))
			BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(lngColor))
			Polygon(BackBuffer, tmp(0), 3)
		Case RenderType.Dot, RenderType.Dothidden
			For idx = 0 To 2
				Call SetPixel(BackBuffer, tmp(idx).X, tmp(idx).Y, lngColor)
			Next
		End Select
		
		DeleteObject(PenSelect)
		DeleteObject(BrushSelect)
		
	End Sub

	Private Sub DrawTriangle(ByVal hdc As Integer, ByRef tmp() As POINTAPI)
		
		Dim p As POINTAPI
		
		MoveToEx(hdc, tmp(0).X, tmp(0).Y, p)
		LineTo(hdc, tmp(1).X, tmp(1).Y)
		LineTo(hdc, tmp(2).X, tmp(2).Y)
		LineTo(hdc, tmp(0).X, tmp(0).Y)
		
	End Sub

	Private Function ShortVisibleFaces() As Short
		
		Dim IsVisible As Boolean
		Dim i As Short
		Dim iV As Short = -1
		
		With ObjPart
			Erase6(.FaceV)
			For i = 0 To .NumFaces
				IsVisible = IIf(VectorDot(ObjPart.NormalT(i), Camera) > 0, True, False)
				If IsVisible Then 
					iV += 1
					ReDim Preserve .FaceV(iV)
					.FaceV(iV).ZValue = (.VerticesT(.Faces(i).A).Z + .VerticesT(.Faces(i).B).Z + .VerticesT(.Faces(i).C).Z) '/ 3
					.FaceV(iV).iVisible = i
				End If
			Next
			If iV > -1 Then  Call SortFaces(.FaceV, 0, iV)
			ShortVisibleFaces = iV
		End With
		
	End Function

	'-----------------------------------------------
	'Sub: ShortFaces
	'Bu standart sýralama algoritmasý.
	'Küçükten büyüðe doðru sýralýyor.
	'Aslýnda nasýl yaptýðýný fazla anlamadým.
	'Matematik projelerinden birinde buldum.Daha hýzlý çalýþaný varsa deðiþtirebilirim.
	'------------------------------------------------
	
	Private Sub SortFaces(ByRef zOrder() As Order, ByVal First As Integer, ByVal Last As Integer)
		
		Dim FirstIdx As Integer
		Dim MidIdx As Integer
		Dim LastIdx As Integer
		Dim MidVal As Single
		Dim TempOrder As Order
		
		If (First < Last) Then 
			With ObjPart
				MidIdx = (First + Last) \ 2
				MidVal = .FaceV(MidIdx).ZValue
				FirstIdx = First
				LastIdx = Last
				Do
					Do While .FaceV(FirstIdx).ZValue < MidVal
						FirstIdx += 1
					Loop
					Do While .FaceV(LastIdx).ZValue > MidVal
						LastIdx -= 1
					Loop
					If (FirstIdx <= LastIdx) Then 
						TempOrder = .FaceV(LastIdx)
						zOrder(LastIdx) = .FaceV(FirstIdx)
						zOrder(FirstIdx) = TempOrder
						FirstIdx += 1
						LastIdx -= 1
					End If
				Loop Until FirstIdx > LastIdx
				
				If (LastIdx <= MidIdx) Then 
					Call SortFaces(.FaceV, First, LastIdx)
					Call SortFaces(.FaceV, FirstIdx, Last)
				Else
					Call SortFaces(.FaceV, FirstIdx, Last)
					Call SortFaces(.FaceV, First, LastIdx)
				End If
			End With
		End If
		
	End Sub

	'Private Sub ShortFaces()
	'
	'    Dim TempDrawOrder() As Long
	'    Dim TempArray() As Long
	'
	'    ReDim TempDrawOrder(4)
	'    ReDim TempArray(4)
	'
	'    TempDrawOrder(0) = ShapeA.PosZ
	'    TempDrawOrder(1) = ShapeB.PosZ
	'    TempDrawOrder(2) = ShapeC.PosZ
	'    TempDrawOrder(3) = ShapeD.PosZ
	'    TempDrawOrder(4) = ShapeE.PosZ
	'    For Aa = 0 To 4
	'        TempArray(Aa) = Aa '-- reset this variable with incrementing numbers
	'    Next Aa
	'    For Aa = 0 To 3
	'        If TempDrawOrder(Aa) > TempDrawOrder(Aa + 1) Then
	'            '--Swaping Variables manually since there is no such function that I know of in VB
	'            Ab = TempArray(Aa)
	'            TempArray(Aa) = TempArray(Aa + 1)
	'            TempArray(Aa + 1) = Ab
	'
	'            Ab = TempDrawOrder(Aa)
	'            TempDrawOrder(Aa) = TempDrawOrder(Aa + 1)
	'            TempDrawOrder(Aa + 1) = Ab
	'            Aa = Aa - 2
	'            If Aa < -1 Then Aa = -1
	'            'If Aa < -10 Then Debug.Print Error
	'        End If
	'    Next Aa
	'End Sub

End Module

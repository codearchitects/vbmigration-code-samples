Attribute VB_Name = "modRender"
Option Explicit

Public Enum RenderType      'Render tipi
    Dot                     'Nokta
    Dothidden               'Görünen yüzeylerin noktalarý
    Wireframe               'Tel kafes
    Hidden                  'Görünen yüzeyler kullanýlýyor
    Solid                   'Katý model
    SolidFrame              'Katý model ile wireframe birlikte
End Enum

'CreatePen(nPenStyle)
Private Const PS_SOLID = 0                   '  _______
Private Const PS_DASH = 1                    '  -------
Private Const PS_DOT = 2                     '  .......
Private Const PS_DASHDOT = 3                 '  _._._._
Private Const PS_DASHDOTDOT = 4              '  _.._.._
Private Const PS_NULL = 5
Private Const PS_INSIDEFRAME = 6



Public Type RenderOption
    RType As RenderType
    tColor As ColorRGB
    Luminance As Integer
    Hidden As Boolean
    Shade As Boolean
    LightOrbit As Boolean
    Show As Boolean
    ShowIndex As Integer
End Type

Private Declare Function GetDC Lib "user32" (ByVal hwnd As Long) As Long
Private Declare Function CreateCompatibleBitmap Lib "gdi32" (ByVal hdc As Long, ByVal nWidth As Long, ByVal nHeight As Long) As Long
Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hdc As Long) As Long
Private Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Long, ByVal hdc As Long) As Long
Private Declare Function DeleteDC Lib "gdi32" (ByVal hdc As Long) As Long
Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hSrcDC As Long, ByVal xSrc As Long, ByVal ySrc As Long, ByVal dwRop As Long) As Long
Private Declare Function SetBkColor Lib "gdi32" (ByVal hdc As Long, ByVal crColor As Long) As Long
Private Declare Function CreatePen Lib "gdi32" (ByVal nPenStyle As Long, ByVal nWidth As Long, ByVal crColor As Long) As Long
Private Declare Function CreateSolidBrush Lib "gdi32" (ByVal crColor As Long) As Long
Private Declare Function SelectObject Lib "gdi32" (ByVal hdc As Long, ByVal hObject As Long) As Long
Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Long) As Long
Private Declare Function Polygon Lib "gdi32" (ByVal hdc As Long, lpPoint As POINTAPI, ByVal nCount As Long) As Long
Private Declare Function SetPixel Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long, ByVal crColor As Long) As Long
Private Declare Function MoveToEx Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long, lpPoint As POINTAPI) As Long
Private Declare Function LineTo Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long) As Long

'Private Declare Function SetPolyFillMode Lib "gdi32" (ByVal hdc As Long, ByVal nPolyFillMode As Long) As Long
'Private Declare Function Rectangle Lib "gdi32" (ByVal hdc As Long, ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long

Public BackBuffer As Long
Public BackBitmap As Long
Public oldBackBitmap As Long

Public RO As RenderOption
Public HalfWidth As Long
Public HalfHeight As Long

'Public MyViewWidth As Single
'Public MyViewHeight As Single

Public Sub InitializeDC(Canvas As PictureBox)

    With Canvas
        .ScaleMode = 3
        .AutoRedraw = False
        .Visible = True
        .FillStyle = vbSolid  'vbTransparent '
        .DrawMode = vbCopyPen
        .DrawStyle = vbSolid
'        MyViewWidth = .ScaleWidth
'        MyViewHeight = .ScaleHeight
        BackBuffer = CreateCompatibleDC(.hdc)
        BackBitmap = CreateCompatibleBitmap(.hdc, .ScaleWidth, .ScaleHeight)
'        BackBitmap = CreateCompatibleBitmap(.hdc, MyViewWidth, MyViewHeight)

        oldBackBitmap = SelectObject(BackBuffer, BackBitmap)
    End With

End Sub

Public Sub TerminateDC()
    
    DeleteDC BackBuffer
    DeleteObject BackBitmap

End Sub

'------------------------------------------------
'Sub: Render
'RType(Render tipine) göre görüntü oluþturuluyor.
'------------------------------------------------

Public Sub Render(Canvas As PictureBox)

    Dim i As Integer, iV As Integer
    
    DoEvents
'    SetPolyFillMode BackBuffer, 2
    With ObjPart
        If RO.Hidden Then
            If ShortVisibleFaces > -1 Then
                For i = 0 To UBound(.FaceV)
                    iV = .FaceV(i).iVisible
                    Call Draw(iV, Canvas)
                Next
            End If
        Else
            For i = 0 To .NumFaces
                Call Draw(i, Canvas)
            Next i
        End If
    End With
    
    BitBlt Canvas.hdc, 0, 0, Canvas.ScaleWidth, Canvas.ScaleHeight, BackBuffer, 0, 0, vbSrcCopy
    BitBlt BackBuffer, 0, 0, Canvas.ScaleWidth, Canvas.ScaleHeight, BackBuffer, 0, 0, vbBlackness
    
End Sub

'------------------------------------------------
'Sub:Draw
'i(index) ile belirlenen yüzey rt ye göre çizdiriliyor.
'------------------------------------------------

Private Sub Draw(i As Integer, Canvas As PictureBox)
    
    Dim idx As Integer
    Dim tmp(2) As POINTAPI
    Dim Result As Long
    Dim L As Single
    Dim PartColor As ColorRGB
    Dim lngColor As Long
    
    Dim BrushSelect As Long
    Dim PenSelect As Long
    
    If RO.Shade Then
        L = VectorDot(ObjPart.NormalT(i), LightT)
        If L < 0 Then L = 0
        PartColor = ColorScale(RO.tColor, L)
    Else
        PartColor = RO.tColor
    End If
    
    If i = RO.ShowIndex And RO.Show Then PartColor = ColorInvert(PartColor)
    lngColor = ColorRGBToLong(ColorPlus(PartColor, RO.Luminance))
    
    With ObjPart
        tmp(0) = .ScreenCoord(.Faces(i).A)
        tmp(1) = .ScreenCoord(.Faces(i).B)
        tmp(2) = .ScreenCoord(.Faces(i).C)
    End With
      
    Select Case RO.RType
        Case Wireframe
            PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
            DrawTriangle BackBuffer, tmp
        Case Hidden
            PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
            BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(0)) 'Canvas.BackColor))
            Polygon BackBuffer, tmp(0), 3
        Case Solid
            PenSelect = SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, lngColor))
            BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(lngColor))
            Polygon BackBuffer, tmp(0), 3
        Case SolidFrame
            DeleteObject SelectObject(BackBuffer, CreatePen(PS_SOLID, 1, 0)) 'Canvas.BackColor))
            BrushSelect = SelectObject(BackBuffer, CreateSolidBrush(lngColor))
            Polygon BackBuffer, tmp(0), 3
        Case Dot, Dothidden
            For idx = 0 To 2
                Call SetPixel(BackBuffer, tmp(idx).X, tmp(idx).Y, lngColor)
            Next
    End Select
    
    DeleteObject PenSelect
    DeleteObject BrushSelect
    
End Sub

Private Sub DrawTriangle(hdc As Long, tmp() As POINTAPI)

    Dim p As POINTAPI
    
    MoveToEx hdc, tmp(0).X, tmp(0).Y, p
    LineTo hdc, tmp(1).X, tmp(1).Y
    LineTo hdc, tmp(2).X, tmp(2).Y
    LineTo hdc, tmp(0).X, tmp(0).Y

End Sub

Private Function ShortVisibleFaces() As Integer
    
    Dim IsVisible As Boolean
    Dim i As Integer
    Dim iV As Integer

    With ObjPart
        iV = -1
        Erase .FaceV
        For i = 0 To .NumFaces
            IsVisible = IIf(VectorDot(ObjPart.NormalT(i), Camera) > 0, True, False)
            If IsVisible Then
                iV = iV + 1
                ReDim Preserve .FaceV(iV)
                .FaceV(iV).ZValue = ( _
                    .VerticesT(.Faces(i).A).Z + _
                    .VerticesT(.Faces(i).B).Z + _
                    .VerticesT(.Faces(i).C).Z) '/ 3
                .FaceV(iV).iVisible = i
            End If
        Next
        If iV > -1 Then Call SortFaces(.FaceV, 0, iV)
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

Private Sub SortFaces(zOrder() As Order, ByVal First As Long, ByVal Last As Long)

    Dim FirstIdx  As Long
    Dim MidIdx As Long
    Dim LastIdx  As Long
    Dim MidVal As Single
    Dim TempOrder  As Order

    If (First < Last) Then
        With ObjPart
            MidIdx = (First + Last) \ 2
            MidVal = .FaceV(MidIdx).ZValue
            FirstIdx = First
            LastIdx = Last
            Do
                Do While .FaceV(FirstIdx).ZValue < MidVal
                    FirstIdx = FirstIdx + 1
                Loop
                Do While .FaceV(LastIdx).ZValue > MidVal
                    LastIdx = LastIdx - 1
                Loop
                If (FirstIdx <= LastIdx) Then
                    TempOrder = .FaceV(LastIdx)
                    zOrder(LastIdx) = .FaceV(FirstIdx)
                    zOrder(FirstIdx) = TempOrder
                    FirstIdx = FirstIdx + 1
                    LastIdx = LastIdx - 1
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


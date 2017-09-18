VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsTransForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
' User32
Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Long, ByVal hRgn As Long, ByVal bRedraw As Boolean) As Long
Private Declare Sub ReleaseCapture Lib "user32" ()
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function GetWindowDC Lib "user32" (ByVal hWnd As Long) As Long
Private Declare Function ReleaseDC Lib "user32" (ByVal hWnd As Long, ByVal hDC As Long) As Long

' gdi32
Private Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
Private Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Long, ByVal hSrcRgn1 As Long, ByVal hSrcRgn2 As Long, ByVal nCombineMode As Long) As Long
Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Long) As Long
Private Declare Function GetRegionData Lib "gdi32" (ByVal hRgn As Long, ByVal dwCount As Long, lpRgnData As Any) As Long
Private Declare Function ExtCreateRegion Lib "gdi32" (lpXform As Any, ByVal nCount As Long, lpRgnData As Any) As Long
Private Declare Function GetPixel Lib "gdi32" (ByVal hDC As Long, ByVal x As Long, ByVal y As Long) As Long
Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hDC As Long) As Long
Private Declare Function SelectObject Lib "gdi32" (ByVal hDC As Long, ByVal hObject As Long) As Long
Private Declare Function GetObject Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Long, ByVal nCount As Long, lpObject As Any) As Long
Private Declare Function DeleteDC Lib "gdi32" (ByVal hDC As Long) As Long

Private Type BITMAP
    bmType As Long
    bmWidth As Long
    bmHeight As Long
    bmWidthBytes As Long
    bmPlanes As Integer
    bmBitsPixel As Integer
    bmBits As Long
End Type

Private CurRgn As Long, TempRgn As Long
Private objName1 As Object

Private Const RGN_DIFF = 4
Private Const WM_NCLBUTTONDOWN = &HA1
Private Const HTCAPTION = 2

Private lngHeight As Long, lngWidth As Long 'height and width of object


Public Sub SetRegion(Objct As Object, Colr As Long, Optional FileName As String = vbNullString)
Dim fso, Exists As Boolean
    
    ' //Check to see if FileName is a file
    Set fso = CreateObject("Scripting.FileSystemObject")
    Exists = fso.fileexists(FileName$)           '// Returns true if file exists
    
        Set objName1 = Objct
        
        '// Free the memory allocated by the previous Region
        If CurRgn& Then DeleteObject CurRgn&
        If (Exists = True) Then                 '// If file there, load it
            CurRgn& = LoadRegionDataFromFile(FileName$)
        Else                                    '// Else, make new transparent
                                                '// form and save it for next use...
            CurRgn& = GetBitmapRegion(objName1.Picture, Colr&)
            
                '// If no name entered, don't bother writing it to HD
                '// This is for testing purposes, since no need to for see
                '// coding errors and this isn't user controled
                If FileName <> vbNullString Then
                    Call SaveRegionDataToFile(FileName$)
                End If
                
        End If
    
    '// Set the Forms new Region
    s = SetWindowRgn(objName1.hWnd, CurRgn&, True)
    
    '// release the DC.
    '// Does not hurt the form even though you got its DC from VB.
    ReleaseDC objName1.hWnd, lngHDC
            
End Sub

Private Function GetBitmapRegion(cPicture As StdPicture, cTransparent As Long)
'///////////////////////////////////
'// SET PICTURE AS TRANSPARENT OBJECT
'//////////
    Dim hRgn As Long, tRgn As Long
    Dim x As Long, y As Long, X0 As Long
    Dim hDC As Long, BM As BITMAP
    '
    'Create a new memory DC, where we will scan the picture
    hDC = CreateCompatibleDC(0)
    If hDC Then
        '
        'Let the new DC select the Picture
        SelectObject hDC, cPicture
        '
        'Get the Picture dimensions and create a new rectangular
        'region
        GetObject cPicture, Len(BM), BM
        hRgn = CreateRectRgn(0, 0, BM.bmWidth, BM.bmHeight)
        '
        'Start scanning the picture from top to bottom
        
        
                '//////////////////////////
                With frmSplash          '// This brings up frmsplash
                    .Show               '// If program is run for the first
                    .Bar1.Min = 0       '// time
                    .Bar1.Max = BM.bmHeight
                End With
                '//////////////////////////
                
                
        For y = 0 To BM.bmHeight
            For x = 0 To BM.bmWidth
                '
                'Scan a line of non transparent pixels
                While x <= BM.bmWidth And GetPixel(hDC, x, y) <> cTransparent
                    x = x + 1
                Wend
                '
                'Mark the start of a line of transparent pixels
                X0 = x
                '
                'Scan a line of transparent pixels
                While x <= BM.bmWidth And GetPixel(hDC, x, y) = cTransparent
                    x = x + 1
                Wend
                '
                'Create a new Region that corresponds to the row of
                'Transparent pixels and then remove it from the main
                'Region
                If X0 < x Then
                    tRgn = CreateRectRgn(X0, y, x, y + 1)
                    CombineRgn hRgn, hRgn, tRgn, 4
                    '
                    'Free the memory used by the new temporary Region
                    DeleteObject tRgn
                End If
            Next x
            
            '///////////////////////////
                frmSplash.Bar1.Value = y
                DoEvents
            '//////////////////////////
            
        Next y
        '
        'Return the memory address to the shaped region
        GetBitmapRegion = hRgn
        
        '//////////////////////////////
                Unload frmSplash
        '//////////////////////////////
        
    End If
    '
    'Free memory by deleting the created DC
    DeleteDC hDC
    
End Function
Public Sub DragForm(hWnd As Long, intButton As Integer)

On Error Resume Next

If intButton = vbLeftButton Then
    'Move the borderless form...
    ReleaseCapture
    SendMessage hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0
End If

End Sub
Private Sub SaveRegionDataToFile(ByVal sPath As String)
'this sub was pulled from www.vbaccelerator.com
Dim iFile As Long
Dim nBytes As Long
Dim b() As Byte

On Error GoTo ErrorHandler ' Out of memory
      
      nBytes = GetRegionData(CurRgn, 0, ByVal 0&)
      If nBytes > 0 Then
         ReDim b(0 To nBytes - 1) As Byte
         If nBytes = GetRegionData(CurRgn, nBytes, b(0)) Then
            On Error Resume Next ' Attempt to kill file
            Kill sPath
            On Error GoTo ErrorHandler ' Error handler checks for file error
            iFile = FreeFile
            Open sPath For Binary Access Write Lock Read As #iFile
            Put #iFile, , b
            Close #iFile
         Else
            Err.Raise vbObjectError + 512 + 2001, "TransForm", "Unable to get region data in SaveRegionDataToFile"
         End If
      Else
         Err.Raise vbObjectError + 512 + 2002, "TransForm", "Unable to determine size of region in SaveRegionDataToFile"
      End If
   
   Exit Sub
   
ErrorHandler:
Dim lErr As Long, sErr As String
   lErr = Err.Number: sErr = Err.Description
   If iFile > 0 Then
      Close #iFile
   End If
   Err.Raise lErr, "TransForm", sErr
   Exit Sub
   
End Sub

Private Function LoadRegionDataFromFile(ByVal sFileName As String) As Long
'this sub was pulled from www.vbaccelerator.com
Dim iFile As Long
Dim b() As Byte
Dim dwCount As Long
On Error GoTo ErrorHandler

   iFile = FreeFile
   Open sFileName For Binary Access Read Lock Write As #iFile
   ReDim b(0 To LOF(iFile) - 1) As Byte
   Get #iFile, , b
   Close #iFile
   
   dwCount = UBound(b) - LBound(b) + 1
   LoadRegionDataFromFile = ExtCreateRegion(ByVal 0&, dwCount, b(0))

   Exit Function

ErrorHandler:
Dim lErr As Long, sErr As String
   lErr = Err.Number: sErr = Err.Description
   If iFile > 0 Then
      Close #iFile
   End If
   Err.Raise lErr, App.EXEName & ".cDIBSectionRegion", sErr
   Exit Function
End Function



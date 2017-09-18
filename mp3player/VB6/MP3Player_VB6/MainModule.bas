Attribute VB_Name = "MainModule"
'## project:DisableMessages CodeAnalysis
'## project:DisableMessage 1478
'## project:DisableMessage 0354
'## project:DisableMessage 0364

Public Const RGN_OR = 2
Public Const WM_NCLBUTTONDOWN = &HA1
Public Const HTCAPTION = 2
Public Const HWND_TOPMOST = -1
Public Const HWND_NOTOPMOST = -2
Public Const SWP_NOSIZE = &H1
Public Const SWP_NOMOVE = &H2
Public Const SWP_NOACTIVATE = &H10
Public Const SWP_SHOWWINDOW = &H40
Public Const SWP_NOZORDER As Long = &H4

Public Declare Sub SetWindowPos Lib "user32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long)
Public Declare Function GetPixel Lib "gdi32" (ByVal hDC As Long, ByVal X As Long, ByVal Y As Long) As Long
Public Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Long, ByVal hRgn As Long, ByVal bRedraw As Boolean) As Long
Public Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
Public Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Long, ByVal hSrcRgn1 As Long, ByVal hSrcRgn2 As Long, ByVal nCombineMode As Long) As Long ' A sample by Yaniv Drukman: www.dr-vb.co.il
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Public Declare Function ReleaseCapture Lib "user32" () As Long
Public Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Long) As Long
Public Declare Function SetTimer Lib "user32" (ByVal hWnd As Long, ByVal nIDEvent As Long, ByVal uElapse As Long, ByVal lpTimerFunc As Long) As Long
Public Declare Function KillTimer Lib "user32" (ByVal hWnd As Long, ByVal nIDEvent As Long) As Long
Public Declare Function OffsetRgn Lib "gdi32" (ByVal hRgn As Long, ByVal X As Long, ByVal Y As Long) As Long
Public Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
Public Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long, ByVal X3 As Long, ByVal Y3 As Long) As Long

Public Declare Function waveOutSetVolume Lib "Winmm" (ByVal wDeviceID As Integer, ByVal dwVolume As Long) As Integer
Public Declare Function waveOutGetVolume Lib "Winmm" (ByVal wDeviceID As Integer, dwVolume As Long) As Integer
Public Declare Function midiOutSetVolume Lib "Winmm" (ByVal mDeviceID As Integer, ByVal dmVolume As Long) As Integer
Public Declare Function midiOutGetVolume Lib "Winmm" (ByVal mDeviceID As Integer, dmVolume As Long) As Integer
Public LstData(1000) As String

Public Sub SetVol(Volume As Integer, Optional Midi As Boolean = False)
    'v = 15
    Dim X As Long
    If Volume > 50 Then
        If Volume = 100 Then
            If Midi Then
                Call midiOutSetVolume(0, &HFFFFFFFF)
            Else
                Call waveOutSetVolume(0, &HFFFFFFFF)
            End If
        Else
            X = -((32767 / 50) * (100 - Volume))
            If Midi Then
                 Call midiOutSetVolume(0, X + (X * 65536))
            Else
                 Call waveOutSetVolume(0, X + (X * 65536))
            End If
        End If
    Else
        X = Int((32767 / 50) * Volume)
        If Midi Then
            Call midiOutSetVolume(0, X + (X * 65536))
        Else
            Call waveOutSetVolume(0, X + (X * 65536))
        End If
    End If
End Sub

Public Function GetVol(Optional Midi As Boolean = False) As Integer
    Dim v As Long
    Dim X As Long
    Dim xh As String
    If Midi Then
        Call midiOutGetVolume(0, X)
    Else
        Call waveOutGetVolume(0, X)
    End If
    xh = HexDec(Right$(Hex$(X), 4)) ', 16, 10) ') ', 16, 10))
    v = Round(Val(xh) / 655.36)
    GetVol = v
End Function

Public Function MakeRegion(picSkin As PictureBox) As Long
   
    Dim X As Long, Y As Long, StartLineX As Long
    Dim FullRegion As Long, LineRegion As Long
    Dim TransparentColor As Long
    Dim InFirstRegion As Boolean
    Dim InLine As Boolean
    Dim hDC As Long
    Dim PicWidth As Long
    Dim PicHeight As Long
    
    hDC = picSkin.hDC
    PicWidth = picSkin.ScaleWidth
    PicHeight = picSkin.ScaleHeight
    
    InFirstRegion = True: InLine = False
    X = Y = StartLineX = 0
    
    ' פונקציה זו יוצרת אזור על פי תמונה נתונה
    ' הפונקציה סורקת את השורות בתמונה, וכל הפיקסלים
    ' שאינם בצבע שנבחר להיות שקוף מוספים לאזור
   ' הצבע הנבחר לשקיפות הוא תמיד הצבע בפינה השמאלית עליונה
    TransparentColor = GetPixel(hDC, 0, 0)
    
    For Y = 0 To PicHeight - 1
        For X = 0 To PicWidth - 1
            
            If GetPixel(hDC, X, Y) = TransparentColor Or X = PicWidth Then
                ' בשורה זה ישנם פיקסלים שקופים
                If InLine Then
                    InLine = False
                    LineRegion = CreateRectRgn(StartLineX, Y, X, Y + 1)
                    
                    If InFirstRegion Then
                        FullRegion = LineRegion
                        InFirstRegion = False
                    Else
                        Call CombineRgn(FullRegion, FullRegion, LineRegion, 2)    ' A sample by Yaniv Drukman: www.dr-vb.co.il
                        ' מחיקת האובייקט שנוצר ליצירת האזור
                        DeleteObject LineRegion
                    End If
                End If
            Else
                ' הגענו לפיקבל לא שקוף
                If Not InLine Then
                    InLine = True
                    StartLineX = X
                End If
            End If
        Next
    Next

    '## InsertStatement picSkin.ReleaseHdc()

    MakeRegion = FullRegion
End Function

Public Function Percent(Val As Long, Percnt As Integer) As Long
    Percent = Val * (Percnt / 100)
End Function

'Public Function GetPercent(Num1 As Long, Num2 As Long) As Integer
'    GetPercent = 100 \ (Num2 / Num1)
'End Function

Public Function UnSpace(exp As String) As String
    Dim i As Integer
    For i = 1 To Len(exp)
        If Left(Right(exp, i), 1) <> Chr(32) Then
            If Left(Right(exp, i), 1) <> Chr(0) Then: Exit For
        End If
    Next i
    UnSpace = Left(exp, Len(exp) - (i - 1))
End Function

Public Function HexDec(h As String) As Long
    Dim i As Integer
    Dim cnt As Long
    h = LCase(h)
    For i = 1 To Len(h)
        Select Case Mid(h, i, 1)
            Case "1": cnt = cnt + 1 * 16 ^ (Len(h) - i)
            Case "2": cnt = cnt + 2 * 16 ^ (Len(h) - i)
            Case "3": cnt = cnt + 3 * 16 ^ (Len(h) - i)
            Case "4": cnt = cnt + 4 * 16 ^ (Len(h) - i)
            Case "5": cnt = cnt + 5 * 16 ^ (Len(h) - i)
            Case "6": cnt = cnt + 6 * 16 ^ (Len(h) - i)
            Case "7": cnt = cnt + 7 * 16 ^ (Len(h) - i)
            Case "8": cnt = cnt + 8 * 16 ^ (Len(h) - i)
            Case "9": cnt = cnt + 9 * 16 ^ (Len(h) - i)
            Case "a": cnt = cnt + 10 * 16 ^ (Len(h) - i)
            Case "b": cnt = cnt + 11 * 16 ^ (Len(h) - i)
            Case "c": cnt = cnt + 12 * 16 ^ (Len(h) - i)
            Case "d": cnt = cnt + 13 * 16 ^ (Len(h) - i)
            Case "e": cnt = cnt + 14 * 16 ^ (Len(h) - i)
            Case "f": cnt = cnt + 15 * 16 ^ (Len(h) - i)
        End Select
        'If Mid(h, i, 1) = "1" Then cnt = cnt + 1 * 16 ^ (Len(h) - i - 0))
        'If Mid(h, i, 1) = "2" Then cnt = cnt + 2 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "3" Then cnt = cnt + 3 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "4" Then cnt = cnt + 4 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "5" Then cnt = cnt + 5 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "6" Then cnt = cnt + 6 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "7" Then cnt = cnt + 7 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "8" Then cnt = cnt + 8 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "9" Then cnt = cnt + 9 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "a" Then cnt = cnt + 10 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "b" Then cnt = cnt + 11 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "c" Then cnt = cnt + 12 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "d" Then cnt = cnt + 13 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "e" Then cnt = cnt + 14 * 16 ^ (Len(h) - (i - 0))
        'If Mid(h, i, 1) = "f" Then cnt = cnt + 15 * 16 ^ (Len(h) - (i - 0))
    Next i
    HexDec = cnt
End Function

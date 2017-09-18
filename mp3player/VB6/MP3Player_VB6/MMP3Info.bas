Attribute VB_Name = "MMP3Info"
Option Explicit
Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
Declare Function SetParent Lib "user32" (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long

Public Type MP3Tag
    Title As String * 30
    Artist As String * 30
    Album As String * 30
    Year As String * 4
    Comments As String * 30
End Type

Private Buffer As String * 255

Public Function GetMP3Info(MP3File As String) As MP3Tag
' MP3 פונקציה זו מחזירה מידע על קובץ
Dim InfoTag As Long

    On Error GoTo errHandler
    ' פתיחת הקובץ
    '## InsertStatement Call mciSendString("close myfile", 0%, 0, 0)
    Close
    Open MP3File For Binary As #1
    ' קריאת המידע על הקובץ
    Get #1, (LOF(1) - 256), Buffer
    Close #1
    
    ' ------- save to C:\
    Open "c:\testmp3.txt" For Binary As #2
    Put #2, , Buffer
    Close #2

    ' שמירת המידע למשתנה
    InfoTag = InStr(1, Buffer, "tag", 1)

    ' בדיקה האם קובץ זה מכיל מידע
    If InfoTag = 0 Then
        'MsgBox "לא ניתן לקבל מידע על קובץ זה", vbOKOnly, "MP3"
        Exit Function
    End If

    ' MP3-עדכון הערכים המוחזרים על ידי הפונקציה במידע על קובץ ה
    With GetMP3Info
        .Title = Mid(Buffer, InfoTag + 3, 30)
        .Artist = Mid(Buffer, InfoTag + 33, 30)
        .Album = Mid(Buffer, InfoTag + 63, 30)
        .Year = Mid(Buffer, InfoTag + 93, 30)
        .Comments = Mid(Buffer, InfoTag + 97, 30)
    End With
    Close
Exit Function
errHandler:
    Close
    MsgBox "File Error!", vbCritical, "MP3"
    Player.mediafile = ""
End Function

Public Function TimeString(Seconds As Long) As String
    'convert seconds to mm:ss format
    Dim Mins As Long
    If Seconds < 60 Then TimeString = "0:" & Right("0" & Seconds, 2)
    If Seconds > 59 Then
        Mins = Int(Seconds / 60)
        Seconds = Seconds - (Mins * 60)
        TimeString = Right("0" + Str(Mins), 2) & ":" & Right("0" & Seconds, 2)
    End If
    If InStr(1, TimeString, " ") Then Mid(TimeString, InStr(1, TimeString, " "), 1) = ""
End Function

Public Function FileLength() As Long
    Dim ml As String
    ml = Space(30)
    Call mciSendString("set myfile time format ms", 0, 0, 0)
    Call mciSendString("status myfile length ", ml, 30, 0) ', , "mci: Calculate playtime"
    FileLength = Val(ml)
End Function

Public Function FileLocation() As Long
    Dim ml As String
    ml = Space(30)
    Call mciSendString("set myfile time format ms", 0, 0, 0)
    Call mciSendString("status myfile position ", ml, 30, 0) ', , "mci: Calculate playtime"
    FileLocation = Val(ml)
End Function


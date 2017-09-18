Attribute VB_Name = "modMain"
'---------------------------------------------------------------------
'
'                ATOMIX Virtual Cipher Machine v2.0
'
'                    (c) D Rijmenants 2006
'
'---------------------------------------------------------------------
'
'  Version Info:
'
'  v1.2 - Improved clipboard formatting of plain text
'  v1.3 - Memorize last code/decode mode for clipboard
'  v1.4 - Correction view contacts from extracted rotor
'       - Added diagrams to help file
'  v1.5 - Keyblock connections visualized
'  v1.6 - Added graphics to help file section 'how to use'
'       - Enabled clearing one cable with DEL key
'  v1.7 - Cleared bug switching rotors K and L
'  v1.8 - Enabled using number keys without shift
'  v1.9 - ...
'
'---------------------------------------------------------------------

Option Explicit

'rotor wire layout
Public gstrWireString As String
'keyboard layout
Public gstrKeyboard As String
' current gintRotorOffset (wheelposition)
Public gintRotorOffset(8) As Integer
'all predefined rotors (rotornr,rotorvalue)
Public gintDefineRotor(12) As String
'selected rotors
Public gstrUsedRotString(8) As String
Public gintUsedRotor(8, 38) As Integer
Public gintUsedRotNr(8) As Integer
'all predefined reflectors
Public gstrDefineReflector(1) As String
' currently used reflectors
Public gintUsedReflector(1, 38) As Integer
'pins
Public gstrUsedPins(8) As String
'keyblock
Public gstrKeyBlock As String
Public P1(38, 2) As Integer
Public P2(38, 2) As Integer


Public gblnEncodeText As Boolean
Public gblnLastEncodeText As Boolean
Public gblnSetRotors As Boolean
Public gblnSetKeyBlock As Boolean

Public gblnLockOpen As Boolean
Public gblnCoverOpen As Boolean
Public gblnRotorsInCradle As Boolean
Public gintRotorsOnAxle As Integer

Public gstrClipInput As String
Public gstrClipOutput As String
Public gstrQuickString As String
Public GroupsCount As Integer

Public gintCurrentRotorSet As Integer
Public gintCounter As Integer
Public gstrExitVal As String
Public gblnSound As Boolean
Public gstrAutoType As Boolean

'cursor functions to move forms
Public Declare Function GetCursorPos Lib "user32" (lpPoint As POINTAPI) As Long
Public LastPoint As POINTAPI
Public iTPPY As Long
Public iTPPX As Long
Public Type POINTAPI
        X As Long
        Y As Long
End Type

'sound api
Declare Function sndPlaySound Lib "WINMM.DLL" Alias "sndPlaySoundA" _
        (ByVal lpszSoundName As Any, ByVal uFlags As Long) As Long
Public Const SND_ASYNC = &H1     ' Play asynchronously
Public Const SND_NODEFAULT = &H2 ' Don't use default sound
Public Const SND_MEMORY = &H4    ' lpszSoundName points to a memory file
Public SoundBuffer As String

'Run or open file

'time function
Public Declare Function GetTickCount Lib "kernel32" () As Long

Sub Main()
Dim k
Dim j
Dim CableColor(5) As Long
Dim XX(10) As Long
Dim YY(8) As Long

iTPPX& = Screen.TwipsPerPixelX
iTPPY& = Screen.TwipsPerPixelY

'keyboard and rotor layout
gstrKeyboard = "1234567890AZERTYUIOPQSDFGHJKLMWXCVBN-+"
gstrWireString = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-+"

'define rotor wiring
gintDefineRotor(1) = "L7MKZB35UEA0+4JTNRD98SOCWG1I2V-PX6FHQY"
gintDefineRotor(2) = "BD-36GACWE+9V4F51QKPURZ8HJSO0NXTL2Y7IM"
gintDefineRotor(3) = "RDCX7LYWQBZ8SK5ETM9AJ4U21G3+H6VI0-FNPO"
gintDefineRotor(4) = "WU2VS58INC90TXGHYOMJR6Z-BFL3+P1EK47ADQ"
gintDefineRotor(5) = "C3X1+97TJQV8SI2ZBDWKNEOUFHL6-R4PG5M0AY"
gintDefineRotor(6) = "Y14QUS7RPT+IV2AXL5J8WCOE3MK6HDB-9ZG0FN"
gintDefineRotor(7) = "F9+08VXWBO7NIQ6-GC4HJADE5PK1T32ZMLUYRS"
gintDefineRotor(8) = "V1DB5WE-NR9L0XFQ32USTPJ+6AOKG87MHZI4YC"
gintDefineRotor(9) = "LBR7MDO52SWFQU-H63A+EVTZNX80PJCG1K9I4Y"
gintDefineRotor(10) = "UDRTEFSC+BP9Q8WIOG7Y4V0NXJ5Z6HK3-MA21L"
gintDefineRotor(11) = "1I4G78SHJFQAXTRNV0U52WO-3KPBZMC69DLEY+"
gintDefineRotor(12) = "8IEVX5QWD-RSUZ20TJ9YCF6+OM3KP14NBG7LAH"
'define reflector wiring
gstrDefineReflector(1) = "DL9WOFBQ3YI7M1+6JNAG-2CH5T8XVPZS4R0UKE"

'set reflector values
For k = 1 To 1
    For j = 1 To 38
        gintUsedReflector(k, j) = StringTowire(Mid(gstrDefineReflector(k), j, 1))
    Next j
Next k

Load frmMain
Load frmClipBoard
Load frmExit
Load frmQuick
Load frmInfo
Load frmKeySheet

With frmMain
.imgBackground.Width = .Width
.imgBackground.Height = .Height
.imgCradle.Width = .picRotorOpen.Width
.imgCradle.Height = .picRotorOpen.Height

CableColor(0) = &H0&     'black
CableColor(1) = &HC0&    'red
CableColor(2) = &HFFFF&  'yellow
CableColor(3) = &HC00000 'blue
CableColor(4) = &H8000&  'green

For k = 1 To 38
    .Cable(k).BorderColor = CableColor(k Mod 5)
Next

End With

'preset cable coordinates
'x coord plugs on key block
XX(1) = 305
XX(2) = 545
XX(3) = 785
XX(4) = 1025
XX(5) = 1265
XX(6) = 1505
XX(7) = 1745
XX(8) = 1985
XX(9) = 2225
XX(10) = 2465
'y coord plugs on key block
YY(1) = 300
YY(2) = 510
YY(3) = 720
YY(4) = 940
YY(5) = 1450
YY(6) = 1660
YY(7) = 1890
YY(8) = 2100
'load each plug X coordinate
For k = 1 To 38
    Select Case k
    Case 1 To 10
        P1(k, 1) = XX(k)
        P2(k, 1) = XX(k)
        P1(k, 2) = YY(1)
        P2(k, 2) = YY(5)
    Case 11 To 19
        P1(k, 1) = XX(k - 10) + 120
        P2(k, 1) = XX(k - 10) + 120
        P1(k, 2) = YY(2)
        P2(k, 2) = YY(6)
    Case 20 To 29
        P1(k, 1) = XX(k - 19)
        P2(k, 1) = XX(k - 19)
        P1(k, 2) = YY(3)
        P2(k, 2) = YY(7)
    Case 30 To 38
        P1(k, 1) = XX(k - 29) + 120
        P2(k, 1) = XX(k - 29) + 120
        P1(k, 2) = YY(4)
        P2(k, 2) = YY(8)
    End Select
Next

frmMain.Show

'load images
For k = 1 To 8
    frmMain.imgRotorOnAxe(k).Picture = frmMain.imgRotor.Picture
Next k
For k = 1 To 12
    frmMain.imgRotorInBox(k).Picture = frmMain.imgBoxRotor.Picture
Next k

'set encode to begin
gblnEncodeText = True
gblnLastEncodeText = gblnEncodeText

'sound on
gblnSound = True

'get key settings from file
Call LoadKeySettings

'set rotors on 'A'
For k = 1 To 8
gintRotorOffset(k) = 10
Next k
Call SetRotorsView

End Sub


Public Sub Crypto(wireIn As Integer)
'encryption routine for 1 character
Dim E As String
Dim wireOut As Integer
Dim CharIn As String
Dim charOut As String
Dim k As Integer

'get out if cradle is open
If gblnCoverOpen = True Then
    Exit Sub
End If

'get out if lock is open
If gblnLockOpen = True Then
    gblnSetRotors = False
    Exit Sub
End If

'if in SET mode, dont encrypt but set rotor positions one by one
If gblnSetRotors = True Then
    'set a rotor
    Call PlaySound(2)
    Call MoveRotorTo(gintCurrentRotorSet, wireIn - 1)
    'goto next rotor
    gintCurrentRotorSet = gintCurrentRotorSet - 1
    If gintCurrentRotorSet < 1 Then Call SetRotors
    Exit Sub
    End If

'complete signal encryption cyclus

' Note that the program numbers the rotors as in the encryption
' cyclus (from right to left) and NOT as the operator counts the
' machine rotors (from left to right)
' Rotor positions users view:     1 2 3 4 5 6 7 8
' Program's Rotor numbering : REF 8 7 6 5 4 3 2 1 ENTRY

' signal path program:
' Keyboard->Keyblock->12345678->Reflector->87654321->Keyblock->Keyboard

'through key block
wireOut = PassBlockToLeft(wireIn)
'from right to left
wireOut = PassToLeft(wireOut, 1)
wireOut = PassToLeft(wireOut, 2)
wireOut = PassToLeft(wireOut, 3)
wireOut = PassToLeft(wireOut, 4)
wireOut = PassToLeft(wireOut, 5)
wireOut = PassToLeft(wireOut, 6)
wireOut = PassToLeft(wireOut, 7)
wireOut = PassToLeft(wireOut, 8)
'return through reflector
wireOut = PassReflector(wireOut)
'back, from left to right
wireOut = PassToRight(wireOut, 8)
wireOut = PassToRight(wireOut, 7)
wireOut = PassToRight(wireOut, 6)
wireOut = PassToRight(wireOut, 5)
wireOut = PassToRight(wireOut, 4)
wireOut = PassToRight(wireOut, 3)
wireOut = PassToRight(wireOut, 2)
wireOut = PassToRight(wireOut, 1)
'again 'through key block
wireOut = PassBlockToRight(wireOut)

'move rotors
Call MoveRotors

'convert wire to character
CharIn = WireToString(wireIn)
charOut = WireToString(wireOut)

'print to tape and memorize clipboard strings
With frmMain

'memorize last operation for clipboard formatting
gblnLastEncodeText = gblnEncodeText

If gblnEncodeText = False And charOut = "-" Then charOut = " "

.lblTapeInput.Caption = .lblTapeInput.Caption & CharIn
.lblTapeOutput.Caption = .lblTapeOutput.Caption & charOut

If gblnEncodeText = True Then
    'encode(only use groups when encoding)
    GroupsCount = GroupsCount + 1
    If GroupsCount = 5 Then
        GroupsCount = 0
        .lblTapeInput.Caption = .lblTapeInput.Caption & " "
        .lblTapeOutput.Caption = .lblTapeOutput.Caption & " "
    End If
    'clipboard
    gstrClipOutput = gstrClipOutput & charOut
    If CharIn <> "-" Then
        gstrClipInput = gstrClipInput & CharIn
        Else
        gstrClipInput = gstrClipInput & " "
        End If
    Else
    'decode
    gstrClipInput = gstrClipInput & CharIn
    gstrClipOutput = gstrClipOutput & charOut
End If

'cut off text if too long for paper ribbon
If Len(.lblTapeInput.Caption) > 55 Then
    .lblTapeInput.Caption = Right(.lblTapeInput.Caption, 65)
    .lblTapeOutput.Caption = Right(.lblTapeOutput.Caption, 65)
    End If

'advance counter
gintCounter = gintCounter + 1
If gintCounter > 9999 Then gintCounter = 0
frmMain.lblCounter(1).Caption = Mid(Format(gintCounter, "0000"), 1, 1)
frmMain.lblCounter(2).Caption = Mid(Format(gintCounter, "0000"), 2, 1)
frmMain.lblCounter(3).Caption = Mid(Format(gintCounter, "0000"), 3, 1)
frmMain.lblCounter(4).Caption = Mid(Format(gintCounter, "0000"), 4, 1)

End With
End Sub

Public Function PassToLeft(ByVal Wire As Integer, rotNr As Integer) As Integer
'pass a rotor going left, direction reflector
Wire = Wire + gintRotorOffset(rotNr)
If Wire > 38 Then Wire = Wire - 38
Wire = gintUsedRotor(rotNr, Wire)
Wire = Wire - gintRotorOffset(rotNr)
If Wire < 1 Then Wire = Wire + 38
PassToLeft = Wire
End Function

Public Function PassReflector(ByVal Wire As Integer) As Integer
'return signal through reflector
Dim Z As Integer
PassReflector = gintUsedReflector(1, Wire)
End Function

Public Function PassToRight(ByVal Wire As Integer, rotNr As Integer) As Integer
'pass a rotor going back, direction entry
Dim k As Integer
Wire = Wire + gintRotorOffset(rotNr)
If Wire > 38 Then Wire = Wire - 38
For k = 1 To 38
    If gintUsedRotor(rotNr, k) = Wire Then Exit For
Next k
Wire = k - gintRotorOffset(rotNr)
If Wire < 1 Then Wire = Wire + 38
PassToRight = Wire
End Function

Public Function PassBlockToLeft(ByVal Wire As Integer) As Integer
'pass key block wiring
PassBlockToLeft = StringTowire(Mid(gstrKeyBlock, Wire, 1))
End Function

Public Function PassBlockToRight(ByVal Wire As Integer) As Integer
'return through key block wiring
Dim k As Integer
For k = 1 To 38
    If Wire = StringTowire(Mid(gstrKeyBlock, k, 1)) Then PassBlockToRight = k: Exit Function
Next k
End Function

Public Sub MoveRotors()
Dim k As Integer
Dim currPin(8) As Integer
For k = 1 To 8
    currPin(k) = gintRotorOffset(k)
Next k

Call PlaySound(1)

' Note that the program numbers the rotors as in the encryption
' cyclus (from right to left) and NOT as the operator counts the
' machine rotors (from left to right)
' Rotor positions users view:     1 2 3 4 5 6 7 8
' Program's Rotor numbering : REF 8 7 6 5 4 3 2 1 ENTRY

' -7-5-3-1 direction up
' 1 always steps (upwards, view from user)
' 1 commands 3, 3 commands 5, 5 commands 7
gintRotorOffset(1) = gintRotorOffset(1) + 1
If gintRotorOffset(1) > 37 Then gintRotorOffset(1) = 0

If Mid(gstrUsedPins(1), currPin(1) + 1, 1) = "1" Then
    gintRotorOffset(3) = gintRotorOffset(3) + 1
    If gintRotorOffset(3) > 37 Then gintRotorOffset(3) = 0
    Else
    GoTo EndStep1
    End If
    
If Mid(gstrUsedPins(3), currPin(3) + 1, 1) = "1" Then
    gintRotorOffset(5) = gintRotorOffset(5) + 1
    If gintRotorOffset(5) > 37 Then gintRotorOffset(5) = 0
    Else
    GoTo EndStep1
    End If

If Mid(gstrUsedPins(5), currPin(5) + 1, 1) = "1" Then
    gintRotorOffset(7) = gintRotorOffset(7) + 1
    If gintRotorOffset(7) > 37 Then gintRotorOffset(7) = 0
    End If

EndStep1:

' 8-6-4-2- direction down
' 8 always steps (downwards, view from user)
' 8 commands 6, 6 commands 4, 4 commands 2
gintRotorOffset(8) = gintRotorOffset(8) - 1
If gintRotorOffset(8) < 0 Then gintRotorOffset(8) = 37

If Mid(gstrUsedPins(8), currPin(8) + 1, 1) = "1" Then
    gintRotorOffset(6) = gintRotorOffset(6) - 1
    If gintRotorOffset(6) < 0 Then gintRotorOffset(6) = 37
    Else
    GoTo EndStep2
    End If
    
If Mid(gstrUsedPins(6), currPin(6) + 1, 1) = "1" Then
    gintRotorOffset(4) = gintRotorOffset(4) - 1
    If gintRotorOffset(4) < 0 Then gintRotorOffset(4) = 37
    Else
    GoTo EndStep2
    End If

If Mid(gstrUsedPins(4), currPin(4) + 1, 1) = "1" Then
    gintRotorOffset(2) = gintRotorOffset(2) - 1
    If gintRotorOffset(2) < 0 Then gintRotorOffset(2) = 37
    End If

EndStep2:

Call SetRotorsView

End Sub

Public Sub SetRotors()
'toggle SET mode
Dim k As Integer

If gblnLockOpen = True Then Exit Sub

If gblnSetRotors = False Then
    gblnSetRotors = True
    gintCurrentRotorSet = 8
    frmMain.imgLampSet.Picture = frmMain.imgLampRedOn.Picture
    Else
    gblnSetRotors = False
    frmMain.imgLampSet.Picture = frmMain.imgLampRedOff.Picture
End If

End Sub

Public Sub SetRotorsView()
'set rotor view labels
Dim k As Integer
Dim tmp As Integer
For k = 1 To 8
tmp = gintRotorOffset(k)
frmMain.lblRot(k).Caption = WireToString(tmp + 1)
frmMain.lblRot(k).Refresh
Next k
End Sub

Public Function WireToString(ByVal Wire As Integer) As String
'convert wire (1-38) to string
WireToString = Mid(gstrWireString, Wire, 1)
End Function

Public Function StringTowire(ByVal aString As String) As Integer
'convert string to wire (1-38)
If aString = " " Then aString = "-"
StringTowire = InStr(1, gstrWireString, aString)
End Function

Public Sub MoveRotorTo(rotNr As Integer, ByVal offset As Integer)
'move a rotor to a certain position
Dim k As Integer
For k = 1 To 38
    If gintRotorOffset(rotNr) <> offset Then
        gintRotorOffset(rotNr) = gintRotorOffset(rotNr) + 1
        If gintRotorOffset(rotNr) > 37 Then gintRotorOffset(rotNr) = 0
        Call SetRotorsView
        Call PlaySound(2)
        Call PauzeTime(10)
    Else
        Exit For
    End If
Next k
End Sub

Public Sub MoveAllRotorsTo(offset As Integer)
'move all rotors to rotnr position
Dim k As Integer
Dim j As Integer
Dim OKcount As Integer
Dim Moreflag As Boolean
For k = 1 To 38
    OKcount = 0
    For j = 1 To 8
    If gintRotorOffset(j) <> offset Then
        gintRotorOffset(j) = gintRotorOffset(j) + 1
        If gintRotorOffset(j) > 37 Then gintRotorOffset(j) = 0
        If gintRotorOffset(j) = offset Then OKcount = OKcount + 1
        Else
        OKcount = OKcount + 1
        End If
    Next
    Call SetRotorsView
    Call PauzeTime(10)
    Call PlaySound(2)
    If OKcount = 8 Then Exit For
Next k
End Sub

Public Sub PauzeTime(TimeToWait As Long)
'make a pauze
Dim currTime As Long
Dim passedTime As Long
currTime = GetTickCount()
Do
    passedTime = Abs(GetTickCount() - currTime)
Loop While passedTime < TimeToWait
End Sub

Public Sub SetPin(ByVal rotNr As Integer)
'set pin of a rotor
Mid(gstrUsedPins(rotNr), gintRotorOffset(1) + 1, 1) = "1"
End Sub

Public Sub LoadKeySettings()
'load key settings from "atomix.dat" file
Dim infile As Integer
Dim FileName As String
Dim tmpInput(10) As String
Dim k As Integer
Dim j As Integer

On Error GoTo errHandle

infile = FreeFile
FileName = App.Path & "\atomix.dat"
If Dir(FileName) = "" Then
    'no file
    GoTo errHandle
    End If
Open FileName For Input As infile

For k = 1 To 10
    Line Input #infile, tmpInput(k)
Next k

Close infile
'check key length
If Len(tmpInput(1)) <> 8 Then GoTo errHandle
'check length key block and pins
For k = 2 To 10
    If Len(tmpInput(k)) <> 38 Then GoTo errHandle
Next k
'rotors
For k = 1 To 8
    j = Asc(Mid(tmpInput(1), k, 1)) - 64
    If j < 0 Or j > 12 Then GoTo errHandle
    gintUsedRotNr(k) = j
Next k
For k = 1 To 8
    gstrUsedRotString(k) = gintDefineRotor(gintUsedRotNr(k))
    For j = 1 To 38
        gintUsedRotor(k, j) = StringTowire(Mid(gstrUsedRotString(k), j, 1))
    Next j
Next k
'key block
gstrKeyBlock = tmpInput(2)
'pins(5)
For k = 1 To 8
gstrUsedPins(k) = tmpInput(k + 2)
Next k

Exit Sub
errHandle:
Close infile
'load default settings
'rotors
gintUsedRotNr(1) = 8
gintUsedRotNr(2) = 7
gintUsedRotNr(3) = 6
gintUsedRotNr(4) = 5
gintUsedRotNr(5) = 4
gintUsedRotNr(6) = 3
gintUsedRotNr(7) = 2
gintUsedRotNr(8) = 1
For k = 1 To 8
    gstrUsedRotString(k) = gintDefineRotor(gintUsedRotNr(k))
    For j = 1 To 38
        gintUsedRotor(k, j) = StringTowire(Mid(gstrUsedRotString(k), j, 1))
    Next j
Next k
'pins
For k = 1 To 8
    gstrUsedPins(k) = "01111111111111111111111111111111111111"
Next k
'keyblock
gstrKeyBlock = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-+"
End Sub

Public Sub SaveKeySettings()
'seve current key settings to "atomix.dat" file
Dim infile As Integer
Dim FileName As String
Dim tmp As String
Dim k As Integer

On Error GoTo errHandle

infile = FreeFile
FileName = App.Path & "\atomix.dat"

Open FileName For Output As infile
'rotors
For k = 1 To 8
    tmp = tmp & Chr(gintUsedRotNr(k) + 64)
Next k
Print #infile, tmp
'key block
Print #infile, gstrKeyBlock
'pins
Print #infile, gstrUsedPins(1)
Print #infile, gstrUsedPins(2)
Print #infile, gstrUsedPins(3)
Print #infile, gstrUsedPins(4)
Print #infile, gstrUsedPins(5)
Print #infile, gstrUsedPins(6)
Print #infile, gstrUsedPins(7)
Print #infile, gstrUsedPins(8)
Close infile
Exit Sub
errHandle:
Close infile
MsgBox "Failed saving the Key settings." & vbCrLf & vbCrLf & Err.Description, vbCritical + vbOKOnly
End Sub

Public Sub EraseStettings()
' erase saved settings (kill "atomix.dat" file)
Dim FileName As String
Dim infile As Integer
On Error GoTo errHandle
infile = FreeFile
FileName = App.Path & "\atomix.dat"
Kill FileName
Exit Sub
errHandle:
MsgBox "Failed deleting the Key settings." & vbCrLf & vbCrLf & Err.Description, vbCritical + vbOKOnly
End Sub
Public Sub EndProgram()
' exit program and ask user what to do with key settings
Dim k As Integer
Dim Retval As Integer
Beep
frmExit.Show (vbModal)
If gstrExitVal = "cancel" Or gstrExitVal = "" Then
    Exit Sub
ElseIf gstrExitVal = "save" Then
    'save
    Call SaveKeySettings
ElseIf gstrExitVal = "erase" Then
    'erase
    Call EraseStettings
End If
Unload frmMain
Unload frmInfo
Unload frmClipBoard
Unload frmQuick
Unload frmExit
Unload frmKeySheet
End
End Sub

Public Sub AutoTyping()
'autotyping function
Dim tmpQuick As String
Dim tmp As String
Dim i As Long
Dim tm As Long
'delet all but alphabet
tmpQuick = frmQuick.txtQuick.Text
If tmpQuick = "" Then Exit Sub
gstrAutoType = True
'sleect autotyping speed
Select Case frmQuick.cmbSpeed.Text
Case "Slow"
    tm = 2000
Case "Normal"
    tm = 250
Case "Fast"
    tm = 0
End Select
For i = 1 To Len(tmpQuick)
    tmp = UCase(Mid(tmpQuick, i, 1))
    If gblnEncodeText = False Then
        'decode, so only 1-0,A-Z,=+
        If InStr(1, gstrWireString, tmp) <> 0 Then
            frmMain.imgKey(InStr(1, gstrKeyboard, tmp)).Picture = frmMain.imgKeyDown(InStr(1, gstrKeyboard, tmp)).Picture
            Crypto (StringTowire(tmp)): PauzeTime (tm)
            frmMain.imgKey(InStr(1, gstrKeyboard, tmp)).Picture = Nothing
            End If
        Else
        'encode, so only 1-0,A-Z and spaces
        If tmp = " " Then tmp = "-"
        If (Asc(tmp) > 64 And Asc(tmp) < 91) Or (Asc(tmp) > 47 And Asc(tmp) < 58) Or tmp = "-" Or tmp = "+" Then
            frmMain.imgKey(InStr(1, gstrKeyboard, tmp)).Picture = frmMain.imgKeyDown(InStr(1, gstrKeyboard, tmp)).Picture
            Crypto (StringTowire(tmp)): PauzeTime (tm)
            frmMain.imgKey(InStr(1, gstrKeyboard, tmp)).Picture = Nothing
            End If
    End If
    DoEvents
    If gstrAutoType = False Then
        MsgBox "Auto Typing aborted.", vbInformation, " ATOMIX"
        Exit For
    End If
Next i
gstrAutoType = False
End Sub

Public Sub PlaySound(aSound As Integer)
'play a sound
Dim Ret
If gblnSound = False Then Exit Sub
Select Case aSound
Case 1
    SoundBuffer = StrConv(LoadResData(1, "Sounds"), vbUnicode)
Case 2
    SoundBuffer = StrConv(LoadResData(2, "Sounds"), vbUnicode)
Case Else
    Exit Sub
End Select
Ret = sndPlaySound(SoundBuffer, SND_ASYNC Or SND_NODEFAULT Or SND_MEMORY)
End Sub

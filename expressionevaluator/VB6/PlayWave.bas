Attribute VB_Name = "modPlayWave"
Option Explicit

Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Long, ByVal dwFlags As Long) As Long
    Private Const SND_ASYNC = &H1    'Play Asyncronically
    Private Const SND_SYNC = &H0    'Play Sincronically
    Private Const SND_MEMORY = &H4    ' lpszSoundName points to a memory file, must be a string, converted to Unicode !
    Private Const SND_PURGE = &H40 'Used to stop playin' WAVE
    Private Const SND_NODEFAULT = &H2 '  silence not default, if sound not found
    Private Const SND_FILENAME = &H20000    'lpszSoundName point to FileNAme
    Private Const SND_LOOP = &H8         '  loop the sound until next sndPlaySound
    Private Const SND_NOSTOP = &H10        '  don't stop any currently playing sound
    Private Const SND_NOWAIT = &H2000      '  don't wait if the driver is busy
'    Private Const SND_VALID = &H1F        '  valid flags          / ;Internal /
'    Private Const SND_VALIDFLAGS = &H17201F    '  Set of valid flag bits.  Anything outside
'                                    '  this range will raise an error
Private Declare Function waveOutGetNumDevs Lib "winmm.dll" () As Long

Public Enum APIWaveSourceTypeConstants
    UseMemory = SND_MEMORY
    UseFileName = SND_FILENAME
End Enum

Public Enum APIWavePlayFlags
    LoopSound = SND_LOOP
    NoStopPreviousSound = SND_NOSTOP
    NoWaitIfBusy = SND_NOWAIT
    NoFlags = 0
End Enum

'***************************Wave Playing Code*************************************
'Returns True if system can play wave
Public Function CanPlayWaves() As Boolean
    CanPlayWaves = waveOutGetNumDevs()
End Function
'Plays Wave
Public Function PlayWave(Source As String, Optional Async As Boolean = True, Optional SourceType As APIWaveSourceTypeConstants = UseFileName, Optional PlayType As APIWavePlayFlags = NoFlags) As Boolean          'Better (must) Call with blnAsync to true !!!
    Dim lngFlags As Long
    'Set Flags for PlaySound
    lngFlags = SND_NODEFAULT Or SND_SYNC
    If Async Then lngFlags = lngFlags Or SND_ASYNC
    lngFlags = lngFlags Or SourceType
    lngFlags = lngFlags Or PlayType
    'Play It !
    PlayWave = PlaySound(Source, 0, lngFlags)
End Function
Public Function StopPlayingWave() As Boolean
    PlaySound vbNullString, 0&, SND_PURGE
End Function

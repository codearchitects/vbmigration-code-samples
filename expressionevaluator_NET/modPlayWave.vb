' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module modPlayWave

	Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
	Private Const SND_ASYNC As Short = &H1S
	'Play Asyncronically
	Private Const SND_SYNC As Short = &H0S
	'Play Sincronically
	Private Const SND_MEMORY As Short = &H4S
	' lpszSoundName points to a memory file, must be a string, converted to Unicode !
	Private Const SND_PURGE As Short = &H40S
	'Used to stop playin' WAVE
	Private Const SND_NODEFAULT As Short = &H2S
	'  silence not default, if sound not found
	Private Const SND_FILENAME As Integer = &H20000I
	'lpszSoundName point to FileNAme
	Private Const SND_LOOP As Short = &H8S
	'  loop the sound until next sndPlaySound
	Private Const SND_NOSTOP As Short = &H10S
	'  don't stop any currently playing sound
	Private Const SND_NOWAIT As Short = &H2000S
	'  don't wait if the driver is busy
	'    Private Const SND_VALID = &H1F        '  valid flags          / ;Internal /
	'    Private Const SND_VALIDFLAGS = &H17201F    '  Set of valid flag bits.  Anything outside
	'                                    '  this range will raise an error
	Private Declare Function waveOutGetNumDevs Lib "winmm.dll" () As Integer
	
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
		Return waveOutGetNumDevs()
	End Function
	
	'Plays Wave
	Public Function PlayWave(ByRef Source As String, Optional ByRef Async As Boolean = True, Optional ByRef SourceType As APIWaveSourceTypeConstants = APIWaveSourceTypeConstants.UseFileName, Optional ByRef PlayType As APIWavePlayFlags = APIWavePlayFlags.NoFlags) As Boolean 'Better (must) Call with blnAsync to true !!!
		Dim lngFlags As Integer = SND_NODEFAULT Or SND_SYNC
		'Set Flags for PlaySound
		If Async Then  lngFlags = lngFlags Or SND_ASYNC
		lngFlags = lngFlags Or SourceType
		lngFlags = lngFlags Or PlayType
		'Play It !
		Return PlaySound(Source, 0, lngFlags)
	End Function
	
	Public Function StopPlayingWave() As Boolean
		PlaySound(Nothing, 0%, SND_PURGE)
	End Function

End Module

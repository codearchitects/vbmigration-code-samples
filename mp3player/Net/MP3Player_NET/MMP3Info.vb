' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Structure MP3Tag

	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> _
	Public Title As VB6FixedString
	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> _
	Public Artist As VB6FixedString
	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> _
	Public Album As VB6FixedString
	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=4)> _
	Public Year As VB6FixedString
	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> _
	Public Comments As VB6FixedString

#Region "Initialization"

	Public Sub New(ByVal dummyArg As Boolean)
		InitializeUDT()
	End Sub

	Public Sub InitializeUDT()
		Title = New VB6FixedString(30)
		Artist = New VB6FixedString(30)
		Album = New VB6FixedString(30)
		Year = New VB6FixedString(4)
		Comments = New VB6FixedString(30)
	End Sub

#End Region

#Region "Clone method"

	Public Function Clone() As MP3Tag
		Dim copy As MP3Tag = Me
		copy.Title.Value = Me.Title.Value
		copy.Artist.Value = Me.Artist.Value
		copy.Album.Value = Me.Album.Value
		copy.Year.Value = Me.Year.Value
		copy.Comments.Value = Me.Comments.Value
		Return copy
	End Function

#End Region

End Structure

Friend Module MMP3Info

	Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
	Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
	
	Private Buffer As New VB6FixedString(255)
	
	Public Function GetMP3Info(ByRef MP3File As String) As MP3Tag
		' The returned structure requires initialization
		GetMP3Info.InitializeUDT()
		' MP3 ôåð÷öéä æå îçæéøä îéãò òì ÷åáõ
		Dim InfoTag As Integer
		
		On Error GoTo errHandler 
		' ôúéçú ä÷åáõ
		Call mciSendString("close myfile", 0%, 0, 0)
		FileClose6()
		FileOpen6(1, MP3File, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1)
		' ÷øéàú äîéãò òì ä÷åáõ
		FileGet6(1, Buffer.Value, (LOF6(1) - 256))
		FileClose6(1)
		
		' ------- save to C:\
		FileOpen6(2, "c:\testmp3.txt", OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1)
		FilePut6(2, Buffer.Value)
		FileClose6(2)
		
		' ùîéøú äîéãò ìîùúðä
		InfoTag = InStr(1, Buffer.Value, "tag", 1)
		
		' áãé÷ä äàí ÷åáõ æä îëéì îéãò
		If InfoTag = 0 Then 
			'MsgBox "ìà ðéúï ì÷áì îéãò òì ÷åáõ æä", vbOKOnly, "MP3"
			Exit Function
		End If
		
		' MP3-òãëåï äòøëéí äîåçæøéí òì éãé äôåð÷öéä áîéãò òì ÷åáõ ä
		With GetMP3Info
			.Title.Value = Mid(Buffer.Value, InfoTag + 3, 30)
			.Artist.Value = Mid(Buffer.Value, InfoTag + 33, 30)
			.Album.Value = Mid(Buffer.Value, InfoTag + 63, 30)
			.Year.Value = Mid(Buffer.Value, InfoTag + 93, 30)
			.Comments.Value = Mid(Buffer.Value, InfoTag + 97, 30)
		End With
		FileClose6()
		Exit Function
errHandler:
		FileClose6()
		MsgBox6("File Error!", MsgBoxStyle.Critical, "MP3")
		Player.mediafile = ""
	End Function

	Public Function TimeString(ByRef Seconds As Integer) As String
		'convert seconds to mm:ss format
		Dim Mins As Integer
		If Seconds < 60 Then  TimeString = "0:" & VB.Right("0" & Seconds, 2)
		If Seconds > 59 Then 
			Mins = Int(Seconds / 60)
			Seconds = Seconds - (Mins * 60)
			TimeString = VB.Right("0" & Str6(Mins), 2) & ":" & VB.Right("0" & Seconds, 2)
		End If
		If InStr(1, TimeString, " ") Then  Mid(TimeString, InStr(1, TimeString, " "), 1) = ""
	End Function

	Public Function FileLength() As Integer
		Dim ml As String = Space(30)
		Call mciSendString("set myfile time format ms", 0, 0, 0)
		Call mciSendString("status myfile length ", ml, 30, 0) ', , "mci: Calculate playtime"
		Return Val(ml)
	End Function

	Public Function FileLocation() As Integer
		Dim ml As String = Space(30)
		Call mciSendString("set myfile time format ms", 0, 0, 0)
		Call mciSendString("status myfile position ", ml, 30, 0) ', , "mci: Calculate playtime"
		Return Val(ml)
	End Function

End Module

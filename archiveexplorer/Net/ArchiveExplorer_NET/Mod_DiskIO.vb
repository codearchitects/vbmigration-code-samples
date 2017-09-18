' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module Mod_DiskIO

	Friend Structure FileTime
	
		Public dwLowDateTime As Integer
		Public dwHighDateTime As Integer
	End Structure
	
	Friend Structure SYSTEMTIME
	
		Public wYear As Short
		Public wMonth As Short
		Public wDayOfWeek As Short
		Public wDay As Short
		Public wHour As Short
		Public wMinute As Short
		Public wSecond As Short
		Public wMilliseconds As Short
	End Structure

	Private Const FILE_SHARE_READ As Integer = &H1I
	Private Const FILE_SHARE_WRITE As Integer = &H2I
	Private Const OPEN_EXISTING As Integer = &H3I
	Private Const GENERIC_WRITE As Integer = &H40000000I
	Private Const GENERIC_READ As Integer = &H80000000I
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'CreateFile' unamanged method with the following .NET member(s): System.IO.File , System.IO.FileInfo 
	Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal NoSecurity As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetFileTime' unamanged method with the following .NET member(s): System.IO.Directory.GetCreationTime, System.IO.Directory.GetLastAccessTime, System.IO.Directory.GetLastWriteTime, System.IO.DirectoryInfo.CreationTime, System.IO.DirectoryInfo.LastAccessTime, System.IO.DirectoryInfo.LastWriteTime, System.IO.File.GetCreationTime, System.IO.File.GetLastAccessTime, System.IO.File.GetLastWriteTime, System.IO.FileInfo.CreationTime, System.IO.FileInfo.LastAccessTime, System.IO.FileInfo.LastWriteTime
	Private Declare Function GetFileTime Lib "kernel32" (ByVal hFile As Integer, ByRef lpCreationTime As Mod_DiskIO.FileTime, ByRef lpLastAccessTime As Mod_DiskIO.FileTime, ByRef lpLastWriteTime As Mod_DiskIO.FileTime) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetFileTime' unamanged method with the following .NET member(s): System.IO.Directory.SetCreationTime, System.IO.Directory.SetLastAccessTime, System.IO.Directory.SetLastWriteTime, System.IO.DirectoryInfo.CreationTime, System.IO.DirectoryInfo.LastAccessTime, System.IO.DirectoryInfo.LastWriteTime, System.IO.File.SetCreationTime, System.IO.File.SetLastAccessTime, System.IO.File.SetLastWriteTime, System.IO.FileInfo.CreationTime, System.IO.FileInfo.LastAccessTime, System.IO.FileInfo.LastWriteTime
	Private Declare Function SetFileTime Lib "kernel32" (ByVal hFile As Integer, ByRef lpCreationTime As Mod_DiskIO.FileTime, ByRef lpLastAccessTime As Mod_DiskIO.FileTime, ByRef lpLastWriteTime As Mod_DiskIO.FileTime) As Integer
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'FileTimeToSystemTime' unamanged method with the following .NET member(s): System.DateTime.ToUniversalTime
	Private Declare Function FileTimeToSystemTime Lib "kernel32" (ByRef lpFileTime As Mod_DiskIO.FileTime, ByRef lpSystemTime As Mod_DiskIO.SYSTEMTIME) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SystemTimeToFileTime' unamanged method with the following .NET member(s): System.DateTime.ToFileTime
	Private Declare Function SystemTimeToFileTime Lib "kernel32" (ByRef lpSystemTime As Mod_DiskIO.SYSTEMTIME, ByRef lpFileTime As Mod_DiskIO.FileTime) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'FileTimeToLocalFileTime' unamanged method with the following .NET member(s): System.DateTime.ToFileTime
	Private Declare Function FileTimeToLocalFileTime Lib "kernel32" (ByRef lpFileTime As Mod_DiskIO.FileTime, ByRef lpLocalFileTime As Mod_DiskIO.FileTime) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'LocalFileTimeToFileTime' unamanged method with the following .NET member(s): System.DateTime.ToFileTimeUtc
	Private Declare Function LocalFileTimeToFileTime Lib "kernel32" (ByRef lpLocalFileTime As Mod_DiskIO.FileTime, ByRef lpFileTime As Mod_DiskIO.FileTime) As Integer
	Private Declare Function DosDateTimeToFileTime Lib "kernel32" (ByVal wFatDate As Integer, ByVal wFatTime As Integer, ByRef lpFileTime As Mod_DiskIO.FileTime) As Integer
	Private Declare Function FileTimeToDosDateTime Lib "kernel32" (ByRef lpFileTime As Mod_DiskIO.FileTime, ByVal lpFatDate As Integer, ByVal lpFatTime As Integer) As Integer
	
	Private Const m_LocalTimes As Boolean = True
	Private PathDilimiter As String = ""
	
	Public Function GetFileDate(ByVal FileName As String, ByRef FDate As Short, ByRef FTime As Short) As Boolean
		Dim hFile As Integer 'Get file created/modified/access times
		Dim fCreated As Mod_DiskIO.FileTime 'Returns True on success
		Dim fModified As Mod_DiskIO.FileTime
		Dim fAccessed As Mod_DiskIO.FileTime 'Note:  Accessing a file with this function
		Dim FilTime As Mod_DiskIO.FileTime '          will modify its File Access Time
		Dim SysTime As Mod_DiskIO.SYSTEMTIME
		Dim FD As Integer
		Dim FT As Integer
		
		hFile = CreateFile(FileName, GENERIC_READ, FILE_SHARE_READ Or FILE_SHARE_WRITE, 0%, OPEN_EXISTING, 0%, 0%)
		If hFile <> 0 Then 
			GetFileDate = (GetFileTime(hFile, fCreated, fAccessed, fModified) <> 0)
			CloseHandle(hFile)
			
			If m_LocalTimes Then  'Convert FILETIMEs to Local
				FileTimeToLocalFileTime(fModified, FilTime)
				fModified = FilTime
			End If
			FileTimeToSystemTime(fModified, SysTime) 'Convert FILETIMEs to Dates
			With SysTime
				FD = (.wYear - 1980) * 2 ^ 9
				FD = FD + (.wMonth * 2 ^ 5)
				FD += .wDay
				FT = .wHour * 2 ^ 11
				FT = FT + (.wMinute * 2 ^ 5)
				FT += .wSecond
			End With
		End If
		If FD > 32767 Then  FDate = FD - &HFFFF% - 1 Else FDate = FD
		If FT > 32767 Then  FTime = FT - &HFFFF% - 1 Else FTime = FT
	End Function

	Public Function SetFileDate(ByVal FileName As String, ByVal dCreated As Date, ByVal dModified As Date, ByVal dAccessed As Date) As Boolean
		Dim hFile As Integer
		Dim fCreated As Mod_DiskIO.FileTime
		Dim fModified As Mod_DiskIO.FileTime
		Dim fAccessed As Mod_DiskIO.FileTime
		Dim FilTime As Mod_DiskIO.FileTime
		Dim SysTime As Mod_DiskIO.SYSTEMTIME
		
		With SysTime 'Convert Dates to FILETIMEs
			.wYear = Year(dCreated)
			.wMonth = Month(dCreated)
			.wDay = VB.Day(dCreated)
			.wHour = Hour(dCreated)
			.wMinute = Minute(dCreated)
			.wSecond = Second(dCreated)
		End With
		SystemTimeToFileTime(SysTime, fCreated)
		
		With SysTime
			.wYear = Year(dModified)
			.wMonth = Month(dModified)
			.wDay = VB.Day(dModified)
			.wHour = Hour(dModified)
			.wMinute = Minute(dModified)
			.wSecond = Second(dModified)
		End With
		SystemTimeToFileTime(SysTime, fModified)
		
		With SysTime
			.wYear = Year(dAccessed)
			.wMonth = Month(dAccessed)
			.wDay = VB.Day(dAccessed)
			.wHour = Hour(dAccessed)
			.wMinute = Minute(dAccessed)
			.wSecond = Second(dAccessed)
		End With
		SystemTimeToFileTime(SysTime, fAccessed)
		
		If m_LocalTimes Then  'Convert FILETIMEs from Local
			LocalFileTimeToFileTime(fCreated, FilTime)
			fCreated = FilTime
			LocalFileTimeToFileTime(fModified, FilTime)
			fModified = FilTime
			LocalFileTimeToFileTime(fAccessed, FilTime)
			fAccessed = FilTime
		End If
		
		hFile = CreateFile(FileName, GENERIC_WRITE, FILE_SHARE_READ Or FILE_SHARE_WRITE, 0%, OPEN_EXISTING, 0%, 0%)
		If hFile <> 0 Then 
			SetFileDate = (SetFileTime(hFile, fCreated, fAccessed, fModified) <> 0)
			CloseHandle(hFile)
		End If
		
	End Function

	Public Function SetUnZippedFileDate(ByVal FileName As String, ByVal FDate As Short, ByVal FTime As Short) As Boolean
		Dim dCreated As Date
		Dim dModified As Date
		Dim dAccessed As Date
		dModified = GetZipDate(FDate, FTime)
		dCreated = dModified
		dAccessed = Now
		Return SetFileDate(FileName, dCreated, dModified, dAccessed)
	End Function

	Public Function GetZipDate(ByVal FDate As Short, ByVal FTime As Short) As Date
		Dim fModified As Mod_DiskIO.FileTime
		Dim SysTime As Mod_DiskIO.SYSTEMTIME
		
		DosDateTimeToFileTime(FDate, FTime, fModified)
		FileTimeToSystemTime(fModified, SysTime)
		With SysTime
			GetZipDate = CDate6(Format6(.wMonth) & "/" & Format6(.wDay) & "/" & Format6(.wYear) & " " & Format6(.wHour) & ":" & Format6(.wMinute, "00") & ":" & Format6(.wSecond, "00"))
		End With
		
	End Function

	'This function is used to write a file
	'It will overwrite existing file without prompting
	'It sets the filedate and time and checks if the directories exist
	Public Function Write_File(ByVal FileName As String, ByRef PathName As String, ByVal Data() As Byte, ByVal FDate As Short, ByVal FTime As Short) As Short
		Dim FLnum As Integer
		Dim TotName As String = ""
		If PathDilimiter = "" Then  PathDilimiter = GetPathdilimiter()
		If VB.Right(PathName, 1) <> "\" And VB.Right(PathName, 1) <> "/" Then  PathName &= PathDilimiter
		TotName = PathName & FileName
		If CreatePath(mbStripDirName(TotName)) = False Then 
			'room for error message
		End If
		If Dir6(TotName, FileAttribute.Normal) <> "" Then 
			On Error Resume Next 
			Kill(TotName)
		End If
		FLnum = FreeFile6()
		FileOpen6(FLnum, TotName, OpenMode.Binary, OpenAccess.Write, OpenShare.Default, -1)
		FilePut6(FLnum, Data)
		FileClose6(FLnum)
		If FDate <> 0 Or FTime <> 0 Then 
			If SetUnZippedFileDate(TotName, FDate, FTime) = False Then 
				'room for error message
			End If
		End If
	End Function

	Public Function CreatePath(ByVal DestPath As String) As Boolean
		Dim BackPos As Short
		Dim ForePos As Short
		Dim Temp As String = ""
		Dim tmp As String = ""
		Dim ThisDir As String = ""
		
		If PathDilimiter = "" Then  PathDilimiter = GetPathdilimiter()
		DestPath = Replace(DestPath, "\", PathDilimiter) 'set dilimiters in the right direction
		DestPath = Replace(DestPath, "/", PathDilimiter) 'set dilimiters in the right direction
		'-------------------------------------------------------
		'- Add slash to end of path if not there already
		'-------------------------------------------------------
		If VB.Right(DestPath, 1) <> PathDilimiter Then  DestPath &= PathDilimiter
		
		'-------------------------------------------------------
		'- Quick check on existance if destination path
		'-------------------------------------------------------
		Temp = Dir6(VB.Left(DestPath, Len6(DestPath) - 1), FileAttribute.Directory)
		If Temp <> "" Then  Return True
		
		ThisDir = CurDir6()
		'-------------------------------------------------------
		'- Change to the root dir of the drive
		'-------------------------------------------------------
		On Error Resume Next 
		ChDrive(DestPath)
		If Err.Number <> 0 Then  GoTo errorOut
		
		ChDir(PathDilimiter)
		
		'-------------------------------------------------------
		'- Attempt to make each directory, then change to it
		'-------------------------------------------------------
		BackPos = 3
		ForePos = InStr(4, DestPath, PathDilimiter)
		Do While ForePos <> 0
			Temp = Mid(DestPath, BackPos + 1, ForePos - BackPos - 1)
			tmp = Dir6(Temp, FileAttribute.Directory)
			If tmp = "" Then 
				Err.Number = 0
				MkDir(Temp)
				If Err.Number <> 0 And Err.Number <> 75 Then  GoTo errorOut
			End If
			Err.Number = 0
			ChDir(Temp)
			If Err.Number <> 0 Then  GoTo errorOut
			BackPos = ForePos
			ForePos = InStr(BackPos + 1, DestPath, PathDilimiter)
		Loop
		ChDir(ThisDir)
		Return True
		
errorOut:
		MsgBox6("Error While Attempting to Create Directories on Destination Drive.", 48, "SETUP")
		ChDir(ThisDir)
		Return False
	End Function

	'----------------------------------------------------------
	'This function is used to retrieve a pathname from a filename
	'input
	'Stripfile = Filename with or without pathname
	'return
	'StripDirName = Pathname
	'----------------------------------------------------------
	Private Function mbStripDirName(ByRef Stripfile As String) As String
		
		Dim Counter As Short
		Dim Stripped As String = ""
		On Error Resume Next 
		If PathDilimiter = "" Then  PathDilimiter = GetPathdilimiter()
		Stripfile = Replace(Stripfile, "\", PathDilimiter) 'set dilimiters in the right direction
		Stripfile = Replace(Stripfile, "/", PathDilimiter) 'set dilimiters in the right direction
		
		If InStr(Stripfile, PathDilimiter) > 0 Then 
			For Counter = Len6(Stripfile) To 1 Step -1
				If Mid(Stripfile, Counter, 1) = PathDilimiter Then 
					Stripped = VB.Left(Stripfile, Counter)
					Exit For
				End If
			Next
		ElseIf InStr(Stripfile, ":") = 2 Then 
			Stripped = CurDir6(Stripfile)
			If Len6(Stripped) = 0 Then 
				Stripped = CurDir6()
			End If
		Else
			Stripped = CurDir6()
		End If
		
		If VB.Right(Stripped, 1) <> PathDilimiter Then 
			Stripped &= PathDilimiter
		End If
		Return UCase(Stripped)
	End Function

	Private Function GetPathdilimiter() As String
		Dim Temp As String = CurDir6()
		If InStr(Temp, "\") > 0 Then 
			Return "\"
		Else
			Return "/"
		End If
	End Function

End Module

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure DirInfo

	Public fNAME As String
	Public fDATE As String
	Public fSize As String
	Public FullPath As String
End Structure

Friend Structure FILETIME

	Public dwLowDateTime As Integer
	Public dwHighDateTime As Integer
End Structure

Friend Module Module1d

	Public DirQUE As VB6Array(Of String)
	' UPGRADE_INFO (#0501): The 'SetVolumeLabel' member isn't used anywhere in current application.
	Public Declare Function SetVolumeLabel Lib "kernel32.dll" Alias "SetVolumeLabelA" (ByVal lpRootPathName As String, ByVal lpVolumeName As String) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetLogicalDriveStrings' unamanged method with the following .NET member(s): System.Environment.GetLogicalDrives, System.IO.Directory.GetLogicalDrives
	Private Declare Function GetLogicalDriveStrings Lib "kernel32" Alias "GetLogicalDriveStringsA" (ByVal nBufferLength As Integer, ByVal lpBuffer As String) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDrivetype' unamanged method with the following .NET member(s): System.Management.ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"").Get, System.Management.ManagementObject.Properties, System.IO.DriveInfo.DriveType
	Private Declare Function GetDrivetype Lib "kernel32" Alias "GetDriveTypeA" (ByVal nDrive As String) As Integer
	' UPGRADE_INFO (#0501): The 'GetLogicalDrives' member isn't used anywhere in current application.
	Public Declare Function GetLogicalDrives Lib "kernel32.dll" () As Integer
	Public Declare Function GetVolumeInformation Lib "kernel32.dll" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'FindFirstFile' unamanged method with the following .NET member(s): System.IO.Directory.Exists, System.IO.Directory.GetDirectories, System.IO.Directory.GetFileSystemEntries, System.IO.Directory.GetFiles, System.IO.DirectoryInfo.Exists, System.IO.DirectoryInfo.GetDirectories, System.IO.DirectoryInfo.GetFileSystemInfos, System.IO.DirectoryInfo.GetFiles, System.IO.File.Exists, System.IO.FileInfo.Exists
	Public Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'FindNextFile' unamanged method with the following .NET member(s): System.IO.Directory.GetDirectories, System.IO.Directory.GetFileSystemEntries, System.IO.Directory.GetFiles, System.IO.DirectoryInfo.GetDirectories, System.IO.DirectoryInfo.GetFileSystemInfos, System.IO.DirectoryInfo.GetFiles
	Public Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" (ByVal hFindFile As Integer, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
	Friend Structure WIN32_FIND_DATA
	
		Public dwFileAttributes As Integer
		Public ftCreationTime As FILETIME
		Public ftLastAccessTime As FILETIME
		Public ftLastWriteTime As FILETIME
		Public nFileSizeHigh As Integer
		Public nFileSizeLow As Integer
		Public dwReserved0 As Integer
		Public dwReserved1 As Integer
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=260)> _
		Public cFileName As VB6FixedString
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=14)> _
		Public cAlternate As VB6FixedString
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			cFileName = New VB6FixedString(260)
			cAlternate = New VB6FixedString(14)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As WIN32_FIND_DATA
			Dim copy As WIN32_FIND_DATA = Me
			copy.cFileName.Value = Me.cFileName.Value
			copy.cAlternate.Value = Me.cAlternate.Value
			Return copy
		End Function
	
	#End Region
	
	End Structure
	
	' UPGRADE_INFO (#0501): The 'FILE_ATTRIBUTE_DIRECTORY' member isn't used anywhere in current application.
	Public Const FILE_ATTRIBUTE_DIRECTORY As Short = &H10S
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetFileAttributes' unamanged method with the following .NET member(s): System.IO.Directory.GetAttributes, System.IO.File.GetAttributes, System.IO.FileSystemInfo.Attributes
	Public Declare Function GetFileAttributes Lib "kernel32.dll" Alias "GetFileAttributesA" (ByVal lpFileName As String) As Integer

	Private Const DRIVE_CDROM As Short = 5
	' UPGRADE_INFO (#0501): The 'DRIVE_FIXED' member isn't used anywhere in current application.
	Private Const DRIVE_FIXED As Short = 3
	' UPGRADE_INFO (#0501): The 'DRIVE_RAMDISK' member isn't used anywhere in current application.
	Private Const DRIVE_RAMDISK As Short = 6
	' UPGRADE_INFO (#0501): The 'DRIVE_REMOTE' member isn't used anywhere in current application.
	Private Const DRIVE_REMOTE As Short = 4
	' UPGRADE_INFO (#0501): The 'DRIVE_REMOVABLE' member isn't used anywhere in current application.
	Private Const DRIVE_REMOVABLE As Short = 2
	Public Function GetDriveListing() As String()
		Dim sDrives As String = String6(255, 0)
		Dim x() As String
		GetLogicalDriveStrings(255, sDrives)
		sDrives = Mid(sDrives, 1, InStrRev(sDrives, "\"))
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'tmp'. Consider using the SetDefaultMember6 helper method.
		tmp = Split(sDrives, Chr6(0))
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Y'. Consider using the GetDefaultMember6 helper method.
		For Y = 0 To UBound6(tmp)
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Y'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tmp(Y)'. Consider using the GetDefaultMember6 helper method.
			If GetDrivetype(tmp(Y)) = DRIVE_CDROM Then 
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Y'. Consider using the GetDefaultMember6 helper method.
				ReDim Preserve x(Y)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Y'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tmp(Y)'. Consider using the GetDefaultMember6 helper method.
				x(Y) = tmp(Y)
			End If
		Next
		Return x
	End Function

	Public Function GetDriveSerial(ByVal driveroot As String) As Integer
		Dim x As String = ""
		Dim Y As Integer
		' UPGRADE_INFO (#0501): The 'strVoleSerial' member isn't used anywhere in current application.
		Dim strVoleSerial As Integer
		GetVolumeInformation(driveroot, x, 255, GetDriveSerial, 255, &H1, x, Y)
	End Function
	
	Public Function GetVolumeLabel(ByVal driveroot As String) As String
		' UPGRADE_INFO (#0501): The 'x' member isn't used anywhere in current application.
		Dim x As String = ""
		' UPGRADE_INFO (#0501): The 'Y' member isn't used anywhere in current application.
		Dim Y As Integer
		' UPGRADE_INFO (#0501): The 'strVoleSerial' member isn't used anywhere in current application.
		Dim strVoleSerial As Integer
		GetVolumeLabel = String6(255, " ")
		' UPGRADE_INFO (#0501): The 'strFileSysFags' member isn't used anywhere in current application.
		Dim strFileSysFags As String = ""
		' UPGRADE_INFO (#0501): The 'strFileSysNameBuff' member isn't used anywhere in current application.
		Dim strFileSysNameBuff As String = ""
		' UPGRADE_INFO (#0501): The 'lngcow' member isn't used anywhere in current application.
		Dim lngcow As Integer
		
		'GetVolumeInformation( "C:\\", szLabel, 255, NULL, &dwMaxLength, &dwFlags, szSysN, 255 );
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow'. Consider using the GetDefaultMember6 helper method.
		Debug.WriteLine(GetVolumeInformation(driveroot, GetVolumeLabel, 255, VariantType.Null, 255, &H1, cow, 255))
		Return Replace(Trim(GetVolumeLabel), Chr6(0), "")
		
	End Function
	
	Public Sub EnumDirs(ByVal search As Object, ByVal fpath As Object, ByRef retarr() As DirInfo)
	' UPGRADE_INFO (#0561): The 'search' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0561): The 'fpath' symbol was defined without an explicit "As" clause.
		'Define Variables
		Dim FindData As New WIN32_FIND_DATA(True)
		Dim fNAME As String = ""
		Dim fHand As Integer
		Dim filecnt As Integer = 0
		'Begin by getting a filehandle by passing fpath as our path and FindData as
		'our data structure to fill.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'fpath'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'search'. Consider using the GetDefaultMember6 helper method.
		fHand = FindFirstFile(fpath & search, FindData)
		'Remove null chars from FindData.cFileName
		fNAME = Trim(Replace(FindData.cFileName.Value, Chr6(0), ""))
		'Set our filecounter to 0
		'FName will never be empty, so when it is empty we are done with the loop.
		Do While fNAME <> ""
			If fNAME = "." Then  GoTo cowgirl
			If fNAME = ".." Then  GoTo cowgirl
			'ReDim Preserve our array
			ReDim Preserve retarr(filecnt)
			
			'Set our new index to the filename
			retarr(filecnt).fNAME = fNAME
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'fpath'. Consider using the GetDefaultMember6 helper method.
			retarr(filecnt).FullPath = fpath & fNAME
			retarr(filecnt).fDATE = FileDateTime6(retarr(filecnt).FullPath)

			Select Case GetFileAttributes(retarr(filecnt).FullPath)
			Case 16
				retarr(filecnt).fSize = "-"
			Case 17
				retarr(filecnt).fSize = "-"
				
			Case Else
				retarr(filecnt).fSize = FileLen(retarr(filecnt).FullPath)
			End Select
cowgirl:
			'Empty our FindData.cFileName structure so we can recieve more data.
			FindData.cFileName.Value = Chr6(0)
			
			'Call FindNextFile passing our filehandle and our data structure.
			Call FindNextFile(fHand, FindData)
			
			'Remove the null chars from our filename
			fNAME = Trim(Replace(FindData.cFileName.Value, Chr6(0), ""))
			
			'Increment the counter.
			
			filecnt += 1
		Loop
		
	End Sub

End Module

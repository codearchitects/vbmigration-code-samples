Attribute VB_Name = "Module1d"
Public DirQUE() As String
Public Declare Function SetVolumeLabel Lib "kernel32.dll" Alias "SetVolumeLabelA" (ByVal lpRootPathName As String, ByVal lpVolumeName As String) As Long
Private Declare Function GetLogicalDriveStrings Lib "kernel32" Alias "GetLogicalDriveStringsA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long
Private Declare Function GetDriveType Lib "kernel32" Alias "GetDriveTypeA" (ByVal nDrive As String) As Long
Public Declare Function GetLogicalDrives Lib "kernel32.dll" () As Long
Public Declare Function GetVolumeInformation Lib "kernel32.dll" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Long, lpVolumeSerialNumber As Long, lpMaximumComponentLength As Long, lpFileSystemFlags As Long, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Long) As Long
 
Public Type DirInfo
    fNAME As String
    fDATE As String
    fSize As String
    FullPath As String
End Type
Public Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, _
       lpFindFileData As WIN32_FIND_DATA) As Long
   Public Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" (ByVal hFindFile As Long, _
       lpFindFileData As WIN32_FIND_DATA) As Long
   Public Type FILETIME
           dwLowDateTime As Long
           dwHighDateTime As Long
   End Type
   Public Type WIN32_FIND_DATA
           dwFileAttributes As Long
           ftCreationTime As FILETIME
           ftLastAccessTime As FILETIME
           ftLastWriteTime As FILETIME
           nFileSizeHigh As Long
           nFileSizeLow As Long
           dwReserved0 As Long
           dwReserved1 As Long
           cFileName As String * 260
           cAlternate As String * 14
   End Type
   Public Const FILE_ATTRIBUTE_DIRECTORY = &H10
   Public Declare Function GetFileAttributes Lib "kernel32.dll" Alias "GetFileAttributesA" (ByVal lpFileName As String) As Long
 
 
Const DRIVE_CDROM = 5
Const DRIVE_FIXED = 3
Const DRIVE_RAMDISK = 6
Const DRIVE_REMOTE = 4
Const DRIVE_REMOVABLE = 2
Public Function GetDriveListing() As String()
    Dim sDrives As String
    sDrives = String(255, 0)
    Dim x() As String
    GetLogicalDriveStrings 255, sDrives
    sDrives = Mid(sDrives, 1, InStrRev(sDrives, "\"))
    tmp = Split(sDrives, Chr(0))
    For Y = 0 To UBound(tmp)
        
        If GetDriveType(tmp(Y)) = DRIVE_CDROM Then
            ReDim Preserve x(0 To Y)
            x(Y) = tmp(Y)
        End If
    Next Y
    GetDriveListing = x
End Function

 Public Function GetDriveSerial(driveroot As String) As Long
    Dim x As String
    Dim Y As Long
    Dim strVoleSerial As Long
    GetVolumeInformation driveroot, x, 255, GetDriveSerial, 255, &H1, x, Y
 End Function
 Public Function GetVolumeLabel(driveroot As String) As String
    Dim x As String
    Dim Y As Long
    Dim strVoleSerial As Long
    GetVolumeLabel = String(255, " ")
    Dim strFileSysFags As String, strFileSysNameBuff As String
    Dim lngcow As Long

    'GetVolumeInformation( "C:\\", szLabel, 255, NULL, &dwMaxLength, &dwFlags, szSysN, 255 );
    Debug.Print GetVolumeInformation(driveroot, GetVolumeLabel, 255, vbNull, 255, &H1, cow, 255)
    GetVolumeLabel = Replace(Trim(GetVolumeLabel), Chr(0), "")
    
 End Function
   Public Sub EnumDirs(search, fpath, retarr() As DirInfo)
   'Define Variables
   Dim FindData As WIN32_FIND_DATA, fNAME As String
   Dim fHand As Long, filecnt As Long
   'Begin by getting a filehandle by passing fpath as our path and FindData as
   'our data structure to fill.
   fHand = FindFirstFile(fpath & search, FindData)
   'Remove null chars from FindData.cFileName
   fNAME = Trim(Replace(FindData.cFileName, Chr(0), ""))
   'Set our filecounter to 0
   filecnt = 0
   'FName will never be empty, so when it is empty we are done with the loop.
   Do While fNAME <> ""
        If fNAME = "." Then GoTo cowgirl
        If fNAME = ".." Then GoTo cowgirl
       'ReDim Preserve our array
       ReDim Preserve retarr(0 To filecnt)
   
       'Set our new index to the filename
       retarr(filecnt).fNAME = fNAME
       retarr(filecnt).FullPath = fpath & fNAME
       retarr(filecnt).fDATE = FileDateTime(retarr(filecnt).FullPath)

       
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
       FindData.cFileName = Chr(0)
   
       'Call FindNextFile passing our filehandle and our data structure.
       Call FindNextFile(fHand, FindData)
       
       'Remove the null chars from our filename
       fNAME = Trim(Replace(FindData.cFileName, Chr(0), ""))
   
       'Increment the counter.

       filecnt = filecnt + 1
   Loop
   
   End Sub

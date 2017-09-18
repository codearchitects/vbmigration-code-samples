' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Cls_Cab

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show the contents of an CAB-archive
	
	Friend Structure CabFileHeaderType
		Implements IVB6FileGetPut
	
		Public signature As Integer ' MSCF (cabinet file signature )
		Public HeadCRC As Integer 'CRC 32 of the cab header
		Public cbCabinet As Integer 'size of this cabinet file in bytes
		Public FolderCRC As Integer 'CRC 32 of the folder header
		Public coffFiles As Integer 'offset of the first CFFILE entry
		Public FilesCRC As Integer 'CRC 32 of the Files header
		Public versionMinor As Byte 'cabinet file format version, minor
		Public versionMajor As Byte 'cabinet file format version, major
		Public cFolders As Short 'number of CFFOLDER entries in this cabinet
		Public cFiles As Short 'number of CFFILE entries in this cabinet
		Public Flags As Short 'cabinet file option indicators
		'bit 0 = Has Previous Cab file
		'bit 1 = Has Next cab file
		'Bit 2 = reserve
		Public setID As Short 'must be the same for all cabinets in a set
		Public iCabinet As Short 'number of this cabinet file in a set
		'  cbCFHeader    As Integer     '(optional) size of per-cabinet reserved area
		'  cbCFFolder    As Byte        '(optional) size of per-folder reserved area
		'  cbCFData      As Byte        '(optional) size of per-datablock reserved area
		'  abReserve     As Byte        '(optional) per-cabinet reserved area
		'  szCabinetPrev As Byte        '(optional) name of previous cabinet file
		'  szDiskPrev    As Byte        '(optional) name of previous disk
		'  szCabinetNext As Byte        '(optional) name of next cabinet file
		'  szDiskNext    As Byte        '(optional) name of next disk
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As CabFileHeaderType
			Try
				FileGet6(fileNumber, struct.signature)
				FileGet6(fileNumber, struct.HeadCRC)
				FileGet6(fileNumber, struct.cbCabinet)
				FileGet6(fileNumber, struct.FolderCRC)
				FileGet6(fileNumber, struct.coffFiles)
				FileGet6(fileNumber, struct.FilesCRC)
				FileGet6(fileNumber, struct.versionMinor)
				FileGet6(fileNumber, struct.versionMajor)
				FileGet6(fileNumber, struct.cFolders)
				FileGet6(fileNumber, struct.cFiles)
				FileGet6(fileNumber, struct.Flags)
				FileGet6(fileNumber, struct.setID)
				FileGet6(fileNumber, struct.iCabinet)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.signature)
			FilePut6(fileNumber, Me.HeadCRC)
			FilePut6(fileNumber, Me.cbCabinet)
			FilePut6(fileNumber, Me.FolderCRC)
			FilePut6(fileNumber, Me.coffFiles)
			FilePut6(fileNumber, Me.FilesCRC)
			FilePut6(fileNumber, Me.versionMinor)
			FilePut6(fileNumber, Me.versionMajor)
			FilePut6(fileNumber, Me.cFolders)
			FilePut6(fileNumber, Me.cFiles)
			FilePut6(fileNumber, Me.Flags)
			FilePut6(fileNumber, Me.setID)
			FilePut6(fileNumber, Me.iCabinet)
		End Sub
	
	#End Region
	
	End Structure

	Friend Structure CFFolderType
		Implements IVB6FileGetPut
	
		Public coffCabStart As Integer 'offset of the first CFDATA block in this folder
		Public cCFData As Short '??number of CFDATA blocks in this folder
		Public typeCompress As Short 'compression type indicator
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As CFFolderType
			Try
				FileGet6(fileNumber, struct.coffCabStart)
				FileGet6(fileNumber, struct.cCFData)
				FileGet6(fileNumber, struct.typeCompress)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.coffCabStart)
			FilePut6(fileNumber, Me.cCFData)
			FilePut6(fileNumber, Me.typeCompress)
		End Sub
	
	#End Region
	
	End Structure

	Friend Structure CFFileType
	
		Public USize As Integer 'uncompressed size of this file in bytes
		Public UoffFolderStart As Integer 'uncompressed offset of this file in the folder
		Public IFolder As Short 'index into the CFFOLDER area
		'&h0000 = FIRST
		'&h0001 = NEXT
		'&hFFFE = SPLIT
		'&hFFFF = CONTINUED
		Public FDate As Short 'date stamp for this file
		Public FTime As Short 'time stamp for this file
		Public Attribs As Short 'attribute flags for this file
		'and &h0001 = READONLY
		'and &h0002 = HIDDEN
		'and &h0004 = SYSTEM
		'and &h0008 = VOLUME
		'and &h0010 = DIRECTORY
		'and &h0020 = ARCHIVE
		'szName is variable length string with Chr$(0) terminator
		'See GetInfo to see how seek is adjusted for block alignment
		Public FileName As String 'name of this file
	End Structure

	'Would have been nice if the Crc and
	'Compressed size were in CFFILE above
	
	Friend Structure CFDataType
	
		Public CRC32 As Integer 'checksum of this CFDATA entry
		Public CSize As Short 'number of compressed bytes in this block
		Public cbUncomp As Short 'number of uncompressed bytes in this block
		'  abReserve  As Byte    '(optional) per-datablock reserved area
		'  ab[cbData] As Byte    'compressed data bytes
	End Structure

	Friend Structure CabFileDataType
	
		Public USize As Integer 'uncompressed size of this file in bytes
		Public UoffFolderStart As Integer 'uncompressed offset of this file in the folder
		Public IFolder As Short 'index into the CFFOLDER area
		'&h0000 = FIRST
		'&h0001 = NEXT
		'&hFFFE = SPLIT
		'&hFFFF = CONTINUED
		Public FDate As Short 'date stamp for this file
		Public FTime As Short 'time stamp for this file
		Public Attribs As Short 'attribute flags for this file
		'and &h0001 = READONLY
		'and &h0002 = HIDDEN
		'and &h0004 = SYSTEM
		'and &h0008 = VOLUME
		'and &h0010 = DIRECTORY
		'and &h0020 = ARCHIVE
		'szName is variable length string with Chr$(0) terminator
		'See GetInfo to see how seek is adjusted for block alignment
		Public FileName As String 'name of this file
		Public CRC32 As Integer 'checksum of this CFDATA entry
		Public CSize As Short 'number of compressed bytes in this block
		Public cbUncomp As Short 'number of uncompressed bytes in this block
		Public DataOffSet As Integer 'start position if the compressed data
		Public Method As Short
		'  abReserve  As Byte    '(optional) per-datablock reserved area
		'  ab[cbData] As Byte    'compressed data bytes
	End Structure

	Private CabFiles() As Cls_Cab.CabFileDataType
	Private CabHead As Cls_Cab.CabFileHeaderType
	Private Const m_Unpack_Supported As Boolean = False
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim ByteVal As Byte
		Dim LN As Integer
		Dim X As Integer
		Dim CabFolder() As Cls_Cab.CFFolderType
		Dim CabReserve As Short
		Dim FolderReserve As Byte
		Dim dataReserve As Byte
		Dim CAbPrevName As String = ""
		Dim CabPrevDisk As String = ""
		Dim CabNextName As String = ""
		Dim CabNextDist As String = ""
		PackFileName = ZipName
		PackComments = ""
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		If LOF6(FileNum) < Len6(CabHead) Then 
			FileClose6(FileNum)
			Exit Function
		End If
		'get the end of central date
		FileGet6(FileNum, CabHead)
		If CabHead.signature = &H4643534D Then 
			PackFileType = CABFileType
			If (CabHead.Flags And 4) Then  'reserve
				FileGet6(FileNum, CabReserve) 'Reserved header space
				FileGet6(FileNum, FolderReserve) 'Reserved folder space
				FileGet6(FileNum, dataReserve) 'Reserved Datablock space
				If CabReserve > 0 Then 
					FileSeek6(FileNum, FileSeek6(FileNum) + CabReserve + 1) 'Skip reserved block
				End If
			End If
			If (CabHead.Flags And 1) Then  'Has Previous
				Do
					FileGet6(FileNum, ByteVal)
					If ByteVal = 0 Then  Exit Do
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'CAbPrevName' variable as a StringBuilder6 object.
					CAbPrevName &= Chr6(ByteVal)
				Loop
				Do
					FileGet6(FileNum, ByteVal)
					If ByteVal = 0 Then  Exit Do
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'CabPrevDisk' variable as a StringBuilder6 object.
					CabPrevDisk &= Chr6(ByteVal)
				Loop
			End If
			If (CabHead.Flags And 2) Then  'Has Next
				Do
					FileGet6(FileNum, ByteVal)
					If ByteVal = 0 Then  Exit Do
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'CabNextName' variable as a StringBuilder6 object.
					CabNextName &= Chr6(ByteVal)
				Loop
				Do
					FileGet6(FileNum, ByteVal)
					If ByteVal = 0 Then  Exit Do
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'CabNextDist' variable as a StringBuilder6 object.
					CabNextDist &= Chr6(ByteVal)
				Loop
			End If
			ReDim CabFolder(CabHead.cFolders)
			For X = 1 To CabHead.cFolders
				FileGet6(FileNum, CabFolder(X))
				If FolderReserve > 0 Then 
					FileSeek6(FileNum, FileSeek6(FileNum) + FolderReserve + 1) 'Skip reserved block
				End If
			Next
			ReDim CabFiles(CabHead.cFiles)
			If FileSeek6(FileNum) <> CabHead.coffFiles + 1 Then  FileSeek6(FileNum, CabHead.coffFiles + 1)
			PackTotFiles = CabHead.cFiles
			For X = 1 To PackTotFiles
				With CabFiles(X)
					FileGet6(FileNum, .USize)
					FileGet6(FileNum, .UoffFolderStart)
					FileGet6(FileNum, .IFolder)
					FileGet6(FileNum, .FDate)
					FileGet6(FileNum, .FTime)
					FileGet6(FileNum, .Attribs)
					Do
						FileGet6(FileNum, ByteVal)
						If ByteVal = 0 Then  Exit Do
						.FileName &= Chr6(ByteVal)
					Loop
					.Method = CabFolder(1).typeCompress
				End With
			Next
			'At this point the CFDatablock begin
			'These are compressed blocks from uncompressed blocks up to 32K
			'The files are stored into a buff of 32K until its full, After that the compression
			'starts. That's why there are no CRC-value of the independed files
			
			'        If Seek(FileNum) <> CabFolder(1).coffCabStart + 1 Then Seek #FileNum, CabFolder(1).coffCabStart + 1
			'        For X = 1 To PackTotFiles
			'            With CabFiles(X)
			'                Get #FileNum, , .CRC32
			'                Get #FileNum, , .CSize
			'                Get #FileNum, , .cbUncomp
			'                .DataOffSet = Seek(FileNum)
			'                .Method = CabFolder(1).typeCompress
			'                Seek #FileNum, Seek(FileNum) + .CSize
			'            End With
			'        Next
		End If
		'    Close FileNum
	End Function

	'Unzip as file and return 0 for good decompression or others for error
	Public Function UnPack(ByVal ZippedFile() As Boolean, ByVal ToPath As String) As Short
		
		Erase6(PackData)
	End Function

	Public Function Pack(ByVal ZipName As String, ByVal Files() As String, ByVal CompType As Short, ByVal CompLevel As Short, Optional ByVal IncludeDir As String = "") As Short
		
	End Function

	Public ReadOnly Property CanUnpack() As Boolean
		Get
			Return m_Unpack_Supported
	 	End Get
	End Property

	Public ReadOnly Property FileCount() As Integer
		Get
			Return PackTotFiles
	 	End Get
	End Property

	Public ReadOnly Property FileName(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return CabFiles(FileNum).FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			Return ""
	 	End Get
	End Property

	Public ReadOnly Property CommentsPack() As String
		Get
			Return ""
	 	End Get
	End Property

	Public ReadOnly Property IsDir(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			If (CabFiles(FileNum).Attribs And &H10) > 0 Then  Return True
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(CShort(CabFiles(FileNum).Method And &HF))
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return CabFiles(FileNum).CRC32
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return CabFiles(FileNum).CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return CabFiles(FileNum).USize
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return False
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GetZipDate(CabFiles(FileNum).FDate, CabFiles(FileNum).FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return "UnKnown"
	 	End Get
	End Property

	Public ReadOnly Property VersionMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return "Unknown"
	 	End Get
	End Property

	Public ReadOnly Property SystemNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return "Unknown"
	 	End Get
	End Property

	Public ReadOnly Property VersionNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Trim(CabHead.versionMajor & "." & CabHead.versionMinor)
	 	End Get
	End Property

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
	End Function

	Private Function DataSize() As Integer
		On Error Resume Next 
		DataSize = UBound6(PackData) + 1
		If Err.Number <> 0 Then 
			Err.Clear()
			Return 0
		End If
	End Function

	Private Function VersionTo(ByVal Version As Byte) As String
		Return Fix(Version / 10) & "." & CInt(Version) Mod 10
	End Function

	Private Function Methods(ByVal MethodType As Short) As String
		Select Case MethodType
		Case 0: Return "No Compression"
		Case 1: Return "MsZip"
		Case 2: Return "Quantum"
		Case 3: Return "Lzx"
		Case Else: Return "Unknown"
		End Select
	End Function

End Class

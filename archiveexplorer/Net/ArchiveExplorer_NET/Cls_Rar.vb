' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Cls_Rar

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show the contents of an RAR-archive
	
	Friend Structure BlockMarkerType
		Implements IVB6FileGetPut
	
		Public HEAD_CRC As Short 'CRC of the header
		Public HEAD_TYPE As Byte 'Header type
		Public HEAD_FLAGS As Short 'Flags
		Public HEAD_SIZE As Short 'Size of the header
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As BlockMarkerType
			Try
				FileGet6(fileNumber, struct.HEAD_CRC)
				FileGet6(fileNumber, struct.HEAD_TYPE)
				FileGet6(fileNumber, struct.HEAD_FLAGS)
				FileGet6(fileNumber, struct.HEAD_SIZE)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.HEAD_CRC)
			FilePut6(fileNumber, Me.HEAD_TYPE)
			FilePut6(fileNumber, Me.HEAD_FLAGS)
			FilePut6(fileNumber, Me.HEAD_SIZE)
		End Sub
	
	#End Region
	
	End Structure
	
	Friend Structure ArchiveHeaderType
	
		Public HEAD_CRC As Short 'CRC of fields HEAD_TYPE to RESERVED2
		Public HEAD_TYPE As Byte '&h73
		Public HEAD_FLAGS As Short '&h01    - Volume attribute (archive volume)
		'                                &h02    - Archive comment present
		'                                &h04    - Archive lock attribute
		'                                &h08    - Solid attribute (solid archive)
		'                                &h10 -Unused
		'                                &h20    - Authenticity information present
		'                                other bits in HEAD_FLAGS are reserved for internal use
		Public HEAD_SIZE As Short 'Archive header total size including archive comments
		Public reserved1 As Short 'Reserved
		Public reserved2 As Integer 'Reserved
		Public COMMENT As String 'present if (HEAD_FLAGS and &h02) <> 0
		
	End Structure
	
	Friend Structure FileHeaderType
	
		Public HEAD_CRC As Short 'CRC of fields from HEAD_TYPE to FILEATTR and file name
		Public HEAD_TYPE As Byte '&h74
		Public HEAD_FLAGS As Short '&h01 - file continued from previous volume
		'                                &h02 - file continued in next volume
		'                                &h04 - file encrypted with password
		'                                &h08 - file comment present
		'                                &h10 - information from previous files is used (solid flag)
		'                                       (for RAR 2.0 and later)
		'
		'                                bits 7 6 5 (for RAR 2.0 and later)
		'
		'                                     0 0 0    - dictionary size   64 Kb
		'                                     0 0 1    - dictionary size  128 Kb
		'                                     0 1 0    - dictionary size  256 Kb
		'                                     0 1 1    - dictionary size  512 Kb
		'                                     1 0 0    - dictionary size 1024 Kb
		'                                     1 0 1    - reserved
		'                                     1 1 0    - reserved
		'                                     1 1 1    - file is directory
		'
		'                                (HEAD_FLAGS And &h8000) == 1, because full block Size Is Head_Size + PACK_SIZE
		Public HEAD_SIZE As Integer 'File header full size including file name and comments
		Public CSize As Integer 'Compressed file size
		Public USize As Integer 'Unompressed file size
		Public Host_OS As Byte 'Operating system used for archiving
		'                                0 - MS DOS
		'                                1 - OS/2
		'                                2 - Win32
		'                                3 - Unix
		Public File_CRC As Integer 'CRC32 of the file
		Public FDateTime As Integer 'Date and time in standard MS DOS format
		Public FDate As Short 'Calculated data
		Public FTime As Short 'Calculated time
		Public VersionNeeded As Byte 'Minimum version need to extract
		Public Method As Byte 'Compression method
		Public FNameLen As Short 'Size of FileName
		Public Attrib As Integer 'File Attributes
		Public FileName As String 'File Name
		Public COMMENT As String 'present if (HEAD_FLAGS and &h08) <> 0
		Public DataOffSet As Integer 'Start position of packed data in archive
	End Structure
	
	Friend Structure CommentHeaderType
	
		Public HEAD_CRC As Short 'CRC of fields from HEAD_TYPE to COMM_CRC
		Public HEAD_TYPE As Byte '&h75
		Public HEAD_FLAGS As Short 'Bit flags
		Public HEAD_SIZE As Short 'Comment header size + comment size
		Public USize As Short 'Uncompressed comment size
		Public VerNeeded As Byte 'RAR version needed to extract comment
		Public Method As Byte 'Packing method
		Public COMM_CRC As Short 'Comment CRC
		Public COMMENT As String 'Comment text
	End Structure
	
	Friend Structure InfoHeaderType
	
		Public HEAD_CRC As Short 'Block CRC
		Public HEAD_TYPE As Byte 'Header type: 0x76
		Public HEAD_FLAGS As Short 'Bit flags
		Public HEAD_SIZE As Short 'Total block size
		Public INFO As String 'Other data
	End Structure
	
	Friend Structure SubblockType
	
		Public HEAD_CRC As Short 'Block CRC
		Public HEAD_TYPE As Byte 'Header type: 0x77
		Public HEAD_FLAGS As Short 'Bit flags
		'                                (HEAD_FLAGS & 0x8000) == 1, because full
		'                                block Size Is HEAD_SIZE + DATA_SIZE
		Public HEAD_SIZE As Short 'Total block size
		Public DATA_SIZE As Integer 'Total data size
		Public SUB_TYPE As Short 'Subblock type
		Public RESERVED As Byte 'Must be 0
		Public OtherFields As String 'Other fields depending on the subblock type
	End Structure

	Private RARArchHead As Cls_Rar.ArchiveHeaderType
	Private RARFiles() As Cls_Rar.FileHeaderType
	Private Const m_Unpack_Supported As Boolean = False
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim X As Integer
		Dim FileNum As Integer
		Dim ByteVal As Byte
		Dim TextBytes() As Byte
		Dim Bpointer As Short
		Dim Temp As Cls_Rar.BlockMarkerType
		Dim TempHead As Cls_Rar.ArchiveHeaderType
		Dim TempComment As Cls_Rar.CommentHeaderType
		Dim TempInfo As Cls_Rar.InfoHeaderType
		Dim TempSub As Cls_Rar.SubblockType
		Dim AddHeadSize As Integer
		PackFileName = ZipName
		PackComments = ""
		PackTotFiles = 0
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		If LOF6(FileNum) < 7 Then 
			FileClose6(FileNum)
			Exit Function
		End If
		'get the end of central date
		FileGet6(FileNum, Temp)
		If Temp.HEAD_CRC <> &H6152 Then  FileClose6(FileNum): Exit Function
		If Temp.HEAD_TYPE <> &H72 Then  FileClose6(FileNum): Exit Function
		If Temp.HEAD_FLAGS <> &H1A21 Then  FileClose6(FileNum): Exit Function
		If Temp.HEAD_SIZE <> &H7 Then  FileClose6(FileNum): Exit Function
		'Header OK  find out what type of header
		PackFileType = RARFileType
		Do
			If FileSeek6(FileNum) >= LOF6(FileNum) Then  Exit Do 'EOF
			FileGet6(FileNum, Temp)
			AddHeadSize = 0
			'        If Temp.HEAD_FLAGS And &H8000& <> 0 Then
			'            Get #FileNum, , AddHeadSize
			'        End If
			Select Case Temp.HEAD_TYPE
			Case &H72 'marker block    =   first block of the file
				'BlockMarker already read
			Case &H73 'archive header
				With TempHead
					.HEAD_CRC = Temp.HEAD_CRC
					.HEAD_TYPE = Temp.HEAD_TYPE
					.HEAD_FLAGS = Temp.HEAD_FLAGS
					.HEAD_SIZE = Temp.HEAD_SIZE + AddHeadSize
					FileGet6(FileNum, .reserved1)
					FileGet6(FileNum, .reserved2)
					If (.HEAD_FLAGS And 2) > 0 Then 
						ReDim TextBytes(100)
						Bpointer = 0
						Do
							FileGet6(FileNum, ByteVal)
							If ByteVal = 0 Then  Exit Do
							TextBytes(Bpointer) = ByteVal
							Bpointer += 1
							If Bpointer > UBound6(TextBytes) Then  ReDim Preserve TextBytes(Bpointer + 50)
						Loop
						ReDim Preserve TextBytes(Bpointer - 1)
						.COMMENT = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
					End If
				End With
				RARArchHead = TempHead
			Case &H74 'file header
				PackTotFiles += 1
				ReDim Preserve RARFiles(PackTotFiles)
				With RARFiles(PackTotFiles)
					.HEAD_CRC = Temp.HEAD_CRC
					.HEAD_TYPE = Temp.HEAD_TYPE
					.HEAD_FLAGS = Temp.HEAD_FLAGS
					.HEAD_SIZE = Temp.HEAD_SIZE + AddHeadSize
					FileGet6(FileNum, .CSize)
					FileGet6(FileNum, .USize)
					FileGet6(FileNum, .Host_OS)
					FileGet6(FileNum, .File_CRC)
					FileGet6(FileNum, .FDateTime)
					FileGet6(FileNum, .VersionNeeded)
					FileGet6(FileNum, .Method)
					FileGet6(FileNum, .FNameLen)
					FileGet6(FileNum, .Attrib)
					ReDim TextBytes(Int2Lng(.FNameLen) - 1)
					FileGet6(FileNum, TextBytes)
					.FileName = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
					If (.HEAD_FLAGS And 2) > 0 Then 
						ReDim TextBytes(100)
						Bpointer = 0
						Do
							FileGet6(FileNum, ByteVal)
							If ByteVal = 0 Then  Exit Do
							TextBytes(Bpointer) = ByteVal
							Bpointer += 1
							If Bpointer > UBound6(TextBytes) Then  ReDim Preserve TextBytes(Bpointer + 50)
						Loop
						ReDim Preserve TextBytes(Bpointer - 1)
						.COMMENT = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
					End If
					.DataOffSet = FileSeek6(FileNum)
					.FDate = Lng2Int((.FDateTime And &HFFFF0000) \ &HFFFF%)
					.FTime = Lng2Int(.FDateTime And &HFFFF%)
					FileSeek6(FileNum, FileSeek6(FileNum) + .CSize)
				End With
			Case &H75 'comment header
				With TempComment
					.HEAD_CRC = Temp.HEAD_CRC
					.HEAD_TYPE = Temp.HEAD_TYPE
					.HEAD_FLAGS = Temp.HEAD_FLAGS
					.HEAD_SIZE = Temp.HEAD_SIZE + AddHeadSize
					FileGet6(FileNum, .USize)
					FileGet6(FileNum, .VerNeeded)
					FileGet6(FileNum, .Method)
					FileGet6(FileNum, .COMM_CRC)
					ReDim TextBytes(Int2Lng(.HEAD_SIZE - 13) - 1)
					FileGet6(FileNum, TextBytes)
					.COMMENT = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End With
			Case &H76 'extra information
				With TempInfo
					.HEAD_CRC = Temp.HEAD_CRC
					.HEAD_TYPE = Temp.HEAD_TYPE
					.HEAD_FLAGS = Temp.HEAD_FLAGS
					.HEAD_SIZE = Temp.HEAD_SIZE + AddHeadSize
					ReDim TextBytes(Int2Lng(.HEAD_SIZE - 7) - 1)
					FileGet6(FileNum, TextBytes)
					.INFO = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End With
			Case &H77 'subblock
				With TempSub
					.HEAD_CRC = Temp.HEAD_CRC
					.HEAD_TYPE = Temp.HEAD_TYPE
					.HEAD_FLAGS = Temp.HEAD_FLAGS
					.HEAD_SIZE = Temp.HEAD_SIZE + AddHeadSize
					FileGet6(FileNum, .DATA_SIZE)
					FileGet6(FileNum, .SUB_TYPE)
					FileGet6(FileNum, .RESERVED)
					ReDim TextBytes(Int2Lng(.HEAD_SIZE) - 14 - 1)
					FileGet6(FileNum, TextBytes)
					.OtherFields = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End With
			Case &H78 'recovery record
			Case Else
				'Unknown Headertype
			End Select
		Loop
		FileClose6(FileNum)
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
			Return RARFiles(FileNum).FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			Return RARFiles(FileNum).COMMENT
	 	End Get
	End Property

	Public ReadOnly Property CommentsPack() As String
		Get
			Return RARArchHead.COMMENT
	 	End Get
	End Property

	Public ReadOnly Property IsDir(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			If (RARFiles(FileNum).HEAD_FLAGS And 224) = 224 Then  Return True
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(CShort(RARFiles(FileNum).Method))
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return RARFiles(FileNum).File_CRC
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return RARFiles(FileNum).CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return RARFiles(FileNum).USize
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ((RARFiles(FileNum).HEAD_FLAGS And &H4) > 0)
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GetZipDate(RARFiles(FileNum).FDate, RARFiles(FileNum).FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return SystemName(RARFiles(FileNum).Host_OS)
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
			Return VersionTo(RARFiles(FileNum).VersionNeeded)
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

	Private Function SystemName(ByVal System As Byte) As String
		Select Case System
		Case 0: Return "MS-DOS"
		Case 1: Return "Win32"
		Case 2: Return "OS/2"
		Case 3: Return "UNIX"
		Case Else: Return "unKnown"
		End Select
	End Function

	Private Function VersionTo(ByVal Version As Byte) As String
		Return Fix(Version / 10) & "." & CInt(Version) Mod 10
	End Function

	Private Function Methods(ByVal MethodType As Short) As String
		Select Case MethodType
		Case &H30: Return "No Compression"
		Case &H31: Return "Fastest"
		Case &H32: Return "Fast"
		Case &H33: Return "Normal"
		Case &H34: Return "Good"
		Case &H35: Return "Maximum"
		Case Else: Return "Unknown"
		End Select
	End Function

	Private Function Lng2Int(ByVal LngValue As Integer) As Short
		If LngValue > 32767 Then  Lng2Int = LngValue - &HFFFF% - 1 Else Return LngValue
	End Function

	Private Function Int2Lng(ByVal Value As Short) As Integer
		If Value < 0 Then  Int2Lng = &HFFFF% + Value + 1 Else Return Value
	End Function

End Class

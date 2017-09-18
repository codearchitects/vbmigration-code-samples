' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Cls_Arj

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show the contents of an ARJ-archive
	
	Friend Structure ARJmainheader
	
		Public Id As Short
		Public Headersize As Short
		Public Firsthdrsize As Byte
		Public Version As Byte
		Public Minversion As Byte
		Public Archiveos As Byte
		Public Flags As Byte
		Public Secversion As Byte
		Public Filetype As Byte
		Public X_reserved As Byte
		Public Createtime As Integer
		Public Modifytime As Integer
		Public FileSize As Integer
		Public Secenvpos As Integer
		Public Filespecpos As Short
		Public Secenvlength As Short
		Public X_notused As Short
	End Structure
	
	Friend Structure ARJlocalheader
	
		Public Id As Short
		Public Headersize As Short
		Public Firsthdrsize As Byte
		Public Version As Byte
		Public Minversion As Byte
		Public Archiveos As Byte
		Public Flags As Byte
		Public Method As Byte
		Public Filetype As Byte
		Public X_reserved As Byte
		Public Datemodify As Integer
		Public Sizecompr As Integer
		Public Sizeorig As Integer
		Public Origcrc As Integer
		Public Filespecpos As Short
		Public Accessmode As Short
		Public Hostdata As Short
	End Structure
	
	Friend Structure ARJFileType
	
		Public Id As Short
		Public Headersize As Short
		Public Firsthdrsize As Byte
		Public Version As Byte
		Public Minversion As Byte
		Public Archiveos As Byte
		Public Flags As Byte
		Public Method As Byte
		Public Filetype As Byte
		Public X_reserved As Byte
		Public FTime As Short
		Public FDate As Short
		Public Sizecompr As Integer
		Public Sizeorig As Integer
		Public Origcrc As Integer
		Public Filespecpos As Short
		Public Accessmode As Short
		Public Hostdata As Short
		Public StartSplit As Integer
		Public FileName As String
		Public FileComment As String
		Public HeaderCRC As Integer
		Public ExtHeadSize As Short
		Public extHeader As String
		Public ExtHeadCRC As Integer
		Public DataOffSet As Integer
	End Structure

	Private ArjFileData() As Cls_Arj.ARJFileType
	Private Const m_Unpack_Supported As Boolean = False
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim LngVal As Integer
		Dim IntVal As Short
		Dim IntVal2 As Short
		Dim ByteVal As Byte
		Dim LN As Integer
		Dim X As Integer
		PackFileName = ZipName
		PackComments = ""
		PackTotFiles = 0
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		If LOF6(FileNum) < 2 Then 
			FileClose6(FileNum)
			Exit Function
		End If
		'get the end of central date
		FileGet6(FileNum, IntVal)
		If IntVal = ARJHeader Then  'arj header
			FileGet6(FileNum, IntVal) 'total header bytes
			FileGet6(FileNum, LngVal, FileSeek6(FileNum) + IntVal) 'Header CRC
			FileGet6(FileNum, IntVal) 'Lenght extra header data
			If IntVal > 0 Then 
				FileGet6(FileNum, LngVal, FileSeek6(FileNum) + IntVal) 'Extra Header CRC
			End If
			PackFileType = Mod_Declarations.ARJFileType
			'Whe reached the local header area so lets collecting the data
			FileGet6(FileNum, IntVal)
			Do While IntVal = ARJHeader 'arj header
				FileGet6(FileNum, IntVal2)
				If IntVal2 = 0 Then  Exit Do 'HeaderSize
				PackTotFiles += 1
				ReDim Preserve ArjFileData(PackTotFiles)
				With ArjFileData(PackTotFiles)
					.Id = IntVal
					.Headersize = IntVal2
					FileGet6(FileNum, .Firsthdrsize)
					FileGet6(FileNum, .Version)
					FileGet6(FileNum, .Minversion)
					FileGet6(FileNum, .Archiveos)
					FileGet6(FileNum, .Flags)
					FileGet6(FileNum, .Method)
					FileGet6(FileNum, .Filetype)
					FileGet6(FileNum, .X_reserved)
					FileGet6(FileNum, .FTime)
					FileGet6(FileNum, .FDate)
					FileGet6(FileNum, .Sizecompr)
					FileGet6(FileNum, .Sizeorig)
					FileGet6(FileNum, .Origcrc)
					FileGet6(FileNum, .Filespecpos)
					FileGet6(FileNum, .Accessmode)
					FileGet6(FileNum, .Hostdata)
					
					If (.Flags And 8) Then  FileGet6(FileNum, .StartSplit)
					Do
						FileGet6(FileNum, ByteVal)
						If ByteVal = 0 Then  Exit Do 'filename complete
						.FileName &= Chr6(ByteVal)
					Loop
					Do
						FileGet6(FileNum, ByteVal)
						If ByteVal = 0 Then  Exit Do 'filecomment complete
						.FileComment &= Chr6(ByteVal)
					Loop
					FileGet6(FileNum, .HeaderCRC)
					
					FileGet6(FileNum, .ExtHeadSize)
					If .ExtHeadSize > 0 Then 
						.extHeader = String6(CInt(.ExtHeadSize), 0)
						FileGet6(FileNum, .extHeader)
						FileGet6(FileNum, .ExtHeadCRC)
					End If
					.DataOffSet = FileSeek6(FileNum)
					FileGet6(FileNum, IntVal, FileSeek6(FileNum) + .Sizecompr) 'get new header
				End With
			Loop
		End If
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
			Return ArjFileData(FileNum).FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			Return ArjFileData(FileNum).FileComment
	 	End Get
	End Property

	Public ReadOnly Property CommentsPack() As String
		Get
			Return PackComments
	 	End Get
	End Property

	Public ReadOnly Property IsDir(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			If (ArjFileData(FileNum).Flags And 2) > 0 Then  Return True
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(CShort(ArjFileData(FileNum).Method))
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ArjFileData(FileNum).Origcrc
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ArjFileData(FileNum).Sizecompr
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ArjFileData(FileNum).Sizeorig
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return (ArjFileData(FileNum).Flags And 1) = 1
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GetZipDate(ArjFileData(FileNum).FDate, ArjFileData(FileNum).FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return SystemName(ArjFileData(FileNum).Archiveos)
	 	End Get
	End Property

	Public ReadOnly Property VersionMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return VersionTo(ArjFileData(FileNum).Version)
	 	End Get
	End Property

	Public ReadOnly Property SystemNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return SystemName(99)
	 	End Get
	End Property

	Public ReadOnly Property VersionNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return VersionTo(ArjFileData(FileNum).Version)
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
		Case 0: Return "MS-DOS and OS/2 (FAT / VFAT / FAT32 file systems)"
		Case 1: Return "Primos"
		Case 2: Return "UNIX"
		Case 3: Return "Amiga"
		Case 4: Return "MAC-OS"
		Case 5: Return "OS/2"
		Case 6: Return "Apple GS"
		Case 7: Return "Atari ST"
		Case 8: Return "Next"
		Case 9: Return "VAX VMS"
		Case Else: Return "unKnown"
		End Select
	End Function

	Private Function VersionTo(ByVal Version As Byte) As String
		Return Fix(Version / 10) & "." & CInt(Version) Mod 10
	End Function

	Private Function Methods(ByVal MethodType As Short) As String
		Select Case MethodType
		Case 0: Return "No Compression"
		Case 1: Return "Maximum"
		Case 2: Return "Normal"
		Case 3: Return "Small"
		Case 4: Return "Fastest"
		Case Else: Return "Unknown"
		End Select
	End Function

End Class

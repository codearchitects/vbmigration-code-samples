' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_LZH

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show the contents of an LZH/LHA-archive
	
	Friend Structure LzhLhaType
	
		Public Headersize As Byte 'Size of archived file header
		Public HeaderCRC As Byte 'Checksum of remaining bytes
		Public Minc1 As Byte '-
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=3)> _
		Public Method As VB6FixedString 'Compression methods used lzs/lh7
		Public Minc2 As Byte '-
		Public CSize As Integer 'Compressed size
		Public USize As Integer 'Uncompressed size
		Public FDateTime As Integer 'File Date and time
		Public FTime As Short 'File Time
		Public FDate As Short 'File Date
		Public Attrib As Short 'File attribute
		Public FLen As Byte 'Filename Lenght
		Public FileName As String 'FileName
		Public CRC16 As Short 'CRC16 of the data
		Public DataOffSet As Integer 'Start Compressed data
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			Method = New VB6FixedString(3)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As LzhLhaType
			Dim copy As LzhLhaType = Me
			copy.Method.Value = Me.Method.Value
			Return copy
		End Function
	
	#End Region
	
	End Structure

	Private LZHFiles() As Cls_LZH.LzhLhaType
	Private Const m_Unpack_Supported As Boolean = False
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim ByteVal(2) As Byte
		Dim Meth As New VB6FixedString(3)
		Dim Temp As New Cls_LZH.LzhLhaType(True)
		Dim NPos As Integer
		PackFileName = ZipName
		PackComments = ""
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		FileLenght = LOF6(FileNum)
		PackTotFiles = 0
		Redim6(LZHFiles, 0, 100)
		Do
			FileGet6(FileNum, ByteVal(0))
			If ByteVal(0) < 24 Then  Exit Do 'HeaderSize to small
			NPos = FileSeek6(FileNum)
			FileGet6(FileNum, ByteVal(1))
			FileGet6(FileNum, ByteVal(2))
			If ByteVal(2) <> 45 Then  Exit Do 'No LZH file
			FileGet6(FileNum, Meth.Value)
			If VB.Left(Meth.Value, 1) <> "l" Then  Exit Do 'No LZH file
			
			PackTotFiles += 1
			With LZHFiles(PackTotFiles)
				.Headersize = ByteVal(0)
				.HeaderCRC = ByteVal(1)
				.Minc1 = ByteVal(2)
				.Method.Value = Meth.Value
				FileGet6(FileNum, .Minc2)
				FileGet6(FileNum, .CSize)
				FileGet6(FileNum, .USize)
				FileGet6(FileNum, .FDateTime)
				FileGet6(FileNum, .Attrib)
				FileGet6(FileNum, .FLen)
				.FileName = String6(.FLen, 0)
				FileGet6(FileNum, .FileName)
				FileGet6(FileNum, .CRC16)
				.DataOffSet = FileSeek6(FileNum)
				FileSeek6(FileNum, NPos + .CSize + 1 + .Headersize)
				.FDate = Lng2Int((.FDateTime And &HFFFF0000) \ &HFFFF%)
				.FTime = Lng2Int(.FDateTime And &HFFFF%)
			End With
		Loop
		RedimPreserve6(LZHFiles, 0, PackTotFiles)
		If PackTotFiles > 0 Then  PackFileType = LZHFileType
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

	Public ReadOnly Property FileName(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return LZHFiles(FileNum).FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return "Not Supported"
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
			If LZHFiles(FileNum).Method.Value = "-lhd-" Then  Return True
			If LZHFiles(FileNum).USize = 0 Then 
				If VB.Right(LZHFiles(FileNum).FileName, 1) = "/" Then  Return True
			End If
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(LZHFiles(FileNum).Method.Value)
	 	End Get
	End Property

	'Not totaly correct but what the hack
	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return LZHFiles(FileNum).CRC16
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return LZHFiles(FileNum).CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return LZHFiles(FileNum).USize
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
			Return GetZipDate(LZHFiles(FileNum).FDate, LZHFiles(FileNum).FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			Return "UnKnown"
	 	End Get
	End Property

	Public ReadOnly Property VersionMadeBy(ByVal FileNum As Integer) As String
		Get
			Return "UnKnown"
	 	End Get
	End Property

	Public ReadOnly Property SystemNeeded(ByVal FileNum As Integer) As String
		Get
			Return "UnKnown"
	 	End Get
	End Property

	Public ReadOnly Property VersionNeeded(ByVal FileNum As Integer) As String
		Get
			Return "UnKnown"
	 	End Get
	End Property

	Private Function Methods(ByVal MethodType As String) As String
		Select Case MethodType
		Case "lzs": Return "LZSS with 2kb window"
		Case "lz4": Return "no compression"
		Case "lz5": Return "LZSS with 4kb window"
		Case "lhd": Return "no compression (this is a directory, not a file!)"
		Case "lh0": Return "no compression (could be a directory or a file)"
		Case "lh1": Return "LZH with 4kb window, dynamic Huffman"
		Case "lh2": Return "LZH with 8kb window, dynamic Huffman"
		Case "lh3": Return "LZH with 8kb window, static Huffman"
		Case "lh4": Return "LZH with 4kb window, static canonical Huffman"
		Case "lh5": Return "LZH with 8kb window, static canonical Huffman"
		Case "lh6": Return "LZH with 32kb window, static canonical Huffman"
		Case "lh7": Return "LZH with 64kb window, static canonical Huffman"
		Case Else: Return "Unknown"
		End Select
	End Function

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
	End Function

	Private Function Lng2Int(ByVal LngValue As Integer) As Short
		If LngValue > 32767 Then  Lng2Int = LngValue - &HFFFF% - 1 Else Return LngValue
	End Function

End Class

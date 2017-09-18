' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_Arc

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	'This class file can be used to show the contents of an ARC-archive
	
	Friend Structure ARCHeaderType
	
		Public Id As Byte 'Arc signature
		Public Method As Byte 'Compression method
		Public FileName As String 'FileName
		Public CSize As Integer 'Compressed filesize
		Public FDate As Short 'Date
		Public FTime As Short 'Time
		Public CRC16 As Short 'CRC 16
		Public USize As Integer 'Original filesize
		Public DataOffSet As Integer 'Offset of the compressed data
	End Structure

	Private ARCFiles() As Cls_Arc.ARCHeaderType
	Private Const m_Unpack_Supported As Boolean = False
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim ByteVal As Byte
		Dim FName As New VB6FixedString(13)
		PackFileName = ZipName
		PackComments = ""
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		PackTotFiles = 0
		Erase6(ARCFiles)
		Do
			FileGet6(FileNum, ByteVal)
			If ByteVal <> ARCHeader Then  Exit Do 'No arc file
			FileGet6(FileNum, ByteVal)
			If ByteVal < 1 Or ByteVal > 9 Then  Exit Do 'probably No arc file or EOF
			PackTotFiles += 1
			ReDim Preserve ARCFiles(PackTotFiles)
			With ARCFiles(PackTotFiles)
				.Id = ARCHeader
				.Method = ByteVal
				FileGet6(FileNum, FName.Value)
				.FileName = Trim(Replace(FName.Value, ControlChars.NullChar, ""))
				FileGet6(FileNum, .CSize)
				FileGet6(FileNum, .FDate)
				FileGet6(FileNum, .FTime)
				FileGet6(FileNum, .CRC16)
				FileGet6(FileNum, .USize)
				.DataOffSet = FileSeek6(FileNum)
				FileSeek6(FileNum, .DataOffSet + .CSize)
			End With
		Loop
		ReDim Preserve ARCFiles(PackTotFiles)
		If PackTotFiles > 0 Then  PackFileType = ARCFileType
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
			Return ARCFiles(FileNum).FileName
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
			If ARCFiles(FileNum).USize = 0 Then 
				If VB.Right(ARCFiles(FileNum).FileName, 1) = "/" Then  Return True
			End If
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(ARCFiles(FileNum).Method)
	 	End Get
	End Property

	'Not totaly correct but what the hack
	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ARCFiles(FileNum).CRC16
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ARCFiles(FileNum).CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ARCFiles(FileNum).USize
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
			Return GetZipDate(ARCFiles(FileNum).FDate, ARCFiles(FileNum).FTime)
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

	Private Function Methods(ByVal MethodType As Byte) As String
		Select Case MethodType
		Case 1: Return "unpacked (obsolete)"
		Case 2: Return "unpacked"
		Case 3: Return "packed"
		Case 4: Return "squeezed (after packing)"
		Case 5: Return "crunched (obsolete)"
		Case 6: Return "crunched (after packing) (obsolete)"
		Case 7: Return "crunched (after packing, using faster hash algorithm)"
		Case 8: Return "crunched (after packing, using dynamic LZW variations)"
		Case 9: Return "Squashed c/o Phil Katz (no packing) (var. on crunching)"
		Case Else: Return "Unknown"
		End Select
	End Function

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
	End Function

End Class

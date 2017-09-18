' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_Zip

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show/extract the contents of an ZIP-archive
	
	Friend Structure Local_Header_Type
		Implements IVB6FileGetPut
	
		Public VerExt As Short 'version needed to extract
		Public Flags As Short 'encrypt and compression flags
		Public Method As Short 'compression method
		Public FTime As Short 'time last modifies, dos format
		Public FDate As Short 'date last modifies, dos format
		Public CRC32 As Integer 'CRC32 for uncompressed file
		Public CSize As Integer 'compressed size
		Public USize As Integer 'uncompressed size
		Public LenFname As Short 'lenght filename
		Public LenExt As Short 'lenght for extra field
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As Local_Header_Type
			Try
				FileGet6(fileNumber, struct.VerExt)
				FileGet6(fileNumber, struct.Flags)
				FileGet6(fileNumber, struct.Method)
				FileGet6(fileNumber, struct.FTime)
				FileGet6(fileNumber, struct.FDate)
				FileGet6(fileNumber, struct.CRC32)
				FileGet6(fileNumber, struct.CSize)
				FileGet6(fileNumber, struct.USize)
				FileGet6(fileNumber, struct.LenFname)
				FileGet6(fileNumber, struct.LenExt)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.VerExt)
			FilePut6(fileNumber, Me.Flags)
			FilePut6(fileNumber, Me.Method)
			FilePut6(fileNumber, Me.FTime)
			FilePut6(fileNumber, Me.FDate)
			FilePut6(fileNumber, Me.CRC32)
			FilePut6(fileNumber, Me.CSize)
			FilePut6(fileNumber, Me.USize)
			FilePut6(fileNumber, Me.LenFname)
			FilePut6(fileNumber, Me.LenExt)
		End Sub
	
	#End Region
	
	End Structure
	
	Friend Structure Central_Header_Type
		Implements IVB6FileGetPut
	
		Public VerMade As Short 'version made by
		Public VerExt As Short 'version needed to extract
		Public Flags As Short 'encrypt and compression flags
		Public Method As Short 'compression method
		Public FTime As Short 'time last modifies, dos format
		Public FDate As Short 'date last modifies, dos format
		Public CRC32 As Integer 'CRC32 for uncompressed file
		Public CSize As Integer 'compressed size
		Public USize As Integer 'uncompressed size
		Public LenFname As Short 'lenght filename
		Public LenExt As Short 'lenght for extra field
		Public LenCom As Short 'lenght for comment field
		Public DiskStart As Short 'start disk number
		Public AttribI As Short 'internal file attributes
		Public AttribX As Integer 'external file attributes
		Public Offset As Integer 'relative offset of local header
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As Central_Header_Type
			Try
				FileGet6(fileNumber, struct.VerMade)
				FileGet6(fileNumber, struct.VerExt)
				FileGet6(fileNumber, struct.Flags)
				FileGet6(fileNumber, struct.Method)
				FileGet6(fileNumber, struct.FTime)
				FileGet6(fileNumber, struct.FDate)
				FileGet6(fileNumber, struct.CRC32)
				FileGet6(fileNumber, struct.CSize)
				FileGet6(fileNumber, struct.USize)
				FileGet6(fileNumber, struct.LenFname)
				FileGet6(fileNumber, struct.LenExt)
				FileGet6(fileNumber, struct.LenCom)
				FileGet6(fileNumber, struct.DiskStart)
				FileGet6(fileNumber, struct.AttribI)
				FileGet6(fileNumber, struct.AttribX)
				FileGet6(fileNumber, struct.Offset)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.VerMade)
			FilePut6(fileNumber, Me.VerExt)
			FilePut6(fileNumber, Me.Flags)
			FilePut6(fileNumber, Me.Method)
			FilePut6(fileNumber, Me.FTime)
			FilePut6(fileNumber, Me.FDate)
			FilePut6(fileNumber, Me.CRC32)
			FilePut6(fileNumber, Me.CSize)
			FilePut6(fileNumber, Me.USize)
			FilePut6(fileNumber, Me.LenFname)
			FilePut6(fileNumber, Me.LenExt)
			FilePut6(fileNumber, Me.LenCom)
			FilePut6(fileNumber, Me.DiskStart)
			FilePut6(fileNumber, Me.AttribI)
			FilePut6(fileNumber, Me.AttribX)
			FilePut6(fileNumber, Me.Offset)
		End Sub
	
	#End Region
	
	End Structure
	
	Friend Structure End_Header_Type
		Implements IVB6FileGetPut
	
		Public signature As Integer 'Signature
		Public DiskNum As Short 'this disk number
		Public DiskStart As Short 'start disk number
		Public Entries As Short 'Entries on this disk
		Public TotEntr As Short 'Number of total entries
		Public CenSize As Integer 'size of entire cetral directory
		Public CenOff As Integer 'offset of central on starting disk
		Public LenCom As Short 'lenght of comment field
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As End_Header_Type
			Try
				FileGet6(fileNumber, struct.signature)
				FileGet6(fileNumber, struct.DiskNum)
				FileGet6(fileNumber, struct.DiskStart)
				FileGet6(fileNumber, struct.Entries)
				FileGet6(fileNumber, struct.TotEntr)
				FileGet6(fileNumber, struct.CenSize)
				FileGet6(fileNumber, struct.CenOff)
				FileGet6(fileNumber, struct.LenCom)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.signature)
			FilePut6(fileNumber, Me.DiskNum)
			FilePut6(fileNumber, Me.DiskStart)
			FilePut6(fileNumber, Me.Entries)
			FilePut6(fileNumber, Me.TotEntr)
			FilePut6(fileNumber, Me.CenSize)
			FilePut6(fileNumber, Me.CenOff)
			FilePut6(fileNumber, Me.LenCom)
		End Sub
	
	#End Region
	
	End Structure
	
	Friend Structure Extended_Local_Header_Type
		Implements IVB6FileGetPut
	
		Public CRC32 As Integer 'CRC32 for uncompressed file
		Public CSize As Integer 'compressed size
		Public USize As Integer 'uncompressed size
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As Extended_Local_Header_Type
			Try
				FileGet6(fileNumber, struct.CRC32)
				FileGet6(fileNumber, struct.CSize)
				FileGet6(fileNumber, struct.USize)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.CRC32)
			FilePut6(fileNumber, Me.CSize)
			FilePut6(fileNumber, Me.USize)
		End Sub
	
	#End Region
	
	End Structure

	Friend Structure CentralData_Type
	
		Public VerMade As Short 'version made by
		Public VerExt As Short 'version needed to extract
		Public Flags As Short 'encrypt and compression flags
		Public Method As Short 'compression method
		Public FTime As Short 'time last modifies, dos format
		Public FDate As Short 'date last modifies, dos format
		Public CRC32 As Integer 'CRC32 for uncompressed file
		Public CSize As Integer 'compressed size
		Public USize As Integer 'uncompressed size
		Public DiskStart As Short 'start disk number
		Public AttribI As Short 'internal file attributes
		Public AttribX As Integer 'external file attributes
		Public Offset As Integer 'relative offset of local header
		Public FileName As String 'Name of the compressed file
		Public ExtField As String 'Data from extended fields
		Public ComField As String 'data from comments fields
	End Structure

	'Signatures long version
	Private Const ZipLocalSigLng As Integer = &H4034B50I
	Private Const ZipCentralSigLng As Integer = &H2014B50I
	Private Const ZipEndSigLng As Integer = &H6054B50I
	Private Const ZipExtLocalSigLng As Integer = &H8074B50I
	
	'Flags values for ZIP-files
	Private Const ZipFlgEncrypted As Byte = 1
	'bit 0 set = file is encrypted
	Private Const ZipFlgUsedMed As Byte = 6
	'bit 1+2 depending on compression type
	'type = 6 (imploding)
	'bit 1 set = use 8k dictionary else 4k dictionary
	'bit 2 set = use 3 trees else use 2 trees
	'type = 8 (deflating)
	'bit 2 : 1
	'    0   0 = Normal (-en) compression option was used.
	'    0   1 = Maximum (-exx/-ex) compression option was used
	'    1   0 = Fast (-ef) compression option was used
	'    1   1 = Super Fast (-es) compression option was used
	'bits are undified if other methods are used
	Private Const ZipFlgExtLocHead As Byte = 8
	'bit 3 set = Extended local header is used to store CRC and size
	Private Const ZipFlgRes64 As Byte = 16
	'bit 4 Reserved for ZIP64
	Private Const ZipFlgPathed As Byte = 32
	'bit 5 set = file is compressed pathed data
	Private Const ZipFlgEncStrong As Byte = 64
	'bit 6 set = file is encrypted using strong encryption
	
	Private ZIPFileData() As Cls_Zip.CentralData_Type
	Private CRC As New Cls_CRC32
	Private Encrypt As New Cls_Encrypt
	Private Const m_Unpack_Supported As Boolean = True
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim NextByte As Byte '1 byte
		Dim Byte2 As Short '2 bytes
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim Header As Short
		Dim LngHeader As Integer
		Dim UnKnown As Boolean
		Dim TextBytes() As Byte
		Dim EndCentralSig As Cls_Zip.End_Header_Type
		Dim CentDat As Cls_Zip.Central_Header_Type
		Dim LocDat As Cls_Zip.Local_Header_Type
		Dim ExtDat As Cls_Zip.Extended_Local_Header_Type
		Dim LN As Integer
		Dim X As Integer
		PackFileName = ZipName
		PackComments = ""
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		FileLenght = LOF6(FileNum)
		'get the end of central date
		FileGet6(FileNum, EndCentralSig, FileLenght - Len6(EndCentralSig) + 1)
		If EndCentralSig.signature <> ZipEndSigLng Then 
			'EndSignature not found (probably comments are added)
			'Search for central data from start
			FileSeek6(FileNum, 1)
			PackTotFiles = 0
			Do
				FileGet6(FileNum, LngHeader)
				Select Case LngHeader
				Case ZipLocalSigLng
					FileGet6(FileNum, LocDat)
					FileSeek6(FileNum, FileSeek6(FileNum) + LocDat.CSize + LocDat.LenFname + LocDat.LenExt)
					PackTotFiles += 1
				Case ZipCentralSigLng
					FileSeek6(FileNum, FileSeek6(FileNum) - 4)
					Exit Do
				Case ZipExtLocalSigLng
					FileGet6(FileNum, ExtDat)
				Case Else
					MsgBox6("Unknown header")
				End Select
			Loop
		Else
			'position pointer to the start of the central header
			FileSeek6(FileNum, EndCentralSig.CenOff + 1)
			PackTotFiles = EndCentralSig.Entries
		End If
		
		ReDim ZIPFileData(PackTotFiles)
		'Read the central header and store the information
		PackFileType = ZipFileType 'Zip file type
		For X = 1 To PackTotFiles
			FileGet6(FileNum, LngHeader) 'read the header
			FileGet6(FileNum, CentDat) 'read the data
			With ZIPFileData(X)
				.VerMade = CentDat.VerMade
				.VerExt = CentDat.VerExt
				.Flags = CentDat.Flags
				.Method = CentDat.Method
				.FTime = CentDat.FTime
				.FDate = CentDat.FDate
				.CRC32 = CentDat.CRC32
				.CSize = CentDat.CSize
				.USize = CentDat.USize
				.DiskStart = CentDat.DiskStart
				.AttribI = CentDat.AttribI
				.AttribX = CentDat.AttribX
				.Offset = CentDat.Offset
				If CentDat.LenFname <> 0 Then 
					ReDim TextBytes(Int2Lng(CentDat.LenFname) - 1)
					FileGet6(FileNum, TextBytes)
					.FileName = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End If
				If CentDat.LenExt <> 0 Then 
					ReDim TextBytes(Int2Lng(CentDat.LenExt) - 1)
					FileGet6(FileNum, TextBytes)
					.ExtField = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End If
				If CentDat.LenCom Then 
					ReDim TextBytes(Int2Lng(CentDat.LenCom) - 1)
					FileGet6(FileNum, TextBytes)
					.ComField = StrConv6(TextBytes, VBA.VbStrConv.vbUnicode)
				End If
			End With
		Next
		FileGet6(FileNum, EndCentralSig)
		PackComments = String6(EndCentralSig.LenCom, 0)
		FileGet6(FileNum, PackComments)
		FileClose6(FileNum)
	End Function

	'Unzip as file and return 0 for good decompression or others for error
	Public Function UnPack(ByVal ZippedFile() As Boolean, ByVal ToPath As String) As Short
		Dim ZipHead As Cls_Zip.Local_Header_Type 'Local Zip Header
		Dim Header As Integer
		Dim X As Integer
		Dim PassWord As String = ""
		Dim FileNum As Integer
		Dim Y As Integer
		Dim TotDir As String = "" 'Used for new pathnames
		If PackTotFiles = 0 Then  Return -10 'nothing to UnPack
		If PackTotFiles <> UBound6(ZippedFile) Then 
			Return -10 'need same amount as files in zipfile
			Exit Function
		End If
		Erase6(PackData)
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		For X = 1 To PackTotFiles
			If ZippedFile(X) = True Then 
				If Not IsDir(X) Then  'decompress if it is not a pathname
					FileSeek6(FileNum, ZIPFileData(X).Offset + 1)
					FileGet6(FileNum, Header)
					If Header = ZipLocalSigLng Then 
						'read the header
						FileGet6(FileNum, ZipHead)
						'skip data whe already know
						FileSeek6(FileNum, FileSeek6(FileNum) + ZipHead.LenFname + ZipHead.LenExt)
						If ZIPFileData(X).CSize = 0 Then 
							Erase6(PackData)
						Else
							ReDim PackData(ZIPFileData(X).CSize - 1)
							FileGet6(FileNum, PackData) 'Read the compressed file
						End If
						If Encrypted(X) Then 
							If PassWord = "" Then 
								PassWord = InputBox6("Give Password", "Password requered")
								If PassWord = "" Then 
									UnPack = -1
									FileClose6(FileNum)
									MsgBox6("Password is incorrect")
									Exit Function
								End If
							End If
							Encrypt.ZipPrepareKey(PackData, PassWord)
							If PackData(11) <> (((ZIPFileData(X).CRC32 And &HFF000000) \ &H1000000) And 255%) Then 
								UnPack = -1
								FileClose6(FileNum)
								MsgBox6("Password is incorrect")
								Exit Function
							End If
							'adjust the size of instream to delete the decryption data
							For Y = 0 To UBound6(PackData) - 12
								PackData(Y) = PackData(Y + 12)
							Next
							ReDim Preserve PackData(UBound6(PackData) - 12)
							Encrypt.ZipDecryptArray(PackData)
						End If
						Select Case ZIPFileData(X).Method
						Case 0
							Call Write_Uncompressed_Data(X, ToPath)
						Case 1
							UnPack = -10 'not supported
						Case 2
							UnPack = UnReduce(PackData, 2, ZIPFileData(X).USize - 1)
						Case 3
							UnPack = UnReduce(PackData, 3, ZIPFileData(X).USize - 1)
						Case 4
							UnPack = UnReduce(PackData, 4, ZIPFileData(X).USize - 1)
						Case 5
							UnPack = UnReduce(PackData, 5, ZIPFileData(X).USize - 1)
						Case 6
							UnPack = -10 'not supported
						Case 7
							UnPack = -10 'not supported
						Case 8
							Call Inflate(PackData, ZIPFileData(X).USize - 1, False)
							Call Write_Uncompressed_Data(X, ToPath)
						Case 9
							Call Inflate(PackData, ZIPFileData(X).USize - 1, True)
							Call Write_Uncompressed_Data(X, ToPath)
						Case 10
							UnPack = -10 'not supported
						End Select
					Else
						MsgBox6("Error in zipfile")
					End If
				Else
					TotDir = ToPath
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'TotDir' variable as a StringBuilder6 object.
					If VB.Right(TotDir, 1) <> "\" And VB.Right(TotDir, 1) <> "/" Then  TotDir = TotDir & "\"
					TotDir &= ZIPFileData(X).FileName
					If CreatePath(TotDir) = False Then 
						'room for error message
					End If
				End If
			End If
		Next
		FileClose6(FileNum)
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
			Return ZIPFileData(FileNum).FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ZIPFileData(FileNum).ComField
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
			If ZIPFileData(FileNum).CSize = 0 Then 
				If VB.Right(ZIPFileData(FileNum).FileName, 1) = "/" Then  Return True
			End If
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(ZIPFileData(FileNum).Method)
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ZIPFileData(FileNum).CRC32
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ZIPFileData(FileNum).CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return ZIPFileData(FileNum).USize
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return (ZIPFileData(FileNum).Flags And 1) = 1
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GetZipDate(ZIPFileData(FileNum).FDate, ZIPFileData(FileNum).FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return SystemName(Fix(ZIPFileData(FileNum).VerMade / 256) And 255)
	 	End Get
	End Property

	Public ReadOnly Property VersionMadeBy(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return VersionTo(ZIPFileData(FileNum).VerMade And 255)
	 	End Get
	End Property

	Public ReadOnly Property SystemNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return SystemName(Fix(ZIPFileData(FileNum).VerExt / 256) And 255)
	 	End Get
	End Property

	Public ReadOnly Property VersionNeeded(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return VersionTo(ZIPFileData(FileNum).VerExt And 255)
	 	End Get
	End Property

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
	End Function

	Private Function Int2Lng(ByVal Value As Short) As Integer
		If Value < 0 Then  Int2Lng = &HFFFF% + Value + 1 Else Return Value
	End Function

	Private Sub Write_Uncompressed_Data(ByVal FileNum As Integer, ByVal ToPath As String)
		Dim DSize As Integer = DataSize()
		If DSize > 0 Then 
			If ZIPFileData(FileNum).CRC32 <> CRC.CalcCRC32File(PackData) Then  'calcCRC32(PackData) Then
				MsgBox6("CRC calculation failed")
			End If
		Else
			If ZIPFileData(FileNum).CRC32 <> 0 Then 
				MsgBox6("CRC error")
			End If
		End If
		If ZIPFileData(FileNum).USize <> DSize Then 
			MsgBox6("Error in decompressed size")
		End If
		If Write_File(ZIPFileData(FileNum).FileName, ToPath, PackData, ZIPFileData(FileNum).FDate, ZIPFileData(FileNum).FTime) <> 0 Then 
			MsgBox6("error writing file")
		End If
	End Sub

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
		Case 1: Return "Amiga"
		Case 2: Return "2 - OpenVMS"
		Case 3: Return "UNIX"
		Case 4: Return "VM/CMS"
		Case 5: Return "Atari ST"
		Case 6: Return "OS/2 H.P.F.S."
		Case 7: Return "Macintosh"
		Case 8: Return "Z-System"
		Case 9: Return "CP/M"
		Case 10: Return "Windows NTFS"
		Case 11: Return "MVS (OS/390 - Z/OS)"
		Case 12: Return "VSE"
		Case 13: Return "Acorn Risc"
		Case 14: Return "VFAT"
		Case 15: Return "Alternate MVS"
		Case 16: Return "BeOS"
		Case 17: Return "Tandem"
		Case 18: Return "OS/400"
		Case Else: Return "UnKnown"
		End Select
	End Function

	Private Function VersionTo(ByVal Version As Byte) As String
		Return Fix(Version / 10) & "." & CInt(Version) Mod 10
	End Function

	Private Function Methods(ByVal MethodType As Short) As String
		Select Case MethodType
		Case 0: Return "No Compression"
		Case 1: Return "Shrunk"
		Case 2: Return "Reduce Factor 1"
		Case 3: Return "Reduce Factor 2"
		Case 4: Return "Reduce Factor 3"
		Case 5: Return "Reduce Factor 4"
		Case 6: Return "Imploded"
		Case 7: Return "Tokenized"
		Case 8: Return "Deflated"
		Case 9: Return "Enhanced Deflating"
		Case 10: Return "PKWARE Imploding"
		Case 11: Return "Reserved"
		Case 12: Return "BZip2"
		Case Else: Return "Unknown"
		End Select
	End Function

End Class

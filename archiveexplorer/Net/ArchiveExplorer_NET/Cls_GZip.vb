' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_GZip

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show/extract the contents of an gZip-archive
	
	Friend Structure GZipType
	
		Public CompType As Byte 'Compression method
		Public Flags As Byte 'Flags
		Public FDateUnix As Integer 'last modified FileDate in UNIX format
		Public ExtFlags As Byte 'Extended Flags
		Public OStype As Byte 'Used OS type
		Public ExtField As String 'Extended fields
		Public FileName As String 'FileName
		Public COMMENT As String 'Comment field
		Public CRC16 As Short 'least significant 2 bytes from CRC32 from header
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=12)> _
		Public Buff() As Byte 'hold encryption header
		Public CRC32 As Integer 'CRC 32
		Public CSize As Integer 'Compressed size
		Public USize As Integer 'Uncompressed size
		Public DataStart As Integer 'OffSet to start of data
		Public FDate As Short 'Zip date format
		Public FTime As Short 'zip time format
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			ReDim Buff(11)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As GZipType
			Dim copy As GZipType = Me
			copy.Buff = Me.Buff.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure

	'Flag values for GZip-files
	Private Const GzFlgAscII As Byte = 1
	'bit 0 set = file is ascii file
	Private Const GzFlgCRC16 As Byte = 2
	'bit 1 set Included CRC16 ofthe header
	Private Const GzFlgExtFld As Byte = 4
	'bit 2 set Extra field is set
	Private Const GzFlgOrgName As Byte = 8
	'bit 3 set original name included
	Private Const GzFlgComment As Byte = 16
	'bit 4 set comment are included
	Private Const GzFlgEncrypt As Byte = 32
	'bit 5 set file is encrypted
	Private Const GzFlgReserved As Byte = 192
	'bit 6,7 reserved
	
	Private GZipData As New Cls_GZip.GZipType(True)
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
		Dim LN As Integer
		Dim X As Integer
		Dim Temp As String = ""
		If ZipName = "" Then 
			Return -1 'file don't exist
			Exit Function
		End If
		PackFileName = ZipName
		PackComments = ""
		PackFileType = 0
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		FileLenght = LOF6(FileNum)
		FileGet6(FileNum, Header)
		PackFileType = GZFileType
		PackTotFiles = 1 'GZip files contain 1 file
		FileGet6(FileNum, GZipData.CompType)
		If GZipData.CompType <> 8 Then  GZipData.CompType = 99 'only deflate allowed
		FileGet6(FileNum, GZipData.Flags) 'get the flags
		FileGet6(FileNum, GZipData.FDateUnix) 'get unix date
		FileGet6(FileNum, GZipData.ExtFlags) 'get extra flags
		FileGet6(FileNum, GZipData.OStype) 'get os type
		GZipData.ExtField = ""
		If (GZipData.Flags And GzFlgExtFld) > 0 Then  'read extra field
			FileGet6(FileNum, Byte2)
			LN = Int2Lng(Byte2)
			GZipData.ExtField = String6(LN, 0)
			FileGet6(FileNum, GZipData.ExtField)
		End If
		GZipData.FileName = ""
		If (GZipData.Flags And GzFlgOrgName) > 0 Then  'Read original filename (NULL terminated)
			Do
				FileGet6(FileNum, NextByte)
				If NextByte = 0 Then  Exit Do 'filename complete
				GZipData.FileName &= Chr6(NextByte)
			Loop
		End If
		If GZipData.FileName = "" Then  GZipData.FileName = GetNameFromFileName()
		GZipData.COMMENT = ""
		If (GZipData.Flags And GzFlgComment) > 0 Then  'read comments (NULL terminated)
			Do
				FileGet6(FileNum, NextByte)
				If NextByte = 0 Then  Exit Do 'filename complete
				GZipData.COMMENT &= Chr6(NextByte)
			Loop
		End If
		If (GZipData.Flags And GzFlgCRC16) > 0 Then  'get CRC16 of header
			FileGet6(FileNum, Byte2)
			GZipData.CRC16 = Byte2
		End If
		If (GZipData.Flags And GzFlgEncrypt) > 0 Then 
			FileGet6(FileNum, GZipData.Buff)
		End If
		'here is where the compressed data is
		GZipData.CSize = FileLenght - FileSeek6(FileNum) - 8
		GZipData.DataStart = FileSeek6(FileNum)
		FileGet6(FileNum, GZipData.CRC32, FileLenght - 7)
		FileGet6(FileNum, GZipData.USize)
		FileClose6(FileNum)
		'Translate unix time to zip time
		GZipData.FDate = GetIntegerDate(GZipData.FDateUnix)
		GZipData.FTime = GetIntegerTime(GZipData.FDateUnix)
	End Function

	'Unzip as file and return 0 for good decompression or others for error
	Public Function UnPack(ByVal ZippedFile() As Boolean, ByVal ToPath As String) As Short
		Dim X As Integer
		Dim FileNum As Integer
		Dim Y As Integer
		Dim PassWord As String = ""
		Dim TotDir As String = "" 'Used for new pathnames
		If PackTotFiles = 0 Then  Return -10 'nothing to UnPack
		Erase6(PackData)
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		For X = 1 To PackTotFiles
			If ZippedFile(X) = True Then 
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
					If PackData(11) <> (((GZipData.CRC32 And &HFF000000) \ &H1000000) And 255%) Then 
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
				ReDim PackData(GZipData.CSize)
				FileGet6(FileNum, PackData, GZipData.DataStart)
				Call Inflate(PackData, GZipData.USize - 1)
				Call Write_Uncompressed_Data(1, ToPath)
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
			Return GZipData.FileName
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GZipData.COMMENT
	 	End Get
	End Property

	Public ReadOnly Property CommentsPack() As String
		Get
			Return GZipData.COMMENT
	 	End Get
	End Property

	Public ReadOnly Property IsDir(ByVal FileNum As Integer) As Boolean
		Get
			Return False 'No dirs allowed in gzip so must be a file
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return Methods(CShort(GZipData.CompType))
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GZipData.CRC32
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GZipData.CSize
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GZipData.USize
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return (GZipData.Flags And GzFlgEncrypt) = 1
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return GetZipDate(GZipData.FDate, GZipData.FTime)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			Return SystemName(GZipData.OStype)
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

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
	End Function

	Private Function Int2Lng(ByVal Value As Short) As Integer
		If Value < 0 Then  Int2Lng = &HFFFF% + Value + 1 Else Return Value
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
		Case 10: Return "Tops-20"
		Case 11: Return "NTFS filesystem"
		Case 12: Return "QDos"
		Case 13: Return "Acorn Risc"
		Case Else: Return "UnKnown"
		End Select
	End Function

	Private Sub Write_Uncompressed_Data(ByVal FileNum As Integer, ByVal ToPath As String)
		Dim DSize As Integer = DataSize()
		If DSize > 0 Then 
			If GZipData.CRC32 <> CRC.CalcCRC32File(PackData) Then 
				MsgBox6("CRC calculation failed")
			End If
		Else
			If GZipData.CRC32 <> 0 Then 
				MsgBox6("CRC error")
			End If
		End If
		If GZipData.USize <> DSize Then 
			MsgBox6("Error in decompressed size")
		End If
		If Write_File(GZipData.FileName, ToPath, PackData, GZipData.FDate, GZipData.FTime) Then 
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

	Private Function VersionTo(ByVal Version As Byte) As String
		Return Fix(Version / 10) & "." & CInt(Version) Mod 10
	End Function

	Private Function Methods(ByVal MethodType As Short) As String
		Select Case MethodType
		Case 0: Return "Stored"
		Case 8: Return "Deflate"
		Case Else: Return "Unknown"
		End Select
	End Function

	Private Function GetNameFromFileName() As Object
	' UPGRADE_INFO (#0561): The 'GetNameFromFileName' symbol was defined without an explicit "As" clause.
		Dim name As String = mbStripFileName(PackFileName, False)
		If InStr(UCase(name), ".GZ") Then 
			Return VB.Left(name, InStr(UCase(name), ".GZ") - 1)
		End If
		If InStr(UCase(name), ".Z") Then 
			Return VB.Left(name, InStr(UCase(name), ".Z") - 1)
		End If
		If InStr(UCase(name), ".TGZ") Then 
			Return VB.Left(name, InStr(UCase(name), ".TGZ") - 1) & ".tar"
		End If
		If InStr(UCase(name), ".TAZ") Then 
			Return VB.Left(name, InStr(UCase(name), ".TAZ") - 1) & ".tar"
		End If
	End Function

	'----------------------------------------------------------
	'This function is used to extract the filename
	'input
	'Stripfile = Filename with or without directory
	'StripBaseOnly = Treu if only filename is needed
	'                False if also the extension is needed
	'return
	'StripFileName = filename
	'----------------------------------------------------------
	Private Function mbStripFileName(ByVal Stripfile As String, ByVal StripBaseOnly As Boolean) As String
		
		Dim Counter As Short
		Dim Stripped As String = ""
		On  Error Resume Next 
		
		If InStr(Stripfile, "\") Then 
			For Counter = Len6(Stripfile) To 1 Step -1
				If Mid(Stripfile, Counter, 1) = "\" Then 
					Stripped = Mid(Stripfile, Counter + 1)
					Exit For
				End If
			Next
		ElseIf InStr(Stripfile, ":") = 2 Then 
			Stripped = Mid(Stripfile, 3)
		Else
			Stripped = Stripfile
		End If
		
		If StripBaseOnly = True Then 
			If InStr(Stripped, ".") > 0 Then 
				Stripped = VB.Left(Stripped, InStr(Stripped, ".") - 1)
			End If
		End If
		
		Return Stripped
	End Function

	Private Function StampToData(ByVal Stamp As Object) As Date
	' UPGRADE_INFO (#0561): The 'Stamp' symbol was defined without an explicit "As" clause.
		Return CDate6(DoubleToDate6(CDbl(DateToDouble6(DateSerial(1970, 1, 1))) + CDbl((CInt(Stamp) / 86400))))
	End Function

	Private Function GetIntegerDate(ByVal Stamp As Integer) As Short
		Dim Dat As String = ""
		Dim FD As Integer
		Dat = StampToData(Stamp)
		FD = (Year(Dat) - 1980) * 2 ^ 9
		FD = FD + (Month(Dat) * 2 ^ 5)
		FD += VB.Day(Dat)
		If FD > 32767 Then  GetIntegerDate = FD - &HFFFF% - 1 Else Return FD
	End Function

	Private Function GetIntegerTime(ByVal Stamp As Integer) As Short
		Dim Dat As String = ""
		Dim FT As Integer
		Dat = StampToData(Stamp)
		FT = Hour(Dat) * 2 ^ 11
		FT = FT + (Minute(Dat) * 2 ^ 5)
		FT += Second(Dat)
		If FT > 32767 Then  GetIntegerTime = FT - &HFFFF% - 1 Else Return FT
	End Function

End Class

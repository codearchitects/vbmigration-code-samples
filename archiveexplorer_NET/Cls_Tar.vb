' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_Tar

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class file can be used to show the contents of a TAR-file
	
	'data for TAR files
	Friend Structure TarHeaderType
		Implements IVB6FileGetPut
	 'byte offset
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=100)> _
		Public FName As VB6FixedString '  0
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Mode As VB6FixedString '100
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Uid As VB6FixedString '108
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Gid As VB6FixedString '116
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> _
		Public Size As VB6FixedString '124
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> _
		Public Mtime As VB6FixedString '136
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Chksum As VB6FixedString '148
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> _
		Public Typeflag As VB6FixedString '156
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=100)> _
		Public Linkname As VB6FixedString '157
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> _
		Public Magic As VB6FixedString '257
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=2)> _
		Public Version As VB6FixedString '263
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> _
		Public Uname As VB6FixedString '265
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> _
		Public Gname As VB6FixedString '297
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Devmajor As VB6FixedString '329
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> _
		Public Devminor As VB6FixedString '337
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=155)> _
		Public Prefix As VB6FixedString '345
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> _
		Public Total As VB6FixedString '500    only to total the block size to 512
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			FName = New VB6FixedString(100)
			Mode = New VB6FixedString(8)
			Uid = New VB6FixedString(8)
			Gid = New VB6FixedString(8)
			Size = New VB6FixedString(12)
			Mtime = New VB6FixedString(12)
			Chksum = New VB6FixedString(8)
			Typeflag = New VB6FixedString(1)
			Linkname = New VB6FixedString(100)
			Magic = New VB6FixedString(6)
			Version = New VB6FixedString(2)
			Uname = New VB6FixedString(32)
			Gname = New VB6FixedString(32)
			Devmajor = New VB6FixedString(8)
			Devminor = New VB6FixedString(8)
			Prefix = New VB6FixedString(155)
			Total = New VB6FixedString(12)
		End Sub
	
	#End Region
	
	#Region "IVB6FileGetPut interface
	
		Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
			Dim struct As New TarHeaderType(True)
			Try
				FileGet6(fileNumber, struct.FName)
				FileGet6(fileNumber, struct.Mode)
				FileGet6(fileNumber, struct.Uid)
				FileGet6(fileNumber, struct.Gid)
				FileGet6(fileNumber, struct.Size)
				FileGet6(fileNumber, struct.Mtime)
				FileGet6(fileNumber, struct.Chksum)
				FileGet6(fileNumber, struct.Typeflag)
				FileGet6(fileNumber, struct.Linkname)
				FileGet6(fileNumber, struct.Magic)
				FileGet6(fileNumber, struct.Version)
				FileGet6(fileNumber, struct.Uname)
				FileGet6(fileNumber, struct.Gname)
				FileGet6(fileNumber, struct.Devmajor)
				FileGet6(fileNumber, struct.Devminor)
				FileGet6(fileNumber, struct.Prefix)
				FileGet6(fileNumber, struct.Total)
			Catch ex As System.IO.EndOfStreamException
				' VB6 ignores attempts to read past the end of file
			End Try
			Return struct
		End Function
	
		Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
			FilePut6(fileNumber, Me.FName)
			FilePut6(fileNumber, Me.Mode)
			FilePut6(fileNumber, Me.Uid)
			FilePut6(fileNumber, Me.Gid)
			FilePut6(fileNumber, Me.Size)
			FilePut6(fileNumber, Me.Mtime)
			FilePut6(fileNumber, Me.Chksum)
			FilePut6(fileNumber, Me.Typeflag)
			FilePut6(fileNumber, Me.Linkname)
			FilePut6(fileNumber, Me.Magic)
			FilePut6(fileNumber, Me.Version)
			FilePut6(fileNumber, Me.Uname)
			FilePut6(fileNumber, Me.Gname)
			FilePut6(fileNumber, Me.Devmajor)
			FilePut6(fileNumber, Me.Devminor)
			FilePut6(fileNumber, Me.Prefix)
			FilePut6(fileNumber, Me.Total)
		End Sub
	
	#End Region

	#Region "Clone method"
	
		Public Function Clone() As TarHeaderType
			Dim copy As TarHeaderType = Me
			copy.FName.Value = Me.FName.Value
			copy.Mode.Value = Me.Mode.Value
			copy.Uid.Value = Me.Uid.Value
			copy.Gid.Value = Me.Gid.Value
			copy.Size.Value = Me.Size.Value
			copy.Mtime.Value = Me.Mtime.Value
			copy.Chksum.Value = Me.Chksum.Value
			copy.Typeflag.Value = Me.Typeflag.Value
			copy.Linkname.Value = Me.Linkname.Value
			copy.Magic.Value = Me.Magic.Value
			copy.Version.Value = Me.Version.Value
			copy.Uname.Value = Me.Uname.Value
			copy.Gname.Value = Me.Gname.Value
			copy.Devmajor.Value = Me.Devmajor.Value
			copy.Devminor.Value = Me.Devminor.Value
			copy.Prefix.Value = Me.Prefix.Value
			copy.Total.Value = Me.Total.Value
			Return copy
		End Function
	
	#End Region
	
	End Structure 
	Friend Structure TarFilesType
	
		Public FileName As String
		Public FileDateUnix As Integer
		Public FDate As Short
		Public FTime As Short
		Public DataLenght As Integer
		Public DataOffSet As Integer
		Public SumHeader As Integer
	End Structure

	Private TarHead As New Cls_Tar.TarHeaderType(True)
	Private TarFiles() As Cls_Tar.TarFilesType
	Private Const m_Unpack_Supported As Boolean = True
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim LN As Integer
		PackFileName = ZipName
		PackComments = ""
		FileNum = FreeFile6()
		FileOpen6(FileNum, PackFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		FileLenght = LOF6(FileNum)
		PackFileType = 0
		PackTotFiles = 0
		ReDim TarFiles(100)
		Do
			If PackTotFiles = UBound6(TarFiles) Then  ReDim Preserve TarFiles(PackTotFiles + 50)
			FileGet6(FileNum, TarHead)
			TarFiles(PackTotFiles + 1).FileName = Replace(TarHead.FName.Value, ControlChars.NullChar, "")
			If TarFiles(PackTotFiles + 1).FileName = "" Then  Exit Do
			PackTotFiles += 1
			TarFiles(PackTotFiles).FileDateUnix = OctToLng(TarHead.Mtime.Value)
			TarFiles(PackTotFiles).SumHeader = OctToLng(TarHead.Chksum.Value)
			TarFiles(PackTotFiles).FDate = GetIntegerDate(TarFiles(PackTotFiles).FileDateUnix)
			TarFiles(PackTotFiles).FTime = GetIntegerTime(TarFiles(PackTotFiles).FileDateUnix)
			LN = OctToLng(TarHead.Size.Value)
			TarFiles(PackTotFiles).DataLenght = LN
			TarFiles(PackTotFiles).DataOffSet = FileSeek6(FileNum)
			Do While LN > 0
				FileSeek6(FileNum, FileSeek6(FileNum) + 512)
				LN -= 512
			Loop
		Loop
		ReDim Preserve TarFiles(PackTotFiles)
		If PackTotFiles > 0 Then  PackFileType = TARFileType
		FileClose6(FileNum)
	End Function

	'Unzip as file and return 0 for good decompression or others for error
	Public Function UnPack(ByVal ZippedFile() As Boolean, ByVal ToPath As String) As Short
		'    Dim ZipHead As Local_Header_Type        'Local Zip Header
		Dim Header As Integer
		Dim X As Integer
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
				If Not IsDir(X) Then  'extract data if no dir
					ReDim PackData(TarFiles(X).DataLenght - 1)
					FileSeek6(FileNum, TarFiles(X).DataOffSet)
					If TarFiles(X).DataLenght = 0 Then 
						Erase6(PackData)
					Else
						ReDim PackData(TarFiles(X).DataLenght - 1)
						FileGet6(FileNum, PackData) 'Read the compressed file
					End If
					Call Write_Uncompressed_Data(X, ToPath)
				Else
					TotDir = ToPath
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'TotDir' variable as a StringBuilder6 object.
					If VB.Right(TotDir, 1) <> "\" And VB.Right(TotDir, 1) <> "/" Then  TotDir = TotDir & "\"
					TotDir &= TarFiles(X).FileName
					If CreatePath(TotDir) = False Then 
						MsgBox6(("error creating directory " & TotDir))
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

	Public ReadOnly Property FileName(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return TarFiles(FileNum).FileName
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
			If TarFiles(FileNum).DataLenght = 0 Then 
				If VB.Right(TarFiles(FileNum).FileName, 1) = "/" Then  Return True
			End If
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return "Stored"
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			Return 0
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return TarFiles(FileNum).DataLenght
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If NotGood(FileNum) Then  Exit  Property
			Return TarFiles(FileNum).DataLenght
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
			Return GetZipDate(TarFiles(FileNum).FDate, TarFiles(FileNum).FTime)
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

	Private Function OctToLng(ByVal OctVal As String) As Integer
		Dim OctNum As String = ""
		Dim X As Short
		OctNum = Trim(Replace(OctVal, ControlChars.NullChar, ""))
		Do While VB.Left(OctNum, 1) = "0"
			OctNum = Mid(OctNum, 2)
		Loop
		For X = 1 To Len6(OctNum)
			OctToLng = OctToLng + CInt(Val(Mid(OctNum, X, 1))) * 8 ^ (Len6(OctNum) - X)
		Next
	End Function

	Private Function NotGood(ByVal FileNum As Integer) As Boolean
		If FileNum = 0 Then  Return True
		If FileNum > PackTotFiles Then  Return True
		If PackFileType = 0 Then  Return True
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

	Private Sub Write_Uncompressed_Data(ByVal FileNum As Integer, ByVal ToPath As String)
		Dim DSize As Integer = DataSize()
		If TarFiles(FileNum).DataLenght <> DSize Then 
			MsgBox6("Error in decompressed size")
		End If
		If Write_File(TarFiles(FileNum).FileName, ToPath, PackData, TarFiles(FileNum).FDate, TarFiles(FileNum).FTime) <> 0 Then 
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

End Class

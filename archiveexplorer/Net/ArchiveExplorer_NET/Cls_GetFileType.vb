' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Cls_GetFileType

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class is used to examen the file if it is supported by the
	'rest of the class files
	
	Private TAR As New Cls_Tar
	Private GZ As New Cls_GZip
	Private ZIP As New Cls_Zip
	Private CAB As New Cls_Cab
	Private ARJ As New Cls_Arj
	Private LZH As New Cls_LZH
	Private RAR As New Cls_Rar
	Private ARC As New Cls_Arc
	Private Archive As Object
	
	Public Function Get_Contents(ByVal ZipName As String) As Short
		Dim FileNum As Integer
		Dim FileLenght As Integer
		Dim Header As Short
		PackFileType = 0
		If ZipName = "" Then 
			Return -1 'file don't exist
			Exit Function
		End If
		If VB.Right(UCase(ZipName), 4) = ".TAR" Then 
			Archive = TAR
			Archive.Get_Contents(ZipName)
		End If
		If VB.Right(UCase(ZipName), 4) = ".LHA" Or VB.Right(UCase(ZipName), 4) = ".LZH" Then 
			Archive = LZH
			Archive.Get_Contents(ZipName)
		End If
		If PackFileType <> 0 Then  Exit Function
		FileNum = FreeFile6()
		FileOpen6(FileNum, ZipName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1)
		FileLenght = LOF6(FileNum)
		FileGet6(FileNum, Header)
		FileClose6(FileNum)
		If (Header And &HFF) = ARCHeader Then 
			Archive = ARC
			Archive.Get_Contents(ZipName)
			If PackFileType <> 0 Then  Exit Function
		End If
		Select Case Header
		Case ZipHeader
			Archive = ZIP
			Archive.Get_Contents(ZipName)
		Case GZipHeader
			Archive = GZ
			Archive.Get_Contents(ZipName)
		Case ARJHeader
			Archive = ARJ
			Archive.Get_Contents(ZipName)
		Case RARHeader
			Archive = RAR
			Archive.Get_Contents(ZipName)
		Case CABHeader
			'        getinfo (ZipName)
			Archive = CAB
			Archive.Get_Contents(ZipName)
		Case Else
			PackFileType = 0
			PackTotFiles = 0
			Get_Contents = -2 'no compressed files
		End Select
		If PackFileType = 0 Then  Archive = Nothing
	End Function

	'Unzip as file and return 0 for good decompression or others for error
	Public Function UnPack(ByVal ZippedFile() As Boolean, ByVal ToPath As String) As Short
		If PackFileType = 0 Then  Exit Function
		Return Archive.UnPack(ZippedFile, ToPath)
	End Function

	Public Function Pack(ByVal ZipName As String, ByVal Files() As String, ByVal CompType As Short, ByVal CompLevel As Short, Optional ByVal IncludeDir As String = "") As Short
		'Packing is not supported in this version
	End Function

	Public ReadOnly Property CanUnpack() As Boolean
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.CanUnpack
	 	End Get
	End Property

	Public ReadOnly Property FileCount() As Integer
		Get
			If PackFileType = 0 Then  Exit  Property
			Return PackTotFiles
	 	End Get
	End Property

	Public ReadOnly Property FileName(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.FileName(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property CommentsFile(ByVal FileNum As Object) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.CommentsFile(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property CommentsPack() As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.CommentsPack
	 	End Get
	End Property

	Public ReadOnly Property IsDir(ByVal FileNum As Integer) As Boolean
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.IsDir(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property Method(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.Method(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property CRC32(ByVal FileNum As Integer) As Integer
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.CRC32(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property Compressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.Compressed_Size(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property UnCompressed_Size(ByVal FileNum As Integer) As Integer
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.UnCompressed_Size(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property Encrypted(ByVal FileNum As Integer) As Boolean
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.Encrypted(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property FileDateTime(ByVal FileNum As Integer) As Date
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.FileDateTime(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property SystemMadeBy(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.SystemMadeBy(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property VersionMadeBy(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.VersionMadeBy(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property SystemNeeded(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.SystemNeeded(FileNum)
	 	End Get
	End Property

	Public ReadOnly Property VersionNeeded(ByVal FileNum As Integer) As String
		Get
			If PackFileType = 0 Then  Exit  Property
			Return Archive.VersionNeeded(FileNum)
	 	End Get
	End Property

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Mod_Declarations

	'Global declaration
	Public PackFileType As Byte 'Type of file (Zip, GZ.etc..etc)
	Public PackTotFiles As Integer
	Public PackFileName As String = ""
	Public PackComments As String = ""
	Public PackData() As Byte 'Used to store Packed/Unpacked data
	
	'signatures short version
	Public Const ZipHeader As Short = &H4B50S
	'PK-zip signature
	Public Const GZipHeader As Short = &H8B1FS
	'Gzip signature
	Public Const ZHeader As Short = &H9D1FS
	'Z signature
	Public Const PackHeader As Short = &H1E1FS
	'Pack signature
	Public Const FreezeHeader As Short = &HA21FS
	'Freeze signature
	Public Const CABHeader As Short = &H534DS
	'Cab Signature
	Public Const ARJHeader As Short = &HEA60S
	'ARJ Signature
	Public Const RARHeader As Short = &H6152S
	'RAR Signature
	Public Const ARCHeader As Short = &H1AS
	'ARC header has only one byte
	
	'FileType Declarations
	Public Const ZipFileType As Short = 1
	Public Const GZFileType As Short = 2
	Public Const TARFileType As Short = 3
	Public Const ARJFileType As Short = 4
	Public Const LZHFileType As Short = 5
	Public Const RARFileType As Short = 6
	Public Const ARCFileType As Short = 7
	Public Const CABFileType As Short = 7

End Module

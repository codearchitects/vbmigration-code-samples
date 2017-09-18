' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class CTempFile
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------------------------
	' The CTEMPFILE class
	'
	' This class lets you easily create temporary files
	' in Windows' TEMP directory (or in a directory of
	' your choice), and automatically closes and deletes
	' it when the object variable goes out of scope
	'
	' Uses the CFILE class
	'-------------------------------------------------

	Private Declare Function GetTempFileName Lib "kernel32" Alias "GetTempFileNameA" (ByVal lpszPath As String, ByVal lpPrefixString As String, ByVal wUnique As Integer, ByVal lpTempFileName As String) As Integer
	Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Integer, ByVal lpBuffer As String) As Integer
	
	' the file handle
	Private m_Handle As Short
	' the internal CFile object
	Private m_CFile As New CFile
	
	' Open a temporary file, return its handle
	
	Public Sub OpenFile(Optional ByRef Path As Object = VB6Missing, Optional ByRef Prefix As Object = VB6Missing, Optional ByRef mode As OpenModeConstants = OpenModeConstants.omRandom)
		Dim fPath As String = ""
		Dim fPrefix As String = ""
		Dim fName As String = ""
		
		' check access mode
		If mode = OpenModeConstants.omInput Or mode = OpenModeConstants.omAppend Then 
			Err.Raise(1001, , "Input and Append mode not supported")
		End If
		
		' retrieve file's path
		' use vbNullString if not path is provided
		If IsMissing6(Path) Then 
			' if the path is not provided, uses Windows' TEMP path
			fPath = Space(512)
			GetTempPath(Len6(fPath), fPath)
			fPath = VB.Left(fPath, InStr(fPath, ControlChars.NullChar) - 1)
		ElseIf Len6(Path) Then 
			fPath = Path
			' ensure there is a trailing backslash
			If VB.Right(fPath, 1) <> "\" Then  fPath = fPath & "\"
		End If
		
		' retrieve file's prefix string, if any
		' use vbNullString if not prefix is provided
		If Not IsMissing6(Prefix) Then 
			fPrefix = Prefix
		End If
		' the prefix must be three character long
		fPrefix = VB.Right("TMP" & fPrefix, 3)
		
		' call Windows to get the name of the temporary file
		fName = Space(512)
		GetTempFileName(fPath, fPrefix, CShort(False), fName)
		fName = VB.Left(fName, InStr(fName, ControlChars.NullChar) - 1)
		
		' use a CFile object to open the temporary file
		m_CFile = New CFile()
		m_CFile.OpenFile(fName, mode)
	End Sub

	' the file name (read-only property)
	
	Public ReadOnly Property Filename() As String
		Get
			' delegate to internal CFile object
			Return m_CFile.Filename
	 	End Get
	End Property

	' the file handle (read-only property)
	
	Public ReadOnly Property Handle() As Short
		Get
			' delegate to internal CFile object
			Return m_CFile.Handle
	 	End Get
	End Property

	' close the file, if still open
	
	Public Sub CloseFile()
		' delegate to internal CFile object
		m_CFile.CloseFile()
	End Sub

	' delete the file
	
	Public Sub DeleteFile()
		' close the file, if necessary
		CloseFile()
		If Len6(Filename) Then 
			Kill(Filename)
		End If
	End Sub

	' delete the temporary file when the object
	' goes out of scope
	
	Private Sub Class_Terminate_VB6()
		' close and delete the temporary file
		On Error Resume Next 
		DeleteFile()
	End Sub

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub

End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

'-------------------------------------------------
' The CFILE class
'
' A wrapper class for the OPEN statement, that
' automatically close the file when the caller
' procedure exits.
'-------------------------------------------------

Public Enum OpenModeConstants
	omInput
	omOutput
	omAppend
	omRandom
	omBinary
End Enum

Friend Class CFile
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' the file name
	Private m_Filename As String = ""
	' the file handle
	Private m_Handle As Short
	
	' Open a file
	
	Public Sub OpenFile(ByRef Filename As String, Optional ByRef mode As OpenModeConstants = OpenModeConstants.omRandom)
		Dim h As Short = FreeFile6()
		' get the next available file handle
		
		' open the file with desired access mode
		Select Case mode
		Case OpenModeConstants.omInput
			FileOpen6(h, Filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		Case OpenModeConstants.omOutput
			FileOpen6(h, Filename, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		Case OpenModeConstants.omAppend
			FileOpen6(h, Filename, OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1)
		Case OpenModeConstants.omBinary
			FileOpen6(h, Filename, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1)
		Case Else
			' this is the default case
			FileOpen6(h, Filename, OpenMode.Random, OpenAccess.Default, OpenShare.Default, -1)
		End Select
		' (never reaches this point if an error has occurred)
		
		' store data into private variables and return
		m_Handle = h
		m_Filename = Filename
	End Sub

	' the file name (read-only property)
	
	Public ReadOnly Property Filename() As String
		Get
			Return m_Filename
	 	End Get
	End Property

	' the file handle (read-only property)
	
	Public ReadOnly Property Handle() As Short
		Get
			Return m_Handle
	 	End Get
	End Property

	' close the file, if still open
	
	Public Sub CloseFile()
		If m_Handle Then 
			FileClose6(m_Handle)
			m_Handle = 0
		End If
	End Sub

	' force a CloseFile operation when the object
	' goes out of scope
	
	Private Sub Class_Terminate_VB6()
		CloseFile()
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

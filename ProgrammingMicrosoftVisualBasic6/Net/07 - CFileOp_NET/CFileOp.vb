' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

'---------------------------------------------
' The CFileOp class module - definitive version
'---------------------------------------------

Public Enum ActionConstants
	foContinue = 1
	foSkip
	foAbort
End Enum

Friend Class CFileOp

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' this class exposes the following events
	Public Event Parsing(ByRef File As String, ByRef Cancel As Boolean)
	Public Event [Error](ByRef OpName As String, ByRef File As String, ByRef File2 As String, ByRef ErrCode As Short, ByRef ErrMessage As String, ByRef Action As ActionConstants)
	Public Event ProgressPercent(ByRef Percent As Short)
	
	Public Event WillCopyFile(ByRef File As String, ByRef DestFile As String, ByRef Action As ActionConstants)
	Public Event FileCopyComplete(ByRef File As String, ByRef DestFile As String)
	Public Event WillDeleteFile(ByRef File As String, ByRef Action As ActionConstants)
	Public Event FileDeleteComplete(ByRef File As String)
	Public Event WillMoveFile(ByRef File As String, ByRef DestFile As String, ByRef Action As ActionConstants)
	Public Event FileMoveComplete(ByRef File As String, ByRef DestFile As String)
	
	' private member variables
	Private m_FileSpec As String = ""
	Private m_Filenames As Collection
	Private m_Attributes As FileAttribute
	
	' The FileSpec property (also includes the path)

	Public Property FileSpec() As String
		Get
			Return m_FileSpec
	 	End Get
		Set(ByVal NewValue As String)
			' reset the internal collection only if a new filespec is given
			If m_FileSpec <> NewValue Then 
				m_FileSpec = NewValue
				m_Filenames = Nothing
			End If
	 	End Set
	End Property

	' The path of source files
	' this property derives and affects FileSpec, but doesn't
	' correspond to any private member variable

	Public Property Path() As String
		Get
			Return GetPath(m_FileSpec)
	 	End Get
		Set(ByVal NewValue As String)
			' get the current Filespec, then substitute just the path
			FileSpec = MakeFilename(NewValue, GetFileName(FileSpec))
	 	End Set
	End Property

	' The attributes of the files that must be processed

	Public Property Attributes() As FileAttribute
		Get
			Return m_Attributes
	 	End Get
		Set(ByVal NewValue As FileAttribute)
			' reset the internal collection only if a new value is given
			If m_Attributes <> NewValue Then 
				m_Attributes = NewValue
				m_Filenames = Nothing
			End If
	 	End Set
	End Property

	' holds the list of all the files that match FileSpec
	' plus any other file added by the client code
	' this is a read-only property
	
	Public ReadOnly Property Filenames() As Collection
		Get
			' build the filelist "on demand", and only if necessary
			If m_Filenames Is Nothing Then  ParseFileSpec()
			Return m_Filenames
	 	End Get
	End Property

	' Parses a file specification and attributes
	' and adds the resulting filename to the internal m_Filenames collection
	
	Public Sub ParseFileSpec(Optional ByRef FileSpec As Object = VB6Missing, Optional ByRef Attributes As FileAttribute = 0)
		Dim File As String = ""
		Dim Path As String = ""
		Dim Cancel As Boolean
		' provide a default for arguments
		If IsMissing6(FileSpec) Then 
			' in this case we need a file specification
			If Me.FileSpec = "" Then  Err.Raise(1001, , "FileSpec undefined")
			FileSpec = Me.FileSpec
			Attributes = Me.Attributes
		End If
		' create the internal collection if necessary
		If m_Filenames Is Nothing Then 
			m_Filenames = New Collection()
		End If
		
		' support for semicolon delimited multiple filespecs
		Dim MultiSpecs() As String
		Dim i As Short
		If InStr(FileSpec, ";") Then 
			MultiSpecs = Split(FileSpec, ";")
			For i = LBound6(MultiSpecs) To UBound6(MultiSpecs)
				' recursive call to this routine
				ParseFileSpec(MultiSpecs(i))
			Next
			Exit Sub
		End If
		
		Path = GetPath(FileSpec)
		' do the real parsing work here
        File = Dir6(FileSpec, Attributes)
		Do While Len6(File)
			Cancel = False
			RaiseEvent Parsing(File, Cancel)
			If Not Cancel Then  m_Filenames.Add(MakeFilename(Path, File))
			File = Dir6()
		Loop
	End Sub

	' Copy all matching files
	
	Public Sub Copy(ByRef DestFile As String)
		Dim var As Object = Nothing
		Dim File As String = ""
		Dim dest As String = ""
		Dim Action As ActionConstants
		On Error Resume Next 
		
		' reset the ProgressPercent internal value
		CheckProgressPercent(0, Filenames.Count())
		
		Dim ErrCode As Short
		Dim ErrMessage As String = ""
		For Each var In Filenames
			CheckProgressPercent()
			File = var
			dest = MakeFilename(DestFile, GetFileName(File))
			Action = ActionConstants.foContinue
			RaiseEvent WillCopyFile(File, dest, Action)
			If Action = ActionConstants.foAbort Then  Exit Sub
			
			If Action = ActionConstants.foContinue Then 
				Debugger.Break()
				' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
				' FileCopy File, dest
				If Err.Number = 0 Then 
					RaiseEvent FileCopyComplete(File, GetPath(dest))
				Else
					ErrCode = Err.Number: ErrMessage = Err.Description
					RaiseEvent [Error]("Copy", File, DestFile, ErrCode, ErrMessage, Action)
					' report the error to the client if user aborted the process
					If Action = ActionConstants.foAbort Then 
						On Error GoTo 0  ' this is necessary
						Err.Raise(ErrCode, , ErrMessage)
					End If
					' otherwise just clear it and continue
					Err.Clear()
				End If
			End If
		Next
	End Sub

	' Delete all matching files
	
	Public Sub Delete()
		Dim var As Object = Nothing
		Dim File As String = ""
		Dim Action As ActionConstants
		On Error Resume Next 
		
		' reset the ProgressPercent internal value
		CheckProgressPercent(0, Filenames.Count())
		
		Dim ErrCode As Short
		Dim ErrMessage As String = ""
		For Each var In Filenames
			CheckProgressPercent()
			File = var
			Action = ActionConstants.foContinue
			RaiseEvent WillDeleteFile(File, Action)
			If Action = ActionConstants.foAbort Then  Exit Sub
			
			If Action = ActionConstants.foContinue Then 
				Debugger.Break()
				' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
				' Kill File
				If Err.Number = 0 Then 
					RaiseEvent FileDeleteComplete(File)
				Else
					ErrCode = Err.Number: ErrMessage = Err.Description
					RaiseEvent [Error]("Delete", File, "", ErrCode, ErrMessage, Action)
					' report the error to the client if user aborted the process
					If Action = ActionConstants.foAbort Then 
						On Error GoTo 0  ' this is necessary
						Err.Raise(ErrCode, , ErrMessage)
					End If
					' otherwise just clear it and continue
					Err.Clear()
				End If
			End If
		Next
	End Sub

	' Move all matching files
	
	Public Sub Move(ByRef DestFile As String)
		Dim var As Object = Nothing
		Dim File As String = ""
		Dim dest As String = ""
		Dim Action As ActionConstants
		On Error Resume Next 
		
		' reset the ProgressPercent internal value
		CheckProgressPercent(0, Filenames.Count())
		
		Dim ErrCode As Short
		Dim ErrMessage As String = ""
		For Each var In Filenames
			CheckProgressPercent()
			File = var
			dest = MakeFilename(DestFile, GetFileName(File))
			Action = ActionConstants.foContinue
			RaiseEvent WillMoveFile(File, dest, Action)
			If Action = ActionConstants.foAbort Then  Exit Sub
			
			If Action = ActionConstants.foContinue Then 
				Debugger.Break()
				' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
				' Name File As dest
				If Err.Number = 0 Then 
					RaiseEvent FileMoveComplete(File, DestFile)
				Else
					ErrCode = Err.Number: ErrMessage = Err.Description
					RaiseEvent [Error]("Move", File, DestFile, ErrCode, ErrMessage, Action)
					' report the error to the client if user aborted the process
					If Action = ActionConstants.foAbort Then 
						On Error GoTo 0  ' this is necessary
						Err.Raise(ErrCode, , ErrMessage)
					End If
					' otherwise just clear it and continue
					Err.Clear()
				End If
			End If
		Next
	End Sub

	' a support routine that parses a filename
	' it is used internally, but it is also exposed as Public for convenience
	
	Public Sub SplitFilename(ByVal CompleteName As String, ByRef Path As String, ByRef File As String, Optional ByRef Extension As Object = VB6Missing)
		Dim i As Short
		' assume there isn't any embedded path
		Path = ""
		File = CompleteName
		' backward search for a path delimiter
		For i = Len6(File) To 1 Step -1
			If Mid(File, i, 1) = "." And Not IsMissing6(Extension) Then 
				' we have found an extension and the caller asked for it
				Extension = Mid(File, i + 1)
				File = VB.Left(File, i - 1)
			ElseIf InStr(":\", Mid(File, i, 1)) Then 
				' paths don't have a trailing backslash
				Path = VB.Left(File, i)
				If VB.Right(Path, 1) = "\" Then  Path = VB.Left(Path, i - 1)
				File = Mid(File, i + 1)
				Exit For
			End If
		Next
	End Sub

	' return the Path portion of a complete filename
	' Note: uses SplitFilename
	
	Public Function GetPath(ByVal CompleteFileName As String) As String
		SplitFilename(CompleteFileName, GetPath, "")
	End Function

	' return the BaseFile portion of a complete filename
	' Note: uses SplitFilename
	
	Public Function GetBaseName(ByVal CompleteFileName As String) As String
		' you need to pass a dummy extension argument
		SplitFilename(CompleteFileName, "", GetBaseName, "")
	End Function

	' return the FileName portion of a complete filename
	' Note: uses SplitFilename
	
	Public Function GetFileName(ByVal CompleteFileName As String) As String
		' don't pass any extension argument
		SplitFilename(CompleteFileName, "", GetFileName)
	End Function

	' return the Extension portion of a complete filename
	' Note: uses SplitFilename
	
	Public Function GetExtension(ByVal CompleteFileName As String) As String
		SplitFilename(CompleteFileName, "", "", GetExtension)
	End Function

	' a support routine that builds a filename
	' it is used internally, but it is also exposed as Public for convenience
	
	Public Function MakeFilename(ByVal Path As String, ByVal filename As String, Optional ByRef Extension As String = "") As String
		Dim result As String = ""
		If Path <> "" Then 
			' path may or may not include a trailing backslash
			result = Path & IIf(VB.Right(Path, 1) <> "\", "\", "")
		End If
		result &= filename
		If Extension <> "" Then 
			' extension may or may not include a dot
			result = result & IIf(VB.Left(Extension, 1) = ".", ".", "") & Extension
		End If
		Return result
	End Function

	' fires a ProgressPercent event, if necessary
	' this is a Private method used elsewhere in the class
	' call once to initialize INITVALUE and MAXVALUE
	' call multiple time to increment values (omit NewValue if 1)
	
	Private Sub CheckProgressPercent(Optional ByRef NewValue As Object = VB6Missing, Optional ByRef MaxValue As Object = VB6Missing)
		Static Value As Object
		Static Limit As Object
		Static LastPercent As Short
		Dim CurrValue As Object = Nothing
		Dim CurrPercent As Short
		
		If Not IsMissing6(MaxValue) Then 
			Limit = MaxValue
			If IsMissing6(NewValue) Then  Err.Raise(9998, , "NewValue can't be omitted in the first call")
			Value = NewValue
		Else
			If IsEmpty6(Limit) Then  Err.Raise(9999, , "Not initialized!")
			Value += IIf(IsMissing6(NewValue), 1, NewValue)
		End If
		
		CurrPercent = (Value * 100) \ Limit
		If CurrPercent <> LastPercent Or Not IsMissing6(MaxValue) Then 
			LastPercent = CurrPercent
			RaiseEvent ProgressPercent(CurrPercent)
		End If
		
	End Sub

End Class

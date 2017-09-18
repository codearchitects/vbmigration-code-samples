VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CFileOp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'---------------------------------------------
' The CFileOp class module - definitive version
'---------------------------------------------

Option Explicit

Enum ActionConstants
    foContinue = 1
    foSkip
    foAbort
End Enum

' this class exposes the following events
Event Parsing(File As String, Cancel As Boolean)
Event Error(OpName As String, File As String, File2 As String, ErrCode As Integer, ErrMessage As String, Action As ActionConstants)
Event ProgressPercent(Percent As Integer)

Event WillCopyFile(File As String, DestFile As String, Action As ActionConstants)
Event FileCopyComplete(File As String, DestFile As String)
Event WillDeleteFile(File As String, Action As ActionConstants)
Event FileDeleteComplete(File As String)
Event WillMoveFile(File As String, DestFile As String, Action As ActionConstants)
Event FileMoveComplete(File As String, DestFile As String)

' private member variables
Private m_FileSpec As String
Private m_Filenames As Collection
Private m_Attributes As VbFileAttribute

' The FileSpec property (also includes the path)

Property Get FileSpec() As String
    FileSpec = m_FileSpec
End Property

Property Let FileSpec(ByVal NewValue As String)
    ' reset the internal collection only if a new filespec is given
    If m_FileSpec <> NewValue Then
        m_FileSpec = NewValue
        Set m_Filenames = Nothing
    End If
End Property

' The path of source files
' this property derives and affects FileSpec, but doesn't
' correspond to any private member variable

Property Get Path() As String
    Path = GetPath(m_FileSpec)
End Property

Property Let Path(ByVal NewValue As String)
    ' get the current Filespec, then substitute just the path
    FileSpec = MakeFilename(NewValue, GetFileName(FileSpec))
End Property

' The attributes of the files that must be processed

Property Get Attributes() As VbFileAttribute
    Attributes = m_Attributes
End Property

Property Let Attributes(ByVal NewValue As VbFileAttribute)
    ' reset the internal collection only if a new value is given
    If m_Attributes <> NewValue Then
        m_Attributes = NewValue
        Set m_Filenames = Nothing
    End If
End Property

' holds the list of all the files that match FileSpec
' plus any other file added by the client code
' this is a read-only property

Property Get Filenames() As Collection
    ' build the filelist "on demand", and only if necessary
    If m_Filenames Is Nothing Then ParseFileSpec
    Set Filenames = m_Filenames
End Property

' Parses a file specification and attributes
' and adds the resulting filename to the internal m_Filenames collection

Sub ParseFileSpec(Optional FileSpec As Variant, _
    Optional Attributes As VbFileAttribute)
        Dim File As String, Path As String, Cancel As Boolean
        ' provide a default for arguments
        If IsMissing(FileSpec) Then
            ' in this case we need a file specification
            If Me.FileSpec = "" Then Err.Raise 1001, , "FileSpec undefined"
            FileSpec = Me.FileSpec
            Attributes = Me.Attributes
        End If
        ' create the internal collection if necessary
        If m_Filenames Is Nothing Then
            Set m_Filenames = New Collection
        End If
        
        ' support for semicolon delimited multiple filespecs
        Dim MultiSpecs() As String, i As Integer
        If InStr(FileSpec, ";") Then
            MultiSpecs = Split(FileSpec, ";")
            For i = LBound(MultiSpecs) To UBound(MultiSpecs)
                ' recursive call to this routine
                ParseFileSpec MultiSpecs(i)
            Next
            Exit Sub
        End If
        
        Path = GetPath(FileSpec)
        ' do the real parsing work here
        File = Dir$(FileSpec, Attributes)
        Do While Len(File)
            Cancel = False
            RaiseEvent Parsing(File, Cancel)
            If Not Cancel Then m_Filenames.Add MakeFilename(Path, File)
            File = Dir$
        Loop
End Sub

' Copy all matching files

Sub Copy(DestFile As String)
    Dim var As Variant, File As String, dest As String
    Dim Action As ActionConstants
    On Error Resume Next
    
    ' reset the ProgressPercent internal value
    CheckProgressPercent 0, Filenames.Count
    
    For Each var In Filenames
        CheckProgressPercent
        File = var
        dest = MakeFilename(DestFile, GetFileName(File))
        Action = foContinue
        RaiseEvent WillCopyFile(File, dest, Action)
        If Action = foAbort Then Exit Sub
        
        If Action = foContinue Then
            Stop
            ' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
            ' FileCopy File, dest
            If Err = 0 Then
                RaiseEvent FileCopyComplete(File, GetPath(dest))
            Else
                Dim ErrCode As Integer, ErrMessage As String
                ErrCode = Err.Number: ErrMessage = Err.Description
                RaiseEvent Error("Copy", File, DestFile, ErrCode, ErrMessage, Action)
                ' report the error to the client if user aborted the process
                If Action = foAbort Then
                    On Error GoTo 0                   ' this is necessary
                    Err.Raise ErrCode, , ErrMessage
                End If
                ' otherwise just clear it and continue
                Err.Clear
            End If
        End If
    Next
End Sub

' Delete all matching files

Sub Delete()
    Dim var As Variant, File As String
    Dim Action As ActionConstants
    On Error Resume Next
    
    ' reset the ProgressPercent internal value
    CheckProgressPercent 0, Filenames.Count
    
    For Each var In Filenames
        CheckProgressPercent
        File = var
        Action = foContinue
        RaiseEvent WillDeleteFile(File, Action)
        If Action = foAbort Then Exit Sub
        
        If Action = foContinue Then
            Stop
            ' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
            ' Kill File
            If Err = 0 Then
                RaiseEvent FileDeleteComplete(File)
            Else
                Dim ErrCode As Integer, ErrMessage As String
                ErrCode = Err.Number: ErrMessage = Err.Description
                RaiseEvent Error("Delete", File, "", ErrCode, ErrMessage, Action)
                ' report the error to the client if user aborted the process
                If Action = foAbort Then
                    On Error GoTo 0                   ' this is necessary
                    Err.Raise ErrCode, , ErrMessage
                End If
                ' otherwise just clear it and continue
                Err.Clear
            End If
        End If
    Next
End Sub

' Move all matching files

Sub Move(DestFile As String)
    Dim var As Variant, File As String, dest As String
    Dim Action As ActionConstants
    On Error Resume Next
    
    ' reset the ProgressPercent internal value
    CheckProgressPercent 0, Filenames.Count
    
    For Each var In Filenames
        CheckProgressPercent
        File = var
        dest = MakeFilename(DestFile, GetFileName(File))
        Action = foContinue
        RaiseEvent WillMoveFile(File, dest, Action)
        If Action = foAbort Then Exit Sub
        
        If Action = foContinue Then
            Stop
            ' UNCOMMENT NEXT LINE IF YOU REALLY WANT TO ACTIVATE THIS COMMAND
            ' Name File As dest
            If Err = 0 Then
                RaiseEvent FileMoveComplete(File, DestFile)
            Else
                Dim ErrCode As Integer, ErrMessage As String
                ErrCode = Err.Number: ErrMessage = Err.Description
                RaiseEvent Error("Move", File, DestFile, ErrCode, ErrMessage, Action)
                ' report the error to the client if user aborted the process
                If Action = foAbort Then
                    On Error GoTo 0                   ' this is necessary
                    Err.Raise ErrCode, , ErrMessage
                End If
                ' otherwise just clear it and continue
                Err.Clear
            End If
        End If
    Next
End Sub


' a support routine that parses a filename
' it is used internally, but it is also exposed as Public for convenience

Sub SplitFilename(ByVal CompleteName As String, Path As String, File As String, _
    Optional Extension As Variant)
        Dim i As Integer
        ' assume there isn't any embedded path
        Path = ""
        File = CompleteName
        ' backward search for a path delimiter
        For i = Len(File) To 1 Step -1
            If Mid$(File, i, 1) = "." And Not IsMissing(Extension) Then
                ' we have found an extension and the caller asked for it
                Extension = Mid$(File, i + 1)
                File = Left$(File, i - 1)
            ElseIf InStr(":\", Mid$(File, i, 1)) Then
                ' paths don't have a trailing backslash
                Path = Left$(File, i)
                If Right$(Path, 1) = "\" Then Path = Left$(Path, i - 1)
                File = Mid$(File, i + 1)
                Exit For
            End If
        Next
End Sub

' return the Path portion of a complete filename
' Note: uses SplitFilename

Function GetPath(ByVal CompleteFileName As String) As String
    SplitFilename CompleteFileName, GetPath, ""
End Function

' return the BaseFile portion of a complete filename
' Note: uses SplitFilename

Function GetBaseName(ByVal CompleteFileName As String) As String
    ' you need to pass a dummy extension argument
    SplitFilename CompleteFileName, "", GetBaseName, ""
End Function

' return the FileName portion of a complete filename
' Note: uses SplitFilename

Function GetFileName(ByVal CompleteFileName As String) As String
    ' don't pass any extension argument
    SplitFilename CompleteFileName, "", GetFileName
End Function

' return the Extension portion of a complete filename
' Note: uses SplitFilename

Function GetExtension(ByVal CompleteFileName As String) As String
    SplitFilename CompleteFileName, "", "", GetExtension
End Function

' a support routine that builds a filename
' it is used internally, but it is also exposed as Public for convenience

Function MakeFilename(ByVal Path As String, ByVal filename As String, _
    Optional Extension As String) As String
        Dim result As String
        If Path <> "" Then
            ' path may or may not include a trailing backslash
            result = Path & IIf(Right$(Path, 1) <> "\", "\", "")
        End If
        result = result & filename
        If Extension <> "" Then
            ' extension may or may not include a dot
            result = result & IIf(Left$(Extension, 1) = ".", ".", "") & Extension
        End If
        MakeFilename = result
End Function

' fires a ProgressPercent event, if necessary
' this is a Private method used elsewhere in the class
' call once to initialize INITVALUE and MAXVALUE
' call multiple time to increment values (omit NewValue if 1)

Private Sub CheckProgressPercent(Optional NewValue As Variant, _
    Optional MaxValue As Variant)
        Static Value As Variant, Limit As Variant, LastPercent As Integer
        Dim CurrValue As Variant, CurrPercent As Integer
        
        If Not IsMissing(MaxValue) Then
            Limit = MaxValue
            If IsMissing(NewValue) Then Err.Raise 9998, , "NewValue can't be omitted in the first call"
            Value = NewValue
        Else
            If IsEmpty(Limit) Then Err.Raise 9999, , "Not initialized!"
            Value = Value + IIf(IsMissing(NewValue), 1, NewValue)
        End If
        
        CurrPercent = (Value * 100) \ Limit
        If CurrPercent <> LastPercent Or Not IsMissing(MaxValue) Then
            LastPercent = CurrPercent
            RaiseEvent ProgressPercent(CurrPercent)
        End If
        
End Sub



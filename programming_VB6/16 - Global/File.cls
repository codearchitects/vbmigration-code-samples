VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "File"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "File routines"
'---------------------------------------------------------
' File routines
'---------------------------------------------------------

Option Explicit

' The attributes of a file in a readable format.
' Also works with open files, raises an error if the file doesn't exist.

Function GetAttrDescr(filename As String) As String
Attribute GetAttrDescr.VB_Description = "The attributes of a file in a readable format."
Attribute GetAttrDescr.VB_MemberFlags = "400"
    Dim result As String, attr As Long
    attr = GetAttr(filename)
    ' GetAttr also works with directories
    If attr And vbDirectory Then result = result & " Directory"
    If attr And vbReadOnly Then result = result & " ReadOnly"
    If attr And vbHidden Then result = result & " Hidden"
    If attr And vbSystem Then result = result & " System"
    If attr And vbArchive Then result = result & " Archive"
    ' discard the first space
    GetAttrDescr = Mid$(result, 2)
End Function

' An array of strings holding all the filenames that
' match a given filespec and search attributes.

Function GetFiles(FileSpec As String, Optional Attributes As VbFileAttribute) As String()
Attribute GetFiles.VB_Description = "An array of strings holding all the filenames that match a given filespec and search attributes."
    '##result.ArrayBounds ForceZero
    Dim result() As String
    Dim filename As String, count As Long, path2 As String
    Const ALLOC_CHUNK = 50
    ReDim result(0 To ALLOC_CHUNK) As String
    filename = Dir$(FileSpec, Attributes)
    Do While Len(filename)
        count = count + 1
        If count > UBound(result) Then
            ' resize the result array, if necessary
            ReDim Preserve result(0 To count + ALLOC_CHUNK) As String
        End If
        result(count) = filename
        ' get ready for the next iteration
        filename = Dir$
    Loop
    ' trim the result array
    ReDim Preserve result(0 To count) As String
    GetFiles = result
End Function

' Check if a file exists.

Function FileExists(filename As String) As Boolean
Attribute FileExists.VB_Description = "Check if a file exists."
    On Error Resume Next
    FileExists = (Dir$(filename) <> "")
End Function

' Check if a directory exists.

Function DirExists(Path As String) As Boolean
Attribute DirExists.VB_Description = "Check if a directory exists."
    On Error Resume Next
    DirExists = (Dir$(Path & "\nul") <> "")
End Function

' An array of strings holding all the subdirectories in a path
' that match search attributes (optionally it returns the entire path).

Function GetDirectories(Path As String, Optional Attributes As VbFileAttribute, Optional IncludePath As Boolean) As String()
Attribute GetDirectories.VB_Description = "An array of strings holding all the subdirectories in a path that match search attributes (optionally it returns the entire path)."
    Dim result() As String
    Dim dirname As String, count As Long, path2 As String
    Const ALLOC_CHUNK = 50
    ReDim result(ALLOC_CHUNK) As String
    ' build the path name + backslash
    path2 = Path
    If Right$(path2, 1) <> "\" Then path2 = path2 & "\"
    dirname = Dir$(path2 & "*.*", vbDirectory Or Attributes)
    Do While Len(dirname)
        If dirname = "." Or dirname = ".." Then
            ' exclude the "." and ".." entries
        ElseIf (GetAttr(path2 & dirname) And vbDirectory) = 0 Then
            ' this is a regular file
        Else
            ' this is a directory
            count = count + 1
            If count > UBound(result) Then
                ' resize the result array, if necessary
                ReDim Preserve result(count + ALLOC_CHUNK) As String
            End If
            ' include the path if requested
            If IncludePath Then dirname = path2 & dirname
            result(count) = dirname
        End If
        dirname = Dir$
    Loop
    ' trim the result array
    ReDim Preserve result(count) As String
    GetDirectories = result
End Function

' The names of all executable files in a directory tree.

Function GetExecutableFiles(ByVal Path As String, Optional RecurseDirs) As String()
Attribute GetExecutableFiles.VB_Description = "The names of all executable files in a directory tree."
    Dim result() As String, i As Long
    Dim names() As String
    ' ensure that there is a trailing backslash
    If Right(Path, 1) <> "\" Then Path = Path & "\"
    ' get the list of executable files
    For i = 1 To 4
        ' at each iteration search for a different extension
        AppendStringArray result(), GetFiles(Path & "*." & Choose(i, "exe", "bat", "com", "pif"))
    Next
    If RecurseDirs Then
        ' get the list of subdirectories, including hidden ones
        ' and call this routine recursively on all of them
        names() = GetDirectories(Path, vbHidden)
        For i = 1 To UBound(names)
            AppendStringArray result(), GetExecutableFiles(Path & names(i), RecurseDirs)
        Next
    End If
    GetExecutableFiles = result()
End Function

' (private) appends two string arrays
' Used by ExecutableFiles

Private Sub AppendStringArray(dest() As String, newvalues() As String)
Attribute AppendStringArray.VB_Description = "."
    Dim numEls As Long, index As Long, i As Long
    numEls = UBound(newvalues) - LBound(newvalues) + 1
    'ReDim Preserve dest(LBound(dest) To UBound(dest) + numEls) As String
    ' MIGRATION NOTE !!!!
    ReDim Preserve dest(UBound(dest) + numEls) As String
    index = UBound(dest)
    For i = LBound(newvalues) To UBound(newvalues)
        index = index + 1
        dest(index) = newvalues(i)
    Next
End Sub

' The contents of a text file as a string.

Function ReadTextFile(filename As String) As String
Attribute ReadTextFile.VB_Description = "The contents of a text file as a string."
    Dim fnum As Integer, isOpen As Boolean
    On Error GoTo Error_Handler
    ' get the next free file number
    fnum = FreeFile()
    Open filename For Input As #fnum
    ' if execution flow got here, the file has been open without error
    isOpen = True
    ' read the entire contents in one single operation
    ReadTextFile = Input(LOF(fnum), fnum)
    ' intentionally flow into the error handler to close the file
Error_Handler:
    ' raise the error (if any), but first close the file
    If isOpen Then Close #fnum
    If Err Then Err.Raise Err.Number, , Err.Description
End Function

' Write the contents of a string to a file, optionally in Append mode.

Sub WriteTextFile(Text As String, filename As String, Optional AppendMode As Boolean)
Attribute WriteTextFile.VB_Description = "Write the contents of a string to a file, optionally in Append mode."
    Dim fnum As Integer, isOpen As Boolean
    On Error GoTo Error_Handler
    ' get the next free file number
    fnum = FreeFile()
    If AppendMode Then
        Open filename For Append As #fnum
    Else
        Open filename For Output As #fnum
    End If
    ' if execution flow got here, the file has been open correctly
    isOpen = True
    ' print to the file in one single operation
    Print #fnum, Text
    ' intentionally flow into the error handler to close the file
Error_Handler:
    ' raise the error (if any), but first close the file
    If isOpen Then Close #fnum
    If Err Then Err.Raise Err.Number, , Err.Description
End Sub

' The contents of a text file as an array of strings.

Function GetTextFileLines(filename As String, Optional DropEmpty As Boolean, Optional Limit As Variant) As String()
Attribute GetTextFileLines.VB_Description = "The contents of a text file as an array of strings."
    Dim FileText As String, items() As String, i As Long
    ' read the file's contents, exit if any error
    FileText = ReadTextFile(filename)
    ' this is necessary, because Split() only accepts 1-char delimiters
    FileText = Replace(FileText, vbCrLf, vbCr)
    ' split the file in individual lines of text
    items() = Split(FileText, vbCr, Limit)
    ' drop empty lines, if requested
    If DropEmpty Then
        ' fill empty lines with something that other items surely don't contain
        For i = 0 To UBound(items)
            If Len(items(i)) = 0 Then items(i) = vbCrLf
        Next
        ' use the Filter() function to quickly drop empty lines
        items() = Filter(items(), vbCrLf, False)
    End If
    GetTextFileLines = items()
End Function

' The contents of a delimited text file as an array of strings arrays.

Function ImportDelimitedFile(filename As String, Optional delimiter As String = vbTab) As Variant()
Attribute ImportDelimitedFile.VB_Description = "The contents of a delimited text file as an array of strings arrays."
    Dim lines() As String, i As Long
    ' get all lines in the file, skipping over blank ones
    lines() = GetTextFileLines(filename, True)
    ' create a string array out of each line of text
    ' and store it into a Variant element
    ReDim values(0 To UBound(lines)) As Variant
    For i = 0 To UBound(lines)
        values(i) = Split(lines(i), delimiter, -1)
    Next
    ImportDelimitedFile = values()
End Function

' Write the contents of an array of string arrays to a delimited text file.

Sub ExportDelimitedFile(values() As Variant, filename As String, Optional delimiter As String = vbTab)
Attribute ExportDelimitedFile.VB_Description = "Write the contents of an array of string arrays to a delimited text file."
    Dim i As Long, j As Long, TextFile As String
    ' rebuild the individual lines of text of the file
    ReDim lines(0 To UBound(values)) As String
    For i = 0 To UBound(values)
        lines(i) = Join(values(i), delimiter)
    Next
    ' create CRLFs among records
    TextFile = Replace(Join(lines, vbCr), vbCr, vbCrLf)
    WriteTextFile TextFile, filename
End Sub

' Parse a filename into its components.

Sub SplitFilename(ByVal CompleteName As String, Path As String, File As String, Optional Extension As Variant)
Attribute SplitFilename.VB_Description = "Parse a filename into its components."
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

' The Path portion of a complete filename.

Function GetPath(ByVal CompleteFileName As String) As String
Attribute GetPath.VB_Description = "The Path portion of a complete filename."
    SplitFilename CompleteFileName, GetPath, ""
End Function

' The BaseFile portion of a complete filename

Function GetBaseName(ByVal CompleteFileName As String) As String
Attribute GetBaseName.VB_Description = "The BaseFile portion of a complete filename."
    ' you need to pass a dummy extension argument
    SplitFilename CompleteFileName, "", GetBaseName, ""
End Function

' The FileName portion of a complete filename.

Function GetFileName(ByVal CompleteFileName As String) As String
Attribute GetFileName.VB_Description = "The FileName portion of a complete filename."
    ' don't pass any extension argument
    SplitFilename CompleteFileName, "", GetFileName
End Function

' The Extension portion of a complete filename.

Function GetExtension(ByVal CompleteFileName As String) As String
Attribute GetExtension.VB_Description = "The Extension portion of a complete filename."
    SplitFilename CompleteFileName, "", "", GetExtension
End Function

' Builds a complete filename from its components

Function MakeFilename(ByVal Path As String, ByVal filename As String, Optional Extension As String) As String
Attribute MakeFilename.VB_Description = "Builds a complete filename from its components."
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


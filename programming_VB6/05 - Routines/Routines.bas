Attribute VB_Name = "Chap05"
'---------------------------------------------------------
' PROGRAMMING VB6 ROUTINE LIBRARY - (C) Francesco Balena
'
' (36+10) Routines in Chapter 05
'---------------------------------------------------------

Option Explicit

' API declares (used by the WaitForProcess routine)
Private Declare Function WaitForSingleObject Lib "kernel32" _
    (ByVal hHandle As Long, ByVal dwMilliseconds As Long) As Long
Private Declare Function OpenProcess Lib "kernel32" (ByVal dwAccess As _
    Long, ByVal fInherit As Integer, ByVal hObject As Long) As Long
Private Declare Function CloseHandle Lib "kernel32" _
    (ByVal hObject As Long) As Long


' a replacement for the "^" operator, when the exponent is an integer value
' it is at least 50% faster in native-compiled code

Function Power(ByVal number As Double, ByVal exponent As Long) As Double
    Dim result As Double
    If exponent < 0 Then Err.Raise 5  ' invalid procedure call or argument
    result = 1
    Do While exponent
        If exponent And 1 Then result = result * number
        number = number * number
        exponent = exponent \ 2
    Loop
    Power = result
End Function

' a MOD replacement that also works with floating point numbers
' Note: this differs from MOD when number is negative

Function FPMod(ByVal number As Double, ByVal divisor As Double) As Double
    FPMod = number - Int(number / divisor) * divisor
End Function

' base-10 logarithm

Function Log10(number As Double) As Double
    Log10 = Log(number) / 2.30258509299405
End Function

' "equal" up to their 10th decimal digit

Function AlmostEqual(x, y) As Boolean
    AlmostEqual = (Abs(x - y) <= 0.0000000001)
End Function

' a very fast routine that returns 2^N, with N in the range [0-31]

Function Power2(ByVal exponent As Long) As Long
    Static result(0 To 31) As Long, i As Integer
    ' evaluate powers of two only once
    If result(0) = 0 Then
        result(0) = 1
        For i = 1 To 30
            result(i) = result(i - 1) * 2
        Next
        result(31) = &H80000000        ' this is a special value
    End If
    Power2 = result(exponent)
End Function

' fractional part of a floating-point number
' note that negative numbers return negative values

Function Fract(number As Double) As Double
    Fract = number - Fix(number)
End Function

' the Greatest Common Divisor of two integers - Euclide's algorithm

Function Gcd(n1 As Long, n2 As Long) As Long
    Dim one As Long, two As Long, tmp As Long
    one = n1: two = n2
    If one > two Then
        tmp = one: one = two: two = tmp
    End If
    
    Do
        tmp = one: one = two: two = tmp
        one = one Mod two
    Loop While one
    Gcd& = two
End Function

' the Least Common Multiple of two integers - Euclide's algorithm

Function Lcm(n1 As Long, n2 As Long) As Long
    Dim one As Long, two As Long, tmp As Long
    one = n1: two = n2: tmp = n1 * n2
    If one > two Then
        tmp = one: one = two: two = tmp
    End If
                                                                              
    Do
        tmp = one: one = two: two = tmp
        one = one Mod two
    Loop While one
    Lcm = tmp \ two
End Function

' the factorial of a number (n = 0-170)

Function Factorial(number As Long) As Double
    Static result(170) As Double, i As Long
    ' illegal procedure call if negative
    If number < 0 Then Err.Raise 5
    ' overflow if too high
    If number > 170 Then Err.Raise 6
    
    ' evalutate all possible values in advance
    If result(0) = 0 Then
        result(0) = 1
        For i = 1 To UBound(result)
            result(i) = result(i - 1) * CDbl(i)
        Next
    End If
    Factorial = result(number)
End Function

' number of combinations of ITEMS elements in groups of GROUPSIZE
' combinations are all the possible arrangements you can combine N object
' in groups of K without distinguishing results that only differ in their order
' For example: Combinations(52,5) gives you the number of card hands you can receive

' Note: uses the Factorial routine

Function Combinations(items As Long, groupsize As Long) As Double
    Combinations = (Factorial(items) / Factorial(items - groupsize)) / Factorial(groupsize)
End Function

' number of permutations of ITEMS elements in groups of GROUPSIZE
' permutations are all the possible arrangements you can combine N object
' in groups of K when you distinguish results that differ in their order
' For example: Permutations(10,3) returns the number of permutation in which
' 1st, 2nd and 3rd prize can be assigned to a game with 10 playes

' Note: uses the Factorial routine

Function Permutations(items As Long, groupsize As Long) As Double
    Permutations = Factorial(items) / Factorial(items - groupsize)
End Function



' convert from degrees to radians

Function Radians(Degrees As Double) As Double
    Radians = Degrees / 57.29577951
End Function

' convert from radians to degrees

Function Degrees(Radians As Double) As Double
    Degrees = Radians * 57.29577951
End Function

' arc sine - error if NUMBER is outside the range [-1,1]

Function ASin(ByVal number As Double) As Double
    If Abs(number) <> 1 Then
        ASin = Atn(number / Sqr(1 - number * number))
    Else
        ASin = 1.5707963267949 * Sgn(number)
    End If
End Function

' arc cosine - error if NUMBER is outside the range [-1,1]

Function ACos(ByVal number As Double) As Double
    If Abs(number) <> 1 Then
        ACos = 1.5707963267949 - Atn(number / Sqr(1 - number * number))
    Else
        ACos = 3.14159265358979 * Sgn(number)
    End If
End Function

' arc tangent of Y/X
' returns values in all four quadrants

Function Atn2(x As Double, y As Double) As Double
    If x = 0 Then
        Atn2 = Sgn(y) * 1.5707963267949
    ElseIf x > 0 Then
        Atn2 = Atn(y / x)
    Else
        Atn2 = Atn(y / x) + 3.14159265358979 * (y < 0)
    End If
End Function

' convert from carthesian to polar coordinates
' Note: uses Atn2 routine

Sub XYToPolar(x As Double, y As Double, angle As Double, radius As Double)
    angle = Atn2(x, y)
    radius = Sqr(x * x + y * y)
End Sub

' convert from polar to carthesian coordinates

Sub PolarToXY(angle As Double, radius As Double, x As Double, y As Double)
    x = radius * Cos(angle)
    y = radius * Sin(angle)
End Sub


' returns the nearest integer equal or higher than the argument

Function Ceiling(number As Double) As Long
    Ceiling = -Int(-number)
End Function

' convert from decimal to binary

Function Bin(ByVal value As Long) As String
    Dim result As String, exponent As Integer
    ' this is faster than creating the string by appending chars
    result = String$(32, "0")
    Do
        If value And Power2(exponent) Then
            ' we found a bit that is set, clear it
            Mid$(result, 32 - exponent, 1) = "1"
            value = value Xor Power2(exponent)
        End If
        exponent = exponent + 1
    Loop While value
    Bin = Mid$(result, 33 - exponent)
End Function

' convert from binary to decimal

Function BinToDec(value As String) As Long
    Dim result As Long, i As Integer, exponent As Integer
    For i = Len(value) To 1 Step -1
        Select Case Asc(Mid$(value, i, 1))
            Case 48      ' "0", do nothing
            Case 49      ' "1", add the corresponding power of 2
                result = result + Power2(exponent)
            Case Else
                Err.Raise 5      ' Invalid procedure call or argument
        End Select
        exponent = exponent + 1
    Next
    BinToDec = result
End Function

' returns a random number in the range (low, high)

Function Rnd2(low As Single, high As Single) As Single
    Rnd2 = Rnd * (high - low) + low
End Function

' returns an array of Long values in the range specified
' without any duplicated value

'## ReplaceStatement Function RandomArray(first As Integer, last As Integer) As VB6Array(of Integer)
Function RandomArray(first As Long, last As Long) As Long()
    Dim i As Long, j As Long, temp As Long
   
   '##result.ArrayBounds ForceVB6Array
   Dim result() As Long
   
    ReDim result(first To last) As Long
    ' initialize the array
    For i = first To last
        result(i) = i
    Next
    ' now shuffle it
    For i = last To first Step -1
        ' generate a random number in the proper range
        j = Rnd * (last - first + 1) + first
        ' swap the two items
        temp = result(i): result(i) = result(j): result(j) = temp
    Next
    RandomArray = result
End Function

' count the number of sub-strings

Function InstrCount(source As String, search As String, Optional start As Long = 1, _
    Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
        Dim i As Long, result As Long
        i = InStr(start, source, search, Compare)
        Do While i
            result = result + 1
            i = InStr(i + 1, source, search, Compare)
        Loop
        InstrCount = result
End Function

' search the first occurrence of a character among those
' listed in SEARCHTABLE

Function InstrTbl(source As String, searchTable As String, Optional start As Long = 1, _
    Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
        Dim i As Long
        For i = start To Len(source)
            If InStr(1, searchTable, Mid$(source, i, 1), Compare) Then
                InstrTbl = i
                Exit For
            End If
        Next
End Function

' search the last occurrence of a character among those
' listed in SEARCHTABLE

Function InstrTblRev(source As String, searchTable As String, Optional ByVal start As Long = -1, _
    Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
        Dim i As Long
        If start < 0 Then start = Len(source)
        For i = start To 1 Step -1
            If InStr(1, searchTable, Mid$(source, i, 1), Compare) Then
                InstrTblRev = i
                Exit For
            End If
        Next
End Function

' a replacement for the built-in Split function, that works with
' multiple delimited chars

Function SplitMulti(source As String, delimTable As String, Optional Limit As Long = -1, _
    Optional Compare As VbCompareMethod = vbBinaryCompare) As String()
        Dim i As Long, start As Long, count As Long
        Dim result() As String
        ' we allocate the result array in chunks, to reduce overhead
        Const ALLOC_CHUNK = 50
        ReDim result(0 To ALLOC_CHUNK - 1) As String
        ' parse the string
        For i = 1 To Len(source)
            If InStr(1, delimTable, Mid$(source, i, 1), Compare) Then
                ' we have found a delimiter
                If start Then
                    ' if we were in the middle of a word
                    If count > UBound(result) Then
                        ' make room in the result array if necessary
                        ReDim Preserve result(0 To UBound(result) _
                            + ALLOC_CHUNK) As String
                    End If
                    result(count) = Mid$(source, start, i - start)
                    start = 0
                    count = count + 1
                    If count = Limit Then Exit For
                End If
            ElseIf start = 0 Then
                ' this isn't a delimiter - remember where the word starts
                start = i
            End If
        Next
        ' if we were in the middle of a word
        If start And count <> Limit Then
            ' make room in the result array if necessary, or trim it
            ReDim Preserve result(0 To count) As String
            result(count) = Mid$(source, start)
        Else
           ' trim the array to the actual number of items
           ReDim Preserve result(0 To count - 1) As String
        End If
        SplitMulti = result()
End Function

' wait for the current timer tick to elapse

Function NextTimerTick() As Single
    Dim t As Single
    t = Timer
    Do: Loop While t = Timer
    NextTimerTick = Timer
End Function

' insert a pause of a given duration (rounded to nearest integer)

Sub Pause(seconds As Integer)
    Const SECS_INDAY = 24! * 60 * 60    ' seconds per day
    Dim start As Single
    start = Timer
    Do: Loop Until (Timer + SECS_INDAY - start) Mod SECS_INDAY >= seconds
End Sub

' returns True if an year is a leap year

Function IsLeapYear(year As Integer) As Boolean
    ' does February 29 coincides with March 1 ?
    IsLeapYear = DateSerial(year, 2, 29) <> DateSerial(year, 3, 1)
End Function

' returns the attributes of a file in a readable format
' this routine also works with open files
' raises an error if the file doesn't exist

Function GetAttrDescr(filename As String) As String
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

' return an array of strings holding all the filenames that
' match a given filespec and search attributes

Function GetFiles(filespec As String, Optional Attributes As _
    VbFileAttribute) As String()
        Dim result() As String
        Dim filename As String, count As Long, path2 As String
        Const ALLOC_CHUNK = 50
        ReDim result(0 To ALLOC_CHUNK) As String
        filename = Dir$(filespec, Attributes)
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

' check if a file exists

Function FileExists(filename As String) As Boolean
    On Error Resume Next
    FileExists = (Dir$(filename) <> "")
End Function

' check if a directory exists

Function DirExists(path As String) As Boolean
    On Error Resume Next
    DirExists = (Dir$(path & "\nul") <> "")
End Function

' return an array of strings holding all the subdirectories in a path
' that match search attributes - optionally it returns the entire path

Function GetDirectories(path As String, Optional Attributes As _
    VbFileAttribute, Optional IncludePath As Boolean) As String()
        Dim result() As String
        Dim dirname As String, count As Long, path2 As String
        Const ALLOC_CHUNK = 50
        ReDim result(ALLOC_CHUNK) As String
        ' build the path name + backslash
        path2 = path
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

' load the names of all executable files in a directory tree into a ListBox
' Note: this is a recursive routine

Sub ListExecutableFiles(ByVal path As String, lst As ListBox)
    Dim names() As String, i As Long, j As Integer
    ' ensure that there is a trailing backslash
    If Right(path, 1) <> "\" Then path = path & "\"
    ' get the list of executable files
    For j = 1 To 4
        ' at each iteration search for a different extension
        names() = GetFiles(path & "*." & _
            Choose(j, "exe", "bat", "com", "pif"))
        ' load partial results in the listbox
        For i = 1 To UBound(names)
            lst.AddItem path & names(i)
        Next
    Next
    ' get the list of subdirectories, including hidden ones
    ' and call this routine recursively on all of them
    names() = GetDirectories(path, vbHidden)
    For i = 1 To UBound(names)
        ListExecutableFiles path & names(i), lst
    Next
End Sub

' load a text file into a TextBox control

Sub LoadFileInTextBox(filename As String, txt As TextBox)
    Dim fnum As Integer, isOpen As Boolean
    Dim textline As String, Text As String
    On Error GoTo Error_Handler
    ' get the next free file number
    fnum = FreeFile()
    Open filename For Input As #fnum
    ' if execution flow got here, the files has been open without error
    isOpen = True
    Do Until EOF(fnum)
        Line Input #fnum, textline
        Text = Text & textline & vbCrLf
    Loop
    ' load into the textbox
    txt.Text = Text
    ' intentionally flow into the error handler to close the file
Error_Handler:
    ' raise the error (if any), but first close the file
    If isOpen Then Close #fnum
    If Err Then Err.Raise Err.number, , Err.Description
End Sub

' returns the entire contents of a text file as a string

Function ReadTextFileContents(filename As String) As String
    Dim fnum As Integer, isOpen As Boolean
    On Error GoTo Error_Handler
    ' get the next free file number
    fnum = FreeFile()
    Open filename For Input As #fnum
    ' if execution flow got here, the file has been open without error
    isOpen = True
    ' read the entire contents in one single operation
    ReadTextFileContents = Input(LOF(fnum), fnum)
    ' intentionally flow into the error handler to close the file
Error_Handler:
    ' raise the error (if any), but first close the file
    If isOpen Then Close #fnum
    If Err Then Err.Raise Err.number, , Err.Description
End Function

' writes the contents of a string to a file, optionally in Append mode

Sub WriteTextFileContents(Text As String, filename As String, _
    Optional AppendMode As Boolean)
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
        If Err Then Err.Raise Err.number, , Err.Description
End Sub

' returns the contents of a text file as an array of strings
' NOTE: requires the ReadTextFileContents routine

Function GetTextFileLines(filename As String, Optional DropEmpty As Boolean, _
    Optional Limit As Variant) As String()
        Dim FileText As String, items() As String, i As Long
        ' read the file's contents, exit if any error
        FileText = ReadTextFileContents(filename)
        ' this is necessary, because Split() only accepts 1-char delimiters
        FileText = Replace(FileText, vbCrLf, vbCr)
        ' split the file in individual lines of text
        items() = Split(FileText, vbCr, Limit)
        ' drop empty lines, if requested
        If DropEmpty Then
            ' fill empty lines with something that other items
            ' surely don't contain
            For i = 0 To UBound(items)
                If Len(items(i)) = 0 Then items(i) = vbCrLf
            Next
            ' use the Filter() function to quickly drop empty lines
            items() = Filter(items(), vbCrLf, False)
        End If
        GetTextFileLines = items()
End Function

' returns the contents of a delimited text file as an array of strings arrays
' NOTE: requires the ReadTextFileContents and GetTextFileLines routines

Function ImportDelimitedFile(filename As String, _
    Optional delimiter As String = vbTab) As Variant()
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

' write the contents of an array of string arrays to a delimited text file
' NOTE: requires the WriteTextFileContents routine

Sub ExportDelimitedFile(values() As Variant, filename As String, _
    Optional delimiter As String = vbTab)
        Dim i As Long, j As Long, TextFile As String
        ' rebuild the individual lines of text of the file
        ReDim lines(0 To UBound(values)) As String
        For i = 0 To UBound(values)
            lines(i) = Join(values(i), delimiter)
        Next
        ' create CRLFs among records
        TextFile = Replace(Join(lines, vbCr), vbCr, vbCrLf)
        WriteTextFileContents TextFile, filename
End Sub

' Duplicate a directory tree without also copying the files

' call this routine to initiate the copy process
' NOTE: the destination folder is created if necessary
'       uses the Private Sub DuplicateDirTreeSub procedure

Sub DuplicateDirTree(SourcePath As String, DestPath As String)
    Dim fso As New Scripting.FileSystemObject
    Dim sourceFld As Scripting.Folder, destFld As Scripting.Folder
    ' the source folder must exists
    Set sourceFld = fso.GetFolder(SourcePath)
    ' the destination folder is created if necessary
    If fso.FolderExists(DestPath) Then
        Set destFld = fso.GetFolder(DestPath)
    Else
        Set destFld = fso.CreateFolder(DestPath)
    End If
    ' jump to the recursive routine to do the real job
    DuplicateDirTreeSub sourceFld, destFld
End Sub

' Private recursive procedure used by DuplicateDirTree

Private Sub DuplicateDirTreeSub(source As Folder, destination As Folder)
    Dim sourceFld As Scripting.Folder, destFld As Scripting.Folder
    For Each sourceFld In source.SubFolders
        ' copy this subfolder into destination folder
        Set destFld = destination.SubFolders.Add(sourceFld.Name)
        ' then repeat the process recursively for all
        ' the subfolders of the folder just considered
        DuplicateDirTreeSub sourceFld, destFld
    Next
End Sub

' search all the TXT files in a directory for a string

' for each matching file returns a Variant element that contains a
' 3-item array that holds the filename, the line and the column line
' NOTE: all searches are case insensitive

Function SearchTextFiles(path As String, search As String) As Variant()
    Dim fso As New Scripting.FileSystemObject
    Dim fil As Scripting.File, ts As Scripting.TextStream
    Dim pos As Long, count As Long
    ReDim result(50) As Variant
    ' search for all the TXT files in the directory
    For Each fil In fso.GetFolder(path).Files
        If UCase$(fso.GetExtensionName(fil.path)) = "TXT" Then
            ' get the corresponding TextStream object
            Set ts = fil.OpenAsTextStream(ForReading)
            ' read its contents, search the string, close it
            pos = InStr(1, ts.ReadAll, search, vbTextCompare)
            ts.Close
            If pos > 0 Then
                ' if the string has been found, reopen the file
                ' to determine its position in terms of (line,column)
                Set ts = fil.OpenAsTextStream(ForReading)
                ' skip all preceding characters to get where we want
                ts.Skip pos - 1
                ' fill the result array, make room if necessary
                count = count + 1
                If count > UBound(result) Then
                    ReDim Preserve result(UBound(result) + 50) As Variant
                End If
                ' each result item is a three-element array
                result(count) = Array(fil.path, ts.Line, ts.Column)
                ' now we may close the TextStrem
                ts.Close
            End If
        End If
    Next
    ' resize the result array to indicate number of matches
    ReDim Preserve result(0 To count) As Variant
    SearchTextFiles = result
End Function

' wait for a number of milliseconds and return the running status of a
' process - if argument is omitted, wait until the process terminates

Function WaitForProcess(taskId As Long, Optional msecs As Long = -1) _
    As Boolean
        Dim procHandle As Long
        ' get the process handle
        procHandle = OpenProcess(&H100000, True, taskId)
        ' check for its signaled status, return to caller
        WaitForProcess = WaitForSingleObject(procHandle, msecs) <> -1
        ' close the handle
        CloseHandle procHandle
End Function



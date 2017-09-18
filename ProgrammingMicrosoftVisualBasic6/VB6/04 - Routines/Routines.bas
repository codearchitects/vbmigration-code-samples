Attribute VB_Name = "Chap04"
'---------------------------------------------------------
' PROGRAMMING VB6 ROUTINE LIBRARY - (C) Francesco Balena
'
' (26) Routines in Chapter 04
'---------------------------------------------------------

'##DisableMessages CodeAnalysis
'##project:DisableMessage 0354
'##project:DisableMessage 0364

'##project:ArrayBounds ForceVB6Array

Option Explicit

' this API function is used by InsertArrayItemLong and DeleteArrayItemLong
Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" _
    (dest As Any, source As Any, ByVal numBytes As Long)

' a sample GlobalUDT structure (change as needed)
Public Type GlobalUDT
    InvoiceCount As Long
    UserName As String
    ' ....
End Type

' a global instance of the GlobalUDT structure
Public glo As GlobalUDT

' the same routine can save and load global data in GLO

Sub SaveLoadGlobalData(filename As String, Save As Boolean)
    Dim filenum As Integer, isOpen As Boolean
    On Error GoTo Error_Handler
    filenum = FreeFile
    Open filename For Binary As filenum
    isOpen = True
    If Save Then
        Put #filenum, , glo
    Else
        Get #filenum, , glo
    End If
Error_Handler:
    If isOpen Then Close #filenum
End Sub

' a Reciprocal function that returns a Variant containing
' its result or an error code

Function Reciprocal(n As Double) As Variant
    If n <> 0 Then
        Reciprocal = 1 / n
    Else
        Reciprocal = CVErr(11)    ' Division by zero error code
    End If
End Function

' a polymorphic function that sums the values in any array

Function ArraySum(arr As Variant) As Variant
    Dim i As Long, result As Variant
    For i = LBound(arr) To UBound(arr)
        result = result + arr(i)
    Next
    ArraySum = result
End Function

' returns the number of dimensions of the array
' passed as an argument, or zero if it isn't an array

Function NumberOfDims(arr As Variant) As Integer
    Dim dims As Integer, dummy As Long
    On Error Resume Next
    Do
        dummy = UBound(arr, dims + 1)
        If Err Then Exit Do
        dims = dims + 1
    Loop
    NumberOfDims = dims
End Function

' a polymorphic sum function that also works with bi-dimensional matrices

Function ArraySum2(arr As Variant) As Variant
    Dim i As Long, j As Long, result As Variant
    ' first, check if we can really work with this array
    Select Case NumberOfDims(arr)
        Case 1       ' mono-dimensional array
            For i = LBound(arr) To UBound(arr)
                result = result + arr(i)
            Next
        Case 2       ' bi-dimensional matrix
            For i = LBound(arr) To UBound(arr)
                For j = LBound(arr, 2) To UBound(arr, 2)
                    result = result + arr(i, j)
                Next
            Next
        Case Else   ' not an array, or too many dimensions
            Err.Raise 1001, , "Not an array or bi-dimensional matrix"
    End Select
    ArraySum2 = result
End Function

' returns an array of long that that includes all natural
' numbers in the range FIRST to LAST

Function InitArray(first As Long, last As Long) As Long()
   Dim result() As Long     ' Manually added
   ReDim result(first To last) As Long
   Dim i As Long
   For i = first To last: result(i) = i: Next
   InitArray = result
End Function

' returns a portion of a Long array
' Note: fails if FIRST or LAST are not valid

Function SubArray(arr() As Long, first As Long, last As Long, _
    newFirstIndex As Long) As Long()
        Dim i As Long, j As Long
        Dim result() As Long     ' Manually added
        ReDim result(newFirstIndex To last - first) As Long
        j = newFirstIndex
        For i = first To last
            result(j) = arr(i)
            j = j + 1
        Next
        SubArray = result
End Function

' returns an array with all the selected items in
' the ListBox control passed as argument

Function SelectedListItems(lst As ListBox) As String()
    Dim i As Long, j As Long
    ReDim result(0 To lst.SelCount) As String
    For i = 0 To lst.ListCount - 1
        If lst.Selected(i) Then
            j = j + 1
            result(j) = lst.List(i)
        End If
    Next
    SelectedListItems = result
End Function

' return an array with the first N prime numbers
Function PrimeArray(numberOfPrimes As Long) As Long()
    Dim found As Long, n As Long, i As Long
    If numberOfPrimes <= 0 Then Err.Raise 1002, , "Invalid argument"
    Dim result() As Long     ' Manually added
    ' we know the size of the result in advance
    ReDim result(1 To numberOfPrimes) As Long
    ' "2" is the first prime number
    result(1) = 2: found = 1
    n = 1
    Do While found < numberOfPrimes
        ' all other prime numbers are odd, so we can skip even numbers
        n = n + 2
        ' let's check if N is a prime number
        For i = 1 To found
            If (n Mod result(i)) = 0 Then Exit For
        Next
        If i > found Then
            ' no prime number < N is a divisor for N, therefore N is prime
            found = found + 1
            result(found) = n
        End If
    Loop
    PrimeArray = result
End Function

' optimized routine that counts the spaces in a string
' NOTE: this function doesn't work with non-Latin alphabets

Function CountSpaces(Text As String) As Long
   '##b.ArrayBounds Unchanged
    Dim b() As Byte, i As Long, result As Long
    b() = Text
    For i = 0 To UBound(b) Step 2
        ' only consider even-numbered items
        If b(i) = 32 Then result = result + 1
    Next
    CountSpaces = result
End Function

' polymorphic routine that inserts an item in an array

Sub InsertArrayItem(arr As Variant, index As Long, newValue As Variant)
    Dim i As Long
    For i = UBound(arr) - 1 To index Step -1
        arr(i + 1) = arr(i)
    Next
    arr(index) = newValue
End Sub

' polymorphic routine that deletes an item from an array

Sub DeleteArrayItem(arr As Variant, index As Long)
    Dim i As Long
    For i = index To UBound(arr) - 1
        arr(i) = arr(i + 1)
    Next
    ' VB will convert this into zero or a null string
    arr(UBound(arr)) = Empty
End Sub

' optimized routine that inserts an element in an array of Longs
' uses the CopyMemory API function
' you can modify this code to make it work with other data types
' by simply modifying the first and last "As Long" clause in the parameter list

Sub InsertArrayItemLong(arr() As Long, index As Long, newValue As Long)
    ' note that we let VB evaluate the size of each item using Len()
    If index < UBound(arr) Then
        CopyMemory arr(index + 1), arr(index), _
            (UBound(arr) - index) * LenB(arr(index))
    End If
    arr(index) = newValue
End Sub

' optimized routine that deletes an element in an array of Longs
' uses the CopyMemory API function
' you can modify this code to make it work with other data types
' by simply modifying the first "As Long" clause in the parameter list

Sub DeleteArrayItemLong(arr() As Long, index As Long)
    ' note that we let VB evaluate the size of each item using LenB()
    If index < UBound(arr) Then
        CopyMemory arr(index), arr(index + 1), _
            (UBound(arr) - index) * LenB(arr(index))
    End If
    arr(index) = Empty
End Sub

' polymorphic sort routine that works with any type of array

Sub ShellSortAny(arr As Variant, numEls As Long, descending As Boolean)
    Dim index As Long, index2 As Long
    Dim firstItem As Long, inverseOrder As Boolean
    Dim distance As Long, value As Variant
    ' exit if it is not an array
    If VarType(arr) < vbArray Then Exit Sub
    firstItem = LBound(arr)
    ' find the best value for distance
    Do
        distance = distance * 3 + 1
    Loop Until distance > numEls
    ' sort the array
    Do
        distance = distance \ 3
        For index = distance + 1 To numEls
            value = arr(index)
            index2 = index
            Do While (arr(index2 - distance) > value) Xor descending
                arr(index2) = arr(index2 - distance)
                index2 = index2 - distance
                If index2 <= distance Then Exit Do
            Loop
            arr(index2) = value
        Next
    Loop Until distance = 1
End Sub

' returns True if an item in a collection actually exists

Function ItemExists(col As Collection, Key As String) As Boolean
    Dim dummy As Variant
    On Error Resume Next
    dummy = col.Item(Key)
    ItemExists = (Err = 0)
End Function

' remove all items in a collection

Sub RemoveAllItems(col As Collection)
    Do While col.Count
        col.Remove 1
    Loop
End Sub

' replace an item in a collection
' INDEX can be either a numeric or a string value

Sub ReplaceItem(col As Collection, index As Variant, newValue As Variant)
    ' first, remove that item (exits with error if it doesn't exist)
    col.Remove index
    ' then, add it again
    If VarType(index) = vbString Then
        ' add a new item with the same string key
        col.Add newValue, index
    Else
        ' add a new item in the same position (without any key)
        col.Add newValue, , index
    End If
End Sub

' polymorphic routine that filters out all duplicate entries in an array
' on entry NUMELS should be set to the number of items to be examined
' on exit it holds the number of non duplicate items

Sub FilterDuplicates(arr As Variant, numEls As Long)
    Dim col As New Collection, i As Long, j As Long
    On Error Resume Next
    j = LBound(arr) - 1
    For i = LBound(arr) To numEls
        col.Add 0, CStr(arr(i))
        If Err = 0 Then
            j = j + 1
            If i <> j Then arr(j) = arr(i)
        Else
            Err.Clear
        End If
    Next
    ' clear all remaining items
    For i = j + 1 To numEls: arr(i) = Empty: Next
    numEls = j
End Sub

' this function returns the special "Missing" value
' NOTE: always call this function without any argument

Function MissingValue(Optional DontPassThis As Variant) As Variant
    MissingValue = DontPassThis
End Function

' a routine that works as a wrapper around the InputBox function
' and automatically uses the App.HelpFile property if an HelpContextID is provided

Function PromptValue(Prompt As String, Optional Title As Variant, _
    Optional Default As Variant, Optional Context As Variant) As String
        PromptValue = InputBox(Prompt, Title, Default, , , IIf(App.HelpFile = "" _
            Or IsMissing(Context), Context, App.HelpFile), Context)
End Function

' a function that sums all the values you pass to it
' or concatenates them if they are strings

Function Sum(ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    For i = LBound(args) To UBound(args)
        result = result + args(i)
    Next
    Sum = result
End Function

' a function that returns the highest value among passed arguments

Function Max(first As Double, ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    result = first
    For i = LBound(args) To UBound(args)
        If args(i) > result Then result = args(i)
    Next
    Max = result
End Function

' a function that returns the lowest value among passed arguments

Function Min(first As Double, ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    result = first
    For i = LBound(args) To UBound(args)
        If args(i) < result Then result = args(i)
    Next
    Min = result
End Function

' a function that builds an array of Longs on the fly
' (similar to VBA's Array(), which only creates Variant arrays)

Function ArrayLong(ParamArray args() As Variant) As Long()
    Dim numEls As Long, i As Long
    numEls = UBound(args) - LBound(args) + 1
    If numEls <= 0 Then Err.Raise 5     ' invalid procedure call
    ReDim result(0 To numEls - 1) As Long
    For i = 0 To numEls - 1
        result(i) = args(i)
    Next
    ArrayLong = result
End Function

' check that a drive contains a disk with a given volume label
' if it doesn't, asks the user to retry or cancel the operation
' returns True if the volume label matches, False otherwise

Function CheckDisk(ByVal Drive As String, VolumeLabel As String) As Boolean
    Dim saveDir As String, answer As Integer
    On Error GoTo Error_Handler
    Drive = Left$(Drive, 1)
    ' try to make that drive the current one
    saveDir = CurDir$
    ' next statement is likely to fire an error
    ChDrive Drive
    ' return True if the label matches, False otherwise
    CheckDisk = (StrComp(Dir$(Drive & ":\*.*", vbVolume), _
        VolumeLabel, vbTextCompare) = 0)
    ' restore the original current drive
    ChDrive saveDir
    Exit Function
Error_Handler:
    If Err <> 68 And Err <> 71 Then
        ' if Device unavailable/Disk Not Ready, report it to the caller
        Err.Raise Err.Number, Err.source, Err.Description
    End If
    ' if it is a floppy disk, give the user a second chance
    If InStr(1, "AB", Drive, vbTextCompare) Then
        answer = MsgBox("Please enter a disk in drive " & Drive, _
            vbExclamation + vbRetryCancel)
        If answer = vbRetry Then Resume
    End If
    ' else Resume with the next statement (returns False)
    Resume Next
End Function







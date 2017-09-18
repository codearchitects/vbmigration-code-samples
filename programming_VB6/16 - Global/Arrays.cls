VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Arrays"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "Array routines"
'---------------------------------------------------------
' Array routines
'---------------------------------------------------------

Option Explicit

Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, source As Any, ByVal bytes As Long)

' A polymorphic function that sums the values in any array.

Function ArraySum(arr As Variant) As Variant
Attribute ArraySum.VB_Description = "A polymorphic function that sums the values in any array."
Attribute ArraySum.VB_MemberFlags = "400"
    Dim i As Long, result As Variant
    For i = LBound(arr) To UBound(arr)
        result = result + arr(i)
    Next
    ArraySum = result
End Function

' The number of dimensions of the array passed as an argument,
' or zero if it isn't an array

Function NumberOfDims(arr As Variant) As Integer
Attribute NumberOfDims.VB_Description = "The number of dimensions of the array passed as an argument, or zero if it isn't an array."
    Dim dims As Integer, dummy As Long
    On Error Resume Next
    Do
        dummy = UBound(arr, dims + 1)
        If Err Then Exit Do
        dims = dims + 1
    Loop
    NumberOfDims = dims
End Function

' A polymorphic sum function that also works with bi-dimensional matrices

Function ArraySum2(arr As Variant) As Variant
Attribute ArraySum2.VB_Description = "A polymorphic sum function that also works with bi-dimensional matrices."
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

' An array of Long that that includes all natural
' numbers in the range FIRST to LAST

Function InitArray(first As Long, last As Long) As Long()
Attribute InitArray.VB_Description = "An array of Long that that includes all natural numbers in the range FIRST to LAST."
    ' MIGRATION NOTE !!!!: Non-sense in using redim with a new array
    'ReDim result(first To last) As Long
    '##result.ArrayBounds ForceZero
    Dim result(first To last) As Long
    Dim i As Long
    For i = first To last: result(i) = i: Next
    InitArray = result
End Function

' A portion of a Long array
' Note: fails if FIRST or LAST are not valid

Function SubArray(arr() As Long, first As Long, last As Long, _
    newFirstIndex As Long) As Long()
Attribute SubArray.VB_Description = "A portion of a Long array."
        Dim i As Long, j As Long
        ' MIGRATION NOTE !!!!: Non-sense in using redim with a new array
        'ReDim result(newFirstIndex To last - first) As Long
        '##result.ArrayBounds ForceZero
        Dim result(newFirstIndex To last - first) As Long
        j = newFirstIndex
        For i = first To last
            result(j) = arr(i)
            j = j + 1
        Next
        SubArray = result
End Function

' Polymorphic routine that inserts an item in an array.

Sub InsertArrayItem(arr As Variant, index As Long, newValue As Variant)
Attribute InsertArrayItem.VB_Description = "Polymorphic routine that inserts an item in an array."
    Dim i As Long
    For i = UBound(arr) - 1 To index Step -1
        arr(i + 1) = arr(i)
    Next
    arr(index) = newValue
End Sub

' Polymorphic routine that deletes an item from an array.

Sub DeleteArrayItem(arr As Variant, index As Long)
Attribute DeleteArrayItem.VB_Description = "Polymorphic routine that deletes an item from an array."
    Dim i As Long
    For i = index To UBound(arr) - 1
        arr(i) = arr(i + 1)
    Next
    ' VB will convert this into zero or a null string
    arr(UBound(arr)) = Empty
End Sub

' Inserts an element in an array of Longs.
' Notes: you can modify this code to make it work with other data types
' by simply modifying the first and last "As Long" clause in the parameter list

Sub InsertArrayItemLong(arr() As Long, index As Long, newValue As Long)
Attribute InsertArrayItemLong.VB_Description = "Inserts an element in an array of Longs."
    ' note that we let VB evaluate the size of each item using Len()
    If index < UBound(arr) Then
        CopyMemory arr(index + 1), arr(index), _
            (UBound(arr) - index) * LenB(arr(index))
    End If
    arr(index) = newValue
End Sub

' Deletes an element in an array of Longs.
' Note: you can modify this code to make it work with other data types
' by simply modifying the first "As Long" clause in the parameter list

Sub DeleteArrayItemLong(arr() As Long, index As Long)
Attribute DeleteArrayItemLong.VB_Description = "Deletes an element in an array of Longs."
    ' note that we let VB evaluate the size of each item using LenB()
    If index < UBound(arr) Then
        CopyMemory arr(index), arr(index + 1), _
            (UBound(arr) - index) * LenB(arr(index))
    End If
    arr(index) = Empty
End Sub

' Polymorphic sort routine.

Sub ShellSortAny(arr As Variant, numEls As Long, descending As Boolean)
Attribute ShellSortAny.VB_Description = "Polymorphic sort routine."
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

' Polymorphic routine that filters out all duplicate entries in an array.
' on entry NUMELS should be set to the number of items to be examined,
' on exit it holds the number of non duplicate items

Sub FilterDuplicates(arr As Variant, numEls As Long)
Attribute FilterDuplicates.VB_Description = "Polymorphic routine that filters out all duplicate entries in an array. on entry NUMELS should be set to the number of items to be examined, on exit it holds the number of non duplicate items."
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

' Builds an array of Longs on the fly.
' Notes: similar to VBA's Array(), which only creates Variant arrays

Function ArrayLong(ParamArray args() As Variant) As Long()
Attribute ArrayLong.VB_Description = "Builds an array of Longs on the fly."
    Dim numEls As Long, i As Long
    numEls = UBound(args) - LBound(args) + 1
    If numEls <= 0 Then Err.Raise 5     ' invalid procedure call
    ReDim result(0 To numEls - 1) As Long
    For i = 0 To numEls - 1
        result(i) = args(i)
    Next
    ArrayLong = result
End Function


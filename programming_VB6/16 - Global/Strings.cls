VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Strings"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "String routines"
'---------------------------------------------------------
' String routines
'---------------------------------------------------------

Option Explicit

' The decimal separator charactor (locale-aware).

Function DecimalSepChar() As String
Attribute DecimalSepChar.VB_Description = "The decimal separator charactor (locale-aware)."
    DecimalSepChar = Format$(0.1, ".")
End Function

' The thousand separator character (locale-aware).

Function ThousandSepChar() As String
Attribute ThousandSepChar.VB_Description = "The thousand separator character (locale-aware)."
    ThousandSepChar = Format$(1, ",")
End Function

' True if a string holds a valid numeric value.
' Works better than IsDecimal, and can reject non-integer values.

Function CheckNumeric(Text As String, DecValue As Boolean) As Boolean
Attribute CheckNumeric.VB_Description = "True if a string holds a valid numeric value. Works better than IsNumeric, and can reject non-integer values."
    Dim i As Integer, decSep As String
    ' retrieve the decimal separator symbol
    decSep = Format$(0.1, ".")
    For i = 1 To Len(Text)
        Select Case Mid$(Text, i, 1)
            Case "0" To "9"
            Case "-", "+"
                ' minus/plus sign are only allowed
                ' as leading chars
                If i > 1 Then Exit Function
            Case decSep
                ' exit if decimal values not allowed
                If Not DecValue Then Exit Function
                ' only one decimal separator is allowed
                If InStr(Text, decSep) < i Then Exit Function
            Case Else
                ' reject all other characters
                Exit Function
        End Select
    Next
    CheckNumeric = True
End Function

' Filter out all invalid characters in a string.

Function FilterString(Text As String, ValidChars As String) As String
Attribute FilterString.VB_Description = "Filter out all invalid characters in a string."
    Dim i As Long, result As String
    For i = 1 To Len(Text)
        If InStr(ValidChars, Mid$(Text, i, 1)) Then
            result = result & Mid$(Text, i, 1)
        End If
    Next
    FilterString = result
End Function

' Filter out all formatting characters in a string that contains a number. Ccorrectly accounts for the current decimal separator character.

Function FilterNumber(Text As String, TrimZeroes As Boolean) As String
Attribute FilterNumber.VB_Description = "Filter out all formatting characters in a string that contains a number. Ccorrectly accounts for the current decimal separator character."
    Dim decSep As String, i As Long, result As String
    ' retrieve the decimal separator symbol
    decSep = Format$(0.1, ".")
    ' use FilterString for most of the work
    result = FilterString(Text, decSep & "-0123456789")
    ' only if there is a decimal part and the
    ' user requested to trim non-significant digits
    If TrimZeroes And InStr(Text, decSep) > 0 Then
        For i = Len(result) To 1 Step -1
            Select Case Mid$(result, i, 1)
                Case decSep
                    result = Left$(result, i - 1)
                    Exit For
                Case "0"
                    result = Left$(result, i - 1)
                Case Else
                    Exit For
            End Select
        Next
    End If
    FilterNumber = result
End Function

' Format a phone-number in the format "XXX-XXX-XXXX".

Function FormatPhoneNumber(Text As String) As String
Attribute FormatPhoneNumber.VB_Description = "Format a phone-number in the format ""XXX-XXX-XXXX""."
    Dim tmp As String
    If Len(Text) Then
        ' first, get rid of all embedded dashes, if any
        tmp = FilterString(Text, "0123456789")
        ' then, re-insert them in the correct position
        If Len(tmp) <= 7 Then
            FormatPhoneNumber = Format$(tmp, "!@@@-@@@@")
        Else
            FormatPhoneNumber = Format$(tmp, "!@@@-@@@-@@@@")
        End If
    End If
End Function

' Format a credit card number.

Function FormatCreditCard(Text As String) As String
Attribute FormatCreditCard.VB_Description = "Format a credit card number."
    Dim tmp As String
    If Text <> "" Then
        ' first, get rid of all embedded spaces,if any
        tmp = FilterNumber(Text, False)
        ' then, re-insert them in the correct position
        FormatCreditCard = Format$(tmp, "!@@@@ @@@@ @@@@ @@@@")
    End If
End Function

' Count the number of substrings.

Function InstrCount(source As String, search As String, Optional start As Long = 1, _
    Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
Attribute InstrCount.VB_Description = "Count the number of substrings."
        InstrCount = Len(source) - Len(Replace(source, search, Mid$(search, 2), , , Compare))
End Function

' Search the first occurrence of a character among those listed in SearchTable.

Function InstrTbl(source As String, searchTable As String, Optional start As Long = 1, Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
Attribute InstrTbl.VB_Description = "Search the first occurrence of a character among those listed in SearchTable."
    Dim i As Long
    For i = start To Len(source)
        If InStr(1, searchTable, Mid$(source, i, 1), Compare) Then
            InstrTbl = i
            Exit For
        End If
    Next
End Function

' Search the last occurrence of a character among those listed in SearchTable.

Function InstrTblRev(source As String, searchTable As String, Optional ByVal start As Long = -1, Optional Compare As VbCompareMethod = vbBinaryCompare) As Long
Attribute InstrTblRev.VB_Description = "Search the last occurrence of a character among those listed in SearchTable."
    Dim i As Long
    If start < 0 Then start = Len(source)
    For i = start To 1 Step -1
        If InStr(1, searchTable, Mid$(source, i, 1), Compare) Then
            InstrTblRev = i
            Exit For
        End If
    Next
End Function

' A replacement for the built-in Split function, that works with multiple delimited chars.

Function SplitMulti(source As String, delimTable As String, Optional Limit As Long = -1, Optional Compare As VbCompareMethod = vbBinaryCompare) As String()
Attribute SplitMulti.VB_Description = "A replacement for the built-in Split function, that works with multiple delimited chars."
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


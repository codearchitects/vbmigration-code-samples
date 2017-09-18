VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsPhoneme"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

'// Please see the accompanying documentation for the algorithms

'// Returns the 4 letter soundex for an english word
Private Function Soundex(argWord As String)
Dim workStr As String, i As Long, replaceMask(5) As Boolean

    '// Capitalize it to remove ambiguity
    argWord = UCase$(argWord)
    
    '// 1. Retain the first letter of the string
    workStr = Left$(argWord, 1)
    
    '// 2. Replacement
    '   [a, e, h, i, o, u, w, y] = 0
    '   [b, f, p, v] = 1
    '   [c, g, j, k, q, s, x, z] = 2
    '   [d, t] = 3
    '   [l] = 4
    '   [m, n] = 5
    '   [r] = 6
    
    For i = 2 To Len(argWord)
        Select Case Mid$(argWord, i, 1)
            Case "B", "F", "P", "V"
                If replaceMask(0) = False Then
                    workStr = workStr & Chr$(49) '// 1
                    replaceMask(0) = True
                End If
                
            Case "C", "G", "J", "K", "Q", "S", "X", "Z"
                If replaceMask(1) = False Then
                    workStr = workStr & Chr$(50) '// 2
                    replaceMask(1) = True
                End If
            
            Case "D", "T"
                If replaceMask(2) = False Then
                    workStr = workStr & Chr$(51) '// 3
                    replaceMask(2) = True
                End If
            
            Case "L"
                If replaceMask(3) = False Then
                    workStr = workStr & Chr$(52) '// 4
                    replaceMask(3) = True
                End If
            
            Case "M", "N"
                If replaceMask(4) = False Then
                    workStr = workStr & Chr$(53) '// 5
                    replaceMask(4) = True
                End If
                
            Case "R"
                If replaceMask(5) = False Then
                    workStr = workStr & Chr$(56) '// 6
                    replaceMask(5) = True
                End If
            
            '// A, E, H, I, O, U, W, Y do nothing
        End Select
    Next i
    
    '// 5. Return the first four bytes padded with 0.
    If Len(workStr) > 4 Then
        Soundex = Left$(workStr, 4)
    Else
        Soundex = workStr & Space$(4 - Len(workStr))
    End If
End Function

'// Returns the Minimum of 3 numbers
Private Function min3(ByVal n1 As Long, ByVal n2 As Long, ByVal n3 As Long) As Long
    min3 = n1
    If n2 < min3 Then min3 = n2
    If n3 < min3 Then min3 = n3
End Function

'// Returns the Levenshtein Distance between 2 strings.
Private Function LevenshteinDistance(argStr1 As String, argStr2 As String) As Long
Dim m As Long, n As Long
Dim editMatrix() As Long, i As Long, j As Long, cost As Long
Dim str1_i As String, str2_j As String
Dim p() As Long, q() As Long, r As Long
Dim x As Long, y As Long

    n = Len(argStr1)
    m = Len(argStr2)
    
    'If (n = 0) Or (m = 0) Then Exit Function
    ReDim editMatrix(n, m) As Long
    
    
    For i = 0 To n
        editMatrix(i, 0) = i
    Next
    
    For j = 0 To m
        editMatrix(0, j) = j
    Next
    
    For i = 1 To n
        str1_i = Mid$(argStr1, i, 1)
        For j = 1 To m
            str2_j = Mid$(argStr2, j, 1)
            If str1_i = str2_j Then
                cost = 0
            Else
                cost = 1
            End If
            
            editMatrix(i, j) = min3(editMatrix(i - 1, j) + 1, editMatrix(i, j - 1) + 1, editMatrix(i - 1, j - 1) + cost)
        Next j
    Next i
            
    LevenshteinDistance = editMatrix(n, m)
    Erase editMatrix
End Function


Public Function GetSoundexWord(ByVal inputStr As String) As String
    If inputStr <> vbNullString Then GetSoundexWord = Soundex(inputStr)
End Function

Public Function GetLevenshteinDistance(ByVal inputStr1 As String, ByVal inputStr2 As String) As Long
    If inputStr1 = vbNullString Then
        GetLevenshteinDistance = Len(inputStr2)
    ElseIf inputStr2 = vbNullString Then
        GetLevenshteinDistance = Len(inputStr1)
    Else
        GetLevenshteinDistance = LevenshteinDistance(inputStr1, inputStr2)
    End If
End Function

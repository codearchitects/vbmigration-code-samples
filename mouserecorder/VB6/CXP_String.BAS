Attribute VB_Name = "CXP_String"
'---------------------------------------------------------------------------------'
' CXP_String Module (C)2002 by CodeXP                             CodeXP@Lycos.de '
'---------------------------------------------------------------------------------'
' YOU CAN USE, YOU CAN CHANGE IT, BUT GIVE IT OTHERS AS IS (WITHOUT CHANGES)      '
'---------------------------------------------------------------------------------'
Option Explicit

'---------------------------------------------------------------------------------'
' GetTokenString Function                                                         '
'---------------------------------------------------------------------------------'
Public Function GetTokenString(ByVal gtString As String, _
                ByVal gtIndex As Long, ByVal gtDelimiter As String) As String
  Dim gtNextDelimiter As Long, gtDelimitedString As String
  Dim gtLastDelimiter As Long, gtDelimiterCounter As Long
  
  ' If Params are Empty then Exit '
  If gtString = "" Or gtDelimiter = "" Or gtIndex < 1 Then Exit Function
  ' Get first Delimiter Position  '
  gtNextDelimiter = InStr(gtString, gtDelimiter)
  ' If first Delimiter was not found then Return gtString '
  If gtNextDelimiter = 0 Then gtDelimitedString = gtString
  
  ' Loop until Delimiter is not Found '
  Do Until gtNextDelimiter = 0
    ' Count up our Delimiters '
    gtDelimiterCounter = gtDelimiterCounter + 1
    ' BackUp our Delimiter Position '
    gtLastDelimiter = gtNextDelimiter
    
    ' The first Delimiter Index is always the first '
    ' Delimited String in the Begin of a String !!  '
    ' For this Reason we don't get the Next         '
    ' Delimiter Position.                           '
    If gtDelimiterCounter > 1 Then
      ' Get Next Delimiter Position '
      gtNextDelimiter = InStr(gtNextDelimiter + Len(gtDelimiter), gtString, gtDelimiter)
    End If
    
    'If asked Delimiter Index matches '
    If gtIndex = gtDelimiterCounter Then
      If gtDelimiterCounter = 1 Then
        ' Get Detimited String at Beginn  '
        gtDelimitedString = Left(gtString, gtLastDelimiter - 1)
      Else
        If gtNextDelimiter = 0 Then
          ' Get Detimited String at End '
          gtDelimitedString = Mid(gtString, gtLastDelimiter + Len(gtDelimiter))
        Else
          ' Get Detimited String at Middle of String  '
          gtDelimitedString = Mid(gtString, gtLastDelimiter + Len(gtDelimiter), _
                                  gtNextDelimiter - gtLastDelimiter - Len(gtDelimiter))
        End If
      End If
      ' Get out of Loop '
      Exit Do
    End If
  Loop
  
  ' Return Delimited String '
  GetTokenString = gtDelimitedString
End Function

'---------------------------------------------------------------------------------'
' GetDelimiterCount Function                                                      '
'---------------------------------------------------------------------------------'
Public Function GetDelimiterCount(ByVal gtString As String, _
                ByVal gtDelimiter As String) As Long
  Dim gtNextDelimiter As Long, gtDelimiterCounter As Long
  
  ' If Params are Empty then Exit '
  If gtString = "" Or gtDelimiter = "" Then Exit Function
  ' Get first Delimiter Position  '
  gtNextDelimiter = InStr(gtString, gtDelimiter)
  
  ' Loop until Delimiter is not Found '
  Do Until gtNextDelimiter = 0
    ' Count up our Delimiters '
    gtDelimiterCounter = gtDelimiterCounter + 1
    
    ' Get Next Delimiter Position '
    gtNextDelimiter = InStr(gtNextDelimiter + Len(gtDelimiter), gtString, gtDelimiter)
  Loop
  
  ' Return Delimited String '
  GetDelimiterCount = gtDelimiterCounter
End Function















'---------------------------------------------------------------------------------'
' GetToken       Assign to GetTokenString                                         '
'---------------------------------------------------------------------------------'
Public Function GetToken(ByVal gtString As String, ByVal gtIndex As Long, ByVal gtDelimiter As String) As String
  GetToken = GetTokenString(gtString, gtIndex, gtDelimiter)
End Function

'---------------------------------------------------------------------------------'
'    DelimiterCount Assign to GetDelimiterCount                                   '
'---------------------------------------------------------------------------------'
Public Function DelimiterCount(ByVal gtString As String, ByVal gtDelimiter As String) As Long
  DelimiterCount = GetDelimiterCount(gtString, gtDelimiter)
End Function

'---------------------------------------------------------------------------------'
' Delete all Double Spaces                                                        '
'---------------------------------------------------------------------------------'
Public Function DelDoubleSpaces(ByVal strText As String, Optional TabIsSpaceToo As Boolean) As String
  If TabIsSpaceToo Then strText = Replace(strText, vbTab, " ")
  Do While InStr(strText, "  ")
    strText = Replace(strText, "  ", " ")
  Loop
  DelDoubleSpaces = Trim(strText)
End Function

'---------------------------------------------------------------------------------'
' Generate a random String with <NumberOfChars> Characters                        '
'---------------------------------------------------------------------------------'
Public Function RndStr(ByVal NumberOfChars As Integer) As String
  Dim i As Integer, Tmp As String
  Randomize Timer
  For i = 1 To NumberOfChars
    If CInt(Rnd * 1) Then
      Tmp = Tmp & Chr(Rnd * 25 + 65)
    Else
      Tmp = Tmp & Chr(Rnd * 25 + 97)
    End If
  Next i
  RndStr = Tmp
End Function

'---------------------------------------------------------------------------------'
' Generate a random UCased String with <NumberOfChars> Characters                 '
'---------------------------------------------------------------------------------'
Public Function RndUStr(ByVal NumberOfChars As Integer) As String
  Dim i As Integer, Tmp As String
  Randomize Timer
  For i = 1 To NumberOfChars
    Tmp = Tmp & Chr(Rnd * 25 + 65)
  Next i
  RndUStr = Tmp
End Function

'---------------------------------------------------------------------------------'
' Generate a random LCased String with <NumberOfChars> Characters                 '
'---------------------------------------------------------------------------------'
Public Function RndLStr(ByVal NumberOfChars As Integer) As String
  Dim i As Integer, Tmp As String
  Randomize Timer
  For i = 1 To NumberOfChars
    Tmp = Tmp & Chr(Rnd * 25 + 97)
  Next i
  RndLStr = Tmp
End Function

'---------------------------------------------------------------------------------'
' Generate a random Numberic String with <NumberOfChars> Characters               '
'---------------------------------------------------------------------------------'
Public Function RndNStr(ByVal NumberOfChars As Integer) As String
  Dim i As Integer, Tmp As String
  Randomize Timer
  For i = 1 To NumberOfChars
    Tmp = Tmp & Chr(Rnd * 9 + 48)
  Next i
  RndNStr = Tmp
End Function

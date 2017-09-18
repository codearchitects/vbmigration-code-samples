' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module CXP_String

	'---------------------------------------------------------------------------------'
	' CXP_String Module (C)2002 by CodeXP                             CodeXP@Lycos.de '
	'---------------------------------------------------------------------------------'
	' YOU CAN USE, YOU CAN CHANGE IT, BUT GIVE IT OTHERS AS IS (WITHOUT CHANGES)      '
	'---------------------------------------------------------------------------------'
	
	'---------------------------------------------------------------------------------'
	' GetTokenString Function                                                         '
	'---------------------------------------------------------------------------------'
	Public Function GetTokenString(ByVal gtString As String, ByVal gtIndex As Integer, ByVal gtDelimiter As String) As String
		Dim gtNextDelimiter As Integer
		Dim gtDelimitedString As String = ""
		Dim gtLastDelimiter As Integer
		Dim gtDelimiterCounter As Integer
		
		' If Params are Empty then Exit '
		If gtString = "" Or gtDelimiter = "" Or gtIndex < 1 Then  Exit Function
		' Get first Delimiter Position  '
		gtNextDelimiter = InStr(gtString, gtDelimiter)
		' If first Delimiter was not found then Return gtString '
		If gtNextDelimiter = 0 Then  gtDelimitedString = gtString
		
		' Loop until Delimiter is not Found '
		Do Until gtNextDelimiter = 0
			' Count up our Delimiters '
			gtDelimiterCounter += 1
			' BackUp our Delimiter Position '
			gtLastDelimiter = gtNextDelimiter
			
			' The first Delimiter Index is always the first '
			' Delimited String in the Begin of a String !!  '
			' For this Reason we don't get the Next         '
			' Delimiter Position.                           '
			If gtDelimiterCounter > 1 Then 
				' Get Next Delimiter Position '
				gtNextDelimiter = InStr(gtNextDelimiter + Len6(gtDelimiter), gtString, gtDelimiter)
			End If
			
			'If asked Delimiter Index matches '
			If gtIndex = gtDelimiterCounter Then 
				If gtDelimiterCounter = 1 Then 
					' Get Detimited String at Beginn  '
					gtDelimitedString = VB.Left(gtString, gtLastDelimiter - 1)
				Else
					If gtNextDelimiter = 0 Then 
						' Get Detimited String at End '
						gtDelimitedString = Mid(gtString, gtLastDelimiter + Len6(gtDelimiter))
					Else
						' Get Detimited String at Middle of String  '
						gtDelimitedString = Mid(gtString, gtLastDelimiter + Len6(gtDelimiter), gtNextDelimiter - gtLastDelimiter - Len6(gtDelimiter))
					End If
				End If
				' Get out of Loop '
				Exit Do
			End If
		Loop
		
		' Return Delimited String '
		Return gtDelimitedString
	End Function

	'---------------------------------------------------------------------------------'
	' GetDelimiterCount Function                                                      '
	'---------------------------------------------------------------------------------'
	Public Function GetDelimiterCount(ByVal gtString As String, ByVal gtDelimiter As String) As Integer
		Dim gtNextDelimiter As Integer
		Dim gtDelimiterCounter As Integer
		
		' If Params are Empty then Exit '
		If gtString = "" Or gtDelimiter = "" Then  Exit Function
		' Get first Delimiter Position  '
		gtNextDelimiter = InStr(gtString, gtDelimiter)
		
		' Loop until Delimiter is not Found '
		Do Until gtNextDelimiter = 0
			' Count up our Delimiters '
			gtDelimiterCounter += 1
			
			' Get Next Delimiter Position '
			gtNextDelimiter = InStr(gtNextDelimiter + Len6(gtDelimiter), gtString, gtDelimiter)
		Loop
		
		' Return Delimited String '
		Return gtDelimiterCounter
	End Function

	'---------------------------------------------------------------------------------'
	' GetToken       Assign to GetTokenString                                         '
	'---------------------------------------------------------------------------------'
	Public Function GetToken(ByVal gtString As String, ByVal gtIndex As Integer, ByVal gtDelimiter As String) As String
		Return GetTokenString(gtString, gtIndex, gtDelimiter)
	End Function

	'---------------------------------------------------------------------------------'
	'    DelimiterCount Assign to GetDelimiterCount                                   '
	'---------------------------------------------------------------------------------'
	Public Function DelimiterCount(ByVal gtString As String, ByVal gtDelimiter As String) As Integer
		Return GetDelimiterCount(gtString, gtDelimiter)
	End Function

	'---------------------------------------------------------------------------------'
	' Delete all Double Spaces                                                        '
	'---------------------------------------------------------------------------------'
	Public Function DelDoubleSpaces(ByVal strText As String, Optional ByRef TabIsSpaceToo As Boolean = False) As String
		If TabIsSpaceToo Then  strText = Replace(strText, ControlChars.Tab, " ")
		Do While InStr(strText, "  ")
			strText = Replace(strText, "  ", " ")
		Loop
		Return Trim(strText)
	End Function

	'---------------------------------------------------------------------------------'
	' Generate a random String with <NumberOfChars> Characters                        '
	'---------------------------------------------------------------------------------'
	Public Function RndStr(ByVal NumberOfChars As Short) As String
		Dim i As Short
		Dim Tmp As String = ""
		Randomize(Timer6)
		For i = 1 To NumberOfChars
			If CShort(Rnd() * 1) Then 
				' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'Tmp' variable as a StringBuilder6 object.
				Tmp = Tmp & Chr6(Rnd() * 25 + 65)
			Else
				Tmp = Tmp & Chr6(Rnd() * 25 + 97)
			End If
		Next
		Return Tmp
	End Function

	'---------------------------------------------------------------------------------'
	' Generate a random UCased String with <NumberOfChars> Characters                 '
	'---------------------------------------------------------------------------------'
	Public Function RndUStr(ByVal NumberOfChars As Short) As String
		Dim i As Short
		Dim Tmp As String = ""
		Randomize(Timer6)
		For i = 1 To NumberOfChars
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'Tmp' variable as a StringBuilder6 object.
			Tmp = Tmp & Chr6(Rnd() * 25 + 65)
		Next
		Return Tmp
	End Function

	'---------------------------------------------------------------------------------'
	' Generate a random LCased String with <NumberOfChars> Characters                 '
	'---------------------------------------------------------------------------------'
	Public Function RndLStr(ByVal NumberOfChars As Short) As String
		Dim i As Short
		Dim Tmp As String = ""
		Randomize(Timer6)
		For i = 1 To NumberOfChars
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'Tmp' variable as a StringBuilder6 object.
			Tmp = Tmp & Chr6(Rnd() * 25 + 97)
		Next
		Return Tmp
	End Function

	'---------------------------------------------------------------------------------'
	' Generate a random Numberic String with <NumberOfChars> Characters               '
	'---------------------------------------------------------------------------------'
	Public Function RndNStr(ByVal NumberOfChars As Short) As String
		Dim i As Short
		Dim Tmp As String = ""
		Randomize(Timer6)
		For i = 1 To NumberOfChars
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'Tmp' variable as a StringBuilder6 object.
			Tmp = Tmp & Chr6(Rnd() * 9 + 48)
		Next
		Return Tmp
	End Function

End Module

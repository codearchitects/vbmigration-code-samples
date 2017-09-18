' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class clsPhoneme

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	'// Please see the accompanying documentation for the algorithms
	
	'// Returns the 4 letter soundex for an english word
	Private Function Soundex(ByRef argWord As String) As Object
	' UPGRADE_INFO (#0561): The 'Soundex' symbol was defined without an explicit "As" clause.
		
		Dim workStr As String = ""
		Dim i As Integer
		Dim replaceMask(5) As Boolean
		
		'// Capitalize it to remove ambiguity
		argWord = UCase(argWord)
		
		'// 1. Retain the first letter of the string
		workStr = VB.Left(argWord, 1)
		
		'// 2. Replacement
		'   [a, e, h, i, o, u, w, y] = 0
		'   [b, f, p, v] = 1
		'   [c, g, j, k, q, s, x, z] = 2
		'   [d, t] = 3
		'   [l] = 4
		'   [m, n] = 5
		'   [r] = 6
		
		For i = 2 To Len6(argWord)
			Select Case Mid(argWord, i, 1)
			Case "B", "F", "P", "V"
				If replaceMask(0) = False Then 
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'workStr' variable as a StringBuilder6 object.
					workStr &= Chr6(49) '// 1
					replaceMask(0) = True
				End If
				
			Case "C", "G", "J", "K", "Q", "S", "X", "Z"
				If replaceMask(1) = False Then 
					workStr &= Chr6(50) '// 2
					replaceMask(1) = True
				End If
				
			Case "D", "T"
				If replaceMask(2) = False Then 
					workStr &= Chr6(51) '// 3
					replaceMask(2) = True
				End If
				
			Case "L"
				If replaceMask(3) = False Then 
					workStr &= Chr6(52) '// 4
					replaceMask(3) = True
				End If
				
			Case "M", "N"
				If replaceMask(4) = False Then 
					workStr &= Chr6(53) '// 5
					replaceMask(4) = True
				End If
				
			Case "R"
				If replaceMask(5) = False Then 
					workStr &= Chr6(56) '// 6
					replaceMask(5) = True
				End If
				
				'// A, E, H, I, O, U, W, Y do nothing
			End Select
		Next
		
		'// 5. Return the first four bytes padded with 0.
		If Len6(workStr) > 4 Then 
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'Soundex'. Consider using the SetDefaultMember6 helper method.
			Return VB.Left(workStr, 4)
		Else
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'Soundex'. Consider using the SetDefaultMember6 helper method.
			Return workStr & Space(4 - Len6(workStr))
		End If
	End Function

	'// Returns the Minimum of 3 numbers
	Private Function min3(ByVal n1 As Integer, ByVal n2 As Integer, ByVal n3 As Integer) As Integer
		min3 = n1
		If n2 < min3 Then  min3 = n2
		If n3 < min3 Then  Return n3
	End Function

	'// Returns the Levenshtein Distance between 2 strings.
	Private Function LevenshteinDistance(ByRef argStr1 As String, ByRef argStr2 As String) As Integer
	' UPGRADE_INFO (#0551): The 'argStr1' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'argStr2' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim m As Integer
		Dim n As Integer
		Dim editMatrix(,) As Integer
		Dim i As Integer
		Dim j As Integer
		Dim cost As Integer
		Dim str1_i As String = ""
		Dim str2_j As String = ""
		' UPGRADE_INFO (#0501): The 'p' member isn't used anywhere in current application.
		Dim p() As Integer
		' UPGRADE_INFO (#0501): The 'q' member isn't used anywhere in current application.
		Dim q() As Integer
		' UPGRADE_INFO (#0501): The 'r' member isn't used anywhere in current application.
		Dim r As Integer
		' UPGRADE_INFO (#0501): The 'x' member isn't used anywhere in current application.
		Dim x As Integer
		' UPGRADE_INFO (#0501): The 'y' member isn't used anywhere in current application.
		Dim y As Integer
		
		n = Len6(argStr1)
		m = Len6(argStr2)
		
		'If (n = 0) Or (m = 0) Then Exit Function
		ReDim editMatrix(n, m)

		For i = 0 To n
			editMatrix(i, 0) = i
		Next
		
		For j = 0 To m
			editMatrix(0, j) = j
		Next
		
		For i = 1 To n
			str1_i = Mid(argStr1, i, 1)
			For j = 1 To m
				str2_j = Mid(argStr2, j, 1)
				If str1_i = str2_j Then 
					cost = 0
				Else
					cost = 1
				End If
				
				editMatrix(i, j) = min3(editMatrix(i - 1, j) + 1, editMatrix(i, j - 1) + 1, editMatrix(i - 1, j - 1) + cost)
			Next
		Next
		
		LevenshteinDistance = editMatrix(n, m)
		Erase6(editMatrix)
	End Function

	Public Function GetSoundexWord(ByVal inputStr As String) As String
		If inputStr <> Nothing Then  Return Soundex(inputStr)
	End Function

	Public Function GetLevenshteinDistance(ByVal inputStr1 As String, ByVal inputStr2 As String) As Integer
		If inputStr1 = Nothing Then 
			Return Len6(inputStr2)
		ElseIf inputStr2 = Nothing Then 
			Return Len6(inputStr1)
		Else
			Return LevenshteinDistance(inputStr1, inputStr2)
		End If
	End Function

End Class

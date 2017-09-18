' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module Chap05

	'---------------------------------------------------------
	' PROGRAMMING VB6 ROUTINE LIBRARY - (C) Francesco Balena
	'
	' (36+10) Routines in Chapter 05
	'---------------------------------------------------------

	' API declares (used by the WaitForProcess routine)
	' UPGRADE_INFO (#0531): You can replace calls to the 'WaitForSingleObject' unamanged method with the following .NET member(s): System.Threading.WaitHandle.WaitOne
	' UPGRADE_INFO (#0511): The 'WaitForSingleObject' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'OpenProcess' unamanged method with the following .NET member(s): System.Diagnostics.Process.GetProcessById
	' UPGRADE_INFO (#0511): The 'OpenProcess' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function OpenProcess Lib "kernel32" (ByVal dwAccess As Integer, ByVal fInherit As Short, ByVal hObject As Integer) As Integer
	' UPGRADE_INFO (#0511): The 'CloseHandle' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer

	' a replacement for the "^" operator, when the exponent is an integer value
	' it is at least 50% faster in native-compiled code
	
	Public Function Power(ByVal number As Double, ByVal exponent As Integer) As Double
	' UPGRADE_INFO (#0501): The 'Power' member isn't used anywhere in current application.
		Dim result As Double
		If exponent < 0 Then  Err.Raise(5) ' invalid procedure call or argument
		result = 1
		Do While exponent
			If exponent And 1 Then  result *= number
			number *= number
			exponent \= 2
		Loop
		Return result
	End Function

	' a MOD replacement that also works with floating point numbers
	' Note: this differs from MOD when number is negative
	
	Public Function FPMod(ByVal number As Double, ByVal divisor As Double) As Double
	' UPGRADE_INFO (#0501): The 'FPMod' member isn't used anywhere in current application.
		Return number - Int(number / divisor) * divisor
	End Function

	' base-10 logarithm
	
	Public Function Log10(ByRef number As Double) As Double
	' UPGRADE_INFO (#0501): The 'Log10' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'number' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Math.Log(number) / 2.30258509299405
	End Function

	' "equal" up to their 10th decimal digit
	
	Public Function AlmostEqual(ByRef x As Object, ByRef y As Object) As Boolean
	' UPGRADE_INFO (#0501): The 'AlmostEqual' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0561): The 'x' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'x' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0561): The 'y' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'y' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y'. Consider using the GetDefaultMember6 helper method.
		Return (Abs6(x - y) <= 0.0000000001)
	End Function

	' a very fast routine that returns 2^N, with N in the range [0-31]
	
	Public Function Power2(ByVal exponent As Integer) As Integer
	' UPGRADE_INFO (#0511): The 'Power2' member is referenced only by members that haven't found to be used in the current project/solution.
		Static result(31) As Integer
		Static i As Short
		' evaluate powers of two only once
		If result(0) = 0 Then 
			result(0) = 1
			For i = 1 To 30
				result(i) = result(i - 1) * 2
			Next
			result(31) = &H80000000 ' this is a special value
		End If
		Return result(exponent)
	End Function

	' fractional part of a floating-point number
	' note that negative numbers return negative values
	
	Public Function Fract(ByRef number As Double) As Double
	' UPGRADE_INFO (#0501): The 'Fract' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'number' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return number - Fix(number)
	End Function

	' the Greatest Common Divisor of two integers - Euclide's algorithm
	
	Public Function Gcd(ByRef n1 As Integer, ByRef n2 As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'Gcd' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'n1' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'n2' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim one As Integer
		Dim two As Integer
		Dim tmp As Integer
		one = n1: two = n2
		If one > two Then 
			tmp = one: one = two: two = tmp
		End If
		
		Do
			tmp = one: one = two: two = tmp
			one = one Mod two
		Loop While one
		Return two
	End Function

	' the Least Common Multiple of two integers - Euclide's algorithm
	
	Public Function Lcm(ByRef n1 As Integer, ByRef n2 As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'Lcm' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'n1' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'n2' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim one As Integer
		Dim two As Integer
		Dim tmp As Integer
		one = n1: two = n2: tmp = n1 * n2
		If one > two Then 
			tmp = one: one = two: two = tmp
		End If
		
		Do
			tmp = one: one = two: two = tmp
			one = one Mod two
		Loop While one
		Return tmp \ two
	End Function

	' the factorial of a number (n = 0-170)
	
	Public Function Factorial(ByRef number As Integer) As Double
	' UPGRADE_INFO (#0511): The 'Factorial' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'number' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Static result(170) As Double
		Static i As Integer
		' illegal procedure call if negative
		If number < 0 Then  Err.Raise(5)
		' overflow if too high
		If number > 170 Then  Err.Raise(6)
		
		' evalutate all possible values in advance
		If result(0) = 0 Then 
			result(0) = 1
			For i = 1 To UBound6(result)
				result(i) = result(i - 1) * CDbl(i)
			Next
		End If
		Return result(number)
	End Function

	' number of combinations of ITEMS elements in groups of GROUPSIZE
	' combinations are all the possible arrangements you can combine N object
	' in groups of K without distinguishing results that only differ in their order
	' For example: Combinations(52,5) gives you the number of card hands you can receive
	
	' Note: uses the Factorial routine
	
	Public Function Combinations(ByRef items As Integer, ByRef groupsize As Integer) As Double
	' UPGRADE_INFO (#0501): The 'Combinations' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'items' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'groupsize' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return (Factorial(items) / Factorial(items - groupsize)) / Factorial(groupsize)
	End Function

	' number of permutations of ITEMS elements in groups of GROUPSIZE
	' permutations are all the possible arrangements you can combine N object
	' in groups of K when you distinguish results that differ in their order
	' For example: Permutations(10,3) returns the number of permutation in which
	' 1st, 2nd and 3rd prize can be assigned to a game with 10 playes
	
	' Note: uses the Factorial routine
	
	Public Function Permutations(ByRef items As Integer, ByRef groupsize As Integer) As Double
	' UPGRADE_INFO (#0501): The 'Permutations' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'items' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'groupsize' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Factorial(items) / Factorial(items - groupsize)
	End Function

	' convert from degrees to radians
	
	Public Function Radians(ByRef Degrees As Double) As Double
	' UPGRADE_INFO (#0501): The 'Radians' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'Degrees' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Degrees / 57.29577951
	End Function

	' convert from radians to degrees
	
	Public Function Degrees(ByRef Radians As Double) As Double
	' UPGRADE_INFO (#0501): The 'Degrees' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'Radians' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Radians * 57.29577951
	End Function

	' arc sine - error if NUMBER is outside the range [-1,1]
	
	Public Function ASin(ByVal number As Double) As Double
	' UPGRADE_INFO (#0501): The 'ASin' member isn't used anywhere in current application.
		If Abs6(number) <> 1 Then 
			Return Math.Atan(number / Math.Sqrt(1 - number * number))
		Else
			Return 1.5707963267949 * Math.Sign(number)
		End If
	End Function

	' arc cosine - error if NUMBER is outside the range [-1,1]
	
	Public Function ACos(ByVal number As Double) As Double
	' UPGRADE_INFO (#0501): The 'ACos' member isn't used anywhere in current application.
		If Abs6(number) <> 1 Then 
			Return 1.5707963267949 - Math.Atan(number / Math.Sqrt(1 - number * number))
		Else
			Return 3.14159265358979 * Math.Sign(number)
		End If
	End Function

	' arc tangent of Y/X
	' returns values in all four quadrants
	
	Public Function Atn2(ByRef x As Double, ByRef y As Double) As Double
	' UPGRADE_INFO (#0511): The 'Atn2' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'x' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'y' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If x = 0 Then 
			Return Math.Sign(y) * 1.5707963267949
		ElseIf x > 0 Then 
			Return Math.Atan(y / x)
		Else
			Return Math.Atan(y / x) + 3.14159265358979 * CShort((y < 0))
		End If
	End Function

	' convert from carthesian to polar coordinates
	' Note: uses Atn2 routine
	
	Public Sub XYToPolar(ByRef x As Double, ByRef y As Double, ByRef angle As Double, ByRef radius As Double)
	' UPGRADE_INFO (#0501): The 'XYToPolar' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'x' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'y' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		angle = Atn2(x, y)
		radius = Math.Sqrt(x * x + y * y)
	End Sub

	' convert from polar to carthesian coordinates
	
	Public Sub PolarToXY(ByRef angle As Double, ByRef radius As Double, ByRef x As Double, ByRef y As Double)
	' UPGRADE_INFO (#0501): The 'PolarToXY' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'angle' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'radius' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		x = radius * Math.Cos(angle)
		y = radius * Math.Sin(angle)
	End Sub

	' returns the nearest integer equal or higher than the argument
	
	Public Function Ceiling(ByRef number As Double) As Integer
	' UPGRADE_INFO (#0501): The 'Ceiling' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'number' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return -Int(-number)
	End Function

	' convert from decimal to binary
	
	Public Function Bin(ByVal value As Integer) As String
	' UPGRADE_INFO (#0501): The 'Bin' member isn't used anywhere in current application.
		Dim result As String = ""
		Dim exponent As Short
		' this is faster than creating the string by appending chars
		result = String6(32, "0")
		Do
			If value And Power2(exponent) Then 
				' we found a bit that is set, clear it
				Mid(result, 32 - exponent, 1) = "1"
				value = value Xor Power2(exponent)
			End If
			exponent += 1
		Loop While value
		Return Mid(result, 33 - exponent)
	End Function

	' convert from binary to decimal
	
	Public Function BinToDec(ByRef value As String) As Integer
	' UPGRADE_INFO (#0501): The 'BinToDec' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'value' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim result As Integer
		Dim i As Short
		Dim exponent As Short
		For i = Len6(value) To 1 Step -1
			Select Case Asc(Mid(value, i, 1))
			Case 48 ' "0", do nothing
			Case 49 ' "1", add the corresponding power of 2
				result += Power2(exponent)
			Case Else
				Err.Raise(5) ' Invalid procedure call or argument
			End Select
			exponent += 1
		Next
		Return result
	End Function

	' returns a random number in the range (low, high)
	
	Public Function Rnd2(ByRef low As Single, ByRef high As Single) As Single
	' UPGRADE_INFO (#0501): The 'Rnd2' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'low' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'high' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Rnd() * (high - low) + low
	End Function

	' returns an array of Long values in the range specified
	' without any duplicated value
	
	Function RandomArray(first As Integer, last As Integer) As VB6Array(of Integer)
		Dim i As Integer
		Dim j As Integer
		Dim temp As Integer
		
		Dim result As VB6Array(Of Integer)
		
		Redim6(result, first, last)
		' initialize the array
		For i = first To last
			result(i) = i
		Next
		' now shuffle it
		For i = last To first Step -1
			' generate a random number in the proper range
			j = Rnd() * (last - first + 1) + first
			' swap the two items
			temp = result(i): result(i) = result(j): result(j) = temp
		Next
		Return result
	End Function

	' count the number of sub-strings
	
	Public Function InstrCount(ByRef source As String, ByRef search As String, Optional ByRef start As Integer = 1, Optional ByRef Compare As CompareMethod = CompareMethod.Binary) As Integer
	' UPGRADE_INFO (#0501): The 'InstrCount' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'source' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'search' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'start' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Compare' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		Dim result As Integer
		i = InStr(start, source, search, Compare)
		Do While i
			result += 1
			i = InStr(i + 1, source, search, Compare)
		Loop
		Return result
	End Function

	' search the first occurrence of a character among those
	' listed in SEARCHTABLE
	
	Public Function InstrTbl(ByRef source As String, ByRef searchTable As String, Optional ByRef start As Integer = 1, Optional ByRef Compare As CompareMethod = CompareMethod.Binary) As Integer
	' UPGRADE_INFO (#0501): The 'InstrTbl' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'source' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'searchTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'start' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Compare' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		For i = start To Len6(source)
			If InStr(1, searchTable, Mid(source, i, 1), Compare) Then 
				InstrTbl = i
				Exit For
			End If
		Next
	End Function

	' search the last occurrence of a character among those
	' listed in SEARCHTABLE
	
	Public Function InstrTblRev(ByRef source As String, ByRef searchTable As String, Optional ByVal start As Integer = -1, Optional ByRef Compare As CompareMethod = CompareMethod.Binary) As Integer
	' UPGRADE_INFO (#0501): The 'InstrTblRev' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'source' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'searchTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Compare' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		If start < 0 Then  start = Len6(source)
		For i = start To 1 Step -1
			If InStr(1, searchTable, Mid(source, i, 1), Compare) Then 
				InstrTblRev = i
				Exit For
			End If
		Next
	End Function

	' a replacement for the built-in Split function, that works with
	' multiple delimited chars
	
	Public Function SplitMulti(ByRef source As String, ByRef delimTable As String, Optional ByRef Limit As Integer = -1, Optional ByRef Compare As CompareMethod = CompareMethod.Binary) As String()
	' UPGRADE_INFO (#0501): The 'SplitMulti' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'source' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'delimTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Limit' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Compare' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		Dim start As Integer
		Dim count As Integer
		Dim result() As String
		' we allocate the result array in chunks, to reduce overhead
		Const ALLOC_CHUNK As Short = 50
		ReDim result(ALLOC_CHUNK - 1)
		' parse the string
		For i = 1 To Len6(source)
			If InStr(1, delimTable, Mid(source, i, 1), Compare) Then 
				' we have found a delimiter
				If start Then 
					' if we were in the middle of a word
					If count > UBound6(result) Then 
						' make room in the result array if necessary
						ReDim Preserve result(UBound6(result) + ALLOC_CHUNK)
					End If
					result(count) = Mid(source, start, i - start)
					start = 0
					count += 1
					If count = Limit Then  Exit For
				End If
			ElseIf start = 0 Then 
				' this isn't a delimiter - remember where the word starts
				start = i
			End If
		Next
		' if we were in the middle of a word
		If start And count <> Limit Then 
			' make room in the result array if necessary, or trim it
			ReDim Preserve result(count)
			result(count) = Mid(source, start)
		Else
			' trim the array to the actual number of items
			ReDim Preserve result(count - 1)
		End If
		Return result
	End Function

	' wait for the current timer tick to elapse
	
	Public Function NextTimerTick() As Single
	' UPGRADE_INFO (#0501): The 'NextTimerTick' member isn't used anywhere in current application.
		Dim t As Single = Timer6
		Do:: Loop While t = Timer6
		Return Timer6
	End Function

	' insert a pause of a given duration (rounded to nearest integer)
	
	Public Sub Pause(ByRef seconds As Short)
	' UPGRADE_INFO (#0501): The 'Pause' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'seconds' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Const SECS_INDAY As Single = 24! * 60 * 60
		' seconds per day
		Dim start As Single = Timer6
		Do:: Loop Until CInt((Timer6 + SECS_INDAY - start)) Mod CInt(SECS_INDAY) >= seconds
	End Sub

	' returns True if an year is a leap year
	
	Public Function IsLeapYear(ByRef year As Short) As Boolean
	' UPGRADE_INFO (#0501): The 'IsLeapYear' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'year' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' does February 29 coincides with March 1 ?
		Return DateSerial(year, 2, 29) <> DateSerial(year, 3, 1)
	End Function

	' returns the attributes of a file in a readable format
	' this routine also works with open files
	' raises an error if the file doesn't exist
	
	Public Function GetAttrDescr(ByRef filename As String) As String
	' UPGRADE_INFO (#0501): The 'GetAttrDescr' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim result As String = ""
		Dim attr As Integer
		attr = GetAttr(filename)
		' GetAttr also works with directories
		If attr And FileAttribute.Directory Then  result &= " Directory"
		If attr And FileAttribute.ReadOnly Then  result &= " ReadOnly"
		If attr And FileAttribute.Hidden Then  result &= " Hidden"
		If attr And FileAttribute.System Then  result &= " System"
		If attr And FileAttribute.Archive Then  result &= " Archive"
		' discard the first space
		Return Mid(result, 2)
	End Function

	' return an array of strings holding all the filenames that
	' match a given filespec and search attributes
	
	Public Function GetFiles(ByRef filespec As String, Optional ByRef Attributes As FileAttribute = 0) As String()
	' UPGRADE_INFO (#0511): The 'GetFiles' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'filespec' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Attributes' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim result() As String
		Dim filename As String = ""
		Dim count As Integer
		' UPGRADE_INFO (#0501): The 'path2' member isn't used anywhere in current application.
		Dim path2 As String = ""
		Const ALLOC_CHUNK As Short = 50
		ReDim result(ALLOC_CHUNK)
		filename = Dir6(filespec, Attributes)
		Do While Len6(filename)
			count += 1
			If count > UBound6(result) Then 
				' resize the result array, if necessary
				ReDim Preserve result(count + ALLOC_CHUNK)
			End If
			result(count) = filename
			' get ready for the next iteration
			filename = Dir6()
		Loop
		' trim the result array
		ReDim Preserve result(count)
		Return result
	End Function

	' check if a file exists
	
	Public Function FileExists(ByRef filename As String) As Boolean
	' UPGRADE_INFO (#0501): The 'FileExists' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		Return (Dir6(filename) <> "")
	End Function

	' check if a directory exists
	
	Public Function DirExists(ByRef path As String) As Boolean
	' UPGRADE_INFO (#0501): The 'DirExists' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'path' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		Return (Dir6(path & "\nul") <> "")
	End Function

	' return an array of strings holding all the subdirectories in a path
	' that match search attributes - optionally it returns the entire path
	
	Public Function GetDirectories(ByRef path As String, Optional ByRef Attributes As FileAttribute = 0, Optional ByRef IncludePath As Boolean = False) As String()
	' UPGRADE_INFO (#0511): The 'GetDirectories' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'path' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Attributes' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'IncludePath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim result() As String
		Dim dirname As String = ""
		Dim count As Integer
		Dim path2 As String = ""
		Const ALLOC_CHUNK As Short = 50
		ReDim result(ALLOC_CHUNK)
		' build the path name + backslash
		path2 = path
		If VB.Right(path2, 1) <> "\" Then  path2 = path2 & "\"
		dirname = Dir6(path2 & "*.*", FileAttribute.Directory Or Attributes)
		Do While Len6(dirname)
			If dirname = "." Or dirname = ".." Then 
				' exclude the "." and ".." entries
			ElseIf (GetAttr(path2 & dirname) And FileAttribute.Directory) = 0 Then 
				' this is a regular file
			Else
				' this is a directory
				count += 1
				If count > UBound6(result) Then 
					' resize the result array, if necessary
					ReDim Preserve result(count + ALLOC_CHUNK)
				End If
				' include the path if requested
				If IncludePath Then  dirname = path2 & dirname
				result(count) = dirname
			End If
			dirname = Dir6()
		Loop
		' trim the result array
		ReDim Preserve result(count)
		Return result
	End Function

	' load the names of all executable files in a directory tree into a ListBox
	' Note: this is a recursive routine
	
	Public Sub ListExecutableFiles(ByVal path As String, ByRef lst As VB6ListBox)
	' UPGRADE_INFO (#0511): The 'ListExecutableFiles' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'lst' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim names() As String
		Dim i As Integer
		Dim j As Short
		' ensure that there is a trailing backslash
		If VB.Right(path, 1) <> "\" Then  path = path & "\"
		' get the list of executable files
		For j = 1 To 4
			' at each iteration search for a different extension
			names = GetFiles(path & "*." & Choose(j, "exe", "bat", "com", "pif"))
			' load partial results in the listbox
			For i = 1 To UBound6(names)
				lst.AddItem(path & names(i))
			Next
		Next
		' get the list of subdirectories, including hidden ones
		' and call this routine recursively on all of them
		names = GetDirectories(path, FileAttribute.Hidden)
		For i = 1 To UBound6(names)
			ListExecutableFiles(path & names(i), lst)
		Next
	End Sub

	' load a text file into a TextBox control
	
	Public Sub LoadFileInTextBox(ByRef filename As String, ByRef txt As VB6TextBox)
	' UPGRADE_INFO (#0501): The 'LoadFileInTextBox' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'txt' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fnum As Short
		Dim isOpen As Boolean
		Dim textline As String = ""
		Dim Text As String = ""
		On Error GoTo Error_Handler 
		' get the next free file number
		fnum = FreeFile6()
		FileOpen6(fnum, filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		' if execution flow got here, the files has been open without error
		isOpen = True
		Do Until EOF6(fnum)
			textline = FileLineInput6(fnum)
			Text = Text & textline & ControlChars.CrLf
		Loop
		' load into the textbox
		txt.Text = Text
		' intentionally flow into the error handler to close the file
Error_Handler:
		' raise the error (if any), but first close the file
		If isOpen Then  FileClose6(fnum)
		If Err.Number Then  Err.Raise(Err.Number, , Err.Description)
	End Sub

	' returns the entire contents of a text file as a string
	
	Public Function ReadTextFileContents(ByRef filename As String) As String
	' UPGRADE_INFO (#0511): The 'ReadTextFileContents' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fnum As Short
		Dim isOpen As Boolean
		On Error GoTo Error_Handler 
		' get the next free file number
		fnum = FreeFile6()
		FileOpen6(fnum, filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		' if execution flow got here, the file has been open without error
		isOpen = True
		' read the entire contents in one single operation
		ReadTextFileContents = FileInputString6(fnum, LOF6(fnum))
		' intentionally flow into the error handler to close the file
Error_Handler:
		' raise the error (if any), but first close the file
		If isOpen Then  FileClose6(fnum)
		If Err.Number Then  Err.Raise(Err.Number, , Err.Description)
	End Function

	' writes the contents of a string to a file, optionally in Append mode
	
	Public Sub WriteTextFileContents(ByRef Text As String, ByRef filename As String, Optional ByRef AppendMode As Boolean = False)
	' UPGRADE_INFO (#0511): The 'WriteTextFileContents' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'Text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'AppendMode' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fnum As Short
		Dim isOpen As Boolean
		On Error GoTo Error_Handler 
		' get the next free file number
		fnum = FreeFile6()
		If AppendMode Then 
			FileOpen6(fnum, filename, OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1)
		Else
			FileOpen6(fnum, filename, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		End If
		' if execution flow got here, the file has been open correctly
		isOpen = True
		' print to the file in one single operation
		FilePrintLine6(fnum, Text)
		' intentionally flow into the error handler to close the file
Error_Handler:
		' raise the error (if any), but first close the file
		If isOpen Then  FileClose6(fnum)
		If Err.Number Then  Err.Raise(Err.Number, , Err.Description)
	End Sub

	' returns the contents of a text file as an array of strings
	' NOTE: requires the ReadTextFileContents routine
	
	Public Function GetTextFileLines(ByRef filename As String, Optional ByRef DropEmpty As Boolean = False, Optional ByRef Limit As Object = VB6Missing) As String()
	' UPGRADE_INFO (#0511): The 'GetTextFileLines' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DropEmpty' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Limit' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim FileText As String = ""
		Dim items() As String
		Dim i As Integer
		' read the file's contents, exit if any error
		FileText = ReadTextFileContents(filename)
		' this is necessary, because Split() only accepts 1-char delimiters
		FileText = Replace(FileText, ControlChars.CrLf, ControlChars.Cr)
		' split the file in individual lines of text
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Limit'. Consider using the GetDefaultMember6 helper method.
		items = Split(FileText, ControlChars.Cr, Limit)
		' drop empty lines, if requested
		If DropEmpty Then 
			' fill empty lines with something that other items
			' surely don't contain
			For i = 0 To UBound6(items)
				If Len6(items(i)) = 0 Then  items(i) = ControlChars.CrLf
			Next
			' use the Filter() function to quickly drop empty lines
			items = Filter(items, ControlChars.CrLf, False)
		End If
		Return items
	End Function

	' returns the contents of a delimited text file as an array of strings arrays
	' NOTE: requires the ReadTextFileContents and GetTextFileLines routines
	
	Public Function ImportDelimitedFile(ByRef filename As String, Optional ByRef delimiter As String = ControlChars.Tab) As Object()
	' UPGRADE_INFO (#0501): The 'ImportDelimitedFile' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'delimiter' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim values() As Object    ' Implicitly declared array
		Dim lines() As String
		Dim i As Integer
		' get all lines in the file, skipping over blank ones
		lines = GetTextFileLines(filename, True)
		' create a string array out of each line of text
		' and store it into a Variant element
		ReDim values(UBound6(lines))
		For i = 0 To UBound6(lines)
			values(i) = Split(lines(i), delimiter, -1)
		Next
		Return values
	End Function

	' write the contents of an array of string arrays to a delimited text file
	' NOTE: requires the WriteTextFileContents routine
	
	Public Sub ExportDelimitedFile(ByRef values() As Object, ByRef filename As String, Optional ByRef delimiter As String = ControlChars.Tab)
	' UPGRADE_INFO (#0501): The 'ExportDelimitedFile' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'values' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'delimiter' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim lines() As String    ' Implicitly declared array
		Dim i As Integer
		' UPGRADE_INFO (#0501): The 'j' member isn't used anywhere in current application.
		Dim j As Integer
		Dim TextFile As String = ""
		' rebuild the individual lines of text of the file
		ReDim lines(UBound6(values))
		For i = 0 To UBound6(values)
			lines(i) = Join(values(i), delimiter)
		Next
		' create CRLFs among records
		TextFile = Replace(Join(lines, ControlChars.Cr), ControlChars.Cr, ControlChars.CrLf)
		WriteTextFileContents(TextFile, filename)
	End Sub

	' Duplicate a directory tree without also copying the files
	
	' call this routine to initiate the copy process
	' NOTE: the destination folder is created if necessary
	'       uses the Private Sub DuplicateDirTreeSub procedure
	
	Public Sub DuplicateDirTree(ByRef SourcePath As String, ByRef DestPath As String)
	' UPGRADE_INFO (#0501): The 'DuplicateDirTree' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'SourcePath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DestPath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fso As New VB6FileSystemObject
		Dim sourceFld As VB6Folder = Nothing
		Dim destFld As VB6Folder = Nothing
		' the source folder must exists
		sourceFld = fso.GetFolder(SourcePath)
		' the destination folder is created if necessary
		If fso.FolderExists(DestPath) Then 
			destFld = fso.GetFolder(DestPath)
		Else
			destFld = fso.CreateFolder(DestPath)
		End If
		' jump to the recursive routine to do the real job
		DuplicateDirTreeSub(sourceFld, destFld)
	End Sub

	' Private recursive procedure used by DuplicateDirTree
	
	Private Sub DuplicateDirTreeSub(ByRef source As VB6Folder, ByRef destination As VB6Folder)
	' UPGRADE_INFO (#0511): The 'DuplicateDirTreeSub' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'source' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'destination' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim sourceFld As VB6Folder = Nothing
		Dim destFld As VB6Folder = Nothing
		For Each sourceFld In source.SubFolders
			' copy this subfolder into destination folder
			destFld = destination.SubFolders.Add(sourceFld.Name)
			' then repeat the process recursively for all
			' the subfolders of the folder just considered
			DuplicateDirTreeSub(sourceFld, destFld)
		Next
	End Sub

	' search all the TXT files in a directory for a string
	
	' for each matching file returns a Variant element that contains a
	' 3-item array that holds the filename, the line and the column line
	' NOTE: all searches are case insensitive
	
	Public Function SearchTextFiles(ByRef path As String, ByRef search As String) As Object()
	' UPGRADE_INFO (#0501): The 'SearchTextFiles' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'path' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'search' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim result() As Object    ' Implicitly declared array
		Dim fso As New VB6FileSystemObject
		Dim fil As VB6File = Nothing
		Dim ts As VB6TextStream = Nothing
		Dim pos As Integer
		Dim count As Integer
		ReDim result(50)
		' search for all the TXT files in the directory
		For Each fil In fso.GetFolder(path).Files
			If UCase(fso.GetExtensionName(fil.Path)) = "TXT" Then 
				' get the corresponding TextStream object
				ts = fil.OpenAsTextStream(Scripting.IOMode.ForReading)
				' read its contents, search the string, close it
				pos = InStr(1, ts.ReadAll(), search, CompareMethod.Text)
				ts.Close()
				If pos > 0 Then 
					' if the string has been found, reopen the file
					' to determine its position in terms of (line,column)
					ts = fil.OpenAsTextStream(Scripting.IOMode.ForReading)
					' skip all preceding characters to get where we want
					ts.Skip(pos - 1)
					' fill the result array, make room if necessary
					count += 1
					If count > UBound6(result) Then 
						ReDim Preserve result(UBound6(result) + 50)
					End If
					' each result item is a three-element array
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Array6(fil.Path, ts.Line, ts.Column)'. Consider using the GetDefaultMember6 helper method.
					result(count) = Array6(fil.Path, ts.Line, ts.Column)
					' now we may close the TextStrem
					ts.Close()
				End If
			End If
		Next
		' resize the result array to indicate number of matches
		ReDim Preserve result(count)
		Return result
	End Function

	' wait for a number of milliseconds and return the running status of a
	' process - if argument is omitted, wait until the process terminates
	
	Public Function WaitForProcess(ByRef taskId As Integer, Optional ByRef msecs As Integer = -1) As Boolean
	' UPGRADE_INFO (#0501): The 'WaitForProcess' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'taskId' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'msecs' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim procHandle As Integer = OpenProcess(&H100000, CShort(True), taskId)
		' get the process handle
		' check for its signaled status, return to caller
		WaitForProcess = WaitForSingleObject(procHandle, msecs) <> -1
		' close the handle
		CloseHandle(procHandle)
	End Function

End Module

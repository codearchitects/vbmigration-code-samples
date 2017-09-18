' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

' a sample GlobalUDT structure (change as needed)
Friend Structure GlobalUDT
	Implements IVB6FileGetPut

	Public InvoiceCount As Integer
	Public UserName As String
	' ....
#Region "IVB6FileGetPut interface

	Public Function Read(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) As Object Implements CodeArchitects.VB6Library.IVB6FileGetPut.Read
		Dim struct As GlobalUDT
		Try
			FileGet6(fileNumber, struct.InvoiceCount)
			FileGet6(fileNumber, struct.UserName)
		Catch ex As System.IO.EndOfStreamException
			' VB6 ignores attempts to read past the end of file
		End Try
		Return struct
	End Function

	Public Sub Write(ByVal fileNumber As Integer, ByVal recordNumber As Long, ByVal arrayIsDynamic As Boolean, ByVal stringIsFixedLength As Boolean) Implements CodeArchitects.VB6Library.IVB6FileGetPut.Write
		FilePut6(fileNumber, Me.InvoiceCount)
		FilePut6(fileNumber, Me.UserName)
	End Sub

#End Region

End Structure

Friend Module Chap04

	'---------------------------------------------------------
	' PROGRAMMING VB6 ROUTINE LIBRARY - (C) Francesco Balena
	'
	' (26) Routines in Chapter 04
	'---------------------------------------------------------

	' this API function is used by InsertArrayItemLong and DeleteArrayItemLong
	' IGNORED: Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory"  (dest As Any, source As Any, ByVal numBytes As Long)
	Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef dest As Integer, ByRef source As Integer, ByVal numBytes As Integer)
	
	' a global instance of the GlobalUDT structure
	Public glo As GlobalUDT
	
	' the same routine can save and load global data in GLO
	
	Public Sub SaveLoadGlobalData(ByRef filename As String, ByRef Save As Boolean)
		Dim filenum As Short
		Dim isOpen As Boolean
		On Error GoTo Error_Handler 
		filenum = FreeFile6()
		FileOpen6(filenum, filename, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1)
		isOpen = True
		If Save Then 
			FilePut6(filenum, glo)
		Else
			FileGet6(filenum, glo)
		End If
Error_Handler:
		If isOpen Then  FileClose6(filenum)
	End Sub

	' a Reciprocal function that returns a Variant containing
	' its result or an error code
	
	Public Function Reciprocal(ByRef n As Double) As Object
		If n <> 0 Then 
			Return 1 / n
		Else
			Return CVErr6(11) ' Division by zero error code
		End If
	End Function

	' a polymorphic function that sums the values in any array
	
	Public Function ArraySum(ByRef arr As Object) As Object
		Dim i As Integer
		Dim result As Object = Nothing
		For i = LBound6(arr) To UBound6(arr)
			result += arr(i)
		Next
		Return result
	End Function

	' returns the number of dimensions of the array
	' passed as an argument, or zero if it isn't an array
	
	Public Function NumberOfDims(ByRef arr As Object) As Short
		Dim dims As Short
		Dim dummy As Integer
		On Error Resume Next 
		Do
			dummy = UBound6(arr, dims + 1)
			If Err.Number Then  Exit Do
			dims += 1
		Loop
		Return dims
	End Function

	' a polymorphic sum function that also works with bi-dimensional matrices
	
	Public Function ArraySum2(ByRef arr As Object) As Object
		Dim i As Integer
		Dim j As Integer
		Dim result As Object = Nothing
		' first, check if we can really work with this array
		Select Case NumberOfDims(arr)
		Case 1 ' mono-dimensional array
			For i = LBound6(arr) To UBound6(arr)
				result += arr(i)
			Next
		Case 2 ' bi-dimensional matrix
			For i = LBound6(arr) To UBound6(arr)
				For j = LBound6(arr, 2) To UBound6(arr, 2)
					result += arr(i, j)
				Next
			Next
		Case Else ' not an array, or too many dimensions
			Err.Raise(1001, , "Not an array or bi-dimensional matrix")
		End Select
		Return result
	End Function

	' returns an array of long that that includes all natural
	' numbers in the range FIRST to LAST
	
	Public Function InitArray(ByRef first As Integer, ByRef last As Integer) As VB6Array(Of Integer)
		Dim result As VB6Array(Of Integer) ' Manually added
		Redim6(result, first, last)
		Dim i As Integer
		For i = first To last: result(i) = i: Next
		Return result
	End Function

	' returns a portion of a Long array
	' Note: fails if FIRST or LAST are not valid
	
	Public Function SubArray(ByRef arr() As Integer, ByRef first As Integer, ByRef last As Integer, ByRef newFirstIndex As Integer) As VB6Array(Of Integer)
		Dim i As Integer
		Dim j As Integer
		Dim result As VB6Array(Of Integer) ' Manually added
		Redim6(result, newFirstIndex, last - first)
		j = newFirstIndex
		For i = first To last
			result(j) = arr(i)
			j += 1
		Next
		Return result
	End Function

	' returns an array with all the selected items in
	' the ListBox control passed as argument
	
	Public Function SelectedListItems(ByRef lst As VB6ListBox) As VB6Array(Of String)
		Dim result As VB6Array(Of String)    ' Implicitly declared array
		Dim i As Integer
		Dim j As Integer
		Redim6(result, 0, lst.SelCount)
		For i = 0 To lst.ListCount - 1
			If lst.Selected(i) Then 
				j += 1
				result(j) = lst.List(i)
			End If
		Next
		Return result
	End Function

	' return an array with the first N prime numbers
	Public Function PrimeArray(ByRef numberOfPrimes As Integer) As VB6Array(Of Integer)
		Dim found As Integer
		Dim n As Integer
		Dim i As Integer
		If numberOfPrimes <= 0 Then  Err.Raise(1002, , "Invalid argument")
		Dim result As VB6Array(Of Integer) ' Manually added
		' we know the size of the result in advance
		Redim6(result, 1, numberOfPrimes)
		' "2" is the first prime number
		result(1) = 2: found = 1
		n = 1
		Do While found < numberOfPrimes
			' all other prime numbers are odd, so we can skip even numbers
			n += 2
			' let's check if N is a prime number
			For i = 1 To found
				If (n Mod result(i)) = 0 Then  Exit For
			Next
			If i > found Then 
				' no prime number < N is a divisor for N, therefore N is prime
				found += 1
				result(found) = n
			End If
		Loop
		Return result
	End Function

	' optimized routine that counts the spaces in a string
	' NOTE: this function doesn't work with non-Latin alphabets
	
	Public Function CountSpaces(ByRef Text As String) As Integer
		Dim b() As Byte
		Dim i As Integer
		Dim result As Integer
		b = StringToByteArray6(Text)
		For i = 0 To UBound6(b) Step 2
			' only consider even-numbered items
			If b(i) = 32 Then  result += 1
		Next
		Return result
	End Function

	' polymorphic routine that inserts an item in an array
	
	Public Sub InsertArrayItem(ByRef arr As Object, ByRef index As Integer, ByRef newValue As Object)
		Dim i As Integer
		For i = UBound6(arr) - 1 To index Step -1
			arr(i + 1) = arr(i)
		Next
		arr(index) = newValue
	End Sub

	' polymorphic routine that deletes an item from an array
	
	Public Sub DeleteArrayItem(ByRef arr As Object, ByRef index As Integer)
		Dim i As Integer
		For i = index To UBound6(arr) - 1
			arr(i) = arr(i + 1)
		Next
		' VB will convert this into zero or a null string
		arr(UBound6(arr)) = VB6Empty
	End Sub

	' optimized routine that inserts an element in an array of Longs
	' uses the CopyMemory API function
	' you can modify this code to make it work with other data types
	' by simply modifying the first and last "As Long" clause in the parameter list
	
	Public Sub InsertArrayItemLong(ByRef arr() As Integer, ByRef index As Integer, ByRef newValue As Integer)
		' note that we let VB evaluate the size of each item using Len()
		If index < UBound6(arr) Then 
			' UPGRADE_WARNING (#1054): The LenB function isn't supported. The LenB6 replacement method returns twice the number of the characters (if used with string arguments) or delegates to the System.Runtime.InteropServices.Marshal.SizeOf method (if used with Structure arguments).
			CopyMemory(arr(index + 1), arr(index), (UBound6(arr) - index) * LenB6(arr(index)))
		End If
		arr(index) = newValue
	End Sub

	' optimized routine that deletes an element in an array of Longs
	' uses the CopyMemory API function
	' you can modify this code to make it work with other data types
	' by simply modifying the first "As Long" clause in the parameter list
	
	Public Sub DeleteArrayItemLong(ByRef arr() As Integer, ByRef index As Integer)
		' note that we let VB evaluate the size of each item using LenB()
		If index < UBound6(arr) Then 
			' UPGRADE_WARNING (#1054): The LenB function isn't supported. The LenB6 replacement method returns twice the number of the characters (if used with string arguments) or delegates to the System.Runtime.InteropServices.Marshal.SizeOf method (if used with Structure arguments).
			CopyMemory(arr(index), arr(index + 1), (UBound6(arr) - index) * LenB6(arr(index)))
		End If
		arr(index) = VB6Empty
	End Sub

	' polymorphic sort routine that works with any type of array
	
	Public Sub ShellSortAny(ByRef arr As Object, ByRef numEls As Integer, ByRef descending As Boolean)
		Dim index As Integer
		Dim index2 As Integer
		Dim firstItem As Integer
		Dim inverseOrder As Boolean
		Dim distance As Integer
		Dim value As Object = Nothing
		' exit if it is not an array
		If VarType6(arr) < VariantType.Array Then  Exit Sub
		firstItem = LBound6(arr)
		' find the best value for distance
		Do
			distance = distance * 3 + 1
		Loop Until distance > numEls
		' sort the array
		Do
			distance \= 3
			For index = distance + 1 To numEls
				value = arr(index)
				index2 = index
				Do While CShort((arr(index2 - distance) > value)) Xor CShort(descending)
					arr(index2) = arr(index2 - distance)
					index2 -= distance
					If index2 <= distance Then  Exit Do
				Loop
				arr(index2) = value
			Next
		Loop Until distance = 1
	End Sub

	' returns True if an item in a collection actually exists
	
	Public Function ItemExists(ByRef col As Collection, ByRef Key As String) As Boolean
		Dim dummy As Object = Nothing
		On Error Resume Next 
		dummy = col.Item(Key)
		Return (Err.Number = 0)
	End Function

	' remove all items in a collection
	
	Public Sub RemoveAllItems(ByRef col As Collection)
		Do While col.Count()
			col.Remove(1)
		Loop
	End Sub

	' replace an item in a collection
	' INDEX can be either a numeric or a string value
	
	Public Sub ReplaceItem(ByRef col As Collection, ByRef index As Object, ByRef newValue As Object)
		' first, remove that item (exits with error if it doesn't exist)
		col.Remove(index)
		' then, add it again
		If VarType6(index) = VariantType.String Then 
			' add a new item with the same string key
			col.Add(newValue, index)
		Else
			' add a new item in the same position (without any key)
			col.Add(newValue, , index)
		End If
	End Sub

	' polymorphic routine that filters out all duplicate entries in an array
	' on entry NUMELS should be set to the number of items to be examined
	' on exit it holds the number of non duplicate items
	
	Public Sub FilterDuplicates(ByRef arr As Object, ByRef numEls As Integer)
		Dim col As New Collection
		Dim i As Integer
		Dim j As Integer
		On Error Resume Next 
		j = LBound6(arr) - 1
		For i = LBound6(arr) To numEls
			col.Add(0, CStr(arr(i)))
			If Err.Number = 0 Then 
				j += 1
				If i <> j Then  arr(j) = arr(i)
			Else
				Err.Clear()
			End If
		Next
		' clear all remaining items
		For i = j + 1 To numEls: arr(i) = VB6Empty: Next
		numEls = j
	End Sub

	' this function returns the special "Missing" value
	' NOTE: always call this function without any argument
	
	Public Function MissingValue(Optional ByRef DontPassThis As Object = VB6Missing) As Object
		Return DontPassThis
	End Function

	' a routine that works as a wrapper around the InputBox function
	' and automatically uses the App.HelpFile property if an HelpContextID is provided
	
	Public Function PromptValue(ByRef Prompt As String, Optional ByRef Title As Object = VB6Missing, Optional ByRef [Default] As Object = VB6Missing, Optional ByRef Context As Object = VB6Missing) As String
		Return InputBox6(Prompt, Title, [Default])
	End Function

	' a function that sums all the values you pass to it
	' or concatenates them if they are strings
	
	Public Function Sum(ByVal ParamArray args() As Object) As Double
		Dim i As Short
		Dim result As Double
		For i = LBound6(args) To UBound6(args)
			result += args(i)
		Next
		Return result
	End Function

	' a function that returns the highest value among passed arguments
	
	Public Function Max(ByRef first As Double, ByVal ParamArray args() As Object) As Double
		Dim i As Short
		Dim result As Double
		result = first
		For i = LBound6(args) To UBound6(args)
			If args(i) > result Then  result = args(i)
		Next
		Return result
	End Function

	' a function that returns the lowest value among passed arguments
	
	Public Function Min(ByRef first As Double, ByVal ParamArray args() As Object) As Double
		Dim i As Short
		Dim result As Double
		result = first
		For i = LBound6(args) To UBound6(args)
			If args(i) < result Then  result = args(i)
		Next
		Return result
	End Function

	' a function that builds an array of Longs on the fly
	' (similar to VBA's Array(), which only creates Variant arrays)
	
	Public Function ArrayLong(ByVal ParamArray args() As Object) As VB6Array(Of Integer)
		Dim result As VB6Array(Of Integer)    ' Implicitly declared array
		Dim numEls As Integer
		Dim i As Integer
		numEls = UBound6(args) - LBound6(args) + 1
		If numEls <= 0 Then  Err.Raise(5) ' invalid procedure call
		Redim6(result, 0, numEls - 1)
		For i = 0 To numEls - 1
			result(i) = args(i)
		Next
		Return result
	End Function

	' check that a drive contains a disk with a given volume label
	' if it doesn't, asks the user to retry or cancel the operation
	' returns True if the volume label matches, False otherwise
	
	Public Function CheckDisk(ByVal Drive As String, ByRef VolumeLabel As String) As Boolean
		Dim saveDir As String = ""
		Dim answer As Short
		On Error GoTo Error_Handler 
		Drive = VB.Left(Drive, 1)
		' try to make that drive the current one
		saveDir = CurDir6()
		' next statement is likely to fire an error
		ChDrive(Drive)
		' return True if the label matches, False otherwise
		CheckDisk = (StrComp(Dir6(Drive & ":\*.*", FileAttribute.Volume), VolumeLabel, CompareMethod.Text) = 0)
		' restore the original current drive
		ChDrive(saveDir)
		Exit Function
Error_Handler:
		If Err.Number <> 68 And Err.Number <> 71 Then 
			' if Device unavailable/Disk Not Ready, report it to the caller
			Err.Raise(Err.Number, Err.Source, Err.Description)
		End If
		' if it is a floppy disk, give the user a second chance
		If InStr(1, "AB", Drive, CompareMethod.Text) Then 
			answer = MsgBox6("Please enter a disk in drive " & Drive, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel)
			If answer = MsgBoxResult.Retry Then  Resume 
		End If
		' else Resume with the next statement (returns False)
		Resume Next 
	End Function

End Module

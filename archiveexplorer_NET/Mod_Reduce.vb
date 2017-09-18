' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Mod_Reduce

	'This mode is not tested cause i couldn't find a file wich was reduced
	
	Friend Structure Data_Type
	
		Public Data() As Byte
		Public Pos As Integer
		Public BitPos As Short
	
	#Region "Clone method"
	
		Public Function Clone() As Data_Type
			Dim copy As Data_Type = Me
			copy.Data = Me.Data.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure

	Private BitMask(15) As Integer
	
	Private Cdata As Mod_Reduce.Data_Type
	Private Udata As Mod_Reduce.Data_Type
	
	Public Function UnReduce(ByVal ByteArray() As Byte, ByVal Level As Short, ByVal UncompressedSize As Integer) As Short
		Dim S(256, 32) As Short
		Dim N(256) As Short
		Dim B(64) As Short
		Dim j As Short
		Dim i As Short
		Dim LastC As Short
		Dim State As Short
		Dim C As Byte
		Dim LN As Short
		Dim Dist As Short
		Dim Cnt As Short
		' UPGRADE_INFO (#0561): The 'Temp' symbol was defined without an explicit "As" clause.
		Dim Temp() As Object
		Dim X As Integer
		Temp = Array6(0, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6)
		For X = 0 To 64
			B(X) = Temp(X)
		Next
		ReDim Udata.Data(UncompressedSize)
		Udata.Pos = 0
		Cdata.Data = ByteArray.Clone()
		Cdata.Pos = -1
		Cdata.BitPos = 0
		For X = 0 To 15
			BitMask(X) = 2 ^ X - 1
		Next
		Cnt = 0
		For j = 255 To 0 Step -1
			N(j) = GetBits(6)
			If N(j) > 32 Then 
				UnReduce = -1 'Follower set to large
				N(j) = 32
			End If
			For i = 0 To N(j) - 1
				S(j, i) = GetBits(8)
				Cnt += 1
			Next
		Next
		LastC = 0
		State = 0
		Do While Udata.Pos <= UncompressedSize
			If Not N(LastC) Then 
				C = GetBits(8)
			Else
				If GetBits(1) Then 
					C = GetBits(8)
				Else
					C = 0
					If N(LastC) <> 0 Then  C = GetBits(B(N(LastC)))
					C = S(LastC, C)
				End If
			End If
			LastC = C
			Select Case State
			Case 0
				If C <> 144 Then 
					Call PutByte(C)
				Else
					State = 1
				End If
			Case 1
				If C Then 
					X = 9 - Level
					Dist = Fix(C / 2 ^ X) * 256
					LN = (2 ^ X - 1) And C
					State = 3
					If LN = (2 ^ X - 1) Then  State = 2
				Else
					Call PutByte(144)
					State = 0
				End If
			Case 2
				LN += C
				State = 3
			Case 3
				Dist = Dist + (C + 1)
				LN += 3
				Do While LN
					Call PutByte(Udata.Data(Udata.Pos - Dist))
					LN -= 1
				Loop
				State = 0
			End Select
		Loop
		Return 0
	End Function

	Private Function GetBits(ByVal Numbits As Short) As Integer
		Dim NB As Short
		Dim Value As Integer
		If Numbits = 0 Then  Exit Function
		If Cdata.BitPos = 0 Then  Cdata.Pos += 1
		NB = 8 - Cdata.BitPos
		Value = Fix(Cdata.Data(Cdata.Pos) / (2 ^ Cdata.BitPos))
		Do While NB < Numbits
			Cdata.Pos += 1
			Value = Value + (Cdata.Data(Cdata.Pos) * (2 ^ NB))
			NB += 8
		Loop
		Cdata.BitPos = (Cdata.BitPos + Numbits) Mod 8
		Return Value And BitMask(Numbits)
	End Function

	Private Sub PutByte(ByVal [Char] As Byte)
		Udata.Data(Udata.Pos) = [Char]
		Udata.Pos += 1
	End Sub

End Module

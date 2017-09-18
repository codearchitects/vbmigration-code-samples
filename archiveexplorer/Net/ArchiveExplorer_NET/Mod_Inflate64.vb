' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Mod_Inflate64

	'This mod is the famoes Inflate routine used by several different
	'Compression programs like ZIP,gZip,PNG,etc..
	'This module is created by Marco v/d Berg but is heavely optimized by John Korejwa
	' IGNORED: Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (Destination As Any, Source As Any, ByVal Length As Long)
	Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As Integer, ByRef Source As Byte, ByVal Length As Integer)
	Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As Byte, ByRef Source As Byte, ByVal Length As Integer)
	
	Friend Structure CodesType
	
		Public Lenght() As Integer
		Public code() As Integer
	
	#Region "Clone method"
	
		Public Function Clone() As CodesType
			Dim copy As CodesType = Me
			copy.Lenght = Me.Lenght.Clone()
			copy.code = Me.code.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure

	Private OutStream() As Byte
	Private OutPos As Integer
	Private InStream() As Byte
	Private Inpos As Integer
	Private ByteBuff As Integer
	Private BitNum As Integer
	Private BitMask(16) As Integer
	Private Pow2(16) As Integer
	
	Private LC As Mod_Inflate64.CodesType
	Private dc As Mod_Inflate64.CodesType
	Private LitLen As Mod_Inflate64.CodesType 'Literal/length tree
	Private Dist As Mod_Inflate64.CodesType 'Distance tree
	Private TempLit As Mod_Inflate64.CodesType
	Private TempDist As Mod_Inflate64.CodesType
	
	Private LenOrder(18) As Integer
	Private MinLLenght As Integer 'Minimum length used in literal/lenght codes
	Private MaxLLenght As Integer 'Maximum length used in literal/lenght codes
	Private MinDLenght As Integer 'Minimum length used in distance codes
	Private MaxDLenght As Integer 'Maximum length used in distance codes
	Private IsStaticBuild As Boolean
	
	Public Function Inflate(ByRef ByteArray() As Byte, ByVal UncompressedSize As Integer, Optional ByVal ZIP64 As Boolean = False) As Integer
		'On Error GoTo errhandle
		
		Dim IsLastBlock As Boolean
		Dim CompType As Integer
		Dim [Char] As Integer
		Dim Nubits As Integer
		Dim L1 As Integer
		Dim L2 As Integer
		Dim X As Integer

		InStream = ByteArray.Clone() 'Copy local array to global array
		Call Init_Inflate(UncompressedSize) 'Init global variables
		
		Do
			IsLastBlock = GetBits(1) 'Read Last Block Flag
			CompType = GetBits(2) 'Read Block Type
			
			If CompType = 0 Then  'Block is Stored
				If Inpos + 4 > UBound6(InStream) Then 
					Inflate = -1 'InStream depleated
					Exit Do
				End If
				'this is done couse if bitnum >= then next byte is already in ByteBuff
				Do While BitNum >= 8
					Inpos -= 1
					BitNum -= 8
				Loop
				CopyMemory(L1, InStream(Inpos), 2%) 'Read Count
				CopyMemory(L2, InStream(Inpos + 2), 2%) 'Read ones compliment of Count
				Inpos += 4
				If L1 - (Not (L2) And &HFFFF%) Then  Inflate = -2
				If Inpos + L1 - 1 > UBound6(InStream) Then 
					Inflate = -1 'InStream depleated
					Exit Do
				End If
				If OutPos + L1 - 1 > UBound6(OutStream) Then 
					Inflate = -1 'OutStream overflow
					Exit Do
				End If
				CopyMemory(OutStream(OutPos), InStream(Inpos), L1) 'Copy stored Block
				OutPos += L1
				Inpos += L1
				ByteBuff = 0
				BitNum = 0
			ElseIf CompType = 3 Then  'Error in compressed data
				Inflate = -1
				Exit Do
			Else
				If CompType = 1 Then  'Static Compression
					If Create_Static_Tree() <> 0 Then 
						MsgBox6("Error in tree creation (Static)")
						Exit Function
					End If
					 Else 'CompType = 2            'Dynamic Compression
					If Create_Dynamic_Tree() <> 0 Then 
						MsgBox6("Error in tree creation (Static)")
						Exit Function
					End If
				End If
				Do
					NeedBits(MaxLLenght)
					Nubits = MinLLenght
					Do While LitLen.Lenght(ByteBuff And BitMask(Nubits)) <> Nubits
						Nubits += 1
					Loop
					[Char] = LitLen.code(ByteBuff And BitMask(Nubits))
					DropBits(Nubits)
					If [Char] < 256 Then  'Character is Literal
						OutStream(OutPos) = [Char] 'output the character
						OutPos += 1
					ElseIf [Char] > 256 Then  'Character is Length Symbol
						'Decode Length L1
						[Char] -= 257
						L1 = LC.code([Char]) + GetBits(LC.Lenght([Char]))
						If (L1 = 258) And ZIP64 Then  L1 = GetBits(16) + 3
						'Decode Distance L2 Symbol
						NeedBits(MaxDLenght)
						Nubits = MinDLenght
						Do While Dist.Lenght(ByteBuff And BitMask(Nubits)) <> Nubits
							Nubits += 1
						Loop
						[Char] = Dist.code(ByteBuff And BitMask(Nubits))
						DropBits(Nubits)
						L2 = dc.code([Char]) + GetBits(dc.Lenght([Char])) 'Decode Distance L2
						'copy L2 positions back L1 characters
						For X = 1 To L1
							OutStream(OutPos) = OutStream(OutPos - L2)
							OutPos += 1
						Next
					End If
				Loop While [Char] <> 256 'EOB
			End If
		Loop While Not IsLastBlock
Stop_Decompression:
		If OutPos > 0 Then 
			ReDim Preserve OutStream(OutPos - 1)
		Else
			Erase6(OutStream)
		End If
		'Clear memory
		Erase6(InStream)
		Erase6(BitMask)
		Erase6(Pow2)
		Erase6(LC.code)
		Erase6(LC.Lenght)
		Erase6(dc.code)
		Erase6(dc.Lenght)
		Erase6(LitLen.code)
		Erase6(LitLen.Lenght)
		Erase6(Dist.code)
		Erase6(Dist.Lenght)
		Erase6(LenOrder)
		ByteArray = OutStream.Clone()
		
		Exit Function
errhandle:
		If OutPos > UBound6(OutStream) Then 
			MsgBox6("Incorrect Uncompressed Size")
			GoTo Stop_Decompression
		ElseIf Inpos > UBound6(InStream) Then 
			MsgBox6("Unexpected End of File")
			GoTo Stop_Decompression
		Else
			Err.Raise(Err.Number, , Err.Description)
		End If
		
	End Function

	'This sub is used to create a static huffmann tree for inflate
	Private Function Create_Static_Tree() As Object
	' UPGRADE_INFO (#0561): The 'Create_Static_Tree' symbol was defined without an explicit "As" clause.
		Dim X As Integer
		Dim Lenght(287) As Integer
		If IsStaticBuild = False Then 
			For X = 0 To 143: Lenght(X) = 8: Next
			For X = 144 To 255: Lenght(X) = 9: Next
			For X = 256 To 279: Lenght(X) = 7: Next
			For X = 280 To 287: Lenght(X) = 8: Next
			If Create_Codes(TempLit, Lenght, 287, MaxLLenght, MinLLenght) <> 0 Then 
				Return -1
			End If
			
			For X = 0 To 31: Lenght(X) = 5: Next
			Create_Static_Tree = Create_Codes(TempDist, Lenght, 31, MaxDLenght, MinDLenght)
			IsStaticBuild = True
		Else
			MinLLenght = 7
			MaxLLenght = 9
			MinDLenght = 5
			MaxDLenght = 5
		End If
		LitLen = TempLit.Clone()
		Dist = TempDist.Clone()
	End Function

	'This sub is used to create a dynamic tree for inflate
	Private Function Create_Dynamic_Tree() As Integer
		Dim Lenght() As Integer
		Dim Bl_Tree As Mod_Inflate64.CodesType
		Dim MinBL As Integer
		Dim MaxBL As Integer
		Dim NumLen As Integer
		Dim Numdis As Integer
		Dim NumCod As Integer
		Dim [Char] As Integer
		Dim Nubits As Integer
		Dim LN As Integer
		Dim Pos As Integer
		Dim X As Integer
		
		NumLen = GetBits(5) + 257 'Get lenght of the literal/lenght tree
		Numdis = GetBits(5) + 1 'Get lenght of the distance tree
		NumCod = GetBits(4) + 4 'Get number of codes for the tree to form the other trees
		ReDim Lenght(18)
		'read the lengths per code
		For X = 0 To NumCod - 1
			Lenght(LenOrder(X)) = GetBits(3)
		Next
		'codes not used get lenght 0
		For X = NumCod To 18
			Lenght(LenOrder(X)) = 0
		Next
		'create the construction tree
		If Create_Codes(Bl_Tree, Lenght, 18, MaxBL, MinBL) <> 0 Then 
			Return -1
		End If
		
		'Get the codes for the literal/lenght and distance trees
		ReDim Lenght(NumLen + Numdis)
		Pos = 0
		Do While Pos < NumLen + Numdis
			NeedBits(MaxBL)
			Nubits = MinBL
			Do While Bl_Tree.Lenght(ByteBuff And BitMask(Nubits)) <> Nubits
				Nubits += 1
			Loop
			[Char] = Bl_Tree.code(ByteBuff And BitMask(Nubits))
			DropBits(Nubits)
			
			If [Char] < 16 Then 
				Lenght(Pos) = [Char]
				Pos += 1
			Else
				If [Char] = 16 Then 
					If Pos = 0 Then  'no last lenght
						Return -5
					End If
					LN = Lenght(Pos - 1)
					[Char] = 3 + GetBits(2)
				ElseIf [Char] = 17 Then 
					[Char] = 3 + GetBits(3)
					LN = 0
				Else
					[Char] = 11 + GetBits(7)
					LN = 0
				End If
				If Pos + [Char] > NumLen + Numdis Then  'to many lenghts
					Return -6
				End If
				Do While [Char] > 0
					[Char] -= 1
					Lenght(Pos) = LN
					Pos += 1
				Loop
			End If
		Loop
		'create the literal/lenght tree
		If Create_Codes(LitLen, Lenght, NumLen - 1, MaxLLenght, MinLLenght) <> 0 Then 
			Return -1
		End If
		For X = 0 To Numdis
			Lenght(X) = Lenght(X + NumLen)
		Next
		'create the distance tree
		Return Create_Codes(Dist, Lenght, Numdis - 1, MaxDLenght, MinDLenght)
	End Function

	'This function is used to retrieve the codes belonging to the huffmann-trees
	Private Function Create_Codes(ByRef tree As Mod_Inflate64.CodesType, ByVal Lenghts() As Integer, ByVal NumCodes As Integer, ByRef MaxBits As Integer, ByRef Minbits As Integer) As Integer
		Dim bits(16) As Integer
		Dim next_code(16) As Integer
		Dim code As Integer
		Dim LN As Integer
		Dim X As Integer
		
		'retrieve the bitlenght count and minimum and maximum bitlenghts
		Minbits = 16
		For X = 0 To NumCodes
			bits(Lenghts(X)) += 1
			If Lenghts(X) > MaxBits Then  MaxBits = Lenghts(X)
			If Lenghts(X) < Minbits And Lenghts(X) > 0 Then  Minbits = Lenghts(X)
		Next
		LN = 1
		For X = 1 To MaxBits
			LN += LN
			LN -= bits(X)
			If LN < 0 Then  Return LN 'Over subscribe, Return negative
		Next
		Create_Codes = LN
		
		ReDim tree.code(2 ^ MaxBits - 1) 'set the right dimensions
		ReDim tree.Lenght(2 ^ MaxBits - 1)
		code = 0
		bits(0) = 0
		For X = 1 To MaxBits
			code = (code + bits(X - 1)) * 2
			next_code(X) = code
		Next
		For X = 0 To NumCodes
			LN = Lenghts(X)
			If LN <> 0 Then 
				code = Bit_Reverse(next_code(LN), LN)
				tree.Lenght(code) = LN
				tree.code(code) = X
				next_code(LN) += 1
			End If
		Next
	End Function

	'Inflated codes are stored in reversed order so this funtion will
	'reverse the stored order to get the original value back
	Private Function Bit_Reverse(ByVal Value As Integer, ByVal Numbits As Integer) As Object
	' UPGRADE_INFO (#0561): The 'Bit_Reverse' symbol was defined without an explicit "As" clause.
		Do While Numbits > 0
			Bit_Reverse = Bit_Reverse * 2 + (Value And 1)
			Numbits -= 1
			Value \= 2
		Loop
	End Function

	Private Sub Init_Inflate(ByVal UncompressedSize As Integer)
		' UPGRADE_INFO (#0561): The 'Temp' symbol was defined without an explicit "As" clause.
		Dim Temp() As Object
		Dim X As Integer
		ReDim OutStream(UncompressedSize)
		Erase6(LitLen.code)
		Erase6(LitLen.Lenght)
		Erase6(Dist.code)
		Erase6(Dist.Lenght)
		ReDim LC.code(31)
		ReDim LC.Lenght(31)
		ReDim dc.code(31)
		ReDim dc.Lenght(31)
		
		'Create the read order array
		Temp = Array6(16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15)
		For X = 0 To UBound6(Temp): LenOrder(X) = Temp(X): Next
		'Create the Start lenghts array
		Temp = Array6(3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 19, 23, 27, 31, 35, 43, 51, 59, 67, 83, 99, 115, 131, 163, 195, 227, 258)
		For X = 0 To UBound6(Temp): LC.code(X) = Temp(X): Next
		'Create the Extra lenght bits array
		Temp = Array6(0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0)
		For X = 0 To UBound6(Temp): LC.Lenght(X) = Temp(X): Next
		'Create the distance code array
		Temp = Array6(1, 2, 3, 4, 5, 7, 9, 13, 17, 25, 33, 49, 65, 97, 129, 193, 257, 385, 513, 769, 1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577, 32769, 49153)
		For X = 0 To UBound6(Temp): dc.code(X) = Temp(X): Next
		'Create the extra bits distance codes
		Temp = Array6(0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14)
		For X = 0 To UBound6(Temp): dc.Lenght(X) = Temp(X): Next

		For X = 0 To 16
			BitMask(X) = 2 ^ X - 1
			Pow2(X) = 2 ^ X
		Next
		OutPos = 0
		Inpos = 0
		ByteBuff = 0
		BitNum = 0
	End Sub

	Private Sub PutByte(ByVal [Char] As Byte)
		If OutPos > UBound6(OutStream) Then  ReDim Preserve OutStream(OutPos + 1000)
		OutStream(OutPos) = [Char]
		OutPos += 1
	End Sub

	'This sub Makes sure that there are at least the number of requested bits
	'in ByteBuff
	Private Sub NeedBits(ByVal Numbits As Integer)
		While BitNum < Numbits
			If Inpos > UBound6(InStream) Then  Exit Sub 'do not past end
			ByteBuff = ByteBuff + (InStream(Inpos) * Pow2(BitNum))
			BitNum += 8
			Inpos += 1
		End While
	End Sub

	'This sub will drop the amount of bits requested
	Private Sub DropBits(ByVal Numbits As Integer)
		ByteBuff \= Pow2(Numbits)
		BitNum -= Numbits
	End Sub

	Private Function GetBits(ByVal Numbits As Integer) As Integer
		While BitNum < Numbits
			ByteBuff = ByteBuff + (InStream(Inpos) * Pow2(BitNum))
			BitNum += 8
			Inpos += 1
		End While
		GetBits = ByteBuff And BitMask(Numbits)
		ByteBuff \= Pow2(Numbits)
		BitNum -= Numbits
	End Function

End Module

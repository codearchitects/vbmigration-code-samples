' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Cls_Encrypt

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This module is created by John Korejwa
	
	Private Key0 As Integer 'Zip Encryption Keys
	Private Key1(3) As Integer 'Key1(0-3) = LSB to MSB of Key1
	Private Key2 As Integer
	Private Key1Mul(3) As Integer 'Multiplier (constant) used in update_keys
	Private Key1Tmp(3) As Integer 'Temp for intermediate Key1
	Private CRC As New Cls_CRC32
	
	'ZIP Decryption/Encryption
	Private Function decrypt_byte() As Integer
		Dim i As Integer
		Dim j As Integer
		
		i = (Key2 And 255%) Or 2%
		j = (Key2 And &HFF00%)
		Return (((i Xor 1%) * (i + j) + i * j) And &HFF00%) \ 256%
	End Function

	Private Sub update_keys(ByVal TheChar As Integer)
		Dim i As Integer
		Dim j As Integer
		Dim reg As Integer
		
		Key0 = (((Key0 And &HFFFFFF00) \ &H100%) And &HFFFFFF) Xor (CRC.GetcrcTable((Key0 And &HFF%) Xor TheChar))
		
		reg = (Key0 And 255%) 'Key1Tmp = Key1 + (Key0 And 255)
		For i = 0 To 3
			reg += Key1(i)
			Key1Tmp(i) = reg And 255%
			reg \= 256%
			Key1(i) = 0%
		Next
		
		Key1(0) = 1 'Key1 = 1 + Key1Tmp * Key1Mul
		For i = 0 To 3
			reg = 0
			For j = 0 To 3 - i
				reg = reg + Key1(i + j) + Key1Tmp(i) * Key1Mul(j)
				Key1(i + j) = reg And 255%
				reg \= 256%
			Next
		Next
		
		Key2 = (((Key2 And &HFFFFFF00) \ &H100%) And &HFFFFFF) Xor (CRC.GetcrcTable((Key2 And &HFF%) Xor Key1(3)))
		
	End Sub

	Public Sub ZipPrepareKey(ByRef Data() As Byte, ByVal PassWord As String)
		Dim C As Integer
		Dim i As Integer
		
		'Initialize Keys
		Key0 = &H12345678
		Key1(3) = &H23
		Key1(2) = &H45
		Key1(1) = &H67
		Key1(0) = &H89
		Key2 = &H34567890
		
		'Prepare Keys with password
		For i = 0 To Len6(PassWord) - 1
			C = Asc(Mid(PassWord, i + 1, 1))
			update_keys(C)
		Next
		
		'Crypt 12 byte header
		For i = 0 To 11
			C = Data(i) Xor decrypt_byte()
			update_keys(C)
			Data(i) = C
		Next
		
	End Sub

	Public Sub ZipDecryptArray(ByRef Data() As Byte)
		Dim i As Integer
		Dim C As Integer
		Dim Min As Integer
		Dim Max As Integer
		Min = LBound6(Data)
		Max = UBound6(Data)
		For i = Min To Max
			C = Data(i) Xor decrypt_byte()
			update_keys(C)
			Data(i) = C
		Next
	End Sub

	Public Sub ZipEncryptArray(ByRef Data() As Byte, ByVal PassWord As String, ByVal CRC32 As Integer)
		Dim C As Integer 'This procedure Not Tested
		Dim i As Integer
		Dim j As Integer
		Dim Max As Integer
		
		'Shift data 12 bytes, to make room for encryption header
		ReDim Preserve Data(UBound6(Data) + 12)
		Max = UBound6(Data)
		For i = Max To 12 Step -1 '    CopyMemory data(12), data(0), UBound(data) - 11
			Data(i) = Data(i - 12)
		Next
		
		'Fill first 11 bytes with random data, 12th byte with the MSB of the crc32 value
		Randomize(Timer6)
		For i = 0 To 10
			j = CInt((Max - 11) * Rnd() + 12)
			Data(i) = Data(j) Xor Int(256 * Rnd())
		Next
		j = 0
		For i = 0 To 10
			j = (j + Asc(Mid(PassWord, (i Mod Len6(PassWord)) + 1, 1))) Mod 11
			C = Data(i)
			Data(i) = Data(j)
			Data(j) = C
		Next
		Data(11) = ((CRC32 And &HFF000000) \ &H1000000) And 255%
		
		ZipPrepareKey(Data, PassWord)
		
		'Encrypt the data
		For i = 12 To UBound6(Data)
			C = Data(i) Xor decrypt_byte()
			update_keys(C)
			Data(i) = C
		Next
		
	End Sub

	Private Sub Class_Initialize_VB6()
		Key1Mul(3) = &H8
		Key1Mul(2) = &H8
		Key1Mul(1) = &H84
		Key1Mul(0) = &H5
	End Sub

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Cls_CRC32

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'This class is used to calculate a CRC32 checksum
	
	Private crcTable(255) As Integer
	Private m_CRC32 As Integer
	
	'This sub Resets to the initial crc32 value
	'This must be done explicitly when using CalcCRC32Byte
	'Usage: ???.ResetCRC32
	Public Sub ResetCRC32()
		m_CRC32 = -1
	End Sub

	'This property updates the current CRC32 value by adding new values to it
	'Usage: ???.CalcCRC32Byte = value to add
	Public WriteOnly Property CalcCRC32Byte() As Byte
		Set(ByVal NewVal As Byte)
			m_CRC32 = (((m_CRC32 And &HFFFFFF00) \ &H100) And &HFFFFFF) Xor (crcTable((m_CRC32 And &HFF) Xor NewVal))
	 	End Set
	End Property

	'This property show u the current CRC32 value
	'usage: CRC = ???.CRC32
	
	'This property sets the CRC32 value to an initial position
	'Usage: ???.CRC32 = CRC
	Public Property CRC32() As Integer
		Get
			Return m_CRC32 Xor &HFFFFFFFF
	 	End Get
		Set(ByVal CrcValue As Integer)
			m_CRC32 = CrcValue
	 	End Set
	End Property

	Public ReadOnly Property GetcrcTable(ByVal TabNum As Short) As Integer
		Get
			Return crcTable(TabNum)
	 	End Get
	End Property

	'This property calculates the CRC32 for a complete file
	'usage: FileCRC32 = ???.CalcCRC32File(Array of the file)
	Public ReadOnly Property CalcCRC32File(ByVal ByteArray() As Byte) As Integer
		Get
			Dim i As Integer
			Call ResetCRC32()
			For i = 0 To UBound6(ByteArray)
				m_CRC32 = (((m_CRC32 And &HFFFFFF00) \ &H100) And &HFFFFFF) Xor (crcTable((m_CRC32 And &HFF) Xor ByteArray(i)))
			Next
			m_CRC32 = m_CRC32 Xor &HFFFFFFFF
			Return m_CRC32
	 	End Get
	End Property

	'This sub is private and initialates the CRCTable used by the properties
	Private Sub Class_Initialize_VB6()
		Dim i As Integer
		Dim j As Integer
		Dim CRC As Integer
		For i = 0 To 255
			CRC = i
			For j = 0 To 7
				If CRC And 1 Then 
					CRC = (((CRC And &HFFFFFFFE) \ 2) And &H7FFFFFFF) Xor &HEDB88320
				Else
					CRC = ((CRC And &HFFFFFFFE) \ 2) And &H7FFFFFFF
				End If
			Next
			crcTable(i) = CRC
		Next
	End Sub

End Class

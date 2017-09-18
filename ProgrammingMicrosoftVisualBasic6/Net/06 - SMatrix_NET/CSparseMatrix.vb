' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CSparseMatrix

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------------------------------
	' CSparseMatrix class - (C) Francesco Balena
	'-------------------------------------------------------

	Private m_Value As New Collection

	<System.Runtime.InteropServices.DispId(0)> _
	Default Public Property Value(ByVal row As Integer, ByVal col As Integer) As Single
	' UPGRADE_INFO (#0501): The 'Value' member isn't used anywhere in current application.
		Get
			' returns an item, or zero if it doesn't exist
			On Error Resume Next 
			Return m_Value.Item(GetKey(row, col))
	 	End Get
		Set(ByVal newValue As Single)
			Dim key As String = GetKey(row, col)
			' first, destroy the value if in the collection
			On Error Resume Next 
			m_Value.Remove(key)
			' then add the new value, but only if not zero
			If newValue <> 0 Then  m_Value.Add(newValue, key)
	 	End Set
	End Property

	' form the key
	
	Private Function GetKey(ByRef row As Integer, ByRef col As Integer) As String
	' UPGRADE_INFO (#0551): The 'row' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'col' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return row & ControlChars.Cr & col
	End Function

End Class

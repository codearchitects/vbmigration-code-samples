' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CSparseMatrixSym

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------------------------------
	' CSparseMatrixSym class - (C) Francesco Balena
	'
	' variant of CSparseMatrix class that uses Variant indices
	' and return value, and is also symmetrical
	'  (in other words:  m(i,j) = m(j,i)
	'-------------------------------------------------------

	' this is the default value used for items not in the collection
	Public DefaultValue As Object
	
	Private m_Value As New Collection

	<System.Runtime.InteropServices.DispId(0)> _
	Default Public Property Value(ByVal row As Object, ByVal col As Object) As Object
	' UPGRADE_INFO (#0501): The 'Value' member isn't used anywhere in current application.
		Get
			' returns an item, or Empty if it doesn't exist
			On Error Resume Next 
			Value = DefaultValue
			' if the next line fails, the default value is returned instead
			Return m_Value.Item(GetKey(row, col))
	 	End Get
		Set(ByVal newValue As Object)
			Dim key As String = GetKey(row, col)
			' first, destroy the value if in the collection
			On Error Resume Next 
			m_Value.Remove(key)
			' then add the new value, but only if not zero
			If newValue <> DefaultValue Then  m_Value.Add(newValue, key)
	 	End Set
	End Property

	' form the key
	
	Private Function GetKey(ByRef row As Object, ByRef col As Object) As String
	' UPGRADE_INFO (#0551): The 'row' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'col' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' always start with the lesser of the two
		' a case insensitive comparison is needed, because collections
		' search their keys in this way
		If StrComp(row, col, CompareMethod.Text) < 0 Then 
			' using a non-printable delimiter is preferable
			Return row & ControlChars.Cr & col
		Else
			Return col & ControlChars.Cr & row
		End If
	End Function

End Class

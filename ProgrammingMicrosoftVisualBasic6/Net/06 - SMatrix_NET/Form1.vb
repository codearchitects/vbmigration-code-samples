' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Command1_Click() Handles Command1.Click
		
		' create a CSparseMatrix object
		Dim mat As CSparseMatrix = New CSparseMatrix()
		
		' start assigning values
		mat(10, 20) = 123
		mat(12, 14) = 456
		mat(23, 88) = 0 ' this doesn't really do anything
		
		PrintLine(mat(10, 20))
		PrintLine(mat(12, 14))
		PrintLine(mat(14, 16)) ' this print zero
		
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		
		' create a CSparseMatrixSym object
		Dim mat As CSparseMatrixSym = New CSparseMatrixSym()
		' set a default value for missing items
		mat.DefaultValue = 0
		
		' start assigning values
		mat("Rome", "Milan") = 550
		mat("Rome", "Florence") = 250
		mat("Rome", "Rome") = 0 ' this isn't even stored
		
		' retrieve them
		PrintLine(mat("Rome", "Milan"))
		PrintLine(mat("Milan", "Rome")) ' this works too
		PrintLine(mat("Milan", "Florence")) ' this prints 0
		
	End Sub

End Class

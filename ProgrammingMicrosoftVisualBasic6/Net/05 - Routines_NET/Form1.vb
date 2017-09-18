' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdRandomArray_Click() Handles cmdRandomArray.Click
		Dim RandArr As New VB6Array(Of Integer)()
		
		RandArr = RandomArray(10, 20)
		
	End Sub

End Class

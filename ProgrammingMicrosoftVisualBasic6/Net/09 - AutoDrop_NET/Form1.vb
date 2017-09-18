' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'DAO' type library is never used in current project. Consider deleting it from VB6 project references.
' UPGRADE_INFO (#0571): The 'ADODB' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Dir1_Click() Handles Dir1.Click
		File1.Path = Dir1.List(Dir1.ListIndex)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim i As Short
		For i = 1 To 20
			List1.AddItem("Item #" & i)
		Next
		
	End Sub

End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' retrieve a reference to a form given its name
	' if there are multiple occurrences of a form, it
	' retrieves the first occurrence in the Forms collection
	
	Public Function GetForm(ByRef formName As String) As VB6Form
	' UPGRADE_INFO (#0501): The 'GetForm' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'formName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim frm As VB6Form = Nothing
		For Each frm In Forms6
			If StrComp(frm.Name, formName, CompareMethod.Text) = 0 Then 
				Return frm
			End If
		Next
	End Function

End Module

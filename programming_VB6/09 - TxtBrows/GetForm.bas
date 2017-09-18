Attribute VB_Name = "Module1"
Option Explicit

' retrieve a reference to a form given its name
' if there are multiple occurrences of a form, it
' retrieves the first occurrence in the Forms collection

Function GetForm(formName As String) As Form
    Dim frm As Form
    For Each frm In Forms
        If StrComp(frm.Name, formName, vbTextCompare) = 0 Then
            Set GetForm = frm
            Exit Function
        End If
    Next
End Function


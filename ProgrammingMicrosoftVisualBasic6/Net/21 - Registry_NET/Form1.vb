' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	' True if showing classes.
	Private ShowClass As Boolean
	
	Private Sub cmdMathProcessor_Click() Handles cmdMathProcessor.Click
		MsgBox6("Math Processor: " & IIf(MathProcessor(), "FOUND", "NOT FOUND"), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdVbSettings_Click() Handles cmdVbSettings.Click
		Dim msg As String = "FontHeight = " & GetRegistryValue(HKEY_CURRENT_USER, "Software\Microsoft\VBA\Microsoft Visual Basic", "FontHeight", REG_DWORD) & ControlChars.Cr
		msg = msg & "FontFace = " & GetRegistryValue(HKEY_CURRENT_USER, "Software\Microsoft\VBA\Microsoft Visual Basic", "FontFace", REG_SZ)
		MsgBox6(msg, MsgBoxStyle.Information)
	End Sub

	Private Sub cmdCreate_Click() Handles cmdCreate.Click
		CreateRegistryKey(HKEY_CURRENT_USER, "Software\YourCompany")
		MsgBox6("Created the HKEY_CURRENT_USER\Software\YourCompany key", MsgBoxStyle.Information)
		
		CreateRegistryKey(HKEY_CURRENT_USER, "Software\YourCompany\YourApplication")
		MsgBox6("Created the HKEY_CURRENT_USER\Software\YourCompany\YourApplication key", MsgBoxStyle.Information)
		
		SetRegistryValue(HKEY_CURRENT_USER, "Software\YourCompany\YourApplication", "LastLogin", REG_SZ, FormatDateTime(Now))
		MsgBox6("Created the HKEY_CURRENT_USER\Software\YourCompany\YourApplication\LastLogin value", MsgBoxStyle.Information)
		
		DeleteRegistryValue(HKEY_CURRENT_USER, "Software\YourCompany\YourApplication", "LastLogin")
		MsgBox6("Deleted the HKEY_CURRENT_USER\Software\YourCompany\YourApplication\LastLogin value", MsgBoxStyle.Information)
		
		DeleteRegistryKey(HKEY_CURRENT_USER, "Software\YourCompany\YourApplication")
		MsgBox6("Deleted the HKEY_CURRENT_USER\Software\YourCompany\YourApplication key", MsgBoxStyle.Information)
		
		DeleteRegistryKey(HKEY_CURRENT_USER, "Software\YourCompany")
		MsgBox6("Deleted the HKEY_CURRENT_USER\Software\YourCompany key", MsgBoxStyle.Information)
		
	End Sub

	Private Sub cmdEnumKeys_Click() Handles cmdEnumKeys.Click
		Dim keys() As String
		Dim i As Integer
		keys = EnumRegistryKeys(HKEY_CLASSES_ROOT, "")
		
		' Filter out a few special items
		For i = LBound6(keys) To UBound6(keys)
			If VB.Left(keys(i), 1) = "." Then 
				' these are reserved names.
				keys(i) = ControlChars.NullChar
			Else
				' filter out some non-component names.
				Select Case keys(i)
				Case "*", "CLSID", "AppID", "Component Categories"
					keys(i) = ControlChars.NullChar
				End Select
			End If
		Next
		keys = Filter(keys, ControlChars.NullChar, False)
		
		List1.Clear()
		For i = LBound6(keys) To UBound6(keys)
			List1.AddItem(keys(i))
		Next
		ShowClass = True
		
	End Sub

	Private Sub List1_Click() Handles List1.Click
		' exit if not showing classes.
		If Not ShowClass Then  Exit Sub
		
		Dim clsid As String = ""
		Dim descr As String = ""
		Dim key As String = ""
		Dim value As String = ""
		
		' Try to open the CLSID key.
		clsid = GetRegistryValue(HKEY_CLASSES_ROOT, List1.Text & "\CLSID", "", REG_SZ, "")
		If Len6(clsid) = 0 Then 
			descr = "CLSID not found"
		Else
			descr = "CLSID = " & clsid & ControlChars.CrLf
			' Try to open the InProcServer key.
			key = "CLSID\" & clsid & "\InProcServer32"
			value = GetRegistryValue(HKEY_CLASSES_ROOT, key, "", REG_SZ, "")
			If Len6(value) Then 
				descr = descr & "InProcServer = " & value & ControlChars.CrLf
			End If
			' Try to open the LocalServer32 key.
			key = "CLSID\" & clsid & "\LocalServer32"
			value = GetRegistryValue(HKEY_CLASSES_ROOT, key, "", REG_SZ, "")
			If Len6(value) Then 
				descr = descr & "InProcServer = " & value & ControlChars.CrLf
			End If
			
		End If
		
		lblDescription.Caption = descr
		
	End Sub

	Private Sub cmdEnumValues_Click() Handles cmdEnumValues.Click
		Dim values(,) As Object
		Dim i As Integer
		Dim descr As String = ""
		values = EnumRegistryValues(HKEY_CURRENT_USER, "Software\Microsoft\VBA\Microsoft Visual Basic")
		
		List1.Clear()
		For i = LBound6(values, 2) To UBound6(values, 2)
			List1.AddItem(values(0, i) & " = " & ValueDescription(values(1, i)))
		Next
		ShowClass = False
	End Sub

	' Convert a value into a printable description.
	
	Private Function ValueDescription(ByVal value As Object) As String
		Dim i As Integer
		Dim buffer As String = ""
		If VarType6(value) = VariantType.Integer Then 
			Return value
		ElseIf VarType6(value) = VariantType.String Then 
			Return """" & value & """"
		ElseIf VarType6(value) = VariantType.Array + VariantType.Byte Then 
			For i = LBound6(value) To UBound6(value)
				buffer = buffer & VB.Right("0" & Hex(value(i)), 2) & " "
			Next
			Return buffer
		Else
			Return "[ unsupported data type ]"
		End If

	End Function

End Class

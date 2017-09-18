' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module Module1

	Private Const NA_VALUE As String = "<< n/a >>"
	
	' Stores a property value into a TextBox, ComboBox, or a CheckBox control.
	' Assumes that the property name is included in the control's name
	' the last argument is used only for ComboBox controls and
	' tells if the number is enumerated or bit-fielded
	
	Public Sub ShowProperty(ByRef obj As Object, ByRef ctrl As Object, Optional ByRef bitfield As Boolean = False)
		Dim propName As String = ""
		Dim propValue As Object = Nothing
		Dim i As Short
		Dim found As Boolean
		
		' Extract the name of the property.
		propName = Mid(ctrl.Name, 4)
		
		' Extract the value.
		On Error Resume Next 
		propValue = CallByName(obj, propName, CallType.Get)
		
		If Err.Number Then 
			' Special treatment for errors.
			If TypeOf ctrl Is VB6CheckBox Then 
				CObj(ctrl).value = VBRUN.CheckBoxConstants.vbGrayed
			Else
				ctrl.Text = NA_VALUE
			End If
			CObj(ctrl).DataChanged = False
			Err.Clear()
			Exit Sub
		End If
		
		If TypeOf ctrl Is VB6TextBox Then 
			ctrl.Text = propValue
		ElseIf TypeOf ctrl Is VB6CheckBox Then 
			CObj(ctrl).value = -(propValue <> 0)
		ElseIf TypeOf ctrl Is VB6ComboBox Then 
			For i = 0 To CObj(ctrl).ListCount - 1
				If Val(CObj(ctrl).ItemData(i)) = propValue Then 
					found = True
					CObj(ctrl).ListIndex = i
				End If
			Next
			If Not found Then 
				For i = 0 To CObj(ctrl).ListCount - 1
					If propValue And Val(CObj(ctrl).ItemData(i)) Then 
						found = True
						If ctrl.Text = "" Then 
							CObj(ctrl).ListIndex = i
							ctrl.Text = CObj(ctrl).List(i)
						Else
							ctrl.Text = ctrl.Text & " Or " & CObj(ctrl).List(i)
						End If
						propValue = propValue And Not Val(CObj(ctrl).ItemData(i))
						If propValue = 0 Then  Exit For
					End If
				Next
			End If
			If Not found Then  ctrl.Text = propValue
		End If
		' clear the DataChanged field.
		CObj(ctrl).DataChanged = False
	End Sub

	' Stores the contents of a control into a property
	' Assumes that the property name is included in the control's name
	
	Public Sub AssignProperty(ByRef obj As Object, ByRef ctrl As Object)
		Dim propName As String = ""
		Dim propValue As Object = Nothing
		Dim i As Short
		
		' Exit right now if no data has been modified
		If Not CObj(ctrl).DataChanged Then  Exit Sub
		
		' Extract the name of the property.
		propName = Mid(ctrl.Name, 4)
		
		On Error Resume Next 
		
		If TypeOf ctrl Is VB6TextBox Then 
			propValue = ctrl.Text
		ElseIf TypeOf ctrl Is VB6CheckBox Then 
			If CObj(ctrl).value = VBRUN.CheckBoxConstants.vbGrayed Then 
				propValue = NA_VALUE
			Else
				propValue = (CObj(ctrl).value <> 0)
			End If
		ElseIf TypeOf ctrl Is VB6ComboBox Then 
			propValue = 0
			For i = 0 To CObj(ctrl).ListCount - 1
				If StrComp(ctrl.Text, CObj(ctrl).List(i), CompareMethod.Text) = 0 Then 
					propValue = CObj(ctrl).ItemData(i)
					Exit For
				ElseIf InStr(1, "+" & ctrl.Text & "+", "+" & CObj(ctrl).List(i) & "+", CompareMethod.Text) Then 
					propValue = propValue Or CObj(ctrl).ItemData(i)
				End If
			Next
		End If
		
		If propValue = NA_VALUE Then  Exit Sub
		
		CallByName(obj, propName, CallType.Let, propValue)
		If Err.Number Then 
			MsgBox6("Unable to assign property " & propName & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
			Err.Clear()
		End If
		
	End Sub

	' Fill a ListBox with all the custom properties of an object
	
	Public Sub ShowCustomProperties(ByRef obj As Object, ByRef lst As VB6ListBox)
		Dim i As Short
		Dim tmp As String = ""
		Dim saveListIndex As Short
		
		On Error Resume Next 
		
		saveListIndex = lst.ListIndex
		lst.Clear()
		
		For i = 0 To obj.Properties.Count - 1
			tmp = obj.Properties(i).Name & " = "
			tmp &= obj.Properties(i)
			If Err.Number Then 
				tmp &= NA_VALUE
				Err.Clear()
			End If
			lst.AddItem(tmp)
		Next
		
		If saveListIndex >= 0 And saveListIndex < lst.ListCount Then 
			lst.ListIndex = saveListIndex
		ElseIf lst.ListCount Then 
			lst.ListIndex = 0
		End If
	End Sub

	' Return the name of the currently selected custom property. (read-only)
	
	Public Function GetCustomPropertyName(ByRef lst As VB6ListBox) As String
		If lst.ListIndex < 0 Then  Exit Function
		Return VB.Left(lst.Text, InStr(lst.Text, " =") - 1)
	End Function

	' Return the value of the currently selected custom property.
	
	Public Function GetCustomPropertyValue(ByRef obj As Object, ByRef lst As VB6ListBox) As String
		If lst.ListIndex < 0 Then  Exit Function
		On Error Resume Next 
		Return obj.Properties(GetCustomPropertyName(lst)).Value
	End Function

	' Assign a value to a custom property.
	
	Public Sub SetCustomPropertyValue(ByRef obj As Object, ByRef lst As VB6ListBox, ByRef newValue As Object)
		If lst.ListIndex < 0 Then  Exit Sub
		
		Dim propName As String = ""
		
		On Error Resume Next 
		propName = GetCustomPropertyName(lst)
		obj.Properties(propName) = newValue
		If Err.Number Then 
			MsgBox6("Unable to assign custom property " & propName & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
			Err.Clear()
		Else
			ShowCustomProperties(obj, lst)
		End If
	End Sub

	' Return True if a custom property is writeable.
	
	Public Function CustomPropertyIsWriteable(ByRef obj As Object, ByRef lst As VB6ListBox) As Boolean
		On Error Resume Next 
		' Note: this function uses the recommended way to check if a dynamic property
		' is writeable. However, there is evidence that this system sometimes returns
		' False event for writeable properties, so this property always returns True.
		CustomPropertyIsWriteable = (obj.Properties(lst.ListIndex).Attributes And ADODB.PropertyAttributesEnum.adPropWrite)
		Return True
	End Function

	' add a property name to a combobox, and its value in its ItemData property.
	
	Public Sub AddToCombo(ByRef cbo As VB6ComboBox, ByRef item As String, ByRef value As Integer)
		cbo.AddItem(item)
		cbo.ItemData(cbo.NewIndex) = value
	End Sub

	' Show an event in a textbox
	
	Public Sub ShowEvent(ByRef txt As VB6TextBox, ByRef EventName As String, ByVal ParamArray args() As Object)
		Dim tmp As String = ""
		Dim Index As Short
		
		On Error Resume Next 
		
		tmp = EventName & " ("
		For Index = 0 To UBound6(args) Step 2
			If Index > 0 Then  tmp &= ", "
			tmp = tmp & args(Index) & ":="
			Select Case VarType6(args(Index + 1))
			Case VariantType.String
				If VB.Left(args(Index + 1), 1) <> "#" Then 
					' This is a string to be enclosed in quotes.
					tmp = tmp & """" & args(Index + 1) & """"
				Else
					' This is a symbolic constant-
					tmp = tmp & Mid(args(Index + 1), 2)
				End If
			Case Else
				tmp = tmp & args(Index + 1)
			End Select
		Next
		tmp = tmp & ")" & ControlChars.CrLf
		
		txt.SelStart = Len6(txt.Text)
		txt.SelText = tmp
	End Sub

	'---------------------------------------------
	' ADO Specific routines
	'---------------------------------------------
	
	' Convert a Status code into a readable string.
	
	Public Function GetStatus(ByRef value As ADODB.EventStatusEnum) As String
		Select Case value
		Case ADODB.EventStatusEnum.adStatusOK
			Return "#adStatusOK"
		Case ADODB.EventStatusEnum.adStatusErrorsOccurred
			Return "#adStatusErrorsOccurred"
		Case ADODB.EventStatusEnum.adStatusCantDeny
			Return "#adStatusCantDeny"
		Case ADODB.EventStatusEnum.adStatusCancel
			Return "#adStatusCancel"
		Case ADODB.EventStatusEnum.adStatusUnwantedEvent
			Return "#adStatusUnwantedEvent"
		Case Else
			Return "#<<UNKNOWN>>"
		End Select
	End Function

	' Convert an error code into a readable string.
	
	Public Function GetError(ByRef value As ADODB.Error) As String
		If value Is Nothing Then 
			Return "OK"
		Else
			Return value.Number
		End If
	End Function

	' Retrieve the ItemData value in a combo box control.
	
	Public Function GetComboValue(ByRef cbo As VB6ComboBox) As Integer
		Return cbo.ItemData(cbo.ListIndex)
	End Function

End Module

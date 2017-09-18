Attribute VB_Name = "Module1"
Option Explicit

Const NA_VALUE = "<< n/a >>"

' Stores a property value into a TextBox, ComboBox, or a CheckBox control.
' Assumes that the property name is included in the control's name
' the last argument is used only for ComboBox controls and
' tells if the number is enumerated or bit-fielded

Sub ShowProperty(obj As Object, ctrl As Control, Optional bitfield As Boolean)
    Dim propName As String, propValue As Variant
    Dim i As Integer, found As Boolean
        
    ' Extract the name of the property.
    propName = Mid$(ctrl.Name, 4)
    
    ' Extract the value.
    On Error Resume Next
    propValue = CallByName(obj, propName, VbGet)
    
    If Err Then
        ' Special treatment for errors.
        If TypeOf ctrl Is CheckBox Then
            ctrl.value = vbGrayed
        Else
            ctrl.Text = NA_VALUE
        End If
        ctrl.DataChanged = False
        Err.Clear
        Exit Sub
    End If
    
    If TypeOf ctrl Is TextBox Then
        ctrl.Text = propValue
    ElseIf TypeOf ctrl Is CheckBox Then
        ctrl.value = -(propValue <> 0)
    ElseIf TypeOf ctrl Is ComboBox Then
        For i = 0 To ctrl.ListCount - 1
            If Val(ctrl.ItemData(i)) = propValue Then
                found = True
                ctrl.ListIndex = i
            End If
        Next
        If Not found Then
            For i = 0 To ctrl.ListCount - 1
                If propValue And Val(ctrl.ItemData(i)) Then
                    found = True
                    If ctrl.Text = "" Then
                        ctrl.ListIndex = i
                        ctrl.Text = ctrl.List(i)
                    Else
                        ctrl.Text = ctrl.Text & " Or " & ctrl.List(i)
                    End If
                    propValue = propValue And Not Val(ctrl.ItemData(i))
                    If propValue = 0 Then Exit For
                End If
            Next
        End If
        If Not found Then ctrl.Text = propValue
    End If
    ' clear the DataChanged field.
    ctrl.DataChanged = False
End Sub

' Stores the contents of a control into a property
' Assumes that the property name is included in the control's name

Sub AssignProperty(obj As Object, ctrl As Control)
    Dim propName As String, propValue As Variant
    Dim i As Integer
        
    ' Exit right now if no data has been modified
    If Not ctrl.DataChanged Then Exit Sub
        
    ' Extract the name of the property.
    propName = Mid$(ctrl.Name, 4)
    
    On Error Resume Next
    
    If TypeOf ctrl Is TextBox Then
        propValue = ctrl.Text
    ElseIf TypeOf ctrl Is CheckBox Then
        If ctrl.value = vbGrayed Then
            propValue = NA_VALUE
        Else
            propValue = (ctrl.value <> 0)
        End If
    ElseIf TypeOf ctrl Is ComboBox Then
        propValue = 0
        For i = 0 To ctrl.ListCount - 1
            If StrComp(ctrl.Text, ctrl.List(i), vbTextCompare) = 0 Then
                propValue = ctrl.ItemData(i)
                Exit For
            ElseIf InStr(1, "+" & ctrl.Text & "+", "+" & ctrl.List(i) & "+", vbTextCompare) Then
                propValue = propValue Or ctrl.ItemData(i)
            End If
        Next
    End If
    
    If propValue = NA_VALUE Then Exit Sub
    
    CallByName obj, propName, VbLet, propValue
    If Err Then
        MsgBox "Unable to assign property " & propName & vbCr & vbCr _
            & "Error = " & Err.Number & " - " & Err.Description, _
            vbExclamation, "Warning"
        Err.Clear
    End If
            
End Sub

' Fill a ListBox with all the custom properties of an object

Sub ShowCustomProperties(obj As Object, lst As ListBox)
    Dim i As Integer, tmp As String
    Dim saveListIndex As Integer
    
    On Error Resume Next
    
    saveListIndex = lst.ListIndex
    lst.Clear
    
    For i = 0 To obj.Properties.Count - 1
        tmp = obj.Properties(i).Name & " = "
        tmp = tmp & obj.Properties(i)
        If Err Then
            tmp = tmp & NA_VALUE
            Err.Clear
        End If
        lst.AddItem tmp
    Next
    
    If saveListIndex >= 0 And saveListIndex < lst.ListCount Then
        lst.ListIndex = saveListIndex
    ElseIf lst.ListCount Then
        lst.ListIndex = 0
    End If
End Sub

' Return the name of the currently selected custom property. (read-only)

Function GetCustomPropertyName(lst As ListBox) As String
    If lst.ListIndex < 0 Then Exit Function
    GetCustomPropertyName = Left$(lst.Text, InStr(lst.Text, " =") - 1)
End Function

' Return the value of the currently selected custom property.

Function GetCustomPropertyValue(obj As Object, lst As ListBox) As String
    If lst.ListIndex < 0 Then Exit Function
    On Error Resume Next
    '##ReplaceStatement Return obj.Properties(GetCustomPropertyName(lst)).Value
    GetCustomPropertyValue = obj.Properties(GetCustomPropertyName(lst))
End Function

' Assign a value to a custom property.

Sub SetCustomPropertyValue(obj As Object, lst As ListBox, newValue As Variant)
    If lst.ListIndex < 0 Then Exit Sub
    
    Dim propName As String
    
    On Error Resume Next
    propName = GetCustomPropertyName(lst)
    obj.Properties(propName) = newValue
    If Err Then
        MsgBox "Unable to assign custom property " & propName & vbCr & vbCr _
            & "Error = " & Err.Number & " - " & Err.Description, _
            vbExclamation, "Warning"
        Err.Clear
    Else
        ShowCustomProperties obj, lst
    End If
End Sub

' Return True if a custom property is writeable.

Function CustomPropertyIsWriteable(obj As Object, lst As ListBox) As Boolean
    On Error Resume Next
    ' Note: this function uses the recommended way to check if a dynamic property
    ' is writeable. However, there is evidence that this system sometimes returns
    ' False event for writeable properties, so this property always returns True.
    CustomPropertyIsWriteable = (obj.Properties(lst.ListIndex).Attributes And adPropWrite)
    CustomPropertyIsWriteable = True
End Function

' add a property name to a combobox, and its value in its ItemData property.

Sub AddToCombo(cbo As ComboBox, item As String, value As Long)
    cbo.AddItem item
    cbo.ItemData(cbo.NewIndex) = value
End Sub

' Show an event in a textbox

Sub ShowEvent(txt As TextBox, EventName As String, ParamArray args() As Variant)
    Dim tmp As String, Index As Integer
    
    On Error Resume Next
    
    tmp = EventName & " ("
    For Index = 0 To UBound(args) Step 2
        If Index > 0 Then tmp = tmp & ", "
        tmp = tmp & args(Index) & ":="
        Select Case VarType(args(Index + 1))
            Case vbString
                If Left$(args(Index + 1), 1) <> "#" Then
                    ' This is a string to be enclosed in quotes.
                    tmp = tmp & """" & args(Index + 1) & """"
                Else
                    ' This is a symbolic constant-
                    tmp = tmp & Mid$(args(Index + 1), 2)
                End If
            Case Else
                tmp = tmp & args(Index + 1)
        End Select
    Next
    tmp = tmp & ")" & vbCrLf
    
    txt.SelStart = Len(txt.Text)
    txt.SelText = tmp
End Sub

'---------------------------------------------
' ADO Specific routines
'---------------------------------------------

' Convert a Status code into a readable string.

Function GetStatus(value As EventStatusEnum) As String
    Select Case value
        Case adStatusOK
            GetStatus = "#adStatusOK"
        Case adStatusErrorsOccurred
            GetStatus = "#adStatusErrorsOccurred"
        Case adStatusCantDeny
            GetStatus = "#adStatusCantDeny"
        Case adStatusCancel
            GetStatus = "#adStatusCancel"
        Case adStatusUnwantedEvent
            GetStatus = "#adStatusUnwantedEvent"
        Case Else
            GetStatus = "#<<UNKNOWN>>"
    End Select
End Function

' Convert an error code into a readable string.

Function GetError(value As ADODB.error) As String
    If value Is Nothing Then
        GetError = "OK"
    Else
        GetError = value.Number
    End If
End Function

' Retrieve the ItemData value in a combo box control.

Function GetComboValue(cbo As ComboBox) As Long
    GetComboValue = cbo.ItemData(cbo.ListIndex)
End Function


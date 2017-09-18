' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' the name of the database
	Private dbName As String = ""
	' the collection of controls added dynamically
	Private WithEvents ControlItems As ControlItems
	Private Sub Form_Resize() Handles MyBase.Resize
		' fix a bug in the original code
		If ControlItems Is Nothing Then  Exit Sub
		
		' resize all controls to ensure that they fit in the form
		Dim ctrl As Object = Nothing
		Dim ctrlItem As ControlItem = Nothing
		
		On Error Resume Next 
		
		For Each ctrlItem In ControlItems
			ctrl = ctrlItem.Control
			ctrl.Width = ctrlItem.Properties.Item("Width")
			If ctrl.Left + ctrl.Width > ScaleWidth Then 
				ctrl.Width = ScaleWidth - ctrl.Left
			End If
		Next
	End Sub

	Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
		With CommonDialog1
			.Filter = "Access Databases (*.mdb)|*mdb|All Files (*.*)|*.*"
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist
			.ShowOpen()
			' exit if no file was selected
			If .FileName = "" Then  Exit Sub
			
			dbName = .FileName
			mnuSelect.Enabled = True
		End With
	End Sub

	Private Sub mnuSelect_Click() Handles mnuSelect.Click
		Dim source As String = ""
		On Error GoTo Error_handler 
		
		source = InputBox6("Enter a table name or a SELECT expression", "Database: " & dbName)
		If source = "" Then  Exit Sub
		
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & dbName
		Adodc1.RecordSource = source
		Adodc1.Recordset = Nothing
		Adodc1.Refresh()
		LoadControls(Adodc1.Recordset)
		
Error_handler:
		
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		Unload6(Me)
	End Sub

	Public Sub LoadControls(ByRef rs As ADODB.Recordset)
	' UPGRADE_INFO (#0551): The 'rs' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim index As Integer
		Dim field As ADODB.Field = Nothing
		Dim ctrl As Object = Nothing
		Dim ctrlItem As ControlItem = Nothing
		Dim ctrlType As String = ""
		Dim Properties As Collection = Nothing
		Dim CustomProperties As Collection = Nothing
		Dim top As Single
		Dim propItem As Object = Nothing
		Dim items() As String
		Dim fieldNum As Short
		
		' first, remove all controls added dynamically
		On Error Resume Next 
		' don't try a forward or a For Each loop
		For index = Controls6.Count - 1 To 1 Step -1
			Controls6.Remove(index)
		Next
		On Error GoTo 0 
		
		' start with a fresh ControlItems collection
		ControlItems = New ControlItems()
		
		' initial value for Top property
		top = 100
		
		' add controls corresponding to fields
		' this demo program only supports a few field types
		For Each field In rs.Fields
			ctrlType = ""
			Properties = New Collection()
			CustomProperties = New Collection()
			Select Case field.Type
			Case ADODB.DataTypeEnum.adBoolean
				ctrlType = "MSWLess.WLCheck"
				Properties.Add("Caption=")
			Case ADODB.DataTypeEnum.adSmallInt ' As Integer
				ctrlType = "MSWLess.WLText"
			Case ADODB.DataTypeEnum.adInteger ' As Long
				ctrlType = "MSWLess.WLText"
				CustomProperties.Add("IsNumeric=-1")
				CustomProperties.Add("IsInteger=-1")
			Case ADODB.DataTypeEnum.adSingle, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adCurrency
				ctrlType = "MSWLess.WLText"
				CustomProperties.Add("Numeric=-1")
			Case ADODB.DataTypeEnum.adChar, ADODB.DataTypeEnum.adVarChar ' As String
				ctrlType = "MSWLess.WLText"
				Properties.Add("Width=" & (field.DefinedSize * TextWidth("W")))
			Case ADODB.DataTypeEnum.adLongVarChar ' (memo field)
				ctrlType = "MSWLess.WLText"
				Properties.Add("Width=99999") ' very large width
				Properties.Add("Height=2000")
				Properties.Add("Multiline=-1")
				Properties.Add("ScrollBars=2") 'vbVertical
			Case ADODB.DataTypeEnum.adDate
				ctrlType = "MSWLess.WLText"
				Properties.Add("Width=1000")
				CustomProperties.Add("IsDate=-1")
			Case Else
				DebugPrintLine6(field.Name, TAB(), field.Type)
			End Select
			
			' do nothing if this field type is not supported
			If ctrlType <> "" Then 
				fieldNum += 1
				' create the label control with database field name
				ctrl = Controls6.Add("VB.Label", "Label" & fieldNum)
				ctrl.Move(50, top, 1800, 315)
				CObj(ctrl).Caption = field.Name
				CObj(ctrl).UseMnemonic = False
				CObj(ctrl).BorderStyle = 1
				CObj(ctrl).Alignment = VBRUN.AlignmentConstants.vbRightJustify
				ctrl.Visible = True
				
				' now create the control
				ctrl = Controls6.Add(ctrlType, "Field" & fieldNum)
				ctrl.Move(1900, top, 2000, 315)
				
				' if field is not updatable, lock the field
				If (field.Attributes And ADODB.FieldAttributeEnum.adFldUpdatable) = 0 Then 
					On Error Resume Next 
					CObj(ctrl).Locked = True
					If Err.Number Then  ctrl.Enabled = False
					On Error GoTo 0 
				End If
				
				' set its other properties
				For Each propItem In Properties
					' split property name and value
					items = Split(propItem, "=")
					CallByName(ctrl, items(0), CallType.Let, items(1))
				Next
				
				' link it to the Data control and make it visible
				CObj(ctrl).DataSource = Adodc1
				CObj(ctrl).DataField = field.Name
				ctrl.Visible = True
				
				' add this control to the ControlItems collection
				' this will enable to receive events from it
				ctrlItem = ControlItems.Add(ctrl)
				
				' move the actual width into the Custom Width property
				' this is used in the Form_Resize event
				ctrlItem.Properties.Add(ctrl.Width, "Width")
				
				' set its other custom properties
				For Each propItem In CustomProperties
					' split property name and value
					items = Split(propItem, "=")
					ctrlItem.Properties.Add(items(1), items(0))
				Next
				
				' increment top
				top = top + ctrl.Height + 80
			End If
		Next
		
		' force a Form_Resize event, to resize longer controls
		Call Form_Resize()
		
		Adodc1.Refresh()
		
	End Sub

	' one control added dynamically is asking for validation
	' Item.Control is a reference to the control
	' Item.GetProperty(propname) returns a custom property
	
	Private Sub ControlItems_Validate(ByRef Item As ControlItem, ByRef Cancel As Boolean) Handles ControlItems.Validate
		If Item.GetProperty("IsNumeric") Then 
			If Not IsNumeric6(Item.Control.Object.Text) Then 
				MsgBox6("Please enter a valid number")
				Cancel = True
				Exit Sub
			End If
		End If
		If Item.GetProperty("IsInteger") Then 
			If CDbl(Item.Control.Object.Text) <> Int(CDbl(Item.Control.Object.Text)) Then 
				MsgBox6("Please enter a valid Integer number")
				Cancel = True
				Exit Sub
			End If
		End If
		If Item.GetProperty("IsDate") Then 
			If Not IsDate6(Item.Control.Object.Text) Then 
				MsgBox6("Please enter a valid date")
				Cancel = True
				Exit Sub
			End If
		End If
		
	End Sub

	Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles Adodc1.MoveComplete
		Adodc1.Caption = "Record " & Adodc1.Recordset.AbsolutePosition & " of " & Adodc1.Recordset.RecordCount
	End Sub

End Class

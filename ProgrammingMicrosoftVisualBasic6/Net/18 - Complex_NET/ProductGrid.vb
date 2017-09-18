' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports CodeArchitects.VB6Library.Events

<VB6Object("Project1.ProductGrid")> _
Friend Class ProductGrid
	Implements IVB6SimpleBoundClass

	'Event Declarations
	Public Shadows Event Click As VB6EventHandler 
	Public Shadows Event DblClick As VB6EventHandler 
	Public Shadows Event KeyDown As VB6KeyEventHandler 
	Public Shadows Event KeyPress As VB6KeyPressEventHandler 
	Public Shadows Event KeyUp As VB6KeyEventHandler 
	Public Shadows Event MouseDown As VB6MouseEventHandler 
	Public Shadows Event MouseMove As VB6MouseEventHandler 
	Public Shadows Event MouseUp As VB6MouseEventHandler 
	Private WithEvents rs As ADODB.Recordset
	Private bndcol As New VB6BindingCollection
	
	Private m_DataMember As String = ""
	Private IgnoreMove As Boolean
	
		
	''' <summary>
	''' Returns/sets the background color used to display text and graphics in an object.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets the background color used to display text and graphics in an object.")> _
	Public Shadows Property BackColor() As System.Drawing.Color
		Get
			Return ListView1.BackColor
	 	End Get
		Set(ByVal New_BackColor As System.Drawing.Color)
			ListView1.BackColor = New_BackColor
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets the background color used to display text and graphics in an object.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets the background color used to display text and graphics in an object.")> _
	Public Shadows Property ForeColor() As System.Drawing.Color
		Get
			Return ListView1.ForeColor
	 	End Get
		Set(ByVal New_ForeColor As System.Drawing.Color)
			ListView1.ForeColor = New_ForeColor
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets a value that determines whether an object can respond to user-generated events.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets a value that determines whether an object can respond to user-generated events.")> _
	Public Shadows Property Enabled() As Boolean
		Get
			Return ListView1.Enabled
	 	End Get
		Set(ByVal New_Enabled As Boolean)
			ListView1.Enabled = New_Enabled
	 	End Set
	End Property

		
	''' <summary>
	''' Returns a Font object.
	''' </summary>
	<System.ComponentModel.Description("Returns a Font object.")> _
	Public Shadows Property Font() As Font
		Get
			Return ListView1.Font
	 	End Get
		Set(ByVal New_Font As Font)
			ListView1.Font = New_Font
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets the border style for an object.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets the border style for an object.")> _
	Public Shadows Property BorderStyle() As VBRUN.BorderStyleConstants
		Get
			Return ListView1.BorderStyle
	 	End Get
		Set(ByVal New_BorderStyle As VBRUN.BorderStyleConstants)
			ListView1.BorderStyle = New_BorderStyle
	 	End Set
	End Property

	Private Sub ListView1_Click() Handles ListView1.Click
		VB6EventDispatcher.Raise(Me, "Click")
	End Sub

	Private Sub ListView1_DblClick() Handles ListView1.DblClick
		VB6EventDispatcher.Raise(Me, "DblClick")
	End Sub

	Private Sub ListView1_ItemClick(ByVal Item As VB6ListItem) Handles ListView1.ItemClick
		' Change the current record.
		IgnoreMove = True
		rs.Bookmark = Item.Tag
	End Sub

	Private Sub ListView1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles ListView1.KeyDown
		VB6KeyEventDispatcher.Raise(Me, "KeyDown", KeyCode, Shift)
	End Sub

	Private Sub ListView1_KeyPress(ByRef KeyAscii As Short) Handles ListView1.KeyPress
		VB6KeyPressEventDispatcher.Raise(Me, "KeyPress", KeyAscii)
	End Sub

	Private Sub ListView1_KeyUp(ByRef KeyCode As Short, ByRef Shift As Short) Handles ListView1.KeyUp
		VB6KeyEventDispatcher.Raise(Me, "KeyUp", KeyCode, Shift)
	End Sub

	Private Sub ListView1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles ListView1.MouseDown
		VB6MouseEventDispatcher.Raise(Me, "MouseDown", Button, Shift, x, y)
	End Sub

	Private Sub ListView1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles ListView1.MouseMove
		VB6MouseEventDispatcher.Raise(Me, "MouseMove", Button, Shift, x, y)
	End Sub

	Private Sub ListView1_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles ListView1.MouseUp
		VB6MouseEventDispatcher.Raise(Me, "MouseUp", Button, Shift, x, y)
	End Sub

		
	''' <summary>
	''' Returns/sets a value which determines if the control displays a checkbox next to each item in the list.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets a value which determines if the control displays a checkbox next to each item in the list.")> _
	Public Property Checkboxes() As Boolean
		Get
			Return ListView1.Checkboxes
	 	End Get
		Set(ByVal New_Checkboxes As Boolean)
			ListView1.Checkboxes = New_Checkboxes
	 	End Set
	End Property

		
	''' <summary>
	''' Returns/sets whether selecting a column highlights the entire row.
	''' </summary>
	<System.ComponentModel.Description("Returns/sets whether selecting a column highlights the entire row.")> _
	Public Property FullRowSelect() As Boolean
		Get
			Return ListView1.FullRowSelect
	 	End Get
		Set(ByVal New_FullRowSelect As Boolean)
			ListView1.FullRowSelect = New_FullRowSelect
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=13,0,2,
	
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Shadows Property ProductName() As String
		Get
			If Ambient.UserMode = False Then  Exit  Property
			Return ListView1.ListItems(ListView1.SelectedItem.Index).Text
	 	End Get
		Set(ByVal New_ProductName As String)
			If Ambient.UserMode = False Then  Err.Raise(387)
			If New_ProductName <> ProductName Then 
				If CanPropertyChange("ProductName") Then 
					ListView1.ListItems(ListView1.SelectedItem.Index).Text = New_ProductName
				End If
			End If
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=13,0,2,
	
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Property UnitPrice() As String
		Get
			If Ambient.UserMode = False Then  Exit  Property
			Return ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(1).Text
	 	End Get
		Set(ByVal New_UnitPrice As String)
			If Ambient.UserMode = False Then  Err.Raise(387)
			If New_UnitPrice <> UnitPrice Then 
				If CanPropertyChange("UnitPrice") Then 
					ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(1).Text = New_UnitPrice
				End If
			End If
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=13,0,2,
	
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Property UnitsInStock() As String
		Get
			If Ambient.UserMode = False Then  Exit  Property
			Return ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(2).Text
	 	End Get
		Set(ByVal New_UnitsInStock As String)
			If Ambient.UserMode = False Then  Err.Raise(387)
			If New_UnitsInStock <> UnitsInStock Then 
				If CanPropertyChange("UnitsInStock") Then 
					ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(2).Text = New_UnitsInStock
				End If
			End If
	 	End Set
	End Property

	'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
	'MemberInfo=13,0,2,
	
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Property UnitsOnOrder() As String
		Get
			If Ambient.UserMode = False Then  Exit  Property
			Return ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(3).Text
	 	End Get
		Set(ByVal New_UnitsOnOrder As String)
			If Ambient.UserMode = False Then  Err.Raise(387)
			If New_UnitsOnOrder <> UnitsOnOrder Then 
				If CanPropertyChange("UnitsOnOrder") Then 
					ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(3).Text = New_UnitsOnOrder
				End If
			End If
	 	End Set
	End Property

	'Load property values from storage
	Protected Overrides Sub UserControl_ReadProperties(ByRef PropBag As VB6PropertyBag)
		
		ListView1.BackColor = FromOleColor6(PropBag.ReadProperty("BackColor", &H80000005))
		ListView1.ForeColor = FromOleColor6(PropBag.ReadProperty("ForeColor", &H80000008))
		ListView1.Enabled = PropBag.ReadProperty("Enabled", True)
		ListView1.Font = PropBag.ReadProperty("Font", Ambient.Font)
		ListView1.BorderStyle = PropBag.ReadProperty("BorderStyle", 1)
		ListView1.Checkboxes = PropBag.ReadProperty("Checkboxes", False)
		ListView1.FullRowSelect = PropBag.ReadProperty("FullRowSelect", False)
	End Sub

	Private Sub UserControl_Resize() Handles MyBase.Resize
		ListView1.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

	'Write property values to storage
	Protected Overrides Sub UserControl_WriteProperties(ByRef PropBag As VB6PropertyBag)
		
		Call PropBag.WriteProperty("BackColor", ToOleColor6(ListView1.BackColor), &H80000005)
		Call PropBag.WriteProperty("ForeColor", ToOleColor6(ListView1.ForeColor), &H80000008)
		Call PropBag.WriteProperty("Enabled", ListView1.Enabled, True)
		Call PropBag.WriteProperty("Font", ListView1.Font, Ambient.Font)
		Call PropBag.WriteProperty("BorderStyle", ListView1.BorderStyle, 1)
		Call PropBag.WriteProperty("Checkboxes", ListView1.Checkboxes, False)
		Call PropBag.WriteProperty("FullRowSelect", ListView1.FullRowSelect, False)
	End Sub

	' The DataMember property

	Public Property DataMember() As String
		Get
			Return m_DataMember
	 	End Get
		Set(ByVal newValue As String)
			m_DataMember = newValue
	 	End Set
	End Property

	' The DataSource property

	Public Property DataSource() As Object
		Get
			If Not (rs Is Nothing) Then 
				Return rs.DataSource
			End If
	 	End Get
		Set(ByVal newValue As Object)
			
			If Not Ambient.UserMode Then  Exit  Property
			
			If Not (rs Is Nothing) Then 
				' If the new value equals the old one, exit right now.
				If rs.DataSource Is newValue Then  Exit  Property
				
				If (newValue Is Nothing) Then 
					' The recordset is being closed (the program might be shutting down)
					' Flush the current record.
					On Error Resume Next 
					Select Case rs.LockType
					Case ADODB.LockTypeEnum.adLockBatchOptimistic
						rs.UpdateBatch()
					Case ADODB.LockTypeEnum.adLockOptimistic, ADODB.LockTypeEnum.adLockPessimistic
						rs.Update()
					Case Else
					End Select
				End If
			End If
			
			If Not (newValue Is Nothing) Then 
				' Recreate the recordset
				rs = New ADODB.Recordset()
				rs.DataMember = m_DataMember
				'--## ReplaceStatement rs.DataSource = DirectCast(newValue, IVB6DataSource).UnderlyingRecordset
				rs.DataSource = newValue
				' Reload all data.
				Refresh()
			End If
	 	End Set
	End Property

		Public Shadows Sub Refresh()
		' Exit if in design-mode
		If Not Ambient.UserMode Then  Exit Sub
		
		' Clear the ListView, exit if Recordset is empty or is closed.
		ListView1.ListItems.Clear()
		If rs Is Nothing Then  Exit Sub
		If rs.State <> ADODB.ObjectStateEnum.adStateOpen Then  Exit Sub
		
		' Move to the first record, but remember where we are.
		Dim Bookmark As Object = Nothing
		Dim FldName As Object = Nothing
		Bookmark = rs.Bookmark
		
		IgnoreMove = True
		rs.MoveFirst()
		
		' Load the data from the recordset into the ListView.
		Do Until rs.EOF
			With ListView1.ListItems.Add(, , rs.Fields("ProductName").Value)
				.ListSubItems.Add(, , rs.Fields("UnitPrice").Value)
				.ListSubItems.Add(, , rs.Fields("UnitsInStock").Value)
				.ListSubItems.Add(, , rs.Fields("UnitsOnOrder").Value)
				' Remember the Bookmark of this record
				.Tag = rs.Bookmark
			End With
			IgnoreMove = True
			rs.MoveNext()
		Loop
		' Restore the pointer to the current record.
		rs.Bookmark = Bookmark
		
		' bind the properties to the recordset.
		bndcol = New VB6BindingCollection()
		'--##OutputMode Remarks, 1
		bndcol.DataMember = m_DataMember
		bndcol.DataSource = rs
		
		For Each FldName In Array6("ProductName", "UnitPrice", "UnitsInStock", "UnitsOnOrder")
			bndcol.Add(Me, FldName, FldName)
		Next
		
	End Sub

	' Always hightlight the current record
	
	Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.MoveComplete
		Dim Item As VB6ListItem = Nothing
		
		' Exit if this move should be ignored.
		If IgnoreMove Then 
			IgnoreMove = False
			Exit Sub
		End If
		
		' Exit if we are in a BOF or EOF condition.
		If rs.EOF Or rs.BOF Then  Exit Sub
		' Highlight the item corresponding to the current record.
		For Each Item In ListView1.ListItems
			If Item.Tag = rs.Bookmark Then 
				ListView1.SelectedItem = Item
				Exit For
			End If
		Next
		
		' Ensure that the item is visible.
		If Not (ListView1.SelectedItem Is Nothing) Then 
			ListView1.SelectedItem.EnsureVisible()
		End If
		ListView1.Refresh()
	End Sub

	#Region "IVB6SimpleBoundClass members"
	
	Public Event BoundPropertyChanged As BoundPropertyChangedEventHandler Implements IVB6SimpleBoundClass.BoundPropertyChanged
	
	Protected Overridable Function CanPropertyChange(ByVal propertyName As String) As Boolean Implements IVB6SimpleBoundClass.CanPropertyChange
		' Changing a bound property is always allowed
		Return True
	End Function
	
	Protected Overridable Sub PropertyChanged(Byval propertyName As String) Implements IVB6SimpleBoundClass.PropertyChanged
		RaiseEvent BoundPropertyChanged(Me, New BoundPropertyChangedEventArgs(propertyName))
	End Sub
	
	#End Region

End Class

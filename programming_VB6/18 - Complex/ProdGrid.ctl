VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.UserControl ProductGrid 
   ClientHeight    =   3285
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6525
   DataBindingBehavior=   1  'vbSimpleBound
   ScaleHeight     =   3285
   ScaleWidth      =   6525
   Begin MSComctlLib.ListView ListView1 
      Height          =   2535
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   4471
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "ProductName"
         Object.Width           =   4939
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   1
         Text            =   "UnitPrice"
         Object.Width           =   2117
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   2
         Text            =   "UnitsInStock"
         Object.Width           =   2469
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   3
         Text            =   "UnitsOnOrder"
         Object.Width           =   2469
      EndProperty
   End
End
Attribute VB_Name = "ProductGrid"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:DisableMessage 0501


'Event Declarations:
Event Click() 'MappingInfo=ListView1,ListView1,-1,Click
Attribute Click.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event DblClick() 'MappingInfo=ListView1,ListView1,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when you press and release a mouse button and then press and release it again over an object."
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=ListView1,ListView1,-1,KeyDown
Attribute KeyDown.VB_Description = "Occurs when the user presses a key while an object has the focus."
Event KeyPress(KeyAscii As Integer) 'MappingInfo=ListView1,ListView1,-1,KeyPress
Attribute KeyPress.VB_Description = "Occurs when the user presses and releases an ANSI key."
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=ListView1,ListView1,-1,KeyUp
Attribute KeyUp.VB_Description = "Occurs when the user releases a key while an object has the focus."
Event MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=ListView1,ListView1,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=ListView1,ListView1,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=ListView1,ListView1,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."

Private WithEvents rs As ADODB.Recordset
Attribute rs.VB_VarHelpID = -1
Private bndcol As New BindingCollection

Private m_DataMember As String
Private IgnoreMove As Boolean

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,BackColor
Public Property Get BackColor() As OLE_COLOR
Attribute BackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    BackColor = ListView1.BackColor
End Property

Public Property Let BackColor(ByVal New_BackColor As OLE_COLOR)
    ListView1.BackColor() = New_BackColor
    PropertyChanged "BackColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,ForeColor
Public Property Get ForeColor() As OLE_COLOR
Attribute ForeColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    ForeColor = ListView1.ForeColor
End Property

Public Property Let ForeColor(ByVal New_ForeColor As OLE_COLOR)
    ListView1.ForeColor() = New_ForeColor
    PropertyChanged "ForeColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
    Enabled = ListView1.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    ListView1.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,Font
Public Property Get Font() As Font
Attribute Font.VB_Description = "Returns a Font object."
Attribute Font.VB_UserMemId = -512
    Set Font = ListView1.Font
End Property

Public Property Set Font(ByVal New_Font As Font)
    Set ListView1.Font = New_Font
    PropertyChanged "Font"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,BorderStyle
Public Property Get BorderStyle() As BorderStyleConstants
Attribute BorderStyle.VB_Description = "Returns/sets the border style for an object."
    BorderStyle = ListView1.BorderStyle
End Property

Public Property Let BorderStyle(ByVal New_BorderStyle As BorderStyleConstants)
    ListView1.BorderStyle() = New_BorderStyle
    PropertyChanged "BorderStyle"
End Property

Private Sub ListView1_Click()
    RaiseEvent Click
End Sub

Private Sub ListView1_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub ListView1_ItemClick(ByVal Item As MSComctlLib.ListItem)
    ' Change the current record.
    IgnoreMove = True
    rs.Bookmark = Item.Tag
End Sub

Private Sub ListView1_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub ListView1_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub ListView1_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
End Sub

Private Sub ListView1_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseDown(Button, Shift, x, y)
End Sub

Private Sub ListView1_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseMove(Button, Shift, x, y)
End Sub

Private Sub ListView1_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseUp(Button, Shift, x, y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,Checkboxes
Public Property Get Checkboxes() As Boolean
Attribute Checkboxes.VB_Description = "Returns/sets a value which determines if the control displays a checkbox next to each item in the list."
    Checkboxes = ListView1.Checkboxes
End Property

Public Property Let Checkboxes(ByVal New_Checkboxes As Boolean)
    ListView1.Checkboxes() = New_Checkboxes
    PropertyChanged "Checkboxes"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,FullRowSelect
Public Property Get FullRowSelect() As Boolean
Attribute FullRowSelect.VB_Description = "Returns/sets whether selecting a column highlights the entire row."
    FullRowSelect = ListView1.FullRowSelect
End Property

Public Property Let FullRowSelect(ByVal New_FullRowSelect As Boolean)
    ListView1.FullRowSelect() = New_FullRowSelect
    PropertyChanged "FullRowSelect"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,2,
Public Property Get ProductName() As String
    If Ambient.UserMode = False Then Exit Property
    ProductName = ListView1.ListItems(ListView1.SelectedItem.Index).Text
End Property

Public Property Let ProductName(ByVal New_ProductName As String)
    If Ambient.UserMode = False Then Err.Raise 387
    If New_ProductName <> ProductName Then
        If CanPropertyChange("ProductName") Then
            ListView1.ListItems(ListView1.SelectedItem.Index).Text = New_ProductName
            PropertyChanged "ProductName"
        End If
    End If
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,2,
Public Property Get UnitPrice() As String
    If Ambient.UserMode = False Then Exit Property
    UnitPrice = ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(1).Text
End Property

Public Property Let UnitPrice(ByVal New_UnitPrice As String)
    If Ambient.UserMode = False Then Err.Raise 387
    If New_UnitPrice <> UnitPrice Then
        If CanPropertyChange("UnitPrice") Then
            ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(1).Text = New_UnitPrice
            PropertyChanged "UnitPrice"
        End If
    End If
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,2,
Public Property Get UnitsInStock() As String
    If Ambient.UserMode = False Then Exit Property
    UnitsInStock = ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(2).Text
End Property

Public Property Let UnitsInStock(ByVal New_UnitsInStock As String)
    If Ambient.UserMode = False Then Err.Raise 387
    If New_UnitsInStock <> UnitsInStock Then
        If CanPropertyChange("UnitsInStock") Then
            ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(2).Text = New_UnitsInStock
            PropertyChanged "UnitsInStock"
        End If
    End If
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,2,
Public Property Get UnitsOnOrder() As String
    If Ambient.UserMode = False Then Exit Property
    UnitsOnOrder = ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(3).Text
End Property

Public Property Let UnitsOnOrder(ByVal New_UnitsOnOrder As String)
    If Ambient.UserMode = False Then Err.Raise 387
    If New_UnitsOnOrder <> UnitsOnOrder Then
        If CanPropertyChange("UnitsOnOrder") Then
            ListView1.ListItems(ListView1.SelectedItem.Index).ListSubItems(3).Text = New_UnitsOnOrder
            PropertyChanged "UnitsOnOrder"
        End If
    End If
End Property

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)

    ListView1.BackColor = PropBag.ReadProperty("BackColor", &H80000005)
    ListView1.ForeColor = PropBag.ReadProperty("ForeColor", &H80000008)
    ListView1.Enabled = PropBag.ReadProperty("Enabled", True)
    Set ListView1.Font = PropBag.ReadProperty("Font", Ambient.Font)
    ListView1.BorderStyle = PropBag.ReadProperty("BorderStyle", 1)
    ListView1.Checkboxes = PropBag.ReadProperty("Checkboxes", False)
    ListView1.FullRowSelect = PropBag.ReadProperty("FullRowSelect", False)
End Sub

Private Sub UserControl_Resize()
    ListView1.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("BackColor", ListView1.BackColor, &H80000005)
    Call PropBag.WriteProperty("ForeColor", ListView1.ForeColor, &H80000008)
    Call PropBag.WriteProperty("Enabled", ListView1.Enabled, True)
    Call PropBag.WriteProperty("Font", ListView1.Font, Ambient.Font)
    Call PropBag.WriteProperty("BorderStyle", ListView1.BorderStyle, 1)
    Call PropBag.WriteProperty("Checkboxes", ListView1.Checkboxes, False)
    Call PropBag.WriteProperty("FullRowSelect", ListView1.FullRowSelect, False)
End Sub

' The DataMember property

Public Property Get DataMember() As String
    DataMember = m_DataMember
End Property

Public Property Let DataMember(ByVal newValue As String)
    m_DataMember = newValue
End Property

' The DataSource property

Public Property Get DataSource() As DataSource
    If Not (rs Is Nothing) Then
        Set DataSource = rs.DataSource
    End If
End Property

Public Property Set DataSource(ByVal newValue As DataSource)
    
    If Not Ambient.UserMode Then Exit Property
    
    If Not (rs Is Nothing) Then
        ' If the new value equals the old one, exit right now.
        If rs.DataSource Is newValue Then Exit Property
    
        If (newValue Is Nothing) Then
            ' The recordset is being closed (the program might be shutting down)
            ' Flush the current record.
            On Error Resume Next
            Select Case rs.LockType
                Case adLockBatchOptimistic
                    rs.UpdateBatch
                Case adLockOptimistic, adLockPessimistic
                    rs.Update
                Case Else
            End Select
        End If
    End If
    
    If Not (newValue Is Nothing) Then
        ' Recreate the recordset
        Set rs = New ADODB.Recordset
        rs.DataMember = m_DataMember
        '## ReplaceStatement rs.DataSource = DirectCast(newValue, IVB6DataSource).UnderlyingRecordset
        Set rs.DataSource = newValue
        ' Reload all data.
        Refresh
    End If
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=ListView1,ListView1,-1,Refresh
Sub Refresh()
    ' Exit if in design-mode
    If Not Ambient.UserMode Then Exit Sub
    
    ' Clear the ListView, exit if Recordset is empty or is closed.
    ListView1.ListItems.Clear
    If rs Is Nothing Then Exit Sub
    If rs.State <> adStateOpen Then Exit Sub
    
    ' Move to the first record, but remember where we are.
    Dim Bookmark As Variant, FldName As Variant
    Bookmark = rs.Bookmark
    
    IgnoreMove = True
    rs.MoveFirst
    
    ' Load the data from the recordset into the ListView.
    Do Until rs.EOF
        With ListView1.ListItems.Add(, , rs("ProductName"))
            .ListSubItems.Add , , rs("UnitPrice")
            .ListSubItems.Add , , rs("UnitsInStock")
            .ListSubItems.Add , , rs("UnitsOnOrder")
            ' Remember the Bookmark of this record
            .Tag = rs.Bookmark
        End With
        IgnoreMove = True
        rs.MoveNext
    Loop
    ' Restore the pointer to the current record.
    rs.Bookmark = Bookmark
    
    ' bind the properties to the recordset.
    Set bndcol = New BindingCollection
    '##OutputMode Remarks, 1
    bndcol.DataMember = m_DataMember
    Set bndcol.DataSource = rs
    
    For Each FldName In Array("ProductName", "UnitPrice", "UnitsInStock", "UnitsOnOrder")
        bndcol.Add Me, FldName, FldName
    Next

End Sub

' Always hightlight the current record

Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    Dim Item As ListItem
    
    ' Exit if this move should be ignored.
    If IgnoreMove Then
        IgnoreMove = False
        Exit Sub
    End If
    
    ' Exit if we are in a BOF or EOF condition.
    If rs.EOF Or rs.BOF Then Exit Sub
    ' Highlight the item corresponding to the current record.
    For Each Item In ListView1.ListItems
        If Item.Tag = rs.Bookmark Then
            Set ListView1.SelectedItem = Item
            Exit For
        End If
    Next
    
    ' Ensure that the item is visible.
    If Not (ListView1.SelectedItem Is Nothing) Then
        ListView1.SelectedItem.EnsureVisible
    End If
    ListView1.Refresh
End Sub







VERSION 5.00
Begin VB.UserControl SuperListBox 
   ClientHeight    =   2190
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   2805
   EditAtDesignTime=   -1  'True
   PropertyPages   =   "XListBox.ctx":0000
   ScaleHeight     =   2190
   ScaleWidth      =   2805
   Begin VB.ListBox List1 
      Height          =   1425
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   2295
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "Edit"
      Visible         =   0   'False
      Begin VB.Menu mnuItem 
         Caption         =   "&Add item"
         Index           =   0
      End
      Begin VB.Menu mnuItem 
         Caption         =   "&Insert item"
         Index           =   1
      End
      Begin VB.Menu mnuItem 
         Caption         =   "&Remove item"
         Index           =   2
      End
      Begin VB.Menu mnuItem 
         Caption         =   "&Edit item"
         Index           =   3
      End
      Begin VB.Menu mnuItem 
         Caption         =   "-"
         Index           =   4
      End
      Begin VB.Menu mnuItem 
         Caption         =   "Move &Up"
         Index           =   5
      End
      Begin VB.Menu mnuItem 
         Caption         =   "Move &Down"
         Index           =   6
      End
      Begin VB.Menu mnuItem 
         Caption         =   "-"
         Index           =   7
      End
      Begin VB.Menu mnuItem 
         Caption         =   "&Copy item"
         Index           =   8
      End
      Begin VB.Menu mnuItem 
         Caption         =   "Copy A&ll"
         Index           =   9
      End
   End
End
Attribute VB_Name = "SuperListBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Ext_KEY = "PropPageWizardRun" ,"Yes"
Option Explicit

'##MenuStrip1.WriteProperty Visible, False
'##project:DisableMessage 0354
'##project:DisableMessage 0114
'##project:DisableMessage 0501
'##project:UseByVal Yes

Public Enum xlbShowPopupMenu
    xlbHide = 0
    xlbShow = 1
    xlbRaiseEvent = 2
End Enum

'Event Declarations:
Event ItemAdded(ByVal Index As Long)
Event ItemEdited(ByVal Index As Long)
Event ItemRemoved(ByVal Index As Long)
Event ItemMoved(ByVal oldIndex As Long, ByVal NewIndex As Long)
Event Click() 'MappingInfo=List1,List1,-1,Click
Attribute Click.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event DblClick() 'MappingInfo=List1,List1,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=List1,List1,-1,KeyDown
Attribute KeyDown.VB_Description = "Occurs when the user presses a key while an object has the focus."
Event KeyPress(KeyAscii As Integer) 'MappingInfo=List1,List1,-1,KeyPress
Attribute KeyPress.VB_Description = "Occurs when the user presses and releases an ANSI key."
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=List1,List1,-1,KeyUp
Attribute KeyUp.VB_Description = "Occurs when the user releases a key while an object has the focus."
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=List1,List1,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=List1,List1,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=List1,List1,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."
Event OLEStartDrag(Data As DataObject, AllowedEffects As Long) 'MappingInfo=List1,List1,-1,OLEStartDrag
Attribute OLEStartDrag.VB_Description = "Occurs when an OLE drag/drop operation is initiated either manually or automatically."
Event OLESetData(Data As DataObject, DataFormat As Integer) 'MappingInfo=List1,List1,-1,OLESetData
Attribute OLESetData.VB_Description = "Occurs at the OLE drag/drop source control when the drop target requests data that was not provided to the DataObject during the OLEDragStart event."
Event OLEGiveFeedback(Effect As Long, DefaultCursors As Boolean) 'MappingInfo=List1,List1,-1,OLEGiveFeedback
Attribute OLEGiveFeedback.VB_Description = "Occurs at the source control of an OLE drag/drop operation when the mouse cursor needs to be changed."
Event OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer) 'MappingInfo=List1,List1,-1,OLEDragOver
Attribute OLEDragOver.VB_Description = "Occurs when the mouse is moved over the control during an OLE drag/drop operation, if its OLEDropMode property is set to manual."
Event OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=List1,List1,-1,OLEDragDrop
Attribute OLEDragDrop.VB_Description = "Occurs when data is dropped onto the control via an OLE drag/drop operation, and OLEDropMode is set to manual."
Event OLECompleteDrag(Effect As Long) 'MappingInfo=List1,List1,-1,OLECompleteDrag
Attribute OLECompleteDrag.VB_Description = "Occurs at the OLE drag/drop source control after a manual or automatic drag/drop has been completed or canceled."

'Default Property Values:
Const m_def_ShowPopupMenu = xlbShow
Const m_def_List = ""
Const m_def_BoundPropertyName = 0

'Property Variables:
Dim m_ShowPopupMenu As xlbShowPopupMenu
Dim m_TabStops(100) As Long
Dim m_ColumnCount As Long
Dim m_BoundPropertyName As String

' API Declares
Private Type RECT
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type
Private Declare Sub GetClientRect Lib "User32" (ByVal hWnd As Long, lpRect As RECT)
Private Declare Function SendMessage Lib "User32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal msg As Long, ByVal wParam As Long, lParam As Any) As Long
Const LB_GETITEMHEIGHT = &H1A1
Const LB_SETTABSTOPS = &H192

Private Sub List1_Click()
    RaiseEvent Click
    PropertyChanged "BoundValue"
End Sub

Private Sub List1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, X, Y)
    If Button = vbRightButton And (Ambient.UserMode = False Or m_ShowPopupMenu <> xlbHide) Then
        PopupMenu mnuEdit
    End If
End Sub

Private Sub mnuEdit_Click()
    
    mnuItem(1).Enabled = List1.ListIndex >= 0
    mnuItem(2).Enabled = List1.ListIndex >= 0
    mnuItem(3).Enabled = List1.ListIndex >= 0
    mnuItem(5).Enabled = List1.ListIndex > 0
    mnuItem(6).Enabled = List1.ListIndex >= 0 And List1.ListIndex < List1.ListCount - 1
    mnuItem(8).Enabled = List1.ListIndex >= 0
    
    mnuItem(9).Enabled = List1.ListIndex >= 0

End Sub

Private Sub mnuItem_Click(Index As Integer)

    Dim item As String, listndx As Long
    Dim i As Long

    listndx = List1.ListIndex
    item = List1.Text

    Select Case Index
    Case 0, 1   ' add & insert item
        If Index = 0 Then
            listndx = List1.ListCount
        End If
        If Ambient.UserMode = False Or m_ShowPopupMenu = xlbShow Then
            item = InputBox$("Insert new item at index " & listndx, "XListBox")
            If Len(item) Then
                List1.AddItem item, listndx
                PropertyChanged "AllItems"
            End If
        Else
            RaiseEvent ItemAdded(listndx)
        End If
    
    Case 2    ' remove item
        If Ambient.UserMode = False Or m_ShowPopupMenu = xlbShow Then
            If List1.ListIndex >= 0 Then
                List1.RemoveItem listndx
                PropertyChanged "AllItems"
            End If
        Else
            RaiseEvent ItemRemoved(listndx)
        End If
        
    Case 3      ' edit item
        If Ambient.UserMode = False Or m_ShowPopupMenu = xlbShow Then
            item = InputBox$("Edit item at index " & listndx, "XListbox", item)
            If Len(item) Then
                List1.RemoveItem listndx
                List1.AddItem item, listndx
                List1.ListIndex = listndx
                PropertyChanged "AllItems"
            End If
        Else
            RaiseEvent ItemEdited(listndx)
        End If
    
    Case 5, 6   ' move up or down
        listndx = listndx + (Index = 5) - (Index = 6)
        If Ambient.UserMode = False Or m_ShowPopupMenu = xlbShow Then
            List1.RemoveItem List1.ListIndex
            List1.AddItem item, listndx
            List1.ListIndex = listndx
            PropertyChanged "AllItems"
        Else
            RaiseEvent ItemMoved(List1.ListIndex, listndx)
        End If
    Case 8    ' copy item
        Clipboard.SetText item
    Case 9    ' copy all items
        If List1.MultiSelect Then
            item = ""
            For i = 0 To List1.ListCount - 1
                If List1.Selected(i) Then
                    item = item & List1.List(i) & vbCrLf
                End If
            Next
        End If
    End Select
End Sub

Private Sub UserControl_Resize()
    If Label1 = "" Then
        List1.Move 0, 0, ScaleWidth, ScaleHeight
    Else
        Label1.Move 0, 0, ScaleWidth, Label1.Height
        List1.Move 0, Label1.Height, ScaleWidth, ScaleHeight - Label1.Height
    End If
    
End Sub
'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,BackColor
Public Property Get BackColor() As OLE_COLOR
Attribute BackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    BackColor = List1.BackColor
End Property

Public Property Let BackColor(ByVal New_BackColor As OLE_COLOR)
    List1.BackColor() = New_BackColor
    PropertyChanged "BackColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,ForeColor
Public Property Get ForeColor() As OLE_COLOR
Attribute ForeColor.VB_Description = "Returns/sets the foreground color used to display text and graphics in an object."
    ForeColor = List1.ForeColor
End Property

Public Property Let ForeColor(ByVal New_ForeColor As OLE_COLOR)
    List1.ForeColor() = New_ForeColor
    PropertyChanged "ForeColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
Attribute Enabled.VB_ProcData.VB_Invoke_Property = "General"
    Enabled = UserControl.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    UserControl.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Font
Public Property Get Font() As Font
Attribute Font.VB_Description = "Returns a Font object."
Attribute Font.VB_UserMemId = -512
    Set Font = List1.Font
End Property

Public Property Set Font(ByVal New_Font As Font)
    Set List1.Font = New_Font
    PropertyChanged "Font"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Refresh
Public Sub Refresh()
Attribute Refresh.VB_Description = "Forces a complete repaint of a object."
    List1.Refresh
End Sub

Private Sub List1_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub List1_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub List1_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub List1_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
End Sub

Private Sub List1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseMove(Button, Shift, X, Y)
End Sub

Private Sub List1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, X, Y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,AddItem
Public Sub AddItem(item As String, Optional Index As Variant)
Attribute AddItem.VB_Description = "Adds an item to a Listbox or ComboBox control or a row to a Grid control."
    '##InsertStatement If IsMissing6(Index) Then Index = -1
    List1.AddItem item, Index
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Label1,Label1,-1,Caption
Public Property Get Caption() As String
Attribute Caption.VB_Description = "Returns/sets the text displayed in an object's title bar or below an object's icon."
Attribute Caption.VB_ProcData.VB_Invoke_Property = "General"
Attribute Caption.VB_UserMemId = -518
Attribute Caption.VB_MemberFlags = "14"
    Caption = Label1.Caption
End Property

Public Property Let Caption(ByVal New_Caption As String)
    If Label1.Caption = "" Xor New_Caption <> "" Then
        Label1.Caption = New_Caption
        UserControl_Resize
    Else
        Label1.Caption = New_Caption
    End If
    PropertyChanged "Caption"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Clear
Public Sub Clear()
Attribute Clear.VB_Description = "Clears the contents of a control or the system Clipboard."
    List1.Clear
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontBold
Public Property Get FontBold() As Boolean
Attribute FontBold.VB_Description = "Returns/sets bold font styles."
    FontBold = List1.FontBold
End Property

Public Property Let FontBold(ByVal New_FontBold As Boolean)
    List1.FontBold() = New_FontBold
    PropertyChanged "FontBold"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontItalic
Public Property Get FontItalic() As Boolean
Attribute FontItalic.VB_Description = "Returns/sets italic font styles."
    FontItalic = List1.FontItalic
End Property

Public Property Let FontItalic(ByVal New_FontItalic As Boolean)
    List1.FontItalic() = New_FontItalic
    PropertyChanged "FontItalic"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontName
Public Property Get FontName() As String
Attribute FontName.VB_Description = "Specifies the name of the font that appears in each row for the given level."
    FontName = List1.FontName
End Property

Public Property Let FontName(ByVal New_FontName As String)
    List1.FontName() = New_FontName
    PropertyChanged "FontName"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontSize
Public Property Get FontSize() As Single
Attribute FontSize.VB_Description = "Specifies the size (in points) of the font that appears in each row for the given level."
    FontSize = List1.FontSize
End Property

Public Property Let FontSize(ByVal New_FontSize As Single)
    List1.FontSize() = New_FontSize
    PropertyChanged "FontSize"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontStrikethru
Public Property Get FontStrikethru() As Boolean
Attribute FontStrikethru.VB_Description = "Returns/sets strikethrough font styles."
    FontStrikethru = List1.FontStrikethru
End Property

Public Property Let FontStrikethru(ByVal New_FontStrikethru As Boolean)
    List1.FontStrikethru() = New_FontStrikethru
    PropertyChanged "FontStrikethru"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,FontUnderline
Public Property Get FontUnderline() As Boolean
Attribute FontUnderline.VB_Description = "Returns/sets underline font styles."
    FontUnderline = List1.FontUnderline
End Property

Public Property Let FontUnderline(ByVal New_FontUnderline As Boolean)
    List1.FontUnderline() = New_FontUnderline
    PropertyChanged "FontUnderline"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,hWnd
Public Property Get hWnd() As Long
Attribute hWnd.VB_Description = "Returns a handle (from Microsoft Windows) to an object's window."
    hWnd = List1.hWnd
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,ItemData
Public Property Get ItemData(Index As Integer) As Long
Attribute ItemData.VB_Description = "Returns/sets a specific number for each item in a ComboBox or ListBox control."
    ItemData = List1.ItemData(Index)
End Property

Public Property Let ItemData(Index As Integer, ByVal New_ItemData As Long)
    List1.ItemData(Index) = New_ItemData
    PropertyChanged "ItemData"
End Property
'
'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,ListCount
Public Property Get ListCount() As Integer
Attribute ListCount.VB_Description = "Returns the number of items in the list portion of a control."
    ListCount = List1.ListCount
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,ListIndex
Public Property Get ListIndex() As Integer
Attribute ListIndex.VB_Description = "Returns/sets the index of the currently selected item in the control."
Attribute ListIndex.VB_MemberFlags = "400"
    ListIndex = List1.ListIndex
End Property

Public Property Let ListIndex(ByVal New_ListIndex As Integer)
    List1.ListIndex() = New_ListIndex
    PropertyChanged "ListIndex"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,MouseIcon
Public Property Get MouseIcon() As Picture
Attribute MouseIcon.VB_Description = "Sets a custom mouse icon."
    Set MouseIcon = List1.MouseIcon
End Property

Public Property Set MouseIcon(ByVal New_MouseIcon As Picture)
    Set List1.MouseIcon = New_MouseIcon
    PropertyChanged "MouseIcon"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,MousePointer
Public Property Get MousePointer() As Integer
Attribute MousePointer.VB_Description = "Returns/sets the type of mouse pointer displayed when over part of an object."
    MousePointer = List1.MousePointer
End Property

Public Property Let MousePointer(ByVal New_MousePointer As Integer)
    List1.MousePointer() = New_MousePointer
    PropertyChanged "MousePointer"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,MultiSelect
Public Property Get MultiSelect() As Integer
Attribute MultiSelect.VB_Description = "Returns/sets a value that determines whether a user can make multiple selections in a control."
    MultiSelect = List1.MultiSelect
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,NewIndex
Public Property Get NewIndex() As Integer
Attribute NewIndex.VB_Description = "Returns the index of the item most recently added to a control."
    NewIndex = List1.NewIndex
End Property

Private Sub List1_OLEStartDrag(Data As DataObject, AllowedEffects As Long)
    RaiseEvent OLEStartDrag(Data, AllowedEffects)
End Sub

Private Sub List1_OLESetData(Data As DataObject, DataFormat As Integer)
    RaiseEvent OLESetData(Data, DataFormat)
End Sub

Private Sub List1_OLEGiveFeedback(Effect As Long, DefaultCursors As Boolean)
    RaiseEvent OLEGiveFeedback(Effect, DefaultCursors)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,OLEDropMode
Public Property Get OLEDropMode() As Integer
Attribute OLEDropMode.VB_Description = "Returns/Sets whether this object can act as an OLE drop target."
    OLEDropMode = List1.OLEDropMode
End Property

Public Property Let OLEDropMode(ByVal New_OLEDropMode As Integer)
    List1.OLEDropMode() = New_OLEDropMode
    PropertyChanged "OLEDropMode"
End Property

Private Sub List1_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    RaiseEvent OLEDragOver(Data, Effect, Button, Shift, X, Y, State)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,OLEDragMode
Public Property Get OLEDragMode() As Integer
Attribute OLEDragMode.VB_Description = "Returns/Sets whether this object can act as an OLE drag/drop source, and whether this process is started automatically or under programmatic control."
    OLEDragMode = List1.OLEDragMode
End Property

Public Property Let OLEDragMode(ByVal New_OLEDragMode As Integer)
    List1.OLEDragMode() = New_OLEDragMode
    PropertyChanged "OLEDragMode"
End Property

Private Sub List1_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent OLEDragDrop(Data, Effect, Button, Shift, X, Y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,OLEDrag
Public Sub OLEDrag()
Attribute OLEDrag.VB_Description = "Starts an OLE drag/drop event with the given control as the source."
    List1.OLEDrag
End Sub

Private Sub List1_OLECompleteDrag(Effect As Long)
    RaiseEvent OLECompleteDrag(Effect)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,RemoveItem
Public Sub RemoveItem(Index As Integer)
Attribute RemoveItem.VB_Description = "Removes an item from a ListBox or ComboBox control or a row from a Grid control."
    List1.RemoveItem Index
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,SelCount
Public Property Get SelCount() As Integer
Attribute SelCount.VB_Description = "Returns the number of selected items in a ListBox control."
    SelCount = List1.SelCount
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Selected
Public Property Get Selected(Index As Integer) As Boolean
Attribute Selected.VB_Description = "Returns/sets the selection status of an item in a control."
    Selected = List1.Selected(Index)
End Property

Public Property Let Selected(Index As Integer, ByVal New_Selected As Boolean)
    List1.Selected(Index) = New_Selected
    PropertyChanged "Selected"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Sorted
Public Property Get Sorted() As Boolean
Attribute Sorted.VB_Description = "Indicates whether the elements of a control are automatically sorted alphabetically."
    Sorted = List1.Sorted
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,Text
Public Property Get Text() As String
Attribute Text.VB_Description = "Returns/sets the text contained in the control."
Attribute Text.VB_UserMemId = 0
Attribute Text.VB_MemberFlags = "400"
    Text = List1.Text
End Property

Public Property Let Text(ByVal New_Text As String)
    List1.Text() = New_Text
    PropertyChanged "Text"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=List1,List1,-1,TopIndex
Public Property Get TopIndex() As Integer
Attribute TopIndex.VB_Description = "Returns/sets which item in a control is displayed in the topmost position."
    TopIndex = List1.TopIndex
End Property

Public Property Let TopIndex(ByVal New_TopIndex As Integer)
    List1.TopIndex() = New_TopIndex
    PropertyChanged "TopIndex"
End Property

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
Dim Index As Integer

    On Error Resume Next

    List1.BackColor = PropBag.ReadProperty("BackColor", &H80000005)
    List1.ForeColor = PropBag.ReadProperty("ForeColor", &H80000008)
    List1.Enabled = PropBag.ReadProperty("Enabled", True)
    Set Font = PropBag.ReadProperty("Font", Ambient.Font)
    Label1.Caption = PropBag.ReadProperty("Caption", "Label1")
    Set MouseIcon = PropBag.ReadProperty("MouseIcon", Nothing)
    List1.MousePointer = PropBag.ReadProperty("MousePointer", 0)
    List1.OLEDropMode = PropBag.ReadProperty("OLEDropMode", 0)
    List1.OLEDragMode = PropBag.ReadProperty("OLEDragMode", 0)
    
    AllItems = PropBag.ReadProperty("AllItems", m_def_List)
    m_ShowPopupMenu = PropBag.ReadProperty("ShowPopupMenu", m_def_ShowPopupMenu)
    m_BoundPropertyName = PropBag.ReadProperty("BoundPropertyName", m_def_BoundPropertyName)
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
Dim Index As Integer

    Call PropBag.WriteProperty("BackColor", List1.BackColor, &H80000005)
    Call PropBag.WriteProperty("ForeColor", List1.ForeColor, &H80000008)
    Call PropBag.WriteProperty("Enabled", List1.Enabled, True)
    Call PropBag.WriteProperty("Font", Font, Ambient.Font)
    Call PropBag.WriteProperty("Caption", Label1.Caption, "Label1")
    Call PropBag.WriteProperty("MouseIcon", MouseIcon, Nothing)
    Call PropBag.WriteProperty("MousePointer", List1.MousePointer, 0)
    Call PropBag.WriteProperty("OLEDropMode", List1.OLEDropMode, 0)
    Call PropBag.WriteProperty("OLEDragMode", List1.OLEDragMode, 0)
    Call PropBag.WriteProperty("AllItems", AllItems, m_def_List)
    Call PropBag.WriteProperty("ShowPopupMenu", m_ShowPopupMenu, m_def_ShowPopupMenu)
    Call PropBag.WriteProperty("BoundPropertyName", m_BoundPropertyName, m_def_BoundPropertyName)
End Sub

Public Property Get List(ByVal Index As Long) As String
Attribute List.VB_Description = "Returns/sets the items contained in a control's list portion."
    List = List1.List(Index)
End Property

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    m_ShowPopupMenu = m_def_ShowPopupMenu
    m_BoundPropertyName = m_def_BoundPropertyName
    Label1.Caption = Ambient.DisplayName
End Sub

Public Property Get ShowPopupMenu() As xlbShowPopupMenu
Attribute ShowPopupMenu.VB_Description = "True if the listbox will show a popup menu for managing items"
Attribute ShowPopupMenu.VB_ProcData.VB_Invoke_Property = "General"
    ShowPopupMenu = m_ShowPopupMenu
End Property

Public Property Let ShowPopupMenu(ByVal New_ShowPopupMenu As xlbShowPopupMenu)
    m_ShowPopupMenu = New_ShowPopupMenu
    PropertyChanged "ShowPopupMenu"
End Property

Property Get AllItems() As String
Attribute AllItems.VB_ProcData.VB_Invoke_Property = "General"
Attribute AllItems.VB_MemberFlags = "14"
    Dim i As Long, result As String
    For i = 0 To List1.ListCount - 1
        result = result & List1.List(i) & vbCrLf
    Next
    AllItems = result
End Property

Property Let AllItems(newValue As String)
    Dim i As Long
    List1.Clear
    Do
        i = InStr(newValue, vbCrLf)
        If i = 0 Then Exit Do
        List1.AddItem Left$(newValue, i - 1)
        newValue = Mid$(newValue, i + 2)
    Loop While Len(newValue)
End Property

Public Sub AddColumn(ByVal dialogUnits As Long)
Attribute AddColumn.VB_Description = "Adds a new column for columnar listboxes"
    Dim i As Long, j As Long
    
    Do While i < m_ColumnCount
        i = i + 1
        If m_TabStops(i) = dialogUnits Then
            Exit Sub
        ElseIf m_TabStops(i) > dialogUnits Then
            Exit Do
        End If
    Loop
    
    For j = m_ColumnCount To i Step -1
        m_TabStops(j + 1) = m_TabStops(j)
    Next
    m_TabStops(i) = dialogUnits
    m_ColumnCount = m_ColumnCount + 1
    SendMessage List1.hWnd, LB_SETTABSTOPS, m_ColumnCount, m_TabStops(1)
    
End Sub

Public Sub RemoveColumn(ByVal colIndex As Integer)
Attribute RemoveColumn.VB_Description = "Remove a column of data in a columnar listbox"
    Dim i As Long
    
    If colIndex <= 0 Or colIndex > m_ColumnCount Then Exit Sub
    
    For i = colIndex To m_ColumnCount
        m_TabStops(i) = m_TabStops(i + 1)
    Next
    m_ColumnCount = m_ColumnCount - 1
    SendMessage List1.hWnd, LB_SETTABSTOPS, m_ColumnCount, m_TabStops(1)
    
End Sub

Public Function ColumnCount() As Long
    ColumnCount = m_ColumnCount
End Function

Public Function VisibleItems() As Integer
Attribute VisibleItems.VB_MemberFlags = "400"
        ' return the number of visible items in a listbox
    Dim lpRect As RECT, itemHeight As Integer
    
    ' get list box internal area size
    GetClientRect List1.hWnd, lpRect
    ' get the height of each list box's item
    itemHeight = SendMessage(List1.hWnd, LB_GETITEMHEIGHT, 0, 0)
    ' evaluate number of visible items
    VisibleItems = (lpRect.Bottom - lpRect.Top) \ itemHeight

End Function

Public Property Get BoundPropertyName() As String
Attribute BoundPropertyName.VB_ProcData.VB_Invoke_Property = "General"
    BoundPropertyName = m_BoundPropertyName
End Property

Public Property Let BoundPropertyName(newValue As String)
    m_BoundPropertyName = newValue
End Property


Public Property Get BoundValue() As Variant
Attribute BoundValue.VB_ProcData.VB_Invoke_Property = "General"
Attribute BoundValue.VB_MemberFlags = "64"
    BoundValue = CallByName(Me, BoundPropertyName, VbGet)
End Property

Public Property Let BoundValue(newValue As Variant)
    
    Dim i As Long
    Select Case BoundPropertyName
        Case "Text", "List"
            ' This is a special case, because these properties are read-only.
            List1.ListIndex = -1
            For i = 0 To List1.ListCount - 1
                If List1.List(i) = newValue Then
                    List1.ListIndex = i
                    Exit For
                End If
            Next
    Case Else
        CallByName Me, BoundPropertyName, VbLet, newValue
    End Select
    PropertyChanged "BoundValue"
End Property









VERSION 5.00
Begin VB.UserControl SuperTextBox 
   ClientHeight    =   1095
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5040
   EditAtDesignTime=   -1  'True
   ScaleHeight     =   1095
   ScaleWidth      =   5040
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   4695
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   4815
   End
End
Attribute VB_Name = "SuperTextBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

'##Text1.WriteProperty MultiLine, True
'##project:DisableMessage 0354
'##project:DisableMessage 0501


Option Explicit
'Default Property Values:
Const m_def_FormatMask = ""
Const m_def_FormattedText = ""
'Property Variables:
Dim m_FormatMask As String
Dim m_FormattedText As String
'Event Declarations:
Event Click() 'MappingInfo=Text1,Text1,-1,Click
Attribute Click.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event DblClick() 'MappingInfo=Text1,Text1,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=Text1,Text1,-1,KeyDown
Attribute KeyDown.VB_Description = "Occurs when the user presses a key while an object has the focus."
Event KeyPress(KeyAscii As Integer) 'MappingInfo=Text1,Text1,-1,KeyPress
Attribute KeyPress.VB_Description = "Occurs when the user presses and releases an ANSI key."
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=Text1,Text1,-1,KeyUp
Attribute KeyUp.VB_Description = "Occurs when the user releases a key while an object has the focus."
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=Text1,Text1,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=Text1,Text1,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=Text1,Text1,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."
Event Change() 'MappingInfo=Text1,Text1,-1,Change
Attribute Change.VB_Description = "Occurs when the contents of a control have changed."
Attribute Change.VB_MemberFlags = "200"
Event SelChange()



' These are used by the CheckSelChange routine.
Private saveSelStart As Long, saveSelLength As Long

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,BackColor
Public Property Get BackColor() As OLE_COLOR
Attribute BackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
Attribute BackColor.VB_MemberFlags = "400"
    BackColor = Text1.BackColor
End Property

Public Property Let BackColor(ByVal New_BackColor As OLE_COLOR)
    Text1.BackColor() = New_BackColor
    PropertyChanged "BackColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,ForeColor
Public Property Get ForeColor() As OLE_COLOR
Attribute ForeColor.VB_Description = "Returns/sets the foreground color used to display text and graphics in an object."
    ForeColor = Text1.ForeColor
End Property

Public Property Let ForeColor(ByVal New_ForeColor As OLE_COLOR)
    Text1.ForeColor() = New_ForeColor
    PropertyChanged "ForeColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
Attribute Enabled.VB_UserMemId = -514
    Enabled = Text1.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    Text1.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,Font
Public Property Get Font() As Font
Attribute Font.VB_Description = "Returns a Font object."
Attribute Font.VB_UserMemId = -512
    Set Font = Text1.Font
End Property

Public Property Set Font(ByVal New_Font As Font)
    Set Text1.Font = New_Font
    PropertyChanged "Font"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,BorderStyle
Public Property Get BorderStyle() As Integer
Attribute BorderStyle.VB_Description = "Returns/sets the border style for an object."
    BorderStyle = Text1.BorderStyle
End Property

Public Property Let BorderStyle(ByVal New_BorderStyle As Integer)
    Text1.BorderStyle() = New_BorderStyle
    PropertyChanged "BorderStyle"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,Refresh
Public Sub Refresh()
Attribute Refresh.VB_Description = "Forces a complete repaint of a object."
    UserControl.Refresh
End Sub

Private Sub Text1_Click()
    RaiseEvent Click
End Sub

Private Sub Text1_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub Label1_Click()
    RaiseEvent Click
End Sub

Private Sub Label1_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub Text1_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub Text1_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
    CheckSelChange
End Sub

Private Sub Text1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, _
        ScaleX(Text1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Text1.Top + Y, vbTwips, vbContainerPosition))
End Sub

Private Sub Text1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseMove(Button, Shift, _
        ScaleX(Text1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Text1.Top + Y, vbTwips, vbContainerPosition))
    CheckSelChange
End Sub

Private Sub Text1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, _
        ScaleX(Text1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Text1.Top + Y, vbTwips, vbContainerPosition))
    CheckSelChange
End Sub

Private Sub Label1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, _
        ScaleX(Label1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Label1.Top + Y, vbTwips, vbContainerPosition))
End Sub

Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseMove(Button, Shift, _
        ScaleX(Label1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Label1.Top + Y, vbTwips, vbContainerPosition))
    CheckSelChange
End Sub

Private Sub Label1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, _
        ScaleX(Label1.Left + X, vbTwips, vbContainerPosition), _
        ScaleY(Label1.Top + Y, vbTwips, vbContainerPosition))
    CheckSelChange
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,Alignment
Public Property Get Alignment() As Integer
Attribute Alignment.VB_Description = "Returns/sets the alignment of a CheckBox or OptionButton, or a control's text."
Attribute Alignment.VB_ProcData.VB_Invoke_Property = ";List"
    Alignment = Text1.Alignment
End Property

Public Property Let Alignment(ByVal New_Alignment As Integer)
    Text1.Alignment() = New_Alignment
    PropertyChanged "Alignment"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Label1,Label1,-1,Caption
Public Property Get Caption() As String
Attribute Caption.VB_Description = "Returns/sets the text displayed in an object's title bar or below an object's icon."
Attribute Caption.VB_UserMemId = -518
    Caption = Label1.Caption
End Property

Public Property Let Caption(ByVal New_Caption As String)
    Label1.Caption() = New_Caption
    PropertyChanged "Caption"
    'Call UserControl_Resize
End Property

Private Sub Text1_Change()
    RaiseEvent Change
    CheckSelChange
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,hWnd
Public Property Get hWnd() As Long
Attribute hWnd.VB_Description = "Returns a handle (from Microsoft Windows) to an object's window."
    hWnd = Text1.hWnd
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,Locked
Public Property Get Locked() As Boolean
Attribute Locked.VB_Description = "Determines whether a control can be edited."
    Locked = Text1.Locked
End Property

Public Property Let Locked(ByVal New_Locked As Boolean)
    Text1.Locked() = New_Locked
    PropertyChanged "Locked"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,MaxLength
Public Property Get MaxLength() As Long
Attribute MaxLength.VB_Description = "Returns/sets the maximum number of characters that can be entered in a control."
    MaxLength = Text1.MaxLength
End Property

Public Property Let MaxLength(ByVal New_MaxLength As Long)
    Text1.MaxLength() = New_MaxLength
    PropertyChanged "MaxLength"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,MouseIcon
Public Property Get MouseIcon() As Picture
Attribute MouseIcon.VB_Description = "Sets a custom mouse icon."
    Set MouseIcon = Text1.MouseIcon
End Property

Public Property Set MouseIcon(ByVal New_MouseIcon As Picture)
    Set Text1.MouseIcon = New_MouseIcon
    PropertyChanged "MouseIcon"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,MousePointer
Public Property Get MousePointer() As MousePointerConstants
Attribute MousePointer.VB_Description = "Returns/sets the type of mouse pointer displayed when over part of an object."
    MousePointer = Text1.MousePointer
End Property

Public Property Let MousePointer(ByVal New_MousePointer As MousePointerConstants)
    Text1.MousePointer() = New_MousePointer
    PropertyChanged "MousePointer"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,PasswordChar
Public Property Get PasswordChar() As String
Attribute PasswordChar.VB_Description = "Returns/sets a value that determines whether characters typed by a user or placeholder characters are displayed in a control."
    PasswordChar = Text1.PasswordChar
End Property

Public Property Let PasswordChar(ByVal New_PasswordChar As String)
    Text1.PasswordChar() = New_PasswordChar
    PropertyChanged "PasswordChar"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,Text
Public Property Get Text() As String
Attribute Text.VB_Description = "Returns/sets the text contained in the control."
Attribute Text.VB_UserMemId = -517
Attribute Text.VB_MemberFlags = "200"
    Text = Text1.Text
End Property

Public Property Let Text(ByVal New_Text As String)
    Text1.Text() = New_Text
    PropertyChanged "Text"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,SelText
Public Property Get SelText() As String
Attribute SelText.VB_Description = "Returns/sets the string containing the currently selected text."
    If Ambient.UserMode = False Then Err.Raise 387
    SelText = Text1.SelText
End Property

Public Property Let SelText(ByVal New_SelText As String)
    Text1.SelText() = New_SelText
    PropertyChanged "SelText"
    CheckSelChange
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,SelStart
Public Property Get SelStart() As Long
Attribute SelStart.VB_Description = "Returns/sets the starting point of text selected."
    If Ambient.UserMode = False Then Err.Raise 387
    SelStart = Text1.SelStart
End Property

Public Property Let SelStart(ByVal New_SelStart As Long)
    Text1.SelStart() = New_SelStart
    PropertyChanged "SelStart"
    CheckSelChange
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Text1,Text1,-1,SelLength
Public Property Get SelLength() As Long
Attribute SelLength.VB_Description = "Returns/sets the number of characters selected."
    If Ambient.UserMode = False Then Err.Raise 387
    SelLength = Text1.SelLength
End Property

Public Property Let SelLength(ByVal New_SelLength As Long)
    Text1.SelLength() = New_SelLength
    PropertyChanged "SelLength"
    CheckSelChange
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,0
Public Property Get FormatMask() As String
Attribute FormatMask.VB_Description = "Affects how the formatted contents of the control is returned in the FormattedText property (same syntax as VB's Format function)"
    FormatMask = m_FormatMask
End Property

Public Property Let FormatMask(ByVal New_FormatMask As String)
    m_FormatMask = New_FormatMask
    PropertyChanged "FormatMask"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,1,2,0
Public Property Get FormattedText() As String
Attribute FormattedText.VB_Description = "The formatted contents of the control"
Attribute FormattedText.VB_MemberFlags = "404"
    FormattedText = Format(Text, FormatMask)
End Property

Public Property Let FormattedText(ByVal New_FormattedText As String)
    If Ambient.UserMode Then Err.Raise 382
    m_FormattedText = New_FormattedText
    PropertyChanged "FormattedText"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Label1,Label1,-1,Font
Public Property Get CaptionFont() As Font
Attribute CaptionFont.VB_Description = "Returns a Font object."
    Set CaptionFont = Label1.Font
End Property

Public Property Set CaptionFont(ByVal New_CaptionFont As Font)
    Set Label1.Font = New_CaptionFont
    PropertyChanged "CaptionFont"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=5
Public Sub Copy()
Attribute Copy.VB_Description = "Copies the contents of the control to the Clipboard."
    Clipboard.Clear
    Clipboard.SetText IIf(SelText <> "", SelText, Text)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=5
Public Sub Clear()
Attribute Clear.VB_Description = "Clear the contents of the control."
    If SelText <> "" Then SelText = "" Else Text = ""
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=5
Public Sub Cut()
Attribute Cut.VB_Description = "Cuts the contents of the control to the Clpboard."
    Clipboard.Clear
    If SelText <> "" Then
        Clipboard.SetText SelText
        SelText = ""
    Else
        Clipboard.SetText Text
        Text = ""
    End If
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=5
Public Sub Paste()
Attribute Paste.VB_Description = "Pastes the current contents of the Clipboard into the control."
    SelText = Clipboard.GetText
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Label1,Label1,-1,ForeColor
Public Property Get CaptionForeColor() As OLE_COLOR
Attribute CaptionForeColor.VB_Description = "Returns/sets the foreground color used to display text and graphics in an object."
    CaptionForeColor = Label1.ForeColor
End Property

Public Property Let CaptionForeColor(ByVal New_CaptionForeColor As OLE_COLOR)
    Label1.ForeColor() = New_CaptionForeColor
    PropertyChanged "CaptionForeColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Label1,Label1,-1,BackColor
Public Property Get CaptionBackColor() As OLE_COLOR
Attribute CaptionBackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    CaptionBackColor = Label1.BackColor
End Property

Public Property Let CaptionBackColor(ByVal New_CaptionBackColor As OLE_COLOR)
    Label1.BackColor() = New_CaptionBackColor
    PropertyChanged "CaptionBackColor"
End Property

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    On Error Resume Next
    m_FormatMask = m_def_FormatMask
    m_FormattedText = m_def_FormattedText
    
    Caption = Ambient.DisplayName
    Set CaptionFont = Ambient.Font
    Set Font = Ambient.Font
    CaptionForeColor = Ambient.ForeColor
    CaptionBackColor = Ambient.BackColor
End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    Text1.BackColor = PropBag.ReadProperty("BackColor", &H80000005)
    Text1.ForeColor = PropBag.ReadProperty("ForeColor", &H80000008)
    Text1.Enabled = PropBag.ReadProperty("Enabled", True)
    Set Text1.Font = PropBag.ReadProperty("Font", Ambient.Font)
    Text1.BorderStyle = PropBag.ReadProperty("BorderStyle", 1)
    Text1.Alignment = PropBag.ReadProperty("Alignment", 0)
    Label1.Caption = PropBag.ReadProperty("Caption", "Label1")
    Text1.Locked = PropBag.ReadProperty("Locked", False)
    Text1.MaxLength = PropBag.ReadProperty("MaxLength", 0)
    Set MouseIcon = PropBag.ReadProperty("MouseIcon", Nothing)
    Text1.MousePointer = PropBag.ReadProperty("MousePointer", 0)
    Text1.PasswordChar = PropBag.ReadProperty("PasswordChar", "")
    Text1.Text = PropBag.ReadProperty("Text", "Text1")
    ' The following statements have been remmed out because they are useless.
    'Text1.SelText = PropBag.ReadProperty("SelText", "")
    'Text1.SelStart = PropBag.ReadProperty("SelStart", 0)
    'Text1.SelLength = PropBag.ReadProperty("SelLength", 0)
    m_FormatMask = PropBag.ReadProperty("FormatMask", m_def_FormatMask)
    'm_FormattedText = PropBag.ReadProperty("FormattedText", m_def_FormattedText)
    Set Label1.Font = PropBag.ReadProperty("CaptionFont", Ambient.Font)
    Label1.ForeColor = PropBag.ReadProperty("CaptionForeColor", &H80000012)
    Label1.BackColor = PropBag.ReadProperty("CaptionBackColor", &H8000000F)
    
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    Call PropBag.WriteProperty("BackColor", Text1.BackColor, &H80000005)
    Call PropBag.WriteProperty("ForeColor", Text1.ForeColor, &H80000008)
    Call PropBag.WriteProperty("Enabled", Text1.Enabled, True)
    Call PropBag.WriteProperty("Font", Text1.Font, Ambient.Font)
    Call PropBag.WriteProperty("BorderStyle", Text1.BorderStyle, 1)
    Call PropBag.WriteProperty("Alignment", Text1.Alignment, 0)
    Call PropBag.WriteProperty("Caption", Label1.Caption, "Label1")
    Call PropBag.WriteProperty("Locked", Text1.Locked, False)
    Call PropBag.WriteProperty("MaxLength", Text1.MaxLength, 0)
    Call PropBag.WriteProperty("MouseIcon", MouseIcon, Nothing)
    Call PropBag.WriteProperty("MousePointer", Text1.MousePointer, 0)
    Call PropBag.WriteProperty("PasswordChar", Text1.PasswordChar, "")
    Call PropBag.WriteProperty("Text", Text1.Text, "Text1")
    ' The following statements have been remmed out because they are useless.
    'Call PropBag.WriteProperty("SelText", Text1.SelText, "")
    'Call PropBag.WriteProperty("SelStart", Text1.SelStart, 0)
    'Call PropBag.WriteProperty("SelLength", Text1.SelLength, 0)
    Call PropBag.WriteProperty("FormatMask", m_FormatMask, m_def_FormatMask)
    'Call PropBag.WriteProperty("FormattedText", m_FormattedText, m_def_FormattedText)
    Call PropBag.WriteProperty("CaptionFont", Label1.Font, Ambient.Font)
    Call PropBag.WriteProperty("CaptionForeColor", Label1.ForeColor, &H80000012)
    Call PropBag.WriteProperty("CaptionBackColor", Label1.BackColor, &H8000000F)
End Sub

' Raise the SelChange event if the caret actually moved.
Private Sub CheckSelChange()
    If Ambient.UserMode Then
        If SelStart <> saveSelStart Or SelLength <> saveSelLength Then
            RaiseEvent SelChange
            saveSelStart = SelStart
            saveSelLength = SelLength
        End If
    End If
End Sub

Private Sub UserControl_Resize()
    On Error Resume Next
    If Caption <> "" Then
        Label1.Move 0, 0, ScaleWidth, Label1.Height
        Text1.Move 0, Label1.Height, ScaleWidth, _
            ScaleHeight - Label1.Height
    Else
        Text1.Move 0, 0, ScaleWidth, ScaleHeight
    End If
End Sub

' This is the default property.

Public Property Get Text_() As String
Attribute Text_.VB_UserMemId = 0
Attribute Text_.VB_MemberFlags = "40"
    Text_ = Text
End Property

Public Property Let Text_(ByVal newValue As String)
    Text = newValue
End Property

' The AboutBox method

Sub AboutBox()
Attribute AboutBox.VB_UserMemId = -552
Attribute AboutBox.VB_MemberFlags = "40"
    MsgBox "The SuperTextBox control" & vbCr & "(C) 1999 Francesco Balena", vbInformation
End Sub




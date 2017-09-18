VERSION 5.00
Begin VB.UserControl ScrollPictureBox 
   ClientHeight    =   2880
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3840
   EditAtDesignTime=   -1  'True
   ScaleHeight     =   192
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   256
   Begin VB.HScrollBar HScroll1 
      Height          =   204
      LargeChange     =   20
      Left            =   96
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   2496
      Width           =   3372
   End
   Begin VB.VScrollBar VScroll1 
      Height          =   2316
      LargeChange     =   20
      Left            =   3552
      TabIndex        =   1
      TabStop         =   0   'False
      Top             =   96
      Width           =   204
   End
   Begin VB.PictureBox Picture1 
      Height          =   2316
      Left            =   0
      ScaleHeight     =   150
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   221
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   0
      Width           =   3372
      Begin VB.Image Image1 
         Height          =   876
         Left            =   0
         Top             =   0
         Width           =   1452
      End
   End
End
Attribute VB_Name = "ScrollPictureBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

'##project:DisableMessage 0354
'##project:DisableMessage 0501
'##project:UseByVal Yes


'Event Declarations:
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=Picture1,Picture1,-1,KeyDown
Attribute KeyDown.VB_Description = "Occurs when the user presses a key while an object has the focus."
Event KeyPress(KeyAscii As Integer) 'MappingInfo=Picture1,Picture1,-1,KeyPress
Attribute KeyPress.VB_Description = "Occurs when the user presses and releases an ANSI key."
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=Picture1,Picture1,-1,KeyUp
Attribute KeyUp.VB_Description = "Occurs when the user releases a key while an object has the focus."
Event Click() 'MappingInfo=Image1,Image1,-1,Click
Event DblClick() 'MappingInfo=Image1,Image1,-1,DblClick
Event MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=Image1,Image1,-1,MouseDown
Event MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=Image1,Image1,-1,MouseMove
Event MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=Image1,Image1,-1,MouseUp
'Default Property Values:
Const m_def_PicturePath = ""
'Property Variables:
Dim m_PicturePath As String

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Picture1,Picture1,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
    Enabled = Picture1.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    Picture1.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Picture1,Picture1,-1,BorderStyle
Public Property Get BorderStyle() As Integer
Attribute BorderStyle.VB_Description = "Returns/sets the border style for an object."
    BorderStyle = Picture1.BorderStyle
End Property

Public Property Let BorderStyle(ByVal New_BorderStyle As Integer)
    Picture1.BorderStyle() = New_BorderStyle
    PropertyChanged "BorderStyle"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Picture1,Picture1,-1,Refresh
Public Sub Refresh()
Attribute Refresh.VB_Description = "Forces a complete repaint of a object."
    Picture1.Refresh
End Sub

Private Sub Image1_Click()
    RaiseEvent Click
End Sub

Private Sub Image1_DblClick()
    RaiseEvent DblClick
End Sub
'
Private Sub Image1_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseDown(Button, Shift, x, y)
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseMove(Button, Shift, x, y)
End Sub

Private Sub Image1_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseUp(Button, Shift, x, y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Image1,Image1,-1,Picture
Public Property Get Picture() As Picture
Attribute Picture.VB_Description = "Returns/sets a graphic to be displayed in a control."
    Set Picture = Image1.Picture
End Property

Public Property Set Picture(ByVal New_Picture As Picture)
    Set Image1.Picture = New_Picture
    Image1.Move 0, 0
    UserControl_Resize
    Scroll 0, 0
    PropertyChanged "Picture"
End Property

Private Sub UserControl_AsyncReadComplete(AsyncProp As AsyncProperty)
    If AsyncProp.PropertyName = "Picture" Then
        Set Picture = AsyncProp.Value
    End If
End Sub

Private Sub UserControl_AsyncReadProgress(AsyncProp As AsyncProperty)
    If AsyncProp.PropertyName = "Picture" Then
        Dim percent As Integer
        'percent = (AsyncProp.BytesRead * 100&) \ AsyncProp.BytesMax
        Beep
    End If
End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    Picture1.Enabled = PropBag.ReadProperty("Enabled", True)
    Picture1.BorderStyle = PropBag.ReadProperty("BorderStyle", 1)
    Set Picture = PropBag.ReadProperty("Picture", Nothing)
    PicturePath = PropBag.ReadProperty("PicturePath", m_def_PicturePath)
End Sub

Private Sub UserControl_Resize()
    
    Picture1.Move 0, 0, ScaleWidth - VScroll1.Width, ScaleHeight - HScroll1.Height
    VScroll1.Move ScaleWidth - VScroll1.Width, 0, VScroll1.Width, Picture1.Height
    HScroll1.Move 0, ScaleHeight - HScroll1.Height, Picture1.Width, HScroll1.Height

    If Image1.Width < Picture1.Width Then
        HScroll1.Enabled = False
    Else
        HScroll1.Enabled = True
        HScroll1.Max = Image1.Width - Picture1.Width
    End If

    If Image1.Height < Picture1.Height Then
        VScroll1.Enabled = False
    Else
        VScroll1.Enabled = True
        VScroll1.Max = Image1.Height - Picture1.Height
    End If

End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("Enabled", Picture1.Enabled, True)
    Call PropBag.WriteProperty("BorderStyle", Picture1.BorderStyle, 1)
    Call PropBag.WriteProperty("Picture", Picture, Nothing)
    Call PropBag.WriteProperty("PicturePath", m_PicturePath, m_def_PicturePath)
End Sub

Public Sub Scroll(Optional x As Variant, Optional y As Variant)

    If Not IsMissing(x) Then
        Image1.Left = -x
        HScroll1.Value = x
    End If
    
    If Not IsMissing(y) Then
        Image1.Top = -y
        VScroll1.Value = y
    End If
    
End Sub

Private Sub hScroll1_Change()
    Scroll HScroll1.Value
End Sub

Private Sub hScroll1_Scroll()
    Scroll HScroll1.Value
End Sub

Private Sub VScroll1_Change()
    Scroll , VScroll1.Value
End Sub

Private Sub VScroll1_Scroll()
    Scroll , VScroll1.Value
End Sub
Private Sub Picture1_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub Picture1_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub Picture1_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,
Public Property Get PicturePath() As String
Attribute PicturePath.VB_Description = "The URL of a picture"
    PicturePath = m_PicturePath
End Property

Public Property Let PicturePath(ByVal New_PicturePath As String)
    m_PicturePath = New_PicturePath
    PropertyChanged "PicturePath"
    If Len(m_PicturePath) Then
        AsyncRead m_PicturePath, vbAsyncTypePicture, "Picture"
    End If
End Property


'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    m_PicturePath = m_def_PicturePath
End Sub



VERSION 5.00
Begin VB.UserControl AddressOCX 
   ClientHeight    =   1875
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5775
   ScaleHeight     =   1875
   ScaleWidth      =   5775
   Begin VB.TextBox txtName 
      Height          =   300
      Left            =   0
      TabIndex        =   4
      Top             =   240
      Width           =   5655
   End
   Begin VB.TextBox txtStreet 
      Height          =   300
      Left            =   0
      TabIndex        =   3
      Top             =   840
      Width           =   5655
   End
   Begin VB.TextBox txtCity 
      Height          =   300
      Left            =   0
      TabIndex        =   2
      Top             =   1440
      Width           =   2535
   End
   Begin VB.TextBox txtZip 
      Height          =   300
      Left            =   2640
      TabIndex        =   1
      Top             =   1440
      Width           =   1575
   End
   Begin VB.TextBox txtState 
      Height          =   300
      Left            =   4320
      TabIndex        =   0
      Top             =   1440
      Width           =   1335
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "&Name"
      Height          =   255
      Left            =   0
      TabIndex        =   9
      Top             =   0
      Width           =   3255
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "&Street"
      Height          =   255
      Left            =   0
      TabIndex        =   8
      Top             =   600
      Width           =   3375
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "&City"
      Height          =   255
      Left            =   0
      TabIndex        =   7
      Top             =   1200
      Width           =   2415
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "&Zip"
      Height          =   255
      Left            =   2640
      TabIndex        =   6
      Top             =   1200
      Width           =   1575
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "S&tate"
      Height          =   255
      Left            =   4320
      TabIndex        =   5
      Top             =   1200
      Width           =   1095
   End
End
Attribute VB_Name = "AddressOCX"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit
'Event Declarations:
Event Click() 'MappingInfo=UserControl,UserControl,-1,Click
Attribute Click.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event DblClick() 'MappingInfo=UserControl,UserControl,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyDown
Attribute KeyDown.VB_Description = "Occurs when the user presses a key while an object has the focus."
Event KeyPress(KeyAscii As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyPress
Attribute KeyPress.VB_Description = "Occurs when the user presses and releases an ANSI key."
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyUp
Attribute KeyUp.VB_Description = "Occurs when the user releases a key while an object has the focus."
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."


'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,BackColor
Public Property Get BackColor() As OLE_COLOR
Attribute BackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    BackColor = UserControl.BackColor
End Property

Public Property Let BackColor(ByVal New_BackColor As OLE_COLOR)
    UserControl.BackColor() = New_BackColor
    PropertyChanged "BackColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,ForeColor
Public Property Get ForeColor() As OLE_COLOR
Attribute ForeColor.VB_Description = "Returns/sets the foreground color used to display text and graphics in an object."
    ForeColor = UserControl.ForeColor
End Property

Public Property Let ForeColor(ByVal New_ForeColor As OLE_COLOR)
    UserControl.ForeColor() = New_ForeColor
    PropertyChanged "ForeColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
    Enabled = UserControl.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    UserControl.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,Font
Public Property Get Font() As Font
Attribute Font.VB_Description = "Returns a Font object."
Attribute Font.VB_UserMemId = -512
    Set Font = UserControl.Font
End Property

Public Property Set Font(ByVal New_Font As Font)
    Set UserControl.Font = New_Font
    PropertyChanged "Font"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,BorderStyle
Public Property Get BorderStyle() As Integer
Attribute BorderStyle.VB_Description = "Returns/sets the border style for an object."
    BorderStyle = UserControl.BorderStyle
End Property

Public Property Let BorderStyle(ByVal New_BorderStyle As Integer)
    UserControl.BorderStyle() = New_BorderStyle
    PropertyChanged "BorderStyle"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=UserControl,UserControl,-1,Refresh
Public Sub Refresh()
Attribute Refresh.VB_Description = "Forces a complete repaint of a object."
    UserControl.Refresh
End Sub

Private Sub txtCity_Change()
    PropertyChanged "City"
End Sub

Private Sub txtName_Change()
    PropertyChanged "Name"
End Sub

Private Sub txtState_Change()
    PropertyChanged "State"
End Sub

Private Sub txtStreet_Change()
    PropertyChanged "Street"
End Sub

Private Sub txtZip_Change()
    PropertyChanged "Zip"
End Sub

Private Sub UserControl_Click()
    RaiseEvent Click
End Sub

Private Sub UserControl_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub UserControl_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub UserControl_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub UserControl_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
End Sub

Private Sub UserControl_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, X, Y)
End Sub

Private Sub UserControl_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseMove(Button, Shift, X, Y)
End Sub

Private Sub UserControl_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, X, Y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtName,txtName,-1,Text
Public Property Get CompleteName() As String
Attribute CompleteName.VB_Description = "Returns/sets the text contained in the control."
Attribute CompleteName.VB_MemberFlags = "34"
    CompleteName = txtName.Text
End Property

Public Property Let CompleteName(ByVal New_CompleteName As String)
    txtName.Text() = New_CompleteName
    PropertyChanged "CompleteName"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtStreet,txtStreet,-1,Text
Public Property Get Street() As String
Attribute Street.VB_Description = "Returns/sets the text contained in the control."
Attribute Street.VB_MemberFlags = "14"
    Street = txtStreet.Text
End Property

Public Property Let Street(ByVal New_Street As String)
    txtStreet.Text() = New_Street
    PropertyChanged "Street"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtCity,txtCity,-1,Text
Public Property Get City() As String
Attribute City.VB_Description = "Returns/sets the text contained in the control."
Attribute City.VB_MemberFlags = "14"
    City = txtCity.Text
End Property

Public Property Let City(ByVal New_City As String)
    txtCity.Text() = New_City
    PropertyChanged "City"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtZip,txtZip,-1,Text
Public Property Get Zip() As String
Attribute Zip.VB_Description = "Returns/sets the text contained in the control."
Attribute Zip.VB_MemberFlags = "14"
    Zip = txtZip.Text
End Property

Public Property Let Zip(ByVal New_Zip As String)
    txtZip.Text() = New_Zip
    PropertyChanged "Zip"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtState,txtState,-1,Text
Public Property Get State() As String
Attribute State.VB_Description = "Returns/sets the text contained in the control."
Attribute State.VB_MemberFlags = "14"
    State = txtState.Text
End Property

Public Property Let State(ByVal New_State As String)
    txtState.Text() = New_State
    PropertyChanged "State"
End Property

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    Set UserControl.Font = Ambient.Font
End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)

    UserControl.BackColor = PropBag.ReadProperty("BackColor", &H8000000F)
    UserControl.ForeColor = PropBag.ReadProperty("ForeColor", &H80000012)
    UserControl.Enabled = PropBag.ReadProperty("Enabled", True)
    Set UserControl.Font = PropBag.ReadProperty("Font", Ambient.Font)
    UserControl.BorderStyle = PropBag.ReadProperty("BorderStyle", 0)
    txtName.Text = PropBag.ReadProperty("CompleteName", "")
    txtStreet.Text = PropBag.ReadProperty("Street", "")
    txtCity.Text = PropBag.ReadProperty("City", "")
    txtZip.Text = PropBag.ReadProperty("Zip", "")
    txtState.Text = PropBag.ReadProperty("State", "")
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("BackColor", UserControl.BackColor, &H8000000F)
    Call PropBag.WriteProperty("ForeColor", UserControl.ForeColor, &H80000012)
    Call PropBag.WriteProperty("Enabled", UserControl.Enabled, True)
    Call PropBag.WriteProperty("Font", UserControl.Font, Ambient.Font)
    Call PropBag.WriteProperty("BorderStyle", UserControl.BorderStyle, 0)
    Call PropBag.WriteProperty("CompleteName", txtName.Text, "")
    Call PropBag.WriteProperty("Street", txtStreet.Text, "")
    Call PropBag.WriteProperty("City", txtCity.Text, "")
    Call PropBag.WriteProperty("Zip", txtZip.Text, "")
    Call PropBag.WriteProperty("State", txtState.Text, "")
End Sub


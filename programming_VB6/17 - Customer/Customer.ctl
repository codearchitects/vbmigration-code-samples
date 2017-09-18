VERSION 5.00
Begin VB.UserControl Customer 
   ClientHeight    =   3075
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6270
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   KeyPreview      =   -1  'True
   PropertyPages   =   "Customer.ctx":0000
   ScaleHeight     =   3075
   ScaleWidth      =   6270
   Begin VB.TextBox txtFax 
      Height          =   375
      Left            =   3120
      TabIndex        =   13
      Top             =   2520
      Width           =   2895
   End
   Begin VB.TextBox txtPhone 
      Height          =   375
      Left            =   120
      TabIndex        =   11
      Top             =   2520
      Width           =   2895
   End
   Begin VB.TextBox txtCountry 
      Height          =   375
      Left            =   3960
      TabIndex        =   9
      Top             =   1800
      Width           =   2055
   End
   Begin VB.TextBox txtZipCode 
      Height          =   375
      Left            =   2640
      TabIndex        =   7
      Top             =   1800
      Width           =   1215
   End
   Begin VB.TextBox txtCity 
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   1800
      Width           =   2415
   End
   Begin VB.TextBox txtAddress 
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   1080
      Width           =   5895
   End
   Begin VB.TextBox txtCustomerName 
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   5895
   End
   Begin VB.Label Label7 
      Caption         =   "&Fax"
      Height          =   285
      Left            =   3120
      TabIndex        =   12
      Top             =   2280
      Width           =   2685
   End
   Begin VB.Label Label6 
      Caption         =   "&Phone"
      Height          =   285
      Left            =   120
      TabIndex        =   10
      Top             =   2280
      Width           =   2685
   End
   Begin VB.Label Label5 
      Caption         =   "C&ountry"
      Height          =   285
      Left            =   3960
      TabIndex        =   8
      Top             =   1560
      Width           =   2685
   End
   Begin VB.Label Label4 
      Caption         =   "&Zip code"
      Height          =   285
      Left            =   2640
      TabIndex        =   6
      Top             =   1560
      Width           =   2685
   End
   Begin VB.Label Label3 
      Caption         =   "&City"
      Height          =   285
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   2325
   End
   Begin VB.Label Label2 
      Caption         =   "&Address"
      Height          =   285
      Left            =   120
      TabIndex        =   2
      Top             =   840
      Width           =   2685
   End
   Begin VB.Label Label1 
      Caption         =   "Customer &Name"
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2685
   End
End
Attribute VB_Name = "Customer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Ext_KEY = "PropPageWizardRun" ,"Yes"
Option Explicit

'##project:DisableMessage 0354
'##project:DisableMessage 0501

'Event Declarations:
Event Change(PropertyName As String)
Event KeyDown(KeyCode As Integer, Shift As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyDown
Event KeyPress(KeyAscii As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyPress
Event KeyUp(KeyCode As Integer, Shift As Integer) 'MappingInfo=UserControl,UserControl,-1,KeyUp
Event Click() 'MappingInfo=UserControl,UserControl,-1,Click
Attribute Click.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event DblClick() 'MappingInfo=UserControl,UserControl,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
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
Attribute Enabled.VB_ProcData.VB_Invoke_Property = "General"
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
'MappingInfo=UserControl,UserControl,-1,BackStyle
Public Property Get BackStyle() As Integer
Attribute BackStyle.VB_Description = "Indicates whether a Label or the background of a Shape is transparent or opaque."
    BackStyle = UserControl.BackStyle
End Property

Public Property Let BackStyle(ByVal New_BackStyle As Integer)
    UserControl.BackStyle() = New_BackStyle
    PropertyChanged "BackStyle"
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

Private Sub txtAddress_Change()
    RaiseEvent Change("Address")
    PropertyChanged "Address"
End Sub

Private Sub txtCity_Change()
    RaiseEvent Change("City")
    PropertyChanged "City"
End Sub

Private Sub txtCountry_Change()
    RaiseEvent Change("Country")
    PropertyChanged "Country"
End Sub

Private Sub txtCustomerName_Change()
    RaiseEvent Change("CustomerName")
    PropertyChanged "CustomerName"
End Sub

Private Sub txtFax_Change()
    RaiseEvent Change("Fax")
    PropertyChanged "Fax"
End Sub

Private Sub txtPhone_Change()
    RaiseEvent Change("Phone")
    PropertyChanged "Phone"
End Sub

Private Sub txtZipCode_Change()
    RaiseEvent Change("ZipCode")
    PropertyChanged "ZipCode"
End Sub

Private Sub UserControl_Click()
    RaiseEvent Click
End Sub

Private Sub UserControl_DblClick()
    RaiseEvent DblClick
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
'MappingInfo=txtCustomerName,txtCustomerName,-1,Text
Public Property Get CustomerName() As String
Attribute CustomerName.VB_Description = "The name of the customer."
Attribute CustomerName.VB_ProcData.VB_Invoke_Property = "General"
Attribute CustomerName.VB_MemberFlags = "34"
    CustomerName = txtCustomerName.Text
End Property

Public Property Let CustomerName(ByVal New_CustomerName As String)
    txtCustomerName.Text() = New_CustomerName
    PropertyChanged "CustomerName"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtAddress,txtAddress,-1,Text
Public Property Get Address() As String
Attribute Address.VB_Description = "The Address of the customer."
Attribute Address.VB_MemberFlags = "14"
    Address = txtAddress.Text
End Property

Public Property Let Address(ByVal New_Address As String)
    txtAddress.Text() = New_Address
    PropertyChanged "Address"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtCity,txtCity,-1,Text
Public Property Get City() As String
Attribute City.VB_Description = "The City of the customer."
Attribute City.VB_MemberFlags = "14"
    City = txtCity.Text
End Property

Public Property Let City(ByVal New_City As String)
    txtCity.Text() = New_City
    PropertyChanged "City"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtZipCode,txtZipCode,-1,Text
Public Property Get ZipCode() As String
Attribute ZipCode.VB_Description = "The ZipCode of the customer."
Attribute ZipCode.VB_MemberFlags = "14"
    ZipCode = txtZipCode.Text
End Property

Public Property Let ZipCode(ByVal New_ZipCode As String)
    txtZipCode.Text() = New_ZipCode
    PropertyChanged "ZipCode"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtCountry,txtCountry,-1,Text
Public Property Get Country() As String
Attribute Country.VB_Description = "The country of the customer."
Attribute Country.VB_MemberFlags = "14"
    Country = txtCountry.Text
End Property

Public Property Let Country(ByVal New_Country As String)
    txtCountry.Text() = New_Country
    PropertyChanged "Country"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtPhone,txtPhone,-1,Text
Public Property Get Phone() As String
Attribute Phone.VB_Description = "The Phone number of the customer."
Attribute Phone.VB_MemberFlags = "14"
    Phone = txtPhone.Text
End Property

Public Property Let Phone(ByVal New_Phone As String)
    txtPhone.Text() = New_Phone
    PropertyChanged "Phone"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=txtFax,txtFax,-1,Text
Public Property Get Fax() As String
Attribute Fax.VB_Description = "The Fax number of the customer."
Attribute Fax.VB_MemberFlags = "14"
    Fax = txtFax.Text
End Property

Public Property Let Fax(ByVal New_Fax As String)
    txtFax.Text() = New_Fax
    PropertyChanged "Fax"
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
    UserControl.BackStyle = PropBag.ReadProperty("BackStyle", 1)
    UserControl.BorderStyle = PropBag.ReadProperty("BorderStyle", 0)
    txtCustomerName.Text = PropBag.ReadProperty("CustomerName", "")
    txtAddress.Text = PropBag.ReadProperty("Address", "")
    txtCity.Text = PropBag.ReadProperty("City", "")
    txtZipCode.Text = PropBag.ReadProperty("ZipCode", "")
    txtCountry.Text = PropBag.ReadProperty("Country", "")
    txtPhone.Text = PropBag.ReadProperty("Phone", "")
    txtFax.Text = PropBag.ReadProperty("Fax", "")
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("BackColor", UserControl.BackColor, &H8000000F)
    Call PropBag.WriteProperty("ForeColor", UserControl.ForeColor, &H80000012)
    Call PropBag.WriteProperty("Enabled", UserControl.Enabled, True)
    Call PropBag.WriteProperty("Font", UserControl.Font, Ambient.Font)
    Call PropBag.WriteProperty("BackStyle", UserControl.BackStyle, 1)
    Call PropBag.WriteProperty("BorderStyle", UserControl.BorderStyle, 0)
    Call PropBag.WriteProperty("CustomerName", txtCustomerName.Text, "")
    Call PropBag.WriteProperty("Address", txtAddress.Text, "")
    Call PropBag.WriteProperty("City", txtCity.Text, "")
    Call PropBag.WriteProperty("ZipCode", txtZipCode.Text, "")
    Call PropBag.WriteProperty("Country", txtCountry.Text, "")
    Call PropBag.WriteProperty("Phone", txtPhone.Text, "")
    Call PropBag.WriteProperty("Fax", txtFax.Text, "")
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




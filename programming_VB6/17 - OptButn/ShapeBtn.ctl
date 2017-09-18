VERSION 5.00
Begin VB.UserControl ShapeBtn 
   BackStyle       =   0  'Transparent
   ClientHeight    =   1890
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3825
   ScaleHeight     =   126
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   255
   Begin VB.Timer Timer1 
      Left            =   2880
      Top             =   240
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00808080&
      FillStyle       =   0  'Solid
      Height          =   975
      Left            =   600
      Shape           =   2  'Oval
      Top             =   480
      Width           =   2055
   End
End
Attribute VB_Name = "ShapeBtn"
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
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."

'Default Property Values:
Const m_def_Value = 0
Const m_def_FalseColor = vbBlack
Const m_def_TrueColor = vbWhite
'Property Variables:
Dim m_Value As Boolean
Dim m_FalseColor As OLE_COLOR
Dim m_TrueColor As OLE_COLOR

Private Sub UserControl_Resize()
    Shape1.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

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
'MappingInfo=UserControl,UserControl,-1,Refresh
Public Sub Refresh()
Attribute Refresh.VB_Description = "Forces a complete repaint of a object."
    UserControl.Refresh
    Shape1.BackColor = IIf(m_Value, TrueColor, FalseColor)
    Shape1.FillColor = Shape1.BackColor
End Sub

Private Sub UserControl_Click()
    Value = True
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

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    Set UserControl.Font = Ambient.Font
    m_FalseColor = m_def_FalseColor
    m_TrueColor = m_def_TrueColor
    m_Value = m_def_Value
    Refresh
End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    UserControl.Enabled = PropBag.ReadProperty("Enabled", True)
    Set UserControl.Font = PropBag.ReadProperty("Font", Ambient.Font)
    
    m_FalseColor = PropBag.ReadProperty("FalseColor", m_def_FalseColor)
    m_TrueColor = PropBag.ReadProperty("TrueColor", m_def_TrueColor)
    m_Value = PropBag.ReadProperty("Value", m_def_Value)
    Refresh
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("Enabled", UserControl.Enabled, True)
    Call PropBag.WriteProperty("Font", UserControl.Font, Ambient.Font)
    Call PropBag.WriteProperty("Value", m_Value, m_def_Value)
    Call PropBag.WriteProperty("FalseColor", m_FalseColor, m_def_FalseColor)
    Call PropBag.WriteProperty("TrueColor", m_TrueColor, m_def_TrueColor)
End Sub
'
'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=14,0,0,0
Public Property Get Value() As OLE_OPTEXCLUSIVE
Attribute Value.VB_Description = "True if the control is selected,False otherwise"
Attribute Value.VB_UserMemId = 0
    Value = m_Value
End Property

Public Property Let Value(ByVal New_Value As OLE_OPTEXCLUSIVE)
    m_Value = New_Value
    Refresh
    PropertyChanged "Value"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=10,0,0,0
Public Property Get FalseColor() As OLE_COLOR
Attribute FalseColor.VB_Description = "The color to display when the control isn't selected."
    FalseColor = m_FalseColor
End Property

Public Property Let FalseColor(ByVal New_FalseColor As OLE_COLOR)
    m_FalseColor = New_FalseColor
    Refresh
    PropertyChanged "FalseColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=10,0,0,&HFFFFFF
Public Property Get TrueColor() As OLE_COLOR
Attribute TrueColor.VB_Description = "The color to display when the button is selected."
    TrueColor = m_TrueColor
End Property

Public Property Let TrueColor(ByVal New_TrueColor As OLE_COLOR)
    m_TrueColor = New_TrueColor
    Refresh
    PropertyChanged "TrueColor"
End Property

Private Sub UserControl_Paint()
    ' VB will refresh the Shape control, but we need to
    ' draw the lines manually, AFTER the Paint event
    Timer1.Interval = 1
    Timer1.Enabled = True
End Sub

Private Sub Timer1_Timer()
    ' Fire just once.
    Timer1.Enabled = False
    ' Draw some lines, just to show that it's possible
    ' Note that ScaleMode = 3-Pixels
    Dim i As Long
    For i = 0 To ScaleWidth Step 4
        Line (i, 0)-(i, ScaleHeight)
    Next
End Sub



VERSION 5.00
Begin VB.UserControl SuperTimer 
   ClientHeight    =   825
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   1230
   InvisibleAtRuntime=   -1  'True
   ScaleHeight     =   825
   ScaleWidth      =   1230
   Begin VB.Timer Timer1 
      Left            =   720
      Top             =   240
   End
   Begin VB.Image Image1 
      Height          =   480
      Left            =   120
      Picture         =   "SuperTim.ctx":0000
      Stretch         =   -1  'True
      Top             =   120
      Width           =   480
   End
End
Attribute VB_Name = "SuperTimer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

'##project:DefaultMemberSupport False

'Event Declarations:
Event Timer() 'MappingInfo=Timer1,Timer1,-1,Timer
Attribute Timer.VB_Description = "Occurs when a preset interval for a Timer control has elapsed."

' We don't delegate directly to the Enabled property of the Timer
Private m_Enabled As Boolean

' member variable for Owner property
Private m_Owner As ISuperTimerCBK

' The Owner property

Public Property Get Owner() As ISuperTimerCBK
    Set Owner = m_Owner
End Property

Public Property Set Owner(ByVal newValue As ISuperTimerCBK)
    Set m_Owner = newValue
End Property

Private Sub Timer1_Timer()
    If m_Owner Is Nothing Then
        ' Fire a regular event
        RaiseEvent Timer
    Else
        ' Fire a callback method
        m_Owner.Timer
    End If
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Timer1,Timer1,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
    Enabled = m_Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    m_Enabled = New_Enabled
    ' Activate the timer only at runtime
    If Ambient.UserMode Then Timer1.Enabled = m_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=Timer1,Timer1,-1,Interval
Public Property Get Interval() As Long
Attribute Interval.VB_Description = "Returns/sets the number of milliseconds between calls to a Timer control's Timer event."
    Interval = Timer1.Interval
End Property

Public Property Let Interval(ByVal New_Interval As Long)
    Timer1.Interval() = New_Interval
    PropertyChanged "Interval"
End Property

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    Enabled = PropBag.ReadProperty("Enabled", True)
    Interval = PropBag.ReadProperty("Interval", 0)
End Sub

Private Sub UserControl_Resize()
    Static active As Boolean
    If active Then Exit Sub
    
    active = True
    Image1.Move 0, 0, 420, 420
    Size 420, 420
    active = False
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    Call PropBag.WriteProperty("Enabled", Timer1.Enabled, True)
    Call PropBag.WriteProperty("Interval", Timer1.Interval, 0)
End Sub





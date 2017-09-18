VERSION 5.00
Begin VB.UserControl Stretcher 
   ClientHeight    =   1350
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   2865
   ControlContainer=   -1  'True
   ScaleHeight     =   1350
   ScaleWidth      =   2865
End
Attribute VB_Name = "Stretcher"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Private Type ControlInfo
    ctrl As Control
    InnerControl As Boolean     ' True if contained into a contained control.
    Left As Single
    Top As Single
    Width As Single
    Height As Single
End Type
'##ctrlInfo.ArrayBounds ForceZero
Dim ctrlInfo() As ControlInfo

' This variable serves to trap form's Resize events.
'##ParentForm.SetType VB6Form
Private WithEvents ParentForm As Form
Attribute ParentForm.VB_VarHelpID = -1

'Default Property Values:
Const m_def_Recursive = True

'Property Variables:
Dim m_Recursive As Boolean

' These properties save the previous size of the control.
Private oldFormScaleWidth As Single
Private oldFormScaleHeight As Single
Private oldScaleWidth As Single
Private oldScaleHeight As Single

Private Sub UserControl_InitProperties()
    UserControl.BackColor = Ambient.BackColor
    UserControl.BorderStyle = 1
    m_Recursive = m_def_Recursive
End Sub

Private Sub UserControl_Show()
    InitControlInfo
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    Call PropBag.WriteProperty("BackColor", UserControl.BackColor, &H8000000F)
    Call PropBag.WriteProperty("BackStyle", UserControl.BackStyle, 1)
    Call PropBag.WriteProperty("Enabled", UserControl.Enabled, True)
    Call PropBag.WriteProperty("Recursive", m_Recursive, m_def_Recursive)
    Call PropBag.WriteProperty("BorderStyle", UserControl.BorderStyle, 0)
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    UserControl.BackColor = PropBag.ReadProperty("BackColor", &H8000000F)
    UserControl.BackStyle = PropBag.ReadProperty("BackStyle", 1)
    UserControl.Enabled = PropBag.ReadProperty("Enabled", True)
    m_Recursive = PropBag.ReadProperty("Recursive", m_def_Recursive)
    UserControl.BorderStyle = PropBag.ReadProperty("BorderStyle", 0)
End Sub

Private Sub UserControl_Resize()
    ' When the form resizes, move and resize all container controls.
    Dim xFactor As Single, yFactor As Single
    
    ' Exit if this is the first resize.
    If oldScaleWidth = 0 Then Exit Sub
    
    ' This accounts for controls that can't be resized.
    On Error Resume Next
    
    xFactor = ScaleWidth / oldScaleWidth
    yFactor = ScaleHeight / oldScaleHeight
    
    oldScaleWidth = ScaleWidth
    oldScaleHeight = ScaleHeight
    
    ' resize all controls accordingly
    Dim i As Integer, ctrl As Object
    
    For i = 1 To UBound(ctrlInfo)
        With ctrlInfo(i)
            If .InnerControl = False Or Recursive Then
                .ctrl.Move .Left * xFactor, .Top * yFactor, _
                    .Width * xFactor, .Height * yFactor
            End If
        End With
    Next
End Sub

' Save info on contained controls

Private Sub InitControlInfo()
    Dim i As Integer, ctrl As Control, ctrl2 As Control
    
    If ContainedControls.Count = 0 Or oldScaleWidth > 0 Then Exit Sub
    
    On Error Resume Next
    
    ' the first slot in this array is this UserControl.
    ReDim ctrlInfo(0 To ContainedControls.Count) As ControlInfo
    
    ' Initialize the private variables .
    oldFormScaleWidth = Parent.ScaleWidth
    oldFormScaleHeight = Parent.ScaleHeight
    oldScaleWidth = ScaleWidth
    oldScaleHeight = ScaleHeight
    
    ' save info on this UserControl
    With ctrlInfo(0)
        Set .ctrl = Extender
        .Left = .ctrl.Left
        .Top = .ctrl.Top
        .Width = .ctrl.Width
        .Height = .ctrl.Height
    End With
    
    ' loop on each contained control
    For Each ctrl In ContainedControls
        i = i + 1
        With ctrlInfo(i)
            Set .ctrl = ctrl
            .Left = ctrl.Left
            .Top = ctrl.Top
            .Width = ctrl.Width
            .Height = ctrl.Height
        End With
        ' loop on controls inside contained controls
        ' (one-level nesting only)
        For Each ctrl2 In Parent.Controls
            If ctrl2.Container Is ctrl Then
                ReDim Preserve ctrlInfo(1 To UBound(ctrlInfo) + 1) As ControlInfo
                i = i + 1
                With ctrlInfo(i)
                    Set .ctrl = ctrl2
                    .Left = ctrl2.Left
                    .Top = ctrl2.Top
                    .Width = ctrl2.Width
                    .Height = ctrl2.Height
                    .InnerControl = True
                End With
            End If
        Next
    Next
        
End Sub


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
'MappingInfo=UserControl,UserControl,-1,Enabled
Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
Attribute Enabled.VB_UserMemId = -514
    Enabled = UserControl.Enabled
End Property

Public Property Let Enabled(ByVal New_Enabled As Boolean)
    UserControl.Enabled() = New_Enabled
    PropertyChanged "Enabled"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=0,0,0,True
Public Property Get Recursive() As Boolean
    Recursive = m_Recursive
End Property

Public Property Let Recursive(ByVal New_Recursive As Boolean)
    m_Recursive = New_Recursive
    PropertyChanged "Recursive"
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


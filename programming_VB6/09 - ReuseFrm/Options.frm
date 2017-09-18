VERSION 5.00
Begin VB.Form frmOptions 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Options"
   ClientHeight    =   3570
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4080
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3570
   ScaleWidth      =   4080
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   960
      TabIndex        =   3
      Top             =   3120
      Width           =   975
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2160
      TabIndex        =   4
      Top             =   3120
      Width           =   975
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Check1"
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   2
      Top             =   2280
      Visible         =   0   'False
      Width           =   3615
   End
   Begin VB.OptionButton Option1 
      Caption         =   "Option1"
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   1
      Top             =   1800
      Value           =   -1  'True
      Visible         =   0   'False
      Width           =   3495
   End
   Begin VB.Frame Frame1 
      Height          =   1215
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Visible         =   0   'False
      Width           =   3855
   End
End
Attribute VB_Name = "frmOptions"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' ------------------------------------------------------------------------
' Copyright © 1998 Francesco Balena.
' ------------------------------------------------------------------------

Option Explicit

' the distance among Frame controls
Const FRAME_DISTANCE = 100
' the Left property of all controls within a frame
Const OPTION_LEFT = 200
' the Top property of the first option button in the frame
Const OPTION_TOP = 200
' the distance among option and check controls
Const OPTION_DISTANCE = 50
' the distance between the OK and Cancel buttons
Const BUTTON_DISTANCE = 100

' the caption of the form
Public DialogTitle As String

' this is set to True if the Cancel button was clicked
Public CancelPressed As Boolean

' this is the Top coordinates of the next button to be placed
Private nextBtnTop As Single

' this collection is loaded on exit with the values of all controls
'##Values.AutoNew True
Dim Values As New Collection


Sub AddFrame(ByVal key As String, ByVal caption As String, Optional showBorder As Boolean = True)
    ' add a new frame control
    
    Dim frameIndex As Integer
    Dim thisFrame As Frame, prevFrame As Frame
    
    ' since control arrays are zero-based, their Count property
    ' returns the index of the next frame that will be created
    frameIndex = Frame1.UBound + 1
    
    ' load a new frame
    Load Frame1(frameIndex)
    Set thisFrame = Frame1(frameIndex)
    Set prevFrame = Frame1(frameIndex - 1)
    ' if this is not the first frame, move it under the previous one
    If frameIndex > 1 Then
        thisFrame.Move prevFrame.Left, prevFrame.Top + prevFrame.Height + FRAME_DISTANCE, prevFrame.Width, thisFrame.Height
    End If
    
    ' set the frame's properties
    thisFrame.caption = caption
    thisFrame.Tag = key
    ' possible values for BorderStyle are 0 (none) or 1 (visible)
    thisFrame.BorderStyle = -(showBorder)
    
    ' set the position of the next button
    nextBtnTop = OPTION_TOP
    
End Sub

Sub AddOption(ByVal key As String, ByVal caption As String, Optional Value As Boolean)
    ' add an option button to the current group
    Dim optionIndex As Integer
    Dim frameIndex As Integer
    Dim thisBtn As OptionButton
    Dim thisFrame As Frame
    
    ' this is the number of the current group of controls
    frameIndex = Frame1.UBound
    Set thisFrame = Frame1(frameIndex)
   
    ' add a new option button
    optionIndex = Option1.UBound + 1
    Load Option1(optionIndex)
    
    ' creating a reference to involved controls simplifies the code
    Set thisBtn = Option1(optionIndex)
    
    ' put the button into the proper container
    Set thisBtn.Container = thisFrame
    ' move it the correct position
    thisBtn.Move OPTION_LEFT, nextBtnTop
    ' evaluate the position of next control
    nextBtnTop = nextBtnTop + thisBtn.Height + OPTION_DISTANCE
    
    ' set the button's properties
    thisBtn.Tag = key
    thisBtn.caption = caption
    thisBtn.Value = Value
    
    ' all control array items are created invisible
    thisBtn.Visible = True
    ' resize the frame and the form
    ResizeContainers thisFrame
End Sub

Sub AddCheck(ByVal key As String, ByVal caption As String, Optional Value As Integer)
    ' add a check button to the current group
    Dim optionIndex As Integer
    Dim frameIndex As Integer
    Dim thisBtn As CheckBox
    Dim thisFrame As Frame
    
    ' this is the number of the current group of controls
    frameIndex = Frame1.UBound
    Set thisFrame = Frame1(frameIndex)
   
    ' add a new check box control
    ' since control arrays are zero-based, their Count property
    ' returns the index of the next control that will be created
    optionIndex = Check1.UBound + 1
    Load Check1(optionIndex)
    
    ' creating a reference to involved controls simplifies the code
    Set thisBtn = Check1(optionIndex)
    
    ' put the button into the proper container
    Set thisBtn.Container = thisFrame
    ' move it the correct position
    thisBtn.Move OPTION_LEFT, nextBtnTop
    ' evaluate the position of next control
    nextBtnTop = nextBtnTop + thisBtn.Height + OPTION_DISTANCE
    
    ' set the button's properties
    thisBtn.Tag = key
    thisBtn.caption = caption
    thisBtn.Value = Abs(Value)
    
    ' all control array items are created invisible
    thisBtn.Visible = True
    ' resize the frame and the form
    ResizeContainers thisFrame
End Sub

Function Value(ByVal key As String) As Variant
    ' return the value associated to an option button,
    ' a checkbox or a frame (the value of a frame is the
    ' key of the option button whose value is true)
    
    Value = Values.Item(key)
    
End Function

Private Sub ResizeContainers(thisFrame As Frame)
    ' resize the frame so that it includes the new option button
    ' and ensure it is visible
    
    thisFrame.Height = nextBtnTop
    thisFrame.Visible = True
    
    ' move the OK and Cancel buttons under the last frame control
    cmdOK.Move ScaleWidth / 2 - BUTTON_DISTANCE - cmdOK.Width, thisFrame.Top + thisFrame.Height + OPTION_DISTANCE
    cmdCancel.Move ScaleWidth / 2 + BUTTON_DISTANCE, cmdOK.Top

    ' also resize the form
    Height = cmdOK.Top + cmdOK.Height + OPTION_DISTANCE + 400

End Sub

Private Sub cmdOK_Click()
    Unload Me
End Sub

Private Sub cmdCancel_Click()
    CancelPressed = True
    Unload Me
End Sub

Private Sub Form_Load()
    ' reset all values
    Set Values = Nothing
    ' set the form caption
    If DialogTitle <> "" Then Me.caption = DialogTitle
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' before unloading, the form must store the current
    ' value of all controls in a local collection, so that
    ' they can later retrieved by the Value function
    Dim ctrl As Control, ctrl2 As Control
    
    On Error Resume Next

    For Each ctrl In Controls
        ' if this is an option button or a check box
        ' just store their current value
        If TypeOf ctrl Is OptionButton Then
            Values.Add ctrl.Value, ctrl.Tag
        ElseIf TypeOf ctrl Is CheckBox Then
            Values.Add ctrl.Value, ctrl.Tag
        ElseIf TypeOf ctrl Is Frame Then
            ' if it is a frame box, store the key of the only
            ' option button inside it whose value is TRue
            For Each ctrl2 In Controls
                If TypeOf ctrl2 Is OptionButton Then
                    If (ctrl2.Container Is ctrl) And ctrl2.Value = True Then
                        Values.Add ctrl2.Tag, ctrl.Tag
                        Exit For
                    End If
                End If
            Next
        End If
    Next

End Sub


' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmOptions

	' ------------------------------------------------------------------------
	' Copyright © 1998 Francesco Balena.
	' ------------------------------------------------------------------------

	' the distance among Frame controls
	Private Const FRAME_DISTANCE As Short = 100
	' the Left property of all controls within a frame
	Private Const OPTION_LEFT As Short = 200
	' the Top property of the first option button in the frame
	Private Const OPTION_TOP As Short = 200
	' the distance among option and check controls
	Private Const OPTION_DISTANCE As Short = 50
	' the distance between the OK and Cancel buttons
	Private Const BUTTON_DISTANCE As Short = 100
	
	' the caption of the form
	Public DialogTitle As String = ""
	
	' this is set to True if the Cancel button was clicked
	Public CancelPressed As Boolean
	
	' this is the Top coordinates of the next button to be placed
	Private nextBtnTop As Single
	
	' this collection is loaded on exit with the values of all controls
	' This wrapper property has been added to preserve As New semantics of Values variable
	Private Property Values() As Collection
		Get
			If Values_InnerField Is Nothing Then Values_InnerField = New Collection()
			Return Values_InnerField
		End Get
		Set(value As Collection)
			Values_InnerField = value
		End Set
	End Property
	
	Private Values_InnerField As Collection

	Public Sub AddFrame(ByVal key As String, ByVal caption As String, Optional ByRef showBorder As Boolean = True)
		' add a new frame control
		
		Dim frameIndex As Short
		Dim thisFrame As VB6Frame = Nothing
		Dim prevFrame As VB6Frame = Nothing
		
		' since control arrays are zero-based, their Count property
		' returns the index of the next frame that will be created
		frameIndex = Frame1.UBound() + 1
		
		' load a new frame
		Frame1.Load(frameIndex)
		thisFrame = Frame1(frameIndex)
		prevFrame = Frame1(frameIndex - 1)
		' if this is not the first frame, move it under the previous one
		If frameIndex > 1 Then 
			thisFrame.Move(prevFrame.Left, prevFrame.Top + prevFrame.Height + FRAME_DISTANCE, prevFrame.Width, thisFrame.Height)
		End If
		
		' set the frame's properties
		thisFrame.Caption = caption
		thisFrame.Tag = key
		' possible values for BorderStyle are 0 (none) or 1 (visible)
		' UPGRADE_ISSUE (#1568): The BorderStyle property isn't supported. This property always returns 1-FixedSingle. Any attempts to assign value other than 1 throws an exception
		thisFrame.BorderStyle = -(showBorder)
		
		' set the position of the next button
		nextBtnTop = OPTION_TOP
		
	End Sub

	Public Sub AddOption(ByVal key As String, ByVal caption As String, Optional ByRef Value As Boolean = False)
		' add an option button to the current group
		Dim optionIndex As Short
		Dim frameIndex As Short
		Dim thisBtn As VB6OptionButton = Nothing
		Dim thisFrame As VB6Frame = Nothing
		
		' this is the number of the current group of controls
		frameIndex = Frame1.UBound()
		thisFrame = Frame1(frameIndex)
		
		' add a new option button
		optionIndex = Option1.UBound() + 1
		Option1.Load(optionIndex)
		
		' creating a reference to involved controls simplifies the code
		thisBtn = Option1(optionIndex)
		
		' put the button into the proper container
		thisBtn.Container = thisFrame
		' move it the correct position
		thisBtn.Move(OPTION_LEFT, nextBtnTop)
		' evaluate the position of next control
		nextBtnTop = nextBtnTop + thisBtn.Height + OPTION_DISTANCE
		
		' set the button's properties
		thisBtn.Tag = key
		thisBtn.Caption = caption
		thisBtn.Value = Value
		
		' all control array items are created invisible
		thisBtn.Visible = True
		' resize the frame and the form
		ResizeContainers(thisFrame)
	End Sub

	Public Sub AddCheck(ByVal key As String, ByVal caption As String, Optional ByRef Value As Short = 0)
		' add a check button to the current group
		Dim optionIndex As Short
		Dim frameIndex As Short
		Dim thisBtn As VB6CheckBox = Nothing
		Dim thisFrame As VB6Frame = Nothing
		
		' this is the number of the current group of controls
		frameIndex = Frame1.UBound()
		thisFrame = Frame1(frameIndex)
		
		' add a new check box control
		' since control arrays are zero-based, their Count property
		' returns the index of the next control that will be created
		optionIndex = Check1.UBound() + 1
		Check1.Load(optionIndex)
		
		' creating a reference to involved controls simplifies the code
		thisBtn = Check1(optionIndex)
		
		' put the button into the proper container
		thisBtn.Container = thisFrame
		' move it the correct position
		thisBtn.Move(OPTION_LEFT, nextBtnTop)
		' evaluate the position of next control
		nextBtnTop = nextBtnTop + thisBtn.Height + OPTION_DISTANCE
		
		' set the button's properties
		thisBtn.Tag = key
		thisBtn.Caption = caption
		thisBtn.Value = Abs6(Value)
		
		' all control array items are created invisible
		thisBtn.Visible = True
		' resize the frame and the form
		ResizeContainers(thisFrame)
	End Sub

	Public Function Value(ByVal key As String) As Object
		' return the value associated to an option button,
		' a checkbox or a frame (the value of a frame is the
		' key of the option button whose value is true)
		
		Return Values.Item(key)
		
	End Function

	Private Sub ResizeContainers(ByRef thisFrame As VB6Frame)
		' resize the frame so that it includes the new option button
		' and ensure it is visible
		
		thisFrame.Height = nextBtnTop
		thisFrame.Visible = True
		
		' move the OK and Cancel buttons under the last frame control
		cmdOK.Move(ScaleWidth / 2 - BUTTON_DISTANCE - cmdOK.Width, thisFrame.Top + thisFrame.Height + OPTION_DISTANCE)
		cmdCancel.Move(ScaleWidth / 2 + BUTTON_DISTANCE, cmdOK.Top)
		
		' also resize the form
		Height = cmdOK.Top + cmdOK.Height + OPTION_DISTANCE + 400
		
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		CancelPressed = True
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' reset all values
		Values = Nothing
		' set the form caption
		If DialogTitle <> "" Then  Me.Caption = DialogTitle
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' before unloading, the form must store the current
		' value of all controls in a local collection, so that
		' they can later retrieved by the Value function
		Dim ctrl As Object = Nothing
		Dim ctrl2 As Object = Nothing
		
		On Error Resume Next 
		
		For Each ctrl In Controls6
			' if this is an option button or a check box
			' just store their current value
			If TypeOf ctrl Is VB6OptionButton Then 
				Values.Add(CObj(ctrl).Value, ctrl.Tag)
			ElseIf TypeOf ctrl Is VB6CheckBox Then 
				Values.Add(CObj(ctrl).Value, ctrl.Tag)
			ElseIf TypeOf ctrl Is VB6Frame Then 
				' if it is a frame box, store the key of the only
				' option button inside it whose value is TRue
				For Each ctrl2 In Controls6
					If TypeOf ctrl2 Is VB6OptionButton Then 
						If (ctrl2.Container Is ctrl) And CObj(ctrl2).Value = True Then 
							Values.Add(ctrl2.Tag, ctrl.Tag)
							Exit For
						End If
					End If
				Next
			End If
		Next
		
	End Sub

End Class

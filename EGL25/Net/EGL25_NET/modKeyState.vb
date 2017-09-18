' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module modKeyState

	Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
	
	Public Sub UpdatePartPos()
		
		With ObjPart
			If frmCanvas.chkAnimation.Value = 1 Then 
				Call UpdateAnim()
			Else
				Call UpdateKey()
			End If
			'this   -> angle step = 1
			.Direction.X = CInt(.Direction.X) Mod 360
			.Direction.Y = CInt(.Direction.Y) Mod 360
			.Direction.Z = CInt(.Direction.Z) Mod 360
			
			'or this
			'        If .Direction.X < 0 Then .Direction.X = .Direction.X + 360
			'        If .Direction.X > 360 Then .Direction.X = .Direction.X - 360
			'        If .Direction.Y < 0 Then .Direction.Y = .Direction.Y + 360
			'        If .Direction.Y > 360 Then .Direction.Y = .Direction.Y - 360
			'        If .Direction.Z < 0 Then .Direction.Z = .Direction.Z + 360
			'        If .Direction.Z > 360 Then .Direction.Z = .Direction.Z - 360
			
			If .Scale < 0.001 Then  .Scale = 0.001
			If .Scale > 1000 Then  .Scale = 1000
		End With
		
	End Sub

	'---------------------------------------
	'Sub: UpdateKey
	'Basýlan tuþa göre parçanýn konumu belirleniyor.
	'---------------------------------------
	
	Private Sub UpdateKey()
		
		Dim R As Single = 2.2
		Dim S As Single
		Dim T As Single
		
		With ObjPart
			S = .Scale * 0.02
			T = 5 / .Scale
			If State(VBRUN.KeyCodeConstants.vbKeyShift) Then 
				If State(VBRUN.KeyCodeConstants.vbKeyD) Then  .Position.X += T
				If State(VBRUN.KeyCodeConstants.vbKeyA) Then  .Position.X -= T
				If State(VBRUN.KeyCodeConstants.vbKeyW) Then  .Position.Y += T
				If State(VBRUN.KeyCodeConstants.vbKeyS) Then  .Position.Y -= T
				If State(VBRUN.KeyCodeConstants.vbKeyE) Then  .Position.Z += T
				If State(VBRUN.KeyCodeConstants.vbKeyQ) Then  .Position.Z -= T
			Else
				If State(VBRUN.KeyCodeConstants.vbKeyS) Then  .Direction.X += R
				If State(VBRUN.KeyCodeConstants.vbKeyW) Then  .Direction.X -= R
				If State(VBRUN.KeyCodeConstants.vbKeyD) Then  .Direction.Y += R
				If State(VBRUN.KeyCodeConstants.vbKeyA) Then  .Direction.Y -= R
				If State(VBRUN.KeyCodeConstants.vbKeyQ) Then  .Direction.Z += R
				If State(VBRUN.KeyCodeConstants.vbKeyE) Then  .Direction.Z -= R
				If State(VBRUN.KeyCodeConstants.vbKeyC) Then  .Scale -= S
				If State(VBRUN.KeyCodeConstants.vbKeyZ) Then  .Scale += S
				If State(VBRUN.KeyCodeConstants.vbKeyX) Then  Call ResetPos()
				If State(VBRUN.KeyCodeConstants.vbKeyEscape) Then  Unload6(frmCanvas): Application.Exit(): End
			End If
		End With
		
	End Sub

	Private Sub UpdateAnim()
		
		Dim i As Short
		Dim R(2) As Single
		Dim T(2) As Single
		
		For i = 0 To 2
			R(i) = VerifyText(frmCanvas.txtRot(i))
			T(i) = VerifyText(frmCanvas.txtTrans(i))
		Next
		
		With ObjPart
			If T(0) <> 0 Then  .Position.X += T(0)
			If T(1) <> 0 Then  .Position.Y += T(1)
			If T(2) <> 0 Then  .Position.Z += T(2)
			If R(0) <> 0 Then  .Direction.X += R(0)
			If R(1) <> 0 Then  .Direction.Y += R(1)
			If R(2) <> 0 Then  .Direction.Z += R(2)
		End With
		
	End Sub

	Private Function State(ByVal key As Integer) As Boolean
		
		Dim lngKeyState As Integer = GetKeyState(key)
		
		Return IIf((lngKeyState And &H8000S), True, False)
		
	End Function

	Private Function VerifyText(ByVal txt As VB6TextBox) As Single
		
		If IsNumeric6(txt.Text) And txt.Text <> 0 Then 
			Return CSng(txt.Text)
		Else
			Return 0
		End If
		
	End Function

	Private Sub ResetPos()
		
		With ObjPart
			.Direction.X = 0: .Direction.Y = 0: .Direction.Z = 0
			.Position.X = 0: .Position.Y = 0: .Position.Z = 0
			.Scale = 1
		End With
		
	End Sub

End Module

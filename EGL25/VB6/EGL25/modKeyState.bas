Attribute VB_Name = "modKeyState"

Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

Public Sub UpdatePartPos()

    With ObjPart
        If frmCanvas.chkAnimation.Value = 1 Then
            Call UpdateAnim
        Else
            Call UpdateKey
        End If
'this   -> angle step = 1
        .Direction.X = .Direction.X Mod 360
        .Direction.Y = .Direction.Y Mod 360
        .Direction.Z = .Direction.Z Mod 360
        
'or this
'        If .Direction.X < 0 Then .Direction.X = .Direction.X + 360
'        If .Direction.X > 360 Then .Direction.X = .Direction.X - 360
'        If .Direction.Y < 0 Then .Direction.Y = .Direction.Y + 360
'        If .Direction.Y > 360 Then .Direction.Y = .Direction.Y - 360
'        If .Direction.Z < 0 Then .Direction.Z = .Direction.Z + 360
'        If .Direction.Z > 360 Then .Direction.Z = .Direction.Z - 360
        
        If .Scale < 0.001 Then .Scale = 0.001
        If .Scale > 1000 Then .Scale = 1000
    End With
    
End Sub

'---------------------------------------
'Sub: UpdateKey
'Basýlan tuþa göre parçanýn konumu belirleniyor.
'---------------------------------------

Private Sub UpdateKey()
 
    Dim R As Single, S As Single, T As Single
    
    With ObjPart
        R = 2.2
        S = .Scale * 0.02
        T = 5 / .Scale
        If State(vbKeyShift) Then
            If State(vbKeyD) Then .Position.X = .Position.X + T
            If State(vbKeyA) Then .Position.X = .Position.X - T
            If State(vbKeyW) Then .Position.Y = .Position.Y + T
            If State(vbKeyS) Then .Position.Y = .Position.Y - T
            If State(vbKeyE) Then .Position.Z = .Position.Z + T
            If State(vbKeyQ) Then .Position.Z = .Position.Z - T
        Else
            If State(vbKeyS) Then .Direction.X = .Direction.X + R
            If State(vbKeyW) Then .Direction.X = .Direction.X - R
            If State(vbKeyD) Then .Direction.Y = .Direction.Y + R
            If State(vbKeyA) Then .Direction.Y = .Direction.Y - R
            If State(vbKeyQ) Then .Direction.Z = .Direction.Z + R
            If State(vbKeyE) Then .Direction.Z = .Direction.Z - R
            If State(vbKeyC) Then .Scale = .Scale - S
            If State(vbKeyZ) Then .Scale = .Scale + S
            If State(vbKeyX) Then Call ResetPos
            If State(vbKeyEscape) Then Unload frmCanvas:    End
        End If
    End With

End Sub

Private Sub UpdateAnim()

    Dim i As Integer
    Dim R(2) As Single, T(2) As Single
    
    For i = 0 To 2
        R(i) = VerifyText(frmCanvas.txtRot(i))
        T(i) = VerifyText(frmCanvas.txtTrans(i))
    Next
    
    With ObjPart
        If T(0) <> 0 Then .Position.X = .Position.X + T(0)
        If T(1) <> 0 Then .Position.Y = .Position.Y + T(1)
        If T(2) <> 0 Then .Position.Z = .Position.Z + T(2)
        If R(0) <> 0 Then .Direction.X = .Direction.X + R(0)
        If R(1) <> 0 Then .Direction.Y = .Direction.Y + R(1)
        If R(2) <> 0 Then .Direction.Z = .Direction.Z + R(2)
    End With
   
End Sub

Private Function State(key As Long) As Boolean
 
    Dim lngKeyState As Long
    
    lngKeyState = GetKeyState(key)
    State = IIf((lngKeyState And &H8000), True, False)

End Function

Private Function VerifyText(txt As TextBox) As Single
  
    If IsNumeric(txt.Text) And txt.Text <> 0 Then
        VerifyText = CSng(txt.Text)
    Else
        VerifyText = 0
    End If

End Function

Private Sub ResetPos()

    With ObjPart
        .Direction.X = 0: .Direction.Y = 0: .Direction.Z = 0
        .Position.X = 0: .Position.Y = 0: .Position.Z = 0
        .Scale = 1
    End With
    
End Sub

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmCanvas

	Private FPS As Short
	
	Private Sub chkShow_Click() Handles chkShow.Click
		
		With chkShow
			scrFaces.Enabled = .Value
			RO.Show = .Value
		End With
		
	End Sub

	Private Sub cmdApply_Click() Handles cmdApply.Click
		
		If IsNumeric6(txtLight(0).Text) And IsNumeric6(txtLight(1).Text) And IsNumeric6(txtLight(2).Text) Then 
			Light = VectorSet(CSng(txtLight(0).Text), CSng(txtLight(1).Text), CSng(txtLight(2).Text))
			Light = VectorNormalize(Light)
		End If
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		
		If Me.ScaleWidth - picCarry.Width - 5 > 5 Then 
			picCanvas.Move(0, 0, Me.ScaleWidth - picCarry.Width - 5, Me.ScaleHeight)
			picCarry.Move(picCanvas.ScaleWidth + 10, 5)
			HalfWidth = picCanvas.ScaleWidth / 2
			HalfHeight = picCanvas.ScaleHeight / 2
			Call TerminateDC()
			Call InitializeDC(picCanvas)
		End If
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		
		Call TerminateDC()
		Application.Exit(): End
		
	End Sub

	Private Sub mnuExit_Click() Handles mnuExit.Click
		
		Unload6(Me)
		
	End Sub

	Private Sub mnuKeyboard_Click() Handles mnuKeyboard.Click
		
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmCanvas' was converted to Me keyword.
		frmKeyboard.Show(VBRUN.FormShowConstants.vbModeless, Me)
		
	End Sub

	Private Sub mnuOpen_Click() Handles mnuOpen.Click
		
		Call LoadPart()
		
	End Sub

	Private Sub mnuRender_Click(ByRef Index As Short)
		
		Dim i As Short
		
		RO.RType = Index
		RO.Hidden = IIf(RO.RType = RenderType.Dot Or RO.RType = RenderType.Wireframe, False, True)
		For i = 0 To mnuRender.Count() - 1
			mnuRender(i).Checked = IIf(i = Index, True, False)
		Next

	End Sub

	Private Sub mnuShade_Click() Handles mnuShade.Click
		
		mnuShade.Checked = Not mnuShade.Checked
		RO.Shade = mnuShade.Checked
		
	End Sub

	Private Sub optColor_Click(ByRef Index As Short)
		
		If Index = 0 Then 
			RO.tColor = ColorSet(scrRed.Value, scrGreen.Value, scrBlue.Value)
		Else
			RO.tColor = ColorGray(scrRed.Value, scrGreen.Value, scrBlue.Value)
		End If
		
	End Sub

	Private Sub optLoc_Click(ByRef Index As Short)
		
		RO.LightOrbit = IIf(Index = 1, True, False)
		
	End Sub

	Private Sub picCanvas_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles picCanvas.MouseMove
		
		If Button = VBRUN.MouseButtonConstants.vbLeftButton Then 
			txtLight(0).Text = X - (picCanvas.ScaleWidth / 2)
			txtLight(1).Text = -Y + (picCanvas.ScaleHeight / 2)
		End If
		Call cmdApply_Click()
		
	End Sub

	Private Sub picCanvas_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles picCanvas.MouseUp
		
		If Button = VBRUN.MouseButtonConstants.vbRightButton Then  PopupMenu(mnuView)
		
	End Sub

	Private Sub scrRed_Change() Handles scrRed.Change
		
		Call UpdateROColor(ColorSet(scrRed.Value, RO.tColor.G, RO.tColor.B))
		
	End Sub

	Private Sub scrRed_Scroll() Handles scrRed.Scroll
		
		Call UpdateROColor(ColorSet(scrRed.Value, RO.tColor.G, RO.tColor.B))
		
	End Sub

	Private Sub scrGreen_Change() Handles scrGreen.Change
		
		Call UpdateROColor(ColorSet(RO.tColor.R, scrGreen.Value, RO.tColor.B))
		
	End Sub

	Private Sub scrGreen_Scroll() Handles scrGreen.Scroll
		
		Call UpdateROColor(ColorSet(RO.tColor.R, scrGreen.Value, RO.tColor.B))
		
	End Sub

	Private Sub scrBlue_Change() Handles scrBlue.Change
		
		Call UpdateROColor(ColorSet(RO.tColor.R, RO.tColor.G, scrBlue.Value))
		
	End Sub

	Private Sub scrBlue_Scroll() Handles scrBlue.Scroll
		
		Call UpdateROColor(ColorSet(RO.tColor.R, RO.tColor.G, scrBlue.Value))
		
	End Sub

	Private Sub scrFaces_Change() Handles scrFaces.Change
		
		lblFaces.Caption = scrFaces.Value
		RO.ShowIndex = scrFaces.Value
		
	End Sub

	Private Sub scrFaces_Scroll() Handles scrFaces.Scroll
		
		lblFaces.Caption = scrFaces.Value
		RO.ShowIndex = scrFaces.Value
		
	End Sub

	Private Sub scrLuminance_Change() Handles scrLuminance.Change
		
		RO.Luminance = scrLuminance.Value
		
	End Sub

	Private Sub scrLuminance_Scroll() Handles scrLuminance.Scroll
		
		RO.Luminance = scrLuminance.Value
		
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		
		lblFPS.Caption = FPS
		FPS = 0
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
		Call InitializeDC(picCanvas)
		Call SetIdentity()
		Call chkShow_Click()
		Call mnuRender_Click(4)
		Call mnuShade_Click()
		'    chkShow.Value = vbUnchecked
		chkShow.Enabled = False
		scrFaces.Enabled = False
		optColor(0).Value = True
		Camera.X = 0
		Camera.Y = 0
		Camera.Z = 1
		
	End Sub

	Private Sub cmdRandom_Click() Handles cmdRandom.Click
		
		Call UpdateROColor(ColorRandom())
		
	End Sub

	Private Sub cmdSelect_Click() Handles cmdSelect.Click
		
		cdiLoad.ShowColor()
		If Not cdiLoad.Color.Equals(Color.Black) Then 
			Call UpdateROColor(ColorLongToRGB(ToOleColor6(cdiLoad.Color)))
		End If
		
	End Sub

	Private Sub UpdateROColor(ByRef C As ColorRGB)
		
		RO.tColor = C
		optColor(0).Value = True
		scrRed.Value = RO.tColor.R
		scrGreen.Value = RO.tColor.G
		scrBlue.Value = RO.tColor.B
		
	End Sub

	Private Sub LoadPart()
		
		On Error Resume Next 
		With cdiLoad
			.Filter = "EGL part file|*.prt"
			'        .InitDir = App.Path + "\objects\"
			.FileName = ""
			.ShowOpen()
			If .FileName = "" Then  Exit Sub
			Call LoadObject(.FileName)
		End With
		
		Dim PosMatrix As Matrix
		Dim i As Integer
		
		With ObjPart
			optLoc(0).Value = True
			chkShow.Enabled = True
			chkShow.Value = VBRUN.CheckBoxConstants.vbUnchecked
			Call UpdateROColor(ColorSet(.Color.R, .Color.G, .Color.B))
			lblFacesNum.Caption = .NumFaces
			Me.Caption = .Caption & " - EGL"
			scrFaces.Max = .NumFaces
			cmdApply_Click()
			RO.Luminance = scrLuminance.Value
			
			Do
				Call UpdatePartPos()
				
				PosMatrix = WorldMatrix()
				
				For i = 0 To .NumVertices
					.VerticesT(i) = MatrixMultVector(PosMatrix, .Vertices(i))
					.VerticesT(i) = VectorScale(.VerticesT(i), .Scale)
					.ScreenCoord(i).X = .VerticesT(i).X + HalfWidth
					.ScreenCoord(i).Y = -.VerticesT(i).Y + HalfHeight
				Next
				
				For i = 0 To .NumFaces
					.NormalT(i) = MatrixMultVector(PosMatrix, .Normal(i))
				Next
				
				If optLoc(0).Value Then 
					LightT = Light
				Else
					LightT = MatrixMultVector(PosMatrix, Light)
				End If
				
				Call Render(picCanvas)
				lblTx.Caption = .Position.X
				lblTy.Caption = .Position.Y
				lblTz.Caption = .Position.Z
				lblRx.Caption = .Direction.X
				lblRy.Caption = .Direction.Y
				lblRz.Caption = .Direction.Z
				lblS.Caption = .Scale
				lblRGBA(0).Caption = scrRed.Value
				lblRGBA(1).Caption = scrGreen.Value
				lblRGBA(2).Caption = scrBlue.Value
				lblRGBA(3).Caption = scrLuminance.Value
				lblFacesNumV.Caption = UBound6(ObjPart.FaceV)
				FPS += 1
				DoEvents6()
			Loop
		End With
		
	End Sub

	'Private Sub UpdateLabels()
	
	'    Dim idx As Integer
	'    Dim point As POINTAPI
	'
	'    With ObjPart
	'        If chkShow.Value Then
	'                lblFaces.Caption = scrFaces.Value
	'                lblA.Caption = .Faces(scrFaces.Value).A
	'                lblB.Caption = .Faces(scrFaces.Value).B
	'                lblC.Caption = .Faces(scrFaces.Value).C
	''                labA.Caption = lblA.Caption
	''                labB.Caption = lblB.Caption
	''                labC.Caption = lblC.Caption
	''                point.X = .VerticesT(lblA.Caption).X
	''                point.Y = -.VerticesT(lblA.Caption).Y
	''                labA.Move point.X, point.Y
	''                point.X = .VerticesT(lblB.Caption).X
	''                point.Y = -.VerticesT(lblB.Caption).Y
	''                labB.Move point.X, point.Y
	''                point.X = .VerticesT(lblC.Caption).X
	''                point.Y = -.VerticesT(lblC.Caption).Y
	''                labC.Move point.X, point.Y
	'        End If
	
	'    End With
	
	'End Sub

End Class

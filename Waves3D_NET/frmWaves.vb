' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmWaves

	Private Const EyeR As Double = 10#
	Private Const EyeTheta As Double = PI * 0.2
	Private Const EyePhi As Double = PI * 0.1
	
	Private Const FocusX As Double = 0#
	Private Const FocusY As Double = 0#
	Private Const FocusZ As Double = 0#

	Private Projector(4, 4) As Single
	
	Private ThePicture As objPicture
	Private TheGrid As ObjGrid3D
	Private Running As Short
	' Draw the surface.
	Private Sub DrawData(ByVal pic As Object)
		' UPGRADE_INFO (#0501): The 'x' member isn't used anywhere in current application.
		Dim x As Single
		' UPGRADE_INFO (#0501): The 'y' member isn't used anywhere in current application.
		Dim y As Single
		' UPGRADE_INFO (#0501): The 'z' member isn't used anywhere in current application.
		Dim z As Single
		Dim S(4, 4) As Single
		Dim t(4, 4) As Single
		Dim ST(4, 4) As Single
		Dim PST(4, 4) As Single

		On Error Resume Next 
		
		' Scale and translate so it looks OK in pixels.
		m3Scale(S, 35, -35, 1)
		m3Translate(t, 230, 175, 0)
		m3MatMultiplyFull(ST, S, t)
		m3MatMultiplyFull(PST, Projector, ST)
		
		' Transform the points.
		ThePicture.ApplyFull(PST)
		
		' Display the data.
		pic.Cls
		ThePicture.Draw(pic, EyeR)
		pic.Refresh
	End Sub

	Private Sub CmdDisplay_Click() Handles cmdDisplay.Click
		Pict.Visible = True
		If Running Then 
			cmdDisplay.Caption = "Stopped"
			cmdDisplay.Enabled = False
			Running = CShort(False)
		Else
			Running = CShort(True)
			cmdDisplay.Caption = "Stop"
			ShowFrames()
			cmdDisplay.Caption = "Run"
			cmdDisplay.Enabled = True
		End If
	End Sub

	Private Sub cmdExit_Click() Handles cmdExit.Click
		If cmdDisplay.Caption = "Stop" Then 
			MsgBox6("Stop the Function first !", MsgBoxStyle.Information, "Waves")
			Exit Sub
		Else
			Unload6(Me)
		End If
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim i As Short
		
		' Initialize the projection transformation.
		m3PProject(Projector, m3Perspective, EyeR, EyePhi, EyeTheta, FocusX, FocusY, FocusZ, 0, 1, 0)
		
		' Load empty image controls for later reproduction of saved image transformation
		For i = 2 To 20
			SurfaceImage.Load(i)
		Next
		
		cmdDisplay.Enabled = False
	End Sub

	Public Sub CmdCreate_click() Handles cmdCreate.click
		cmdDisplay.Enabled = True
		lblCounter.Visible = True
		txtCounter.Visible = True
		Pict.Visible = False
		Const PI_10 As Double = PI / 10
		Const xmin As Short = -5
		Const Zmin As Short = -5
		Const dx As Single = 0.3
		Const dz As Single = 0.3
		Const NumX As Double = -2 * xmin / dx
		Const NumZ As Double = -2 * Zmin / dz
		Const Amp As Single = 0.25
		
		Dim num As Short
		Dim offset As Single
		Dim i As Short
		Dim j As Short
		Dim x As Single
		Dim y As Single
		Dim z As Single
		Dim D As Single
		
		MousePointer = VBRUN.MousePointerConstants.vbHourglass
		Refresh()
		'Save 20 positions of grid(net) as images
		Dim count As Short
		For num = 1 To 20
			count = (20 - num) \ 2
			lblCounter.Caption = ControlChars.CrLf & "Loading ... "
			txtCounter.Text = count
			ThePicture = New objPicture()
			TheGrid = New ObjGrid3D()
			TheGrid.SetBounds(xmin, dx, NumX, Zmin, dz, NumZ)
			ThePicture.objects.Add(TheGrid)
			
			offset = num * PI_10
			x = xmin
			For i = 1 To NumX
				z = Zmin
				For j = 1 To NumZ
					D = Math.Sqrt(x * x + z * z)
					
					'This is a Function that can be modified , You can test various
					'formulas and even ,( I think it is possible ) to get data from Db and
					'set the function to show graphical ( 3D ) report.
					'If you perform testing , take care about OVERFLOW error
					y = Amp * Math.Sin(3 * D - offset)
					
					TheGrid.SetValue(x, y, z)
					z += dz
					
				Next
				
				x += dx
			Next
			
			' Display the data.
			DrawData(Pict)
			
			' Save the bitmap for later.
			SurfaceImage(num).Picture = Pict.Image
			DoEvents6()
			
		Next
		txtCounter.Visible = False
		lblCounter.Visible = False
		Pict.Visible = True
		cmdCreate.Enabled = False
		cmdDisplay.Enabled = True
		cmdDisplay.Default = True
		MousePointer = VBRUN.MousePointerConstants.vbDefault
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Application.Exit(): End
	End Sub

	' Show the images.
	Private Sub ShowFrames()
		Const ms_per_frame As Short = 50
		Static num As Short
		Dim next_time As Integer
		
		Do While Running
			num += 1
			If num > 20 Then  num = 1
			next_time = GetTickCount() + ms_per_frame
			Pict.Picture = SurfaceImage(num).Picture
			DoEvents6()
			WaitTill(next_time)
		Loop
	End Sub

End Class

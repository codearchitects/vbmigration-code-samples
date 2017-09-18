' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const n As Short = 20
	Private Const d As Short = 20
	Private Const ox As Short = 50
	Private Const oy As Short = 50
	
	Private Const userid As Short = 1
	Private Const comid As Short = 2
	Private com As computer1
	Private bang(n, n) As Short

	Private Sub veo(ByRef i As Short, ByRef j As Short)
		DrawWidth = 3
		'X
		If bang(i, j) = 1 Then 
			Line(VBRUN.GraphicsOptions.None, ox + (j - 1) * d + 2, oy + (i - 1) * d + 2, ox + j * d - 2, oy + i * d - 2, VBRUN.ColorConstants.vbRed)
			Line(VBRUN.GraphicsOptions.None, ox + (j - 1) * d + 2, oy + i * d - 2, ox + j * d - 2, oy + (i - 1) * d + 2, VBRUN.ColorConstants.vbRed)
		End If
		'O
		If bang(i, j) = 2 Then 
			Circle(VBRUN.GraphicsOptions.None, ox + (j - 1) * d + d \ 2, oy + (i - 1) * d + d \ 2, d \ 2 - 1, VBRUN.ColorConstants.vbBlue)
		End If
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim i As Short
		Dim j As Short
		com = New computer1()
		com.n = n
		For i = 1 To n
			For j = 1 To n
				bang(i, j) = 1
			Next
		Next
	End Sub

	Private Sub Form_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseDown
		Dim i As Short
		Dim j As Short
		Dim nx As Short
		Dim ny As Short
		If com.checkwin() Then  Exit Sub
		'Tinh vi tri
		i = (Y - oy) \ d + 1
		j = (X - ox) \ d + 1
		If (i < 0) Or (i > n) Or (j < 0) Or (j > n) Then  Exit Sub
		If bang(i, j) <> 0 Then  Exit Sub
		bang(i, j) = userid
		Call com.gan(i, j, bang(i, j))
		Call veo(i, j)
		If com.checkwin() Then  MsgBox6(("Ban da thang"))
		'Computer
		Call com.timnuocdi(i, j)
		bang(i, j) = comid
		Call com.gan(i, j, bang(i, j))
		Call veo(i, j)
		If com.checkwin() Then  MsgBox6(("May da thang"))
	End Sub

	Private Sub veban()
		Dim i As Short
		Dim j As Short
		'To
		DrawWidth = 1
		For i = 1 To n
			For j = 1 To n
				Line(VBRUN.GraphicsOptions.BoxFilled, ox + (i - 1) * d, oy + (j - 1) * d, ox + i * d, oy + j * d, VBRUN.ColorConstants.vbWhite)
			Next
		Next
		'Ke
		For i = 0 To n
			Line(VBRUN.GraphicsOptions.None, ox + i * d, oy, ox + i * d, oy + n * d, VBRUN.ColorConstants.vbBlack)
		Next
		For i = 0 To n
			Line(VBRUN.GraphicsOptions.None, ox, oy + i * d, ox + n * d, oy + i * d, VBRUN.ColorConstants.vbBlack)
		Next
	End Sub

	Private Sub mnuexit_Click() Handles mnuexit.Click
		Application.Exit(): End
	End Sub

	Private Sub mnunew_Click() Handles mnunew.Click
		Dim i As Short
		Dim j As Short
		'Khoi tao
		Call veban()
		For i = 1 To n
			For j = 1 To n
				bang(i, j) = 0
				Call com.gan(i, j, 0)
			Next
		Next
	End Sub

End Class

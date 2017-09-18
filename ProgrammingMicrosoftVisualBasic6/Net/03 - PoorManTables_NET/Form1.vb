' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		' load values for numbers 1-100
		Dim n As Integer
		For n = 1 To 100
			lstN.AddItem(n)
			lstSquare.AddItem(n * n)
		Next

	End Sub

	Private Sub lstN_Click() Handles lstN.Click
		' synchronize listboxes
		lstSquare.TopIndex = lstN.TopIndex
		lstSquare.ListIndex = lstN.ListIndex
	End Sub

	Private Sub lstSquare_Click() Handles lstSquare.Click
		' synchronize listboxes
		lstN.TopIndex = lstSquare.TopIndex
		lstN.ListIndex = lstSquare.ListIndex
	End Sub

	Private Sub lstN_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstN.MouseDown
		Call lstN_Click()
	End Sub

	Private Sub lstN_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstN.MouseMove
		Call lstN_Click()
	End Sub

	Private Sub lstSquare_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstSquare.MouseDown
		Call lstSquare_Click()
	End Sub

	Private Sub lstSquare_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstSquare.MouseMove
		Call lstSquare_Click()
	End Sub

	Private Sub lstN_Scroll() Handles lstN.Scroll
		lstSquare.TopIndex = lstN.TopIndex
	End Sub

	Private Sub lstSquare_Scroll() Handles lstSquare.Scroll
		lstN.TopIndex = lstSquare.TopIndex
	End Sub

End Class

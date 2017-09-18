' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		StartSubclassing(Me.hWnd)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		StopSubclassing()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		With lstMessages
			.Move(.Left, .Top, ScaleWidth - .Left * 2, ScaleHeight - .Top - 200)
		End With
	End Sub

End Class

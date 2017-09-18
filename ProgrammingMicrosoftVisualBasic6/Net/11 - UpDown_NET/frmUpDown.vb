' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmUpDown

	Private Sub updHorizontal_DownClick() Handles updHorizontal.DownClick
		Dim ctrl As Object = Nothing
		For Each ctrl In Controls6
			ctrl.Left -= ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		Next
	End Sub

	Private Sub updHorizontal_UpClick() Handles updHorizontal.UpClick
		Dim ctrl As Object = Nothing
		For Each ctrl In Controls6
			ctrl.Left += ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		Next
	End Sub

	Private Sub updVertical_DownClick() Handles updVertical.DownClick
		Dim ctrl As Object = Nothing
		For Each ctrl In Controls6
			ctrl.Top += ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		Next
	End Sub

	Private Sub updVertical_UpClick() Handles updVertical.UpClick
		Dim ctrl As Object = Nothing
		For Each ctrl In Controls6
			ctrl.Top -= ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		Next
	End Sub

	Private Sub cmdChangeBuddy_Click() Handles cmdChangeBuddy.Click
		If updBuddy.BuddyControl = "txtValue" Then 
			' the BuddyControl property accepts both a reference
			' and the name of the buddy control
			updBuddy.BuddyControl = txtValue2.Name
			updBuddy.BuddyProperty = "Text"
		Else
			updBuddy.BuddyControl = "txtValue"
			updBuddy.BuddyProperty = "Text"
		End If
	End Sub

End Class

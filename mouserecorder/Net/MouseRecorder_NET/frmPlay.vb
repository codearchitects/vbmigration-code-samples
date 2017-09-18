' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmPlay

	Private ShapeForm As clsTransForm 'make a reference to the class
	
	Private Sub Form_Load() Handles MyBase.Load
		ShapeForm = New clsTransForm() 'instantiate the object from the class
		
		Me.Top = 0
		Me.Left = Screen6.Width - Me.Width
		
		If Dir6(ApplPath() & "playfrm.shp") = "" Then  ' Save the FormRegion
			ShapeForm.ShapeMe(Me, RGB(0, 0, 255), False, ApplPath() & "playfrm.shp")
			 Else ' Only use below if you wish to recalculate everything...
			ShapeForm.ShapeMe(Me, RGB(0, 0, 255), True, ApplPath() & "playfrm.shp")
		End If
	End Sub

End Class

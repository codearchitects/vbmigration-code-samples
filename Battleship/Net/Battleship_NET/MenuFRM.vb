' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class MenuFRM

	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
	'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
	'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	
	Private Sub Form_Load() Handles MyBase.Load
		PlayWav("click!.wav")
		
	End Sub

	Private Sub Form_LostFocus() Handles MyBase.LostFocus
		If FORMtagg = "1" Then  'server
			ServerFRM.DestroyerLBL.BackColor = Color.Navy : ServerFRM.DestroyerLBL.ForeColor = Color.White : ServerFRM.SubMarineLBL.BackColor = Color.Navy : ServerFRM.SubMarineLBL.ForeColor = Color.White : ServerFRM.CarrierLBL.BackColor = Color.Navy : ServerFRM.CarrierLBL.ForeColor = Color.White : ServerFRM.battleshipLBL.BackColor = Color.Navy : ServerFRM.battleshipLBL.ForeColor = Color.White : ServerFRM.CruiserLBL.BackColor = Color.Navy : ServerFRM.CruiserLBL.ForeColor = Color.White : Unload6(Me)
			 Else 'client
			ClientFRM.DestroyerLBL.BackColor = Color.Navy : ClientFRM.DestroyerLBL.ForeColor = Color.White : ClientFRM.SubMarineLBL.BackColor = Color.Navy : ClientFRM.SubMarineLBL.ForeColor = Color.White : ClientFRM.CarrierLBL.BackColor = Color.Navy : ClientFRM.CarrierLBL.ForeColor = Color.White : ClientFRM.battleshipLBL.BackColor = Color.Navy : ClientFRM.battleshipLBL.ForeColor = Color.White : ClientFRM.CruiserLBL.BackColor = Color.Navy : ClientFRM.CruiserLBL.ForeColor = Color.White : Unload6(Me)
		End If
		
	End Sub

	Private Sub leftTOrightLBL_Click() Handles leftTOrightLBL.Click
		' UPGRADE_INFO (#0561): The 'f' symbol was defined without an explicit "As" clause.
		Dim f As Object = Nothing
		If FORMtagg = "1" Then  'server
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
			For f = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
				If ServerFRM.Field(f).BackColor.Equals(Color.Navy) Then  'if blue
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
					ServerFRM.Field(f).BackColor = FromOleColor6(&HFFFF%) 'changes to  yellow
				End If
			Next
			WhiCHway = "lr" 'left to right
			' UPGRADE_INFO (#0181): Reference to default form instance 'MenuFRM' was converted to Me keyword.
			Unload6(Me)
			 Else 'client
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
			For f = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
				If ClientFRM.Field(f).BackColor.Equals(Color.Navy) Then  'if blue
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
					ClientFRM.Field(f).BackColor = FromOleColor6(&HFFFF%) 'yellow
				End If
			Next
			WhiCHway = "lr" 'left to right
			' UPGRADE_INFO (#0181): Reference to default form instance 'MenuFRM' was converted to Me keyword.
			Unload6(Me)
		End If

	End Sub

	Private Sub leftTOrightLBL_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles leftTOrightLBL.MouseMove
		leftTOrightLBL.BackStyle = 1
		leftTOrightLBL.BackColor = Color.Blue 
		northTOsouthLBL.BackStyle = 0
		
	End Sub

	Private Sub northTOsouthLBL_Click() Handles northTOsouthLBL.Click
		' UPGRADE_INFO (#0561): The 'f' symbol was defined without an explicit "As" clause.
		Dim f As Object = Nothing
		If FORMtagg = "1" Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
			For f = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
				If ServerFRM.Field(f).BackColor.Equals(Color.Navy) Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
					ServerFRM.Field(f).BackColor = FromOleColor6(&HFFFF%)
				End If
			Next
			WhiCHway = "ns"
			
			' UPGRADE_INFO (#0181): Reference to default form instance 'MenuFRM' was converted to Me keyword.
			Unload6(Me)
		Else
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
			For f = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
				If ClientFRM.Field(f).BackColor.Equals(Color.Navy) Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
					ClientFRM.Field(f).BackColor = FromOleColor6(&HFFFF%)
				End If
			Next
			WhiCHway = "ns"
			
			' UPGRADE_INFO (#0181): Reference to default form instance 'MenuFRM' was converted to Me keyword.
			Unload6(Me)
		End If

	End Sub

	Private Sub northTOsouthLBL_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles northTOsouthLBL.MouseMove
		northTOsouthLBL.BackStyle = 1
		northTOsouthLBL.BackColor = Color.Blue 
		leftTOrightLBL.BackStyle = 0
		
	End Sub

End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	'--##DefaultMemberSupport False

	Public Sub ChangeTab(ByRef SSTab As VB6SSTab)
	' UPGRADE_INFO (#0551): The 'SSTab' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'--##SSTab.UseByVal Yes
		Dim ctrl As Object = Nothing
		Dim TabIndex As Integer = 99999
		
		' A very high value.
		
		On Error Resume Next 
		
		For Each ctrl In SSTab.Parent.Controls
			If ctrl.Container Is SSTab Then 
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ctrl.Left'. Consider using the GetDefaultMember6 helper method.
				If ctrl.Left < -10000 Then 
					ctrl.Enabled = False
				Else
					ctrl.Enabled = True
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ctrl.TabIndex'. Consider using the GetDefaultMember6 helper method.
					If ctrl.TabIndex >= TabIndex Then 
						' this control comes after our best candidate or
						' ctrl doesn't support the TabIndex property.
					Else
						' This is the best candidate to get the focus (so far).
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ctrl.TabIndex'. Consider using the GetDefaultMember6 helper method.
						TabIndex = ctrl.TabIndex
						' (Next statement may fail with a few controls (e.g. Labels)
						CObj(ctrl).SetFocus
					End If
				End If
			End If
		Next
	End Sub

End Module

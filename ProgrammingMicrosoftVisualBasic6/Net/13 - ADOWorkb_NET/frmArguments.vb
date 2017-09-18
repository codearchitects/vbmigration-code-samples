' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmArguments

	Private ArgInfo(5) As Object
	Private ArgCount As Short
	
	Private RunPressed As Boolean
	
	' Display the dialog, return True if RUN button is clicked.
	' Values of arguments are returned in the args() array.
	' Expects the name of values - if an argument name is preceded
	' by a "@" character, it is considered as an optional argument
	' Fields are initialized with the values in args()
	
	Public Function GetArgValues(ByRef MethodName As String, ByRef args() As Object, ByVal ParamArray argNames() As Object) As Boolean
		Dim index As Short
		Dim ArgCount As Short
		
		ArgCount = UBound6(argNames)
		
		For index = 0 To ArgCount
			If VB.Left(argNames(index), 1) = "@" Then 
				lblArgName(index).Caption = Mid(argNames(index), 2)
				chkMissing(index).Value = VBRUN.CheckBoxConstants.vbChecked
				txtArgument(index).Enabled = False
				txtArgument(index).BackColor = SystemColors.InactiveBorder 
			Else
				lblArgName(index).Caption = argNames(index)
				chkMissing(index).Visible = False
			End If
			If Not IsEmpty6(args(index)) Then 
				txtArgument(index).Text = args(index)
			End If
		Next
		
		If ArgCount < lblArgName.UBound() Then 
			
			For index = ArgCount + 1 To lblArgName.UBound()
				lblArgName(index).Visible = False
				txtArgument(index).Visible = False
				chkMissing(index).Visible = False
			Next
			
			cmdRun.Top = lblArgName(ArgCount + 1).Top
			cmdCancel.Top = lblArgName(ArgCount + 1).Top
			Me.Height = cmdRun.Top + cmdRun.Height + 600
		End If
		
		If Len6(MethodName) Then 
			Caption = Caption & " - " & MethodName
		End If
		
		Me.Show(VBRUN.FormShowConstants.vbModal)
		
		If RunPressed Then 
			For index = 0 To ArgCount
				If chkMissing(index).Value = VBRUN.CheckBoxConstants.vbUnchecked Then 
					args(index) = txtArgument(index).Text
				Else
					args(index) = IsMissingValue()
				End If
			Next
			' return True to indicate that RUN was clicked
			GetArgValues = True
		End If
		
		Unload6(Me)
		
	End Function

	Private Sub chkMissing_Click(ByRef index As Short)
		If chkMissing(index).Value Then 
			txtArgument(index).Enabled = False
			txtArgument(index).BackColor = SystemColors.InactiveBorder 
		Else
			txtArgument(index).Enabled = True
			txtArgument(index).BackColor = SystemColors.Window 
		End If
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		Hide()
	End Sub

	Private Sub cmdRun_Click() Handles cmdRun.Click
		RunPressed = True
		Hide()
	End Sub

	Private Function IsMissingValue(Optional ByRef dontPassThis As Object = VB6Missing) As Object
		Return dontPassThis
	End Function

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmCalcu

	Private tama As Boolean
	Private firstnum As Double
	Private secondnum As Double
	Private sign As String = ""
	Private memory As Double
	Private memrelease As Boolean
	
	Private Sub cmdCancel_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			'if any other button has been click
			'except for the numbers
			'dont do anything
			If tama = True Then  Exit Sub
			'make sure that the last number be equal to 0
			If Len6(txtDisplay.Text) = 1 Then 
				txtDisplay.Text = "0"
				cmdEqual.SetFocus()
				Exit Sub
			End If
			'erase the last inputed number
			On Error Resume Next 
			txtDisplay.Text = Mid(txtDisplay.Text, 1, Len6(txtDisplay.Text) - 1)
			cmdEqual.SetFocus()
		Case 1
			'make firstnum and secondnum equal to 0
			'so that every operation will be equal to 0
			firstnum = 0
			secondnum = 0
			txtDisplay.Text = "0"
			cmdEqual.SetFocus()
		Case 2
			'clear display and set text to 0
			txtDisplay.Text = "0"
			cmdEqual.SetFocus()
		End Select
		cmdEqual.SetFocus()

	End Sub

	Private Sub cmdDot_Click() Handles cmdDot.Click
		
		'determine if period is already present
		If tama = False Then  'equal sign was not click
			'already present exit
			If InStr(txtDisplay.Text, ".") Then 
				cmdEqual.SetFocus()
				Exit Sub
			End If
			'not present append
			cmdEqual.SetFocus()
			txtDisplay.AppendText(cmdDot.Caption)
		ElseIf tama = True Then  'equal sign was click
			txtDisplay.Text = "0."
			tama = False
			cmdEqual.SetFocus()
		End If
		cmdEqual.SetFocus()
	End Sub

	Private Sub cmdEqual_Click() Handles cmdEqual.Click
		Dim answer As Double
		secondnum = Val(txtDisplay.Text) 'store the second variable
		On Error GoTo errhandler 
		'perform operation
		If sign = "+" Then  answer = firstnum + secondnum
		If sign = "-" Then  answer = firstnum - secondnum
		If sign = "*" Then  answer = firstnum * secondnum
		If sign = "/" And secondnum <> 0 Then  answer = firstnum / secondnum
		txtDisplay.Text = answer
		tama = True
		firstnum = answer
		Exit Sub
errhandler:
		txtDisplay.Text = "Error"
		MsgBox6(Err.Description, MsgBoxStyle.Critical, "Operation Aborted")
		tama = True
	End Sub

	Private Sub cmdEqual_KeyPress(ByRef KeyAscii As Short) Handles cmdEqual.KeyPress
		'this is for the operator
		For x = 0 To 3
			If Chr6(KeyAscii) = [operator](x).Caption Then 
				[operator](x).SetFocus()
				operator_Click((x))
			End If
		Next
		
		'this is for the period
		If Chr6(KeyAscii) = "." Then 
			cmdDot.SetFocus()
			cmdDot_Click()
		End If
		
		'this is for the numbers
		If VB.Left(txtDisplay.Text, 1) = "0" Then 
			'if there is already a period
			If InStr(txtDisplay.Text, ".") Then 
				'append digits and exit so that
				'it wont append twice
				For i = 48 To 57
					'simulate a press of numbers
					If KeyAscii = i Then  'ascii = 0 to 9
						numero(Chr6(KeyAscii)).SetFocus()
						numero_Click((Chr6(KeyAscii)))
						Exit Sub
					End If
				Next
			Else
				'else dont put anything
				txtDisplay.Text = ""
			End If
		End If
		'simulate a press of numbers
		For i = 48 To 57 'ascii = 0 to 9
			If KeyAscii = i Then 
				numero(Chr6(KeyAscii)).SetFocus()
				numero_Click((Chr6(KeyAscii)))
				Exit Sub
			End If
		Next
		
		'this is for the cancel
		If Val(KeyAscii) = &H8 Then 
			cmdCancel(0).SetFocus()
			cmdCancel_Click((0))
		End If

	End Sub

	Private Sub cmdFunction_Click(ByRef Index As Short)
		Select Case Index
		Case 0 'case positve to negative
			txtDisplay.Text = -Val(txtDisplay.Text)
		Case 1 'case 1/x
			If Val(txtDisplay.Text) <> 0 Then  txtDisplay.Text = 1 / Val(txtDisplay.Text)
		Case 2 'case percentage
			txtDisplay.Text = firstnum * Val("." & txtDisplay.Text)
		Case 3 ' case squareroot
			If Val(txtDisplay.Text) = 0 Then 
				txtDisplay.Text = "Error"
				Exit Sub
			Else
				txtDisplay.Text = Math.Sqrt(Val(txtDisplay.Text))
			End If
		End Select
	End Sub

	Private Sub cmdMemory_Click(ByRef Index As Short)
		Select Case Index
		Case 0 ' clear memory (MC)
			memory = 0
			lblMem.Caption = ""
		Case 1 ' add number to memory (M+)
			If txtDisplay.Text = "0" Then  Exit Sub
			memory += Val(txtDisplay.Text)
			lblMem.Caption = "M"
		Case 2 ' get value of memory (MC)
			If txtDisplay.Text = "0" Then  Exit Sub
			'if operator are click release value of memory
			If memrelease = True Then 
				lblMem.Caption = ""
				memory = 0
				'if numbers are click get value of memory
			ElseIf memrelease = False Then 
				lblMem.Caption = "M"
				memory = txtDisplay.Text
			End If
		Case 3 'get value of memory (MR)
			txtDisplay.Text = memory
		End Select
	End Sub

	Private Sub numero_Click(ByRef Index As Short)
		memrelease = False 'toggle the memory
		If tama Then  'toggle the answer
			txtDisplay.Text = ""
			tama = False
		End If
		'determine if the first digit is zero
		If VB.Left(txtDisplay.Text, 1) = "0" Then 
			'if there is already a period
			If InStr(txtDisplay.Text, ".") Then 
				'append digits and exit so that
				'it wont append twice
				txtDisplay.AppendText(numero(Index).Caption)
				cmdEqual.SetFocus()
				Exit Sub
			Else
				'else dont put anything
				txtDisplay.Text = ""
				cmdEqual.SetFocus()
			End If
		End If
		'if first digit is zero
		'erase 0 and append digits
		txtDisplay.AppendText(numero(Index).Caption)
		cmdEqual.SetFocus()
	End Sub

	Private Sub operator_Click(ByRef Index As Short)
		memrelease = True 'toggle memory
		firstnum = Val(txtDisplay.Text) 'store value txtdisplay.text to variable
		'store operations to variable
		Select Case Index
		Case 0
			sign = "/"
		Case 1
			sign = "+"
		Case 2
			sign = "-"
		Case 3
			sign = "*"
		End Select
		tama = True 'toggle answer
		cmdEqual.SetFocus()
	End Sub

End Class

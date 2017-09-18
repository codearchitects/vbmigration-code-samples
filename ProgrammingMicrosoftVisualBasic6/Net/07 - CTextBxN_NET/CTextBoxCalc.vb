' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CTextBoxCalc

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------------------------
	' The CTextBoxNum Class module
	'----------------------------------------------

	Public TextBox As VB6TextBox
	Public FormatMask As String = ""
	
	' we can trap events from max 5 textbox controls
	Private WithEvents Text1 As VB6TextBox
	Private WithEvents Text2 As VB6TextBox
	Private WithEvents Text3 As VB6TextBox
	Private WithEvents Text4 As VB6TextBox
	Private WithEvents Text5 As VB6TextBox
	Private expression As VB6Array(Of Object)
	
	Public Sub SetExpression(ByVal ParamArray args() As Object)
		Dim i As Short
		Dim n As Short
		Redim6(expression, LBound6(args), UBound6(args))
		For i = LBound6(args) To UBound6(args)
			If IsObject6(args(i)) Then 
				' object must be stored as such, using Set
				expression(i) = args(i)
				If TypeName6(args(i)) = "TextBox" Then 
					n += 1
					If n = 1 Then  Text1 = args(i)
					If n = 2 Then  Text2 = args(i)
					If n = 3 Then  Text3 = args(i)
					If n = 4 Then  Text4 = args(i)
					If n = 5 Then  Text5 = args(i)
				End If
			Else
				' store number and strings without Set keyword
				expression(i) = args(i)
			End If
		Next
	End Sub

	Public Sub EvalExpression()
		Dim i As Short
		Dim opcode As Object = Nothing
		Dim value As Object = Nothing
		Dim operand As Object = Nothing
		Const VB6Empty As Object = Nothing
		
		On Error GoTo Error_Handler 
		
		For i = LBound6(expression) To UBound6(expression)
			If Not IsObject6(expression(i)) And VarType6(expression(i)) = VariantType.String Then 
				opcode = expression(i)
			Else
				' this works with number and Text (default) property alike
				operand = CDbl(GetDefaultMember6(expression(i)))
				Select Case opcode
				Case VB6Empty: value = operand
				Case "+": value += operand
				Case "-": value -= operand
				Case "*": value *= operand
				Case "/": value /= operand
				End Select
				'opcode = Nothing
			End If
		Next
		If Len6(FormatMask) Then  value = Format6(value, FormatMask)
		TextBox.Text = value
		Exit Sub
		
Error_Handler:
		TextBox.Text = ""
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		EvalExpression()
	End Sub

	Private Sub Text2_Change() Handles Text2.Change
		EvalExpression()
	End Sub

	Private Sub Text3_Change() Handles Text3.Change
		EvalExpression()
	End Sub

	Private Sub Text4_Change() Handles Text4.Change
		EvalExpression()
	End Sub

	Private Sub Text5_Change() Handles Text5.Change
		EvalExpression()
	End Sub

End Class

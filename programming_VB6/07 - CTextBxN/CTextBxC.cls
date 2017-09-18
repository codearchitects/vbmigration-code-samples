VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CTextBoxCalc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------------------------
' The CTextBoxNum Class module
'----------------------------------------------

Option Explicit

Public TextBox As TextBox
Public FormatMask As String

' we can trap events from max 5 textbox controls
Private WithEvents Text1 As TextBox
Attribute Text1.VB_VarHelpID = -1
Private WithEvents Text2 As TextBox
Attribute Text2.VB_VarHelpID = -1
Private WithEvents Text3 As TextBox
Attribute Text3.VB_VarHelpID = -1
Private WithEvents Text4 As TextBox
Attribute Text4.VB_VarHelpID = -1
Private WithEvents Text5 As TextBox
Attribute Text5.VB_VarHelpID = -1

'## expression.ArrayBounds ForceVB6Array
Dim expression() As Variant

Sub SetExpression(ParamArray args() As Variant)
    Dim i As Integer, n As Integer
    ReDim expression(LBound(args) To UBound(args)) As Variant
    For i = LBound(args) To UBound(args)
        If IsObject(args(i)) Then
            ' object must be stored as such, using Set
            Set expression(i) = args(i)
            If TypeName(args(i)) = "TextBox" Then
                n = n + 1
                If n = 1 Then Set Text1 = args(i)
                If n = 2 Then Set Text2 = args(i)
                If n = 3 Then Set Text3 = args(i)
                If n = 4 Then Set Text4 = args(i)
                If n = 5 Then Set Text5 = args(i)
            End If
        Else
            ' store number and strings without Set keyword
            expression(i) = args(i)
        End If
    Next
End Sub

Sub EvalExpression()
    '## DefaultMemberSupport False
    Dim i As Integer, opcode As Variant
    Dim value As Variant, operand As Variant
   '## InsertStatement Const VB6Empty As Object = Nothing
    
    On Error GoTo Error_Handler
    
    For i = LBound(expression) To UBound(expression)
        If Not IsObject(expression(i)) And VarType(expression(i)) = vbString Then
            opcode = expression(i)
        Else
            ' this works with number and Text (default) property alike
            '##ReplaceStatement operand = CDbl(GetDefaultMember6(expression(i)))
            operand = CDbl(expression(i))
            Select Case opcode
                Case Empty: value = operand
                Case "+": value = value + operand
                Case "-": value = value - operand
                Case "*": value = value * operand
                Case "/": value = value / operand
            End Select
            '##REM Commented out: it generates an error at runtime
            'opcode = Nothing
        End If
    Next
    If Len(FormatMask) Then value = Format$(value, FormatMask)
    TextBox.Text = value
    Exit Sub
    
Error_Handler:
    TextBox.Text = ""
End Sub


Private Sub Text1_Change()
    EvalExpression
End Sub

Private Sub Text2_Change()
    EvalExpression
End Sub

Private Sub Text3_Change()
    EvalExpression
End Sub

Private Sub Text4_Change()
    EvalExpression
End Sub

Private Sub Text5_Change()
    EvalExpression
End Sub

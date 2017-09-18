' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

'This is the part to be improved - I mean this error-handling
Public Enum EvalError
	ERR_NONE = 0
	ERR_DBL_POINT = 1
	ERR_WRONG_SYNTAX = 2
	ERR_WRONG_SIGN = 4
	ERR_WRONG_BRACKETS = 8
	ERR_WRONG_FUNCTION = 16
End Enum

Friend Class Evaluator

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'Copyright© 1999, Tretyakov Konstantin
	'_____________________________________________________
	'This is the 'Evaluator' class: it inputs a string
	'like "2+2" or "2+4*sin(3.4)^2-8*arccos(0.55)", etc
	'_____________________________________________________
	'You may use the code for free, if you give me credit.
	'If you modify it or make your own program with it,
	'I would VERY APPRECIATE, if you mail me it (or better-
	'a link to it)
	'On the whole - just do not stamp your name on what you haven't
	'done quite alone.
	'This code was written totally by me, and 'it took me about
	'2 days to code it (and about a year
	'-that is,from the very moment I got interested in programming-
	'I spent dreaming of having such a thing)
	
	'(BTW this code seems to be quite unique-
	'I searched all over the Internet for such, but NOONE
	'is giving the source for such things)
	'______________________________________________________
	'Yours Sincerely, Konstantin Tretyakov (kt_ee@yahoo.com)
	
	'********************Here we go...********************
	'Well, at the very beginning (when I had only + and -)
	'These constants didplay a role
	'e.g. I could change the PLUS_SIGN to "plus"
	'and the MINUS_SIGN to "minus", so that I could
	'write an expression like "1 plus 2 minus 3"
	'But now it will not go. :(
	Private Const PLUS_SIGN As String = "+"
	Private Const MINUS_SIGN As String = "-"
	Private Const MULTIPLY_SIGN As String = "*"
	Private Const DIVIDE_SIGN As String = "/"
	Private Const POWER_SIGN As String = "^"
	Private Const POINT_SIGN As String = ","
	Private Const BRACKET_LEFT As String = "("
	Private Const BRACKET_RIGHT As String = ")"
	
	'This entry was needed for my other project - Function Analyzer
	'(look for it at the same place, where you found this one)
	Private m_Assigned As Boolean
	'I hope you get, what these do
	Private m_Expression As String = ""
	Private m_Result As Double
	Private m_Error As EvalError
	
	Public Property Expression() As String
		Get
			Return m_Expression
	 	End Get
		Set(ByVal NewExpr As String)
			m_Expression = ReplaceText(UCase(RemoveSpaces(NewExpr)), ".", POINT_SIGN)
	 	End Set
	End Property

	Public ReadOnly Property [Error]() As EvalError
		Get
			Return m_Error
	 	End Get
	End Property

	Public ReadOnly Property Result() As Double
		Get
			'Reset the Error
			m_Error = EvalError.ERR_NONE
			'Calculate
			m_Result = Eval(m_Expression)
			m_Assigned = (m_Error = EvalError.ERR_NONE)
			'Return
			Return m_Result
	 	End Get
	End Property

	Public ReadOnly Property Assigned() As Boolean
		Get
			Return m_Assigned
	 	End Get
	End Property

	Public Function Evaluate(ByVal Expressn As String, Optional ByVal Silent As Boolean = False) As Double
		'That's the wrapper for the main procedure
		'You may use this class in 2 ways
		'1) Set the 'Expression' property and then read the 'Result' property
		'2) Call this sub. If you set Silent to False, then the sub will generate a message automatically
		Dim Res As Double
		Expression = Expressn
		Res = Result
		If Not Silent Then 
			If m_Error <> EvalError.ERR_NONE Then 
				Select Case m_Error
				Case EvalError.ERR_DBL_POINT: MsgBox6("Error: Wrong decimal separator placement!", MsgBoxStyle.Critical, "Eval Error")
				Case EvalError.ERR_WRONG_BRACKETS: MsgBox6("Error: Wrong bracket placement!", MsgBoxStyle.Critical, "Eval Error")
				Case EvalError.ERR_WRONG_SIGN: MsgBox6("Error: Wrong sign or bracket placement!", MsgBoxStyle.Critical, "Eval Error")
				Case EvalError.ERR_WRONG_SYNTAX: MsgBox6("Error: Wrong syntax!", MsgBoxStyle.Critical, "Eval Error")
				End Select
			Else
				MsgBox6("Result: " & Res, MsgBoxStyle.Exclamation, "Eval Result")
			End If
		End If
		Return m_Result
	End Function

	'***********************************************************
	' 2 helper functions, well they are too 'universal' for this class
	' (Here we use them only to remove spaces and replace the '.' to ','
	
	Private Function RemoveSpaces(ByRef S As String) As String
		Return ReplaceText(S)
	End Function

	Public Function ReplaceText(ByVal SourceText As String, Optional ByVal StrToReplace As String = " ", Optional ByVal StrToInsert As String = "") As String
		Dim RetS As String = ""
		Dim I As Short
		If StrToReplace = StrToInsert Or StrToReplace = "" Then  Exit Function
		RetS = SourceText
		I = InStr(RetS, StrToReplace)
		Do While I <> 0
			RetS = IIf(I = 1, "", VB.Left(RetS, I - 1)) & StrToInsert & IIf(I = Len6(RetS) - Len6(StrToReplace) + 1, "", VB.Right(RetS, Len6(RetS) - I - Len6(StrToReplace) + 1))
			I = InStr(RetS, StrToReplace)
		Loop
		Return RetS
	End Function
	
	'***********************************************************
	
	'The HEART of the class.
	'What it does? - it just splits the expression to monomials
	'(that is: 2*3+3^(3-2)-(2+3) has 3 monomials
	'      +2*3,  +3^(3-2)  -(2+3)
	'Then it calls the CalcMonomial for each and sums the result
	
	Private Function Eval(ByVal Expr As String) As Double
		Dim sEval As String = ""
		Dim I As Integer
		Dim MonomArray As Object = Nothing
		Dim dResult As Double
		sEval = Expr
		MonomArray = SplitToMonomials(sEval)
		For I = LBound6(MonomArray) To UBound6(MonomArray)
			dResult += CalcMonomial(MonomArray(I))
		Next
		Return dResult
	End Function

	Private Function SplitToMonomials(ByVal EvalStr As String, Optional ByVal Sign1 As String = PLUS_SIGN, Optional ByVal Sign2 As String = MINUS_SIGN) As Object
		'Divides the given string in parts using the given sign (Sign1 and Sign2) parameter
		
		'Returns an array where each item is a string
		'For example SplitToMonomials("2+3*8-4","+","-") returns [2, +3*8, -4]
		'        and SplitToMonomials("3*2/23","*","/") returns [3, *2, /23]
		
		'The function also doesn't split brackets so that
		'      SplitToMonominals("(3+2)*2-3","+","-") will return [(3+2)*2, -3]
		
		Dim MonomArray As Object = Nothing
		Dim I As Integer
		Dim Count As Integer
		Dim CurMonom As String = ""
		Dim sEval As String = ""
		ReDim MonomArray(0)
		sEval = EvalStr
		'Find the first PLUS or MINUS (MUL or DIV) that are not in Bracket
		'(GetSplitPos is Just an Improved Instr, that considers brackets)
		I = GetSplitPos(EvalStr, Sign1, Sign2)
		Do While I > 0
			'NOT DONE
			'Check for expressions of a kind: "2-3*4+6*-5"
			'because we must not split between 6 and 5
			CurMonom = VB.Left(sEval, I - 1)
			'Populate the Array
			ReDim Preserve MonomArray(Count)
			MonomArray(Count) = CurMonom
			Count += 1
			sEval = Mid(sEval, I)
			I = GetSplitPos(sEval, Sign1, Sign2)
		Loop
		
		CurMonom = sEval
		ReDim Preserve MonomArray(Count)
		MonomArray(Count) = CurMonom
		Return MonomArray
	End Function

	'Calculates a monomial (expression without PLUSes and MINUSes inside)
	'The work is in fact like of the Eval function
	'We split it to smaller parts (the ones, that may contain only the ^ sign)
	'and then Calculate each part separately
	Private Function CalcMonomial(ByVal Monomial As String) As Double
		On Error GoTo ErrCalcMember 
		If m_Error <> EvalError.ERR_NONE Then  Exit Function
		Dim MemberArray As Object = Nothing
		Dim Sign As String = ""
		Dim I As Integer
		Dim dResult As Double
		Dim TempRes As Double
		'Split again, but now by * and /
		MemberArray = SplitToMonomials(Monomial, MULTIPLY_SIGN, DIVIDE_SIGN)
		For I = LBound6(MemberArray) To UBound6(MemberArray)
			TempRes = CalcMember(MemberArray(I), Sign)
			Select Case Sign
				'Remember - we may have the Plus_sign left in a monomial
				'(like a monomial may be "+2^2*3")
			Case PLUS_SIGN: dResult += TempRes
			Case MULTIPLY_SIGN: dResult *= TempRes
			Case DIVIDE_SIGN: dResult /= TempRes
			End Select
		Next
		Return dResult
ErrCalcMember:
		m_Error = EvalError.ERR_WRONG_FUNCTION
	End Function

	'Calculates an expression, that contains only the operands
	'higher in proirity than * and /
	
	'TODO: It raises an error on X^Y^Z and calculates only X^Y,
	'That is, for correct calculation you must specify either (X^Y)^Z
	'or X^(Y^Z) (btw which is right ???)
	Private Function CalcMember(ByVal Member As String, ByRef Sign As String) As Double
		Dim sSign As String = ""
		Dim sEval As String = ""
		Dim HaveMinus As Boolean
		Dim GotNum1 As Boolean
		Dim Num1 As Double
		Dim Num2 As Double
		Dim Op As String = ""
		Dim dResult As Double
		Dim Func As String = ""
		Dim FuncExpr As String = ""
		If m_Error <> EvalError.ERR_NONE Then  Exit Function
		'Here we calculate the results of operations
		'whose priority is higher than * and /
		'The sample given string may be: "+5^2", "*4^2", "/6", "6^2,3"
		'or +(expr)^2, or (expr)^(expr)
		Sign = PLUS_SIGN
		sEval = Member
		sSign = VB.Left(sEval, 1)
		'Determine the Sign (or find the Bracket or a function)
		If Not IsNumeric6(sSign) Then 
			Select Case sSign
			Case MINUS_SIGN
				HaveMinus = True
				sEval = Mid(sEval, 2)
				If VB.Left(sEval, 1) = BRACKET_LEFT Then  GoTo LBrack
				If IsNumeric6(VB.Left(sEval, 1)) = False Then  GoTo HaveFunc
			Case PLUS_SIGN, MULTIPLY_SIGN, DIVIDE_SIGN
				Sign = sSign
				sEval = Mid(sEval, 2)
				If VB.Left(sEval, 1) = BRACKET_LEFT Then  GoTo LBrack
				If IsNumeric6(VB.Left(sEval, 1)) = False Then  GoTo HaveFunc
			Case BRACKET_LEFT
LBrack:
				'That's easy - when we find a bracket - we just 'Eval' the expression in the brackets
				Num1 = Eval(ExtractBrackets(sEval))
				GotNum1 = True
			Case Else
				'Here Must make some checks for Functions (like when it's SIN(expr))
HaveFunc:
				Func = ExtractFunction(sEval, FuncExpr)
				Num1 = CalcFunction(Func, FuncExpr)
				GotNum1 = True
			End Select
		End If
		'Now Do the Calculation
		If Not GotNum1 Then  Num1 = ExtractNumber(sEval)
		If Len6(sEval) <> 0 Then 
			Op = VB.Left(sEval, 1)
			sEval = Mid(sEval, 2)
			'Check if the second number is a bracketed expression
			If VB.Left(sEval, 1) = BRACKET_LEFT Then 
				Num2 = Eval(ExtractBrackets(sEval))
			Else
				If IsNumeric6(VB.Left(sEval, 1)) = False Then 
					Func = ExtractFunction(sEval, FuncExpr)
					Num2 = CalcFunction(Func, FuncExpr)
				Else
					Num2 = ExtractNumber(sEval)
				End If
			End If
			Select Case Op
			Case POWER_SIGN
				On Error GoTo ErrCalcMember 
				dResult = Num1 ^ Num2
			Case Else
				m_Error = EvalError.ERR_WRONG_SIGN
			End Select
		Else
			dResult = Num1
		End If
		If Len6(sEval) <> 0 Then  m_Error = EvalError.ERR_WRONG_SYNTAX
		Return IIf(HaveMinus, -dResult, dResult)
ErrCalcMember:
		m_Error = EvalError.ERR_WRONG_FUNCTION
	End Function

	'***********************************************************
	'This is nearly an equivalent of VAL,
	'only here we may know if there was an error
	'and it also modifies the string by removing the "Extracted" number
	
	'TODO: It doesn't support the "2.34E+2" notation
	Private Function ExtractNumber(ByRef EvalExpr As String) As Double
		Dim HavePoint As Boolean
		Dim I As Short
		Dim NewNum As String = ""
		Dim TempChar As String = ""
		Dim TempSign As String = ""
		Dim HaveMinus As Boolean
		Dim sEval As String = ""
		'Determine whether there is a sign in front of the string
		TempSign = VB.Left(EvalExpr, 1)
		If TempSign = POINT_SIGN Then 
			sEval = "0" & EvalExpr
		Else
			If Not IsNumeric6(TempSign) Then 
				sEval = Mid(EvalExpr, 2)
				HaveMinus = (TempSign = MINUS_SIGN)
				 Else:
				sEval = EvalExpr
			End If
		End If
		
		For I = 1 To Len6(sEval)
			TempChar = Mid(sEval, I, 1)
			If IsNumeric6(TempChar) Then 
				NewNum &= TempChar
			Else
				If TempChar = POINT_SIGN Then 
					If HavePoint Then 
						'We have already a point, that's an error
						m_Error = EvalError.ERR_DBL_POINT
						Exit For
					Else
						HavePoint = True
						NewNum &= "." 'We shall use val in the end
					End If
				Else
					Exit For
				End If
			End If
		Next
		If NewNum = "" Then 
			m_Error = EvalError.ERR_WRONG_SYNTAX
			 Else 'Cut out the number from the string
			EvalExpr = Mid(sEval, Len6(NewNum) + 1)
		End If
		Return IIf(HaveMinus, -Val(NewNum), Val(NewNum))
	End Function

	'***********************************************************
	'This is a Helper-func to SplitToMonomials
	'it returns the position in a string of a Sign(1 or 2)
	'it doesn't return the signs that are in brackets and the sign on the 1st place
	Private Function GetSplitPos(ByVal EvalStr As String, ByVal Sign1 As String, ByVal Sign2 As String, Optional ByRef StartPos As Short = 1) As Object
		Dim I As Short
		Dim InBracket As Short
		Dim TempChar As String = ""
		
		For I = StartPos To Len6(EvalStr)
			TempChar = Mid(EvalStr, I, 1)
			Select Case TempChar
			Case Sign1, Sign2
				If InBracket = 0 And I > 1 Then 
					Return I
				End If
			Case BRACKET_LEFT
				InBracket += 1
			Case BRACKET_RIGHT
				InBracket -= 1
				If InBracket < 0 Then 
					m_Error = EvalError.ERR_WRONG_BRACKETS
					Exit Function
				End If
			End Select
		Next
	End Function

	'Gets a String, beginning with a Left Bracket and
	'returns the expression in this bracket
	'deletes this expression(with both brackets) from the string
	Private Function ExtractBrackets(ByRef EvalExpr As String) As String
		Dim InBracket As Short = 1
		Dim I As Integer
		Dim TempChar As String = ""
		Dim RetStr As String = ""
		'We Suppose that the first sign in the string is BRACKET_LEFT
		For I = 2 To Len6(EvalExpr)
			TempChar = Mid(EvalExpr, I, 1)
			Select Case TempChar
			Case BRACKET_LEFT
				InBracket += 1
			Case BRACKET_RIGHT
				InBracket -= 1
			End Select
			If InBracket = 0 Then 
				RetStr = Mid(EvalExpr, 2, I - 2)
				EvalExpr = Mid(EvalExpr, I + 1)
				Return RetStr
			End If
		Next
		m_Error = EvalError.ERR_WRONG_BRACKETS
	End Function

	'Process the expression "FUNC(expr)"
	'Returns "FUNC"
	Private Function ExtractFunction(ByRef EvalExpr As String, ByRef FuncExpr As String) As Object
		Dim FuncID As String = ""
		Dim I As Integer
		I = InStr(EvalExpr, BRACKET_LEFT)
		If I = 0 Then 
			m_Error = EvalError.ERR_WRONG_SYNTAX
			Exit Function
		Else
			ExtractFunction = VB.Left(EvalExpr, I - 1)
			EvalExpr = Mid(EvalExpr, I)
			FuncExpr = ExtractBrackets(EvalExpr)
		End If
	End Function

	'You give it a function name and an expression in the brackets after it
	'as 2 separate strings, and it calculates
	'ADD ANY of the Functions you like
	'(E.G. it's interesting to add some 'acting' functions, like, say, MsgBox :)
	'Then there are only several steps towards your own Script-Language
	Private Function CalcFunction(ByVal FunctionID As String, ByVal FuncExpr As String) As Double
		On Error GoTo ErrCalc 
		If m_Error <> EvalError.ERR_NONE Then  Exit Function
		Dim Arg As Double = Eval(FuncExpr)
		Select Case FunctionID
		Case "ABS"
			Return Abs6(Arg)
		Case "ATN"
			Return Math.Atan(Arg)
		Case "COS"
			Return Math.Cos(Arg)
		Case "EXP"
			Return Math.Exp(Arg)
		Case "FIX"
			Return Fix(Arg)
		Case "INT"
			Return Int(Arg)
		Case "LOG"
			Return Math.Log(Arg)
		Case "RND"
			Return Rnd(Arg)
		Case "SGN"
			Return Math.Sign(Arg)
		Case "SIN"
			Return Math.Sin(Arg)
		Case "SQR"
			Return Math.Sqrt(Arg)
		Case "TAN"
			Return Math.Tan(Arg)
			'Derived
		Case "SEC"
			Return 1 / Math.Cos(Arg)
		Case "COSEC"
			Return 1 / Math.Sin(Arg)
		Case "COTAN"
			Return 1 / Math.Tan(Arg)
		Case "ARCSIN"
			Return Math.Atan(Arg / Math.Sqrt(-Arg * Arg + 1))
		Case "ARCCOS"
			Return Math.Atan(-Arg / Math.Sqrt(-Arg * Arg + 1)) + 2 * Math.Atan(1)
		Case "ARCSEC"
			Return Math.Atan(Arg / Math.Sqrt(Arg * Arg - 1)) + Math.Sign(Arg - 1) * (2 * Math.Atan(1))
		Case "ARCCOSEC"
			Return Math.Atan(Arg / Math.Sqrt(Arg * Arg - 1)) + (Math.Sign(Arg) - 1) * (2 * Math.Atan(1))
		Case "ARCCOTAN"
			Return Math.Atan(Arg) + 2 * Math.Atan(1)
		Case "HSIN"
			Return (Math.Exp(Arg) - Math.Exp(-Arg)) / 2
		Case "HCOS"
			Return (Math.Exp(Arg) + Math.Exp(-Arg)) / 2
		Case "HTAN"
			Return (Math.Exp(Arg) - Math.Exp(-Arg)) / (Math.Exp(Arg) + Math.Exp(-Arg))
		Case "HSEC"
			Return 2 / (Math.Exp(Arg) + Math.Exp(-Arg))
		Case "HCOSEC"
			Return 2 / (Math.Exp(Arg) - Math.Exp(-Arg))
		Case "HCOTAN"
			Return (Math.Exp(Arg) + Math.Exp(-Arg)) / (Math.Exp(Arg) - Math.Exp(-Arg))
		Case "HARCSIN"
			Return Math.Log(Arg + Math.Sqrt(Arg * Arg + 1))
		Case "HARCCOS"
			Return Math.Log(Arg + Math.Sqrt(Arg * Arg - 1))
		Case "HARCTAN"
			Return Math.Log((1 + Arg) / (1 - Arg)) / 2
		Case "HARCSEC"
			Return Math.Log((Math.Sqrt(-Arg * Arg + 1) + 1) / Arg)
		Case "HARCCOSEC"
			Return Math.Log((Math.Sign(Arg) * Math.Sqrt(Arg * Arg + 1) + 1) / Arg)
		Case "HARCCOTAN"
			Return Math.Log((Arg + 1) / (Arg - 1)) / 2
			'Not Math functions, but also useful
		Case "TIMER"
			Return Timer6
		Case "YEAR"
			Return Year(Now)
		Case "MONTH"
			Return Month(Now)
		Case "DAY"
			Return VB.Day(Now)
		Case "WEEKDAY"
			Return Weekday(Now)
		Case "HOUR"
			Return Hour(TimeOfDay)
		Case "MINUTE"
			Return Minute(TimeOfDay)
		Case "SECOND"
			Return Second(TimeOfDay)
			'These should be constants, but here you must use them as functions
			'(i.e. with an argument, no matter what)
		Case "PI"
			Return 3.14159265358979
		Case "E"
			Return 2.71828182845905
		Case "ZERO"
			Return 0
		Case Else
			m_Error = EvalError.ERR_WRONG_SYNTAX
		End Select
		Exit Function
ErrCalc:
		m_Error = EvalError.ERR_WRONG_FUNCTION
	End Function

End Class

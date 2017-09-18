VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Evaluator"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
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
'These constants didplay a role:
'e.g. I could change the PLUS_SIGN to "plus"
'and the MINUS_SIGN to "minus", so that I could
'write an expression like "1 plus 2 minus 3"
'But now it will not go. :(
Const PLUS_SIGN = "+"
Const MINUS_SIGN = "-"
Const MULTIPLY_SIGN = "*"
Const DIVIDE_SIGN = "/"
Const POWER_SIGN = "^"
Const POINT_SIGN = ","
Const BRACKET_LEFT = "("
Const BRACKET_RIGHT = ")"

'This is the part to be improved - I mean this error-handling
Public Enum EvalError
    ERR_NONE = 0
    ERR_DBL_POINT = 1
    ERR_WRONG_SYNTAX = 2
    ERR_WRONG_SIGN = 4
    ERR_WRONG_BRACKETS = 8
    ERR_WRONG_FUNCTION = 16
End Enum

'This entry was needed for my other project - Function Analyzer
'(look for it at the same place, where you found this one)
Private m_Assigned As Boolean
'I hope you get, what these do
Private m_Expression As String
Private m_Result As Double
Private m_Error As EvalError

Public Property Let Expression(ByVal NewExpr As String)
    m_Expression = ReplaceText(UCase(RemoveSpaces(NewExpr)), ".", POINT_SIGN)
End Property
Public Property Get Expression() As String
    Expression = m_Expression
End Property
Public Property Get Error() As EvalError
    Error = m_Error
End Property

Public Property Get Result() As Double
'Reset the Error
    m_Error = ERR_NONE
'Calculate
    m_Result = Eval(m_Expression)
    m_Assigned = (m_Error = ERR_NONE)
'Return
    Result = m_Result
End Property
Public Property Get Assigned() As Boolean
    Assigned = m_Assigned
End Property
Public Function Evaluate(ByVal Expressn As String, Optional ByVal Silent As Boolean = False) As Double
'That's the wrapper for the main procedure
'You may use this class in 2 ways:
'1) Set the 'Expression' property and then read the 'Result' property
'2) Call this sub. If you set Silent to False, then the sub will generate a message automatically
    Dim Res As Double
    Expression = Expressn
    Res = Result
    If Not Silent Then
        If m_Error <> ERR_NONE Then
            Select Case m_Error
                Case ERR_DBL_POINT:  MsgBox "Error: Wrong decimal separator placement!", vbCritical, "Eval Error"
                Case ERR_WRONG_BRACKETS: MsgBox "Error: Wrong bracket placement!", vbCritical, "Eval Error"
                Case ERR_WRONG_SIGN: MsgBox "Error: Wrong sign or bracket placement!", vbCritical, "Eval Error"
                Case ERR_WRONG_SYNTAX: MsgBox "Error: Wrong syntax!", vbCritical, "Eval Error"
            End Select
        Else
            MsgBox "Result: " & Res, vbExclamation, "Eval Result"
        End If
    End If
    Evaluate = m_Result
End Function

'***********************************************************
' 2 helper functions, well they are too 'universal' for this class
' (Here we use them only to remove spaces and replace the '.' to ','

Private Function RemoveSpaces(S$) As String
    RemoveSpaces = ReplaceText(S$)
End Function

Public Function ReplaceText(ByVal SourceText$, Optional ByVal StrToReplace$ = " ", Optional ByVal StrToInsert$ = "") As String
    Dim RetS$, I%
    If StrToReplace = StrToInsert Or StrToReplace = "" Then Exit Function
    RetS = SourceText$
    I = InStr(RetS, StrToReplace)
    Do While I <> 0
        RetS = IIf(I = 1, "", Left(RetS, I - 1)) & StrToInsert$ & IIf(I = Len(RetS) - Len(StrToReplace) + 1, "", Right(RetS, Len(RetS) - I - Len(StrToReplace) + 1))
        I = InStr(RetS, StrToReplace)
    Loop
    ReplaceText = RetS
End Function
'***********************************************************

'The HEART of the class.
'What it does? - it just splits the expression to monomials
'(that is: 2*3+3^(3-2)-(2+3) has 3 monomials:
'      +2*3,  +3^(3-2)  -(2+3)
'Then it calls the CalcMonomial for each and sums the result

Private Function Eval(ByVal Expr As String) As Double
    Dim sEval$, I&, MonomArray As Variant, dResult As Double
    sEval = Expr
    MonomArray = SplitToMonomials(sEval)
    For I = LBound(MonomArray) To UBound(MonomArray)
        dResult = dResult + CalcMonomial(MonomArray(I))
    Next
    Eval = dResult
End Function



Private Function SplitToMonomials(ByVal EvalStr As String, Optional ByVal Sign1 As String = PLUS_SIGN, Optional ByVal Sign2 As String = MINUS_SIGN) As Variant
'Divides the given string in parts using the given sign (Sign1 and Sign2) parameter

'Returns an array where each item is a string
'For example SplitToMonomials("2+3*8-4","+","-") returns [2, +3*8, -4]
'        and SplitToMonomials("3*2/23","*","/") returns [3, *2, /23]

'The function also doesn't split brackets so that
'      SplitToMonominals("(3+2)*2-3","+","-") will return [(3+2)*2, -3]
                            
    Dim MonomArray As Variant, I&, Count&
    Dim CurMonom As String, sEval As String
    ReDim MonomArray(0)
    sEval = EvalStr
'Find the first PLUS or MINUS (MUL or DIV) that are not in Bracket
'(GetSplitPos is Just an Improved Instr, that considers brackets)
    I = GetSplitPos(EvalStr, Sign1, Sign2)
    Do While I > 0
'NOT DONE:
        'Check for expressions of a kind: "2-3*4+6*-5"
        'because we must not split between 6 and 5
        CurMonom = Left(sEval, I - 1)
'Populate the Array
        ReDim Preserve MonomArray(Count)
        MonomArray(Count) = CurMonom
        Count = Count + 1
        sEval = Mid(sEval, I)
        I = GetSplitPos(sEval, Sign1, Sign2)
    Loop

    CurMonom = sEval
    ReDim Preserve MonomArray(Count)
    MonomArray(Count) = CurMonom
    SplitToMonomials = MonomArray
End Function

'Calculates a monomial (expression without PLUSes and MINUSes inside)
'The work is in fact like of the Eval function:
'We split it to smaller parts (the ones, that may contain only the ^ sign)
'and then Calculate each part separately
Private Function CalcMonomial(ByVal Monomial As String) As Double
    On Error GoTo ErrCalcMember
    If m_Error <> ERR_NONE Then Exit Function
    Dim MemberArray As Variant, Sign As String
    Dim I&, dResult As Double, TempRes As Double
'Split again, but now by * and /
    MemberArray = SplitToMonomials(Monomial, MULTIPLY_SIGN, DIVIDE_SIGN)
    For I = LBound(MemberArray) To UBound(MemberArray)
        TempRes = CalcMember(MemberArray(I), Sign)
        Select Case Sign
'Remember - we may have the Plus_sign left in a monomial
'(like a monomial may be "+2^2*3")
            Case PLUS_SIGN: dResult = dResult + TempRes
            Case MULTIPLY_SIGN: dResult = dResult * TempRes
            Case DIVIDE_SIGN:  dResult = dResult / TempRes
        End Select
    Next
    CalcMonomial = dResult
    Exit Function
ErrCalcMember:
    m_Error = ERR_WRONG_FUNCTION
End Function

'Calculates an expression, that contains only the operands
'higher in proirity than * and /

'TODO: It raises an error on X^Y^Z and calculates only X^Y,
'That is, for correct calculation you must specify either (X^Y)^Z
'or X^(Y^Z) (btw which is right ???)
Private Function CalcMember(ByVal Member As String, ByRef Sign As String) As Double
    Dim sSign As String, sEval As String, HaveMinus As Boolean, GotNum1 As Boolean
    Dim Num1 As Double, Num2 As Double, Op As String, dResult As Double
    Dim Func As String, FuncExpr As String
    If m_Error <> ERR_NONE Then Exit Function
    'Here we calculate the results of operations
    'whose priority is higher than * and /
    'The sample given string may be: "+5^2", "*4^2", "/6", "6^2,3"
                        'or +(expr)^2, or (expr)^(expr)
    Sign = PLUS_SIGN
    sEval = Member
    sSign = Left(sEval, 1)
    'Determine the Sign (or find the Bracket or a function)
    If Not IsNumeric(sSign) Then
        Select Case sSign
            Case MINUS_SIGN
                HaveMinus = True
                sEval = Mid(sEval, 2)
                If Left(sEval, 1) = BRACKET_LEFT Then GoTo LBrack
                If IsNumeric(Left(sEval, 1)) = False Then GoTo HaveFunc
            Case PLUS_SIGN, MULTIPLY_SIGN, DIVIDE_SIGN
                Sign = sSign
                sEval = Mid(sEval, 2)
                If Left(sEval, 1) = BRACKET_LEFT Then GoTo LBrack
                If IsNumeric(Left(sEval, 1)) = False Then GoTo HaveFunc
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
    If Not GotNum1 Then Num1 = ExtractNumber(sEval)
    If Len(sEval) <> 0 Then
        Op = Left(sEval, 1)
        sEval = Mid(sEval, 2)
'Check if the second number is a bracketed expression
        If Left(sEval, 1) = BRACKET_LEFT Then
            Num2 = Eval(ExtractBrackets(sEval))
        Else
            If IsNumeric(Left(sEval, 1)) = False Then
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
                m_Error = ERR_WRONG_SIGN
        End Select
    Else
        dResult = Num1
    End If
    If Len(sEval) <> 0 Then m_Error = ERR_WRONG_SYNTAX
    CalcMember = IIf(HaveMinus, -dResult, dResult)
    Exit Function
ErrCalcMember:
    m_Error = ERR_WRONG_FUNCTION
End Function

'***********************************************************
'This is nearly an equivalent of VAL,
'only here we may know if there was an error
'and it also modifies the string by removing the "Extracted" number

'TODO: It doesn't support the "2.34E+2" notation
Private Function ExtractNumber(ByRef EvalExpr$) As Double
    Dim HavePoint As Boolean, I As Integer, NewNum As String
    Dim TempChar As String, TempSign As String, HaveMinus As Boolean
    Dim sEval As String
'Determine whether there is a sign in front of the string
    TempSign = Left(EvalExpr, 1)
    If TempSign = POINT_SIGN Then
        sEval = "0" & EvalExpr
    Else
        If Not IsNumeric(TempSign) Then
            sEval = Mid(EvalExpr, 2)
            HaveMinus = (TempSign = MINUS_SIGN)
        Else: sEval = EvalExpr
        End If
    End If
    
    For I = 1 To Len(sEval)
        TempChar = Mid(sEval, I, 1)
        If IsNumeric(TempChar) Then
            NewNum = NewNum & TempChar
        Else
            If TempChar = POINT_SIGN Then
                If HavePoint Then
                'We have already a point, that's an error
                    m_Error = ERR_DBL_POINT
                    Exit For
                Else
                    HavePoint = True
                    NewNum = NewNum + "."   'We shall use val in the end
                End If
            Else
                Exit For
            End If
        End If
    Next
    If NewNum = "" Then
        m_Error = ERR_WRONG_SYNTAX
    Else    'Cut out the number from the string
        EvalExpr = Mid(sEval, Len(NewNum) + 1)
    End If
    ExtractNumber = IIf(HaveMinus, -Val(NewNum), Val(NewNum))
End Function


'***********************************************************
'This is a Helper-func to SplitToMonomials
'it returns the position in a string of a Sign(1 or 2)
'it doesn't return the signs that are in brackets and the sign on the 1st place
Private Function GetSplitPos(ByVal EvalStr$, ByVal Sign1$, ByVal Sign2$, Optional StartPos As Integer = 1)
    Dim I%, InBracket%, TempChar$
    
    For I = StartPos To Len(EvalStr$)
        TempChar = Mid(EvalStr, I, 1)
        Select Case TempChar
            Case Sign1, Sign2
                If InBracket = 0 And I > 1 Then
                    GetSplitPos = I
                    Exit Function
                End If
            Case BRACKET_LEFT
                InBracket = InBracket + 1
            Case BRACKET_RIGHT
                InBracket = InBracket - 1
                If InBracket < 0 Then
                    m_Error = ERR_WRONG_BRACKETS
                    Exit Function
                End If
        End Select
    Next
End Function

'Gets a String, beginning with a Left Bracket and
'returns the expression in this bracket
'deletes this expression(with both brackets) from the string
Private Function ExtractBrackets(ByRef EvalExpr As String) As String
    Dim InBracket%, I&, TempChar$, RetStr$
    'We Suppose that the first sign in the string is BRACKET_LEFT
    InBracket = 1
    For I = 2 To Len(EvalExpr)
        TempChar = Mid(EvalExpr, I, 1)
        Select Case TempChar
            Case BRACKET_LEFT
                InBracket = InBracket + 1
            Case BRACKET_RIGHT
                InBracket = InBracket - 1
        End Select
        If InBracket = 0 Then
            RetStr = Mid(EvalExpr, 2, I - 2)
            EvalExpr = Mid(EvalExpr, I + 1)
            ExtractBrackets = RetStr
            Exit Function
        End If
    Next
    m_Error = ERR_WRONG_BRACKETS
End Function

'Process the expression "FUNC(expr)"
'Returns "FUNC"
Private Function ExtractFunction(ByRef EvalExpr As String, ByRef FuncExpr As String)
    Dim FuncID As String, I&
    I = InStr(EvalExpr, BRACKET_LEFT)
    If I = 0 Then
        m_Error = ERR_WRONG_SYNTAX
        Exit Function
    Else
        ExtractFunction = Left(EvalExpr, I - 1)
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
    If m_Error <> ERR_NONE Then Exit Function
    Dim Arg As Double
    Arg = Eval(FuncExpr)
    Select Case FunctionID
        Case "ABS"
            CalcFunction = Abs(Arg)
        Case "ATN"
            CalcFunction = Atn(Arg)
        Case "COS"
            CalcFunction = Cos(Arg)
        Case "EXP"
            CalcFunction = Exp(Arg)
        Case "FIX"
            CalcFunction = Fix(Arg)
        Case "INT"
            CalcFunction = Int(Arg)
        Case "LOG"
            CalcFunction = Log(Arg)
        Case "RND"
            CalcFunction = Rnd(Arg)
        Case "SGN"
            CalcFunction = Sgn(Arg)
        Case "SIN"
            CalcFunction = Sin(Arg)
        Case "SQR"
            CalcFunction = Sqr(Arg)
        Case "TAN"
            CalcFunction = Tan(Arg)
    'Derived
        Case "SEC"
            CalcFunction = 1 / Cos(Arg)
        Case "COSEC"
            CalcFunction = 1 / Sin(Arg)
        Case "COTAN"
            CalcFunction = 1 / Tan(Arg)
        Case "ARCSIN"
            CalcFunction = Atn(Arg / Sqr(-Arg * Arg + 1))
        Case "ARCCOS"
            CalcFunction = Atn(-Arg / Sqr(-Arg * Arg + 1)) + 2 * Atn(1)
        Case "ARCSEC"
            CalcFunction = Atn(Arg / Sqr(Arg * Arg - 1)) + Sgn(Arg - 1) * (2 * Atn(1))
        Case "ARCCOSEC"
            CalcFunction = Atn(Arg / Sqr(Arg * Arg - 1)) + (Sgn(Arg) - 1) * (2 * Atn(1))
        Case "ARCCOTAN"
            CalcFunction = Atn(Arg) + 2 * Atn(1)
        Case "HSIN"
            CalcFunction = (Exp(Arg) - Exp(-Arg)) / 2
        Case "HCOS"
            CalcFunction = (Exp(Arg) + Exp(-Arg)) / 2
        Case "HTAN"
            CalcFunction = (Exp(Arg) - Exp(-Arg)) / (Exp(Arg) + Exp(-Arg))
        Case "HSEC"
            CalcFunction = 2 / (Exp(Arg) + Exp(-Arg))
        Case "HCOSEC"
            CalcFunction = 2 / (Exp(Arg) - Exp(-Arg))
        Case "HCOTAN"
            CalcFunction = (Exp(Arg) + Exp(-Arg)) / (Exp(Arg) - Exp(-Arg))
        Case "HARCSIN"
            CalcFunction = Log(Arg + Sqr(Arg * Arg + 1))
        Case "HARCCOS"
            CalcFunction = Log(Arg + Sqr(Arg * Arg - 1))
        Case "HARCTAN"
            CalcFunction = Log((1 + Arg) / (1 - Arg)) / 2
        Case "HARCSEC"
            CalcFunction = Log((Sqr(-Arg * Arg + 1) + 1) / Arg)
        Case "HARCCOSEC"
            CalcFunction = Log((Sgn(Arg) * Sqr(Arg * Arg + 1) + 1) / Arg)
        Case "HARCCOTAN"
            CalcFunction = Log((Arg + 1) / (Arg - 1)) / 2
'Not Math functions, but also useful
        Case "TIMER"
            CalcFunction = Timer
        Case "YEAR"
            CalcFunction = Year(Now)
        Case "MONTH"
            CalcFunction = Month(Now)
        Case "DAY"
            CalcFunction = Day(Now)
        Case "WEEKDAY"
            CalcFunction = Weekday(Now)
        Case "HOUR"
            CalcFunction = Hour(Time)
        Case "MINUTE"
            CalcFunction = Minute(Time)
        Case "SECOND"
            CalcFunction = Second(Time)
'These should be constants, but here you must use them as functions
'(i.e. with an argument, no matter what)
        Case "PI"
            CalcFunction = 3.14159265358979
        Case "E"
            CalcFunction = 2.71828182845905
        Case "ZERO"
            CalcFunction = 0
        Case Else
            m_Error = ERR_WRONG_SYNTAX
    End Select
 Exit Function
ErrCalc:
 m_Error = ERR_WRONG_FUNCTION
End Function


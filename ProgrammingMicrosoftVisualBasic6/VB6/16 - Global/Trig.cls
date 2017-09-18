VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Trig"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
'---------------------------------------------------------
' TRIG routines
'---------------------------------------------------------

Option Explicit

'-----------------------------------------
' Additional Trig functions
'-----------------------------------------

' Cotangent

Function Cot(Radians As Double) As Double
    Cot = 1 / Tan(Radians)
End Function

' Secant

Function Sec(Radians As Double) As Double
    Sec = 1 / Cos(Radians)
End Function

' Cosecant

Function Csc(Radians As Double) As Double
    Csc = 1 / Sin(Radians)
End Function


'-----------------------------------------
' Inverse Trig functions
'-----------------------------------------

' Arc Sine (error if Number is outside the range [-1,1])

Function ASin(ByVal Number As Double) As Double
Attribute ASin.VB_Description = "Arc Sine (error if Number is outside the range [-1,1])."
    If Abs(Number) <> 1 Then
        ASin = Atn(Number / Sqr(1 - Number * Number))
    Else
        ASin = 1.5707963267949 * Sgn(Number)
    End If
End Function

' Arc Cosine (error if Number is outside the range [-1,1])

Function ACos(ByVal Number As Double) As Double
Attribute ACos.VB_Description = "Arc Cosine (error if Number is outside the range [-1,1])."
    If Abs(Number) <> 1 Then
        ACos = 1.5707963267949 - Atn(Number / Sqr(1 - Number * Number))
    Else
        ACos = 3.14159265358979 * Sgn(Number)
    End If
End Function

' Arc Tangent of Y/X (returns values in all four quadrants).

Function Atn2(x As Double, y As Double) As Double
Attribute Atn2.VB_Description = "Arc tangent of Y/X (returns values in all four quadrants)."
    If x = 0 Then
        Atn2 = Sgn(y) * 1.5707963267949
    ElseIf x > 0 Then
        Atn2 = Atn(y / x)
    Else
        Atn2 = Atn(y / x) + 3.14159265358979 * (y < 0)
    End If
End Function

' Arc Cotangent (error if Number is zero)

Function ACot(Number As Double) As Double
    ACot = Atn(1 / Number)
End Function

' Arc Secant (error if Number is inside the range [-1,1]).

Function ASec(Number As Double) As Double
    If Abs(Number) <> 1 Then
        ASec = 1.5707963267949 - Atn((1 / Number) / Sqr(1 - 1 / (Number * Number)))
    Else
        ASec = 3.14159265358979 * Sgn(Number)
    End If
End Function

' Arc Cosecant (error if Number is inside the range [-1,1]).

Function ACsc(Number As Double) As Double
    If Abs(Number) <> 1 Then
        ACsc = Atn((1 / Number) / Sqr(1 - 1 / (Number * Number)))
    Else
        ACsc = 1.5707963267949 * Sgn(Number)
    End If
End Function


'-----------------------------------------
' Conversion functions
'-----------------------------------------

' Convert from carthesian to polar coordinates

Sub XYToPolar(x As Double, y As Double, angle As Double, radius As Double)
Attribute XYToPolar.VB_Description = "Convert from carthesian to polar coordinates."
    angle = Atn2(x, y)
    radius = Sqr(x * x + y * y)
End Sub

' Convert from polar to carthesian coordinates.

Sub PolarToXY(angle As Double, radius As Double, x As Double, y As Double)
Attribute PolarToXY.VB_Description = "Convert from polar to carthesian coordinates."
    x = radius * Cos(angle)
    y = radius * Sin(angle)
End Sub

'-----------------------------------------
' Hyperbolic functions
'-----------------------------------------

' Hyperbolic Sine

Function SinH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    SinH = (temp - 1 / temp) / 2
End Function

' Hyperbolic Cosine

Function CosH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    CosH = (temp + 1 / temp) / 2
End Function

' Hyperbolic Tangent

Function TanH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    TanH = (temp - 1 / temp) / (temp + 1 / temp)
End Function

' Hyperbolic Cotangent

Function CotH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    CotH = (temp + 1 / temp) / (temp - 1 / temp)
End Function

' Hyperbolic Secant

Function SecH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    SecH = 2 / (temp + 1 / temp)
End Function

' Hyperbolic Cosecant

Function CscH(Number As Double) As Double
    Dim temp As Double
    temp = Exp(Number)
    CscH = 2 / (temp - 1 / temp)
End Function


'-----------------------------------------
' Inverse Hyperbolic functions
'-----------------------------------------

' Hyperbolic Arc Sine

Function ASinH(Number As Double) As Double
    ASinH = Log(Number + Sqr(Number * Number + 1))
End Function

' Hyperbolic Arc Cosine (error if Number is inside the range [-1,1]).

Function ACosH(Number As Double) As Double
    ACosH = Log(Number + Sqr(Number * Number - 1))
End Function

' Hyperbolic Arc Tangent (error if Number is zero).

Function ATanH(Number As Double) As Double
    ATanH = Log((1 / Number + 1) / (1 / Number - 1)) / 2
End Function

' Hyperbolic Arc Cotangent.

Function ACotH(Number As Double) As Double
    ACotH = Log((Number + 1) / (Number - 1)) / 2
End Function

' Hyperbolic Arc Secant (error if Number is outside the range [-1,1]).

Function ASecH(Number As Double) As Double
    ASecH = Log((Sqr(1 - Number * Number) + 1) / Number)
End Function

' Hyperbolic Arc Cosecant

Function ACscH(Number As Double) As Double
    ACscH = Log((Sgn(Number) * Sqr(1 + Number * Number) + 1) / Number)
End Function


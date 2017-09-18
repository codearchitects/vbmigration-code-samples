VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Math"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
'---------------------------------------------------------
' Math routines
'---------------------------------------------------------

Option Explicit

'##project:DefaultMemberSupport False
'##project:UseByval Yes
'##project:DisableMessage 0501
'##project:DisableMessage 0511

' PI, a read-only property

Property Get Pi() As Double
    Pi = 3.14159265358979
End Property


' A replacement for the "^" operator, when the exponent is an integer value.
' Note: at least 50% faster in native-compiled code

Function Power(ByVal Number As Double, ByVal exponent As Long) As Double
    Dim result As Double
    If exponent < 0 Then Err.Raise 5  ' invalid procedure call or argument
    result = 1
    Do While exponent
        If exponent And 1 Then result = result * Number
        Number = Number * Number
        exponent = exponent \ 2
    Loop
    Power = result
End Function

' A replacement for MOD that also works with floating point numbers.
' Note: this differs from MOD when number is negative

Function FPMod(ByVal Number As Double, ByVal divisor As Double) As Double
    FPMod = Number - Int(Number / divisor) * divisor
End Function

' Base-10 logarithm.

Function Log10(Number As Double) As Double
    Log10 = Log(Number) / 2.30258509299405
End Function

' "Equal" up to their 10th decimal digit.

Function AlmostEqual(x, y) As Boolean
    AlmostEqual = (Abs(x - y) <= 0.0000000001)
End Function

' Return 2^N, with N in the range [0-31].

Function Power2(ByVal exponent As Long) As Long
    Static result(0 To 31) As Long, i As Integer
    ' evaluate powers of two only once
    If result(0) = 0 Then
        result(0) = 1
        For i = 1 To 30
            result(i) = result(i - 1) * 2
        Next
        result(31) = &H80000000        ' this is a special value
    End If
    Power2 = result(exponent)
End Function

' Fractional part of a floating-point number.
' (negative numbers return negative values)

Function Fract(Number As Double) As Double
    Fract = Number - Fix(Number)
End Function

' Greatest Common Divisor of two integers.
' Based on Euclide's algorithm

Function GCD(n1 As Long, n2 As Long) As Long
    Dim one As Long, two As Long, tmp As Long
    one = n1: two = n2
    If one > two Then
        tmp = one: one = two: two = tmp
    End If
    
    Do
        tmp = one: one = two: two = tmp
        one = one Mod two
    Loop While one
    GCD& = two
End Function

' Least Common Multiple of two integers.
' Based on Euclide's algorithm

Function LCM(n1 As Long, n2 As Long) As Long
    Dim one As Long, two As Long, tmp As Long
    one = n1: two = n2: tmp = n1 * n2
    If one > two Then
        tmp = one: one = two: two = tmp
    End If
                                                                              
    Do
        tmp = one: one = two: two = tmp
        one = one Mod two
    Loop While one
    LCM = tmp \ two
End Function

' Factorial of a number (n = 0-170).

Function Factorial(Number As Long) As Double
    Static result(170) As Double, i As Long
    ' illegal procedure call if negative
    If Number < 0 Then Err.Raise 5
    ' overflow if too high
    If Number > 170 Then Err.Raise 6
    
    ' evalutate all possible values in advance
    If result(0) = 0 Then
        result(0) = 1
        For i = 1 To UBound(result)
            result(i) = result(i - 1) * CDbl(i)
        Next
    End If
    Factorial = result(Number)
End Function

' Number of combinations of Items elements in groups of GroupSize.

' Combinations are all the possible arrangements you can combine N object
' in groups of K without distinguishing results that only differ in their order
' For example: Combinations(52,5) gives you the number of card hands you can receive

Function Combinations(items As Long, GroupSize As Long) As Double
    Combinations = (Factorial(items) / Factorial(items - GroupSize)) / Factorial(GroupSize)
End Function

' Number of permutations of Items elements in groups of GroupSize.

' Permutations are all the possible arrangements you can combine N object
' in groups of K when you distinguish results that differ in their order
' For example: Permutations(10,3) returns the number of permutation in which
' 1st, 2nd and 3rd prize can be assigned to a game with 10 playes

Function Permutations(items As Long, GroupSize As Long) As Double
    Permutations = Factorial(items) / Factorial(items - GroupSize)
End Function

' The nearest integer equal or higher than the argument.

Function Ceiling(Number As Double) As Long
    Ceiling = -Int(-Number)
End Function

' An array with the first N prime numbers.

Function PrimeArray(numberOfPrimes As Long) As Long()
    Dim found As Long, n As Long, i As Long
    If numberOfPrimes <= 0 Then Err.Raise 1002, , "Invalid argument"
    ' we know the size of the result in advance
    ' MIGRATION NOTE !!! : Non-sense in using a Redim with a new array
    'ReDim result(1 To numberOfPrimes) As Long
    '##result.ArrayBounds ForceZero
    Dim result(1 To numberOfPrimes) As Long
    ' "2" is the first prime number
    result(1) = 2: found = 1
    n = 1
    Do While found < numberOfPrimes
        ' all other prime numbers are odd, so we can skip even numbers
        n = n + 2
        ' let's check if N is a prime number
        For i = 1 To found
            If (n Mod result(i)) = 0 Then Exit For
        Next
        If i > found Then
            ' no prime number < N is a divisor for N, therefore N is prime
            found = found + 1
            result(found) = n
        End If
    Loop
    PrimeArray = result
End Function

' Sum of the numeric arguments, concatenation of strings.

Function Sum(ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    For i = LBound(args) To UBound(args)
        result = result + args(i)
    Next
    Sum = result
End Function

' The highest value among passed arguments.

Function Max(first As Double, ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    result = first
    For i = LBound(args) To UBound(args)
        If args(i) > result Then result = args(i)
    Next
    Max = result
End Function

' The lowest value among passed arguments.

Function Min(first As Double, ParamArray args() As Variant) As Double
    Dim i As Integer, result As Double
    result = first
    For i = LBound(args) To UBound(args)
        If args(i) < result Then result = args(i)
    Next
    Min = result
End Function

' A random number in the range (low, high)

Function Rnd2(low As Single, high As Single) As Single
    Rnd2 = Rnd * (high - low) + low
End Function

' An array of Long values in the range specified, without any duplicated value
'## ReplaceStatement Function RandomArray(first As Integer, last As Integer) As VB6Array(of Integer)
Function RandomArray(first As Long, last As Long) As Long()
    Dim i As Long, j As Long, temp As Long
   
   '##Note Added for handling the zero LBound array
   '##result.ArrayBounds ForceVB6Array
   Dim result() As Long
   
    ReDim result(first To last) As Long
    ' initialize the array
    For i = first To last
        result(i) = i
    Next
    ' now shuffle it
    For i = last To first Step -1
        ' generate a random number in the proper range
        j = Rnd * (last - first + 1) + first
        ' swap the two items
        temp = result(i): result(i) = result(j): result(j) = temp
    Next
    RandomArray = result
End Function






VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Conversion"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "Conversion routines"
'---------------------------------------------------------
' Conversion routines
'---------------------------------------------------------

Option Explicit

' Convert from decimal to binary.

Function Bin(ByVal value As Long) As String
Attribute Bin.VB_Description = "Convert from decimal to binary."
    Dim result As String, exponent As Integer
    ' this is faster than creating the string by appending chars
    result = String$(32, "0")
    Do
        If value And Power2(exponent) Then
            ' we found a bit that is set, clear it
            Mid$(result, 32 - exponent, 1) = "1"
            value = value Xor Power2(exponent)
        End If
        exponent = exponent + 1
    Loop While value
    Bin = Mid$(result, 33 - exponent)
End Function

' Convert from binary to decimal.

Function BinToDec(value As String) As Long
Attribute BinToDec.VB_Description = "Convert from binary to decimal."
    Dim result As Long, i As Integer, exponent As Integer
    For i = Len(value) To 1 Step -1
        Select Case Asc(Mid$(value, i, 1))
            Case 48      ' "0", do nothing
            Case 49      ' "1", add the corresponding power of 2
                result = result + Power2(exponent)
            Case Else
                Err.Raise 5      ' Invalid procedure call or argument
        End Select
        exponent = exponent + 1
    Next
    BinToDec = result
End Function

' Convert from degrees to radians.

Function Radians(Degrees As Double) As Double
    Radians = Degrees / 57.29577951
End Function

' Convert from radians to degrees.

Function Degrees(Radians As Double) As Double
    Degrees = Radians * 57.29577951
End Function

' Private function

Private Function Power2(ByVal exponent As Long) As Long
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


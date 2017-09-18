VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CTextBoxNum"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------------------------
' The CTextBoxNum Class module
'----------------------------------------------

Option Explicit

Event ValidateError(Cancel As Boolean)

Public WithEvents TextBox As TextBox
Attribute TextBox.VB_VarHelpID = -1

Public IsDecimal As Boolean
Public FormatMask As String
Public SelectOnEntry As Boolean
Public Min As Variant, Max As Variant

Private Sub TextBox_KeyPress(KeyAscii As Integer)
    Select Case KeyAscii
        Case 0 To 31       ' accept control chars
        Case 48 To 57      ' accept digits
        Case Asc(Format$(0.1, "."))
            If Not IsDecimal Then KeyAscii = 0
        Case Else
            KeyAscii = 0   ' reject anything else
    End Select
End Sub

' filter off all non-numeric characters on entry

Private Sub TextBox_GotFocus()
    TextBox.Text = FilterNumber(TextBox.Text, True)
    If SelectOnEntry Then
        TextBox.SelStart = 0: TextBox.SelLength = 9999
    End If
End Sub

' format the number when the focus leaves the control

Private Sub TextBox_LostFocus()
    If Len(FormatMask) Then
        TextBox.Text = Format$(TextBox.Text, FormatMask)
    End If
End Sub

Private Sub TextBox_Validate(Cancel As Boolean)
    If Not IsEmpty(Min) Then
        If CDbl(TextBox.Text) < Min Then RaiseEvent ValidateError(Cancel)
    End If
    If Not IsEmpty(Max) Then
        If CDbl(TextBox.Text) > Max Then RaiseEvent ValidateError(Cancel)
    End If
End Sub

' private functions (from chapter 02)

Private Function FilterString(Text As String, ValidChars As String) As String
    Dim i As Long, result As String
    For i = 1 To Len(Text)
        If InStr(ValidChars, Mid$(Text, i, 1)) Then
            result = result & Mid$(Text, i, 1)
        End If
    Next
    FilterString = result
End Function

Private Function FilterNumber(Text As String, TrimZeroes As Boolean) As String
    Dim decSep As String, i As Long, result As String
    ' retrieve the decimal separator symbol
    decSep = Format$(0.1, ".")
    ' use FilterString for most of the work
    result = FilterString(Text, decSep & "-0123456789")
    ' only if there is a decimal part and the
    ' user requested to trim non-significant digits
    If TrimZeroes And InStr(Text, decSep) > 0 Then
        For i = Len(result) To 1 Step -1
            Select Case Mid$(result, i, 1)
                Case decSep
                    result = Left$(result, i - 1)
                    Exit For
                Case "0"
                    result = Left$(result, i - 1)
                Case Else
                    Exit For
            End Select
        Next
    End If
    FilterNumber = result
End Function


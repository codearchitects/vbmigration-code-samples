Attribute VB_Name = "Module1"
' module with factory methods

Option Explicit

Function New_CLine(X As Single, Y As Single, X2 As Single, Y2 As Single, Optional color As Variant) As CLine
    Set New_CLine = New CLine
    New_CLine.Init X, Y, X2, Y2, color
End Function

Function New_CRectangle(Left As Single, Top As Single, Width As Single, Height As Single, Optional color As Variant, Optional FillColor As Variant) As CRectangle

#If VBC_VER = 8 Then
    Dim Rect As New CRectangle
    Rect.Init Left, Top, Width, Height, color, FillColor
    Set New_CRectangle = Rect
#Else
    ' original code in "Programming Microsoft Visual Basic 6" book
    Set New_CRectangle = New CRectangle
    New_CRectangle.Init Left, Top, Width, Height, color, FillColor
#End If
    
    
End Function

Function New_CEllipse(Left As Single, Top As Single, Width As Single, Height As Single, Optional color As Variant, Optional FillColor As Variant) As CEllipse
    Set New_CEllipse = New CEllipse
    New_CEllipse.Init Left, Top, Width, Height, color, FillColor
End Function

Function New_CSquare(Left As Single, Top As Single, Width As Single, Optional color As Variant, Optional FillColor As Variant) As CSquare
    Set New_CSquare = New CSquare
    New_CSquare.Init Left, Top, Width, color, FillColor
End Function



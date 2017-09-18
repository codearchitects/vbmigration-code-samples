Attribute VB_Name = "Module1"
Option Explicit

' this routine is actually useful only at design time
' and isn't necessarily included in the compiled program
' run this sub from the Immediate window

Sub CreateLicenseFile()
    Open App.Path & "\MSWLess.key" For Output As #1
    Print #1, Licenses.Add("MSWLess.WLText")
    Close #1
End Sub



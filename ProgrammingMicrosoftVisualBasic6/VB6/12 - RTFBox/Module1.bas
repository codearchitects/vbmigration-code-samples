Attribute VB_Name = "Module1"
Option Explicit

Public fMainForm As frmMain

Public gloCancel As Boolean


Sub Main()
    Set fMainForm = New frmMain
    fMainForm.Show
End Sub


Attribute VB_Name = "MainModule"
Declare Function GetUserDefaultLangID Lib "kernel32" () As Integer

'##rs.AutoNew true
Public rs As New MyApplication000.Resources

Sub Main()
    InitLanguage              ' Load the satellite DLL.
    frmPublishers.Show        ' Show the startup form.
End Sub

' Load the satellite DLL that corresponds to the current user's locale.
Sub InitLanguage()
    Dim LangId As Long, ProgID As String
    ' Get the default language.
    LangId = GetUserDefaultLangID()
    ' Build the complete class name.
    ProgID = App.EXEName & Hex$(LangId) & ".Resources"
    ' Try to create the object, but ignore errors. If this statement
    ' fails, the RS variable will point to the default DLL (English)
    On Error Resume Next
    Set rs = CreateObject(ProgID)
End Sub


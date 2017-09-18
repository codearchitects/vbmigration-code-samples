Attribute VB_Name = "OpenDialog"
Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (pOpenfilename As OPENFILENAME) As Long
Private Const OFN_HIDEREADONLY As Long = &H4
Private Const OFN_EXPLORER As Long = &H80000
Private Const OFN_ALLOWMULTISELECT As Long = &H200
Private Type OPENFILENAME
    lStructSize As Long
    hwndOwner As Long
    hInstance As Long
    lpstrFilter As String
    lpstrCustomFilter As String
    nMaxCustFilter As Long
    nFilterIndex As Long
    lpstrFile As String
    nMaxFile As Long
    lpstrFileTitle As String
    nMaxFileTitle As Long
    lpstrInitialDir As String
    lpstrTitle As String
    flags As Long
    nFileOffset As Integer
    nFileExtension As Integer
    lpstrDefExt As String
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type


Public Function OpenDlg(hWnd As Long, Optional Filter As String = "", Optional Title As String = "Select file", Optional InitialDir As String, Optional MultiSelect As Boolean = False)
    Dim OFName As OPENFILENAME
    Static InDir As String

    Do While InStr(1, Filter, "|") > 0
        'Replace all '|' chars in the filter with spaces
        Mid(Filter, InStr(1, Filter, "|")) = Chr$(0)
    Loop
    '## InsertStatement Filter &= Chr6(0)

    If InDir = "" Then InDir = App.Path
    'load the last directory path if is it missing
    If InitialDir = "" Then InitialDir = InDir

    OFName.lStructSize = Len(OFName)
    'Set the parent window
    OFName.hwndOwner = hWnd
    'Set the application's instance
    OFName.hInstance = App.hInstance
    'Select a filter
    OFName.lpstrFilter = Filter
    'create a buffer for the file
    OFName.lpstrFile = Space$(10000)
    'set the maximum length of a returned file
    OFName.nMaxFile = 10001
    'Create a buffer for the file title
    OFName.lpstrFileTitle = Space$(10000)
    'Set the maximum length of a returned file title
    OFName.nMaxFileTitle = 10001
    'Set the initial directory
    OFName.lpstrInitialDir = InitialDir
    'Set the title
    OFName.lpstrTitle = Title '"Open File - KPD-Team 1998"
    'Hide the readonly check box
    OFName.flags = OFN_HIDEREADONLY
    If MultiSelect Then
        'Allow multi file selection
        OFName.flags = OFName.flags Or OFN_EXPLORER Or OFN_ALLOWMULTISELECT
    End If

    'Show the open dialog
    If GetOpenFileName(OFName) = 1 Then
        OpenDlg = Trim$(OFName.lpstrFile)
        'Save the file path
        InDir = Left(OFName.lpstrFile, Len(Trim$(OFName.lpstrFile)) - Len(Trim$(OFName.lpstrFileTitle))) & "\"
    Else
        OpenDlg = "?"
    End If
End Function

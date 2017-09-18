' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module OpenDialog

	Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (ByRef pOpenfilename As OpenDialog.OPENFILENAME) As Integer
	Private Const OFN_HIDEREADONLY As Integer = &H4I
	Private Const OFN_EXPLORER As Integer = &H80000I
	Private Const OFN_ALLOWMULTISELECT As Integer = &H200I
	Friend Structure OPENFILENAME
	
		Public lStructSize As Integer
		Public hwndOwner As Integer
		Public hInstance As Integer
		Public lpstrFilter As String
		Public lpstrCustomFilter As String
		Public nMaxCustFilter As Integer
		Public nFilterIndex As Integer
		Public lpstrFile As String
		Public nMaxFile As Integer
		Public lpstrFileTitle As String
		Public nMaxFileTitle As Integer
		Public lpstrInitialDir As String
		Public lpstrTitle As String
		Public flags As Integer
		Public nFileOffset As Short
		Public nFileExtension As Short
		Public lpstrDefExt As String
		Public lCustData As Integer
		Public lpfnHook As Integer
		Public lpTemplateName As String
	End Structure

	Public Function OpenDlg(ByRef hWnd As Integer, Optional ByRef Filter As String = "", Optional ByRef Title As String = "Select file", Optional ByRef InitialDir As String = "", Optional ByRef MultiSelect As Boolean = False) As Object
		Dim OFName As OpenDialog.OPENFILENAME
		Static InDir As String
		
		Do While InStr(1, Filter, "|") > 0
			'Replace all '|' chars in the filter with spaces
			Mid(Filter, InStr(1, Filter, "|")) = Chr6(0)
		Loop
		Filter &= Chr6(0)
		
		If InDir = "" Then  InDir = App6.Path
		'load the last directory path if is it missing
		If InitialDir = "" Then  InitialDir = InDir
		
		OFName.lStructSize = Len6(OFName)
		'Set the parent window
		OFName.hwndOwner = hWnd
		'Set the application's instance
		OFName.hInstance = App6.hInstance
		'Select a filter
		OFName.lpstrFilter = Filter
		'create a buffer for the file
		OFName.lpstrFile = Space(10000)
		'set the maximum length of a returned file
		OFName.nMaxFile = 10001
		'Create a buffer for the file title
		OFName.lpstrFileTitle = Space(10000)
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
			OpenDlg = Trim(OFName.lpstrFile)
			'Save the file path
			InDir = VB.Left(OFName.lpstrFile, Len6(Trim(OFName.lpstrFile)) - Len6(Trim(OFName.lpstrFileTitle))) & "\"
		Else
			Return "?"
		End If
	End Function

End Module

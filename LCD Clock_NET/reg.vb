' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module reg

	Public Const REG_SZ As Short = 1
	' Unicode nul terminated string
	' UPGRADE_INFO (#0511): The 'REG_BINARY' member is referenced only by members that haven't found to be used in the current project/solution.
	Public Const REG_BINARY As Short = 3
	' Free form binary
	
	' UPGRADE_INFO (#0501): The 'HKEY_CLASSES_ROOT' member isn't used anywhere in current application.
	Public Const HKEY_CLASSES_ROOT As Integer = &H80000000I
	' UPGRADE_INFO (#0501): The 'HKEY_CURRENT_USER' member isn't used anywhere in current application.
	Public Const HKEY_CURRENT_USER As Integer = &H80000001I
	Public Const HKEY_LOCAL_MACHINE As Integer = &H80000002I
	' UPGRADE_INFO (#0501): The 'HKEY_USERS' member isn't used anywhere in current application.
	Public Const HKEY_USERS As Integer = &H80000003I
	' UPGRADE_INFO (#0501): The 'HKEY_PERFORMANCE_DATA' member isn't used anywhere in current application.
	Public Const HKEY_PERFORMANCE_DATA As Integer = &H80000004I
	' UPGRADE_INFO (#0501): The 'HKEY_CURRENT_CONFIG' member isn't used anywhere in current application.
	Public Const HKEY_CURRENT_CONFIG As Integer = &H80000005I
	' UPGRADE_INFO (#0501): The 'HKEY_DYN_DATA' member isn't used anywhere in current application.
	Public Const HKEY_DYN_DATA As Integer = &H80000006I
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegCloseKey' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.Close
	Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
	Private Declare Function RegCreateKey Lib "advapi32.dll" Alias "RegCreateKeyA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegDeleteValue' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.DeleteValue
	' UPGRADE_INFO (#0511): The 'RegDeleteValue' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Integer, ByVal lpValueName As String) As Integer
	' UPGRADE_INFO (#0511): The 'RegOpenKey' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegQueryValueEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.GetValue
	' UPGRADE_INFO (#0511): The 'RegQueryValueEx' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As Any, lpcbData As Long) As Long
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Short, ByRef lpcbData As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegSetValueEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.SetValue
	' IGNORED: Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As Any, ByVal cbData As Long) As Long
	Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByVal lpData As String, ByVal cbData As Integer) As Integer
	Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Byte, ByVal cbData As Integer) As Integer
	
	Public Function RegQueryStringValue(ByVal hKey As Integer, ByVal strValueName As String) As String
	' UPGRADE_INFO (#0511): The 'RegQueryStringValue' member is referenced only by members that haven't found to be used in the current project/solution.
		Dim lResult As Integer
		Dim lValueType As Integer
		Dim strBuf As String = ""
		Dim lDataBufSize As Integer
		'retrieve nformation about the key
		lResult = RegQueryValueEx(hKey, strValueName, 0, lValueType, 0, lDataBufSize)
		Dim strData As Short
		If lResult = 0 Then 
			If lValueType = REG_SZ Then 
				'Create a buffer
				strBuf = String6(lDataBufSize, Chr6(0))
				'retrieve the key's content
				lResult = RegQueryValueEx(hKey, strValueName, 0, 0, strBuf, lDataBufSize)
				If lResult = 0 Then 
					'Remove the unnecessary chr$(0)'s
					Return VB.Left(strBuf, InStr(1, strBuf, Chr6(0)) - 1)
				End If
			ElseIf lValueType = REG_BINARY Then 
				'retrieve the key's value
				lResult = RegQueryValueEx(hKey, strValueName, 0, 0, strData, lDataBufSize)
				If lResult = 0 Then 
					Return strData
				End If
			End If
		End If
	End Function
	
	Public Function GetString(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String) As Object
	' UPGRADE_INFO (#0501): The 'GetString' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0561): The 'GetString' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'hKey' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strPath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_INFO (#0561): The 'Ret' symbol was defined without an explicit "As" clause.
		Dim Ret As Object = Nothing
		'Open the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegOpenKey(hKey, strPath, Ret)
		'Get the key's content
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'GetString'. Consider using the SetDefaultMember6 helper method.
		GetString = RegQueryStringValue(Ret, strValue)
		'Close the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCloseKey(Ret)
	End Function
	
	Public Sub SaveString(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String, ByRef strData As String)
	' UPGRADE_INFO (#0551): The 'hKey' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strPath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strData' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_INFO (#0561): The 'Ret' symbol was defined without an explicit "As" clause.
		Dim Ret As Object = Nothing
		'Create a new key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCreateKey(hKey, strPath, Ret)
		'Save a string to the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegSetValueEx(Ret, strValue, 0, REG_SZ, strData, Len6(strData))
		'close the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCloseKey(Ret)
	End Sub
	
	Public Sub SaveStringLong(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String, ByRef strData As String)
	' UPGRADE_INFO (#0501): The 'SaveStringLong' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'hKey' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strPath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strData' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_INFO (#0561): The 'Ret' symbol was defined without an explicit "As" clause.
		Dim Ret As Object = Nothing
		'Create a new key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCreateKey(hKey, strPath, Ret)
		'Set the key's value
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegSetValueEx(Ret, strValue, 0, REG_BINARY, CByte(strData), 4)
		'close the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCloseKey(Ret)
	End Sub
	
	Public Sub DelSetting(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String)
	' UPGRADE_INFO (#0501): The 'DelSetting' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'hKey' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strPath' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'strValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_INFO (#0561): The 'Ret' symbol was defined without an explicit "As" clause.
		Dim Ret As Object = Nothing
		'Create a new key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCreateKey(hKey, strPath, Ret)
		'Delete the key's value
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegDeleteValue(Ret, strValue)
		'close the key
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ret'. Consider using the GetDefaultMember6 helper method.
		RegCloseKey(Ret)
	End Sub

End Module

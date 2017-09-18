' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module RegistryAPI

	' UPGRADE_INFO (#0531): You can replace calls to the 'RegOpenKeyEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.OpenSubKey
	Private Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegCloseKey' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.Close
	Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegQueryValueEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.GetValue
	' IGNORED: Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As Any, lpcbData As Long) As Long
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Integer, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Byte, ByRef lpcbData As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegCreateKeyEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.CreateSubKey
	Private Declare Function RegCreateKeyEx Lib "advapi32.dll" Alias "RegCreateKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal Reserved As Integer, ByVal lpClass As Integer, ByVal dwOptions As Integer, ByVal samDesired As Integer, ByVal lpSecurityAttributes As Integer, ByRef phkResult As Integer, ByRef lpdwDisposition As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegDeleteKey' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.DeleteSubKeyTree
	Private Declare Function RegDeleteKey Lib "advapi32.dll" Alias "RegDeleteKeyA" (ByVal hKey As Integer, ByVal lpSubKey As String) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegSetValueEx' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.SetValue
	' IGNORED: Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As Any, ByVal cbData As Long) As Long
	Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Integer, ByVal cbData As Integer) As Integer
	Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByVal lpData As String, ByVal cbData As Integer) As Integer
	Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Byte, ByVal cbData As Integer) As Integer
	Private Declare Function RegEnumKey Lib "advapi32.dll" Alias "RegEnumKeyA" (ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpName As String, ByVal cbName As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegDeleteValue' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.DeleteValue
	Private Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Integer, ByVal lpValueName As String) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'RegEnumValue' unamanged method with the following .NET member(s): Microsoft.Win32.RegistryKey.GetValueNames, Microsoft.Win32.RegistryKey.GetValue
	' IGNORED: Private Declare Function RegEnumValue Lib "advapi32.dll" Alias "RegEnumValueA" (ByVal hKey As Long, ByVal dwIndex As Long, ByVal lpValueName As String, lpcbValueName As Long, ByVal lpReserved As Long, lpType As Long, lpData As Any, lpcbData As Long) As Long
	Private Declare Function RegEnumValue Lib "advapi32.dll" Alias "RegEnumValueA" (ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpValueName As String, ByRef lpcbValueName As Integer, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Byte, ByRef lpcbData As Integer) As Integer
	' IGNORED: Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, source As Any, ByVal numBytes As Long)
	Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef dest As Integer, ByRef source As Byte, ByVal numBytes As Integer)
	
	' UPGRADE_INFO (#0511): The 'FormatMessage' member is referenced only by members that haven't found to be used in the current project/solution.
	' IGNORED: Declare Function FormatMessage Lib "kernel32" Alias "FormatMessageA" (ByVal dwFlags As Long, lpSource As Any, ByVal dwMessageId As Long, ByVal dwLanguageId As Long, ByVal lpBuffer As String, ByVal nSize As Long, Arguments As Long) As Long
	Declare Function FormatMessage Lib "kernel32" Alias "FormatMessageA" (ByVal dwFlags As Integer, ByVal lpSource As Short, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByVal lpBuffer As String, ByVal nSize As Integer, ByRef Arguments As Integer) As Integer
	
	Private Const SYNCHRONIZE As Integer = &H100000I
	Private Const READ_CONTROL As Integer = &H20000I
	Private Const STANDARD_RIGHTS_READ As Integer = (READ_CONTROL)
	Private Const STANDARD_RIGHTS_WRITE As Integer = (READ_CONTROL)
	Private Const STANDARD_RIGHTS_ALL As Integer = &H1F0000I
	
	Private Const KEY_QUERY_VALUE As Short = &H1S
	Private Const KEY_ENUMERATE_SUB_KEYS As Short = &H8S
	Private Const KEY_NOTIFY As Short = &H10S
	Private Const KEY_SET_VALUE As Short = &H2S
	Private Const KEY_CREATE_SUB_KEY As Short = &H4S
	Private Const KEY_READ As Integer = ((READ_CONTROL Or KEY_QUERY_VALUE Or KEY_ENUMERATE_SUB_KEYS Or KEY_NOTIFY) And (Not SYNCHRONIZE))
	Private Const KEY_WRITE As Integer = ((STANDARD_RIGHTS_WRITE Or KEY_SET_VALUE Or KEY_CREATE_SUB_KEY) And (Not SYNCHRONIZE))
	
	Private Const ERROR_SUCCESS As Integer = 0&
	
	Public Const REG_SZ As Short = 1
	Public Const REG_BINARY As Short = 3
	Public Const REG_DWORD As Short = 4
	
	Public Const HKEY_CLASSES_ROOT As Integer = &H80000000I
	Public Const HKEY_CURRENT_USER As Integer = &H80000001I
	Public Const HKEY_LOCAL_MACHINE As Integer = &H80000002I
	Public Const HKEY_USERS As Integer = &H80000003I
	Public Const HKEY_PERFORMANCE_DATA As Integer = &H80000004I
	Public Const HKEY_CURRENT_CONFIG As Integer = &H80000005I
	Public Const HKEY_DYN_DATA As Integer = &H80000006I
	
	Public Const REG_CREATED_NEW_KEY As Short = &H1S
	Public Const REG_OPENED_EXISTING_KEY As Short = &H2S
	
	const VB6Empty as string = ""
	
	' Return True if the system has a math processor.
	
	Public Function MathProcessor() As Boolean
		Dim hKey As Integer
		Dim key As String = "HARDWARE\DESCRIPTION\System\FloatingPointProcessor"
		If RegOpenKeyEx(HKEY_LOCAL_MACHINE, key, 0, KEY_READ, hKey) = 0 Then 
			' If the open operation succeeded, the key exists
			MathProcessor = True
			' Important: close the key before exiting.
			RegCloseKey(hKey)
		End If
	End Function

	' Test if a Registry key exists.
	
	Public Function CheckRegistryKey(ByVal hKey As Integer, ByVal KeyName As String) As Boolean
		Dim handle As Integer
		' Try to open the key.
		If RegOpenKeyEx(hKey, KeyName, 0, KEY_READ, handle) = 0 Then 
			' The key exists.
			CheckRegistryKey = True
			' Close it before exiting.
			RegCloseKey(handle)
		End If
	End Function

	' Create a registry key, then close it.
	' Returns True if the key already existed, False if it was created.
	
	Public Function CreateRegistryKey(ByVal hKey As Integer, ByVal KeyName As String) As Boolean
		Dim handle As Integer
		Dim disposition As Integer
		If RegCreateKeyEx(hKey, KeyName, 0, 0, 0, 0, 0, handle, disposition) Then 
			Err.Raise(1001, , "Unable to create the registry key")
		Else
			' Return True if the key already existed.
			CreateRegistryKey = (disposition = REG_OPENED_EXISTING_KEY)
			' Close the key.
			RegCloseKey(handle)
		End If
	End Function

	' Delete a registry key.
	' Under Windows NT it doesn't work if the key contains subkeys.
	
	Public Sub DeleteRegistryKey(ByVal hKey As Integer, ByVal KeyName As String)
		RegDeleteKey(hKey, KeyName)
	End Sub

	' Read a Registry value.
	' Use KeyName = "" for the default value.
	' Supports only DWORD, SZ, and BINARY value types.
	
	Public Function GetRegistryValue(ByVal hKey As Integer, ByVal KeyName As String, ByVal ValueName As String, ByVal KeyType As Short, Optional ByVal DefaultValue As Object = VB6Empty) As Object
		
		Dim handle As Integer
		Dim resLong As Integer
		Dim resString As String = ""
		Dim length As Integer
		Dim resBinary() As Byte
		
		' Prepare the default result.
		GetRegistryValue = DefaultValue
		' Open the key, exit if not found.
		If RegOpenKeyEx(hKey, KeyName, 0, KEY_READ, handle) Then  Exit Function
		
		Select Case KeyType
		Case REG_DWORD
			' Read the value, use the default if not found.
			If RegQueryValueEx(handle, ValueName, 0, REG_DWORD, resLong, 4) = 0 Then 
				GetRegistryValue = resLong
			End If
		Case REG_SZ
			length = 1024: resString = Space(length)
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'resString' argument. Consider creating an overload of the Declare statement.
			If RegQueryValueEx(handle, ValueName, 0, REG_SZ, resString, length) = 0 Then 
				' If value is found, trim characters in excess.
				GetRegistryValue = VB.Left(resString, length - 1)
			End If
		Case REG_BINARY
			length = 4096
			ReDim resBinary(length - 1)
			If RegQueryValueEx(handle, ValueName, 0, REG_BINARY, resBinary(0), length) = 0 Then 
				GetRegistryValue = resBinary
			End If
		Case Else
			Err.Raise(1001, , "Unsupported value type")
		End Select
		
		RegCloseKey(handle)
	End Function

	' Write / Create a Registry value.
	' Use KeyName = "" for the default value.
	' Supports only DWORD, SZ, and BINARY value types.
	
	Public Sub SetRegistryValue(ByVal hKey As Integer, ByVal KeyName As String, ByVal ValueName As String, ByVal KeyType As Short, ByVal value As Object)
		Dim handle As Integer
		Dim lngValue As Integer
		Dim strValue As String = ""
		Dim binValue() As Byte
		Dim length As Integer
		
		' Open the key, exit if not found.
		If RegOpenKeyEx(hKey, KeyName, 0, KEY_WRITE, handle) Then  Exit Sub
		
		Select Case KeyType
		Case REG_DWORD
			lngValue = value
			RegSetValueEx(handle, ValueName, 0, KeyType, lngValue, 4)
		Case REG_SZ
			strValue = value
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'strValue' argument. Consider creating an overload of the Declare statement.
			RegSetValueEx(handle, ValueName, 0, KeyType, strValue, Len6(strValue))
		Case REG_BINARY
			binValue = value
			length = UBound6(binValue) - LBound6(binValue) + 1
			RegSetValueEx(handle, ValueName, 0, KeyType, binValue(LBound6(binValue)), length)
		End Select
		
		' Close the key.
		RegCloseKey(handle)
	End Sub

	' Delete a value.
	
	Public Sub DeleteRegistryValue(ByVal hKey As Integer, ByVal KeyName As String, ByVal ValueName As String)
		Dim handle As Integer
		
		' Open the key, exit if not found.
		If RegOpenKeyEx(hKey, KeyName, 0, KEY_WRITE, handle) Then  Exit Sub
		' Delete the value.
		RegDeleteValue(handle, ValueName)
		' Close the handle.
		RegCloseKey(handle)
	End Sub

	' Enumerate registry keys under a given key, returns an array of strings.
	
	Public Function EnumRegistryKeys(ByVal hKey As Integer, ByVal KeyName As String) As String()
		Dim result() As String    ' Implicitly declared array
		Dim handle As Integer
		Dim index As Integer
		Dim length As Integer
		ReDim result(100)
		Dim FileTimeBuffer(100) As Byte
		
		' Open the key, exit if not found.
		If Len6(KeyName) Then 
			If RegOpenKeyEx(hKey, KeyName, 0, KEY_READ, handle) Then  Exit Function
			' in all case the subsequent functions use hKey
			hKey = handle
		End If
		
		For index = 0 To 999999
			' Make room in the array.
			If index > UBound6(result) Then 
				ReDim Preserve result(index + 99)
			End If
			length = 260 ' Max length for a key name.
			result(index) = Space(length)
			If RegEnumKey(hKey, index, result(index), length) Then  Exit For
			result(index) = VB.Left(result(index), InStr(result(index), ControlChars.NullChar) - 1)
		Next
		
		' Close the key, if it was actually opened.
		If handle Then  RegCloseKey(handle)
		
		' Trim unused items in the array.
		ReDim Preserve result(index - 1)
		Return result
	End Function

	' Enumerate registry values under a given key,
	' returns a two dimensional array of Variant (row 0 for value names, row 1 for value contents)
	
	Public Function EnumRegistryValues(ByVal hKey As Integer, ByVal KeyName As String) As Object(,)
		Dim result(,) As Object    ' Implicitly declared array
		Dim binValue() As Byte    ' Implicitly declared array
		Dim handle As Integer
		Dim index As Integer
		Dim valueType As Integer
		Dim name As String = ""
		Dim nameLen As Integer
		Dim lngValue As Integer
		Dim strValue As String = ""
		Dim dataLen As Integer
		
		ReDim result(1, 100)
		
		' Open the key, exit if not found.
		If Len6(KeyName) Then 
			If RegOpenKeyEx(hKey, KeyName, 0, KEY_READ, handle) Then  Exit Function
			' in all case the subsequent functions use hKey
			hKey = handle
		End If
		
		For index = 0 To 999999
			' Make room in the array.
			If index > UBound6(result, 2) Then 
				ReDim Preserve result(1, index + 99)
			End If
			nameLen = 260 ' Max length for a key name.
			name = Space(nameLen)
			dataLen = 4096
			ReDim binValue(dataLen - 1)
			If RegEnumValue(hKey, index, name, nameLen, 0%, valueType, binValue(0), dataLen) Then  Exit For
			result(0, index) = VB.Left(name, nameLen)
			
			Select Case valueType
			Case REG_DWORD
				' Copy the first 4 bytes into a long variable
				CopyMemory(lngValue, binValue(0), 4)
				result(1, index) = lngValue
			Case REG_SZ
				' Convert the result to a string.
				result(1, index) = VB.Left(StrConv6(binValue, VBA.VbStrConv.vbUnicode), dataLen - 1)
			Case Else
				' In all other cases, just copy the array of bytes.
				ReDim Preserve binValue(dataLen - 1)
				result(1, index) = binValue
			End Select
		Next
		
		' Close the key, if it was actually opened.
		If handle Then  RegCloseKey(handle)
		
		' Trim unused items in the array.
		ReDim Preserve result(1, index - 1)
		Return result
	End Function

	' You can use this function to decypher error messages from the API.
	
	Public Function SystemMessage(ByVal ApiErrorCode As Integer) As String
		Dim buffer As String = ""
		Dim length As Integer
		Const FORMAT_MESSAGE_FROM_SYSTEM As Short = &H1000S
		
		buffer = Space(1024)
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0' argument. Consider creating an overload of the Declare statement.
		length = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, 0, ApiErrorCode, 0, buffer, Len6(buffer), 0)
		Return VB.Left(buffer, length)
		
	End Function

End Module

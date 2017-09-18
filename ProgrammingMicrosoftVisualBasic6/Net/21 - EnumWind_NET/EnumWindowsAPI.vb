' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module EnumWindowsAPI
' List of Private delegates used for callback methods
Private Delegate Function EnumChildWindows_CBK(ByVal hWnd As Integer, ByVal lParam As Integer) As Integer

	Private Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As Integer, ByVal lParam As Integer) As Integer
	Private  Declare Function EnumWindows_Private Lib "user32" Alias "EnumWindows"  (ByVal lpEnumFunc As EnumChildWindows_CBK, ByVal lParam As Integer) As Integer
	
	' This wrapper method ensures that delegate values are kept alive between calls.
	Private Function EnumWindows (ByVal lpEnumFunc As EnumChildWindows_CBK, ByVal lParam As Integer) As Integer
		KeepAliveObjects6.Add(lpEnumFunc)
		Return EnumWindows_Private(lpEnumFunc, lParam)
	End Function
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'EnumChildWindows' unamanged method with the following .NET member(s): System.Windows.Forms.Form.Controls
	Private Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As Integer, ByVal lpEnumFunc As Integer, ByVal lParam As Integer) As Integer
	Private  Declare Function EnumChildWindows_Private Lib "user32" Alias "EnumChildWindows"  (ByVal hWndParent As Integer, ByVal lpEnumFunc As EnumChildWindows_CBK, ByVal lParam As Integer) As Integer
	
	' This wrapper method ensures that delegate values are kept alive between calls.
	Private Function EnumChildWindows (ByVal hWndParent As Integer, ByVal lpEnumFunc As EnumChildWindows_CBK, ByVal lParam As Integer) As Integer
		KeepAliveObjects6.Add(lpEnumFunc)
		Return EnumChildWindows_Private(hWndParent, lpEnumFunc, lParam)
	End Function
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetClassName' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Name
	Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hWnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetWindowText' unamanged method with the following .NET member(s): System.Windows.Forms.Form.Text
	Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hWnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	
	' An array of Long holding the handle of all child windows.
	Private windows() As Integer
	' The number of elements in the array.
	Private windowsCount As Integer
	
	' Return an array of Long holding the handles of all the child windows
	' of a given window. If hWnd = 0 it returns all the top-level windows.
	
	Public Function ChildWindows(ByVal hWnd As Integer) As Integer()
		windowsCount = 0
		If hWnd Then 
			EnumChildWindows(hWnd, AddressOf EnumWindows_CBK, 1)
		Else
			EnumWindows(AddressOf EnumWindows_CBK, 1)
		End If
		' Trim uninitialized elements and return to caller.
		ReDim Preserve windows(windowsCount)
		Return windows.Clone()
	End Function

	' The callback routine, common to both EnumWindows and EnumChildWindows.
	
	Public Function EnumWindows_CBK(ByVal hWnd As Integer, ByVal lParam As Integer) As Integer
		' Make room in the array, if necessary.
		If windowsCount = 0 Then 
			ReDim windows(100)
		ElseIf windowsCount >= UBound6(windows) Then 
			ReDim Preserve windows(windowsCount + 100)
		End If
		' Store the new item.
		windowsCount += 1
		windows(windowsCount) = hWnd
		' Return 1 to continue enumeration.
		Return 1
	End Function

	' Return the caption/text of a window.
	
	Public Function WindowText(ByVal hWnd As Integer) As String
		Dim buffer As New VB6FixedString(256)
		Dim length As Integer
		length = GetWindowText(hWnd, buffer.Value, Len6(buffer.Value))
		Return VB.Left(buffer.Value, length)
	End Function

	Public Function WindowClassName(ByVal hWnd As Integer) As String
		Dim buffer As New VB6FixedString(256)
		Dim length As Integer
		length = GetClassName(hWnd, buffer.Value, Len6(buffer.Value))
		Return VB.Left(buffer.Value, length)
	End Function

	Public Function WindowDescription(ByVal hWnd As Integer) As String
		Dim text As String = WindowText(hWnd)
		
		WindowDescription = "[" & VB.Right("0000000" & Hex(hWnd), 8) & "] " & WindowClassName(hWnd)
		If Len6(text) Then 
			Return WindowDescription & " - """ & text & """"
		End If
	End Function

End Module

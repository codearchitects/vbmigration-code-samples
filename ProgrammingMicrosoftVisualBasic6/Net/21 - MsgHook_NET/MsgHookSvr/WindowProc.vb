' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

' --------------------------------------------

Public Structure WindowInfoUDT

	Public hWnd As Integer ' Handle of window being subclassed
	Public oldWndProc As Integer ' Address of original window procedure
	Public obj As MsgHook ' The MsgHook object serving this window
	' UPGRADENOTE: this item has been added because VB2005 delegate must be kept alive between GCs
	Public newWndProc As SetWindowLong_CBK
End Structure

' List of Public delegates used for callback methods
Public Delegate Function SetWindowLong_CBK(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

Friend Module WindowProc

	Declare Function IsWindow Lib "user32" (ByVal hWnd As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowLong' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Parent, System.Windows.Forms.Form.CreateParams.ExStyle, System.Windows.Forms.Form.CreateParams.Style, System.Windows.Forms.Form, System.Windows.Forms.Form
	Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal ndx As Integer, ByVal newValue As Integer) As Integer
	Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal ndx As Integer, ByVal newValue As SetWindowLong_CBK) As Integer
	Declare Function CallWindowProc Lib "user32" Alias "CallWindowProcA" (ByVal lpPrevWndFunc As Integer, ByVal hWnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	' This is used with the SetWindowLong API function.
	Private Const GWL_WNDPROC As Short = -4
	' The message all windows receive before being closed.
	Private Const WM_DESTROY As Short = &H2S
	
	' This array stores info on subclassed windows.
	Private WindowInfo() As WindowInfoUDT
	' This is the number of elements in the array.
	Private WindowInfoCount As Integer
	
	'------------------------------------------------------
	' The subclassing routines
	'------------------------------------------------------
	
	' Start the subclassing of a window.
	
	Public Sub HookWindow(ByRef obj As MsgHook, ByVal hWnd As Integer)
	' UPGRADE_INFO (#0551): The 'obj' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		' Make room in the array, if necessary
		If WindowInfoCount = 0 Then 
			ReDim WindowInfo(10)
		ElseIf WindowInfoCount > UBound6(WindowInfo) Then 
			ReDim Preserve WindowInfo(WindowInfoCount + 9)
		End If
		WindowInfoCount += 1
		
		' Store data in the array, and start the subclassing of this window
		With WindowInfo(WindowInfoCount)
			.hWnd = hWnd
			.obj = obj
			.newWndProc = AddressOf WndProc
			.oldWndProc = SetWindowLong(hWnd, GWL_WNDPROC, .newWndProc)
		End With
	End Sub

	' Stop the subclassing of the window associated to an object.
	
	Public Sub UnhookWindow(ByRef obj As MsgHook)
	' UPGRADE_INFO (#0551): The 'obj' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		' UPGRADE_INFO (#0501): The 'objPointer' member isn't used anywhere in current application.
		Dim objPointer As Integer
		
		For i = 1 To WindowInfoCount
			If WindowInfo(i).obj Is obj Then 
				' Stop subclassing.
				SetWindowLong(WindowInfo(i).hWnd, GWL_WNDPROC, WindowInfo(i).oldWndProc)
				' Remove this element from the array.
				WindowInfo(i) = WindowInfo(WindowInfoCount)
				WindowInfo(WindowInfoCount) = WindowInfo(0)
				WindowInfoCount -= 1
				Exit For
			End If
		Next
	End Sub

	' The custom window procedure
	
	Public Function WndProc(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		Dim i As Integer
		Dim obj As MsgHook = Nothing
		
		' Search this handle in the array.
		For i = 1 To WindowInfoCount
			If WindowInfo(i).hWnd = hWnd Then 
				' The client program is not in break mode.
				' Notify the object that a message has arrived.
				obj = WindowInfo(i).obj
				WndProc = obj.WndProc(hWnd, uMsg, wParam, lParam, WindowInfo(i).oldWndProc)
				
				' If we've got a WM_DESTROY message, the window is about to be closed
				' therefore there is no point in keeping this object in the array.
				If uMsg = WM_DESTROY Then 
					WindowInfo(i).obj.StopSubclass()
				End If
				
				' Nothing else to do (this version of the component
				' doesn't support multiple objects that subclass the same window.
				Exit For
			End If
		Next
	End Function

End Module

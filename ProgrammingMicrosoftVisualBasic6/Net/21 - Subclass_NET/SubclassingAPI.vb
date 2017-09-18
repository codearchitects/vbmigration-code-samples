' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module SubclassingAPI

	' Some message constants.
	Private Const WM_MOVE As Short = &H3S
	Private Const WM_SIZING As Short = &H214S
	Private Const WM_ACTIVATEAPP As Short = &H1CS
	
	' --------------------------------------------
	
	Dim subclasser As VB6WindowSubclasser
	
	Public Sub StartSubclassing(ByVal hWnd As Integer)
		subclasser = New VB6WindowSubclasser(hWnd, AddressOf WndProc)
	End Sub

	Public Sub StopSubclassing()
		subclasser.Dispose()
	End Sub

	Public Function WndProc(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		' Send the message to the original window procedure, and then
		' return Windows the return value from the original procedure.
		
		WndProc = subclasser.CallWindowProc(hWnd, uMsg, wParam, lParam)
		
		' See if this is one of the messages we're waiting for.
		' In this demo we simply show an informative message in the window.
		Select Case uMsg
		Case WM_MOVE
			NotifyMsg("Windows has moved")
		Case WM_SIZING
			NotifyMsg("Windows is being resized")
		Case WM_ACTIVATEAPP
			If wParam Then 
				NotifyMsg("The application got the focus")
			Else
				NotifyMsg("The application lost the focus")
			End If
		End Select
	End Function

	' Notify the event to the window. In this demo we simply
	' add an element in a ListBox control.
	
	Public Sub NotifyMsg(ByRef text As String)
	' UPGRADE_INFO (#0551): The 'text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Form1.lstMessages.AddItem(text)
		Form1.lstMessages.ListIndex = Form1.lstMessages.ListCount - 1
	End Sub

End Module

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Private WithEvents FormHook As MsgHookSvr.MsgHook
	Private WithEvents TextBoxHook As MsgHookSvr.MsgHook
	Private Sub Form_Load() Handles MyBase.Load
		FormHook = New MsgHookSvr.MsgHook()
		FormHook.StartSubclass(hWnd)
		TextBoxHook = New MsgHookSvr.MsgHook()
		TextBoxHook.StartSubclass(txtEditor.hWnd)
	End Sub

	Private Sub cmdClearList_Click() Handles cmdClearList.Click
		lstEvents.Clear()
	End Sub

	' Add an item to the event list.
	
	Private Sub ShowEvent(ByRef text As String)
	' UPGRADE_INFO (#0551): The 'text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		lstEvents.AddItem(text)
		lstEvents.ListIndex = lstEvents.ListCount - 1
	End Sub

	Private Sub FormHook_BeforeMessage(ByRef hWnd As Integer, ByRef uMsg As Integer, ByRef wParam As Integer, ByRef lParam As Integer, ByRef retValue As Integer, ByRef Cancel As Boolean) Handles FormHook.BeforeMessage
		Dim lpRect As RECT
		Select Case uMsg
		Case WM_PAINT
			' Windows is requesting the window to repaint itself
			GetUpdateRect(hWnd, lpRect, CShort(False))
			With lpRect
				ShowEvent("About to repaint rectangle (" & .Left & "," & .Top & ")-(" & .Right & "," & .Bottom & ")")
			End With
		End Select
	End Sub

	Private Sub FormHook_AfterMessage(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer, ByRef retValue As Integer) Handles FormHook.AfterMessage
		Dim mmInfo As APIDeclares.MINMAXINFO
		Dim menuId As Integer
		Dim menuCaption As String = ""
		Dim length As Integer
		Dim menuDescr As String = ""
		Select Case uMsg
		Case WM_MOVE
			' The form has moved.
			ShowEvent("Move")
		Case WM_ACTIVATEAPP
			' The application has been activated or deactivated.
			If wParam Then 
				ShowEvent("The application is being activated")
			Else
				ShowEvent("The application is being deactivated")
			End If
		Case WM_DISPLAYCHANGE
			' The screen resolution has changed.
			ShowEvent("Screen resolution has changed")
		Case WM_TIMECHANGE
			' System date/time has changed.
			ShowEvent("System time has changed")
		Case WM_COMPACTING
			' Windows is low in memory (release resources if possible).
			ShowEvent("Windows is compacting memory")
		Case WM_QUERYOPEN
			' The iconized form is being restored.
			ShowEvent("The iconized window is about to be restored")
			' Uncomment the next line to prevent the window from being restored.
			' retValue = False
		Case WM_GETMINMAXINFO
			' Windows is querying the form for its
			' minimum and maximum size and position.
			' Read contents of structure pointed to by lParam.
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'lParam' argument. Consider creating an overload of the Declare statement.
			CopyMemory(mmInfo, lParam, Len6(mmInfo))
			With mmInfo
				' ptMaxSize is the size of the maximized form.
				.ptMaxSize.X = 600
				.ptMaxSize.Y = 400
				' ptMaxPosition is the position of the maximized form.
				.ptMaxPosition.X = ((Screen6.Width / Screen6.TwipsPerPixelX) - 600) \ 2
				.ptMaxPosition.Y = ((Screen6.Height / Screen6.TwipsPerPixelY) - 400) \ 2
				' ptMinTrackSize is the minimum size of a form when resizing with the mouse.
				.ptMinTrackSize.X = 300
				.ptMinTrackSize.Y = 200
				' ptMinTrackSize is the maximum size of a form when resizing with the mouse.
				' (It is usually equal to ptMaxSize.)
				.ptMaxTrackSize.X = 600
				.ptMaxTrackSize.Y = 400
			End With
			' Copy back in the original structure in memory.
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'lParam' argument. Consider creating an overload of the Declare statement.
			CopyMemory(lParam, mmInfo, Len6(mmInfo))
			' Must return zero to inform that the structure has been modified.
			retValue = 0
		Case WM_COMMAND
			' The user selects a command item from a menu,
			' or a control sends a notification message to its parent window,
			' or an accelerator keystroke is translated.
			
			' If this is a notification from a control, lParam holds its handle.
			
			If lParam = txtEditor.hWnd Then 
				' In this case, the notification message is in the
				' high-order word of wParam.
				' NOTE: this msg doesn't arrive if the scroll bar indicator is scrolled.
				Select Case (wParam \ &H10000)
				Case EN_HSCROLL
					ShowEvent("The TextBox control has been scrolled horizontally")
				Case EN_VSCROLL
					ShowEvent("The TextBox control has been scrolled vertically")
				End Select
			End If
		Case WM_MENUSELECT
			' A menu has been selected (but not clicked yet).
			' The menu item identifier is in the low-order word of wParam.
			' The menu handle is in lParam
			menuId = (wParam And &HFFFF%)
			' Get the menu caption
			menuCaption = Space(256)
			length = GetMenuString(lParam, menuId, menuCaption, Len6(menuCaption), 0)
			menuCaption = VB.Left(menuCaption, length)
			
			Select Case menuCaption
			Case "&New"
				menuDescr = "Create a new file"
			Case "&Open"
				menuDescr = "Open an existing file"
			Case "&Save"
				menuDescr = "Save a file to disk"
			Case "E&xit"
				menuDescr = "Exit the program"
			End Select
			lblStatus.Caption = menuDescr
			
		End Select
	End Sub

	Private Sub TextBoxHook_BeforeMessage(ByRef hWnd As Integer, ByRef uMsg As Integer, ByRef wParam As Integer, ByRef lParam As Integer, ByRef retValue As Integer, ByRef Cancel As Boolean) Handles TextBoxHook.BeforeMessage
		If uMsg = WM_CONTEXTMENU Then 
			' Show a custom popup menu.
			PopupMenu(mnuPopup)
			' Cancel the default processing (i.e. the default context menu).
			Cancel = True
		End If
	End Sub

	Private Sub mnuPopupItem_Click(ByRef Index As Short)
		MsgBox6("Custom context menu for TextBox controls!", MsgBoxStyle.Exclamation)
	End Sub

End Class

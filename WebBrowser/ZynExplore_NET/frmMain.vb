' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	'autocomplete textbox
	' UPGRADE_INFO (#0501): The 'SHACF_AUTOAPPEND_FORCE_OFF' member isn't used anywhere in current application.
	Private Const SHACF_AUTOAPPEND_FORCE_OFF As Integer = &H80000000I
	' UPGRADE_INFO (#0501): The 'SHACF_AUTOAPPEND_FORCE_ON' member isn't used anywhere in current application.
	Private Const SHACF_AUTOAPPEND_FORCE_ON As Integer = &H40000000I
	' UPGRADE_INFO (#0501): The 'SHACF_AUTOSUGGEST_FORCE_OFF' member isn't used anywhere in current application.
	Private Const SHACF_AUTOSUGGEST_FORCE_OFF As Integer = &H20000000I
	' UPGRADE_INFO (#0501): The 'SHACF_AUTOSUGGEST_FORCE_ON' member isn't used anywhere in current application.
	Private Const SHACF_AUTOSUGGEST_FORCE_ON As Integer = &H10000000I
	Private Const SHACF_DEFAULT As Short = &H0S
	' UPGRADE_INFO (#0501): The 'SHACF_FILESYSTEM' member isn't used anywhere in current application.
	Private Const SHACF_FILESYSTEM As Short = &H1S
	Private Const SHACF_URLHISTORY As Short = &H2S
	Private Const SHACF_URLMRU As Short = &H4S
	' UPGRADE_INFO (#0501): The 'SHACF_USETAB' member isn't used anywhere in current application.
	Private Const SHACF_USETAB As Short = &H8S
	' UPGRADE_INFO (#0501): The 'SHACF_URLALL' member isn't used anywhere in current application.
	Private Const SHACF_URLALL As Integer = (SHACF_URLHISTORY Or SHACF_URLMRU)
	Private Declare Sub SHAutoComplete Lib "shlwapi.dll" (ByVal hwndEdit As Integer, ByVal dwFlags As Integer)
	
	'progress bar in status bar
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetParent' unamanged method with the following .NET member(s): System.Windows.Forms.Form.Parent
	Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
	Private X As Short
	Private Y As Short
	' UPGRADE_INFO (#0501): The 'myURL' member isn't used anywhere in current application.
	Private myURL As String = ""
	Private myCol As New Collection
	Private blnGoBack As Boolean
	Private blnGoForward As Boolean

	Private Sub CmdGo_Click() Handles cmdGo.Click
		'preventing unwanted runtime scriipting error
		WebBrowser1.Silent = True
		WebBrowser1.Navigate((Text1.Text))
	End Sub

	Private Sub cmdGo_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles cmdGo.MouseMove
		'set tooltip
		cmdGo.ToolTipText = "Go to " & "'' " & Text1.Text & " ''"
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		On Error Resume Next 
		' UPGRADE_INFO (#0501): The 'GetURL' member isn't used anywhere in current application.
		Dim GetURL As String = ""
		SHAutoComplete(Text1.hWnd, SHACF_DEFAULT)
		WebBrowser1.Navigate("www.google.com")
		Text1.Text = "www.google.com"
		
		'setparent
		SetParent(ProgressBar1.hWnd, StatusBar1.hWnd)
		ProgressBar1.Top = 55
		
		'position
		ProgressBar1.Left = StatusBar1.Panels(1).Width + 60

		ProgressBar1.Width = StatusBar1.Panels(2).Width - 50
		ProgressBar1.Height = StatusBar1.Height - 90
		
		'Just tested this one on favorites im getting lazy with this
		'try to continue this one put the favs on the dat file
		'GetURL = GetSetting(App.EXEName, "Favorites", "URL")
		'Load nmeAddFav(nmeAddFav.UBound + 1)
		'nmeAddFav(nmeAddFav.UBound).Caption = GetURL
		'nmeAddFav(nmeAddFav.UBound).Visible = True
		
	End Sub

	Private Sub nmeAbout_Click() Handles nmeAbout.Click
		frmAbout.Show()
	End Sub

	Private Sub nmeAddFav_Click(ByRef Index As Short)
		'add favs to runtime
		If nmeAddFav(0).Enabled Then 
			If MsgBox6("Do you wish to add " & Text1.Text & " to favorites?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then 
				nmeAddFav.Load(nmeAddFav.UBound() + 1)
				nmeAddFav(nmeAddFav.UBound()).Caption = Text1.Text
				nmeAddFav(nmeAddFav.UBound()).Tag = Text1.Text
				nmeAddFav(nmeAddFav.UBound()).Visible = True
			Else
				Exit Sub
			End If
			
		Else
			'MsgBox mnuSub(Index).Caption
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'nmeAddFav(Index).Tag'. Consider using the GetDefaultMember6 helper method.
			WebBrowser1.Navigate(nmeAddFav(Index).Tag)
		End If
	End Sub

	Private Sub nmeCopy_Click() Handles nmeCopy.Click
		'copy the page
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_COPY, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	Private Sub nmeExit_Click() Handles nmeExit.Click
		Unload6(Me)
	End Sub

	Private Sub nmeOffline_Click() Handles nmeOffline.Click
		'offline settings
		If nmeOffline.Checked = True Then 
			nmeOffline.Checked = False
			' UPGRADE_ISSUE (#1F68): The Offline property isn't supported. This replacement property retains the value assigned to it, but has no effect.
			WebBrowser1.Offline = False
		Else
			nmeOffline.Checked = True
			' UPGRADE_ISSUE (#1F68): The Offline property isn't supported. This replacement property retains the value assigned to it, but has no effect.
			WebBrowser1.Offline = True
		End If
	End Sub

	Private Sub nmeOpen_Click() Handles nmeOpen.Click
		'open file
		CommonDialog1.Filter = "Web Page (*.html)|*.html|All File (*.*)|*.*"
		CommonDialog1.ShowOpen()
		WebBrowser1.Navigate(CommonDialog1.FileName)
	End Sub

	'paste
	Private Sub nmePaste_Click() Handles nmePaste.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PASTE, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'print
	Private Sub nmePrint_Click() Handles nmePrint.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PRINT, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
	End Sub

	'page properties
	Private Sub nmeProp_Click() Handles nmeProp.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PROPERTIES, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'page setup
	Private Sub nmePsetup_Click() Handles nmePsetup.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PAGESETUP, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'print preview
	Private Sub nmePview_Click() Handles nmePview.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PRINTPREVIEW, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'save
	Private Sub nmeSave_Click() Handles nmeSave.Click
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_SAVEAS, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'select all
	Private Sub nmeSelAll_Click() Handles nmeSelAll.Click
		WebBrowser1.SetFocus()
		WebBrowser1.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_SELECTALL, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT)
	End Sub

	'show source
	Private Sub nmeSource_Click() Handles nmeSource.Click
		frmSource.Show()
	End Sub

	'new window
	Private Sub nmeWin_Click() Handles nmeWin.Click
		Dim runApp As Double = Shell(App6.Path & "\" & App6.EXEName)
	End Sub

	Private Sub text1_Click() Handles Text1.Click
		'select all
		Text1.SelStart = 0
		Text1.SelLength = Len6(Text1.Text)
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal Button As VB6Button) Handles Toolbar1.ButtonClick
		On Error Resume Next 
		Select Case Button.Index
		Case 1
			X += 1
			Y -= 1
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'myCol.Item(X - 1)'. Consider using the GetDefaultMember6 helper method.
			Toolbar1.Buttons(2).ButtonMenus.Add(, , myCol.Item(X - 1))
			Toolbar1.Buttons(1).ButtonMenus.Remove((X - 1))
			blnGoBack = True
			WebBrowser1.GoBack()
			blnGoBack = False
		Case 2
			X -= 1
			Y += 1
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'myCol.Item(Y - 1)'. Consider using the GetDefaultMember6 helper method.
			Toolbar1.Buttons(1).ButtonMenus.Add(, , myCol.Item(Y - 1))
			Toolbar1.Buttons(2).ButtonMenus.Remove((Y - 1))
			blnGoForward = True
			WebBrowser1.GoForward()
			blnGoForward = False
		Case 3
			WebBrowser1.Stop()
		Case 4
			WebBrowser1.Refresh()
		Case 5
			WebBrowser1.Navigate("www.google.com.ph")
		End Select
	End Sub

	' UPGRADE_WARNING (#1D04): The pDisp, Flags, PostData and Headers parameters of the BeforeNavigate2 event are not supported, and are always Nothing.
	Private Sub WebBrowser1_BeforeNavigate2(ByVal pDisp As Object, ByRef URL As Object, ByRef Flags As Object, ByRef TargetFrameName As Object, ByRef PostData As Object, ByRef Headers As Object, ByRef Cancel As Boolean) Handles WebBrowser1.BeforeNavigate2
		
		'you can add filters here. Sample you don't want the users to browse youtube
		'so you include the keywords from below
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'URL'. Consider using the GetDefaultMember6 helper method.
		If InStr(1, URL, ".avi") > 0 Or InStr(1, URL, ".wmv") > 0 Or InStr(1, URL, "youtube") Then 
			MsgBox6("Can not view this page")
			Cancel = True
		End If
		
	End Sub

	' UPGRADE_WARNING (#1D24): The pDisp and URL parameters of the DocumentComplete event aren't supported, and are always Nothing.
	Private Sub WebBrowser1_DocumentComplete(ByVal pDisp As Object, ByRef URL As Object) Handles WebBrowser1.DocumentComplete
		On Error Resume Next 
		Dim HTML As mshtml.HTMLDocument = Nothing 'Notice the changes here
		Dim AHREF As mshtml.HTMLAnchorElement = Nothing 'and Here
		' UPGRADE_ISSUE (#1F38): The Application property isn't supported. This replacement property always returns Nothing.
		If (pDisp Is WebBrowser1.Application) Then 

			HTML = WebBrowser1.Document 'Set the Doc to the HTML object
			
			For Each AHREF In HTML.links 'Take note when you type '.' look at all the goodies!
				
				'look in the AHREF object as well....
				
				'in this case we will use 2 different parts of the AHREF object to
				
				'filter out.. the href, and the innerText
				
				If InStr(AHREF.href, "google") = 0 And AHREF.innerText <> "Cached" Then 
					
					'Debug.Print AHREF.href

				End If
				
			Next
			
		End If

		'prevent adding from the collection
		If blnGoBack Or blnGoForward Then  Exit Sub
		
		Y += 1
		X += 1
		myCol.Add(Text1.Text)
		
		If X = 1 Then  Exit Sub
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'myCol.Item(X - 1)'. Consider using the GetDefaultMember6 helper method.
		Toolbar1.Buttons(1).ButtonMenus.Add(, , myCol.Item(X - 1))

	End Sub

	' UPGRADE_ISSUE (#1D78): The pDisp parameter of the NewWindow2 event isn't supported, and is always Nothing.
	Private Sub WebBrowser1_NewWindow2(ByRef ppDisp As Object, ByRef Cancel As Boolean) Handles WebBrowser1.NewWindow2
		'Here is a sample that grabs the new window and starts
		'a New Copy of the current form
		
		Dim frm As New frmMain 'Declare frm as a New copy of Form1
		
		' UPGRADE_ISSUE (#1F78): The RegisterAsBrowser property isn't supported. This replacement property retains the value assigned to it, but has no effect.
		frm.WebBrowser1.RegisterAsBrowser = True 'Register it with windows
		
		' UPGRADE_ISSUE (#1498): The Object property isn't supported. This replament property returns a reference to the control itself.
		ppDisp = frm.WebBrowser1.Object 'Set the ppDisp = to your new form
		
		frm.Show() 'Display it
		
		'The new Webpage will load in a new instance of your form
		
	End Sub

	Private Sub WebBrowser1_CommandStateChange(ByVal Command As Integer, ByVal Enable As Boolean) Handles WebBrowser1.CommandStateChange
		
		'back and forward buttons
		'disabling and enabling
		On Error Resume Next 
		
		DoEvents6(): DoEvents6(): DoEvents6()
		If Enable = True And Command = SHDocVwCtl.CommandStateChangeConstants.CSC_NAVIGATEBACK Then 
			
			Toolbar1.Buttons(1).Enabled = True
			
		ElseIf Enable = False And Command = SHDocVwCtl.CommandStateChangeConstants.CSC_NAVIGATEBACK Then 
			
			Toolbar1.Buttons(1).Enabled = False
			
		End If
		
		If Enable = True And Command = SHDocVwCtl.CommandStateChangeConstants.CSC_NAVIGATEFORWARD Then 
			
			Toolbar1.Buttons(2).Enabled = True
			
		ElseIf Enable = False And Command = SHDocVwCtl.CommandStateChangeConstants.CSC_NAVIGATEFORWARD Then 
			
			Toolbar1.Buttons(2).Enabled = False
			
		End If
		
		'put the current location to the textbox
		Text1.Text = WebBrowser1.LocationURL
		
	End Sub

	Private Sub WebBrowser1_ProgressChange(ByVal Progress As Integer, ByVal ProgressMax As Integer) Handles WebBrowser1.ProgressChange
		On Error Resume Next 
		ProgressBar1.Max = ProgressMax
		ProgressBar1.Value = Progress
		
	End Sub

	' UPGRADE_ISSUE (#1DE8): The Text parameter of the StatusTextChanged event isnt't supported, and is always Nothing.
	Private Sub WebBrowser1_StatusTextChange(ByVal Text As String) Handles WebBrowser1.StatusTextChange
		'status bar
		StatusBar1.Panels(1).Text = Text
	End Sub

	'auto resize/scale function for any screen resolution
	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		Me.WebBrowser1.Height = Me.Height - 2350
		Me.WebBrowser1.Width = Me.Width - 100
		StatusBar1.Panels(1).Width = Me.Width - 3650
		Frame1.Width = Me.Width - 120
		ProgressBar1.Left = StatusBar1.Panels(1).Width + 60
		Text1.Width = Me.Width - 2220
		cmdGo.Left = Text1.Width + 1185
	End Sub

	'change the title of the form
	' UPGRADE_ISSUE (#1DF8): The TitleChange event is not supported.
	Private Sub WebBrowser1_TitleChange(ByVal Text As String) Handles WebBrowser1.TitleChange
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmMain' was converted to Me keyword.
		Me.Caption = "ZynExplore - " & Text
	End Sub

End Class

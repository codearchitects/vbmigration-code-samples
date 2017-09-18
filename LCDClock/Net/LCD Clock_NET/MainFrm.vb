' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class MainFrm

	Private Lastx As Integer
	Private Lasty As Integer
	Private Saveleft As Integer
	Private Savetop As Integer
	Private DelayCounter As Integer
	Private Amer_Euro As Boolean
	Private TopMost_Renamed As Boolean
	Private Startup As Boolean
	Public ShowAbout As Integer
	
	Private Const LWA_COLORKEY As Short = &H1S
	Private Const GWL_EXSTYLE As Short = (-20)
	Private Const WS_EX_LAYERED As Integer = &H80000I
	' UPGRADE_INFO (#0501): The 'BM_SETSTATE' member isn't used anywhere in current application.
	Private Const BM_SETSTATE As Short = &HF3S
	
	Private Const HWND_TOPMOST As Short = -1
	Private Const HWND_NOTOPMOST As Short = -2
	Private Const SWP_NOSIZE As Short = &H1S
	Private Const SWP_NOMOVE As Short = &H2S
	Private Const SWP_NOACTIVATE As Short = &H10S
	Private Const SWP_SHOWWINDOW As Short = &H40S
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowPos' unamanged method with the following .NET member(s): System.Windows.Forms.Form.BringToFront, System.Windows.Forms.Form.Enabled, System.Windows.Forms.Form.SendToBack, System.Windows.Forms.Form.SetBounds, System.Windows.Forms.Form.TopMost, System.Windows.Forms.Form.Visible
	Private Declare Sub SetWindowPos Lib "User32" (ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetWindowLong' unamanged method with the following .NET member(s): System.ComponentModel.Component.Events, System.Windows.Forms.Control.Parent, System.Windows.Forms.Form.CreateParams.ExStyle, System.Windows.Forms.Form.CreateParams.Style, System.Windows.Forms.Form
	Private Declare Function GetWindowLong Lib "User32" Alias "GetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowLong' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Parent, System.Windows.Forms.Form.CreateParams.ExStyle, System.Windows.Forms.Form.CreateParams.Style, System.Windows.Forms.Form, System.Windows.Forms.Form
	Private Declare Function SetWindowLong Lib "User32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	' UPGRADE_INFO (#0501): The 'ReleaseCapture' member isn't used anywhere in current application.
	Private Declare Function ReleaseCapture Lib "user32.dll" () As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' UPGRADE_INFO (#0501): The 'SendMessage' member isn't used anywhere in current application.
	' IGNORED: Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetLayeredWindowAttributes' unamanged method with the following .NET member(s): System.Windows.Forms.Form.Opacity, System.Windows.Forms.Form.TransparencyKey
	Private Declare Function SetLayeredWindowAttributes Lib "user32.dll" (ByVal hWnd As Integer, ByVal crKey As Integer, ByVal bAlpha As Byte, ByVal dwFlags As Integer) As Integer
	
	Private Sub Form_Load() Handles MyBase.Load
		Dim Ret As Integer
		Dim CLR As Integer = RGB(255, 255, 255)
		'this color is the color that will be transparent
		'Set the window style to 'Layered'
		Ret = GetWindowLong(Me.hWnd, GWL_EXSTYLE)
		Ret = Ret Or WS_EX_LAYERED
		SetWindowLong(Me.hWnd, GWL_EXSTYLE, Ret)
		'Set the opacity of the layered window to 128
		SetLayeredWindowAttributes(Me.hWnd, CLR, 0, LWA_COLORKEY)
		'Load Settings from registery
		LoadSettings()
		'Set these settings
		Me.Left = Saveleft
		Me.Top = Savetop
		SetTopMost()
		SetStartUp()
		AboutFrm.Check1.Value = ShowAbout
		If ShowAbout Then  AboutFrm.Show()
	End Sub
	
	Private Sub Image2_MouseDown(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Select Case Index
		Case 14
			Startup = Not Startup
			SetStartUp()
		Case 15
			TopMost_Renamed = Not TopMost_Renamed
			SetTopMost()
			SaveSettings()
		Case 16
			Lastx = X
			Lasty = Y
		Case 17
			Amer_Euro = Not Amer_Euro
			SaveSettings()
		Case 18
			AboutFrm.Show()
		Case 19
			Me.Hide()
			DelayCounter = 0
			Timer2.Interval = 100
		Case 20
			Application.Exit(): End
		End Select
	End Sub
	
	Private Sub Image2_MouseMove(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Select Case Index
		Case 16
			If Button = 1 Then 
				Me.Left = Me.Left + (X - Lastx)
				Me.Top = Me.Top + (Y - Lasty)
			End If
		End Select
	End Sub
	
	Private Sub Image2_MouseUp(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		SaveSettings()
	End Sub
	
	Private Sub Timer1_Timer() Handles Timer1.Timer
		Image2(0).Picture = Image1(Mid(TimeString, 1, 1)).Picture
		Image2(1).Picture = Image1(Mid(TimeString, 2, 1)).Picture
		Image2(2).Picture = Image1(Mid(TimeString, 4, 1)).Picture
		Image2(3).Picture = Image1(Mid(TimeString, 5, 1)).Picture
		Image2(4).Picture = Image1(Mid(TimeString, 7, 1)).Picture
		Image2(5).Picture = Image1(Mid(TimeString, 8, 1)).Picture
		If Amer_Euro Then 
			Image2(6).Picture = Image1(Mid(DateString, 1, 1)).Picture
			Image2(6).ToolTipText = "Month"
			Image2(7).Picture = Image1(Mid(DateString, 2, 1)).Picture
			Image2(7).ToolTipText = "Month"
			Image2(8).Picture = Image1(Mid(DateString, 4, 1)).Picture
			Image2(8).ToolTipText = "Day"
			Image2(9).Picture = Image1(Mid(DateString, 5, 1)).Picture
			Image2(9).ToolTipText = "Day"
		Else
			Image2(8).Picture = Image1(Mid(DateString, 1, 1)).Picture
			Image2(8).ToolTipText = "Month"
			Image2(9).Picture = Image1(Mid(DateString, 2, 1)).Picture
			Image2(9).ToolTipText = "Month"
			Image2(6).Picture = Image1(Mid(DateString, 4, 1)).Picture
			Image2(6).ToolTipText = "Day"
			Image2(7).Picture = Image1(Mid(DateString, 5, 1)).Picture
			Image2(7).ToolTipText = "Day"
		End If
		Image2(10).Picture = Image1(Mid(DateString, 7, 1)).Picture
		Image2(11).Picture = Image1(Mid(DateString, 8, 1)).Picture
		Image2(12).Picture = Image1(Mid(DateString, 9, 1)).Picture
		Image2(13).Picture = Image1(Mid(DateString, 10, 1)).Picture
	End Sub
	
	Private Sub SetStartUp()
		If (Startup) Then 
			Image2(14).ToolTipText = "Run Manually"
			SaveString(HKEY_LOCAL_MACHINE, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "LCD Clock", App6.Path & "\" & App6.EXEName & ".exe")
			SaveSettings()
		Else
			Image2(14).ToolTipText = "Run When Windows Starts Up"
			SaveString(HKEY_LOCAL_MACHINE, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "LCD Clock", "<NonRun>")
			SaveSettings()
		End If
	End Sub
	
	Private Sub SetTopMost()
		If TopMost_Renamed Then 
			SetWindowPos(Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE)
			Image2(15).ToolTipText = "Make Not Always On Top"
		Else
			SetWindowPos(Me.hWnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE)
			Image2(15).ToolTipText = "Make Always On Top"
		End If
	End Sub
	
	Private Sub LoadSettings()
		Saveleft = GetSetting("LCD Clock", "Settings", "Left", 0)
		Savetop = GetSetting("LCD Clock", "Settings", "Top", 0)
		Amer_Euro = GetSetting("LCD Clock", "Settings", "AmerEuro", True)
		TopMost_Renamed = GetSetting("LCD Clock", "Settings", "TopMost", True)
		Startup = GetSetting("LCD Clock", "Settings", "Startup", False)
		ShowAbout = GetSetting("LCD Clock", "Settings", "ShowAbout", 1)
	End Sub
	
	Public Sub SaveSettings()
		Call SaveSetting("LCD Clock", "Settings", "Left", Me.Left)
		Call SaveSetting("LCD Clock", "Settings", "Top", Me.Top)
		Call SaveSetting("LCD Clock", "Settings", "AmerEuro", Amer_Euro)
		Call SaveSetting("LCD Clock", "Settings", "TopMost", TopMost_Renamed)
		Call SaveSetting("LCD Clock", "Settings", "Startup", Startup)
		Call SaveSetting("LCD Clock", "Settings", "ShowAbout", ShowAbout)
	End Sub
	
	Private Sub Timer2_Timer() Handles Timer2.Timer
		DelayCounter += 1
		If DelayCounter >= 100 Then 
			Me.Show()
			Timer2.Interval = 0
		End If
	End Sub

End Class

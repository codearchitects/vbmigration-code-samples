' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module mdul_Main

	Public Const MAX_TOOLTIP As Short = 64
	Public Const NIF_ICON As Short = &H2S
	Public Const NIF_MESSAGE As Short = &H1S
	Public Const NIF_TIP As Short = &H4S
	Public Const NIM_ADD As Short = &H0S
	Public Const NIM_DELETE As Short = &H2S
	Public Const WM_MOUSEMOVE As Short = &H200S
	Public Const WM_LBUTTONDOWN As Short = &H201S
	Public Const WM_LBUTTONUP As Short = &H202S
	Public Const WM_LBUTTONDBLCLK As Short = &H203S
	Public Const WM_RBUTTONDOWN As Short = &H204S
	Public Const WM_RBUTTONUP As Short = &H205S
	Public Const WM_RBUTTONDBLCLK As Short = &H206S
	
	Friend Structure NOTIFYICONDATA
	
		Public cbSize As Integer
		Public hwnd As Integer
		Public uID As Integer
		Public uFlags As Integer
		Public uCallbackMessage As Integer
		Public hIcon As Integer
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=MAX_TOOLTIP)> _
		Private m_szTip As String
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			m_szTip = VB6FixedString.GetEmptyBuffer(MAX_TOOLTIP)
		End Sub
	
	#End Region

		Public Property szTip() As String
			Get
				Return VB6FixedString.Truncate(m_szTip, MAX_TOOLTIP, ControlChars.NullChar)
			End Get
			Set(ByVal value As String)
				m_szTip = VB6FixedString.Truncate(value, MAX_TOOLTIP)
			End Set
		End Property
	End Structure

	Public Declare Function Shell_NotifyIcon Lib "shell32.dll" Alias "Shell_NotifyIconA" (ByVal dwMessage As Integer, ByRef lpData As NOTIFYICONDATA) As Integer
	
	Public nfIconData As New NOTIFYICONDATA(True)
	Public v_rsPhoneBook As ADODB.Recordset
	Public pSystemTrayOnly As Boolean
	Public pPrintPageCount As Short
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	<STAThread()> _
	Public Sub Main()
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'FileName'. Consider using the GetDefaultMember6 helper method.
		If InStr(Command(), FileName) > 0 Then 
			
			Select Case UCase(VB.Left(Command(), 2))
			Case "/S"
				pSystemTrayOnly = True
			End Select
			
		End If
		
		With nfIconData
			.hwnd = frm_Main.hWnd
			.uID = frm_Main.Icon.Handle
			.uFlags = NIF_ICON Or NIF_MESSAGE Or NIF_TIP
			.uCallbackMessage = WM_MOUSEMOVE
			.hIcon = frm_Main.Icon.Handle
			.szTip = "Phone Book" & ControlChars.NullChar
			.cbSize = Len6(nfIconData)
		End With
		Call Shell_NotifyIcon(NIM_ADD, nfIconData)
		
		If pSystemTrayOnly Then 
			Exit Sub
		End If
		
		frm_Main.Show()
	End Sub

	Public Sub MakePrintPreview(Optional ByRef m_PageNo As Short = 0)
	' UPGRADE_INFO (#0551): The 'm_PageNo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim v_rsPreview As New ADODB.RecordsetClass
		Dim v_sActiveConnection As String = ""
		' UPGRADE_INFO (#0561): The 'v_iCurrentX' symbol was defined without an explicit "As" clause.
		Dim v_iCurrentX As Object = Nothing
		Dim v_iCurrentY As Short
		Dim v_iPageCount As Short
		Dim v_iLoop As Short
		
		On Error GoTo Err 
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		v_rsPreview.Open("SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, ADODB.CursorTypeEnum.adOpenStatic)
		
		frm_PrintPreview.tbx_Page.Text = "1"
		v_iPageCount = Abs6(v_rsPreview.RecordCount / 63) + 1
		
		If m_PageNo = 0 Then 
			
			pPrintPageCount = v_iPageCount
			For v_iLoop = 2 To v_iPageCount
				frm_PrintPreview.ppi_PageNo.Load(v_iLoop)
				frm_PrintPreview.ppi_PageNo(v_iLoop).Caption = v_iLoop
				frm_PrintPreview.ppi_PageNo(v_iLoop).Visible = True
			Next
			
		End If
		
		With frm_PrintPreview
			.pic_Preview.Cls()
			.pic_Preview.CurrentX = 1440
			.pic_Preview.CurrentY = 1800
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'v_iCurrentX'. Consider using the SetDefaultMember6 helper method.
			v_iCurrentX = 1440
			v_iCurrentY = 1800
			
			.pic_Preview.FontBold = True
			.pic_Preview.Print("First Name")
			.pic_Preview.CurrentX = 2940
			.pic_Preview.Print("Last Name")
			.pic_Preview.CurrentX = 5140
			.pic_Preview.PrintLine("Telephone Number")
			
			.pic_Preview.FontBold = False
			
			If m_PageNo = 0 Then 
				
				While Not v_rsPreview.EOF
					If v_iCurrentY >= (.pic_Preview.ScaleHeight) - 1800 Then 
						v_iCurrentY = 1800
						Exit Sub
					End If
					
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					v_iCurrentY += .pic_Preview.TextHeight(v_rsPreview.Fields("FirstName").Value)
					.pic_Preview.CurrentX = 1440
					.pic_Preview.Print(v_rsPreview.Fields("FirstName"))
					.pic_Preview.CurrentX = 2940
					.pic_Preview.Print(v_rsPreview.Fields("LastName"))
					.pic_Preview.CurrentX = 5140
					.pic_Preview.PrintLine(v_rsPreview.Fields("TelNo"))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, Printer6.ScaleWidth - v_iCurrentX + 60, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 2860, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 5060, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					v_rsPreview.MoveNext()
				End While
				
			Else
				
				v_rsPreview.Move(((m_PageNo - 1) * 63))
				While Not v_rsPreview.EOF
					If v_iCurrentY >= (.pic_Preview.ScaleHeight) - 1800 Then 
						v_iCurrentY = 1800
						Exit Sub
					End If
					
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					v_iCurrentY += .pic_Preview.TextHeight(v_rsPreview.Fields("FirstName").Value)
					.pic_Preview.CurrentX = 1440
					.pic_Preview.Print(v_rsPreview.Fields("FirstName"))
					.pic_Preview.CurrentX = 2940
					.pic_Preview.Print(v_rsPreview.Fields("LastName"))
					.pic_Preview.CurrentX = 5140
					.pic_Preview.PrintLine(v_rsPreview.Fields("TelNo"))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, Printer6.ScaleWidth - v_iCurrentX + 60, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 2860, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPreview.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
					.pic_Preview.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 5060, v_iCurrentY + Printer6.TextHeight(v_rsPreview.Fields("FirstName").Value))
					v_rsPreview.MoveNext()
				End While
				
			End If
		End With
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

End Module

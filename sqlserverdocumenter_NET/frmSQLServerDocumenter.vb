' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmSQLServerDocumenter

	' ##########################################
	'
	' SQL Server Documenter
	'
	' Coded by RaiVeN for Da Londo Software
	' http://users.dalondo.2y.net/RaiVeN/
	'
	' This program may be used freely as long as you
	' keep a reference to me in it. Thnx! RaiVeN
	'
	' ##########################################

	' UPGRADE_INFO (#0531): You can replace calls to the 'SetCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	Private Declare Function SetCapture Lib "user32" (ByVal hwnd As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	Private Declare Function ReleaseCapture Lib "user32" () As Integer
	Private Declare Function GetCapture Lib "user32" () As Integer
	Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Private Const SW_NORMAL As Short = 1
	
	Private Sub cboDatabaseName_Click() Handles cboDatabaseName.Click
		
		Dim errhandle As VB6Label = Nothing
		
		' Fills the table combo with all user tables in the database
		
		On Error GoTo errhandle 
		
		Me.MousePointer = 11
		Fill_cboTableName()
		Me.MousePointer = 0
		Exit Sub
		
errhandle:
		Me.MousePointer = 0
		MsgBox6("An error occurred:" & ControlChars.CrLf & Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub cmdConnect_Click() Handles cmdConnect.Click
		
		Dim errhandle As VB6Label = Nothing
		
		On Error GoTo errhandle 
		
		' Connects to or disconnects from the database server, either using SQL or NT/2000 authentication.
		' Also controls the (de)activation of the username and password textboxes
		
		If cboSQLServerList.ListIndex < 1 Then 
			MsgBox6("Select a server", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		Select Case cmdConnect.Caption
		Case "Connect"
			lblStatus.Caption = "Connecting..."
			picConnectionStatus.Picture = imlConnectionStatus.ListImages(2).Picture
			lblStatus.Refresh()
			If optSQLAuth.Value = True Then 
				objSQLServer = New SQLDMO.SQLServer()
				objSQLServer.Connect(cboSQLServerList.Text, txtUserName.Text, txtPassword.Text)
				txtUserName.Enabled = False
				txtPassword.Enabled = False
			ElseIf optWinAuth.Value = True Then 
				objSQLServer = New SQLDMO.SQLServer()
				objSQLServer.LoginSecure = True
				objSQLServer.Connect(cboSQLServerList.Text)
			End If
			cmdConnect.Caption = "Disconnect"
			blnConnectionState = True
			Fill_cboDatabaseName()
			cboSQLServerList.Enabled = False
			optSQLAuth.Enabled = False
			optWinAuth.Enabled = False
			lblStatus.Caption = "Connected"
			picConnectionStatus.Picture = imlConnectionStatus.ListImages(1).Picture
		Case "Disconnect"
			lblStatus.Caption = "Disconnecting..."
			picConnectionStatus.Picture = imlConnectionStatus.ListImages(4).Picture
			lblStatus.Refresh()
			objSQLServer.DisConnect()
			objSQLServer = Nothing
			cmdConnect.Caption = "Connect"
			blnConnectionState = False
			cboSQLServerList.Enabled = True
			If optSQLAuth.Value = True Then 
				txtUserName.Enabled = True
				txtPassword.Enabled = True
			End If
			optSQLAuth.Enabled = True
			optWinAuth.Enabled = True
			cboDatabaseName.Clear()
			cboTableName.Clear()
			lsvTableData.ListItems.Clear()
			lblStatus.Caption = "Not Connected"
			picConnectionStatus.Picture = imlConnectionStatus.ListImages(3).Picture
		End Select

		Exit Sub
errhandle:
		lblStatus.Caption = "Connection Failed"
		picConnectionStatus.Picture = imlConnectionStatus.ListImages(5).Picture
		MsgBox6(Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub cmdExport2XLS_Click() Handles cmdExport2XLS.Click
		
		Dim errhandle As VB6Label = Nothing
		
		On Error GoTo errhandle 
		
		' Opens a dialog box and calls the "Exort2XLS" sub in modMain
		
		If cboTableName.Text = "" Then 
			MsgBox6("Select a table", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		Me.MousePointer = 11
		dlgExport.DialogTitle = "Export Excel File"
		dlgExport.DefaultExt = ".xls"
		dlgExport.Filter = "Excel Workbook|*.xls"
		dlgExport.ShowSave()
		
		If dlgExport.FileName = "" Then 
			Exit Sub
		End If
		
		Export2XLS(cboTableName.Text, dlgExport.FileName, cboSQLServerList.Text, cboDatabaseName.Text)
		
		Me.MousePointer = 0
		Exit Sub
errhandle:
		Me.MousePointer = 0
		MsgBox6(Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub cmdPreviewPrint_Click() Handles cmdPreviewPrint.Click
		
		Dim errhandle As VB6Label = Nothing
		
		On Error GoTo errhandle 
		
		' Writes the and HTML file to disk in the application path called "TMPPRT.DAT"
		' and opens it in the browser control on the frmPrintPreview form
		
		If cboTableName.Text = "" Then 
			MsgBox6("Select a table", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		PrintPreview(cboTableName.Text, cboDatabaseName.Text, cboSQLServerList.Text)
		
		frmPrintPreview.Show(1)
		
		Exit Sub
errhandle:
		MsgBox6(Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub cmdShowIndexes_Click() Handles cmdShowIndexes.Click
		
		Dim errhandle As VB6Label = Nothing
		
		On Error GoTo errhandle 
		
		' Formats the listview for indexes and lists all indexes in the table in the listview
		
		blnShowTable = False
		
		If cboTableName.ListIndex < 1 Then 
			MsgBox6("Please select a table", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		Me.MousePointer = 11
		Format_lsvIndex()
		Fill_lsvIndex()
		Me.MousePointer = 0
		
		Exit Sub
errhandle:
		Me.MousePointer = 0
		MsgBox6(Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub cmdShowTable_Click() Handles cmdShowTable.Click
		
		Dim errhandle As VB6Label = Nothing
		
		On Error GoTo errhandle 
		
		' Formats the listview for fields and lists all fields in the table in the listview
		
		blnShowTable = True
		
		If cboTableName.ListIndex < 1 Then 
			MsgBox6("Please select a table", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		Me.MousePointer = 11
		Format_lsvTable()
		Fill_lsvTable()
		Me.MousePointer = 0
		
		Exit Sub
errhandle:
		Me.MousePointer = 0
		MsgBox6(Err.Description & ControlChars.CrLf & Err.Number, MsgBoxStyle.Critical, "Error")
		
	End Sub

	Private Sub fmeAbout_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles fmeAbout.MouseMove
		
		' Animates the blue "web link" in the lower right hand side of the form
		' Snippet taken (and modified) from http://www.planet-source-code.com
		
		If X > 0 And X < fmeAbout.Width And Y > 0 And Y < fmeAbout.Height Then 
			If GetCapture() <> fmeAbout.hWnd Then 
				lblAbout.ForeColor = Color.Blue 
				lblAbout.FontUnderline = True
				SetCapture(fmeAbout.hWnd)
			End If
		Else
			lblAbout.ForeColor = Color.Black 
			lblAbout.FontUnderline = False
			ReleaseCapture()
		End If
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
		' Launches the splash form and sets initial parameters.
		
		frmSplash.Show()
		DoEvents6()
		Me.Caption = "SQL Server Documenter v" & App6.Major & "." & App6.Minor & "." & App6.Revision
		Center(Me)
		frmSplash.lblStatus.Caption = "Initializing environment"
		frmSplash.lblStatus.Refresh()
		InitArray()
		txtUserName.Enabled = False
		txtPassword.Enabled = False
		txtUserName.BackColor = SystemColors.Control 
		txtPassword.BackColor = SystemColors.Control 
		frmSplash.lblStatus.Caption = "Scanning for SQL Servers on network"
		frmSplash.lblStatus.Refresh()
		Fill_cboSQLServerList()
		blnConnectionState = False
		picConnectionStatus.Picture = imlConnectionStatus.ListImages(3).Picture
		Unload6(frmSplash)
		
	End Sub

	Private Sub Form_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		
		' Check if the application is disconnected. If not disconnect before closing
		
		If blnConnectionState = True Then 
			cmdConnect_Click()
			objSQLServer = Nothing
		End If
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		
		' Keep the form's current measurements when trying to resize
		
		If Me.WindowState <> 1 Then 
			Me.Width = 9945
			Me.Height = 7200
		End If
		
	End Sub

	Private Sub lblAbout_Click() Handles lblAbout.Click
		
		' Open Da Londo website when clicking the "web link"
		
		ShellExecute(Me.hWnd, "open", "http://www.dalondo.2y.net/", Nothing, Nothing, SW_NORMAL)
		
	End Sub

	Private Sub optSQLAuth_Click() Handles optSQLAuth.Click
		
		txtUserName.Enabled = True
		txtPassword.Enabled = True
		txtUserName.BackColor = SystemColors.Window 
		txtPassword.BackColor = SystemColors.Window 
		txtUserName.SetFocus()
		
	End Sub

	Private Sub optWinAuth_Click() Handles optWinAuth.Click
		
		txtUserName.Enabled = False
		txtPassword.Enabled = False
		txtUserName.BackColor = SystemColors.Control 
		txtPassword.BackColor = SystemColors.Control 
		txtUserName.Text = ""
		txtPassword.Text = ""
		
	End Sub

	Public Sub Fill_cboSQLServerList()
		
		Dim ServerList As SQLDMO.NameList = Nothing
		Dim SQLApp As SQLDMO.Application = Nothing
		Dim lngCounter As Integer
		
		' Scan the network for SQL Servers and list them in the combo
		
		SQLApp = New SQLDMO.Application()
		ServerList = SQLApp.ListAvailableSQLServers()
		
		cboSQLServerList.AddItem("")
		cboSQLServerList.ItemData(cboSQLServerList.NewIndex) = 0
		
		For lngCounter = 1 To ServerList.Count
			cboSQLServerList.AddItem(ServerList.Item(lngCounter))
			cboSQLServerList.ItemData(cboSQLServerList.NewIndex) = lngCounter
		Next
		
	End Sub

	Public Sub Fill_cboDatabaseName()
		
		Dim lngCounter As Integer
		
		' once connected to a server, show all user databases
		
		cboDatabaseName.Clear()
		
		cboDatabaseName.AddItem("")
		cboDatabaseName.ItemData(cboDatabaseName.NewIndex) = 0
		
		For Each objDatabase In objSQLServer.Databases
			If (Not objDatabase.SystemObject = True) Then 
				cboDatabaseName.AddItem(objDatabase.Name)
				cboDatabaseName.ItemData(cboDatabaseName.NewIndex) = lngCounter
				lngCounter += 1
			End If
		Next
		
	End Sub

	Public Sub Fill_cboTableName()
		
		Dim lngCounter As Integer
		
		' When a database has been selected, show all user tables in the database
		
		If cboDatabaseName.ListIndex < 1 Then 
			MsgBox6("Please select a database", MsgBoxStyle.Critical, "Error")
			Exit Sub
		End If
		
		objTable = New SQLDMO.Table()
		objDatabase = objSQLServer.Databases.Item(cboDatabaseName.Text)
		cboTableName.Clear()
		
		cboTableName.AddItem("")
		cboTableName.ItemData(cboTableName.NewIndex) = 0
		
		For Each objTable In objDatabase.Tables
			If Not objTable.SystemObject = True Then 
				cboTableName.AddItem(objTable.Name)
				cboTableName.ItemData(cboTableName.NewIndex) = lngCounter
				lngCounter += 1
			End If
		Next
		
	End Sub

	Public Sub Format_lsvTable()
		
		Dim itmX As VB6ColumnHeader = Nothing
		
		' Format the listview for showing fields
		
		lsvTableData.ColumnHeaders.Clear()
		
		itmX = lsvTableData.ColumnHeaders.Add(, , "Column Name", 2500)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Data Type", 2500)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Length", 1000)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Allow NULL", 1500)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Ident", 1000)
		
		lsvTableData.View = MSComctlLib.ListViewConstants.lvwReport
		
	End Sub

	Public Sub Format_lsvIndex()
		
		Dim itmX As VB6ColumnHeader = Nothing
		
		' Format the listview for showing indexes
		
		lsvTableData.ColumnHeaders.Clear()
		
		itmX = lsvTableData.ColumnHeaders.Add(, , "Index Name", 2000)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Index Type", 3000)
		itmX = lsvTableData.ColumnHeaders.Add(, , "Indexed Fields", 3700)
		itmX = lsvTableData.ColumnHeaders.Add(, , "% Fill", 600, VBRUN.AlignmentConstants.vbCenter)
		
		lsvTableData.View = MSComctlLib.ListViewConstants.lvwReport
		
	End Sub

	Public Sub Fill_lsvTable()
		
		Dim lngCounter As Integer
		Dim itmY As VB6ListItem = Nothing
		Dim objIndex As SQLDMO.Index = Nothing
		Dim objTable As SQLDMO.Table = Nothing
		
		' Fill the listview with all fields in the selected database
		
		lsvTableData.ListItems.Clear()
		
		objColumn = New SQLDMO.Column()
		objTable = objDatabase.Tables.Item(cboTableName.Text)
		
		For Each objColumn In objTable.Columns
			itmY = lsvTableData.ListItems.Add(, "U" & lngCounter, objColumn.Name)
			itmY.SubItems(1) = objColumn.Datatype
			itmY.SubItems(2) = objColumn.Length
			itmY.SubItems(3) = objColumn.AllowNulls
			itmY.SubItems(4) = objColumn.Identity
			lngCounter += 1
		Next
		
	End Sub

	Public Sub Fill_lsvIndex()
		
		Dim lngCounter As Integer
		Dim itmY As VB6ListItem = Nothing
		Dim objIndex As SQLDMO.Index = Nothing
		Dim objTable As SQLDMO.Table = Nothing
		Dim objColumn As SQLDMO.Column = Nothing
		Dim strIndexedFields As String = ""
		Dim intCount As Short
		
		' Fill the listview with all indexes in the selected database
		
		lsvTableData.ListItems.Clear()
		
		objIndex = New SQLDMO.Index()
		objTable = objDatabase.Tables.Item(cboTableName.Text)
		
		For Each objIndex In objTable.Indexes
			If VB.Left(objIndex.Name, 8) <> "_WA_Sys_" And VB.Left(objIndex.Name, 5) <> "hind_" Then 
				itmY = lsvTableData.ListItems.Add(, "U" & lngCounter, objIndex.Name)
				itmY.SubItems(1) = DecodeIDXType(objIndex.Type)
				For intCount = 1 To objIndex.ListIndexedColumns().Count
					objColumn = objIndex.ListIndexedColumns().Item(intCount)
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'strIndexedFields' variable as a StringBuilder6 object.
					strIndexedFields = strIndexedFields & objColumn.Name & ", "
				Next
				itmY.SubItems(2) = VB.Left(strIndexedFields, Len6(strIndexedFields) - 2)
				itmY.SubItems(3) = objIndex.FillFactor
				lngCounter += 1
			End If
			strIndexedFields = ""
		Next
		
	End Sub

End Class

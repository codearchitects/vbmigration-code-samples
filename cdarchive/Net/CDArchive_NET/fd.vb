' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0581): The 'MSChart20Lib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class fd

	Private filenamea As String = ""
	Private xDB As New ADODB.ConnectionClass
	Private rsFiles As New ADODB.RecordsetClass
	Private rsCDs As New ADODB.RecordsetClass
	Private toclick As String = ""
	' UPGRADE_INFO (#0501): The 'inAnother' member isn't used anywhere in current application.
	Private inAnother As Integer
	Private lastnode As VB6Node
	Private lastitem As VB6ListItem
	Public Sub emptynode(ByVal n As VB6Node)
		On  Error Resume Next 
		Do While n.Children <> 0
			n.Expanded = False
			emptynode(n.Child)
			cds.Nodes.Remove(n.Child.Key)
		Loop
		
	End Sub

	Private Sub cds_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef Y As Single) Handles cds.MouseDown
		Dim cow As VB6Node = cds.HitTest(x, Y)
		
		If TypeName6(cow) = "Nothing" Then  cds.ToolTipText = "": Exit Sub
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
		If InStr(1, cow.Key, "\") <> 0 Then  Label1.Caption = cow.Tag: Exit Sub
		Dim cdn As VB6Node = Nothing
		Dim f As VB6Node = Nothing
		If Button = 1 Then 
			If cow.Children > 0 Then  Exit Sub
			cow.Expanded = False
			Label1.Caption = ""
			
			Enabled = False
			
			cds.Enabled = False
			On  Error Resume Next 
			For x = 1 To cds.Nodes.Count
				emptynode(cds.Nodes(x))
			Next
			On  Error GoTo 0 
			cdn = cds.Nodes(cow.Key)

			rsFiles.Open("SELECT * FROM Files WHERE  CDID='" & cow.Key & "' Order by FullPath;", xDB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			pb.Max = rsFiles.RecordCount
			
			Do While Not rsFiles.EOF
				pb.Value = rsFiles.AbsolutePosition
				Text2.Text = "Loading directory structure..." & pb.Value & " of " & pb.Max & ", " & FormatPercent(pb.Value / pb.Max, 0)
				Select Case rsFiles.Fields("Type").Value
				Case 0
					'directory
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
					If DoesNodeExsist(cow.Key & GetDir(rsFiles.Fields("FullPath").Value)) = False Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cdn, MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 3)
						f.ExpandedImage = 2
					Else
						
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cow.Key & GetDir(rsFiles.Fields("FullPath").Value), MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 3)
						f.ExpandedImage = 2
					End If
				Case 1
					'file
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
					If DoesNodeExsist(cow.Key & GetDir(rsFiles.Fields("FullPath").Value)) = False Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cdn, MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 4)
					Else
						
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cow.Key & GetDir(rsFiles.Fields("FullPath").Value), MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 4)
					End If
				End Select
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
				f.Tag = "File Name: " & rsFiles.Fields("Name").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Date").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "Date: " & rsFiles.Fields("Date").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Type").Value'. Consider using the GetDefaultMember6 helper method.
				If rsFiles.Fields("Type").Value = 1 Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Size").Value'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Size: " & makesize(rsFiles.Fields("Size").Value) & ControlChars.CrLf
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Type: File" & ControlChars.CrLf
				Else
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Type: Directory" & ControlChars.CrLf
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "Path: " & rsFiles.Fields("FullPath").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("ID").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "FileID: " & rsFiles.Fields("ID").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CDID: " & cow.Key & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CD Serial: " & cow.Tag & ControlChars.CrLf
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CD Label: " & cow.Text & ControlChars.CrLf
				
				rsFiles.MoveNext()
				If cds.Nodes.Count Mod 200 = 0 Then  DoEvents6()
				'f.Sorted = True
			Loop

			rsFiles.Close()
			
			pb.Value = 0
			cow.Expanded = True
			'node.EnsureVisible
			If toclick <> "" Then 
				cds.Nodes(toclick).Expanded = True
				cds.Nodes(toclick).EnsureVisible()
				On  Error Resume Next 
				If TypeName6(lastnode) = "Nothing" Then  lastnode = cds.Nodes(toclick)

				lastnode = cds.Nodes(toclick)
				toclick = ""
			End If
			
			cds.Enabled = True
			Enabled = True
			Text2.Text = ""
			
			Exit Sub
doneo:
			cds.Enabled = True
			Enabled = True
			Text2.Text = ""
		End If
		If Button = 2 Then 
			mnuInfo.Caption = "CDID: " & cow.Text
			mnuInfo.Tag = cow.Key
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
			mnuInfo2.Caption = "CDLabel: " & cow.Tag
			PopupMenu(mnuCDOptions, , x, Y, mnuRemCD)
			
		End If
	End Sub

	Private Sub cds_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef Y As Single) Handles cds.MouseMove
		Dim cow As VB6Node = cds.HitTest(x, Y)
		
		If TypeName6(cow) = "Nothing" Then  cds.ToolTipText = "": Exit Sub
		If TypeName6(lastnode) = "Nothing" Then  lastnode = cow
		If cow.Key = lastnode.Key Then  Exit Sub
		Debug.WriteLine(cow.Key)
		Debug.WriteLine(lastnode.Key)
		On  Error Resume Next 

		lastnode = cow
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
		If InStr(1, cow.Key, "\") = 0 Then  cds.ToolTipText = "CDLabel: " & cow.Tag
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
		If InStr(1, cow.Key, "\") > 0 Then  Label1.Caption = cow.Tag
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		Me.Enabled = False
		Dim dlisting() As String
		dlisting = GetDriveListing()
		mnuDrive(0).Caption = dlisting(0) & ":" & GetDriveSerial(dlisting(0))
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		mnuDrive(0).Tag = dlisting(x)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(0).Tag'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		If GetDriveSerial(mnuDrive(0).Tag) = "0" Then  mnuDrive(x).Visible = False
		If Len6(dlisting(0)) = 0 Then  mnuDrive(0).Visible = False
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		For x = 1 To UBound6(dlisting)
			DoEvents6()
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			mnuDrive.Load(x)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			mnuDrive(x).Caption = dlisting(x) & ":" & GetDriveSerial(dlisting(x))
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			mnuDrive(x).Tag = dlisting(x)
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			If Len6(dlisting(x)) <> 0 Then  mnuDrive(x).Visible = True
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(x).Tag'. Consider using the GetDefaultMember6 helper method.
			If GetDriveSerial(mnuDrive(x).Tag) = "0" Then  mnuDrive(x).Visible = False
			
		Next
		
		PopupMenu(mnuAddCd, , Command1.Left, Command1.Top + Command1.Height)
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		For x = 1 To mnuDrive.UBound()
			DoEvents6()
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			mnuDrive.Unload(x)
		Next
		
		Me.Enabled = True
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		
		Enabled = False
		ListView1.ListItems.Clear()
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'query'. Consider using the SetDefaultMember6 helper method.
		query = "SELECT f.*,c.* FROM Files f, CDs c WHERE Name LIKE ""%" & Text1.Text & "%"" AND c.CDID=f.CDID;"
		'Sum (f.Size)
		rsFiles.Open(query, xDB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'query'. Consider using the GetDefaultMember6 helper method.
		Debug.WriteLine(query)
		Dim cowcum As Decimal
		Dim cdn As VB6ListItem = Nothing
		On  Error Resume Next 
		pb.Max = rsFiles.RecordCount
		Text2.Text = "Found " & rsFiles.RecordCount & " results."
		Do While Not rsFiles.EOF
			Text2.Text = "Gathering search results..." & pb.Value + 1 & " of " & pb.Max & ", " & FormatPercent((pb.Value + 1) / pb.Max, 0) & ", " & makesize(CDbl(cowcum))
			
			pb.Value = rsFiles.AbsolutePosition
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("ID").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Type").Value'. Consider using the GetDefaultMember6 helper method.
			cdn = ListView1.ListItems.Add(, Chr6(0) & rsFiles.Fields("ID").Value, rsFiles.Fields("Name").Value, rsFiles.Fields("Type").Value + 3, rsFiles.Fields("Type").Value + 3)
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
			cdn.Tag = "File Name: " & rsFiles.Fields("Name").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Date").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "Date: " & rsFiles.Fields("Date").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Type").Value'. Consider using the GetDefaultMember6 helper method.
			If rsFiles.Fields("Type").Value = 1 Then 
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Size").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
				cdn.Tag = cdn.Tag & "Size: " & makesize(rsFiles.Fields("Size").Value) & ControlChars.CrLf
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
				cdn.Tag = cdn.Tag & "Type: File" & ControlChars.CrLf
				
			Else
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
				cdn.Tag = cdn.Tag & "Type: Directory" & ControlChars.CrLf

			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "Path: " & rsFiles.Fields("FullPath").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("ID").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "FileID: " & rsFiles.Fields("ID").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("c.CDID").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "CDID: " & rsFiles.Fields("c.CDID").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("CDSerial").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "CD Serial: " & rsFiles.Fields("CDSerial").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("CDLabel").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'cdn.Tag'. Consider using the SetDefaultMember6 helper method.
			cdn.Tag = cdn.Tag & "CD Label: " & rsFiles.Fields("CDLabel").Value & ControlChars.CrLf
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("c.CDID").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
			cdn.Key = rsFiles.Fields("c.CDID").Value & rsFiles.Fields("FullPath").Value
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Size").Value'. Consider using the GetDefaultMember6 helper method.
			cowcum += rsFiles.Fields("Size").Value
			
			If ListView1.ListItems.Count Mod 200 = 0 Then  DoEvents6()
			
			rsFiles.MoveNext()
		Loop
		pb.Value = 0
		rsFiles.Close()
		Enabled = True
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Dim jro As New JRO.JetEngineClass
		xDB.Close()
		Kill(filenamea & ".bak")
		VB.Rename(filenamea, filenamea & ".bak")
		jro.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filenamea & ".bak", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filenamea)
		xDB.Open()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		MsgBox6("Hi, Visit http://www.compiled.org")
		Shell("explorer http://www.compiled.org")
		Show()
		Dim thedir As String = App6.Path
		If VB.Left(thedir, 1) <> "\" Then  thedir = thedir & "\"
		ListView1.ColumnHeaders(1).Width = ListView1.Width
		xDB.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & thedir & "archive.mdb")
		filenamea = thedir & "archive.mdb"
		RefreshCDs()

	End Sub
	
	Public Function DoesNodeExsist(ByVal key As String) As Boolean
		DoesNodeExsist = False
		On  Error GoTo errhand 
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f'. Consider using the SetDefaultMember6 helper method.
		f = TypeName6(cds.Nodes(key))
		Return True
errhand:
	End Function
	
	Public Function GetDir(ByVal s As String) As String
		If InStr(1, s, "\") = InStrRev(s, "\") Then  Return s
		GetDir = Mid(s, 1, InStrRev(s, "\"))
		If VB.Right(GetDir, 1) = "\" Then  Return Mid(GetDir, 1, Len6(GetDir) - 1)
	End Function
	
	Public Function RefreshCDs() As Object
	' UPGRADE_INFO (#0561): The 'RefreshCDs' symbol was defined without an explicit "As" clause.
		On  Error Resume Next 
		cds.Nodes.Clear()
		Show()
		rsCDs.Open("SELECT * FROM CDs ORDER BY CDSerial", xDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		Dim cdn As VB6Node = Nothing
		' UPGRADE_INFO (#0501): The 'f' member isn't used anywhere in current application.
		Dim f As VB6Node = Nothing
		Do While Not rsCDs.EOF
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("CDID").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("CDLabel").Value'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("CDSerial").Value'. Consider using the GetDefaultMember6 helper method.
			cdn = cds.Nodes.Add(, MSComctlLib.LabelEditConstants.tvwAutomatic, rsCDs.Fields("CDID").Value, rsCDs.Fields("CDLabel").Value & " [" & rsCDs.Fields("CDSerial").Value & "]", 1)
			cdn.Tag = rsCDs.Fields("CDLabel").Value
			
			rsCDs.MoveNext()
		Loop
		rsCDs.Close()
		rsCDs.Open("DBInfo")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("AllSize").Value'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("FileCount").Value'. Consider using the GetDefaultMember6 helper method.
		Caption = "CDArchive [" & cds.Nodes.Count & " discs] [" & makesize(rsCDs.Fields("AllSize").Value) & " bytes in " & rsCDs.Fields("FileCount").Value & " files and directories]"
		rsCDs.Close()
	End Function

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		On Error Resume Next 
		rsFiles = Nothing
		rsCDs = Nothing
		
	End Sub

	Private Sub ListView1_ItemClick(ByVal Item As VB6ListItem) Handles ListView1.ItemClick
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Item.Tag'. Consider using the GetDefaultMember6 helper method.
		Label1.Caption = Item.Tag
		' UPGRADE_ISSUE (#1648): The CreateDrawImage method isn't supported. Invoking this method throws an exception.
		Icon = BitmapToIcon6(Item.CreateDragImage())
		toclick = Item.Key
		ListView1.Enabled = False
		Dim cow As VB6Node = Nothing
		Dim cdn As VB6Node = Nothing
		Dim f As VB6Node = Nothing
		If DoesNodeExsist(Item.Key) = True Then 
			cds.Nodes(Item.Key).Expanded = True
			
			cds.Nodes(Item.Key).Selected = True
			On  Error Resume Next 
			If TypeName6(lastnode) = "Nothing" Then  lastnode = cds.Nodes(Item.Key)
			
			lastnode = cds.Nodes(Item.Key)
			cds.Nodes(Item.Key).EnsureVisible()
		Else

			cow = cds.Nodes(Mid(Item.Key, 1, InStr(1, Item.Key, "\") - 1))
			If TypeName6(cow) = "Nothing" Then  cds.ToolTipText = "": Exit Sub
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
			If InStr(1, cow.Key, "\") <> 0 Then  Label1.Caption = cow.Tag: Exit Sub
			
			If cow.Children > 0 Then  Exit Sub
			cow.Expanded = False
			Label1.Caption = ""
			
			Enabled = False
			
			cds.Enabled = False
			On  Error Resume Next 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			For x = 1 To cds.Nodes.Count
				emptynode(cds.Nodes(x))
			Next
			On  Error GoTo 0 
			cdn = cds.Nodes(cow.Key)

			rsFiles.Open("SELECT * FROM Files WHERE  CDID='" & cow.Key & "' Order by FullPath;", xDB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			pb.Max = rsFiles.RecordCount
			
			Do While Not rsFiles.EOF
				pb.Value = rsFiles.AbsolutePosition
				Text2.Text = "Loading directory structure..." & pb.Value & " of " & pb.Max & ", " & FormatPercent(pb.Value / pb.Max, 0)
				Select Case rsFiles.Fields("Type").Value
				Case 0
					'directory
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
					If DoesNodeExsist(cow.Key & GetDir(rsFiles.Fields("FullPath").Value)) = False Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cdn, MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 3)
						f.ExpandedImage = 2
					Else
						
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cow.Key & GetDir(rsFiles.Fields("FullPath").Value), MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 3)
						f.ExpandedImage = 2
					End If
				Case 1
					'file
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
					If DoesNodeExsist(cow.Key & GetDir(rsFiles.Fields("FullPath").Value)) = False Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cdn, MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 4)
					Else
						
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
						f = cds.Nodes.Add(cow.Key & GetDir(rsFiles.Fields("FullPath").Value), MSComctlLib.TreeRelationshipConstants.tvwChild, cow.Key & rsFiles.Fields("FullPath").Value, rsFiles.Fields("Name").Value, 4)
					End If
				End Select
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
				f.Tag = "File Name: " & rsFiles.Fields("Name").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Date").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "Date: " & rsFiles.Fields("Date").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Type").Value'. Consider using the GetDefaultMember6 helper method.
				If rsFiles.Fields("Type").Value = 1 Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("Size").Value'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Size: " & makesize(rsFiles.Fields("Size").Value) & ControlChars.CrLf
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Type: File" & ControlChars.CrLf
				Else
					' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
					f.Tag = f.Tag & "Type: Directory" & ControlChars.CrLf
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("FullPath").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "Path: " & rsFiles.Fields("FullPath").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsFiles.Fields("ID").Value'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "FileID: " & rsFiles.Fields("ID").Value & ControlChars.CrLf
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CDID: " & cow.Key & ControlChars.CrLf
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CD Serial: " & cow.Tag & ControlChars.CrLf
				' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f.Tag'. Consider using the SetDefaultMember6 helper method.
				f.Tag = f.Tag & "CD Label: " & cow.Text & ControlChars.CrLf
				
				rsFiles.MoveNext()
				If cds.Nodes.Count Mod 200 = 0 Then  DoEvents6()
				'f.Sorted = True
			Loop

			rsFiles.Close()
			
			pb.Value = 0
			cow.Expanded = True
			'node.EnsureVisible
			If toclick <> "" Then 
				cds.Nodes(toclick).Expanded = True
				cds.Nodes(toclick).EnsureVisible()
				On  Error Resume Next 
				If TypeName6(lastnode) = "Nothing" Then  lastnode = cds.Nodes(toclick)

				lastnode = cds.Nodes(toclick)
				toclick = ""
			End If
			
			cds.Enabled = True
			Enabled = True
			Text2.Text = ""
			ListView1.Enabled = True
			Exit Sub
doneo:
			cds.Enabled = True
			Enabled = True
			Text2.Text = ""

		End If
		ListView1.Enabled = True
	End Sub

	Private Sub ListView1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef Y As Single) Handles ListView1.MouseMove
		Dim cow As VB6ListItem = ListView1.HitTest(x, Y)
		
		If TypeName6(cow) = "Nothing" Then  ListView1.ToolTipText = "": Exit Sub
		If TypeName6(lastitem) = "Nothing" Then  lastitem = cow
		If cow.Key = lastitem.Key Then  Exit Sub
		Debug.WriteLine(cow.Key)
		Debug.WriteLine(lastitem.Key)
		On  Error Resume Next 
		lastitem.Bold = False
		lastitem.ForeColor = Color.Black 
		
		cow.Bold = True
		cow.ForeColor = Color.Red 
		' UPGRADE_ISSUE (#1648): The CreateDrawImage method isn't supported. Invoking this method throws an exception.
		Icon = BitmapToIcon6(cow.CreateDragImage())
		lastitem = cow
		ListView1.ToolTipText = "CDID: " & Mid(cow.Key, 1, InStr(1, cow.Key, "\") - 1)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'cow.Tag'. Consider using the GetDefaultMember6 helper method.
		Label1.Caption = cow.Tag
		If DoesNodeExsist(cow.Key) = True Then 
			' UPGRADE NOTE: original code had a bug => cdscds.Nodes(cow.key).Expanded = True
			cds.Nodes(cow.Key).Expanded = True
			
			cds.Nodes(cow.Key).Selected = True
			On  Error Resume Next 
			If TypeName6(lastnode) = "Nothing" Then  lastnode = cds.Nodes(cow.Key)

			lastnode = cds.Nodes(cow.Key)
			cds.Nodes(cow.Key).EnsureVisible()
		End If
	End Sub

	Private Sub mnuDrive_Click(ByRef Index As Short)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(Index).Tag'. Consider using the GetDefaultMember6 helper method.
		rsCDs = xDB.Execute("SELECT COUNT(*) FROM CDs WHERE CDSerial=" & GetDriveSerial(mnuDrive(Index).Tag) & ";")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		If rsCDs.Fields(0).Value <> 0 Then 
			MsgBox6("This CD has already been cataloged.", MsgBoxStyle.Critical, "Error")
			rsCDs.Close()
			Exit Sub
		End If
		rsCDs.Close()
		rsCDs.Open("CDs", xDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		rsCDs.AddNew()
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(Index).Tag'. Consider using the GetDefaultMember6 helper method.
		rsCDs.Fields("CDSerial").Value = GetDriveSerial(mnuDrive(Index).Tag)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(Index).Tag'. Consider using the GetDefaultMember6 helper method.
		rsCDs.Fields("CDLabel").Value = GetVolumeLabel(mnuDrive(Index).Tag)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("CDLabel").Value'. Consider using the GetDefaultMember6 helper method.
		If rsCDs.Fields("CDLabel").Value = "" Then  rsCDs.Fields("CDLabel").Value = "[No Label]"
		rsCDs.Update()
		rsCDs.Close()
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(Index).Tag'. Consider using the GetDefaultMember6 helper method.
		rsCDs = xDB.Execute("SELECT CDID FROM CDs WHERE CDSerial=" & GetDriveSerial(mnuDrive(Index).Tag) & ";")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsCDs.Fields("CDID").Value'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuDrive(Index).Tag'. Consider using the GetDefaultMember6 helper method.
		AddFiles(rsCDs.Fields("CDID").Value, mnuDrive(Index).Tag)
		RefreshCDs()
	End Sub
	
	Private Sub AddFiles(ByVal cdGUID As String, ByVal driveroot As String)
		Enabled = False
		Text2.Text = "Reading CD..."
		rsCDs.Close()
		rsFiles.Open("Files", xDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		Redim6(DirQUE, 0, 0)
		DirQUE(0) = driveroot
		
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f'. Consider using the SetDefaultMember6 helper method.
		f = 0
		Dim cow() As DirInfo
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
		Do While (UBound6(DirQUE) <> f - 1)
			DoEvents6()
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'f'. Consider using the GetDefaultMember6 helper method.
			Call EnumDirs("*", DirQUE(f), cow)
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'f'. Consider using the SetDefaultMember6 helper method.
			f += 1
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
			For x = 0 To UBound6(cow)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				If cow(x).FullPath = "" Then  GoTo cowboy
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				If cow(x).fSize = "-" Then 
					RedimPreserve6(DirQUE, LBound6(DirQUE), UBound6(DirQUE) + 1)
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					DirQUE(UBound6(DirQUE)) = cow(x).FullPath & "\"
					
					rsFiles.AddNew()
					rsFiles.Fields("CDID").Value = cdGUID
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("Name").Value = cow(x).fNAME
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("Date").Value = cow(x).fDATE
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("FullPath").Value = Mid(cow(x).FullPath, 3)
					rsFiles.Fields("Type").Value = 0
					rsFiles.Fields("Size").Value = 0
					rsFiles.Update()
				Else
					'file

					rsFiles.AddNew()
					rsFiles.Fields("CDID").Value = cdGUID
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("Name").Value = cow(x).fNAME
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("Date").Value = cow(x).fDATE
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("FullPath").Value = Mid(cow(x).FullPath, 3)
					rsFiles.Fields("Type").Value = 1
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
					rsFiles.Fields("Size").Value = cow(x).fSize
					rsFiles.Update()
				End If
cowboy:
				DoEvents6()
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
				Text2.Text = "Reading CD..." & cow(x).FullPath
			Next
			ReDim cow(0)
		Loop
		rsFiles.Close()
		Label1.Caption = "Reading CD...Done.."
		Label1.Caption = Label1.Caption & "Label this CD " & GetDriveSerial(driveroot) & ControlChars.CrLf & ControlChars.CrLf
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x'. Consider using the GetDefaultMember6 helper method.
		Label1.Caption = Label1.Caption & x & " files and directories read."
		Enabled = True
	End Sub

	Public Function makesize(ByVal bytes As Double) As String
		
		If bytes < 1024 Then 
			Return FormatNumber(bytes, 0, 0, 0, True) & " b"
		End If
		
		If (bytes / 1024) < 1024 Then 
			Return FormatNumber((bytes / 1024), 2, 0, 0, True) & " KB"
		End If
		If ((bytes / 1024) / 1024) < 1024 Then 
			Return FormatNumber(((bytes / 1024) / 1024), 2, 0, 0, True) & " MB"
		End If
		If (((bytes / 1024) / 1024) / 1024) < 1024 Then 
			Return FormatNumber((((bytes / 1024) / 1024) / 1024), 2, 0, 0, True) & " GB"
		End If
	End Function

	Private Sub mnuRemCD_Click() Handles mnuRemCD.Click
		If MsgBox6("Removing a CD is a irreversable action, the CD Can Be re-added but only if you re-add it manually!" & ControlChars.CrLf & "Are you sure you want to delete it?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Yes/No?") = MsgBoxResult.Yes Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuInfo.Tag'. Consider using the GetDefaultMember6 helper method.
			xDB.Execute("DELETE FROM CDs WHERE CDID='" & mnuInfo.Tag & "'")
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mnuInfo.Tag'. Consider using the GetDefaultMember6 helper method.
			xDB.Execute("DELETE FROM Files WHERE CDID='" & mnuInfo.Tag & "'")
			RefreshCDs()
		End If
	End Sub

End Class

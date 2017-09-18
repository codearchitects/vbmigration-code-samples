' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class ezExport

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	Private AllTables As Boolean
	Private sHTML As String = ""
	Public Event NotConnected()
	Public Event Successful()
	Public Event [Error](ByRef Description As String)
	
	Public Sub AllToHTML(ByRef sLocation As String, Optional ByRef TableColor As String = "000000", Optional ByRef HeaderColor As String = "EEEEEE", Optional ByRef DataColor As String = "FFFFFF", Optional ByVal CellPadding As Short = 1, Optional ByVal CellSpacing As Short = 1, Optional ByVal Border As Boolean = False, Optional ByRef BorderColor As String = "000000")
	' UPGRADE_INFO (#0551): The 'TableColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'HeaderColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DataColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'BorderColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If dbCon.State <> 1 Then  RaiseEvent NotConnected(): Exit Sub
		Dim sPath As String = ""
		Dim sFile() As String
		sFile = Split(sLocation, "\")
		sPath = VB.Left(sLocation, Len6(sLocation) - Len6(sFile(UBound6(sFile))))
		Dim i As Integer
		' UPGRADE_INFO (#0501): The 'fNum' member isn't used anywhere in current application.
		Dim fNum As Short
		If FolderExists(sPath) = True Then 
			
			AllTables = True
			For i = 0 To UBound6(dbRs)
				Call ToHTML(sLocation, i, TableColor, HeaderColor, DataColor, CellPadding, CellSpacing, Border, BorderColor)
			Next
			AllTables = False
		Else
			RaiseEvent [Error]("Cannot Export. Invalid Path Specified.")
		End If
	End Sub
	
	Public Sub ToHTML(ByRef sLocation As String, ByVal nTable As Integer, Optional ByRef TableColor As String = "000000", Optional ByRef HeaderColor As String = "EEEEEE", Optional ByRef DataColor As String = "FFFFFF", Optional ByVal CellPadding As Short = 0, Optional ByVal CellSpacing As Short = 0, Optional ByVal Border As Boolean = False, Optional ByRef BorderColor As String = "000000")
	' UPGRADE_INFO (#0551): The 'TableColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'HeaderColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DataColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'BorderColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If dbCon.State <> 1 Then  RaiseEvent NotConnected(): Exit Sub
		If TableExists(nTable) = False Then  RaiseEvent [Error]("Invalid Table Number."): Exit Sub
		
		Dim sPath As String = ""
		Dim sFile() As String
		sFile = Split(sLocation, "\")
		sPath = VB.Left(sLocation, Len6(sLocation) - Len6(sFile(UBound6(sFile))))
		
		Dim i As Integer
		Dim j As Integer
		Dim fNum As Short
		Dim rsClone As ADODB.Recordset = Nothing
		Dim sTable As String = ""
		Dim sSplitLoc() As String
		Dim oldLocation As String = ""
		If FolderExists(sPath) = True Then 
			
			rsClone = dbRs(nTable)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsClone.Source'. Consider using the GetDefaultMember6 helper method.
			sTable = VB.Left(Split(rsClone.Source, "[")(1), Len6(Split(rsClone.Source, "[")(1)) - 1)
			
			GenerateHeader(Border, TableColor, CellSpacing, CellPadding, sTable, BorderColor)
			
			For i = 0 To rsClone.Fields.Count - 1
				' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'sHTML' variable as a StringBuilder6 object.
				sHTML = sHTML & "<td bgcolor=" & HeaderColor & ">" & rsClone.Fields(i).Name & "</td>" & ControlChars.NewLine
			Next
			
			sHTML = sHTML & "</tr>" & ControlChars.NewLine
			rsClone.MoveFirst()
			For i = 1 To rsClone.RecordCount
				sHTML &= "<tr>"
				For j = 0 To rsClone.Fields.Count - 1
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rsClone.Fields(j).Value'. Consider using the GetDefaultMember6 helper method.
					sHTML = sHTML & "<td bgcolor=" & DataColor & ">" & rsClone.Fields(j).Value & "</td>" & ControlChars.NewLine
				Next
				sHTML = sHTML & "</tr>" & ControlChars.NewLine
				rsClone.MoveNext()
				DoEvents6()
			Next
			
			sHTML = sHTML & "</table>"
			
			fNum = FreeFile6()
			
			If AllTables = True Then 
				sSplitLoc = Split(sLocation, ".")
				oldLocation = sLocation
				sLocation = Replace(sLocation, "." & sSplitLoc(UBound6(sSplitLoc)), sTable & "." & sSplitLoc(UBound6(sSplitLoc)))
			End If
			FileOpen6(fNum, sLocation, OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1)
			FilePrintLine6(fNum, sHTML)
			FileClose6(fNum)
			
			RaiseEvent Successful()
			
			If Len6(oldLocation) Then  sLocation = oldLocation
			sHTML = Nothing
		Else
			RaiseEvent [Error]("Cannot Export. Invalid Path Specified.")
		End If
	End Sub

	Private Sub GenerateHeader(ByVal Border As Boolean, ByVal TableColor As String, ByVal CellSpacing As Short, ByVal CellPadding As Short, ByRef sTable As String, Optional ByRef BorderColor As Object = VB6Missing)
	' UPGRADE_INFO (#0551): The 'sTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0561): The 'BorderColor' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'BorderColor' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Border = False Then 
			sHTML = "<html>" & ControlChars.NewLine & "<title>ezDatabase HTML Export Table: " & sTable & "</title>" & ControlChars.NewLine & "</html>" & ControlChars.NewLine & "<table width=100% bgcolor=" & TableColor & " cellspacing=" & CellSpacing & " cellpadding=" & CellPadding & ">" & ControlChars.NewLine & "<tr>"
		Else
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'BorderColor'. Consider using the GetDefaultMember6 helper method.
			sHTML = "<html>" & ControlChars.NewLine & "<title>ezDatabase HTML Export Table: " & sTable & "</title>" & ControlChars.NewLine & "</html>" & ControlChars.NewLine & "<table width=100% bgcolor=" & TableColor & " cellspacing=" & CellSpacing & " cellpadding=" & CellPadding & "border=1 " & "bordercolor= " & BorderColor & ">" & ControlChars.NewLine & "<tr>"
		End If
		
	End Sub
	
	Private Function TableExists(ByRef nTable As Integer) As Boolean
	' UPGRADE_INFO (#0551): The 'nTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error GoTo IsFalse_RENAMED 
		Dim sSource As String = dbRs(nTable).Source
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(nTable).Source'. Consider using the GetDefaultMember6 helper method.
		Return True
IsFalse_RENAMED:
	End Function

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module modMain

	Public objSQLServer As SQLDMO.SQLServer
	Public objDatabase As SQLDMO.Database
	Public objTable As SQLDMO.Table
	Public objColumn As SQLDMO.Column
	Public blnConnectionState As Boolean
	Public blnShowTable As Boolean
	Public arrIDXtype(11, 3) As String
	
	Public Function Center(ByRef frm As VB6Form) As Object
		
		' Centers the form on the screen
		
		frm.Left = (Screen6.Width / 2) - (frm.Width / 2)
		frm.Top = (Screen6.Height / 2) - (frm.Height / 2)
		
	End Function

	Public Sub Export2XLS(ByRef strTable As String, ByRef strPath As String, ByRef strServer As String, ByRef strDatabase As String)
		
		Dim objFSO As New VB6FileSystemObject
		Dim objFile As VB6TextStream = Nothing
		Dim strTypeTemp As String = ""
		Dim strIDXCol As String = ""
		Dim objColumn As SQLDMO.Column = Nothing
		Dim objIndex As SQLDMO.Index = Nothing
		Dim objTable As SQLDMO.Table = Nothing
		Dim intCount As Short
		
		' Create HTML style report being saved as a .XLS file.
		' When opened by Excel, it will be converted to an excel sheet automatically.
		' This eliminates the need for excel libraries and DLL's
		
		If blnShowTable = True Then 
			
			objFile = objFSO.OpenTextFile(strPath, Scripting.IOMode.ForWriting, True)
			
			objFile.WriteLine("<table>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td colspan=5><h3><strong>" & strServer & " | " & strDatabase & " | " & strTable & "</strong></h3></td>")
			objFile.WriteLine("</tr>")
			objFile.WriteLine("<tr><td>&nbsp;</td></tr>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td><strong>Column Name</strong></td>")
			objFile.WriteLine(" <td><strong>Data Type</strong></td>")
			objFile.WriteLine(" <td><strong>Length</strong></td>")
			objFile.WriteLine(" <td><strong>Allow NULL</strong></td>")
			objFile.WriteLine(" <td><strong>Ident</strong></td>")
			objFile.WriteLine("</tr>")
			
			objColumn = New SQLDMO.Column()
			objTable = objDatabase.Tables.Item(strTable)

			For Each objColumn In objTable.Columns
				objFile.WriteLine("<tr>")
				objFile.WriteLine(" <td>" & objColumn.Name & "</td>")
				objFile.WriteLine(" <td>" & objColumn.Datatype & "</td>")
				objFile.WriteLine(" <td>" & objColumn.Length & "</td>")
				objFile.WriteLine(" <td>" & objColumn.AllowNulls & "</td>")
				objFile.WriteLine(" <td>" & objColumn.Identity & "</td>")
				objFile.WriteLine("</tr>")
				
			Next
			
			objFile.WriteLine("</table>")
			
			objFile.Close()
			
		Else
			
			objFile = objFSO.OpenTextFile(strPath, Scripting.IOMode.ForWriting, True)
			
			objFile.WriteLine("<table>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td colspan=4><h3><strong>" & strServer & " | " & strDatabase & " | " & strTable & "</strong></h3></td>")
			objFile.WriteLine("</tr>")
			objFile.WriteLine("<tr><td>&nbsp;</td></tr>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td><strong>Index Name</strong></td>")
			objFile.WriteLine(" <td><strong>Index Type</strong></td>")
			objFile.WriteLine(" <td><strong>Fields</strong></td>")
			objFile.WriteLine(" <td><strong>Fill Factor</strong></td>")
			objFile.WriteLine("</tr>")
			
			objIndex = New SQLDMO.Index()
			objTable = objDatabase.Tables.Item(strTable)

			For Each objIndex In objTable.Indexes
				
				' SQLDMO returns all indexes, even system indexes. Filtering on "_WA_SYS_" and "hind_" hides these from the user
				If VB.Left(objIndex.Name, 8) <> "_WA_Sys_" And VB.Left(objIndex.Name, 5) <> "hind_" Then 
					strTypeTemp = DecodeIDXType(objIndex.Type)
					strTypeTemp = Replace(strTypeTemp, ", ", "<BR>")
					For intCount = 1 To objIndex.ListIndexedColumns().Count
						objColumn = objIndex.ListIndexedColumns().Item(intCount)
						' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'strIDXCol' variable as a StringBuilder6 object.
						strIDXCol = strIDXCol & objColumn.Name & ", "
					Next
					strIDXCol = VB.Left(strIDXCol, Len6(strIDXCol) - 2)
					strIDXCol = Replace(strIDXCol, ", ", "<BR>")
					objFile.WriteLine("<tr>")
					objFile.WriteLine(" <td valign=top>" & objIndex.Name & "</td>")
					objFile.WriteLine(" <td valign=top>" & strTypeTemp & "</td>")
					objFile.WriteLine(" <td valign=top>" & strIDXCol & "</td>")
					objFile.WriteLine(" <td valign=top>" & objIndex.FillFactor & "</td>")
				End If
				strIDXCol = ""
			Next
			
			objFile.WriteLine("</table>")
			
			objFile.Close()
		End If
		
	End Sub

	Public Sub PrintPreview(ByRef strTable As String, ByRef strDatabase As String, ByRef strServer As String)
		
		Dim objFSO As New VB6FileSystemObject
		Dim objFile As VB6TextStream = Nothing
		Dim strTypeTemp As String = ""
		Dim strIDXCol As String = ""
		Dim objColumn As SQLDMO.Column = Nothing
		Dim objIndex As SQLDMO.Index = Nothing
		Dim objTable As SQLDMO.Table = Nothing
		Dim intCount As Short
		
		' Create HTML report to be shown in the browser control for printing
		
		If blnShowTable = True Then 
			
			objFile = objFSO.OpenTextFile(App6.Path & "\tmpprt.dat", Scripting.IOMode.ForWriting, True)
			
			objFile.WriteLine("<table cellpadding=1 cellspacing=1 border=1 bordercolor=#F0F0F0>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td colspan=5 style=""font-size : 22px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strServer & " | " & strDatabase & " | " & strTable & "</td>")
			objFile.WriteLine("</tr>")
			objFile.WriteLine("<tr><td colspan=5>&nbsp;</td></tr>")
			objFile.WriteLine("<tr bgcolor=#F0F0F0>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Column Name</td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Data Type</td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Length</td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">NULL</td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Ident</td>")
			objFile.WriteLine("</tr>")
			
			objColumn = New SQLDMO.Column()
			objTable = objDatabase.Tables.Item(strTable)

			For Each objColumn In objTable.Columns
				objFile.WriteLine("<tr>")
				objFile.WriteLine(" <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Name & "</td>")
				objFile.WriteLine(" <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Datatype & "</td>")
				objFile.WriteLine(" <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Length & "</td>")
				If objColumn.AllowNulls = True Then 
					objFile.WriteLine(" <td align=center style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">True</td>")
				Else
					objFile.WriteLine(" <td>&nbsp;</td>")
				End If
				If objColumn.Identity = True Then 
					objFile.WriteLine(" <td align=center style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">True</td>")
				Else
					objFile.WriteLine(" <td>&nbsp;</td>")
				End If
				objFile.WriteLine("</tr>")
				
			Next
			
			objFile.WriteLine("</table>")
			
			objFile.Close()
		Else
			
			objFile = objFSO.OpenTextFile(App6.Path & "\tmpprt.dat", Scripting.IOMode.ForWriting, True)
			
			objFile.WriteLine("<table cellpadding=1 cellspacing=1 border=1 bordercolor=#F0F0F0>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td colspan=4 style=""font-size : 22px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strServer & " | " & strDatabase & " | " & strTable & "</td>")
			objFile.WriteLine("</tr>")
			objFile.WriteLine("<tr><td colspan=4>&nbsp;</td></tr>")
			objFile.WriteLine("<tr>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Index Name</strong></td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Index Type</strong></td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Fields</strong></td>")
			objFile.WriteLine(" <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Fill Factor</strong></td>")
			objFile.WriteLine("</tr>")
			
			objIndex = New SQLDMO.Index()
			objTable = objDatabase.Tables.Item(strTable)

			For Each objIndex In objTable.Indexes
				
				' SQLDMO returns all indexes, even system indexes. Filtering on "_WA_SYS_" and "hind_" hides these from the user
				If VB.Left(objIndex.Name, 8) <> "_WA_Sys_" And VB.Left(objIndex.Name, 5) <> "hind_" Then 
					strTypeTemp = DecodeIDXType(objIndex.Type)
					strTypeTemp = Replace(strTypeTemp, ", ", "<BR>")
					For intCount = 1 To objIndex.ListIndexedColumns().Count
						objColumn = objIndex.ListIndexedColumns().Item(intCount)
						' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'strIDXCol' variable as a StringBuilder6 object.
						strIDXCol = strIDXCol & objColumn.Name & ", "
					Next
					strIDXCol = VB.Left(strIDXCol, Len6(strIDXCol) - 2)
					strIDXCol = Replace(strIDXCol, ", ", "<BR>")
					objFile.WriteLine("<tr>")
					objFile.WriteLine(" <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objIndex.Name & "</td>")
					objFile.WriteLine(" <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strTypeTemp & "</td>")
					objFile.WriteLine(" <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strIDXCol & "</td>")
					objFile.WriteLine(" <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objIndex.FillFactor & "</td>")
					objFile.WriteLine("</tr>")
				End If
				strIDXCol = ""
			Next
			
			objFile.WriteLine("</table>")
			
			objFile.Close()
			
		End If
		
	End Sub

	Public Sub InitArray()
		
		'Static array of index type names
		' arrIDXType(x, y) : x represents the bit that should be high in a 32 bit word, y holds the name of the index type
		
		arrIDXtype(1, 1) = "32"
		arrIDXtype(1, 3) = "Ignore Dupl. Key"
		arrIDXtype(2, 1) = "31"
		arrIDXtype(2, 3) = "Unique"
		arrIDXtype(3, 1) = "28"
		arrIDXtype(3, 3) = "Clustered"
		arrIDXtype(4, 1) = "27"
		arrIDXtype(4, 3) = "Hypotethical"
		arrIDXtype(5, 1) = "24"
		arrIDXtype(5, 3) = "Pad index nodes"
		arrIDXtype(6, 1) = "23"
		arrIDXtype(6, 3) = "!!OBSOLETE!!"
		arrIDXtype(7, 1) = "21"
		arrIDXtype(7, 3) = "Primary Key"
		arrIDXtype(8, 1) = "20"
		arrIDXtype(8, 3) = "Unique Key"
		arrIDXtype(9, 1) = "19"
		arrIDXtype(9, 3) = "!!OBSOLETE!!"
		arrIDXtype(10, 1) = "17"
		arrIDXtype(10, 3) = "Drop Exist"
		arrIDXtype(11, 1) = "8"
		arrIDXtype(11, 3) = "No Recompute"
		
	End Sub

	Private Function ConvertToBinary(ByVal Number As Integer, ByVal Bits As Byte) As String
		
		Dim intCount As Byte
		
		' The actual long to binary conversion.
		' This snippet was taken from http://www.planet-source-code.com
		
		ConvertToBinary = String6(Bits, "0")
		For intCount = 1 To Bits
			If Number And 1 Then  Mid(ConvertToBinary, Bits + 1 - intCount, 1) = "1"
			Number \= 2
		Next
		
	End Function

	Public Function DecodeIDXType(ByRef TypeNr As Integer) As String
		
		Dim intCount As Short
		Dim strOutput As String = ""
		Dim strInput As String = ""
		
		' Convert the Type number to binary and check which bits are high
		' Macht the "high" bits to the array "arrIDXType" and return the index type name
		
		For intCount = 1 To 11
			If TypeNr <> "0" Then 
				strInput = ConvertToBinary(TypeNr, 32)
				If Mid(strInput, CShort(arrIDXtype(intCount, 1)), 1) = "1" Then 
					arrIDXtype(intCount, 2) = "Y"
				End If
			End If
		Next

		For intCount = 1 To 11
			If arrIDXtype(intCount, 2) = "Y" Then 
				strOutput = arrIDXtype(intCount, 3) & ", " & strOutput
			End If
		Next
		
		If strOutput = "" Then 
			Return "UNKNOWN (" & TypeNr & ")"
		Else
			Return VB.Left(strOutput, Len6(strOutput) - 2)
		End If
		
	End Function

End Module

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSpellCheck

	Private Declare Function GetInputState Lib "user32.dll" () As Integer
	
	Private wordlistDB As DAO.Database
	Private cPhoneme As New clsPhoneme
	
	'// Private Helper functions
	Private Function DataIsPresentIn(ByRef TestRS As DAO.Recordset) As Boolean
	' UPGRADE_INFO (#0551): The 'TestRS' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		DataIsPresentIn = True
		TestRS.MoveFirst()
		If Err.Number Then  DataIsPresentIn = False
		Err.Clear()
	End Function

	Private Sub cmdCreateList_Click() Handles cmdCreateList.Click
		Dim frf As Short
		Dim tmpStr As String = ""
		Dim i As Integer
		Dim wordRS As DAO.Recordset = Nothing
		
		frf = FreeFile6()
		wordRS = wordlistDB.OpenRecordset("Words")
		With wordRS
			FileOpen6(frf, App6.Path & "\wl.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
			'// Read words from the file and add to the database
			Do While Not EOF6(frf)
				If GetInputState() <> 0 Then  DoEvents6()
				tmpStr = FileLineInput6(frf)
				tmpStr = Trim(tmpStr)
				.AddNew()
				.Fields("Word").Value = tmpStr
				.Fields("Soundex").Value = cPhoneme.GetSoundexWord(tmpStr)
				.Update()
				'// Prevent the UI from freezing up
				i += 1
				If i Mod 1000 = 0 Then 
					lblStatus.Caption = "Added..." & i & " words."
					lblStatus.Refresh()
					DoEvents6()
				End If
			Loop
			FileClose6(frf)
			lblStatus.Caption = "Database created! " & i & " words were added."
			.Close()
			'// Just to ensure this is done only once
			frf = FreeFile6()
			FileOpen6(frf, App6.Path & "\words.done", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
			FileClose6(frf)
		End With
	End Sub

	Private Sub cmdGO_Click() Handles cmdGO.Click
		Dim workStr As String = ""
		Dim SndxMatchRS As DAO.Recordset = Nothing
		Dim navIndex As Integer
		Dim navMax As Integer
		Dim LdMax As Integer
		Dim lenTmp As Integer

		'// Get the soundex of the input word
		workStr = Trim(txtInputWord.Text)
		If workStr <> Nothing Then  lblSoundex.Caption = cPhoneme.GetSoundexWord(workStr)
		
		'// Now find all entries in the database which match the soundex of the input word
		SndxMatchRS = wordlistDB.OpenRecordset("SELECT [word] from Words WHERE " & "Soundex = " & Chr6(34) & lblSoundex.Caption & Chr6(34), DAO.RecordsetTypeEnum.dbOpenSnapshot)
		
		'// Populate the Listbox
		If DataIsPresentIn(SndxMatchRS) Then 
			With SndxMatchRS
				.MoveLast()
				navMax = .RecordCount
				.MoveFirst()
				lstSoundexMatches.Clear()
				
				'// TIP: Use LB_INITSTORAGE with sendmessage here

				For navIndex = 1 To navMax
					If GetInputState() <> 0 Then  DoEvents6()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields("Word").Value'. Consider using the GetDefaultMember6 helper method.
					lstSoundexMatches.AddItem(.Fields("Word").Value)
					'// The max length of returned matches is the maximum Leveshtein
					'// distance we can have
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields("Word").Value'. Consider using the GetDefaultMember6 helper method.
					lenTmp = Len6(.Fields("Word").Value)
					If lenTmp > LdMax Then  LdMax = lenTmp
					
					.MoveNext()
					
					If navIndex Mod 5 = 0 Then 
						lblStatus.Caption = "Adding items..." & FormatPercent(navIndex \ navMax) & " added."
						lblStatus.Refresh()
					End If
					
				Next
				lblStatus.Caption = Nothing
				lblSndxMatchCount.Caption = lstSoundexMatches.ListCount & " matches."
			End With
			
			With LdVal
				.Max = LdMax
				.Min = 0
				.Value = LdMax \ 2
				lblLDVal.Caption = .Value
			End With
		End If
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		wordlistDB = DAO_DBEngine_DefInstance.OpenDatabase(App6.Path & "\words.mdb", False, False)
		'// '// Just to ensure this is done only once
		If Dir6(App6.Path & "\words.done") = Nothing Then 
			cmdCreateList.Enabled = True
		Else
			cmdCreateList.Enabled = False
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		wordlistDB.Close()
		cPhoneme = Nothing
	End Sub

	Private Sub LdVal_Change() Handles LdVal.Change
		Dim i As Integer
		Dim threshold As Integer
		Dim LD As Integer
		Dim strInput As String = ""
		Dim striMatch As String = ""
		
		strInput = UCase(Trim(txtInputWord.Text))
		threshold = LdVal.Value
		lstLdMatches.Clear()
		'// walk through all soundex matches
		For i = 0 To lstSoundexMatches.ListCount
			striMatch = Trim(lstSoundexMatches.List(i))
			If striMatch <> Nothing Then 
				If GetInputState() <> 0 Then  DoEvents6()
				LD = cPhoneme.GetLevenshteinDistance(strInput, UCase(striMatch))
				
				'// Get all Levenshtein distances less than the scroll(threshold) value
				If LD <= threshold Then 
					If LD < lstLdMatches.ListCount Then 
						'// Add better matches up
						lstLdMatches.AddItem(striMatch, LD)
					Else
						lstLdMatches.AddItem(striMatch)
					End If
				End If
				
				If i Mod 5 = 0 Then 
					lblStatus.Caption = "Adding items..." & i & "matches found."
					lblStatus.Refresh()
				End If
			End If
		Next
		lblLDMatchCount.Caption = lstLdMatches.ListCount
		
		LdVal_Scroll()
	End Sub

	Private Sub LdVal_Scroll() Handles LdVal.Scroll
		lblLDVal.Caption = LdVal.Value
	End Sub

End Class

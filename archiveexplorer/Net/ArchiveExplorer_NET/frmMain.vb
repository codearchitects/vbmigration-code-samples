' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private ZF As New Cls_GetFileType
	Private Filetype(10) As String
	
	Private Sub btnUnzip_Click() Handles btnUnzip.Click
		Dim FileUnzip() As Boolean
		Dim ToDir As String = ""
		Dim Sel As Boolean
		Dim X As Integer
		Dim RetVal As Boolean
		With lstInZip
			ReDim FileUnzip(.ListItems.Count)
			For X = 1 To .ListItems.Count
				If .ListItems(X).Selected Then 
					Sel = True
					Exit For
				End If
			Next
			For X = 1 To .ListItems.Count
				If .ListItems(X).Selected = Sel Then 
					FileUnzip(X) = True
				End If
			Next
		End With
		ToDir = tsGetPathFromUser()
		If ToDir = "" Then 
			MsgBox6("No path to store files")
			Exit Sub
		End If
		MousePointer = VBRUN.MousePointerConstants.vbHourglass
		RetVal = ZF.UnPack(FileUnzip, ToDir)
		'    RetVal = ZF.Unzip(FileUnzip, ToDir)
		MousePointer = FileAttribute.Normal
	End Sub

	Private Sub DirList_Change() Handles DirList.Change
		FileList.Path = DirList.Path
	End Sub

	Private Sub DriveList_Change() Handles DriveList.Change
		DirList.Path = DriveList.Drive
	End Sub

	Private Sub FileList_Click() Handles FileList.Click
		If FileList.FileName <> "" Then 
			lstInZip.ListItems.Clear
			Call Show_ZipContents()
			If Len6(ZF.CommentsPack) > 0 Then 
				MsgBox6(ZF.CommentsPack)
			End If
		End If
	End Sub

	Private Sub Show_ZipContents()
		Dim X As Integer
		Dim Enc As String = ""
		Dim DirCnt As Integer
		Dim FileCnt As Integer
		Dim Temp As Integer
		ZF.Get_Contents((DirList.Path & "\" & FileList.FileName))
		For X = 1 To lstInZip.ListItems.Count
			lstInZip.ListItems(X).Selected = False
		Next
		For X = 1 To ZF.FileCount
			With lstInZip
				Enc = " "
				If ZF.Encrypted(X) Then  Enc = "+"
				If Not ZF.IsDir(X) Then 
					FileCnt += 1
					.ListItems.Add(X, , Enc & ZF.FileName(X))
					.ListItems(X).SubItems(1) = ZF.Method(X)
					Temp = ZF.CRC32(X)
					If Temp = 0 Then 
						.ListItems(X).SubItems(2) = "?"
					Else
						.ListItems(X).SubItems(2) = Hex(Temp)
					End If
					Temp = ZF.Compressed_Size(X)
					If Temp = 0 Then 
						.ListItems(X).SubItems(3) = "?"
					Else
						.ListItems(X).SubItems(3) = Temp
					End If
					.ListItems(X).SubItems(4) = ZF.UnCompressed_Size(X)
					.ListItems(X).SubItems(5) = ZF.FileDateTime(X)
				Else
					DirCnt += 1
					.ListItems.Add(X, , Enc & ZF.FileName(X))
					.ListItems(X).SubItems(1) = ZF.Method(X)
					.ListItems(X).SubItems(2) = "Directory Entry"
					.ListItems(X).SubItems(3) = "Directory Entry"
					.ListItems(X).SubItems(4) = "Directory Entry"
					.ListItems(X).SubItems(5) = ZF.FileDateTime(X)
				End If
			End With
		Next
		If ZF.FileCount > 0 Then 
			lblHeadLine.Caption = "Contents of " & Filetype(PackFileType) & " file " & FileList.FileName & " -> " & DirCnt & " directories and " & FileCnt & " files"
		Else
			lblHeadLine.Caption = "Not supported format"
		End If
		If ZF.CanUnpack Then 
			btnUnzip.Enabled = True
		Else
			btnUnzip.Enabled = False
		End If
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call Insert_Header()
		'    FileList.Pattern = "*.zip;*.gz;*.tgz;*.tar;*.arj"
		Filetype(ZipFileType) = "ZIP"
		Filetype(GZFileType) = "GZIP"
		Filetype(TARFileType) = "TAR"
		Filetype(RARFileType) = "RAR"
		Filetype(ARJFileType) = "ARJ"
		Filetype(LZHFileType) = "LZH/LHA"
		Filetype(CABFileType) = "Cabinet"
		'    DirList.Path = "d:\download\new\archives"
		btnUnzip.Enabled = False
	End Sub

	Private Sub Insert_Header()
		With lstInZip
			.ColumnHeaders.Add(, , "File Name")
			.ColumnHeaders.Add(, , "Compression Method")
			.ColumnHeaders.Add(, , "CRC-32")
			.ColumnHeaders.Add(, , "Compressed Size")
			.ColumnHeaders.Add(, , "Decompressed Size")
			.ColumnHeaders.Add(, , "File date")
		End With
	End Sub

End Class

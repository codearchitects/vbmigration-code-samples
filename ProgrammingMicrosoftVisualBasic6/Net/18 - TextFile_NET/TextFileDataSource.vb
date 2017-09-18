' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Public Enum adsEOFActionEnum
	adsEOFActionMoveLast
	adsEOFActionEOF
	adsEOFActionAddnew
End Enum

Public Enum adsBOFAction
	adsBOFActionMoveFirst
	adsBOFActionBOF
End Enum

Friend Class TextFileDataSource
	Implements IDisposable
	Implements IVB6DataSourceClass

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	' A data source class that wraps semicolon delimited text files
	' The first line in the file holds the field names.

	' This event is sent when data is flushed to disk.
	Public Event Flush()
	
	Private Const DEFAULT_EXT As String = ".DAT"
	' Default extension for text files.
	
	' The manufactured ADO recordset
	Private rs As ADODB.Recordset
	
	Private m_DataMember As String = ""
	Private m_File As String = ""
	
	Private m_EOFAction As adsEOFActionEnum
	Private m_BOFAction As adsBOFAction
	Private m_FilePath As String = ""
	Private m_ReadOnlyMode As Boolean
	
	' Return the recordset when the consumer asks for it.
	
	Private Sub Class_GetDataMember(ByRef DataMember As String, ByRef Data As Object)
		If DataMember = "" Then  Exit Sub
		
		' Create the recordset only if necessary.
		' (it doesn't appear to be useful: defensive programming)
		If DataMember <> m_DataMember Or (rs Is Nothing) Then 
			LoadRecordset(DataMember)
		End If
		Data = rs
	End Sub

	Private Sub LoadRecordset(ByVal DataMember As String)
		Dim File As String = ""
		Dim fnum As Short
		Dim row As Integer
		Dim col As Integer
		Dim Text As String = ""
		Dim Lines() As String
		Dim Values() As String
		
		On Error GoTo ErrorHandler 
		
		File = m_FilePath & DataMember
		If InStr(File, ".") = 0 Then  File &= DEFAULT_EXT
		
		' Read the contents of file in memory.
		fnum = FreeFile6()
		FileOpen6(fnum, File, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		Text = FileInputString6(fnum, LOF6(fnum))
		FileClose6(fnum)
		
		' Create a new recordset.
		CloseRecordset()
		rs = New ADODB.Recordset()
		
		' Convert the long string into an array of arrays
		Lines = Split(Text, ControlChars.CrLf)
		' Get the field names, append to the Fields collection.
		Values = Split(Lines(0), ";")
		For col = 0 To UBound6(Values)
			rs.Fields.Append(Values(col), ADODB.DataTypeEnum.adBSTR)
		Next
		
		' Read the actual data, append to the recordset
		rs.Open()
		For row = 1 To UBound6(Lines)
			' Skip over empty lines.
			If Len6(Lines(row)) Then 
				Values = Split(Lines(row), ";")
				rs.AddNew()
				For col = 0 To UBound6(Values)
					rs.Fields(col).Value = Values(col)
				Next
			End If
		Next
		' Reset the record pointer.
		rs.MoveFirst()
		
		' remember DataMember and File for next time.
		m_DataMember = DataMember
		m_File = File
		Exit Sub
		
ErrorHandler:
		Err.Raise(1001, , "Unable to load data from " & DataMember)
	End Sub

	Public Sub Flush_Renamed()
		Dim fnum As Short
		Dim Text As String = ""
		Dim row As Integer
		Dim col As Integer
		Dim Bookmark As Object = Nothing
		
		On Error GoTo Error_Handler 
		
		' convert Field names into a semicolon-delimited string
		For col = 0 To rs.Fields.Count - 1
			Text = Text & rs.Fields(col).Name & ";"
		Next
		Text = VB.Left(Text, Len6(Text) - 1) & ControlChars.CrLf
		
		' Remember the current position in the recordset.
		Bookmark = rs.Bookmark
		' Convert data into a semicolon-delimited string
		rs.MoveFirst()
		Text &= rs.GetString(ADODB.StringFormatEnum.adClipString, , ";", ControlChars.CrLf)
		' Restore original position.
		rs.Bookmark = Bookmark
		
		' Flush the string to the file.
		fnum = FreeFile6()
		FileOpen6(fnum, m_File, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		FilePrint6(fnum, Text)
		FileClose6(1)
		
		RaiseEvent Flush()
		
		Exit Sub
		
Error_Handler:
		Err.Raise(1002, , "Unable to flush data to file")
	End Sub

	' "Safe" access to the recordset, raises a meaningful error if Nothing.
	
	Public ReadOnly Property Recordset() As ADODB.Recordset
		Get
			If rs Is Nothing Then 
				Err.Raise(1001, , "Recordset isn't available yet")
			Else
				Return rs
			End If
	 	End Get
	End Property

	' Close the recordset if still open.
	
	Private Sub CloseRecordset()
		If Not (rs Is Nothing) Then 
			If Not ReadOnlyMode Then  Flush_Renamed()
			rs.Close()
		End If
		m_DataMember = ""
	End Sub

	Private Sub Class_Initialize_VB6()
		RefreshDataMembers()
		m_ReadOnlyMode = True
	End Sub

	Private Sub Class_Terminate_VB6()
		' Close the recordset on exit.
		CloseRecordset()
	End Sub

	' The FilePath property.
	' Each time this property changes the DataMembers collection is refreshed.

	Public Property FilePath() As String
		Get
			Return m_FilePath
	 	End Get
		Set(ByVal newValue As String)
			If newValue <> m_FilePath Then 
				m_FilePath = newValue
				If Len6(m_FilePath) > 0 And InStr(":\", VB.Right(m_FilePath, 1)) = 0 Then 
					m_FilePath = m_FilePath & "\"
				End If
				RefreshDataMembers()
			End If
	 	End Set
	End Property

	' Rebuild the DataMembers collections
	
	Private Sub RefreshDataMembers()
		Dim File As String = ""
		
		DataMembers.Clear
		' Load all the file names in the directory
		File = Dir6(m_FilePath & "*" & DEFAULT_EXT)
		Do While Len6(File)
			DataMembers.Add(VB.Left(File, Len6(File) - Len6(DEFAULT_EXT)))
			File = Dir6()
		Loop
	End Sub

	' Public properties.
	
	Public ReadOnly Property EOF() As Boolean
		Get
			Return Recordset.EOF
	 	End Get
	End Property

	Public ReadOnly Property BOF() As Boolean
		Get
			Return Recordset.BOF
	 	End Get
	End Property

	Public ReadOnly Property RecordCount() As Integer
		Get
			Return Recordset.RecordCount
	 	End Get
	End Property

	Public Property Bookmark() As Object
		Get
			Return Recordset.Bookmark
	 	End Get
		Set(ByVal newValue As Object)
			Recordset.Bookmark = newValue
	 	End Set
	End Property

	' If ReadOnlyMode property is True, the file is saved

	Public Property ReadOnlyMode() As Boolean
		Get
			Return m_ReadOnlyMode
	 	End Get
		Set(ByVal newValue As Boolean)
			m_ReadOnlyMode = newValue
	 	End Set
	End Property

	' The EOFAction and BOFAction properties can't be delegated to the recordset.

	Public Property EOFAction() As adsEOFActionEnum
		Get
			Return m_EOFAction
	 	End Get
		Set(ByVal newValue As adsEOFActionEnum)
			m_EOFAction = newValue
	 	End Set
	End Property

	Public Property BOFAction() As adsBOFAction
		Get
			Return m_BOFAction
	 	End Get
		Set(ByVal newValue As adsBOFAction)
			m_BOFAction = newValue
	 	End Set
	End Property

	' Public Methods
	
	Public Sub MoveFirst()
		Recordset.MoveFirst()
	End Sub

	Public Sub MovePrevious()
		' Note that we don't need to use Recordset more than once.
		If Recordset.BOF Then 
			Select Case BOFAction
			Case adsBOFAction.adsBOFActionMoveFirst
				rs.MoveFirst()
			Case adsBOFAction.adsBOFActionBOF
				' do nothing
			End Select
		Else
			rs.MovePrevious()
		End If
	End Sub

	Public Sub MoveNext()
		' Note that we don't need to use Recordset more than once.
		If Not Recordset.EOF Then  rs.MoveNext()
		
		If rs.EOF Then 
			Select Case EOFAction
			Case adsEOFActionEnum.adsEOFActionMoveLast
				rs.MoveLast()
			Case adsEOFActionEnum.adsEOFActionEOF
				' do nothing
			Case adsEOFActionEnum.adsEOFActionAddnew
				rs.AddNew()
			End Select
		End If
	End Sub

	Public Sub MoveLast()
		Recordset.MoveLast()
	End Sub

	Public Sub AddNew()
		Recordset.AddNew()
	End Sub

	Public Sub Delete()
		Recordset.Delete()
	End Sub

	Public Sub Refresh()
		LoadRecordset(m_DataMember)
	End Sub

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub
	
	#Region "IVB6DataSourceClass members"
	
	Protected Sub DataSource_GetDataMember(ByRef dataMember As String, ByRef data As Object) Implements IVB6DataSourceClass.GetDataMember
		Class_GetDataMember(dataMember, data)
	End Sub
	
	Protected Sub DataMemberChanged(ByVal dataMember As String) Implements IVB6DataSourceClass.DataMemberChanged
		Class_GetDataMember(Nothing, Nothing)
	End Sub
	
	Private m_DataMembers As New VB6DataMembers
	Protected ReadOnly Property DataMembers() As VB6DataMembers Implements IVB6DataSourceClass.DataMembers
		Get
			Return m_DataMembers
		End Get
	End Property
	
	#End Region

End Class

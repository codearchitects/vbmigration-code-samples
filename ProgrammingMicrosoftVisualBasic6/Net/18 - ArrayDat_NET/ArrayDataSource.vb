' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Public Enum adsEOFActionEnum
	adsEOFActionMoveLast
	adsEOFActionEOF
	adsEOFActionAddnew
End Enum

Public Enum adsBOFAction
	adsBOFActionMoveFirst
	adsBOFActionBOF
End Enum

Friend Class ArrayDataSource
	Implements IVB6DataSourceClass

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' The manufactured ADO recordset
	Private rs As ADODB.Recordset
	
	' Member variable for EOFAction and BOFAction properties
	Private m_EOFAction As adsEOFActionEnum
	Private m_BOFAction As adsBOFAction

	' Initialize the array of data.
	
	Public Sub SetArray(ByVal Values As Object, ByVal Fields As Object)
		Dim row As Integer
		Dim col As Integer
		
		' Build the ADO recordset.
		If Not (rs Is Nothing) Then 
			If rs.Status = ADODB.ObjectStateEnum.adStateOpen Then  rs.Close()
		End If
		rs = New ADODB.Recordset()
		
		' Create the Fields collection.
		For col = LBound6(Fields) To UBound6(Fields)
			rs.Fields.Append(Fields(col), ADODB.DataTypeEnum.adBSTR)
		Next
		
		' Add the values.
		rs.Open()
		For row = LBound6(Values) To UBound6(Values)
			rs.AddNew()
			For col = 0 To UBound6(Values, 2)
				rs.Fields(col).Value = Values(row, col)
			Next
		Next
		rs.MoveFirst()
		
		' Inform consumers that the Data has changed
		DataMemberChanged("")
	End Sub

	' Retrieve the array of data as an array of Variant or String.
	
	Public Function GetArray(Optional ByVal ReturnAsString As Boolean = False) As Object
		Dim ValuesStr(,) As String    ' Implicitly declared array
		Dim ValuesVar(,) As Object    ' Implicitly declared array
		Dim numFields As Integer
		Dim row As Integer
		Dim col As Integer
		Dim Bookmark As Object = Nothing
		Dim result As Object = Nothing
		
		' Remember the current record pointer, raise error if no recordset.
		Bookmark = Recordset.Bookmark
		
		' Create the result array (String or Variant) and
		' assign to the result
		numFields = rs.Fields.Count
		If ReturnAsString Then 
			ReDim ValuesStr(rs.RecordCount - 1, numFields - 1)
			result = ValuesStr
		Else
			ReDim ValuesVar(rs.RecordCount - 1, numFields - 1)
			result = ValuesVar
		End If
		
		' Fill the array with data from the recordset.
		rs.MoveFirst()
		For row = 0 To rs.RecordCount - 1
			For col = 0 To numFields - 1
				result(row, col) = rs.Fields(col).Value
			Next
			rs.MoveNext()
		Next
		GetArray = result
		
		' restore record pointer
		rs.Bookmark = Bookmark
	End Function

	' Return the recordset when the consumer ask for it.
	
	Private Sub Class_GetDataMember(ByRef DataMember As String, ByRef Data As Object)
		' Return the recordset to the data consumer.
		Data = Recordset
	End Sub

	' "Safe" access to the recordset, raises a meaningful error if Nothing.
	
	Public ReadOnly Property Recordset() As ADODB.Recordset
		Get
			If rs Is Nothing Then 
				Err.Raise(1001, , "No data array has been provided")
			Else
				Return rs
			End If
	 	End Get
	End Property

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
		' No need to use Recordset more than once.
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
		' No real need to use Recordset more than once.
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
		With Recordset
			.Delete()
			.MoveNext()
			If .EOF And Not .BOF Then 
				' The next statement is necessary because the BOF condition
				' isn't correctly updated if the record was the only one
				' in the recordset
				On Error Resume Next 
				.MoveLast()
			End If
		End With
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

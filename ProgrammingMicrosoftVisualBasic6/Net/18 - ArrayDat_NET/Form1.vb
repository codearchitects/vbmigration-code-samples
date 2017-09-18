' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Public MyData As New ArrayDataSource
	
	Private Bookmark As Object

	Private Sub Form_Load() Handles MyBase.Load
		Dim Fields() As String    ' Implicitly declared array
		Dim Values(,) As String    ' Implicitly declared array
		' Create the Fields array.
		ReDim Fields(2)
		Fields(0) = "ID"
		Fields(1) = "Name"
		Fields(2) = "Department"
		
		' Create the Values array.
		ReDim Values(3, 2)
		SetArrayRow(Values, 0, 104, "Christine Johnson", "Marketing")
		SetArrayRow(Values, 1, 101, "John Smith", "Sales")
		SetArrayRow(Values, 2, 102, "Anne Robertson", "Sales")
		SetArrayRow(Values, 3, 103, "Robert Johnson", "Marketing")
		
		MyData.SetArray(Values, Fields)
		MyData.EOFAction = adsEOFActionEnum.adsEOFActionAddnew
		
		' Bind the controls
		txtID.DataSource = MyData
		txtID.DataField = "ID"
		txtName.DataSource = MyData
		txtName.DataField = "Name"
		txtDepartment.DataSource = MyData
		txtDepartment.DataField = "Department"
		
	End Sub

	Private Sub SetArrayRow(ByRef arr As Object, ByVal row As Integer, ByVal ParamArray Items() As Object)
		Dim i As Integer
		Dim j As Integer
		For i = LBound6(arr, 2) To UBound6(arr, 2)
			arr(row, i) = Items(j)
			j += 1
		Next
	End Sub

	Private Sub cmdMove_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			If CheckFields() Then  MyData.MoveFirst()
		Case 1
			If CheckFields() Then  MyData.MovePrevious()
		Case 2
			If CheckFields() Then  MyData.MoveNext()
		Case 3
			If CheckFields() Then  MyData.MoveLast()
		Case 4
			If CheckFields() Then  MyData.AddNew()
		Case 5
			MyData.Delete()
		Case 6
			Bookmark = MyData.Bookmark
		Case 7
			If CheckFields() Then  Me.MyData.Bookmark = Bookmark
		Case 8
			ShowData()
		End Select
	End Sub

	' Returns True if all the fields have been filled.
	
	Public Function CheckFields() As Boolean
		If MyData.BOF Or MyData.EOF Then 
			' no need to check values in this case
			Return True
		Else
			CheckFields = (txtID.Text <> "") And (txtName.Text <> "") And (txtDepartment.Text <> "")
			If Not CheckFields Then 
				MsgBox6("Please fill all the fields", MsgBoxStyle.Exclamation)
			End If
		End If
	End Function

	Private Sub ShowData()
		Dim Values(,) As String    ' Implicitly declared array
		ReDim Values(0, 0)
		Dim row As Integer
		Dim col As Integer
		Dim msg As String = ""
		
		Values = MyData.GetArray(True)
		For row = 0 To UBound6(Values)
			For col = 0 To UBound6(Values, 2)
				msg = msg & Values(row, col) & ","
			Next
			' Drop trailing comma, add a carriage return.
			msg = VB.Left(msg, Len6(msg) - 1) & ControlChars.CrLf
		Next
		
		MsgBox6(msg)
	End Sub

End Class

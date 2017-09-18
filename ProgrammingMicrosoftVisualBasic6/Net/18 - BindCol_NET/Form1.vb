' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const DBPATH As String = "c:\program files\microsoft visual studio\Vb98\nwind.mdb"
	
	Private cn As New ADODB.ConnectionClass
	Private rs As New ADODB.RecordsetClass
	Private WithEvents bndcol As VB6BindingCollection
	Private DateFormat As New VB6StdDataFormat
	' UPGRADE_INFO (#0501): The 'col' member isn't used anywhere in current application.
	Private WithEvents col As VB6BindingCollection
	Private Sub Form_Load() Handles MyBase.Load
		' Open the recordset
		cn.Open("Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH)
		rs.Open("Employees", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		
		' Create the two StdDataFormat objects
		DateFormat.Type = StdFormat.FormatType.fmtCustom
		DateFormat.Format = "mmmm dd, yyyy"
		
		' bind the recordset to fields
		bndcol = New VB6BindingCollection()
		bndcol.DataSource = rs
		bndcol.Add(txtFirstName, "Text", "FirstName")
		bndcol.Add(txtLastName, "Text", "LastName")
		bndcol.Add(txtBirthDate, "Text", "BirthDate", DateFormat)
		bndcol.Add(txtHireDate, "Text", "HireDate", DateFormat)
	End Sub

	Private Sub cmdMove_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			rs.MoveFirst()
		Case 1
			rs.MovePrevious()
		Case 2
			rs.MoveNext()
		Case 3
			rs.MoveLast()
		End Select
	End Sub

	Private Sub bndcol_Error(ByVal [Error] As Integer, ByVal Description As String, ByVal Binding As VB6Binding, ByRef fCancelDisplay As Boolean) Handles bndcol.Error
		MsgBox6("An error has occurred:" & ControlChars.Cr & "Code: " & [Error] & ControlChars.Cr & "Description: " & Description, MsgBoxStyle.Exclamation)
		fCancelDisplay = True
	End Sub

End Class

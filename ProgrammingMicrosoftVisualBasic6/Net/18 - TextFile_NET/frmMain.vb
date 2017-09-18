' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	' Modify this constant to match your directory structure
	'Const DATABASE_DIRECTORY = "D:\Projects_NET20\VBMigrator\SamplesVB6\ProgrammingVB6 Book\17 - TextFile"
	Private Const DATABASE_DIRECTORY As String = ""
	
	' this serves to share data sources between forms.
	' This wrapper property has been added to preserve As New semantics of MyData variable
	Public Property MyData() As TextFileDataSource
		Get
			If MyData_InnerField Is Nothing Then MyData_InnerField = New TextFileDataSource()
			Return MyData_InnerField
		End Get
		Set(value As TextFileDataSource)
			MyData_InnerField = value
		End Set
	End Property
	
	Private MyData_InnerField As TextFileDataSource
	
	Private Sub Command1_Dummy()
		' dummy event
	End Sub

	Private Sub Form_Dummy()
		' dummy initializer
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		'Err.Raise 999, , "Fuffa"
		
		Dim frm As New frmRecord
		frm.MyData = GetDataSource()
		frm.Show(, Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Dim frm As New frmTable
		frm.MyData = GetDataSource()
		frm.Show(, Me)
	End Sub

	Private Function GetDataSource() As TextFileDataSource
		If Option1(1).Value Then 
			MyData = New TextFileDataSource()
		End If
		MyData.FilePath = DATABASE_DIRECTORY
		Return MyData
	End Function

End Class

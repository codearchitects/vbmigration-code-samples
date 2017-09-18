' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class DataEnvironment1
	Inherits VB6DataEnvironment
' UPGRADE_INFO (#0501): The 'DataEnvironment1' member isn't used anywhere in current application.

	#Region "DefInstance"
	
		Private Shared m_DefInstance As DataEnvironment1
	
		Public Shared ReadOnly Property DefInstance() As DataEnvironment1
			Get
				If m_DefInstance Is Nothing Then m_DefInstance = New DataEnvironment1()
				Return m_DefInstance
			End Get
		End Property
	
	#End Region
	
	#Region "Public Connection and Recordset variables"
	
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsAuthors As ADODB.Recordset
	Public WithEvents rsTitle_Author As ADODB.Recordset
	Public WithEvents rsTitles As ADODB.Recordset
	
	' Private Command variables
	Private m_Authors As ADODB.Command
	Private m_Title_Author As ADODB.Command
	Private m_Titles As ADODB.Command
	
	Public Sub New()
		' The Connection1 connection
		Connection1 = CreateConnection("Connection1", "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\BIBLIO.MDB;Mode=Share Deny None;Extended Properties="""";Persist Security Info=False;Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False")
		' The Authors command
		m_Authors = CreateCommand("Authors", "Authors", 2, -1, False)
		rsAuthors = CreateRecordset("Authors", m_Authors, 3, -1, -1, -1)
		' The Title_Author command
		m_Title_Author = CreateCommand("Title_Author", "Title Author", 2, -1, False)
		rsTitle_Author = CreateRecordset("Title_Author", m_Title_Author, 3, -1, -1, -1)
		' The Titles command
		m_Titles = CreateCommand("Titles", "Titles", 2, -1, False)
		rsTitles = CreateRecordset("Titles", m_Titles, 3, -1, -1, -1)
	End Sub

	' public Command methods
	
	Public Sub Authors()
		ExecuteCommand(m_Authors, Connection1, rsAuthors)
	End Sub
	
	Public Sub Title_Author()
		ExecuteCommand(m_Title_Author, Connection1, rsTitle_Author)
	End Sub
	
	Public Sub Titles()
		ExecuteCommand(m_Titles, Connection1, rsTitles)
	End Sub

	#End Region

	' WARNING: Ensure that this constant points to a valid
	' copy of the Biblio.mdb database.
	'Const DB_PATH = "e:\VisStudio\Vb98\Biblio.mdb"
	Private Const DB_PATH As String = "c:\program files\Microsoft Visual Studio\Vb98\Biblio.mdb"
	
	Private Sub Connection1_WillConnect(ByRef ConnectionString As String, ByRef UserID As String, ByRef Password As String, ByRef Options As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles Connection1.WillConnect
		Dim i As Short
		Dim j As Short
		' Search and replace the Data Source argument.
		i = InStr(ConnectionString, "Data Source=")
		If i Then 
			j = InStr(i, ConnectionString & ";", ";")
			ConnectionString = VB.Left(ConnectionString, i + 11) & DB_PATH & Mid(ConnectionString, j)
		End If
		
	End Sub

End Class

' this class offers support for DataEnvironment used as design-time data sources

Friend Class DataEnvironment1_Instance
	Inherits System.ComponentModel.Component
	Implements IVB6DataEnvironmentInstance

	Public Function GetDataEnvironment() As CodeArchitects.VB6Library.VB6DataEnvironment Implements CodeArchitects.VB6Library.IVB6DataEnvironmentInstance.GetDataEnvironment
		Return DataEnvironment1.DefInstance
	End Function
End Class

' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

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
	
	Public WithEvents Biblio As ADODB.Connection
	Public WithEvents rsAuthors As ADODB.Recordset
	Public WithEvents rsTitle_Author As ADODB.Recordset
	Public WithEvents rsTitles As ADODB.Recordset
	Public WithEvents rsPublishers As ADODB.Recordset
	Public WithEvents rsTitles2 As ADODB.Recordset
	Public WithEvents rsPublishers2 As ADODB.Recordset
	
	' Private Command variables
	Private m_Authors As ADODB.Command
	Private m_Title_Author As ADODB.Command
	Private m_Titles As ADODB.Command
	Private m_Publishers As ADODB.Command
	Private m_Titles2 As ADODB.Command
	Private m_Publishers2 As ADODB.Command
	
	Public Sub New()
		' The Biblio connection
		Biblio = CreateConnection("Biblio", "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\BIBLIO.MDB;Mode=Share Deny None;Extended Properties="""";Persist Security Info=False;Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False")
		' The Authors command
		m_Authors = CreateCommand("Authors", "Authors", 2, -1, False)
		rsAuthors = CreateRecordset("Authors", m_Authors, 3, -1, -1, -1)
		' The Title_Author command
		m_Title_Author = CreateCommand("Title_Author", "Title Author", 2, -1, False)
		rsTitle_Author = CreateRecordset("Title_Author", m_Title_Author, 3, -1, -1, -1)
		' The Titles command
		m_Titles = CreateCommand("Titles", "Titles", 2, -1, False)
		rsTitles = CreateRecordset("Titles", m_Titles, 3, -1, -1, -1)
		' The Publishers command
		m_Publishers = CreateCommand("Publishers", "Publishers", 2, -1, False)
		rsPublishers = CreateRecordset("Publishers", m_Publishers, 3, -1, -1, -1)
		' The Titles2 command
		m_Titles2 = CreateCommand("Titles2", "Titles", 2, -1, False)
		rsTitles2 = CreateRecordset("Titles2", m_Titles2, 3, -1, -1, -1)
		' The Publishers2 command
		m_Publishers2 = CreateCommand("Publishers2", "Publishers", 2, -1, False)
		rsPublishers2 = CreateRecordset("Publishers2", m_Publishers2, 3, -1, -1, -1)
	End Sub

	' public Command methods
	
	Public Sub Authors()
		ExecuteCommand(m_Authors, Biblio, rsAuthors)
	End Sub
	
	Public Sub Title_Author()
		ExecuteCommand(m_Title_Author, Biblio, rsTitle_Author)
	End Sub
	
	Public Sub Titles()
		ExecuteCommand(m_Titles, Biblio, rsTitles)
	End Sub
	
	Public Sub Publishers()
		ExecuteCommand(m_Publishers, Biblio, rsPublishers)
	End Sub
	
	Public Sub Titles2()
		ExecuteCommand(m_Titles2, Biblio, rsTitles2)
	End Sub
	
	Public Sub Publishers2()
		ExecuteCommand(m_Publishers2, Biblio, rsPublishers2)
	End Sub

	#End Region

End Class

' this class offers support for DataEnvironment used as design-time data sources

Friend Class DataEnvironment1_Instance
	Inherits System.ComponentModel.Component
	Implements IVB6DataEnvironmentInstance

	Public Function GetDataEnvironment() As CodeArchitects.VB6Library.VB6DataEnvironment Implements CodeArchitects.VB6Library.IVB6DataEnvironmentInstance.GetDataEnvironment
		Return DataEnvironment1.DefInstance
	End Function
End Class

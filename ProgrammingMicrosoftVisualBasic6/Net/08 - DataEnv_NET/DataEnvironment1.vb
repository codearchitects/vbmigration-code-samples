' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

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
	
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsauthors As ADODB.Recordset
	Public WithEvents rsAuthorsByState As ADODB.Recordset
	
	' Private Command variables
	Private m_authors As ADODB.Command
	Private m_AuthorsByState As ADODB.Command
	
	Public Sub New()
		' The Connection1 connection
		Connection1 = CreateConnection("Connection1", "Provider=SQLOLEDB.1;Password=sa;Persist Security Info=True;User ID=sa;Data Source=localhost\SQLEXPRESS")
		' The authors command
		m_authors = CreateCommand("authors", "dbo.authors", 2, -1, False)
		rsauthors = CreateRecordset("authors", m_authors, 3, -1, -1, -1)
		' The AuthorsByState command
		m_AuthorsByState = CreateCommand("AuthorsByState", "SELECT * FROM Authors WHERE State = ? ", 1, -1, False)
		CreateParameter(m_AuthorsByState, "State", 200, 1, 2, 0, 0)
		rsAuthorsByState = CreateRecordset("AuthorsByState", m_AuthorsByState, 3, -1, -1, -1)
	End Sub

	' public Command methods
	
	Public Sub authors()
		ExecuteCommand(m_authors, Connection1, rsauthors)
	End Sub
	
	Public Sub AuthorsByState(ByVal State As String)
		m_AuthorsByState.Parameters("State").Value = State
		ExecuteCommand(m_AuthorsByState, Connection1, rsAuthorsByState)
	End Sub
	
	Public Sub AuthorsByState()
		AuthorsByState("")
	End Sub

	#End Region
	
	' This code proves that the Disconnect and the Terminate events
	' are never executed for the DataEnvironment designer, if you use
	' a DE object that is global or stored in a form-level variable.
	
	Private Sub Connection1_Disconnect(ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles Connection1.Disconnect
		MsgBox6("disconnect")
	End Sub

	Protected Overrides Sub DataEnvironment_Terminate_VB6()
		MsgBox6("Terminate")
	End Sub

	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
				DataEnvironment_Terminate_VB6()
		Finally
			MyBase.Dispose(disposing)
		End Try
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

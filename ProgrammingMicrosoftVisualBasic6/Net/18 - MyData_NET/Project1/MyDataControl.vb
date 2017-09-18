' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<System.Runtime.InteropServices.ProgID("Project1.MyDataControl")> _ 
<VB6Object("Project1.MyDataControl")> _
Public Class MyDataControl
	Implements IVB6DataSourceClass

	Public Enum mdcBOFActionEnum
		mdcBOFActionMoveFirst
		mdcBOFActionBOF
	End Enum

	Public Enum mdcEOFActionEnum
		mdcEOFActionMoveLast
		mdcEOFActionEOF
		mdcEOFActionAddNew
	End Enum

	Private cn As ADODB.Connection
	Private rs As ADODB.Recordset
	
	Private CnIsInvalid As Boolean
	Private RsIsInvalid As Boolean
	
	'Default Property Values
	Private Const m_def_RecordSource As String = ""
	Private Const m_def_Provider As String = ""
	Private Const m_def_BOFAction As Integer = mdcBOFActionEnum.mdcBOFActionMoveFirst
	Private Const m_def_EOFAction As Integer = mdcEOFActionEnum.mdcEOFActionMoveLast
	Private Const m_def_UserName As String = ""
	Private Const m_def_Password As String = ""
	Private Const m_def_ConnectionString As String = ""
	
	'Property Variables
	Private m_RecordSource As String = ""
	Private m_Provider As Object
	Private m_BOFAction As MyDataControl.mdcBOFActionEnum
	Private m_EOFAction As MyDataControl.mdcEOFActionEnum
	Private m_UserName As String = ""
	Private m_Password As String = ""
	Private m_ConnectionString As String = ""
	Private m_CommandType As ADODB.CommandTypeEnum
	Private m_CursorType As ADODB.CursorTypeEnum
	Private m_LockType As ADODB.LockTypeEnum
	Private m_CursorLocation As ADODB.CursorLocationEnum
	
	Private Sub cmdMove_Click(ByRef Index As Short)
		If rs Is Nothing Then  Exit Sub
		Select Case Index
		Case 0
			rs.MoveFirst()
		Case 1
			If rs.BOF Then 
				Select Case m_BOFAction
				Case mdcBOFActionEnum.mdcBOFActionMoveFirst
					rs.MoveFirst()
				Case mdcBOFActionEnum.mdcBOFActionBOF
					' Do nothing.
				End Select
			Else
				rs.MovePrevious()
			End If
		Case 2
			If rs.EOF = False Then  rs.MoveNext()
			If rs.EOF = True Then 
				Select Case m_EOFAction
				Case mdcEOFActionEnum.mdcEOFActionAddNew
					rs.AddNew()
				Case mdcEOFActionEnum.mdcEOFActionMoveLast
					rs.MoveLast()
				Case mdcEOFActionEnum.mdcEOFActionEOF
					' do nothing
				End Select
			End If
		Case 3
			rs.MoveLast()
		Case 4
			rs.AddNew()
		Case 5
			rs.Delete()
		End Select
	End Sub

	' Raise an error in the most appropriate way.
	
	Private Sub RaiseError(ByRef ercode As Integer, ByRef Description As String)
	' UPGRADE_INFO (#0551): The 'ercode' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Description' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Ambient.UserMode = True Then 
			Err.Raise(ercode, Ambient.DisplayName, Description)
		Else
			MsgBox6(Description, MsgBoxStyle.Exclamation, Ambient.DisplayName)
		End If
	End Sub

	' Close the recordset and the connection in the correct way.
	
	Private Sub CloseRecordset()
		If Not rs Is Nothing Then 
			If rs.State <> ADODB.ObjectStateEnum.adStateClosed Then  rs.Close()
			rs = Nothing
		End If
	End Sub

	Private Sub CloseConnection()
		CloseRecordset()
		If Not cn Is Nothing Then 
			If cn.State <> ADODB.ObjectStateEnum.adStateClosed Then  cn.Close()
			cn = Nothing
		End If
	End Sub

	Private Sub UserControl_GetDataMember(ByRef DataMember As String, ByRef Data As Object)
		
		On Error GoTo Error_Handler 
		
		' Recreate the connection if necessary.
		If cn Is Nothing Or CnIsInvalid Then 
			' Close the recordset and the connection, if open.
			CloseConnection()
			
			' Validate the ConnectionString property.
			If Trim(m_ConnectionString) = "" Then 
				Err.Raise(1001, Ambient.DisplayName, "ConnectionString can't be a null string")
			Else
				' Open the connection
				cn = New ADODB.Connection()
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'm_Provider'. Consider using the GetDefaultMember6 helper method.
				If m_Provider <> "" Then  cn.Provider = m_Provider
				
				' Three cases
				If Trim(m_UserName) = "" Then 
					cn.Open(m_ConnectionString)
				ElseIf Trim(m_Password) = "" Then 
					cn.Open(m_ConnectionString, m_UserName)
				Else
					cn.Open(m_ConnectionString, m_UserName, m_Password)
				End If
				CnIsInvalid = False
			End If
		End If
		
		' Recreate the Recordset, if necessary
		If rs Is Nothing Or RsIsInvalid Then 
			rs = New ADODB.Recordset()
			rs.CursorLocation = m_CursorLocation
			rs.Open(m_RecordSource, cn, m_CursorType, m_LockType, m_CommandType)
			rs.MoveFirst()
			RsIsInvalid = False
			' UPGRADE NOTE: under .NET we must force re-binding
			VB6DataSourceWrapper.Create(rs, Me)
		End If
		
		' Return the recordset to the data consumer.
		Data = rs
		Exit Sub
		
Error_Handler:
		RaiseError(Err.Number, Err.Description)
		CloseConnection()
	End Sub

	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public ReadOnly Property Recordset() As ADODB.Recordset
	' UPGRADE_INFO (#0501): The 'Recordset' member isn't used anywhere in current application.
		Get
			Return rs
	 	End Get
	End Property

	Public Property RecordSource() As String
		Get
			Return m_RecordSource
	 	End Get
		Set(ByVal New_RecordSource As String)
			m_RecordSource = New_RecordSource
			m_CommandType = ADODB.CommandTypeEnum.adCmdUnknown
			RsIsInvalid = True
	 	End Set
	End Property

	Public Property Provider() As Object
	' UPGRADE_INFO (#0501): The 'Provider' member isn't used anywhere in current application.
		Get
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'm_Provider'. Consider using the GetDefaultMember6 helper method.
			Return m_Provider
	 	End Get
		Set(ByVal New_Provider As Object)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'New_Provider'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'm_Provider'. Consider using the SetDefaultMember6 helper method.
			m_Provider = New_Provider
			CnIsInvalid = True
	 	End Set
	End Property

	Public Property BOFAction() As MyDataControl.mdcBOFActionEnum
	' UPGRADE_INFO (#0501): The 'BOFAction' member isn't used anywhere in current application.
		Get
			Return m_BOFAction
	 	End Get
		Set(ByVal New_BOFAction As MyDataControl.mdcBOFActionEnum)
			m_BOFAction = New_BOFAction
	 	End Set
	End Property

	Public Property EOFAction() As MyDataControl.mdcEOFActionEnum
	' UPGRADE_INFO (#0501): The 'EOFAction' member isn't used anywhere in current application.
		Get
			Return m_EOFAction
	 	End Get
		Set(ByVal New_EOFAction As MyDataControl.mdcEOFActionEnum)
			Select Case New_EOFAction
			Case mdcEOFActionEnum.mdcEOFActionMoveLast, mdcEOFActionEnum.mdcEOFActionEOF, mdcEOFActionEnum.mdcEOFActionAddNew
				m_EOFAction = New_EOFAction
			Case Else
				Err.Raise(5)
			End Select
	 	End Set
	End Property

	Public Property UserName() As String
	' UPGRADE_INFO (#0501): The 'UserName' member isn't used anywhere in current application.
		Get
			Return m_UserName
	 	End Get
		Set(ByVal New_UserName As String)
			m_UserName = New_UserName
			CnIsInvalid = True
	 	End Set
	End Property

	Public Property Password() As String
	' UPGRADE_INFO (#0501): The 'Password' member isn't used anywhere in current application.
		Get
			Return m_Password
	 	End Get
		Set(ByVal New_Password As String)
			m_Password = New_Password
			CnIsInvalid = True
	 	End Set
	End Property

	Public Property ConnectionString() As String
		Get
			Return m_ConnectionString
	 	End Get
		Set(ByVal New_ConnectionString As String)
			m_ConnectionString = New_ConnectionString
			CnIsInvalid = True
	 	End Set
	End Property

	Public Property CommandType() As ADODB.CommandTypeEnum
	' UPGRADE_INFO (#0501): The 'CommandType' member isn't used anywhere in current application.
		Get
			Return m_CommandType
	 	End Get
		Set(ByVal New_CommandType As ADODB.CommandTypeEnum)
			m_CommandType = New_CommandType
			RsIsInvalid = True
	 	End Set
	End Property

	Public Property CursorType() As ADODB.CursorTypeEnum
	' UPGRADE_INFO (#0501): The 'CursorType' member isn't used anywhere in current application.
		Get
			Return m_CursorType
	 	End Get
		Set(ByVal New_CursorType As ADODB.CursorTypeEnum)
			m_CursorType = New_CursorType
			RsIsInvalid = True
	 	End Set
	End Property

	Public Property LockType() As ADODB.LockTypeEnum
	' UPGRADE_INFO (#0501): The 'LockType' member isn't used anywhere in current application.
		Get
			Return m_LockType
	 	End Get
		Set(ByVal New_LockType As ADODB.LockTypeEnum)
			m_LockType = New_LockType
			RsIsInvalid = True
	 	End Set
	End Property

	Public Property CursorLocation() As ADODB.CursorLocationEnum
	' UPGRADE_INFO (#0501): The 'CursorLocation' member isn't used anywhere in current application.
		Get
			Return m_CursorLocation
	 	End Get
		Set(ByVal New_CursorLocation As ADODB.CursorLocationEnum)
			m_CursorLocation = New_CursorLocation
			RsIsInvalid = True
	 	End Set
	End Property

	Public Shadows Sub Refresh()
		CloseRecordset()
		DataMemberChanged("")
	End Sub

	Protected Overrides Sub UserControl_InitProperties()
		m_RecordSource = m_def_RecordSource
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'm_Provider'. Consider using the SetDefaultMember6 helper method.
		m_Provider = m_def_Provider
		m_BOFAction = m_def_BOFAction
		m_EOFAction = m_def_EOFAction
		m_UserName = m_def_UserName
		m_Password = m_def_Password
		m_ConnectionString = m_def_ConnectionString
		m_CommandType = ADODB.CommandTypeEnum.adCmdUnknown
		m_CursorType = ADODB.CursorTypeEnum.adOpenStatic
		m_LockType = ADODB.LockTypeEnum.adLockOptimistic
		m_CursorLocation = ADODB.CursorLocationEnum.adUseClient
	End Sub

	Protected Overrides Sub UserControl_ReadProperties(ByRef PropBag As VB6PropertyBag)
		m_RecordSource = PropBag.ReadProperty("RecordSource", m_def_RecordSource)
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'm_Provider'. Consider using the SetDefaultMember6 helper method.
		m_Provider = PropBag.ReadProperty("Provider", m_def_Provider)
		m_BOFAction = PropBag.ReadProperty("BOFAction", m_def_BOFAction)
		m_EOFAction = PropBag.ReadProperty("EOFAction", m_def_EOFAction)
		m_UserName = PropBag.ReadProperty("UserName", m_def_UserName)
		m_Password = PropBag.ReadProperty("Password", m_def_Password)
		m_ConnectionString = PropBag.ReadProperty("ConnectionString", m_def_ConnectionString)
		m_CommandType = PropBag.ReadProperty("CommandType", ADODB.CommandTypeEnum.adCmdUnknown)
		m_CursorType = PropBag.ReadProperty("CursorType", ADODB.CursorTypeEnum.adOpenStatic)
		m_LockType = PropBag.ReadProperty("LockType", ADODB.LockTypeEnum.adLockOptimistic)
		m_CursorLocation = PropBag.ReadProperty("CursorLocation", ADODB.CursorLocationEnum.adUseClient)
	End Sub

	Protected Overrides Sub UserControl_WriteProperties(ByRef PropBag As VB6PropertyBag)
		Call PropBag.WriteProperty("RecordSource", m_RecordSource, m_def_RecordSource)
		Call PropBag.WriteProperty("Provider", m_Provider, m_def_Provider)
		Call PropBag.WriteProperty("BOFAction", m_BOFAction, m_def_BOFAction)
		Call PropBag.WriteProperty("EOFAction", m_EOFAction, m_def_EOFAction)
		Call PropBag.WriteProperty("UserName", m_UserName, m_def_UserName)
		Call PropBag.WriteProperty("Password", m_Password, m_def_Password)
		Call PropBag.WriteProperty("ConnectionString", m_ConnectionString, m_def_ConnectionString)
		Call PropBag.WriteProperty("CommandType", m_CommandType, ADODB.CommandTypeEnum.adCmdUnknown)
		Call PropBag.WriteProperty("CursorType", m_CursorType, ADODB.CursorTypeEnum.adOpenStatic)
		Call PropBag.WriteProperty("LockType", m_LockType, ADODB.LockTypeEnum.adLockOptimistic)
		Call PropBag.WriteProperty("CursorLocation", m_CursorLocation, ADODB.CursorLocationEnum.adUseClient)
	End Sub

	Protected Overrides Sub UserControl_Terminate_VB6()
		On Error Resume Next 
		CloseConnection()
		Err.Clear()
	End Sub

	#Region "IVB6DataSourceClass members"
	
	Protected Sub DataSource_GetDataMember(ByRef dataMember As String, ByRef data As Object) Implements IVB6DataSourceClass.GetDataMember
		UserControl_GetDataMember(dataMember, data)
	End Sub
	
	Protected Sub DataMemberChanged(ByVal dataMember As String) Implements IVB6DataSourceClass.DataMemberChanged
		UserControl_GetDataMember(Nothing, Nothing)
	End Sub
	
	Private m_DataMembers As New VB6DataMembers
	Protected ReadOnly Property DataMembers() As VB6DataMembers Implements IVB6DataSourceClass.DataMembers
		Get
			Return m_DataMembers
		End Get
	End Property
	
	#End Region

End Class

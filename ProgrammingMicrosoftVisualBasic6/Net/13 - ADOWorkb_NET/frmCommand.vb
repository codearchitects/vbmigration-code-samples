' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmCommand

	Public cmd As ADODB.Command
	Public cn As ADODB.Connection
	
	Private rs As ADODB.Recordset
	
	Private frmParameters As frmParameters
	
	Private Sub cmdShowParameters_Click() Handles cmdShowParameters.Click
		On Error Resume Next 
		frmParameters = New frmParameters()
		frmParameters.Parameters = cmd.Parameters
		frmParameters.Show()
	End Sub

	Private Sub cmdDefineConnection_Click() Handles cmdDefineConnection.Click
		Dim frmConnection As frmConnection = New frmConnection()
		frmConnection.cn = cn
		frmConnection.Show(VBRUN.FormShowConstants.vbModal)
		cn = frmConnection.cn
	End Sub

	Private Sub cmdShowRecordset_Click() Handles cmdShowRecordset.Click
		Dim frmRecordset As New frmRecordset
		frmRecordset.rs = rs
		frmRecordset.Show()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		cmd = New ADODB.Command()
		InitFields()
		ShowProperties()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If Not (frmParameters Is Nothing) Then  Unload6(frmParameters)
	End Sub

	Private Sub lstCustomProperties_Click() Handles lstCustomProperties.Click
		txtCustomProperty.Text = GetCustomPropertyValue(cmd, lstCustomProperties)
		cmdSet.Enabled = CustomPropertyIsWriteable(cmd, lstCustomProperties)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		SetCustomPropertyValue(cmd, lstCustomProperties, txtCustomProperty.Text)
	End Sub

	Private Sub cmdSetProperties_Click() Handles cmdSetProperties.Click
		AssignProperties()
		ShowProperties()
	End Sub

	' Initialize fields and combo boxes
	
	Private Sub InitFields()
		AddToCombo(cboPrepared, "False", CShort(False))
		AddToCombo(cboPrepared, "True", CShort(True))
		
		AddToCombo(cboCommandType, "adCmdText", ADODB.CommandTypeEnum.adCmdText)
		AddToCombo(cboCommandType, "adCmdTable", ADODB.CommandTypeEnum.adCmdTable)
		AddToCombo(cboCommandType, "adCmdStoredProc", ADODB.CommandTypeEnum.adCmdStoredProc)
		AddToCombo(cboCommandType, "adCmdUnknown", ADODB.CommandTypeEnum.adCmdUnknown)
		AddToCombo(cboCommandType, "adCmdFile", ADODB.CommandTypeEnum.adCmdFile)
		AddToCombo(cboCommandType, "adCmdTableDirect", ADODB.CommandTypeEnum.adCmdTableDirect)
		
		AddToCombo(cboState, "adStateClosed", ADODB.ObjectStateEnum.adStateClosed)
		AddToCombo(cboState, "adStateOpen", ADODB.ObjectStateEnum.adStateOpen)
		AddToCombo(cboState, "adStateConnecting", ADODB.ObjectStateEnum.adStateConnecting)
		AddToCombo(cboState, "adStateExecuting", ADODB.ObjectStateEnum.adStateExecuting)
		AddToCombo(cboState, "adStateFetching", ADODB.ObjectStateEnum.adStateFetching)
	End Sub

	' Refresh the contents of the property fields.
	
	Public Sub ShowProperties()
		ShowProperty(cmd, txtCommandText)
		ShowProperty(cmd, txtCommandTimeout)
		ShowProperty(cmd, cboCommandType)
		ShowProperty(cmd, txtName)
		ShowProperty(cmd, cboPrepared)
		ShowProperty(cmd, cboState)
		
		cmdShowRecordset.Enabled = Not (rs Is Nothing)
		
		' If you query the Properties collection before opening the connection
		' you might make it impossible to open the connection later.
		ShowCustomProperties(cmd, lstCustomProperties)
		cmdSet.Enabled = True
	End Sub

	' Assign current values in fields to properties
	
	Public Sub AssignProperties()
		AssignProperty(cmd, txtCommandText)
		AssignProperty(cmd, txtCommandTimeout)
		AssignProperty(cmd, cboCommandType)
		AssignProperty(cmd, txtName)
		AssignProperty(cmd, cboPrepared)
	End Sub

	Private Sub cmdMethod_Click(ByRef Index As Short)
		Dim action As String = ""
		Dim args(5) As Object
		Dim returnValue As Object = Nothing
		Dim retLong As Integer
		Dim frmArgs As New frmArguments
		
		On Error GoTo ErrorHandler 
		
		AssignProperties()
		
		' prepare the ActiveConnection property
		If Not (cn Is Nothing) Then  cmd.ActiveConnection.ConnectionString = cn.ConnectionString
		
		Dim param As ADODB.Parameter = Nothing
		Select Case Index
		Case 0
			action = "execute the command"
			If frmArgs.GetArgValues("Execute", args, "@Options") Then 
				If IsMissing6(args(0)) Then  args(0) = -1
				rs = cmd.Execute(retLong, , args(0))
				If rs Is Nothing Then  returnValue = retLong
			End If
		Case 1
			action = "cancel the command"
			cmd.Cancel()
		Case 2
			action = "create a new parameter"
			If frmArgs.GetArgValues("CreateParameter", args, "Name", "Type", "@Direction", "@Size", "@Value") Then 
				param = cmd.CreateParameter()
				If Not IsMissing6(args(0)) Then  param.Name = args(0)
				If Not IsMissing6(args(1)) Then  param.Type = args(1)
				If Not IsMissing6(args(2)) Then  param.Direction = args(2)
				If Not IsMissing6(args(3)) Then  param.Size = args(3)
				If Not IsMissing6(args(4)) Then  param.Value = args(4)
				cmd.Parameters.Append(param)
			End If
		End Select
		
		ShowProperties()
		If Not IsEmpty6(returnValue) Then 
			On Error Resume Next 
			MsgBox6("Return Value = " & returnValue, MsgBoxStyle.Information, cmdMethod(Index).Name & " Method")
		End If
		
		Exit Sub
		
ErrorHandler:
		MsgBox6("Unable to " & action & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
		
	End Sub

End Class

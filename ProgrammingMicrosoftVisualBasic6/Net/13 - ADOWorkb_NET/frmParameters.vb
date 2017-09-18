' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmParameters

	Public Parameters As ADODB.Parameters
	Private param As ADODB.Parameter
	
	Private Sub cboName_Click() Handles cboName.Click
		param = Parameters(cboName.Text)
		ShowProperties()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		InitFields()
		' Set the current parameter (also fires ShowProperties)
		If cboName.ListCount Then  cboName.ListIndex = 0
	End Sub

	Private Sub lstCustomProperties_Click() Handles lstCustomProperties.Click
		txtCustomProperty.Text = GetCustomPropertyValue(param, lstCustomProperties)
		cmdSet.Enabled = CustomPropertyIsWriteable(param, lstCustomProperties)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		SetCustomPropertyValue(param, lstCustomProperties, txtCustomProperty.Text)
	End Sub

	Private Sub cmdSetProperties_Click() Handles cmdSetProperties.Click
		AssignProperties()
		ShowProperties()
	End Sub

	' Initialize Parameters and combo boxes
	
	Private Sub InitFields()
		AddToCombo(cboAttributes, "adParamSigned", ADODB.ParameterAttributesEnum.adParamSigned)
		AddToCombo(cboAttributes, "adParamNullable", ADODB.ParameterAttributesEnum.adParamNullable)
		AddToCombo(cboAttributes, "adParamLong", ADODB.ParameterAttributesEnum.adParamLong)
		
		AddToCombo(cboDirection, "adParamUnknown", ADODB.ParameterDirectionEnum.adParamUnknown)
		AddToCombo(cboDirection, "adParamInput", ADODB.ParameterDirectionEnum.adParamInput)
		AddToCombo(cboDirection, "adParamOutput", ADODB.ParameterDirectionEnum.adParamOutput)
		AddToCombo(cboDirection, "adParamInputOutput", ADODB.ParameterDirectionEnum.adParamInputOutput)
		AddToCombo(cboDirection, "adParamReturnValue", ADODB.ParameterDirectionEnum.adParamReturnValue)
		
		AddToCombo(cboType, "adEmpty", ADODB.DataTypeEnum.adEmpty)
		AddToCombo(cboType, "adSmallInt", ADODB.DataTypeEnum.adSmallInt)
		AddToCombo(cboType, "adInteger", ADODB.DataTypeEnum.adInteger)
		AddToCombo(cboType, "adSingle", ADODB.DataTypeEnum.adSingle)
		AddToCombo(cboType, "adDouble", ADODB.DataTypeEnum.adDouble)
		AddToCombo(cboType, "adCurrency", ADODB.DataTypeEnum.adCurrency)
		AddToCombo(cboType, "adDate", ADODB.DataTypeEnum.adDate)
		AddToCombo(cboType, "adBSTR", ADODB.DataTypeEnum.adBSTR)
		AddToCombo(cboType, "adIDispatch", ADODB.DataTypeEnum.adIDispatch)
		AddToCombo(cboType, "adError", ADODB.DataTypeEnum.adError)
		AddToCombo(cboType, "adBoolean", ADODB.DataTypeEnum.adBoolean)
		AddToCombo(cboType, "adVariant", ADODB.DataTypeEnum.adVariant)
		AddToCombo(cboType, "adIUnknown", ADODB.DataTypeEnum.adIUnknown)
		AddToCombo(cboType, "adDecimal", ADODB.DataTypeEnum.adDecimal)
		AddToCombo(cboType, "adTinyInt", ADODB.DataTypeEnum.adTinyInt)
		AddToCombo(cboType, "adUnsignedTinyInt", ADODB.DataTypeEnum.adUnsignedTinyInt)
		AddToCombo(cboType, "adUnsignedSmallInt", ADODB.DataTypeEnum.adUnsignedSmallInt)
		AddToCombo(cboType, "adUnsignedInt", ADODB.DataTypeEnum.adUnsignedInt)
		AddToCombo(cboType, "adBigInt", ADODB.DataTypeEnum.adBigInt)
		AddToCombo(cboType, "adUnsignedBigInt", ADODB.DataTypeEnum.adUnsignedBigInt)
		AddToCombo(cboType, "adGUID", ADODB.DataTypeEnum.adGUID)
		AddToCombo(cboType, "adBinary", ADODB.DataTypeEnum.adBinary)
		AddToCombo(cboType, "adChar", ADODB.DataTypeEnum.adChar)
		AddToCombo(cboType, "adWChar", ADODB.DataTypeEnum.adWChar)
		AddToCombo(cboType, "adNumeric", ADODB.DataTypeEnum.adNumeric)
		AddToCombo(cboType, "adUserDefined", ADODB.DataTypeEnum.adUserDefined)
		AddToCombo(cboType, "adDBDate", ADODB.DataTypeEnum.adDBDate)
		AddToCombo(cboType, "adDBTime", ADODB.DataTypeEnum.adDBTime)
		AddToCombo(cboType, "adDBTimeStamp", ADODB.DataTypeEnum.adDBTimeStamp)
		AddToCombo(cboType, "adChapter", ADODB.DataTypeEnum.adChapter)
		AddToCombo(cboType, "adVarNumeric", ADODB.DataTypeEnum.adVarNumeric)
		AddToCombo(cboType, "adVarChar", ADODB.DataTypeEnum.adVarChar)
		AddToCombo(cboType, "adLongVarChar", ADODB.DataTypeEnum.adLongVarChar)
		AddToCombo(cboType, "adVarWChar", ADODB.DataTypeEnum.adVarWChar)
		AddToCombo(cboType, "adLongVarWChar", ADODB.DataTypeEnum.adLongVarWChar)
		AddToCombo(cboType, "adVarBinary", ADODB.DataTypeEnum.adVarBinary)
		AddToCombo(cboType, "adLongVarBinary", ADODB.DataTypeEnum.adLongVarBinary)
		
		' Fill the combobox with the list of names.
		Dim p As ADODB.Parameter = Nothing
		On Error Resume Next 
		For Each p In Parameters
			cboName.AddItem(p.Name)
		Next
		
	End Sub

	' Refresh the contents of the property Parameters.
	
	Public Sub ShowProperties()
		ShowProperty(param, cboAttributes)
		ShowProperty(param, cboDirection)
		ShowProperty(param, txtNumericScale)
		ShowProperty(param, txtPrecision)
		ShowProperty(param, txtSize)
		ShowProperty(param, cboType)
		ShowProperty(param, txtValue)
		
		ShowCustomProperties(param, lstCustomProperties)
	End Sub

	' Assign current values in Parameters to properties
	
	Public Sub AssignProperties()
		AssignProperty(param, cboAttributes)
		AssignProperty(param, cboDirection)
		AssignProperty(param, txtNumericScale)
		AssignProperty(param, txtPrecision)
		AssignProperty(param, txtSize)
		AssignProperty(param, cboType)
		AssignProperty(param, txtValue)
	End Sub

End Class

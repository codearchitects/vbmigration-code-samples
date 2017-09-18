' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmFields

	Public WithEvents rs As ADODB.Recordset
	Private Fields As ADODB.Fields
	Private fld As ADODB.Field
	
	Private Sub cboName_Click() Handles cboName.Click
		fld = Fields(cboName.Text)
		ShowProperties()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Fields = rs.Fields
		InitFields()
		' Set the current field (also fires ShowProperties)
		If cboName.ListCount Then  cboName.ListIndex = 0
	End Sub

	Private Sub lstCustomProperties_Click() Handles lstCustomProperties.Click
		txtCustomProperty.Text = GetCustomPropertyValue(fld, lstCustomProperties)
		cmdSet.Enabled = CustomPropertyIsWriteable(fld, lstCustomProperties)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		SetCustomPropertyValue(fld, lstCustomProperties, txtCustomProperty.Text)
	End Sub

	Private Sub cmdSetProperties_Click() Handles cmdSetProperties.Click
		AssignProperties()
		ShowProperties()
	End Sub

	' Initialize fields and combo boxes
	
	Private Sub InitFields()
		AddToCombo(cboAttributes, "adFldMayDefer", ADODB.FieldAttributeEnum.adFldMayDefer)
		AddToCombo(cboAttributes, "adFldUpdatable", ADODB.FieldAttributeEnum.adFldUpdatable)
		AddToCombo(cboAttributes, "adFldUnknownUpdatable", ADODB.FieldAttributeEnum.adFldUnknownUpdatable)
		AddToCombo(cboAttributes, "adFldFixed", ADODB.FieldAttributeEnum.adFldFixed)
		AddToCombo(cboAttributes, "adFldIsNullable", ADODB.FieldAttributeEnum.adFldIsNullable)
		AddToCombo(cboAttributes, "adFldMayBeNull", ADODB.FieldAttributeEnum.adFldMayBeNull)
		AddToCombo(cboAttributes, "adFldLong", ADODB.FieldAttributeEnum.adFldLong)
		AddToCombo(cboAttributes, "adFldRowID", ADODB.FieldAttributeEnum.adFldRowID)
		AddToCombo(cboAttributes, "adFldRowVersion", ADODB.FieldAttributeEnum.adFldRowVersion)
		AddToCombo(cboAttributes, "adFldCacheDeferred", ADODB.FieldAttributeEnum.adFldCacheDeferred)
		AddToCombo(cboAttributes, "adFldNegativeScale", ADODB.FieldAttributeEnum.adFldNegativeScale)
		AddToCombo(cboAttributes, "adFldKeyColumn", ADODB.FieldAttributeEnum.adFldKeyColumn)
		
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
		Dim f As ADODB.Field = Nothing
		On Error Resume Next 
		For Each f In Fields
			cboName.AddItem(f.Name)
		Next
		
	End Sub

	' Refresh the contents of the property fields.
	
	Public Sub ShowProperties()
		ShowProperty(fld, txtActualSize)
		ShowProperty(fld, cboAttributes)
		ShowProperty(fld, txtDefinedSize)
		ShowProperty(fld, txtNumericScale)
		ShowProperty(fld, txtOriginalValue)
		ShowProperty(fld, txtPrecision)
		ShowProperty(fld, cboType)
		ShowProperty(fld, txtUnderlyingValue)
		ShowProperty(fld, txtValue)
		
		ShowCustomProperties(fld, lstCustomProperties)
	End Sub

	' Assign current values in fields to properties
	
	Public Sub AssignProperties()
		AssignProperty(fld, txtActualSize)
		AssignProperty(fld, cboAttributes)
		AssignProperty(fld, txtDefinedSize)
		AssignProperty(fld, txtNumericScale)
		AssignProperty(fld, txtOriginalValue)
		AssignProperty(fld, txtPrecision)
		AssignProperty(fld, cboType)
		AssignProperty(fld, txtUnderlyingValue)
		AssignProperty(fld, txtValue)
	End Sub

	Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.MoveComplete
		ShowProperties()
	End Sub

	Private Sub rs_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.RecordChangeComplete
		ShowProperties()
	End Sub

End Class

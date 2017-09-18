VERSION 5.00
Begin VB.Form frmFields 
   Caption         =   "Fields"
   ClientHeight    =   4215
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8505
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4215
   ScaleWidth      =   8505
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtUnderlyingValue 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   24
      Top             =   3360
      Width           =   2535
   End
   Begin VB.TextBox txtValue 
      Height          =   360
      Left            =   2040
      TabIndex        =   23
      Top             =   3720
      Width           =   2535
   End
   Begin VB.TextBox txtNumericScale 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   22
      Top             =   1920
      Width           =   2535
   End
   Begin VB.ComboBox cboAttributes 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   21
      Top             =   1200
      Width           =   2535
   End
   Begin VB.CommandButton cmdSetProperties 
      Caption         =   "Set &Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   20
      Top             =   120
      Width           =   1815
   End
   Begin VB.ComboBox cboName 
      Height          =   360
      Left            =   2040
      Style           =   2  'Dropdown List
      TabIndex        =   19
      Top             =   120
      Width           =   2535
   End
   Begin VB.ComboBox cboType 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   18
      Top             =   3000
      Width           =   2535
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Height          =   375
      Left            =   7440
      TabIndex        =   17
      Top             =   1080
      Width           =   855
   End
   Begin VB.TextBox txtCustomProperty 
      Height          =   375
      Left            =   4800
      TabIndex        =   15
      Top             =   1080
      Width           =   2655
   End
   Begin VB.ListBox lstCustomProperties 
      Height          =   2460
      Left            =   4800
      Sorted          =   -1  'True
      TabIndex        =   14
      Top             =   1560
      Width           =   3495
   End
   Begin VB.TextBox txtPrecision 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   9
      Top             =   2640
      Width           =   2535
   End
   Begin VB.TextBox txtDefinedSize 
      Height          =   360
      Left            =   2040
      TabIndex        =   7
      Top             =   1560
      Width           =   2535
   End
   Begin VB.TextBox txtOriginalValue 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   2280
      Width           =   2535
   End
   Begin VB.TextBox txtActualSize 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   840
      Width           =   2535
   End
   Begin VB.Label lblCustomProperty 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Custom Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   16
      Top             =   720
      Width           =   3495
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Value"
      Height          =   375
      Index           =   9
      Left            =   120
      TabIndex        =   13
      Top             =   3720
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "UnderlyingValue"
      Height          =   375
      Index           =   8
      Left            =   120
      TabIndex        =   12
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Type"
      Height          =   375
      Index           =   7
      Left            =   120
      TabIndex        =   11
      Top             =   3000
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "NumericScale"
      Height          =   375
      Index           =   6
      Left            =   120
      TabIndex        =   10
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Precision"
      Height          =   375
      Index           =   5
      Left            =   120
      TabIndex        =   8
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "DefinedSize"
      Height          =   375
      Index           =   4
      Left            =   120
      TabIndex        =   6
      Top             =   1560
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Attributes"
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   5
      Top             =   1200
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "OriginalValue"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   3
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ActualSize"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   1
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Name"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1935
   End
End
Attribute VB_Name = "frmFields"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public WithEvents rs As ADODB.Recordset
Attribute rs.VB_VarHelpID = -1

Private Fields As ADODB.Fields
Attribute Fields.VB_VarHelpID = -1
Private fld As ADODB.Field

Private Sub cboName_Click()
    Set fld = Fields(cboName.Text)
    ShowProperties
End Sub

Private Sub Form_Load()
    Set Fields = rs.Fields
    InitFields
    ' Set the current field (also fires ShowProperties)
    If cboName.ListCount Then cboName.ListIndex = 0
End Sub

Private Sub lstCustomProperties_Click()
    txtCustomProperty.Text = GetCustomPropertyValue(fld, lstCustomProperties)
    cmdSet.Enabled = CustomPropertyIsWriteable(fld, lstCustomProperties)
End Sub

Private Sub cmdSet_Click()
    SetCustomPropertyValue fld, lstCustomProperties, txtCustomProperty.Text
End Sub

Private Sub cmdSetProperties_Click()
    AssignProperties
    ShowProperties
End Sub

' Initialize fields and combo boxes

Private Sub InitFields()
    AddToCombo cboAttributes, "adFldMayDefer", adFldMayDefer
    AddToCombo cboAttributes, "adFldUpdatable", adFldUpdatable
    AddToCombo cboAttributes, "adFldUnknownUpdatable", adFldUnknownUpdatable
    AddToCombo cboAttributes, "adFldFixed", adFldFixed
    AddToCombo cboAttributes, "adFldIsNullable", adFldIsNullable
    AddToCombo cboAttributes, "adFldMayBeNull", adFldMayBeNull
    AddToCombo cboAttributes, "adFldLong", adFldLong
    AddToCombo cboAttributes, "adFldRowID", adFldRowID
    AddToCombo cboAttributes, "adFldRowVersion", adFldRowVersion
    AddToCombo cboAttributes, "adFldCacheDeferred", adFldCacheDeferred
    AddToCombo cboAttributes, "adFldNegativeScale", adFldNegativeScale
    AddToCombo cboAttributes, "adFldKeyColumn", adFldKeyColumn
    
    AddToCombo cboType, "adEmpty", adEmpty
    AddToCombo cboType, "adSmallInt", adSmallInt
    AddToCombo cboType, "adInteger", adInteger
    AddToCombo cboType, "adSingle", adSingle
    AddToCombo cboType, "adDouble", adDouble
    AddToCombo cboType, "adCurrency", adCurrency
    AddToCombo cboType, "adDate", adDate
    AddToCombo cboType, "adBSTR", adBSTR
    AddToCombo cboType, "adIDispatch", adIDispatch
    AddToCombo cboType, "adError", adError
    AddToCombo cboType, "adBoolean", adBoolean
    AddToCombo cboType, "adVariant", adVariant
    AddToCombo cboType, "adIUnknown", adIUnknown
    AddToCombo cboType, "adDecimal", adDecimal
    AddToCombo cboType, "adTinyInt", adTinyInt
    AddToCombo cboType, "adUnsignedTinyInt", adUnsignedTinyInt
    AddToCombo cboType, "adUnsignedSmallInt", adUnsignedSmallInt
    AddToCombo cboType, "adUnsignedInt", adUnsignedInt
    AddToCombo cboType, "adBigInt", adBigInt
    AddToCombo cboType, "adUnsignedBigInt", adUnsignedBigInt
    AddToCombo cboType, "adGUID", adGUID
    AddToCombo cboType, "adBinary", adBinary
    AddToCombo cboType, "adChar", adChar
    AddToCombo cboType, "adWChar", adWChar
    AddToCombo cboType, "adNumeric", adNumeric
    AddToCombo cboType, "adUserDefined", adUserDefined
    AddToCombo cboType, "adDBDate", adDBDate
    AddToCombo cboType, "adDBTime", adDBTime
    AddToCombo cboType, "adDBTimeStamp", adDBTimeStamp
    AddToCombo cboType, "adChapter", adChapter
    AddToCombo cboType, "adVarNumeric", adVarNumeric
    AddToCombo cboType, "adVarChar", adVarChar
    AddToCombo cboType, "adLongVarChar", adLongVarChar
    AddToCombo cboType, "adVarWChar", adVarWChar
    AddToCombo cboType, "adLongVarWChar", adLongVarWChar
    AddToCombo cboType, "adVarBinary", adVarBinary
    AddToCombo cboType, "adLongVarBinary", adLongVarBinary

    ' Fill the combobox with the list of names.
    Dim f As ADODB.Field
    On Error Resume Next
    For Each f In Fields
        cboName.AddItem f.Name
    Next

End Sub

' Refresh the contents of the property fields.

Sub ShowProperties()
    ShowProperty fld, txtActualSize
    ShowProperty fld, cboAttributes
    ShowProperty fld, txtDefinedSize
    ShowProperty fld, txtNumericScale
    ShowProperty fld, txtOriginalValue
    ShowProperty fld, txtPrecision
    ShowProperty fld, cboType
    ShowProperty fld, txtUnderlyingValue
    ShowProperty fld, txtValue
    
    ShowCustomProperties fld, lstCustomProperties
End Sub

' Assign current values in fields to properties

Sub AssignProperties()
    AssignProperty fld, txtActualSize
    AssignProperty fld, cboAttributes
    AssignProperty fld, txtDefinedSize
    AssignProperty fld, txtNumericScale
    AssignProperty fld, txtOriginalValue
    AssignProperty fld, txtPrecision
    AssignProperty fld, cboType
    AssignProperty fld, txtUnderlyingValue
    AssignProperty fld, txtValue
End Sub

Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowProperties
End Sub

Private Sub rs_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowProperties
End Sub


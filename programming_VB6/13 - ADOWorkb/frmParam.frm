VERSION 5.00
Begin VB.Form frmParameters 
   Caption         =   "Parameters"
   ClientHeight    =   3510
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
   ScaleHeight     =   3510
   ScaleWidth      =   8505
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtSize 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   19
      Top             =   2280
      Width           =   2535
   End
   Begin VB.ComboBox cboDirection 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   17
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtValue 
      Height          =   360
      Left            =   2040
      TabIndex        =   16
      Top             =   3000
      Width           =   2535
   End
   Begin VB.TextBox txtNumericScale 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   15
      Top             =   1560
      Width           =   2535
   End
   Begin VB.ComboBox cboAttributes 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   14
      Top             =   840
      Width           =   2535
   End
   Begin VB.CommandButton cmdSetProperties 
      Caption         =   "Set &Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   13
      Top             =   120
      Width           =   1815
   End
   Begin VB.ComboBox cboName 
      Height          =   360
      Left            =   2040
      Style           =   2  'Dropdown List
      TabIndex        =   12
      Top             =   120
      Width           =   2535
   End
   Begin VB.ComboBox cboType 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   11
      Top             =   2640
      Width           =   2535
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Height          =   375
      Left            =   7440
      TabIndex        =   10
      Top             =   1080
      Width           =   855
   End
   Begin VB.TextBox txtCustomProperty 
      Height          =   375
      Left            =   4800
      TabIndex        =   8
      Top             =   1080
      Width           =   2655
   End
   Begin VB.ListBox lstCustomProperties 
      Height          =   1740
      Left            =   4800
      Sorted          =   -1  'True
      TabIndex        =   7
      Top             =   1560
      Width           =   3495
   End
   Begin VB.TextBox txtPrecision 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   1920
      Width           =   2535
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Size"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   20
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Direction"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   18
      Top             =   1200
      Width           =   1935
   End
   Begin VB.Label lblCustomProperty 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Custom Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   9
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
      TabIndex        =   6
      Top             =   3000
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Type"
      Height          =   375
      Index           =   7
      Left            =   120
      TabIndex        =   5
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "NumericScale"
      Height          =   375
      Index           =   6
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Precision"
      Height          =   375
      Index           =   5
      Left            =   120
      TabIndex        =   2
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Attributes"
      Height          =   375
      Index           =   3
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
Attribute VB_Name = "frmParameters"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public Parameters As ADODB.Parameters
Attribute Parameters.VB_VarHelpID = -1
Private param As ADODB.Parameter

Private Sub cboName_Click()
    Set param = Parameters(cboName.Text)
    ShowProperties
End Sub

Private Sub Form_Load()
    InitFields
    ' Set the current parameter (also fires ShowProperties)
    If cboName.ListCount Then cboName.ListIndex = 0
End Sub

Private Sub lstCustomProperties_Click()
    txtCustomProperty.Text = GetCustomPropertyValue(param, lstCustomProperties)
    cmdSet.Enabled = CustomPropertyIsWriteable(param, lstCustomProperties)
End Sub

Private Sub cmdSet_Click()
    SetCustomPropertyValue param, lstCustomProperties, txtCustomProperty.Text
End Sub

Private Sub cmdSetProperties_Click()
    AssignProperties
    ShowProperties
End Sub

' Initialize Parameters and combo boxes

Private Sub InitFields()
    AddToCombo cboAttributes, "adParamSigned", adParamSigned
    AddToCombo cboAttributes, "adParamNullable", adParamNullable
    AddToCombo cboAttributes, "adParamLong", adParamLong
    
    AddToCombo cboDirection, "adParamUnknown", adParamUnknown
    AddToCombo cboDirection, "adParamInput", adParamInput
    AddToCombo cboDirection, "adParamOutput", adParamOutput
    AddToCombo cboDirection, "adParamInputOutput", adParamInputOutput
    AddToCombo cboDirection, "adParamReturnValue", adParamReturnValue
    
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
    Dim p As ADODB.Parameter
    On Error Resume Next
    For Each p In Parameters
        cboName.AddItem p.Name
    Next

End Sub

' Refresh the contents of the property Parameters.

Sub ShowProperties()
    ShowProperty param, cboAttributes
    ShowProperty param, cboDirection
    ShowProperty param, txtNumericScale
    ShowProperty param, txtPrecision
    ShowProperty param, txtSize
    ShowProperty param, cboType
    ShowProperty param, txtValue
    
    ShowCustomProperties param, lstCustomProperties
End Sub

' Assign current values in Parameters to properties

Sub AssignProperties()
    AssignProperty param, cboAttributes
    AssignProperty param, cboDirection
    AssignProperty param, txtNumericScale
    AssignProperty param, txtPrecision
    AssignProperty param, txtSize
    AssignProperty param, cboType
    AssignProperty param, txtValue
End Sub


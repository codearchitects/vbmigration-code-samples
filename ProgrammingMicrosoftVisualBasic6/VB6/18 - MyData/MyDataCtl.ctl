VERSION 5.00
Begin VB.UserControl MyDataControl 
   ClientHeight    =   510
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3390
   DataSourceBehavior=   1  'vbDataSource
   ScaleHeight     =   510
   ScaleWidth      =   3390
   Begin VB.CommandButton cmdMove 
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   2400
      TabIndex        =   5
      Top             =   0
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   2880
      TabIndex        =   4
      Top             =   0
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">|"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   1560
      TabIndex        =   3
      Top             =   0
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   1080
      TabIndex        =   2
      Top             =   0
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   480
      TabIndex        =   1
      Top             =   0
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "|<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   495
   End
End
Attribute VB_Name = "MyDataControl"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Enum mdcBOFActionEnum
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

'Default Property Values:
Const m_def_RecordSource = ""
Const m_def_Provider = ""
Const m_def_BOFAction = mdcBOFActionMoveFirst
Const m_def_EOFAction = mdcEOFActionMoveLast
Const m_def_UserName = ""
Const m_def_Password = ""
Const m_def_ConnectionString = ""

'Property Variables:
Private m_RecordSource As String
Private m_Provider As Variant
Private m_BOFAction As mdcBOFActionEnum
Private m_EOFAction As mdcEOFActionEnum
Private m_UserName As String
Private m_Password As String
Private m_ConnectionString As String
Private m_CommandType As ADODB.CommandTypeEnum
Private m_CursorType As ADODB.CursorTypeEnum
Private m_LockType As ADODB.LockTypeEnum
Private m_CursorLocation As ADODB.CursorLocationEnum

Private Sub cmdMove_Click(Index As Integer)
    If rs Is Nothing Then Exit Sub
    Select Case Index
        Case 0
            rs.MoveFirst
        Case 1
            If rs.BOF Then
                Select Case m_BOFAction
                    Case mdcBOFActionEnum.mdcBOFActionMoveFirst
                        rs.MoveFirst
                    Case mdcBOFActionEnum.mdcBOFActionBOF
                        ' Do nothing.
                End Select
            Else
                rs.MovePrevious
            End If
        Case 2
            If rs.EOF = False Then rs.MoveNext
            If rs.EOF = True Then
                Select Case m_EOFAction
                    Case mdcEOFActionEnum.mdcEOFActionAddNew
                        rs.AddNew
                    Case mdcEOFActionEnum.mdcEOFActionMoveLast
                        rs.MoveLast
                    Case mdcEOFActionEnum.mdcEOFActionEOF
                        ' do nothing
                End Select
            End If
        Case 3
            rs.MoveLast
        Case 4
            rs.AddNew
        Case 5
            rs.Delete
    End Select
End Sub

' Raise an error in the most appropriate way.

Private Sub RaiseError(ercode As Long, Description As String)
    If Ambient.UserMode = True Then
        Err.Raise ercode, Ambient.DisplayName, Description
    Else
        MsgBox Description, vbExclamation, Ambient.DisplayName
    End If
End Sub

' Close the recordset and the connection in the correct way.

Private Sub CloseRecordset()
    If Not rs Is Nothing Then
        If rs.State <> adStateClosed Then rs.Close
        Set rs = Nothing
    End If
End Sub

Private Sub CloseConnection()
    CloseRecordset
    If Not cn Is Nothing Then
        If cn.State <> adStateClosed Then cn.Close
        Set cn = Nothing
    End If
End Sub

Private Sub UserControl_GetDataMember(DataMember As String, Data As Object)
   
    On Error GoTo Error_Handler
    
    ' Recreate the connection if necessary.
    If cn Is Nothing Or CnIsInvalid Then
        ' Close the recordset and the connection, if open.
        CloseConnection
        
        ' Validate the ConnectionString property.
        If Trim$(m_ConnectionString) = "" Then
            Err.Raise 1001, Ambient.DisplayName, "ConnectionString can't be a null string"
        Else
            ' Open the connection
            Set cn = New ADODB.Connection
            If m_Provider <> "" Then cn.Provider = m_Provider
            
            ' Three cases
            If Trim$(m_UserName) = "" Then
                cn.Open m_ConnectionString
            ElseIf Trim$(m_Password) = "" Then
                cn.Open m_ConnectionString, m_UserName
            Else
                cn.Open m_ConnectionString, m_UserName, m_Password
            End If
            CnIsInvalid = False
        End If
    End If
    
    ' Recreate the Recordset, if necessary
    If rs Is Nothing Or RsIsInvalid Then
        Set rs = New ADODB.Recordset
        rs.CursorLocation = m_CursorLocation
        rs.Open m_RecordSource, cn, m_CursorType, m_LockType, m_CommandType
        rs.MoveFirst
        RsIsInvalid = False
        '## NOTE under .NET we must force re-binding
        '## InsertStatement  VB6DataSourceWrapper.Create(rs, Me)
    End If
     
    ' Return the recordset to the data consumer.
    Set Data = rs
    Exit Sub
     
Error_Handler:
    RaiseError Err.Number, Err.Description
    CloseConnection
End Sub

Public Property Get Recordset() As ADODB.Recordset
    Set Recordset = rs
End Property

Public Property Get RecordSource() As String
    RecordSource = m_RecordSource
End Property

Public Property Let RecordSource(ByVal New_RecordSource As String)
    m_RecordSource = New_RecordSource
    PropertyChanged "RecordSource"
    m_CommandType = adCmdUnknown
    RsIsInvalid = True
End Property

Public Property Get Provider() As Variant
    Provider = m_Provider
End Property

Public Property Let Provider(ByVal New_Provider As Variant)
    m_Provider = New_Provider
    PropertyChanged "Provider"
    CnIsInvalid = True
End Property

Public Property Get BOFAction() As mdcBOFActionEnum
    BOFAction = m_BOFAction
End Property

Public Property Let BOFAction(ByVal New_BOFAction As mdcBOFActionEnum)
    m_BOFAction = New_BOFAction
    PropertyChanged "BOFAction"
End Property

Public Property Get EOFAction() As mdcEOFActionEnum
    EOFAction = m_EOFAction
End Property

Public Property Let EOFAction(ByVal New_EOFAction As mdcEOFActionEnum)
    Select Case New_EOFAction
        Case mdcEOFActionMoveLast, mdcEOFActionEOF, mdcEOFActionAddNew
            m_EOFAction = New_EOFAction
            PropertyChanged "EOFAction"
        Case Else
            Err.Raise 5
    End Select
End Property

Public Property Get UserName() As String
    UserName = m_UserName
End Property

Public Property Let UserName(ByVal New_UserName As String)
    m_UserName = New_UserName
    PropertyChanged "UserName"
    CnIsInvalid = True
End Property

Public Property Get Password() As String
    Password = m_Password
End Property

Public Property Let Password(ByVal New_Password As String)
    m_Password = New_Password
    PropertyChanged "Password"
    CnIsInvalid = True
End Property

Public Property Get ConnectionString() As String
    ConnectionString = m_ConnectionString
End Property

Public Property Let ConnectionString(ByVal New_ConnectionString As String)
    m_ConnectionString = New_ConnectionString
    PropertyChanged "ConnectionString"
    CnIsInvalid = True
End Property

Public Property Get CommandType() As ADODB.CommandTypeEnum
    CommandType = m_CommandType
End Property

Public Property Let CommandType(ByVal New_CommandType As ADODB.CommandTypeEnum)
    m_CommandType = New_CommandType
    PropertyChanged "CommandType"
    RsIsInvalid = True
End Property

Public Property Get CursorType() As ADODB.CursorTypeEnum
    CursorType = m_CursorType
End Property

Public Property Let CursorType(ByVal New_CursorType As ADODB.CursorTypeEnum)
    m_CursorType = New_CursorType
    PropertyChanged "CursorType"
    RsIsInvalid = True
End Property

Public Property Get LockType() As ADODB.LockTypeEnum
    LockType = m_LockType
End Property

Public Property Let LockType(ByVal New_LockType As ADODB.LockTypeEnum)
    m_LockType = New_LockType
    PropertyChanged "LockType"
    RsIsInvalid = True
End Property

Public Property Get CursorLocation() As ADODB.CursorLocationEnum
    CursorLocation = m_CursorLocation
End Property

Public Property Let CursorLocation(ByVal New_CursorLocation As ADODB.CursorLocationEnum)
    m_CursorLocation = New_CursorLocation
    PropertyChanged "CursorLocation"
    RsIsInvalid = True
End Property

Public Sub Refresh()
    CloseRecordset
    DataMemberChanged ""
End Sub

Private Sub UserControl_InitProperties()
   m_RecordSource = m_def_RecordSource
   m_Provider = m_def_Provider
   m_BOFAction = m_def_BOFAction
   m_EOFAction = m_def_EOFAction
   m_UserName = m_def_UserName
   m_Password = m_def_Password
   m_ConnectionString = m_def_ConnectionString
   m_CommandType = adCmdUnknown
   m_CursorType = adOpenStatic
   m_LockType = adLockOptimistic
   m_CursorLocation = adUseClient
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    m_RecordSource = PropBag.ReadProperty("RecordSource", m_def_RecordSource)
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

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
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

Private Sub UserControl_Terminate()
    On Error Resume Next
    CloseConnection
    Err.Clear
End Sub




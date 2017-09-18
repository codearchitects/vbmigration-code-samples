VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 1  'vbSimpleBound
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CEmployee"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private m_FirstName As String
Private m_LastName As String
Private m_BirthDate As Date

'## PostProcess "Shadows Property DataSource", "Shadows Property DataSource_"

' Variables for data consumer support
Private bndcol As New BindingCollection


' The FirstName property

Public Property Get FirstName() As String
Attribute FirstName.VB_MemberFlags = "3c"
    FirstName = m_FirstName
End Property

Public Property Let FirstName(ByVal newValue As String)
    If CanPropertyChange("FirstName") Then
        m_FirstName = newValue
        PropertyChanged "FirstName"
    End If
End Property


' The LastName property

Public Property Get LastName() As String
Attribute LastName.VB_MemberFlags = "c"
    LastName = m_LastName
End Property

Public Property Let LastName(ByVal newValue As String)
    If CanPropertyChange("LastName") Then
        m_LastName = newValue
        PropertyChanged "LastName"
    End If
End Property


' The BirthDate property

Public Property Get BirthDate() As Date
    BirthDate = m_BirthDate
End Property

Public Property Let BirthDate(ByVal newValue As Date)
    If CanPropertyChange("BirthDate") Then
        m_BirthDate = newValue
        PropertyChanged "BirthDate"
    End If
End Property

' The CompleteName property (read only)

Property Get CompleteName() As String
    CompleteName = FirstName & " " & LastName
End Property

' The Age property (read only)

Property Get Age() As Integer
    Age = Year(Now) - Year(BirthDate)
End Property

' The DataSource property

Property Get DataSource() As Object
Attribute DataSource.VB_Description = "The DataSource property"
    Set DataSource = bndcol.DataSource
End Property

Property Set DataSource(ByVal newValue As Object)
    Set bndcol = New BindingCollection
    Set bndcol.DataSource = newValue
    bndcol.UpdateMode = vbUsePropertyAttributes
    
    bndcol.Add Me, "FirstName", "FirstName", , "FirstName"
    bndcol.Add Me, "LastName", "LastName", , "LastName"
    bndcol.Add Me, "BirthDate", "BirthDate", , "LastName"
End Property


Private Sub Class_Initialize()

End Sub

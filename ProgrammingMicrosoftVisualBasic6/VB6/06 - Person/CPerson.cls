VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPerson"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

enum SexConstants
    Male = 1
    Female
End Enum

enum MaritalStatusConstants
    NotMarried = 1
    Married
    Divorced
    Widower
    MARITALSTATUS_MAX = Widower
End Enum

' private members
Private m_FirstName As String
Private m_LastName As String
Private m_BirthDate As Date
Private m_Citizenship As String
Private m_ID As Variant
Private m_ReverseName As Variant
'##m_Notes.ArrayBounds ForceVB6Array
Private m_Notes(1 To 10) As String
Private m_Sex As SexConstants
Private m_MaritalStatus As MaritalStatusConstants

' object properties
Private m_HomeAddress As CAddress
Private m_WorkAddress As CAddress
Private m_VacationAddress As CAddress
' object/regular property
Private m_CurrentAddress As Variant

Private Sub Class_Initialize()
    m_Citizenship = "American"
End Sub

' a constructor method

Friend Sub Init(FirstName As String, LastName As String, Optional ID As Variant, Optional BirthDate As Variant)
    Me.FirstName = FirstName
    Me.LastName = LastName
    If Not IsMissing(ID) Then Me.ID = ID
    If Not IsMissing(BirthDate) Then Me.BirthDate = BirthDate
End Sub

' the first name

Property Get FirstName() As String
    ' simply return the current value of the member variable
    FirstName = m_FirstName
End Property

Property Let FirstName(ByVal newValue As String)
    ' raise an error if an invalid assignment is attempted
    If newValue = "" Then Err.Raise 5    ' invalid procedure argument
    ' else store in the private member variable
    m_FirstName = newValue
    m_ReverseName = Empty
End Property

' the last name

Property Get LastName() As String
    ' simply return the current value of the member variable
    LastName = m_LastName
End Property

Property Let LastName(ByVal newValue As String)
    ' raise an error if an invalid assignment is attempted
    If newValue = "" Then Err.Raise 5    ' invalid procedure argument
    ' else store in the private member variable
    m_LastName = newValue
    m_ReverseName = Empty
End Property

' the birth date

Property Get BirthDate() As Date
    BirthDate = m_BirthDate
End Property

Property Let BirthDate(ByVal newValue As Date)
    If newValue >= Now Then Err.Raise 1001, , "Can't be a future Birth Date"
    m_BirthDate = newValue
End Property

' the complete name

Property Get CompleteName() As String
    CompleteName = FirstName & " " & LastName
End Property

Property Let CompleteName(ByVal newValue As String)
    Dim items() As String
    items() = Split(newValue)
    ' we expect exactly two items (no support for middle names)
    If UBound(items) <> 1 Then Err.Raise 5
    ' assign to main properties
    FirstName = items(0)
    LastName = items(1)
End Property

' reversed name

Function ReverseName() As String
    If IsEmpty(m_ReverseName) Then
        m_ReverseName = LastName & ", " & FirstName
    End If
    ReverseName = m_ReverseName
End Function

' the current age (this year)

Property Get Age() As Integer
Attribute Age.VB_MemberFlags = "40"
    Age = Year(Now) - Year(BirthDate)
End Property

' Citizenship as a string

Property Get Citizenship() As String
    Citizenship = m_Citizenship
End Property

Property Let Citizenship(ByVal newValue As String)
    m_Citizenship = newValue
End Property

' ID property (write-once, read-many)

Property Get ID() As Long
    ID = m_ID
End Property

Property Let ID(ByVal newValue As Long)
    If Not IsEmpty(m_ID) Then Err.Raise 1002, , "Write-once property"
    m_ID = newValue
End Property

' The Notes property (array)

Property Get Notes(Optional index As Integer = 1) As String
    Notes = m_Notes(index)
End Property

Property Let Notes(Optional index As Integer = 1, ByVal newValue As String)
    ' check for subscript out of range error
    If index < LBound(m_Notes) Or index > UBound(m_Notes) Then Err.Raise 9
    m_Notes(index) = newValue
End Property

' The Sex property

Property Get Sex() As SexConstants
    Sex = m_Sex
End Property

Property Let Sex(ByVal newValue As SexConstants)
    ' refuse invalid assignments
    If newValue <> Male And newValue <> Female Then Err.Raise 5
    m_Sex = newValue
End Property

' The MaritalStatus property

Property Get MaritalStatus() As MaritalStatusConstants
    MaritalStatus = m_MaritalStatus
End Property

Property Let MaritalStatus(ByVal newValue As MaritalStatusConstants)
    ' refuse invalid assignments (assumes that zero is always invalid)
    If newValue < 0 Or newValue > MARITALSTATUS_MAX Then Err.Raise 5
    m_MaritalStatus = newValue
End Property

' the MaritalStatusDescr property

Property Get MaritalStatusDescr() As String
    Select Case m_MaritalStatus
        Case NotMarried: MaritalStatusDescr = "NotMarried"
        Case Married: MaritalStatusDescr = "Married"
        Case Divorced: MaritalStatusDescr = "Divorced"
        Case Widower
            If Sex = Male Then
                MaritalStatusDescr = "Widower"
            ElseIf Sex = Female Then
                MaritalStatusDescr = "Widow"
            End If
        Case Else
            Err.Raise 5       ' defensive programming
    End Select
End Property

Property Let MaritalStatusDescr(ByVal newValue As String)
    Select Case LCase$(newValue)
        Case "notmarried": MaritalStatus = NotMarried
        Case "married": MaritalStatus = Married
        Case "divorced": MaritalStatus = Divorced
        Case "widower", "widow": MaritalStatus = Widower
        Case Else
            Err.Raise 5       ' error otherwise
    End Select
End Property

' The WorkAddress property

Property Get WorkAddress() As CAddress
    Set WorkAddress = m_WorkAddress
End Property

Property Set WorkAddress(ByVal newValue As CAddress)
    Set m_WorkAddress = newValue
End Property

' The HomeAddress property

Property Get HomeAddress() As CAddress
    Set HomeAddress = m_HomeAddress
End Property

Property Set HomeAddress(ByVal newValue As CAddress)
    Set m_HomeAddress = newValue
End Property

' The VacationAddress property

Property Get VacationAddress() As CAddress
    Set VacationAddress = m_VacationAddress
End Property

Property Set VacationAddress(ByVal newValue As CAddress)
    Set m_VacationAddress = newValue
End Property

' the CurrentAddress property
' (example of a Variant property that can also hold an object)

Property Get CurrentAddress() As Variant
    If IsObject(m_CurrentAddress) Then
        Set CurrentAddress = m_CurrentAddress
    Else
        CurrentAddress = m_CurrentAddress
    End If
End Property

Property Let CurrentAddress(ByVal newValue As Variant)
    If VarType(newValue) <> vbString Then Err.Raise 5
    m_CurrentAddress = newValue
End Property

Property Set CurrentAddress(ByVal newValue As CAddress)
    ' the next line is useless because the object type is
    ' tested automatically by VB compiler
    ' If TypeName(newValue) <> "CAddress" Then Err.Raise 5
    Set m_CurrentAddress = newValue
End Property








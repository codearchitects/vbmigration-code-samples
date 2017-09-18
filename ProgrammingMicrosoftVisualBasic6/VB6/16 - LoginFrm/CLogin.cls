VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

'##project:UseByval Yes
'##DisableMessage 0354

Event WrongPassword(Password As String)


'Dim WithEvents frmLogin As frmLogin
'##Note Renamed for avoiding name conflicts
Dim WithEvents frmLogin As frmLoginWin
Attribute frmLogin.VB_VarHelpID = -1

Private Sub Class_Initialize()
    '##ReplaceStatement frmLogin = New frmLoginWin
    Set frmLogin = New frmLoginWin
End Sub

' The Name property

Public Property Get UserName() As String
    UserName = frmLogin.UserName
End Property

Public Property Let UserName(ByVal newValue As String)
    frmLogin.UserName = newValue
End Property

' The Password property

Public Property Get Password() As String
    Password = frmLogin.Password
End Property

Public Property Let Password(ByVal newValue As String)
    frmLogin.Password = newValue
End Property

' the Show method

Sub Show(Optional mode As Integer)
    frmLogin.Show mode
End Sub

Private Sub frmLogin_WrongPassword(Password As String)
    RaiseEvent WrongPassword(Password)
End Sub





















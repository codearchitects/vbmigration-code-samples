VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CThread"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' These declares are used to determine if it is the first thread.
Private Declare Function FindAtom Lib "kernel32" Alias "FindAtomA" (ByVal atomName As String) As Integer
Private Declare Function AddAtom Lib "kernel32" Alias "AddAtomA" (ByVal atomName As String) As Integer
Private Declare Function DeleteAtom Lib "kernel32" (ByVal atomName As Integer) As Integer

Private atomID As Integer

Private Sub Class_Initialize()
    Dim atomName As String
    ' Build an atom name unique for this application.
    atomName = App.EXEName & App.hInstance
    ' Create the atom if it doesn't exist already.
    If FindAtom(atomName) = 0 Then
        atomID = AddAtom(atomName)
    End If
End Sub

Private Sub Class_Terminate()
    ' Delete the atom when this thread terminates.
    If atomID Then DeleteAtom atomID
End Sub

Function IsFirstThread() As Boolean
    ' This is the first thread if it was the one which created the atom.
    IsFirstThread = (atomID <> 0)
End Function


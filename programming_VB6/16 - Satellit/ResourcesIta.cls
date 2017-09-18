VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Resources"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "MyApplication: Italian Resources"
' ------------------------------------------------------------------------
' Copyright © 1998 Francesco Balena.
' ------------------------------------------------------------------------

'-----------------------------------------------
'  ITALIAN class
'
' This class contains all the strings, pictures
' and binary data used by the program, and at the
' same time it defines the interface that all DLLs
' holding resources for this app should implement
'
' This interface might be expanded using methods
' that format date, time and currency values, ecc.
'-----------------------------------------------

Implements MyApplication000.Resources

Option Explicit

Private Sub Class_Initialize()
    '
End Sub

Function Resources_GetInfo(LanguageID As Long, Language As String)
    LanguageID = &H410
    Language = "Italiano"
End Function

Private Function Resources_LoadResString(ByVal ID As MyApplication000.ResStringID) As String
    Dim res As String
    Select Case ID
        Case rsDataError: res = "L'evento Error di Data ha riportato l'errore:"
        Case rsRecord: res = "Record: "
        Case rsPublishers: res = "Editori"
        Case rsClose: res = "&Chiudi"
        Case rsRefresh: res = "&Rileggi"
        Case rsDelete: res = "Ca&ncella"
        Case rsUpdate: res = "&Aggiorna"
        Case rsAdd: res = "A&ggiungi"
        Case rsComments: res = "Commenti:"
        Case rsFax: res = "Fax:"
        Case rsTelephone: res = "Telefono:"
        Case rsZip: res = "CAP:"
        Case rsState: res = "Stato:"
        Case rsCity: res = "Città:"
        Case rsAddress: res = "Indirizzo:"
        Case rsName: res = "Nome:"
        Case rsEnglish: res = "Inglese"
        Case rsItalian: res = "Italiano"
    End Select
    Resources_LoadResString = res
End Function

Private Function Resources_LoadResPicture(ByVal ID As MyApplication000.ResPictureID, Optional Format As Long) As IPictureDisp
    Select Case ID
        Case rpFlag: Set Resources_LoadResPicture = frmResources410.imgFlag.Picture
    End Select
End Function

Private Function Resources_LoadResData(ByVal ID As MyApplication000.ResDataID, Optional Format As Long) As Variant
    '
End Function



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
Attribute VB_Description = "MyApplication: English resources (default)"
' ------------------------------------------------------------------------
' Copyright © 1998 Francesco Balena.
' ------------------------------------------------------------------------

'-----------------------------------------------
'  RESOURCES class
'
' This class contains all the strings, pictures
' and binary data used by the program, and at the
' same time it defines the interface that all DLLs
' holding resources for this app should implement
'
' This interface might be expanded using methods
' that format date, time and currency values, ecc.
'-----------------------------------------------

Option Explicit

Enum ResStringID
    rsDataError = 1
    rsRecord
    rsPublishers
    rsClose
    rsRefresh
    rsDelete
    rsUpdate
    rsAdd
    rsComments
    rsFax
    rsTelephone
    rsZip
    rsState
    rsCity
    rsAddress
    rsName
    rsEnglish
    rsItalian
End Enum

Enum ResPictureID
    rpFlag = 1
End Enum

Enum ResDataID
    rdDummy = 0      ' necessary, as a placeholder
End Enum

Function GetInfo(LanguageID As Long, Language As String)
    LanguageID = 0  ' means default
    Language = "English"
End Function

Function LoadResString(ByVal ID As ResStringID) As String
    Select Case ID
        Case rsDataError: LoadResString = "Data error event hit err:"
        Case rsRecord: LoadResString = "Record: "
        Case rsPublishers: LoadResString = "Publishers"
        Case rsClose: LoadResString = "&Close"
        Case rsRefresh: LoadResString = "&Refresh"
        Case rsDelete: LoadResString = "&Delete"
        Case rsUpdate: LoadResString = "&Update"
        Case rsAdd: LoadResString = "&Add"
        Case rsComments: LoadResString = "Remarks:"
        Case rsFax: LoadResString = "Fax:"
        Case rsTelephone: LoadResString = "Phone:"
        Case rsZip: LoadResString = "Zip:"
        Case rsState: LoadResString = "Country:"
        Case rsCity: LoadResString = "City:"
        Case rsAddress: LoadResString = "Address:"
        Case rsName: LoadResString = "Name:"
        Case rsEnglish: LoadResString = "English"
        Case rsItalian: LoadResString = "Italian"
    End Select
End Function

Function LoadResPicture(ByVal ID As ResPictureID, Optional Format As Long) As IPictureDisp
    Select Case ID
        Case rpFlag: Set LoadResPicture = frmResources000.imgFlag.Picture
    End Select
End Function

Function LoadResData(ByVal ID As ResDataID, Optional Format As Long) As Variant
    ' not used in this program
End Function




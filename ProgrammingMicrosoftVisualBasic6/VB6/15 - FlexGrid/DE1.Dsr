VERSION 5.00
Begin {C0E45035-5775-11D0-B388-00A0C9055D8E} DataEnvironment1 
   ClientHeight    =   8640
   ClientLeft      =   1080
   ClientTop       =   1500
   ClientWidth     =   8835
   _ExtentX        =   15584
   _ExtentY        =   15240
   FolderFlags     =   3
   TypeLibGuid     =   "{A5DC9AF5-9235-11D1-B067-00DD01144174}"
   TypeInfoGuid    =   "{A5DC9AF6-9235-11D1-B067-00DD01144174}"
   TypeInfoCookie  =   0
   Version         =   4
   NumConnections  =   1
   BeginProperty Connection1 
      ConnectionName  =   "Connection1"
      ConnDispId      =   1002
      SourceOfData    =   3
      ConnectionSource=   $"DE1.dsx":0000
      Expanded        =   -1  'True
      QuoteChar       =   96
      SeparatorChar   =   46
   EndProperty
   NumRecordsets   =   3
   BeginProperty Recordset1 
      CommandName     =   "Authors"
      CommDispId      =   1003
      RsDispId        =   1004
      CommandText     =   "Authors"
      ActiveConnectionName=   "Connection1"
      CommandType     =   2
      dbObjectType    =   1
      Expanded        =   -1  'True
      IsRSReturning   =   -1  'True
      NumFields       =   3
      BeginProperty Field1 
         Precision       =   10
         Size            =   4
         Scale           =   0
         Type            =   3
         Name            =   "Au_ID"
         Caption         =   "Au_ID"
      EndProperty
      BeginProperty Field2 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Author"
         Caption         =   "Author"
      EndProperty
      BeginProperty Field3 
         Precision       =   5
         Size            =   2
         Scale           =   0
         Type            =   2
         Name            =   "Year Born"
         Caption         =   "Year Born"
      EndProperty
      NumGroups       =   0
      ParamCount      =   0
      RelationCount   =   0
      AggregateCount  =   0
   EndProperty
   BeginProperty Recordset2 
      CommandName     =   "Title_Author"
      CommDispId      =   -1
      RsDispId        =   -1
      CommandText     =   "Title Author"
      ActiveConnectionName=   "Connection1"
      CommandType     =   2
      dbObjectType    =   1
      RelateToParent  =   -1  'True
      ParentCommandName=   "Authors"
      Expanded        =   -1  'True
      IsRSReturning   =   -1  'True
      NumFields       =   2
      BeginProperty Field1 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   202
         Name            =   "ISBN"
         Caption         =   "ISBN"
      EndProperty
      BeginProperty Field2 
         Precision       =   10
         Size            =   4
         Scale           =   0
         Type            =   3
         Name            =   "Au_ID"
         Caption         =   "Au_ID"
      EndProperty
      NumGroups       =   0
      ParamCount      =   0
      RelationCount   =   1
      BeginProperty Relation1 
         ParentField     =   "Au_ID"
         ChildField      =   "Au_ID"
         ParentType      =   0
         ChildType       =   0
      EndProperty
      AggregateCount  =   0
   EndProperty
   BeginProperty Recordset3 
      CommandName     =   "Titles"
      CommDispId      =   -1
      RsDispId        =   -1
      CommandText     =   "Titles"
      ActiveConnectionName=   "Connection1"
      CommandType     =   2
      dbObjectType    =   1
      RelateToParent  =   -1  'True
      ParentCommandName=   "Title_Author"
      IsRSReturning   =   -1  'True
      NumFields       =   8
      BeginProperty Field1 
         Precision       =   0
         Size            =   255
         Scale           =   0
         Type            =   202
         Name            =   "Title"
         Caption         =   "Title"
      EndProperty
      BeginProperty Field2 
         Precision       =   5
         Size            =   2
         Scale           =   0
         Type            =   2
         Name            =   "Year Published"
         Caption         =   "Year Published"
      EndProperty
      BeginProperty Field3 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   202
         Name            =   "ISBN"
         Caption         =   "ISBN"
      EndProperty
      BeginProperty Field4 
         Precision       =   10
         Size            =   4
         Scale           =   0
         Type            =   3
         Name            =   "PubID"
         Caption         =   "PubID"
      EndProperty
      BeginProperty Field5 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Description"
         Caption         =   "Description"
      EndProperty
      BeginProperty Field6 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Notes"
         Caption         =   "Notes"
      EndProperty
      BeginProperty Field7 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Subject"
         Caption         =   "Subject"
      EndProperty
      BeginProperty Field8 
         Precision       =   0
         Size            =   536870910
         Scale           =   0
         Type            =   203
         Name            =   "Comments"
         Caption         =   "Comments"
      EndProperty
      NumGroups       =   0
      ParamCount      =   0
      RelationCount   =   1
      BeginProperty Relation1 
         ParentField     =   "ISBN"
         ChildField      =   "ISBN"
         ParentType      =   0
         ChildType       =   0
      EndProperty
      AggregateCount  =   0
   EndProperty
End
Attribute VB_Name = "DataEnvironment1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' WARNING: Ensure that this constant points to a valid
' copy of the Biblio.mdb database.
'Const DB_PATH = "e:\VisStudio\Vb98\Biblio.mdb"
Const DB_PATH = "c:\program files\Microsoft Visual Studio\Vb98\Biblio.mdb"

Private Sub Connection1_WillConnect(ConnectionString As String, UserID As String, Password As String, Options As Long, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    Dim i As Integer, j As Integer
    ' Search and replace the Data Source argument.
    i = InStr(ConnectionString, "Data Source=")
    If i Then
        j = InStr(i, ConnectionString & ";", ";")
        ConnectionString = Left$(ConnectionString, i + 11) & DB_PATH & Mid$(ConnectionString, j)
    End If
    
End Sub


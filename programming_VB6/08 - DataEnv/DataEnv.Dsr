VERSION 5.00
Begin {C0E45035-5775-11D0-B388-00A0C9055D8E} DataEnvironment1 
   ClientHeight    =   8535
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   8880
   _ExtentX        =   15663
   _ExtentY        =   15055
   FolderFlags     =   1
   TypeLibGuid     =   "{7EC84B41-B25B-11D2-ACEC-0080C8F21830}"
   TypeInfoGuid    =   "{7EC84B42-B25B-11D2-ACEC-0080C8F21830}"
   TypeInfoCookie  =   0
   Version         =   4
   NumConnections  =   1
   BeginProperty Connection1 
      ConnectionName  =   "Connection1"
      ConnDispId      =   1002
      CommandTimeout  =   20
      ConnectionTimeout=   3
      SourceOfData    =   3
      ConnectionSource=   "Provider=SQLOLEDB.1;Password=sa;Persist Security Info=True;User ID=sa;Data Source=localhost\SQLEXPRESS"
      Expanded        =   -1  'True
      RunPromptBehavior=   4
      IsSQL           =   -1  'True
      QuoteChar       =   34
      SeparatorChar   =   46
   EndProperty
   NumRecordsets   =   2
   BeginProperty Recordset1 
      CommandName     =   "authors"
      CommDispId      =   1003
      RsDispId        =   1004
      CommandText     =   "dbo.authors"
      ActiveConnectionName=   "Connection1"
      CommandType     =   2
      dbObjectType    =   1
      Expanded        =   -1  'True
      IsRSReturning   =   -1  'True
      NumFields       =   9
      BeginProperty Field1 
         Precision       =   0
         Size            =   11
         Scale           =   0
         Type            =   200
         Name            =   "au_id"
         Caption         =   "au_id"
      EndProperty
      BeginProperty Field2 
         Precision       =   0
         Size            =   40
         Scale           =   0
         Type            =   200
         Name            =   "au_lname"
         Caption         =   "au_lname"
      EndProperty
      BeginProperty Field3 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   200
         Name            =   "au_fname"
         Caption         =   "au_fname"
      EndProperty
      BeginProperty Field4 
         Precision       =   0
         Size            =   12
         Scale           =   0
         Type            =   129
         Name            =   "phone"
         Caption         =   "phone"
      EndProperty
      BeginProperty Field5 
         Precision       =   0
         Size            =   40
         Scale           =   0
         Type            =   200
         Name            =   "address"
         Caption         =   "address"
      EndProperty
      BeginProperty Field6 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   200
         Name            =   "city"
         Caption         =   "city"
      EndProperty
      BeginProperty Field7 
         Precision       =   0
         Size            =   2
         Scale           =   0
         Type            =   129
         Name            =   "state"
         Caption         =   "state"
      EndProperty
      BeginProperty Field8 
         Precision       =   0
         Size            =   5
         Scale           =   0
         Type            =   129
         Name            =   "zip"
         Caption         =   "zip"
      EndProperty
      BeginProperty Field9 
         Precision       =   0
         Size            =   2
         Scale           =   0
         Type            =   11
         Name            =   "contract"
         Caption         =   "contract"
      EndProperty
      NumGroups       =   0
      ParamCount      =   0
      RelationCount   =   0
      AggregateCount  =   0
   EndProperty
   BeginProperty Recordset2 
      CommandName     =   "AuthorsByState"
      CommDispId      =   1005
      RsDispId        =   1008
      CommandText     =   "SELECT * FROM Authors WHERE State = ? "
      ActiveConnectionName=   "Connection1"
      CommandType     =   1
      Expanded        =   -1  'True
      IsRSReturning   =   -1  'True
      NumFields       =   9
      BeginProperty Field1 
         Precision       =   0
         Size            =   11
         Scale           =   0
         Type            =   200
         Name            =   "au_id"
         Caption         =   "au_id"
      EndProperty
      BeginProperty Field2 
         Precision       =   0
         Size            =   40
         Scale           =   0
         Type            =   200
         Name            =   "au_lname"
         Caption         =   "au_lname"
      EndProperty
      BeginProperty Field3 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   200
         Name            =   "au_fname"
         Caption         =   "au_fname"
      EndProperty
      BeginProperty Field4 
         Precision       =   0
         Size            =   12
         Scale           =   0
         Type            =   129
         Name            =   "phone"
         Caption         =   "phone"
      EndProperty
      BeginProperty Field5 
         Precision       =   0
         Size            =   40
         Scale           =   0
         Type            =   200
         Name            =   "address"
         Caption         =   "address"
      EndProperty
      BeginProperty Field6 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   200
         Name            =   "city"
         Caption         =   "city"
      EndProperty
      BeginProperty Field7 
         Precision       =   0
         Size            =   2
         Scale           =   0
         Type            =   129
         Name            =   "state"
         Caption         =   "state"
      EndProperty
      BeginProperty Field8 
         Precision       =   0
         Size            =   5
         Scale           =   0
         Type            =   129
         Name            =   "zip"
         Caption         =   "zip"
      EndProperty
      BeginProperty Field9 
         Precision       =   0
         Size            =   2
         Scale           =   0
         Type            =   11
         Name            =   "contract"
         Caption         =   "contract"
      EndProperty
      NumGroups       =   0
      ParamCount      =   1
      BeginProperty P1 
         RealName        =   "Param1"
         UserName        =   "State"
         Direction       =   1
         Precision       =   0
         Scale           =   0
         Size            =   2
         DataType        =   200
         HostType        =   8
         Required        =   -1  'True
      EndProperty
      RelationCount   =   0
      AggregateCount  =   0
   EndProperty
End
Attribute VB_Name = "DataEnvironment1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' This code proves that the Disconnect and the Terminate events
' are never executed for the DataEnvironment designer, if you use
' a DE object that is global or stored in a form-level variable.

Private Sub Connection1_Disconnect(adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    MsgBox "disconnect"
End Sub

Private Sub DataEnvironment_Terminate()
    MsgBox "Terminate"
End Sub

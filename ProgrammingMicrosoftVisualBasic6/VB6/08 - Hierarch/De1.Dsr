VERSION 5.00
Begin {C0E45035-5775-11D0-B388-00A0C9055D8E} DataEnvironment1 
   ClientHeight    =   6480
   ClientLeft      =   1080
   ClientTop       =   1500
   ClientWidth     =   5175
   _ExtentX        =   9128
   _ExtentY        =   11430
   FolderFlags     =   3
   TypeLibGuid     =   "{A5DC9AF5-9235-11D1-B067-00DD01144174}"
   TypeInfoGuid    =   "{A5DC9AF6-9235-11D1-B067-00DD01144174}"
   TypeInfoCookie  =   0
   Version         =   4
   NumConnections  =   1
   BeginProperty Connection1 
      ConnectionName  =   "Biblio"
      ConnDispId      =   1002
      SourceOfData    =   3
      ConnectionSource=   $"De1.dsx":0000
      Expanded        =   -1  'True
      QuoteChar       =   96
      SeparatorChar   =   46
   EndProperty
   NumRecordsets   =   6
   BeginProperty Recordset1 
      CommandName     =   "Authors"
      CommDispId      =   1009
      RsDispId        =   1010
      CommandText     =   "Authors"
      ActiveConnectionName=   "Biblio"
      CommandType     =   2
      dbObjectType    =   1
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
      ActiveConnectionName=   "Biblio"
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
      ActiveConnectionName=   "Biblio"
      CommandType     =   2
      dbObjectType    =   1
      RelateToParent  =   -1  'True
      ParentCommandName=   "Title_Author"
      Expanded        =   -1  'True
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
   BeginProperty Recordset4 
      CommandName     =   "Publishers"
      CommDispId      =   -1
      RsDispId        =   -1
      CommandText     =   "Publishers"
      ActiveConnectionName=   "Biblio"
      CommandType     =   2
      dbObjectType    =   1
      RelateToParent  =   -1  'True
      ParentCommandName=   "Titles"
      IsRSReturning   =   -1  'True
      NumFields       =   10
      BeginProperty Field1 
         Precision       =   10
         Size            =   4
         Scale           =   0
         Type            =   3
         Name            =   "PubID"
         Caption         =   "PubID"
      EndProperty
      BeginProperty Field2 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Name"
         Caption         =   "Name"
      EndProperty
      BeginProperty Field3 
         Precision       =   0
         Size            =   255
         Scale           =   0
         Type            =   202
         Name            =   "Company Name"
         Caption         =   "Company Name"
      EndProperty
      BeginProperty Field4 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Address"
         Caption         =   "Address"
      EndProperty
      BeginProperty Field5 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   202
         Name            =   "City"
         Caption         =   "City"
      EndProperty
      BeginProperty Field6 
         Precision       =   0
         Size            =   10
         Scale           =   0
         Type            =   202
         Name            =   "State"
         Caption         =   "State"
      EndProperty
      BeginProperty Field7 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Zip"
         Caption         =   "Zip"
      EndProperty
      BeginProperty Field8 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Telephone"
         Caption         =   "Telephone"
      EndProperty
      BeginProperty Field9 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Fax"
         Caption         =   "Fax"
      EndProperty
      BeginProperty Field10 
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
         ParentField     =   "PubID"
         ChildField      =   "PubID"
         ParentType      =   0
         ChildType       =   0
      EndProperty
      AggregateCount  =   0
   EndProperty
   BeginProperty Recordset5 
      CommandName     =   "Titles2"
      CommDispId      =   1024
      RsDispId        =   1035
      CommandText     =   "Titles"
      ActiveConnectionName=   "Biblio"
      CommandType     =   2
      dbObjectType    =   1
      Grouping        =   -1  'True
      GroupingName    =   "Titles2_Grouping"
      Expanded        =   -1  'True
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
      NumGroups       =   1
      BeginProperty Grouping1 
         Precision       =   5
         Size            =   2
         Scale           =   0
         Type            =   2
         Name            =   "Year Published"
         Caption         =   "Year Published"
      EndProperty
      ParamCount      =   0
      RelationCount   =   0
      AggregateCount  =   1
      BeginProperty Aggregate1 
         Name            =   "TitleCount"
         AggOn           =   "Titles2"
         AggField        =   "Title"
         AggType         =   2
         AggFunction     =   3
         Precision       =   8
         Size            =   4
         Scale           =   8
         Type            =   131
         Name            =   "TitleCount"
         Caption         =   "TitleCount"
         Control         =   "TextBox"
         ControlGuid     =   "{0CA5C786-7C71-11D0-B223-00A0C908FB55}"
      EndProperty
   EndProperty
   BeginProperty Recordset6 
      CommandName     =   "Publishers2"
      CommDispId      =   -1
      RsDispId        =   -1
      CommandText     =   "Publishers"
      ActiveConnectionName=   "Biblio"
      CommandType     =   2
      dbObjectType    =   1
      RelateToParent  =   -1  'True
      ParentCommandName=   "Titles2"
      IsRSReturning   =   -1  'True
      NumFields       =   10
      BeginProperty Field1 
         Precision       =   10
         Size            =   4
         Scale           =   0
         Type            =   3
         Name            =   "PubID"
         Caption         =   "PubID"
      EndProperty
      BeginProperty Field2 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Name"
         Caption         =   "Name"
      EndProperty
      BeginProperty Field3 
         Precision       =   0
         Size            =   255
         Scale           =   0
         Type            =   202
         Name            =   "Company Name"
         Caption         =   "Company Name"
      EndProperty
      BeginProperty Field4 
         Precision       =   0
         Size            =   50
         Scale           =   0
         Type            =   202
         Name            =   "Address"
         Caption         =   "Address"
      EndProperty
      BeginProperty Field5 
         Precision       =   0
         Size            =   20
         Scale           =   0
         Type            =   202
         Name            =   "City"
         Caption         =   "City"
      EndProperty
      BeginProperty Field6 
         Precision       =   0
         Size            =   10
         Scale           =   0
         Type            =   202
         Name            =   "State"
         Caption         =   "State"
      EndProperty
      BeginProperty Field7 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Zip"
         Caption         =   "Zip"
      EndProperty
      BeginProperty Field8 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Telephone"
         Caption         =   "Telephone"
      EndProperty
      BeginProperty Field9 
         Precision       =   0
         Size            =   15
         Scale           =   0
         Type            =   202
         Name            =   "Fax"
         Caption         =   "Fax"
      EndProperty
      BeginProperty Field10 
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
         ParentField     =   "PubID"
         ChildField      =   "PubID"
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

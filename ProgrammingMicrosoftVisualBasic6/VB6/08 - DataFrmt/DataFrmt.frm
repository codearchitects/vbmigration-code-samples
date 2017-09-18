VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "DataFormat and StdDataFormat objects"
   ClientHeight    =   3600
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6825
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   3600
   ScaleWidth      =   6825
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton optFreight 
      Caption         =   "Euros"
      Height          =   255
      Index           =   1
      Left            =   4920
      TabIndex        =   9
      Top             =   2640
      Width           =   1095
   End
   Begin VB.OptionButton optFreight 
      Caption         =   "Dollars"
      Height          =   255
      Index           =   0
      Left            =   4920
      TabIndex        =   8
      Top             =   2400
      Value           =   -1  'True
      Width           =   1095
   End
   Begin VB.TextBox txtFreight 
      DataField       =   "Freight"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   4
      Top             =   2400
      Width           =   2415
   End
   Begin VB.TextBox txtOrderID 
      DataField       =   "OrderID"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   3
      Top             =   240
      Width           =   2415
   End
   Begin VB.TextBox txtShippedDate 
      DataField       =   "ShippedDate"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   1680
      Width           =   2415
   End
   Begin VB.TextBox txtOrderDate 
      DataField       =   "OrderDate"
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "MMMM d, yyyy"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   3
      EndProperty
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   1
      Top             =   960
      Width           =   2415
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      Top             =   3225
      Width           =   6825
      _ExtentX        =   12039
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Orders"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Freight"
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   7
      Top             =   2400
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Shipped Date"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   6
      Top             =   1680
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Order Date"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   5
      Top             =   960
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "OrderID"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

' IMPORTANT: ensure that the DB_PATH constant is pointing to the
' NWind.mdb database on your system
Const DB_PATH As String = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=c:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"

' How many euros in one dollar ?
' In a real program this would be a variable, of course.
Const DOLLARS_TO_EURO = 1.1734

' A StdDataFormat object that raises events.
Dim WithEvents sdfFreight As StdDataFormat
Attribute sdfFreight.VB_VarHelpID = -1

Private Sub Form_Load()
    ' This is an example of a dynamic StdDataFormat object
    Dim sdfShipped As New StdDataFormat
    sdfShipped.Type = fmtCustom
    sdfShipped.Format = "mmm dd, yyyy"
    Set txtShippedDate.DataFormat = sdfShipped
    
    ' This is an example of a StdDataFormat object
    ' that relies on events - no need to set properties
    Set sdfFreight = New StdDataFormat
    Set txtFreight.DataFormat = sdfFreight
    
    ' You need to refresh the Data control
    ' to display the first record correctly.
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & DB_PATH
    '##ReplaceStatement Adodc1.Refresh()
    Adodc1.Recordset.Move 0
    
End Sub

Private Sub sdfFreight_Format(ByVal DataValue As StdFormat.StdDataValue)
    ' Show the value in red ink if >30 dollars
    If DataValue.value > 30 Then
        DataValue.TargetObject.ForeColor = FromOleColor6(vbRed)
    Else
        DataValue.TargetObject.ForeColor = FromOleColor6(vbBlack)
    End If
    
    ' Convert to Euros if necessary
    If optFreight(1) Then
        DataValue.value = Round(DataValue.value * DOLLARS_TO_EURO, 2)
    End If
End Sub

Private Sub sdfFreight_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
    ' Convert back to dollars if necessary
    If optFreight(1) Then
        DataValue.value = Round(DataValue.value / DOLLARS_TO_EURO, 2)
    End If
End Sub

Private Sub optFreight_Click(Index As Integer)
    If Index = 0 Then
        ' Convert from Euros to Dollars.
        txtFreight = Trim$(Round(CDbl(txtFreight) / DOLLARS_TO_EURO, 2))
    Else
        ' Convert from dollars to Euros.
        txtFreight = Trim$(Round(CDbl(txtFreight) * DOLLARS_TO_EURO, 2))
    End If
End Sub




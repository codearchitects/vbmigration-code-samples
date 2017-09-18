VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   4170
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8370
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
   ScaleHeight     =   4170
   ScaleWidth      =   8370
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtUnitsOnOrder 
      Alignment       =   1  'Right Justify
      DataField       =   "UnitsOnOrder"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   6360
      TabIndex        =   7
      Top             =   360
      Width           =   1455
   End
   Begin VB.TextBox txtUnitsInStock 
      Alignment       =   1  'Right Justify
      DataField       =   "UnitsInStock"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   4800
      TabIndex        =   5
      Top             =   360
      Width           =   1455
   End
   Begin VB.TextBox txtUnitPrice 
      Alignment       =   1  'Right Justify
      DataField       =   "UnitPrice"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Top             =   360
      Width           =   1455
   End
   Begin VB.TextBox txtProductName 
      DataField       =   "ProductName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   3015
   End
   Begin Project1.ProductGrid ProductGrid1 
      Height          =   2535
      Left            =   120
      TabIndex        =   0
      Top             =   960
      Width           =   7935
      _extentx        =   13996
      _extenty        =   4471
      font            =   "Form1.frx":0000
      fullrowselect   =   -1  'True
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      Top             =   3795
      Width           =   8370
      _ExtentX        =   14764
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
      EOFAction       =   1
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program files\Microsoft Visual Studio\VB98\Nwind.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program files\Microsoft Visual Studio\VB98\Nwind.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Products"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label Label4 
      Caption         =   "Units on &Order"
      Height          =   255
      Left            =   6360
      TabIndex        =   8
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label3 
      Caption         =   "Units In &Stock"
      Height          =   255
      Left            =   4800
      TabIndex        =   6
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label Label2 
      Caption         =   "&Unit Price"
      Height          =   255
      Left            =   3240
      TabIndex        =   4
      Top             =   120
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "&Product Name"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Modify this to match your directory structure
Const DBPATH = "c:\program files\microsoft visual studio\Vb98\nwind.mdb"

Private Sub Form_Load()
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH
    Adodc1.Refresh
    ' You need to explicitly refresh the DataSource property.
    Set ProductGrid1.DataSource = Adodc1
End Sub

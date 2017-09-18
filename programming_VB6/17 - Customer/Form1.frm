VERSION 5.00
Object = "*\ACustOCX.vbp"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   4080
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6810
   LinkTopic       =   "Form1"
   ScaleHeight     =   4080
   ScaleWidth      =   6810
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      DataField       =   "Fax"
      DataSource      =   "Adodc1"
      Height          =   285
      Left            =   4440
      TabIndex        =   1
      Text            =   "Text1"
      Top             =   3480
      Width           =   1455
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   240
      Top             =   3600
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   582
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\PROGRAM FILES\MICROSOFT VISUAL STUDIO\VB98\NWIND.MDB;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\PROGRAM FILES\MICROSOFT VISUAL STUDIO\VB98\NWIND.MDB;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Customers"
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
   Begin CustOCX.Customer Customer1 
      Bindings        =   "Form1.frx":0000
      DataField       =   "CompanyName"
      DataSource      =   "Adodc1"
      Height          =   3135
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   6255
      _extentx        =   11033
      _extenty        =   5530
      font            =   "Form1.frx":00AA
      customername    =   "Francesco Balena"
      city            =   "Bari"
      zipcode         =   "70124"
      country         =   "Italy"
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub Customer1_KeyPress(KeyAscii As Integer)
    If KeyAscii = 32 Then KeyAscii = 0
End Sub

Private Sub Form_Load()

#If VBC_VER = 8 Then
      With Me.Customer1.DataBindings
         .Add(Customer1, "CustomerName", "CompanyName")
         .Add(Customer1, "Address", "Address")
         .Add(Customer1, "City", "City")
         .Add(Customer1, "ZipCode", "PostalCode")
         .Add(Customer1, "Country", "Country")
         .Add(Customer1, "Phone", "Phone")
         .Add(Customer1, "Fax", "Fax")
      End With
#End If

End Sub

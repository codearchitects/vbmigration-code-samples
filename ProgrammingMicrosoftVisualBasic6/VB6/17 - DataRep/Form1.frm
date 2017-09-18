VERSION 5.00
Object = "{5C8CED40-8909-11D0-9483-00A0C91110ED}#1.0#0"; "MSDATREP.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "DataRepeater Demo"
   ClientHeight    =   6720
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7035
   LinkTopic       =   "Form1"
   ScaleHeight     =   6720
   ScaleWidth      =   7035
   StartUpPosition =   3  'Windows Default
   Begin MSDataRepeaterLib.DataRepeater DataRepeater1 
      Bindings        =   "Form1.frx":0000
      Height          =   6030
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6735
      _ExtentX        =   11880
      _ExtentY        =   10636
      _StreamID       =   -1412567295
      _Version        =   393216
      Caption         =   "DataRepeater1"
      BeginProperty RepeatedControlName {21FC0FC0-1E5C-11D1-A327-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         Name            =   "AddressControl.AddressOCX"
      EndProperty
      RepeaterBindings=   5
      BeginProperty RepeaterBinding(0) {7D21A594-FC9B-11D0-A320-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         PropertyName    =   "CompleteName"
         DataField       =   "Company Name"
      EndProperty
      BeginProperty RepeaterBinding(1) {7D21A594-FC9B-11D0-A320-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         PropertyName    =   "Street"
         DataField       =   "Address"
      EndProperty
      BeginProperty RepeaterBinding(2) {7D21A594-FC9B-11D0-A320-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         PropertyName    =   "City"
         DataField       =   "City"
      EndProperty
      BeginProperty RepeaterBinding(3) {7D21A594-FC9B-11D0-A320-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         PropertyName    =   "State"
         DataField       =   "State"
      EndProperty
      BeginProperty RepeaterBinding(4) {7D21A594-FC9B-11D0-A320-00AA00688B10} 
         _StreamID       =   -1412567295
         _Version        =   65536
         PropertyName    =   "Zip"
         DataField       =   "Zip"
      EndProperty
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   120
      Top             =   6360
      Width           =   3495
      _ExtentX        =   6165
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
      ConnectStringType=   2
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "FILE NAME=C:\Program Files\Common Files\SYSTEM\ole db\Data Links\Biblio.Udl"
      OLEDBString     =   ""
      OLEDBFile       =   "C:\Program Files\Common Files\SYSTEM\ole db\Data Links\Biblio.Udl"
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Publishers"
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
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_resize()
    DataRepeater1.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

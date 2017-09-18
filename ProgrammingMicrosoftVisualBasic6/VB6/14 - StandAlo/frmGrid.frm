VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmGrid 
   Caption         =   "Stand-alone Recordset demo"
   ClientHeight    =   3870
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8235
   LinkTopic       =   "Form1"
   ScaleHeight     =   3870
   ScaleWidth      =   8235
   StartUpPosition =   3  'Windows Default
   Begin MSDataGridLib.DataGrid DataGrid1 
      Height          =   2535
      Left            =   240
      TabIndex        =   0
      Top             =   360
      Width           =   6495
      _ExtentX        =   11456
      _ExtentY        =   4471
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   "Test Caption"
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmGrid"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'----------------------------------------------------------
' Sample code that creates a stand-alone disconnected Recordset.
'----------------------------------------------------------

'##AddDataFile Publishers.dat

#Const UseLoopOnFields = True

Option Explicit

Private Sub Form_Load()
    Dim rs As New ADODB.Recordset
    Dim lines() As String, fields() As String
    Dim fieldMax As Integer
    Dim i As Long, j As Long
    
    ' modify to match the current directory structure
    Dim dataFile As String
    
    dataFile = "publishers.dat"
    
    ' Open the Publishers.dat text file.
    ChDrive App.Path
    ChDir App.Path
    Open dataFile For Input As #1
    ' Read the contents of the file and parse it in individual lines.
    lines() = Split(Input(LOF(1), 1), vbCrLf)
    Close #1
    
    ' Parse the first line, that contains the list of fields.
    fields() = Split(lines(0), ";")
    fieldMax = UBound(fields)
    For j = 0 To fieldMax
        rs.fields.Append fields(j), adChar, 200
    Next
    rs.Open
    
#If UseLoopOnFields Then
    ' Parse all the remaining lines.
    For i = 1 To UBound(lines)
        rs.AddNew
        fields() = Split(lines(i), ";")
        For j = 0 To UBound(fields)
            rs(j) = fields(j)
        Next
    Next
#Else
    ' Build the FieldNames() variant array.
    ReDim fieldNames(0 To fieldMax) As Variant
    For j = 0 To fieldMax
        fieldNames(j) = fields(j)
    Next
    ' Parse the data lines, but use an array of values in AddNew.
    For i = 1 To UBound(lines)
        fields() = Split(lines(i), ";")
        ReDim fieldValues(0 To fieldMax) As Variant
        For j = 0 To UBound(fields)
            fieldValues(j) = fields(j)
        Next
        rs.AddNew fieldNames(), fieldValues()
    Next
#End If
        
    rs.MoveFirst
    Set DataGrid1.DataSource = rs
End Sub

Private Sub Form_Resize()
    DataGrid1.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

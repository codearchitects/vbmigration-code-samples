VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "Loading DB data into a ListView control"
   ClientHeight    =   4425
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8415
   LinkTopic       =   "Form1"
   ScaleHeight     =   4425
   ScaleWidth      =   8415
   StartUpPosition =   3  'Windows Default
   Begin MSComctlLib.ListView ListView1 
      Height          =   3735
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   8175
      _ExtentX        =   14420
      _ExtentY        =   6588
      View            =   3
      MultiSelect     =   -1  'True
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      AllowReorder    =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   0
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False
'##project:DisableMessages CodeAnalysis

Option Explicit

' WARNING: modify the DBPATH constant to match your database's path.
Const DBPATH = "C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"

Private Sub Form_Load()
    Dim cn As New ADODB.Connection, rs As New ADODB.Recordset
    cn.Open "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH
    rs.Open "Orders", cn, adOpenForwardOnly, adLockReadOnly
    
    LoadListViewFromRecordset ListView1, rs
    ListViewAdjustColumnWidth ListView1, True

End Sub

Private Sub Form_Resize()
    ListView1.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

Private Sub ListView1_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    ' sort according to data in this column
    
    ' a few special fields
    If ColumnHeader.Text = "Freight" Then
        ListViewSortOnNonStringField ListView1, ColumnHeader.Index
        Exit Sub
    ElseIf ColumnHeader.Text = "OrderDate" Or ColumnHeader.Text = "RequiredDate" Then
        ListViewSortOnNonStringField ListView1, ColumnHeader.Index, , True
        Exit Sub
    End If
    
    If ListView1.Sorted And ColumnHeader.Index - 1 = ListView1.SortKey Then
        ' the ListView is already sorted on this column, just invert the sort order
        ListView1.SortOrder = 1 - ListView1.SortOrder
    Else
        ListView1.SortOrder = lvwAscending
        ListView1.SortKey = ColumnHeader.Index - 1
    End If
    ListView1.Sorted = True
End Sub




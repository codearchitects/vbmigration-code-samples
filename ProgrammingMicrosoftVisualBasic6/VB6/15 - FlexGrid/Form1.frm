VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form Form1 
   Caption         =   "Hierarchical FlexGrid demo"
   ClientHeight    =   3180
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6225
   LinkTopic       =   "Form1"
   ScaleHeight     =   3180
   ScaleWidth      =   6225
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCollapse 
      Caption         =   "Collapse All"
      Height          =   375
      Left            =   1200
      TabIndex        =   3
      Top             =   0
      Width           =   1215
   End
   Begin VB.CommandButton cmdExpand 
      Caption         =   "Expand All"
      Height          =   375
      Left            =   0
      TabIndex        =   2
      Top             =   0
      Width           =   1215
   End
   Begin VB.TextBox txtCellEditor 
      BorderStyle     =   0  'None
      Height          =   375
      Left            =   960
      MultiLine       =   -1  'True
      TabIndex        =   1
      Top             =   2520
      Width           =   1335
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Bindings        =   "Form1.frx":0000
      Height          =   1200
      Left            =   0
      TabIndex        =   0
      Top             =   480
      Width           =   5250
      _ExtentX        =   9260
      _ExtentY        =   2117
      _Version        =   393216
      Cols            =   7
      AllowUserResizing=   3
      DataMember      =   "Authors"
      _NumberOfBands  =   3
      _Band(0).Cols   =   3
      _Band(0).GridLinesBand=   1
      _Band(0).TextStyleBand=   0
      _Band(0).TextStyleHeader=   0
      _Band(0)._NumMapCols=   3
      _Band(0)._MapCol(0)._Name=   "Au_ID"
      _Band(0)._MapCol(0)._RSIndex=   0
      _Band(0)._MapCol(0)._Alignment=   7
      _Band(0)._MapCol(0)._Hidden=   -1  'True
      _Band(0)._MapCol(1)._Name=   "Author"
      _Band(0)._MapCol(1)._RSIndex=   1
      _Band(0)._MapCol(2)._Name=   "Year Born"
      _Band(0)._MapCol(2)._RSIndex=   2
      _Band(0)._MapCol(2)._Alignment=   7
      _Band(1).BandIndent=   1
      _Band(1).GridLinesBand=   1
      _Band(1).TextStyleBand=   0
      _Band(1).TextStyleHeader=   0
      _Band(1)._ParentBand=   0
      _Band(1)._NumMapCols=   2
      _Band(1)._MapCol(0)._Name=   "ISBN"
      _Band(1)._MapCol(0)._RSIndex=   0
      _Band(1)._MapCol(0)._Hidden=   -1  'True
      _Band(1)._MapCol(1)._Name=   "Au_ID"
      _Band(1)._MapCol(1)._RSIndex=   1
      _Band(1)._MapCol(1)._Alignment=   7
      _Band(1)._MapCol(1)._Hidden=   -1  'True
      _Band(2).BandIndent=   2
      _Band(2).Cols   =   4
      _Band(2).GridLinesBand=   1
      _Band(2).TextStyleBand=   0
      _Band(2).TextStyleHeader=   0
      _Band(2)._ParentBand=   1
      _Band(2)._NumMapCols=   8
      _Band(2)._MapCol(0)._Name=   "Title"
      _Band(2)._MapCol(0)._RSIndex=   0
      _Band(2)._MapCol(1)._Name=   "Year Published"
      _Band(2)._MapCol(1)._RSIndex=   1
      _Band(2)._MapCol(1)._Alignment=   7
      _Band(2)._MapCol(2)._Name=   "ISBN"
      _Band(2)._MapCol(2)._RSIndex=   2
      _Band(2)._MapCol(3)._Name=   "PubID"
      _Band(2)._MapCol(3)._RSIndex=   3
      _Band(2)._MapCol(3)._Alignment=   7
      _Band(2)._MapCol(3)._Hidden=   -1  'True
      _Band(2)._MapCol(4)._Name=   "Description"
      _Band(2)._MapCol(4)._RSIndex=   4
      _Band(2)._MapCol(4)._Hidden=   -1  'True
      _Band(2)._MapCol(5)._Name=   "Notes"
      _Band(2)._MapCol(5)._RSIndex=   5
      _Band(2)._MapCol(5)._Hidden=   -1  'True
      _Band(2)._MapCol(6)._Name=   "Subject"
      _Band(2)._MapCol(6)._RSIndex=   6
      _Band(2)._MapCol(7)._Name=   "Comments"
      _Band(2)._MapCol(7)._RSIndex=   7
      _Band(2)._MapCol(7)._Hidden=   -1  'True
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' WARNING: see DB_PATH constant in DataEnvironment1 module
'          to ensure that it points to the Biblio database

' These variables keep track of the cell that was active
' when edit mode was entered.
Dim cellRow As Long, cellCol As Long

Private Sub Form_Load()
    txtCellEditor.Visible = False
    Set txtCellEditor.Font = MSHFlexGrid1.Font
End Sub

Private Sub Form_Resize()
    MSHFlexGrid1.Move 0, MSHFlexGrid1.Top, ScaleWidth, ScaleHeight - MSHFlexGrid1.Top
End Sub

Private Sub MSHFlexGrid1_DblClick()
    ShowCellEditor
End Sub

Sub ShowCellEditor()
    With MSHFlexGrid1
        ' Cancel range selection, if any.
        .RowSel = .Row
        .ColSel = .Col
        ' Move the cell editor in place, by maing it one pixel smaller
        ' then the current cell.
        txtCellEditor.Move .Left + .CellLeft, .Top + .CellTop, _
            .CellWidth - ScaleX(1, vbPixels, vbTwips), _
            .CellHeight - ScaleY(1, vbPixels, vbTwips)
        ' Transfer the contents of the current cell into the TextBox.
        txtCellEditor.Text = .Text
        ' Move the textbox in front of the grid.
        txtCellEditor.Visible = True
        txtCellEditor.ZOrder
        txtCellEditor.SetFocus
        ' Remember current coordinates for later.
        cellRow = .Row
        cellCol = .Col
    End With
End Sub

Sub HideCellEditor(Optional Cancel As Boolean)
    ' Hide the textbox if necessary.
    If txtCellEditor.Visible Then
        ' If the operation hasn't been canceled, transfer the contents
        ' of the textbox into the original active cell.
        If Not Cancel Then
            MSHFlexGrid1.TextMatrix(cellRow, cellCol) = txtCellEditor.Text
        End If
        txtCellEditor.Visible = False
    End If
End Sub

Private Sub MSHFlexGrid1_KeyPress(KeyAscii As Integer)
    ShowCellEditor
    If KeyAscii >= 32 Then
        txtCellEditor.Text = Chr$(KeyAscii)
        txtCellEditor.SelStart = 1
    End If
End Sub

Private Sub txtCellEditor_KeyPress(KeyAscii As Integer)
    Select Case KeyAscii
        Case 13
            HideCellEditor
        Case 27
            HideCellEditor True
    End Select
End Sub

Private Sub txtCellEditor_LostFocus()
    HideCellEditor
End Sub

Private Sub cmdCollapse_Click()
    MSHFlexGrid1.CollapseAll
End Sub

Private Sub cmdExpand_Click()
    MSHFlexGrid1.ExpandAll
End Sub



VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Dynamic Control Creation Demo"
   ClientHeight    =   4965
   ClientLeft      =   225
   ClientTop       =   825
   ClientWidth     =   9780
   LinkTopic       =   "Form1"
   ScaleHeight     =   4965
   ScaleWidth      =   9780
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   480
      Top             =   240
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   2  'Align Bottom
      Height          =   495
      Left            =   0
      Top             =   4470
      Width           =   9780
      _ExtentX        =   17251
      _ExtentY        =   873
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      Cursortype      =   3
      LockType        =   3
      CommandType     =   8
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
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
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileOpen 
         Caption         =   "&Open Database"
      End
      Begin VB.Menu mnuSelect 
         Caption         =   "&Select RecordSource"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuFileBar 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False

' the name of the database
Dim dbName As String
' the collection of controls added dynamically
Dim WithEvents ControlItems As ControlItems
Attribute ControlItems.VB_VarHelpID = -1

Private Sub Form_Resize()
    ' fix a bug in the original code
    If ControlItems Is Nothing Then Exit Sub
    
    ' resize all controls to ensure that they fit in the form
    Dim ctrl As Control
    Dim ctrlItem As ControlItem
    
    On Error Resume Next
    
    For Each ctrlItem In ControlItems
        Set ctrl = ctrlItem.Control
        ctrl.Width = ctrlItem.Properties("Width")
        If ctrl.Left + ctrl.Width > ScaleWidth Then
            ctrl.Width = ScaleWidth - ctrl.Left
        End If
    Next
End Sub

Private Sub mnuFileOpen_Click()
    With CommonDialog1
        .Filter = "Access Databases (*.mdb)|*mdb|All Files (*.*)|*.*"
        .Flags = cdlOFNFileMustExist
        .ShowOpen
        ' exit if no file was selected
        If .FileName = "" Then Exit Sub
        
        dbName = .FileName
        mnuSelect.Enabled = True
    End With
End Sub

Private Sub mnuSelect_Click()
    Dim source As String
    On Error GoTo Error_handler
    
    source = InputBox("Enter a table name or a SELECT expression", "Database: " & dbName)
    If source = "" Then Exit Sub
    
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & dbName
    Adodc1.RecordSource = source
    '##InsertStatement Adodc1.Recordset = Nothing
    Adodc1.Refresh
    LoadControls Adodc1.Recordset
    
Error_handler:

End Sub

Private Sub mnuFileExit_Click()
    Unload Me
End Sub

Sub LoadControls(rs As ADODB.Recordset)
    Dim index As Long
    Dim field As ADODB.field
    Dim ctrl As Control
    Dim ctrlItem As ControlItem
    Dim ctrlType As String
    Dim Properties As Collection
    Dim CustomProperties As Collection
    Dim top As Single
    Dim propItem As Variant
    Dim items() As String
    Dim fieldNum As Integer
    
    ' first, remove all controls added dynamically
    On Error Resume Next
    ' don't try a forward or a For Each loop
    For index = Controls.Count - 1 To 1 Step -1
        Controls.Remove index
    Next
    On Error GoTo 0
    
    ' start with a fresh ControlItems collection
    Set ControlItems = New ControlItems
    
    ' initial value for Top property
    top = 100
    
    ' add controls corresponding to fields
    ' this demo program only supports a few field types
    For Each field In rs.Fields
        ctrlType = ""
        Set Properties = New Collection
        Set CustomProperties = New Collection
        Select Case field.Type
            Case adBoolean
                ctrlType = "MSWLess.WLCheck"
                Properties.Add "Caption="
            Case adSmallInt   ' As Integer
                ctrlType = "MSWLess.WLText"
            Case adInteger    ' As Long
                ctrlType = "MSWLess.WLText"
                CustomProperties.Add "IsNumeric=-1"
                CustomProperties.Add "IsInteger=-1"
            Case adSingle, adDouble, adCurrency
                ctrlType = "MSWLess.WLText"
                CustomProperties.Add "Numeric=-1"
            Case adChar, adVarChar  ' As String
                ctrlType = "MSWLess.WLText"
                Properties.Add "Width=" & (field.DefinedSize * TextWidth("W"))
            Case adLongVarChar   ' (memo field)
                ctrlType = "MSWLess.WLText"
                Properties.Add "Width=99999"  ' very large width
                Properties.Add "Height=2000"
                Properties.Add "Multiline=-1"
                Properties.Add "ScrollBars=2"  'vbVertical
            Case adDate
                ctrlType = "MSWLess.WLText"
                Properties.Add "Width=1000"
                CustomProperties.Add "IsDate=-1"
            Case Else
                Debug.Print field.Name, field.Type
        End Select
        
        ' do nothing if this field type is not supported
        If ctrlType <> "" Then
            fieldNum = fieldNum + 1
            ' create the label control with database field name
            Set ctrl = Controls.Add("VB.Label", "Label" & fieldNum)
            ctrl.Move 50, top, 1800, 315
            ctrl.Caption = field.Name
            ctrl.UseMnemonic = False
            ctrl.BorderStyle = 1
            ctrl.Alignment = vbRightJustify
            ctrl.Visible = True
            
            ' now create the control
            Set ctrl = Controls.Add(ctrlType, "Field" & fieldNum)
            ctrl.Move 1900, top, 2000, 315
            
            ' if field is not updatable, lock the field
            If (field.Attributes And adFldUpdatable) = 0 Then
                On Error Resume Next
                ctrl.Locked = True
                If Err Then ctrl.Enabled = False
                On Error GoTo 0
            End If
            
            ' set its other properties
            For Each propItem In Properties
                ' split property name and value
                items() = Split(propItem, "=")
                CallByName ctrl, items(0), VbLet, items(1)
            Next
            
            ' link it to the Data control and make it visible
            Set ctrl.DataSource = Adodc1
            ctrl.DataField = field.Name
            ctrl.Visible = True
            
            ' add this control to the ControlItems collection
            ' this will enable to receive events from it
            Set ctrlItem = ControlItems.Add(ctrl)
            
            ' move the actual width into the Custom Width property
            ' this is used in the Form_Resize event
            ctrlItem.Properties.Add ctrl.Width, "Width"
            
            ' set its other custom properties
            For Each propItem In CustomProperties
                ' split property name and value
                items() = Split(propItem, "=")
                ctrlItem.Properties.Add items(1), items(0)
            Next
            
            ' increment top
            top = top + ctrl.Height + 80
        End If
    Next
    
    ' force a Form_Resize event, to resize longer controls
    Call Form_Resize
    
    Adodc1.Refresh
    
End Sub

' one control added dynamically is asking for validation
' Item.Control is a reference to the control
' Item.GetProperty(propname) returns a custom property

Private Sub ControlItems_Validate(Item As ControlItem, Cancel As Boolean)
    If Item.GetProperty("IsNumeric") Then
        If Not IsNumeric(Item.Control.Text) Then
            MsgBox "Please enter a valid number"
            Cancel = True
            Exit Sub
        End If
    End If
    If Item.GetProperty("IsInteger") Then
        If CDbl(Item.Control.Text) <> Int(CDbl(Item.Control.Text)) Then
            MsgBox "Please enter a valid Integer number"
            Cancel = True
            Exit Sub
        End If
    End If
    If Item.GetProperty("IsDate") Then
        If Not IsDate(Item.Control.Text) Then
            MsgBox "Please enter a valid date"
            Cancel = True
            Exit Sub
        End If
    End If
    
End Sub

Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    Adodc1.Caption = "Record " & Adodc1.Recordset.AbsolutePosition & " of " & Adodc1.Recordset.RecordCount
End Sub









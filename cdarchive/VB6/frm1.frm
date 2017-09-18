VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form fd 
   Caption         =   "CDArchive"
   ClientHeight    =   7485
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11280
   Icon            =   "frm1.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   7485
   ScaleWidth      =   11280
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "Compress Database"
      Height          =   255
      Left            =   9360
      TabIndex        =   8
      Top             =   420
      Width           =   1815
   End
   Begin MSComctlLib.ProgressBar pb 
      Height          =   375
      Left            =   6240
      TabIndex        =   7
      Top             =   0
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   661
      _Version        =   393216
      Appearance      =   0
      Scrolling       =   1
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   4335
      Left            =   4680
      TabIndex        =   4
      Top             =   720
      Width           =   6615
      _ExtentX        =   11668
      _ExtentY        =   7646
      View            =   3
      LabelEdit       =   1
      Sorted          =   -1  'True
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      _Version        =   393217
      Icons           =   "ImageList1"
      SmallIcons      =   "ImageList1"
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      Appearance      =   1
      NumItems        =   1
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Results"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Add CD"
      Height          =   375
      Left            =   4800
      TabIndex        =   1
      Top             =   0
      Width           =   1335
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   4680
      TabIndex        =   2
      Top             =   405
      Width           =   3495
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   1080
      Top             =   2760
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   4
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frm1.frx":0442
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frm1.frx":0894
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frm1.frx":098E
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frm1.frx":0A88
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.TreeView cds 
      Height          =   7455
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   4575
      _ExtentX        =   8070
      _ExtentY        =   13150
      _Version        =   393217
      Indentation     =   265
      LabelEdit       =   1
      LineStyle       =   1
      Sorted          =   -1  'True
      Style           =   7
      HotTracking     =   -1  'True
      SingleSel       =   -1  'True
      ImageList       =   "ImageList1"
      Appearance      =   1
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Search"
      Height          =   255
      Left            =   8280
      TabIndex        =   3
      Top             =   420
      Width           =   975
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      Height          =   525
      Left            =   4680
      Locked          =   -1  'True
      MousePointer    =   1  'Arrow
      TabIndex        =   6
      Top             =   5085
      Width           =   6495
   End
   Begin VB.Label Label1 
      Height          =   1755
      Left            =   4680
      TabIndex        =   5
      Top             =   5640
      Width           =   6525
   End
   Begin VB.Menu mnuAddCd 
      Caption         =   "mnuAddCD"
      Visible         =   0   'False
      Begin VB.Menu mnuCancel 
         Caption         =   "Cancel"
      End
      Begin VB.Menu sep01 
         Caption         =   "-"
      End
      Begin VB.Menu mnuDrive 
         Caption         =   "mnuDrive"
         Index           =   0
      End
   End
   Begin VB.Menu mnuCDOptions 
      Caption         =   "mnuCDOptions"
      Visible         =   0   'False
      Begin VB.Menu mnuInfo2 
         Caption         =   ""
      End
      Begin VB.Menu mnuInfo 
         Caption         =   ""
      End
      Begin VB.Menu fdshg 
         Caption         =   "-"
      End
      Begin VB.Menu mnuRemCD 
         Caption         =   "Remove CD From Archive"
      End
   End
End
Attribute VB_Name = "fd"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim filenamea As String
Dim xDB As New Connection
Dim rsFiles As New Recordset
Dim rsCDs As New Recordset
Dim toclick As String
Dim inAnother As Long
Dim lastnode As Node
Dim lastitem As ListItem
Public Sub emptynode(n As Node)
On Local Error Resume Next
Do While n.Children <> 0
    n.Expanded = False
  emptynode n.Child
    cds.Nodes.Remove n.Child.key
Loop
    
End Sub

Private Sub cds_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
Dim cow As Node

Set cow = cds.HitTest(x, Y)
If TypeName(cow) = "Nothing" Then cds.ToolTipText = "": Exit Sub
If InStr(1, cow.key, "\") <> 0 Then Label1 = cow.Tag: Exit Sub
If Button = 1 Then
If cow.Children > 0 Then Exit Sub
cow.Expanded = False
Label1 = ""

Enabled = False

cds.Enabled = False
On Local Error Resume Next
 For x = 1 To cds.Nodes.Count
    emptynode cds.Nodes(x)
Next x
On Local Error GoTo 0
    Dim cdn As Node
    Dim f As Node
        Set cdn = cds.Nodes(cow.key)
    

        rsFiles.Open "SELECT * FROM Files WHERE  CDID='" & cow.key & "' Order by FullPath;", xDB, adOpenStatic, adLockReadOnly
        pb.Max = rsFiles.RecordCount
        
        Do While Not rsFiles.EOF
        pb.Value = rsFiles.AbsolutePosition
Text2 = "Loading directory structure..." & pb.Value & " of " & pb.Max & ", " & FormatPercent(pb.Value / pb.Max, 0)
        Select Case rsFiles("Type")
    Case 0
        'directory
        If DoesNodeExsist(cow.key & GetDir(rsFiles("FullPath"))) = False Then
            Set f = cds.Nodes.Add(cdn, tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 3)
            f.ExpandedImage = 2
        Else
            
            Set f = cds.Nodes.Add(cow.key & GetDir(rsFiles("FullPath")), tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 3)
             f.ExpandedImage = 2
        End If
    Case 1
        'file
        If DoesNodeExsist(cow.key & GetDir(rsFiles("FullPath"))) = False Then
            Set f = cds.Nodes.Add(cdn, tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 4)
        Else
            
            Set f = cds.Nodes.Add(cow.key & GetDir(rsFiles("FullPath")), tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 4)
        End If
End Select
    f.Tag = "File Name: " & rsFiles("Name") & vbCrLf
    f.Tag = f.Tag & "Date: " & rsFiles("Date") & vbCrLf
If rsFiles("Type") = 1 Then
      f.Tag = f.Tag & "Size: " & makesize(rsFiles("Size")) & vbCrLf
      f.Tag = f.Tag & "Type: File" & vbCrLf
Else
      f.Tag = f.Tag & "Type: Directory" & vbCrLf
End If
    f.Tag = f.Tag & "Path: " & rsFiles("FullPath") & vbCrLf
    f.Tag = f.Tag & "FileID: " & rsFiles("ID") & vbCrLf
    f.Tag = f.Tag & "CDID: " & cow.key & vbCrLf
    f.Tag = f.Tag & "CD Serial: " & cow.Tag & vbCrLf
    f.Tag = f.Tag & "CD Label: " & cow.Text & vbCrLf

            rsFiles.MoveNext
            If cds.Nodes.Count Mod 200 = 0 Then DoEvents
 'f.Sorted = True
        Loop
        
 
        rsFiles.Close
 
pb.Value = 0
cow.Expanded = True
'node.EnsureVisible
If toclick <> "" Then
    cds.Nodes(toclick).Expanded = True
    cds.Nodes(toclick).EnsureVisible
On Local Error Resume Next
    If TypeName(lastnode) = "Nothing" Then Set lastnode = cds.Nodes(toclick)
   

        
    Set lastnode = cds.Nodes(toclick)
     toclick = ""
End If

cds.Enabled = True
Enabled = True
Text2 = ""

Exit Sub
doneo:
cds.Enabled = True
Enabled = True
Text2 = ""
End If
If Button = 2 Then
    mnuInfo.Caption = "CDID: " & cow.Text
    mnuInfo.Tag = cow.key
    mnuInfo2.Caption = "CDLabel: " & cow.Tag
    PopupMenu mnuCDOptions, , x, Y, mnuRemCD

End If
End Sub

Private Sub cds_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
Dim cow As Node

Set cow = cds.HitTest(x, Y)
If TypeName(cow) = "Nothing" Then cds.ToolTipText = "": Exit Sub
 If TypeName(lastnode) = "Nothing" Then Set lastnode = cow
If cow.key = lastnode.key Then Exit Sub
Debug.Print cow.key
Debug.Print lastnode.key
On Local Error Resume Next


Set lastnode = cow
If InStr(1, cow.key, "\") = 0 Then cds.ToolTipText = "CDLabel: " & cow.Tag
If InStr(1, cow.key, "\") > 0 Then Label1 = cow.Tag
End Sub


Private Sub Command1_Click()
Me.Enabled = False
Dim dlisting() As String
dlisting = GetDriveListing()
mnuDrive(0).Caption = dlisting(0) & ":" & GetDriveSerial(dlisting(0))
mnuDrive(0).Tag = dlisting(x)
If GetDriveSerial(mnuDrive(0).Tag) = "0" Then mnuDrive(x).Visible = False
If Len(dlisting(0)) = 0 Then mnuDrive(0).Visible = False
For x = 1 To UBound(dlisting)
    DoEvents
    
    Load mnuDrive(x)
    mnuDrive(x).Caption = dlisting(x) & ":" & GetDriveSerial(dlisting(x))
    mnuDrive(x).Tag = dlisting(x)
    
    If Len(dlisting(x)) <> 0 Then mnuDrive(x).Visible = True
    If GetDriveSerial(mnuDrive(x).Tag) = "0" Then mnuDrive(x).Visible = False
    
Next x

PopupMenu mnuAddCd, , Command1.Left, Command1.Top + Command1.Height

For x = 1 To mnuDrive.UBound
    DoEvents
    Unload mnuDrive(x)
Next x

Me.Enabled = True
End Sub

Private Sub Command2_Click()

Enabled = False
ListView1.ListItems.Clear
query = "SELECT f.*,c.* FROM Files f, CDs c WHERE Name LIKE ""%" & Text1.Text & "%"" AND c.CDID=f.CDID;"
'Sum (f.Size)
rsFiles.Open query, xDB, adOpenStatic, adLockReadOnly
Debug.Print query
Dim cowcum As Currency
Dim cdn As ListItem
On Local Error Resume Next
pb.Max = rsFiles.RecordCount
Text2 = "Found " & rsFiles.RecordCount & " results."
Do While Not rsFiles.EOF
Text2 = "Gathering search results..." & pb.Value + 1 & " of " & pb.Max & ", " & FormatPercent((pb.Value + 1) / pb.Max, 0) & ", " & makesize(CDbl(cowcum))

    pb.Value = rsFiles.AbsolutePosition
    Set cdn = ListView1.ListItems.Add(, Chr(0) & rsFiles("ID"), rsFiles("Name"), rsFiles("Type") + 3, rsFiles("Type") + 3)
    
    cdn.Tag = "File Name: " & rsFiles("Name") & vbCrLf
    cdn.Tag = cdn.Tag & "Date: " & rsFiles("Date") & vbCrLf
If rsFiles("Type") = 1 Then
    cdn.Tag = cdn.Tag & "Size: " & makesize(rsFiles("Size")) & vbCrLf
    cdn.Tag = cdn.Tag & "Type: File" & vbCrLf

Else
    cdn.Tag = cdn.Tag & "Type: Directory" & vbCrLf


End If
    cdn.Tag = cdn.Tag & "Path: " & rsFiles("FullPath") & vbCrLf
    cdn.Tag = cdn.Tag & "FileID: " & rsFiles("ID") & vbCrLf
    cdn.Tag = cdn.Tag & "CDID: " & rsFiles("c.CDID") & vbCrLf
    cdn.Tag = cdn.Tag & "CD Serial: " & rsFiles("CDSerial") & vbCrLf
    cdn.Tag = cdn.Tag & "CD Label: " & rsFiles("CDLabel") & vbCrLf
    cdn.key = rsFiles("c.CDID") & rsFiles("FullPath")
    
    cowcum = cowcum + rsFiles("Size")
   
    If ListView1.ListItems.Count Mod 200 = 0 Then DoEvents
    
     rsFiles.MoveNext
Loop
pb.Value = 0
rsFiles.Close
Enabled = True
End Sub



Private Sub Command3_Click()
Dim jro As New JetEngine
xDB.Close
Kill filenamea & ".bak"
Name filenamea As filenamea & ".bak"
jro.CompactDatabase "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filenamea & ".bak", _
"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filenamea
xDB.Open
End Sub

Private Sub Form_Load()
MsgBox "Hi, Visit http://www.compiled.org"
Shell "explorer http://www.compiled.org"
Show
Dim thedir As String
thedir = App.Path
If Left$(thedir, 1) <> "\" Then thedir = thedir & "\"
ListView1.ColumnHeaders(1).Width = ListView1.Width
xDB.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & thedir & "archive.mdb"
filenamea = thedir & "archive.mdb"
RefreshCDs


End Sub
Function DoesNodeExsist(key As String) As Boolean
DoesNodeExsist = False
On Local Error GoTo errhand
    f = TypeName(cds.Nodes(key))
    DoesNodeExsist = True
Exit Function
errhand:
End Function
Function GetDir(s As String) As String
    If InStr(1, s, "\") = InStrRev(s, "\") Then GetDir = s: Exit Function
    GetDir = Mid(s, 1, InStrRev(s, "\"))
    If Right(GetDir, 1) = "\" Then GetDir = Mid(GetDir, 1, Len(GetDir) - 1)
End Function
Function RefreshCDs()
    On Local Error Resume Next
    cds.Nodes.Clear
    Show
    rsCDs.Open "SELECT * FROM CDs ORDER BY CDSerial", xDB, adOpenForwardOnly, adLockReadOnly
    Dim cdn As Node
    Dim f As Node
    Do While Not rsCDs.EOF
        Set cdn = cds.Nodes.Add(, tvwAutomatic, rsCDs("CDID"), rsCDs("CDLabel") & " [" & rsCDs("CDSerial") & "]", 1)
    cdn.Tag = rsCDs("CDLabel")
        
        rsCDs.MoveNext
    Loop
    rsCDs.Close
    rsCDs.Open "DBInfo"
Caption = "CDArchive [" & cds.Nodes.Count & " discs] [" & makesize(rsCDs("AllSize")) & " bytes in " & rsCDs("FileCount") & " files and directories]"
rsCDs.Close
End Function

Private Sub Form_Unload(Cancel As Integer)
On Error Resume Next
Set rsFiles = Nothing
Set rsCDs = Nothing

End Sub

Private Sub ListView1_ItemClick(ByVal Item As MSComctlLib.ListItem)
Label1 = Item.Tag
Icon = Item.CreateDragImage
toclick = Item.key
ListView1.Enabled = False
If DoesNodeExsist(Item.key) = True Then
    cds.Nodes(Item.key).Expanded = True
    
    cds.Nodes(Item.key).Selected = True
    On Local Error Resume Next
    If TypeName(lastnode) = "Nothing" Then Set lastnode = cds.Nodes(Item.key)

    Set lastnode = cds.Nodes(Item.key)
cds.Nodes(Item.key).EnsureVisible
Else
    
Dim cow As Node

Set cow = cds.Nodes(Mid(Item.key, 1, InStr(1, Item.key, "\") - 1))
If TypeName(cow) = "Nothing" Then cds.ToolTipText = "": Exit Sub
If InStr(1, cow.key, "\") <> 0 Then Label1 = cow.Tag: Exit Sub

If cow.Children > 0 Then Exit Sub
cow.Expanded = False
Label1 = ""

Enabled = False

cds.Enabled = False
On Local Error Resume Next
 For x = 1 To cds.Nodes.Count
    emptynode cds.Nodes(x)
Next x
On Local Error GoTo 0
    Dim cdn As Node
    Dim f As Node
        Set cdn = cds.Nodes(cow.key)
    

        rsFiles.Open "SELECT * FROM Files WHERE  CDID='" & cow.key & "' Order by FullPath;", xDB, adOpenStatic, adLockReadOnly
        pb.Max = rsFiles.RecordCount
        
        Do While Not rsFiles.EOF
        pb.Value = rsFiles.AbsolutePosition
Text2 = "Loading directory structure..." & pb.Value & " of " & pb.Max & ", " & FormatPercent(pb.Value / pb.Max, 0)
        Select Case rsFiles("Type")
    Case 0
        'directory
        If DoesNodeExsist(cow.key & GetDir(rsFiles("FullPath"))) = False Then
            Set f = cds.Nodes.Add(cdn, tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 3)
            f.ExpandedImage = 2
        Else
            
            Set f = cds.Nodes.Add(cow.key & GetDir(rsFiles("FullPath")), tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 3)
             f.ExpandedImage = 2
        End If
    Case 1
        'file
        If DoesNodeExsist(cow.key & GetDir(rsFiles("FullPath"))) = False Then
            Set f = cds.Nodes.Add(cdn, tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 4)
        Else
            
            Set f = cds.Nodes.Add(cow.key & GetDir(rsFiles("FullPath")), tvwChild, cow.key & rsFiles("FullPath"), rsFiles("Name"), 4)
        End If
End Select
    f.Tag = "File Name: " & rsFiles("Name") & vbCrLf
    f.Tag = f.Tag & "Date: " & rsFiles("Date") & vbCrLf
If rsFiles("Type") = 1 Then
      f.Tag = f.Tag & "Size: " & makesize(rsFiles("Size")) & vbCrLf
      f.Tag = f.Tag & "Type: File" & vbCrLf
Else
      f.Tag = f.Tag & "Type: Directory" & vbCrLf
End If
    f.Tag = f.Tag & "Path: " & rsFiles("FullPath") & vbCrLf
    f.Tag = f.Tag & "FileID: " & rsFiles("ID") & vbCrLf
    f.Tag = f.Tag & "CDID: " & cow.key & vbCrLf
    f.Tag = f.Tag & "CD Serial: " & cow.Tag & vbCrLf
    f.Tag = f.Tag & "CD Label: " & cow.Text & vbCrLf

            rsFiles.MoveNext
            If cds.Nodes.Count Mod 200 = 0 Then DoEvents
 'f.Sorted = True
        Loop
        
 
        rsFiles.Close
 
pb.Value = 0
cow.Expanded = True
'node.EnsureVisible
If toclick <> "" Then
    cds.Nodes(toclick).Expanded = True
    cds.Nodes(toclick).EnsureVisible
On Local Error Resume Next
    If TypeName(lastnode) = "Nothing" Then Set lastnode = cds.Nodes(toclick)
   

        
    Set lastnode = cds.Nodes(toclick)
     toclick = ""
End If

cds.Enabled = True
Enabled = True
Text2 = ""
ListView1.Enabled = True
Exit Sub
doneo:
cds.Enabled = True
Enabled = True
Text2 = ""


End If
ListView1.Enabled = True
End Sub

Private Sub ListView1_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
Dim cow As ListItem

Set cow = ListView1.HitTest(x, Y)
If TypeName(cow) = "Nothing" Then ListView1.ToolTipText = "": Exit Sub
 If TypeName(lastitem) = "Nothing" Then Set lastitem = cow
If cow.key = lastitem.key Then Exit Sub
Debug.Print cow.key
Debug.Print lastitem.key
On Local Error Resume Next
lastitem.Bold = False
lastitem.ForeColor = vbBlack

cow.Bold = True
cow.ForeColor = vbRed
Icon = cow.CreateDragImage
Set lastitem = cow
ListView1.ToolTipText = "CDID: " & Mid(cow.key, 1, InStr(1, cow.key, "\") - 1)
Label1 = cow.Tag
If DoesNodeExsist(cow.key) = True Then
    cdscds.Nodes(cow.key).Expanded = True
    
    cds.Nodes(cow.key).Selected = True
    On Local Error Resume Next
    If TypeName(lastnode) = "Nothing" Then Set lastnode = cds.Nodes(cow.key)
   
        
    Set lastnode = cds.Nodes(cow.key)
cds.Nodes(cow.key).EnsureVisible
End If
End Sub

Private Sub mnuDrive_Click(Index As Integer)
Set rsCDs = xDB.Execute("SELECT COUNT(*) FROM CDs WHERE CDSerial=" & GetDriveSerial(mnuDrive(Index).Tag) & ";")
If rsCDs.Fields(0).Value <> 0 Then
    MsgBox "This CD has already been cataloged.", vbCritical, "Error"
    rsCDs.Close
    Exit Sub
End If
rsCDs.Close
rsCDs.Open "CDs", xDB, adOpenDynamic, adLockOptimistic
rsCDs.AddNew
    rsCDs("CDSerial") = GetDriveSerial(mnuDrive(Index).Tag)
    rsCDs("CDLabel") = GetVolumeLabel(mnuDrive(Index).Tag)
    If rsCDs("CDLabel") = "" Then rsCDs("CDLabel") = "[No Label]"
rsCDs.Update
    rsCDs.Close

Set rsCDs = xDB.Execute("SELECT CDID FROM CDs WHERE CDSerial=" & GetDriveSerial(mnuDrive(Index).Tag) & ";")
AddFiles rsCDs("CDID"), mnuDrive(Index).Tag
RefreshCDs
End Sub
Private Sub AddFiles(cdGUID As String, driveroot As String)
Enabled = False
Text2.Text = "Reading CD..."
rsCDs.Close
rsFiles.Open "Files", xDB, adOpenDynamic, adLockOptimistic
ReDim DirQUE(0 To 0)
DirQUE(0) = driveroot

f = 0
Dim cow() As DirInfo
Do While (UBound(DirQUE) <> f - 1)
DoEvents
Call EnumDirs("*", DirQUE(f), cow())
f = f + 1
For x = 0 To UBound(cow)
If cow(x).FullPath = "" Then GoTo cowboy
    If cow(x).fSize = "-" Then
        ReDim Preserve DirQUE(LBound(DirQUE) To UBound(DirQUE) + 1)
        DirQUE(UBound(DirQUE)) = cow(x).FullPath & "\"
   
        rsFiles.AddNew
        rsFiles("CDID") = cdGUID
        rsFiles("Name") = cow(x).fNAME
        rsFiles("Date") = cow(x).fDATE
        rsFiles("FullPath") = Mid(cow(x).FullPath, 3)
        rsFiles("Type") = 0
        rsFiles("Size") = 0
        rsFiles.Update
    Else
        'file

        
        rsFiles.AddNew
        rsFiles("CDID") = cdGUID
        rsFiles("Name") = cow(x).fNAME
        rsFiles("Date") = cow(x).fDATE
        rsFiles("FullPath") = Mid(cow(x).FullPath, 3)
        rsFiles("Type") = 1
        rsFiles("Size") = cow(x).fSize
        rsFiles.Update
    End If
cowboy:
DoEvents
Text2.Text = "Reading CD..." & cow(x).FullPath
Next x
ReDim cow(0 To 0)
Loop
rsFiles.Close
Label1 = "Reading CD...Done.."
Label1 = Label1 & "Label this CD " & GetDriveSerial(driveroot) & vbCrLf & vbCrLf
Label1 = Label1 & x & " files and directories read."
Enabled = True
End Sub

Function makesize(bytes As Double) As String

    If bytes < 1024 Then
        makesize = FormatNumber(bytes, 0, 0, 0, True) & " b"
        Exit Function
    End If
    
    If (bytes / 1024) < 1024 Then
        makesize = FormatNumber((bytes / 1024), 2, 0, 0, True) & " KB"
        Exit Function
    End If
    If ((bytes / 1024) / 1024) < 1024 Then
        makesize = FormatNumber(((bytes / 1024) / 1024), 2, 0, 0, True) & " MB"
        Exit Function
    End If
    If (((bytes / 1024) / 1024) / 1024) < 1024 Then
        makesize = FormatNumber((((bytes / 1024) / 1024) / 1024), 2, 0, 0, True) & " GB"
        Exit Function
    End If
End Function

Private Sub mnuRemCD_Click()
If MsgBox("Removing a CD is a irreversable action, the CD Can Be re-added but only if you re-add it manually!" & vbCrLf & "Are you sure you want to delete it?", vbYesNo Or vbInformation, "Yes/No?") = vbYes Then
    xDB.Execute "DELETE FROM CDs WHERE CDID='" & mnuInfo.Tag & "'"
    xDB.Execute "DELETE FROM Files WHERE CDID='" & mnuInfo.Tag & "'"
    RefreshCDs
End If
End Sub

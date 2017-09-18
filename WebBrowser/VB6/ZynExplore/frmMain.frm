VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "SHDOCVW.dll"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmMain 
   Caption         =   "ZynExplore"
   ClientHeight    =   7620
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   11370
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   7620
   ScaleWidth      =   11370
   StartUpPosition =   2  'CenterScreen
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   255
      Left            =   7560
      TabIndex        =   6
      Top             =   7320
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   450
      _Version        =   393216
      Appearance      =   0
      Scrolling       =   1
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   315
      Left            =   0
      TabIndex        =   5
      Top             =   7305
      Width           =   11370
      _ExtentX        =   20055
      _ExtentY        =   556
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   3
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   13123
            MinWidth        =   13123
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":164A
            Text            =   "ZynExplore"
            TextSave        =   "ZynExplore"
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame1 
      Height          =   550
      Left            =   0
      TabIndex        =   2
      Top             =   1000
      Width           =   11295
      Begin VB.TextBox Text1 
         Height          =   350
         Left            =   840
         TabIndex        =   7
         Top             =   150
         Width           =   9255
      End
      Begin VB.CommandButton cmdGo 
         Caption         =   "Go"
         Default         =   -1  'True
         Height          =   350
         Left            =   10320
         TabIndex        =   3
         Top             =   135
         Width           =   735
      End
      Begin VB.Label Label1 
         Caption         =   "Address"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   210
         Width           =   735
      End
   End
   Begin SHDocVwCtl.WebBrowser WebBrowser1 
      Height          =   5775
      Left            =   0
      TabIndex        =   1
      Top             =   1560
      Width           =   11295
      ExtentX         =   19923
      ExtentY         =   10186
      ViewMode        =   0
      Offline         =   0
      Silent          =   0
      RegisterAsBrowser=   0
      RegisterAsDropTarget=   1
      AutoArrange     =   0   'False
      NoClientEdge    =   0   'False
      AlignLeft       =   0   'False
      NoWebView       =   0   'False
      HideFileNames   =   0   'False
      SingleClick     =   0   'False
      SingleSelection =   0   'False
      NoFolders       =   0   'False
      Transparent     =   0   'False
      ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
      Location        =   "http:///"
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   1035
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   11370
      _ExtentX        =   20055
      _ExtentY        =   1826
      ButtonWidth     =   1376
      ButtonHeight    =   1667
      Appearance      =   1
      ImageList       =   "ImageList1"
      DisabledImageList=   "ImageList2"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   5
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Back"
            Key             =   "Back"
            Object.Tag             =   "Back"
            ImageIndex      =   1
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   1
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Forward"
            Key             =   "Forward"
            Object.Tag             =   "Forward"
            ImageIndex      =   2
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   1
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Stop"
            Key             =   "Stop"
            Object.Tag             =   "Stop"
            ImageIndex      =   6
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Refresh"
            Key             =   "Refresh"
            Object.Tag             =   "Refresh"
            ImageIndex      =   5
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Home"
            ImageIndex      =   4
         EndProperty
      EndProperty
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   8400
         Top             =   120
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin MSComctlLib.ImageList ImageList2 
         Left            =   9120
         Top             =   0
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   45
         ImageHeight     =   43
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   2
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":1BE4
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":330E
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin MSComctlLib.ImageList ImageList1 
         Left            =   9960
         Top             =   0
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   45
         ImageHeight     =   43
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   6
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":5388
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":6AB2
               Key             =   ""
            EndProperty
            BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":8B2C
               Key             =   ""
            EndProperty
            BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":A67E
               Key             =   ""
            EndProperty
            BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":C2D8
               Key             =   ""
            EndProperty
            BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmMain.frx":DD9A
               Key             =   ""
            EndProperty
         EndProperty
      End
   End
   Begin VB.Menu nmeFile 
      Caption         =   "&File"
      Begin VB.Menu nmeNew 
         Caption         =   "New"
         Begin VB.Menu nmeWin 
            Caption         =   "Window"
            Shortcut        =   ^N
         End
      End
      Begin VB.Menu nmeOpen 
         Caption         =   "Open"
         Shortcut        =   ^O
      End
      Begin VB.Menu nmeSave 
         Caption         =   "Save As..."
      End
      Begin VB.Menu line2 
         Caption         =   "-"
      End
      Begin VB.Menu nmePsetup 
         Caption         =   "Page Setup"
      End
      Begin VB.Menu nmePrint 
         Caption         =   "Print"
      End
      Begin VB.Menu nmePview 
         Caption         =   "Print Preview"
      End
      Begin VB.Menu line 
         Caption         =   "-"
      End
      Begin VB.Menu nmeProp 
         Caption         =   "Properties"
      End
      Begin VB.Menu nmeOffline 
         Caption         =   "Work Offline"
      End
      Begin VB.Menu nmeExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu nmeEdit 
      Caption         =   "&Edit"
      Begin VB.Menu nmeCopy 
         Caption         =   "Copy"
      End
      Begin VB.Menu nmeSelAll 
         Caption         =   "Select All"
      End
      Begin VB.Menu nmePaste 
         Caption         =   "Paste"
      End
   End
   Begin VB.Menu nmeView 
      Caption         =   "&View"
      Begin VB.Menu nmeTool 
         Caption         =   "Toolbars"
         Begin VB.Menu nmeStan 
            Caption         =   "Standard Buttons"
            Checked         =   -1  'True
         End
      End
      Begin VB.Menu nmeSource 
         Caption         =   "Source"
      End
      Begin VB.Menu nmeFull 
         Caption         =   "FullScreen"
      End
   End
   Begin VB.Menu nmeFav 
      Caption         =   "&Favorites"
      Begin VB.Menu nmeAddFav 
         Caption         =   "Add Favorites"
         Index           =   0
      End
   End
   Begin VB.Menu nmeHelp 
      Caption         =   "&Help"
      Begin VB.Menu nmeHelpT 
         Caption         =   "Help Topics"
      End
      Begin VB.Menu nmeAbout 
         Caption         =   "About ZynExplore"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'autocomplete textbox
Private Const SHACF_AUTOAPPEND_FORCE_OFF = &H80000000
Private Const SHACF_AUTOAPPEND_FORCE_ON = &H40000000
Private Const SHACF_AUTOSUGGEST_FORCE_OFF = &H20000000
Private Const SHACF_AUTOSUGGEST_FORCE_ON = &H10000000
Private Const SHACF_DEFAULT = &H0
Private Const SHACF_FILESYSTEM = &H1
Private Const SHACF_URLHISTORY = &H2
Private Const SHACF_URLMRU = &H4
Private Const SHACF_USETAB = &H8
Private Const SHACF_URLALL = (SHACF_URLHISTORY Or SHACF_URLMRU)
Private Declare Sub SHAutoComplete Lib "shlwapi.dll" (ByVal hwndEdit As Long, ByVal dwFlags As Long)

'progress bar in status bar
Private Declare Function SetParent Lib "user32" _
        (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
Dim X As Integer
Dim Y As Integer
Dim myURL As String
Dim myCol As New Collection
Dim blnGoBack As Boolean
Dim blnGoForward As Boolean


Private Sub CmdGo_Click()
    'preventing unwanted runtime scriipting error
    WebBrowser1.Silent = True
    WebBrowser1.Navigate (text1.Text)
End Sub

Private Sub cmdGo_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    'set tooltip
    cmdGo.ToolTipText = "Go to " & "'' " & text1.Text & " ''"
End Sub

Private Sub Form_Load()
On Error Resume Next
Dim GetURL As String
    SHAutoComplete text1.hWnd, SHACF_DEFAULT
    WebBrowser1.Navigate "www.google.com"
    text1.Text = "www.google.com"
            
        'setparent
        SetParent ProgressBar1.hWnd, StatusBar1.hWnd
        ProgressBar1.Top = 55
        
        'position
        ProgressBar1.Left = StatusBar1.Panels(1).Width + 60
        
        
        ProgressBar1.Width = StatusBar1.Panels(2).Width - 50
        ProgressBar1.Height = StatusBar1.Height - 90
    
        'Just tested this one on favorites im getting lazy with this
        'try to continue this one put the favs on the dat file
        'GetURL = GetSetting(App.EXEName, "Favorites", "URL")
        'Load nmeAddFav(nmeAddFav.UBound + 1)
        'nmeAddFav(nmeAddFav.UBound).Caption = GetURL
        'nmeAddFav(nmeAddFav.UBound).Visible = True
    
End Sub


Private Sub nmeAbout_Click()
    frmAbout.Show
End Sub


Private Sub nmeAddFav_Click(Index As Integer)
    'add favs to runtime
    If nmeAddFav.Item(0) Then
        If MsgBox("Do you wish to add " & text1.Text & " to favorites?", vbOKCancel) = vbOK Then
            Load nmeAddFav(nmeAddFav.UBound + 1)
            nmeAddFav(nmeAddFav.UBound).Caption = text1.Text
            nmeAddFav(nmeAddFav.UBound).Tag = text1.Text
            nmeAddFav(nmeAddFav.UBound).Visible = True
        Else
            Exit Sub
        End If
        
    Else
            'MsgBox mnuSub(Index).Caption
            WebBrowser1.Navigate nmeAddFav(Index).Tag
    End If
End Sub

Private Sub nmeCopy_Click()
    'copy the page
    WebBrowser1.ExecWB OLECMDID_COPY, OLECMDEXECOPT_DODEFAULT
End Sub

Private Sub nmeExit_Click()
    Unload Me
End Sub

Private Sub nmeOffline_Click()
    'offline settings
    If nmeOffline.Checked = True Then
        nmeOffline.Checked = False
        WebBrowser1.Offline = False
    Else
        nmeOffline.Checked = True
        WebBrowser1.Offline = True
    End If
End Sub

Private Sub nmeOpen_Click()
    'open file
    CommonDialog1.Filter = "Web Page (*.html)|*.html|All File (*.*)|*.*"
    CommonDialog1.ShowOpen
    WebBrowser1.Navigate CommonDialog1.FileName
End Sub

'paste
Private Sub nmePaste_Click()
    WebBrowser1.ExecWB OLECMDID_PASTE, OLECMDEXECOPT_DODEFAULT
End Sub

'print
Private Sub nmePrint_Click()
    WebBrowser1.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_PROMPTUSER
End Sub

'page properties
Private Sub nmeProp_Click()
    WebBrowser1.ExecWB OLECMDID_PROPERTIES, OLECMDEXECOPT_DODEFAULT
End Sub

'page setup
Private Sub nmePsetup_Click()
    WebBrowser1.ExecWB OLECMDID_PAGESETUP, OLECMDEXECOPT_DODEFAULT
End Sub

'print preview
Private Sub nmePview_Click()
    WebBrowser1.ExecWB OLECMDID_PRINTPREVIEW, OLECMDEXECOPT_DODEFAULT
End Sub

'save
Private Sub nmeSave_Click()
    WebBrowser1.ExecWB OLECMDID_SAVEAS, OLECMDEXECOPT_DODEFAULT
End Sub

'select all
Private Sub nmeSelAll_Click()
    WebBrowser1.SetFocus
    WebBrowser1.ExecWB OLECMDID_SELECTALL, OLECMDEXECOPT_DODEFAULT
End Sub

'show source
Private Sub nmeSource_Click()
    frmSource.Show
End Sub

'new window
Private Sub nmeWin_Click()
Dim runApp As Double
    runApp = Shell(App.Path & "\" & App.EXEName)
End Sub

Private Sub text1_Click()
    'select all
    text1.SelStart = 0
    text1.SelLength = Len(text1.Text)
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
On Error Resume Next
Select Case Button.Index
    Case 1
        X = X + 1
        Y = Y - 1
        Toolbar1.Buttons(2).ButtonMenus.Add , , myCol.Item(X - 1)
        Toolbar1.Buttons(1).ButtonMenus.Remove (X - 1)
        blnGoBack = True
        WebBrowser1.GoBack
        blnGoBack = False
    Case 2
        X = X - 1
        Y = Y + 1
        Toolbar1.Buttons(1).ButtonMenus.Add , , myCol.Item(Y - 1)
        Toolbar1.Buttons(2).ButtonMenus.Remove (Y - 1)
        blnGoForward = True
        WebBrowser1.GoForward
        blnGoForward = False
    Case 3
        WebBrowser1.Stop
    Case 4
        WebBrowser1.Refresh
    Case 5
        WebBrowser1.Navigate "www.google.com.ph"
End Select
End Sub

Private Sub WebBrowser1_BeforeNavigate2(ByVal pDisp As Object, URL As Variant, Flags As Variant, TargetFrameName As Variant, PostData As Variant, Headers As Variant, Cancel As Boolean)
  
'you can add filters here. Sample you don't want the users to browse youtube
'so you include the keywords from below
If InStr(1, URL, ".avi") > 0 Or InStr(1, URL, ".wmv") > 0 Or InStr(1, URL, "youtube") Then
    MsgBox "Can not view this page"
    Cancel = True
End If

End Sub

Private Sub WebBrowser1_DocumentComplete(ByVal pDisp As Object, URL As Variant)
On Error Resume Next
    If (pDisp Is WebBrowser1.Application) Then

        Dim HTML As HTMLDocument 'Notice the changes here

        Dim AHREF As HTMLAnchorElement 'and Here

        Set HTML = WebBrowser1.Document 'Set the Doc to the HTML object

        For Each AHREF In HTML.links 'Take note when you type '.' look at all the goodies!

        'look in the AHREF object as well....

        'in this case we will use 2 different parts of the AHREF object to

        'filter out.. the href, and the innerText

            If InStr(AHREF.href, "google") = 0 And AHREF.innerText <> "Cached" Then

                'Debug.Print AHREF.href
                
                
            End If

        Next

    End If
    
        
      'prevent adding from the collection
      If blnGoBack Or blnGoForward Then Exit Sub
      
      Y = Y + 1
      X = X + 1
      myCol.Add text1.Text
      
      If X = 1 Then Exit Sub
      Toolbar1.Buttons(1).ButtonMenus.Add , , myCol.Item(X - 1)

      
End Sub


Private Sub WebBrowser1_NewWindow2(ppDisp As Object, Cancel As Boolean)
    'Here is a sample that grabs the new window and starts
    'a New Copy of the current form

    Dim frm As New frmMain  'Declare frm as a New copy of Form1

    frm.WebBrowser1.RegisterAsBrowser = True 'Register it with windows
    
    Set ppDisp = frm.WebBrowser1.object 'Set the ppDisp = to your new form

    frm.Show 'Display it

    'The new Webpage will load in a new instance of your form

End Sub

Private Sub WebBrowser1_CommandStateChange(ByVal Command As Long, ByVal Enable As Boolean)

    'back and forward buttons
    'disabling and enabling
    On Error Resume Next
    
    DoEvents: DoEvents: DoEvents
    If Enable = True And Command = CSC_NAVIGATEBACK Then

        Toolbar1.Buttons.Item(1).Enabled = True

    ElseIf Enable = False And Command = CSC_NAVIGATEBACK Then

        Toolbar1.Buttons.Item(1).Enabled = False

    End If

    If Enable = True And Command = CSC_NAVIGATEFORWARD Then

        Toolbar1.Buttons.Item(2).Enabled = True

    ElseIf Enable = False And Command = CSC_NAVIGATEFORWARD Then

        Toolbar1.Buttons.Item(2).Enabled = False

    End If
    
    'put the current location to the textbox
    text1.Text = WebBrowser1.LocationURL

End Sub

Private Sub WebBrowser1_ProgressChange(ByVal Progress As Long, ByVal ProgressMax As Long)
On Error Resume Next
    ProgressBar1.Max = ProgressMax
    ProgressBar1.Value = Progress

End Sub

Private Sub WebBrowser1_StatusTextChange(ByVal Text As String)
    'status bar
    StatusBar1.Panels.Item(1).Text = Text
End Sub


'auto resize/scale function for any screen resolution
Private Sub Form_Resize()
On Error Resume Next
     Me.WebBrowser1.Height = Me.Height - 2350
     Me.WebBrowser1.Width = Me.Width - 100
     StatusBar1.Panels(1).Width = Me.Width - 3650
     Frame1.Width = Me.Width - 120
     ProgressBar1.Left = StatusBar1.Panels(1).Width + 60
     text1.Width = Me.Width - 2220
     cmdGo.Left = text1.Width + 1185
End Sub

'change the title of the form
Private Sub WebBrowser1_TitleChange(ByVal Text As String)
    frmMain.Caption = "ZynExplore - " & Text
End Sub

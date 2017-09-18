Attribute VB_Name = "mdul_Main"
Public Const MAX_TOOLTIP As Integer = 64
Public Const NIF_ICON = &H2
Public Const NIF_MESSAGE = &H1
Public Const NIF_TIP = &H4
Public Const NIM_ADD = &H0
Public Const NIM_DELETE = &H2
Public Const WM_MOUSEMOVE = &H200
Public Const WM_LBUTTONDOWN = &H201
Public Const WM_LBUTTONUP = &H202
Public Const WM_LBUTTONDBLCLK = &H203
Public Const WM_RBUTTONDOWN = &H204
Public Const WM_RBUTTONUP = &H205
Public Const WM_RBUTTONDBLCLK = &H206

Type NOTIFYICONDATA
    cbSize           As Long
    hwnd             As Long
    uID              As Long
    uFlags           As Long
    uCallbackMessage As Long
    hIcon            As Long
    szTip            As String * MAX_TOOLTIP
End Type

Public Declare Function Shell_NotifyIcon Lib "shell32.dll" Alias "Shell_NotifyIconA" (ByVal dwMessage As Long, lpData As NOTIFYICONDATA) As Long

Public nfIconData As NOTIFYICONDATA
Public v_rsPhoneBook As Recordset
Public pSystemTrayOnly As Boolean
Public pPrintPageCount As Integer

Sub Main()
    If InStr(Command, FileName) > 0 Then
    
    Select Case UCase(Left(Command, 2))
        Case "/S"
            pSystemTrayOnly = True
    End Select
    
    End If
    
    With nfIconData
        .hwnd = frm_Main.hwnd
        .uID = frm_Main.Icon
        .uFlags = NIF_ICON Or NIF_MESSAGE Or NIF_TIP
        .uCallbackMessage = WM_MOUSEMOVE
        .hIcon = frm_Main.Icon.Handle
        .szTip = "Phone Book" & vbNullChar
        .cbSize = Len(nfIconData)
    End With
    Call Shell_NotifyIcon(NIM_ADD, nfIconData)
    
    If pSystemTrayOnly Then
        Exit Sub
    End If
    
    frm_Main.Show
End Sub

Public Sub MakePrintPreview(Optional m_PageNo As Integer)
    Dim v_rsPreview As New Recordset
    Dim v_sActiveConnection As String
    Dim v_iCurrentX, v_iCurrentY As Integer
    Dim v_iPageCount As Integer
    Dim v_iLoop As Integer

    On Error GoTo Err
    
    v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App.Path & "\PhoneBook.mdb"
    v_rsPreview.Open "SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, adOpenStatic
    
    frm_PrintPreview.tbx_Page.Text = "1"
    v_iPageCount = Abs(v_rsPreview.RecordCount / 63) + 1
    
    If m_PageNo = 0 Then
    
    pPrintPageCount = v_iPageCount
    For v_iLoop = 2 To v_iPageCount
        Load frm_PrintPreview.ppi_PageNo(v_iLoop)
        frm_PrintPreview.ppi_PageNo(v_iLoop).Caption = v_iLoop
        frm_PrintPreview.ppi_PageNo(v_iLoop).Visible = True
    Next v_iLoop
    
    End If
    
    With frm_PrintPreview
        .pic_Preview.Cls
        .pic_Preview.CurrentX = 1440
        .pic_Preview.CurrentY = 1800
        v_iCurrentX = 1440
        v_iCurrentY = 1800
        
        .pic_Preview.FontBold = True
        .pic_Preview.Print "First Name";
        .pic_Preview.CurrentX = 2940
        .pic_Preview.Print "Last Name";
        .pic_Preview.CurrentX = 5140
        .pic_Preview.Print "Telephone Number"
        
        .pic_Preview.FontBold = False
        
        If m_PageNo = 0 Then
        
        While Not v_rsPreview.EOF
            If v_iCurrentY >= (.pic_Preview.ScaleHeight) - 1800 Then
                v_iCurrentY = 1800
                Exit Sub
            End If
            
            v_iCurrentY = v_iCurrentY + .pic_Preview.TextHeight(v_rsPreview.Fields!FirstName)
            .pic_Preview.CurrentX = 1440
            .pic_Preview.Print v_rsPreview.Fields!FirstName;
            .pic_Preview.CurrentX = 2940
            .pic_Preview.Print v_rsPreview.Fields!LastName;
            .pic_Preview.CurrentX = 5140
            .pic_Preview.Print v_rsPreview.Fields!TelNo
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(Printer.ScaleWidth - v_iCurrentX + 60, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(2860, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(5060, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            v_rsPreview.MoveNext
        Wend
        
        Else
        
        v_rsPreview.Move ((m_PageNo - 1) * 63)
        While Not v_rsPreview.EOF
            If v_iCurrentY >= (.pic_Preview.ScaleHeight) - 1800 Then
                v_iCurrentY = 1800
                Exit Sub
            End If
            
            v_iCurrentY = v_iCurrentY + .pic_Preview.TextHeight(v_rsPreview.Fields!FirstName)
            .pic_Preview.CurrentX = 1440
            .pic_Preview.Print v_rsPreview.Fields!FirstName;
            .pic_Preview.CurrentX = 2940
            .pic_Preview.Print v_rsPreview.Fields!LastName;
            .pic_Preview.CurrentX = 5140
            .pic_Preview.Print v_rsPreview.Fields!TelNo
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(Printer.ScaleWidth - v_iCurrentX + 60, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(2860, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            .pic_Preview.Line (v_iCurrentX - 60, v_iCurrentY)-(5060, v_iCurrentY + Printer.TextHeight(v_rsPreview.Fields!FirstName)), , B
            v_rsPreview.MoveNext
        Wend
        
        End If
    End With
    Exit Sub

Err:
    MsgBox Err.Description, vbCritical
End Sub

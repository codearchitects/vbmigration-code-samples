VERSION 5.00
Begin VB.Form frmMain 
   BackColor       =   &H00D0D0D0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "AldInvaders 2.0"
   ClientHeight    =   6570
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5775
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6570
   ScaleWidth      =   5775
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer tmrBulletsMove 
      Interval        =   30
      Left            =   3120
      Top             =   6120
   End
   Begin VB.CommandButton cmdStart 
      Caption         =   "Start"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4440
      TabIndex        =   0
      Top             =   620
      Width           =   735
   End
   Begin VB.Timer TmrRk 
      Interval        =   50
      Left            =   3000
      Top             =   6000
   End
   Begin VB.Timer tmrMonster 
      Enabled         =   0   'False
      Interval        =   50
      Left            =   2880
      Top             =   5880
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   8
      Left            =   6000
      Picture         =   "frmMain.frx":038A
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   7
      Left            =   6060
      Picture         =   "frmMain.frx":1054
      Top             =   6000
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   6
      Left            =   6060
      Picture         =   "frmMain.frx":1D1E
      Top             =   5460
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   5
      Left            =   6060
      Picture         =   "frmMain.frx":29E8
      Top             =   4920
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   4
      Left            =   6060
      Picture         =   "frmMain.frx":36B2
      Top             =   4380
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   3
      Left            =   6060
      Picture         =   "frmMain.frx":437C
      Top             =   3780
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   2
      Left            =   6060
      Picture         =   "frmMain.frx":5046
      Top             =   3180
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   1
      Left            =   6060
      Picture         =   "frmMain.frx":5D10
      Top             =   2580
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   0
      Left            =   6060
      Picture         =   "frmMain.frx":69DA
      Top             =   2040
      Width           =   480
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   3
      Left            =   3600
      Picture         =   "frmMain.frx":76A4
      Top             =   6240
      Width           =   240
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   2
      Left            =   2640
      Picture         =   "frmMain.frx":7A2E
      Stretch         =   -1  'True
      Top             =   480
      Width           =   300
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   1
      Left            =   2400
      Picture         =   "frmMain.frx":86F8
      Stretch         =   -1  'True
      Top             =   480
      Width           =   300
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   0
      Left            =   2160
      Picture         =   "frmMain.frx":93C2
      Stretch         =   -1  'True
      Top             =   480
      Width           =   300
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00D0FAD0&
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   390
      Left            =   2160
      TabIndex        =   6
      Top             =   450
      Width           =   795
   End
   Begin VB.Label lblLevel 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00C0E0FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "000"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   285
      Left            =   3240
      TabIndex        =   5
      Top             =   60
      Width           =   435
   End
   Begin VB.Label lblPoints 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "000.000.000"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   285
      Left            =   780
      TabIndex        =   4
      Top             =   90
      Width           =   1155
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "ASTRONAVI"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   2
      Left            =   960
      TabIndex        =   3
      Top             =   540
      Width           =   1155
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "PUNTI"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   675
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "LIVELLO"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   2340
      TabIndex        =   1
      Top             =   120
      Width           =   855
   End
   Begin VB.Image K 
      Height          =   240
      Index           =   0
      Left            =   3960
      Picture         =   "frmMain.frx":A08C
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image MI 
      Height          =   240
      Index           =   1
      Left            =   4020
      Picture         =   "frmMain.frx":A416
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image MI 
      Height          =   240
      Index           =   0
      Left            =   3840
      Picture         =   "frmMain.frx":A7A0
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image Image1 
      Height          =   990
      Left            =   4320
      Picture         =   "frmMain.frx":AB2A
      Top             =   0
      Width           =   1500
   End
   Begin VB.Image M 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   2640
      Top             =   5880
      Width           =   240
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   2
      Left            =   3660
      Picture         =   "frmMain.frx":B80E
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   1
      Left            =   3660
      Picture         =   "frmMain.frx":BB98
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   0
      Left            =   3540
      Picture         =   "frmMain.frx":BF22
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image SH 
      Height          =   480
      Left            =   2640
      Picture         =   "frmMain.frx":C2AC
      Top             =   5340
      Width           =   480
   End
   Begin VB.Shape Shape1 
      FillStyle       =   0  'Solid
      Height          =   4875
      Left            =   60
      Top             =   960
      Width           =   5655
   End
   Begin VB.Image M 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   2640
      Picture         =   "frmMain.frx":CF76
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   2400
      Picture         =   "frmMain.frx":D300
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   2160
      Picture         =   "frmMain.frx":D68A
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   1920
      Picture         =   "frmMain.frx":DA14
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   1680
      Picture         =   "frmMain.frx":DD9E
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   1440
      Picture         =   "frmMain.frx":E128
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   1140
      Picture         =   "frmMain.frx":E4B2
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   900
      Picture         =   "frmMain.frx":E83C
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   660
      Picture         =   "frmMain.frx":EBC6
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   420
      Picture         =   "frmMain.frx":EF50
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   180
      Picture         =   "frmMain.frx":F2DA
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   2400
      Picture         =   "frmMain.frx":F664
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   2160
      Picture         =   "frmMain.frx":F9EE
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   1920
      Picture         =   "frmMain.frx":FD78
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   1680
      Picture         =   "frmMain.frx":10102
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   1440
      Picture         =   "frmMain.frx":1048C
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   1140
      Picture         =   "frmMain.frx":10816
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   900
      Picture         =   "frmMain.frx":10BA0
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   660
      Picture         =   "frmMain.frx":10F2A
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   420
      Picture         =   "frmMain.frx":112B4
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   180
      Picture         =   "frmMain.frx":1163E
      Top             =   5940
      Width           =   240
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim An As Integer
Dim AnM As Integer
Dim MM As Integer
Dim POmx As Integer
Dim POmn As Integer
Dim TP As Long
Dim TiIn As Integer
Dim finito As Boolean

Private Type Pannello
    Lives As Integer
    Level As Integer
    Points As Long
End Type

Dim Pnl As Pannello

Const MAXBombe = 10
Const MONperRIGA = 11

Dim GMC(0 To 3, 0 To MONperRIGA) As Collection
Dim TMC As Collection

Dim Colpo As Boolean

Private Sub Form_Load()
    Dim i As Integer
    Dim J As Integer
    Dim Z As Integer
    Dim Y As Integer
    
    Colpo = False
    For J = 0 To 3
        For i = 0 To MONperRIGA
            Set GMC(J, i) = New Collection
        Next
    Next
    
    Shape1.Left = 60
    Height = Shape1.Height + Shape1.Top + 440
    
    For Y = 0 To 3
        For J = 0 To MONperRIGA
            Z = M.UBound + 1
            For i = 0 To 4
                Load M(Z + i)
            Next
        Next
    Next

    For i = 1 To 10
        Load K(i)
        K(i).Visible = False
        Set K(i).Picture = MI(0).Picture
    Next

    Shape1.ZOrder 1

    '------------------------------------
    ' Imposta i limiti (dx e sx)
    '------------------------------------
    POmx = Shape1.Left + Shape1.Width - 400
    POmn = Shape1.Left + 200

    SH.Top = Shape1.Top + Shape1.Height - SH.Height
    SH.Left = Shape1.Width / 2 - SH.Width / 2

    Resetta
    azzera

End Sub

Private Sub azzera()
    Dim T As Integer
    Dim Z As Integer
    Dim Y As Integer
    Dim X As Integer
    Dim L As Integer
    Dim J As Integer
    Dim i As Integer
        
    T = Shape1.Top + A(0).Height + 300
    
    Z = 2
    For Y = 0 To 3
        X = 0
        L = Shape1.Left + A(0).Width * 2 + 45
        For J = 0 To MONperRIGA
            Set TMC = Nothing
            Set TMC = New Collection
            For i = 0 To 4
                Select Case Y
                    Case Is = 0: Set M(Z + i).Picture = A(i).Picture
                    Case Is = 1: Set M(Z + i).Picture = B(i).Picture
                    Case Is = 2: Set M(Z + i).Picture = C(i).Picture
                    Case Is = 3: Set M(Z + i).Picture = D(i).Picture
                End Select
                M(Z + i).Visible = False
                M(Z + i).Top = T
                M(Z + i).Left = L
                TMC.Add M(Z + i), "M" & Y & Right("0" & Trim(CStr(X)), 2)
                X = X + 1
            Next
            Z = Z + 5
            L = L + A(0).Width + 60
            Set GMC(Y, J) = TMC
        Next
        T = T + A(0).Height + 15
    Next
    Set TMC = Nothing
    
    An = 0
    AnM = -1
    MM = 30
    
    TP = Shape1.Top + A(0).Height + 300
    GameGo

End Sub

Private Sub Resetta()
    Dim J As Integer
    Pnl.Points = 0
    Pnl.Level = 1
    Pnl.Lives = 3
    Set SH.Picture = SE(8).Picture
    For J = 0 To 2
        Lives(J).Visible = True
    Next
    finito = False
    LevelSetting
End Sub

Private Sub cmdStart_Click()
    Resetta
    azzera
    tmrMonster.Enabled = True
End Sub

Private Sub cmdStart_KeyPress(KeyAscii As Integer)
    getmov KeyAscii
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    getmov KeyAscii
End Sub

Private Sub getmov(KeyAscii As Integer)
    If tmrMonster.Enabled Then
        Select Case KeyAscii
            Case 52, 122, 44
                SH.Left = SH.Left - 60
                If SH.Left < Shape1.Left Then
                    SH.Left = SH.Left + 60
                End If
            Case 54, 120, 46
                SH.Left = SH.Left + 60
                If SH.Left + SH.Width > Shape1.Left + Shape1.Width Then
                    SH.Left = SH.Left - 60
                End If
            Case 32, 56
                ' spara
                If Colpo = False Then
                    R(2).Top = SH.Top - R(2).Height
                    R(2).Left = SH.Left + (SH.Width / 2 - R(2).Width / 2)
                    Colpo = True
                End If
        End Select
    End If
End Sub

Private Sub Image1_Click()
    MsgBox "Se questo giochino ti è piacito scrivimi all'indirizzo:" & vbCrLf & vbCrLf & "If you like this game you can email me at:" & vbCrLf & vbCrLf & "aldus@email.it"
End Sub

Private Sub tmrBulletsMove_Timer()
    Dim i As Integer
    Dim Y As Integer
    Dim J As Integer
    Dim Z As Integer
    Dim NM As String
    Dim NM2 As String
    Dim ME1 As Integer
    Dim ME2 As Integer
    Dim TT As Single
    
    tmrBulletsMove.Enabled = False
    '--------------------------------
    ' Rende invisibili le ev. bombe
    '--------------------------------
    For i = 0 To MAXBombe
        If K(i).Visible = True Then
            K(i).Tag = "V"
            K(i).Visible = False
        End If
    Next
    '--------------------------------
    ' GESTISCE IL COLPO
    '--------------------------------
    If Colpo Then
        R(2).Visible = False
        R(2).Top = R(2).Top - R(2).Height / 2
        If R(2).Top < Shape1.Top + 30 Then
            Colpo = False
        Else
            R(2).Visible = True
        End If
    End If
    
    '------------------------------------------
    ' incrementa posizione orizzontale degli M
    '------------------------------------------
    For Y = 0 To 3
        Z = An
        For i = 0 To MONperRIGA
            NM = "M" & Y & Right("0" & Trim(CStr(Z)), 2)
            If Not (GMC(Y, i).Item(NM).Picture Is M(1).Picture) Then
                
                If Colpo Then
                    If (R(2).Top + A(0).Height) > TP Then
                        If (R(2).Left + 90) >= GMC(Y, i).Item(NM).Left And (R(2).Left + R(2).Width - 90) <= (GMC(Y, i).Item(NM).Left + A(0).Width) Then
                            ' è in range di larghezza
                            If (R(2).Top >= GMC(Y, i).Item(NM).Top) And (R(2).Top <= (GMC(Y, i).Item(NM).Top + A(0).Height - 30)) Then
                                ' colpito!
                                ' definire le 5 immagini da eliminare...
                                ME1 = Z
                                Do
                                    If ME1 / 5 = Int(ME1 / 5) Then Exit Do
                                    ME1 = ME1 - 1
                                Loop
                                For ME2 = ME1 To ME1 + 4
                                    NM2 = "M" & Y & Right("0" & Trim(CStr(ME2)), 2)
                                    Set GMC(Y, i).Item(NM2).Picture = M(1).Picture
                                Next
                                
                                Pnl.Points = Pnl.Points + ((4 - Y) * 15)

                                Colpo = False
                                R(2).Visible = False
                            End If
                        End If
                    End If
                End If
            End If
            Z = Z + 5
        Next
    Next
   
    '--------------------------------
    ' Sposta e visualizza le ev. bombe
    '--------------------------------
    Y = 0
    For i = 0 To MAXBombe
        If K(i).Tag = "V" Then
            K(i).Top = K(i).Top + (K(i).Height / 4)
            K(i).Tag = "R"
            If K(i).Top < (Shape1.Top + Shape1.Height) Then
                K(i).Visible = True
                If (K(i).Left + 80 >= (SH.Left + 90)) And ((K(i).Left + K(i).Width - 80) <= ((SH.Left + SH.Width) - 60)) Then
                    ' colpo in range orizz. con l'astronave
                    If ((K(i).Top + K(i).Height) - 20) >= SH.Top Then
                        ' ASTRONAVE COLPITA!
                        Y = i
                    End If
                End If
            Else
                K(i).Tag = ""
            End If
        End If
    Next
    
    If Y > 0 And finito = False Then
        For J = 2 To 0 Step -1
            If Lives(J).Visible Then
                K(Y).Tag = ""
                K(Y).Visible = False
                Lives(J).Visible = False
                For Z = 0 To 7
                    Set SH.Picture = SE(Z).Picture
                    TT = Timer + 0.1
                    Do
                        If Timer > TT Then
                            Exit Do
                        End If
                    Loop
                    DoEvents
                Next
                TT = Timer + 1
                Do
                    If Timer > TT Then
                        Exit Do
                    End If
                Loop
                DoEvents
                Exit For
            End If
        Next
        If J = 0 Then
            ' FINITE LE VITE!
            Set SH.Picture = SE(7).Picture
            finito = True
            tmrMonster.Enabled = False
            MsgBox "Spiacente, hai toppato."
        Else
            Set SH.Picture = SE(8).Picture
        End If
    End If
    tmrBulletsMove.Enabled = True

End Sub

Private Sub tmrMonster_Timer()
    Dim B As Integer

    tmrMonster.Enabled = False
    
    If finito Then Exit Sub
    
    B = GameGo
    If B = 1 Then
        tmrMonster.Enabled = True
    ElseIf B = -1 Then
        MsgBox "INVASION!"
    Else
        MsgBox "GOOD JOB!"
        Pnl.Level = Pnl.Level + 1
        LevelSetting
        azzera
        tmrMonster.Enabled = True
    End If
    
End Sub

Private Function GameGo() As Integer
    Dim L As Integer
    Dim i As Integer
    Dim J As Integer
    Dim NM As String
    
    Dim FH(0 To 3) As Integer
    Dim LH(0 To 3) As Integer
    
    Dim T As Integer
    Dim Z As Integer
    Dim Y As Integer
    
    Dim Lc1 As Integer
    Dim ME1 As Integer
    Dim ME2 As Integer
    Dim NM2 As String
    Dim CT As Boolean
    Dim MR As Integer
    Dim XMR As Integer
    Dim XMM As Integer
    Dim MT As Integer
    
    Dim RN1 As Integer
    Dim RN2 As Integer
    
    '--------------------------------
    ' Rende invisibili gli M attuali
    '--------------------------------
    MR = 0: XMR = ((MONperRIGA + 1) * 4)
    For Y = 0 To 3
        FH(Y) = -1
        J = An
        For i = 0 To MONperRIGA
            NM = "M" & Y & Right("0" & Trim(CStr(J)), 2)
            If Not (GMC(Y, i).Item(NM).Picture Is M(1).Picture) Then
                If FH(Y) < 0 Then FH(Y) = GMC(Y, i).Item(NM).Left
                GMC(Y, i).Item(NM).Visible = False
                LH(Y) = GMC(Y, i).Item(NM).Left
                MR = MR + 1
            End If
            J = J + 5
        Next
    Next
    XMR = (XMR - MR)
    
    '-----------------------
    ' Controlla esistenza M
    '-----------------------
    If MR < 1 Then
        GameGo = 0
        Exit Function
    End If
    
    '-----------------------------------
    ' incrementa contatore animazione M
    '-----------------------------------
    An = An + AnM
    If (An > 4) Or (An < 0) Then
        AnM = -AnM
        An = (An + (AnM * 2))
    End If
    
    '----------------------------------------------
    ' controlla se si è raggiunto il limite minimo
    ' o il limite massimo, dipendentemente dalla
    ' direzione dei M
    '----------------------------------------------
    J = 0
    XMM = CInt(XMR * 1.5)
    Select Case MM
        Case Is < 0
            XMM = -XMM
            ' vanno verso sinistra
            '----------------------
            'trova il più vicino a sinistra
            L = POmx
            For i = 0 To 3
                If (FH(i) < L) And (FH(i) > 0) Then L = FH(i)
            Next
            ' controlla limite sinistro
            If L + MM < POmn Then
                J = 1
            End If
        Case Else
            ' vanno verso destra
            '----------------------
            'trova il più vicino a destra
            L = POmn
            For i = 0 To 3
                If (LH(i) > L) And (LH(i) > 0) Then L = LH(i)
            Next
            ' controlla limite destro
            If L + MM > POmx Then
                J = 1
            End If
    End Select
    
    TiIn = ((11 - Pnl.Level) * 10) + MR
    tmrMonster.Interval = TiIn
    
    If J Then
        ' se si è raggiunto un limite,
        ' cambia la direzione di marcia
        ' e incrementa il TOP
        MM = -MM

        TP = TP + A(0).Height / 3
    End If
    T = TP
    
    '------------------------------------------
    ' incrementa posizione orizzontale degli M
    '------------------------------------------
    Randomize Timer
    RN1 = Int(Rnd * (255 - (XMR * 2.5))) + 1
    For Y = 0 To 3
        Z = An
        For i = 0 To MONperRIGA
            For J = 1 To GMC(Y, i).Count
                Lc1 = GMC(Y, i).Item(J).Left + (MM + XMM)
                GMC(Y, i).Item(J).Left = Lc1
                GMC(Y, i).Item(J).Top = T
            Next
            NM = "M" & Y & Right("0" & Trim(CStr(Z)), 2)
            If Not (GMC(Y, i).Item(NM).Picture Is M(1).Picture) Then
                
                GMC(Y, i).Item(NM).Visible = True
                MT = GMC(Y, i).Item(NM).Top
                
                RN2 = Int(Rnd * (255 - (XMR * 2.5))) + 1
                If RN2 = RN1 Then
                    For RN1 = 0 To CInt(MAXBombe - (XMR / 8))
                        If K(RN1).Tag = "" Then
                            K(RN1).Tag = "V"
                            K(RN1).Top = GMC(Y, i).Item(NM).Top + GMC(Y, i).Item(NM).Height + 15
                            K(RN1).Left = GMC(Y, i).Item(NM).Left
                            Exit For
                        End If
                    Next
                End If
            End If
            Z = Z + 5
        Next
        T = T + A(0).Height + 15
    Next
    
    '----------------------------
    ' controlla se hanno invaso!
    '----------------------------
    If MT > (SH.Top - A(0).Height) Then
        GameGo = -1
    Else
        GameGo = 1
    End If

End Function

Private Sub TmrRk_Timer()
    ' anima il rocket sparato dalla ship
    If R(2).Picture Is R(0).Picture Then
        Set R(2).Picture = R(1).Picture
    ElseIf R(2).Picture Is R(1).Picture Then
        Set R(2).Picture = R(3).Picture
    Else
        Set R(2).Picture = R(0).Picture
    End If
    Dim i As Integer
   
    ' anima le bombe lanciate dai M
    For i = 0 To MAXBombe
        If K(i).Visible Or K(i).Tag = "V" Then
            If K(i).Picture Is MI(1).Picture Then
                Set K(i).Picture = MI(0).Picture
            Else
                Set K(i).Picture = MI(1).Picture
            End If
        End If
    Next
    
    '----------------------------
    ' Aggiorna il pannello
    '----------------------------
    lblPoints.Caption = Pnl.Points
    lblLevel.Caption = Pnl.Level

End Sub

Sub LevelSetting()
    '----------------------------
    ' Aggiorna il timer
    '----------------------------
    TiIn = ((11 - Pnl.Level) * 10) + 50
    tmrMonster.Interval = TiIn
End Sub



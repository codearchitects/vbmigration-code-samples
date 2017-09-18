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
      Left            =   240
      TabIndex        =   0
      Top             =   720
      Width           =   735
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   3.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   165
      Left            =   600
      TabIndex        =   7
      Text            =   "Text1"
      Top             =   720
      Width           =   135
   End
   Begin VB.Image Image1 
      Height          =   855
      Left            =   60
      Picture         =   "frmMain.frx":038A
      Top             =   -60
      Width           =   1155
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   3
      Left            =   3600
      Picture         =   "frmMain.frx":12AC
      Top             =   6240
      Width           =   240
   End
   Begin VB.Image K 
      Height          =   240
      Index           =   0
      Left            =   3960
      Picture         =   "frmMain.frx":1636
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image MI 
      Height          =   240
      Index           =   1
      Left            =   4020
      Picture         =   "frmMain.frx":19C0
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image MI 
      Height          =   240
      Index           =   0
      Left            =   3840
      Picture         =   "frmMain.frx":1D4A
      Top             =   5940
      Width           =   240
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
      Picture         =   "frmMain.frx":20D4
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   1
      Left            =   3660
      Picture         =   "frmMain.frx":245E
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image R 
      Height          =   240
      Index           =   0
      Left            =   3540
      Picture         =   "frmMain.frx":27E8
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image M 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   2640
      Picture         =   "frmMain.frx":2B72
      Top             =   6120
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   2400
      Picture         =   "frmMain.frx":2EFC
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   2160
      Picture         =   "frmMain.frx":3286
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   1920
      Picture         =   "frmMain.frx":3610
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   1680
      Picture         =   "frmMain.frx":399A
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image D 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   1440
      Picture         =   "frmMain.frx":3D24
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   1140
      Picture         =   "frmMain.frx":40AE
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   900
      Picture         =   "frmMain.frx":4438
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   660
      Picture         =   "frmMain.frx":47C2
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   420
      Picture         =   "frmMain.frx":4B4C
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image C 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   180
      Picture         =   "frmMain.frx":4ED6
      Top             =   6180
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   2400
      Picture         =   "frmMain.frx":5260
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   2160
      Picture         =   "frmMain.frx":55EA
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   1920
      Picture         =   "frmMain.frx":5974
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   1680
      Picture         =   "frmMain.frx":5CFE
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image B 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   1440
      Picture         =   "frmMain.frx":6088
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   4
      Left            =   1140
      Picture         =   "frmMain.frx":6412
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   3
      Left            =   900
      Picture         =   "frmMain.frx":679C
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   2
      Left            =   660
      Picture         =   "frmMain.frx":6B26
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   1
      Left            =   420
      Picture         =   "frmMain.frx":6EB0
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image A 
      Appearance      =   0  'Flat
      Height          =   240
      Index           =   0
      Left            =   180
      Picture         =   "frmMain.frx":723A
      Top             =   5940
      Width           =   240
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   8
      Left            =   6000
      Picture         =   "frmMain.frx":75C4
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   7
      Left            =   6060
      Picture         =   "frmMain.frx":828E
      Top             =   6000
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   6
      Left            =   6060
      Picture         =   "frmMain.frx":8F58
      Top             =   5460
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   5
      Left            =   6060
      Picture         =   "frmMain.frx":9C22
      Top             =   4920
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   4
      Left            =   6060
      Picture         =   "frmMain.frx":A8EC
      Top             =   4380
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   3
      Left            =   6060
      Picture         =   "frmMain.frx":B5B6
      Top             =   3780
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   2
      Left            =   6060
      Picture         =   "frmMain.frx":C280
      Top             =   3180
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   1
      Left            =   6060
      Picture         =   "frmMain.frx":CF4A
      Top             =   2580
      Width           =   480
   End
   Begin VB.Image SE 
      Height          =   480
      Index           =   0
      Left            =   6060
      Picture         =   "frmMain.frx":DC14
      Top             =   2040
      Width           =   480
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   2
      Left            =   3840
      Picture         =   "frmMain.frx":E8DE
      Stretch         =   -1  'True
      Top             =   480
      Width           =   300
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   1
      Left            =   3600
      Picture         =   "frmMain.frx":F5A8
      Stretch         =   -1  'True
      Top             =   480
      Width           =   300
   End
   Begin VB.Image Lives 
      Height          =   300
      Index           =   0
      Left            =   3360
      Picture         =   "frmMain.frx":10272
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
      Left            =   3360
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
      Left            =   4740
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
      Left            =   2280
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
      Left            =   2160
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
      Left            =   1620
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
      Left            =   3840
      TabIndex        =   1
      Top             =   120
      Width           =   855
   End
   Begin VB.Image SH 
      Height          =   480
      Left            =   2640
      Picture         =   "frmMain.frx":10F3C
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
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'--------------------------------------------------------------------
' Ald Win Invaders v.2.0 FreeWare
'--------------------------------------------------------------------
' Author: Aldo Prinzi (Milan/Italy) e.mail:aprinzi@tiscalinet.it
' Date  : July 2001
'--------------------------------------------------------------------
' My v.1.0 version of the game (Ald Invaders) was written in 1993 in
' Ms-Quick Basic to demonstrate the use of sprites in that language,
' that were freely distribute by microsoft on all the older version
' of Ms-Windows.
' That version where already freeware, but the distribution will be
' poor due to the minimal use of internet in Italy for that year.
'
' This version was written to demonstrate other things about the use
' of a Smart Card with a program written in Visual Basic (WPC 2001).
' Since the actual version have none to do with Smart Card many
' friends, who knows the v1.0, ask to get this version.
' And I will be happy to share it with all who like Space Invaders.
'
' This is only a demonstration software freely distributed on an
' AS-IS basis. I can't know if it will work on any system or version
' of Visual Basic. It was written on VB 6.0 SP5 wit Windows 2K Sp2.
'--------------------------------------------------------------------
' SPACE INVADERS is one of best and ancient videogame on the earth.
' It was written by Toshihiro Nishikado for TAITO corporation in 1978.
' This version is not a really clone, but a game who recall the
' original idea with some differences (that is for trademark purpose)
' Hope you like it.
' July 2001,
' Aldo Prinzi.
'--------------------------------------------------------------------
' "Microsoft", "Microsoft Windows" and "Microsoft Visual Basic"
' are trademark of Microsoft corp. - Redmond- USA
'
' "TAITO" and the name "Space Invaders" are trademark of TAITO Corp.
'--------------------------------------------------------------------

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

Dim GMC(0 To 3) As Collection
Dim TMC As Collection

Dim Colpo As Boolean

Private Sub Form_Load()
    Dim I As Integer
    Dim J As Integer
    Dim Z As Integer
    Dim Y As Integer
    
    Colpo = False
    
    Shape1.Left = 60
    Height = Shape1.Height + Shape1.Top + 440
    
    For Y = 0 To 3
        For J = 0 To MONperRIGA
            Z = M.UBound + 1
            Load M(Z)
        Next
    Next

    For I = 1 To 10
        Load K(I)
        K(I).Visible = False
        Set K(I).Picture = MI(0).Picture
    Next

    Shape1.ZOrder 1

    '------------------------------------
    ' Imposta i limiti (dx e sx)
    '------------------------------------
    POmx = Shape1.Left + Shape1.Width - 400
    POmn = Shape1.Left + 200

    SH.Top = Shape1.Top + Shape1.Height - SH.Height
    SH.Left = Shape1.Width / 2 - SH.Width / 2

    azzera
    Resetta

End Sub

Private Sub azzera()
    Dim mnTop As Integer
    Dim mnLeft As Integer
    Dim nrRiga As Integer
    Dim nrMonst As Integer
    Dim nrImg As Integer
    
    mnTop = Shape1.Top + A(0).Height + 300
    nrImg = 2
    For nrRiga = 0 To 3
        mnLeft = Shape1.Left + A(0).Width * 2 + 45
        Set GMC(nrRiga) = Nothing
        Set GMC(nrRiga) = New Collection
        Select Case nrRiga
            Case Is = 0: Set M(nrImg).Picture = A(0).Picture
            Case Is = 1: Set M(nrImg).Picture = B(0).Picture
            Case Is = 2: Set M(nrImg).Picture = C(0).Picture
            Case Is = 3: Set M(nrImg).Picture = D(0).Picture
        End Select
        For nrMonst = 0 To MONperRIGA
            With M(nrImg)
                .Visible = True
                .Top = mnTop
                .Left = mnLeft
                .Tag = "V"
            End With
            GMC(nrRiga).Add M(nrImg), "M" & Right("0" & Trim(CStr(nrMonst)), 2)
            mnLeft = mnLeft + A(0).Width + 60
            nrImg = nrImg + 1
        Next
        mnTop = mnTop + A(0).Height + 15
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
    Dim I As Integer
    
    Pnl.Points = 0
    Pnl.Level = 1
    Pnl.Lives = 3
    Set SH.Picture = SE(8).Picture
    For J = 0 To 2
        Lives(J).Visible = True
    Next
    finito = False
    LevelSetting
    For I = 0 To 3
        For J = 1 To GMC(I).Count
            With GMC(I).Item(J)
                .Visible = True
                .Tag = "V"
            End With
        Next
    Next
End Sub

Private Sub cmdStart_Click()
    Text1.SetFocus
    Resetta
    azzera
    tmrMonster.Enabled = True
End Sub

Private Sub Text1_KeyDown(KeyCode As Integer, Shift As Integer)
    getmov KeyCode
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    getmov KeyCode
End Sub

Private Sub cmdStart_KeyDown(KeyCode As Integer, Shift As Integer)
    getmov KeyCode
End Sub

Private Sub getmov(KeyCode As Integer)
    If tmrMonster.Enabled Then
        Select Case KeyCode
            Case vbKeyLeft
                SH.Left = SH.Left - 60
                If SH.Left < Shape1.Left Then
                    SH.Left = SH.Left + 60
                End If
            Case vbKeyRight
                SH.Left = SH.Left + 60
                If SH.Left + SH.Width > Shape1.Left + Shape1.Width Then
                    SH.Left = SH.Left - 60
                End If
            Case vbKeyUp, vbKeySpace
                ' spara
                If Colpo = False Then
                    R(2).Top = SH.Top - R(2).Height
                    R(2).Left = SH.Left + (SH.Width / 2 - R(2).Width / 2)
                    Colpo = True
                End If
        End Select
    End If
End Sub

Private Sub tmrBulletsMove_Timer()
    Dim I As Integer
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
    For I = 0 To MAXBombe
        If K(I).Visible = True Then
            K(I).Tag = "V"
            K(I).Visible = False
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
    ' Controlla se è stato colpito un M
    '------------------------------------------
    For Y = 0 To 3
        Z = 0
        For I = 0 To MONperRIGA
            NM = "M" & Right("0" & Trim(CStr(I)), 2)
            With GMC(Y).Item(NM)
                If .Tag = "V" Then
                    
                    If Colpo Then
                        If (R(2).Top + A(0).Height) > TP Then
                            If (R(2).Left + 90) >= .Left And (R(2).Left + R(2).Width - 90) <= (.Left + A(0).Width) Then
                                ' è in range di larghezza
                                If (R(2).Top >= .Top) And (R(2).Top <= (.Top + A(0).Height - 30)) Then
                                    ' colpito!
                                    ' definire le 5 immagini da eliminare...
                                    ME1 = Z
                                    Do
                                        If ME1 / 5 = Int(ME1 / 5) Then Exit Do
                                        ME1 = ME1 - 1
                                    Loop
                                    For ME2 = ME1 To ME1 + 4
                                        NM2 = "M" & Y & Right("0" & Trim(CStr(ME2)), 2)
                                        .Tag = "M"
                                        .Visible = False
                                    Next
                                    
                                    Pnl.Points = Pnl.Points + ((4 - Y) * 15)
    
                                    Colpo = False
                                    R(2).Visible = False
                                End If
                            End If
                        End If
                    End If
                End If
            End With
            Z = Z + 1
        Next
    Next
   
    '--------------------------------
    ' Sposta e visualizza le ev. bombe
    '--------------------------------
    Y = 0
    For I = 0 To MAXBombe
        If K(I).Tag = "V" Then
            K(I).Top = K(I).Top + (K(I).Height / 4)
            K(I).Tag = "R"
            If K(I).Top < (Shape1.Top + Shape1.Height) Then
                K(I).Visible = True
                If (K(I).Left + 80 >= (SH.Left + 90)) And ((K(I).Left + K(I).Width - 80) <= ((SH.Left + SH.Width) - 60)) Then
                    ' colpo in range orizz. con l'astronave
                    If ((K(I).Top + K(I).Height) - 20) >= SH.Top Then
                        ' ASTRONAVE COLPITA!
                        Y = I
                    End If
                End If
            Else
                K(I).Tag = ""
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
        Text1.Text = ""
        Pnl.Level = Pnl.Level + 1
        LevelSetting
        azzera
        tmrMonster.Enabled = True
    End If
    
End Sub

Private Function GameGo() As Integer
    Dim L As Integer
    Dim I As Integer
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
        J = 0
        For I = 0 To MONperRIGA
            NM = "M" & Right("0" & Trim(CStr(J)), 2)
            With GMC(Y).Item(NM)
                If .Tag = "V" Then
                    If FH(Y) < 0 Then FH(Y) = .Left
                    LH(Y) = .Left
                    '.Visible = False
                    MR = MR + 1
                End If
            End With
            J = J + 1
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
            For I = 0 To 3
                If (FH(I) < L) And (FH(I) > 0) Then L = FH(I)
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
            For I = 0 To 3
                If (LH(I) > L) And (LH(I) > 0) Then L = LH(I)
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

        TP = TP + (A(0).Height / 3)
    End If
    T = TP
    
    '-----------------------------------
    ' incrementa contatore animazione M
    '-----------------------------------
    An = An + AnM
    If (An > 4) Or (An < 0) Then
        AnM = -AnM
        An = (An + (AnM * 2))
    End If
    
    '------------------------------------------
    ' incrementa posizione orizzontale degli M
    ' e visualizza nuova immagine per animazione
    '------------------------------------------
    Randomize Timer
    RN1 = Int(Rnd * (255 - (XMR * 2.5))) + 1
    M(0).Visible = True
    For Y = 0 To 3
        Select Case Y
            Case Is = 0: Set M(0).Picture = A(An).Picture
            Case Is = 1: Set M(0).Picture = B(An).Picture
            Case Is = 2: Set M(0).Picture = C(An).Picture
            Case Is = 3: Set M(0).Picture = D(An).Picture
        End Select
        For I = 1 To GMC(Y).Count
            With GMC(Y).Item(I)
                Lc1 = .Left + (MM + XMM)
                .Left = Lc1
                .Top = T
                If .Tag = "V" Then
                    Set .Picture = M(0).Picture
                    MT = .Top
                    
                    RN2 = Int(Rnd * (255 - (XMR * 2.5))) + 1
                    If RN2 = RN1 Then
                        For RN1 = 0 To CInt(MAXBombe - (XMR / 8))
                            If K(RN1).Tag = "" Then
                                K(RN1).Tag = "V"
                                K(RN1).Top = .Top + (.Height + 15)
                                K(RN1).Left = .Left
                                Exit For
                            End If
                        Next
                    End If
                End If
            End With
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
    Dim I As Integer
   
    ' anima le bombe lanciate dai M
    For I = 0 To MAXBombe
        If K(I).Visible Or K(I).Tag = "V" Then
            If K(I).Picture Is MI(1).Picture Then
                Set K(I).Picture = MI(0).Picture
            Else
                Set K(I).Picture = MI(1).Picture
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



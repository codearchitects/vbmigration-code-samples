VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form ClientFRM 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00FF8080&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Battleship"
   ClientHeight    =   8805
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   7800
   Icon            =   "MainClientFRM.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   ScaleHeight     =   8805
   ScaleWidth      =   7800
   StartUpPosition =   3  'Windows Default
   Tag             =   "2"
   Begin VB.Frame Frame1 
      BackColor       =   &H00FF8080&
      Caption         =   "Color Key-"
      ForeColor       =   &H00FFFFFF&
      Height          =   1575
      Left            =   6360
      TabIndex        =   305
      Top             =   6600
      Width           =   1335
      Begin VB.Label Label2 
         BackColor       =   &H0000FF00&
         Height          =   255
         Left            =   960
         TabIndex        =   315
         Top             =   480
         Width           =   255
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "   Miss ="
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   -120
         TabIndex        =   314
         Top             =   480
         Width           =   1335
      End
      Begin VB.Label Label16 
         BackColor       =   &H0000FFFF&
         Height          =   255
         Left            =   960
         TabIndex        =   313
         Top             =   1200
         Width           =   255
      End
      Begin VB.Label Label17 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Waiting ="
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   -120
         TabIndex        =   312
         Top             =   1200
         Width           =   1275
      End
      Begin VB.Label Label18 
         BackColor       =   &H000000FF&
         Height          =   255
         Left            =   960
         TabIndex        =   311
         Top             =   240
         Width           =   255
      End
      Begin VB.Label Label19 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   " Hit ="
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   0
         TabIndex        =   310
         Top             =   240
         Width           =   1290
      End
      Begin VB.Label Label21 
         BackColor       =   &H00808080&
         Height          =   255
         Left            =   960
         TabIndex        =   309
         Top             =   720
         Width           =   255
      End
      Begin VB.Label Label22 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Ship ="
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   0
         TabIndex        =   308
         Top             =   720
         Width           =   1260
      End
      Begin VB.Label Label23 
         BackColor       =   &H00800000&
         Height          =   255
         Left            =   960
         TabIndex        =   307
         Top             =   960
         Width           =   255
      End
      Begin VB.Label Label24 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "  Water ="
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   -120
         TabIndex        =   306
         Top             =   960
         Width           =   1290
      End
   End
   Begin VB.PictureBox nopicturePIC 
      Height          =   375
      Left            =   0
      ScaleHeight     =   315
      ScaleWidth      =   315
      TabIndex        =   304
      Top             =   240
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Timer startgameTMR 
      Interval        =   1000
      Left            =   0
      Top             =   120
   End
   Begin VB.PictureBox hitPIC 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   405
      Left            =   0
      Picture         =   "MainClientFRM.frx":08CA
      ScaleHeight     =   375
      ScaleWidth      =   375
      TabIndex        =   303
      Top             =   0
      Visible         =   0   'False
      Width           =   405
   End
   Begin VB.TextBox destroyerTXT 
      Height          =   195
      Index           =   2
      Left            =   5280
      TabIndex        =   302
      Top             =   7680
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox destroyerTXT 
      Height          =   195
      Index           =   1
      Left            =   4680
      TabIndex        =   301
      Top             =   7680
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox submarineTXT 
      Height          =   195
      Index           =   2
      Left            =   5400
      TabIndex        =   300
      Top             =   7200
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox submarineTXT 
      Height          =   195
      Index           =   1
      Left            =   4800
      TabIndex        =   299
      Top             =   7200
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox cruiserTXT 
      Height          =   195
      Index           =   3
      Left            =   5640
      TabIndex        =   298
      Top             =   6720
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox cruiserTXT 
      Height          =   195
      Index           =   2
      Left            =   5040
      TabIndex        =   297
      Top             =   6720
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox cruiserTXT 
      Height          =   195
      Index           =   1
      Left            =   4440
      TabIndex        =   296
      Top             =   6720
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox battleshipTXT 
      Height          =   195
      Index           =   4
      Left            =   6480
      TabIndex        =   295
      Top             =   6240
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox battleshipTXT 
      Height          =   195
      Index           =   3
      Left            =   5880
      TabIndex        =   294
      Top             =   6240
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox battleshipTXT 
      Height          =   195
      Index           =   2
      Left            =   5280
      TabIndex        =   293
      Top             =   6240
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox battleshipTXT 
      Height          =   195
      Index           =   1
      Left            =   4680
      TabIndex        =   292
      Top             =   6240
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox carrierTXT 
      Height          =   225
      Index           =   5
      Left            =   6840
      TabIndex        =   291
      Top             =   5730
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox carrierTXT 
      Height          =   225
      Index           =   4
      Left            =   6240
      TabIndex        =   290
      Top             =   5730
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox carrierTXT 
      Height          =   225
      Index           =   3
      Left            =   5760
      TabIndex        =   289
      Top             =   5730
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox carrierTXT 
      Height          =   225
      Index           =   2
      Left            =   5040
      TabIndex        =   288
      Top             =   5730
      Visible         =   0   'False
      Width           =   150
   End
   Begin VB.TextBox carrierTXT 
      Height          =   225
      Index           =   1
      Left            =   4440
      TabIndex        =   287
      Top             =   5730
      Visible         =   0   'False
      Width           =   150
   End
   Begin RichTextLib.RichTextBox MainTXT 
      Height          =   2775
      Left            =   120
      TabIndex        =   286
      Top             =   4920
      Width           =   3255
      _ExtentX        =   5741
      _ExtentY        =   4895
      _Version        =   393217
      ReadOnly        =   -1  'True
      ScrollBars      =   2
      TextRTF         =   $"MainClientFRM.frx":0FC8
   End
   Begin MSWinsockLib.Winsock Winsock 
      Left            =   5400
      Top             =   8760
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin VB.TextBox sendTXT 
      Height          =   285
      Left            =   120
      MaxLength       =   100
      TabIndex        =   282
      Top             =   7800
      Width           =   2415
   End
   Begin VB.CommandButton sendtextCMD 
      Caption         =   "&Send"
      Default         =   -1  'True
      Height          =   315
      Left            =   2640
      TabIndex        =   281
      Top             =   7800
      Width           =   735
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   240
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   280
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   239
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   279
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   238
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   278
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   237
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   277
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   236
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   276
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   235
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   275
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   234
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   274
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   233
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   273
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   232
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   272
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   231
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   271
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   230
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   270
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   229
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   269
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   228
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   268
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   227
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   267
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   226
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   266
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   225
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   265
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   224
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   264
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   223
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   263
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   222
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   262
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   221
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   261
      Top             =   4440
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   220
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   260
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   219
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   259
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   218
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   258
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   217
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   257
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   216
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   256
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   215
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   255
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   214
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   254
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   213
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   253
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   212
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   252
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   211
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   251
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   210
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   250
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   209
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   249
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   208
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   248
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   207
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   247
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   206
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   246
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   205
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   245
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   204
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   244
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   203
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   243
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   202
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   242
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   201
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   241
      Top             =   4080
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   200
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   240
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   199
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   239
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   198
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   238
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   197
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   237
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   196
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   236
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   195
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   235
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   194
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   234
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   193
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   233
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   192
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   232
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   191
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   231
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   190
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   230
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   189
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   229
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   188
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   228
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   187
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   227
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   186
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   226
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   185
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   225
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   184
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   224
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   183
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   223
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   182
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   222
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   181
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   221
      Top             =   3720
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   180
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   220
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   179
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   219
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   178
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   218
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   177
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   217
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   176
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   216
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   175
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   215
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   174
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   214
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   173
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   213
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   172
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   212
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   171
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   211
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   170
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   210
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   169
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   209
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   168
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   208
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   167
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   207
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   166
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   206
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   165
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   205
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   164
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   204
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   163
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   203
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   162
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   202
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   161
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   201
      Top             =   3360
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   160
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   200
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   159
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   199
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   158
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   198
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   157
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   197
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   156
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   196
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   155
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   195
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   154
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   194
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   153
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   193
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   152
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   192
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   151
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   191
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   150
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   190
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      DrawStyle       =   1  'Dash
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   149
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   189
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   148
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   188
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   147
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   187
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   146
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   186
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   145
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   185
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   144
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   184
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   143
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   183
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   142
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   182
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   141
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   181
      Top             =   3000
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   140
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   180
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   139
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   179
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   138
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   178
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   137
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   177
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   136
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   176
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   135
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   175
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   134
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   174
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   133
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   173
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   132
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   172
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   131
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   171
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   130
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   170
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   129
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   169
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   128
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   168
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   127
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   167
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   126
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   166
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   125
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   165
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   124
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   164
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   123
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   163
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   122
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   162
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   121
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   161
      Top             =   2640
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   120
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   160
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   119
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   159
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   118
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   158
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   117
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   157
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   116
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   156
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   115
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   155
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   114
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   154
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   113
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   153
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   112
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   152
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   111
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   151
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   110
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   150
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   109
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   149
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   108
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   148
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   107
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   147
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   106
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   146
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   105
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   145
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   104
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   144
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   103
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   143
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   102
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   142
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   101
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   141
      Top             =   2280
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   100
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   140
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   99
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   139
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   98
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   138
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   97
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   137
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   96
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   136
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   95
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   135
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   94
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   134
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   93
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   133
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   92
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   132
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   91
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   131
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   90
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   130
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   89
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   129
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   88
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   128
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   87
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   127
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   86
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   126
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   85
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   125
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   84
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   124
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   83
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   123
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   82
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   122
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   81
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   121
      Top             =   1920
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   80
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   120
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   79
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   119
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   78
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   118
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   77
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   117
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   76
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   116
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   75
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   115
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   74
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   114
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   73
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   113
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   72
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   112
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   71
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   111
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   70
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   110
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   69
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   109
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   68
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   108
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   67
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   107
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   66
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   106
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   65
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   105
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   64
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   104
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   63
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   103
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   62
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   102
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   61
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   101
      Top             =   1560
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   60
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   100
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   59
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   99
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   58
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   98
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   57
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   97
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   56
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   96
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   55
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   95
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   54
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   94
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   53
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   93
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   52
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   92
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   51
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   91
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   50
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   90
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   49
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   89
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   48
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   88
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   47
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   87
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   46
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   86
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   45
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   85
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   44
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   84
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   43
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   83
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   42
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   82
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   41
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   81
      Top             =   1200
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   40
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   80
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   39
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   79
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   38
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   78
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   37
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   77
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   36
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   76
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   35
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   75
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   34
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   74
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   33
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   73
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   32
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   72
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   31
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   71
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   30
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   70
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   29
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   69
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   28
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   68
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   27
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   67
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   26
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   66
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   25
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   65
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   24
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   64
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   23
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   63
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   22
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   62
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   21
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   61
      Top             =   840
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   20
      Left            =   7200
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   60
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   19
      Left            =   6840
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   59
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   18
      Left            =   6480
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   58
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   17
      Left            =   6120
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   57
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   16
      Left            =   5760
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   56
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   15
      Left            =   5400
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   55
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   14
      Left            =   5040
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   54
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   13
      Left            =   4680
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   53
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   12
      Left            =   4320
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   52
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   11
      Left            =   3960
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   51
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   10
      Left            =   3600
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   50
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   9
      Left            =   3240
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   49
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   8
      Left            =   2880
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   48
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   7
      Left            =   2520
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   47
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   6
      Left            =   2160
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   46
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   5
      Left            =   1800
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   45
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   4
      Left            =   1440
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   44
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   3
      Left            =   1080
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   43
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   2
      Left            =   720
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   42
      Top             =   480
      Width           =   375
   End
   Begin VB.PictureBox Field 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   375
      Index           =   1
      Left            =   360
      ScaleHeight     =   345
      ScaleWidth      =   345
      TabIndex        =   41
      Top             =   480
      Width           =   375
   End
   Begin VB.Frame statsFRA 
      BackColor       =   &H00FF8080&
      Caption         =   "Game Stats-"
      ForeColor       =   &H00FFFFFF&
      Height          =   615
      Left            =   3480
      TabIndex        =   0
      Top             =   4920
      Width           =   3735
      Begin VB.Label GameStatsLBL 
         BackStyle       =   0  'Transparent
         ForeColor       =   &H00800000&
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   3495
      End
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   6
      X1              =   6120
      X2              =   4800
      Y1              =   8280
      Y2              =   8280
   End
   Begin VB.Label nickSERVER 
      Height          =   135
      Left            =   360
      TabIndex        =   285
      Top             =   7800
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Label nickCLIENT 
      Height          =   135
      Left            =   720
      TabIndex        =   284
      Top             =   7800
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "© 2000 One"
      BeginProperty Font 
         Name            =   "MS Serif"
         Size            =   6
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   135
      Left            =   120
      TabIndex        =   283
      Top             =   4800
      Width           =   855
   End
   Begin VB.Line Line31 
      X1              =   4800
      X2              =   6000
      Y1              =   7440
      Y2              =   7440
   End
   Begin VB.Line Line30 
      X1              =   4800
      X2              =   6000
      Y1              =   7080
      Y2              =   7080
   End
   Begin VB.Line Line29 
      X1              =   4680
      X2              =   5880
      Y1              =   7920
      Y2              =   7920
   End
   Begin VB.Line Line28 
      X1              =   4680
      X2              =   5880
      Y1              =   7560
      Y2              =   7560
   End
   Begin VB.Line Line27 
      X1              =   5880
      X2              =   5880
      Y1              =   7560
      Y2              =   7920
   End
   Begin VB.Line Line26 
      X1              =   4680
      X2              =   4680
      Y1              =   7560
      Y2              =   7920
   End
   Begin VB.Line Line25 
      X1              =   6000
      X2              =   6000
      Y1              =   7080
      Y2              =   7440
   End
   Begin VB.Line Line24 
      X1              =   4800
      X2              =   4800
      Y1              =   7080
      Y2              =   7440
   End
   Begin VB.Line Line23 
      X1              =   6240
      X2              =   6240
      Y1              =   6600
      Y2              =   6960
   End
   Begin VB.Line Line22 
      X1              =   4440
      X2              =   4440
      Y1              =   6600
      Y2              =   6960
   End
   Begin VB.Line Line21 
      X1              =   4440
      X2              =   6240
      Y1              =   6960
      Y2              =   6960
   End
   Begin VB.Line Line20 
      X1              =   4440
      X2              =   6240
      Y1              =   6600
      Y2              =   6600
   End
   Begin VB.Line Line19 
      X1              =   4680
      X2              =   7080
      Y1              =   6480
      Y2              =   6480
   End
   Begin VB.Line Line18 
      X1              =   4680
      X2              =   7080
      Y1              =   6120
      Y2              =   6120
   End
   Begin VB.Line Line17 
      X1              =   7080
      X2              =   7080
      Y1              =   6120
      Y2              =   6480
   End
   Begin VB.Line Line16 
      X1              =   4680
      X2              =   4680
      Y1              =   6120
      Y2              =   6480
   End
   Begin VB.Line Line15 
      X1              =   7440
      X2              =   7440
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Line Line14 
      X1              =   4440
      X2              =   4440
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Line Line13 
      X1              =   4440
      X2              =   7440
      Y1              =   6000
      Y2              =   6000
   End
   Begin VB.Line Line12 
      X1              =   4440
      X2              =   7440
      Y1              =   5640
      Y2              =   5640
   End
   Begin VB.Line Line10 
      X1              =   5280
      X2              =   5280
      Y1              =   7560
      Y2              =   7920
   End
   Begin VB.Line Line8 
      X1              =   5400
      X2              =   5400
      Y1              =   7080
      Y2              =   7440
   End
   Begin VB.Line Line5 
      X1              =   5640
      X2              =   5640
      Y1              =   6600
      Y2              =   6960
   End
   Begin VB.Line Line11 
      X1              =   6480
      X2              =   6480
      Y1              =   6120
      Y2              =   6480
   End
   Begin VB.Line Line9 
      X1              =   5040
      X2              =   5040
      Y1              =   6600
      Y2              =   6960
   End
   Begin VB.Line Line7 
      X1              =   5880
      X2              =   5880
      Y1              =   6120
      Y2              =   6480
   End
   Begin VB.Line Line6 
      X1              =   5280
      X2              =   5280
      Y1              =   6120
      Y2              =   6480
   End
   Begin VB.Line Line4 
      X1              =   6240
      X2              =   6240
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Line Line3 
      X1              =   6840
      X2              =   6840
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Line Line2 
      X1              =   5640
      X2              =   5640
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Line Line1 
      X1              =   5040
      X2              =   5040
      Y1              =   5640
      Y2              =   6000
   End
   Begin VB.Label Label30 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Destroyer:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Left            =   3480
      TabIndex        =   19
      Top             =   7560
      Width           =   1215
   End
   Begin VB.Label Label29 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Submarine:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   255
      Left            =   3480
      TabIndex        =   18
      Top             =   7080
      Width           =   1335
   End
   Begin VB.Label Label28 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Cruiser:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Left            =   3480
      TabIndex        =   17
      Top             =   6600
      Width           =   855
   End
   Begin VB.Label Label27 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Battleship:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Left            =   3480
      TabIndex        =   16
      Top             =   6120
      Width           =   1215
   End
   Begin VB.Label Label26 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Carrier:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   255
      Left            =   3480
      TabIndex        =   15
      Top             =   5640
      Width           =   975
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   19
      X1              =   1440
      X2              =   120
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   18
      X1              =   1440
      X2              =   120
      Y1              =   8280
      Y2              =   8280
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   17
      X1              =   120
      X2              =   120
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   16
      X1              =   1440
      X2              =   1440
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   15
      X1              =   3000
      X2              =   1680
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   14
      X1              =   3000
      X2              =   1680
      Y1              =   8280
      Y2              =   8280
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   13
      X1              =   1680
      X2              =   1680
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   12
      X1              =   3000
      X2              =   3000
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   11
      X1              =   4560
      X2              =   3240
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   10
      X1              =   4560
      X2              =   3240
      Y1              =   8280
      Y2              =   8280
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   9
      X1              =   3240
      X2              =   3240
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   8
      X1              =   4560
      X2              =   4560
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   7
      X1              =   6120
      X2              =   4800
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   5
      X1              =   4800
      X2              =   4800
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   4
      X1              =   6120
      X2              =   6120
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   3
      X1              =   7680
      X2              =   6360
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   2
      X1              =   7680
      X2              =   6360
      Y1              =   8280
      Y2              =   8280
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   1
      X1              =   6360
      X2              =   6360
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Line labelBgLNE 
      BorderColor     =   &H0000FFFF&
      BorderWidth     =   2
      Index           =   0
      X1              =   7680
      X2              =   7680
      Y1              =   8280
      Y2              =   8640
   End
   Begin VB.Label Label15 
      BackStyle       =   0  'Transparent
      Caption         =   "L"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   14
      Top             =   4440
      Width           =   135
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "K"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   13
      Top             =   4080
      Width           =   135
   End
   Begin VB.Label Label13 
      BackStyle       =   0  'Transparent
      Caption         =   "J"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   12
      Top             =   3720
      Width           =   135
   End
   Begin VB.Label Label12 
      BackStyle       =   0  'Transparent
      Caption         =   "I"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   11
      Top             =   3360
      Width           =   135
   End
   Begin VB.Label Label11 
      BackStyle       =   0  'Transparent
      Caption         =   "H"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   10
      Top             =   3000
      Width           =   135
   End
   Begin VB.Label Label10 
      BackStyle       =   0  'Transparent
      Caption         =   "G"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   9
      Top             =   2640
      Width           =   135
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "F"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   8
      Top             =   2280
      Width           =   135
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "E"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   1920
      Width           =   135
   End
   Begin VB.Label Label20 
      BackStyle       =   0  'Transparent
      Caption         =   "D"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   1560
      Width           =   135
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   1200
      Width           =   135
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "B"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   135
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "A"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   480
      Width           =   135
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "  1   2    3   4    5   6   7    8   9   10  11  12  13  14  15  16  17  18  19  20"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   120
      Width           =   7215
   End
   Begin VB.Label MYcarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4440
      TabIndex        =   36
      Top             =   5640
      Width           =   615
   End
   Begin VB.Label MYcarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5040
      TabIndex        =   37
      Top             =   5640
      Width           =   615
   End
   Begin VB.Label MYcarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5640
      TabIndex        =   38
      Top             =   5640
      Width           =   615
   End
   Begin VB.Label MYcarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   6240
      TabIndex        =   40
      Top             =   5640
      Width           =   615
   End
   Begin VB.Label MYcarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   6840
      TabIndex        =   39
      Top             =   5640
      Width           =   615
   End
   Begin VB.Label MYbattleshipLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4680
      TabIndex        =   35
      Top             =   6120
      Width           =   615
   End
   Begin VB.Label MYbattleshipLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5280
      TabIndex        =   34
      Top             =   6120
      Width           =   615
   End
   Begin VB.Label MYbattleshipLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5880
      TabIndex        =   33
      Top             =   6120
      Width           =   615
   End
   Begin VB.Label MYbattleshipLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   6480
      TabIndex        =   32
      Top             =   6120
      Width           =   615
   End
   Begin VB.Label MYcruiserLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5640
      TabIndex        =   31
      Top             =   6600
      Width           =   615
   End
   Begin VB.Label MYcruiserLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5040
      TabIndex        =   30
      Top             =   6600
      Width           =   615
   End
   Begin VB.Label MYcruiserLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4440
      TabIndex        =   29
      Top             =   6600
      Width           =   615
   End
   Begin VB.Label MYsubmarineLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4800
      TabIndex        =   28
      Top             =   7080
      Width           =   615
   End
   Begin VB.Label MYsubmarineLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5400
      TabIndex        =   27
      Top             =   7080
      Width           =   615
   End
   Begin VB.Label MYdestroyerLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4680
      TabIndex        =   25
      Top             =   7560
      Width           =   615
   End
   Begin VB.Label MYdestroyerLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5280
      TabIndex        =   26
      Top             =   7560
      Width           =   615
   End
   Begin VB.Label DestroyerLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00800000&
      Caption         =   "Destroyer"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   24
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Label SubMarineLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00800000&
      Caption         =   "Submarine"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   1680
      TabIndex        =   23
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Label CruiserLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00800000&
      Caption         =   "Cruiser"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   3240
      TabIndex        =   22
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Label battleshipLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00800000&
      Caption         =   "Battleship"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   4800
      TabIndex        =   20
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Label CarrierLBL 
      Alignment       =   2  'Center
      BackColor       =   &H00800000&
      Caption         =   "Carrier"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   6360
      TabIndex        =   21
      Top             =   8280
      Width           =   1335
   End
End
Attribute VB_Name = "ClientFRM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
'the client frm if HEAVILY and probably OVERLY commented on...
'the server frm will not be commented as much!!!!!!!!!!!!!!

'server frm tag is 1 and will be used in MENUFRM
'client frm tag is 2 and will be used in menufrm
Dim daINDEX As Integer 'holds the index of the Field picturebox
Dim isGAME As Integer 'checks if game is over
Dim playerTURN As Integer 'holds player's turn  (0 is server, 1 is client)

Private Sub battleshipLBL_Click()
    'used for the MENUFRM
    FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
    whichMNU = "battleship" 'tells menufrm that battleshiplbl was clicked
    'sets position of menuFRM
    MenuFRM.Left = Me.Left + 4800
    MenuFRM.Top = Me.Top + 8950
    MenuFRM.Show
    
End Sub

Private Sub CarrierLBL_Click()
    'used for the MENUFRM
    FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
    whichMNU = "carrier" 'tells menufrm that carrierlbl was clicked
    'sets position of menuFRM
    MenuFRM.Left = Me.Left + 6360
    MenuFRM.Top = Me.Top + 8950
    MenuFRM.Show
    
End Sub

Private Sub CruiserLBL_Click()
    'used for the MENUFRM
    FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
    whichMNU = "cruiser" 'tells menufrm that cruiserlbl was clicked
    'sets position of menuFRM
    MenuFRM.Left = Me.Left + 3240
    MenuFRM.Top = Me.Top + 8950
    MenuFRM.Show
    
End Sub

Private Sub DestroyerLBL_Click()
    'used for the MENUFRM
    FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
    whichMNU = "destroyer" 'tells menufrm that destroyerlbl was clicked
    'sets position of menuFRM
    MenuFRM.Left = Me.Left + 120
    MenuFRM.Top = Me.Top + 8950
    MenuFRM.Show
    
End Sub

Private Sub Field_Click(Index As Integer)
    If ShiPcount < 6 Then 'checks if all ships are selected or not!
        daINDEX = Field(Index).Index 'saves the index of the array of FIELD into daINDEX
        PlayWav "ff7-blip.wav" 'plays a .wav to similiate a click sound
            If WhiCHway = "ns" Then 'for north to south ship placement
                If whichMNU = "carrier" Then 'tells how long to make ship
                    If daINDEX + 80 > 240 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 20).BackColor = &HFFFF& And Field(daINDEX + 40).BackColor = &HFFFF& And Field(daINDEX + 60).BackColor = &HFFFF& And Field(daINDEX + 80).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 20).BackColor = &H808080: Field(daINDEX + 40).BackColor = &H808080: Field(daINDEX + 60).BackColor = &H808080: Field(daINDEX + 80).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts the .caption of lbl's in
                        Winsock.SendData "K" & daINDEX 'tells remote computer what and where u put your ship
                        CarrierLBL.Enabled = False 'disables so you cant select the ship again
                        ShiPcount = ShiPcount + 1 'tells your computer that u selected another ship
                    End If
                End If
                If whichMNU = "battleship" Then 'tells how long to make ship
                    If daINDEX + 60 > 240 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 20).BackColor = &HFFFF& And Field(daINDEX + 40).BackColor = &HFFFF& And Field(daINDEX + 60).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 20).BackColor = &H808080: Field(daINDEX + 40).BackColor = &H808080: Field(daINDEX + 60).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts .caption of lbl's in
                        Winsock.SendData "B" & daINDEX 'tells remote computer what and where u put your ship
                        battleshipLBL.Enabled = False 'disables so u cant select the ship again
                        ShiPcount = ShiPcount + 1 'tells your computer that u selected another ship
                    End If
                End If
                If whichMNU = "cruiser" Then 'tells how long to make ship
                    If daINDEX + 40 > 240 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 20).BackColor = &HFFFF& And Field(daINDEX + 40).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 20).BackColor = &H808080: Field(daINDEX + 40).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts .caption of lbl's in
                        Winsock.SendData "R" & daINDEX 'tells remote computer what and where u put your ship
                        CruiserLBL.Enabled = False 'disables so u cant select the ship again
                        ShiPcount = ShiPcount + 1 'tells computer that u selected another ship
                    End If
                End If
                If whichMNU = "submarine" Then 'tells how long to make ship
                    If daINDEX + 20 > 240 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 20).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 20).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts .caption of lbl's in
                        Winsock.SendData "S" & daINDEX 'tells remote computer what and where u placed ur ship
                        SubMarineLBL.Enabled = False 'disables so u cant select ur ship again
                        ShiPcount = ShiPcount + 1 'tells computer that u selected another ship
                    End If
                End If
                If whichMNU = "destroyer" Then 'tells how long to make ship
                    If daINDEX + 20 > 240 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 20).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 20).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts .caption of lbl's in
                        Winsock.SendData "D" & daINDEX 'tells remote computer what and where u put your ship
                        DestroyerLBL.Enabled = False 'disables so u cant select ur ship again
                        ShiPcount = ShiPcount + 1 'tells computer that u selected another ship
                    End If
                End If
            End If
            '==========================================================
            If WhiCHway = "lr" Then 'for left to right ship placement
                If whichMNU = "carrier" Then 'tells how long to make ship
                    If Field(daINDEX).Left > 5760 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 1).BackColor = &HFFFF& And Field(daINDEX + 2).BackColor = &HFFFF& And Field(daINDEX + 3).BackColor = &HFFFF& And Field(daINDEX + 4).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 1).BackColor = &H808080: Field(daINDEX + 2).BackColor = &H808080: Field(daINDEX + 3).BackColor = &H808080: Field(daINDEX + 4).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts .caption of lbls in
                        Winsock.SendData "I" & daINDEX 'tells remote computer what and where u put your ship
                        CarrierLBL.Enabled = False 'disables so u cant select ur ship again
                        ShiPcount = ShiPcount + 1 'tells computer that u selected another ship
                    End If
                End If
                If whichMNU = "battleship" Then 'tells how long ship is
                    If Field(daINDEX).Left > 6120 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 1).BackColor = &HFFFF& And Field(daINDEX + 2).BackColor = &HFFFF& And Field(daINDEX + 3).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 1).BackColor = &H808080: Field(daINDEX + 2).BackColor = &H808080: Field(daINDEX + 3).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts caption into lbls
                        Winsock.SendData "L" & daINDEX 'tells remote computer what and where u put your ship
                        battleshipLBL.Enabled = False 'disables so u cant select ship again
                        ShiPcount = ShiPcount + 1 'tells computer that another ship was selected
                    End If
                End If
                If whichMNU = "cruiser" Then 'tells how long ship is
                    If Field(daINDEX).Left > 6480 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 1).BackColor = &HFFFF& And Field(daINDEX + 2).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 1).BackColor = &H808080: Field(daINDEX + 2).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts caption into lbls
                        Winsock.SendData "U" & daINDEX 'tells remote computer what and where u put your ship
                        CruiserLBL.Enabled = False 'disables so u cant select ship again
                        ShiPcount = ShiPcount + 1 'tells computer another ship was selected
                    End If
                End If
                If whichMNU = "submarine" Then 'tells how long the ship is
                    If Field(daINDEX).Left > 6840 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 1).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 1).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts caption into lbls
                        Winsock.SendData "E" & daINDEX 'tells remote computer what and where u put your ship
                        SubMarineLBL.Enabled = False 'disables so u cant select the ship again
                        ShiPcount = ShiPcount + 1 'tells copmuter that another ship was selected
                    End If
                End If
                If whichMNU = "destroyer" Then 'tells how long the ship is
                    If Field(daINDEX).Left > 6840 Then Exit Sub 'allows only to place ship where there is room for ship
                    If Field(daINDEX).BackColor = &HFFFF& And Field(daINDEX + 1).BackColor = &HFFFF& Then 'checks to see if there is already a ship there
                        Field(daINDEX).BackColor = &H808080: Field(daINDEX + 1).BackColor = &H808080 'puts ship in
                        PUTlabelsIN 'puts caption into right labels
                        Winsock.SendData "O" & daINDEX 'tells remote computer what and where u put your ship
                        DestroyerLBL.Enabled = False 'disables so u cant select ship again
                        ShiPcount = ShiPcount + 1 'tells computer that another ship was selected
                    End If
                End If
            End If
    End If
'determines if game is to be started or not!
    If ShiPcount = 5 Then 'tells u that all 5 ships were selected
        ShiPcount = 10 'sets to 10 so it will skip over code above
        startgameTMR.Enabled = True 'starts the timer to tell server that u are ready
        Dim zZ 'holds the integer
        For zZ = 1 To 240 'the #'s represent the field's array index
            Field(zZ).BackColor = &H800000 'changes bg to blue again
        Next 'loops to for till all # are done... then moves on
            GameStatsLBL.Caption = "Waiting For Server To Finish..." 'just a visual note that u are ready
            playerTURN = "0" 'shows who turn it is
            For zZ = 1 To 240 'again the #'s representthe field's array index
                Field(zZ).Enabled = False 'disables field so you cant start w/o server
            Next 'again it loops though till all #'s are done then moves on
            Exit Sub 'exits sub to skip the next part of code
    End If
    '=================================
    If playerTURN = "0" Then Exit Sub 'this is the head on head part of game
    If ShiPcount = 10 Then 'just to make sure it is game time
        PlayWav "ff7-blip.wav" 'plays sound for clicking in the field
        daINDEX = Field(Index).Index 'saves the field's array index into daINDEX
        If Field(daINDEX).BackColor <> &H800000 Then Exit Sub 'checkes if already guessed
        If Field(daINDEX).Picture = hitPIC.Picture Then Exit Sub 'exits sub if already guessed
        playerTURN = "0" 'tells the turn is server(rememeber look at the declaration note!!!)
        Dim Yq 'variable used below
        For Yq = 1 To 5 'holds # to represent the array of the txtbox
            If carrierTXT(Yq).Text = daINDEX Then 'checks if a hit
                Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
                Winsock.SendData "H" & "C" & Yq 'tells server that u hit one of their ships!!!!!!!!
                GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays whos turn it is
                Field(daINDEX).Refresh 'just for the hell of it
                PlayWav "arrow.wav" 'plays a HIT sound
                Exit Sub 'exits sub so it wont show a miss
            End If
        Next
        For Yq = 1 To 4 'holds # to represent the array of the txtbox
            If battleshipTXT(Yq).Text = daINDEX Then 'checks if a hit
                Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
                Winsock.SendData "H" & "B" & Yq 'tells server u hit a ship
                GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays whos turn it is
                Field(daINDEX).Refresh 'just incase
                PlayWav "arrow.wav" 'plays a HIT sound
                Exit Sub 'exits sub so it wont show a miss
            End If
        Next
        For Yq = 1 To 3 'holds # to represent the array of the txtbox
            If cruiserTXT(Yq).Text = daINDEX Then 'checks if a hit
                Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
                Winsock.SendData "H" & "R" & Yq 'tells server u hit a ship
                GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays who turn it is
                Field(daINDEX).Refresh 'u never know... u might need it
                PlayWav "arrow.wav" 'plays a HIT sound
                Exit Sub 'exits sub so it wont show a miss
            End If
        Next
        For Yq = 1 To 2 'holds # to represent the array of the txtbox
            If destroyerTXT(Yq).Text = daINDEX Then 'checks if a hit
                Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
                Winsock.SendData "H" & "D" & Yq 'sends data telling a hit
                GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays turn
                Field(daINDEX).Refresh 'well this just makes sure the pic shows
                PlayWav "arrow.wav" 'plays a HIT soundup
                Exit Sub 'exits sub so it wont show a miss
            End If
            If submarineTXT(Yq).Text = daINDEX Then 'checks if a hit
                Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
                Winsock.SendData "H" & "S" & Yq 'send data telling a hit
                GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays turn
                Field(daINDEX).Refresh 'this just makes sure the pic shows up
                PlayWav "arrow.wav" 'plays a HIT sound
                Exit Sub 'exits sub so it wont show a miss
            End If
        Next
            Winsock.SendData "M" & "Your Turn..." 'sends data telling a miss
            GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'displays turn
            Field(daINDEX).BackColor = vbGreen 'shows a miss
            PlayWav "you-lose.wav" 'plays a miss sound
    End If
'=========================================

End Sub

Sub PUTlabelsIN()
'put the color back to blue
Dim Yp 'hold the integer
    For Yp = 1 To 240 'represents the array #
        If Field(Yp).BackColor = &HFFFF& Then 'checks if the field(Yp) BG is yellow
            Field(Yp).BackColor = &H800000 'turns it blue
        End If
    Next 'loops till all # have been gone though... then moves on
'puts the ships positions into labels
    If WhiCHway = "ns" Then 'for north to south label input
        If whichMNU = "carrier" Then 'for carrier
            If daINDEX > 0 Then 'row A
                MYcarrierLBL(1).Caption = "A:" & daINDEX: MYcarrierLBL(2).Caption = "B:" & daINDEX: MYcarrierLBL(3).Caption = "C:" & daINDEX: MYcarrierLBL(4).Caption = "D:" & daINDEX: MYcarrierLBL(5).Caption = "E:" & daINDEX 'displays the grid #
            End If
            If daINDEX > 20 Then 'row B
                MYcarrierLBL(1).Caption = "B:" & daINDEX - 20: MYcarrierLBL(2).Caption = "C:" & daINDEX - 20: MYcarrierLBL(3).Caption = "D:" & daINDEX - 20: MYcarrierLBL(4).Caption = "E:" & daINDEX - 20: MYcarrierLBL(5).Caption = "F:" & daINDEX - 20 'displays the grid #
            End If
            If daINDEX > 40 Then 'row C
                MYcarrierLBL(1).Caption = "C:" & daINDEX - 40: MYcarrierLBL(2).Caption = "D:" & daINDEX - 40: MYcarrierLBL(3).Caption = "E:" & daINDEX - 40: MYcarrierLBL(4).Caption = "F:" & daINDEX - 40: MYcarrierLBL(5).Caption = "G:" & daINDEX - 40 'displays the grid #
            End If
            If daINDEX > 60 Then 'row D
                MYcarrierLBL(1).Caption = "D:" & daINDEX - 60: MYcarrierLBL(2).Caption = "E:" & daINDEX - 60: MYcarrierLBL(3).Caption = "F:" & daINDEX - 60: MYcarrierLBL(4).Caption = "G:" & daINDEX - 60: MYcarrierLBL(5).Caption = "H:" & daINDEX - 60 'displays the grid #
            End If
            If daINDEX > 80 Then 'row E
                MYcarrierLBL(1).Caption = "E:" & daINDEX - 80: MYcarrierLBL(2).Caption = "F:" & daINDEX - 80: MYcarrierLBL(3).Caption = "G:" & daINDEX - 80: MYcarrierLBL(4).Caption = "H:" & daINDEX - 80: MYcarrierLBL(5).Caption = "I:" & daINDEX - 80 'displays the grid #
            End If
            If daINDEX > 100 Then 'row F
                MYcarrierLBL(1).Caption = "F:" & daINDEX - 100: MYcarrierLBL(2).Caption = "G:" & daINDEX - 100: MYcarrierLBL(3).Caption = "H:" & daINDEX - 100: MYcarrierLBL(4).Caption = "I:" & daINDEX - 100: MYcarrierLBL(5).Caption = "J:" & daINDEX - 100 'displays the grid #
            End If
            If daINDEX > 120 Then 'row G
                MYcarrierLBL(1).Caption = "G:" & daINDEX - 120: MYcarrierLBL(2).Caption = "H:" & daINDEX - 120: MYcarrierLBL(3).Caption = "I:" & daINDEX - 120: MYcarrierLBL(4).Caption = "J:" & daINDEX - 120: MYcarrierLBL(5).Caption = "K:" & daINDEX - 120 'displays the grid #
            End If
            If daINDEX > 140 Then 'row H
                MYcarrierLBL(1).Caption = "H:" & daINDEX - 140: MYcarrierLBL(2).Caption = "I:" & daINDEX - 140: MYcarrierLBL(3).Caption = "J:" & daINDEX - 140: MYcarrierLBL(4).Caption = "K:" & daINDEX - 140: MYcarrierLBL(5).Caption = "L:" & daINDEX - 140 'displays the grid #
            End If
        End If
        If whichMNU = "battleship" Then 'for battleship
            If daINDEX > 0 Then 'row A
                MYbattleshipLBL(1).Caption = "A:" & daINDEX: MYbattleshipLBL(2).Caption = "B:" & daINDEX: MYbattleshipLBL(3).Caption = "C:" & daINDEX: MYbattleshipLBL(4).Caption = "D:" & daINDEX 'displays the grid #
            End If
            If daINDEX > 20 Then 'row B
                MYbattleshipLBL(1).Caption = "B:" & daINDEX - 20: MYbattleshipLBL(2).Caption = "C:" & daINDEX - 20: MYbattleshipLBL(3).Caption = "D:" & daINDEX - 20: MYbattleshipLBL(4).Caption = "E:" & daINDEX - 20 'displays the grid #
            End If
            If daINDEX > 40 Then 'row C
                MYbattleshipLBL(1).Caption = "C:" & daINDEX - 40: MYbattleshipLBL(2).Caption = "D:" & daINDEX - 40: MYbattleshipLBL(3).Caption = "E:" & daINDEX - 40: MYbattleshipLBL(4).Caption = "F:" & daINDEX - 40 'displays the grid #
            End If
            If daINDEX > 60 Then 'row D
                MYbattleshipLBL(1).Caption = "D:" & daINDEX - 60: MYbattleshipLBL(2).Caption = "E:" & daINDEX - 60: MYbattleshipLBL(3).Caption = "F:" & daINDEX - 60: MYbattleshipLBL(4).Caption = "G:" & daINDEX - 60 'displays the grid #
            End If
            If daINDEX > 80 Then 'row E
                MYbattleshipLBL(1).Caption = "E:" & daINDEX - 80: MYbattleshipLBL(2).Caption = "F:" & daINDEX - 80: MYbattleshipLBL(3).Caption = "G:" & daINDEX - 80: MYbattleshipLBL(4).Caption = "H:" & daINDEX - 80 'displays the grid #
            End If
            If daINDEX > 100 Then 'row F
                MYbattleshipLBL(1).Caption = "F:" & daINDEX - 100: MYbattleshipLBL(2).Caption = "G:" & daINDEX - 100: MYbattleshipLBL(3).Caption = "H:" & daINDEX - 100: MYbattleshipLBL(4).Caption = "I:" & daINDEX - 100 'displays the grid #
            End If
            If daINDEX > 120 Then 'row G
                MYbattleshipLBL(1).Caption = "G:" & daINDEX - 120: MYbattleshipLBL(2).Caption = "H:" & daINDEX - 120: MYbattleshipLBL(3).Caption = "I:" & daINDEX - 120: MYbattleshipLBL(4).Caption = "J:" & daINDEX - 120 'displays the grid #
            End If
            If daINDEX > 140 Then 'row H
                MYbattleshipLBL(1).Caption = "H:" & daINDEX - 140: MYbattleshipLBL(2).Caption = "I:" & daINDEX - 140: MYbattleshipLBL(3).Caption = "J:" & daINDEX - 140: MYbattleshipLBL(4).Caption = "K:" & daINDEX - 140 'displays the grid #
            End If
            If daINDEX > 160 Then 'row I
                MYbattleshipLBL(1).Caption = "I:" & daINDEX - 160: MYbattleshipLBL(2).Caption = "J:" & daINDEX - 160: MYbattleshipLBL(3).Caption = "K:" & daINDEX - 160: MYbattleshipLBL(4).Caption = "L:" & daINDEX - 160 'displays the grid #
            End If
        End If
        If whichMNU = "cruiser" Then 'for cruiser
            If daINDEX > 0 Then 'for A
                MYcruiserLBL(1).Caption = "A:" & daINDEX: MYcruiserLBL(2).Caption = "B:" & daINDEX: MYcruiserLBL(3).Caption = "C:" & daINDEX 'displays the grid #
            End If
            If daINDEX > 20 Then 'for B
                MYcruiserLBL(1).Caption = "B:" & daINDEX - 20: MYcruiserLBL(2).Caption = "C:" & daINDEX - 20: MYcruiserLBL(3).Caption = "D:" & daINDEX - 20 'displays the grid #
            End If
            If daINDEX > 40 Then 'for C
                MYcruiserLBL(1).Caption = "C:" & daINDEX - 40: MYcruiserLBL(2).Caption = "D:" & daINDEX - 40: MYcruiserLBL(3).Caption = "E:" & daINDEX - 40 'displays the grid #
            End If
            If daINDEX > 60 Then 'for D
                MYcruiserLBL(1).Caption = "D:" & daINDEX - 60: MYcruiserLBL(2).Caption = "E:" & daINDEX - 60: MYcruiserLBL(3).Caption = "F:" & daINDEX - 60 'displays the grid #
            End If
            If daINDEX > 80 Then 'for E
                MYcruiserLBL(1).Caption = "E:" & daINDEX - 80: MYcruiserLBL(2).Caption = "F:" & daINDEX - 80: MYcruiserLBL(3).Caption = "G:" & daINDEX - 80 'displays the grid #
            End If
            If daINDEX > 100 Then 'for F
                MYcruiserLBL(1).Caption = "F:" & daINDEX - 100: MYcruiserLBL(2).Caption = "G:" & daINDEX - 100: MYcruiserLBL(3).Caption = "H:" & daINDEX - 100 'displays the grid #
            End If
            If daINDEX > 120 Then 'for G
                MYcruiserLBL(1).Caption = "G:" & daINDEX - 120: MYcruiserLBL(2).Caption = "H:" & daINDEX - 120: MYcruiserLBL(3).Caption = "I:" & daINDEX - 120 'displays the grid #
            End If
            If daINDEX > 140 Then 'for H
                MYcruiserLBL(1).Caption = "H:" & daINDEX - 140: MYcruiserLBL(2).Caption = "I:" & daINDEX - 140: MYcruiserLBL(3).Caption = "J:" & daINDEX - 140 'displays the grid #
            End If
            If daINDEX > 160 Then 'For I
                MYcruiserLBL(1).Caption = "I:" & daINDEX - 160: MYcruiserLBL(2).Caption = "J:" & daINDEX - 160: MYcruiserLBL(3).Caption = "K:" & daINDEX - 160 'displays the grid #
            End If
            If daINDEX > 180 Then 'for J
                MYcruiserLBL(1).Caption = "J:" & daINDEX - 180: MYcruiserLBL(2).Caption = "K:" & daINDEX - 180: MYcruiserLBL(3).Caption = "L:" & daINDEX - 180 'displays the grid #
            End If
        End If
        If whichMNU = "submarine" Then 'for submarine
            If daINDEX > 0 Then 'for A
                MYsubmarineLBL(1).Caption = "A:" & daINDEX: MYsubmarineLBL(2).Caption = "B:" & daINDEX 'displays the grid #
            End If
            If daINDEX > 20 Then 'for B
                MYsubmarineLBL(1).Caption = "B:" & daINDEX - 20: MYsubmarineLBL(2).Caption = "C:" & daINDEX - 20 'displays the grid #
            End If
            If daINDEX > 40 Then 'for C
                MYsubmarineLBL(1).Caption = "C:" & daINDEX - 40: MYsubmarineLBL(2).Caption = "D:" & daINDEX - 40 'displays the grid #
            End If
            If daINDEX > 60 Then 'for D
                MYsubmarineLBL(1).Caption = "D:" & daINDEX - 60: MYsubmarineLBL(2).Caption = "E:" & daINDEX - 60 'displays the grid #
            End If
            If daINDEX > 80 Then 'for E
                MYsubmarineLBL(1).Caption = "E:" & daINDEX - 80: MYsubmarineLBL(2).Caption = "F:" & daINDEX - 80 'displays the grid #
            End If
            If daINDEX > 100 Then 'for F
                MYsubmarineLBL(1).Caption = "F:" & daINDEX - 100: MYsubmarineLBL(2).Caption = "G:" & daINDEX - 100 'displays the grid #
            End If
            If daINDEX > 120 Then 'for G
                MYsubmarineLBL(1).Caption = "G:" & daINDEX - 120: MYsubmarineLBL(2).Caption = "H:" & daINDEX - 120 'displays the grid #
            End If
            If daINDEX > 140 Then 'for H
                MYsubmarineLBL(1).Caption = "H:" & daINDEX - 140: MYsubmarineLBL(2).Caption = "I:" & daINDEX - 140 'displays the grid #
            End If
            If daINDEX > 160 Then 'for I
                MYsubmarineLBL(1).Caption = "I:" & daINDEX - 160: MYsubmarineLBL(2).Caption = "J:" & daINDEX - 160 'displays the grid #
            End If
            If daINDEX > 180 Then 'for J
                MYsubmarineLBL(1).Caption = "J:" & daINDEX - 180: MYsubmarineLBL(2).Caption = "K:" & daINDEX - 180 'displays the grid #
            End If
            If daINDEX > 200 Then 'for K
                MYsubmarineLBL(1).Caption = "K:" & daINDEX - 200: MYsubmarineLBL(2).Caption = "L:" & daINDEX - 200 'displays the grid #
            End If
        End If
        If whichMNU = "destroyer" Then 'for destroyer
            If daINDEX > 0 Then 'for A
                MYdestroyerLBL(1).Caption = "A:" & daINDEX: MYdestroyerLBL(2).Caption = "B:" & daINDEX 'displays the grid #
            End If
            If daINDEX > 20 Then 'for B
                MYdestroyerLBL(1).Caption = "B:" & daINDEX - 20: MYdestroyerLBL(2).Caption = "C:" & daINDEX - 20 'displays the grid #
            End If
            If daINDEX > 40 Then 'for C
                MYdestroyerLBL(1).Caption = "C:" & daINDEX - 40: MYdestroyerLBL(2).Caption = "D:" & daINDEX - 40 'displays the grid #
            End If
            If daINDEX > 60 Then 'for D
                MYdestroyerLBL(1).Caption = "D:" & daINDEX - 60: MYdestroyerLBL(2).Caption = "E:" & daINDEX - 60 'displays the grid #
            End If
            If daINDEX > 80 Then 'for E
                MYdestroyerLBL(1).Caption = "E:" & daINDEX - 80: MYdestroyerLBL(2).Caption = "F:" & daINDEX - 80 'displays the grid #
            End If
            If daINDEX > 100 Then 'for F
                MYdestroyerLBL(1).Caption = "F:" & daINDEX - 100: MYdestroyerLBL(2).Caption = "G:" & daINDEX - 100 'displays the grid #
            End If
            If daINDEX > 120 Then 'for G
                MYdestroyerLBL(1).Caption = "G:" & daINDEX - 120: MYdestroyerLBL(2).Caption = "H:" & daINDEX - 120 'displays the grid #
            End If
            If daINDEX > 140 Then 'for H
                MYdestroyerLBL(1).Caption = "H:" & daINDEX - 140: MYdestroyerLBL(2).Caption = "I:" & daINDEX - 140 'displays the grid #
            End If
            If daINDEX > 160 Then 'For I
                MYdestroyerLBL(1).Caption = "I:" & daINDEX - 160: MYdestroyerLBL(2).Caption = "J:" & daINDEX - 160 'displays the grid #
            End If
            If daINDEX > 180 Then 'for J
                MYdestroyerLBL(1).Caption = "J:" & daINDEX - 180: MYdestroyerLBL(2).Caption = "K:" & daINDEX - 180 'displays the grid #
            End If
            If daINDEX > 200 Then 'for K
                MYdestroyerLBL(1).Caption = "K:" & daINDEX - 200: MYdestroyerLBL(2).Caption = "L:" & daINDEX - 200 'displays the grid #
            End If
        End If
    End If
    If WhiCHway = "lr" Then 'for left to right label input
    '*******same comments as above**********
        If whichMNU = "carrier" Then
            If daINDEX > 0 Then
                MYcarrierLBL(1).Caption = "A:" & daINDEX: MYcarrierLBL(2).Caption = "A:" & daINDEX + 1: MYcarrierLBL(3).Caption = "A:" & daINDEX + 2: MYcarrierLBL(4).Caption = "A:" & daINDEX + 3: MYcarrierLBL(5).Caption = "A:" & daINDEX + 4
            End If
            If daINDEX > 20 Then
                MYcarrierLBL(1).Caption = "B:" & daINDEX - 20: MYcarrierLBL(2).Caption = "B:" & daINDEX - 19: MYcarrierLBL(3).Caption = "B:" & daINDEX - 18: MYcarrierLBL(4).Caption = "B:" & daINDEX - 17: MYcarrierLBL(5).Caption = "B:" & daINDEX - 16
            End If
            If daINDEX > 40 Then
                MYcarrierLBL(1).Caption = "C:" & daINDEX - 40: MYcarrierLBL(2).Caption = "C:" & daINDEX - 39: MYcarrierLBL(3).Caption = "C:" & daINDEX - 38: MYcarrierLBL(4).Caption = "C:" & daINDEX - 37: MYcarrierLBL(5).Caption = "C:" & daINDEX - 36
            End If
            If daINDEX > 60 Then
                MYcarrierLBL(1).Caption = "D:" & daINDEX - 60: MYcarrierLBL(2).Caption = "D:" & daINDEX - 59: MYcarrierLBL(3).Caption = "D:" & daINDEX - 58: MYcarrierLBL(4).Caption = "D:" & daINDEX - 57: MYcarrierLBL(5).Caption = "D:" & daINDEX - 56
            End If
            If daINDEX > 80 Then
                MYcarrierLBL(1).Caption = "E:" & daINDEX - 80: MYcarrierLBL(2).Caption = "E:" & daINDEX - 79: MYcarrierLBL(3).Caption = "E:" & daINDEX - 78: MYcarrierLBL(4).Caption = "E:" & daINDEX - 77: MYcarrierLBL(5).Caption = "E:" & daINDEX - 76
            End If
            If daINDEX > 100 Then
                MYcarrierLBL(1).Caption = "F:" & daINDEX - 100: MYcarrierLBL(2).Caption = "F:" & daINDEX - 99: MYcarrierLBL(3).Caption = "F:" & daINDEX - 98: MYcarrierLBL(4).Caption = "F:" & daINDEX - 97: MYcarrierLBL(5).Caption = "F:" & daINDEX - 96
            End If
            If daINDEX > 120 Then
                MYcarrierLBL(1).Caption = "G:" & daINDEX - 120: MYcarrierLBL(2).Caption = "G:" & daINDEX - 119: MYcarrierLBL(3).Caption = "G:" & daINDEX - 118: MYcarrierLBL(4).Caption = "G:" & daINDEX - 117: MYcarrierLBL(5).Caption = "G:" & daINDEX - 116
            End If
            If daINDEX > 140 Then
                MYcarrierLBL(1).Caption = "H:" & daINDEX - 140: MYcarrierLBL(2).Caption = "H:" & daINDEX - 139: MYcarrierLBL(3).Caption = "H:" & daINDEX - 138: MYcarrierLBL(4).Caption = "H:" & daINDEX - 137: MYcarrierLBL(5).Caption = "H:" & daINDEX - 136
            End If
            If daINDEX > 160 Then
                MYcarrierLBL(1).Caption = "I:" & daINDEX - 160: MYcarrierLBL(2).Caption = "I:" & daINDEX - 159: MYcarrierLBL(3).Caption = "I:" & daINDEX - 158: MYcarrierLBL(4).Caption = "I:" & daINDEX - 157: MYcarrierLBL(5).Caption = "I:" & daINDEX - 156
            End If
            If daINDEX > 180 Then
                MYcarrierLBL(1).Caption = "J:" & daINDEX - 180: MYcarrierLBL(2).Caption = "J:" & daINDEX - 179: MYcarrierLBL(3).Caption = "J:" & daINDEX - 178: MYcarrierLBL(4).Caption = "J:" & daINDEX - 177: MYcarrierLBL(5).Caption = "J:" & daINDEX - 176
            End If
            If daINDEX > 200 Then
                MYcarrierLBL(1).Caption = "K:" & daINDEX - 200: MYcarrierLBL(2).Caption = "K:" & daINDEX - 199: MYcarrierLBL(3).Caption = "K:" & daINDEX - 198: MYcarrierLBL(4).Caption = "K:" & daINDEX - 197: MYcarrierLBL(5).Caption = "K:" & daINDEX - 196
            End If
            If daINDEX > 220 Then
                MYcarrierLBL(1).Caption = "L:" & daINDEX - 220: MYcarrierLBL(2).Caption = "L:" & daINDEX - 219: MYcarrierLBL(3).Caption = "L:" & daINDEX - 218: MYcarrierLBL(4).Caption = "L:" & daINDEX - 217: MYcarrierLBL(5).Caption = "L:" & daINDEX - 216
            End If
        End If
        If whichMNU = "battleship" Then
            If daINDEX > 0 Then
                MYbattleshipLBL(1).Caption = "A:" & daINDEX: MYbattleshipLBL(2).Caption = "A:" & daINDEX + 1: MYbattleshipLBL(3).Caption = "A:" & daINDEX + 2: MYbattleshipLBL(4).Caption = "A:" & daINDEX + 3
            End If
            If daINDEX > 20 Then
                MYbattleshipLBL(1).Caption = "B:" & daINDEX - 20: MYbattleshipLBL(2).Caption = "B:" & daINDEX - 19: MYbattleshipLBL(3).Caption = "B:" & daINDEX - 18: MYbattleshipLBL(4).Caption = "B:" & daINDEX - 17
            End If
            If daINDEX > 40 Then
                MYbattleshipLBL(1).Caption = "C:" & daINDEX - 40: MYbattleshipLBL(2).Caption = "C:" & daINDEX - 39: MYbattleshipLBL(3).Caption = "C:" & daINDEX - 38: MYbattleshipLBL(4).Caption = "C:" & daINDEX - 37
            End If
            If daINDEX > 60 Then
                MYbattleshipLBL(1).Caption = "D:" & daINDEX - 60: MYbattleshipLBL(2).Caption = "D:" & daINDEX - 59: MYbattleshipLBL(3).Caption = "D:" & daINDEX - 58: MYbattleshipLBL(4).Caption = "D:" & daINDEX - 57
            End If
            If daINDEX > 80 Then
                MYbattleshipLBL(1).Caption = "E:" & daINDEX - 80: MYbattleshipLBL(2).Caption = "E:" & daINDEX - 79: MYbattleshipLBL(3).Caption = "E:" & daINDEX - 78: MYbattleshipLBL(4).Caption = "E:" & daINDEX - 77
            End If
            If daINDEX > 100 Then
                MYbattleshipLBL(1).Caption = "F:" & daINDEX - 100: MYbattleshipLBL(2).Caption = "F:" & daINDEX - 99: MYbattleshipLBL(3).Caption = "F:" & daINDEX - 98: MYbattleshipLBL(4).Caption = "F:" & daINDEX - 97
            End If
            If daINDEX > 120 Then
                MYbattleshipLBL(1).Caption = "G:" & daINDEX - 120: MYbattleshipLBL(2).Caption = "G:" & daINDEX - 119: MYbattleshipLBL(3).Caption = "G:" & daINDEX - 118: MYbattleshipLBL(4).Caption = "G:" & daINDEX - 117
            End If
            If daINDEX > 140 Then
                MYbattleshipLBL(1).Caption = "H:" & daINDEX - 140: MYbattleshipLBL(2).Caption = "H:" & daINDEX - 139: MYbattleshipLBL(3).Caption = "H:" & daINDEX - 138: MYbattleshipLBL(4).Caption = "H:" & daINDEX - 137
            End If
            If daINDEX > 160 Then
                MYbattleshipLBL(1).Caption = "I:" & daINDEX - 160: MYbattleshipLBL(2).Caption = "I:" & daINDEX - 159: MYbattleshipLBL(3).Caption = "I:" & daINDEX - 158: MYbattleshipLBL(4).Caption = "I:" & daINDEX - 157
            End If
            If daINDEX > 180 Then
                MYbattleshipLBL(1).Caption = "J:" & daINDEX - 180: MYbattleshipLBL(2).Caption = "J:" & daINDEX - 179: MYbattleshipLBL(3).Caption = "J:" & daINDEX - 178: MYbattleshipLBL(4).Caption = "J:" & daINDEX - 177
            End If
            If daINDEX > 200 Then
                MYbattleshipLBL(1).Caption = "K:" & daINDEX - 200: MYbattleshipLBL(2).Caption = "K:" & daINDEX - 199: MYbattleshipLBL(3).Caption = "K:" & daINDEX - 198: MYbattleshipLBL(4).Caption = "K:" & daINDEX - 197
            End If
            If daINDEX > 220 Then
                MYbattleshipLBL(1).Caption = "L:" & daINDEX - 220: MYbattleshipLBL(2).Caption = "L:" & daINDEX - 219: MYbattleshipLBL(3).Caption = "L:" & daINDEX - 218: MYbattleshipLBL(4).Caption = "L:" & daINDEX - 217
            End If
        End If
        If whichMNU = "cruiser" Then
            If daINDEX > 0 Then
                MYcruiserLBL(1).Caption = "A:" & daINDEX: MYcruiserLBL(2).Caption = "A:" & daINDEX + 1: MYcruiserLBL(3).Caption = "A:" & daINDEX + 2
            End If
            If daINDEX > 20 Then
                MYcruiserLBL(1).Caption = "B:" & daINDEX - 20: MYcruiserLBL(2).Caption = "B:" & daINDEX - 19: MYcruiserLBL(3).Caption = "B:" & daINDEX - 18
            End If
            If daINDEX > 40 Then
                MYcruiserLBL(1).Caption = "C:" & daINDEX - 40: MYcruiserLBL(2).Caption = "C:" & daINDEX - 39: MYcruiserLBL(3).Caption = "C:" & daINDEX - 38
            End If
            If daINDEX > 60 Then
                MYcruiserLBL(1).Caption = "D:" & daINDEX - 60: MYcruiserLBL(2).Caption = "D:" & daINDEX - 59: MYcruiserLBL(3).Caption = "D:" & daINDEX - 58
            End If
            If daINDEX > 80 Then
                MYcruiserLBL(1).Caption = "E:" & daINDEX - 80: MYcruiserLBL(2).Caption = "E:" & daINDEX - 79: MYcruiserLBL(3).Caption = "E:" & daINDEX - 78
            End If
            If daINDEX > 100 Then
                MYcruiserLBL(1).Caption = "F:" & daINDEX - 100: MYcruiserLBL(2).Caption = "F:" & daINDEX - 99: MYcruiserLBL(3).Caption = "F:" & daINDEX - 98
            End If
            If daINDEX > 120 Then
                MYcruiserLBL(1).Caption = "G:" & daINDEX - 120: MYcruiserLBL(2).Caption = "G:" & daINDEX - 119: MYcruiserLBL(3).Caption = "G:" & daINDEX - 118
            End If
            If daINDEX > 140 Then
                MYcruiserLBL(1).Caption = "H:" & daINDEX - 140: MYcruiserLBL(2).Caption = "H:" & daINDEX - 139: MYcruiserLBL(3).Caption = "H:" & daINDEX - 138
            End If
            If daINDEX > 160 Then
                MYcruiserLBL(1).Caption = "I:" & daINDEX - 160: MYcruiserLBL(2).Caption = "I:" & daINDEX - 159: MYcruiserLBL(3).Caption = "I:" & daINDEX - 158
            End If
            If daINDEX > 180 Then
                MYcruiserLBL(1).Caption = "J:" & daINDEX - 180: MYcruiserLBL(2).Caption = "J:" & daINDEX - 179: MYcruiserLBL(3).Caption = "J:" & daINDEX - 178
            End If
            If daINDEX > 200 Then
                MYcruiserLBL(1).Caption = "K:" & daINDEX - 200: MYcruiserLBL(2).Caption = "K:" & daINDEX - 199: MYcruiserLBL(3).Caption = "K:" & daINDEX - 198
            End If
            If daINDEX > 220 Then
                MYcruiserLBL(1).Caption = "L:" & daINDEX - 220: MYcruiserLBL(2).Caption = "L:" & daINDEX - 219: MYcruiserLBL(3).Caption = "L:" & daINDEX - 218
            End If
        End If
        If whichMNU = "submarine" Then
            If daINDEX > 0 Then
                MYsubmarineLBL(1).Caption = "A:" & daINDEX: MYsubmarineLBL(2).Caption = "A:" & daINDEX + 1
            End If
            If daINDEX > 20 Then
                MYsubmarineLBL(1).Caption = "B:" & daINDEX - 20: MYsubmarineLBL(2).Caption = "B:" & daINDEX - 19
            End If
            If daINDEX > 40 Then
                MYsubmarineLBL(1).Caption = "C:" & daINDEX - 40: MYsubmarineLBL(2).Caption = "C:" & daINDEX - 39
            End If
            If daINDEX > 60 Then
                MYsubmarineLBL(1).Caption = "D:" & daINDEX - 60: MYsubmarineLBL(2).Caption = "D:" & daINDEX - 59
            End If
            If daINDEX > 80 Then
                MYsubmarineLBL(1).Caption = "E:" & daINDEX - 80: MYsubmarineLBL(2).Caption = "E:" & daINDEX - 79
            End If
            If daINDEX > 100 Then
                MYsubmarineLBL(1).Caption = "F:" & daINDEX - 100: MYsubmarineLBL(2).Caption = "F:" & daINDEX - 99
            End If
            If daINDEX > 120 Then
                MYsubmarineLBL(1).Caption = "G:" & daINDEX - 120: MYsubmarineLBL(2).Caption = "G:" & daINDEX - 119
            End If
            If daINDEX > 140 Then
                MYsubmarineLBL(1).Caption = "H:" & daINDEX - 140: MYsubmarineLBL(2).Caption = "H:" & daINDEX - 139
            End If
            If daINDEX > 160 Then
                MYsubmarineLBL(1).Caption = "I:" & daINDEX - 160: MYsubmarineLBL(2).Caption = "I:" & daINDEX - 159
            End If
            If daINDEX > 180 Then
                MYsubmarineLBL(1).Caption = "J:" & daINDEX - 180: MYsubmarineLBL(2).Caption = "J:" & daINDEX - 179
            End If
            If daINDEX > 200 Then
                MYsubmarineLBL(1).Caption = "K:" & daINDEX - 200: MYsubmarineLBL(2).Caption = "K:" & daINDEX - 199
            End If
            If daINDEX > 220 Then
                MYsubmarineLBL(1).Caption = "L:" & daINDEX - 220: MYsubmarineLBL(2).Caption = "L:" & daINDEX - 219
            End If
        End If
        If whichMNU = "destroyer" Then
            If daINDEX > 0 Then
                MYdestroyerLBL(1).Caption = "A:" & daINDEX: MYdestroyerLBL(2).Caption = "A:" & daINDEX + 1
            End If
            If daINDEX > 20 Then
                MYdestroyerLBL(1).Caption = "B:" & daINDEX - 20: MYdestroyerLBL(2).Caption = "B:" & daINDEX - 19
            End If
            If daINDEX > 40 Then
                MYdestroyerLBL(1).Caption = "C:" & daINDEX - 40: MYdestroyerLBL(2).Caption = "C:" & daINDEX - 39
            End If
            If daINDEX > 60 Then
                MYdestroyerLBL(1).Caption = "D:" & daINDEX - 60: MYdestroyerLBL(2).Caption = "D:" & daINDEX - 59
            End If
            If daINDEX > 80 Then
                MYdestroyerLBL(1).Caption = "E:" & daINDEX - 80: MYdestroyerLBL(2).Caption = "E:" & daINDEX - 79
            End If
            If daINDEX > 100 Then
                MYdestroyerLBL(1).Caption = "F:" & daINDEX - 100: MYdestroyerLBL(2).Caption = "F:" & daINDEX - 99
            End If
            If daINDEX > 120 Then
                MYdestroyerLBL(1).Caption = "G:" & daINDEX - 120: MYdestroyerLBL(2).Caption = "G:" & daINDEX - 119
            End If
            If daINDEX > 140 Then
                MYdestroyerLBL(1).Caption = "H:" & daINDEX - 140: MYdestroyerLBL(2).Caption = "H:" & daINDEX - 139
            End If
            If daINDEX > 160 Then
                MYdestroyerLBL(1).Caption = "I:" & daINDEX - 160: MYdestroyerLBL(2).Caption = "I:" & daINDEX - 159
            End If
            If daINDEX > 180 Then
                MYdestroyerLBL(1).Caption = "J:" & daINDEX - 180: MYdestroyerLBL(2).Caption = "J:" & daINDEX - 179
            End If
            If daINDEX > 200 Then
                MYdestroyerLBL(1).Caption = "K:" & daINDEX - 200: MYdestroyerLBL(2).Caption = "K:" & daINDEX - 199
            End If
            If daINDEX > 220 Then
                MYdestroyerLBL(1).Caption = "L:" & daINDEX - 220: MYdestroyerLBL(2).Caption = "L:" & daINDEX - 219
            End If
        End If
        '********end same comments*****
    End If

End Sub

Private Sub Form_Load()
    Me.Height = CarrierLBL.Top + 800 'sets form height
    CenterForm Me 'centers frm
    startgameTMR.Enabled = False 'keeps disabled till necessary
    
    Dim z 'hold integer
    For z = 1 To 240 '#represents the index of the array's in the field object
        Field(z).BackColor = &H800000 'changes color to blue
        Field(z).Picture = nopicturePIC.Picture 'makes all pic box's have NO PIC
    Next 'loops around till all numbers done... then move right along
    ShiPcount = 0 'sets ship count to 0 (will be increased as u select ships)
    playerTURN = "0" 'sets the playerturn(review the declarations for mroe info)
    isGAME = 0 'sets the game over deciding feature to 0(will be increased as u fing the server's ships)
    
    WhiCHway = "" 'clears string
    whichMNU = "" 'clears string
    
End Sub

Sub startNEWgame()
    Form_Load 'does all functions in the Form_Load event
    daINDEX = 0 'sets daindex to 0
        Dim Ng 'integer used
        For Ng = 1 To 5 'represent array #'s
            MYcarrierLBL(Ng).Caption = "" 'clears the lbl
            MYcarrierLBL(Ng).BackColor = &H808080 'changes color back to grey
        Next 'loops till ALL NUMBERS ARE DONE!!!!!!!!!!!!!!!  woohoo
        For Ng = 1 To 4 'represents array #'s
            MYbattleshipLBL(Ng).Caption = "" 'clears the lbl
            MYbattleshipLBL(Ng).BackColor = &H808080 'changes BG to grey
        Next 'see last comment on next (u can tell im having fun!!hehe)
        For Ng = 1 To 3 'represents array #'s
            MYcruiserLBL(Ng).Caption = "" 'clears the lbl
            MYcruiserLBL(Ng).BackColor = &H808080 'changes BG to grey
        Next 'does stuff that u should know by now... hehe (refer above if really necessary)
        For Ng = 1 To 2 'represents array #'s
            MYsubmarineLBL(Ng).Caption = "" 'clears the lbl
            MYdestroyerLBL(Ng).Caption = "" 'clears the lbl
            MYsubmarineLBL(Ng).BackColor = &H808080 'changes BG to grey
            MYdestroyerLBL(Ng).BackColor = &H808080 'changes BG to grey
        Next 'proceeds to next line of code
        For Ng = 1 To 240 'represents array #'s
            If Field(Ng).Picture = hitPIC.Picture Then Field(Ng).Picture = nopicturePIC.Picture 'changes the picture boxes back so they have no pictures
        Next 'NEXT ALREADY!!
        CarrierLBL.Enabled = True: battleshipLBL.Enabled = True: CruiserLBL.Enabled = True: SubMarineLBL.Enabled = True: DestroyerLBL.Enabled = True 'lets menu's work
            Winsock.SendData "Z" & "Select Your Ships..." 'tells server to start new game
End Sub

Private Sub startgameTMR_Timer()
    Winsock.SendData "A" & "Client is ready..." 'sends data at intervals till client is ready
    
End Sub

Private Sub SubMarineLBL_Click()
    'used for the MENUFRM
    FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
    whichMNU = "submarine" 'tells mnufrm that submarine was clicked!!
    'sets position of menuFRM
    MenuFRM.Left = Me.Left + 1680
    MenuFRM.Top = Me.Top + 8950
    MenuFRM.Show
    
End Sub


Private Sub sendtextCMD_Click()
If sendTXT.Text = "" Then Exit Sub 'wont let u send NOTEXT!!!  type something PLEASE
    MainTXT.SelColor = vbRed: MainTXT.SelBold = True: MainTXT.SelText = nickCLIENT.Caption & ":":  MainTXT.SelBold = False: MainTXT.SelColor = vbBlack 'makes it look all pretty    hehe
    MainTXT.SelText = "     " & sendTXT.Text & vbCrLf  'puts what u typed in ur maintxt
    Winsock.SendData "T" & sendTXT.Text 'sends the data to the server
    sendTXT.Text = "" 'clears the txtbox u typed in

End Sub

'===========================================================================
'======================Displays info if disconnected========================
Private Sub Winsock_Close()
    MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = vbRed: MainTXT.SelText = "Disconnected to Server": MainTXT.SelColor = vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & vbCrLf 'displays u are disconnected
    sendtextCMD.Enabled = False 'this wont let you send text anymore since server is disconnected
End Sub

'===========================================================================
'=======================RETREIVES DATA FROM SERVER==========================
Private Sub winsock_DataArrival(ByVal bytesTotal As Long)
Dim strData, strData2 As String 'where the data sent by the client will be stored
Call Winsock.GetData(strData, vbString) 'gets the data sent by the client

strData2 = Left(strData, 1) 'saves the first variable's value to strData2
strData = Mid(strData, 2) 'saves the text the server sent to strData

If strData2 = "C" Then 'tells form to load and do other form stuff
    nickSERVER.Caption = strData 'loads the server's username from data sent
    Me.Show 'shows Client frm
    Unload ConnectFRM 'unloads the connect frm
    Winsock.SendData "N" & nickCLIENT.Caption 'sends your username to the server
    ClientFRM.Caption = "Battleship Online   [Welcome, " & nickCLIENT.Caption & "!]" 'renames the form approiately
    MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = vbRed: MainTXT.SelText = "Connected to Server": MainTXT.SelColor = vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & vbCrLf 'displays that connection worked
    GameStatsLBL.Caption = "Select Your Ships..." 'displays stuff telling u to do stuff
    PlayWav "defend.wav" 'plays a .wav that simulates a start game sound
End If

If strData2 = "T" Then
    MainTXT.SelColor = vbBlue: MainTXT.SelBold = True: MainTXT.SelText = nickSERVER.Caption & ":": MainTXT.SelBold = False: MainTXT.SelColor = vbBlack 'makes it look all nice and pretty
    MainTXT.SelText = "     " & strData & vbCrLf  'adds data to textbox
End If

'////////////////////////////// strings for ships for north to south
'K = carrier
'B = battleship
'R = cruiser
'S = submarine
'D = destroyer
'////////////////////////////// strings for ships for left to right
'I = carrier
'L = battleship
'U = cruiser
'E = submarine
'O = destroyer
Dim fiKi As String 'fiki is used to replace strData
    'this is for North to South ships
    If strData2 = "K" Then 'carrier
        fiKi = strData 'changes over to Fiki
        carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 20: carrierTXT(3).Text = fiKi + 40: carrierTXT(4).Text = fiKi + 60: carrierTXT(5).Text = fiKi + 80 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "B" Then 'battleship
        fiKi = strData 'changes over to fiki
        battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 20: battleshipTXT(3).Text = fiKi + 40: battleshipTXT(4).Text = fiKi + 60 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "R" Then 'cruiser
        fiKi = strData 'changes strings
        cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 20: cruiserTXT(3).Text = fiKi + 40 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "S" Then 'submarine
        fiKi = strData 'changes strings
        submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 20 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "D" Then 'destroyer
        fiKi = strData 'changes strings
        destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 20 'puts the position of the server's ship into hidden txt file
    End If
    'this is for Left to RIGHT ships
    If strData2 = "I" Then 'carrier
        fiKi = strData 'changes strings
        carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 1: carrierTXT(3).Text = fiKi + 2: carrierTXT(4).Text = fiKi + 3: carrierTXT(5).Text = fiKi + 4 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "L" Then 'battleship
        fiKi = strData 'changes strings
        battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 1: battleshipTXT(3).Text = fiKi + 2: battleshipTXT(4).Text = fiKi + 3 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "U" Then 'cruiser
        fiKi = strData 'changes strings
        cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 1: cruiserTXT(3).Text = fiKi + 2 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "E" Then 'submarine
        fiKi = strData 'changes strings
        submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 1 'puts the position of the server's ship into hidden txt file
    End If
    If strData2 = "O" Then 'destroyer
        fiKi = strData 'changes strings
        destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 1 'puts the position of the server's ship into hidden txt file
    End If
'==========================================================
    'this starts the game
Dim uO 'holds integer
    If strData2 = "A" Then 'server is ready for u
        If ShiPcount = 10 Then 'u are ready too
            Winsock.SendData "Y" & "Your Turn..." 'tell em ur ready
            GameStatsLBL.Caption = nickSERVER & "'s Turn..." 'display ur ready
            startgameTMR.Enabled = False 'disable tmr cause ur ready already!! hehe
            For uO = 1 To 240 'represents array index of field
                Field(uO).Enabled = True 'enables field so u can play now!!  yeehaa
            Next 'god another next!
        End If
        If ShiPcount < 5 Then 'sorry not ready yet!!! try again
            GameStatsLBL.Caption = nickSERVER & " is waiting for you to finish!" 'show em that they are waiting for u to finish
        End If
    End If
    If strData2 = "Y" Then 'YEAHHH!!!!!  I am ready and the server is ready!!!
        GameStatsLBL.Caption = strData 'display how ready i am
        startgameTMR.Enabled = False 'im ready... i dont need this now
            For uO = 1 To 240 'represents the array of the index of field
                Field(uO).Enabled = True 'enables em so i can play!
            Next 'ughh
    End If
'============================================================
    'this shows a hit
    If strData2 = "H" Then 'H means HIT
        If strData = "C1" Then MYcarrierLBL(1).BackColor = vbRed 'show it RED for BLOOD!
        If strData = "C2" Then MYcarrierLBL(2).BackColor = vbRed 'show it red
        If strData = "C3" Then MYcarrierLBL(3).BackColor = vbRed 'show it red
        If strData = "C4" Then MYcarrierLBL(4).BackColor = vbRed 'show it red
        If strData = "C5" Then MYcarrierLBL(5).BackColor = vbRed 'show it red
    
        If strData = "B1" Then MYbattleshipLBL(1).BackColor = vbRed 'show it red
        If strData = "B2" Then MYbattleshipLBL(2).BackColor = vbRed 'show it red
        If strData = "B3" Then MYbattleshipLBL(3).BackColor = vbRed 'show it red
        If strData = "B4" Then MYbattleshipLBL(4).BackColor = vbRed 'show it red
    
        If strData = "R1" Then MYcruiserLBL(1).BackColor = vbRed 'show it red
        If strData = "R2" Then MYcruiserLBL(2).BackColor = vbRed 'show it red
        If strData = "R3" Then MYcruiserLBL(3).BackColor = vbRed 'show it red
    
        If strData = "S1" Then MYsubmarineLBL(1).BackColor = vbRed 'show it red
        If strData = "S2" Then MYsubmarineLBL(2).BackColor = vbRed 'show it red
    
        If strData = "D1" Then MYdestroyerLBL(1).BackColor = vbRed 'show it red
        If strData = "D2" Then MYdestroyerLBL(2).BackColor = vbRed 'show it red
    
            GameStatsLBL.Caption = "Your Turn..." 'display whos turn it is
            isGAME = isGAME + 1 'hey thats one part of a ship down...
            playerTURN = "1" 'Clients turn
            PlayWav "drip.wav" 'plays a sound for ur turn
                If isGAME = 16 Then 'game over already?
                    Winsock.SendData "P" & " Won!" 'sends data that server WON!
                    GameStatsLBL.Caption = nickSERVER & " Won!" 'shows that he/she/it won
                    PlayWav "spacede.wav" 'plays nice loser music
                    NewgameFRM.Show 1 'asks if u wanna go for another round??
                End If
    End If
    
    'this shows a miss
    If strData2 = "M" Then 'M means MISS!!!
        PlayWav "drip.wav" 'play a sound for ur turn
        GameStatsLBL.Caption = strData 'nice little caption
        playerTURN = "1" 'clients turn!
    End If
    
    'this shows a win
    If strData2 = "P" Then 'P means WIN!! yeah!
        PlayWav "clap.wav" 'nice little .wav for a VICTORY OVER THE SERVER!!!
        GameStatsLBL.Caption = nickCLIENT & strData 'shows u won!  yeah!!!!
        NewgameFRM.Show 1 'asks if u wanna play again
    End If
    
    'starts a new game
    If strData2 = "Z" Then 'Z means NEWGAME
        If GameStatsLBL.Caption = strData Then 'ready for new game
            startNEWgame 'start a new game
            Winsock.SendData "F" & strData 'tells em u wanna play again
            Else 'what if they arent ready yet!
                Exit Sub
        End If
    End If
    If strData2 = "F" Then startNEWgame 'ok their ready now

End Sub


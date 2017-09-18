VERSION 5.00
Object = "{27E4261E-9145-11D2-BAC5-0080C8F21830}#1.0#0"; "XListBox.ocx"
Begin VB.Form Form1 
   Caption         =   "SuperList demo"
   ClientHeight    =   3255
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4785
   FillColor       =   &H00404040&
   FillStyle       =   2  'Horizontal Line
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   3260.094
   ScaleMode       =   0  'User
   ScaleWidth      =   4785
   StartUpPosition =   3  'Windows Default
   Begin SuperListOCX.SuperListBox XListBox1 
      Height          =   1815
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   4215
      _ExtentX        =   7435
      _ExtentY        =   3201
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   "SuperListBox2"
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Tabular Listbox"
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   2280
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
    With XListBox1
        .Clear
        .AddColumn 8
        .AddColumn 20
        .AddItem "1" & vbTab & "Rossi" & vbTab & "Mario"
        .AddItem "2" & vbTab & "Bianchi" & vbTab & "Roberto"
        .AddItem "3" & vbTab & "Verdi" & vbTab & "Giuseppe"
    End With
End Sub



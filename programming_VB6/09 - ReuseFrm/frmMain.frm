VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Reusable Forms Demo"
   ClientHeight    =   1755
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   1755
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOptionsTwo 
      Caption         =   "Options Form Two"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2400
      TabIndex        =   3
      Top             =   960
      Width           =   2055
   End
   Begin VB.CommandButton cmdCalendar 
      Caption         =   "Calendar"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   2
      Top             =   240
      Width           =   2055
   End
   Begin VB.CommandButton cmdOptionsOne 
      Caption         =   "Options Form One"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   960
      Width           =   2055
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2400
      TabIndex        =   0
      Top             =   240
      Width           =   2055
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False
'##project:DisableMessages CodeAnalysis

Option Explicit

' this will let us receive events from the FrmCalendar module
Dim WithEvents Calendar As frmCalendar
Attribute Calendar.VB_VarHelpID = -1

Private Sub cmdOptionsOne_Click()
    Dim frm As New frmOptions

    frm.DialogTitle = "Options One"
    frm.AddFrame "F1", "First Group"
    frm.AddOption "O1", "&1. First", True
    frm.AddOption "O2", "&2. Second"
    frm.AddOption "O3", "&3. Third"

    frm.AddFrame "F2", "Second Group"
    frm.AddOption "O4", "&4. Fourth", True
    frm.AddOption "O5", "&5. Fifth"
    frm.AddOption "O6", "&6. Sixth"
    frm.AddCheck "C1", "&7. Check one", True
    frm.AddCheck "C2", "&8. Check two"

    frm.Show vbModal

    If frm.CancelPressed Then
        MsgBox "Command canceled", vbInformation
    Else
        MsgBox "Option button in first frame: " & frm.Value("F1") & vbCr _
            & "Option button in second frame: " & frm.Value("F2") & vbCr _
            & "First checkbox : " & frm.Value("C1") & vbCr _
            & "Second checkbox: " & frm.Value("c2") & vbCr, _
            vbInformation, "Result of Options form"
    End If
End Sub

Private Sub cmdOptionsTwo_Click()
    Dim frm As New frmOptions

    frm.DialogTitle = "Options Two"
    frm.AddFrame "F1", "First Group"
    frm.AddCheck "C1", "&1. Check one", True
    frm.AddCheck "C2", "&2. Check two"

    frm.AddFrame "F2", "Second Group"
    frm.AddOption "O1", "&3. First", True
    frm.AddOption "O2", "&4. Second"

    frm.AddFrame "F3", "Third Group"
    frm.AddOption "O3", "&5. Third", True
    frm.AddOption "O4", "&6. Fourth"
    frm.AddOption "O5", "&7. Fifth"

    frm.Show vbModal

    If frm.CancelPressed Then
        MsgBox "Command canceled", vbInformation
    Else
        MsgBox "First checkbox : " & frm.Value("C1") & vbCr _
            & "Second checkbox: " & frm.Value("C2") & vbCr _
            & "Option button in second frame: " & frm.Value("F2") & vbCr _
            & "Option button in third frame: " & frm.Value("F3") & vbCr, _
            vbInformation, "Result of Options form"
    End If

End Sub

Private Sub cmdCalendar_Click()
    Set Calendar = New frmCalendar
    Load Calendar
    
    With Calendar
        .FirstDayOfWeek = vbMonday
        .SaturdayIsHoliday = True
        .ShowMonth 1997, 8, 15
        .Show
    End With
End Sub

' this event fires when a new date has been
' selected in the calendar form

Private Sub Calendar_DateChanged(newDate As Date)
    lblStatus = Format(newDate, "Long Date")
End Sub

' this event fires when the calendar is being closed

Private Sub Calendar_Unload(CancelPressed As Boolean)
    lblStatus = ""
    If CancelPressed Then
        MsgBox "Command canceled", vbInformation
    Else
        MsgBox "Selected date: " & Format$(Calendar.SelectedDate, "Long Date"), vbInformation
    End If
    ' we don't need this any longer
    Set Calendar = Nothing
End Sub



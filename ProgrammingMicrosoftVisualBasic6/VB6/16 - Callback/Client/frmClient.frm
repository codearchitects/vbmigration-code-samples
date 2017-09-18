VERSION 5.00
Begin VB.Form frmClient 
   Caption         =   "Print Client"
   ClientHeight    =   2835
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7545
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   2835
   ScaleWidth      =   7545
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstPrimes 
      Height          =   1260
      Left            =   3120
      TabIndex        =   4
      Top             =   1080
      Width           =   2175
   End
   Begin VB.CommandButton cmdFindPrime 
      Caption         =   "Find Primes"
      Height          =   495
      Left            =   480
      TabIndex        =   3
      Top             =   1080
      Width           =   2415
   End
   Begin VB.CommandButton cmdMsgBox 
      Caption         =   "Message Box"
      Height          =   495
      Left            =   480
      TabIndex        =   2
      Top             =   1920
      Width           =   2415
   End
   Begin VB.CommandButton cmdStart 
      Caption         =   "Start Print Job"
      Height          =   495
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   2415
   End
   Begin VB.Label lblPrimes 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   3120
      TabIndex        =   5
      Top             =   2400
      Width           =   2175
   End
   Begin VB.Label lblStatus 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Inactive"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3120
      TabIndex        =   1
      Top             =   240
      Width           =   3975
   End
End
Attribute VB_Name = "frmClient"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Running As Boolean
    
' evaluate all prime numbers

Private Sub cmdFindPrime_Click()
    Dim n As Long, i As Long
    ReDim primes(1000) As Long
    Dim numPrimes As Long
    
    ' if already active, stop the process
    If Running Then
        Running = False
        Exit Sub
    End If
    
    ' else, change status and caption
    Running = True
    cmdFindPrime.Caption = "Stop Find"
    lstPrimes.Clear
    
    ' a very stupid and non-optimized algorithm
    n = 1
    Do
        n = n + 1
        For i = 1 To numPrimes
            If (n Mod primes(i)) = 0 Then Exit For
        Next
        If i > numPrimes Then
            ' we've found a prime number
            numPrimes = numPrimes + 1
            If numPrimes > UBound(primes) Then
                ' make room in the primes array is necessary
                ReDim Preserve primes(numPrimes + 999) As Long
            End If
            primes(numPrimes) = n
            
            ' add to the listbox and update the label
            lstPrimes.AddItem Str(n)
            lblPrimes.Caption = "Found: " & numPrimes
            ' this is necessary to let the user click other buttons
            DoEvents
            ' if cancel was pressed, bail out
            If Not Running Then Exit Do
        End If
    Loop
    
    ' restore original caption
    cmdFindPrime.Caption = "Find Primes"
    
End Sub

Private Sub cmdMsgBox_Click()
    MsgBox "Click Me Please"
End Sub

' start the (simulated) printing process

Private Sub cmdStart_Click()
    Dim prn As PrintServer.CPrinter
    
    ' disable this button until the process has completed
    frmClient.cmdStart.Enabled = False
    
    ' ask the CPrinter server to spool a fictitious file
    Set prn = New PrintServer.CPrinter
    prn.StartPrintJob "a dummy filename", New CallbackCls
    
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    If Running Then
        ' refuse to exit if any code is running
        MsgBox "Please stop the program before quitting", vbExclamation
        Cancel = True
    ElseIf cmdStart.Enabled = False Then
        ' refuse to exit if callback calls are coming
        MsgBox "Please wait until the print job is active", vbExclamation
        Cancel = True
    End If
End Sub


VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Stars"
   ClientHeight    =   8400
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10800
   LinkTopic       =   "Form1"
   ScaleHeight     =   560
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   720
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command3 
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   1
      Left            =   5520
      TabIndex        =   37
      Top             =   480
      Width           =   255
   End
   Begin VB.CommandButton Command3 
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   5280
      TabIndex        =   36
      Top             =   480
      Width           =   255
   End
   Begin VB.ComboBox Combo2 
      Height          =   315
      Left            =   5880
      Style           =   2  'Dropdown List
      TabIndex        =   35
      Top             =   480
      Width           =   735
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Now"
      Height          =   255
      Left            =   4080
      TabIndex        =   34
      Top             =   480
      Width           =   615
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   5880
      Style           =   2  'Dropdown List
      TabIndex        =   32
      Top             =   120
      Width           =   735
   End
   Begin VB.OptionButton Option2 
      Caption         =   "Rew"
      Height          =   255
      Index           =   2
      Left            =   7200
      Style           =   1  'Graphical
      TabIndex        =   31
      Top             =   120
      Width           =   495
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Refresh"
      Height          =   255
      Left            =   9360
      TabIndex        =   9
      Top             =   480
      Width           =   855
   End
   Begin VB.HScrollBar HScroll1 
      Height          =   255
      LargeChange     =   5
      Left            =   7200
      Max             =   30
      Min             =   1
      TabIndex        =   28
      Top             =   480
      Value           =   1
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   375
      Left            =   3840
      TabIndex        =   25
      Top             =   120
      Width           =   1095
      Begin VB.OptionButton Option1 
         Caption         =   "24"
         Height          =   255
         Index           =   2
         Left            =   720
         Style           =   1  'Graphical
         TabIndex        =   38
         Top             =   0
         Width           =   375
      End
      Begin VB.OptionButton Option1 
         Caption         =   "PM"
         Height          =   255
         Index           =   1
         Left            =   360
         Style           =   1  'Graphical
         TabIndex        =   27
         Top             =   0
         Width           =   375
      End
      Begin VB.OptionButton Option1 
         Caption         =   "AM"
         Height          =   255
         Index           =   0
         Left            =   0
         Style           =   1  'Graphical
         TabIndex        =   26
         Top             =   0
         Width           =   375
      End
   End
   Begin VB.OptionButton Option2 
      Caption         =   "Stop"
      Height          =   255
      Index           =   1
      Left            =   7680
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   120
      Value           =   -1  'True
      Width           =   495
   End
   Begin VB.OptionButton Option2 
      Caption         =   "Fwd"
      Height          =   255
      Index           =   0
      Left            =   8160
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   120
      Width           =   495
   End
   Begin VB.TextBox Text3 
      Height          =   285
      Index           =   2
      Left            =   3360
      TabIndex        =   21
      Top             =   120
      Width           =   375
   End
   Begin VB.TextBox Text4 
      Height          =   285
      Index           =   2
      Left            =   3360
      TabIndex        =   13
      Top             =   480
      Width           =   615
   End
   Begin VB.TextBox Text4 
      Height          =   285
      Index           =   1
      Left            =   2880
      TabIndex        =   12
      Top             =   480
      Width           =   375
   End
   Begin VB.TextBox Text4 
      Height          =   285
      Index           =   0
      Left            =   2400
      TabIndex        =   11
      Top             =   480
      Width           =   375
   End
   Begin VB.TextBox Text3 
      Height          =   285
      Index           =   1
      Left            =   2880
      TabIndex        =   4
      Top             =   120
      Width           =   375
   End
   Begin VB.TextBox Text3 
      Height          =   285
      Index           =   0
      Left            =   2400
      TabIndex        =   3
      Top             =   120
      Width           =   375
   End
   Begin VB.TextBox Text2 
      Height          =   285
      Index           =   1
      Left            =   600
      TabIndex        =   2
      Top             =   480
      Width           =   1215
   End
   Begin VB.TextBox Text2 
      Height          =   285
      Index           =   0
      Left            =   600
      TabIndex        =   1
      Top             =   120
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      FillStyle       =   0  'Solid
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   7575
      Left            =   0
      ScaleHeight     =   501
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   717
      TabIndex        =   0
      Top             =   840
      Width           =   10815
   End
   Begin VB.PictureBox SwapScreen 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      FillStyle       =   0  'Solid
      Height          =   7575
      Left            =   0
      ScaleHeight     =   501
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   693
      TabIndex        =   17
      Top             =   840
      Width           =   10455
   End
   Begin VB.PictureBox SwapScreen2 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      FillStyle       =   0  'Solid
      Height          =   7575
      Left            =   0
      ScaleHeight     =   501
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   693
      TabIndex        =   20
      Top             =   840
      Width           =   10455
   End
   Begin VB.Timer Timer2 
      Interval        =   10
      Left            =   0
      Top             =   720
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   360
      Top             =   720
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "Play"
      Height          =   255
      Left            =   6720
      TabIndex        =   33
      Top             =   120
      Width           =   495
   End
   Begin VB.Label Label9 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C0FFFF&
      Height          =   255
      Left            =   8760
      TabIndex        =   18
      Top             =   120
      Width           =   1935
   End
   Begin VB.Label Label13 
      BackStyle       =   0  'Transparent
      Caption         =   "Rate"
      Height          =   255
      Left            =   6720
      TabIndex        =   30
      Top             =   480
      Width           =   495
   End
   Begin VB.Label Label12 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      Height          =   255
      Left            =   8280
      TabIndex        =   29
      Top             =   480
      Width           =   375
   End
   Begin VB.Label Label11 
      Alignment       =   2  'Center
      Caption         =   ":"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3240
      TabIndex        =   22
      Top             =   120
      Width           =   135
   End
   Begin VB.Label Label10 
      Height          =   375
      Left            =   8760
      TabIndex        =   19
      Top             =   360
      Width           =   1935
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Time Zone"
      Height          =   255
      Left            =   5040
      TabIndex        =   16
      Top             =   120
      Width           =   855
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      Caption         =   "/"
      Height          =   255
      Left            =   3240
      TabIndex        =   15
      Top             =   480
      Width           =   135
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      Caption         =   "/"
      Height          =   255
      Left            =   2760
      TabIndex        =   14
      Top             =   480
      Width           =   135
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Date"
      Height          =   255
      Left            =   1920
      TabIndex        =   10
      Top             =   480
      Width           =   495
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Time"
      Height          =   255
      Left            =   1920
      TabIndex        =   8
      Top             =   120
      Width           =   495
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Lat."
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   495
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Long."
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   480
      Width           =   495
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      Caption         =   ":"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2760
      TabIndex        =   5
      Top             =   120
      Width           =   135
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H00FFC0C0&
      BackStyle       =   1  'Opaque
      BorderStyle     =   0  'Transparent
      Height          =   855
      Left            =   6600
      Top             =   0
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Long, ByVal x As Long, ByVal y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hSrcDC As Long, ByVal xSrc As Long, ByVal ySrc As Long, ByVal dwRop As Long) As Long
Dim A%, B%, C%, D%, E%, F%, FF%
Dim Cntr!, UserX#, UserY#, Colr!, DotSize!, DotSizeFactor!
Dim SunNum!
Dim Temp$
Dim StarData$(10000, 24), Coords#(10000, 1), Mag#(10000)
Dim TempStore!(3000, 3000)
Dim TempStore2!(10000, 1)
Dim UCoords#(10000, 1)
Const Deg = 0.01745329251994
Dim MidX#, MidY#, HorizY#
Dim Alt#, Az#, Lat#, Lon#
Dim TimeHr%, HrType%, TimeMin%, TimeSec%, TimeDec#, UT#
Dim JDay#, TimeZone#
Dim Yr!, MoY%, DoM#
Dim LST#, HA#, RA#, Dec#
Dim DirNames As Variant, DrawingArc As Boolean, DrawingMarks As Boolean
Dim ArcStep!, ArcDashes As Boolean, ArcColr!, MarkLength!
Dim ShowExtraInfo As Boolean
Dim Playing%, Changing As Boolean
Dim DaysPerMonth%(12), MinSkip%
Dim FormLoading As Boolean, StarInfo As Boolean

Private Sub Combo1_Click()

RefreshScreen

End Sub

Private Sub RefreshScreen()
Dim Tmp#, DecR#, LatR#, HAR#, AltR#
Dim TmpX#, TmpY#

If FormLoading Then Exit Sub

'Get values from text boxes
Lat = Val(Text2(0).Text)
Lon = Val(Text2(1).Text)
TimeZone = Combo1.ListIndex - 12
Yr = Int(Val(Text4(2).Text))
MoY = Int(Val(Text4(0).Text))
DoM = Int(Val(Text4(1).Text))
TimeHr = Int(Val(Text3(0).Text))
TimeMin = Int(Val(Text3(1).Text))
TimeSec = Int(Val(Text3(2).Text))
'convert 12 hour time (1 - 12 am/pm) to 24 hour (0 - 23)
If Option1(0).Value = True And TimeHr = 12 Then TimeHr = 0 'change 12 am to 0
If Option1(1).Value = True And TimeHr < 12 Then TimeHr = TimeHr + 12 'for 1-11 pm

'Make all values within valid range
If TimeSec > 59 Or TimeSec < 0 Then TimeSec = 0
If TimeMin > 59 Or TimeMin < 0 Then TimeMin = 0
If TimeHr > 23 Or TimeHr < 0 Then TimeHr = 0
If MoY > 12 Or MoY < 1 Then MoY = 1
If DoM > DaysPerMonth(MoY) Or DoM < 1 Then DoM = 1

'Format numbers
Text3(2).Text = IIf(TimeSec < 10, "0" & Trim(Str(TimeSec)), Trim(Str(TimeSec)))
Text3(1).Text = IIf(TimeMin < 10, "0" & Trim(Str(TimeMin)), Trim(Str(TimeMin)))
If Option1(2).Value = False Then
    Text3(0).Text = Trim(Str(IIf(TimeHr Mod 12 = 0, 12, TimeHr Mod 12)))
Else
    Text3(0).Text = Trim(Str(TimeHr))
End If
Text4(0).Text = MoY
Text4(1).Text = DoM
Text4(2).Text = Yr

TimeDec = TimeHr + TimeMin / 60 + TimeSec / 3600 'Convert time to decimal
UT = TimeDec - TimeZone 'Universal Time
TimeDec = UT - 12 'Julian day starts at noon

'Julian day formula
JDay = (1461 * (Yr + 4800 + (MoY - 14) \ 12)) \ 4 + _
          (367 * (MoY - 2 - 12 * ((MoY - 14) \ 12))) \ 12 - _
          (3 * ((Yr + 4900 + (MoY - 14) \ 12) \ 100)) \ 4 + _
          DoM - 32075
                    
JDay = JDay + TimeDec / 24 'Add partial day
JDay = JDay - 2451545 'Convert to days from 1/1/2000
LST = 100.46 + 0.985647 * JDay + Lon + 15 * UT 'Local Sidereal Time

'Get LST within the 0-360 range
Do
    If LST < 0 Then LST = LST + 360
    If LST >= 360 Then LST = LST - 360
Loop Until LST >= 0 And LST < 360

'Refresh Sun coordinates
AddSun

For A = 0 To Cntr
    RA = Coords(A, 0)
    Dec = Coords(A, 1)
    HA = LST - RA 'Hour Angle
    If HA < 0 Then HA = HA + 360
    'Convert variables to radians
    DecR = Dec * Deg
    LatR = Lat * Deg
    HAR = HA * Deg
    'Altitude
    Tmp = Sin(DecR) * Sin(LatR) + Cos(DecR) * Cos(LatR) * Cos(HAR)
    AltR = Atn(Tmp / Sqr(-Tmp * Tmp + 1))
    Alt = AltR / Deg
    'Azimuth
    Tmp = (Sin(DecR) - Sin(AltR) * Sin(LatR)) / (Cos(AltR) * Cos(LatR))
    'Error check
    If Abs(Tmp) > 1 Then
        TmpY = -Cos(DecR) * Cos(LatR) * Sin(HAR)
        TmpX = Sin(DecR) - Sin(LatR) * Sin(AltR)
        Tmp = Atn(TmpY / TmpX) / Deg
    Else
        Tmp = (Atn(-Tmp / Sqr(-Tmp * Tmp + 1)) + 2 * Atn(1)) / Deg
    End If
    
    If Sin(HAR) < 0 Then
        Az = 360 - Tmp
    Else
        Az = Tmp
    End If
    'Write Alt and Az to UCoords
    UCoords(A, 0) = Az
    UCoords(A, 1) = Alt
Next A

DrawStars

End Sub

'Refresh Button
Private Sub Command1_Click()

If Playing = 0 Then RefreshScreen

End Sub

Private Sub Command2_Click()

RightNow
RefreshScreen

End Sub

Private Sub Command3_Click(Index As Integer)

Changing = True

'Get current values from text boxes
TimeSec = Val(Text3(2).Text)
TimeMin = Val(Text3(1).Text)
TimeHr = Val(Text3(0).Text)
If Option1(2).Value = False Then
    If TimeHr = 12 Then TimeHr = 0
    If Option1(1).Value = True Then TimeHr = TimeHr + 12
End If
MoY = Text4(0).Text
DoM = Text4(1).Text
Yr = Text4(2).Text

If Combo2.ListIndex = 0 Then TimeSec = TimeSec + (2 * Index - 1) 'seconds
If Combo2.ListIndex = 1 Then TimeMin = TimeMin + (2 * Index - 1) 'minutes
If Combo2.ListIndex = 2 Then TimeHr = TimeHr + (2 * Index - 1) 'hours
If Combo2.ListIndex = 3 Then DoM = DoM + (2 * Index - 1) 'days
If Combo2.ListIndex = 4 Then 'months
    MoY = MoY + (2 * Index - 1)
    If MoY > 12 Then
        MoY = 1
        Yr = Yr + 1
    End If
    If MoY < 1 Then
        MoY = 12
        Yr = Yr - 1
    End If
End If
If Combo2.ListIndex = 5 Then Yr = Yr + (2 * Index - 1) 'years

If TimeSec < 0 Then
    TimeSec = 59
    TimeMin = TimeMin - 1
End If
If TimeSec > 59 Then
    TimeSec = 0
    TimeMin = TimeMin + 1
End If
If TimeMin < 0 Then
    TimeMin = 59
    TimeHr = TimeHr - 1
End If
If TimeMin > 59 Then
    TimeMin = 0
    TimeHr = TimeHr + 1
End If
If TimeHr < 0 Then
    TimeHr = 23
    DoM = DoM - 1
End If
If TimeHr > 23 Then
    TimeHr = 0
    DoM = DoM + 1
End If
If DoM < 1 Then
    MoY = MoY - 1
    If MoY < 1 Then
        MoY = 12
        DoM = 31
        Yr = Yr - 1
    Else
        DoM = DaysPerMonth(MoY)
    End If
End If
If DoM > DaysPerMonth(MoY) Then
    MoY = MoY + 1
    If MoY > 12 Then
        MoY = 1
        DoM = 1
        Yr = Yr + 1
    Else
        DoM = 1
    End If
End If
If MoY < 1 Then
    MoY = 12
    Yr = Yr - 1
End If
If MoY > 12 Then
    MoY = 1
    Yr = Yr + 1
End If

'Format numbers
Text3(2).Text = IIf(TimeSec < 10, "0" & Trim(Str(TimeSec)), Trim(Str(TimeSec)))
Text3(1).Text = IIf(TimeMin < 10, "0" & Trim(Str(TimeMin)), Trim(Str(TimeMin)))
If Option1(2).Value = False Then
    If TimeHr < 12 Then
        Option1(0).Value = True
    Else
        Option1(1).Value = True
    End If
    Text3(0).Text = Trim(Str(IIf(TimeHr Mod 12 = 0, 12, TimeHr Mod 12)))
Else
    Text3(0).Text = Trim(Str(TimeHr))
End If
Text4(0).Text = MoY
Text4(1).Text = DoM
Text4(2).Text = Yr

Changing = False
RefreshScreen

End Sub

Private Sub Form_Load()
Dim V As Variant, LastStar$

FormLoading = True

'Add time zones
For A = -12 To 13
    If A < 0 Then
        Combo1.AddItem A
    Else
        Combo1.AddItem "+" & A
    End If
Next A

'Add increment types
Combo2.AddItem "Sec."
Combo2.AddItem "Min."
Combo2.AddItem "Hr."
Combo2.AddItem "Day"
Combo2.AddItem "Mo."
Combo2.AddItem "Yr."

'Lat and Long for Gilbert, AZ
Text2(0).Text = "33.3702" 'Latitude
Text2(1).Text = "-111.7919" 'Longitude
TimeZone = -7 'Time Zone
Combo1.ListIndex = TimeZone + 12
Combo2.ListIndex = 1

RightNow

Cntr = -1
MidX = Picture1.ScaleWidth / 2
MidY = Picture1.ScaleHeight / 2
DirNames = Split("N,NNE,NE,ENE,E,ESE,SE,SSE,S,SSW,SW,WSW,W,WNW,NW,NNW,N", ",")
ArcStep = 6
ArcDashes = True
ShowExtraInfo = True
DaysPerMonth(1) = 31
DaysPerMonth(2) = 28
DaysPerMonth(3) = 31
DaysPerMonth(4) = 30
DaysPerMonth(5) = 31
DaysPerMonth(6) = 30
DaysPerMonth(7) = 31
DaysPerMonth(8) = 31
DaysPerMonth(9) = 30
DaysPerMonth(10) = 31
DaysPerMonth(11) = 30
DaysPerMonth(12) = 31
MinSkip = 1
StarInfo = True

'Get data from stardata.txt
FF = FreeFile
Open App.Path & "\stardata.txt" For Input As FF
    Do While Not EOF(FF)
        Line Input #FF, Temp
        V = Split(Temp, vbTab)
        If V(3) <> "" And Val(V(3)) <= 6.5 And V(0) <> LastStar Then 'If magnitude is less than 6.5 (visible to naked eye) and star is not a duplicate of the last star
            LastStar = V(0) 'Store info to compare with next star and check for duplicate
            'Add data to StarData
            Cntr = Cntr + 1
            For A = 0 To 24
                StarData(Cntr, A) = V(A)
            Next A
            If StarData(Cntr, 16) = "" Then StarData(Cntr, 16) = StarData(Cntr, 2)
            StarData(Cntr, 16) = FixCase(StarData(Cntr, 16)) 'Format letters to proper case
            Coords(Cntr, 0) = ConvToDec(StarData(Cntr, 6)) 'Convert Right Ascension to decimal
            Coords(Cntr, 1) = ConvToDec(StarData(Cntr, 7)) 'Convert Declination to decimal
            Mag(Cntr) = Val(StarData(Cntr, 3))
        End If
    Loop
Close FF

'The Sun
Cntr = Cntr + 1
SunNum = Cntr
StarData(Cntr, 16) = "Sun"
StarData(Cntr, 3) = "-27.97"
Mag(Cntr) = Val(StarData(Cntr, 3))


Temp = Cntr & " stars.  "
'For A = 0 To Cntr
    'Temp = Temp & StarData(A, 16) & ": " & StarData(A, 3) & vbCrLf
    'Temp = Temp & "  " & Coords(A, 0) & ", " & Coords(A, 1) & vbCrLf
'Next A

FormLoading = False

RefreshScreen

End Sub


Private Function ConvToDec(Inp$) As Double
Dim Z#, I%, J%, K%
Dim y$, Neg As Boolean, Symb$

y = Left(Inp, 1)
If y = "+" Or y = "-" Then
    Symb = Chr(186)
    If y = "-" Then Neg = True
Else
    Symb = "h"
End If

I = InStr(1, Inp, Symb)
If I > 0 Then
    Z = Z + Abs(Val(Left(Inp, I - 1))) 'Add degrees/hours
Else
    I = 1
End If
J = InStr(I, Inp, "'")
If J > 0 Then
    Z = Z + Val(Mid(Inp, I + 1, J - I - 1)) / 60 'Add arcminutes
Else
    J = 1
End If
K = InStr(J, Inp, "''")
If K > 0 Then
    Z = Z + Val(Mid(Inp, J + 1, K - J - 1)) / 3600 'Add arcseconds
End If
If Neg Then Z = -Z
If Symb = "h" Then Z = Z * 15 '1 hr = 15 degrees

ConvToDec = Z


End Function

Private Function FixCase(Inp$) As String
Dim y$, Z%

y = UCase(Left(Inp, 1))

If Len(Inp) > 1 Then
    For Z = 2 To Len(Inp)
        If Mid(Inp, Z - 1, 1) = " " Then
            y = y & UCase(Mid(Inp, Z, 1))
        Else
            y = y & LCase(Mid(Inp, Z, 1))
        End If
    Next Z
End If

FixCase = y

End Function

Private Sub PlotStar(W As Double, L As Double)
Dim Cx#, Cy#, Cz#
Dim WR#, LR#
Dim x#, y#, YArc#
Dim PixelX#, PixelY#
Dim ArcSkip!, CompassDir#, CDir$

'Convert degrees to radians
WR = W * Deg
LR = L * Deg

'Cartesian coordinates
Cx = Cos(LR) * Sin(WR)
Cy = Sin(LR)
Cz = Cos(LR) * Cos(WR)

If Cz = -1 Then Exit Sub

'2D coordinates
x = -(Cx / (1 + Cz))
y = -(Cy / (1 + Cz))

If DrawingArc Then '*** Drawing an arc ***
    If W <> 180 Then
        If ArcDashes Then 'If drawing dashed line arc
            Picture1.DrawStyle = 2
            If L = 0 Then 'If at horizon
                Picture1.PSet (MidX * (x + 1), HorizY * (y + 1)), ArcColr 'Start arc with a dot
            Else 'If above horizon
                Picture1.Line -(MidX * (x + 1), HorizY * (y + 1)), ArcColr 'Continue drawing line from last point
            End If
            Picture1.DrawStyle = 0
        Else 'If drawing solid line arc
            If L = 0 Then 'If at horizon
                Picture1.PSet (MidX * (x + 1), HorizY * (y + 1)), ArcColr 'Start arc with a dot
            Else 'If above horizon
                Picture1.Line -(MidX * (x + 1), HorizY * (y + 1)), ArcColr 'Continue drawing line from last point
            End If
        End If
    End If
Else
    If DrawingMarks Then '*** Drawing compass marks ***
        Picture1.Line (MidX * (x + 1), HorizY)-(MidX * (x + 1), HorizY + MarkLength), vbYellow
        CompassDir = W - UserX
        'MsgBox CompassDir
        If CompassDir < 0 Then CompassDir = 360 + CompassDir
        If CompassDir > 359 Then CompassDir = CompassDir - 360
        CDir = DirNames(16 - CInt(CompassDir / 22.5))
        Picture1.FontSize = 8
        Picture1.ForeColor = &HC0C0&
        
        Picture1.CurrentX = MidX * (x + 1) - (Picture1.TextWidth(CDir) \ 2)
        Picture1.CurrentY = Int(HorizY) + 6
        Picture1.Print CDir

        
    Else '*** Drawing a star ***
        Picture1.FillColor = Colr
        Picture1.FillStyle = 0
        PixelX = MidX * (x + 1)
        PixelY = HorizY * (y + 1)
        If PixelX >= 0 And PixelX <= Picture1.ScaleWidth And PixelY >= 0 And PixelY <= Picture1.ScaleHeight Then
            TempStore(CInt(PixelX), CInt(PixelY)) = A
            TempStore2(A, 0) = CInt(PixelX)
            TempStore2(A, 1) = CInt(PixelY)
        End If
        
        Picture1.Circle (PixelX, PixelY), DotSize, Colr
    End If
End If

End Sub

Private Sub DrawStars()
Dim UX#, UY#, DirDeg$, Compass$
Dim T1#, T2#, U1#, U2#
Picture1.Cls

'Copy grass from SwapScreen to Picture1
BitBlt Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen2.hDC, 0, 0, vbSrcCopy

For A = 0 To Cntr
    TempStore(TempStore2(A, 0), TempStore2(A, 1)) = 0
Next A

For A = 1 To Cntr
    Colr = MagColr(Mag(A))
    'highlight Orion
    'If StarData(A, 16) = "Rigel" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Betelgeuse" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Bellatrix" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Saiph" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Alnitak" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Alnilam" Then Colr = &HFFFF00
    'If StarData(A, 16) = "Mintaka" Then Colr = &HFFFF00
    'highlight the North Star
    'If StarData(A, 16) = "Polaris" Then Colr = vbYellow
    
    UX = UCoords(A, 0) + UserX
    UY = UCoords(A, 1)
    
    If UY >= 0 Then
        If A = SunNum Then
            Colr = vbYellow
            DotSize = 8
        End If
        PlotStar UX, UY
    End If
Next A


Picture1.ForeColor = &H404040
Picture1.FontSize = 14

DirDeg = Str(UserX) & "°"
Picture1.CurrentX = MidX - (Picture1.TextWidth(DirDeg) \ 2)
Picture1.CurrentY = Picture1.Height - 50
Picture1.Print DirDeg

Compass = DirNames(CInt(UserX / 22.5))
Picture1.CurrentX = MidX - (Picture1.TextWidth(Compass) \ 2)
Picture1.CurrentY = Picture1.Height - 75
Picture1.Print Compass

Picture1.Line (MidX, HorizY)-(MidX, HorizY + 5), vbGreen
Picture1.Line (MidX, HorizY + 20)-(MidX, HorizY + 25), vbGreen



'Draw arcs across sky from N to S and from E to W
DrawingArc = True

'N, S, E and W
ArcColr = &H331133   '&H404000
For UX = 0 To 270 Step 90
    For UY = 0 To 90 Step ArcStep
        PlotStar UserX + UX, UY
    Next UY
Next UX

'In between directions
ArcColr = &H1A1A1A
For UX = 22.5 To 360 Step 22.5
    If UX Mod 90 <> 0 Then
        For UY = 0 To 90 Step ArcStep
            PlotStar UserX + UX, UY
        Next UY
    End If
Next UX

DrawingArc = False

DrawingMarks = True

'T1 = ((UserX - 90) \ 22.5) * 22.5
'T2 = Int((UserX + 90) / 22.5 + 1) * 22.5

T1 = UserX - 180
T2 = UserX + 180
U1 = Int(T1 / 22.5) * 22.5
U2 = (Int(T2 / 22.5) + 1) * 22.5

For UX = U1 To U2 Step 22.5
    If UX >= T1 And UX <= T2 Then
        If UX Mod 90 = 0 Then
            MarkLength = 5
        Else
            MarkLength = 5
        End If
        PlotStar UserX + UX, 0
    End If
Next UX

DrawingMarks = False

Picture1.Refresh

'Copy entire Picture1 to SwapScreen
BitBlt SwapScreen.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, Picture1.hDC, 0, 0, vbSrcCopy


End Sub

Private Function MagColr(M As Double) As Long
Dim Shade#

If M < -1 Then M = -1
If M > 6.5 Then M = 6.5
Shade = 255 - Int((M + 1) * 33)
MagColr = Shade + 256 * Shade + 65536 * Shade
DotSize = (7 - M) * DotSizeFactor 'Range = 0.5 to 8 * DotSizeFactor

End Function

Private Sub Form_Resize()
Dim GreenVal!, GreenLow!, GreenHigh!
Dim NumFadeRows%, FadeStep!, GrassColr!

If Me.WindowState = 1 Then Exit Sub

Picture1.Width = Me.ScaleWidth
Picture1.Height = Me.ScaleHeight - 56
SwapScreen.Width = Picture1.Width
SwapScreen.Height = Picture1.Height
SwapScreen2.Width = Picture1.Width
SwapScreen2.Height = Picture1.Height
MidX = Picture1.ScaleWidth / 2
MidY = Picture1.ScaleHeight / 2
HorizY = Picture1.Height * 0.8

'Draw Grass on SwapScreen2
SwapScreen2.Cls
NumFadeRows = 50
GreenLow = 20
GreenHigh = 80 '255
FadeStep = (GreenHigh - GreenLow) / (NumFadeRows + 1)
B = Int(HorizY)

'Gradient
For A = B To B + NumFadeRows
    GreenVal = Int((A - B) * FadeStep + GreenLow)
    GrassColr = 65536 * GreenVal + GreenVal \ 3 ' 256 * GreenVal '2228258
    SwapScreen2.Line (0, A)-(Picture1.ScaleWidth, A), GrassColr '&H226622
Next A
'End of gradient to bottom of window
SwapScreen2.Line (0, B + NumFadeRows + 1)-(SwapScreen2.Width, SwapScreen2.Height), GrassColr, BF
SwapScreen2.Refresh

DotSizeFactor = Sqr(Picture1.ScaleWidth * Picture1.Height / 200000) / 8  'Max dot size / 8
DrawStars

End Sub

Private Sub HScroll1_Change()

Label12.Caption = HScroll1.Value
MinSkip = HScroll1.Value

End Sub

Private Sub Label10_Click()

'Label10.Caption = DotSizeFactor * 8

MsgBox UCoords(Cntr, 0) & "  " & UCoords(Cntr, 1)

End Sub

Private Sub Label8_Click()

MsgBox Coords(SunNum, 0) & ", " & Coords(SunNum, 1)

End Sub

Private Sub Option1_Click(Index As Integer)

'If "AM" or "PM" is selected and "24" was previously selected convert to 12hr time
If Index < 2 And HrType = 2 Then
    TimeHr = Int(Val(Text3(0).Text))
    TimeHr = TimeHr Mod 12
    If TimeHr = 0 Then TimeHr = 12
    Text3(0).Text = Trim(Str(TimeHr))
End If

'If "24" is selected convert 12hr time to 24hr time
If Index = 2 Then
    TimeHr = Int(Val(Text3(0).Text))
    If HrType < 2 Then 'Convert time based on previously selected hr button
        If TimeHr = 12 Then TimeHr = 0
        If HrType = 1 Then TimeHr = TimeHr + 12
        Text3(0).Text = Trim(Str(TimeHr))
    End If
End If

HrType = Index

If Playing = 0 And Changing = False Then RefreshScreen

End Sub

Private Sub Option2_Click(Index As Integer)

If Option2(0).Value = True Then Playing = 1 'play forward
If Option2(1).Value = True Then Playing = 0 'stop
If Option2(2).Value = True Then Playing = -1 'play reverse

End Sub

Private Sub Picture1_KeyDown(KeyCode As Integer, Shift As Integer)
Dim Inc#

Inc = 1
If Shift = 1 Then Inc = 5
If Shift = 2 Then Inc = 0.25

If KeyCode = vbKeyRight Then
    UserX = UserX - Inc
    If UserX < 0 Then UserX = 360 + UserX
    DrawStars
End If
If KeyCode = vbKeyLeft Then
    UserX = UserX + Inc
    If UserX >= 360 Then UserX = UserX - 360
    DrawStars
End If

End Sub


Private Sub RightNow()

Text4(0).Text = Month(Date)
Text4(1).Text = Day(Date)
Text4(2).Text = Year(Date)

Text3(0).Text = Hour(Time)
Text3(1).Text = Minute(Time)
Text3(2).Text = Second(Time)

Temp = UCase(Right(Time, 2))
If Temp = "AM" Then Option1(0).Value = True
If Temp = "PM" Then Option1(1).Value = True
If Temp <> "AM" And Temp <> "PM" Then Option1(2).Value = True

End Sub


Private Sub Picture1_KeyPress(KeyAscii As Integer)

'Display Extra Info Toggle
If KeyAscii = 105 Or KeyAscii = 73 Then
    If ShowExtraInfo = True Then
        ShowExtraInfo = False
    Else
        ShowExtraInfo = True
    End If
End If

End Sub

Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 1 Then
    If StarInfo Then
        StarInfo = False
        'Copy entire SwapScreen to Picture1
        BitBlt Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen.hDC, 0, 0, vbSrcCopy
        Picture1.Refresh
    Else
        StarInfo = True
    End If
End If

End Sub

Private Sub Picture1_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
Dim XScan#, YScan#
Dim OverStar#, ClosestStar#(3) '0 = Star #, 1 = Distance, 2 = X Coord., 3 = Y Coord.
Dim TempDist#, StarName$

Label9.Caption = "X = " & x & "   Y = " & y
ClosestStar(1) = 100

If StarInfo Then
    For XScan = x - 8 To x + 8
        For YScan = y - 8 To y + 8
            If XScan >= 0 And YScan >= 0 Then
                If TempStore(XScan, YScan) > 0 Then
                    OverStar = TempStore(XScan, YScan)
                    TempDist = Sqr((XScan - x) ^ 2 + (YScan - y) ^ 2)
                    If TempDist < ClosestStar(1) Then
                        ClosestStar(0) = OverStar
                        ClosestStar(1) = TempDist
                        ClosestStar(2) = XScan
                        ClosestStar(3) = YScan
                    End If
                End If
            End If
        Next YScan
    Next XScan
    
    'Copy entire SwapScreen to Picture1
    BitBlt Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen.hDC, 0, 0, vbSrcCopy
    
    If ClosestStar(0) > 0 Then
        Picture1.CurrentX = ClosestStar(2) + 20
        Picture1.CurrentY = ClosestStar(3) - 20
        Picture1.FontSize = 8
        Picture1.ForeColor = &HFFFF00
        Picture1.FontBold = False
        'Display Star Name
        StarName = Trim(StarData(ClosestStar(0), 16))
        If StarName = "" Then StarName = "Star #" & ClosestStar(0) & " (No Name Supplied)"
        Picture1.Print StarName
        If ShowExtraInfo Then
            'Display Magnitude
            Picture1.ForeColor = &HDDDD00
            Picture1.CurrentX = ClosestStar(2) + 20
            Picture1.CurrentY = ClosestStar(3) - 10
            Picture1.Print "Magnitude: " & StarData(ClosestStar(0), 3)
            'Display Distance
            Picture1.ForeColor = &HBBBB00
            Picture1.CurrentX = ClosestStar(2) + 20
            Picture1.CurrentY = ClosestStar(3)
            Picture1.Print "Distance: " & StarData(ClosestStar(0), 8) & " LY"
            'Azimuth
            Picture1.ForeColor = &HAAAA00
            Picture1.CurrentX = ClosestStar(2) + 20
            Picture1.CurrentY = ClosestStar(3) + 10
            Picture1.Print "Azimuth: " & FormatNumber(360 - (UCoords(ClosestStar(0), 0)), 4) & "°"
            'Altitude
            Picture1.ForeColor = &H999900
            Picture1.CurrentX = ClosestStar(2) + 20
            Picture1.CurrentY = ClosestStar(3) + 20
            Picture1.Print "Altitude: " & FormatNumber((UCoords(ClosestStar(0), 1)), 4) & "°"
        End If
        Picture1.FillStyle = 1
        Picture1.Line (ClosestStar(2) + 2, ClosestStar(3) - 2)-(ClosestStar(2) + 18, ClosestStar(3) - 15), &H555555
        Picture1.DrawStyle = 2
        Picture1.Circle (ClosestStar(2), ClosestStar(3)), 4, vbRed
        Picture1.DrawStyle = 0
    End If
End If

End Sub

Private Sub Text2_KeyPress(Index As Integer, KeyAscii As Integer)

If KeyAscii = vbKeyReturn Then
    KeyAscii = 0
    RefreshScreen
End If

End Sub

Private Sub Text3_KeyPress(Index As Integer, KeyAscii As Integer)

If KeyAscii = vbKeyReturn Then
    KeyAscii = 0
    RefreshScreen
End If

End Sub

Private Sub Text4_KeyPress(Index As Integer, KeyAscii As Integer)

If KeyAscii = vbKeyReturn Then
    KeyAscii = 0
    RefreshScreen
End If

End Sub

Private Sub Timer2_Timer()


If Playing <> 0 Then
    'Get current values from text boxes
    TimeMin = Val(Text3(1).Text)
    TimeHr = Val(Text3(0).Text)
    TimeMin = TimeMin + (MinSkip * Playing)
    MoY = Text4(0).Text
    DoM = Text4(1).Text
    Yr = Text4(2).Text
    
    'play forward
    If Playing = 1 Then
        'past 59 min
        If TimeMin > 59 Then
            TimeMin = TimeMin - 60
            TimeHr = TimeHr + 1
            If Option1(2).Value = False Then '12 hour time
                'past 12 hr
                If TimeHr > 12 Then TimeHr = 1
                'change to 12 am or pm
                If TimeHr = 12 Then
                    'am to pm
                    If Option1(0).Value = True Then
                        Option1(1).Value = True
                    'pm to am
                    Else
                        Option1(0).Value = True
                        DoM = DoM + 1 'go to next day
                    End If
                End If
            Else '24 hour time
                If TimeHr > 23 Then
                    TimeHr = 0
                    DoM = DoM + 1 'go to next day
                End If
            End If
        End If
        'past last day of month
        If DoM > DaysPerMonth(MoY) Then
            DoM = 1 'reset to 1st of month
            MoY = MoY + 1 'go to next month
            'past end of year
            If MoY > 12 Then
                MoY = 1 'reset to January
                Yr = Yr + 1 'go to next year
            End If
            'update date fields with new values
            Text4(0).Text = MoY
            Text4(1).Text = DoM
            Text4(2).Text = Yr
        End If
        'update time fields with new values
        Text3(1).Text = TimeMin
        Text3(0).Text = TimeHr
        Text4(1).Text = DoM
    End If
    
    'play reverse
    If Playing = -1 Then
        'under 0 min
        If TimeMin < 0 Then
            TimeMin = TimeMin + 60
            TimeHr = TimeHr - 1
            If Option1(2).Value = False Then '12 hour time
                'under 1 hr
                If TimeHr < 1 Then TimeHr = 12
                'change to 11 am or pm
                If TimeHr = 11 Then
                    'am to pm
                    If Option1(0).Value = True Then
                        Option1(1).Value = True
                        DoM = DoM - 1 'go to previous day
                    'pm to am
                    Else
                        Option1(0).Value = True
                    End If
                End If
            Else '24 hour time
                If TimeHr < 0 Then
                    TimeHr = 23
                    DoM = DoM - 1 'go to previous day
                End If
            End If
        End If
        'before first day of month
        If DoM < 1 Then
            MoY = MoY - 1 'go to previous month
            'if it's before beginning of year (Jan. 1)
            If MoY < 1 Then
                MoY = 12 'go to December
                DoM = 31 'last day of December
                Yr = Yr - 1 'go to previous year
            'go to last day of previous month
            Else
                DoM = DaysPerMonth(MoY) 'last day of previous month
            End If
            'update date fields with new values
            Text4(0).Text = MoY
            Text4(1).Text = DoM
            Text4(2).Text = Yr
        End If
        'update time fields with new values
        Text3(1).Text = TimeMin
        Text3(0).Text = TimeHr
        Text4(1).Text = DoM
    End If
    
    'display sky for new time
    RefreshScreen
End If



Exit Sub

RightNow 'Current time
RefreshScreen 'Update display
Picture1_MouseMove 0, 0, Picture1.CurrentX, Picture1.CurrentY


End Sub


Private Sub AddSun()
Dim SunNN#, Suni#, Sunw#, Suna#, Sune#, SunMM#
Dim SunEE#, Sunxv#, Sunyv#, Sunv#, Sunr#
Dim LonSun#, Sunxs#, Sunys#, Sunxe#, Sunye#, Sunze#
Dim Sunecl#, SunRA#, SunDec#, Sund#
Dim syear#, smonth#, sdate#

Sund = JDay

Sunecl = 23.4393 - 0.0000003563 * Sund

SunNN = 0 'longitude of the ascending node
Suni = 0 'inclination to the ecliptic (plane of the Earth's orbit)
Sunw = 282.9404 + 0.0000470935 * Sund 'argument of perihelion
Suna = 1 'semi-major axis, or mean distance from Sun
Sune = 0.016709 - 0.000000001151 * Sund 'eccentricity (0=circle, 0-1=ellipse, 1=parabola)
SunMM = 356.047 + 0.9856002585 * Sund 'mean anomaly (0 at perihelion; increases uniformly with time)

'get SunMM in the 0-360 range
Do
    If SunMM < 0 Then SunMM = SunMM + 360
    If SunMM >= 360 Then SunMM = SunMM - 360
Loop Until SunMM >= 0 And SunMM < 360

SunEE = SunMM + Sune * Sin(SunMM * Deg) * (1 + Sune * Cos(SunMM * Deg))

Sunxv = Cos(SunEE * Deg) - Sune
Sunyv = Sqr(1 - Sune * Sune) * Sin(SunEE * Deg)
Sunv = Atan2(Sunyv, Sunxv) / Deg 'Sun's true anomaly
Sunr = Sqr(Sunxv * Sunxv + Sunyv * Sunyv) 'Sun's distance
LonSun = Sunv + Sunw 'Sun's true longitude

Sunxs = Sunr * Cos(LonSun * Deg) 'ecliptic rectangular geocentric coordinates
Sunys = Sunr * Sin(LonSun * Deg)

Sunxe = Sunxs 'equatorial, rectangular, geocentric coordinates
Sunye = Sunys * Cos(Sunecl * Deg)
Sunze = Sunys * Sin(Sunecl * Deg)

SunRA = Atan2(Sunye, Sunxe) / Deg
SunDec = Atan2(Sunze, Sqr(Sunxe * Sunxe + Sunye * Sunye)) / Deg

Do
    If SunRA < 0 Then SunRA = SunRA + 360
    If SunRA >= 360 Then SunRA = SunRA - 360
Loop Until SunRA >= 0 And SunRA < 360
Do
    If SunDec < 0 Then SunDec = SunDec + 360
    If SunDec >= 360 Then SunDec = SunDec - 360
Loop Until SunDec >= 0 And SunDec < 360

Coords(SunNum, 0) = SunRA
Coords(SunNum, 1) = SunDec

End Sub

Public Function Atan2(ByVal aay As Double, ByVal aax As Double) _
    As Double
  Dim theta As Double

  If (Abs(aax) < 0.0000001) Then
    If (Abs(aay) < 0.0000001) Then
      theta = 0#
    ElseIf (aay > 0#) Then
      theta = 1.5707963267949
    Else
      theta = -1.5707963267949
    End If
  Else
    theta = Atn(aay / aax)
  
    If (aax < 0) Then
      If (aay >= 0#) Then
        theta = 3.14159265358979 + theta
      Else
        theta = theta - 3.14159265358979
      End If
    End If
  End If
    
  Atan2 = theta
End Function


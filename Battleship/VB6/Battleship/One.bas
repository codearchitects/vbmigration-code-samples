Attribute VB_Name = "One"
'8o. Adam Spicer .o8'

Option Explicit

Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Long) As Long

Dim hesitator

Global ShiPcount As Integer
Global WhiCHway As String
Global whichMNU As String
Global FORMtagg As Integer

Public Function PlayWav(Snd As String)
  Dim PlayIt
    Snd = App.Path & "/" & "sounds/" & Snd
    PlayIt = sndPlaySound(Snd, 1)
    
End Function

Function CenterForm(frm As Form)
    frm.Top = (Screen.Height - frm.Height) / 2
    frm.Left = (Screen.Width - frm.Width) / 2

End Function

Public Function TimeOUT(HesitateTime)
    hesitator = Timer
    Do While Timer - hesitator < Val(HesitateTime)
    DoEvents
    Loop
    
End Function



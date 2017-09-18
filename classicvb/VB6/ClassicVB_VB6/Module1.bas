Attribute VB_Name = "Module1"
'## project:DisableMessages CodeAnalysis
'## project:DisableMessage 0354

Public fMainForm As frmMain

Sub Main()
    '## InsertStatement If InitializeFormChaining6() Then Exit Sub
   
    frmSplash.Show
    frmSplash.Refresh
    Set fMainForm = New frmMain
    Load fMainForm
    Unload frmSplash
    fMainForm.Show
End Sub


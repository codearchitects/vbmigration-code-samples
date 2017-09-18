' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmTetris

	Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
	Private Const SND_ASYNC As Short = &H1S
	Private Const SND_NOSTOP As Short = &H2000S
	'&H10
	Private Const SND_NOWAIT As Short = &H2000S
	
	Private Const SND_RUOTA As Short = 1
	Private Const SND_SPOSTA As Short = 2
	Private Const SND_DROP As Short = 3
	Private Const SND_TETRIS As Short = 4
	Private Const SND_FINE As Short = 5
	Private Const SND_RIGA As Short = 6
	
	Private Blocco As frmTetris.tyBlocco
	
	Private Const CDx As Short = 1
	Private Const CSx As Short = -1
	Private Const CDw As Short = 2
	Private Const CRd As Short = 3
	Private Const CRs As Short = 4
	
	Private Const iRow As Short = 15
	Private Const iCol As Short = 9
	
	Public iPxlLato As Short
	
	Private iGriglia(iCol, iRow) As Short
	
	Private Const CVuoto As Short = 0
	Private Const CVerde As Short = 1
	Private Const CBlu As Short = 2
	Private Const CRosso As Short = 3
	Private Const CRosa As Short = 4
	Private Const CGiallo As Short = 5
	Private Const CArancio As Short = 6
	Private Const CViola As Short = 7
	Private Const CGrigio As Short = 10
	
	Private Const CBLs As Short = 1
	Private Const CBLd As Short = 2
	Private Const CBSs As Short = 3
	Private Const CBSd As Short = 4
	Private Const CBT As Short = 5
	Private Const CBI As Short = 6
	Private Const CBQ As Short = 7
	
	Private i As Short
	Private j As Short
	
	Friend Structure tyQuadro
	
		Public X As Short
		Public Y As Short
	End Structure

	Friend Structure tyBlocco
	
		Public Q1 As frmTetris.tyQuadro
		Public Q2 As frmTetris.tyQuadro
		Public Q3 As frmTetris.tyQuadro
		Public Q4 As frmTetris.tyQuadro
		Public qdRot As frmTetris.tyQuadro ' punto di rotazione
		Public iTipo As Short ' iTipo di blocco
		Public iClr As Short ' colore
	End Structure

	Private Const CVelBase As Short = 1200
	Private Const CVelBoost As Short = 30
	Public iVelocita As Short
	
	Public iPuntiBoost As Short
	
	Public iLivello As Short
	
	Private Const CNBlocchi As Short = 7
	
	Private iBlocchi(CNBlocchi) As frmTetris.tyBlocco
	
	Private Const sMsgPausa As String = "Premi F3 per continuare"
	Private Const sMsgFine As String = "GAME OVER"
	Private Const sMsgInizio As String = "Premi F2 per iniziare"
	Private Const sMsgs As String = " "
	
	Private bPausa As Boolean
	
	Private Sub Form_Load() Handles MyBase.Load
		'--##InsertStatement Me.BorderStyle = VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Left = (Screen6.Width - Me.Width) / 2
		Me.Top = (Screen6.Height - Me.Height) / 2
		Me.Width = 4155
		Me.Height = 5250
		
		Randomize((Timer6))
		iPxlLato = imgBlock(0).Height
		pctGriglia.ScaleWidth = iPxlLato * iCol
		pctGriglia.ScaleHeight = iPxlLato * iRow
		Me.ScaleHeight = pctGriglia.Height
		pctPreView.Width = iPxlLato * 4
		pctPreView.Height = iPxlLato * 4
		lblMsg(0).Left = iPxlLato * 2: lblMsg(1).Left = iPxlLato * 2 - 1
		lblMsg(0).Top = iPxlLato * Int(iRow / 2 - 1): lblMsg(1).Top = iPxlLato * Int(iRow / 2 - 1) - 1
		lblMsg(0).Width = iPxlLato * (iCol - 4): lblMsg(1).Width = iPxlLato * (iCol - 4)
		lblMsg(0).Height = iPxlLato * 2: lblMsg(1).Height = iPxlLato * 2
		InizializzaGriglia()
		InizializzaBlocchi()
		VisualizzaRecord()
		Messaggio((sMsgInizio))
		ImpostaLivello((5))
	End Sub

	Private Sub InizializzaBlocchi()
		InizializzaBlocco(CBLd, 4, 1, 5, 1, 6, 1, 4, 2, 5, 1, CGiallo)
		InizializzaBlocco(CBLs, 4, 1, 5, 1, 6, 1, 6, 2, 5, 1, CViola)
		InizializzaBlocco(CBSd, 5, 1, 6, 1, 4, 2, 5, 2, 5, 1, CBlu)
		InizializzaBlocco(CBSs, 4, 1, 5, 1, 5, 2, 6, 2, 5, 1, CArancio)
		InizializzaBlocco(CBT, 4, 1, 5, 1, 6, 1, 5, 2, 5, 1, CVerde)
		InizializzaBlocco(CBI, 3, 1, 4, 1, 5, 1, 6, 1, 5, 1, CRosso)
		InizializzaBlocco(CBQ, 4, 1, 5, 1, 4, 2, 5, 2, 0, 0, CRosa)
	End Sub

	Private Sub IniziaPartita()
		mnuNuova.Enabled = False
		InizializzaGriglia()
		ImpostaVelocita()
		ImpostaDifficolta((getChkIndex(mnuD)))
		AggiornaGriglia((True))
		NuovoBlocco()
		Call DisegnaBlocco(Blocco, True)
		tmrGioco.Interval = iVelocita
		lblPunti.Caption = 0
		lblLinee.Caption = 0
		VisualizzaRecord()
		HideMsg()
	End Sub

	Private Function getChkIndex(ByRef Mnu As Object) As Short
	' UPGRADE_INFO (#0551): The 'Mnu' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim mnuTmp As VB6Menu = Nothing
		For Each mnuTmp In Mnu
			If mnuTmp.Checked Then  getChkIndex = mnuTmp.Index
		Next
	End Function

	Private Sub ImpostaVelocita()
		iVelocita = Int(CVelBase / iLivello)
		tmrGioco.Interval = iVelocita
	End Sub

	Private Sub InizializzaBlocco(ByVal iBlk As Short, ByVal x1 As Short, ByVal y1 As Short, ByVal x2 As Short, ByVal y2 As Short, ByVal x3 As Short, ByVal y3 As Short, ByVal x4 As Short, ByVal y4 As Short, ByVal Rx As Short, ByVal Ry As Short, ByVal iColor As Short)
		iBlocchi(iBlk).Q1.X = x1
		iBlocchi(iBlk).Q1.Y = y1
		iBlocchi(iBlk).Q2.X = x2
		iBlocchi(iBlk).Q2.Y = y2
		iBlocchi(iBlk).Q3.X = x3
		iBlocchi(iBlk).Q3.Y = y3
		iBlocchi(iBlk).Q4.X = x4
		iBlocchi(iBlk).Q4.Y = y4
		iBlocchi(iBlk).iClr = iColor
		iBlocchi(iBlk).qdRot.X = Rx
		iBlocchi(iBlk).qdRot.Y = Ry
		iBlocchi(iBlk).iTipo = iBlk
	End Sub

	Private Sub InizializzaGriglia()
		For i = 1 To iRow
			For j = 1 To iCol
				iGriglia(j, i) = CVuoto
				DisegnaQuadro(pctGriglia, j, i, CVuoto)
			Next
		Next
	End Sub

	Private Sub AggiornaGriglia(Optional ByVal bNuova As Object = VB6Missing)
	' UPGRADE_INFO (#0561): The 'bNuova' symbol was defined without an explicit "As" clause.
		Static grdPrec(iCol, iRow) As Short
		
		If Not IsMissing6(bNuova) Then 
			For i = 1 To iRow
				For j = 1 To iCol
					grdPrec(j, i) = CVuoto
				Next
			Next
		End If
		
		For i = 1 To iRow
			For j = 1 To iCol
				If grdPrec(j, i) <> iGriglia(j, i) Then 
					DisegnaQuadro(pctGriglia, j, i, iGriglia(j, i))
					grdPrec(j, i) = iGriglia(j, i)
				End If
			Next
		Next
	End Sub

	Private Sub AggiornaSfondo()
		For i = 1 To iRow
			For j = 1 To iCol
				If iGriglia(j, i) = CVuoto Then  DisegnaQuadro(pctGriglia, j, i, iGriglia(j, i))
			Next
		Next
	End Sub

	Private Sub DisegnaQuadro(ByVal pct As VB6PictureBox, ByVal X As Short, ByVal Y As Short, ByVal iClr As Short)
		pct.PaintPicture(imgBlock(iClr).Picture, (X - 1) * iPxlLato, (Y - 1) * iPxlLato, iPxlLato, iPxlLato)
	End Sub

	Public Function Rand(ByVal i As Short) As Short
		Return Int(Rnd() * i) + 1
	End Function

	Private Sub DisegnaBlocco(ByRef blk As frmTetris.tyBlocco, ByVal bNuovo As Boolean)
		Static prec As frmTetris.tyBlocco
		
		If Not bNuovo Then  'nuovo blocco
			iGriglia(prec.Q1.X, prec.Q1.Y) = CVuoto 'cancella la posizione precedente
			iGriglia(prec.Q2.X, prec.Q2.Y) = CVuoto
			iGriglia(prec.Q3.X, prec.Q3.Y) = CVuoto
			iGriglia(prec.Q4.X, prec.Q4.Y) = CVuoto
		End If
		
		iGriglia(blk.Q1.X, blk.Q1.Y) = blk.iClr 'disegna nella nuova posizione
		iGriglia(blk.Q2.X, blk.Q2.Y) = blk.iClr
		iGriglia(blk.Q3.X, blk.Q3.Y) = blk.iClr
		iGriglia(blk.Q4.X, blk.Q4.Y) = blk.iClr
		
		prec = blk
		AggiornaGriglia()
	End Sub

	Private Sub RuotaQuadro(ByRef Q As frmTetris.tyQuadro, ByRef R As frmTetris.tyQuadro, ByVal iDir As Short)
		Dim iTmpQX As Short
		Dim iTmpQY As Short
		
		If iDir = CRd Then  iDir = CDx
		If iDir = CRs Then  iDir = CSx
		
		iTmpQX = iDir * (Q.Y - R.Y) + R.X
		iTmpQY = -iDir * (Q.X - R.X) + R.Y
		
		Q.X = iTmpQX
		Q.Y = iTmpQY
	End Sub

	Private Function MovimentoBlocco(ByRef blk As frmTetris.tyBlocco, ByVal iDir As Short) As Boolean
		Dim blkUndo As frmTetris.tyBlocco
		
		blkUndo = blk
		Select Case iDir
		Case CDx, CSx: blk.Q1.X += iDir
			blk.Q2.X += iDir
			blk.Q3.X += iDir
			blk.Q4.X += iDir
			blk.qdRot.X += iDir
		Case CDw: blk.Q1.Y += 1
			blk.Q2.Y += 1
			blk.Q3.Y += 1
			blk.Q4.Y += 1
			blk.qdRot.Y += 1
		Case CRd, CRs
			If blk.iTipo <> CBQ Then 
				RuotaQuadro(blk.Q1, blk.qdRot, iDir)
				RuotaQuadro(blk.Q2, blk.qdRot, iDir)
				RuotaQuadro(blk.Q3, blk.qdRot, iDir)
				RuotaQuadro(blk.Q4, blk.qdRot, iDir)
			End If
		End Select
		
		MovimentoBlocco = ControllaStatoQuadro(blk.Q1, blkUndo) And ControllaStatoQuadro(blk.Q2, blkUndo) And ControllaStatoQuadro(blk.Q3, blkUndo) And ControllaStatoQuadro(blk.Q4, blkUndo)
		
		If Not MovimentoBlocco Then 
			blk = blkUndo
		Else
			DisegnaBlocco(Blocco, False)
		End If
		
	End Function

	Private Function ControllaStatoQuadro(ByRef Q As frmTetris.tyQuadro, ByRef blkOld As frmTetris.tyBlocco) As Boolean
		ControllaStatoQuadro = True
		If Q.Y > iRow Or Q.Y < 1 Or Q.X > iCol Or Q.X < 1 Then 
			Return False
		End If
		
		If (Q.X = blkOld.Q1.X And Q.Y = blkOld.Q1.Y) Or (Q.X = blkOld.Q2.X And Q.Y = blkOld.Q2.Y) Or (Q.X = blkOld.Q3.X And Q.Y = blkOld.Q3.Y) Or (Q.X = blkOld.Q4.X And Q.Y = blkOld.Q4.Y) Then  Exit Function
		
		If iGriglia(Q.X, Q.Y) <> CVuoto Then  Return False
	End Function

	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		If bPausa Then  Exit Sub
		Select Case KeyCode
		Case VBRUN.KeyCodeConstants.vbKeyRight: MovimentoBlocco(Blocco, CDx)
			Suono((SND_SPOSTA))
		Case VBRUN.KeyCodeConstants.vbKeyLeft: MovimentoBlocco(Blocco, CSx)
			Suono((SND_SPOSTA))
		Case VBRUN.KeyCodeConstants.vbKeySpace: MovimentoBlocco(Blocco, CRd)
			Suono(SND_RUOTA)
		Case VBRUN.KeyCodeConstants.vbKeyShift: MovimentoBlocco(Blocco, CRs)
			Suono(SND_RUOTA)
		Case VBRUN.KeyCodeConstants.vbKeyDown: tmrGioco.Interval = CVelBoost
		End Select
	End Sub

	Private Sub Form_KeyUp(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyUp
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyDown Then  tmrGioco.Interval = iVelocita
		iPuntiBoost = 0
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		If Me.WindowState = VBRUN.FormWindowStateConstants.vbMinimized Then  Call Pausa(True)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Application.Exit(): End
	End Sub

	Private Sub mnuAbout_Click() Handles mnuAbout.Click
		MsgBox6(" Creato da:" & ControlChars.Tab & "Enrico Melani" & Chr6(13) & " Versione:" & ControlChars.Tab & ControlChars.Tab & "2.0" & Chr6(13) & " Ultima modifica:" & ControlChars.Tab & "07/04/1999" & Chr6(13) & " e-mail:" & ControlChars.Tab & ControlChars.Tab & "e.melani@infogroup.it" & Chr6(13))
	End Sub

	Private Sub mnuD_Click(ByRef Index As Short)
		Dim mnuTmp As VB6Menu = Nothing
		For Each mnuTmp In mnuD
			mnuTmp.Checked = (mnuD(Index).Index = mnuTmp.Index)
		Next
	End Sub

	Private Sub mnuEsci_Click() Handles mnuEsci.Click
		Application.Exit(): End
	End Sub

	Private Sub mnuL_Click(ByRef Index As Short)
		Dim mnuTmp As VB6Menu = Nothing
		For Each mnuTmp In mnuL
			mnuTmp.Checked = (mnuL(Index).Index = mnuTmp.Index)
		Next
		ImpostaLivello((Index))
	End Sub

	Private Sub mnuNuova_Click() Handles mnuNuova.Click
		Call IniziaPartita()
	End Sub

	Private Sub mnuPausa_Click() Handles mnuPausa.Click
		Static bFlag As Boolean
		bFlag = Not bFlag
		Call Pausa(bFlag)
	End Sub

	Private Sub mnuPreview_Click() Handles mnuPreview.Click
		pctPreView.Cls()
		mnuPreview.Checked = Not mnuPreview.Checked
	End Sub

	Private Sub mnuSfondi_Click() Handles mnuSfondi.Click
		mnuSfondi.Checked = Not mnuSfondi.Checked
		If Not mnuSfondi.Checked Then 
			imgBlock(0).Picture = imgBlock(20).Picture
		Else
			imgBlock(0).Picture = imgSfondo(iLivello).Picture
		End If
		AggiornaSfondo()
	End Sub

	Private Sub mnuTasti_Click() Handles mnuTasti.Click
		MsgBox6("[Spazio]" & ControlChars.Tab & ControlChars.Tab & "Rotazione sinistra" & Chr6(13) & "[Shift]" & ControlChars.Tab & ControlChars.Tab & "Rotazione destra" & Chr6(13) & "Freccia giù" & ControlChars.Tab & "Accelera" & Chr6(13) & "Frecce [<]  [>]" & ControlChars.Tab & "Blocco sinistra/destra" & Chr6(13) & "[F2]" & ControlChars.Tab & ControlChars.Tab & "Inizia partita" & Chr6(13) & "[F3]" & ControlChars.Tab & ControlChars.Tab & "Pausa / riprendi" & Chr6(13), , "Tasti Tetris")
	End Sub

	Private Sub pctGriglia_LostFocus() Handles pctGriglia.LostFocus
		Call Pausa(True)
	End Sub

	Private Sub tmrGioco_Timer() Handles tmrGioco.Timer
		If Not (MovimentoBlocco(Blocco, CDw)) Then 
			DropGriglia()
			Suono(SND_DROP)
			lblPunti.Caption += iPuntiBoost
			iPuntiBoost = 0
			If Not NuovoBlocco() Then 
				Suono(SND_FINE)
				Messaggio((sMsgFine))
				ControllaRecord()
				mnuNuova.Enabled = True
			Else
				'Beep
			End If
		End If
		If tmrGioco.Interval = CVelBoost Then  iPuntiBoost += iLivello
	End Sub

	Public Sub Pausa(ByVal bStato As Boolean)
		tmrGioco.Enabled = bStato
		bPausa = bStato
		If bStato Then 
			Messaggio((sMsgPausa))
		Else
			HideMsg()
		End If
	End Sub

	Private Function NuovoBlocco() As Boolean
		Static blkPreview As frmTetris.tyBlocco
		
		Blocco = blkPreview
		blkPreview = iBlocchi(Rand(CNBlocchi))
		If Blocco.iTipo = 0 Then  Blocco = blkPreview
		Anteprima(blkPreview)
		
		NuovoBlocco = iGriglia(Blocco.Q1.X, Blocco.Q1.Y) = CVuoto And iGriglia(Blocco.Q2.X, Blocco.Q4.Y) = CVuoto And iGriglia(Blocco.Q3.X, Blocco.Q3.Y) = CVuoto And iGriglia(Blocco.Q4.X, Blocco.Q2.Y) = CVuoto
		
		DisegnaBlocco(Blocco, True)
	End Function

	Public Sub DropGriglia()
		Dim h As Short
		Dim k As Short
		Dim nDropLine As Short
		
		Dim bLine As Boolean
		On Error Resume Next 
		nDropLine = 0
		For i = 1 To iRow
			bLine = True
			For j = 1 To iCol
				bLine = bLine And (iGriglia(j, i) <> CVuoto)
			Next
			If bLine Then 
				nDropLine += 1
				For h = i To 1 Step -1
					For k = 1 To iCol
						If h > 1 Then 
							iGriglia(k, h) = iGriglia(k, h - 1)
						Else
							iGriglia(k, h) = CVuoto
						End If
					Next
				Next
				i -= 1
			End If
		Next
		Select Case nDropLine
		Case 1: lblPunti.Caption = lblPunti.Caption + 10 * iLivello
			Suono(SND_RIGA)
		Case 2: lblPunti.Caption = lblPunti.Caption + 50 * iLivello
			Suono(SND_RIGA)
		Case 3: lblPunti.Caption = lblPunti.Caption + 200 * iLivello
			Suono(SND_RIGA)
		Case 4: lblPunti.Caption = lblPunti.Caption + 500 * iLivello
			Suono(SND_TETRIS)
		End Select
		lblLinee.Caption += nDropLine
		If lblLinee.Caption >= (8 * iLivello) Then  ImpostaLivello((iLivello + 1))
	End Sub

	Private Sub Delay(ByVal lMSec As Integer)
		Dim s1 As Single
		tmrGioco.Enabled = False
		s1 = Timer6
		While s1 > Timer6 - lMSec / 1000
		End While
		tmrGioco.Enabled = True
	End Sub

	Private Sub ImpostaDifficolta(ByVal iDiff As Short)
		Dim iRnd As Short
		For i = 0 To iDiff - 1
			For j = 1 To iCol
				iRnd = Rand(10)
				If iRnd > 6 Then  iGriglia(j, iRow - i) = CGrigio
			Next
		Next
	End Sub

	Private Sub Messaggio(ByRef sMsg As String)
	' UPGRADE_INFO (#0551): The 'sMsg' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		tmrGioco.Enabled = False
		lblMsg(0).Caption = sMsg
		lblMsg(1).Caption = sMsg
		lblMsg(0).Visible = True
		lblMsg(1).Visible = True
	End Sub

	Private Sub HideMsg()
		lblMsg(0).Visible = False
		lblMsg(1).Visible = False
		tmrGioco.Enabled = True
	End Sub

	Private Sub ImpostaLivello(ByVal iLiv As Short)
		iLivello = iLiv
		lblLivello.Caption = iLiv
		ImpostaVelocita()
		If mnuSfondi.Checked Then 
			imgBlock(0).Picture = imgSfondo(iLiv).Picture
			AggiornaSfondo()
		End If
	End Sub

	Private Sub Anteprima(ByRef blk As frmTetris.tyBlocco)
		If Not mnuPreview.Checked Then  Exit Sub
		pctPreView.Cls()
		DisegnaQuadro(pctPreView, blk.Q1.X - 2, blk.Q1.Y, blk.iClr)
		DisegnaQuadro(pctPreView, blk.Q2.X - 2, blk.Q2.Y, blk.iClr)
		DisegnaQuadro(pctPreView, blk.Q3.X - 2, blk.Q3.Y, blk.iClr)
		DisegnaQuadro(pctPreView, blk.Q4.X - 2, blk.Q4.Y, blk.iClr)
	End Sub

	Private Sub VisualizzaRecord()
		lblRecN(0).Caption = GetSetting("Tetris", "Record", "Nome1", "Player1")
		lblRecP(0).Caption = GetSetting("Tetris", "Record", "Punti1", 0)
		lblRecN(1).Caption = GetSetting("Tetris", "Record", "Nome2", "Player2")
		lblRecP(1).Caption = GetSetting("Tetris", "Record", "Punti2", 0)
		lblRecN(2).Caption = GetSetting("Tetris", "Record", "Nome3", "Player3")
		lblRecP(2).Caption = GetSetting("Tetris", "Record", "Punti3", 0)
	End Sub

	Private Sub SalvaRecord()
		SaveSetting("Tetris", "Record", "Nome1", lblRecN(0).Caption)
		SaveSetting("Tetris", "Record", "Punti1", lblRecP(0).Caption)
		SaveSetting("Tetris", "Record", "Nome2", lblRecN(1).Caption)
		SaveSetting("Tetris", "Record", "Punti2", lblRecP(1).Caption)
		SaveSetting("Tetris", "Record", "Nome3", lblRecN(2).Caption)
		SaveSetting("Tetris", "Record", "Punti3", lblRecP(2).Caption)
	End Sub

	Private Sub ControllaRecord()
		Dim i As Short
		Dim j As Short
		For i = 0 To 2
			If CInt(lblPunti.Caption) > CInt(lblRecP(i).Caption) Then 
				For j = 2 To i + 1 Step -1
					lblRecP(j).Caption = lblRecP(j - 1).Caption
					lblRecN(j).Caption = lblRecN(j - 1).Caption
				Next
				lblRecP(i).Caption = lblPunti.Caption
				lblRecN(i).Caption = ""
				lblRecN(i).Caption = InputBox6("Complimenti, hai ottenuto un nuovo record" & Chr6(13) & "Scrivi il tuo nome (max. 10 car)")
				SalvaRecord()
				Exit Sub
			End If
		Next
	End Sub

	Private Sub mnuPunteggi_Click() Handles mnuPunteggi.Click
		Dim sMsg As String = "LIVELLO / LINEE" & ControlChars.Tab & "1" & ControlChars.Tab & "2" & ControlChars.Tab & "3" & ControlChars.Tab & "TETRIS" & Chr6(13) & "----------------------------------------------------------------------------------------------" & Chr6(13)
		
		For i = 1 To 16
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'sMsg' variable as a StringBuilder6 object.
			sMsg = sMsg & "Livello " & i & ControlChars.Tab & ControlChars.Tab & i * 10 & ControlChars.Tab & i * 50 & ControlChars.Tab & i * 200 & ControlChars.Tab & i * 500 & Chr6(13)
		Next
		sMsg = sMsg & "----------------------------------------------------------------------------------------------" & Chr6(13)
		
		MsgBox6(sMsg, , "Punteggi Tetris")
	End Sub

	Private Sub Suono(ByVal iSnd As Short)
		Select Case iSnd
		Case SND_RUOTA: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris3.wav", &O0, SND_ASYNC + SND_NOSTOP)
		Case SND_SPOSTA: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris6.wav", &O0, SND_ASYNC + SND_NOSTOP)
		Case SND_DROP: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris4.wav", &O0, SND_ASYNC + SND_NOSTOP)
		Case SND_TETRIS: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris7.wav", &O0, SND_ASYNC + SND_NOSTOP)
		Case SND_RIGA: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris5.wav", &O0, SND_ASYNC + SND_NOSTOP)
		Case SND_FINE: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol '&O0'. Consider using the GetDefaultMember6 helper method.
			PlaySound(App6.Path & "\wav\tetris8.wav", &O0, SND_ASYNC + SND_NOSTOP)
		End Select
	End Sub

End Class

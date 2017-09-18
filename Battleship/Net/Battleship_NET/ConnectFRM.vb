' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class ConnectFRM

	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
	'                   One Computer Software                    '
	'                       DeI3oe@aol.com                       '
	'                    !Battleship Online!                     '
	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'
	Private Sub ClientCMD_Click() Handles ClientCMD.Click
		IPtxt.Text = "Server's IP here" 'tells u to put the servers ip in the txtbox
		Me.Caption = "Connect as Client" 'recaptions form to fit user
		IPtxt.Enabled = True 'needed button to connect
		nicknameTXT.Enabled = True 'needed button to connect
		ServerCMD.Enabled = False 'unneeded button to connect to client
		ClientCMD.Enabled = False 'unneeded button to connect to client
		ConnectCMD.Enabled = True 'needed button to connect
		
	End Sub

	Private Sub ConnectCMD_Click() Handles ConnectCMD.Click
		If nicknameTXT.Text = "" Then  Exit Sub 'wont connect till a name has been entered!
		
		If Me.Caption = "Connect as Server" Then  'connects u to the client
			Load6(ServerFRM)
			ServerFRM.Winsock.Close() 'closes any previous connections
			ServerFRM.Winsock.LocalPort = CInt(187) '187 is the port
			ServerFRM.Winsock.Listen() 'listens to see if client wants to connect
			ServerFRM.nickSERVER.Caption = nicknameTXT.Text 'put the username for the server in a lbl on serverfrm
		End If
		
		If Me.Caption = "Connect as Client" Then  'connects u to the server
			If IPtxt.Text = "Server's IP here" Then  Exit Sub 'just incase u forgot to put IP in
			If IPtxt.Text = "" Then  Exit Sub 'just incase u forgot to put IP in
			Load6(ClientFRM)
			ClientFRM.Winsock.Close() 'closes any previous connections
			ClientFRM.Winsock.Connect(IPtxt.Text, "187") 'sends ur IP to connect to server:187 is the port
			ClientFRM.nickCLIENT.Caption = nicknameTXT.Text 'puts username for client in a lbl on clientfrm
		End If
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		ConnectCMD.Enabled = False 'wont allow u to connect until u select necessary options
		YouripLBL.Caption = "Your IP:  " & Winsock.LocalIP 'shows u your IP address
		IPtxt.Enabled = False 'disabled till select server or client
		nicknameTXT.Enabled = False 'disabled till select server or client
		
	End Sub

	Private Sub ServerCMD_Click() Handles ServerCMD.Click
		Me.Caption = "Connect as Server" 'recaptions form to fit user
		
		IPtxt.Enabled = True 'needed button to connect
		nicknameTXT.Enabled = True 'needed button to connect
		ServerCMD.Enabled = False 'unneeded button to connect to server
		ClientCMD.Enabled = False 'unneeded button to connect to server
		IPtxt.Enabled = False 'unneeded txtbox to server
		ConnectCMD.Enabled = True 'needed button to connnect
		
	End Sub

End Class

' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module Mod_ShowDirs

	'.=========================================================================
	'.Browse Folders Module
	'.Copyright 1999 Tribble Software.  All rights reserved.
	'.Phone        : (616) 455-2055
	'.E-mail       : carltribble@earthlink.net
	'.=========================================================================
	' DO NOT DELETE THE COMMENTS ABOVE.  All other comments in this module
	' may be deleted from production code, but lines above must remain.
	'--------------------------------------------------------------------------
	'.Description  : This module calls three functions in shell32.dll to allow
	'.               the user to browse for a folder.
	'.
	'.Written By   : Carl Tribble
	'.Date Created : 10/05/1999 08:06:31 PM
	'.Rev. History
	' Comments     : The public entry point is the procedure tsGetPathFromUser,
	'                The selected folder name is returned in the form of a full
	'                path but without the trailing "\". If the User presses
	'                Cancel, or an error occurs, the procedure returns Null.
	'                This module is completely self-contained.  Simply copy it
	'                into your database to use it.
	'.-------------------------------------------------------------------------
	'.
	' ADDITIONAL NOTES
	'
	'  If you want your user to browse for file names you must use the module
	'  basBrowseFiles instead, or the common dialog activeX control.
	'
	'  TO STREAMLINE this module for production programs, you should remove
	'     1) Unnecessary comments
	'     2) Flag and Root Folder Constants which you do not intend to use.
	'     3) The test procedure tsGetPathFromUserTest
	'       *DO NOT REMOVE ANYTHING ELSE. Everything else is required.
	'
	'--------------------------------------------------------------------------
	'
	' INSTRUCTIONS
	'
	'         ( For a working example, open the Debug window  )
	'         ( and enter tsGetPathFromUserTest.              )
	'         (                                               )
	'         ( frmBrowseFoldersTest, if available, provides  )
	'         ( additional testing features.                  )
	'
	'.All the arguments for the function are optional.  You may call it with no
	'.arguments whatsoever and simply assign its return value to a variable of
	'.the Variant type.  For example
	'.
	'.   varFileName = tsGetPathFromUser()
	'.
	'.The function will return
	'.   the full path selected by the user, or
	'.   Null if an error occurs or if the user presses Cancel.
	'.
	'.Optional arguments may include any of the following
	'. rlngFlags     : one or more of the tscBF* Flag constants (declared
	'.                 below). Combine multiple constants like this
	'.                   tscBFReturnOnlyFSDirs Or tscBFDontGoBelowDomain
	'. lngRootFolder : a tscRF Root Folder constant (declared below) indicating
	'.                 what folder you want to start with.  These constants are
	'.                 not to be combined, just pick the one you want to use.
	'. strHeaderMsg  : a message you want to appear at the top of the dialog
	'.                 box.  Note although it is refered to internally as the
	'.                 Title it is NOT the dialog title, aka caption (the
	'                  caption is always "Browse for Folder").  The message
	'                  can be up to about 110 characters in length and
	'                  up to two lines.  It appears below the Title bar, but
	'                  above the actual folder box.
	'
	'.-------------------------------------------------------------------------
	'.
	
	Private Declare Function SHGetPathFromIDList Lib "shell32.dll" Alias "SHGetPathFromIDListA" (ByVal pidl As Integer, ByVal pszPath As String) As Integer
	
	Private Declare Function SHGetSpecialFolderLocation Lib "shell32.dll" (ByVal hwndOwner As Integer, ByVal nFolder As Integer, ByRef pidl As Mod_ShowDirs.ITEMIDLIST) As Integer
	
	Private Declare Function SHBrowseForFolder Lib "shell32.dll" Alias "SHBrowseForFolderA" (ByRef lpBrowseInfo As Mod_ShowDirs.BROWSEINFO) As Integer
	
	Friend Structure BROWSEINFO
	
		Public hOwner As Integer
		Public pidlRoot As Integer
		Public pszDisplayName As String
		Public lpszTitle As String
		Public ulFlags As Integer
		Public lpfn As Integer
		Public lParam As Integer
		Public iImage As Integer
	End Structure

	Friend Structure SHITEMID
	
		Public cb As Integer
		Public abID As Byte
	End Structure

	Friend Structure ITEMIDLIST
	
		Public mkid As Mod_ShowDirs.SHITEMID
	End Structure

	' Flag Constants
	Public Const tscBFReturnOnlyFSDirs As Short = &H1S
	Public Const tscBFDontGoBelowDomain As Short = &H2S
	Public Const tscBFStatusText As Short = &H4S
	Public Const tscBFReturnFSAncestors As Short = &H8S
	Public Const tscBFBrowseForComputer As Short = &H1000S
	Public Const tscBFBrowseForPrinter As Short = &H2000S
	
	' Root Folder Constants
	Public Const tscRFDesktop As Short = &H0S
	Public Const tscRFPrograms As Short = &H2S
	Public Const tscRFControls As Short = &H3S
	Public Const tscRFPrinters As Short = &H4S
	Public Const tscRFPersonal As Short = &H5S
	Public Const tscRFFavorites As Short = &H6S
	Public Const tscRFRecent As Short = &H8S
	Public Const tscRFBitBucket As Short = &HAS
	Public Const tscRFDesktopDirectory As Short = &H10S
	Public Const tscRFDrives As Short = &H11S
	Public Const tscRFNetwork As Short = &H12S
	Public Const tscRFNethood As Short = &H13S
	Public Const tscRFTemplates As Short = &H15S
	
	Public Function tsGetPathFromUser(Optional ByRef rlngflags As Integer = tscBFReturnOnlyFSDirs, Optional ByVal lngRootFolder As Integer = tscRFDrives, Optional ByVal strHeaderMsg As String = "") As Object
	' UPGRADE_INFO (#0551): The 'rlngflags' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		On Error GoTo tsGetPathFromUser_Err 
		Const conBufLen As Short = 512
		Dim bi As Mod_ShowDirs.BROWSEINFO
		Dim idl As Mod_ShowDirs.ITEMIDLIST
		Dim lngReturn As Integer
		Dim pidl As Integer
		Dim strPath As String = ""
		
		bi.hOwner = 0
		lngReturn = SHGetSpecialFolderLocation(bi.hOwner, lngRootFolder, idl)
		bi.pidlRoot = idl.mkid.cb
		bi.lpszTitle = strHeaderMsg
		bi.ulFlags = rlngflags
		pidl = SHBrowseForFolder(bi)
		strPath = Space(conBufLen)
		lngReturn = SHGetPathFromIDList(pidl, strPath)
		
		If lngReturn <> 0 Then 
			Return tsTrimNull(strPath)
		Else
			Return ""
		End If
		
tsGetPathFromUser_End:
		' IGNORED: On Error GoTo 0 
		Exit Function
		
tsGetPathFromUser_Err:
		Beep()
		MsgBox6(Err.Description, , "Error: " & Err.Number & " in function basBrowseFolders.tsGetPathFromUser")
		Resume tsGetPathFromUser_End 
		
	End Function

	' Trim Nulls from a string returned by an API call.
	
	Private Function tsTrimNull(ByVal strItem As String) As String
		
		On Error GoTo tsTrimNull_Err 
		Dim i As Short = InStr(strItem, ControlChars.NullChar)
		
		If i > 0 Then 
			Return VB.Left(strItem, i - 1)
		Else
			Return strItem
		End If
		
tsTrimNull_End:
		' IGNORED: On Error GoTo 0 
		Exit Function
		
tsTrimNull_Err:
		Beep()
		MsgBox6(Err.Description, , "Error: " & Err.Number & " in function basBrowseFolders.tsTrimNull")
		Resume tsTrimNull_End 
		
	End Function

	'--------------------------------------------------------------------------
	' Project      : tsDeveloperTools
	' Description  : An example of how you can call tsGetPathFromUser()
	' Calls
	' Accepts
	' Returns
	' Written By   : Carl Tribble
	' Date Created : 05/04/1999 11:19:41 AM
	' Rev. History
	' Comments     : This is provided merely as an example to the programmer
	'                It may be safely deleted from production code.
	'--------------------------------------------------------------------------
	
	Public Sub tsGetPathFromUserTest()
		
		On Error GoTo tsGetPathFromUserTest_Err 
		Dim lngFlags As Integer
		Dim lngRoot As Integer
		Dim strHeaderMsg As String = ""
		Dim varPath As Object = Nothing
		
		lngFlags = tscBFReturnOnlyFSDirs Or tscBFDontGoBelowDomain
		lngRoot = tscRFDrives
		strHeaderMsg = "This is where the header message displays. " & ControlChars.CrLf & "Note it only holds 2 full lines (about 100 " & "characters altogether)."
		varPath = tsGetPathFromUser(lngFlags, lngRoot, strHeaderMsg)
		
		If IsNull6(varPath) Then 
			Debug.WriteLine("User pressed 'Cancel'.")
		Else
			Debug.WriteLine(varPath)
		End If
		
tsGetPathFromUserTest_End:
		' IGNORED: On Error GoTo 0 
		Exit Sub
		
tsGetPathFromUserTest_Err:
		Beep()
		MsgBox6(Err.Description, , "Error: " & Err.Number & " in sub basBrowseFolders.tsGetPathFromUserTest")
		Resume tsGetPathFromUserTest_End 
		
	End Sub

End Module

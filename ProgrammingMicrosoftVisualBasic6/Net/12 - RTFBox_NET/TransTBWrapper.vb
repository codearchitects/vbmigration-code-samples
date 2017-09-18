' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<VB6Object("RTFDemo.TransTBWrapper")> _
Friend Class TransTBWrapper

	' ------------------------------------------------------------------------
	' Copyright © 1997 Microsoft Corporation. All rights reserved.
	'
	' You have a royalty-free right to use, modify, reproduce and distribute
	' the Sample Application Files (and/or any modified version) in any way
	' you find useful, provided that you agree that Microsoft has no warranty,
	' obligations or liability for any Sample Application Files.
	' ------------------------------------------------------------------------
	
	'-------------------------------------------------------------------------------
	'API declarations
	
	'Functions
	'Windows functions
	Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Short) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetParent' unamanged method with the following .NET member(s): System.Windows.Forms.Form.Parent
	Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.FromHwnd(Windows.Forms.Control.Handle), System.Drawing.Printing.PrintPageEventArgs.Graphics, System.Windows.Forms.PaintEventArgs.Graphics, System.Drawing.Graphics.GetHdc
	Private Declare Function GetDC Lib "user32" (ByVal hWnd As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseDC' unamanged method with the following .NET member(s): System.Drawing.Graphics.ReleaseHdc
	Private Declare Function ReleaseDC Lib "user32" (ByVal hWnd As Integer, ByVal hDC As Integer) As Integer
	'ImageList functions
	Private Declare Function ImageList_SetBkColor Lib "ComCtl32" (ByVal hIml As Integer, ByVal clrBk As Integer) As Integer
	
	'Constants
	'ImageList constants
	Private Const CLR_NONE As Integer = &HFFFFFFFFI
	
	'Styles
	'CommonControl styles
	Private Const CCS_NORESIZE As Short = &H4S
	'Prevents a toolbar from trying to resize to fill the top edge of the parent's client area.
	Private Const CCS_NODIVIDER As Short = &H40S
	'Prevents a toolbar from drawing a divider line on the top edge.
	'Toolbar styles
	Private Const TBSTYLE_LIST As Short = &H1000S
	'Puts captions beside buttons instead of below.
	Private Const TBSTYLE_FLAT As Short = &H800S
	'Makes toolbar buttons transparent and flat.
	Private Const TBSTYLE_TRANSPARENT As Short = &H8000S
	'Makes a toolbar transparent, but not the buttons.
	'Note: Under IE3, TBSTYLE_FLAT by itself makes a toolbar fully flat and transparent. Under IE4, TBSTYLE_FLAT and TBSTYLE_TRANSPARENT are both required.
	
	'Messages
	'Window messages
	Private Const WM_PAINT As Short = &HFS
	Private Const WM_USER As Integer = &H400%
	'Toolbar messages
	Private Const TB_GETSTYLE As Short = (WM_USER + 57)
	Private Const TB_SETSTYLE As Short = (WM_USER + 56)
	
	'-------------------------------------------------------------------------------
	'Property declarations
	
	'ListStyle property declarations.
	Private mfListStyle As Boolean 'The property value
	Private Const mfDefListStyle As Boolean = False
	'The default value
	Private Const msListStyleName As String = "ListStyle"
	'The property name
	
	'Transparent property declarations.
	Private mfTransparent As Boolean 'The property value
	Private Const mfDefTransparent As Boolean = False
	'The default value
	Private Const msTransparentName As String = "Transparent"
	'The property name
	
	'-------------------------------------------------------------------------------
	'Declarations for the toolbar which we are currently modifying
	
	'The toolbar
	Private moToolbar As VB6Toolbar
	
	'When we modify toolbar styles, we need to cache them so we can reset them later.
	Private mnToolbarStyles As Integer
	
	'When we get a toolbar, we will store its hWnd and the hWnd of the underlying
	'   ComCtl32.dll toolbar window.
	Private mhWndToolbarOCX As Integer
	Private mhWndToolbarDLL As Integer
	
	'-------------------------------------------------------------------------------
	'Code to restore a toolbar
	
	'We un-parent the ComCtl32.dll toolbar window from the ComCtl32.ocx toolbar
	'   window in order to achieve transparency. Re-parenting the DLL toolbar window
	'   on the OCX toolbar window before teardown of the app is required to prevent
	'   a GPF, but it does not restore the toolbar to a functional state; after
	'   reparenting, the toolbar no longer responds to the mouse. Therefore, if the
	'   user chooses to turn off transparency, we do not restore the parenting. We
	'   only restore the parenting when we're done with the toolbar in order to
	'   prevent teardown errors. This means that the client must call
	'
	'       Set TransTBWrapper.Toolbar = Nothing
	'
	'   before or during Form_Unload. We cannot reliably take care of this ourselves
	'   in the UserControl_Terminate event because the OCX toolbar windows generally
	'   tear down before this control (this is because OCX toolbars automatically
	'   bring themselves to the top of the ZOrder).
	Private Sub RestoreParenting()
		If moToolbar Is Nothing Then  Exit Sub
		SetParent(mhWndToolbarDLL, mhWndToolbarOCX)
	End Sub

	'Toolbar.Refresh does not take into account the changes we've made using
	'   messages instead of the ComCtl32.ocx toolbar object model. For some reason,
	'   resetting Button(1).Image causes everything to be reevaluated - it will get
	'   the new transparent images AND reset the button size if using List style.
	Private Sub RefreshToolbar()
		If moToolbar Is Nothing Then  Exit Sub
		If moToolbar.Buttons.Count = 0 Then  Exit Sub
		With moToolbar.Buttons(1)
			.Image = .Image
		End With
	End Sub

	'Restore the toolbar styles using the cached value.
	Private Sub RestoreStyles()
		If moToolbar Is Nothing Then  Exit Sub
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'mnToolbarStyles' argument. Consider creating an overload of the Declare statement.
		SendMessage(mhWndToolbarDLL, TB_SETSTYLE, 0, mnToolbarStyles)
	End Sub

	'-------------------------------------------------------------------------------
	'Property code
	
	'Get and set the toolbar which we will modify
	Public Property Toolbar() As VB6Toolbar
		Get
			Return moToolbar
	 	End Get
		Set(ByVal NewToolbar As VB6Toolbar)
			' UPGRADE_INFO (#0501): The 'hWndToolbarOCX' member isn't used anywhere in current application.
			Dim hWndToolbarOCX As Integer
			' UPGRADE_INFO (#0501): The 'hWndToolbarDLL' member isn't used anywhere in current application.
			Dim hWndToolbarDLL As Integer
			Dim hDC As Integer
			
			'Put everything back the way it was before
			RestoreStyles()
			RestoreParenting()
			RefreshToolbar()
			
			'Get the new toolbar
			moToolbar = NewToolbar
			If moToolbar Is Nothing Then 
				RefreshContainingBand()
				Exit  Property
			End If
			
			'Make it invisible
			moToolbar.Visible = False
			
			'Cache the window handles and style bits
			mhWndToolbarOCX = moToolbar.hWnd
			mhWndToolbarDLL = FindWindowEx(mhWndToolbarOCX, 0, "msvb_lib_toolbar", Nothing)
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0' argument. Consider creating an overload of the Declare statement.
			mnToolbarStyles = SendMessage(mhWndToolbarDLL, TB_GETSTYLE, 0, 0)
			
			'The following code allows you to create a transparent toolbar with working
			'   tooltips in Form_Load. Without this code, the regular toolbar must be
			'   shown and refreshed before it is made transparent in order for the
			'   tooltips to show up.
			hDC = GetDC(mhWndToolbarOCX)
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0' argument. Consider creating an overload of the Declare statement.
			SendMessage(mhWndToolbarOCX, WM_PAINT, hDC, 0)
			ReleaseDC(mhWndToolbarOCX, hDC)
			
			'Make the images transparent
			MakeImagesTransparent()
			
			'Make the modifications to the toolbar
			ChangeToolbar()
	 	End Set
	End Property

	'Get and set the list style
	Public Property ListStyle() As Boolean
		Get
			Return mfListStyle
	 	End Get
		Set(ByVal Value As Boolean)
			If mfListStyle <> Value Then 
				mfListStyle = Value
				'Change the toolbar according to the style
				ChangeToolbar()
			End If
	 	End Set
	End Property

	'Get and set the transparency
	Public Property Transparent() As Boolean
		Get
			Return mfTransparent
	 	End Get
		Set(ByVal Value As Boolean)
			If mfTransparent <> Value Then 
				mfTransparent = Value
				'Change the toolbar according to the style
				ChangeToolbar()
			End If
	 	End Set
	End Property

	'-------------------------------------------------------------------------------
	'Code to modify a toolbar
	
	'This routine makes the images in the ImageList transparent. I will do it once
	'   each time I'm given a toolbar. I don't need to undo it because the regular
	'   toolbar still looks the same after this change. For the same reason, I don't
	'   need to redo it when properties (ListStyle or Transparent) change.
	Private Sub MakeImagesTransparent()
		Dim oImageList As VB6ImageList = moToolbar.ImageList
		
		'Get the relevant ImageList, if any
		If oImageList Is Nothing Then  Exit Sub
		
		'Set the ImageList's backcolor to transparent
		ImageList_SetBkColor(oImageList.hImageList, CLR_NONE)
	End Sub

	'This routine modifies the toolbar according to the current set of properties
	'   (ListStyle, Transparent). It has three main parts
	'   1.  Set the toolbar styles.
	'   2.  Refresh the toolbar.
	'   3.  Refresh the coolbar band which contains the toolbar.
	Private Sub ChangeToolbar()
		Dim nStyle As Integer
		Dim nCurrentStyles As Integer
		
		If moToolbar Is Nothing Then  Exit Sub
		
		'1. Set the toolbar styles
		
		'Start with the existing styles
		nStyle = mnToolbarStyles
		'Add styles to make it size correctly and to prevent a divider line from
		'   being drawn
		nStyle = nStyle Or CCS_NORESIZE Or CCS_NODIVIDER
		
		'Add the List style if desired
		If mfListStyle Then 
			nStyle = nStyle Or TBSTYLE_LIST
		End If
		
		'If Transparent style then
		If mfTransparent Then 
			'Add the transparent style
			'Note: Under IE3, TBSTYLE_FLAT by itself makes a toolbar fully flat and
			'   transparent. Under IE4, TBSTYLE_FLAT and TBSTYLE_TRANSPARENT are
			'   both required. The IE4 code will work with both.
			nStyle = nStyle Or TBSTYLE_FLAT Or TBSTYLE_TRANSPARENT
		End If
		
		'Get the current styles for comparison
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0' argument. Consider creating an overload of the Declare statement.
		nCurrentStyles = SendMessage(mhWndToolbarDLL, TB_GETSTYLE, 0, 0)
		'If the new styles differ from the old styles, then
		If nStyle <> nCurrentStyles Then 
			'Set the new styles
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the 'nStyle' argument. Consider creating an overload of the Declare statement.
			SendMessage(mhWndToolbarDLL, TB_SETSTYLE, 0, nStyle)
			
			'2. Refresh the toolbar
			RefreshToolbar()
		End If
		
		'3. Refresh the coolbar band which contains the toolbar
		RefreshContainingBand()
	End Sub

	'Refresh the coolbar band which contains this toolbar
	Private Sub RefreshContainingBand()
		Dim oCoolbar As Object = Nothing
		Dim oBand As Object = Nothing
		' UPGRADE_INFO (#0501): The 'fWrappable' member isn't used anywhere in current application.
		Dim fWrappable As Boolean
		Dim nMinHeight As Single
		
		'Get the coolbar
		oCoolbar = ContainingCoolbar
		If oCoolbar Is Nothing Then  Exit Sub
		
		'Get the band
		oBand = ContainingBand(oCoolbar)
		If oBand Is Nothing Then  Exit Sub
		
		'Undo the parenting
		oBand.Child = Nothing
		
		'Set the minheight
		If Not moToolbar Is Nothing Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'oCoolbar.Orientation'. Consider using the GetDefaultMember6 helper method.
			If oCoolbar.Orientation = ComCtl3.OrientationConstants.cc3OrientationHorizontal Then 
				'Get the height of the buttons
				nMinHeight = moToolbar.ButtonHeight
				If Not mfTransparent Then 
					'Add room for the border
					nMinHeight = nMinHeight + (2 * moToolbar.Buttons(1).Top)
				End If
			Else
				'Get the width of the buttons
				nMinHeight = moToolbar.ButtonWidth
				If Not mfTransparent Then 
					'Add room for the border.
					nMinHeight = nMinHeight + (2 * moToolbar.Buttons(1).Left)
				End If
			End If
			oBand.MinHeight = nMinHeight
		End If
		
		'Redo the parenting. This will cause the band to ask for our hWnd and to
		'   validate our height or width, depending on the coolbar orientation.
		' UPGRADE_WARNING (#2004): The Extender property isn't supported. This replacement property always returns a reference to the control itself.
		oBand.Child = Extender
		
		'Ask the coolbar to repaint
		oCoolbar.Refresh
	End Sub

	'Get the coolbar which contains us (if any)
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Private ReadOnly Property ContainingCoolbar() As Object
		Get
			On Error Resume Next 
			' UPGRADE_WARNING (#2004): The Extender property isn't supported. This replacement property always returns a reference to the control itself.
			ContainingCoolbar = Extender.Container
			Err.Clear()
	 	End Get
	End Property

	'Get the coolbar band which contains us (if any)
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Private ReadOnly Property ContainingBand(ByVal CoolBar As Object) As Object
		Get
			Dim oBand As Object = Nothing
			
			For Each oBand In CoolBar.Bands
				' UPGRADE_WARNING (#2004): The Extender property isn't supported. This replacement property always returns a reference to the control itself.
				If oBand.Child Is Extender Then 
					Return oBand
				End If
			Next
	 	End Get
	End Property

	'-------------------------------------------------------------------------------
	'Code to provide an hWnd
	
	'Coolbar will ask us for an hWnd in order to parent us on a band. We don't want
	'   it to parent us. Rather we want it to parent the toolbar window from
	'   ComCtl32.dll.
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Shadows ReadOnly Property hWnd() As Integer
	' UPGRADE_INFO (#0501): The 'hWnd' member isn't used anywhere in current application.
		Get
			If moToolbar Is Nothing Then 
				Return MyBase.hWnd
			Else
				Return mhWndToolbarDLL
			End If
	 	End Get
	End Property

	'-------------------------------------------------------------------------------
	'Code to persist properties
	
	Protected Overrides Sub UserControl_ReadProperties(ByRef PropBag As VB6PropertyBag)
		ListStyle = PropBag.ReadProperty(msListStyleName, mfDefListStyle)
		Transparent = PropBag.ReadProperty(msTransparentName, mfDefTransparent)
	End Sub

	Protected Overrides Sub UserControl_WriteProperties(ByRef PropBag As VB6PropertyBag)
		PropBag.WriteProperty(msListStyleName, mfListStyle, mfDefListStyle)
		PropBag.WriteProperty(msTransparentName, mfTransparent, mfDefTransparent)
	End Sub

	'-------------------------------------------------------------------------------
	'Resizing code
	
	'Coolbar will try to resize me in order to validate the minheight. If I set the
	'   size back to what I think the minheight should be, then Coolbar will use my
	'   size for the minheight. This ensures that the minheight is always
	'   appropriate.
	Private Sub UserControl_Resize() Handles MyBase.Resize
		Dim oCoolbar As Object = Nothing
		Dim nMinHeight As Single
		Static fResizing As Boolean
		
		'This static flag prevents us from getting into problems with recursion
		If Not fResizing Then 
			If moToolbar Is Nothing Then  Exit Sub
			
			oCoolbar = ContainingCoolbar
			If oCoolbar Is Nothing Then  Exit Sub
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'oCoolbar.Orientation'. Consider using the GetDefaultMember6 helper method.
			If oCoolbar.Orientation = ComCtl3.OrientationConstants.cc3OrientationHorizontal Then 
				'Get the height of the buttons
				nMinHeight = moToolbar.ButtonHeight
				'If opaque, add room for the border
				If Not mfTransparent Then 
					nMinHeight = nMinHeight + (2 * moToolbar.Buttons(1).Top)
				End If
				'Set the Height, preventing recursion
				fResizing = True
				Height = nMinHeight
				fResizing = False
			Else
				'Get the width of the buttons
				nMinHeight = moToolbar.ButtonWidth
				'If opaque, add room for the border
				If Not mfTransparent Then 
					nMinHeight = nMinHeight + (2 * moToolbar.Buttons(1).Left)
				End If
				'Set the Width, preventing recursion
				fResizing = True
				Width = nMinHeight
				fResizing = False
			End If
		End If
	End Sub

End Class

VERSION 5.00
Begin VB.UserControl SoftBttn 
   ClientHeight    =   1155
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   1440
   ClipControls    =   0   'False
   PropertyPages   =   "UCTLBTTN.ctx":0000
   ScaleHeight     =   77
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   96
   ToolboxBitmap   =   "UCTLBTTN.ctx":0026
End
Attribute VB_Name = "SoftBttn"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Description = "Soft Button Control"
Option Explicit
' ------------------------------------------------------------------------
'      Copyright © 1997 Microsoft Corporation.  All rights reserved.
'
' You have a royalty-free right to use, modify, reproduce and distribute
' the Sample Application Files (and/or any modified version) in any way
' you find useful, provided that you agree that Microsoft has no warranty,
' obligations or liability for any Sample Application Files.
' ------------------------------------------------------------------------

'-------------------------------------------------------------------------
'This user control mimics the behavior of a button in the VB5 toolbar.
'When no mouse is over the button, it appears flat, like an image with a
'transparent background.  When a mouse is over the button, a soft 3D edge
'is drawn.  When the mouse is pressed a sunken 3D edge is drawn.  This control
'creates its own Tooltips because the VB intrinsic tooltips are disabled
'by the controls use of SetCapture.
'Needed files:
'   modTlTip.bas    module providing WinProc needed for ToolTips
'   clsDraw.cls     Class module provides transparent and disabled drawing
'                   procedures
'   modSftBn.bas    Declarations of needed Types, API Functions, and Constants
'-------------------------------------------------------------------------
'Property Name constants
Private Const msURL_PICTURE_NAME = "URLPicture"
Private Const msBACK_COLOR_NAME = "BackColor"
Private Const msPICTURE_NAME = "Picture"
Private Const msENABLED_NAME = "Enabled"
Private Const msMASK_COLOR_NAME = "MaskColor"
Private Const msUSE_MASK_COLOR_NAME = "UseMaskColor"
Private Const msPLAY_SOUNDS_NAME = "PlaySounds"
Private Const msTOOL_TIP_TEXT_NAME = "ToolTipText"


'Property Values
Private m_bEnabled As Boolean
Private m_clrMaskColor As OLE_COLOR
Private m_bUseMaskColor As Boolean
Private m_bPlaySounds As Boolean
Private m_picPictured As Picture
Private m_sToolTipText As String
Private m_sURLPicture As String

'Class level variables
Private msToolTipBuffer As String         'Tool tip text; This string must have
                                          'module or global level scope, because
                                          'a pointer to it is copied into a
                                          'ToolTipText structure
Private mbClearURLOnly As Boolean
Private mbClearPictureOnly As Boolean
Private mbToolTipNotInExtender As Boolean
Private moDrawTool As clsDrawPictures
Private mbGotFocus As Boolean
Private mbMouseOver As Boolean
Private miCurrentState As Integer
Private mWndProcNext As Long            'The address entry point for the subclassed window
Private mHWndSubClassed As Long         'hWnd of the subclassed window
Private mbLeftMouseDown As Boolean
Private mbLeftWasDown As Boolean
Private mudtButtonRect As RECT
Private mudtPictureRect As RECT
Private mudtPicturePoint As POINTAPI
Private mbPropertiesLoaded As Boolean
Private mbEnterOnce As Boolean
Private mbMouseDownFired As Boolean
Private mlhHalftonePal As Long

#If DEBUGSUBCLASS Then                      'Tool that checks if in break mode and then
    Private moProcHook As Object            'Sends messages to mWndPRocNext instead of
#End If                                     'Address of my function

Public Event Click()
Public Event MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
Public Event MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
Public Event MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
Public Event PopUp()


'****************************
'UserControl event procedures
'****************************
Private Sub UserControl_Click()
    mbMouseOver = False     'Set mbMouseOver = False so that SetCapture
                            'will be called again.  For some reason, capture
                            'is released during MouseClick
    MouseOver
End Sub

Private Sub UserControl_EnterFocus()
    '-------------------------------------------------------------------------
    'Purpose:   If tabstop property is true, show button raised so that user
    '           can see that button received focus.
    '-------------------------------------------------------------------------
    On Error GoTo UserControl_EnterFocusError
    'Error may occur if TabStop property is not available
    If UserControl.Extender.TabStop Then
        On Error Resume Next
        mbGotFocus = True
        If Not miCurrentState = giRAISED Then DrawButtonState giRAISED
    End If
UserControl_EnterFocusError:
    Exit Sub
End Sub

Private Sub UserControl_ExitFocus()
    '-------------------------------------------------------------------------
    'Purpose:   Flatten button if the mouse is not over it
    '-------------------------------------------------------------------------
    If Not mbMouseOver Then DrawButtonState giFLATTENED
    mbGotFocus = False
End Sub

Private Sub UserControl_Initialize()
    mbPropertiesLoaded = False
    UserControl.ScaleMode = vbPixels
    UserControl.PaletteMode = vbPaletteModeContainer
    Set moDrawTool = New clsDrawPictures
    mlhHalftonePal = CreateHalftonePalette(UserControl.hDC)
End Sub

Private Sub UserControl_InitProperties()
    '-------------------------------------------------------------------------
    'Purpose:   Set the default properties to be displayed the first time this
    '           control is placed on a container
    '-------------------------------------------------------------------------
    On Error Resume Next
    'Error may occur if TabStop property is not available
    BackColor = UserControl.BackColor
    Enabled = True
    UseMaskColor = False
    MaskColor = vbWhite
    UserControl.Extender.TabStop = False
    UserControl.ScaleMode = vbPixels
    ToolTipText = ""
    mbPropertiesLoaded = True
End Sub

Private Sub UserControl_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    '-------------------------------------------------------------------------
    'Purpose:   If the mouse is over the button and the left button is down
    '           show that the button is sunken and set a flag that the button
    '           is down
    '-------------------------------------------------------------------------
    With UserControl
        If Button = vbLeftButton And (x >= 0 And x <= .ScaleWidth) And (y >= 0 And y <= .ScaleHeight) Then
            mbLeftMouseDown = True
            DrawButtonState giSUNKEN
        End If
    End With
    RaiseEvent MouseDown(Button, Shift, x, y)
End Sub

Private Sub UserControl_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    '-------------------------------------------------------------------------
    'Purpose:   If the mouse is over show the button raised.  If the mouse is
    '           over and the left mouse is down and was down when the mouse left
    '           the button show button sunken.  If mouse is off button, flatten,
    '           unless left button is down show the mouse raised until the button
    '           is released.
    '-------------------------------------------------------------------------
    With UserControl
        If (x <= .ScaleWidth And x >= 0) And (y <= .ScaleHeight And y >= 0) Then
            If mbLeftWasDown Then
                mbLeftMouseDown = True
                mbLeftWasDown = False
                DrawButtonState giSUNKEN
            Else
                If Button <> vbLeftButton Then MouseOver
            End If
            RaiseEvent MouseMove(Button, Shift, x, y)
        Else
            If mbLeftMouseDown Then
                mbLeftWasDown = True
                mbLeftMouseDown = False
                DrawButtonState giRAISED
                RaiseEvent MouseMove(Button, Shift, x, y)
            ElseIf Not mbLeftWasDown Then
                Flatten
            Else
                RaiseEvent MouseMove(Button, Shift, x, y)
            End If
        End If
    End With
End Sub

Private Sub UserControl_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
    '-------------------------------------------------------------------------
    'Purpose:   If the left mouse was down and the left button is up and the mouse
    '           is over the button raise a Click event.  If left button was down
    '           and mouse is off button flatten button.
    '-------------------------------------------------------------------------
    With UserControl
        If (x >= 0 And x <= .ScaleWidth) And (y >= 0 And y <= .ScaleHeight) Then
            If (mbLeftMouseDown Or mbLeftWasDown) And Button = vbLeftButton Then
                mbLeftMouseDown = False
                DrawButtonState giRAISED
                MakeClick
            End If
        ElseIf mbLeftWasDown And Button = vbLeftButton Then
            mbLeftWasDown = False
            Flatten
        Else
            mbMouseOver = False     'Set mbMouseOver = False so that SetCapture
                                    'will be called again.  For some reason, capture
                                    'is released during MouseUp
        End If
    End With
    RaiseEvent MouseUp(Button, Shift, x, y)
End Sub

Private Sub UserControl_Paint()
    DrawButtonState miCurrentState
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    Dim sUrl As String
    Dim picMine As Picture
    On Error Resume Next
    ' Read in the properties that have been saved into the PropertyBag...
    With PropBag
        sUrl = .ReadProperty(msURL_PICTURE_NAME, "")        ' Read URLPicture property value
        If Len(sUrl) <> 0 Then                         ' If a URL has been entered...
            URLPicture = sUrl                        ' Attempt to download it now, URL may be unavailable at this time
        Else
            Set picMine = PropBag.ReadProperty(msPICTURE_NAME, UserControl.Picture) ' Read Picture property value
            If Not (picMine Is Nothing) Then            ' URL is not available
                Set Picture = picMine                   ' Use existing picture (This is used only if URL is empty)
            End If
        End If
    End With
    BackColor = PropBag.ReadProperty(msBACK_COLOR_NAME, UserControl.BackColor)
    Enabled = PropBag.ReadProperty(msENABLED_NAME, True)
    MaskColor = PropBag.ReadProperty(msMASK_COLOR_NAME, vbWhite)
    UseMaskColor = PropBag.ReadProperty(msUSE_MASK_COLOR_NAME, False)
    PlaySounds = PropBag.ReadProperty(msPLAY_SOUNDS_NAME, False)
    ToolTipText = PropBag.ReadProperty(msTOOL_TIP_TEXT_NAME, "")
    InstanciateToolTipsWindow
    mbPropertiesLoaded = True
End Sub

Private Sub UserControl_Terminate()
    Set moDrawTool = Nothing
    DeleteObject mlhHalftonePal
    glToolsCount = glToolsCount - 1
    UnSubClass
    If gbToolTipsInstanciated And glToolsCount = 0 Then
        DestroyWindow gHWndToolTip
    End If
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    If Len(m_sURLPicture) <> 0 Then
        PropBag.WriteProperty msURL_PICTURE_NAME, m_sURLPicture
    Else
        PropBag.WriteProperty msPICTURE_NAME, m_picPictured
    End If
    PropBag.WriteProperty msBACK_COLOR_NAME, UserControl.BackColor
    PropBag.WriteProperty msENABLED_NAME, m_bEnabled
    PropBag.WriteProperty msMASK_COLOR_NAME, m_clrMaskColor
    PropBag.WriteProperty msUSE_MASK_COLOR_NAME, m_bUseMaskColor
    PropBag.WriteProperty msPLAY_SOUNDS_NAME, m_bPlaySounds
    PropBag.WriteProperty msTOOL_TIP_TEXT_NAME, m_sToolTipText
End Sub

Private Sub UserControl_Resize()
    'Reevaluate coordinates
    'Repaint control
    PositionChanged
    DrawButtonState miCurrentState
End Sub

'**********************
'Public Properties
'**********************
Public Property Let ToolTipText(ByVal sToolTip As String)
    m_sToolTipText = sToolTip
    'If this property gets called with more than an empty
    'string, I know for sure that there is not a ToolTipText
    'extender property
    If Len(sToolTip) <> 0 Then mbToolTipNotInExtender = True
    PropertyChanged (msTOOL_TIP_TEXT_NAME)
End Property

Public Property Get ToolTipText() As String
Attribute ToolTipText.VB_Description = "Returns/sets the text displayed when the mouse is paused over the control."
    ToolTipText = m_sToolTipText
End Property

Public Property Let PlaySounds(ByVal bPlaySounds As Boolean)
    'The following line of code ensures that the integer
    'value of the boolean parameter is either
    '0 or -1.  It is known that Access 97 will
    'set the boolean's value to 255 for true.
    'In this case a P-Code compiled VB5 built
    'OCX will return True for the expression
    '(Not [boolean variable that ='s 255]).  This
    'line ensures the reliability of boolean operations
    If CBool(bPlaySounds) Then bPlaySounds = True Else bPlaySounds = False
    m_bPlaySounds = bPlaySounds
    PropertyChanged (msPLAY_SOUNDS_NAME)
End Property

Public Property Get PlaySounds() As Boolean
Attribute PlaySounds.VB_Description = "Returns or sets whether or not system sounds are played for user generated events."
Attribute PlaySounds.VB_ProcData.VB_Invoke_Property = ";Behavior"
    PlaySounds = m_bPlaySounds
End Property

Public Property Let MaskColor(ByVal clrMaskColor As OLE_COLOR)
    'If there is a valid picture, repaint control
    m_clrMaskColor = clrMaskColor
    If m_bUseMaskColor And Not m_picPictured Is Nothing Then DrawButtonState miCurrentState
    PropertyChanged (msMASK_COLOR_NAME)
End Property

Public Property Get MaskColor() As OLE_COLOR
Attribute MaskColor.VB_Description = "Returns or sets a color in a button's picture to be a 'mask' (that is, transparent)."
Attribute MaskColor.VB_ProcData.VB_Invoke_Property = "StandardColor;Appearance"
    MaskColor = m_clrMaskColor
End Property

Public Property Let UseMaskColor(ByVal bUseMaskColor As Boolean)
    'If true, use the mask color.  Mask color only applies
    'to bitmaps not icons.
    'Repaint control
    'Validate whether correct picture type is provided
    
    'The following line of code ensures that the integer
    'value of the boolean parameter is either
    '0 or -1.  It is known that Access 97 will
    'set the boolean's value to 255 for true.
    'In this case a P-Code compiled VB5 built
    'OCX will return True for the expression
    '(Not [boolean variable that ='s 255]).  This
    'line ensures the reliability of boolean operations
    If CBool(bUseMaskColor) Then bUseMaskColor = True Else bUseMaskColor = False
    m_bUseMaskColor = bUseMaskColor
    If m_picPictured Is Nothing Then
        If m_picPictured.Type = vbPicTypeBitmap Then DrawButtonState miCurrentState
    End If
    PropertyChanged (msUSE_MASK_COLOR_NAME)
End Property

Public Property Get UseMaskColor() As Boolean
Attribute UseMaskColor.VB_Description = "Returns or sets a value that determines whether the color assigned in the MaskColor property is used as a 'mask'. (That is, used to create transparent regions.)"
Attribute UseMaskColor.VB_ProcData.VB_Invoke_Property = ";Appearance"
    UseMaskColor = m_bUseMaskColor
End Property

Public Property Let BackColor(ByVal clrBackColor As OLE_COLOR)
    'Control will be repainted because VB will
    'fire paint event
    UserControl.BackColor = clrBackColor
    DrawButtonState miCurrentState
    PropertyChanged (msBACK_COLOR_NAME)
End Property

Public Property Get BackColor() As OLE_COLOR
Attribute BackColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
Attribute BackColor.VB_ProcData.VB_Invoke_Property = "StandardColor;Appearance"
Attribute BackColor.VB_UserMemId = -501
    BackColor = UserControl.BackColor
End Property

Public Property Set Picture(ByVal picPicture As Picture)
Attribute Picture.VB_Description = "Returns or sets a graphic to be displayed  on the control."
Attribute Picture.VB_ProcData.VB_Invoke_PropertyPutRef = "StandardPicture;Appearance"
    'Validate what kind of picture is passed
    'Only allow bitmaps and icons
    'If not in runtime display message that UseMaskColor can't be
    'used with icons, if picture is icon.
    'If picture is icon, make sure UseMaskColor is false
    'Paint Control
    If Not picPicture Is Nothing Then
        With picPicture
            If (.Type <> vbPicTypeBitmap) And (.Type <> vbPicTypeNone) And (.Type <> vbPicTypeIcon) Then
                If Not UserControl.Ambient.UserMode Then
                    MsgBox LoadResString(giINVALID_PIC_TYPE), vbOKOnly, UserControl.Name
                End If
                Exit Property
            End If
        End With
    End If
    If Not mbClearPictureOnly Then
        mbClearURLOnly = True       ' If Picture property is not being set by the URLPicture
        URLPicture = ""             ' property then clear the URLPicture value...
        mbClearURLOnly = False
    End If
    
    If (Not picPicture Is Nothing) Then
        If (picPicture.Handle = 0) Then Set picPicture = Nothing
    End If
    Set m_picPictured = picPicture
    PositionChanged
    DrawButtonState miCurrentState
    PropertyChanged (msPICTURE_NAME)
End Property

Public Property Get Picture() As Picture
    Set Picture = m_picPictured
End Property

Public Property Let URLPicture(ByVal Url As String)
    If (m_sURLPicture <> Url) Then                   ' Do only if value has changed...
        mbClearPictureOnly = Not mbClearURLOnly      ' If Picture property is not being set by the URLPicture
                                                     ' property then clear the URLPicture value...
        m_sURLPicture = Url                          ' Save URL string value to global variable
        PropertyChanged msURL_PICTURE_NAME           ' Notify property bag of property change

        If Not mbClearURLOnly Then
            On Error GoTo ErrorHandler               ' Handle Error if URL is unavailable or Invalid...
            If (Url <> "") Then
                UserControl.AsyncRead Url, vbAsyncTypePicture, msPICTURE_NAME ' Begin async download of picture file...
            Else
                Set Picture = Nothing
            End If
        End If
    End If
ErrorHandler:
    mbClearPictureOnly = False
End Property

Public Property Get URLPicture() As String
Attribute URLPicture.VB_Description = "Returns or sets the URL address of a picture to be used instead of the Picture property."
Attribute URLPicture.VB_ProcData.VB_Invoke_Property = ";Appearance"
    URLPicture = m_sURLPicture                         ' Return URL string value
End Property

Public Property Let Enabled(ByVal bEnabled As Boolean)
    'If button is raised, flatten it
    'Draw disabled appearance of picture
    Dim lresult As Long
    'The following line of code ensures that the integer
    'value of the boolean parameter is either
    '0 or -1.  It is known that Access 97 will
    'set the boolean's value to 255 for true.
    'In this case a P-Code compiled VB5 built
    'OCX will return True for the expression
    '(Not [boolean variable that ='s 255]).  This
    'line ensures the reliability of boolean operations
    If CBool(bEnabled) Then bEnabled = True Else bEnabled = False
    UserControl.Enabled = bEnabled
    m_bEnabled = bEnabled
    If bEnabled Then
        DrawButtonState giFLATTENED
    Else
        If miCurrentState = giRAISED Then
            'Call flatten as if button does not have focus
            If mbGotFocus Then
                'Get rid of focus
                mbGotFocus = False
            End If
            Flatten
        End If
        DrawButtonState giDISABLED
    End If
    PropertyChanged (msENABLED_NAME)
End Property

Public Property Get Enabled() As Boolean
Attribute Enabled.VB_Description = "Returns/sets a value that determines whether an object can respond to user-generated events."
Attribute Enabled.VB_ProcData.VB_Invoke_Property = ";Behavior"
Attribute Enabled.VB_UserMemId = -514
    Enabled = UserControl.Enabled
End Property

'*************************
'Private Procedures
'*************************

Private Sub MakeClick()
    '-------------------------------------------------------------------------
    'Purpose:   Raise a Click event to container, play sound
    '-------------------------------------------------------------------------
    '-----------------------------------------
    '- Added for sound support
    '-----------------------------------------
    If m_bPlaySounds Then PlaySound EVENT_MENU_COMMAND, 0, SND_SYNC
    '-----------------------------------------
    RaiseEvent Click
End Sub

Private Sub MouseOver()
    '-------------------------------------------------------------------------
    'Purpose:   Call whenever the mouse is over the button and
    '           button needs raised appearance and capture set
    '-------------------------------------------------------------------------
    If miCurrentState <> giRAISED Then DrawButtonState giRAISED
    
    If Not mbMouseOver Then
        Capture True
        mbMouseOver = True
        '-----------------------------------------
        '- Added for sound support
        '-----------------------------------------
        If Not mbEnterOnce Then
            RaiseEvent PopUp
            If m_bPlaySounds Then PlaySound EVENT_MENU_POPUP, 0, SND_SYNC
            mbEnterOnce = True
        End If
        '-----------------------------------------
    End If
End Sub

Private Sub Flatten()
    '-------------------------------------------------------------------------
    'Purpose:   Call whenever the mouse is off the control
    '           and capture needs released and button needs
    '           flattened appearance
    '-------------------------------------------------------------------------
    If mbMouseOver Then Capture False
    mbMouseOver = False
    If (Not mbGotFocus) And miCurrentState <> giFLATTENED Then DrawButtonState giFLATTENED
    '-----------------------------------------
    '- Added for sound support
    '-----------------------------------------
    '   PlaySound EVENT_MENU_POPUP, 0, SND_SYNC
    mbEnterOnce = False
    '-----------------------------------------
End Sub

Private Sub UserControl_AsyncReadComplete(AsyncProp As AsyncProperty)
    On Error GoTo ErrorHandler
    
    If (AsyncProp.PropertyName = msPICTURE_NAME) Then ' Picture download is complete
        mbClearPictureOnly = True
        Set Picture = AsyncProp.Value           ' Store picture data to property...
    End If
ErrorHandler:
    mbClearPictureOnly = False
End Sub

Private Sub AddTool(hwnd As Long)
    '-------------------------------------------------------------------------
    'Purpose:   Add a tool to the ToolTips object
    'In:        [hWnd]
    '               hWnd of Tool being added
    '-------------------------------------------------------------------------
                   
    Dim ti As TOOLINFO
    
    With ti
        .cbSize = Len(ti)
        .uId = hwnd
        .hwnd = hwnd
        .hinst = App.hInstance
        .uFlags = TTF_IDISHWND
        .lpszText = LPSTR_TEXTCALLBACK
    End With
    
    SendMessage gHWndToolTip, TTM_ADDTOOL, 0, ti
    SendMessage gHWndToolTip, TTM_ACTIVATE, 1, ByVal hwnd
    Exit Sub
End Sub

Private Sub InstanciateToolTipsWindow()
    '-------------------------------------------------------------------------
    'Purpose:   Instanciate needed collections.
    '           Create ToolTips Class window
    '-------------------------------------------------------------------------
    glToolsCount = glToolsCount + 1
    If UserControl.Ambient.UserMode Then
        If Not gbToolTipsInstanciated Then
            gbToolTipsInstanciated = True
            InitCommonControls
            gHWndToolTip = CreateWindowEX(WS_EX_TOPMOST, TOOLTIPS_CLASS, vbNullString, 0, _
                      CW_USEDEFAULT, CW_USEDEFAULT, _
                      CW_USEDEFAULT, CW_USEDEFAULT, _
                      0, 0, _
                      App.hInstance, _
                      ByVal 0)
            SendMessage gHWndToolTip, TTM_ACTIVATE, 1, ByVal 0
            
            #If DEBUGSUBCLASS Then
                If goWindowProcHookCreator Is Nothing Then Set goWindowProcHookCreator = CreateObject("DbgWindowProc.WindowProcHookCreator")
            #End If
        End If
        'Sub class this code module to receive
        'window messages for the Usercontrol
        SubClass UserControl.hwnd
        'Add Register Usercontrol with ToolTip window
        AddTool UserControl.hwnd
    End If
End Sub

Private Sub SubClass(hwnd)
    '-------------------------------------------------------------------------
    'Purpose:   Subclass control so that the ToolTip Need text message can be
    '           handled.  Store handle of class as UserData of control window
    '-------------------------------------------------------------------------
    Dim lresult As Long
    
    UnSubClass
    
    #If DEBUGSUBCLASS Then
        'If in debug, SubClass window using address of WindowProcHook
        'Let WindowProcHook CallWindowProc at address of my function
        'if in run mode but call the previous address if in break mode
        'this prevents crashes in break mode
        Set moProcHook = goWindowProcHookCreator.CreateWindowProcHook
        With moProcHook
            .SetMainProc AddressOf SubWndProc
            mWndProcNext = SetWindowLong(hwnd, GWL_WNDPROC, CLng(.ProcAddress))
            .SetDebugProc mWndProcNext
        End With
    #Else
        mWndProcNext = SetWindowLong(hwnd, GWL_WNDPROC, AddressOf SubWndProc)
    #End If
    
    If mWndProcNext Then
        mHWndSubClassed = hwnd
        lresult = SetWindowLong(hwnd, GWL_USERDATA, ObjPtr(Me))
    End If
End Sub

Private Sub UnSubClass()
    '-------------------------------------------------------------------------
    'Purpose:   Unsubclass control
    '-------------------------------------------------------------------------
    If mWndProcNext Then
        SetWindowLong mHWndSubClassed, GWL_WNDPROC, mWndProcNext
        mWndProcNext = 0
        
        #If DEBUGSUBCLASS Then
            Set moProcHook = Nothing
        #End If
        
    End If
End Sub

Private Sub Capture(bCapture As Boolean)
    '-------------------------------------------------------------------------
    'Purpose:   Is the only place where setcapture and releasecapture are called
    '           setcapture may be called after mouse clicks because VB seems to
    '           release capture on my behalf.
    '-------------------------------------------------------------------------
    If bCapture Then
        SetCapture UserControl.hwnd
    Else
        ReleaseCapture
    End If
End Sub

Private Sub PositionChanged()
    '-------------------------------------------------------------------------
    'Purpose:   Calculate needed coordinates for painting the control
    '-------------------------------------------------------------------------
    On Error GoTo PositionChangedError
    With mudtButtonRect
        .Bottom = UserControl.ScaleHeight
        .Right = UserControl.ScaleWidth
    End With
    If Not m_picPictured Is Nothing Then
        With mudtPicturePoint
            .x = CLng(UserControl.ScaleX(m_picPictured.Width, vbHimetric, vbPixels))
            .y = CLng(UserControl.ScaleY(m_picPictured.Height, vbHimetric, vbPixels))
        End With
        
        With mudtPictureRect
            .Left = CLng((mudtButtonRect.Right - mudtPicturePoint.x) / 2)
            .Top = CLng((mudtButtonRect.Bottom - mudtPicturePoint.y) / 2)
            .Right = .Left + mudtPicturePoint.x
            .Bottom = .Top + mudtPicturePoint.y
        End With
    End If
    Exit Sub
PositionChangedError:
    Exit Sub
End Sub

Private Sub DrawButtonState(iState As Integer)
    '-------------------------------------------------------------------------
    'Purpose:   Draw the button in whatever state it needs to be in
    '-------------------------------------------------------------------------
    Dim lhbmMemory As Long
    Dim lhbmMemoryOld As Long
    Dim lhdcMem As Long 'HDC
    Dim lBackColor As Long
    Dim udtPictureRect As RECT
    Dim bUseMask As Boolean
    Dim lhPal As Long
    Dim lhPalOld As Long
    Dim lhbrBack As Long
    Dim bHaveAmbientPalette As Boolean
    
    On Error GoTo DrawButtonState_Error
    If mbPropertiesLoaded Then
        miCurrentState = iState
        udtPictureRect = mudtPictureRect
        On Error Resume Next
        'Error will occur if the Ambient.Palette is not supported
        bHaveAmbientPalette = (Not UserControl.Ambient.Palette Is Nothing)
        If Err.Number <> 0 Then bHaveAmbientPalette = False
        Err.Clear
        If bHaveAmbientPalette Then
            'If the Palette or hPal property fails
            'resume next and use the halftone palette
            lhPal = UserControl.Ambient.Palette.hPal
            If lhPal = 0 Then lhPal = mlhHalftonePal
            Err.Clear
        Else
            lhPal = mlhHalftonePal    'If there is no specified palette
                                      'use the halftone palette.
        End If
        On Error GoTo DrawButtonState_Error
        'If button is sunken offset the picture coordinates
        'so that the picture looks like it is in sunken
        'perspective
        If iState = giSUNKEN Then
            With udtPictureRect
                .Right = .Right + glSUNKEN_OFFSET
                .Left = .Left + glSUNKEN_OFFSET
                .Top = .Top + glSUNKEN_OFFSET
                .Bottom = .Bottom + glSUNKEN_OFFSET
            End With
        End If
        
        'Create memory DC and bitmap to do all of the painting work
        lhdcMem = CreateCompatibleDC(UserControl.hDC)
        lhbmMemory = CreateCompatibleBitmap(UserControl.hDC, mudtButtonRect.Right, mudtButtonRect.Bottom)
        lhbmMemoryOld = SelectObject(lhdcMem, lhbmMemory)
        lhPalOld = SelectPalette(lhdcMem, lhPal, True)
        RealizePalette lhdcMem
        
        'fill the memory DC with the background color of the screen dc
        OleTranslateColor UserControl.BackColor, 0, lBackColor
        SetBkColor lhdcMem, lBackColor
        lhbrBack = CreateSolidBrush(lBackColor)
        FillRect lhdcMem, mudtButtonRect, lhbrBack
        If Not m_picPictured Is Nothing Then
            If m_picPictured.Type = vbPicTypeBitmap Then
                If m_bUseMaskColor Then bUseMask = True
            End If
            If Not m_bEnabled Then
                'If button is disabled draw disabled picture on memory dc
                moDrawTool.DrawDisabledPicture lhdcMem, m_picPictured, udtPictureRect.Left, udtPictureRect.Top, mudtPicturePoint.x, mudtPicturePoint.y, lBackColor, bUseMask, m_clrMaskColor, lhPal
            ElseIf bUseMask Then
                'if using mask color draw transparent bitmap on memory dc
                moDrawTool.DrawTransparentBitmap lhdcMem, m_picPictured, udtPictureRect.Left, udtPictureRect.Top, mudtPicturePoint.x, mudtPicturePoint.y, m_clrMaskColor, lhPal
            Else
                'otherwise draw picture with no effects on button
                If m_picPictured.Type = vbPicTypeBitmap Then
                    moDrawTool.DrawBitmapToHDC lhdcMem, m_picPictured, udtPictureRect.Left, udtPictureRect.Top, mudtPicturePoint.x, mudtPicturePoint.y, lhPal
                ElseIf m_picPictured.Type = vbPicTypeIcon Then
                    DrawIcon lhdcMem, udtPictureRect.Left, udtPictureRect.Top, m_picPictured.Handle
                End If
            End If
        End If
        
DrawButtonState_DrawFrame:
        'Draw Frame Needed
        Select Case iState
            Case giFLATTENED, giDISABLED
                If Not UserControl.Ambient.UserMode Then
                    DrawEdge lhdcMem, mudtButtonRect, BDR_RAISEDOUTER, BF_RECT Or BF_SOFT
                End If
            Case giRAISED
                DrawEdge lhdcMem, mudtButtonRect, BDR_RAISEDOUTER, BF_RECT Or BF_SOFT
            Case giSUNKEN
                DrawEdge lhdcMem, mudtButtonRect, BDR_SUNKENOUTER, BF_RECT Or BF_SOFT
        End Select
        'Copy the destination to the screen
        BitBlt UserControl.hDC, 0, 0, mudtButtonRect.Right, mudtButtonRect.Bottom, lhdcMem, 0, 0, vbSrcCopy
DrawButtonStateCleanUp:
        DeleteObject lhbrBack
        SelectPalette lhdcMem, lhPalOld, True
        RealizePalette (lhdcMem)
        DeleteObject SelectObject(lhdcMem, lhbmMemoryOld)
        DeleteDC lhdcMem
    End If
    Exit Sub
DrawButtonState_Error:
    Select Case Err.Number
        Case giOBJECT_VARIABLE_NOT_SET
            Resume DrawButtonState_DrawFrame
        Case giINVALID_PICTURE
            Resume DrawButtonState_DrawFrame
        Case Else
            Resume DrawButtonStateCleanUp
    End Select
End Sub

'*************************
'Friend Methods
'*************************
Friend Function WindowProc(ByVal hwnd As Long, ByVal uMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    '-------------------------------------------------------------------------
    'Purpose:   Handles window messages specific to subclassed window associated
    '           with this object.  Is called by SubWndProc in standard module.
    '           Relays all mouse messages to ToolTip window, and returns a value
    '           for ToolTip NeedText message.
    '-------------------------------------------------------------------------
    Dim msgStruct As MSG
    Dim hdr As NMHDR
    Dim ttt As ToolTipText
    On Error GoTo WindowProc_Error
    Select Case uMsg
        Case WM_MOUSEMOVE, WM_LBUTTONDOWN, WM_LBUTTONUP, WM_RBUTTONDOWN, WM_RBUTTONUP, WM_MBUTTONDOWN, WM_MBUTTONUP
            With msgStruct
                .lParam = lParam
                .wParam = wParam
                .message = uMsg
                .hwnd = hwnd
            End With
            SendMessage gHWndToolTip, TTM_RELAYEVENT, 0, msgStruct
        Case WM_NOTIFY
            CopyMemory hdr, ByVal lParam, Len(hdr)
            If hdr.code = TTN_NEEDTEXT And hdr.hwndFrom = gHWndToolTip Then
                'Get the tooltip text from the UserControl class object
                'If the host for this control provides a ToolTipText property
                'on the extender object (as in VB5).  The ToolTipText property
                'declares will not be hit.  Therefore, the user's ToolTipText
                'may be found either in the Extender.ToolTipText property or
                'in my own member variable m_sToolTipText
                'Error may occur if ToolTipText property is not available
                On Error Resume Next
                If mbToolTipNotInExtender Then
                    msToolTipBuffer = StrConv(m_sToolTipText, vbFromUnicode)
                Else
                    msToolTipBuffer = StrConv(UserControl.Extender.ToolTipText, vbFromUnicode)
                End If
                If Err.Number = 0 Then
                    CopyMemory ttt, ByVal lParam, Len(ttt)
                    ttt.lpszText = StrPtr(msToolTipBuffer)
                    CopyMemory ByVal lParam, ttt, Len(ttt)
                End If
            End If
        Case WM_CANCELMODE
            'A window has been put over this one
            'flatten the button
            Flatten
            mbGotFocus = False
            mbLeftMouseDown = False
            mbLeftWasDown = False
            mbMouseDownFired = False
    End Select
WindowProc_Resume:
    WindowProc = CallWindowProc(mWndProcNext, hwnd, uMsg, wParam, ByVal lParam)
    Exit Function
WindowProc_Error:
    Resume WindowProc_Resume
End Function


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ServerFRM
	Inherits CodeArchitects.VB6Library.VB6Form

#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
	EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Windows Form Designer generated code "

	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Create all controls and control arrays.
		InitializeComponents()
	End Sub

	' This method wraps the call to InitializeComponent, but can be called from base class.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
		Me.ObjectIsInitializing = True
		InitializeComponent()
		' Initialize control arrays.
		Me.destroyerTXT = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(destroyerTXT_002, destroyerTXT_001)
		Me.submarineTXT = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(submarineTXT_002, submarineTXT_001)
		Me.cruiserTXT = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(cruiserTXT_003, cruiserTXT_002, cruiserTXT_001)
		Me.battleshipTXT = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(battleshipTXT_004, battleshipTXT_003, battleshipTXT_002, battleshipTXT_001)
		Me.carrierTXT = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(carrierTXT_005, carrierTXT_004, carrierTXT_003, carrierTXT_002, carrierTXT_001)
		Me.Field = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)(Field_240, Field_239, Field_238, Field_237, Field_236, Field_235, Field_234, Field_233, Field_232, Field_231, Field_230, Field_229, Field_228, Field_227, Field_226, Field_225, Field_224, Field_223, Field_222, Field_221, Field_220, Field_219, Field_218, Field_217, Field_216, Field_215, Field_214, Field_213, Field_212, Field_211, Field_210, Field_209, Field_208, Field_207, Field_206, Field_205, Field_204, Field_203, Field_202, Field_201, Field_200, Field_199, Field_198, Field_197, Field_196, Field_195, Field_194, Field_193, Field_192, Field_191, Field_190, Field_189, Field_188, Field_187, Field_186, Field_185, Field_184, Field_183, Field_182, Field_181, Field_180, Field_179, Field_178, Field_177, Field_176, Field_175, Field_174, Field_173, Field_172, Field_171, Field_170, Field_169, Field_168, Field_167, Field_166, Field_165, Field_164, Field_163, Field_162, Field_161, Field_160, Field_159, Field_158, Field_157, Field_156, Field_155, Field_154, Field_153, Field_152, Field_151, Field_150, Field_149, Field_148, Field_147, Field_146, Field_145, Field_144, Field_143, Field_142, Field_141, Field_140, Field_139, Field_138, Field_137, Field_136, Field_135, Field_134, Field_133, Field_132, Field_131, Field_130, Field_129, Field_128, Field_127, Field_126, Field_125, Field_124, Field_123, Field_122, Field_121, Field_120, Field_119, Field_118, Field_117, Field_116, Field_115, Field_114, Field_113, Field_112, Field_111, Field_110, Field_109, Field_108, Field_107, Field_106, Field_105, Field_104, Field_103, Field_102, Field_101, Field_100, Field_099, Field_098, Field_097, Field_096, Field_095, Field_094, Field_093, Field_092, Field_091, Field_090, Field_089, Field_088, Field_087, Field_086, Field_085, Field_084, Field_083, Field_082, Field_081, Field_080, Field_079, Field_078, Field_077, Field_076, Field_075, Field_074, Field_073, Field_072, Field_071, Field_070, Field_069, Field_068, Field_067, Field_066, Field_065, Field_064, Field_063, Field_062, Field_061, Field_060, Field_059, Field_058, Field_057, Field_056, Field_055, Field_054, Field_053, Field_052, Field_051, Field_050, Field_049, Field_048, Field_047, Field_046, Field_045, Field_044, Field_043, Field_042, Field_041, Field_040, Field_039, Field_038, Field_037, Field_036, Field_035, Field_034, Field_033, Field_032, Field_031, Field_030, Field_029, Field_028, Field_027, Field_026, Field_025, Field_024, Field_023, Field_022, Field_021, Field_020, Field_019, Field_018, Field_017, Field_016, Field_015, Field_014, Field_013, Field_012, Field_011, Field_010, Field_009, Field_008, Field_007, Field_006, Field_005, Field_004, Field_003, Field_002, Field_001)
		Me.labelBgLNE = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)(labelBgLNE_019, labelBgLNE_018, labelBgLNE_017, labelBgLNE_016, labelBgLNE_015, labelBgLNE_014, labelBgLNE_013, labelBgLNE_012, labelBgLNE_011, labelBgLNE_010, labelBgLNE_009, labelBgLNE_008, labelBgLNE_007, labelBgLNE_006, labelBgLNE_005, labelBgLNE_004, labelBgLNE_003, labelBgLNE_002, labelBgLNE_001, labelBgLNE_000)
		Me.MYcarrierLBL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(MYcarrierLBL_001, MYcarrierLBL_002, MYcarrierLBL_003, MYcarrierLBL_004, MYcarrierLBL_005)
		Me.MYbattleshipLBL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(MYbattleshipLBL_001, MYbattleshipLBL_002, MYbattleshipLBL_003, MYbattleshipLBL_004)
		Me.MYcruiserLBL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(MYcruiserLBL_003, MYcruiserLBL_002, MYcruiserLBL_001)
		Me.MYsubmarineLBL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(MYsubmarineLBL_001, MYsubmarineLBL_002)
		Me.MYdestroyerLBL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(MYdestroyerLBL_001, MYdestroyerLBL_002)
		Me.ObjectIsInitializing = False
	End Sub

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing Then
				If components IsNot Nothing Then components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public destroyerTXT As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public submarineTXT As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public cruiserTXT As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public battleshipTXT As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public carrierTXT As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public Field As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)
	Public labelBgLNE As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)
	Public MYcarrierLBL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public MYbattleshipLBL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public MYcruiserLBL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public MYsubmarineLBL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public MYdestroyerLBL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Label24 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label23 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label22 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label21 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label19 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label18 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label17 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label16 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents nopicturePIC As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents startgameTMR As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents destroyerTXT_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents destroyerTXT_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents submarineTXT_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents submarineTXT_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cruiserTXT_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cruiserTXT_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cruiserTXT_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents battleshipTXT_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents battleshipTXT_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents battleshipTXT_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents battleshipTXT_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents carrierTXT_005 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents carrierTXT_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents carrierTXT_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents carrierTXT_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents carrierTXT_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents hitPIC As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Winsock As CodeArchitects.VB6Library.VB6Winsock
	Public WithEvents sendTXT As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents sendtextCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Field_240 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_239 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_238 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_237 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_236 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_235 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_234 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_233 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_232 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_231 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_230 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_229 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_228 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_227 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_226 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_225 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_224 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_223 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_222 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_221 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_220 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_219 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_218 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_217 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_216 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_215 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_214 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_213 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_212 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_211 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_210 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_209 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_208 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_207 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_206 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_205 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_204 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_203 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_202 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_201 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_200 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_199 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_198 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_197 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_196 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_195 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_194 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_193 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_192 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_191 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_190 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_189 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_188 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_187 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_186 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_185 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_184 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_183 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_182 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_181 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_180 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_179 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_178 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_177 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_176 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_175 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_174 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_173 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_172 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_171 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_170 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_169 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_168 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_167 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_166 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_165 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_164 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_163 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_162 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_161 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_160 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_159 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_158 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_157 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_156 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_155 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_154 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_153 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_152 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_151 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_150 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_149 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_148 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_147 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_146 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_145 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_144 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_143 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_142 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_141 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_140 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_139 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_138 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_137 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_136 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_135 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_134 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_133 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_132 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_131 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_130 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_129 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_128 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_127 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_126 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_125 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_124 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_123 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_122 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_121 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_120 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_119 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_118 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_117 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_116 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_115 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_114 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_113 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_112 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_111 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_110 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_109 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_108 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_107 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_106 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_105 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_104 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_103 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_102 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_101 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_100 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_099 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_098 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_097 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_096 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_095 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_094 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_093 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_092 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_091 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_090 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_089 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_088 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_087 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_086 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_085 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_084 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_083 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_082 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_081 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_080 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_079 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_078 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_077 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_076 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_075 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_074 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_073 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_072 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_071 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_070 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_069 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_068 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_067 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_066 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_065 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_064 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_063 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_062 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_061 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_060 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_059 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_058 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_057 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_056 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_055 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_054 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_053 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_052 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_051 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_050 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_049 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_048 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_047 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_046 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_045 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_044 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_043 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_042 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_041 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_040 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_039 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_038 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_037 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_036 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_035 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_034 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_033 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_032 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_031 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_030 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_029 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_028 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_027 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_026 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_025 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_024 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_023 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_022 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_021 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_020 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_019 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_018 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_017 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_016 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_015 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_014 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_013 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_012 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_011 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_010 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_009 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_008 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_007 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_006 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_005 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_004 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_003 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_002 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Field_001 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents statsFRA As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents GameStatsLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MainTXT As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents nickSERVER As CodeArchitects.VB6Library.VB6Label
	Public WithEvents nickCLIENT As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line31 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line30 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line29 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line28 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line27 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line26 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line25 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line24 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line23 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line22 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line21 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line20 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line19 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line18 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line17 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line16 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line15 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line14 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line13 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line12 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line10 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line8 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line5 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line11 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line9 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line7 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line6 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line4 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line3 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line2 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line1 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Label30 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label29 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label28 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label27 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label26 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents labelBgLNE_019 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_018 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_017 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_016 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_015 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_014 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_013 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_012 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_011 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_010 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_009 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_008 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_007 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_006 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_005 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_004 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_003 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_002 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_001 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents labelBgLNE_000 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Label15 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label14 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label20 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcarrierLBL_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcarrierLBL_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcarrierLBL_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcarrierLBL_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcarrierLBL_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYbattleshipLBL_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYbattleshipLBL_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYbattleshipLBL_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYbattleshipLBL_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcruiserLBL_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcruiserLBL_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYcruiserLBL_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYsubmarineLBL_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYsubmarineLBL_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYdestroyerLBL_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MYdestroyerLBL_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents DestroyerLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents SubMarineLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents CruiserLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents battleshipLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents CarrierLBL As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ServerFRM))
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Label24 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label23 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label22 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label21 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label19 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label18 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label17 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label16 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.nopicturePIC = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.startgameTMR = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.destroyerTXT_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.destroyerTXT_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.submarineTXT_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.submarineTXT_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cruiserTXT_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cruiserTXT_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cruiserTXT_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.battleshipTXT_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.battleshipTXT_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.battleshipTXT_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.battleshipTXT_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.carrierTXT_005 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.carrierTXT_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.carrierTXT_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.carrierTXT_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.carrierTXT_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.hitPIC = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Winsock = New CodeArchitects.VB6Library.VB6Winsock()
		Me.sendTXT = New CodeArchitects.VB6Library.VB6TextBox()
		Me.sendtextCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Field_240 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_239 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_238 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_237 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_236 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_235 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_234 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_233 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_232 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_231 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_230 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_229 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_228 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_227 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_226 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_225 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_224 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_223 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_222 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_221 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_220 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_219 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_218 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_217 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_216 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_215 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_214 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_213 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_212 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_211 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_210 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_209 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_208 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_207 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_206 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_205 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_204 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_203 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_202 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_201 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_200 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_199 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_198 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_197 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_196 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_195 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_194 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_193 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_192 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_191 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_190 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_189 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_188 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_187 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_186 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_185 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_184 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_183 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_182 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_181 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_180 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_179 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_178 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_177 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_176 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_175 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_174 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_173 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_172 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_171 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_170 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_169 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_168 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_167 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_166 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_165 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_164 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_163 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_162 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_161 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_160 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_159 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_158 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_157 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_156 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_155 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_154 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_153 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_152 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_151 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_150 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_149 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_148 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_147 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_146 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_145 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_144 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_143 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_142 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_141 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_140 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_139 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_138 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_137 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_136 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_135 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_134 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_133 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_132 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_131 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_130 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_129 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_128 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_127 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_126 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_125 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_124 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_123 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_122 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_121 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_120 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_119 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_118 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_117 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_116 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_115 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_114 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_113 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_112 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_111 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_110 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_109 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_108 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_107 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_106 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_105 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_104 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_103 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_102 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_101 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_100 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_099 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_098 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_097 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_096 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_095 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_094 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_093 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_092 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_091 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_090 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_089 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_088 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_087 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_086 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_085 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_084 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_083 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_082 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_081 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_080 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_079 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_078 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_077 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_076 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_075 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_074 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_073 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_072 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_071 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_070 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_069 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_068 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_067 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_066 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_065 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_064 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_063 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_062 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_061 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_060 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_059 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_058 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_057 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_056 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_055 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_054 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_053 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_052 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_051 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_050 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_049 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_048 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_047 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_046 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_045 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_044 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_043 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_042 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_041 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_040 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_039 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_038 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_037 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_036 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_035 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_034 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_033 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_032 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_031 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_030 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_029 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_028 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_027 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_026 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_025 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_024 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_023 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_022 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_021 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_020 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_019 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_018 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_017 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_016 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_015 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_014 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_013 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_012 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_011 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_010 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_009 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_008 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_007 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_006 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_005 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_004 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_003 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_002 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Field_001 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.statsFRA = New CodeArchitects.VB6Library.VB6Frame()
		Me.GameStatsLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.MainTXT = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.nickSERVER = New CodeArchitects.VB6Library.VB6Label()
		Me.nickCLIENT = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Line31 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line30 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line29 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line28 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line27 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line26 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line25 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line24 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line23 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line22 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line21 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line20 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line19 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line18 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line17 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line16 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line15 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line14 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line13 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line12 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line10 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line8 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line5 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line11 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line9 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line7 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line6 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line4 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line3 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line2 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line1 = New CodeArchitects.VB6Library.VB6Line()
		Me.Label30 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label29 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label28 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label27 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label26 = New CodeArchitects.VB6Library.VB6Label()
		Me.labelBgLNE_019 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_018 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_017 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_016 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_015 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_014 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_013 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_012 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_011 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_010 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_009 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_008 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_007 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_006 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_005 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_004 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_003 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_002 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_001 = New CodeArchitects.VB6Library.VB6Line()
		Me.labelBgLNE_000 = New CodeArchitects.VB6Library.VB6Line()
		Me.Label15 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label14 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label20 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcarrierLBL_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcarrierLBL_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcarrierLBL_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcarrierLBL_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcarrierLBL_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYbattleshipLBL_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYbattleshipLBL_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYbattleshipLBL_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYbattleshipLBL_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcruiserLBL_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcruiserLBL_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYcruiserLBL_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYsubmarineLBL_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYsubmarineLBL_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYdestroyerLBL_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.MYdestroyerLBL_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.DestroyerLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.SubMarineLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.CruiserLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.battleshipLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.CarrierLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		Me.statsFRA.SuspendLayout()
		CType(Me.Line31, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line30, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line29, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line28, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line27, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line26, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line25, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line18, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_019, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_018, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_017, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_016, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_015, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_014, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_013, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_012, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_011, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_009, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.labelBgLNE_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(89, 105)
		Me.Frame1.Location = New System.Drawing.Point(424, 440)
		Me.Frame1.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Frame1.Caption = "Color Key-"
		Me.Frame1.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Frame1.TabIndex = 305
		'
		' Label24
		'
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(86, 13)
		Me.Label24.Location = New System.Drawing.Point(-8, 64)
		Me.Label24.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label24.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label24.Caption = "  Water ="
		Me.Label24.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label24.TabIndex = 315
		Me.Label24.AutoSize = False
		Me.Label24.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label23
		'
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(17, 17)
		Me.Label23.Location = New System.Drawing.Point(64, 64)
		Me.Label23.BackColor = FromOleColor6(CInt(&H00800000))
		Me.Label23.TabIndex = 314
		Me.Label23.AutoSize = False
		'
		' Label22
		'
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(84, 13)
		Me.Label22.Location = New System.Drawing.Point(0, 48)
		Me.Label22.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label22.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label22.Caption = "Ship ="
		Me.Label22.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label22.TabIndex = 313
		Me.Label22.AutoSize = False
		Me.Label22.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label21
		'
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(17, 17)
		Me.Label21.Location = New System.Drawing.Point(64, 48)
		Me.Label21.BackColor = FromOleColor6(CInt(&H00808080))
		Me.Label21.TabIndex = 312
		Me.Label21.AutoSize = False
		'
		' Label19
		'
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(86, 13)
		Me.Label19.Location = New System.Drawing.Point(0, 16)
		Me.Label19.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label19.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label19.Caption = " Hit ="
		Me.Label19.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label19.TabIndex = 311
		Me.Label19.AutoSize = False
		Me.Label19.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label18
		'
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(17, 17)
		Me.Label18.Location = New System.Drawing.Point(64, 16)
		Me.Label18.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.Label18.TabIndex = 310
		Me.Label18.AutoSize = False
		'
		' Label17
		'
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(85, 13)
		Me.Label17.Location = New System.Drawing.Point(-8, 80)
		Me.Label17.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label17.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label17.Caption = "Waiting ="
		Me.Label17.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label17.TabIndex = 309
		Me.Label17.AutoSize = False
		Me.Label17.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label16
		'
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(17, 17)
		Me.Label16.Location = New System.Drawing.Point(64, 80)
		Me.Label16.BackColor = FromOleColor6(CInt(&H0000FFFF))
		Me.Label16.TabIndex = 308
		Me.Label16.AutoSize = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(89, 13)
		Me.Label3.Location = New System.Drawing.Point(-8, 32)
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "   Miss ="
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label3.TabIndex = 307
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(17, 17)
		Me.Label2.Location = New System.Drawing.Point(64, 32)
		Me.Label2.BackColor = FromOleColor6(CInt(&H0000FF00))
		Me.Label2.TabIndex = 306
		Me.Label2.AutoSize = False
		'
		' nopicturePIC
		'
		Me.nopicturePIC.Name = "nopicturePIC"
		Me.nopicturePIC.Size = New System.Drawing.Size(25, 25)
		Me.nopicturePIC.Location = New System.Drawing.Point(24, 0)
		Me.nopicturePIC.TabIndex = 304
		Me.nopicturePIC.Visible = False
		Me.nopicturePIC.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.nopicturePIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.nopicturePIC.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.nopicturePIC.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' startgameTMR
		'
		Me.startgameTMR.Name = "startgameTMR"
		Me.startgameTMR.ParentForm = Me
		Me.startgameTMR.Name6 = "startgameTMR"
		Me.startgameTMR.Interval = 1000
		'
		' destroyerTXT_002
		'
		Me.destroyerTXT_002.Name = "destroyerTXT_002"
		Me.destroyerTXT_002.Size = New System.Drawing.Size(10, 13)
		Me.destroyerTXT_002.Location = New System.Drawing.Point(352, 512)
		Me.destroyerTXT_002.TabIndex = 303
		Me.destroyerTXT_002.Visible = False
		'
		' destroyerTXT_001
		'
		Me.destroyerTXT_001.Name = "destroyerTXT_001"
		Me.destroyerTXT_001.Size = New System.Drawing.Size(10, 13)
		Me.destroyerTXT_001.Location = New System.Drawing.Point(312, 512)
		Me.destroyerTXT_001.TabIndex = 302
		Me.destroyerTXT_001.Visible = False
		'
		' submarineTXT_002
		'
		Me.submarineTXT_002.Name = "submarineTXT_002"
		Me.submarineTXT_002.Size = New System.Drawing.Size(10, 13)
		Me.submarineTXT_002.Location = New System.Drawing.Point(360, 480)
		Me.submarineTXT_002.TabIndex = 301
		Me.submarineTXT_002.Visible = False
		'
		' submarineTXT_001
		'
		Me.submarineTXT_001.Name = "submarineTXT_001"
		Me.submarineTXT_001.Size = New System.Drawing.Size(10, 13)
		Me.submarineTXT_001.Location = New System.Drawing.Point(320, 480)
		Me.submarineTXT_001.TabIndex = 300
		Me.submarineTXT_001.Visible = False
		'
		' cruiserTXT_003
		'
		Me.cruiserTXT_003.Name = "cruiserTXT_003"
		Me.cruiserTXT_003.Size = New System.Drawing.Size(10, 13)
		Me.cruiserTXT_003.Location = New System.Drawing.Point(376, 448)
		Me.cruiserTXT_003.TabIndex = 299
		Me.cruiserTXT_003.Visible = False
		'
		' cruiserTXT_002
		'
		Me.cruiserTXT_002.Name = "cruiserTXT_002"
		Me.cruiserTXT_002.Size = New System.Drawing.Size(10, 13)
		Me.cruiserTXT_002.Location = New System.Drawing.Point(336, 448)
		Me.cruiserTXT_002.TabIndex = 298
		Me.cruiserTXT_002.Visible = False
		'
		' cruiserTXT_001
		'
		Me.cruiserTXT_001.Name = "cruiserTXT_001"
		Me.cruiserTXT_001.Size = New System.Drawing.Size(10, 13)
		Me.cruiserTXT_001.Location = New System.Drawing.Point(296, 448)
		Me.cruiserTXT_001.TabIndex = 297
		Me.cruiserTXT_001.Visible = False
		'
		' battleshipTXT_004
		'
		Me.battleshipTXT_004.Name = "battleshipTXT_004"
		Me.battleshipTXT_004.Size = New System.Drawing.Size(10, 13)
		Me.battleshipTXT_004.Location = New System.Drawing.Point(432, 416)
		Me.battleshipTXT_004.TabIndex = 296
		Me.battleshipTXT_004.Visible = False
		'
		' battleshipTXT_003
		'
		Me.battleshipTXT_003.Name = "battleshipTXT_003"
		Me.battleshipTXT_003.Size = New System.Drawing.Size(10, 13)
		Me.battleshipTXT_003.Location = New System.Drawing.Point(392, 416)
		Me.battleshipTXT_003.TabIndex = 295
		Me.battleshipTXT_003.Visible = False
		'
		' battleshipTXT_002
		'
		Me.battleshipTXT_002.Name = "battleshipTXT_002"
		Me.battleshipTXT_002.Size = New System.Drawing.Size(10, 13)
		Me.battleshipTXT_002.Location = New System.Drawing.Point(352, 416)
		Me.battleshipTXT_002.TabIndex = 294
		Me.battleshipTXT_002.Visible = False
		'
		' battleshipTXT_001
		'
		Me.battleshipTXT_001.Name = "battleshipTXT_001"
		Me.battleshipTXT_001.Size = New System.Drawing.Size(10, 13)
		Me.battleshipTXT_001.Location = New System.Drawing.Point(312, 416)
		Me.battleshipTXT_001.TabIndex = 293
		Me.battleshipTXT_001.Visible = False
		'
		' carrierTXT_005
		'
		Me.carrierTXT_005.Name = "carrierTXT_005"
		Me.carrierTXT_005.Size = New System.Drawing.Size(10, 13)
		Me.carrierTXT_005.Location = New System.Drawing.Point(456, 384)
		Me.carrierTXT_005.TabIndex = 292
		Me.carrierTXT_005.Visible = False
		'
		' carrierTXT_004
		'
		Me.carrierTXT_004.Name = "carrierTXT_004"
		Me.carrierTXT_004.Size = New System.Drawing.Size(10, 13)
		Me.carrierTXT_004.Location = New System.Drawing.Point(416, 384)
		Me.carrierTXT_004.TabIndex = 291
		Me.carrierTXT_004.Visible = False
		'
		' carrierTXT_003
		'
		Me.carrierTXT_003.Name = "carrierTXT_003"
		Me.carrierTXT_003.Size = New System.Drawing.Size(10, 13)
		Me.carrierTXT_003.Location = New System.Drawing.Point(384, 384)
		Me.carrierTXT_003.TabIndex = 290
		Me.carrierTXT_003.Visible = False
		'
		' carrierTXT_002
		'
		Me.carrierTXT_002.Name = "carrierTXT_002"
		Me.carrierTXT_002.Size = New System.Drawing.Size(10, 13)
		Me.carrierTXT_002.Location = New System.Drawing.Point(336, 384)
		Me.carrierTXT_002.TabIndex = 289
		Me.carrierTXT_002.Visible = False
		'
		' carrierTXT_001
		'
		Me.carrierTXT_001.Name = "carrierTXT_001"
		Me.carrierTXT_001.Size = New System.Drawing.Size(10, 13)
		Me.carrierTXT_001.Location = New System.Drawing.Point(296, 384)
		Me.carrierTXT_001.TabIndex = 288
		Me.carrierTXT_001.Visible = False
		'
		' hitPIC
		'
		Me.hitPIC.Name = "hitPIC"
		Me.hitPIC.Size = New System.Drawing.Size(27, 27)
		Me.hitPIC.Location = New System.Drawing.Point(0, 24)
		Me.hitPIC.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.hitPIC.AutoRedraw = True
		Me.hitPIC.AutoSize = True
		Me.hitPIC.BackColor = FromOleColor6(CInt(&H80000005))
		Me.hitPIC.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.hitPIC.Picture = CType(resources.GetObject("hitPIC.Picture"), System.Drawing.Image)
		Me.hitPIC.TabIndex = 287
		Me.hitPIC.Visible = False
		Me.hitPIC.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.hitPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.hitPIC.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Winsock
		'
		Me.Winsock.Name = "Winsock"
		Me.Winsock.ParentForm = Me
		Me.Winsock.Name6 = "Winsock"
		'
		' sendTXT
		'
		Me.sendTXT.Name = "sendTXT"
		Me.sendTXT.Size = New System.Drawing.Size(161, 19)
		Me.sendTXT.Location = New System.Drawing.Point(8, 520)
		Me.sendTXT.MaxLength = 100
		Me.sendTXT.TabIndex = 282
		'
		' sendtextCMD
		'
		Me.sendtextCMD.Name = "sendtextCMD"
		Me.sendtextCMD.Size = New System.Drawing.Size(49, 21)
		Me.sendtextCMD.Location = New System.Drawing.Point(176, 520)
		Me.sendtextCMD.Caption = "&Send"
		Me.sendtextCMD.TabIndex = 281
		Me.sendtextCMD.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.sendtextCMD
		Me.sendtextCMD.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Field_240
		'
		Me.Field_240.Name = "Field_240"
		Me.Field_240.Size = New System.Drawing.Size(25, 25)
		Me.Field_240.Location = New System.Drawing.Point(480, 296)
		Me.Field_240.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_240.AutoRedraw = True
		Me.Field_240.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_240.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_240.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_240.TabIndex = 280
		Me.Field_240.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_240.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_240.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_239
		'
		Me.Field_239.Name = "Field_239"
		Me.Field_239.Size = New System.Drawing.Size(25, 25)
		Me.Field_239.Location = New System.Drawing.Point(456, 296)
		Me.Field_239.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_239.AutoRedraw = True
		Me.Field_239.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_239.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_239.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_239.TabIndex = 279
		Me.Field_239.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_239.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_239.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_238
		'
		Me.Field_238.Name = "Field_238"
		Me.Field_238.Size = New System.Drawing.Size(25, 25)
		Me.Field_238.Location = New System.Drawing.Point(432, 296)
		Me.Field_238.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_238.AutoRedraw = True
		Me.Field_238.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_238.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_238.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_238.TabIndex = 278
		Me.Field_238.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_238.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_238.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_237
		'
		Me.Field_237.Name = "Field_237"
		Me.Field_237.Size = New System.Drawing.Size(25, 25)
		Me.Field_237.Location = New System.Drawing.Point(408, 296)
		Me.Field_237.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_237.AutoRedraw = True
		Me.Field_237.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_237.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_237.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_237.TabIndex = 277
		Me.Field_237.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_237.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_237.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_236
		'
		Me.Field_236.Name = "Field_236"
		Me.Field_236.Size = New System.Drawing.Size(25, 25)
		Me.Field_236.Location = New System.Drawing.Point(384, 296)
		Me.Field_236.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_236.AutoRedraw = True
		Me.Field_236.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_236.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_236.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_236.TabIndex = 276
		Me.Field_236.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_236.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_236.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_235
		'
		Me.Field_235.Name = "Field_235"
		Me.Field_235.Size = New System.Drawing.Size(25, 25)
		Me.Field_235.Location = New System.Drawing.Point(360, 296)
		Me.Field_235.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_235.AutoRedraw = True
		Me.Field_235.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_235.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_235.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_235.TabIndex = 275
		Me.Field_235.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_235.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_235.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_234
		'
		Me.Field_234.Name = "Field_234"
		Me.Field_234.Size = New System.Drawing.Size(25, 25)
		Me.Field_234.Location = New System.Drawing.Point(336, 296)
		Me.Field_234.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_234.AutoRedraw = True
		Me.Field_234.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_234.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_234.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_234.TabIndex = 274
		Me.Field_234.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_234.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_234.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_233
		'
		Me.Field_233.Name = "Field_233"
		Me.Field_233.Size = New System.Drawing.Size(25, 25)
		Me.Field_233.Location = New System.Drawing.Point(312, 296)
		Me.Field_233.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_233.AutoRedraw = True
		Me.Field_233.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_233.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_233.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_233.TabIndex = 273
		Me.Field_233.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_233.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_233.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_232
		'
		Me.Field_232.Name = "Field_232"
		Me.Field_232.Size = New System.Drawing.Size(25, 25)
		Me.Field_232.Location = New System.Drawing.Point(288, 296)
		Me.Field_232.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_232.AutoRedraw = True
		Me.Field_232.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_232.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_232.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_232.TabIndex = 272
		Me.Field_232.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_232.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_232.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_231
		'
		Me.Field_231.Name = "Field_231"
		Me.Field_231.Size = New System.Drawing.Size(25, 25)
		Me.Field_231.Location = New System.Drawing.Point(264, 296)
		Me.Field_231.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_231.AutoRedraw = True
		Me.Field_231.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_231.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_231.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_231.TabIndex = 271
		Me.Field_231.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_231.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_231.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_230
		'
		Me.Field_230.Name = "Field_230"
		Me.Field_230.Size = New System.Drawing.Size(25, 25)
		Me.Field_230.Location = New System.Drawing.Point(240, 296)
		Me.Field_230.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_230.AutoRedraw = True
		Me.Field_230.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_230.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_230.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_230.TabIndex = 270
		Me.Field_230.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_230.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_230.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_229
		'
		Me.Field_229.Name = "Field_229"
		Me.Field_229.Size = New System.Drawing.Size(25, 25)
		Me.Field_229.Location = New System.Drawing.Point(216, 296)
		Me.Field_229.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_229.AutoRedraw = True
		Me.Field_229.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_229.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_229.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_229.TabIndex = 269
		Me.Field_229.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_229.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_229.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_228
		'
		Me.Field_228.Name = "Field_228"
		Me.Field_228.Size = New System.Drawing.Size(25, 25)
		Me.Field_228.Location = New System.Drawing.Point(192, 296)
		Me.Field_228.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_228.AutoRedraw = True
		Me.Field_228.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_228.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_228.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_228.TabIndex = 268
		Me.Field_228.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_228.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_228.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_227
		'
		Me.Field_227.Name = "Field_227"
		Me.Field_227.Size = New System.Drawing.Size(25, 25)
		Me.Field_227.Location = New System.Drawing.Point(168, 296)
		Me.Field_227.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_227.AutoRedraw = True
		Me.Field_227.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_227.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_227.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_227.TabIndex = 267
		Me.Field_227.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_227.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_227.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_226
		'
		Me.Field_226.Name = "Field_226"
		Me.Field_226.Size = New System.Drawing.Size(25, 25)
		Me.Field_226.Location = New System.Drawing.Point(144, 296)
		Me.Field_226.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_226.AutoRedraw = True
		Me.Field_226.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_226.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_226.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_226.TabIndex = 266
		Me.Field_226.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_226.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_226.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_225
		'
		Me.Field_225.Name = "Field_225"
		Me.Field_225.Size = New System.Drawing.Size(25, 25)
		Me.Field_225.Location = New System.Drawing.Point(120, 296)
		Me.Field_225.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_225.AutoRedraw = True
		Me.Field_225.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_225.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_225.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_225.TabIndex = 265
		Me.Field_225.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_225.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_225.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_224
		'
		Me.Field_224.Name = "Field_224"
		Me.Field_224.Size = New System.Drawing.Size(25, 25)
		Me.Field_224.Location = New System.Drawing.Point(96, 296)
		Me.Field_224.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_224.AutoRedraw = True
		Me.Field_224.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_224.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_224.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_224.TabIndex = 264
		Me.Field_224.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_224.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_224.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_223
		'
		Me.Field_223.Name = "Field_223"
		Me.Field_223.Size = New System.Drawing.Size(25, 25)
		Me.Field_223.Location = New System.Drawing.Point(72, 296)
		Me.Field_223.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_223.AutoRedraw = True
		Me.Field_223.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_223.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_223.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_223.TabIndex = 263
		Me.Field_223.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_223.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_223.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_222
		'
		Me.Field_222.Name = "Field_222"
		Me.Field_222.Size = New System.Drawing.Size(25, 25)
		Me.Field_222.Location = New System.Drawing.Point(48, 296)
		Me.Field_222.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_222.AutoRedraw = True
		Me.Field_222.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_222.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_222.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_222.TabIndex = 262
		Me.Field_222.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_222.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_222.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_221
		'
		Me.Field_221.Name = "Field_221"
		Me.Field_221.Size = New System.Drawing.Size(25, 25)
		Me.Field_221.Location = New System.Drawing.Point(24, 296)
		Me.Field_221.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_221.AutoRedraw = True
		Me.Field_221.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_221.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_221.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_221.TabIndex = 261
		Me.Field_221.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_221.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_221.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_220
		'
		Me.Field_220.Name = "Field_220"
		Me.Field_220.Size = New System.Drawing.Size(25, 25)
		Me.Field_220.Location = New System.Drawing.Point(480, 272)
		Me.Field_220.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_220.AutoRedraw = True
		Me.Field_220.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_220.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_220.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_220.TabIndex = 260
		Me.Field_220.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_220.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_220.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_219
		'
		Me.Field_219.Name = "Field_219"
		Me.Field_219.Size = New System.Drawing.Size(25, 25)
		Me.Field_219.Location = New System.Drawing.Point(456, 272)
		Me.Field_219.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_219.AutoRedraw = True
		Me.Field_219.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_219.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_219.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_219.TabIndex = 259
		Me.Field_219.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_219.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_219.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_218
		'
		Me.Field_218.Name = "Field_218"
		Me.Field_218.Size = New System.Drawing.Size(25, 25)
		Me.Field_218.Location = New System.Drawing.Point(432, 272)
		Me.Field_218.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_218.AutoRedraw = True
		Me.Field_218.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_218.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_218.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_218.TabIndex = 258
		Me.Field_218.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_218.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_218.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_217
		'
		Me.Field_217.Name = "Field_217"
		Me.Field_217.Size = New System.Drawing.Size(25, 25)
		Me.Field_217.Location = New System.Drawing.Point(408, 272)
		Me.Field_217.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_217.AutoRedraw = True
		Me.Field_217.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_217.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_217.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_217.TabIndex = 257
		Me.Field_217.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_217.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_217.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_216
		'
		Me.Field_216.Name = "Field_216"
		Me.Field_216.Size = New System.Drawing.Size(25, 25)
		Me.Field_216.Location = New System.Drawing.Point(384, 272)
		Me.Field_216.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_216.AutoRedraw = True
		Me.Field_216.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_216.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_216.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_216.TabIndex = 256
		Me.Field_216.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_216.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_216.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_215
		'
		Me.Field_215.Name = "Field_215"
		Me.Field_215.Size = New System.Drawing.Size(25, 25)
		Me.Field_215.Location = New System.Drawing.Point(360, 272)
		Me.Field_215.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_215.AutoRedraw = True
		Me.Field_215.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_215.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_215.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_215.TabIndex = 255
		Me.Field_215.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_215.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_215.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_214
		'
		Me.Field_214.Name = "Field_214"
		Me.Field_214.Size = New System.Drawing.Size(25, 25)
		Me.Field_214.Location = New System.Drawing.Point(336, 272)
		Me.Field_214.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_214.AutoRedraw = True
		Me.Field_214.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_214.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_214.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_214.TabIndex = 254
		Me.Field_214.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_214.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_214.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_213
		'
		Me.Field_213.Name = "Field_213"
		Me.Field_213.Size = New System.Drawing.Size(25, 25)
		Me.Field_213.Location = New System.Drawing.Point(312, 272)
		Me.Field_213.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_213.AutoRedraw = True
		Me.Field_213.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_213.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_213.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_213.TabIndex = 253
		Me.Field_213.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_213.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_213.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_212
		'
		Me.Field_212.Name = "Field_212"
		Me.Field_212.Size = New System.Drawing.Size(25, 25)
		Me.Field_212.Location = New System.Drawing.Point(288, 272)
		Me.Field_212.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_212.AutoRedraw = True
		Me.Field_212.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_212.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_212.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_212.TabIndex = 252
		Me.Field_212.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_212.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_212.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_211
		'
		Me.Field_211.Name = "Field_211"
		Me.Field_211.Size = New System.Drawing.Size(25, 25)
		Me.Field_211.Location = New System.Drawing.Point(264, 272)
		Me.Field_211.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_211.AutoRedraw = True
		Me.Field_211.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_211.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_211.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_211.TabIndex = 251
		Me.Field_211.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_211.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_211.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_210
		'
		Me.Field_210.Name = "Field_210"
		Me.Field_210.Size = New System.Drawing.Size(25, 25)
		Me.Field_210.Location = New System.Drawing.Point(240, 272)
		Me.Field_210.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_210.AutoRedraw = True
		Me.Field_210.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_210.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_210.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_210.TabIndex = 250
		Me.Field_210.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_210.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_210.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_209
		'
		Me.Field_209.Name = "Field_209"
		Me.Field_209.Size = New System.Drawing.Size(25, 25)
		Me.Field_209.Location = New System.Drawing.Point(216, 272)
		Me.Field_209.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_209.AutoRedraw = True
		Me.Field_209.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_209.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_209.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_209.TabIndex = 249
		Me.Field_209.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_209.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_209.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_208
		'
		Me.Field_208.Name = "Field_208"
		Me.Field_208.Size = New System.Drawing.Size(25, 25)
		Me.Field_208.Location = New System.Drawing.Point(192, 272)
		Me.Field_208.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_208.AutoRedraw = True
		Me.Field_208.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_208.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_208.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_208.TabIndex = 248
		Me.Field_208.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_208.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_208.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_207
		'
		Me.Field_207.Name = "Field_207"
		Me.Field_207.Size = New System.Drawing.Size(25, 25)
		Me.Field_207.Location = New System.Drawing.Point(168, 272)
		Me.Field_207.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_207.AutoRedraw = True
		Me.Field_207.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_207.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_207.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_207.TabIndex = 247
		Me.Field_207.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_207.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_207.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_206
		'
		Me.Field_206.Name = "Field_206"
		Me.Field_206.Size = New System.Drawing.Size(25, 25)
		Me.Field_206.Location = New System.Drawing.Point(144, 272)
		Me.Field_206.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_206.AutoRedraw = True
		Me.Field_206.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_206.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_206.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_206.TabIndex = 246
		Me.Field_206.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_206.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_206.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_205
		'
		Me.Field_205.Name = "Field_205"
		Me.Field_205.Size = New System.Drawing.Size(25, 25)
		Me.Field_205.Location = New System.Drawing.Point(120, 272)
		Me.Field_205.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_205.AutoRedraw = True
		Me.Field_205.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_205.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_205.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_205.TabIndex = 245
		Me.Field_205.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_205.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_205.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_204
		'
		Me.Field_204.Name = "Field_204"
		Me.Field_204.Size = New System.Drawing.Size(25, 25)
		Me.Field_204.Location = New System.Drawing.Point(96, 272)
		Me.Field_204.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_204.AutoRedraw = True
		Me.Field_204.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_204.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_204.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_204.TabIndex = 244
		Me.Field_204.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_204.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_204.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_203
		'
		Me.Field_203.Name = "Field_203"
		Me.Field_203.Size = New System.Drawing.Size(25, 25)
		Me.Field_203.Location = New System.Drawing.Point(72, 272)
		Me.Field_203.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_203.AutoRedraw = True
		Me.Field_203.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_203.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_203.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_203.TabIndex = 243
		Me.Field_203.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_203.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_203.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_202
		'
		Me.Field_202.Name = "Field_202"
		Me.Field_202.Size = New System.Drawing.Size(25, 25)
		Me.Field_202.Location = New System.Drawing.Point(48, 272)
		Me.Field_202.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_202.AutoRedraw = True
		Me.Field_202.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_202.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_202.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_202.TabIndex = 242
		Me.Field_202.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_202.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_202.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_201
		'
		Me.Field_201.Name = "Field_201"
		Me.Field_201.Size = New System.Drawing.Size(25, 25)
		Me.Field_201.Location = New System.Drawing.Point(24, 272)
		Me.Field_201.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_201.AutoRedraw = True
		Me.Field_201.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_201.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_201.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_201.TabIndex = 241
		Me.Field_201.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_201.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_201.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_200
		'
		Me.Field_200.Name = "Field_200"
		Me.Field_200.Size = New System.Drawing.Size(25, 25)
		Me.Field_200.Location = New System.Drawing.Point(480, 248)
		Me.Field_200.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_200.AutoRedraw = True
		Me.Field_200.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_200.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_200.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_200.TabIndex = 240
		Me.Field_200.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_200.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_199
		'
		Me.Field_199.Name = "Field_199"
		Me.Field_199.Size = New System.Drawing.Size(25, 25)
		Me.Field_199.Location = New System.Drawing.Point(456, 248)
		Me.Field_199.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_199.AutoRedraw = True
		Me.Field_199.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_199.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_199.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_199.TabIndex = 239
		Me.Field_199.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_199.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_199.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_198
		'
		Me.Field_198.Name = "Field_198"
		Me.Field_198.Size = New System.Drawing.Size(25, 25)
		Me.Field_198.Location = New System.Drawing.Point(432, 248)
		Me.Field_198.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_198.AutoRedraw = True
		Me.Field_198.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_198.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_198.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_198.TabIndex = 238
		Me.Field_198.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_198.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_198.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_197
		'
		Me.Field_197.Name = "Field_197"
		Me.Field_197.Size = New System.Drawing.Size(25, 25)
		Me.Field_197.Location = New System.Drawing.Point(408, 248)
		Me.Field_197.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_197.AutoRedraw = True
		Me.Field_197.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_197.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_197.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_197.TabIndex = 237
		Me.Field_197.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_197.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_197.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_196
		'
		Me.Field_196.Name = "Field_196"
		Me.Field_196.Size = New System.Drawing.Size(25, 25)
		Me.Field_196.Location = New System.Drawing.Point(384, 248)
		Me.Field_196.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_196.AutoRedraw = True
		Me.Field_196.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_196.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_196.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_196.TabIndex = 236
		Me.Field_196.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_196.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_196.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_195
		'
		Me.Field_195.Name = "Field_195"
		Me.Field_195.Size = New System.Drawing.Size(25, 25)
		Me.Field_195.Location = New System.Drawing.Point(360, 248)
		Me.Field_195.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_195.AutoRedraw = True
		Me.Field_195.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_195.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_195.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_195.TabIndex = 235
		Me.Field_195.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_195.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_195.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_194
		'
		Me.Field_194.Name = "Field_194"
		Me.Field_194.Size = New System.Drawing.Size(25, 25)
		Me.Field_194.Location = New System.Drawing.Point(336, 248)
		Me.Field_194.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_194.AutoRedraw = True
		Me.Field_194.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_194.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_194.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_194.TabIndex = 234
		Me.Field_194.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_194.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_194.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_193
		'
		Me.Field_193.Name = "Field_193"
		Me.Field_193.Size = New System.Drawing.Size(25, 25)
		Me.Field_193.Location = New System.Drawing.Point(312, 248)
		Me.Field_193.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_193.AutoRedraw = True
		Me.Field_193.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_193.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_193.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_193.TabIndex = 233
		Me.Field_193.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_193.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_193.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_192
		'
		Me.Field_192.Name = "Field_192"
		Me.Field_192.Size = New System.Drawing.Size(25, 25)
		Me.Field_192.Location = New System.Drawing.Point(288, 248)
		Me.Field_192.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_192.AutoRedraw = True
		Me.Field_192.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_192.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_192.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_192.TabIndex = 232
		Me.Field_192.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_192.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_192.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_191
		'
		Me.Field_191.Name = "Field_191"
		Me.Field_191.Size = New System.Drawing.Size(25, 25)
		Me.Field_191.Location = New System.Drawing.Point(264, 248)
		Me.Field_191.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_191.AutoRedraw = True
		Me.Field_191.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_191.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_191.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_191.TabIndex = 231
		Me.Field_191.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_191.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_191.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_190
		'
		Me.Field_190.Name = "Field_190"
		Me.Field_190.Size = New System.Drawing.Size(25, 25)
		Me.Field_190.Location = New System.Drawing.Point(240, 248)
		Me.Field_190.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_190.AutoRedraw = True
		Me.Field_190.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_190.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_190.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_190.TabIndex = 230
		Me.Field_190.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_190.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_190.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_189
		'
		Me.Field_189.Name = "Field_189"
		Me.Field_189.Size = New System.Drawing.Size(25, 25)
		Me.Field_189.Location = New System.Drawing.Point(216, 248)
		Me.Field_189.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_189.AutoRedraw = True
		Me.Field_189.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_189.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_189.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_189.TabIndex = 229
		Me.Field_189.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_189.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_189.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_188
		'
		Me.Field_188.Name = "Field_188"
		Me.Field_188.Size = New System.Drawing.Size(25, 25)
		Me.Field_188.Location = New System.Drawing.Point(192, 248)
		Me.Field_188.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_188.AutoRedraw = True
		Me.Field_188.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_188.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_188.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_188.TabIndex = 228
		Me.Field_188.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_188.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_188.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_187
		'
		Me.Field_187.Name = "Field_187"
		Me.Field_187.Size = New System.Drawing.Size(25, 25)
		Me.Field_187.Location = New System.Drawing.Point(168, 248)
		Me.Field_187.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_187.AutoRedraw = True
		Me.Field_187.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_187.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_187.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_187.TabIndex = 227
		Me.Field_187.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_187.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_187.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_186
		'
		Me.Field_186.Name = "Field_186"
		Me.Field_186.Size = New System.Drawing.Size(25, 25)
		Me.Field_186.Location = New System.Drawing.Point(144, 248)
		Me.Field_186.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_186.AutoRedraw = True
		Me.Field_186.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_186.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_186.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_186.TabIndex = 226
		Me.Field_186.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_186.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_186.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_185
		'
		Me.Field_185.Name = "Field_185"
		Me.Field_185.Size = New System.Drawing.Size(25, 25)
		Me.Field_185.Location = New System.Drawing.Point(120, 248)
		Me.Field_185.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_185.AutoRedraw = True
		Me.Field_185.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_185.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_185.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_185.TabIndex = 225
		Me.Field_185.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_185.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_185.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_184
		'
		Me.Field_184.Name = "Field_184"
		Me.Field_184.Size = New System.Drawing.Size(25, 25)
		Me.Field_184.Location = New System.Drawing.Point(96, 248)
		Me.Field_184.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_184.AutoRedraw = True
		Me.Field_184.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_184.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_184.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_184.TabIndex = 224
		Me.Field_184.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_184.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_184.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_183
		'
		Me.Field_183.Name = "Field_183"
		Me.Field_183.Size = New System.Drawing.Size(25, 25)
		Me.Field_183.Location = New System.Drawing.Point(72, 248)
		Me.Field_183.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_183.AutoRedraw = True
		Me.Field_183.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_183.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_183.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_183.TabIndex = 223
		Me.Field_183.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_183.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_183.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_182
		'
		Me.Field_182.Name = "Field_182"
		Me.Field_182.Size = New System.Drawing.Size(25, 25)
		Me.Field_182.Location = New System.Drawing.Point(48, 248)
		Me.Field_182.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_182.AutoRedraw = True
		Me.Field_182.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_182.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_182.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_182.TabIndex = 222
		Me.Field_182.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_182.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_182.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_181
		'
		Me.Field_181.Name = "Field_181"
		Me.Field_181.Size = New System.Drawing.Size(25, 25)
		Me.Field_181.Location = New System.Drawing.Point(24, 248)
		Me.Field_181.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_181.AutoRedraw = True
		Me.Field_181.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_181.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_181.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_181.TabIndex = 221
		Me.Field_181.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_181.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_181.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_180
		'
		Me.Field_180.Name = "Field_180"
		Me.Field_180.Size = New System.Drawing.Size(25, 25)
		Me.Field_180.Location = New System.Drawing.Point(480, 224)
		Me.Field_180.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_180.AutoRedraw = True
		Me.Field_180.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_180.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_180.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_180.TabIndex = 220
		Me.Field_180.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_180.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_180.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_179
		'
		Me.Field_179.Name = "Field_179"
		Me.Field_179.Size = New System.Drawing.Size(25, 25)
		Me.Field_179.Location = New System.Drawing.Point(456, 224)
		Me.Field_179.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_179.AutoRedraw = True
		Me.Field_179.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_179.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_179.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_179.TabIndex = 219
		Me.Field_179.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_179.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_179.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_178
		'
		Me.Field_178.Name = "Field_178"
		Me.Field_178.Size = New System.Drawing.Size(25, 25)
		Me.Field_178.Location = New System.Drawing.Point(432, 224)
		Me.Field_178.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_178.AutoRedraw = True
		Me.Field_178.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_178.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_178.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_178.TabIndex = 218
		Me.Field_178.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_178.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_178.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_177
		'
		Me.Field_177.Name = "Field_177"
		Me.Field_177.Size = New System.Drawing.Size(25, 25)
		Me.Field_177.Location = New System.Drawing.Point(408, 224)
		Me.Field_177.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_177.AutoRedraw = True
		Me.Field_177.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_177.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_177.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_177.TabIndex = 217
		Me.Field_177.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_177.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_177.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_176
		'
		Me.Field_176.Name = "Field_176"
		Me.Field_176.Size = New System.Drawing.Size(25, 25)
		Me.Field_176.Location = New System.Drawing.Point(384, 224)
		Me.Field_176.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_176.AutoRedraw = True
		Me.Field_176.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_176.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_176.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_176.TabIndex = 216
		Me.Field_176.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_176.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_176.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_175
		'
		Me.Field_175.Name = "Field_175"
		Me.Field_175.Size = New System.Drawing.Size(25, 25)
		Me.Field_175.Location = New System.Drawing.Point(360, 224)
		Me.Field_175.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_175.AutoRedraw = True
		Me.Field_175.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_175.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_175.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_175.TabIndex = 215
		Me.Field_175.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_175.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_175.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_174
		'
		Me.Field_174.Name = "Field_174"
		Me.Field_174.Size = New System.Drawing.Size(25, 25)
		Me.Field_174.Location = New System.Drawing.Point(336, 224)
		Me.Field_174.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_174.AutoRedraw = True
		Me.Field_174.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_174.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_174.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_174.TabIndex = 214
		Me.Field_174.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_174.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_174.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_173
		'
		Me.Field_173.Name = "Field_173"
		Me.Field_173.Size = New System.Drawing.Size(25, 25)
		Me.Field_173.Location = New System.Drawing.Point(312, 224)
		Me.Field_173.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_173.AutoRedraw = True
		Me.Field_173.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_173.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_173.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_173.TabIndex = 213
		Me.Field_173.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_173.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_173.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_172
		'
		Me.Field_172.Name = "Field_172"
		Me.Field_172.Size = New System.Drawing.Size(25, 25)
		Me.Field_172.Location = New System.Drawing.Point(288, 224)
		Me.Field_172.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_172.AutoRedraw = True
		Me.Field_172.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_172.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_172.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_172.TabIndex = 212
		Me.Field_172.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_172.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_172.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_171
		'
		Me.Field_171.Name = "Field_171"
		Me.Field_171.Size = New System.Drawing.Size(25, 25)
		Me.Field_171.Location = New System.Drawing.Point(264, 224)
		Me.Field_171.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_171.AutoRedraw = True
		Me.Field_171.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_171.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_171.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_171.TabIndex = 211
		Me.Field_171.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_171.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_171.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_170
		'
		Me.Field_170.Name = "Field_170"
		Me.Field_170.Size = New System.Drawing.Size(25, 25)
		Me.Field_170.Location = New System.Drawing.Point(240, 224)
		Me.Field_170.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_170.AutoRedraw = True
		Me.Field_170.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_170.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_170.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_170.TabIndex = 210
		Me.Field_170.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_170.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_170.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_169
		'
		Me.Field_169.Name = "Field_169"
		Me.Field_169.Size = New System.Drawing.Size(25, 25)
		Me.Field_169.Location = New System.Drawing.Point(216, 224)
		Me.Field_169.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_169.AutoRedraw = True
		Me.Field_169.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_169.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_169.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_169.TabIndex = 209
		Me.Field_169.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_169.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_169.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_168
		'
		Me.Field_168.Name = "Field_168"
		Me.Field_168.Size = New System.Drawing.Size(25, 25)
		Me.Field_168.Location = New System.Drawing.Point(192, 224)
		Me.Field_168.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_168.AutoRedraw = True
		Me.Field_168.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_168.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_168.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_168.TabIndex = 208
		Me.Field_168.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_168.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_168.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_167
		'
		Me.Field_167.Name = "Field_167"
		Me.Field_167.Size = New System.Drawing.Size(25, 25)
		Me.Field_167.Location = New System.Drawing.Point(168, 224)
		Me.Field_167.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_167.AutoRedraw = True
		Me.Field_167.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_167.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_167.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_167.TabIndex = 207
		Me.Field_167.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_167.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_167.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_166
		'
		Me.Field_166.Name = "Field_166"
		Me.Field_166.Size = New System.Drawing.Size(25, 25)
		Me.Field_166.Location = New System.Drawing.Point(144, 224)
		Me.Field_166.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_166.AutoRedraw = True
		Me.Field_166.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_166.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_166.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_166.TabIndex = 206
		Me.Field_166.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_166.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_166.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_165
		'
		Me.Field_165.Name = "Field_165"
		Me.Field_165.Size = New System.Drawing.Size(25, 25)
		Me.Field_165.Location = New System.Drawing.Point(120, 224)
		Me.Field_165.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_165.AutoRedraw = True
		Me.Field_165.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_165.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_165.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_165.TabIndex = 205
		Me.Field_165.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_165.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_165.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_164
		'
		Me.Field_164.Name = "Field_164"
		Me.Field_164.Size = New System.Drawing.Size(25, 25)
		Me.Field_164.Location = New System.Drawing.Point(96, 224)
		Me.Field_164.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_164.AutoRedraw = True
		Me.Field_164.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_164.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_164.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_164.TabIndex = 204
		Me.Field_164.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_164.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_164.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_163
		'
		Me.Field_163.Name = "Field_163"
		Me.Field_163.Size = New System.Drawing.Size(25, 25)
		Me.Field_163.Location = New System.Drawing.Point(72, 224)
		Me.Field_163.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_163.AutoRedraw = True
		Me.Field_163.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_163.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_163.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_163.TabIndex = 203
		Me.Field_163.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_163.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_163.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_162
		'
		Me.Field_162.Name = "Field_162"
		Me.Field_162.Size = New System.Drawing.Size(25, 25)
		Me.Field_162.Location = New System.Drawing.Point(48, 224)
		Me.Field_162.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_162.AutoRedraw = True
		Me.Field_162.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_162.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_162.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_162.TabIndex = 202
		Me.Field_162.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_162.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_162.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_161
		'
		Me.Field_161.Name = "Field_161"
		Me.Field_161.Size = New System.Drawing.Size(25, 25)
		Me.Field_161.Location = New System.Drawing.Point(24, 224)
		Me.Field_161.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_161.AutoRedraw = True
		Me.Field_161.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_161.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_161.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_161.TabIndex = 201
		Me.Field_161.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_161.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_161.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_160
		'
		Me.Field_160.Name = "Field_160"
		Me.Field_160.Size = New System.Drawing.Size(25, 25)
		Me.Field_160.Location = New System.Drawing.Point(480, 200)
		Me.Field_160.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_160.AutoRedraw = True
		Me.Field_160.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_160.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_160.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_160.TabIndex = 200
		Me.Field_160.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_160.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_160.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_159
		'
		Me.Field_159.Name = "Field_159"
		Me.Field_159.Size = New System.Drawing.Size(25, 25)
		Me.Field_159.Location = New System.Drawing.Point(456, 200)
		Me.Field_159.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_159.AutoRedraw = True
		Me.Field_159.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_159.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_159.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_159.TabIndex = 199
		Me.Field_159.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_159.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_159.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_158
		'
		Me.Field_158.Name = "Field_158"
		Me.Field_158.Size = New System.Drawing.Size(25, 25)
		Me.Field_158.Location = New System.Drawing.Point(432, 200)
		Me.Field_158.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_158.AutoRedraw = True
		Me.Field_158.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_158.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_158.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_158.TabIndex = 198
		Me.Field_158.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_158.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_158.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_157
		'
		Me.Field_157.Name = "Field_157"
		Me.Field_157.Size = New System.Drawing.Size(25, 25)
		Me.Field_157.Location = New System.Drawing.Point(408, 200)
		Me.Field_157.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_157.AutoRedraw = True
		Me.Field_157.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Field_157.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_157.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_157.TabIndex = 197
		Me.Field_157.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_157.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_157.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_156
		'
		Me.Field_156.Name = "Field_156"
		Me.Field_156.Size = New System.Drawing.Size(25, 25)
		Me.Field_156.Location = New System.Drawing.Point(384, 200)
		Me.Field_156.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_156.AutoRedraw = True
		Me.Field_156.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Field_156.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_156.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_156.TabIndex = 196
		Me.Field_156.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_156.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_156.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_155
		'
		Me.Field_155.Name = "Field_155"
		Me.Field_155.Size = New System.Drawing.Size(25, 25)
		Me.Field_155.Location = New System.Drawing.Point(360, 200)
		Me.Field_155.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_155.AutoRedraw = True
		Me.Field_155.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Field_155.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_155.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_155.TabIndex = 195
		Me.Field_155.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_155.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_155.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_154
		'
		Me.Field_154.Name = "Field_154"
		Me.Field_154.Size = New System.Drawing.Size(25, 25)
		Me.Field_154.Location = New System.Drawing.Point(336, 200)
		Me.Field_154.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_154.AutoRedraw = True
		Me.Field_154.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_154.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_154.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_154.TabIndex = 194
		Me.Field_154.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_154.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_154.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_153
		'
		Me.Field_153.Name = "Field_153"
		Me.Field_153.Size = New System.Drawing.Size(25, 25)
		Me.Field_153.Location = New System.Drawing.Point(312, 200)
		Me.Field_153.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_153.AutoRedraw = True
		Me.Field_153.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_153.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_153.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_153.TabIndex = 193
		Me.Field_153.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_153.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_153.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_152
		'
		Me.Field_152.Name = "Field_152"
		Me.Field_152.Size = New System.Drawing.Size(25, 25)
		Me.Field_152.Location = New System.Drawing.Point(288, 200)
		Me.Field_152.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_152.AutoRedraw = True
		Me.Field_152.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_152.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_152.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_152.TabIndex = 192
		Me.Field_152.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_152.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_152.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_151
		'
		Me.Field_151.Name = "Field_151"
		Me.Field_151.Size = New System.Drawing.Size(25, 25)
		Me.Field_151.Location = New System.Drawing.Point(264, 200)
		Me.Field_151.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_151.AutoRedraw = True
		Me.Field_151.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_151.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_151.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_151.TabIndex = 191
		Me.Field_151.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_151.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_151.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_150
		'
		Me.Field_150.Name = "Field_150"
		Me.Field_150.Size = New System.Drawing.Size(25, 25)
		Me.Field_150.Location = New System.Drawing.Point(240, 200)
		Me.Field_150.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_150.AutoRedraw = True
		Me.Field_150.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_150.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_150.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_150.TabIndex = 190
		Me.Field_150.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_150.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_150.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_149
		'
		Me.Field_149.Name = "Field_149"
		Me.Field_149.Size = New System.Drawing.Size(25, 25)
		Me.Field_149.Location = New System.Drawing.Point(216, 200)
		Me.Field_149.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_149.AutoRedraw = True
		Me.Field_149.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_149.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbDash
		Me.Field_149.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_149.TabIndex = 189
		Me.Field_149.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_149.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_149.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_148
		'
		Me.Field_148.Name = "Field_148"
		Me.Field_148.Size = New System.Drawing.Size(25, 25)
		Me.Field_148.Location = New System.Drawing.Point(192, 200)
		Me.Field_148.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_148.AutoRedraw = True
		Me.Field_148.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_148.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_148.TabIndex = 188
		Me.Field_148.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_148.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_148.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_147
		'
		Me.Field_147.Name = "Field_147"
		Me.Field_147.Size = New System.Drawing.Size(25, 25)
		Me.Field_147.Location = New System.Drawing.Point(168, 200)
		Me.Field_147.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_147.AutoRedraw = True
		Me.Field_147.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_147.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_147.TabIndex = 187
		Me.Field_147.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_147.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_147.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_146
		'
		Me.Field_146.Name = "Field_146"
		Me.Field_146.Size = New System.Drawing.Size(25, 25)
		Me.Field_146.Location = New System.Drawing.Point(144, 200)
		Me.Field_146.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_146.AutoRedraw = True
		Me.Field_146.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_146.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_146.TabIndex = 186
		Me.Field_146.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_146.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_146.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_145
		'
		Me.Field_145.Name = "Field_145"
		Me.Field_145.Size = New System.Drawing.Size(25, 25)
		Me.Field_145.Location = New System.Drawing.Point(120, 200)
		Me.Field_145.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_145.AutoRedraw = True
		Me.Field_145.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_145.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_145.TabIndex = 185
		Me.Field_145.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_145.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_145.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_144
		'
		Me.Field_144.Name = "Field_144"
		Me.Field_144.Size = New System.Drawing.Size(25, 25)
		Me.Field_144.Location = New System.Drawing.Point(96, 200)
		Me.Field_144.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_144.AutoRedraw = True
		Me.Field_144.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_144.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_144.TabIndex = 184
		Me.Field_144.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_144.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_144.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_143
		'
		Me.Field_143.Name = "Field_143"
		Me.Field_143.Size = New System.Drawing.Size(25, 25)
		Me.Field_143.Location = New System.Drawing.Point(72, 200)
		Me.Field_143.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_143.AutoRedraw = True
		Me.Field_143.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_143.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_143.TabIndex = 183
		Me.Field_143.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_143.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_143.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_142
		'
		Me.Field_142.Name = "Field_142"
		Me.Field_142.Size = New System.Drawing.Size(25, 25)
		Me.Field_142.Location = New System.Drawing.Point(48, 200)
		Me.Field_142.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_142.AutoRedraw = True
		Me.Field_142.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_142.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_142.TabIndex = 182
		Me.Field_142.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_142.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_142.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_141
		'
		Me.Field_141.Name = "Field_141"
		Me.Field_141.Size = New System.Drawing.Size(25, 25)
		Me.Field_141.Location = New System.Drawing.Point(24, 200)
		Me.Field_141.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_141.AutoRedraw = True
		Me.Field_141.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_141.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_141.TabIndex = 181
		Me.Field_141.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_141.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_141.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_140
		'
		Me.Field_140.Name = "Field_140"
		Me.Field_140.Size = New System.Drawing.Size(25, 25)
		Me.Field_140.Location = New System.Drawing.Point(480, 176)
		Me.Field_140.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_140.AutoRedraw = True
		Me.Field_140.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_140.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_140.TabIndex = 180
		Me.Field_140.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_140.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_140.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_139
		'
		Me.Field_139.Name = "Field_139"
		Me.Field_139.Size = New System.Drawing.Size(25, 25)
		Me.Field_139.Location = New System.Drawing.Point(456, 176)
		Me.Field_139.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_139.AutoRedraw = True
		Me.Field_139.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_139.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_139.TabIndex = 179
		Me.Field_139.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_139.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_139.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_138
		'
		Me.Field_138.Name = "Field_138"
		Me.Field_138.Size = New System.Drawing.Size(25, 25)
		Me.Field_138.Location = New System.Drawing.Point(432, 176)
		Me.Field_138.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_138.AutoRedraw = True
		Me.Field_138.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_138.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_138.TabIndex = 178
		Me.Field_138.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_138.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_138.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_137
		'
		Me.Field_137.Name = "Field_137"
		Me.Field_137.Size = New System.Drawing.Size(25, 25)
		Me.Field_137.Location = New System.Drawing.Point(408, 176)
		Me.Field_137.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_137.AutoRedraw = True
		Me.Field_137.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_137.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_137.TabIndex = 177
		Me.Field_137.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_137.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_137.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_136
		'
		Me.Field_136.Name = "Field_136"
		Me.Field_136.Size = New System.Drawing.Size(25, 25)
		Me.Field_136.Location = New System.Drawing.Point(384, 176)
		Me.Field_136.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_136.AutoRedraw = True
		Me.Field_136.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_136.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_136.TabIndex = 176
		Me.Field_136.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_136.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_136.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_135
		'
		Me.Field_135.Name = "Field_135"
		Me.Field_135.Size = New System.Drawing.Size(25, 25)
		Me.Field_135.Location = New System.Drawing.Point(360, 176)
		Me.Field_135.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_135.AutoRedraw = True
		Me.Field_135.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_135.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_135.TabIndex = 175
		Me.Field_135.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_135.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_135.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_134
		'
		Me.Field_134.Name = "Field_134"
		Me.Field_134.Size = New System.Drawing.Size(25, 25)
		Me.Field_134.Location = New System.Drawing.Point(336, 176)
		Me.Field_134.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_134.AutoRedraw = True
		Me.Field_134.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_134.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_134.TabIndex = 174
		Me.Field_134.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_134.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_134.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_133
		'
		Me.Field_133.Name = "Field_133"
		Me.Field_133.Size = New System.Drawing.Size(25, 25)
		Me.Field_133.Location = New System.Drawing.Point(312, 176)
		Me.Field_133.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_133.AutoRedraw = True
		Me.Field_133.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_133.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_133.TabIndex = 173
		Me.Field_133.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_133.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_133.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_132
		'
		Me.Field_132.Name = "Field_132"
		Me.Field_132.Size = New System.Drawing.Size(25, 25)
		Me.Field_132.Location = New System.Drawing.Point(288, 176)
		Me.Field_132.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_132.AutoRedraw = True
		Me.Field_132.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Field_132.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_132.TabIndex = 172
		Me.Field_132.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_132.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_132.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_131
		'
		Me.Field_131.Name = "Field_131"
		Me.Field_131.Size = New System.Drawing.Size(25, 25)
		Me.Field_131.Location = New System.Drawing.Point(264, 176)
		Me.Field_131.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_131.AutoRedraw = True
		Me.Field_131.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_131.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_131.TabIndex = 171
		Me.Field_131.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_131.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_131.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_130
		'
		Me.Field_130.Name = "Field_130"
		Me.Field_130.Size = New System.Drawing.Size(25, 25)
		Me.Field_130.Location = New System.Drawing.Point(240, 176)
		Me.Field_130.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_130.AutoRedraw = True
		Me.Field_130.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_130.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_130.TabIndex = 170
		Me.Field_130.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_130.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_130.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_129
		'
		Me.Field_129.Name = "Field_129"
		Me.Field_129.Size = New System.Drawing.Size(25, 25)
		Me.Field_129.Location = New System.Drawing.Point(216, 176)
		Me.Field_129.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_129.AutoRedraw = True
		Me.Field_129.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_129.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_129.TabIndex = 169
		Me.Field_129.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_129.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_129.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_128
		'
		Me.Field_128.Name = "Field_128"
		Me.Field_128.Size = New System.Drawing.Size(25, 25)
		Me.Field_128.Location = New System.Drawing.Point(192, 176)
		Me.Field_128.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_128.AutoRedraw = True
		Me.Field_128.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_128.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_128.TabIndex = 168
		Me.Field_128.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_128.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_128.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_127
		'
		Me.Field_127.Name = "Field_127"
		Me.Field_127.Size = New System.Drawing.Size(25, 25)
		Me.Field_127.Location = New System.Drawing.Point(168, 176)
		Me.Field_127.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_127.AutoRedraw = True
		Me.Field_127.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_127.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_127.TabIndex = 167
		Me.Field_127.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_127.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_127.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_126
		'
		Me.Field_126.Name = "Field_126"
		Me.Field_126.Size = New System.Drawing.Size(25, 25)
		Me.Field_126.Location = New System.Drawing.Point(144, 176)
		Me.Field_126.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_126.AutoRedraw = True
		Me.Field_126.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_126.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_126.TabIndex = 166
		Me.Field_126.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_126.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_126.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_125
		'
		Me.Field_125.Name = "Field_125"
		Me.Field_125.Size = New System.Drawing.Size(25, 25)
		Me.Field_125.Location = New System.Drawing.Point(120, 176)
		Me.Field_125.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_125.AutoRedraw = True
		Me.Field_125.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_125.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_125.TabIndex = 165
		Me.Field_125.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_125.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_125.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_124
		'
		Me.Field_124.Name = "Field_124"
		Me.Field_124.Size = New System.Drawing.Size(25, 25)
		Me.Field_124.Location = New System.Drawing.Point(96, 176)
		Me.Field_124.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_124.AutoRedraw = True
		Me.Field_124.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_124.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_124.TabIndex = 164
		Me.Field_124.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_124.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_124.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_123
		'
		Me.Field_123.Name = "Field_123"
		Me.Field_123.Size = New System.Drawing.Size(25, 25)
		Me.Field_123.Location = New System.Drawing.Point(72, 176)
		Me.Field_123.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_123.AutoRedraw = True
		Me.Field_123.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_123.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_123.TabIndex = 163
		Me.Field_123.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_123.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_123.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_122
		'
		Me.Field_122.Name = "Field_122"
		Me.Field_122.Size = New System.Drawing.Size(25, 25)
		Me.Field_122.Location = New System.Drawing.Point(48, 176)
		Me.Field_122.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_122.AutoRedraw = True
		Me.Field_122.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_122.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_122.TabIndex = 162
		Me.Field_122.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_122.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_122.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_121
		'
		Me.Field_121.Name = "Field_121"
		Me.Field_121.Size = New System.Drawing.Size(25, 25)
		Me.Field_121.Location = New System.Drawing.Point(24, 176)
		Me.Field_121.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_121.AutoRedraw = True
		Me.Field_121.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_121.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_121.TabIndex = 161
		Me.Field_121.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_121.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_121.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_120
		'
		Me.Field_120.Name = "Field_120"
		Me.Field_120.Size = New System.Drawing.Size(25, 25)
		Me.Field_120.Location = New System.Drawing.Point(480, 152)
		Me.Field_120.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_120.AutoRedraw = True
		Me.Field_120.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_120.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_120.TabIndex = 160
		Me.Field_120.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_120.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_120.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_119
		'
		Me.Field_119.Name = "Field_119"
		Me.Field_119.Size = New System.Drawing.Size(25, 25)
		Me.Field_119.Location = New System.Drawing.Point(456, 152)
		Me.Field_119.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_119.AutoRedraw = True
		Me.Field_119.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_119.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_119.TabIndex = 159
		Me.Field_119.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_119.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_119.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_118
		'
		Me.Field_118.Name = "Field_118"
		Me.Field_118.Size = New System.Drawing.Size(25, 25)
		Me.Field_118.Location = New System.Drawing.Point(432, 152)
		Me.Field_118.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_118.AutoRedraw = True
		Me.Field_118.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_118.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_118.TabIndex = 158
		Me.Field_118.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_118.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_118.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_117
		'
		Me.Field_117.Name = "Field_117"
		Me.Field_117.Size = New System.Drawing.Size(25, 25)
		Me.Field_117.Location = New System.Drawing.Point(408, 152)
		Me.Field_117.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_117.AutoRedraw = True
		Me.Field_117.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_117.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_117.TabIndex = 157
		Me.Field_117.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_117.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_117.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_116
		'
		Me.Field_116.Name = "Field_116"
		Me.Field_116.Size = New System.Drawing.Size(25, 25)
		Me.Field_116.Location = New System.Drawing.Point(384, 152)
		Me.Field_116.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_116.AutoRedraw = True
		Me.Field_116.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_116.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_116.TabIndex = 156
		Me.Field_116.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_116.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_116.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_115
		'
		Me.Field_115.Name = "Field_115"
		Me.Field_115.Size = New System.Drawing.Size(25, 25)
		Me.Field_115.Location = New System.Drawing.Point(360, 152)
		Me.Field_115.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_115.AutoRedraw = True
		Me.Field_115.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_115.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_115.TabIndex = 155
		Me.Field_115.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_115.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_115.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_114
		'
		Me.Field_114.Name = "Field_114"
		Me.Field_114.Size = New System.Drawing.Size(25, 25)
		Me.Field_114.Location = New System.Drawing.Point(336, 152)
		Me.Field_114.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_114.AutoRedraw = True
		Me.Field_114.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_114.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_114.TabIndex = 154
		Me.Field_114.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_114.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_114.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_113
		'
		Me.Field_113.Name = "Field_113"
		Me.Field_113.Size = New System.Drawing.Size(25, 25)
		Me.Field_113.Location = New System.Drawing.Point(312, 152)
		Me.Field_113.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_113.AutoRedraw = True
		Me.Field_113.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_113.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_113.TabIndex = 153
		Me.Field_113.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_113.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_113.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_112
		'
		Me.Field_112.Name = "Field_112"
		Me.Field_112.Size = New System.Drawing.Size(25, 25)
		Me.Field_112.Location = New System.Drawing.Point(288, 152)
		Me.Field_112.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_112.AutoRedraw = True
		Me.Field_112.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_112.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_112.TabIndex = 152
		Me.Field_112.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_112.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_112.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_111
		'
		Me.Field_111.Name = "Field_111"
		Me.Field_111.Size = New System.Drawing.Size(25, 25)
		Me.Field_111.Location = New System.Drawing.Point(264, 152)
		Me.Field_111.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_111.AutoRedraw = True
		Me.Field_111.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_111.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_111.TabIndex = 151
		Me.Field_111.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_111.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_111.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_110
		'
		Me.Field_110.Name = "Field_110"
		Me.Field_110.Size = New System.Drawing.Size(25, 25)
		Me.Field_110.Location = New System.Drawing.Point(240, 152)
		Me.Field_110.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_110.AutoRedraw = True
		Me.Field_110.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_110.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_110.TabIndex = 150
		Me.Field_110.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_110.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_110.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_109
		'
		Me.Field_109.Name = "Field_109"
		Me.Field_109.Size = New System.Drawing.Size(25, 25)
		Me.Field_109.Location = New System.Drawing.Point(216, 152)
		Me.Field_109.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_109.AutoRedraw = True
		Me.Field_109.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_109.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_109.TabIndex = 149
		Me.Field_109.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_109.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_109.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_108
		'
		Me.Field_108.Name = "Field_108"
		Me.Field_108.Size = New System.Drawing.Size(25, 25)
		Me.Field_108.Location = New System.Drawing.Point(192, 152)
		Me.Field_108.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_108.AutoRedraw = True
		Me.Field_108.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_108.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_108.TabIndex = 148
		Me.Field_108.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_108.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_108.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_107
		'
		Me.Field_107.Name = "Field_107"
		Me.Field_107.Size = New System.Drawing.Size(25, 25)
		Me.Field_107.Location = New System.Drawing.Point(168, 152)
		Me.Field_107.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_107.AutoRedraw = True
		Me.Field_107.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_107.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_107.TabIndex = 147
		Me.Field_107.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_107.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_107.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_106
		'
		Me.Field_106.Name = "Field_106"
		Me.Field_106.Size = New System.Drawing.Size(25, 25)
		Me.Field_106.Location = New System.Drawing.Point(144, 152)
		Me.Field_106.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_106.AutoRedraw = True
		Me.Field_106.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_106.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_106.TabIndex = 146
		Me.Field_106.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_106.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_106.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_105
		'
		Me.Field_105.Name = "Field_105"
		Me.Field_105.Size = New System.Drawing.Size(25, 25)
		Me.Field_105.Location = New System.Drawing.Point(120, 152)
		Me.Field_105.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_105.AutoRedraw = True
		Me.Field_105.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_105.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_105.TabIndex = 145
		Me.Field_105.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_105.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_105.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_104
		'
		Me.Field_104.Name = "Field_104"
		Me.Field_104.Size = New System.Drawing.Size(25, 25)
		Me.Field_104.Location = New System.Drawing.Point(96, 152)
		Me.Field_104.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_104.AutoRedraw = True
		Me.Field_104.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_104.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_104.TabIndex = 144
		Me.Field_104.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_104.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_104.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_103
		'
		Me.Field_103.Name = "Field_103"
		Me.Field_103.Size = New System.Drawing.Size(25, 25)
		Me.Field_103.Location = New System.Drawing.Point(72, 152)
		Me.Field_103.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_103.AutoRedraw = True
		Me.Field_103.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_103.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_103.TabIndex = 143
		Me.Field_103.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_103.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_103.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_102
		'
		Me.Field_102.Name = "Field_102"
		Me.Field_102.Size = New System.Drawing.Size(25, 25)
		Me.Field_102.Location = New System.Drawing.Point(48, 152)
		Me.Field_102.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_102.AutoRedraw = True
		Me.Field_102.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_102.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_102.TabIndex = 142
		Me.Field_102.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_102.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_102.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_101
		'
		Me.Field_101.Name = "Field_101"
		Me.Field_101.Size = New System.Drawing.Size(25, 25)
		Me.Field_101.Location = New System.Drawing.Point(24, 152)
		Me.Field_101.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_101.AutoRedraw = True
		Me.Field_101.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_101.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_101.TabIndex = 141
		Me.Field_101.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_101.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_101.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_100
		'
		Me.Field_100.Name = "Field_100"
		Me.Field_100.Size = New System.Drawing.Size(25, 25)
		Me.Field_100.Location = New System.Drawing.Point(480, 128)
		Me.Field_100.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_100.AutoRedraw = True
		Me.Field_100.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_100.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_100.TabIndex = 140
		Me.Field_100.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_100.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_099
		'
		Me.Field_099.Name = "Field_099"
		Me.Field_099.Size = New System.Drawing.Size(25, 25)
		Me.Field_099.Location = New System.Drawing.Point(456, 128)
		Me.Field_099.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_099.AutoRedraw = True
		Me.Field_099.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_099.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_099.TabIndex = 139
		Me.Field_099.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_099.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_099.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_098
		'
		Me.Field_098.Name = "Field_098"
		Me.Field_098.Size = New System.Drawing.Size(25, 25)
		Me.Field_098.Location = New System.Drawing.Point(432, 128)
		Me.Field_098.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_098.AutoRedraw = True
		Me.Field_098.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_098.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_098.TabIndex = 138
		Me.Field_098.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_098.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_098.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_097
		'
		Me.Field_097.Name = "Field_097"
		Me.Field_097.Size = New System.Drawing.Size(25, 25)
		Me.Field_097.Location = New System.Drawing.Point(408, 128)
		Me.Field_097.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_097.AutoRedraw = True
		Me.Field_097.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_097.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_097.TabIndex = 137
		Me.Field_097.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_097.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_097.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_096
		'
		Me.Field_096.Name = "Field_096"
		Me.Field_096.Size = New System.Drawing.Size(25, 25)
		Me.Field_096.Location = New System.Drawing.Point(384, 128)
		Me.Field_096.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_096.AutoRedraw = True
		Me.Field_096.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_096.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_096.TabIndex = 136
		Me.Field_096.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_096.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_096.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_095
		'
		Me.Field_095.Name = "Field_095"
		Me.Field_095.Size = New System.Drawing.Size(25, 25)
		Me.Field_095.Location = New System.Drawing.Point(360, 128)
		Me.Field_095.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_095.AutoRedraw = True
		Me.Field_095.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_095.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_095.TabIndex = 135
		Me.Field_095.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_095.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_095.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_094
		'
		Me.Field_094.Name = "Field_094"
		Me.Field_094.Size = New System.Drawing.Size(25, 25)
		Me.Field_094.Location = New System.Drawing.Point(336, 128)
		Me.Field_094.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_094.AutoRedraw = True
		Me.Field_094.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_094.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_094.TabIndex = 134
		Me.Field_094.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_094.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_094.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_093
		'
		Me.Field_093.Name = "Field_093"
		Me.Field_093.Size = New System.Drawing.Size(25, 25)
		Me.Field_093.Location = New System.Drawing.Point(312, 128)
		Me.Field_093.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_093.AutoRedraw = True
		Me.Field_093.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_093.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_093.TabIndex = 133
		Me.Field_093.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_093.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_093.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_092
		'
		Me.Field_092.Name = "Field_092"
		Me.Field_092.Size = New System.Drawing.Size(25, 25)
		Me.Field_092.Location = New System.Drawing.Point(288, 128)
		Me.Field_092.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_092.AutoRedraw = True
		Me.Field_092.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_092.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_092.TabIndex = 132
		Me.Field_092.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_092.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_092.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_091
		'
		Me.Field_091.Name = "Field_091"
		Me.Field_091.Size = New System.Drawing.Size(25, 25)
		Me.Field_091.Location = New System.Drawing.Point(264, 128)
		Me.Field_091.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_091.AutoRedraw = True
		Me.Field_091.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_091.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_091.TabIndex = 131
		Me.Field_091.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_091.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_091.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_090
		'
		Me.Field_090.Name = "Field_090"
		Me.Field_090.Size = New System.Drawing.Size(25, 25)
		Me.Field_090.Location = New System.Drawing.Point(240, 128)
		Me.Field_090.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_090.AutoRedraw = True
		Me.Field_090.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_090.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_090.TabIndex = 130
		Me.Field_090.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_090.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_090.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_089
		'
		Me.Field_089.Name = "Field_089"
		Me.Field_089.Size = New System.Drawing.Size(25, 25)
		Me.Field_089.Location = New System.Drawing.Point(216, 128)
		Me.Field_089.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_089.AutoRedraw = True
		Me.Field_089.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_089.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_089.TabIndex = 129
		Me.Field_089.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_089.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_089.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_088
		'
		Me.Field_088.Name = "Field_088"
		Me.Field_088.Size = New System.Drawing.Size(25, 25)
		Me.Field_088.Location = New System.Drawing.Point(192, 128)
		Me.Field_088.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_088.AutoRedraw = True
		Me.Field_088.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_088.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_088.TabIndex = 128
		Me.Field_088.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_088.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_088.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_087
		'
		Me.Field_087.Name = "Field_087"
		Me.Field_087.Size = New System.Drawing.Size(25, 25)
		Me.Field_087.Location = New System.Drawing.Point(168, 128)
		Me.Field_087.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_087.AutoRedraw = True
		Me.Field_087.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_087.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_087.TabIndex = 127
		Me.Field_087.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_087.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_087.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_086
		'
		Me.Field_086.Name = "Field_086"
		Me.Field_086.Size = New System.Drawing.Size(25, 25)
		Me.Field_086.Location = New System.Drawing.Point(144, 128)
		Me.Field_086.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_086.AutoRedraw = True
		Me.Field_086.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_086.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_086.TabIndex = 126
		Me.Field_086.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_086.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_086.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_085
		'
		Me.Field_085.Name = "Field_085"
		Me.Field_085.Size = New System.Drawing.Size(25, 25)
		Me.Field_085.Location = New System.Drawing.Point(120, 128)
		Me.Field_085.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_085.AutoRedraw = True
		Me.Field_085.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_085.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_085.TabIndex = 125
		Me.Field_085.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_085.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_085.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_084
		'
		Me.Field_084.Name = "Field_084"
		Me.Field_084.Size = New System.Drawing.Size(25, 25)
		Me.Field_084.Location = New System.Drawing.Point(96, 128)
		Me.Field_084.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_084.AutoRedraw = True
		Me.Field_084.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_084.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_084.TabIndex = 124
		Me.Field_084.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_084.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_084.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_083
		'
		Me.Field_083.Name = "Field_083"
		Me.Field_083.Size = New System.Drawing.Size(25, 25)
		Me.Field_083.Location = New System.Drawing.Point(72, 128)
		Me.Field_083.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_083.AutoRedraw = True
		Me.Field_083.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_083.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_083.TabIndex = 123
		Me.Field_083.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_083.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_083.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_082
		'
		Me.Field_082.Name = "Field_082"
		Me.Field_082.Size = New System.Drawing.Size(25, 25)
		Me.Field_082.Location = New System.Drawing.Point(48, 128)
		Me.Field_082.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_082.AutoRedraw = True
		Me.Field_082.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_082.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_082.TabIndex = 122
		Me.Field_082.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_082.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_082.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_081
		'
		Me.Field_081.Name = "Field_081"
		Me.Field_081.Size = New System.Drawing.Size(25, 25)
		Me.Field_081.Location = New System.Drawing.Point(24, 128)
		Me.Field_081.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_081.AutoRedraw = True
		Me.Field_081.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_081.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_081.TabIndex = 121
		Me.Field_081.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_081.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_081.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_080
		'
		Me.Field_080.Name = "Field_080"
		Me.Field_080.Size = New System.Drawing.Size(25, 25)
		Me.Field_080.Location = New System.Drawing.Point(480, 104)
		Me.Field_080.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_080.AutoRedraw = True
		Me.Field_080.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_080.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_080.TabIndex = 120
		Me.Field_080.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_080.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_080.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_079
		'
		Me.Field_079.Name = "Field_079"
		Me.Field_079.Size = New System.Drawing.Size(25, 25)
		Me.Field_079.Location = New System.Drawing.Point(456, 104)
		Me.Field_079.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_079.AutoRedraw = True
		Me.Field_079.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_079.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_079.TabIndex = 119
		Me.Field_079.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_079.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_079.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_078
		'
		Me.Field_078.Name = "Field_078"
		Me.Field_078.Size = New System.Drawing.Size(25, 25)
		Me.Field_078.Location = New System.Drawing.Point(432, 104)
		Me.Field_078.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_078.AutoRedraw = True
		Me.Field_078.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_078.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_078.TabIndex = 118
		Me.Field_078.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_078.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_078.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_077
		'
		Me.Field_077.Name = "Field_077"
		Me.Field_077.Size = New System.Drawing.Size(25, 25)
		Me.Field_077.Location = New System.Drawing.Point(408, 104)
		Me.Field_077.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_077.AutoRedraw = True
		Me.Field_077.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_077.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_077.TabIndex = 117
		Me.Field_077.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_077.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_077.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_076
		'
		Me.Field_076.Name = "Field_076"
		Me.Field_076.Size = New System.Drawing.Size(25, 25)
		Me.Field_076.Location = New System.Drawing.Point(384, 104)
		Me.Field_076.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_076.AutoRedraw = True
		Me.Field_076.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_076.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_076.TabIndex = 116
		Me.Field_076.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_076.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_076.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_075
		'
		Me.Field_075.Name = "Field_075"
		Me.Field_075.Size = New System.Drawing.Size(25, 25)
		Me.Field_075.Location = New System.Drawing.Point(360, 104)
		Me.Field_075.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_075.AutoRedraw = True
		Me.Field_075.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_075.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_075.TabIndex = 115
		Me.Field_075.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_075.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_075.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_074
		'
		Me.Field_074.Name = "Field_074"
		Me.Field_074.Size = New System.Drawing.Size(25, 25)
		Me.Field_074.Location = New System.Drawing.Point(336, 104)
		Me.Field_074.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_074.AutoRedraw = True
		Me.Field_074.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_074.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_074.TabIndex = 114
		Me.Field_074.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_074.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_074.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_073
		'
		Me.Field_073.Name = "Field_073"
		Me.Field_073.Size = New System.Drawing.Size(25, 25)
		Me.Field_073.Location = New System.Drawing.Point(312, 104)
		Me.Field_073.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_073.AutoRedraw = True
		Me.Field_073.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_073.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_073.TabIndex = 113
		Me.Field_073.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_073.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_073.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_072
		'
		Me.Field_072.Name = "Field_072"
		Me.Field_072.Size = New System.Drawing.Size(25, 25)
		Me.Field_072.Location = New System.Drawing.Point(288, 104)
		Me.Field_072.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_072.AutoRedraw = True
		Me.Field_072.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_072.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_072.TabIndex = 112
		Me.Field_072.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_072.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_072.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_071
		'
		Me.Field_071.Name = "Field_071"
		Me.Field_071.Size = New System.Drawing.Size(25, 25)
		Me.Field_071.Location = New System.Drawing.Point(264, 104)
		Me.Field_071.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_071.AutoRedraw = True
		Me.Field_071.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_071.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_071.TabIndex = 111
		Me.Field_071.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_071.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_071.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_070
		'
		Me.Field_070.Name = "Field_070"
		Me.Field_070.Size = New System.Drawing.Size(25, 25)
		Me.Field_070.Location = New System.Drawing.Point(240, 104)
		Me.Field_070.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_070.AutoRedraw = True
		Me.Field_070.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_070.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_070.TabIndex = 110
		Me.Field_070.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_070.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_070.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_069
		'
		Me.Field_069.Name = "Field_069"
		Me.Field_069.Size = New System.Drawing.Size(25, 25)
		Me.Field_069.Location = New System.Drawing.Point(216, 104)
		Me.Field_069.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_069.AutoRedraw = True
		Me.Field_069.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_069.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_069.TabIndex = 109
		Me.Field_069.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_069.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_069.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_068
		'
		Me.Field_068.Name = "Field_068"
		Me.Field_068.Size = New System.Drawing.Size(25, 25)
		Me.Field_068.Location = New System.Drawing.Point(192, 104)
		Me.Field_068.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_068.AutoRedraw = True
		Me.Field_068.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_068.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_068.TabIndex = 108
		Me.Field_068.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_068.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_068.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_067
		'
		Me.Field_067.Name = "Field_067"
		Me.Field_067.Size = New System.Drawing.Size(25, 25)
		Me.Field_067.Location = New System.Drawing.Point(168, 104)
		Me.Field_067.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_067.AutoRedraw = True
		Me.Field_067.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_067.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_067.TabIndex = 107
		Me.Field_067.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_067.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_067.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_066
		'
		Me.Field_066.Name = "Field_066"
		Me.Field_066.Size = New System.Drawing.Size(25, 25)
		Me.Field_066.Location = New System.Drawing.Point(144, 104)
		Me.Field_066.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_066.AutoRedraw = True
		Me.Field_066.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_066.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_066.TabIndex = 106
		Me.Field_066.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_066.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_066.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_065
		'
		Me.Field_065.Name = "Field_065"
		Me.Field_065.Size = New System.Drawing.Size(25, 25)
		Me.Field_065.Location = New System.Drawing.Point(120, 104)
		Me.Field_065.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_065.AutoRedraw = True
		Me.Field_065.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_065.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_065.TabIndex = 105
		Me.Field_065.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_065.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_065.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_064
		'
		Me.Field_064.Name = "Field_064"
		Me.Field_064.Size = New System.Drawing.Size(25, 25)
		Me.Field_064.Location = New System.Drawing.Point(96, 104)
		Me.Field_064.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_064.AutoRedraw = True
		Me.Field_064.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_064.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_064.TabIndex = 104
		Me.Field_064.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_064.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_064.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_063
		'
		Me.Field_063.Name = "Field_063"
		Me.Field_063.Size = New System.Drawing.Size(25, 25)
		Me.Field_063.Location = New System.Drawing.Point(72, 104)
		Me.Field_063.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_063.AutoRedraw = True
		Me.Field_063.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_063.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_063.TabIndex = 103
		Me.Field_063.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_063.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_063.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_062
		'
		Me.Field_062.Name = "Field_062"
		Me.Field_062.Size = New System.Drawing.Size(25, 25)
		Me.Field_062.Location = New System.Drawing.Point(48, 104)
		Me.Field_062.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_062.AutoRedraw = True
		Me.Field_062.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_062.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_062.TabIndex = 102
		Me.Field_062.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_062.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_062.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_061
		'
		Me.Field_061.Name = "Field_061"
		Me.Field_061.Size = New System.Drawing.Size(25, 25)
		Me.Field_061.Location = New System.Drawing.Point(24, 104)
		Me.Field_061.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_061.AutoRedraw = True
		Me.Field_061.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_061.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_061.TabIndex = 101
		Me.Field_061.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_061.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_061.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_060
		'
		Me.Field_060.Name = "Field_060"
		Me.Field_060.Size = New System.Drawing.Size(25, 25)
		Me.Field_060.Location = New System.Drawing.Point(480, 80)
		Me.Field_060.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_060.AutoRedraw = True
		Me.Field_060.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_060.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_060.TabIndex = 100
		Me.Field_060.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_060.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_060.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_059
		'
		Me.Field_059.Name = "Field_059"
		Me.Field_059.Size = New System.Drawing.Size(25, 25)
		Me.Field_059.Location = New System.Drawing.Point(456, 80)
		Me.Field_059.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_059.AutoRedraw = True
		Me.Field_059.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Field_059.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_059.TabIndex = 99
		Me.Field_059.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_059.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_059.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_058
		'
		Me.Field_058.Name = "Field_058"
		Me.Field_058.Size = New System.Drawing.Size(25, 25)
		Me.Field_058.Location = New System.Drawing.Point(432, 80)
		Me.Field_058.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_058.AutoRedraw = True
		Me.Field_058.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_058.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_058.TabIndex = 98
		Me.Field_058.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_058.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_058.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_057
		'
		Me.Field_057.Name = "Field_057"
		Me.Field_057.Size = New System.Drawing.Size(25, 25)
		Me.Field_057.Location = New System.Drawing.Point(408, 80)
		Me.Field_057.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_057.AutoRedraw = True
		Me.Field_057.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_057.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_057.TabIndex = 97
		Me.Field_057.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_057.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_057.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_056
		'
		Me.Field_056.Name = "Field_056"
		Me.Field_056.Size = New System.Drawing.Size(25, 25)
		Me.Field_056.Location = New System.Drawing.Point(384, 80)
		Me.Field_056.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_056.AutoRedraw = True
		Me.Field_056.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_056.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_056.TabIndex = 96
		Me.Field_056.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_056.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_056.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_055
		'
		Me.Field_055.Name = "Field_055"
		Me.Field_055.Size = New System.Drawing.Size(25, 25)
		Me.Field_055.Location = New System.Drawing.Point(360, 80)
		Me.Field_055.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_055.AutoRedraw = True
		Me.Field_055.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_055.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_055.TabIndex = 95
		Me.Field_055.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_055.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_055.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_054
		'
		Me.Field_054.Name = "Field_054"
		Me.Field_054.Size = New System.Drawing.Size(25, 25)
		Me.Field_054.Location = New System.Drawing.Point(336, 80)
		Me.Field_054.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_054.AutoRedraw = True
		Me.Field_054.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_054.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_054.TabIndex = 94
		Me.Field_054.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_054.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_054.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_053
		'
		Me.Field_053.Name = "Field_053"
		Me.Field_053.Size = New System.Drawing.Size(25, 25)
		Me.Field_053.Location = New System.Drawing.Point(312, 80)
		Me.Field_053.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_053.AutoRedraw = True
		Me.Field_053.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_053.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_053.TabIndex = 93
		Me.Field_053.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_053.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_053.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_052
		'
		Me.Field_052.Name = "Field_052"
		Me.Field_052.Size = New System.Drawing.Size(25, 25)
		Me.Field_052.Location = New System.Drawing.Point(288, 80)
		Me.Field_052.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_052.AutoRedraw = True
		Me.Field_052.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_052.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_052.TabIndex = 92
		Me.Field_052.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_052.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_052.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_051
		'
		Me.Field_051.Name = "Field_051"
		Me.Field_051.Size = New System.Drawing.Size(25, 25)
		Me.Field_051.Location = New System.Drawing.Point(264, 80)
		Me.Field_051.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_051.AutoRedraw = True
		Me.Field_051.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_051.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_051.TabIndex = 91
		Me.Field_051.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_051.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_051.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_050
		'
		Me.Field_050.Name = "Field_050"
		Me.Field_050.Size = New System.Drawing.Size(25, 25)
		Me.Field_050.Location = New System.Drawing.Point(240, 80)
		Me.Field_050.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_050.AutoRedraw = True
		Me.Field_050.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_050.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_050.TabIndex = 90
		Me.Field_050.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_050.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_049
		'
		Me.Field_049.Name = "Field_049"
		Me.Field_049.Size = New System.Drawing.Size(25, 25)
		Me.Field_049.Location = New System.Drawing.Point(216, 80)
		Me.Field_049.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_049.AutoRedraw = True
		Me.Field_049.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_049.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_049.TabIndex = 89
		Me.Field_049.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_049.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_049.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_048
		'
		Me.Field_048.Name = "Field_048"
		Me.Field_048.Size = New System.Drawing.Size(25, 25)
		Me.Field_048.Location = New System.Drawing.Point(192, 80)
		Me.Field_048.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_048.AutoRedraw = True
		Me.Field_048.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_048.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_048.TabIndex = 88
		Me.Field_048.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_048.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_048.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_047
		'
		Me.Field_047.Name = "Field_047"
		Me.Field_047.Size = New System.Drawing.Size(25, 25)
		Me.Field_047.Location = New System.Drawing.Point(168, 80)
		Me.Field_047.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_047.AutoRedraw = True
		Me.Field_047.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_047.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_047.TabIndex = 87
		Me.Field_047.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_047.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_047.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_046
		'
		Me.Field_046.Name = "Field_046"
		Me.Field_046.Size = New System.Drawing.Size(25, 25)
		Me.Field_046.Location = New System.Drawing.Point(144, 80)
		Me.Field_046.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_046.AutoRedraw = True
		Me.Field_046.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_046.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_046.TabIndex = 86
		Me.Field_046.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_046.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_046.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_045
		'
		Me.Field_045.Name = "Field_045"
		Me.Field_045.Size = New System.Drawing.Size(25, 25)
		Me.Field_045.Location = New System.Drawing.Point(120, 80)
		Me.Field_045.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_045.AutoRedraw = True
		Me.Field_045.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_045.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_045.TabIndex = 85
		Me.Field_045.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_045.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_045.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_044
		'
		Me.Field_044.Name = "Field_044"
		Me.Field_044.Size = New System.Drawing.Size(25, 25)
		Me.Field_044.Location = New System.Drawing.Point(96, 80)
		Me.Field_044.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_044.AutoRedraw = True
		Me.Field_044.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_044.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_044.TabIndex = 84
		Me.Field_044.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_044.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_044.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_043
		'
		Me.Field_043.Name = "Field_043"
		Me.Field_043.Size = New System.Drawing.Size(25, 25)
		Me.Field_043.Location = New System.Drawing.Point(72, 80)
		Me.Field_043.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_043.AutoRedraw = True
		Me.Field_043.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_043.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_043.TabIndex = 83
		Me.Field_043.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_043.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_043.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_042
		'
		Me.Field_042.Name = "Field_042"
		Me.Field_042.Size = New System.Drawing.Size(25, 25)
		Me.Field_042.Location = New System.Drawing.Point(48, 80)
		Me.Field_042.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_042.AutoRedraw = True
		Me.Field_042.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_042.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_042.TabIndex = 82
		Me.Field_042.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_042.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_042.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_041
		'
		Me.Field_041.Name = "Field_041"
		Me.Field_041.Size = New System.Drawing.Size(25, 25)
		Me.Field_041.Location = New System.Drawing.Point(24, 80)
		Me.Field_041.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_041.AutoRedraw = True
		Me.Field_041.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_041.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_041.TabIndex = 81
		Me.Field_041.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_041.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_041.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_040
		'
		Me.Field_040.Name = "Field_040"
		Me.Field_040.Size = New System.Drawing.Size(25, 25)
		Me.Field_040.Location = New System.Drawing.Point(480, 56)
		Me.Field_040.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_040.AutoRedraw = True
		Me.Field_040.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_040.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_040.TabIndex = 80
		Me.Field_040.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_040.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_040.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_039
		'
		Me.Field_039.Name = "Field_039"
		Me.Field_039.Size = New System.Drawing.Size(25, 25)
		Me.Field_039.Location = New System.Drawing.Point(456, 56)
		Me.Field_039.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_039.AutoRedraw = True
		Me.Field_039.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_039.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_039.TabIndex = 79
		Me.Field_039.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_039.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_039.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_038
		'
		Me.Field_038.Name = "Field_038"
		Me.Field_038.Size = New System.Drawing.Size(25, 25)
		Me.Field_038.Location = New System.Drawing.Point(432, 56)
		Me.Field_038.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_038.AutoRedraw = True
		Me.Field_038.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_038.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_038.TabIndex = 78
		Me.Field_038.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_038.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_038.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_037
		'
		Me.Field_037.Name = "Field_037"
		Me.Field_037.Size = New System.Drawing.Size(25, 25)
		Me.Field_037.Location = New System.Drawing.Point(408, 56)
		Me.Field_037.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_037.AutoRedraw = True
		Me.Field_037.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_037.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_037.TabIndex = 77
		Me.Field_037.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_037.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_037.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_036
		'
		Me.Field_036.Name = "Field_036"
		Me.Field_036.Size = New System.Drawing.Size(25, 25)
		Me.Field_036.Location = New System.Drawing.Point(384, 56)
		Me.Field_036.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_036.AutoRedraw = True
		Me.Field_036.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_036.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_036.TabIndex = 76
		Me.Field_036.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_036.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_036.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_035
		'
		Me.Field_035.Name = "Field_035"
		Me.Field_035.Size = New System.Drawing.Size(25, 25)
		Me.Field_035.Location = New System.Drawing.Point(360, 56)
		Me.Field_035.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_035.AutoRedraw = True
		Me.Field_035.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_035.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_035.TabIndex = 75
		Me.Field_035.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_035.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_035.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_034
		'
		Me.Field_034.Name = "Field_034"
		Me.Field_034.Size = New System.Drawing.Size(25, 25)
		Me.Field_034.Location = New System.Drawing.Point(336, 56)
		Me.Field_034.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_034.AutoRedraw = True
		Me.Field_034.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_034.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_034.TabIndex = 74
		Me.Field_034.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_034.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_034.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_033
		'
		Me.Field_033.Name = "Field_033"
		Me.Field_033.Size = New System.Drawing.Size(25, 25)
		Me.Field_033.Location = New System.Drawing.Point(312, 56)
		Me.Field_033.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_033.AutoRedraw = True
		Me.Field_033.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_033.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_033.TabIndex = 73
		Me.Field_033.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_033.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_033.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_032
		'
		Me.Field_032.Name = "Field_032"
		Me.Field_032.Size = New System.Drawing.Size(25, 25)
		Me.Field_032.Location = New System.Drawing.Point(288, 56)
		Me.Field_032.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_032.AutoRedraw = True
		Me.Field_032.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_032.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_032.TabIndex = 72
		Me.Field_032.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_032.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_032.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_031
		'
		Me.Field_031.Name = "Field_031"
		Me.Field_031.Size = New System.Drawing.Size(25, 25)
		Me.Field_031.Location = New System.Drawing.Point(264, 56)
		Me.Field_031.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_031.AutoRedraw = True
		Me.Field_031.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_031.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_031.TabIndex = 71
		Me.Field_031.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_031.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_031.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_030
		'
		Me.Field_030.Name = "Field_030"
		Me.Field_030.Size = New System.Drawing.Size(25, 25)
		Me.Field_030.Location = New System.Drawing.Point(240, 56)
		Me.Field_030.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_030.AutoRedraw = True
		Me.Field_030.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_030.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_030.TabIndex = 70
		Me.Field_030.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_030.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_030.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_029
		'
		Me.Field_029.Name = "Field_029"
		Me.Field_029.Size = New System.Drawing.Size(25, 25)
		Me.Field_029.Location = New System.Drawing.Point(216, 56)
		Me.Field_029.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_029.AutoRedraw = True
		Me.Field_029.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_029.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_029.TabIndex = 69
		Me.Field_029.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_029.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_029.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_028
		'
		Me.Field_028.Name = "Field_028"
		Me.Field_028.Size = New System.Drawing.Size(25, 25)
		Me.Field_028.Location = New System.Drawing.Point(192, 56)
		Me.Field_028.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_028.AutoRedraw = True
		Me.Field_028.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_028.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_028.TabIndex = 68
		Me.Field_028.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_028.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_028.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_027
		'
		Me.Field_027.Name = "Field_027"
		Me.Field_027.Size = New System.Drawing.Size(25, 25)
		Me.Field_027.Location = New System.Drawing.Point(168, 56)
		Me.Field_027.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_027.AutoRedraw = True
		Me.Field_027.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_027.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_027.TabIndex = 67
		Me.Field_027.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_027.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_027.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_026
		'
		Me.Field_026.Name = "Field_026"
		Me.Field_026.Size = New System.Drawing.Size(25, 25)
		Me.Field_026.Location = New System.Drawing.Point(144, 56)
		Me.Field_026.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_026.AutoRedraw = True
		Me.Field_026.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_026.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_026.TabIndex = 66
		Me.Field_026.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_026.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_026.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_025
		'
		Me.Field_025.Name = "Field_025"
		Me.Field_025.Size = New System.Drawing.Size(25, 25)
		Me.Field_025.Location = New System.Drawing.Point(120, 56)
		Me.Field_025.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_025.AutoRedraw = True
		Me.Field_025.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_025.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_025.TabIndex = 65
		Me.Field_025.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_025.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_025.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_024
		'
		Me.Field_024.Name = "Field_024"
		Me.Field_024.Size = New System.Drawing.Size(25, 25)
		Me.Field_024.Location = New System.Drawing.Point(96, 56)
		Me.Field_024.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_024.AutoRedraw = True
		Me.Field_024.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_024.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_024.TabIndex = 64
		Me.Field_024.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_024.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_024.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_023
		'
		Me.Field_023.Name = "Field_023"
		Me.Field_023.Size = New System.Drawing.Size(25, 25)
		Me.Field_023.Location = New System.Drawing.Point(72, 56)
		Me.Field_023.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_023.AutoRedraw = True
		Me.Field_023.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_023.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_023.TabIndex = 63
		Me.Field_023.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_023.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_023.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_022
		'
		Me.Field_022.Name = "Field_022"
		Me.Field_022.Size = New System.Drawing.Size(25, 25)
		Me.Field_022.Location = New System.Drawing.Point(48, 56)
		Me.Field_022.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_022.AutoRedraw = True
		Me.Field_022.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_022.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_022.TabIndex = 62
		Me.Field_022.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_022.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_022.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_021
		'
		Me.Field_021.Name = "Field_021"
		Me.Field_021.Size = New System.Drawing.Size(25, 25)
		Me.Field_021.Location = New System.Drawing.Point(24, 56)
		Me.Field_021.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_021.AutoRedraw = True
		Me.Field_021.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_021.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_021.TabIndex = 61
		Me.Field_021.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_021.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_021.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_020
		'
		Me.Field_020.Name = "Field_020"
		Me.Field_020.Size = New System.Drawing.Size(25, 25)
		Me.Field_020.Location = New System.Drawing.Point(480, 32)
		Me.Field_020.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_020.AutoRedraw = True
		Me.Field_020.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_020.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_020.TabIndex = 60
		Me.Field_020.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_020.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_020.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_019
		'
		Me.Field_019.Name = "Field_019"
		Me.Field_019.Size = New System.Drawing.Size(25, 25)
		Me.Field_019.Location = New System.Drawing.Point(456, 32)
		Me.Field_019.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_019.AutoRedraw = True
		Me.Field_019.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_019.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_019.TabIndex = 59
		Me.Field_019.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_019.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_019.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_018
		'
		Me.Field_018.Name = "Field_018"
		Me.Field_018.Size = New System.Drawing.Size(25, 25)
		Me.Field_018.Location = New System.Drawing.Point(432, 32)
		Me.Field_018.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_018.AutoRedraw = True
		Me.Field_018.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_018.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_018.TabIndex = 58
		Me.Field_018.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_018.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_018.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_017
		'
		Me.Field_017.Name = "Field_017"
		Me.Field_017.Size = New System.Drawing.Size(25, 25)
		Me.Field_017.Location = New System.Drawing.Point(408, 32)
		Me.Field_017.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_017.AutoRedraw = True
		Me.Field_017.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_017.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_017.TabIndex = 57
		Me.Field_017.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_017.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_017.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_016
		'
		Me.Field_016.Name = "Field_016"
		Me.Field_016.Size = New System.Drawing.Size(25, 25)
		Me.Field_016.Location = New System.Drawing.Point(384, 32)
		Me.Field_016.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_016.AutoRedraw = True
		Me.Field_016.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_016.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_016.TabIndex = 56
		Me.Field_016.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_016.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_016.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_015
		'
		Me.Field_015.Name = "Field_015"
		Me.Field_015.Size = New System.Drawing.Size(25, 25)
		Me.Field_015.Location = New System.Drawing.Point(360, 32)
		Me.Field_015.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_015.AutoRedraw = True
		Me.Field_015.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_015.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_015.TabIndex = 55
		Me.Field_015.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_015.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_015.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_014
		'
		Me.Field_014.Name = "Field_014"
		Me.Field_014.Size = New System.Drawing.Size(25, 25)
		Me.Field_014.Location = New System.Drawing.Point(336, 32)
		Me.Field_014.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_014.AutoRedraw = True
		Me.Field_014.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_014.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_014.TabIndex = 54
		Me.Field_014.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_014.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_014.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_013
		'
		Me.Field_013.Name = "Field_013"
		Me.Field_013.Size = New System.Drawing.Size(25, 25)
		Me.Field_013.Location = New System.Drawing.Point(312, 32)
		Me.Field_013.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_013.AutoRedraw = True
		Me.Field_013.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_013.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_013.TabIndex = 53
		Me.Field_013.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_013.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_013.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_012
		'
		Me.Field_012.Name = "Field_012"
		Me.Field_012.Size = New System.Drawing.Size(25, 25)
		Me.Field_012.Location = New System.Drawing.Point(288, 32)
		Me.Field_012.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_012.AutoRedraw = True
		Me.Field_012.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_012.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_012.TabIndex = 52
		Me.Field_012.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_012.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_012.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_011
		'
		Me.Field_011.Name = "Field_011"
		Me.Field_011.Size = New System.Drawing.Size(25, 25)
		Me.Field_011.Location = New System.Drawing.Point(264, 32)
		Me.Field_011.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_011.AutoRedraw = True
		Me.Field_011.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_011.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_011.TabIndex = 51
		Me.Field_011.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_011.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_010
		'
		Me.Field_010.Name = "Field_010"
		Me.Field_010.Size = New System.Drawing.Size(25, 25)
		Me.Field_010.Location = New System.Drawing.Point(240, 32)
		Me.Field_010.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_010.AutoRedraw = True
		Me.Field_010.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_010.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_010.TabIndex = 50
		Me.Field_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_010.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_010.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_009
		'
		Me.Field_009.Name = "Field_009"
		Me.Field_009.Size = New System.Drawing.Size(25, 25)
		Me.Field_009.Location = New System.Drawing.Point(216, 32)
		Me.Field_009.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_009.AutoRedraw = True
		Me.Field_009.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_009.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_009.TabIndex = 49
		Me.Field_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_009.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_009.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_008
		'
		Me.Field_008.Name = "Field_008"
		Me.Field_008.Size = New System.Drawing.Size(25, 25)
		Me.Field_008.Location = New System.Drawing.Point(192, 32)
		Me.Field_008.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_008.AutoRedraw = True
		Me.Field_008.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_008.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_008.TabIndex = 48
		Me.Field_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_008.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_008.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_007
		'
		Me.Field_007.Name = "Field_007"
		Me.Field_007.Size = New System.Drawing.Size(25, 25)
		Me.Field_007.Location = New System.Drawing.Point(168, 32)
		Me.Field_007.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_007.AutoRedraw = True
		Me.Field_007.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_007.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_007.TabIndex = 47
		Me.Field_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_007.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_007.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_006
		'
		Me.Field_006.Name = "Field_006"
		Me.Field_006.Size = New System.Drawing.Size(25, 25)
		Me.Field_006.Location = New System.Drawing.Point(144, 32)
		Me.Field_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_006.AutoRedraw = True
		Me.Field_006.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_006.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_006.TabIndex = 46
		Me.Field_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_006.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_006.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_005
		'
		Me.Field_005.Name = "Field_005"
		Me.Field_005.Size = New System.Drawing.Size(25, 25)
		Me.Field_005.Location = New System.Drawing.Point(120, 32)
		Me.Field_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_005.AutoRedraw = True
		Me.Field_005.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_005.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_005.TabIndex = 45
		Me.Field_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_005.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_005.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_004
		'
		Me.Field_004.Name = "Field_004"
		Me.Field_004.Size = New System.Drawing.Size(25, 25)
		Me.Field_004.Location = New System.Drawing.Point(96, 32)
		Me.Field_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_004.AutoRedraw = True
		Me.Field_004.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_004.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_004.TabIndex = 44
		Me.Field_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_004.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_004.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_003
		'
		Me.Field_003.Name = "Field_003"
		Me.Field_003.Size = New System.Drawing.Size(25, 25)
		Me.Field_003.Location = New System.Drawing.Point(72, 32)
		Me.Field_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_003.AutoRedraw = True
		Me.Field_003.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_003.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_003.TabIndex = 43
		Me.Field_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_003.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_003.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_002
		'
		Me.Field_002.Name = "Field_002"
		Me.Field_002.Size = New System.Drawing.Size(25, 25)
		Me.Field_002.Location = New System.Drawing.Point(48, 32)
		Me.Field_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_002.AutoRedraw = True
		Me.Field_002.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_002.TabIndex = 42
		Me.Field_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_002.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_002.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Field_001
		'
		Me.Field_001.Name = "Field_001"
		Me.Field_001.Size = New System.Drawing.Size(25, 25)
		Me.Field_001.Location = New System.Drawing.Point(24, 32)
		Me.Field_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Field_001.AutoRedraw = True
		Me.Field_001.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Field_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Field_001.TabIndex = 41
		Me.Field_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Field_001.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Field_001.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' statsFRA
		'
		Me.statsFRA.Name = "statsFRA"
		Me.statsFRA.Size = New System.Drawing.Size(249, 41)
		Me.statsFRA.Location = New System.Drawing.Point(232, 328)
		Me.statsFRA.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.statsFRA.Caption = "Game Stats-"
		Me.statsFRA.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.statsFRA.TabIndex = 0
		'
		' GameStatsLBL
		'
		Me.GameStatsLBL.Name = "GameStatsLBL"
		Me.GameStatsLBL.Size = New System.Drawing.Size(233, 17)
		Me.GameStatsLBL.Location = New System.Drawing.Point(8, 16)
		Me.GameStatsLBL.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.GameStatsLBL.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.GameStatsLBL.TabIndex = 1
		Me.GameStatsLBL.AutoSize = False
		Me.GameStatsLBL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MainTXT
		'
		Me.MainTXT.Name = "MainTXT"
		Me.MainTXT.Size = New System.Drawing.Size(217, 185)
		Me.MainTXT.Location = New System.Drawing.Point(8, 328)
		Me.MainTXT.TabIndex = 286
		Me.MainTXT.ReadOnly = True
		Me.MainTXT.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfVertical
		Me.MainTXT.TextRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "\viewkind4\uc1\pard\f0\fs17 " & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		Me.MainTXT.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.MainTXT.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		'
		' nickSERVER
		'
		Me.nickSERVER.Name = "nickSERVER"
		Me.nickSERVER.Size = New System.Drawing.Size(17, 9)
		Me.nickSERVER.Location = New System.Drawing.Point(24, 520)
		Me.nickSERVER.TabIndex = 285
		Me.nickSERVER.Visible = False
		Me.nickSERVER.AutoSize = False
		Me.nickSERVER.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' nickCLIENT
		'
		Me.nickCLIENT.Name = "nickCLIENT"
		Me.nickCLIENT.Size = New System.Drawing.Size(17, 9)
		Me.nickCLIENT.Location = New System.Drawing.Point(48, 520)
		Me.nickCLIENT.TabIndex = 284
		Me.nickCLIENT.Visible = False
		Me.nickCLIENT.AutoSize = False
		Me.nickCLIENT.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(57, 9)
		Me.Label1.Location = New System.Drawing.Point(8, 320)
		Me.Label1.Font = New System.Drawing.Font("Arial", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "© 2000 One"
		Me.Label1.TabIndex = 283
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line31
		'
		Me.Line31.Name = "Line31"
		Me.Line31.ParentForm = Me
		Me.Line31.Name6 = "Line31"
		Me.Line31.X1 = 4800
		Me.Line31.X2 = 6000
		Me.Line31.Y1 = 7440
		Me.Line31.Y2 = 7440
		'
		' Line30
		'
		Me.Line30.Name = "Line30"
		Me.Line30.ParentForm = Me
		Me.Line30.Name6 = "Line30"
		Me.Line30.X1 = 4800
		Me.Line30.X2 = 6000
		Me.Line30.Y1 = 7080
		Me.Line30.Y2 = 7080
		'
		' Line29
		'
		Me.Line29.Name = "Line29"
		Me.Line29.ParentForm = Me
		Me.Line29.Name6 = "Line29"
		Me.Line29.X1 = 4680
		Me.Line29.X2 = 5880
		Me.Line29.Y1 = 7920
		Me.Line29.Y2 = 7920
		'
		' Line28
		'
		Me.Line28.Name = "Line28"
		Me.Line28.ParentForm = Me
		Me.Line28.Name6 = "Line28"
		Me.Line28.X1 = 4680
		Me.Line28.X2 = 5880
		Me.Line28.Y1 = 7560
		Me.Line28.Y2 = 7560
		'
		' Line27
		'
		Me.Line27.Name = "Line27"
		Me.Line27.ParentForm = Me
		Me.Line27.Name6 = "Line27"
		Me.Line27.X1 = 5880
		Me.Line27.X2 = 5880
		Me.Line27.Y1 = 7560
		Me.Line27.Y2 = 7920
		'
		' Line26
		'
		Me.Line26.Name = "Line26"
		Me.Line26.ParentForm = Me
		Me.Line26.Name6 = "Line26"
		Me.Line26.X1 = 4680
		Me.Line26.X2 = 4680
		Me.Line26.Y1 = 7560
		Me.Line26.Y2 = 7920
		'
		' Line25
		'
		Me.Line25.Name = "Line25"
		Me.Line25.ParentForm = Me
		Me.Line25.Name6 = "Line25"
		Me.Line25.X1 = 6000
		Me.Line25.X2 = 6000
		Me.Line25.Y1 = 7080
		Me.Line25.Y2 = 7440
		'
		' Line24
		'
		Me.Line24.Name = "Line24"
		Me.Line24.ParentForm = Me
		Me.Line24.Name6 = "Line24"
		Me.Line24.X1 = 4800
		Me.Line24.X2 = 4800
		Me.Line24.Y1 = 7080
		Me.Line24.Y2 = 7440
		'
		' Line23
		'
		Me.Line23.Name = "Line23"
		Me.Line23.ParentForm = Me
		Me.Line23.Name6 = "Line23"
		Me.Line23.X1 = 6240
		Me.Line23.X2 = 6240
		Me.Line23.Y1 = 6600
		Me.Line23.Y2 = 6960
		'
		' Line22
		'
		Me.Line22.Name = "Line22"
		Me.Line22.ParentForm = Me
		Me.Line22.Name6 = "Line22"
		Me.Line22.X1 = 4440
		Me.Line22.X2 = 4440
		Me.Line22.Y1 = 6600
		Me.Line22.Y2 = 6960
		'
		' Line21
		'
		Me.Line21.Name = "Line21"
		Me.Line21.ParentForm = Me
		Me.Line21.Name6 = "Line21"
		Me.Line21.X1 = 4440
		Me.Line21.X2 = 6240
		Me.Line21.Y1 = 6960
		Me.Line21.Y2 = 6960
		'
		' Line20
		'
		Me.Line20.Name = "Line20"
		Me.Line20.ParentForm = Me
		Me.Line20.Name6 = "Line20"
		Me.Line20.X1 = 4440
		Me.Line20.X2 = 6240
		Me.Line20.Y1 = 6600
		Me.Line20.Y2 = 6600
		'
		' Line19
		'
		Me.Line19.Name = "Line19"
		Me.Line19.ParentForm = Me
		Me.Line19.Name6 = "Line19"
		Me.Line19.X1 = 4680
		Me.Line19.X2 = 7080
		Me.Line19.Y1 = 6480
		Me.Line19.Y2 = 6480
		'
		' Line18
		'
		Me.Line18.Name = "Line18"
		Me.Line18.ParentForm = Me
		Me.Line18.Name6 = "Line18"
		Me.Line18.X1 = 4680
		Me.Line18.X2 = 7080
		Me.Line18.Y1 = 6120
		Me.Line18.Y2 = 6120
		'
		' Line17
		'
		Me.Line17.Name = "Line17"
		Me.Line17.ParentForm = Me
		Me.Line17.Name6 = "Line17"
		Me.Line17.X1 = 7080
		Me.Line17.X2 = 7080
		Me.Line17.Y1 = 6120
		Me.Line17.Y2 = 6480
		'
		' Line16
		'
		Me.Line16.Name = "Line16"
		Me.Line16.ParentForm = Me
		Me.Line16.Name6 = "Line16"
		Me.Line16.X1 = 4680
		Me.Line16.X2 = 4680
		Me.Line16.Y1 = 6120
		Me.Line16.Y2 = 6480
		'
		' Line15
		'
		Me.Line15.Name = "Line15"
		Me.Line15.ParentForm = Me
		Me.Line15.Name6 = "Line15"
		Me.Line15.X1 = 7440
		Me.Line15.X2 = 7440
		Me.Line15.Y1 = 5640
		Me.Line15.Y2 = 6000
		'
		' Line14
		'
		Me.Line14.Name = "Line14"
		Me.Line14.ParentForm = Me
		Me.Line14.Name6 = "Line14"
		Me.Line14.X1 = 4440
		Me.Line14.X2 = 4440
		Me.Line14.Y1 = 5640
		Me.Line14.Y2 = 6000
		'
		' Line13
		'
		Me.Line13.Name = "Line13"
		Me.Line13.ParentForm = Me
		Me.Line13.Name6 = "Line13"
		Me.Line13.X1 = 4440
		Me.Line13.X2 = 7440
		Me.Line13.Y1 = 6000
		Me.Line13.Y2 = 6000
		'
		' Line12
		'
		Me.Line12.Name = "Line12"
		Me.Line12.ParentForm = Me
		Me.Line12.Name6 = "Line12"
		Me.Line12.X1 = 4440
		Me.Line12.X2 = 7440
		Me.Line12.Y1 = 5640
		Me.Line12.Y2 = 5640
		'
		' Line10
		'
		Me.Line10.Name = "Line10"
		Me.Line10.ParentForm = Me
		Me.Line10.Name6 = "Line10"
		Me.Line10.X1 = 5280
		Me.Line10.X2 = 5280
		Me.Line10.Y1 = 7560
		Me.Line10.Y2 = 7920
		'
		' Line8
		'
		Me.Line8.Name = "Line8"
		Me.Line8.ParentForm = Me
		Me.Line8.Name6 = "Line8"
		Me.Line8.X1 = 5400
		Me.Line8.X2 = 5400
		Me.Line8.Y1 = 7080
		Me.Line8.Y2 = 7440
		'
		' Line5
		'
		Me.Line5.Name = "Line5"
		Me.Line5.ParentForm = Me
		Me.Line5.Name6 = "Line5"
		Me.Line5.X1 = 5640
		Me.Line5.X2 = 5640
		Me.Line5.Y1 = 6600
		Me.Line5.Y2 = 6960
		'
		' Line11
		'
		Me.Line11.Name = "Line11"
		Me.Line11.ParentForm = Me
		Me.Line11.Name6 = "Line11"
		Me.Line11.X1 = 6480
		Me.Line11.X2 = 6480
		Me.Line11.Y1 = 6120
		Me.Line11.Y2 = 6480
		'
		' Line9
		'
		Me.Line9.Name = "Line9"
		Me.Line9.ParentForm = Me
		Me.Line9.Name6 = "Line9"
		Me.Line9.X1 = 5040
		Me.Line9.X2 = 5040
		Me.Line9.Y1 = 6600
		Me.Line9.Y2 = 6960
		'
		' Line7
		'
		Me.Line7.Name = "Line7"
		Me.Line7.ParentForm = Me
		Me.Line7.Name6 = "Line7"
		Me.Line7.X1 = 5880
		Me.Line7.X2 = 5880
		Me.Line7.Y1 = 6120
		Me.Line7.Y2 = 6480
		'
		' Line6
		'
		Me.Line6.Name = "Line6"
		Me.Line6.ParentForm = Me
		Me.Line6.Name6 = "Line6"
		Me.Line6.X1 = 5280
		Me.Line6.X2 = 5280
		Me.Line6.Y1 = 6120
		Me.Line6.Y2 = 6480
		'
		' Line4
		'
		Me.Line4.Name = "Line4"
		Me.Line4.ParentForm = Me
		Me.Line4.Name6 = "Line4"
		Me.Line4.X1 = 6240
		Me.Line4.X2 = 6240
		Me.Line4.Y1 = 5640
		Me.Line4.Y2 = 6000
		'
		' Line3
		'
		Me.Line3.Name = "Line3"
		Me.Line3.ParentForm = Me
		Me.Line3.Name6 = "Line3"
		Me.Line3.X1 = 6840
		Me.Line3.X2 = 6840
		Me.Line3.Y1 = 5640
		Me.Line3.Y2 = 6000
		'
		' Line2
		'
		Me.Line2.Name = "Line2"
		Me.Line2.ParentForm = Me
		Me.Line2.Name6 = "Line2"
		Me.Line2.X1 = 5640
		Me.Line2.X2 = 5640
		Me.Line2.Y1 = 5640
		Me.Line2.Y2 = 6000
		'
		' Line1
		'
		Me.Line1.Name = "Line1"
		Me.Line1.ParentForm = Me
		Me.Line1.Name6 = "Line1"
		Me.Line1.X1 = 5040
		Me.Line1.X2 = 5040
		Me.Line1.Y1 = 5640
		Me.Line1.Y2 = 6000
		'
		' Label30
		'
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(81, 25)
		Me.Label30.Location = New System.Drawing.Point(232, 504)
		Me.Label30.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label30.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Label30.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label30.Caption = "Destroyer:"
		Me.Label30.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label30.TabIndex = 19
		Me.Label30.AutoSize = False
		'
		' Label29
		'
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(89, 17)
		Me.Label29.Location = New System.Drawing.Point(232, 472)
		Me.Label29.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label29.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Label29.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label29.Caption = "Submarine:"
		Me.Label29.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label29.TabIndex = 18
		Me.Label29.AutoSize = False
		'
		' Label28
		'
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(57, 25)
		Me.Label28.Location = New System.Drawing.Point(232, 440)
		Me.Label28.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Label28.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label28.Caption = "Cruiser:"
		Me.Label28.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label28.TabIndex = 17
		Me.Label28.AutoSize = False
		'
		' Label27
		'
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(81, 25)
		Me.Label27.Location = New System.Drawing.Point(232, 408)
		Me.Label27.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label27.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Label27.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label27.Caption = "Battleship:"
		Me.Label27.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label27.TabIndex = 16
		Me.Label27.AutoSize = False
		'
		' Label26
		'
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(65, 17)
		Me.Label26.Location = New System.Drawing.Point(232, 376)
		Me.Label26.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Label26.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label26.Caption = "Carrier:"
		Me.Label26.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.Label26.TabIndex = 15
		Me.Label26.AutoSize = False
		'
		' labelBgLNE_019
		'
		Me.labelBgLNE_019.Name = "labelBgLNE_019"
		Me.labelBgLNE_019.ParentForm = Me
		Me.labelBgLNE_019.Name6 = "labelBgLNE_019"
		Me.labelBgLNE_019.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_019.BorderWidth = 2
		Me.labelBgLNE_019.X1 = 1440
		Me.labelBgLNE_019.X2 = 120
		Me.labelBgLNE_019.Y1 = 8640
		Me.labelBgLNE_019.Y2 = 8640
		'
		' labelBgLNE_018
		'
		Me.labelBgLNE_018.Name = "labelBgLNE_018"
		Me.labelBgLNE_018.ParentForm = Me
		Me.labelBgLNE_018.Name6 = "labelBgLNE_018"
		Me.labelBgLNE_018.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_018.BorderWidth = 2
		Me.labelBgLNE_018.X1 = 1440
		Me.labelBgLNE_018.X2 = 120
		Me.labelBgLNE_018.Y1 = 8280
		Me.labelBgLNE_018.Y2 = 8280
		'
		' labelBgLNE_017
		'
		Me.labelBgLNE_017.Name = "labelBgLNE_017"
		Me.labelBgLNE_017.ParentForm = Me
		Me.labelBgLNE_017.Name6 = "labelBgLNE_017"
		Me.labelBgLNE_017.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_017.BorderWidth = 2
		Me.labelBgLNE_017.X1 = 120
		Me.labelBgLNE_017.X2 = 120
		Me.labelBgLNE_017.Y1 = 8280
		Me.labelBgLNE_017.Y2 = 8640
		'
		' labelBgLNE_016
		'
		Me.labelBgLNE_016.Name = "labelBgLNE_016"
		Me.labelBgLNE_016.ParentForm = Me
		Me.labelBgLNE_016.Name6 = "labelBgLNE_016"
		Me.labelBgLNE_016.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_016.BorderWidth = 2
		Me.labelBgLNE_016.X1 = 1440
		Me.labelBgLNE_016.X2 = 1440
		Me.labelBgLNE_016.Y1 = 8280
		Me.labelBgLNE_016.Y2 = 8640
		'
		' labelBgLNE_015
		'
		Me.labelBgLNE_015.Name = "labelBgLNE_015"
		Me.labelBgLNE_015.ParentForm = Me
		Me.labelBgLNE_015.Name6 = "labelBgLNE_015"
		Me.labelBgLNE_015.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_015.BorderWidth = 2
		Me.labelBgLNE_015.X1 = 3000
		Me.labelBgLNE_015.X2 = 1680
		Me.labelBgLNE_015.Y1 = 8640
		Me.labelBgLNE_015.Y2 = 8640
		'
		' labelBgLNE_014
		'
		Me.labelBgLNE_014.Name = "labelBgLNE_014"
		Me.labelBgLNE_014.ParentForm = Me
		Me.labelBgLNE_014.Name6 = "labelBgLNE_014"
		Me.labelBgLNE_014.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_014.BorderWidth = 2
		Me.labelBgLNE_014.X1 = 3000
		Me.labelBgLNE_014.X2 = 1680
		Me.labelBgLNE_014.Y1 = 8280
		Me.labelBgLNE_014.Y2 = 8280
		'
		' labelBgLNE_013
		'
		Me.labelBgLNE_013.Name = "labelBgLNE_013"
		Me.labelBgLNE_013.ParentForm = Me
		Me.labelBgLNE_013.Name6 = "labelBgLNE_013"
		Me.labelBgLNE_013.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_013.BorderWidth = 2
		Me.labelBgLNE_013.X1 = 1680
		Me.labelBgLNE_013.X2 = 1680
		Me.labelBgLNE_013.Y1 = 8280
		Me.labelBgLNE_013.Y2 = 8640
		'
		' labelBgLNE_012
		'
		Me.labelBgLNE_012.Name = "labelBgLNE_012"
		Me.labelBgLNE_012.ParentForm = Me
		Me.labelBgLNE_012.Name6 = "labelBgLNE_012"
		Me.labelBgLNE_012.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_012.BorderWidth = 2
		Me.labelBgLNE_012.X1 = 3000
		Me.labelBgLNE_012.X2 = 3000
		Me.labelBgLNE_012.Y1 = 8280
		Me.labelBgLNE_012.Y2 = 8640
		'
		' labelBgLNE_011
		'
		Me.labelBgLNE_011.Name = "labelBgLNE_011"
		Me.labelBgLNE_011.ParentForm = Me
		Me.labelBgLNE_011.Name6 = "labelBgLNE_011"
		Me.labelBgLNE_011.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_011.BorderWidth = 2
		Me.labelBgLNE_011.X1 = 4560
		Me.labelBgLNE_011.X2 = 3240
		Me.labelBgLNE_011.Y1 = 8640
		Me.labelBgLNE_011.Y2 = 8640
		'
		' labelBgLNE_010
		'
		Me.labelBgLNE_010.Name = "labelBgLNE_010"
		Me.labelBgLNE_010.ParentForm = Me
		Me.labelBgLNE_010.Name6 = "labelBgLNE_010"
		Me.labelBgLNE_010.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_010.BorderWidth = 2
		Me.labelBgLNE_010.X1 = 4560
		Me.labelBgLNE_010.X2 = 3240
		Me.labelBgLNE_010.Y1 = 8280
		Me.labelBgLNE_010.Y2 = 8280
		'
		' labelBgLNE_009
		'
		Me.labelBgLNE_009.Name = "labelBgLNE_009"
		Me.labelBgLNE_009.ParentForm = Me
		Me.labelBgLNE_009.Name6 = "labelBgLNE_009"
		Me.labelBgLNE_009.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_009.BorderWidth = 2
		Me.labelBgLNE_009.X1 = 3240
		Me.labelBgLNE_009.X2 = 3240
		Me.labelBgLNE_009.Y1 = 8280
		Me.labelBgLNE_009.Y2 = 8640
		'
		' labelBgLNE_008
		'
		Me.labelBgLNE_008.Name = "labelBgLNE_008"
		Me.labelBgLNE_008.ParentForm = Me
		Me.labelBgLNE_008.Name6 = "labelBgLNE_008"
		Me.labelBgLNE_008.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_008.BorderWidth = 2
		Me.labelBgLNE_008.X1 = 4560
		Me.labelBgLNE_008.X2 = 4560
		Me.labelBgLNE_008.Y1 = 8280
		Me.labelBgLNE_008.Y2 = 8640
		'
		' labelBgLNE_007
		'
		Me.labelBgLNE_007.Name = "labelBgLNE_007"
		Me.labelBgLNE_007.ParentForm = Me
		Me.labelBgLNE_007.Name6 = "labelBgLNE_007"
		Me.labelBgLNE_007.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_007.BorderWidth = 2
		Me.labelBgLNE_007.X1 = 6120
		Me.labelBgLNE_007.X2 = 4800
		Me.labelBgLNE_007.Y1 = 8640
		Me.labelBgLNE_007.Y2 = 8640
		'
		' labelBgLNE_006
		'
		Me.labelBgLNE_006.Name = "labelBgLNE_006"
		Me.labelBgLNE_006.ParentForm = Me
		Me.labelBgLNE_006.Name6 = "labelBgLNE_006"
		Me.labelBgLNE_006.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_006.BorderWidth = 2
		Me.labelBgLNE_006.X1 = 6120
		Me.labelBgLNE_006.X2 = 4800
		Me.labelBgLNE_006.Y1 = 8280
		Me.labelBgLNE_006.Y2 = 8280
		'
		' labelBgLNE_005
		'
		Me.labelBgLNE_005.Name = "labelBgLNE_005"
		Me.labelBgLNE_005.ParentForm = Me
		Me.labelBgLNE_005.Name6 = "labelBgLNE_005"
		Me.labelBgLNE_005.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_005.BorderWidth = 2
		Me.labelBgLNE_005.X1 = 4800
		Me.labelBgLNE_005.X2 = 4800
		Me.labelBgLNE_005.Y1 = 8280
		Me.labelBgLNE_005.Y2 = 8640
		'
		' labelBgLNE_004
		'
		Me.labelBgLNE_004.Name = "labelBgLNE_004"
		Me.labelBgLNE_004.ParentForm = Me
		Me.labelBgLNE_004.Name6 = "labelBgLNE_004"
		Me.labelBgLNE_004.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_004.BorderWidth = 2
		Me.labelBgLNE_004.X1 = 6120
		Me.labelBgLNE_004.X2 = 6120
		Me.labelBgLNE_004.Y1 = 8280
		Me.labelBgLNE_004.Y2 = 8640
		'
		' labelBgLNE_003
		'
		Me.labelBgLNE_003.Name = "labelBgLNE_003"
		Me.labelBgLNE_003.ParentForm = Me
		Me.labelBgLNE_003.Name6 = "labelBgLNE_003"
		Me.labelBgLNE_003.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_003.BorderWidth = 2
		Me.labelBgLNE_003.X1 = 7680
		Me.labelBgLNE_003.X2 = 6360
		Me.labelBgLNE_003.Y1 = 8640
		Me.labelBgLNE_003.Y2 = 8640
		'
		' labelBgLNE_002
		'
		Me.labelBgLNE_002.Name = "labelBgLNE_002"
		Me.labelBgLNE_002.ParentForm = Me
		Me.labelBgLNE_002.Name6 = "labelBgLNE_002"
		Me.labelBgLNE_002.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_002.BorderWidth = 2
		Me.labelBgLNE_002.X1 = 7680
		Me.labelBgLNE_002.X2 = 6360
		Me.labelBgLNE_002.Y1 = 8280
		Me.labelBgLNE_002.Y2 = 8280
		'
		' labelBgLNE_001
		'
		Me.labelBgLNE_001.Name = "labelBgLNE_001"
		Me.labelBgLNE_001.ParentForm = Me
		Me.labelBgLNE_001.Name6 = "labelBgLNE_001"
		Me.labelBgLNE_001.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_001.BorderWidth = 2
		Me.labelBgLNE_001.X1 = 6360
		Me.labelBgLNE_001.X2 = 6360
		Me.labelBgLNE_001.Y1 = 8280
		Me.labelBgLNE_001.Y2 = 8640
		'
		' labelBgLNE_000
		'
		Me.labelBgLNE_000.Name = "labelBgLNE_000"
		Me.labelBgLNE_000.ParentForm = Me
		Me.labelBgLNE_000.Name6 = "labelBgLNE_000"
		Me.labelBgLNE_000.BorderColor = FromOleColor6(CInt(&H0000FFFF))
		Me.labelBgLNE_000.BorderWidth = 2
		Me.labelBgLNE_000.X1 = 7680
		Me.labelBgLNE_000.X2 = 7680
		Me.labelBgLNE_000.Y1 = 8280
		Me.labelBgLNE_000.Y2 = 8640
		'
		' Label15
		'
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(9, 17)
		Me.Label15.Location = New System.Drawing.Point(8, 296)
		Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label15.Caption = "L"
		Me.Label15.TabIndex = 14
		Me.Label15.AutoSize = False
		Me.Label15.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label14
		'
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(9, 17)
		Me.Label14.Location = New System.Drawing.Point(8, 272)
		Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label14.Caption = "K"
		Me.Label14.TabIndex = 13
		Me.Label14.AutoSize = False
		Me.Label14.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(9, 17)
		Me.Label13.Location = New System.Drawing.Point(8, 248)
		Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label13.Caption = "J"
		Me.Label13.TabIndex = 12
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(9, 17)
		Me.Label12.Location = New System.Drawing.Point(8, 224)
		Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label12.Caption = "I"
		Me.Label12.TabIndex = 11
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(9, 17)
		Me.Label11.Location = New System.Drawing.Point(8, 200)
		Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label11.Caption = "H"
		Me.Label11.TabIndex = 10
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(9, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 176)
		Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label10.Caption = "G"
		Me.Label10.TabIndex = 9
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(9, 17)
		Me.Label9.Location = New System.Drawing.Point(8, 152)
		Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label9.Caption = "F"
		Me.Label9.TabIndex = 8
		Me.Label9.AutoSize = False
		Me.Label9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(9, 17)
		Me.Label8.Location = New System.Drawing.Point(8, 128)
		Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label8.Caption = "E"
		Me.Label8.TabIndex = 7
		Me.Label8.AutoSize = False
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label20
		'
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(9, 17)
		Me.Label20.Location = New System.Drawing.Point(8, 104)
		Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label20.Caption = "D"
		Me.Label20.TabIndex = 6
		Me.Label20.AutoSize = False
		Me.Label20.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(9, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 80)
		Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label7.Caption = "C"
		Me.Label7.TabIndex = 5
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(9, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 56)
		Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label6.Caption = "B"
		Me.Label6.TabIndex = 4
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(9, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 32)
		Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "A"
		Me.Label5.TabIndex = 3
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(481, 25)
		Me.Label4.Location = New System.Drawing.Point(24, 8)
		Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "  1   2    3   4    5   6   7    8   9   10  11  12  13  14  15  16  17  18  19  20"
		Me.Label4.TabIndex = 2
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MYcarrierLBL_001
		'
		Me.MYcarrierLBL_001.Name = "MYcarrierLBL_001"
		Me.MYcarrierLBL_001.Size = New System.Drawing.Size(41, 25)
		Me.MYcarrierLBL_001.Location = New System.Drawing.Point(296, 376)
		Me.MYcarrierLBL_001.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcarrierLBL_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcarrierLBL_001.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcarrierLBL_001.TabIndex = 36
		Me.MYcarrierLBL_001.AutoSize = False
		'
		' MYcarrierLBL_002
		'
		Me.MYcarrierLBL_002.Name = "MYcarrierLBL_002"
		Me.MYcarrierLBL_002.Size = New System.Drawing.Size(41, 25)
		Me.MYcarrierLBL_002.Location = New System.Drawing.Point(336, 376)
		Me.MYcarrierLBL_002.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcarrierLBL_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcarrierLBL_002.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcarrierLBL_002.TabIndex = 37
		Me.MYcarrierLBL_002.AutoSize = False
		'
		' MYcarrierLBL_003
		'
		Me.MYcarrierLBL_003.Name = "MYcarrierLBL_003"
		Me.MYcarrierLBL_003.Size = New System.Drawing.Size(41, 25)
		Me.MYcarrierLBL_003.Location = New System.Drawing.Point(376, 376)
		Me.MYcarrierLBL_003.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcarrierLBL_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcarrierLBL_003.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcarrierLBL_003.TabIndex = 38
		Me.MYcarrierLBL_003.AutoSize = False
		'
		' MYcarrierLBL_004
		'
		Me.MYcarrierLBL_004.Name = "MYcarrierLBL_004"
		Me.MYcarrierLBL_004.Size = New System.Drawing.Size(41, 25)
		Me.MYcarrierLBL_004.Location = New System.Drawing.Point(416, 376)
		Me.MYcarrierLBL_004.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcarrierLBL_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcarrierLBL_004.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcarrierLBL_004.TabIndex = 40
		Me.MYcarrierLBL_004.AutoSize = False
		'
		' MYcarrierLBL_005
		'
		Me.MYcarrierLBL_005.Name = "MYcarrierLBL_005"
		Me.MYcarrierLBL_005.Size = New System.Drawing.Size(41, 25)
		Me.MYcarrierLBL_005.Location = New System.Drawing.Point(456, 376)
		Me.MYcarrierLBL_005.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcarrierLBL_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcarrierLBL_005.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcarrierLBL_005.TabIndex = 39
		Me.MYcarrierLBL_005.AutoSize = False
		'
		' MYbattleshipLBL_001
		'
		Me.MYbattleshipLBL_001.Name = "MYbattleshipLBL_001"
		Me.MYbattleshipLBL_001.Size = New System.Drawing.Size(41, 25)
		Me.MYbattleshipLBL_001.Location = New System.Drawing.Point(312, 408)
		Me.MYbattleshipLBL_001.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYbattleshipLBL_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYbattleshipLBL_001.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYbattleshipLBL_001.TabIndex = 35
		Me.MYbattleshipLBL_001.AutoSize = False
		'
		' MYbattleshipLBL_002
		'
		Me.MYbattleshipLBL_002.Name = "MYbattleshipLBL_002"
		Me.MYbattleshipLBL_002.Size = New System.Drawing.Size(41, 25)
		Me.MYbattleshipLBL_002.Location = New System.Drawing.Point(352, 408)
		Me.MYbattleshipLBL_002.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYbattleshipLBL_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYbattleshipLBL_002.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYbattleshipLBL_002.TabIndex = 34
		Me.MYbattleshipLBL_002.AutoSize = False
		'
		' MYbattleshipLBL_003
		'
		Me.MYbattleshipLBL_003.Name = "MYbattleshipLBL_003"
		Me.MYbattleshipLBL_003.Size = New System.Drawing.Size(41, 25)
		Me.MYbattleshipLBL_003.Location = New System.Drawing.Point(392, 408)
		Me.MYbattleshipLBL_003.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYbattleshipLBL_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYbattleshipLBL_003.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYbattleshipLBL_003.TabIndex = 33
		Me.MYbattleshipLBL_003.AutoSize = False
		'
		' MYbattleshipLBL_004
		'
		Me.MYbattleshipLBL_004.Name = "MYbattleshipLBL_004"
		Me.MYbattleshipLBL_004.Size = New System.Drawing.Size(41, 25)
		Me.MYbattleshipLBL_004.Location = New System.Drawing.Point(432, 408)
		Me.MYbattleshipLBL_004.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYbattleshipLBL_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYbattleshipLBL_004.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYbattleshipLBL_004.TabIndex = 32
		Me.MYbattleshipLBL_004.AutoSize = False
		'
		' MYcruiserLBL_003
		'
		Me.MYcruiserLBL_003.Name = "MYcruiserLBL_003"
		Me.MYcruiserLBL_003.Size = New System.Drawing.Size(41, 25)
		Me.MYcruiserLBL_003.Location = New System.Drawing.Point(376, 440)
		Me.MYcruiserLBL_003.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcruiserLBL_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcruiserLBL_003.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcruiserLBL_003.TabIndex = 31
		Me.MYcruiserLBL_003.AutoSize = False
		'
		' MYcruiserLBL_002
		'
		Me.MYcruiserLBL_002.Name = "MYcruiserLBL_002"
		Me.MYcruiserLBL_002.Size = New System.Drawing.Size(41, 25)
		Me.MYcruiserLBL_002.Location = New System.Drawing.Point(336, 440)
		Me.MYcruiserLBL_002.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcruiserLBL_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcruiserLBL_002.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcruiserLBL_002.TabIndex = 30
		Me.MYcruiserLBL_002.AutoSize = False
		'
		' MYcruiserLBL_001
		'
		Me.MYcruiserLBL_001.Name = "MYcruiserLBL_001"
		Me.MYcruiserLBL_001.Size = New System.Drawing.Size(41, 25)
		Me.MYcruiserLBL_001.Location = New System.Drawing.Point(296, 440)
		Me.MYcruiserLBL_001.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYcruiserLBL_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYcruiserLBL_001.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYcruiserLBL_001.TabIndex = 29
		Me.MYcruiserLBL_001.AutoSize = False
		'
		' MYsubmarineLBL_001
		'
		Me.MYsubmarineLBL_001.Name = "MYsubmarineLBL_001"
		Me.MYsubmarineLBL_001.Size = New System.Drawing.Size(41, 25)
		Me.MYsubmarineLBL_001.Location = New System.Drawing.Point(320, 472)
		Me.MYsubmarineLBL_001.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYsubmarineLBL_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYsubmarineLBL_001.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYsubmarineLBL_001.TabIndex = 28
		Me.MYsubmarineLBL_001.AutoSize = False
		'
		' MYsubmarineLBL_002
		'
		Me.MYsubmarineLBL_002.Name = "MYsubmarineLBL_002"
		Me.MYsubmarineLBL_002.Size = New System.Drawing.Size(41, 25)
		Me.MYsubmarineLBL_002.Location = New System.Drawing.Point(360, 472)
		Me.MYsubmarineLBL_002.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYsubmarineLBL_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYsubmarineLBL_002.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYsubmarineLBL_002.TabIndex = 27
		Me.MYsubmarineLBL_002.AutoSize = False
		'
		' MYdestroyerLBL_001
		'
		Me.MYdestroyerLBL_001.Name = "MYdestroyerLBL_001"
		Me.MYdestroyerLBL_001.Size = New System.Drawing.Size(41, 25)
		Me.MYdestroyerLBL_001.Location = New System.Drawing.Point(312, 504)
		Me.MYdestroyerLBL_001.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYdestroyerLBL_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYdestroyerLBL_001.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYdestroyerLBL_001.TabIndex = 25
		Me.MYdestroyerLBL_001.AutoSize = False
		'
		' MYdestroyerLBL_002
		'
		Me.MYdestroyerLBL_002.Name = "MYdestroyerLBL_002"
		Me.MYdestroyerLBL_002.Size = New System.Drawing.Size(41, 25)
		Me.MYdestroyerLBL_002.Location = New System.Drawing.Point(352, 504)
		Me.MYdestroyerLBL_002.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MYdestroyerLBL_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.MYdestroyerLBL_002.BackColor = FromOleColor6(CInt(&H00808080))
		Me.MYdestroyerLBL_002.TabIndex = 26
		Me.MYdestroyerLBL_002.AutoSize = False
		'
		' DestroyerLBL
		'
		Me.DestroyerLBL.Name = "DestroyerLBL"
		Me.DestroyerLBL.Size = New System.Drawing.Size(89, 25)
		Me.DestroyerLBL.Location = New System.Drawing.Point(8, 552)
		Me.DestroyerLBL.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DestroyerLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.DestroyerLBL.BackColor = FromOleColor6(CInt(&H00800000))
		Me.DestroyerLBL.Caption = "Destroyer"
		Me.DestroyerLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.DestroyerLBL.TabIndex = 24
		Me.DestroyerLBL.AutoSize = False
		'
		' SubMarineLBL
		'
		Me.SubMarineLBL.Name = "SubMarineLBL"
		Me.SubMarineLBL.Size = New System.Drawing.Size(89, 25)
		Me.SubMarineLBL.Location = New System.Drawing.Point(112, 552)
		Me.SubMarineLBL.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SubMarineLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.SubMarineLBL.BackColor = FromOleColor6(CInt(&H00800000))
		Me.SubMarineLBL.Caption = "Submarine"
		Me.SubMarineLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.SubMarineLBL.TabIndex = 23
		Me.SubMarineLBL.AutoSize = False
		'
		' CruiserLBL
		'
		Me.CruiserLBL.Name = "CruiserLBL"
		Me.CruiserLBL.Size = New System.Drawing.Size(89, 25)
		Me.CruiserLBL.Location = New System.Drawing.Point(216, 552)
		Me.CruiserLBL.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CruiserLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.CruiserLBL.BackColor = FromOleColor6(CInt(&H00800000))
		Me.CruiserLBL.Caption = "Cruiser"
		Me.CruiserLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.CruiserLBL.TabIndex = 22
		Me.CruiserLBL.AutoSize = False
		'
		' battleshipLBL
		'
		Me.battleshipLBL.Name = "battleshipLBL"
		Me.battleshipLBL.Size = New System.Drawing.Size(89, 25)
		Me.battleshipLBL.Location = New System.Drawing.Point(320, 552)
		Me.battleshipLBL.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.battleshipLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.battleshipLBL.BackColor = FromOleColor6(CInt(&H00800000))
		Me.battleshipLBL.Caption = "Battleship"
		Me.battleshipLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.battleshipLBL.TabIndex = 20
		Me.battleshipLBL.AutoSize = False
		'
		' CarrierLBL
		'
		Me.CarrierLBL.Name = "CarrierLBL"
		Me.CarrierLBL.Size = New System.Drawing.Size(89, 25)
		Me.CarrierLBL.Location = New System.Drawing.Point(424, 552)
		Me.CarrierLBL.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CarrierLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.CarrierLBL.BackColor = FromOleColor6(CInt(&H00800000))
		Me.CarrierLBL.Caption = "Carrier"
		Me.CarrierLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.CarrierLBL.TabIndex = 21
		Me.CarrierLBL.AutoSize = False
		'
		' ServerFRM
		'
		Me.Name = "ServerFRM"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Battleship"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Tag = "1"
		Me.Location = New System.Drawing.Point(11, 30)
		Me.ClientSize = New System.Drawing.Size(520, 587)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Label24)
		Me.Frame1.Controls.Add(Label23)
		Me.Frame1.Controls.Add(Label22)
		Me.Frame1.Controls.Add(Label21)
		Me.Frame1.Controls.Add(Label19)
		Me.Frame1.Controls.Add(Label18)
		Me.Frame1.Controls.Add(Label17)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Controls.Add(nopicturePIC)
		Me.Controls.Add(destroyerTXT_002)
		Me.Controls.Add(destroyerTXT_001)
		Me.Controls.Add(submarineTXT_002)
		Me.Controls.Add(submarineTXT_001)
		Me.Controls.Add(cruiserTXT_003)
		Me.Controls.Add(cruiserTXT_002)
		Me.Controls.Add(cruiserTXT_001)
		Me.Controls.Add(battleshipTXT_004)
		Me.Controls.Add(battleshipTXT_003)
		Me.Controls.Add(battleshipTXT_002)
		Me.Controls.Add(battleshipTXT_001)
		Me.Controls.Add(carrierTXT_005)
		Me.Controls.Add(carrierTXT_004)
		Me.Controls.Add(carrierTXT_003)
		Me.Controls.Add(carrierTXT_002)
		Me.Controls.Add(carrierTXT_001)
		Me.Controls.Add(hitPIC)
		Me.Controls.Add(sendTXT)
		Me.Controls.Add(sendtextCMD)
		Me.Controls.Add(Field_240)
		Me.Controls.Add(Field_239)
		Me.Controls.Add(Field_238)
		Me.Controls.Add(Field_237)
		Me.Controls.Add(Field_236)
		Me.Controls.Add(Field_235)
		Me.Controls.Add(Field_234)
		Me.Controls.Add(Field_233)
		Me.Controls.Add(Field_232)
		Me.Controls.Add(Field_231)
		Me.Controls.Add(Field_230)
		Me.Controls.Add(Field_229)
		Me.Controls.Add(Field_228)
		Me.Controls.Add(Field_227)
		Me.Controls.Add(Field_226)
		Me.Controls.Add(Field_225)
		Me.Controls.Add(Field_224)
		Me.Controls.Add(Field_223)
		Me.Controls.Add(Field_222)
		Me.Controls.Add(Field_221)
		Me.Controls.Add(Field_220)
		Me.Controls.Add(Field_219)
		Me.Controls.Add(Field_218)
		Me.Controls.Add(Field_217)
		Me.Controls.Add(Field_216)
		Me.Controls.Add(Field_215)
		Me.Controls.Add(Field_214)
		Me.Controls.Add(Field_213)
		Me.Controls.Add(Field_212)
		Me.Controls.Add(Field_211)
		Me.Controls.Add(Field_210)
		Me.Controls.Add(Field_209)
		Me.Controls.Add(Field_208)
		Me.Controls.Add(Field_207)
		Me.Controls.Add(Field_206)
		Me.Controls.Add(Field_205)
		Me.Controls.Add(Field_204)
		Me.Controls.Add(Field_203)
		Me.Controls.Add(Field_202)
		Me.Controls.Add(Field_201)
		Me.Controls.Add(Field_200)
		Me.Controls.Add(Field_199)
		Me.Controls.Add(Field_198)
		Me.Controls.Add(Field_197)
		Me.Controls.Add(Field_196)
		Me.Controls.Add(Field_195)
		Me.Controls.Add(Field_194)
		Me.Controls.Add(Field_193)
		Me.Controls.Add(Field_192)
		Me.Controls.Add(Field_191)
		Me.Controls.Add(Field_190)
		Me.Controls.Add(Field_189)
		Me.Controls.Add(Field_188)
		Me.Controls.Add(Field_187)
		Me.Controls.Add(Field_186)
		Me.Controls.Add(Field_185)
		Me.Controls.Add(Field_184)
		Me.Controls.Add(Field_183)
		Me.Controls.Add(Field_182)
		Me.Controls.Add(Field_181)
		Me.Controls.Add(Field_180)
		Me.Controls.Add(Field_179)
		Me.Controls.Add(Field_178)
		Me.Controls.Add(Field_177)
		Me.Controls.Add(Field_176)
		Me.Controls.Add(Field_175)
		Me.Controls.Add(Field_174)
		Me.Controls.Add(Field_173)
		Me.Controls.Add(Field_172)
		Me.Controls.Add(Field_171)
		Me.Controls.Add(Field_170)
		Me.Controls.Add(Field_169)
		Me.Controls.Add(Field_168)
		Me.Controls.Add(Field_167)
		Me.Controls.Add(Field_166)
		Me.Controls.Add(Field_165)
		Me.Controls.Add(Field_164)
		Me.Controls.Add(Field_163)
		Me.Controls.Add(Field_162)
		Me.Controls.Add(Field_161)
		Me.Controls.Add(Field_160)
		Me.Controls.Add(Field_159)
		Me.Controls.Add(Field_158)
		Me.Controls.Add(Field_157)
		Me.Controls.Add(Field_156)
		Me.Controls.Add(Field_155)
		Me.Controls.Add(Field_154)
		Me.Controls.Add(Field_153)
		Me.Controls.Add(Field_152)
		Me.Controls.Add(Field_151)
		Me.Controls.Add(Field_150)
		Me.Controls.Add(Field_149)
		Me.Controls.Add(Field_148)
		Me.Controls.Add(Field_147)
		Me.Controls.Add(Field_146)
		Me.Controls.Add(Field_145)
		Me.Controls.Add(Field_144)
		Me.Controls.Add(Field_143)
		Me.Controls.Add(Field_142)
		Me.Controls.Add(Field_141)
		Me.Controls.Add(Field_140)
		Me.Controls.Add(Field_139)
		Me.Controls.Add(Field_138)
		Me.Controls.Add(Field_137)
		Me.Controls.Add(Field_136)
		Me.Controls.Add(Field_135)
		Me.Controls.Add(Field_134)
		Me.Controls.Add(Field_133)
		Me.Controls.Add(Field_132)
		Me.Controls.Add(Field_131)
		Me.Controls.Add(Field_130)
		Me.Controls.Add(Field_129)
		Me.Controls.Add(Field_128)
		Me.Controls.Add(Field_127)
		Me.Controls.Add(Field_126)
		Me.Controls.Add(Field_125)
		Me.Controls.Add(Field_124)
		Me.Controls.Add(Field_123)
		Me.Controls.Add(Field_122)
		Me.Controls.Add(Field_121)
		Me.Controls.Add(Field_120)
		Me.Controls.Add(Field_119)
		Me.Controls.Add(Field_118)
		Me.Controls.Add(Field_117)
		Me.Controls.Add(Field_116)
		Me.Controls.Add(Field_115)
		Me.Controls.Add(Field_114)
		Me.Controls.Add(Field_113)
		Me.Controls.Add(Field_112)
		Me.Controls.Add(Field_111)
		Me.Controls.Add(Field_110)
		Me.Controls.Add(Field_109)
		Me.Controls.Add(Field_108)
		Me.Controls.Add(Field_107)
		Me.Controls.Add(Field_106)
		Me.Controls.Add(Field_105)
		Me.Controls.Add(Field_104)
		Me.Controls.Add(Field_103)
		Me.Controls.Add(Field_102)
		Me.Controls.Add(Field_101)
		Me.Controls.Add(Field_100)
		Me.Controls.Add(Field_099)
		Me.Controls.Add(Field_098)
		Me.Controls.Add(Field_097)
		Me.Controls.Add(Field_096)
		Me.Controls.Add(Field_095)
		Me.Controls.Add(Field_094)
		Me.Controls.Add(Field_093)
		Me.Controls.Add(Field_092)
		Me.Controls.Add(Field_091)
		Me.Controls.Add(Field_090)
		Me.Controls.Add(Field_089)
		Me.Controls.Add(Field_088)
		Me.Controls.Add(Field_087)
		Me.Controls.Add(Field_086)
		Me.Controls.Add(Field_085)
		Me.Controls.Add(Field_084)
		Me.Controls.Add(Field_083)
		Me.Controls.Add(Field_082)
		Me.Controls.Add(Field_081)
		Me.Controls.Add(Field_080)
		Me.Controls.Add(Field_079)
		Me.Controls.Add(Field_078)
		Me.Controls.Add(Field_077)
		Me.Controls.Add(Field_076)
		Me.Controls.Add(Field_075)
		Me.Controls.Add(Field_074)
		Me.Controls.Add(Field_073)
		Me.Controls.Add(Field_072)
		Me.Controls.Add(Field_071)
		Me.Controls.Add(Field_070)
		Me.Controls.Add(Field_069)
		Me.Controls.Add(Field_068)
		Me.Controls.Add(Field_067)
		Me.Controls.Add(Field_066)
		Me.Controls.Add(Field_065)
		Me.Controls.Add(Field_064)
		Me.Controls.Add(Field_063)
		Me.Controls.Add(Field_062)
		Me.Controls.Add(Field_061)
		Me.Controls.Add(Field_060)
		Me.Controls.Add(Field_059)
		Me.Controls.Add(Field_058)
		Me.Controls.Add(Field_057)
		Me.Controls.Add(Field_056)
		Me.Controls.Add(Field_055)
		Me.Controls.Add(Field_054)
		Me.Controls.Add(Field_053)
		Me.Controls.Add(Field_052)
		Me.Controls.Add(Field_051)
		Me.Controls.Add(Field_050)
		Me.Controls.Add(Field_049)
		Me.Controls.Add(Field_048)
		Me.Controls.Add(Field_047)
		Me.Controls.Add(Field_046)
		Me.Controls.Add(Field_045)
		Me.Controls.Add(Field_044)
		Me.Controls.Add(Field_043)
		Me.Controls.Add(Field_042)
		Me.Controls.Add(Field_041)
		Me.Controls.Add(Field_040)
		Me.Controls.Add(Field_039)
		Me.Controls.Add(Field_038)
		Me.Controls.Add(Field_037)
		Me.Controls.Add(Field_036)
		Me.Controls.Add(Field_035)
		Me.Controls.Add(Field_034)
		Me.Controls.Add(Field_033)
		Me.Controls.Add(Field_032)
		Me.Controls.Add(Field_031)
		Me.Controls.Add(Field_030)
		Me.Controls.Add(Field_029)
		Me.Controls.Add(Field_028)
		Me.Controls.Add(Field_027)
		Me.Controls.Add(Field_026)
		Me.Controls.Add(Field_025)
		Me.Controls.Add(Field_024)
		Me.Controls.Add(Field_023)
		Me.Controls.Add(Field_022)
		Me.Controls.Add(Field_021)
		Me.Controls.Add(Field_020)
		Me.Controls.Add(Field_019)
		Me.Controls.Add(Field_018)
		Me.Controls.Add(Field_017)
		Me.Controls.Add(Field_016)
		Me.Controls.Add(Field_015)
		Me.Controls.Add(Field_014)
		Me.Controls.Add(Field_013)
		Me.Controls.Add(Field_012)
		Me.Controls.Add(Field_011)
		Me.Controls.Add(Field_010)
		Me.Controls.Add(Field_009)
		Me.Controls.Add(Field_008)
		Me.Controls.Add(Field_007)
		Me.Controls.Add(Field_006)
		Me.Controls.Add(Field_005)
		Me.Controls.Add(Field_004)
		Me.Controls.Add(Field_003)
		Me.Controls.Add(Field_002)
		Me.Controls.Add(Field_001)
		Me.Controls.Add(statsFRA)
		Me.statsFRA.Controls.Add(GameStatsLBL)
		Me.Controls.Add(MainTXT)
		Me.Controls.Add(nickSERVER)
		Me.Controls.Add(nickCLIENT)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label30)
		Me.Controls.Add(Label29)
		Me.Controls.Add(Label28)
		Me.Controls.Add(Label27)
		Me.Controls.Add(Label26)
		Me.Controls.Add(Label15)
		Me.Controls.Add(Label14)
		Me.Controls.Add(Label13)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label20)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(MYcarrierLBL_001)
		Me.Controls.Add(MYcarrierLBL_002)
		Me.Controls.Add(MYcarrierLBL_003)
		Me.Controls.Add(MYcarrierLBL_004)
		Me.Controls.Add(MYcarrierLBL_005)
		Me.Controls.Add(MYbattleshipLBL_001)
		Me.Controls.Add(MYbattleshipLBL_002)
		Me.Controls.Add(MYbattleshipLBL_003)
		Me.Controls.Add(MYbattleshipLBL_004)
		Me.Controls.Add(MYcruiserLBL_003)
		Me.Controls.Add(MYcruiserLBL_002)
		Me.Controls.Add(MYcruiserLBL_001)
		Me.Controls.Add(MYsubmarineLBL_001)
		Me.Controls.Add(MYsubmarineLBL_002)
		Me.Controls.Add(MYdestroyerLBL_001)
		Me.Controls.Add(MYdestroyerLBL_002)
		Me.Controls.Add(DestroyerLBL)
		Me.Controls.Add(SubMarineLBL)
		Me.Controls.Add(CruiserLBL)
		Me.Controls.Add(battleshipLBL)
		Me.Controls.Add(CarrierLBL)
		CType(Me.Line31, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line30, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line29, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line28, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line27, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line26, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line25, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line18, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_019, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_018, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_017, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_016, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_015, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_014, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_013, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_012, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_011, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_009, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.labelBgLNE_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.statsFRA.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbAngleDrive = New System.Windows.Forms.GroupBox()
        Me.flpAngleDriveSelect = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbAngleAbsolute = New System.Windows.Forms.RadioButton()
        Me.rbAngleRelative = New System.Windows.Forms.RadioButton()
        Me.tlpAngleDrive = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMes041 = New System.Windows.Forms.Label()
        Me.lblMes042 = New System.Windows.Forms.Label()
        Me.nudAngleDriveEL = New System.Windows.Forms.NumericUpDown()
        Me.nudAngleDriveAZ = New System.Windows.Forms.NumericUpDown()
        Me.btnAngleDrive = New System.Windows.Forms.Button()
        Me.gbRotatorControll = New System.Windows.Forms.GroupBox()
        Me.tcRotatorControll = New System.Windows.Forms.TabControl()
        Me.tpAuto = New System.Windows.Forms.TabPage()
        Me.gbBalloonPred = New System.Windows.Forms.GroupBox()
        Me.cbxEnableBalloonPred = New System.Windows.Forms.CheckBox()
        Me.gbErrorModify = New System.Windows.Forms.GroupBox()
        Me.btnResetErrorValues = New System.Windows.Forms.Button()
        Me.tlpErrorModify = New System.Windows.Forms.TableLayoutPanel()
        Me.nudErrorTime = New System.Windows.Forms.NumericUpDown()
        Me.lblMes021 = New System.Windows.Forms.Label()
        Me.lblMes022 = New System.Windows.Forms.Label()
        Me.nudErrorEL = New System.Windows.Forms.NumericUpDown()
        Me.nudErrorAZ = New System.Windows.Forms.NumericUpDown()
        Me.lblMes023 = New System.Windows.Forms.Label()
        Me.cbxEditErrorModify = New System.Windows.Forms.CheckBox()
        Me.btnRotatorStopA = New System.Windows.Forms.Button()
        Me.gbPresentLocationSet = New System.Windows.Forms.GroupBox()
        Me.btnPresentLocationConvert = New System.Windows.Forms.Button()
        Me.tbxPresentNmea = New System.Windows.Forms.TextBox()
        Me.cbxEditPresentLocate = New System.Windows.Forms.CheckBox()
        Me.tlpPresentLocate = New System.Windows.Forms.TableLayoutPanel()
        Me.nudPresentLat = New System.Windows.Forms.NumericUpDown()
        Me.lblMes011 = New System.Windows.Forms.Label()
        Me.lblMes012 = New System.Windows.Forms.Label()
        Me.nudPresentLon = New System.Windows.Forms.NumericUpDown()
        Me.nudPresentAlt = New System.Windows.Forms.NumericUpDown()
        Me.lblMes013 = New System.Windows.Forms.Label()
        Me.cbxToggleAutoMode = New System.Windows.Forms.CheckBox()
        Me.tpManual = New System.Windows.Forms.TabPage()
        Me.btnRotatorStopM = New System.Windows.Forms.Button()
        Me.gbDirectDrive = New System.Windows.Forms.GroupBox()
        Me.tlpDirectDrive = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDirectDriveUp = New System.Windows.Forms.Button()
        Me.btnDirectDriveDown = New System.Windows.Forms.Button()
        Me.btnDirectDriveRight = New System.Windows.Forms.Button()
        Me.btnDirectDriveLeft = New System.Windows.Forms.Button()
        Me.gbBalloonLocationDrive = New System.Windows.Forms.GroupBox()
        Me.lblMes054 = New System.Windows.Forms.Label()
        Me.tlpBalloonLocateDrive = New System.Windows.Forms.TableLayoutPanel()
        Me.nudBalloonLocateDriveLat = New System.Windows.Forms.NumericUpDown()
        Me.lblMes051 = New System.Windows.Forms.Label()
        Me.lblMes052 = New System.Windows.Forms.Label()
        Me.nudBalloonLocateDriveLon = New System.Windows.Forms.NumericUpDown()
        Me.nudBalloonLocateDriveAlt = New System.Windows.Forms.NumericUpDown()
        Me.lblMes053 = New System.Windows.Forms.Label()
        Me.btnBalloonLocateDrive = New System.Windows.Forms.Button()
        Me.tmrClockUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiBalloonMapEnable = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiKmlEnable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiOpenLogFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAntenna = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveAntennaFirstPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveAntennaOriginPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslPowerState = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbBatteryLife = New System.Windows.Forms.ToolStripProgressBar()
        Me.gbSerialPort = New System.Windows.Forms.GroupBox()
        Me.tlpSerialPort = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMes101 = New System.Windows.Forms.Label()
        Me.cmbRotatorPortList = New System.Windows.Forms.ComboBox()
        Me.lblMes102 = New System.Windows.Forms.Label()
        Me.lblMes103 = New System.Windows.Forms.Label()
        Me.btnGpsOpen = New System.Windows.Forms.Button()
        Me.btnRotatorOpen = New System.Windows.Forms.Button()
        Me.nudGpsTcpPort = New System.Windows.Forms.NumericUpDown()
        Me.gbPresentValue = New System.Windows.Forms.GroupBox()
        Me.gbNowTime = New System.Windows.Forms.GroupBox()
        Me.lblNowTime = New System.Windows.Forms.Label()
        Me.gbLastGps = New System.Windows.Forms.GroupBox()
        Me.btnGpsAngleDrive = New System.Windows.Forms.Button()
        Me.tlpAZELbyGPS = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMes220 = New System.Windows.Forms.Label()
        Me.lblMes221 = New System.Windows.Forms.Label()
        Me.tbxCalcedEL = New System.Windows.Forms.TextBox()
        Me.tbxCalcedAZ = New System.Windows.Forms.TextBox()
        Me.tbxLastGpsGetTime = New System.Windows.Forms.TextBox()
        Me.lblMes210 = New System.Windows.Forms.Label()
        Me.tlpPresentGps = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMes211 = New System.Windows.Forms.Label()
        Me.lblMes212 = New System.Windows.Forms.Label()
        Me.lblMes213 = New System.Windows.Forms.Label()
        Me.tbxLastLat = New System.Windows.Forms.TextBox()
        Me.tbxLastLon = New System.Windows.Forms.TextBox()
        Me.tbxLastAlt = New System.Windows.Forms.TextBox()
        Me.gbPresentRotator = New System.Windows.Forms.GroupBox()
        Me.tlpPresentRotator = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxPresentAZ = New System.Windows.Forms.TextBox()
        Me.tbxPresentEL = New System.Windows.Forms.TextBox()
        Me.tbxSetEL = New System.Windows.Forms.TextBox()
        Me.lblMes203 = New System.Windows.Forms.Label()
        Me.lblMes204 = New System.Windows.Forms.Label()
        Me.lblMes202 = New System.Windows.Forms.Label()
        Me.lblMes201 = New System.Windows.Forms.Label()
        Me.tbxSetAZ = New System.Windows.Forms.TextBox()
        Me.lblMes205 = New System.Windows.Forms.Label()
        Me.tbxMoveTimeEL = New System.Windows.Forms.TextBox()
        Me.tbxMoveTimeAZ = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrRotater = New System.Windows.Forms.Timer(Me.components)
        Me.gbLogs = New System.Windows.Forms.GroupBox()
        Me.lblMes302 = New System.Windows.Forms.Label()
        Me.lblMes301 = New System.Windows.Forms.Label()
        Me.lblMes300 = New System.Windows.Forms.Label()
        Me.tbxSystemLog = New System.Windows.Forms.TextBox()
        Me.tbxSerialLog = New System.Windows.Forms.TextBox()
        Me.tbxTcpLog = New System.Windows.Forms.TextBox()
        Me.gbMap = New System.Windows.Forms.GroupBox()
        Me.cmsBalloonMap = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiMapElementClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMapReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.wbBalloonMap = New System.Windows.Forms.WebBrowser()
        Me.tmrPredictDrive = New System.Windows.Forms.Timer(Me.components)
        Me.gbAngleDrive.SuspendLayout()
        Me.flpAngleDriveSelect.SuspendLayout()
        Me.tlpAngleDrive.SuspendLayout()
        CType(Me.nudAngleDriveEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngleDriveAZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRotatorControll.SuspendLayout()
        Me.tcRotatorControll.SuspendLayout()
        Me.tpAuto.SuspendLayout()
        Me.gbBalloonPred.SuspendLayout()
        Me.gbErrorModify.SuspendLayout()
        Me.tlpErrorModify.SuspendLayout()
        CType(Me.nudErrorTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudErrorEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudErrorAZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPresentLocationSet.SuspendLayout()
        Me.tlpPresentLocate.SuspendLayout()
        CType(Me.nudPresentLat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPresentLon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPresentAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManual.SuspendLayout()
        Me.gbDirectDrive.SuspendLayout()
        Me.tlpDirectDrive.SuspendLayout()
        Me.gbBalloonLocationDrive.SuspendLayout()
        Me.tlpBalloonLocateDrive.SuspendLayout()
        CType(Me.nudBalloonLocateDriveLat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBalloonLocateDriveLon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBalloonLocateDriveAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbSerialPort.SuspendLayout()
        Me.tlpSerialPort.SuspendLayout()
        CType(Me.nudGpsTcpPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPresentValue.SuspendLayout()
        Me.gbNowTime.SuspendLayout()
        Me.gbLastGps.SuspendLayout()
        Me.tlpAZELbyGPS.SuspendLayout()
        Me.tlpPresentGps.SuspendLayout()
        Me.gbPresentRotator.SuspendLayout()
        Me.tlpPresentRotator.SuspendLayout()
        Me.gbLogs.SuspendLayout()
        Me.gbMap.SuspendLayout()
        Me.cmsBalloonMap.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAngleDrive
        '
        Me.gbAngleDrive.Controls.Add(Me.flpAngleDriveSelect)
        Me.gbAngleDrive.Controls.Add(Me.tlpAngleDrive)
        Me.gbAngleDrive.Controls.Add(Me.btnAngleDrive)
        Me.gbAngleDrive.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.gbAngleDrive.Location = New System.Drawing.Point(13, 7)
        Me.gbAngleDrive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbAngleDrive.Name = "gbAngleDrive"
        Me.gbAngleDrive.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbAngleDrive.Size = New System.Drawing.Size(364, 145)
        Me.gbAngleDrive.TabIndex = 0
        Me.gbAngleDrive.TabStop = False
        Me.gbAngleDrive.Text = "角度指定"
        '
        'flpAngleDriveSelect
        '
        Me.flpAngleDriveSelect.Controls.Add(Me.rbAngleAbsolute)
        Me.flpAngleDriveSelect.Controls.Add(Me.rbAngleRelative)
        Me.flpAngleDriveSelect.Location = New System.Drawing.Point(22, 24)
        Me.flpAngleDriveSelect.Name = "flpAngleDriveSelect"
        Me.flpAngleDriveSelect.Size = New System.Drawing.Size(192, 32)
        Me.flpAngleDriveSelect.TabIndex = 2
        '
        'rbAngleAbsolute
        '
        Me.rbAngleAbsolute.AutoSize = True
        Me.rbAngleAbsolute.Checked = True
        Me.rbAngleAbsolute.Location = New System.Drawing.Point(3, 3)
        Me.rbAngleAbsolute.Name = "rbAngleAbsolute"
        Me.rbAngleAbsolute.Size = New System.Drawing.Size(82, 22)
        Me.rbAngleAbsolute.TabIndex = 0
        Me.rbAngleAbsolute.TabStop = True
        Me.rbAngleAbsolute.Text = "絶対移動"
        Me.ToolTip1.SetToolTip(Me.rbAngleAbsolute, "設定した仰角・方位角に絶対移動を行うモード")
        Me.rbAngleAbsolute.UseVisualStyleBackColor = True
        '
        'rbAngleRelative
        '
        Me.rbAngleRelative.AutoSize = True
        Me.rbAngleRelative.Location = New System.Drawing.Point(91, 3)
        Me.rbAngleRelative.Name = "rbAngleRelative"
        Me.rbAngleRelative.Size = New System.Drawing.Size(82, 22)
        Me.rbAngleRelative.TabIndex = 1
        Me.rbAngleRelative.Text = "相対移動"
        Me.ToolTip1.SetToolTip(Me.rbAngleRelative, "現在の仰角・方位角から相対移動を行うモード")
        Me.rbAngleRelative.UseVisualStyleBackColor = True
        '
        'tlpAngleDrive
        '
        Me.tlpAngleDrive.ColumnCount = 2
        Me.tlpAngleDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAngleDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAngleDrive.Controls.Add(Me.lblMes041, 0, 0)
        Me.tlpAngleDrive.Controls.Add(Me.lblMes042, 1, 0)
        Me.tlpAngleDrive.Controls.Add(Me.nudAngleDriveEL, 0, 1)
        Me.tlpAngleDrive.Controls.Add(Me.nudAngleDriveAZ, 1, 1)
        Me.tlpAngleDrive.Location = New System.Drawing.Point(22, 62)
        Me.tlpAngleDrive.Name = "tlpAngleDrive"
        Me.tlpAngleDrive.RowCount = 2
        Me.tlpAngleDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpAngleDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpAngleDrive.Size = New System.Drawing.Size(218, 65)
        Me.tlpAngleDrive.TabIndex = 0
        '
        'lblMes041
        '
        Me.lblMes041.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes041.AutoSize = True
        Me.lblMes041.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes041.Location = New System.Drawing.Point(34, 3)
        Me.lblMes041.Name = "lblMes041"
        Me.lblMes041.Size = New System.Drawing.Size(41, 20)
        Me.lblMes041.TabIndex = 0
        Me.lblMes041.Text = "仰角"
        '
        'lblMes042
        '
        Me.lblMes042.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes042.AutoSize = True
        Me.lblMes042.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes042.Location = New System.Drawing.Point(135, 3)
        Me.lblMes042.Name = "lblMes042"
        Me.lblMes042.Size = New System.Drawing.Size(57, 20)
        Me.lblMes042.TabIndex = 2
        Me.lblMes042.Text = "方位角"
        '
        'nudAngleDriveEL
        '
        Me.nudAngleDriveEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudAngleDriveEL.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudAngleDriveEL.Location = New System.Drawing.Point(4, 31)
        Me.nudAngleDriveEL.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudAngleDriveEL.Name = "nudAngleDriveEL"
        Me.nudAngleDriveEL.Size = New System.Drawing.Size(100, 28)
        Me.nudAngleDriveEL.TabIndex = 1
        Me.nudAngleDriveEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudAngleDriveEL.Value = New Decimal(New Integer() {256, 0, 0, 65536})
        '
        'nudAngleDriveAZ
        '
        Me.nudAngleDriveAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudAngleDriveAZ.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudAngleDriveAZ.Location = New System.Drawing.Point(113, 31)
        Me.nudAngleDriveAZ.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudAngleDriveAZ.Name = "nudAngleDriveAZ"
        Me.nudAngleDriveAZ.Size = New System.Drawing.Size(100, 28)
        Me.nudAngleDriveAZ.TabIndex = 3
        Me.nudAngleDriveAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudAngleDriveAZ.Value = New Decimal(New Integer() {1234, 0, 0, 65536})
        '
        'btnAngleDrive
        '
        Me.btnAngleDrive.Location = New System.Drawing.Point(274, 97)
        Me.btnAngleDrive.Name = "btnAngleDrive"
        Me.btnAngleDrive.Size = New System.Drawing.Size(71, 30)
        Me.btnAngleDrive.TabIndex = 1
        Me.btnAngleDrive.Text = "移動"
        Me.ToolTip1.SetToolTip(Me.btnAngleDrive, "角度指定移動の実行")
        Me.btnAngleDrive.UseVisualStyleBackColor = True
        '
        'gbRotatorControll
        '
        Me.gbRotatorControll.Controls.Add(Me.tcRotatorControll)
        Me.gbRotatorControll.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.gbRotatorControll.Location = New System.Drawing.Point(15, 36)
        Me.gbRotatorControll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbRotatorControll.Name = "gbRotatorControll"
        Me.gbRotatorControll.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbRotatorControll.Size = New System.Drawing.Size(449, 667)
        Me.gbRotatorControll.TabIndex = 1
        Me.gbRotatorControll.TabStop = False
        Me.gbRotatorControll.Text = "ローテータ制御"
        '
        'tcRotatorControll
        '
        Me.tcRotatorControll.Controls.Add(Me.tpAuto)
        Me.tcRotatorControll.Controls.Add(Me.tpManual)
        Me.tcRotatorControll.Location = New System.Drawing.Point(18, 24)
        Me.tcRotatorControll.Name = "tcRotatorControll"
        Me.tcRotatorControll.SelectedIndex = 0
        Me.tcRotatorControll.Size = New System.Drawing.Size(411, 624)
        Me.tcRotatorControll.TabIndex = 0
        '
        'tpAuto
        '
        Me.tpAuto.Controls.Add(Me.gbBalloonPred)
        Me.tpAuto.Controls.Add(Me.gbErrorModify)
        Me.tpAuto.Controls.Add(Me.btnRotatorStopA)
        Me.tpAuto.Controls.Add(Me.gbPresentLocationSet)
        Me.tpAuto.Controls.Add(Me.cbxToggleAutoMode)
        Me.tpAuto.Location = New System.Drawing.Point(4, 26)
        Me.tpAuto.Name = "tpAuto"
        Me.tpAuto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAuto.Size = New System.Drawing.Size(403, 594)
        Me.tpAuto.TabIndex = 0
        Me.tpAuto.Text = "自動制御"
        Me.tpAuto.UseVisualStyleBackColor = True
        '
        'gbBalloonPred
        '
        Me.gbBalloonPred.Controls.Add(Me.cbxEnableBalloonPred)
        Me.gbBalloonPred.Location = New System.Drawing.Point(20, 403)
        Me.gbBalloonPred.Name = "gbBalloonPred"
        Me.gbBalloonPred.Size = New System.Drawing.Size(364, 54)
        Me.gbBalloonPred.TabIndex = 3
        Me.gbBalloonPred.TabStop = False
        Me.gbBalloonPred.Text = "バルーン位置予測"
        '
        'cbxEnableBalloonPred
        '
        Me.cbxEnableBalloonPred.AutoSize = True
        Me.cbxEnableBalloonPred.Location = New System.Drawing.Point(19, 23)
        Me.cbxEnableBalloonPred.Name = "cbxEnableBalloonPred"
        Me.cbxEnableBalloonPred.Size = New System.Drawing.Size(55, 22)
        Me.cbxEnableBalloonPred.TabIndex = 0
        Me.cbxEnableBalloonPred.Text = "有効"
        Me.ToolTip1.SetToolTip(Me.cbxEnableBalloonPred, "バルーンの現在地位置予測の有効無効の切り替え")
        Me.cbxEnableBalloonPred.UseVisualStyleBackColor = True
        '
        'gbErrorModify
        '
        Me.gbErrorModify.Controls.Add(Me.btnResetErrorValues)
        Me.gbErrorModify.Controls.Add(Me.tlpErrorModify)
        Me.gbErrorModify.Controls.Add(Me.cbxEditErrorModify)
        Me.gbErrorModify.Location = New System.Drawing.Point(20, 265)
        Me.gbErrorModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbErrorModify.Name = "gbErrorModify"
        Me.gbErrorModify.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbErrorModify.Size = New System.Drawing.Size(364, 131)
        Me.gbErrorModify.TabIndex = 2
        Me.gbErrorModify.TabStop = False
        Me.gbErrorModify.Text = "誤差修正"
        '
        'btnResetErrorValues
        '
        Me.btnResetErrorValues.Enabled = False
        Me.btnResetErrorValues.Location = New System.Drawing.Point(266, 21)
        Me.btnResetErrorValues.Name = "btnResetErrorValues"
        Me.btnResetErrorValues.Size = New System.Drawing.Size(75, 26)
        Me.btnResetErrorValues.TabIndex = 2
        Me.btnResetErrorValues.Text = "リセット"
        Me.btnResetErrorValues.UseVisualStyleBackColor = True
        '
        'tlpErrorModify
        '
        Me.tlpErrorModify.ColumnCount = 3
        Me.tlpErrorModify.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpErrorModify.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpErrorModify.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpErrorModify.Controls.Add(Me.nudErrorTime, 2, 1)
        Me.tlpErrorModify.Controls.Add(Me.lblMes021, 0, 0)
        Me.tlpErrorModify.Controls.Add(Me.lblMes022, 1, 0)
        Me.tlpErrorModify.Controls.Add(Me.nudErrorEL, 0, 1)
        Me.tlpErrorModify.Controls.Add(Me.nudErrorAZ, 1, 1)
        Me.tlpErrorModify.Controls.Add(Me.lblMes023, 2, 0)
        Me.tlpErrorModify.Enabled = False
        Me.tlpErrorModify.Location = New System.Drawing.Point(19, 50)
        Me.tlpErrorModify.Name = "tlpErrorModify"
        Me.tlpErrorModify.RowCount = 2
        Me.tlpErrorModify.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpErrorModify.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpErrorModify.Size = New System.Drawing.Size(327, 65)
        Me.tlpErrorModify.TabIndex = 1
        '
        'nudErrorTime
        '
        Me.nudErrorTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudErrorTime.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudErrorTime.Location = New System.Drawing.Point(222, 31)
        Me.nudErrorTime.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudErrorTime.Minimum = New Decimal(New Integer() {60, 0, 0, -2147483648})
        Me.nudErrorTime.Name = "nudErrorTime"
        Me.nudErrorTime.Size = New System.Drawing.Size(100, 28)
        Me.nudErrorTime.TabIndex = 5
        Me.nudErrorTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMes021
        '
        Me.lblMes021.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes021.AutoSize = True
        Me.lblMes021.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes021.Location = New System.Drawing.Point(34, 3)
        Me.lblMes021.Name = "lblMes021"
        Me.lblMes021.Size = New System.Drawing.Size(41, 20)
        Me.lblMes021.TabIndex = 0
        Me.lblMes021.Text = "仰角"
        '
        'lblMes022
        '
        Me.lblMes022.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes022.AutoSize = True
        Me.lblMes022.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes022.Location = New System.Drawing.Point(135, 3)
        Me.lblMes022.Name = "lblMes022"
        Me.lblMes022.Size = New System.Drawing.Size(57, 20)
        Me.lblMes022.TabIndex = 2
        Me.lblMes022.Text = "方位角"
        '
        'nudErrorEL
        '
        Me.nudErrorEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudErrorEL.DecimalPlaces = 1
        Me.nudErrorEL.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudErrorEL.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudErrorEL.Location = New System.Drawing.Point(4, 31)
        Me.nudErrorEL.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudErrorEL.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.nudErrorEL.Name = "nudErrorEL"
        Me.nudErrorEL.Size = New System.Drawing.Size(100, 28)
        Me.nudErrorEL.TabIndex = 1
        Me.nudErrorEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudErrorAZ
        '
        Me.nudErrorAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudErrorAZ.DecimalPlaces = 1
        Me.nudErrorAZ.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudErrorAZ.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudErrorAZ.Location = New System.Drawing.Point(113, 31)
        Me.nudErrorAZ.Maximum = New Decimal(New Integer() {359, 0, 0, 0})
        Me.nudErrorAZ.Minimum = New Decimal(New Integer() {359, 0, 0, -2147483648})
        Me.nudErrorAZ.Name = "nudErrorAZ"
        Me.nudErrorAZ.Size = New System.Drawing.Size(100, 28)
        Me.nudErrorAZ.TabIndex = 3
        Me.nudErrorAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMes023
        '
        Me.lblMes023.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes023.AutoSize = True
        Me.lblMes023.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes023.Location = New System.Drawing.Point(221, 3)
        Me.lblMes023.Name = "lblMes023"
        Me.lblMes023.Size = New System.Drawing.Size(103, 20)
        Me.lblMes023.TabIndex = 4
        Me.lblMes023.Text = "GPS時刻(秒)"
        '
        'cbxEditErrorModify
        '
        Me.cbxEditErrorModify.AutoSize = True
        Me.cbxEditErrorModify.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.cbxEditErrorModify.Image = Global.BalloonSystem.My.Resources.Resources.EditLabel
        Me.cbxEditErrorModify.Location = New System.Drawing.Point(19, 25)
        Me.cbxEditErrorModify.Name = "cbxEditErrorModify"
        Me.cbxEditErrorModify.Size = New System.Drawing.Size(66, 19)
        Me.cbxEditErrorModify.TabIndex = 0
        Me.cbxEditErrorModify.Text = "編集"
        Me.cbxEditErrorModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cbxEditErrorModify, "GPSデータの誤差修正値編集を有効化" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "チェックを外すと反映されます．")
        Me.cbxEditErrorModify.UseVisualStyleBackColor = True
        '
        'btnRotatorStopA
        '
        Me.btnRotatorStopA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRotatorStopA.BackColor = System.Drawing.Color.Red
        Me.btnRotatorStopA.Font = New System.Drawing.Font("Meiryo UI", 18.0!)
        Me.btnRotatorStopA.ForeColor = System.Drawing.Color.White
        Me.btnRotatorStopA.Location = New System.Drawing.Point(260, 525)
        Me.btnRotatorStopA.Name = "btnRotatorStopA"
        Me.btnRotatorStopA.Size = New System.Drawing.Size(122, 53)
        Me.btnRotatorStopA.TabIndex = 4
        Me.btnRotatorStopA.Text = "緊急停止"
        Me.ToolTip1.SetToolTip(Me.btnRotatorStopA, "ローテータの緊急停止")
        Me.btnRotatorStopA.UseVisualStyleBackColor = False
        '
        'gbPresentLocationSet
        '
        Me.gbPresentLocationSet.Controls.Add(Me.btnPresentLocationConvert)
        Me.gbPresentLocationSet.Controls.Add(Me.tbxPresentNmea)
        Me.gbPresentLocationSet.Controls.Add(Me.cbxEditPresentLocate)
        Me.gbPresentLocationSet.Controls.Add(Me.tlpPresentLocate)
        Me.gbPresentLocationSet.Location = New System.Drawing.Point(20, 88)
        Me.gbPresentLocationSet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbPresentLocationSet.Name = "gbPresentLocationSet"
        Me.gbPresentLocationSet.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbPresentLocationSet.Size = New System.Drawing.Size(364, 169)
        Me.gbPresentLocationSet.TabIndex = 1
        Me.gbPresentLocationSet.TabStop = False
        Me.gbPresentLocationSet.Text = "現在地設定(WGS-84)"
        '
        'btnPresentLocationConvert
        '
        Me.btnPresentLocationConvert.Enabled = False
        Me.btnPresentLocationConvert.Location = New System.Drawing.Point(271, 124)
        Me.btnPresentLocationConvert.Name = "btnPresentLocationConvert"
        Me.btnPresentLocationConvert.Size = New System.Drawing.Size(75, 26)
        Me.btnPresentLocationConvert.TabIndex = 3
        Me.btnPresentLocationConvert.Text = "↑変換"
        Me.btnPresentLocationConvert.UseVisualStyleBackColor = True
        '
        'tbxPresentNmea
        '
        Me.tbxPresentNmea.Enabled = False
        Me.tbxPresentNmea.Location = New System.Drawing.Point(19, 126)
        Me.tbxPresentNmea.Name = "tbxPresentNmea"
        Me.tbxPresentNmea.Size = New System.Drawing.Size(247, 24)
        Me.tbxPresentNmea.TabIndex = 2
        '
        'cbxEditPresentLocate
        '
        Me.cbxEditPresentLocate.AutoSize = True
        Me.cbxEditPresentLocate.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.cbxEditPresentLocate.Image = Global.BalloonSystem.My.Resources.Resources.EditLabel
        Me.cbxEditPresentLocate.Location = New System.Drawing.Point(19, 25)
        Me.cbxEditPresentLocate.Name = "cbxEditPresentLocate"
        Me.cbxEditPresentLocate.Size = New System.Drawing.Size(66, 19)
        Me.cbxEditPresentLocate.TabIndex = 0
        Me.cbxEditPresentLocate.Text = "編集"
        Me.cbxEditPresentLocate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cbxEditPresentLocate, "現在地設定を有効化" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "チェックを外すと反映されます．")
        Me.cbxEditPresentLocate.UseVisualStyleBackColor = True
        '
        'tlpPresentLocate
        '
        Me.tlpPresentLocate.ColumnCount = 3
        Me.tlpPresentLocate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentLocate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentLocate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentLocate.Controls.Add(Me.nudPresentLat, 0, 1)
        Me.tlpPresentLocate.Controls.Add(Me.lblMes011, 0, 0)
        Me.tlpPresentLocate.Controls.Add(Me.lblMes012, 1, 0)
        Me.tlpPresentLocate.Controls.Add(Me.nudPresentLon, 0, 1)
        Me.tlpPresentLocate.Controls.Add(Me.nudPresentAlt, 1, 1)
        Me.tlpPresentLocate.Controls.Add(Me.lblMes013, 2, 0)
        Me.tlpPresentLocate.Enabled = False
        Me.tlpPresentLocate.Location = New System.Drawing.Point(19, 52)
        Me.tlpPresentLocate.Name = "tlpPresentLocate"
        Me.tlpPresentLocate.RowCount = 2
        Me.tlpPresentLocate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPresentLocate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpPresentLocate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPresentLocate.Size = New System.Drawing.Size(327, 65)
        Me.tlpPresentLocate.TabIndex = 1
        '
        'nudPresentLat
        '
        Me.nudPresentLat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudPresentLat.DecimalPlaces = 4
        Me.nudPresentLat.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudPresentLat.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudPresentLat.Location = New System.Drawing.Point(4, 31)
        Me.nudPresentLat.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudPresentLat.Name = "nudPresentLat"
        Me.nudPresentLat.Size = New System.Drawing.Size(100, 28)
        Me.nudPresentLat.TabIndex = 1
        Me.nudPresentLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPresentLat.Value = New Decimal(New Integer() {351234, 0, 0, 262144})
        '
        'lblMes011
        '
        Me.lblMes011.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes011.AutoSize = True
        Me.lblMes011.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes011.Location = New System.Drawing.Point(34, 3)
        Me.lblMes011.Name = "lblMes011"
        Me.lblMes011.Size = New System.Drawing.Size(41, 20)
        Me.lblMes011.TabIndex = 0
        Me.lblMes011.Text = "緯度"
        '
        'lblMes012
        '
        Me.lblMes012.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes012.AutoSize = True
        Me.lblMes012.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes012.Location = New System.Drawing.Point(143, 3)
        Me.lblMes012.Name = "lblMes012"
        Me.lblMes012.Size = New System.Drawing.Size(41, 20)
        Me.lblMes012.TabIndex = 2
        Me.lblMes012.Text = "経度"
        '
        'nudPresentLon
        '
        Me.nudPresentLon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudPresentLon.DecimalPlaces = 4
        Me.nudPresentLon.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudPresentLon.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudPresentLon.Location = New System.Drawing.Point(113, 31)
        Me.nudPresentLon.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudPresentLon.Name = "nudPresentLon"
        Me.nudPresentLon.Size = New System.Drawing.Size(100, 28)
        Me.nudPresentLon.TabIndex = 3
        Me.nudPresentLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPresentLon.Value = New Decimal(New Integer() {1351234, 0, 0, 262144})
        '
        'nudPresentAlt
        '
        Me.nudPresentAlt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudPresentAlt.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudPresentAlt.Location = New System.Drawing.Point(222, 31)
        Me.nudPresentAlt.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.nudPresentAlt.Name = "nudPresentAlt"
        Me.nudPresentAlt.Size = New System.Drawing.Size(100, 28)
        Me.nudPresentAlt.TabIndex = 5
        Me.nudPresentAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPresentAlt.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'lblMes013
        '
        Me.lblMes013.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes013.AutoSize = True
        Me.lblMes013.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes013.Location = New System.Drawing.Point(252, 3)
        Me.lblMes013.Name = "lblMes013"
        Me.lblMes013.Size = New System.Drawing.Size(41, 20)
        Me.lblMes013.TabIndex = 4
        Me.lblMes013.Text = "高度"
        '
        'cbxToggleAutoMode
        '
        Me.cbxToggleAutoMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbxToggleAutoMode.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.cbxToggleAutoMode.Location = New System.Drawing.Point(20, 19)
        Me.cbxToggleAutoMode.Name = "cbxToggleAutoMode"
        Me.cbxToggleAutoMode.Size = New System.Drawing.Size(364, 62)
        Me.cbxToggleAutoMode.TabIndex = 0
        Me.cbxToggleAutoMode.Text = "自動追尾ON"
        Me.cbxToggleAutoMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cbxToggleAutoMode, "自動追尾の有効・無効の切り替え")
        Me.cbxToggleAutoMode.UseVisualStyleBackColor = True
        '
        'tpManual
        '
        Me.tpManual.Controls.Add(Me.btnRotatorStopM)
        Me.tpManual.Controls.Add(Me.gbDirectDrive)
        Me.tpManual.Controls.Add(Me.gbBalloonLocationDrive)
        Me.tpManual.Controls.Add(Me.gbAngleDrive)
        Me.tpManual.Location = New System.Drawing.Point(4, 26)
        Me.tpManual.Name = "tpManual"
        Me.tpManual.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManual.Size = New System.Drawing.Size(403, 594)
        Me.tpManual.TabIndex = 1
        Me.tpManual.Text = "手動制御"
        Me.tpManual.UseVisualStyleBackColor = True
        '
        'btnRotatorStopM
        '
        Me.btnRotatorStopM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRotatorStopM.BackColor = System.Drawing.Color.Red
        Me.btnRotatorStopM.Font = New System.Drawing.Font("Meiryo UI", 18.0!)
        Me.btnRotatorStopM.ForeColor = System.Drawing.Color.White
        Me.btnRotatorStopM.Location = New System.Drawing.Point(260, 525)
        Me.btnRotatorStopM.Name = "btnRotatorStopM"
        Me.btnRotatorStopM.Size = New System.Drawing.Size(122, 53)
        Me.btnRotatorStopM.TabIndex = 3
        Me.btnRotatorStopM.Text = "緊急停止"
        Me.ToolTip1.SetToolTip(Me.btnRotatorStopM, "ローテータの緊急停止")
        Me.btnRotatorStopM.UseVisualStyleBackColor = False
        '
        'gbDirectDrive
        '
        Me.gbDirectDrive.Controls.Add(Me.tlpDirectDrive)
        Me.gbDirectDrive.Location = New System.Drawing.Point(13, 305)
        Me.gbDirectDrive.Name = "gbDirectDrive"
        Me.gbDirectDrive.Size = New System.Drawing.Size(231, 221)
        Me.gbDirectDrive.TabIndex = 2
        Me.gbDirectDrive.TabStop = False
        Me.gbDirectDrive.Text = "直接制御"
        '
        'tlpDirectDrive
        '
        Me.tlpDirectDrive.ColumnCount = 3
        Me.tlpDirectDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.Controls.Add(Me.btnDirectDriveUp, 1, 0)
        Me.tlpDirectDrive.Controls.Add(Me.btnDirectDriveDown, 1, 2)
        Me.tlpDirectDrive.Controls.Add(Me.btnDirectDriveRight, 2, 1)
        Me.tlpDirectDrive.Controls.Add(Me.btnDirectDriveLeft, 0, 1)
        Me.tlpDirectDrive.Location = New System.Drawing.Point(32, 38)
        Me.tlpDirectDrive.Name = "tlpDirectDrive"
        Me.tlpDirectDrive.RowCount = 3
        Me.tlpDirectDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDirectDrive.Size = New System.Drawing.Size(170, 170)
        Me.tlpDirectDrive.TabIndex = 0
        '
        'btnDirectDriveUp
        '
        Me.btnDirectDriveUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDirectDriveUp.Location = New System.Drawing.Point(59, 8)
        Me.btnDirectDriveUp.Name = "btnDirectDriveUp"
        Me.btnDirectDriveUp.Size = New System.Drawing.Size(50, 40)
        Me.btnDirectDriveUp.TabIndex = 0
        Me.btnDirectDriveUp.Text = "↑"
        Me.btnDirectDriveUp.UseVisualStyleBackColor = True
        '
        'btnDirectDriveDown
        '
        Me.btnDirectDriveDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDirectDriveDown.Location = New System.Drawing.Point(59, 121)
        Me.btnDirectDriveDown.Name = "btnDirectDriveDown"
        Me.btnDirectDriveDown.Size = New System.Drawing.Size(50, 40)
        Me.btnDirectDriveDown.TabIndex = 2
        Me.btnDirectDriveDown.Text = "↓"
        Me.btnDirectDriveDown.UseVisualStyleBackColor = True
        '
        'btnDirectDriveRight
        '
        Me.btnDirectDriveRight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDirectDriveRight.Location = New System.Drawing.Point(116, 64)
        Me.btnDirectDriveRight.Name = "btnDirectDriveRight"
        Me.btnDirectDriveRight.Size = New System.Drawing.Size(50, 40)
        Me.btnDirectDriveRight.TabIndex = 1
        Me.btnDirectDriveRight.Text = "→"
        Me.btnDirectDriveRight.UseVisualStyleBackColor = True
        '
        'btnDirectDriveLeft
        '
        Me.btnDirectDriveLeft.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDirectDriveLeft.Location = New System.Drawing.Point(3, 64)
        Me.btnDirectDriveLeft.Name = "btnDirectDriveLeft"
        Me.btnDirectDriveLeft.Size = New System.Drawing.Size(50, 40)
        Me.btnDirectDriveLeft.TabIndex = 3
        Me.btnDirectDriveLeft.Text = "←"
        Me.btnDirectDriveLeft.UseVisualStyleBackColor = True
        '
        'gbBalloonLocationDrive
        '
        Me.gbBalloonLocationDrive.Controls.Add(Me.lblMes054)
        Me.gbBalloonLocationDrive.Controls.Add(Me.tlpBalloonLocateDrive)
        Me.gbBalloonLocationDrive.Controls.Add(Me.btnBalloonLocateDrive)
        Me.gbBalloonLocationDrive.Location = New System.Drawing.Point(13, 160)
        Me.gbBalloonLocationDrive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbBalloonLocationDrive.Name = "gbBalloonLocationDrive"
        Me.gbBalloonLocationDrive.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbBalloonLocationDrive.Size = New System.Drawing.Size(364, 138)
        Me.gbBalloonLocationDrive.TabIndex = 1
        Me.gbBalloonLocationDrive.TabStop = False
        Me.gbBalloonLocationDrive.Text = "バルーン位置指定"
        '
        'lblMes054
        '
        Me.lblMes054.AutoSize = True
        Me.lblMes054.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.lblMes054.Location = New System.Drawing.Point(19, 104)
        Me.lblMes054.Name = "lblMes054"
        Me.lblMes054.Size = New System.Drawing.Size(244, 15)
        Me.lblMes054.TabIndex = 1
        Me.lblMes054.Text = "※自動制御タブで現在地登録と誤差修正が必要"
        '
        'tlpBalloonLocateDrive
        '
        Me.tlpBalloonLocateDrive.ColumnCount = 3
        Me.tlpBalloonLocateDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpBalloonLocateDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpBalloonLocateDrive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpBalloonLocateDrive.Controls.Add(Me.nudBalloonLocateDriveLat, 0, 1)
        Me.tlpBalloonLocateDrive.Controls.Add(Me.lblMes051, 0, 0)
        Me.tlpBalloonLocateDrive.Controls.Add(Me.lblMes052, 1, 0)
        Me.tlpBalloonLocateDrive.Controls.Add(Me.nudBalloonLocateDriveLon, 0, 1)
        Me.tlpBalloonLocateDrive.Controls.Add(Me.nudBalloonLocateDriveAlt, 1, 1)
        Me.tlpBalloonLocateDrive.Controls.Add(Me.lblMes053, 2, 0)
        Me.tlpBalloonLocateDrive.Location = New System.Drawing.Point(18, 24)
        Me.tlpBalloonLocateDrive.Name = "tlpBalloonLocateDrive"
        Me.tlpBalloonLocateDrive.RowCount = 2
        Me.tlpBalloonLocateDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpBalloonLocateDrive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpBalloonLocateDrive.Size = New System.Drawing.Size(327, 65)
        Me.tlpBalloonLocateDrive.TabIndex = 0
        '
        'nudBalloonLocateDriveLat
        '
        Me.nudBalloonLocateDriveLat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudBalloonLocateDriveLat.DecimalPlaces = 4
        Me.nudBalloonLocateDriveLat.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudBalloonLocateDriveLat.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudBalloonLocateDriveLat.Location = New System.Drawing.Point(4, 31)
        Me.nudBalloonLocateDriveLat.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudBalloonLocateDriveLat.Name = "nudBalloonLocateDriveLat"
        Me.nudBalloonLocateDriveLat.Size = New System.Drawing.Size(100, 28)
        Me.nudBalloonLocateDriveLat.TabIndex = 1
        Me.nudBalloonLocateDriveLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudBalloonLocateDriveLat.Value = New Decimal(New Integer() {342321, 0, 0, 262144})
        '
        'lblMes051
        '
        Me.lblMes051.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes051.AutoSize = True
        Me.lblMes051.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes051.Location = New System.Drawing.Point(34, 3)
        Me.lblMes051.Name = "lblMes051"
        Me.lblMes051.Size = New System.Drawing.Size(41, 20)
        Me.lblMes051.TabIndex = 0
        Me.lblMes051.Text = "緯度"
        '
        'lblMes052
        '
        Me.lblMes052.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes052.AutoSize = True
        Me.lblMes052.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes052.Location = New System.Drawing.Point(143, 3)
        Me.lblMes052.Name = "lblMes052"
        Me.lblMes052.Size = New System.Drawing.Size(41, 20)
        Me.lblMes052.TabIndex = 2
        Me.lblMes052.Text = "経度"
        '
        'nudBalloonLocateDriveLon
        '
        Me.nudBalloonLocateDriveLon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudBalloonLocateDriveLon.DecimalPlaces = 4
        Me.nudBalloonLocateDriveLon.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudBalloonLocateDriveLon.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudBalloonLocateDriveLon.Location = New System.Drawing.Point(113, 31)
        Me.nudBalloonLocateDriveLon.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudBalloonLocateDriveLon.Name = "nudBalloonLocateDriveLon"
        Me.nudBalloonLocateDriveLon.Size = New System.Drawing.Size(100, 28)
        Me.nudBalloonLocateDriveLon.TabIndex = 3
        Me.nudBalloonLocateDriveLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudBalloonLocateDriveLon.Value = New Decimal(New Integer() {1352643, 0, 0, 262144})
        '
        'nudBalloonLocateDriveAlt
        '
        Me.nudBalloonLocateDriveAlt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudBalloonLocateDriveAlt.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.nudBalloonLocateDriveAlt.Location = New System.Drawing.Point(222, 31)
        Me.nudBalloonLocateDriveAlt.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.nudBalloonLocateDriveAlt.Name = "nudBalloonLocateDriveAlt"
        Me.nudBalloonLocateDriveAlt.Size = New System.Drawing.Size(100, 28)
        Me.nudBalloonLocateDriveAlt.TabIndex = 5
        Me.nudBalloonLocateDriveAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudBalloonLocateDriveAlt.Value = New Decimal(New Integer() {22560, 0, 0, 0})
        '
        'lblMes053
        '
        Me.lblMes053.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes053.AutoSize = True
        Me.lblMes053.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes053.Location = New System.Drawing.Point(252, 3)
        Me.lblMes053.Name = "lblMes053"
        Me.lblMes053.Size = New System.Drawing.Size(41, 20)
        Me.lblMes053.TabIndex = 4
        Me.lblMes053.Text = "高度"
        '
        'btnBalloonLocateDrive
        '
        Me.btnBalloonLocateDrive.Location = New System.Drawing.Point(273, 95)
        Me.btnBalloonLocateDrive.Name = "btnBalloonLocateDrive"
        Me.btnBalloonLocateDrive.Size = New System.Drawing.Size(74, 30)
        Me.btnBalloonLocateDrive.TabIndex = 2
        Me.btnBalloonLocateDrive.Text = "移動"
        Me.ToolTip1.SetToolTip(Me.btnBalloonLocateDrive, "バルーン位置指定移動の実行")
        Me.btnBalloonLocateDrive.UseVisualStyleBackColor = True
        '
        'tmrClockUpdate
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSetting, Me.tsmiAntenna, Me.tsmiHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiSetting
        '
        Me.tsmiSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiBalloonMapEnable, Me.tsmiKmlEnable, Me.ToolStripSeparator2, Me.tsmiOpenLogFolder, Me.ToolStripSeparator1, Me.tsmiExit})
        Me.tsmiSetting.Name = "tsmiSetting"
        Me.tsmiSetting.Size = New System.Drawing.Size(61, 20)
        Me.tsmiSetting.Text = "設定(&S)"
        '
        'tsmiBalloonMapEnable
        '
        Me.tsmiBalloonMapEnable.CheckOnClick = True
        Me.tsmiBalloonMapEnable.Name = "tsmiBalloonMapEnable"
        Me.tsmiBalloonMapEnable.Size = New System.Drawing.Size(201, 22)
        Me.tsmiBalloonMapEnable.Text = "バルーン位置の地図表示"
        '
        'tsmiKmlEnable
        '
        Me.tsmiKmlEnable.CheckOnClick = True
        Me.tsmiKmlEnable.Enabled = False
        Me.tsmiKmlEnable.Name = "tsmiKmlEnable"
        Me.tsmiKmlEnable.Size = New System.Drawing.Size(201, 22)
        Me.tsmiKmlEnable.Text = "GPS KMLファイル出力"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        'tsmiOpenLogFolder
        '
        Me.tsmiOpenLogFolder.Name = "tsmiOpenLogFolder"
        Me.tsmiOpenLogFolder.Size = New System.Drawing.Size(201, 22)
        Me.tsmiOpenLogFolder.Text = "ログファイル出力先を開く..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeyDisplayString = "Alt+F4"
        Me.tsmiExit.Size = New System.Drawing.Size(201, 22)
        Me.tsmiExit.Text = "終了(&H)"
        '
        'tsmiAntenna
        '
        Me.tsmiAntenna.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMoveAntennaFirstPosition, Me.tsmiMoveAntennaOriginPosition})
        Me.tsmiAntenna.Name = "tsmiAntenna"
        Me.tsmiAntenna.Size = New System.Drawing.Size(126, 20)
        Me.tsmiAntenna.Text = "ローテータオプション(&R)"
        '
        'tsmiMoveAntennaFirstPosition
        '
        Me.tsmiMoveAntennaFirstPosition.Name = "tsmiMoveAntennaFirstPosition"
        Me.tsmiMoveAntennaFirstPosition.Size = New System.Drawing.Size(211, 22)
        Me.tsmiMoveAntennaFirstPosition.Text = "アンテナ取り付け位置へ移動"
        '
        'tsmiMoveAntennaOriginPosition
        '
        Me.tsmiMoveAntennaOriginPosition.Name = "tsmiMoveAntennaOriginPosition"
        Me.tsmiMoveAntennaOriginPosition.Size = New System.Drawing.Size(211, 22)
        Me.tsmiMoveAntennaOriginPosition.Text = "アンテナを中立点へ移動"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiVersion})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(67, 20)
        Me.tsmiHelp.Text = "ヘルプ(&H)"
        '
        'tsmiVersion
        '
        Me.tsmiVersion.Name = "tsmiVersion"
        Me.tsmiVersion.Size = New System.Drawing.Size(173, 22)
        Me.tsmiVersion.Text = "バージョン情報(&A)..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslPowerState, Me.tspbBatteryLife})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 23)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslPowerState
        '
        Me.tsslPowerState.Name = "tsslPowerState"
        Me.tsslPowerState.Size = New System.Drawing.Size(55, 18)
        Me.tsslPowerState.Text = "電源状態"
        '
        'tspbBatteryLife
        '
        Me.tspbBatteryLife.MarqueeAnimationSpeed = 1000
        Me.tspbBatteryLife.Name = "tspbBatteryLife"
        Me.tspbBatteryLife.Size = New System.Drawing.Size(100, 17)
        Me.tspbBatteryLife.Step = 1
        Me.tspbBatteryLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'gbSerialPort
        '
        Me.gbSerialPort.Controls.Add(Me.tlpSerialPort)
        Me.gbSerialPort.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.gbSerialPort.Location = New System.Drawing.Point(470, 36)
        Me.gbSerialPort.Name = "gbSerialPort"
        Me.gbSerialPort.Size = New System.Drawing.Size(397, 151)
        Me.gbSerialPort.TabIndex = 2
        Me.gbSerialPort.TabStop = False
        Me.gbSerialPort.Text = "ポート"
        '
        'tlpSerialPort
        '
        Me.tlpSerialPort.ColumnCount = 3
        Me.tlpSerialPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.4!))
        Me.tlpSerialPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.tlpSerialPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSerialPort.Controls.Add(Me.lblMes101, 0, 0)
        Me.tlpSerialPort.Controls.Add(Me.cmbRotatorPortList, 0, 1)
        Me.tlpSerialPort.Controls.Add(Me.lblMes102, 1, 0)
        Me.tlpSerialPort.Controls.Add(Me.lblMes103, 1, 1)
        Me.tlpSerialPort.Controls.Add(Me.btnGpsOpen, 1, 2)
        Me.tlpSerialPort.Controls.Add(Me.btnRotatorOpen, 0, 2)
        Me.tlpSerialPort.Controls.Add(Me.nudGpsTcpPort, 2, 1)
        Me.tlpSerialPort.Location = New System.Drawing.Point(21, 24)
        Me.tlpSerialPort.Name = "tlpSerialPort"
        Me.tlpSerialPort.RowCount = 3
        Me.tlpSerialPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSerialPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSerialPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSerialPort.Size = New System.Drawing.Size(355, 114)
        Me.tlpSerialPort.TabIndex = 0
        '
        'lblMes101
        '
        Me.lblMes101.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes101.AutoSize = True
        Me.lblMes101.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes101.Location = New System.Drawing.Point(4, 9)
        Me.lblMes101.Name = "lblMes101"
        Me.lblMes101.Size = New System.Drawing.Size(127, 20)
        Me.lblMes101.TabIndex = 0
        Me.lblMes101.Text = "ローテータ(Serial)"
        '
        'cmbRotatorPortList
        '
        Me.cmbRotatorPortList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbRotatorPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRotatorPortList.FormattingEnabled = True
        Me.cmbRotatorPortList.Location = New System.Drawing.Point(12, 41)
        Me.cmbRotatorPortList.MaxDropDownItems = 20
        Me.cmbRotatorPortList.Name = "cmbRotatorPortList"
        Me.cmbRotatorPortList.Size = New System.Drawing.Size(112, 25)
        Me.cmbRotatorPortList.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbRotatorPortList, "ローテータを接続するCOMポート番号")
        '
        'lblMes102
        '
        Me.lblMes102.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes102.AutoSize = True
        Me.tlpSerialPort.SetColumnSpan(Me.lblMes102, 2)
        Me.lblMes102.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes102.Location = New System.Drawing.Point(200, 9)
        Me.lblMes102.Name = "lblMes102"
        Me.lblMes102.Size = New System.Drawing.Size(91, 20)
        Me.lblMes102.TabIndex = 3
        Me.lblMes102.Text = "GPS (TCP)"
        '
        'lblMes103
        '
        Me.lblMes103.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMes103.AutoSize = True
        Me.lblMes103.Location = New System.Drawing.Point(150, 48)
        Me.lblMes103.Name = "lblMes103"
        Me.lblMes103.Size = New System.Drawing.Size(82, 18)
        Me.lblMes103.TabIndex = 4
        Me.lblMes103.Text = "ポート番号："
        '
        'btnGpsOpen
        '
        Me.btnGpsOpen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpSerialPort.SetColumnSpan(Me.btnGpsOpen, 2)
        Me.btnGpsOpen.Location = New System.Drawing.Point(208, 80)
        Me.btnGpsOpen.Name = "btnGpsOpen"
        Me.btnGpsOpen.Size = New System.Drawing.Size(75, 30)
        Me.btnGpsOpen.TabIndex = 6
        Me.btnGpsOpen.Text = "開く"
        Me.ToolTip1.SetToolTip(Me.btnGpsOpen, "GPS情報受信用のTCPサーバを開く")
        Me.btnGpsOpen.UseVisualStyleBackColor = True
        '
        'btnRotatorOpen
        '
        Me.btnRotatorOpen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRotatorOpen.Location = New System.Drawing.Point(30, 80)
        Me.btnRotatorOpen.Name = "btnRotatorOpen"
        Me.btnRotatorOpen.Size = New System.Drawing.Size(75, 30)
        Me.btnRotatorOpen.TabIndex = 2
        Me.btnRotatorOpen.Text = "開く"
        Me.ToolTip1.SetToolTip(Me.btnRotatorOpen, "ローテータ制御ポートの開閉")
        Me.btnRotatorOpen.UseVisualStyleBackColor = True
        '
        'nudGpsTcpPort
        '
        Me.nudGpsTcpPort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudGpsTcpPort.Location = New System.Drawing.Point(245, 45)
        Me.nudGpsTcpPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nudGpsTcpPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGpsTcpPort.Name = "nudGpsTcpPort"
        Me.nudGpsTcpPort.Size = New System.Drawing.Size(100, 24)
        Me.nudGpsTcpPort.TabIndex = 5
        Me.nudGpsTcpPort.Value = New Decimal(New Integer() {5554, 0, 0, 0})
        '
        'gbPresentValue
        '
        Me.gbPresentValue.Controls.Add(Me.gbNowTime)
        Me.gbPresentValue.Controls.Add(Me.gbLastGps)
        Me.gbPresentValue.Controls.Add(Me.gbPresentRotator)
        Me.gbPresentValue.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.gbPresentValue.Location = New System.Drawing.Point(471, 193)
        Me.gbPresentValue.Name = "gbPresentValue"
        Me.gbPresentValue.Size = New System.Drawing.Size(396, 491)
        Me.gbPresentValue.TabIndex = 3
        Me.gbPresentValue.TabStop = False
        Me.gbPresentValue.Text = "現在の値"
        '
        'gbNowTime
        '
        Me.gbNowTime.Controls.Add(Me.lblNowTime)
        Me.gbNowTime.Location = New System.Drawing.Point(21, 23)
        Me.gbNowTime.Name = "gbNowTime"
        Me.gbNowTime.Size = New System.Drawing.Size(354, 56)
        Me.gbNowTime.TabIndex = 0
        Me.gbNowTime.TabStop = False
        Me.gbNowTime.Text = "現在時刻"
        '
        'lblNowTime
        '
        Me.lblNowTime.AutoSize = True
        Me.lblNowTime.Font = New System.Drawing.Font("Meiryo UI", 14.0!)
        Me.lblNowTime.Location = New System.Drawing.Point(50, 20)
        Me.lblNowTime.Name = "lblNowTime"
        Me.lblNowTime.Size = New System.Drawing.Size(270, 24)
        Me.lblNowTime.TabIndex = 0
        Me.lblNowTime.Text = "yyyy/MM/dd HH:mm:ss JST"
        '
        'gbLastGps
        '
        Me.gbLastGps.Controls.Add(Me.btnGpsAngleDrive)
        Me.gbLastGps.Controls.Add(Me.tlpAZELbyGPS)
        Me.gbLastGps.Controls.Add(Me.tbxLastGpsGetTime)
        Me.gbLastGps.Controls.Add(Me.lblMes210)
        Me.gbLastGps.Controls.Add(Me.tlpPresentGps)
        Me.gbLastGps.Location = New System.Drawing.Point(21, 258)
        Me.gbLastGps.Name = "gbLastGps"
        Me.gbLastGps.Size = New System.Drawing.Size(354, 213)
        Me.gbLastGps.TabIndex = 2
        Me.gbLastGps.TabStop = False
        Me.gbLastGps.Text = "GPS"
        '
        'btnGpsAngleDrive
        '
        Me.btnGpsAngleDrive.Location = New System.Drawing.Point(237, 160)
        Me.btnGpsAngleDrive.Name = "btnGpsAngleDrive"
        Me.btnGpsAngleDrive.Size = New System.Drawing.Size(75, 30)
        Me.btnGpsAngleDrive.TabIndex = 4
        Me.btnGpsAngleDrive.Text = "移動"
        Me.btnGpsAngleDrive.UseVisualStyleBackColor = True
        '
        'tlpAZELbyGPS
        '
        Me.tlpAZELbyGPS.ColumnCount = 2
        Me.tlpAZELbyGPS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAZELbyGPS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAZELbyGPS.Controls.Add(Me.lblMes220, 0, 0)
        Me.tlpAZELbyGPS.Controls.Add(Me.lblMes221, 1, 0)
        Me.tlpAZELbyGPS.Controls.Add(Me.tbxCalcedEL, 0, 1)
        Me.tlpAZELbyGPS.Controls.Add(Me.tbxCalcedAZ, 1, 1)
        Me.tlpAZELbyGPS.Location = New System.Drawing.Point(17, 130)
        Me.tlpAZELbyGPS.Name = "tlpAZELbyGPS"
        Me.tlpAZELbyGPS.RowCount = 2
        Me.tlpAZELbyGPS.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpAZELbyGPS.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpAZELbyGPS.Size = New System.Drawing.Size(214, 65)
        Me.tlpAZELbyGPS.TabIndex = 3
        '
        'lblMes220
        '
        Me.lblMes220.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes220.AutoSize = True
        Me.lblMes220.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes220.Location = New System.Drawing.Point(33, 3)
        Me.lblMes220.Name = "lblMes220"
        Me.lblMes220.Size = New System.Drawing.Size(41, 20)
        Me.lblMes220.TabIndex = 0
        Me.lblMes220.Text = "仰角"
        '
        'lblMes221
        '
        Me.lblMes221.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes221.AutoSize = True
        Me.lblMes221.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes221.Location = New System.Drawing.Point(132, 3)
        Me.lblMes221.Name = "lblMes221"
        Me.lblMes221.Size = New System.Drawing.Size(57, 20)
        Me.lblMes221.TabIndex = 2
        Me.lblMes221.Text = "方位角"
        '
        'tbxCalcedEL
        '
        Me.tbxCalcedEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxCalcedEL.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxCalcedEL.Location = New System.Drawing.Point(3, 31)
        Me.tbxCalcedEL.Name = "tbxCalcedEL"
        Me.tbxCalcedEL.ReadOnly = True
        Me.tbxCalcedEL.Size = New System.Drawing.Size(100, 28)
        Me.tbxCalcedEL.TabIndex = 1
        Me.tbxCalcedEL.Text = "--"
        '
        'tbxCalcedAZ
        '
        Me.tbxCalcedAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxCalcedAZ.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxCalcedAZ.Location = New System.Drawing.Point(110, 31)
        Me.tbxCalcedAZ.Name = "tbxCalcedAZ"
        Me.tbxCalcedAZ.ReadOnly = True
        Me.tbxCalcedAZ.Size = New System.Drawing.Size(100, 28)
        Me.tbxCalcedAZ.TabIndex = 3
        Me.tbxCalcedAZ.Text = "--"
        '
        'tbxLastGpsGetTime
        '
        Me.tbxLastGpsGetTime.Location = New System.Drawing.Point(115, 29)
        Me.tbxLastGpsGetTime.Name = "tbxLastGpsGetTime"
        Me.tbxLastGpsGetTime.ReadOnly = True
        Me.tbxLastGpsGetTime.Size = New System.Drawing.Size(222, 24)
        Me.tbxLastGpsGetTime.TabIndex = 1
        Me.tbxLastGpsGetTime.Text = "--:--:--"
        '
        'lblMes210
        '
        Me.lblMes210.AutoSize = True
        Me.lblMes210.Location = New System.Drawing.Point(17, 32)
        Me.lblMes210.Name = "lblMes210"
        Me.lblMes210.Size = New System.Drawing.Size(92, 18)
        Me.lblMes210.TabIndex = 0
        Me.lblMes210.Text = "最終取得時刻"
        '
        'tlpPresentGps
        '
        Me.tlpPresentGps.ColumnCount = 3
        Me.tlpPresentGps.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentGps.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentGps.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentGps.Controls.Add(Me.lblMes211, 0, 0)
        Me.tlpPresentGps.Controls.Add(Me.lblMes212, 1, 0)
        Me.tlpPresentGps.Controls.Add(Me.lblMes213, 2, 0)
        Me.tlpPresentGps.Controls.Add(Me.tbxLastLat, 0, 1)
        Me.tlpPresentGps.Controls.Add(Me.tbxLastLon, 1, 1)
        Me.tlpPresentGps.Controls.Add(Me.tbxLastAlt, 2, 1)
        Me.tlpPresentGps.Location = New System.Drawing.Point(17, 59)
        Me.tlpPresentGps.Name = "tlpPresentGps"
        Me.tlpPresentGps.RowCount = 2
        Me.tlpPresentGps.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPresentGps.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpPresentGps.Size = New System.Drawing.Size(320, 65)
        Me.tlpPresentGps.TabIndex = 2
        '
        'lblMes211
        '
        Me.lblMes211.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes211.AutoSize = True
        Me.lblMes211.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes211.Location = New System.Drawing.Point(32, 3)
        Me.lblMes211.Name = "lblMes211"
        Me.lblMes211.Size = New System.Drawing.Size(41, 20)
        Me.lblMes211.TabIndex = 0
        Me.lblMes211.Text = "緯度"
        '
        'lblMes212
        '
        Me.lblMes212.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes212.AutoSize = True
        Me.lblMes212.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes212.Location = New System.Drawing.Point(138, 3)
        Me.lblMes212.Name = "lblMes212"
        Me.lblMes212.Size = New System.Drawing.Size(41, 20)
        Me.lblMes212.TabIndex = 2
        Me.lblMes212.Text = "経度"
        '
        'lblMes213
        '
        Me.lblMes213.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes213.AutoSize = True
        Me.lblMes213.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes213.Location = New System.Drawing.Point(245, 3)
        Me.lblMes213.Name = "lblMes213"
        Me.lblMes213.Size = New System.Drawing.Size(41, 20)
        Me.lblMes213.TabIndex = 4
        Me.lblMes213.Text = "高度"
        '
        'tbxLastLat
        '
        Me.tbxLastLat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxLastLat.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxLastLat.Location = New System.Drawing.Point(3, 31)
        Me.tbxLastLat.Name = "tbxLastLat"
        Me.tbxLastLat.ReadOnly = True
        Me.tbxLastLat.Size = New System.Drawing.Size(100, 28)
        Me.tbxLastLat.TabIndex = 1
        Me.tbxLastLat.Text = "--"
        '
        'tbxLastLon
        '
        Me.tbxLastLon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxLastLon.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxLastLon.Location = New System.Drawing.Point(109, 31)
        Me.tbxLastLon.Name = "tbxLastLon"
        Me.tbxLastLon.ReadOnly = True
        Me.tbxLastLon.Size = New System.Drawing.Size(100, 28)
        Me.tbxLastLon.TabIndex = 3
        Me.tbxLastLon.Text = "--"
        '
        'tbxLastAlt
        '
        Me.tbxLastAlt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxLastAlt.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxLastAlt.Location = New System.Drawing.Point(216, 31)
        Me.tbxLastAlt.Name = "tbxLastAlt"
        Me.tbxLastAlt.ReadOnly = True
        Me.tbxLastAlt.Size = New System.Drawing.Size(100, 28)
        Me.tbxLastAlt.TabIndex = 5
        Me.tbxLastAlt.Text = "--"
        '
        'gbPresentRotator
        '
        Me.gbPresentRotator.Controls.Add(Me.tlpPresentRotator)
        Me.gbPresentRotator.Location = New System.Drawing.Point(21, 82)
        Me.gbPresentRotator.Name = "gbPresentRotator"
        Me.gbPresentRotator.Size = New System.Drawing.Size(354, 170)
        Me.gbPresentRotator.TabIndex = 1
        Me.gbPresentRotator.TabStop = False
        Me.gbPresentRotator.Text = "ローテータ"
        '
        'tlpPresentRotator
        '
        Me.tlpPresentRotator.ColumnCount = 3
        Me.tlpPresentRotator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentRotator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentRotator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPresentRotator.Controls.Add(Me.tbxPresentAZ, 2, 1)
        Me.tlpPresentRotator.Controls.Add(Me.tbxPresentEL, 1, 1)
        Me.tlpPresentRotator.Controls.Add(Me.tbxSetEL, 1, 2)
        Me.tlpPresentRotator.Controls.Add(Me.lblMes203, 0, 1)
        Me.tlpPresentRotator.Controls.Add(Me.lblMes204, 0, 2)
        Me.tlpPresentRotator.Controls.Add(Me.lblMes202, 2, 0)
        Me.tlpPresentRotator.Controls.Add(Me.lblMes201, 1, 0)
        Me.tlpPresentRotator.Controls.Add(Me.tbxSetAZ, 2, 2)
        Me.tlpPresentRotator.Controls.Add(Me.lblMes205, 0, 3)
        Me.tlpPresentRotator.Controls.Add(Me.tbxMoveTimeEL, 1, 3)
        Me.tlpPresentRotator.Controls.Add(Me.tbxMoveTimeAZ, 2, 3)
        Me.tlpPresentRotator.Location = New System.Drawing.Point(17, 24)
        Me.tlpPresentRotator.Name = "tlpPresentRotator"
        Me.tlpPresentRotator.RowCount = 4
        Me.tlpPresentRotator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPresentRotator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPresentRotator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPresentRotator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPresentRotator.Size = New System.Drawing.Size(320, 133)
        Me.tlpPresentRotator.TabIndex = 0
        '
        'tbxPresentAZ
        '
        Me.tbxPresentAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxPresentAZ.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxPresentAZ.Location = New System.Drawing.Point(216, 36)
        Me.tbxPresentAZ.Name = "tbxPresentAZ"
        Me.tbxPresentAZ.ReadOnly = True
        Me.tbxPresentAZ.Size = New System.Drawing.Size(100, 28)
        Me.tbxPresentAZ.TabIndex = 4
        Me.tbxPresentAZ.Text = "--"
        Me.tbxPresentAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxPresentEL
        '
        Me.tbxPresentEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxPresentEL.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxPresentEL.Location = New System.Drawing.Point(109, 36)
        Me.tbxPresentEL.Name = "tbxPresentEL"
        Me.tbxPresentEL.ReadOnly = True
        Me.tbxPresentEL.Size = New System.Drawing.Size(100, 28)
        Me.tbxPresentEL.TabIndex = 3
        Me.tbxPresentEL.Text = "--"
        Me.tbxPresentEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxSetEL
        '
        Me.tbxSetEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxSetEL.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxSetEL.Location = New System.Drawing.Point(109, 69)
        Me.tbxSetEL.Name = "tbxSetEL"
        Me.tbxSetEL.ReadOnly = True
        Me.tbxSetEL.Size = New System.Drawing.Size(100, 28)
        Me.tbxSetEL.TabIndex = 6
        Me.tbxSetEL.Text = "--"
        Me.tbxSetEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMes203
        '
        Me.lblMes203.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes203.AutoSize = True
        Me.lblMes203.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes203.Location = New System.Drawing.Point(24, 39)
        Me.lblMes203.Name = "lblMes203"
        Me.lblMes203.Size = New System.Drawing.Size(57, 20)
        Me.lblMes203.TabIndex = 2
        Me.lblMes203.Text = "現在値"
        '
        'lblMes204
        '
        Me.lblMes204.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes204.AutoSize = True
        Me.lblMes204.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes204.Location = New System.Drawing.Point(24, 72)
        Me.lblMes204.Name = "lblMes204"
        Me.lblMes204.Size = New System.Drawing.Size(57, 20)
        Me.lblMes204.TabIndex = 5
        Me.lblMes204.Text = "設定値"
        '
        'lblMes202
        '
        Me.lblMes202.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes202.AutoSize = True
        Me.lblMes202.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes202.Location = New System.Drawing.Point(237, 6)
        Me.lblMes202.Name = "lblMes202"
        Me.lblMes202.Size = New System.Drawing.Size(57, 20)
        Me.lblMes202.TabIndex = 1
        Me.lblMes202.Text = "方位角"
        '
        'lblMes201
        '
        Me.lblMes201.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes201.AutoSize = True
        Me.lblMes201.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.lblMes201.Location = New System.Drawing.Point(138, 6)
        Me.lblMes201.Name = "lblMes201"
        Me.lblMes201.Size = New System.Drawing.Size(41, 20)
        Me.lblMes201.TabIndex = 0
        Me.lblMes201.Text = "仰角"
        '
        'tbxSetAZ
        '
        Me.tbxSetAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxSetAZ.Font = New System.Drawing.Font("Meiryo UI", 12.0!)
        Me.tbxSetAZ.Location = New System.Drawing.Point(216, 69)
        Me.tbxSetAZ.Name = "tbxSetAZ"
        Me.tbxSetAZ.ReadOnly = True
        Me.tbxSetAZ.Size = New System.Drawing.Size(100, 28)
        Me.tbxSetAZ.TabIndex = 7
        Me.tbxSetAZ.Text = "--"
        Me.tbxSetAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMes205
        '
        Me.lblMes205.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMes205.AutoSize = True
        Me.lblMes205.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.lblMes205.Location = New System.Drawing.Point(15, 107)
        Me.lblMes205.Name = "lblMes205"
        Me.lblMes205.Size = New System.Drawing.Size(76, 18)
        Me.lblMes205.TabIndex = 8
        Me.lblMes205.Text = "(移動時間)"
        '
        'tbxMoveTimeEL
        '
        Me.tbxMoveTimeEL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxMoveTimeEL.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.tbxMoveTimeEL.Location = New System.Drawing.Point(109, 104)
        Me.tbxMoveTimeEL.Name = "tbxMoveTimeEL"
        Me.tbxMoveTimeEL.ReadOnly = True
        Me.tbxMoveTimeEL.Size = New System.Drawing.Size(100, 24)
        Me.tbxMoveTimeEL.TabIndex = 9
        Me.tbxMoveTimeEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxMoveTimeAZ
        '
        Me.tbxMoveTimeAZ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxMoveTimeAZ.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.tbxMoveTimeAZ.Location = New System.Drawing.Point(216, 104)
        Me.tbxMoveTimeAZ.Name = "tbxMoveTimeAZ"
        Me.tbxMoveTimeAZ.ReadOnly = True
        Me.tbxMoveTimeAZ.Size = New System.Drawing.Size(100, 24)
        Me.tbxMoveTimeAZ.TabIndex = 10
        Me.tbxMoveTimeAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'tmrRotater
        '
        Me.tmrRotater.Interval = 500
        '
        'gbLogs
        '
        Me.gbLogs.Controls.Add(Me.lblMes302)
        Me.gbLogs.Controls.Add(Me.lblMes301)
        Me.gbLogs.Controls.Add(Me.lblMes300)
        Me.gbLogs.Controls.Add(Me.tbxSystemLog)
        Me.gbLogs.Controls.Add(Me.tbxSerialLog)
        Me.gbLogs.Controls.Add(Me.tbxTcpLog)
        Me.gbLogs.Location = New System.Drawing.Point(873, 36)
        Me.gbLogs.Name = "gbLogs"
        Me.gbLogs.Size = New System.Drawing.Size(379, 396)
        Me.gbLogs.TabIndex = 4
        Me.gbLogs.TabStop = False
        Me.gbLogs.Text = "ログ"
        '
        'lblMes302
        '
        Me.lblMes302.AutoSize = True
        Me.lblMes302.Location = New System.Drawing.Point(14, 269)
        Me.lblMes302.Name = "lblMes302"
        Me.lblMes302.Size = New System.Drawing.Size(63, 15)
        Me.lblMes302.TabIndex = 4
        Me.lblMes302.Text = "システムログ"
        '
        'lblMes301
        '
        Me.lblMes301.AutoSize = True
        Me.lblMes301.Location = New System.Drawing.Point(14, 146)
        Me.lblMes301.Name = "lblMes301"
        Me.lblMes301.Size = New System.Drawing.Size(114, 15)
        Me.lblMes301.TabIndex = 2
        Me.lblMes301.Text = "ローテータ(Serial)ログ"
        '
        'lblMes300
        '
        Me.lblMes300.AutoSize = True
        Me.lblMes300.Location = New System.Drawing.Point(14, 19)
        Me.lblMes300.Name = "lblMes300"
        Me.lblMes300.Size = New System.Drawing.Size(82, 15)
        Me.lblMes300.TabIndex = 0
        Me.lblMes300.Text = "GPS(TCP)ログ"
        '
        'tbxSystemLog
        '
        Me.tbxSystemLog.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbxSystemLog.Location = New System.Drawing.Point(17, 287)
        Me.tbxSystemLog.MaxLength = 0
        Me.tbxSystemLog.Multiline = True
        Me.tbxSystemLog.Name = "tbxSystemLog"
        Me.tbxSystemLog.ReadOnly = True
        Me.tbxSystemLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxSystemLog.Size = New System.Drawing.Size(345, 100)
        Me.tbxSystemLog.TabIndex = 5
        Me.tbxSystemLog.Text = "テストメッセージ"
        Me.tbxSystemLog.WordWrap = False
        '
        'tbxSerialLog
        '
        Me.tbxSerialLog.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbxSerialLog.Location = New System.Drawing.Point(17, 164)
        Me.tbxSerialLog.MaxLength = 0
        Me.tbxSerialLog.Multiline = True
        Me.tbxSerialLog.Name = "tbxSerialLog"
        Me.tbxSerialLog.ReadOnly = True
        Me.tbxSerialLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxSerialLog.Size = New System.Drawing.Size(345, 100)
        Me.tbxSerialLog.TabIndex = 3
        Me.tbxSerialLog.Text = "テストメッセージ"
        Me.tbxSerialLog.WordWrap = False
        '
        'tbxTcpLog
        '
        Me.tbxTcpLog.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbxTcpLog.Location = New System.Drawing.Point(17, 38)
        Me.tbxTcpLog.MaxLength = 0
        Me.tbxTcpLog.Multiline = True
        Me.tbxTcpLog.Name = "tbxTcpLog"
        Me.tbxTcpLog.ReadOnly = True
        Me.tbxTcpLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxTcpLog.Size = New System.Drawing.Size(345, 100)
        Me.tbxTcpLog.TabIndex = 1
        Me.tbxTcpLog.Text = "テストメッセージ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tbxTcpLog.WordWrap = False
        '
        'gbMap
        '
        Me.gbMap.ContextMenuStrip = Me.cmsBalloonMap
        Me.gbMap.Controls.Add(Me.wbBalloonMap)
        Me.gbMap.Location = New System.Drawing.Point(873, 438)
        Me.gbMap.Name = "gbMap"
        Me.gbMap.Size = New System.Drawing.Size(379, 265)
        Me.gbMap.TabIndex = 5
        Me.gbMap.TabStop = False
        Me.gbMap.Text = "バルーン位置"
        '
        'cmsBalloonMap
        '
        Me.cmsBalloonMap.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMapElementClear, Me.tsmiMapReload})
        Me.cmsBalloonMap.Name = "cmsBalloonMap"
        Me.cmsBalloonMap.Size = New System.Drawing.Size(200, 48)
        '
        'tsmiMapElementClear
        '
        Me.tsmiMapElementClear.Name = "tsmiMapElementClear"
        Me.tsmiMapElementClear.Size = New System.Drawing.Size(199, 22)
        Me.tsmiMapElementClear.Text = "全てのパス・ポイントを消去"
        '
        'tsmiMapReload
        '
        Me.tsmiMapReload.Name = "tsmiMapReload"
        Me.tsmiMapReload.Size = New System.Drawing.Size(199, 22)
        Me.tsmiMapReload.Text = "再読み込み"
        '
        'wbBalloonMap
        '
        Me.wbBalloonMap.AllowWebBrowserDrop = False
        Me.wbBalloonMap.ContextMenuStrip = Me.cmsBalloonMap
        Me.wbBalloonMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbBalloonMap.IsWebBrowserContextMenuEnabled = False
        Me.wbBalloonMap.Location = New System.Drawing.Point(3, 19)
        Me.wbBalloonMap.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbBalloonMap.Name = "wbBalloonMap"
        Me.wbBalloonMap.ScrollBarsEnabled = False
        Me.wbBalloonMap.Size = New System.Drawing.Size(373, 243)
        Me.wbBalloonMap.TabIndex = 0
        Me.wbBalloonMap.TabStop = False
        Me.wbBalloonMap.WebBrowserShortcutsEnabled = False
        '
        'tmrPredictDrive
        '
        Me.tmrPredictDrive.Interval = 2000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 730)
        Me.Controls.Add(Me.gbMap)
        Me.Controls.Add(Me.gbLogs)
        Me.Controls.Add(Me.gbPresentValue)
        Me.Controls.Add(Me.gbSerialPort)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbRotatorControll)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Baloon System 2013"
        Me.gbAngleDrive.ResumeLayout(False)
        Me.flpAngleDriveSelect.ResumeLayout(False)
        Me.flpAngleDriveSelect.PerformLayout()
        Me.tlpAngleDrive.ResumeLayout(False)
        Me.tlpAngleDrive.PerformLayout()
        CType(Me.nudAngleDriveEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngleDriveAZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRotatorControll.ResumeLayout(False)
        Me.tcRotatorControll.ResumeLayout(False)
        Me.tpAuto.ResumeLayout(False)
        Me.gbBalloonPred.ResumeLayout(False)
        Me.gbBalloonPred.PerformLayout()
        Me.gbErrorModify.ResumeLayout(False)
        Me.gbErrorModify.PerformLayout()
        Me.tlpErrorModify.ResumeLayout(False)
        Me.tlpErrorModify.PerformLayout()
        CType(Me.nudErrorTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudErrorEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudErrorAZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPresentLocationSet.ResumeLayout(False)
        Me.gbPresentLocationSet.PerformLayout()
        Me.tlpPresentLocate.ResumeLayout(False)
        Me.tlpPresentLocate.PerformLayout()
        CType(Me.nudPresentLat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPresentLon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPresentAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManual.ResumeLayout(False)
        Me.gbDirectDrive.ResumeLayout(False)
        Me.tlpDirectDrive.ResumeLayout(False)
        Me.gbBalloonLocationDrive.ResumeLayout(False)
        Me.gbBalloonLocationDrive.PerformLayout()
        Me.tlpBalloonLocateDrive.ResumeLayout(False)
        Me.tlpBalloonLocateDrive.PerformLayout()
        CType(Me.nudBalloonLocateDriveLat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBalloonLocateDriveLon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBalloonLocateDriveAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbSerialPort.ResumeLayout(False)
        Me.tlpSerialPort.ResumeLayout(False)
        Me.tlpSerialPort.PerformLayout()
        CType(Me.nudGpsTcpPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPresentValue.ResumeLayout(False)
        Me.gbNowTime.ResumeLayout(False)
        Me.gbNowTime.PerformLayout()
        Me.gbLastGps.ResumeLayout(False)
        Me.gbLastGps.PerformLayout()
        Me.tlpAZELbyGPS.ResumeLayout(False)
        Me.tlpAZELbyGPS.PerformLayout()
        Me.tlpPresentGps.ResumeLayout(False)
        Me.tlpPresentGps.PerformLayout()
        Me.gbPresentRotator.ResumeLayout(False)
        Me.tlpPresentRotator.ResumeLayout(False)
        Me.tlpPresentRotator.PerformLayout()
        Me.gbLogs.ResumeLayout(False)
        Me.gbLogs.PerformLayout()
        Me.gbMap.ResumeLayout(False)
        Me.cmsBalloonMap.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbAngleDrive As System.Windows.Forms.GroupBox
    Friend WithEvents tlpAngleDrive As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMes041 As System.Windows.Forms.Label
    Friend WithEvents lblMes042 As System.Windows.Forms.Label
    Friend WithEvents btnAngleDrive As System.Windows.Forms.Button
    Friend WithEvents gbRotatorControll As System.Windows.Forms.GroupBox
    Friend WithEvents gbBalloonLocationDrive As System.Windows.Forms.GroupBox
    Friend WithEvents nudAngleDriveEL As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAngleDriveAZ As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBalloonLocateDrive As System.Windows.Forms.Button
    Friend WithEvents tmrClockUpdate As System.Windows.Forms.Timer
    Friend WithEvents tcRotatorControll As System.Windows.Forms.TabControl
    Friend WithEvents tpAuto As System.Windows.Forms.TabPage
    Friend WithEvents cbxToggleAutoMode As System.Windows.Forms.CheckBox
    Friend WithEvents tpManual As System.Windows.Forms.TabPage
    Friend WithEvents gbPresentValue As System.Windows.Forms.GroupBox
    Friend WithEvents gbSerialPort As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRotatorOpen As System.Windows.Forms.Button
    Friend WithEvents gbDirectDrive As System.Windows.Forms.GroupBox
    Friend WithEvents tlpDirectDrive As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnDirectDriveUp As System.Windows.Forms.Button
    Friend WithEvents btnDirectDriveDown As System.Windows.Forms.Button
    Friend WithEvents btnDirectDriveRight As System.Windows.Forms.Button
    Friend WithEvents btnDirectDriveLeft As System.Windows.Forms.Button
    Friend WithEvents tlpBalloonLocateDrive As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudBalloonLocateDriveLat As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMes051 As System.Windows.Forms.Label
    Friend WithEvents lblMes052 As System.Windows.Forms.Label
    Friend WithEvents nudBalloonLocateDriveLon As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBalloonLocateDriveAlt As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMes053 As System.Windows.Forms.Label
    Friend WithEvents btnRotatorStopM As System.Windows.Forms.Button
    Friend WithEvents tlpSerialPort As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMes101 As System.Windows.Forms.Label
    Friend WithEvents cmbRotatorPortList As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes054 As System.Windows.Forms.Label
    Friend WithEvents gbPresentLocationSet As System.Windows.Forms.GroupBox
    Friend WithEvents cbxEditPresentLocate As System.Windows.Forms.CheckBox
    Friend WithEvents tlpPresentLocate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudPresentLat As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMes011 As System.Windows.Forms.Label
    Friend WithEvents lblMes012 As System.Windows.Forms.Label
    Friend WithEvents nudPresentLon As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPresentAlt As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMes013 As System.Windows.Forms.Label
    Friend WithEvents btnRotatorStopA As System.Windows.Forms.Button
    Friend WithEvents gbLastGps As System.Windows.Forms.GroupBox
    Friend WithEvents gbPresentRotator As System.Windows.Forms.GroupBox
    Friend WithEvents gbNowTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblNowTime As System.Windows.Forms.Label
    Friend WithEvents gbErrorModify As System.Windows.Forms.GroupBox
    Friend WithEvents tlpErrorModify As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMes021 As System.Windows.Forms.Label
    Friend WithEvents lblMes022 As System.Windows.Forms.Label
    Friend WithEvents nudErrorEL As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudErrorAZ As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxEditErrorModify As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiKmlEnable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tlpPresentRotator As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbxSetAZ As System.Windows.Forms.TextBox
    Friend WithEvents tbxPresentAZ As System.Windows.Forms.TextBox
    Friend WithEvents tbxPresentEL As System.Windows.Forms.TextBox
    Friend WithEvents tbxSetEL As System.Windows.Forms.TextBox
    Friend WithEvents lblMes203 As System.Windows.Forms.Label
    Friend WithEvents lblMes204 As System.Windows.Forms.Label
    Friend WithEvents lblMes202 As System.Windows.Forms.Label
    Friend WithEvents lblMes201 As System.Windows.Forms.Label
    Friend WithEvents gbBalloonPred As System.Windows.Forms.GroupBox
    Friend WithEvents tbxLastGpsGetTime As System.Windows.Forms.TextBox
    Friend WithEvents lblMes210 As System.Windows.Forms.Label
    Friend WithEvents tlpPresentGps As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMes211 As System.Windows.Forms.Label
    Friend WithEvents lblMes212 As System.Windows.Forms.Label
    Friend WithEvents lblMes213 As System.Windows.Forms.Label
    Friend WithEvents cbxEnableBalloonPred As System.Windows.Forms.CheckBox
    Friend WithEvents tbxLastLat As System.Windows.Forms.TextBox
    Friend WithEvents tbxLastLon As System.Windows.Forms.TextBox
    Friend WithEvents tbxLastAlt As System.Windows.Forms.TextBox
    Friend WithEvents tmrRotater As System.Windows.Forms.Timer
    Friend WithEvents flpAngleDriveSelect As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbAngleAbsolute As System.Windows.Forms.RadioButton
    Friend WithEvents rbAngleRelative As System.Windows.Forms.RadioButton
    Friend WithEvents nudErrorTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMes023 As System.Windows.Forms.Label
    Friend WithEvents tsslPowerState As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMes102 As System.Windows.Forms.Label
    Friend WithEvents btnGpsOpen As System.Windows.Forms.Button
    Friend WithEvents tspbBatteryLife As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblMes205 As System.Windows.Forms.Label
    Friend WithEvents tbxMoveTimeEL As System.Windows.Forms.TextBox
    Friend WithEvents tbxMoveTimeAZ As System.Windows.Forms.TextBox
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAntenna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnResetErrorValues As System.Windows.Forms.Button
    Friend WithEvents tsmiMoveAntennaFirstPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMoveAntennaOriginPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMes103 As System.Windows.Forms.Label
    Friend WithEvents nudGpsTcpPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbLogs As System.Windows.Forms.GroupBox
    Friend WithEvents gbMap As System.Windows.Forms.GroupBox
    Friend WithEvents wbBalloonMap As System.Windows.Forms.WebBrowser
    Friend WithEvents lblMes301 As System.Windows.Forms.Label
    Friend WithEvents lblMes300 As System.Windows.Forms.Label
    Friend WithEvents tbxSystemLog As System.Windows.Forms.TextBox
    Friend WithEvents tbxSerialLog As System.Windows.Forms.TextBox
    Friend WithEvents tbxTcpLog As System.Windows.Forms.TextBox
    Friend WithEvents lblMes302 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiOpenLogFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBalloonMapEnable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBalloonMap As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiMapElementClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMapReload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpAZELbyGPS As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMes220 As System.Windows.Forms.Label
    Friend WithEvents lblMes221 As System.Windows.Forms.Label
    Friend WithEvents tbxCalcedEL As System.Windows.Forms.TextBox
    Friend WithEvents tbxCalcedAZ As System.Windows.Forms.TextBox
    Friend WithEvents btnGpsAngleDrive As System.Windows.Forms.Button
    Friend WithEvents tmrPredictDrive As System.Windows.Forms.Timer
    Friend WithEvents btnPresentLocationConvert As System.Windows.Forms.Button
    Friend WithEvents tbxPresentNmea As System.Windows.Forms.TextBox

End Class

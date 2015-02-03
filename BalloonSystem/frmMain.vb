Imports System
Imports System.Text
Imports System.IO
Imports System.Math
Imports System.Deployment.Application
Imports Microsoft.WindowsAPICodePack.ApplicationServices
Imports NmeaAnalyzeLibrary

Public Class frmMain

#Region "使用するクラスのインスタンス生成"

    'ローテータ用のシリアルポートインスタンスの生成
    Private WithEvents spRotator As New RotatorSerialControl

    'GPS用のTCP通信のインスタンス生成
    Private WithEvents tcpGps As New clsTcpControl

    'GPSのデータ解析クラスのインスタンス生成
    Private GpsPurser As New clsNmeaAnalyzer

    '位置計算用クラスのインスタンス生成
    Private tracking As New clsTracking

    'ログファイル書き込みクラスのインスタンス生成
    Private tcpLog As New TcpPortLogWriter
    Private serialLog As New SerialPortLogWriter
    Private gpsLog As New GpsLogWriter
    Private systemLog As New SystemLogWriter

#End Region

#Region "デリゲートの宣言"

    'ログファイル画面書き出し用デリゲート
    Private Delegate Sub tbxTcpLogAppendTextDelegate(ByVal message As String)
    Private Delegate Sub tbxSerialLogAppendTextDelegate(ByVal message As String)
    Private Delegate Sub tbxSystemLogAppendTextDelegate(ByVal message As String, ByVal type As SystemLogWriter.LogType)

    'GUI更新用デリゲート
    Private Delegate Sub UpdateGpsDataDelegate()
    Private Delegate Sub btnRotatorOpenChangeTextDelegate(ByVal IsOpen As Boolean)

#End Region

#Region "クラス内プライベート変数"

    'クラッシュに備えてデータを一時的に保存しておくString
    Private RecoveryData As String = ""

    'クラッシュ時に、一時的にデータを書き込んでおくファイル名 
    Private RecoveryFile As String = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "AppRecoveryData.dat")

    'ログの出力先パス
    Private LogFolderPath As String

    '自動追尾の有効状態
    Private IsAutoMode As Boolean = False

    '地図表示の有効状態(起動時に1回だけ読み込む)
    Private IsBalloonMapEnabled As Boolean

    '仰角の設定値
    Private SetEL As Integer

    '水平角の設定値
    Private SetAZ As Integer

#End Region

#Region "クラス内定数"

    'MAD-SSのデータ送信開始時刻と受信時刻の差
    Private Const MADSS_delay As Integer = 14

#End Region

#Region "初期化・終了処理"

    'コンポーネント初期化
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        '現在時刻更新タイマー開始
        tmrClockUpdate.Start()

        'コントロール初期化
        Me.Text = My.Application.Info.Title

        cmbRotatorPortList.Items.Clear()

        lblNowTime.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
        tbxPresentEL.Text = "--"
        tbxPresentAZ.Text = "--"
        tbxSetEL.Text = "--"
        tbxSetAZ.Text = "--"
        tbxMoveTimeAZ.Clear()
        tbxMoveTimeEL.Clear()
        tbxLastGpsGetTime.Text = "----/--/-- --:--:--"
        tbxLastLat.Text = "--"
        tbxLastLon.Text = "--"
        tbxLastAlt.Text = "--"
        tbxCalcedEL.Text = "--"
        tbxCalcedAZ.Text = "--"
        tbxTcpLog.Clear()
        tbxSerialLog.Clear()
        tbxSystemLog.Clear()

        '設定値を読出し
        nudPresentLat.Value = CDec(My.Settings.PresentLat)
        nudPresentLon.Value = CDec(My.Settings.PresentLon)
        nudPresentAlt.Value = CDec(My.Settings.PresentAlt)
        nudErrorEL.Value = CDec(My.Settings.ErrorEL)
        nudErrorAZ.Value = CDec(My.Settings.ErrorAZ)
        nudErrorTime.Value = CDec(My.Settings.ErrorTime)
        tsmiBalloonMapEnable.Checked = My.Settings.IsBalloonMapEnable
        tsmiKmlEnable.Checked = My.Settings.IsKmlEnable
        nudGpsTcpPort.Value = My.Settings.GpsPort

        IsBalloonMapEnabled = My.Settings.IsBalloonMapEnable

        '位置計算用クラスのプロパティを更新
        tracking.PresentLat = My.Settings.PresentLat
        tracking.PresentLon = My.Settings.PresentLon
        tracking.PresentAlt = My.Settings.PresentAlt / 1000

        '位置計算用クラスのプロパティを更新
        tracking.ErrorEL = My.Settings.ErrorEL
        tracking.ErrorAZ = My.Settings.ErrorAZ
        tracking.ErrorTime = My.Settings.ErrorTime

    End Sub

    '初期化処理 (& クラッシュ回復)
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'アプリケーションの再起動時に渡されるコマンドラインオプションの指定 
        ApplicationRestartRecoveryManager.RegisterForApplicationRestart(New RestartSettings("/restart", RestartRestrictions.NotOnReboot Or RestartRestrictions.NotOnPatch))

        'クラッシュ時に自動的に呼ばれる修復用メソッドの登録 
        Dim data As New RecoveryData(New RecoveryCallback(AddressOf RecoveryProcedure), Nothing)
        Dim settings As New RecoverySettings(data, 0)
        ApplicationRestartRecoveryManager.RegisterForApplicationRecovery(settings)

        'クラッシュによる再起動かどうか判断 
        If System.Environment.GetCommandLineArgs().Length > 1 AndAlso System.Environment.GetCommandLineArgs()(1) = "/restart" Then
            'クラッシュによる再起動だった場合は、ファイルに保存したデータを復元する 
            If (File.Exists(RecoveryFile)) Then
                'TODO:指定したファイルからデータを読み込む 
                'TextBox1.Text = File.ReadAllText(RecoveryFile)
            End If
        End If

        'ポート名コンボボックスのアイテム追加
        For Each p As String In spRotator.PortNames
            cmbRotatorPortList.Items.Add(p)
        Next


        'ログファイル設定
        ''出力先の設定
        If ApplicationDeployment.IsNetworkDeployed Then
            'ClickOnceでインストールされているので，デスクトップに設定
            Try
                LogFolderPath = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "BalloonSystem_Logs", Now.ToString("yyyyMMdd_HHmm"))
                IO.Directory.CreateDirectory(LogFolderPath)

            Catch ex As UnauthorizedAccessException
                MessageBox.Show("書き込み先ディレクトリのアクセス許可がありません．" & vbNewLine & "一時フォルダに保存します．", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogFolderPath = Path.Combine(Path.GetTempPath, "BalloonSystem", Now.ToString("yyyyMMdd_HHmm"))
                IO.Directory.CreateDirectory(LogFolderPath)

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbNewLine & "アプリケーションを終了します．", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()

            End Try

        Else
            '実行可能ファイルから起動したので，同じ場所に設定
            Try
                LogFolderPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "BalloonSystem_Logs", Now.ToString("yyyyMMdd_HHmm"))
                IO.Directory.CreateDirectory(LogFolderPath)

            Catch ex As UnauthorizedAccessException
                MessageBox.Show("書き込み先ディレクトリのアクセス許可がありません．" & vbNewLine & "一時フォルダに保存します．", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogFolderPath = Path.Combine(Path.GetTempPath, "BalloonSystem", Now.ToString("yyyyMMdd_HHmm"))
                IO.Directory.CreateDirectory(LogFolderPath)

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbNewLine & "アプリケーションを終了します．", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()

            End Try
        End If

        ''ファイル名の設定
        tcpLog.LogFilePath = Path.Combine(LogFolderPath, "TCP.log")
        serialLog.LogFilePath = Path.Combine(LogFolderPath, "Serial.log")
        gpsLog.LogFilePath = Path.Combine(LogFolderPath, "GPS.log")
        systemLog.LogFilePath = Path.Combine(LogFolderPath, "System.log")

        ''1行目書き込み
        tcpLog.WriteLog("[START LOGGING]")
        serialLog.WriteLog("[START LOGGING]")
        gpsLog.WriteLog("[START LOGGING]")
        systemLog.WriteLog("[START LOGGING]", SystemLogWriter.LogType.Information)

        '地図表示
        If IsBalloonMapEnabled Then
            wbBalloonMap.DocumentText = htmlDoc(My.Settings.PresentLat, My.Settings.PresentLon)
        End If

    End Sub

    'クラッシュ時に呼び出される修復用メソッド
    Private Function RecoveryProcedure(ByVal state As Object) As Integer

        'TODO:クラッシュ時のデータ退避記述
        'File.WriteAllText(RecoveryFile, TextData) 

        ApplicationRestartRecoveryManager.ApplicationRecoveryFinished(True)
        Return 0

    End Function

    'アプリケーション終了
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            'TCPサーバが動作中の場合，停止する
            If tcpGps.IsRunning Then
                tcpGps.ServerStop()
            End If

            'シリアルポートが開いている場合，閉じる
            If spRotator.IsOpen Then
                spRotator.Close()
            End If

            'ログ終了
            tcpLog.WriteLog("[END LOGGING]")
            serialLog.WriteLog("[END LOGGING]")
            gpsLog.WriteLog("[END LOGGING]")
            systemLog.WriteLog("[END LOGGING]", SystemLogWriter.LogType.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error - FormClosing", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'システムログに追記
            SystemLogWrite(ex.Message, SystemLogWriter.LogType.Exception)

        Finally
            'アプリケーション終了
            Application.Exit()
        End Try

    End Sub

#End Region

#Region "GUI動作"

    '地図表示の有効状態更新
    Private Sub tsmiBalloonMapEnable_Click(sender As Object, e As EventArgs) Handles tsmiBalloonMapEnable.Click
        If tsmiBalloonMapEnable.Checked = True Then
            '地図表示有効化
            MessageBox.Show("地図表示を有効化します．インターネットに接続してください．" & vbNewLine & "変更は次回起動時に反映されます．", "地図表示の有効化", MessageBoxButtons.OK)
            SystemLogWrite("地図表示有効化", SystemLogWriter.LogType.Information)
            My.Settings.IsBalloonMapEnable = True

        Else
            '地図表示無効化
            MessageBox.Show("地図表示を無効化します．" & vbNewLine & "変更は次回起動時に反映されます．", "地図表示の無効化", MessageBoxButtons.OK)
            SystemLogWrite("地図表示無効化", SystemLogWriter.LogType.Information)
            My.Settings.IsBalloonMapEnable = False

        End If
    End Sub

    'KML出力有効状態更新(未実装)
    Private Sub tsmiKmlEnable_CheckedChanged(sender As Object, e As EventArgs) Handles tsmiKmlEnable.CheckedChanged

    End Sub

    '[ログファイル出力先を開く]
    Private Sub tsmiOpenLogFolder_Click(sender As Object, e As EventArgs) Handles tsmiOpenLogFolder.Click
        Try
            Process.Start(LogFolderPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error - OpenLogFolder", MessageBoxButtons.OK, MessageBoxIcon.Error)
            systemLog.WriteLog(ex.Message, SystemLogWriter.LogType.Exception)
            Return
        End Try
    End Sub

    '現在値編集許可
    Private Sub cbxEditPresentLocate_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEditPresentLocate.CheckedChanged

        If cbxEditPresentLocate.Checked = True Then
            '現在地編集開始
            tlpPresentLocate.Enabled = True     '入力欄を有効化
            tbxPresentNmea.Enabled = True
            btnPresentLocationConvert.Enabled = True
        Else
            '現在地編集完了
            tlpPresentLocate.Enabled = False    '入力欄を無効化
            tbxPresentNmea.Enabled = False
            btnPresentLocationConvert.Enabled = False

            '設定を更新
            My.Settings.PresentLat = nudPresentLat.Value
            My.Settings.PresentLon = nudPresentLon.Value
            My.Settings.PresentAlt = nudPresentLon.Value

            '位置計算用クラスのプロパティを更新
            tracking.PresentLat = nudPresentLat.Value
            tracking.PresentLon = nudPresentLon.Value
            tracking.PresentAlt = nudPresentAlt.Value / 1000

            'ログ出力
            systemLog.WriteLog("[現在値更新]," & nudPresentLat.Value & "," & nudPresentLon.Value & "," & nudPresentAlt.Value, SystemLogWriter.LogType.Information)

            '地図の中心位置を更新
            If IsBalloonMapEnabled Then
                wbBalloonMap.Document.InvokeScript("setCenterPoint", {nudPresentLat.Value, nudPresentLon.Value})
            End If
        End If

    End Sub

    '現在値をGPSメッセージ(NMEA0183)から入力
    Private Sub btnPresentLocationConvert_Click(sender As Object, e As EventArgs) Handles btnPresentLocationConvert.Click

        'GPSメッセージを解析
        Dim presloc As clsNmeaAnalyzer.strGpsData = GpsPurser.PurseGgaFunction(tbxPresentNmea.Text)

        '返ってきた値が有効なら適用，無効なら警告表示
        If presloc.IsEnable Then
            '値を適用
            nudPresentLat.Value = presloc.Lat
            nudPresentLon.Value = presloc.Lon
            nudPresentAlt.Value = presloc.Alt

            '入力欄をクリア
            tbxPresentNmea.Clear()

        Else
            MessageBox.Show("入力されたGPSメッセージが不正です．", "Exclamation - PresentLocationConvert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            systemLog.WriteLog("テキストボックスに入力されたGPSメッセージが不正です．", SystemLogWriter.LogType.Exclamation)
            Return
        End If

    End Sub

    '誤差修正編集許可
    Private Sub cbxEditErrorModify_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEditErrorModify.CheckedChanged

        If cbxEditErrorModify.Checked = True Then
            '誤差修正値編集開始
            tlpErrorModify.Enabled = True   '入力欄を有効化
            btnResetErrorValues.Enabled = True
        Else
            '誤差修正値編集完了
            tlpErrorModify.Enabled = False  '入力欄を無効化
            btnResetErrorValues.Enabled = False

            '設定を更新
            My.Settings.ErrorEL = nudErrorEL.Value
            My.Settings.ErrorAZ = nudErrorAZ.Value
            My.Settings.ErrorTime = nudErrorTime.Value

            '位置計算用クラスのプロパティを更新
            tracking.ErrorEL = nudErrorEL.Value
            tracking.ErrorAZ = nudErrorAZ.Value
            tracking.ErrorTime = nudErrorTime.Value

            'ログ出力
            systemLog.WriteLog("[誤差修正更新]," & nudErrorEL.Value & "," & nudErrorAZ.Value & "," & nudErrorTime.Value, SystemLogWriter.LogType.Information)
        End If

    End Sub

    '誤差修正リセット
    Private Sub btnResetErrorValues_Click(sender As Object, e As EventArgs) Handles btnResetErrorValues.Click

        nudErrorEL.Value = 0
        nudErrorAZ.Value = 0
        nudErrorTime.Value = 0

    End Sub

    '手動制御角度指定モード変更
    Private Sub rbAngle_CheckedChanged(sender As Object, e As EventArgs) Handles rbAngleRelative.CheckedChanged, rbAngleAbsolute.CheckedChanged

        If rbAngleAbsolute.Checked = True Then
            nudAngleDriveEL.Minimum = 0
            nudAngleDriveEL.Maximum = 180
            nudAngleDriveAZ.Minimum = 0
            nudAngleDriveAZ.Maximum = 450
            nudAngleDriveEL.Value = spRotator.NowEL
            nudAngleDriveAZ.Value = spRotator.NowAZ
        Else
            nudAngleDriveEL.Minimum = -180
            nudAngleDriveEL.Maximum = 180
            nudAngleDriveAZ.Minimum = -450
            nudAngleDriveAZ.Maximum = 450
            nudAngleDriveEL.Value = 0
            nudAngleDriveAZ.Value = 0
        End If

    End Sub

    'バージョン情報表示
    Private Sub tsmiVersion_Click(sender As Object, e As EventArgs) Handles tsmiVersion.Click

        frmVersion.ShowDialog()
        frmVersion.Dispose()

    End Sub

    '地図表示用HTMLドキュメント生成
    Private Shared Function htmlDoc(ByVal Lat As Double, ByVal Lng As Double) As String

        Dim sbHtml As New StringBuilder

        sbHtml.AppendLine("<!DOCTYPE html>")
        sbHtml.AppendLine("<html>")
        sbHtml.AppendLine(" <head>")
        sbHtml.AppendLine("  <meta name=""viewport"" content=""initial-scale=1.0, user-scalable=no"">")
        sbHtml.AppendLine("  <style>")
        sbHtml.AppendLine("   html, body, #map-canvas {height: 100%; margin: 0px; padding: 0px}")
        sbHtml.AppendLine("  </style>")
        sbHtml.AppendLine("  <script src=""https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false""></script>")
        sbHtml.AppendLine("  <script>")

        'グローバル変数の宣言
        sbHtml.AppendLine("   var map;")
        sbHtml.AppendLine("   var poly;")
        sbHtml.AppendLine("   var lastmarker;")

        'Mapの初期化
        sbHtml.AppendLine("   function initialize() {")
        sbHtml.AppendLine("    var myLatlng = new google.maps.LatLng(" & Lat.ToString & "," & Lng.ToString & ");")
        sbHtml.AppendLine("    var mapOptions = {zoom: 7, center: myLatlng, disableDefaultUI: true};")
        sbHtml.AppendLine("    var polyOptions = {strokeColor: '#ff0000', strokeOpacity: 0.9, strokeWeight: 1.5};")
        sbHtml.AppendLine("    map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);")
        sbHtml.AppendLine("    poly = new google.maps.Polyline(polyOptions);")
        sbHtml.AppendLine("    poly.setMap(map);")
        sbHtml.AppendLine("   }")

        sbHtml.AppendLine("   google.maps.event.addDomListener(window, 'load', initialize);")

        '中心位置更新
        sbHtml.AppendLine("   function setCenterPoint(Lat, Lng) {")
        sbHtml.AppendLine("    var LatLng = new google.maps.LatLng(Lat, Lng);")
        sbHtml.AppendLine("    map.setCenter(LatLng);")
        sbHtml.AppendLine("   }")

        'Markerの描画
        sbHtml.AppendLine("   function moveToPoint(Lat, Lng, strTitle) {")
        sbHtml.AppendLine("    var LatLng = new google.maps.LatLng(Lat, Lng);")
        sbHtml.AppendLine("    var path = poly.getPath();")
        sbHtml.AppendLine("    map.setCenter(LatLng);")
        sbHtml.AppendLine("    deleteMarker();")
        sbHtml.AppendLine("    path.push(LatLng);")
        sbHtml.AppendLine("    var marker = new google.maps.Marker({position: LatLng, map: map});")
        sbHtml.AppendLine("    lastmarker = marker;")
        sbHtml.AppendLine("   }")

        '過去のMarkerの消去
        sbHtml.AppendLine("   function deleteMarker() {")
        sbHtml.AppendLine("    if (lastmarker) {")
        sbHtml.AppendLine("     lastmarker.setMap(null);")
        sbHtml.AppendLine("     lastmarker = null;")
        sbHtml.AppendLine("    }")
        sbHtml.AppendLine("   }")

        sbHtml.AppendLine("  </script>")
        sbHtml.AppendLine(" </head>")
        sbHtml.AppendLine(" <body>")
        sbHtml.AppendLine("  <div id=""map-canvas""></div>")
        sbHtml.AppendLine(" </body>")
        sbHtml.AppendLine("</html>")

        Return sbHtml.ToString()

    End Function

    '[終了]ボタン
    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Me.Close()
    End Sub

#End Region

#Region "GUI表示更新"

    '現在時刻表示，電源状態更新
    Private Sub tmrClockUpdate_Tick(sender As Object, e As EventArgs) Handles tmrClockUpdate.Tick

        '現在時刻更新
        lblNowTime.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")

        '電源状態更新
        Select Case PowerManager.PowerSource
            Case PowerSource.AC
                tsslPowerState.Text = "AC電源"
                tspbBatteryLife.Visible = False
            Case PowerSource.Battery
                tsslPowerState.Text = String.Format("バッテリ：{0}%", PowerManager.BatteryLifePercent)
                tspbBatteryLife.Visible = True
                tspbBatteryLife.Value = PowerManager.BatteryLifePercent
            Case Else
                tsslPowerState.Text = "電源不明"
        End Select

    End Sub

    'デリゲート経由ローテータ状態表示変更
    Private Sub btnRotatorOpenChangeText(ByVal IsOpen As Boolean)
        If IsOpen = False Then
            btnRotatorOpen.Text = "開く"
            cmbRotatorPortList.Enabled = True
        Else
            btnRotatorOpen.Text = "閉じる"
            cmbRotatorPortList.Enabled = False
        End If
    End Sub

    'デリゲート経由GPS情報表示更新
    Private Sub UpdateGpsData()

        'GPS情報表示更新
        tbxLastGpsGetTime.Text = GpsPurser.AnalyzedGpsValue.ReceiveTime.ToLocalTime.ToString("HH:mm:ss (JST)")
        tbxLastLat.Text = GpsPurser.AnalyzedGpsValue.Lat.ToString("#0.####")
        tbxLastLon.Text = GpsPurser.AnalyzedGpsValue.Lon.ToString("##0.####")
        tbxLastAlt.Text = CStr(GpsPurser.AnalyzedGpsValue.Alt)

        '仰角・方位角表示更新
        Dim AZELnow As clsTracking.strAZEL = tracking.getAZEL(GpsPurser.AnalyzedGpsValue.Lat, GpsPurser.AnalyzedGpsValue.Lon, GpsPurser.AnalyzedGpsValue.Alt / 1000)
        tbxCalcedEL.Text = AZELnow.EL.ToString("#0.####")
        tbxCalcedAZ.Text = AZELnow.AZ.ToString("##0.####")

        '自動予測追尾用にデータ追加
        tracking.setNewGpsData(GpsPurser.AnalyzedGpsValue.ReceiveTime, GpsPurser.AnalyzedGpsValue.Lat, GpsPurser.AnalyzedGpsValue.Lon, GpsPurser.AnalyzedGpsValue.Alt / 1000)

        '自動追尾が有効かつ予測が無効ならローテータ駆動開始
        If IsAutoMode = True And tracking.IsPredictEnable = False Then
            If spRotator.IsOpen = True Then
                Dim bLat As Double = GpsPurser.AnalyzedGpsValue.Lat
                Dim bLon As Double = GpsPurser.AnalyzedGpsValue.Lon
                Dim bAlt As Double = GpsPurser.AnalyzedGpsValue.Alt / 1000

                Dim setAZEL As clsTracking.strAZEL

                '計算
                setAZEL = tracking.getAZEL(bLat, bLon, bAlt)

                '真上対策
                If setAZEL.IsJustAbove = True Then
                    setAZEL.AZ = SetAZ
                End If

                '駆動
                RotatorDrive(CInt(setAZEL.EL), CInt(setAZEL.AZ))
            End If
        End If

        'ログ追記
        gpsLog.WriteLog(GpsPurser.AnalyzedGpsValue.ReceiveTime, GpsPurser.AnalyzedGpsValue.Lat, GpsPurser.AnalyzedGpsValue.Lon, GpsPurser.AnalyzedGpsValue.Alt, GpsPurser.AnalyzedGpsValue.IsEnable)

        '現在値を地図に表示
        If IsBalloonMapEnabled Then
            Dim Lat As Double = GpsPurser.AnalyzedGpsValue.Lat
            Dim Lon As Double = GpsPurser.AnalyzedGpsValue.Lon

            wbBalloonMap.Document.InvokeScript("moveToPoint", {Lat, Lon, String.Format("{0},{1}", Lat, Lon)})
        End If

    End Sub

#End Region

#Region "自動制御"

    '自動追尾有効状態変更
    Private Sub cbxToggleAutoMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbxToggleAutoMode.CheckedChanged

        If cbxToggleAutoMode.Checked = True Then
            '有効化
            IsAutoMode = True

        Else
            '無効化
            IsAutoMode = False

        End If

    End Sub

    'バルーン位置予測有効化
    Private Sub cbxEnableBalloonPred_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEnableBalloonPred.CheckedChanged

        If cbxEnableBalloonPred.Checked = True Then
            'バルーン位置予測有効化
            tracking.IsPredictEnable = True
            tmrPredictDrive.Start()

        Else
            'バルーン位置予測無効化
            tracking.IsPredictEnable = False
            tmrPredictDrive.Stop()

        End If

    End Sub

    'バルーン位置予測駆動用タイマ
    Private Sub tmrPredictDrive_Tick(sender As Object, e As EventArgs) Handles tmrPredictDrive.Tick

        '位置予測が使用可能か確認
        If tracking.IsPredictUsable And tracking.IsPredictEnable Then

            'ローテータが使用可能かつ自動実行が有効か確認
            If spRotator.IsOpen And IsAutoMode Then

                '現在の時刻 - (受信時刻 - MADSS_delay) が120秒以下であれば，ローテータを駆動
                Dim span As TimeSpan = Date.UtcNow - (tracking.LastPoint.ReceiveTime - New TimeSpan(0, 0, MADSS_delay))

                If span.TotalSeconds < 120 Then
                    Dim setAZEL As clsTracking.strAZEL = tracking.getAZEL(CInt(span.TotalSeconds))

                    '真上対策
                    If setAZEL.IsJustAbove = True Then
                        setAZEL.AZ = SetAZ
                    End If

                    '駆動
                    RotatorDrive(CInt(setAZEL.EL), CInt(setAZEL.AZ))

                End If
            End If
        End If
    End Sub

#End Region

#Region "GPS(TCPポート関連)"

    'GPS用TCPポート開閉
    Private Sub btnGpsOpen_Click(sender As Object, e As EventArgs) Handles btnGpsOpen.Click

        Try
            If tcpGps.IsRunning = True Then
                If MessageBox.Show("GPSとの通信を行うポートを閉じますか？", "TCPポートを閉じる", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    'サーバ停止
                    tcpGps.ServerStop()

                    'ログ追記
                    TcpLogWrite("[Close Port]")
                    SystemLogWrite("TCPポートクローズ", SystemLogWriter.LogType.Information)

                    btnGpsOpen.Text = "開く"
                    nudGpsTcpPort.Enabled = True
                End If
            Else
                'ポート番号のセット
                tcpGps.PortNo = CInt(nudGpsTcpPort.Value)

                'My.Settingsを更新
                My.Settings.GpsPort = CInt(nudGpsTcpPort.Value)

                'サーバ開始
                tcpGps.ServerStart()

                'ログ追記
                TcpLogWrite("[Open Port]")
                SystemLogWrite("TCPポートオープン", SystemLogWriter.LogType.Information)

                btnGpsOpen.Text = "閉じる"
                nudGpsTcpPort.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error at OpenTcpPort", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SystemLogWrite(ex.Message, SystemLogWriter.LogType.Exception)
            Return
        End Try

    End Sub

    'GPS用TCPポートからメッセージ受信
    Private Sub tcpGps_TcpServerReceived(sender As Object, e As TcpServerReceivedEventArgs) Handles tcpGps.TcpServerReceived

        'ログ表示にInvokeが必要か判断
        If tbxTcpLog.InvokeRequired = True Then
            'デリゲート経由で表示
            tbxTcpLog.Invoke(New tbxTcpLogAppendTextDelegate(AddressOf TcpLogWrite), New Object() {e.ReceivedText})
        Else
            '直接表示
            TcpLogWrite(e.ReceivedText)
        End If

        '受信メッセージの解析開始
        GpsPurser.PurseGga(e.ReceivedText)

        '受信データが有効なら表示を更新
        If GpsPurser.AnalyzedGpsValue.IsEnable Then

            'GPS表示更新にInvokeが必要か判断
            If tbxLastGpsGetTime.InvokeRequired = True Then
                'デリゲート経由で表示更新
                tbxLastGpsGetTime.Invoke(New UpdateGpsDataDelegate(AddressOf UpdateGpsData))
            Else
                UpdateGpsData()
            End If

        End If

    End Sub

#End Region

#Region "ローテータ制御(シリアルポート関連)"

    'ローテータポート開閉
    Private Sub btnRotatorOpen_Click(sender As Object, e As EventArgs) Handles btnRotatorOpen.Click

        'ポート番号のセット
        If cmbRotatorPortList.SelectedItem IsNot Nothing Then
            spRotator.PortName = cmbRotatorPortList.SelectedItem.ToString

            'ポート開閉

            If spRotator.IsOpen = True Then
                If MessageBox.Show("ローテータとの通信を切断しますか？" & vbNewLine &
                                   "切断する場合は，ローテータが停止しているのを確認してから「はい」を押してください．", "ローテータとの通信を切断", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    tmrRotater.Stop()   'ローテータ監視タイマ停止

                    Try
                        spRotator.Close()   'ローテータポートクローズ
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error - Closing SerialPort", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SystemLogWrite("Closing SerialPort" & ex.Message, SystemLogWriter.LogType.Exception)
                        Return
                    End Try

                    'ログ出力
                    SerialLogWrite("[Close Port]")
                    SystemLogWrite("シリアルポートクローズ", SystemLogWriter.LogType.Information)

                    'GUI表示更新
                    btnRotatorOpen.Text = "開く"
                    cmbRotatorPortList.Enabled = True
                End If
            Else
                Try
                    spRotator.Open()    'ローテータポートオープン
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error - Opening SerialPort", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SystemLogWrite("Opening SerialPort" & ex.Message, SystemLogWriter.LogType.Exception)
                    Return
                End Try

                tmrRotater.Start()  'ローテータ監視タイマ開始

                'ログ出力
                SerialLogWrite("[Open Port]")
                SystemLogWrite("シリアルポートオープン", SystemLogWriter.LogType.Information)

                'GUI表示更新
                btnRotatorOpen.Text = "閉じる"
                cmbRotatorPortList.Enabled = False

                '応答してもらえるように改行を送信
                spRotator.Write(vbCr)
            End If
        End If

    End Sub

    'ローテータ駆動
    Private Sub RotatorDrive(ByVal EL As Integer, ByVal AZ As Integer)

        '設定角度の更新
        SetEL = EL
        SetAZ = AZ
        tbxSetEL.Text = CStr(EL)
        tbxSetAZ.Text = CStr(AZ)

        '駆動
        If EL <> SetEL Or AZ <> SetAZ Then  '現在の設定値と異なる値の場合
            spRotator.MoveAngle(CUInt(EL), CUInt(AZ))
        ElseIf EL <> spRotator.NowEL Or AZ <> spRotator.NowAZ Then  '現在のローテータの角度と異なる場合
            spRotator.MoveAngle(CUInt(EL), CUInt(AZ))
        End If

        'ログ出力
        SerialLogWrite(String.Format("MOVE,{0},{1}", AZ, EL))

    End Sub

    'ローテータ角度取得
    Private Sub tmrRotater_Tick(sender As Object, e As EventArgs) Handles tmrRotater.Tick

        Try
            spRotator.ReadNowAngle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error - Get Rotator Angle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If spRotator.IsNowAngleEnable = True Then

            '現在の角度取得
            Dim nowEL As Integer = spRotator.NowEL
            Dim nowAZ As Integer = spRotator.NowAZ


            '表示更新
            tbxPresentEL.Text = CStr(nowEL)
            tbxPresentAZ.Text = CStr(nowAZ)

            '残り移動時間表示更新
            Dim remainEL As Integer = 0
            Dim remainAZ As Integer = 0

            If tbxSetEL.Text <> "--" Then
                remainEL = CInt(Abs(SetEL - nowEL) * 0.37222222222222223 + 0.5)

            End If

            If tbxSetAZ.Text <> "--" Then
                remainAZ = CInt(Abs(SetAZ - nowAZ) * 0.16111111111111112 + 0.5)

            End If

            If remainEL > 3 Then
                tbxMoveTimeEL.Text = remainEL & " 秒"
            ElseIf remainEL < 2 Then
                tbxMoveTimeEL.Text = ""
            Else
                tbxMoveTimeEL.Text = "<3秒"
            End If

            If remainAZ > 3 Then
                tbxMoveTimeAZ.Text = remainAZ & " 秒"
            ElseIf remainAZ < 2 Then
                tbxMoveTimeAZ.Text = ""
            Else
                tbxMoveTimeAZ.Text = "<3秒"
            End If

        End If

    End Sub

    '手動制御(角度指定)
    Private Sub btnAngleDrive_Click(sender As Object, e As EventArgs) Handles btnAngleDrive.Click

        If spRotator.IsOpen = True Then
            If rbAngleAbsolute.Checked = True Then
                '絶対角度指定
                RotatorDrive(CInt(nudAngleDriveEL.Value), CInt(nudAngleDriveAZ.Value))

            Else
                '相対角度指定
                Dim AZ As Integer = CInt(spRotator.NowAZ + nudAngleDriveAZ.Value)
                Dim EL As Integer = CInt(spRotator.NowEL + nudAngleDriveEL.Value)

                If AZ > 360 Then
                    AZ = AZ - 360
                ElseIf SetAZ < 0 Then
                    AZ = AZ + 360
                End If

                If EL > 180 Then
                    EL = EL - 180
                ElseIf EL < 0 Then
                    EL = EL + 180
                End If

                '駆動
                RotatorDrive(EL, AZ)

            End If
        End If

    End Sub

    '手動制御(位置指定)
    Private Sub btnBalloonLocateDrive_Click(sender As Object, e As EventArgs) Handles btnBalloonLocateDrive.Click

        If spRotator.IsOpen = True Then
            Dim bLat As Double = nudBalloonLocateDriveLat.Value
            Dim bLon As Double = nudBalloonLocateDriveLon.Value
            Dim bAlt As Double = nudBalloonLocateDriveAlt.Value / 1000

            Dim setAZEL As clsTracking.strAZEL

            '計算
            setAZEL = tracking.getAZEL(bLat, bLon, bAlt)

            '真上対策
            If setAZEL.IsJustAbove = True Then
                setAZEL.AZ = SetAZ
            End If

            '駆動
            RotatorDrive(CInt(setAZEL.EL), CInt(setAZEL.AZ))
        End If

    End Sub

    '手動制御(上)
    Private Sub btnDirectDriveUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDirectDriveUp.MouseDown
        If spRotator.IsOpen = True Then
            spRotator.MoveUp()

            'ログ出力
            SerialLogWrite("UP")
        End If
    End Sub

    '手動制御(右)
    Private Sub btnDirectDriveRight_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDirectDriveRight.MouseDown
        If spRotator.IsOpen = True Then
            spRotator.MoveRight()

            'ログ出力
            SerialLogWrite("RIGHT")
        End If
    End Sub

    '手動制御(下)
    Private Sub btnDirectDriveDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDirectDriveDown.MouseDown
        If spRotator.IsOpen = True Then
            spRotator.MoveDown()

            'ログ出力
            SerialLogWrite("DOWN")
        End If
    End Sub

    '手動制御(左)
    Private Sub btnDirectDriveLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDirectDriveLeft.MouseDown
        If spRotator.IsOpen = True Then
            spRotator.MoveLeft()

            'ログ出力
            SerialLogWrite("LEFT")
        End If
    End Sub

    '手動制御(MouseUp停止)
    Private Sub btnDirectDrive_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDirectDriveUp.MouseUp, btnDirectDriveRight.MouseUp, btnDirectDriveLeft.MouseUp, btnDirectDriveDown.MouseUp
        If spRotator.IsOpen = True Then
            spRotator.StopDrive()

            'ログ出力
            SerialLogWrite("STOP")
        End If
    End Sub

    'アンテナを取り付け位置に移動(EL=0 AZ=0に移動)
    Private Sub tsmiMoveAntennaFirstPosition_Click(sender As Object, e As EventArgs) Handles tsmiMoveAntennaFirstPosition.Click
        If spRotator.IsOpen = True Then
            'アンテナ駆動
            RotatorDrive(0, 0)
        End If
    End Sub

    'アンテナを原点(EL=90 AZ=180に移動)
    Private Sub tsmiMoveAntennaOriginPosition_Click(sender As Object, e As EventArgs) Handles tsmiMoveAntennaOriginPosition.Click
        If spRotator.IsOpen = True Then
            'アンテナ駆動
            RotatorDrive(90, 180)
        End If
    End Sub

    'ローテータ緊急停止(自動・手動)
    Private Sub btnRotatorStop_Click(sender As Object, e As EventArgs) Handles btnRotatorStopM.Click, btnRotatorStopA.Click
        If spRotator.IsOpen = True Then
            cbxToggleAutoMode.Checked = False   '自動追尾解除
            spRotator.StopDrive()               'ローテータ動作停止

            'ログ出力
            SerialLogWrite("EM_STOP")
        End If
    End Sub

    '手動制御(TCP受信データより指定)
    Private Sub btnGpsAngleDrive_Click(sender As Object, e As EventArgs) Handles btnGpsAngleDrive.Click

        If spRotator.IsOpen = True Then
            Dim bLat As Double = nudBalloonLocateDriveLat.Value
            Dim bLon As Double = nudBalloonLocateDriveLon.Value
            Dim bAlt As Double = nudBalloonLocateDriveAlt.Value / 1000

            Dim setAZEL As clsTracking.strAZEL

            '計算
            setAZEL = tracking.getAZEL(bLat, bLon, bAlt)

            '真上対策
            If setAZEL.IsJustAbove = True Then
                setAZEL.AZ = SetAZ
            End If

            '駆動
            RotatorDrive(CInt(setAZEL.EL), CInt(setAZEL.AZ))
        End If

    End Sub

    'ローテータタイムアウトイベント処理
    Private Sub SerialTimeoutEventHandler(sender As Object, e As EventArgs) Handles spRotator.SerialTimeoutEvent

        'ローテータポートクローズ
        tmrRotater.Stop()   'ローテータ監視タイマ停止
        spRotator.Close()   'ローテータポートクローズ

        'ログ表示にInvokeが必要か判断して出力
        If tbxSerialLog.InvokeRequired = True Then
            'デリゲート経由で表示
            tbxTcpLog.Invoke(New tbxTcpLogAppendTextDelegate(AddressOf SerialLogWrite), New Object() {"ERR_PORT_CLOSE"})
        Else
            '直接表示
            SerialLogWrite("ERR_PORT_CLOSE")
        End If

        If tbxSystemLog.InvokeRequired = True Then
            'デリゲート経由で表示
            tbxSystemLog.Invoke(New tbxSystemLogAppendTextDelegate(AddressOf SystemLogWrite), New Object() {"SerialPort Timeout", SystemLogWriter.LogType.Exception})
        Else
            SystemLogWrite("SerialPort Timeout", SystemLogWriter.LogType.Exception)
        End If

        'GUI表示更新(必要ならデリゲート経由)
        If btnRotatorOpen.InvokeRequired = True Then
            'デリゲート経由で表示更新
            btnRotatorOpen.Invoke(New btnRotatorOpenChangeTextDelegate(AddressOf btnRotatorOpenChangeText), New Object() {False})
        Else
            btnRotatorOpen.Text = "開く"
            cmbRotatorPortList.Enabled = True
        End If

        MessageBox.Show("シリアルポートがタイムアウトしました．機器を確認して，接続し直してください．", "Error - SerialPort Timeout", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

#End Region

#Region "ログテキストボックス出力"

    'TCPログの出力メソッド
    Private Sub TcpLogWrite(ByVal message As String)

        'テキストボックスに出力
        tbxTcpLog.AppendText(Now.ToString("HH:mm:ss,") & message & vbNewLine)

        'ログファイルに出力
        tcpLog.WriteLog(message)

    End Sub

    'ローテータログのテキストボックスへの追加メソッド
    Private Sub SerialLogWrite(ByVal message As String)

        'テキストボックスに出力
        tbxSerialLog.AppendText(Now.ToString("HH:mm:ss,") & message & vbNewLine)

        'ログファイルに出力
        serialLog.WriteLog(message)

    End Sub

    'システムログのテキストボックスへの追加メソッド
    Private Sub SystemLogWrite(ByVal message As String, ByVal type As SystemLogWriter.LogType)

        'テキストボックスに出力
        Dim typetext As String

        ''種別の選択
        Select Case type
            Case Is = SystemLogWriter.LogType.Exception
                typetext = "例外"
            Case Is = SystemLogWriter.LogType.Exclamation
                typetext = "警告"
            Case Is = SystemLogWriter.LogType.Information
                typetext = "情報"
            Case Else
                typetext = "その他"
        End Select

        tbxSystemLog.AppendText(String.Format("{0},{1},{2}" & vbNewLine, Now.ToString("HH:mm:ss,"), typetext, message))

        'ログファイルに出力
        systemLog.WriteLog(message, type)

    End Sub

#End Region

End Class
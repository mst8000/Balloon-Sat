Imports System
Imports System.IO.Ports

''' <summary>
''' シリアルポート基本機能提供クラス
''' </summary>
Public Class clsSerialControl

    'シリアルポートのインスタンス作成(イベント発生させる)
    Protected WithEvents sp As New SerialPort()

#Region "プロパティ定義"

    'ポート名
    Private _PortName As String = "COM2"
    Public Property PortName As String
        Get
            Return _PortName
        End Get
        Set(ByVal value As String)
            _PortName = value
        End Set
    End Property

    'ボーレート
    Private _BaudRate As Integer = 9600
    Public Property BaudRate As Integer
        Get
            Return _BaudRate
        End Get
        Set(value As Integer)
            _BaudRate = value
        End Set
    End Property

    'パリティ
    Private _Parity As Parity = IO.Ports.Parity.None
    Public Property Parity As Parity
        Get
            Return _Parity
        End Get
        Set(value As Parity)
            _Parity = value
        End Set
    End Property

    'データビット
    Private _DataBits As Integer = 8
    Public Property DataBits As Integer
        Get
            Return _DataBits
        End Get
        Set(value As Integer)
            _DataBits = value
        End Set
    End Property

    'ストップビット
    Private _StopBits As StopBits = IO.Ports.StopBits.One
    Public Property StopBits As StopBits
        Get
            Return _StopBits
        End Get
        Set(value As StopBits)
            _StopBits = value
        End Set
    End Property

    'ポート名配列
    Private _PortNames() As String
    Public Property PortNames() As String()
        Get
            Return _PortNames
        End Get
        Private Set(value As String())
            _PortNames = value
        End Set

    End Property

    'ポート状態
    Public ReadOnly Property IsOpen As Boolean
        Get
            Return sp.IsOpen
        End Get
    End Property

#End Region

    'インスタンス生成時初期化
    Public Sub New()
        'ポート名配列の取得
        GetPorts()
    End Sub

    'インスタンス破棄時処理
    Protected Overrides Sub Finalize()
        If sp.IsOpen = True Then
            sp.Close()
        End If
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' ポート名配列の取得
    ''' </summary>
    Private Sub GetPorts()
        PortNames = SerialPort.GetPortNames
    End Sub

    ''' <summary>
    ''' ポートオープン
    ''' </summary>
    Public Sub Open()

        If sp.IsOpen = True Then
            'もし開いていたら閉じる
            sp.Close()
            sp.Dispose()
        Else
            'SerialPortの新規インスタンスを生成
            sp = New SerialPort(PortName, BaudRate, Parity, DataBits, StopBits)
            sp.ReceivedBytesThreshold = 6
            sp.ReadTimeout = 500
            sp.WriteTimeout = 500

            'ポートを開く
            sp.Open()
        End If

    End Sub

    ''' <summary>
    ''' ポートクローズ
    ''' </summary>
    Public Sub Close()
        If sp.IsOpen = True Then
            sp.Close()
            sp.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' シリアルポートに文字列を送信
    ''' </summary>
    ''' <param name="str">送信文字列</param>
    ''' <remarks>改行コードは自動で付加されません．</remarks>
    Public Sub Write(ByVal str As String)
        If sp.IsOpen = True Then
            sp.Write(str)
        End If
    End Sub

End Class

''' <summary>
''' ローテータ用シリアルコントローラクラス
''' </summary>
''' <remarks></remarks>
Public Class RotatorSerialControl : Inherits clsSerialControl

    Public Event SerialTimeoutEvent(sender As Object, e As EventArgs)

#Region "プロパティ定義"

    Private _NowAZ As Integer = 0
    ''' <summary>
    ''' 現在の水平角
    ''' </summary>
    Public Property NowAZ As Integer
        Get
            Return _NowAZ
        End Get
        Private Set(value As Integer)
            _NowAZ = value
        End Set
    End Property

    Private _NowEL As Integer = 0
    ''' <summary>
    ''' 現在の仰角
    ''' </summary>
    Public Property NowEL As Integer
        Get
            Return _NowEL
        End Get
        Private Set(value As Integer)
            _NowEL = value
        End Set
    End Property

    Private _IsNowAngleEnable As Boolean = False
    ''' <summary>
    ''' ローテータ角度取得状態
    ''' </summary>
    Public Property IsNowAngleEnable As Boolean
        Get
            Return _IsNowAngleEnable
        End Get
        Private Set(value As Boolean)
            _IsNowAngleEnable = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' 1文字コマンドの送信
    ''' </summary>
    ''' <param name="c">コマンド文字列</param>
    Public Sub SendCommand(c As String)
        Write(c & vbCr)
    End Sub

    ''' <summary>
    ''' 仰角UP回転
    ''' </summary>
    Public Sub MoveUp()
        Write("U" & vbCr)
    End Sub

    ''' <summary>
    ''' 仰角DOWN回転
    ''' </summary>
    Public Sub MoveDown()
        Write("D" & vbCr)
    End Sub

    ''' <summary>
    ''' 水平角左回転
    ''' </summary>
    Public Sub MoveLeft()
        Write("L" & vbCr)
    End Sub

    ''' <summary>
    ''' 水平角右回転
    ''' </summary>
    Public Sub MoveRight()
        Write("R" & vbCr)
    End Sub

    ''' <summary>
    ''' 動作停止
    ''' </summary>
    Public Sub StopDrive()
        Write("S" & vbCr)
    End Sub

    ''' <summary>
    ''' 角度指定移動
    ''' </summary>
    ''' <param name="AZ">水平角(0deg～450deg)</param>
    ''' <param name="EL">仰角(0deg～180deg)</param>
    ''' <remarks></remarks>
    Public Sub MoveAngle(EL As UInteger, AZ As UInteger)
        If AZ > 450 Then
            Throw New ArgumentException("AZ over 450 degree.")
        ElseIf EL > 180 Then
            Throw New ArgumentException("EL over 180 degree.")
        Else
            Write(String.Format("W{0:000} {1:000}", AZ, EL) & vbCr)
        End If
    End Sub

    ''' <summary>
    ''' 現在のローテータの角度を取得
    ''' </summary>
    Public Sub ReadNowAngle()
        Write("C2" & vbCr)
    End Sub

    ''' <summary>
    ''' シリアルポートデータ受信イベント
    ''' </summary>
    Private Sub SerialDataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles sp.DataReceived
        Try
            Dim port As SerialPort = CType(sender, SerialPort)
            Dim str As String = port.ReadLine

            If Left(str, 3) = "AZ=" Then
                NowEL = CInt(Mid(str, 12, 3))
                NowAZ = CInt(Mid(str, 4, 3))
                IsNowAngleEnable = True
            End If
        Catch tex As TimeoutException
            RaiseEvent SerialTimeoutEvent(Me, New EventArgs)
        Catch ioex As IO.IOException
            Return
        Catch ex As Exception
            Return
        End Try
    End Sub

End Class

#If 0 Then
''' <summary>
''' シリアル受信イベントの
''' </summary>
''' <remarks></remarks>
Public Class SerialReceivedEventArgs : Inherits EventArgs

    Private _ReceivedData As String
    Public Property ReceivedData As String
        Get
            Return _ReceivedData
        End Get
        Set(value As String)
            _ReceivedData = value
        End Set
    End Property

End Class

''' <summary>
''' MAD-SS用シリアルコントローラクラス
''' </summary>
Public Class GpsSerialControl : Inherits clsSerialControl

    'イベントの定義
    Public Event GpsReceived(ByVal sender As Object, ByVal e As EventArgs)

    ''' <summary>
    ''' シリアルポートデータ受信イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SerialDataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles sp.DataReceived
        Dim port As SerialPort = CType(sender, SerialPort)
        Dim str As String = port.ReadLine

        'イベントのプロパティに値設定
        Dim args As GpsReceivedEventArgs = New GpsReceivedEventArgs()
        args.ReceivedText = str

        'イベント発生
        OnGpsReceived(args)

    End Sub

    'イベント発生
    Protected Overridable Sub OnGpsReceived(e As GpsReceivedEventArgs)
        RaiseEvent GpsReceived(Me, e)
    End Sub

End Class

''' <summary>
''' GpsReceivedイベントの持つデータ
''' </summary>
''' <remarks></remarks>
Public Class GpsReceivedEventArgs
    Inherits EventArgs

    Public Property ReceivedText As String
End Class
#End If
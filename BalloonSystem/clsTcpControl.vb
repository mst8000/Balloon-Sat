Imports System
Imports TcpServerLibrary

''' <summary>
''' TCP通信基本機能提供クラス
''' </summary>
Public Class clsTcpControl

    'TCPサーバクラスのインスタンス生成
    Private WithEvents tcpSvr As TcpServer

    'イベントの定義
    Public Event TcpServerReceived(ByVal sender As Object, ByVal e As TcpServerReceivedEventArgs)

#Region "プロパティ定義"

    ''' <summary>
    ''' 待受けポート番号
    ''' </summary>
    Private _PortNo As Integer = 4000
    Public Property PortNo As Integer
        Get
            Return _PortNo
        End Get
        Set(value As Integer)
            If value > 0 And value < 65535 Then
                _PortNo = value
            Else
                Throw New ArgumentException("ポート番号は1から65535の間で指定してください．")
            End If
        End Set
    End Property

    ''' <summary>
    ''' TCPサーバ状態
    ''' </summary>
    Private _IsRunning As Boolean = False
    Public Property IsRunning As Boolean
        Get
            Return _IsRunning
        End Get
        Private Set(value As Boolean)
            _IsRunning = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' 設定したポートでTCPサーバを開始
    ''' </summary>
    Public Sub ServerStart()

        'サーバインスタンスの生成
        tcpSvr = New TcpServer

        'ポート番号の設定
        tcpSvr.Port = PortNo

        'サーバ開始
        Try
            tcpSvr.ServerStart()
            IsRunning = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' TCPサーバを停止
    ''' </summary>
    Public Sub ServerStop()

        'サーバ停止
        Try
            tcpSvr.ServerStop()
            IsRunning = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '文字列受信(イベント発生)
    Private Sub MessageReceived(ByVal sender As Object, e As MessageReceivedEventArgs) Handles tcpSvr.MessageReceivedEvent
        Dim args As New TcpServerReceivedEventArgs
        args.ReceivedText = e.ReceivedText

        RaiseEvent TcpServerReceived(Me, args)
    End Sub

End Class

''' <summary>
''' TcpServerReceivedイベントの持つデータ
''' </summary>
''' <remarks></remarks>
Public Class TcpServerReceivedEventArgs : Inherits EventArgs
    Public Property ReceivedText As String
End Class
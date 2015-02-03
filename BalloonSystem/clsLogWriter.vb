Imports System
Imports System.Text
Imports System.IO

''' <summary>
''' ログ書き込み基本機能提供クラス
''' </summary>
Public Class LogWriterBase

    Private _LogFilePath As String
    ''' <summary>
    ''' ログファイルのファイルパス
    ''' </summary>
    Public Property LogFilePath As String
        Get
            Return _LogFilePath
        End Get
        Set(value As String)
            _LogFilePath = value
        End Set
    End Property

    ''' <summary>
    ''' 設定されたログファイルに文字列を追記
    ''' </summary>
    ''' <param name="message">書き込む文字列</param>
    ''' <remarks></remarks>
    Protected Sub WriteLogText(ByVal message As String)
        My.Computer.FileSystem.WriteAllText(LogFilePath, message, True)
    End Sub

End Class

''' <summary>
''' TCPログ書き込みクラス
''' </summary>
''' <remarks></remarks>
Public Class TcpPortLogWriter : Inherits LogWriterBase

    ''' <summary>
    ''' 設定されたログファイルに文字列を追記
    ''' </summary>
    ''' <param name="message">書き込む文字列</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(ByVal message As String)
        Dim str = String.Format("{0},{1}" & vbNewLine, Now.ToString("yyyy/MM/dd HH:mm:ss"), message)

        '書き込み操作
        WriteLogText(str)
    End Sub

End Class

''' <summary>
''' ローテータ用シリアルポートログ書き込みクラス
''' </summary>
''' <remarks></remarks>
Public Class SerialPortLogWriter : Inherits LogWriterBase

    ''' <summary>
    ''' 設定されたログファイルに文字列を追記
    ''' </summary>
    ''' <param name="message">書き込む文字列</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(ByVal message As String)
        Dim str = String.Format("{0},{1}" & vbNewLine, Now.ToString("yyyy/MM/dd HH:mm:ss"), message)

        '書き込み操作
        WriteLogText(str)
    End Sub

End Class

''' <summary>
''' GPSログ書き込みクラス
''' </summary>
''' <remarks></remarks>
Public Class GpsLogWriter : Inherits LogWriterBase

    ''' <summary>
    ''' 設定されたログファイルにGPSデータを追記
    ''' </summary>
    ''' <param name="receivedTime">受信時刻(GPS時刻)</param>
    ''' <param name="lat">緯度</param>
    ''' <param name="lon">経度</param>
    ''' <param name="alt">高度</param>
    ''' <param name="enable">有効状態</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(ByVal receivedTime As DateTime, ByVal lat As Double, ByVal lon As Double, ByVal alt As Integer, ByVal enable As Boolean)
        Dim str = String.Format("{0},{1},{2},{3},{4},{5}" & vbNewLine, Now.ToString("yyyy/MM/dd HH:mm:ss"), receivedTime.ToString("HH:mm:ss"), lat, lon, alt, enable.ToString)

        '書き込み操作
        WriteLogText(str)
    End Sub

    ''' <summary>
    ''' 設定されたログファイルに文字列を追記
    ''' </summary>
    ''' <param name="message">書き込む文字列</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(ByVal message As String)
        Dim str = String.Format("{0},{1}" & vbNewLine, Now.ToString("yyyy/MM/dd HH:mm:ss"), message)

        '書き込み操作
        WriteLogText(str)
    End Sub

End Class

''' <summary>
''' システムログ書き込みクラス
''' </summary>
''' <remarks></remarks>
Public Class SystemLogWriter : Inherits LogWriterBase

    ''' <summary>
    ''' ログの種類を選択するための列挙体
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LogType
        Exception
        Exclamation
        Information
        Other
    End Enum

    ''' <summary>
    ''' 設定されたログファイルに文字列を追記
    ''' </summary>
    ''' <param name="message">書き込む文字列</param>
    ''' <param name="type">メッセージ種別</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(ByVal message As String, ByVal type As LogType)

        Dim str, typetext As String

        '種別の選択
        Select Case type
            Case Is = LogType.Exception
                typetext = "例外"
            Case Is = LogType.Exclamation
                typetext = "警告"
            Case Is = LogType.Information
                typetext = "情報"
            Case Else
                typetext = "その他"
        End Select

        str = String.Format("{0},{1},{2}" & vbNewLine, Now.ToString("yyyy/MM/dd HH:mm:ss"), typetext, message)

        '書き込み操作
        WriteLogText(str)

    End Sub

End Class
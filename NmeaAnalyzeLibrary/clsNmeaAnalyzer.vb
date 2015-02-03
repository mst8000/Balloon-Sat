Imports System
Imports System.Text

Public Class clsNmeaAnalyzer

    ''' <summary>
    ''' GPS情報格納構造体
    ''' </summary>
    Public Structure strGpsData
        Dim ReceiveTime As Date '受信時刻(UTC)
        Dim Lat As Double       '緯度
        Dim Lon As Double       '経度
        Dim Alt As Double       '高度(km単位)
        Dim IsEnable As Boolean   '有効状態
    End Structure

    Private _AnalyzedGpsValue As strGpsData
    ''' <summary>
    ''' 変換したGPSデータ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AnalyzedGpsValue As strGpsData
        Get
            Return _AnalyzedGpsValue
        End Get
        Private Set(value As strGpsData)
            _AnalyzedGpsValue = value
        End Set
    End Property

    ''' <summary>
    ''' GPGGAデータ解析要求
    ''' </summary>
    ''' <param name="message">GPGGA受信文字列</param>
    Public Sub PurseGga(ByVal message As String)

        '「$GPGGA,hhmmss.ss,ddmm.mmmmm.N,dddmm.mmmmm,E,,,,hhhhh,M,,,,ccc」

        '値格納先構造体の宣言
        Dim resGpsData As strGpsData

        '区切り文字の定義
        Dim delimiter As Char() = {","c}

        'データを分割
        Dim GgaArrayData As String() = message.Split(delimiter, StringSplitOptions.None)

        '正常性チェック
        If CheckGgaArray(GgaArrayData) = True Then
            resGpsData.IsEnable = True

            '値を変換
            ''受信時刻(UTC)
            resGpsData.ReceiveTime = ConvertDate(GgaArrayData(1))

            ''緯度
            resGpsData.Lat = ConvertLatValue(GgaArrayData(2))

            ''経度
            resGpsData.Lon = ConvertLonValue(GgaArrayData(4))

            ''高度
            resGpsData.Alt = Integer.Parse(GgaArrayData(9))
        Else
            resGpsData.IsEnable = False
        End If

        '値を公開
        AnalyzedGpsValue = resGpsData

    End Sub

    ''' <summary>
    ''' GPGGAを解析して，結果をstrGpsData構造体で返す関数
    ''' </summary>
    ''' <param name="message">GPGGA受信文字列</param>
    ''' <returns>解析結果を格納したstrGpsData構造体</returns>
    ''' <remarks></remarks>
    Public Function PurseGgaFunction(ByVal message As String) As strGpsData
        '「$GPGGA,hhmmss.ss,ddmm.mmmmm.N,dddmm.mmmmm,E,,,,hhhhh,M,,,,ccc」

        '値格納先構造体の宣言
        Dim resGpsData As strGpsData

        '区切り文字の定義
        Dim delimiter As Char() = {","c}

        'データを分割
        Dim GgaArrayData As String() = message.Split(delimiter, StringSplitOptions.None)

        '正常性チェック
        If CheckGgaArray(GgaArrayData) = True Then
            resGpsData.IsEnable = True

            '値を変換
            ''受信時刻(UTC)
            resGpsData.ReceiveTime = ConvertDate(GgaArrayData(1))

            ''緯度
            resGpsData.Lat = ConvertLatValue(GgaArrayData(2))

            ''経度
            resGpsData.Lon = ConvertLonValue(GgaArrayData(4))

            ''高度
            resGpsData.Alt = Integer.Parse(GgaArrayData(9))
        Else
            resGpsData.IsEnable = False
        End If

        '値を公開
        Return resGpsData
    End Function

    'GGAデータの正常性を確認
    Private Function CheckGgaArray(array As String()) As Boolean

        'テストデータ
        '「$GPGGA,025944.00,3548.24526,N,13849.53649,E,,,,01138,M,,,,*FF」
        '「$GPGGA,hhmmss.ss,ddmm.mmmmm.N,dddmm.mmmmm,E,,,,hhhhh,M,,,,ccc」

        Dim IsEnable As Boolean = True

        '配列の要素数をチェック
        If array.Length <> 15 Then
            IsEnable = False
        Else
            '配列内の文字数とパターンを正規表現でチェック
            If RegularExpressions.Regex.IsMatch(array(1), "^\d{6}\.\d{2}") = False Then
                IsEnable = False
            End If

            If RegularExpressions.Regex.IsMatch(array(2), "^\d{4}\.\d{2,}") = False Then
                IsEnable = False
            End If

            If RegularExpressions.Regex.IsMatch(array(3), "^[N]$") = False Then
                IsEnable = False
            End If

            If RegularExpressions.Regex.IsMatch(array(4), "^\d{5}\.\d{2,}") = False Then
                IsEnable = False
            End If

            If RegularExpressions.Regex.IsMatch(array(5), "^[E]") = False Then
                IsEnable = False
            End If

            If RegularExpressions.Regex.IsMatch(array(9), "^\d{5,}") = False Then
                IsEnable = False
            End If
        End If

        '結果を返す
        Return IsEnable

    End Function

#Region "GPSのデータ形式変換"

    '受信時刻変換(UTC)
    Private Function ConvertDate(ByVal str As String) As Date
        Return New Date(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day,
                        Integer.Parse(Left(str, 2)), Integer.Parse(Mid(str, 3, 2)), Integer.Parse(Mid(str, 5, 2)), Integer.Parse(Mid(str, 8, 2)), DateTimeKind.Utc)
    End Function

    '緯度をdd.dddd形式のDoubleに変換
    Private Function ConvertLatValue(ByVal str As String) As Double
        'ddmm.mmmm
        Dim latd As Double = Double.Parse(Left(str, 2))
        Dim latm As Double = Double.Parse(Mid(str, 3))

        Return latd + latm / 60

    End Function

    '経度をddd.dddd形式のDoubleに変換
    Private Function ConvertLonValue(ByVal str As String) As Double
        'dddmm.mmmm
        Dim lond As Double = Double.Parse(Left(str, 3))
        Dim lonm As Double = Double.Parse(Mid(str, 4))

        Return lond + lonm / 60

    End Function

#End Region

End Class
Imports System
Imports System.Math
Imports System.Threading
Imports System.Threading.Tasks

Public Class clsTracking

    '構造体
    ''' <summary>
    ''' 水平角・仰角格納構造体
    ''' </summary>
    Public Structure strAZEL
        Dim AZ As Double        '水平角
        Dim EL As Double        '仰角
        Dim Distance As Double  '距離(km単位)
        Dim IsJustAbove As Boolean  '真上(or真下)ならTrue
    End Structure



    ''' <summary>
    ''' GPS情報格納用構造体
    ''' </summary>
    Public Structure strGPSData
        Dim ReceiveTime As Date '受信時刻
        Dim Lat As Double       '緯度
        Dim Lon As Double       '経度
        Dim Alt As Double       '高度(km単位)
        Dim Enable As Boolean   '有効状態
    End Structure

#Region "定数宣言"

    '緯度1度当たりのkm距離
    Private Const Lat1d As Double = 111.31954315315113

    '経度1度当たりのkm距離(潮岬(33.43778) 基準)
    '地球の円周 * cos(潮岬の緯度)
    Private Const Lon1d As Double = 92.89445588845102

#End Region

    '変数
    Private pastPoint As strGPSData    '一つ前のGPSデータ
    Private PredictAZEL(120) As strAZEL '予測して得たバルーンの位置

#Region "プロパティ定義"

    Private _IsPredictEnable As Boolean
    ''' <summary>
    ''' 予測計算の実行有無
    ''' </summary>
    Public Property IsPredictEnable As Boolean
        Get
            Return _IsPredictEnable
        End Get
        Set(value As Boolean)
            _IsPredictEnable = value
        End Set
    End Property

    Private _IsPredictUsable As Boolean
    ''' <summary>
    ''' 予測計算の有効状態
    ''' </summary>
    Public Property IsPredictUsable As Boolean
        Get
            Return _IsPredictUsable
        End Get
        Private Set(value As Boolean)
            _IsPredictUsable = value
        End Set
    End Property

    Private _PresentLat As Double
    ''' <summary>
    ''' 観測点の緯度(ddd.dddd形式)
    ''' </summary>
    Public Property PresentLat As Double
        Get
            Return _PresentLat
        End Get
        Set(value As Double)
            _PresentLat = value
        End Set
    End Property

    Private _PresentLon As Double
    ''' <summary>
    ''' 観測点の経度(dd.dddd形式)
    ''' </summary>
    Public Property PresentLon As Double
        Get
            Return _PresentLon
        End Get
        Set(value As Double)
            _PresentLon = value
        End Set
    End Property

    Private _PresentAlt As Double
    ''' <summary>
    ''' 観測点の高度(km単位)
    ''' </summary>
    Public Property PresentAlt As Double
        Get
            Return _PresentAlt
        End Get
        Set(value As Double)
            _PresentAlt = value
        End Set
    End Property

    Private _ErrorAZ As Double
    ''' <summary>
    ''' 水平角の誤差修正値
    ''' </summary>
    Public Property ErrorAZ As Double
        Get
            Return _ErrorAZ
        End Get
        Set(value As Double)
            _ErrorAZ = value
        End Set
    End Property

    Private _ErrorEL As Double
    ''' <summary>
    ''' 仰角の誤差修正値
    ''' </summary>
    Public Property ErrorEL As Double
        Get
            Return _ErrorEL
        End Get
        Set(value As Double)
            _ErrorEL = value
        End Set
    End Property

    Private _ErrorTime As Double
    ''' <summary>
    ''' GPS受信時刻の誤差修正値
    ''' </summary>
    Public Property ErrorTime As Double
        Get
            Return _ErrorTime
        End Get
        Set(value As Double)
            _ErrorTime = value
        End Set
    End Property

    Private _lastPoint As strGPSData
    ''' <summary>
    ''' 最新のGPSデータ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LastPoint As strGPSData
        Get
            Return _lastPoint
        End Get
    End Property

#End Region

    ''' <summary>
    ''' GPS情報の追加(自動追尾用)
    ''' </summary>
    ''' <param name="Time">受信時刻</param>
    ''' <param name="BalloonLat">バルーンの緯度</param>
    ''' <param name="BalloonLon">バルーンの経度</param>
    ''' <param name="BalloonAlt">バルーンの高度(km単位)</param>
    ''' <remarks></remarks>
    Public Sub setNewGpsData(ByVal Time As DateTime, ByVal BalloonLat As Double, ByVal BalloonLon As Double, ByVal BalloonAlt As Double)

        '現状の最新のデータを古いデータに上書きする
        pastPoint = _lastPoint

        '最新のデータを書き込む
        _lastPoint.ReceiveTime = Time
        _lastPoint.Lat = BalloonLat
        _lastPoint.Lon = BalloonLon
        _lastPoint.Alt = BalloonAlt
        _lastPoint.Enable = True

        '2点の緯度経度が取得できたら予測実行
        If _IsPredictEnable Then
            If pastPoint.Enable = True Then
                predAZEL()
            End If
        End If

    End Sub


    ''' <summary>
    ''' 緯度経度高度から仰角・水平角を算出
    ''' </summary>
    ''' <param name="BalloonLat">バルーンの緯度</param>
    ''' <param name="BalloonLon">バルーンの経度</param>
    ''' <param name="BalloonAlt">バルーンの高度(km単位)</param>
    Public Function getAZEL(ByVal BalloonLat As Double, ByVal BalloonLon As Double, ByVal BalloonAlt As Double) As strAZEL

        Dim balAZEL As strAZEL

        Dim dx As Double = Sqrt(Pow(((BalloonLat - PresentLat) * Lat1d), 2))
        Dim dy As Double = Sqrt(Pow(((BalloonLon - PresentLon) * Lon1d), 2))
        Dim dz As Double = Sqrt(Pow(BalloonAlt - PresentAlt, 2))
        Dim dxy As Double = Sqrt(Pow(((BalloonLat - PresentLat) * Lat1d), 2) + Pow(((BalloonLon - PresentLon) * Lon1d), 2))
        Dim dxyz As Double = Sqrt(Pow(((BalloonLat - PresentLat) * Lat1d), 2) + Pow(((BalloonLon - PresentLon) * Lon1d), 2) + Pow(BalloonAlt - PresentAlt, 2))

        '真上対策
        If dxy = 0 Then
            balAZEL.EL = 90
            balAZEL.AZ = 0
            balAZEL.IsJustAbove = True
            Return balAZEL
        End If

        '観測点に対してバルーンがどの象限にいるのかで分類
        Dim quadrant As Integer = 0
        If BalloonLat - PresentLat >= 0 Then 'バルーンのほうが緯度が大きい：10，緯度が小さい：00
            quadrant += 10
        End If
        If BalloonLon - PresentLon >= 0 Then 'バルーンのほうが経度が大きい：01，経度が小さい：00
            quadrant += 1
        End If

        '水平角の算出
        Select Case quadrant
            Case Is = 11    '第一象限
                balAZEL.AZ = 90 - getDeg(Atan(dx / dy))

            Case Is = 10     '第二象限
                balAZEL.AZ = 270 + getDeg(Atan(dx / dy))

            Case Is = 0      '第三象限
                balAZEL.AZ = 270 - getDeg(Atan(dx / dy))

            Case Else        '第四象限
                balAZEL.AZ = 90 + getDeg(Atan(dx / dy))

        End Select

        '仰角の算出
        balAZEL.EL = getDeg(Atan(dz / dxy))

        'バルーンまでの距離の算出
        balAZEL.Distance = dxyz

        '誤差修正値の適用
        ''水平角
        If balAZEL.AZ + ErrorAZ > 360 Then
            balAZEL.AZ = balAZEL.AZ + ErrorAZ - 360
        ElseIf balAZEL.AZ + ErrorAZ < 0 Then
            balAZEL.AZ = balAZEL.AZ + ErrorAZ + 360
        Else
            balAZEL.AZ = balAZEL.AZ + ErrorAZ
        End If

        ''仰角
        If balAZEL.EL + ErrorEL > 180 Then
            balAZEL.EL = 180
        ElseIf balAZEL.EL + ErrorEL < 0 Then
            balAZEL.EL = 0
        Else
            balAZEL.EL = balAZEL.EL + ErrorEL
        End If

        '値を返す
        Return balAZEL

    End Function

    ''' <summary>
    ''' 予測した仰角・水平角を返す
    ''' </summary>
    ''' <param name="t">最新のGPS情報受信からの経過時間</param>
    Public Function getAZEL(ByVal t As Integer) As strAZEL
        'tの値が0～120以外なら例外発生
        If t > 120 Or t < 0 Then
            Throw New ArgumentOutOfRangeException("tの値は0以上120以下としてください．")
        End If

        '予測データがあるか確認
        If IsPredictUsable = True Then
            Return PredictAZEL(t)
        Else
            Throw New Exception("予測データがありません．")
        End If

        Return Nothing
    End Function


    '0～120秒後までのバルーン位置を予測
    Private Sub predAZEL()

        '予測の使用可能状態を無効にする
        IsPredictUsable = False

        '計算範囲を定義
        Dim range = Enumerable.Range(0, 120)

        '並列実行
        Parallel.ForEach(range, AddressOf procAZEL)

        '予測の使用可能状態を有効にする
        IsPredictUsable = True

    End Sub

    '並列実行するプロシージャ本体
    Private Sub procAZEL(ByVal t As Integer)

        ' GPS情報の受信時間の差
        Dim dts As TimeSpan = _lastPoint.ReceiveTime - pastPoint.ReceiveTime

        ' 最新のGPS情報を受信するまでに移動した1秒あたりの緯度経度高度
        Dim dLat As Double = (_lastPoint.Lat - pastPoint.Lat) / dts.TotalSeconds
        Dim dLon As Double = (_lastPoint.Lon - pastPoint.Lon) / dts.TotalSeconds
        Dim dAlt As Double = (_lastPoint.Alt - pastPoint.Alt) / dts.TotalSeconds

        '今バルーンがあるであろう場所(緯度経度高度)を求める
        Dim BalloonPredLat As Double = _lastPoint.Lat + dLat * t
        Dim BalloonPredLon As Double = _lastPoint.Lon + dLon * t
        Dim BalloonPredAlt As Double = _lastPoint.Alt + dAlt * t

        '仰角と水平角を算出
        Dim balPredAZEL As strAZEL

        Dim dx As Double = Sqrt(Pow(((BalloonPredLat - PresentLat) * Lat1d), 2))
        Dim dy As Double = Sqrt(Pow(((BalloonPredLon - PresentLon) * Lon1d), 2))
        Dim dz As Double = Sqrt(Pow(BalloonPredAlt - PresentAlt, 2))
        Dim dxy As Double = Sqrt(Pow(((BalloonPredLat - PresentLat) * Lat1d), 2) + Pow(((BalloonPredLon - PresentLon) * Lon1d), 2))
        Dim dxyz As Double = Sqrt(Pow(((BalloonPredLat - PresentLat) * Lat1d), 2) + Pow(((BalloonPredLon - PresentLon) * Lon1d), 2) + Pow(BalloonPredAlt - PresentAlt, 2))

        '観測点に対してバルーンがどの象限にいるのかで分類
        Dim quadrant As Integer = 0
        If BalloonPredLat - PresentLat > 0 Then 'バルーンのほうが緯度が大きい：10，緯度が小さい：00
            quadrant += 10
        End If
        If BalloonPredLon - PresentLon > 0 Then 'バルーンのほうが経度が大きい：01，経度が小さい：00
            quadrant += 1
        End If

        '水平角の算出
        Select Case quadrant
            Case Is = 11    '第一象限
                balPredAZEL.AZ = 90 - getDeg(Atan(dx / dy))

            Case Is = 10     '第二象限
                balPredAZEL.AZ = 270 + getDeg(Atan(dx / dy))

            Case Is = 0      '第三象限
                balPredAZEL.AZ = 270 - getDeg(Atan(dx / dy))

            Case Else        '第四象限
                balPredAZEL.AZ = 90 + getDeg(Atan(dx / dy))

        End Select

        '仰角の算出
        balPredAZEL.EL = getDeg(Atan(dz / dxy))

        'バルーンまでの距離の算出
        balPredAZEL.Distance = dxyz

        '誤差修正値の適用
        ''水平角
        If balPredAZEL.AZ + ErrorAZ > 360 Then
            balPredAZEL.AZ = balPredAZEL.AZ + ErrorAZ - 360
        ElseIf balPredAZEL.AZ + ErrorAZ < 0 Then
            balPredAZEL.AZ = balPredAZEL.AZ + ErrorAZ + 360
        Else
            balPredAZEL.AZ = balPredAZEL.AZ + ErrorAZ
        End If

        ''仰角
        If balPredAZEL.EL + ErrorEL > 180 Then
            balPredAZEL.EL = 180
        ElseIf balPredAZEL.EL + ErrorEL < 0 Then
            balPredAZEL.EL = 0
        Else
            balPredAZEL.EL = balPredAZEL.EL + ErrorEL
        End If

        '値を配列に保存
        PredictAZEL(t) = balPredAZEL

    End Sub

    'ラジアンから度に変換
    Private Shared Function getDeg(ByVal rad As Double) As Double
        Return rad * 180 / PI
    End Function

End Class
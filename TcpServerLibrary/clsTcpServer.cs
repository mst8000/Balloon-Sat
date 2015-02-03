using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TcpServerLibrary
{

    //TCPサーバ本体
    public class TcpServer
    {
        //ユーザ定義メンバ関数
        private TcpListener listener = null;

        //サーバ側ストリーム
        private StreamReader serverReader = null;

        //サーバスレッド
        Thread threadServer = null;

        //ポート番号
        public int Port { get; set; }

        //文字列受信イベント処理用デリゲート
        private delegate void RaiseReceiveTextEvent(string message);

        //文字列受信イベントの定義
        public event EventHandler MessageReceivedEvent;

        /// <summary>
        /// 設定したポートでTCPサーバ開始
        /// </summary>
        public void ServerStart()
        {
            //TcpListenerを使用してサーバーを指定のポートで確立
            listener = new TcpListener(IPAddress.Any, Port);
            listener.Start();

            //クライアントからの通信を処理するスレッドを実行
            threadServer = new Thread(new ThreadStart(ServerListen));
            threadServer.Start();

            //taskServer = new Task(() => {ServerListen();});
            //taskServer.Start();
        }

        /// <summary>
        /// サーバ停止
        /// </summary>
        public void ServerStop()
        {
            if (listener != null)
            {
                listener.Stop();
            }

            if (serverReader != null)
            {
                serverReader.BaseStream.Close();
                serverReader.Close();
            }

            if (threadServer != null)
            {
                threadServer.Abort();
            }
        }

        //別スレッドで実行されるサーバ本体部分
        private void ServerListen()
        {
            while (true)
            {
                //クライアントからの要求があれば接続を確立
                try
                {
                    TcpClient server = listener.AcceptTcpClient();

                    if (server.Connected == true)
                    {
                        //クライアントとの間の通信に使用するストリームを取得
                        NetworkStream ns = server.GetStream();
                        serverReader = new StreamReader(ns, Encoding.ASCII);

                        //クライアントからのデータをループで待機
                        while (true)
                        {
                            if (ProcessMessage(serverReader) == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                catch (SocketException)
                {
                    return;
                }
            }
        }

        //受信文字列を処理(イベントに投げる)
        private int ProcessMessage(StreamReader reader)
        {
            int state = 1;

            try
            {
                lock (this)
                {
                    string message = reader.ReadToEnd();

                    if (message.Length > 0)
                    {
                        //デリゲート経由で呼び出し
                        RaiseReceiveTextEvent MessageReceive = new RaiseReceiveTextEvent(RaiseMessageReceivedEvent);
                        MessageReceive(message);
                        state = 0;
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                state = -1;
            }

            return state;
        }

        //文字列受信イベント発生
        private void RaiseMessageReceivedEvent(string message)
        {
            MessageReceivedEventArgs args = new MessageReceivedEventArgs();
            args.ReceivedText = message;
            MessageReceivedEvent(this, args);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    //受信文字列格納イベント定義
    public class MessageReceivedEventArgs : EventArgs
    {
        private string _ReceivedText;

        public string ReceivedText
        {
            get { return _ReceivedText; }
            set { _ReceivedText = value; }
        }
    }
}
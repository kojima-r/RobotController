using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControllerPC
{
    class RobotController
    {
        private System.Net.Sockets.TcpClient tcp;
        private System.Net.Sockets.NetworkStream ns;
        public bool isOpen
        {
            get;
            private set;
        }
        public void open(ConnectionData cnn)
        {
            //TcpClientを作成し、サーバーと接続する
            tcp = new System.Net.Sockets.TcpClient(cnn.addr, cnn.port);
            //NetworkStreamを取得する
            ns = tcp.GetStream();
            ns.WriteTimeout = 1;
            //
            isOpen = true;
        }
        public void send(string msg)
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            //文字列をByte型配列に変換
            byte[] sendBytes = enc.GetBytes(msg);
            //データを送信する
            try
            {
                ns.Write(sendBytes, 0, sendBytes.Length);
                
            }
            catch 
            {
            }
        }
        public void send(byte[] sendBytes)
        {
            
            //データを送信する
            try
            {
                ns.Write(sendBytes, 0, sendBytes.Length);
            }
            catch
            {
            }
        }
        public string recv()
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            //サーバーから送られたデータを受信する
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            byte[] resBytes = new byte[1];
            int resSize;
            ns.ReadTimeout = 100;
            do
            {
                //データの一部を受信する
                resSize = ns.Read(resBytes,0,1);
                //Readが0を返した時はサーバーが切断したと判断
                if (resSize == 0)
                {
                    Console.WriteLine("サーバーが切断しました。");
                    return "";
                }
                if (resBytes[0] == ';')
                {
                    break;
                }
                //受信したデータを蓄積する
                ms.Write(resBytes, 0,1);
                
            } while (ns.DataAvailable);
            //受信したデータを文字列に変換
            string resMsg = enc.GetString(ms.ToArray());
            ms.Close();
            Console.WriteLine(resMsg);
            return resMsg;
        }
        public void close()
        {
            isOpen=false;
            if (ns != null)
            {
                ns.Close();
            }
            if (tcp != null)
            {
                tcp.Close();
            }
        }
        
    }
}

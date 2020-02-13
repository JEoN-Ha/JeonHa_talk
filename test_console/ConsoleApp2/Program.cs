using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8000;
            string strIP = "127.0.0.1";

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress ip = IPAddress.Parse(strIP);
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            socket.Bind(endPoint);

            //데이터 받기
            byte[] rBuffer = new byte[1024];

            int length = socket.Receive(rBuffer, 0, rBuffer.Length, SocketFlags.None);

            //디코딩
            string result = Encoding.UTF8.GetString(rBuffer);

            Console.WriteLine("전송된 데이터 : " + result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp1
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            //UDP Socket Client
            //시스템 포트 : 0~1023
            //사용자 포트 : 1024~49151
            //동적 포트 : 49152~65535

            string strIP = "127.0.0.1";
            int port = 8000;
            //UDP Socket 생성
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //종점 생성
            IPAddress ip = IPAddress.Parse(strIP);
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            //바인드
            socket.Connect(endPoint);

            //데이터 입력
            Console.Write("보낼 데이터 입력 : ");
            string input = Console.ReadLine();

            //인코딩(byte[])
            byte[] sBuffer = Encoding.UTF8.GetBytes(input);

            //보내기
            socket.Send(sBuffer, 0, sBuffer.Length, SocketFlags.None);
            socket.SendTo(sBuffer, endPoint);//접속(Connect)를 안할거면 일케 SendTo로 할수 있다.

            //소켓 닫기
            socket.Close();
        }
    }
}

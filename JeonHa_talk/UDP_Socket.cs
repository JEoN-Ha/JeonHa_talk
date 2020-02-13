using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPChatServer
{
    class UDP_Socket
    {
        

        //소켓 생성
        Socket Slave_Socket;
        Socket Send_socket;

        //종점 생성
        IPAddress ip;
        IPEndPoint endPoint;
        IPEndPoint endPoint_test;
        EndPoint remoteEP;

        //byte[] sBuffer;
        public byte[] rBuffer;
        public int Port_Num;
        
        

        public void Open_Socket(string strIP, int port_int)
        {
            Port_Num = port_int;
            Slave_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //Send_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ip = IPAddress.Parse(strIP);
            endPoint = new IPEndPoint(ip, port_int);
        }

        public void Connect_FoR_Client()
        {
            endPoint_test = new IPEndPoint(ip, 8003);
            Slave_Socket.Connect(endPoint_test);
        }// 접속(Connect)를 안할거면 일케 SendTo로 할수 있다하여 잠시 삭제 대기

        public void Send_Msg(byte[] Cli_Msg_sBuffer)
        {
            // Cli_Msg_sBuffer는 Client에서 보내진 메시지를 바이트로 인코딩한것.
            Slave_Socket.SendTo(Cli_Msg_sBuffer, endPoint_test);     //접속(Connect)를 안할거면 일케 SendTo로 할수 있다.
        }

        public void Receive_FoRA_ll()
        {
            //Slave_Socket.Bind(endPoint);
            rBuffer = new byte[1024];
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, Port_Num);
            Slave_Socket.BeginReceiveFrom(rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEP,
                new AsyncCallback(Server_Data_Communication),
                Slave_Socket);
        }

        public void Server_Data_Communication(IAsyncResult aresult)
        {
            remoteEP = new IPEndPoint(IPAddress.Any, Port_Num);
            int datalen = Slave_Socket.EndReceive(aresult);
            string result = Encoding.UTF8.GetString(rBuffer);

            Slave_Socket.BeginReceiveFrom(rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEP,
                new AsyncCallback(Server_Data_Communication),
                Slave_Socket);
        }
    }
}

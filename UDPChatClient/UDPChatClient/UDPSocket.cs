using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPChatClient
{
    class TargetInfo
    {
        public Socket socket;
        public byte[] buffer;
    }

    class UDPSocket
    {
        Socket m_udpSocket;
        TargetInfo m_targetInfo;
        IPEndPoint m_receiveEndpoint;
        EndPoint m_sendEndpoint;

        UDPChatClient m_parentForm;

        string m_targetAddr;
        int m_targetPort;
        int m_openPort;


        public UDPSocket(UDPChatClient form)            //초기값 설정
        {
            m_parentForm = form;
            m_targetAddr = "127.0.0.1";
            m_targetPort = 9999;
        }

        public void openSocket(int port)
        {
            try
            {
                m_targetInfo = new TargetInfo();
                m_targetInfo.buffer = new byte[256];        //데이터를 담을 공간
                m_udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //AdderessFamily : Socket의 주소지정 틀을 정의, InterNetwork : IPv4에 대한 주소, SocketType : 소켓의 종류를 지정
                m_udpSocket.Blocking = false; //소켓 차단 여부 지정, 기본값 : true (차단)
                m_openPort = port;
                m_receiveEndpoint = new IPEndPoint(IPAddress.Any, m_openPort); //endpoint의 주소, 포트 번호
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                m_udpSocket.Bind(m_receiveEndpoint); //소켓을 Endpoint와 연결
                m_udpSocket.BeginReceiveFrom(       //연결된 소켓에서 데이터를 받을 준비가 됨
                    m_targetInfo.buffer,            
                    0,                              //데이터를 저장하기 위한 buffer 매개변수의 위치
                    m_targetInfo.buffer.Length,     //수신 바이트 수
                    SocketFlags.None,               //소켓 전송 및 수신 동작을 지정함. None이므로 플래그를 사용하지 않음
                    ref remoteEndpoint,
                    new AsyncCallback(recvfromTargetClient),
                    m_udpSocket);
            }
            catch (SocketException)
            {
                return;
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }

        public void closeSocket()
        {
            m_udpSocket.Close();
            m_udpSocket = null;
            m_sendEndpoint = null;
            m_receiveEndpoint = null;
        }

        public void recvfromTargetClient(IAsyncResult result)        //계속 반복
        {
            try
            {
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                int dataLen = this.m_udpSocket.EndReceiveFrom(result, ref remoteEndpoint);
                m_parentForm.recvFrom(m_targetInfo.buffer);
            }
            catch (SocketException)
            {

            }
            catch (ObjectDisposedException)
            {

            }
            finally 
            {
                m_udpSocket.BeginReceiveFrom(
                    m_targetInfo.buffer,
                    0,
                    m_targetInfo.buffer.Length,
                    SocketFlags.None,
                    ref m_sendEndpoint,
                    new AsyncCallback(recvfromTargetClient),
                    m_udpSocket);
            }
        }

        public void setTarget(string addr, int port)
        {
            IPAddress targetAddr = IPAddress.Parse(addr); //Parse : ipaddress 문자열을 ipaddress 객체로 만듬
            m_sendEndpoint = new IPEndPoint(targetAddr, port);  //보낼 endpoint 설정
        }

        public void sendPacket(byte[] packet)
        {
            m_udpSocket.SendTo(packet, m_sendEndpoint);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;



namespace UDPChatServer
{
    public partial class UDPChatServer : Form
    {
        Socket socket;
        IPEndPoint localEP;
        IPEndPoint remoteEP;
        IPAddress ip;

        int port;
        string strIP;
        byte[] rBuffer;
        byte[] sBuffer;

        private delegate void dataDelegate(string sData);
  
        public UDPChatServer()
        {
            InitializeComponent();
            port = 8000;
            strIP = "127.0.0.1";
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            ip = IPAddress.Parse(strIP);
            localEP = new IPEndPoint(ip, port);
            remoteEP = new IPEndPoint(IPAddress.Any, port);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socket.Bind(localEP);
            rBuffer = new byte[1024];
           
            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(server_recvfrom),
                socket
                );
        }

        public void server_recvfrom(IAsyncResult Result)
        {
            EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            int datalen = socket.EndReceiveFrom(Result, ref remoteEndpoint);
            string result = Encoding.UTF8.GetString(rBuffer);

            //server에서 받은 데이터 client로 전송
            byte[] cBuffer = Encoding.UTF8.GetBytes(result);
            
            socket.SendTo(cBuffer, remoteEndpoint);

            //데이터 출력
            this.Invoke(new dataDelegate(delegatefunction), result);
            //byte[] rBuffer = new byte[1024];
            socket.BeginReceiveFrom(
                rBuffer,
                0,
                rBuffer.Length,
                SocketFlags.None,
                ref remoteEndpoint,
                new AsyncCallback(server_recvfrom),
                socket
                );
        }

        private void delegatefunction(string sData)
        {
            server_window.Text = server_window.Text + "\n" + sData;
        }
    }
}

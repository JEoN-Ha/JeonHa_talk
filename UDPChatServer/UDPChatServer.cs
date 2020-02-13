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

namespace UDPChatServer
{
    public partial class UDPChatServer : Form
    {
        int port;
        string strIP;
        Socket socket;

        IPAddress ip;
        IPEndPoint endPoint;
        EndPoint remoteEP;

        byte[] rBuffer;

        public UDPChatServer()
        {
            InitializeComponent();

            port = 8000;
            strIP = "127.0.0.1";

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            ip = IPAddress.Parse(strIP);
            endPoint = new IPEndPoint(ip, port);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socket.Bind(endPoint);
            rBuffer = new byte[1024];
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, port);
            socket.BeginReceiveFrom(rBuffer,
                0,
                rBuffer.Length, 
                SocketFlags.None, 
                ref remoteEP, 
                new AsyncCallback(Server_Data_Communication), 
                socket);
        }

        public void Server_Data_Communication(IAsyncResult aresult)
        {
            remoteEP = new IPEndPoint(IPAddress.Any, port);
            int datalen = socket.EndReceive(aresult);


            //int length;

            //length = socket.Receive(result, 0, rBuffer.Length, SocketFlags.None);
            string result = Encoding.UTF8.GetString(rBuffer);

            server_window.Text = server_window.Text + "\n" + result;
            socket.BeginReceiveFrom(rBuffer, 0, rBuffer.Length, SocketFlags.None, ref remoteEP, new AsyncCallback(Server_Data_Communication), socket);
            //try
            //{
            //    remoteEP = new IPEndPoint(IPAddress.Any, port);
            //    int datalen = socket.EndReceive(aresult);


            //    //int length;

            //    //length = socket.Receive(result, 0, rBuffer.Length, SocketFlags.None);
            //    string result = Encoding.UTF8.GetString(rBuffer);

            //    server_window.Text = server_window.Text + "\n" + result;
            //    socket.BeginReceiveFrom(rBuffer, 0, rBuffer.Length, SocketFlags.None, ref remoteEP, new AsyncCallback(Server_Data_Communication), socket);
            //}
            //catch (SocketException)
            //{

            //}
            //catch (ObjectDisposedException)
            //{

            //}
            //finally
            //{
                
            //}
            

            
            
        }

  
    }
}

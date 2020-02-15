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
        Server_Socket Server_Socket;
        string Server_IP;
        int Server_Port;

        private delegate void Data_delegate(string Server_data);
        

        public UDPChatServer()
        {
            InitializeComponent();

            //port = 8000;
            //strIP = "127.0.0.1";

            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //ip = IPAddress.Parse(strIP);
            //endPoint = new IPEndPoint(ip, port);
        }

        private void Server_Connect_Click(object sender, EventArgs e)
        {
            Server_IP = "127.0.0.1";
            Server_Port = 8000;
            int Client_Port = 7000;
            //Server_IP = Sever_Address.Text;
            //Server_Port = Convert.ToInt32(Port_Number.Text);

            Server_Socket = new Server_Socket(this);
            Server_Socket.Open_Socket(Server_IP, Server_Port, Client_Port);
            Server_Socket.Bind_Socket();

            Server_Socket.Receive_FoRA_ll();
            
        }

        public void Show_Msg(string Server_Text)
        {
            this.Invoke(new Data_delegate(test), Server_Text);
        }
        public void test(string D)
        {
            server_window.Text = server_window.Text + "\n" + D;
        }
    }
}

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
    public partial class UDPChat_Dlg : Form
    {

        public string IP_Address;
        public int Port_num;
        
        byte[] C_Buffer;

        string receive_msg;
        bool Connect_state = false;

        public UDPChat_Dlg()
        {
            InitializeComponent();
        }

        private void server_connect_Click(object sender, EventArgs e)
        {
            IP_Address = "127.0.0.1";
            Port_num = 7000;
            //IP_Address = Sever_Address.Text;
            //Port_num = Convert.ToInt32(Port_number.Text);
            if (Connect_state == false)
            {
                Server_Connect.Text = "해제";
                Connect_state = true;
            }
            else
            {
                Server_Connect.Text = "연결";
                Connect_state = false;
            }

        }

        

    }
}

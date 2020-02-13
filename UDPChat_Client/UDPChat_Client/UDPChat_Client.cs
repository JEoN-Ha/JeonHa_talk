using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChat_Client
{
    public partial class UDPChat_Client : Form
    {
        private UDPSocket m_Socket;
        private bool m_openedSocket;
        int m_openedPort;

        public UDPChat_Client()
        {
            InitializeComponent();
            m_openedSocket = false;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if(m_openedSocket == false)
            {
                m_openedPort = Convert.ToInt32(port_text.Text);
                m_Socket = new UDPSocket(this);
                m_Socket.openSocket(m_openedPort);      //지정한 포트 번호로 소켓 Open                  
                m_openedSocket = true;
                button_open.Text = "Close Socket";
            }
        }
    }
}

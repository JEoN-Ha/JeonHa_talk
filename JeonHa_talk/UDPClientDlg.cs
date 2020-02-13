using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeonHa_talk
{
    public partial class UDPClientDlg : Form
    {
        public string strIP;
        public int port;

        public UDPClientDlg()
        {
            InitializeComponent();
        }

        private void UDPClientDlg_Load(object sender, EventArgs e)
        {
            TextBox_strIP.Text = "127.0.0.1";
            TextBox_port.Text = "8000";
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
           strIP = TextBox_strIP.Text;
           port = Convert.ToInt32(TextBox_port.Text);
           
            this.Close();
        }

    }
}


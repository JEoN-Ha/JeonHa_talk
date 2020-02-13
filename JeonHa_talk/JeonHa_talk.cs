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
    public partial class JeonHa_talk : Form
    {
        UDP_Socket Cli_Socket;
        //UDPChatServer server_form = new UDPChatServer();
        //server_form.Show();

        string Cli_IP;
        int Cli_Port;

        //종점 생성
        IPAddress ip;
        IPEndPoint endPoint;


        public JeonHa_talk()
        {
            InitializeComponent();
            //strIP = "127.0.0.1";
            //port = 8000;
            ////UDP Socket 생성

            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            ////종점 생성
            //ip = IPAddress.Parse(strIP);
            //endPoint = new IPEndPoint(ip, port);
        }


        private void send_data(string my_data)
        {
            string msg = my_data;

            byte[] sBuffer = Encoding.UTF8.GetBytes(msg);

            //보내기
            //socket.Send(sBuffer, 0, sBuffer.Length, SocketFlags.None);
            try
            {
                Cli_Socket.Send_Msg(sBuffer);
            }
            catch (System.NullReferenceException)
            {

            }
        }
        

        private void button_send_Click(object sender, EventArgs e)
        {
            text_window.Text = text_window.Text + "\n" + text_input.Text;
            send_data(text_window.Text);
            text_input.Clear();
        }

        private void text_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                text_input.Text = text_input.Text + "\n";
                text_input.SelectionStart = text_input.Text.Length;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                text_window.Text = text_window.Text + "\n" + text_input.Text;
                send_data(text_input.Text);
                text_input.Clear();
            }
        }


        private void JeonHa_talk_Load(object sender, EventArgs e)
        {
            this.ActiveControl = text_input; //커서가 텍스트박스에 깜빡이게 함
            text_input.Focus();
            text_window.ReadOnly = true;

            //전체창으로 띄우기 가능
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            //바인드
            
            UDPChat_Dlg dlg = new UDPChat_Dlg();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cli_Socket = new UDP_Socket();
                Cli_IP = dlg.IP_Address;
                Cli_Port = dlg.Port_num;
                Cli_Socket.Open_Socket(Cli_IP, Cli_Port);

                Cli_Socket.Connect_FoR_Client();
                Cli_Socket.Receive_FoRA_ll();
                string receive_msg = Encoding.UTF8.GetString(Cli_Socket.rBuffer);
                text_window.Text = text_window.Text + "\n" + receive_msg;
            }
            else
            {
                //Cli_Socket.close_Socket();
            }



        }

       



        /*private void 초대가능_SelectedIndexChanged(object sender, EventArgs e)
        {
            참여자목록.Items.Add(초대가능.SelectedItem.ToString());
            전체 연락처에서 채팅 참여자 리스트로 추가할 때 
        }*/


    }
}

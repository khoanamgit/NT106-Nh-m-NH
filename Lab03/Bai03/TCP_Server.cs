using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace Bai03
{
    public partial class TCP_Server : Form
    {
        public TCP_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Hide();
            richTextBox1.Text = "Server running on 127.0.0.1:8080" + "\n";
            Thread thread = new Thread(new ThreadStart(StartUnsafeThread));
            thread.Start();
        }

        private void StartUnsafeThread()
        {
            byte[] recv = new byte[1024];
            Socket client;
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listen.Bind(ipep);
            listen.Listen(-1);
            client = listen.Accept();
            richTextBox1.Text += "New client onnected" + "\n";
            while (client.Connected)
            {
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                richTextBox1.Text += s + "\n";
            }
            listen.Close();
        }
    }
}

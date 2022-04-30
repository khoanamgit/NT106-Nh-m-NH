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
using System.Threading.Tasks;

namespace UDPServer
{
    public partial class Form1 : Form
    {
        public delegate void ShowMessage(string message);
        public ShowMessage myDelegate;
        Int32 port = 8080;
        UdpClient udpClient = new UdpClient(8080);
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            richTextBox1.Text = "Start Listening" + "\n";
            myDelegate = new ShowMessage(Show);
            thread = new Thread(new ThreadStart(Received));
            thread.IsBackground = true;
            thread.Start();
        }
        public void Received()
        {
            while (true)
            {
                IPEndPoint RemoteIPEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] data = udpClient.Receive(ref RemoteIPEndPoint);
                if (data.Length > 0)
                {
                    string message = RemoteIPEndPoint.Address.ToString() + ": " + UTF32Encoding.UTF32.GetString(data);
                    this.Invoke(myDelegate, new object[] { message });
                }
            }
        }

        private void Show(string message)
        {
            richTextBox1.Text += message + "\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.IO;
using System.Net.Configuration;
using System.Net;
using System.Net.Sockets;


namespace Bai03
{
    public partial class TCP_Client : Form
    {

        
   
        public TCP_Client()
        {
            InitializeComponent();
            
            //CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();

            IPAddress ipAdress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndpoint = new IPEndPoint(ipAdress, 8080);
            tcpClient.Connect(ipEndpoint);

            NetworkStream ns = tcpClient.GetStream();

            byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n");
            ns.Write(data, 0, data.Length);

            tcpClient.Close();


        }




    }
}

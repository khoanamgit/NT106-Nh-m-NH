﻿using System;
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



namespace UDPClient
{
    public partial class Form1 : Form
    {
        UdpClient udpClient = new UdpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 port = Int32.Parse(textBox2.Text);
            IPAddress ip = IPAddress.Parse(textBox1.Text.Trim());
            IPEndPoint iped = new IPEndPoint(ip, port);

            byte[] data = UTF32Encoding.UTF32.GetBytes(richTextBox1.Text);
            try
            {
                int count = udpClient.Send(data, data.Length, iped);
                if (count > 0)
                {
                    richTextBox1.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Error occurs.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

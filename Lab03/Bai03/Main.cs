﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tcpServer = new TCP_Server();
            tcpServer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tcpClient = new TCP_Client();
            tcpClient.Show();
        }
    }
}

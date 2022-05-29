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


using MailKit.Net.Imap;
using MailKit.Search;
using System.Threading;
using MailKit.Security;
using System.Linq.Expressions;
using MailKit;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.Columns.Add("Subject", 200);
            listView.Columns.Add("From", 200);
            listView.Columns.Add("Date", 200);
            listView.View = View.Details;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {
                ReadMail();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Điền user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Điền password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void ReadMail()
        {
            try
            {
             
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("localhost", 993, true);

                    client.Authenticate(txtEmail.Text, txtPassword.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    label5.Text = inbox.Count.ToString();
                    label6.Text = inbox.Recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = message.Subject;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.Date.ToString() });
                        listView.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra user và password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

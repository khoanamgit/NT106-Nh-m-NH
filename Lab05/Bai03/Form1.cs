using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Net.Mail;

namespace Bai03
{
    public partial class Form1 : Form
    {
        WebBrowser webBrowser1;
        public Form1()
        {
            InitializeComponent();
            webBrowser1 = new WebBrowser();
            webBrowser1.Width = pnlWeb.Width;
            webBrowser1.Height = pnlWeb.Height;
            pnlWeb.Controls.Add(webBrowser1);
        }

        TcpClient popclient;
        StreamReader sr;
        StreamWriter sw;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IPAddress server;
            IPAddress.TryParse(txtServer.Text, out server);
            int port;
            Int32.TryParse(txtPort.Text.Trim(), out port);
            IPEndPoint iep = new IPEndPoint(server, port);
            popclient = new TcpClient();
            popclient.Connect(iep);
            sr = new StreamReader(popclient.GetStream()); 
            sw = new StreamWriter(popclient.GetStream());
            sr.ReadLine();

            string data = "";
            data = "USER " + txtUser.Text;
            sw.WriteLine(data);
            sw.Flush();
            sr.ReadLine() ;

            data = "PASS " + txtPass.Text;
            sw.WriteLine(data);
            sw.Flush();
            sr.ReadLine();

            data = "LIST";
            sw.WriteLine(data);
            sw.Flush ();

            string s = sr.ReadLine();

            List<string> list = new List<string>();
            while((s = sr.ReadLine()) != ".")
            {
                string[] words = s.Split(' ');
                list.Add(words[0]);
            }
            foreach (string word in list)
            {
                Add(word);   
            }
        }

        void Add(string word)
        {
            string data = "RETR " + word;
            sw.WriteLine(data);
            sw.Flush();
            string from = "";
            string subject = "";
            string s;
            while ((s = sr.ReadLine().Trim()) != null)
            {
                if (s.Length == 0) break;
                if (s.ToUpper().StartsWith("FROM"))
                    from = s.Substring(5, s.Length - 5);
                if (s.ToUpper().StartsWith("SUBJECT"))
                {
                    if (s.Substring(8, s.Length - 8).Contains("=?"))
                        subject = Decode(s.Substring(8, s.Length - 8));
                    else
                        subject = s.Substring(8, s.Length - 8);
                }
;
            }

            //Lay phan body 
            string html = "";
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Trim();
                if (s.Equals("."))
                {
                    break;
                }
            }
            dataGridView.Rows.Add(new object[] { word, from, subject });
        }

        public static string Decode(string s)
        {
            return String.Join("", Regex.Matches(s ?? "", @"(?:=\?)([^\?]+)(?:\?B\?)([^\?]*)(?:\?=)").Cast<Match>().Select(m =>
            {
                string charset = m.Groups[1].Value;
                string data = m.Groups[2].Value;
                byte[] b = Convert.FromBase64String(data);
                return Encoding.GetEncoding(charset).GetString(b);
            }));
        }
       

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if(e.ColumnIndex==0)
                {
                    string id = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string data = "RETR " + id.ToString();
                    sw.WriteLine(data);
                    sw.Flush();
                    string s;

                    while ((s = sr.ReadLine().Trim()) != null)
                    {
                        if (s.Length == 0) break;
                        if (s.ToUpper().StartsWith("FROM"))
                            txtFrom.Text = s.Substring(5, s.Length - 5);
                        if (s.ToUpper().StartsWith("TO"))
                            txtToReceive.Text = s.Substring(3, s.Length - 3);
                        if (s.ToUpper().StartsWith("SUBJECT"))
                        {
                            if (s.Substring(8, s.Length - 8).Contains("=?"))
                                txtSubject.Text = Decode(s.Substring(8, s.Length - 8));
                            else
                                txtSubject.Text = s.Substring(8, s.Length - 8);
                        }
                    }

                    //Lay phan body 
                    string html = "";
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine().Trim();
                        if (s.Equals("."))
                        {
                            break;
                        }
                        try
                        {
                            var bytes = Convert.FromBase64String(s);
                            var text = Encoding.UTF8.GetString(bytes);
                            html += text + "\r\n";
                        }
                        catch {
                            html += s + "\r\n";
                        }
                    }
                    //Hien thi Email (HTML) bang WebBrowser
                    webBrowser1.DocumentText = html;
                    Application.DoEvents();
                }    
            }    
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtUser.Text.ToString().Trim();
                string mailto = txtToSend.Text.ToString().Trim();
                string password = txtPass.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = txtSubjectSend.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = rtbMessage.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    MessageBox.Show("Done");
                }

            }
        }
    }
}



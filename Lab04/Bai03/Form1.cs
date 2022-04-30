using System.Net;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string fileurl = txtFileUrl.Text;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, fileurl);

            StreamReader reader = new StreamReader(response);
            string responseFromServer = reader.ReadToEnd();
            rtxtHtml.Text = responseFromServer;
        }
    }
}
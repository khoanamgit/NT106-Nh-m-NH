using HtmlAgilityPack;

namespace Bai_4
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            

            string link = txtUrl.Text;
            webBrowser1.Navigate(link);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string url = webBrowser1.Url.ToString();
            var html = new HtmlWeb();
            var document = html.Load(url);
            File.WriteAllText(txtSave.Text, document.DocumentNode.InnerHtml);
            MessageBox.Show("Done");
        }

        private void btnSources_Click(object sender, EventArgs e)
        {
            string url = webBrowser1.Url.ToString();
            var html = new HtmlWeb();
            var document = html.Load(url);
            sources child = new sources(document.DocumentNode.InnerHtml);
            child.Show();
        }
    }
}
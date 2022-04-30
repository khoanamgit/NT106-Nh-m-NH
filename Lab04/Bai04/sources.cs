using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class sources : Form
    {
        private string _message;
        public sources()
        {
            InitializeComponent();
        }

        public sources(string html): this()
        {
            _message = html;
            rtxtHtml.Text = _message;
        }
    }
}

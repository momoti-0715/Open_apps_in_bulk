using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_apps_in_bulk
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string TextBoxSName_InputText    // 外部からの入出力用
        {
            get { return textBoxSName.Text; }
            set { textBoxSName.Text = value; }
        }
        public string TextBoxBrowserPass_InputText
        {
            get { return textBoxBrowserPass.Text; }
            set { textBoxBrowserPass.Text = value; }
        }

        private void buttonWebNew_Click(object sender, EventArgs e)
        {

        }
    }
}

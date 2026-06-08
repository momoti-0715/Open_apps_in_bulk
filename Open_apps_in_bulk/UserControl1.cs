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

            listViewWeb.LabelEdit = true;
            listViewTask.LabelEdit = true;
            listViewCmd.LabelEdit = true;
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
        public string LabelWarning_InputText
        {
            get { return labelWarning.Text; }
            set { labelWarning.Text = value; }
        }
        public bool LabelWarning_Visible
        {
            get { return labelWarning.Visible; }
            set { labelWarning.Visible = value; }
        }

        private void ButtonWebNew_Click(object sender, EventArgs e)
        {
            listViewWeb.Items.Add("");
        }

        private void ButtonAppNew_Click(object sender, EventArgs e)
        {
            listViewTask.Items.Add("");
        }

        private void ButtonCmdNew_Click(object sender, EventArgs e)
        {
            string[] row = {"A1", "B1"};
            listViewCmd.Items.Add(new ListViewItem(row));
        }
    }
}

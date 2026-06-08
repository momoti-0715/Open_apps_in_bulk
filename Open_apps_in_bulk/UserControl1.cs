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

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "サイトを開くブラウザを選択してください",  // タイトル
                Filter = "実行ファイル(*.exe)|*.exe|すべてのファイル(*.*)|*.*",   // 表示するファイルの拡張子
                RestoreDirectory = true    // 現在のディレクトリを復元
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                textBoxBrowserPass.Text = ofd.FileName;
            }
        }

        private void ListViewCmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonWebDel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonWebEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTaskEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTaskRef_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTaskDel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCmdEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCmdDel_Click(object sender, EventArgs e)
        {

        }
    }
}

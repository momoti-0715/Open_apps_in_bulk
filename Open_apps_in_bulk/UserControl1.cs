using JsonFileIO.Jsons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

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

        public DataGridViewRowCollection DataGridViewWeb_Get
        {
            get { return dataGridViewWeb.Rows; }
        }

        public DataGridViewRowCollection DataGridViewTask_Get
        {
            get { return dataGridViewTask.Rows; }
        }

        public DataGridViewRowCollection DataGridViewCmd_Get
        {
            get { return dataGridViewCmd.Rows; }
        }

        public List<string> DataGridViewWeb_Set
        {
            set
            {
                if (value == null)
                {
                    return;
                }
                foreach (string item in value)
                {
                    dataGridViewWeb.Rows.Add(item);
                }
            }
        }
        public List<string> DataGridViewTask_Set
        {
            set
            {
                if(value == null)
                {
                    return;
                }
                foreach (string item in value)
                {
                    dataGridViewTask.Rows.Add(item);
                }
            }
        }
        public List<PCList> DataGridViewCmd_Set
        {
            set
            {
                foreach (PCList item in value)
                {
                    dataGridViewTask.Rows.Add(item.Path, item.Command, item.Close);
                }
            }
        }

        private void ButtonWebNew_Click(object sender, EventArgs e)
        {
            dataGridViewWeb.Rows.Add();
        }

        private void ButtonTaskNew_Click(object sender, EventArgs e)
        {
            dataGridViewTask.Rows.Add();
        }

        private void ButtonCmdNew_Click(object sender, EventArgs e)
        {
            dataGridViewCmd.Rows.Add();
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

        private void ButtonTaskRef_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "実行するアプリケーションを選択してください",  // タイトル
                Filter = "すべてのファイル(*.*)|*.*|実行ファイル(*.exe)|*.exe",   // 表示するファイルの拡張子
                RestoreDirectory = true    // 現在のディレクトリを復元
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名をdataGridViewに追加
                dataGridViewTask.Rows.Add(ofd.FileName);
            }
        }

        private void ButtonWebDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewWeb.SelectedRows.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                dataGridViewWeb.Rows.Remove(dataGridViewWeb.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonTaskDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewTask.SelectedRows.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                dataGridViewTask.Rows.Remove(dataGridViewTask.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCmdDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewCmd.SelectedRows.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                dataGridViewCmd.Rows.Remove(dataGridViewCmd.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

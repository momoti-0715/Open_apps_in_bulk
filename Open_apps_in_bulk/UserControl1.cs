using JsonFileIO.Jsons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Control = System.Windows.Forms.Control;
using UserControl = System.Windows.Forms.UserControl;

namespace Open_apps_in_bulk
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            RegisterClickEvent(this);
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
                if (value == null)
                {
                    return;
                }

                foreach (PCList item in value)
                {
                    dataGridViewCmd.Rows.Add(item.Path, item.Command, item.Close);
                }
            }
        }

        private void RegisterClickEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (!(control is DataGridView))
                {
                    control.MouseDown += Control_MouseDown;
                }

                if (control.HasChildren)
                {
                    RegisterClickEvent(control);
                }
            }
        }

        private void ClearGridState(DataGridView dgv)
        {
            dgv.EndEdit();          // 編集確定
            dgv.ClearSelection();   // 選択解除
            dgv.CurrentCell = null; // フォーカス解除
        }

        private void ButtonWebNew_Click(object sender, EventArgs e)
        {
            dataGridViewWeb.Rows.Add();
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                return;
            }

            ClearGridState(dataGridViewWeb);
            ClearGridState(dataGridViewTask);
            ClearGridState(dataGridViewCmd);
        }

        private void dataGridViewWeb_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridViewWeb.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearGridState(dataGridViewWeb);
                ClearGridState(dataGridViewTask);
                ClearGridState(dataGridViewCmd);
            }
        }

        private void dataGridViewTask_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridViewTask.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearGridState(dataGridViewWeb);
                ClearGridState(dataGridViewTask);
                ClearGridState(dataGridViewCmd);
            }
        }

        private void dataGridViewCmd_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridViewCmd.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearGridState(dataGridViewWeb);
                ClearGridState(dataGridViewTask);
                ClearGridState(dataGridViewCmd);
            }
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

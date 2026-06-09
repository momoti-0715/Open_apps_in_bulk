using JsonFileIO.Jsons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Open_apps_in_bulk
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            listViewWeb.EnableInPlaceEdit();
            listViewTask.EnableInPlaceEdit();
            listViewCmd.EnableInPlaceEdit();
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

        public ListView.ListViewItemCollection ListViewWeb_Get
        {
            get { return listViewWeb.Items; }
        }

        public ListView.ListViewItemCollection ListViewTask_Get
        {
            get { return listViewTask.Items; }
        }

        public ListView.ListViewItemCollection ListViewCmd_Get
        {
            get { return listViewCmd.Items; }
        }

        public List<string> ListViewWeb_Set
        {
            set
            {
                if (value == null)
                {
                    return;
                }
                foreach (string item in value)
                {
                    listViewWeb.Items.Add(new ListViewItem(item));
                }
            }
        }
        public List<string> ListViewTask_Set
        {
            set
            {
                if(value == null)
                {
                    return;
                }
                foreach (string item in value)
                {
                    listViewTask.Items.Add(new ListViewItem(item));
                }
            }
        }
        public List<PCList> ListViewCmd_Set
        {
            set
            {
                foreach (PCList item in value)
                {
                    ListViewItem lvi = new ListViewItem(item.Path);
                    lvi.SubItems.Add(item.Command);

                    listViewCmd.Items.Add(lvi);
                }
            }
        }

        private void ButtonWebNew_Click(object sender, EventArgs e)
        {
            listViewWeb.Items.Add("");
            listViewWeb.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            SetListBackgroundColor(listViewWeb);
        }

        private void ButtonTaskNew_Click(object sender, EventArgs e)
        {
            listViewTask.Items.Add("");
            listViewTask.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            SetListBackgroundColor(listViewTask);
        }

        private void ButtonCmdNew_Click(object sender, EventArgs e)
        {
            string[] row = { "", "" };
            listViewCmd.Items.Add(new ListViewItem(row));
            listViewCmd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            SetListBackgroundColor(listViewCmd);
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
                //OKボタンがクリックされたとき、選択されたファイル名をlistに追加
                listViewTask.Items.Add(ofd.FileName);
                listViewTask.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            SetListBackgroundColor(listViewTask);
        }

        private void ButtonWebEdit_Click(object sender, EventArgs e)
        {
            listViewWeb.BeginEditSelectedRow();
        }
        private void ButtonTaskEdit_Click(object sender, EventArgs e)
        {
            listViewTask.BeginEditSelectedRow();
        }

        private void ButtonCmdEdit_Click(object sender, EventArgs e)
        {
            listViewCmd.BeginEditSelectedRow();
        }

        private void ButtonWebDel_Click(object sender, EventArgs e)
        {
            if (listViewWeb.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewWeb.Items.RemoveAt(listViewWeb.SelectedItems[0].Index);
                SetListBackgroundColor(listViewWeb);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonTaskDel_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewTask.Items.RemoveAt(listViewTask.SelectedItems[0].Index);
                SetListBackgroundColor(listViewTask);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCmdDel_Click(object sender, EventArgs e)
        {
            if (listViewCmd.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewCmd.Items.RemoveAt(listViewCmd.SelectedItems[0].Index);
                SetListBackgroundColor(listViewCmd);
            }
            else
            {
                MessageBox.Show("削除する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetListBackgroundColor(ListView list)
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.Text != null)
                {
                    item.BackColor = SystemColors.Window; // 背景色を変更
                }
            }
        }

    }
}

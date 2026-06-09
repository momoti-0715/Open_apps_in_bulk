using JsonFileIO.Jsons;
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

            //listViewWeb.EnableInPlaceEdit();
            //listViewTask.EnableInPlaceEdit();
            //listViewCmd.EnableInPlaceEdit();

            buttonWebEdit.Enabled = false;
            buttonWebDel.Enabled = false;
            buttonTaskEdit.Enabled = false;
            buttonTaskDel.Enabled = false;
            buttonCmdEdit.Enabled = false;
            buttonCmdDel.Enabled = false;
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

        private void ButtonWebNew_Click(object sender, EventArgs e)
        {
            listViewWeb.Items.Add("");
            listViewWeb.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonAppNew_Click(object sender, EventArgs e)
        {
            listViewTask.Items.Add("");
            listViewTask.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonCmdNew_Click(object sender, EventArgs e)
        {
            string[] row = {"", ""};
            listViewCmd.Items.Add(new ListViewItem(row));
            listViewCmd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
        }

        private void ButtonWebEdit_Click(object sender, EventArgs e)
        {
            //listViewWeb.BeginEditSelectedRow();
        }
        private void ButtonTaskEdit_Click(object sender, EventArgs e)
        {
            //listViewTask.BeginEditSelectedRow();
        }

        private void ButtonCmdEdit_Click(object sender, EventArgs e)
        {
            //listViewCmd.BeginEditSelectedRow();
        }

        private void ButtonWebDel_Click(object sender, EventArgs e)
        {
            if (listViewWeb.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewWeb.Items.RemoveAt(listViewWeb.SelectedItems[0].Index);
            }
        }

        private void ButtonTaskDel_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewTask.Items.RemoveAt(listViewTask.SelectedItems[0].Index);
            }
        }

        private void ButtonCmdDel_Click(object sender, EventArgs e)
        {
            if (listViewCmd.SelectedItems.Count > 0)
            {
                // 選択されたアイテムのインデックスを取得して削除
                listViewCmd.Items.RemoveAt(listViewCmd.SelectedItems[0].Index);
            }
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Button buttonEdit = new Button();
            Button buttonDel = new Button();

            if (sender == listViewWeb)
            {
                buttonEdit = buttonWebEdit;
                buttonDel = buttonWebDel;
            }
            else if (sender == listViewTask)
            {
                buttonEdit = buttonTaskEdit;
                buttonDel = buttonTaskDel;
            }
            else if (sender == listViewCmd)
            {
                buttonEdit = buttonCmdEdit;
                buttonDel = buttonCmdDel;
            }

            // 選択が解除されたとき
            if (!e.IsSelected)
            {
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
                buttonDel.Enabled = true;
            }

        }

        private void ListView_Leave(object sender, EventArgs e)
        {
            if(sender == listViewWeb)
            {
                buttonWebEdit.Enabled = false;
                buttonWebDel.Enabled = false;
            }else if (sender == listViewTask)
            {
                buttonTaskEdit.Enabled = false;
                buttonTaskDel.Enabled = false;
            }
            else if(sender == listViewCmd)
            {
                buttonCmdEdit.Enabled = false;
                buttonCmdDel.Enabled = false;
            }
        }

    }
}

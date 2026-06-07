using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace Open_apps_in_bulk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            string folderPath = @".\Shortcut\";

            if (!Directory.Exists(folderPath))   // フォルダがないとき
            {
                Directory.CreateDirectory(folderPath);  // フォルダ生成
            }

            shortcutList.Items.Clear(); // 一度リストの中身をリセット

            if (Directory.EnumerateFiles(folderPath).Any()) // フォルダ内にファイルがあるとき
            {
                string[] files = Directory.GetFiles(folderPath, "*");
                buttonEdit.Enabled = true;
                buttonDel.Enabled = true;

                foreach (string file in files)
                {
                    shortcutList.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            else
            {
                shortcutList.Items.Add("ショートカットはありません");
                shortcutList.Items.Add("新規作成してください");
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }
    }
}

using IWshRuntimeLibrary;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using File = System.IO.File;
using Path = System.IO.Path;

namespace Open_apps_in_bulk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MaximizeBox = false;    // 最大化を禁止
            FormBorderStyle = FormBorderStyle.FixedSingle;  // サイズ変更禁止

            string folderPath = @".\Shortcut\";

            if (!Directory.Exists(folderPath))   // フォルダがないとき
            {
                Directory.CreateDirectory(folderPath);  // フォルダ生成
            }

            Display_ShortcutList();
        }

        void Display_ShortcutList()
        {
            string folderPath = @".\Shortcut\";
            shortcutList.Items.Clear(); // 一度リストの中身をリセット

            if (Directory.EnumerateFiles(folderPath).Any()) // フォルダ内にファイルがあるとき
            {
                string[] files = Directory.GetFiles(folderPath, "*.exe");   // exeファイルを取得

                foreach (string file in files)
                {
                    shortcutList.Items.Add(Path.GetFileNameWithoutExtension(file)); // ショートカットの名前をリストに追加
                }
            }
            else
            {
                shortcutList.Items.Add("ショートカットはありません");    // ショートカットがないときにリストにメッセージを追加する
                shortcutList.Items.Add("新規作成してください");
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var rForm = new RegisterForm();
            rForm.ShowDialog();
            rForm.Dispose();

            buttonEdit.Enabled = false; // 編集と削除ボタンの無効化
            buttonDel.Enabled = false;
            buttonCreateShortcut.Enabled = false;
            Display_ShortcutList();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var eForm = new EditForm();
            eForm.userControl11.TextBoxSName_InputText = shortcutList.Text; // 編集フォームのショートカット名に選択されているショートカット名を入力

            eForm.ShowDialog();
            eForm.Dispose();

            buttonEdit.Enabled = false; // 編集と削除ボタンの無効化
            buttonDel.Enabled = false;
            buttonCreateShortcut.Enabled = false;
            Display_ShortcutList();
        }

        private void ShortcutList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (shortcutList.SelectedIndex != -1)
            {
                buttonEdit.Enabled = true;
                buttonDel.Enabled = true;
                buttonCreateShortcut.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
                buttonCreateShortcut.Enabled = false;
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            // 実行ファイルと設定ファイルの削除
            File.Delete(@".\Shortcut\" + shortcutList.Text + ".exe");
            File.Delete(@".\Setting\" + shortcutList.Text + ".json");
            DeleteShortcutFile(shortcutList.Text);

            buttonEdit.Enabled = false;
            buttonDel.Enabled = false;
            buttonCreateShortcut.Enabled = false;
            Display_ShortcutList();
        }

        private void ButtonCreateShortcut_Click(object sender, EventArgs e)
        {
            CreateShortcutFile(shortcutList.Text);  // ショートカット生成
        }

        private void CreateShortcutFile(string sName)
        {
            IWshShell shell = new WshShell();   // シェルオブジェクト
            IWshShortcut sc;    // ショートカットオブジェクト

            string sDeskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullPath = Path.GetFullPath(@".\Shortcut\" + sName + ".exe");
            string workingDirPath = Path.GetFullPath(@".\Shortcut");
            string shortcutPath = sDeskPath + @"\" + sName + ".lnk";

            sc = (IWshShortcut)shell.CreateShortcut(shortcutPath);  // ショートカットのパス
            sc.TargetPath = fullPath;   // 実行パス
            sc.WorkingDirectory = workingDirPath;   // 作業フォルダの設定
            sc.Save();
        }

        private void DeleteShortcutFile(string sName)
        {
            // デスクトップにショートカットがあるときに実行パスも変更する
            IWshShell shell = new WshShell();   // シェルオブジェクト
            IWshShortcut sc;    // ショートカットオブジェクト

            string sDeskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   // デスクトップの絶対パス
            string[] sFiles = Directory.GetFiles(sDeskPath, "*.lnk");  // デスクトップにあるショートカットファイルを取得
            string fullPath = Path.GetFullPath(@".\Shortcut\" + sName + ".exe");

            foreach (string sFile in sFiles)
            {
                sc = (IWshShortcut)shell.CreateShortcut(sFile);
                if (sc.TargetPath == fullPath)    // 取得したショートカットの実行ファイルが選択されたショートカットのパスと同じとき
                {
                    File.Delete(sFile); // デスクトップのショートカット削除
                }
            }
        }
    }
}

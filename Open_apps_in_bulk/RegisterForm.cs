using IWshRuntimeLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace Open_apps_in_bulk
{
    public partial class RegisterForm : Form
    {
        private string appData, settingDir, shortcutDir;

        public RegisterForm()
        {
            InitializeComponent();

            MaximizeBox = false;    // 最大化を禁止
            FormBorderStyle = FormBorderStyle.FixedSingle;  // サイズ変更禁止

            appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MatometeHirakundesu");
            settingDir = Path.Combine(appData, "Setting");
            shortcutDir = Path.Combine(appData, "Shortcut");
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ControlJson jsonControl = new ControlJson();

            string sName = userControl11.TextBoxSName_InputText;
            if (jsonControl.PrintError(labelWarning, sName) != 0) return;   // エラー文を表示するときはそのまま関数を終了する

            string browserPass = userControl11.TextBoxBrowserPass_InputText;
            DataGridViewRowCollection dataGridViewWeb = userControl11.DataGridViewWeb_Get;
            DataGridViewRowCollection dataGridViewTask = userControl11.DataGridViewTask_Get;
            DataGridViewRowCollection dataGridViewCmd = userControl11.DataGridViewCmd_Get;

            jsonControl.RegisterJson(sName, browserPass, dataGridViewWeb, dataGridViewTask, dataGridViewCmd);   // jsonの登録
            jsonControl.ExeCopy(sName);

            if (checkBox.Checked == true)
            {
                CreateShurtcutFile(sName);
            }

            Close();
        }

        private void CreateShurtcutFile(string sName)
        {
            IWshShell shell = new WshShell();   // シェルオブジェクト
            IWshShortcut sc;    // ショートカットオブジェクト

            string sDeskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullPath = Path.Combine(shortcutDir, sName + ".exe");
            string shortcutPath = sDeskPath + @"\" + sName + ".lnk";

            sc = (IWshShortcut)shell.CreateShortcut(shortcutPath);  // ショートカットのパス
            sc.TargetPath = fullPath;   // 実行パス
            sc.WorkingDirectory = shortcutDir;   // 作業フォルダの設定
            sc.Save();
        }
    }
}

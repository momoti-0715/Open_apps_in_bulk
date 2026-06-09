using JsonFileIO.Jsons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Open_apps_in_bulk
{
    public partial class RegisterForm : Form
    {
        JsonControl jsonControl = new JsonControl();
        public RegisterForm()
        {
            InitializeComponent();

            MaximizeBox = false;    // 最大化を禁止
            FormBorderStyle = FormBorderStyle.FixedSingle;  // サイズ変更禁止
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string sName = userControl11.TextBoxSName_InputText;
            if (jsonControl.PrintError(labelWarning, sName) != 0) return;   // エラー文を表示するときはそのまま関数を終了する

            SettingJson setting = new SettingJson();
            // データ設定
            // ブラウザ登録
            string browserPass = userControl11.TextBoxBrowserPass_InputText;
            if (!string.IsNullOrWhiteSpace(browserPass))
            {
                setting.Web_open.Browser = browserPass;
            }

            // urlの登録
            ListView.ListViewItemCollection listViewWeb = userControl11.ListViewWeb_Get;
            if (listViewWeb?.Count > 0)
            {
                List<string> allValues = listViewWeb.Cast<ListViewItem>()
                    .Select(item => item.Text)
                    .ToList();

                setting.Web_open.Url_list = allValues;

            }

            // アプリの登録
            ListView.ListViewItemCollection listViewTask = userControl11.ListViewTask_Get;
            if (listViewTask?.Count > 0)
            {
                List<string> allValues = listViewTask.Cast<ListViewItem>()
                    .Select(item => item.Text)
                    .ToList();

                setting.Task_open.Task_list = allValues;
            }

            // コマンドの登録
            ListView.ListViewItemCollection listViewCmd = userControl11.ListViewCmd_Get;
            if (listViewCmd?.Count > 0)
            {
                Console.WriteLine(listViewCmd.Cast<ListViewItem>());
                foreach (ListViewItem item in listViewCmd)
                {
                    string mainValue = item.Text;
                    // サブアイテムの取得
                    string subValue = item.SubItems[1].Text;

                    setting.Cmd_open.P_c_list.Add(new PCList
                    {
                        Path = mainValue,
                        Command = subValue
                    });
                }
            }

            // JSON データにシリアライズ
            var jsonWriteData = JsonConvert.SerializeObject(setting);

            using (var sw = new StreamWriter(@".\Setting\" + sName + ".json", false, Encoding.UTF8))
            {
                // JSON データをファイルに書き込み
                sw.Write(jsonWriteData);
            }


            File.Copy(@".\origin.exe", @".\Shortcut\" + sName + ".exe");

            Close();
        }
    }
}

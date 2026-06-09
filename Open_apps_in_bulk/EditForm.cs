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
using System.Windows.Controls;
using System.Windows.Forms;
using ListView = System.Windows.Forms.ListView;

namespace Open_apps_in_bulk
{
    public partial class EditForm : Form
    {
        string originSName;
        public EditForm()
        {
            InitializeComponent();

            MaximizeBox = false;    // 最大化を禁止
            FormBorderStyle = FormBorderStyle.FixedSingle;  // サイズ変更禁止
        }

        private void Form_Shown(object sender, EventArgs e) // フォームが表示された直後に動作する
        {
            originSName = userControl11.TextBoxSName_InputText; // 元のショートカット名
            Register(originSName);
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ControlJson jsonControl = new ControlJson();

            string sName = userControl11.TextBoxSName_InputText;
            if (jsonControl.PrintError(labelWarning, sName) != 0) return;   // エラー文を表示するときはそのまま関数を終了する

            // jsonファイルとexeファイルをリネーム
            File.Move(@".\Setting\" + originSName + ".json", @".\Setting\" + sName + ".json");
            File.Move(@".\Shortcut\" + originSName + ".exe", @".\Shortcut\" + sName + ".exe");

            string browserPass = userControl11.TextBoxBrowserPass_InputText;
            ListView.ListViewItemCollection listViewWeb = userControl11.ListViewWeb_Get;
            ListView.ListViewItemCollection listViewTask = userControl11.ListViewTask_Get;
            ListView.ListViewItemCollection listViewCmd = userControl11.ListViewCmd_Get;

            jsonControl.RegisterJson(sName, browserPass, listViewWeb, listViewTask, listViewCmd);   // jsonの登録

            Close();
        }

        public void Register(string sName)
        {
            SettingJson pCList = new SettingJson();

            using (var sr = new StreamReader(@".\Setting\" + sName +".json", Encoding.UTF8))
            {
                // 変数 jsonReadData にファイルの内容を代入 
                var jsonReadData = sr.ReadToEnd();

                // デシリアライズして person にセット
                pCList = JsonConvert.DeserializeObject<SettingJson>(jsonReadData);
            }

            userControl11.TextBoxBrowserPass_InputText = pCList.Web_open.Browser;
            userControl11.ListViewWeb_Set = pCList.Web_open.Url_list;
            userControl11.ListViewTask_Set = pCList.Task_open.Task_list;
            userControl11.ListViewCmd_Set = pCList.Cmd_open.P_c_list;
            
        }
    }
}

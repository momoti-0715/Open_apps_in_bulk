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

            string browserPass = userControl11.TextBoxBrowserPass_InputText;
            ListView.ListViewItemCollection listViewWeb = userControl11.ListViewWeb_Get;
            ListView.ListViewItemCollection listViewTask = userControl11.ListViewTask_Get;
            ListView.ListViewItemCollection listViewCmd = userControl11.ListViewCmd_Get;

            jsonControl.RegisterJson(sName, browserPass, listViewWeb, listViewTask, listViewCmd);
            jsonControl.ExeCopy(sName);

            Close();
        }
    }
}

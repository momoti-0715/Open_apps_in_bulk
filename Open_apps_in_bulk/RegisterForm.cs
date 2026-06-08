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
using JsonFileIO.Jsons;
using Newtonsoft.Json;

namespace Open_apps_in_bulk
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string sName = userControl11.TextBoxSName_InputText;
            string[] unusableChars = new string[] { "/", "?", "<", ">", "\\", ":", "*", "|", "\"",};

            if (string.IsNullOrWhiteSpace(sName))
            {
                PrintWarning("ショートカット名を入力してください");
                return;
            }
            else
            {
                foreach (string uChar in unusableChars)
                {
                    if (sName.Contains(uChar))
                    {
                        PrintWarning("ショートカット名に以下の文字は使用できません ( / ? < > \\ : * | \" )");
                        return;
                    }
                }

                if (File.Exists(@".\Shortcut\" + sName + ".exe"))
                {
                    PrintWarning("このショートカット名は既に存在します");
                    return;
                }
            }

            SettingJson setting = new SettingJson();
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

        private void PrintWarning(string message)
        {
            labelWarning.Text = message;
        }
    }
}

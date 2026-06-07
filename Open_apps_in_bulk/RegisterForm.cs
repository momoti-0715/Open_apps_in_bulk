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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SettingJson setting = new SettingJson();
            // JSON データにシリアライズ
            var jsonWriteData = JsonConvert.SerializeObject(setting);

            using (var sw = new StreamWriter(@",\Setting\"+"", false, Encoding.UTF8))
            {
                // JSON データをファイルに書き込み
                sw.Write(jsonWriteData);
            }

            this.Close();
        }
    }
}

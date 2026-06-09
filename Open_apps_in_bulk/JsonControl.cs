using JsonFileIO.Jsons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class JsonControl
{
    public int PrintError(Label label, string sName)
    {
        string[] unusableChars = new string[] { "/", "?", "<", ">", "\\", ":", "*", "|", "\"", };

        if (string.IsNullOrWhiteSpace(sName))
        {
            label.Text = "ショートカット名を入力してください";
            return 1;
        }
        else
        {
            foreach (string uChar in unusableChars)
            {
                if (sName.Contains(uChar))
                {
                    label.Text = "ショートカット名に以下の文字は使用できません ( / ? < > \\ : * | \" )";
                    return 1;
                }
            }

            if (File.Exists(@".\Shortcut\" + sName + ".exe"))
            {

                label.Text = "このショートカット名は既に存在します";
                return 1;
            }
        }
        return 0;
    }
}

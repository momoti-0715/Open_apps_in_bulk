using JsonFileIO.Jsons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class ControlJson
{
    static string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MatometeHirakundesu");
    string settingDir = Path.Combine(appData, "Setting");
    string shortcutDir = Path.Combine(appData, "Shortcut");

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

            if (File.Exists(Path.Combine(shortcutDir, sName + ".exe")))
            {

                label.Text = "このショートカット名は既に存在します";
                return 1;
            }
        }
        return 0;
    }

    public void RegisterJson(string sName,
        string browserPass,
        ListView.ListViewItemCollection listViewWeb,
        ListView.ListViewItemCollection listViewTask,
        ListView.ListViewItemCollection listViewCmd)
    {
        SettingJson setting = new SettingJson();
        // データ設定
        // ブラウザ登録
        if (!string.IsNullOrWhiteSpace(browserPass))
        {
            setting.Web_open.Browser = browserPass;
        }

        // urlの登録
        if (listViewWeb?.Count > 0)
        {
            List<string> allValues = listViewWeb.Cast<ListViewItem>()
                .Select(item => item.Text)
                .ToList();

            setting.Web_open.Url_list = allValues;

        }

        // アプリの登録
        if (listViewTask?.Count > 0)
        {
            List<string> allValues = listViewTask.Cast<ListViewItem>()
                .Select(item => item.Text)
                .ToList();

            setting.Task_open.Task_list = allValues;
        }

        // コマンドの登録
        if (listViewCmd?.Count > 0)
        {
            Console.WriteLine(listViewCmd.Cast<ListViewItem>());
            foreach (ListViewItem item in listViewCmd)
            {
                string mainValue = item.Text;
                // サブアイテムの取得
                string subValue = item.SubItems[1].Text;

                if (string.IsNullOrWhiteSpace(mainValue))
                {
                    mainValue = null;
                }
                if (string.IsNullOrWhiteSpace(subValue))
                {
                    subValue = null;
                }

                setting.Cmd_open.P_c_list.Add(new PCList
                {
                    Path = mainValue,
                    Command = subValue
                });
            }
        }

        // JSON データにシリアライズ
        var jsonWriteData = JsonConvert.SerializeObject(setting);

        var utf8WithBom = new UTF8Encoding(false); // BOMなし

        string jsonFile = Path.Combine(settingDir, sName + ".json");

        using (var sw = new StreamWriter(jsonFile, false, utf8WithBom))
        {
            // JSON データをファイルに書き込み
            sw.Write(jsonWriteData);
        }
    }

    public void ExeCopy(string sName)
    {
        string exeFile = Path.Combine(shortcutDir, sName + ".exe");
        File.Copy(@".\origin.exe", exeFile);
    }
}

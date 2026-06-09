using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;

namespace JsonFileIO.Jsons
{
    [JsonObject("SettingJson")]
    public sealed class SettingJson
    {
        [JsonProperty("web_open")]
        public WebOpen Web_open { get; set; } = new WebOpen();

        [JsonProperty("cmd_open")]
        public CmdOpen Cmd_open { get; set; } = new CmdOpen();

        [JsonProperty("task_open")]
        public TaskOpen Task_open { get; set; } = new TaskOpen();

    }

    public class WebOpen
    {
        [JsonProperty("browser")]
        public string Browser { get; set; } = null;

        [JsonProperty("url_list")]
        public List<string> Url_list { get; set; } = null;
    }

    public class CmdOpen
    {
        [JsonProperty("p_c_list")]
        public List<PCList> P_c_list { get; set; } = new List<PCList>();
    }

    public class PCList
    {
        [JsonProperty("path")]
        public string Path { get; set; } = null;

        [JsonProperty("command")]
        public string Command { get; set; } = null;
    }

    public class TaskOpen
    {
        [JsonProperty("task_list")]
        public List<string> Task_list { get; set; } = null;
    }
}

// Jsonファイルの構成イメージ
//{
//    "web_open": {
//        "browser": "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
//        "url_list": [
//            "https://www.google.com"
//        ]
//    },
//    "cmd_open": {
//        "p_c_list": [
//            {
//            "path": null,
//            "command": "ls"
//            }
//        ]
//    },
//    "task_open": {
//        "task_list": []
//    }
//}
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Documents;

namespace JsonFileIO.Jsons
{
    [JsonObject("SettingJson")]
    public sealed class SettingJson
    {
        [JsonProperty("web_open")]
        public WebOpen web_open { get; set; } = new WebOpen();

        [JsonProperty("cmd_open")]
        public CmdOpen cmd_open { get; set; } = new CmdOpen();

        [JsonProperty("task_open")]
        public TaskOpen task_open { get; set; } = new TaskOpen();

    }

    public class WebOpen
    {
        [JsonProperty("browser")]
        public string browser { get; set; } = null;

        [JsonProperty("url_list")]
        public List<string> url_list { get; set; } = null;
    }

    public class CmdOpen
    {
        [JsonProperty("p_c_list")]
        public List<PCList> p_c_list { get; set; } = new List<PCList>();
    }

    public class PCList
    {
        [JsonProperty("path")]
        public string path { get; set; } = null;

        [JsonProperty("command")]
        public string command { get; set; } = null;
    }

    public class TaskOpen
    {
        [JsonProperty("task_list")]
        public List<string> task_list { get; set; } = null;
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
//                "command": "ls"
//            }
//        ]
//    },
//    "task_open": {
//        "task_list": []
//    }
//}
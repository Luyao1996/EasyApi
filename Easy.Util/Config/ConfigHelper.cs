using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Easy.Util.Config
{
    /// <summary>
    /// 配置文件读取类
    /// 静态缓存 可手动刷新
    /// </summary>
    public class ConfigHelper
    {
        public static JObject JobjConfig { get; private set; }

        static ConfigHelper()
        {
            ReadConfig();
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        private static void ReadConfig()
        {
            JobjConfig = null;
            string contentPath = AppContext.BaseDirectory + @"\"; ;   //项目根目录
            var filePath = contentPath + "appsettings.json";
            using (StreamReader file = new StreamReader(filePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jObj = (JObject)JToken.ReadFrom(reader);
                JobjConfig = jObj;
            }
        }

        /// <summary>
        /// 重新加载缓存
        /// </summary>
        public static void ReLoadConfig()
        {
            ReadConfig();
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy.Util
{
    public static class MyConvert
    {
        public static int ToInt32(this object i)
        {
            return MyConvert.ToInt32(i);
        }
        public static DateTime ToDatetime(this object time)
        {
            return Convert.ToDateTime(time);
        }

        public static string ToJson<T>(this T t)
        {
            return JsonConvert.SerializeObject(t);
        }
        public static T ToModel<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

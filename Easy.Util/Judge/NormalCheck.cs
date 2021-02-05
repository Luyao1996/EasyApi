using System;
using System.Collections.Generic;
using System.Text;

namespace Easy.Util.Judge
{
    public static class NormalCheck
    {
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}

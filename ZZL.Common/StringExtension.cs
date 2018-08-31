using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZL.Common
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string strSource)
        {
            return string.IsNullOrEmpty(strSource);
        }

        public static int TryToInt(this string strSource)
        {
            int defVal;

            int.TryParse(strSource, out defVal);

            return defVal;

        }
    }
}

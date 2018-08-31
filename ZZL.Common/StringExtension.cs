using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static string ToMD5(this string strSource)
        {
            MD5 md = MD5.Create();

            byte[] by = md.ComputeHash(Encoding.UTF8.GetBytes(strSource));

            StringBuilder strBulider = new StringBuilder(200);
            foreach (var item in by)
            {
                strBulider.Append(item.ToString("X2"));
            }

            return strBulider.ToString();
        }
    }
}

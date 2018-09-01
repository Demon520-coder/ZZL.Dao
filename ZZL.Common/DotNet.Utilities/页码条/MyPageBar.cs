using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.BookShop.Common
{
   public class MyPageBar
    {
       public static string CreatePageBar(int pageIndex, int pageCount)
       {
           if (pageCount == 1)
           {
               return string.Empty;
           }
           int start = pageIndex - 5;//计算起始位置.
           start = start < 1 ? 1 : start;
           int end = start + 9;//计算终止位置.
           end = end > pageCount ? pageCount : end;
           StringBuilder sb=new StringBuilder();
           for (int i = start; i <= end;i++)
           {
               if (i == pageIndex)
               {
                   sb.Append(i);
               }
               else
               {
                   sb.Append(string.Format("<a href='?pageIndex={0}'>{0}</a>",i));
               }
           }
           return sb.ToString();
       }
    }
}

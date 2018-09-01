using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CZBK.Shop.Common
{
   public class CacheHelper
    {
       /// <summary>
       /// 根据键从缓存中取出数据
       /// </summary>
       /// <param name="key"></param>
       /// <returns></returns>
       public static object Get(string key)
       {
           System.Web.Caching.Cache cache = HttpRuntime.Cache;
           return cache[key];
       }
       public static void Insert(string key, object value)
       {
           System.Web.Caching.Cache cache = HttpRuntime.Cache;
           cache.Insert(key, value);
       }
    }
}

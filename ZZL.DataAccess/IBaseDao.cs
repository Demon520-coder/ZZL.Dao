using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZL.DataAccess
{
    /// <summary>
    /// 定义数据基础访问方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDao<T, TKey> where T : EntityBase<TKey>, new()
    {
        /// <summary>
        /// 判断某个字段数据是否存在
        /// </summary>
        /// <param name="param"></param>
        /// <param name="sqlId"></param>
        /// <returns></returns>
        bool IsExists(object param, string sqlId = "IsExists");


        IEnumerable<T> GetList(object param, string sqlId = "GetList");


        T Find(TKey key, string sqlId = "GetEntity");


        IEnumerable<T> GetListByPage(object param, string sqlId = "GetListByPage");


        int GetRecord(object param, string sqlId = "GetRecord");


        bool Save(T entity, string sqlId = "Insert");


        bool Update(T entity, string sqlId = "Update");


        bool DeleteByPhysic(TKey key, string sqlId = "DeleteByPhysic");


        IEnumerable<TOut> GetList<TOut>(object param, string sqlId = "GetList");


        IEnumerable<TOut> GetListByPage<TOut>(object param, string sqlId = "GetListByPage");
    }
}

using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZL.Common;

namespace ZZL.DataAccess
{
    public class BaseDao<T, TKey> : IBaseDao<T, TKey> where T : EntityBase<TKey>, new()
    {
        protected ISmartSqlMapper sqlMapper = SmartSql.MapperContainer.Instance.GetSqlMapper();

        protected string Scope
        {
            get
            {
                return typeof(T).GetCustomAttributeValueWithNoCache<ScopeAttribute>(s => s.Name);
            }
        }

        public bool DeleteByPhysic(TKey key, string sqlId = "DeleteByPhysic")
        {
            return sqlMapper.Execute(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = new { Id = key }
            }) > 0;
        }

        public T Find(TKey key, string sqlId = "GetEntity")
        {
            return sqlMapper.QuerySingle<T>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = new { Id = key }
            });
        }

        public IEnumerable<T> GetList(object param, string sqlId = "GetList")
        {
            return sqlMapper.Query<T>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = param
            });
        }

        public IEnumerable<TOut> GetList<TOut>(object param, string sqlId = "GetList")
        {
            return sqlMapper.Query<TOut>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = param
            });
        }

        public IEnumerable<T> GetListByPage(object param, string sqlId = "GetListByPage")
        {
            return sqlMapper.Query<T>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = param
            });
        }

        public IEnumerable<TOut> GetListByPage<TOut>(object param, string sqlId = "GetListByPage")
        {
            return sqlMapper.Query<TOut>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = param
            });
        }

        public int GetRecord(object param, string sqlId = "GetRecord")
        {
            return sqlMapper.ExecuteScalar<int>(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = param
            });
        }

        public bool IsExists(object param, string sqlId = "IsExists")
        {
            return GetRecord(param, sqlId) > 0;
        }

        public bool Save(T entity, string sqlId = "Insert")
        {
            return sqlMapper.Execute(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = entity
            }) > 0;
        }

        public bool Update(T entity, string sqlId = "Update")
        {
            return sqlMapper.Execute(new RequestContext
            {
                Scope = Scope,
                SqlId = sqlId,
                Request = entity
            }) > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Webdiyer.WebControls.Mvc;

namespace WebLibrary
{
    /// <summary>
    /// 业务服务基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BLLService<T>
        where T : class
    {
        /// <summary>
        /// 数据访问上下文
        /// </summary>
        protected DbContext DbContext { get; set; }

        public BLLService(DbContext dbcontext)
        {
            DbContext = dbcontext;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Added;
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Deleted;
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Modified;
            return  DbContext.SaveChanges()>0;         
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public T GetModel(params object[] keyValues)
        {
            return DbContext.Set<T>().Find(keyValues);
        }

        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public PagedList<T> GetModelList<Tkey>(Expression<Func<T,bool>> where,Expression<Func<T,Tkey>> order,int page,int pagesize=20)
        {
            return DbContext.Set<T>().Where(where).OrderBy(order).ToPagedList(page, pagesize);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

        public bool Add(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Added;
            return DbContext.SaveChanges() > 0;
        }

        public bool Delete(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Deleted;
            return DbContext.SaveChanges() > 0;
        }

        public bool Update(T model)
        {
            DbContext.Entry<T>(model).State = EntityState.Modified;
            return  DbContext.SaveChanges()>0;
           
        }

    }
}

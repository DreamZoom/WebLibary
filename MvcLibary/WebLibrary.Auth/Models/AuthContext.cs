using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebLibrary.Auth
{
    /// <summary>
    /// 权限数据库
    /// </summary>
    public class AuthContext : DbContext
    {

        public AuthContext()
            : base("name=Auth_ConnectionString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 权限列表
        /// </summary>
        public DbSet<Auth> Auths { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        public DbSet<Role> Roles { get; set; }
    }
}

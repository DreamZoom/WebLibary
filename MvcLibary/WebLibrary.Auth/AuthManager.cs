using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Auth
{
    public static class AuthManager
    {
        #region Auth 相关操作

        /// <summary>
        /// 添加到权限
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        public static bool addAuth(string controllerName, string actionName, string authName)
        {
            AuthContext db = new AuthContext();
            db.Auths.Add(new Auth()
            {
                ActionName = actionName,
                AuthName = authName,
                ControllerName = controllerName,
            });

            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// 删除一个权限
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public static bool removeAuth(string controllerName, string actionName)
        {
            AuthContext db = new AuthContext();
            var auth = db.Auths.FirstOrDefault(m => m.ControllerName == controllerName && m.ActionName == actionName);
            db.Auths.Remove(auth);
            return db.SaveChanges() > 0;
        }

        #endregion

        #region Role 相关操作

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="auths"></param>
        /// <param name="isSystem"></param>
        /// <returns></returns>
        public static bool addRole(string roleName, IEnumerable<Auth> auths, bool isSystem = false)
        {
            AuthContext db = new AuthContext();
            var role = db.Roles.Add(new Role()
            {
                RoleName = roleName,
                IsSystem = isSystem
            });

            foreach (var au in auths)
            {
                role.Auths.Add(au);
            }

            return db.SaveChanges() > 0;
        }


        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool removeRole(int ID)
        {
            AuthContext db = new AuthContext();
            var role = db.Roles.FirstOrDefault(m => m.ID == ID && m.IsSystem == false);
            if (role != null)
            {
                db.Roles.Remove(role);
            }
            return db.SaveChanges() > 0;
        }


        /// <summary>
        /// 修改角色权限
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="auths"></param>
        /// <returns></returns>
        public static bool updateRoleAuths(int ID, IEnumerable<Auth> auths)
        {
            AuthContext db = new AuthContext();
            var role = db.Roles.FirstOrDefault(m => m.ID == ID && m.IsSystem == false);
            if (role != null)
            {
                role.Auths.Clear();
                foreach (var au in auths)
                {
                    role.Auths.Add(au);
                }

            }
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// 验证权限
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public static bool Verify(int roleID, string controllerName, string actionName)
        {
            AuthContext db = new AuthContext();
            var role = db.Roles.FirstOrDefault(m => m.ID == roleID);
            if (role != null)
            {
                var au = role.Auths.FirstOrDefault(m => m.ActionName == actionName && m.ControllerName == controllerName);
                if (au != null) return true;
            }
            return false;
        }

        #endregion
    }
}

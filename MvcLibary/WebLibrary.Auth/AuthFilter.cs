using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;


namespace WebLibrary.Auth
{
    public class AuthFilter : ActionFilterAttribute
    {
        /// <summary>
        /// 在action执行之前执行
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var actionName = filterContext.ActionDescriptor.ActionName; 
            
            var returnUrl = System.Configuration.ConfigurationManager.AppSettings["auth_return_url"];
            var url = filterContext.HttpContext.Request.Url.ToString();
            returnUrl += "?back_url=" + url;

            if (filterContext.HttpContext.Session["RoleID"] == null)
            {
                filterContext.Result = new RedirectResult(returnUrl);
                return;
            }

            var roleID = Convert.ToInt32(filterContext.HttpContext.Session["RoleID"]);
           
            
            if (!AuthManager.Verify(roleID, controllerName, actionName))
            {
                filterContext.Result = new RedirectResult(returnUrl);
            }
            //base.OnActionExecuting(filterContext);
        }
    }
}

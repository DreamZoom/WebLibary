using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebLibrary
{
    public class ManageBase<T> : System.Web.Mvc.Controller
         where T : class
    {
        protected BLLService<T> BllService = null;
        

        public ManageBase()
        {
            BllService = getService();
        }

        protected virtual BLLService<T> getService()
        {
            return null;
        }
        public virtual ActionResult List()
        {
            var list = BllService.GetModelList();
            return View(list);
        }

        public virtual ActionResult Create()
        {
            return View();
        }

        public virtual ActionResult Edit()
        {
            return View();
        }

        public virtual ActionResult Details()
        {
            return View();
        }

        public virtual ActionResult Delete()
        {
            return View();
        }


        
         
    }
}

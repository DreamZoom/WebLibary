using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString EditModel(this HtmlHelper helper)
        {
            var model = helper.ViewData.Model;

            var propertys = helper.ViewData.ModelMetadata.Properties;

            foreach(var p in propertys){
                
            }

            return new MvcHtmlString("");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// 编辑模型
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static MvcHtmlString EditModel(this HtmlHelper helper)
        {
            var propertys = helper.ViewData.ModelMetadata.Properties;
            StringBuilder sb = new StringBuilder();
            foreach (var p in propertys)
            {
                if (!p.ShowForEdit) continue;

                if (p.IsComplexType) continue;

                string item = string.Format("<div class='field-label'>{0}</div>", p.DisplayName ?? p.PropertyName);
                item += string.Format("<div class='field-show'>{0}</div>", helper.Editor(p.PropertyName));
                sb.AppendFormat("<li>{0}</li>", item);
            }
            return new MvcHtmlString(sb.ToString());
        }


        /// <summary>
        /// 修改模型
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static MvcHtmlString ShowModel(this HtmlHelper helper)
        {
            var propertys = helper.ViewData.ModelMetadata.Properties;
            StringBuilder sb = new StringBuilder();
            foreach (var p in propertys)
            {
                if (!p.ShowForDisplay) continue;
                if (p.IsComplexType) continue;

                string item = string.Format("<div class='field-label'>{0}</div>", p.DisplayName ?? p.PropertyName);
                item += string.Format("<div class='field-show'>{0}</div>", helper.Display(p.PropertyName));
                sb.AppendFormat("<li>{0}</li>", item);
            }
            return new MvcHtmlString(sb.ToString());
        }

    }
}

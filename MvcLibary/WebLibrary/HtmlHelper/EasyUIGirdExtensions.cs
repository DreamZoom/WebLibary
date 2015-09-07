using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System.Web.Mvc
{
    public static class EasyUIGirdExtensions
    {
        public static MvcHtmlString EasyUIGird<T>(this HtmlHelper helper,IEnumerable<T> list)
        {
            var propertys = typeof(T).GetProperties();

            List<string> headers = propertys.ToList().ConvertAll(m => getFiledName(m));

            string tHead =string.Format("<thead><tr>{0}</tr></thead>", string.Join("",headers));

            StringBuilder tBody = new StringBuilder();
            tBody.AppendLine("<table class=\"easyui-datagird\">");
             tBody.AppendLine(tHead);
            tBody.AppendLine("<tbody>");
            foreach(var model in list){
                tBody.AppendLine(string.Format("<tr>{0}</tr>", string.Join("",propertys.ToList().ConvertAll(m => getFiledValue(m,model)))));
            }
            tBody.AppendLine("</tbody>");
             tBody.AppendLine("</table>");
            return MvcHtmlString.Create(tBody.ToString());
        }

        private static string getFiledName(PropertyInfo property)
        {
            return string.Format("<th>{0}</th>",property.Name);
        }

        private static string getFiledValue(PropertyInfo property,object model)
        {
            return string.Format("<td>{0}</td>", property.GetValue(model));
        }
    }


   
}

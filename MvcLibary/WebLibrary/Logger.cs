using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    /// <summary>
    /// 日志记录器
    /// </summary>
    public class Logger
    {
        static string LogPath = System.Configuration.ConfigurationManager.AppSettings["LoggerPath"];

        public void Log(object o)
        {

        }

        public void Debug(object o)
        {

        }

        public void Info(object o)
        {

        }

        public void Error(object o)
        {

        }

        public void Success(object o)
        {

        }

        private void WriteLog(string type, string log)
        {

        }
    }
}

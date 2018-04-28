using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService
{
    public enum PowerLogFileType
    {
        Info = 0,

        Error = 1,

        Success = 2,

        Debug = 3,

        Fatal = 4,

        Warn = 5,
    }
    //https://blog.csdn.net/liyan530/article/details/77821900
    //https://www.cnblogs.com/xiekeli/p/4611113.html
    public class PowerLog
    {
        public ILog Logger { get; set; }

        public PowerLog(ILog _logger)
        {
            this.Logger = _logger;
        }

        public void Write(PowerLogFileType logtype, string content, bool iscover)
        {
            //string work = this.Logger.Logger.Name.Replace("QuartzWinService.Jobs.", "");
            switch (logtype)
            {
                case PowerLogFileType.Info:
                    this.Logger.InfoFormat(content);
                    break;
                case PowerLogFileType.Success:
                    this.Logger.InfoFormat(content);
                    break;
                case PowerLogFileType.Debug:
                    this.Logger.DebugFormat(content);
                    break;
                case PowerLogFileType.Error:
                    this.Logger.ErrorFormat(content);
                    break;
                case PowerLogFileType.Fatal:
                    this.Logger.FatalFormat(content);
                    break;
                case PowerLogFileType.Warn:
                    this.Logger.WarnFormat(content);
                    break;
                default:
                    break;
            }
        }

        public void WriteErr(string content)
        {
            Write(PowerLogFileType.Error, content, false);
        }

        public void WriteLog(string content)
        {
            Write(PowerLogFileType.Info, content, false);
        }

        public void WriteSucc(string content)
        {
            Write(PowerLogFileType.Success, content, false);
        }

        public void WriteDebug(string content)
        {
            Write(PowerLogFileType.Debug, content, false);
        }

        public void WriteFatal(string content)
        {
            Write(PowerLogFileType.Fatal, content, false);
        }

        public void WriteWarn(string content)
        {
            Write(PowerLogFileType.Warn, content, false);
        }
    }
}

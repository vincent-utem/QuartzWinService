using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace QuartzWinService
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取服务运行根目录下的log4net.config文件
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));

            HostFactory.Run(x =>
            {
                x.UseLog4Net();

                x.Service<ServiceRunner>();

                //windows服务描述
                x.SetDescription(ServiceConfig.Description);
                //windows服务在服务列表中显示名称
                x.SetDisplayName(ServiceConfig.DisplayName);
                //windows服务在进程中显示名称
                x.SetServiceName(ServiceConfig.Name);

                x.EnablePauseAndContinue();
            });
        }
    }
}

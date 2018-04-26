using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService
{
    public static class ServiceConfig
    {
        //windows服务在进程中显示名称
        public static string Name = "QuartzWinService";

        //windows服务在服务列表中显示名称
        public static string DisplayName = "QuartzWinService";

        //windows服务描述
        public static string Description = "基于Quartz.net的WinService，支持分布式部署";
    }
}

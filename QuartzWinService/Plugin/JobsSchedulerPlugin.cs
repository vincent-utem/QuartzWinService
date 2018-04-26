using log4net;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService.Plugin
{
    public class JobsSchedulerPlugin : ISchedulerPlugin
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(JobsSchedulerPlugin));

        public void Initialize(string pluginName, IScheduler sched)
        {
            _logger.InfoFormat("调度器插件实例化");
        }
        public void Start()
        {
            _logger.InfoFormat("调度器开启");

            //服务启动之前要预先加载的逻辑写在这里

        }
        public void Shutdown()
        {
            _logger.InfoFormat("调度器关闭");

            //服务关闭之前要处理的逻辑写在这里

        }
    }
}

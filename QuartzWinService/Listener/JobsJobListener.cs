using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService.Listener
{
    public class JobsJobListener : IJobListener
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(JobsJobListener));

        public string Name { get; set; }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            _logger.InfoFormat("暂时不知什么时候被执行");
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            _logger.InfoFormat("作业准备执行");
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            _logger.InfoFormat("作业执行结束");
        }
    }
}

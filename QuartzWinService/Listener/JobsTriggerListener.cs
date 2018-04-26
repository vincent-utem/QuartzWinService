using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService.Listener
{
    public class JobsTriggerListener : ITriggerListener
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(JobsTriggerListener));

        public string Name { get; set; }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            _logger.InfoFormat("trigger完成时调用\r\n\r\n");
        }
        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            _logger.InfoFormat("trigger执行时调用");
        }
        public void TriggerMisfired(ITrigger trigger)
        {
            _logger.InfoFormat("错过触发时调用(例：线程不够用的情况下)");
        }
        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            //Trigger触发后，job执行时调用本方法。true即否决，job后面不执行。
            return false;
        }
    }
}

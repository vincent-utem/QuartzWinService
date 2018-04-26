using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWinService.Jobs.JobTemplate
{
    public class Work : IJob
    {
        private readonly PowerLog _logger = new PowerLog(LogManager.GetLogger(typeof(Work)));

        public void Execute(IJobExecutionContext context)
        {
            //任务逻辑代码写这里
            _logger.WriteLog("记录当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));



        }
    }
}

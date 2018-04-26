using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace QuartzWinService
{
    public class ServiceRunner : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler scheduler;

        public ServiceRunner()
        {
            #region [创建作业调度池 - 配置默认取程序同级目录下的quartz.config]
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
            #endregion



            #region [创建作业调度池 - 配置写在程序里]
            //NameValueCollection properties = new NameValueCollection();

            ////存储类型
            //properties["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz";
            ////表明前缀
            //properties["quartz.jobStore.tablePrefix"] = "QRTZ_";
            ////驱动类型
            //properties["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.SqlServerDelegate, Quartz";                //数据源名称
            //properties["quartz.jobStore.dataSource"] = "QuartzDemo";
            ////连接字符串
            //properties["quartz.dataSource.QuartzDemo.connectionString"] = ConfigurationManager.ConnectionStrings["QuartzDemoConn"].ConnectionString;
            ////sqlserver版本 SqlServer-20
            //properties["quartz.dataSource.QuartzDemo.provider"] = ConfigurationManager.ConnectionStrings["QuartzDemoConn"].ProviderName;
            ////最大链接数
            ////properties["quartz.dataSource.QuartzDemo.maxConnections"] = "5";


            ////线程相关
            //properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
            //properties["quartz.threadPool.threadCount"] = "10";
            //properties["quartz.threadPool.threadPriority"] = "Normal";

            ////作业相关
            //properties["quartz.plugin.xml.type"] = "Quartz.Plugin.Xml.XMLSchedulingDataProcessorPlugin, Quartz";
            //properties["quartz.plugin.xml.fileNames"] = "~/quartz_jobs.xml";

            ////作业监控服务端
            //properties["quartz.scheduler.exporter.type"] = "Quartz.Simpl.RemotingSchedulerExporter, Quartz";
            //properties["quartz.scheduler.exporter.port"] = "555";
            //properties["quartz.scheduler.exporter.bindName"] = "QuartzScheduler";
            //properties["quartz.scheduler.exporter.channelType"] = "tcp";
            //properties["quartz.scheduler.exporter.channelName"] = "httpQuartz";

            ////是否集群
            //properties["quartz.jobStore.clustered"] = "true";
            //properties["quartz.scheduler.instanceId"] = "AUTO";

            //ISchedulerFactory sf = new StdSchedulerFactory(properties);
            //scheduler = sf.GetScheduler();
            #endregion

            #region [添加Trigger监听器相关方法]
            //var myTriggerListener = new JobsTriggerListener();
            //myTriggerListener.Name = "myTriggerListener";

            ////添加监听器到指定的trigger
            //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, KeyMatcher<TriggerKey>.KeyEquals(new TriggerKey("TestJobTrigger", "Test")));

            ////添加监听器到指定分类的所有监听器。
            //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, GroupMatcher<TriggerKey>.GroupEquals("Test"));

            ////添加监听器到指定分类的所有监听器。
            //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, GroupMatcher<TriggerKey>.GroupEquals("Test"));

            ////添加监听器到指定的2个分组。
            //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, GroupMatcher<TriggerKey>.GroupEquals("Test"), GroupMatcher<TriggerKey>.GroupEquals("Test2"));

            ////添加监听器到所有的触发器上。
            //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, GroupMatcher<TriggerKey>.AnyGroup());
            #endregion

            #region [添加Job监听器相关方法]
            //var myJobListener = new JobsJobListener();
            //myJobListener.Name = "myJobListener";

            ////Adding a JobListener that is interested in a particular job:
            //scheduler.ListenerManager.AddJobListener(myJobListener, KeyMatcher<JobKey>.KeyEquals(new JobKey("TestJob", "Test")));

            ////Adding a JobListener that is interested in all jobs of a particular group:
            //scheduler.ListenerManager.AddJobListener(myJobListener, GroupMatcher<JobKey>.GroupEquals("Test"));

            ////Adding a JobListener that is interested in all jobs of two particular groups:
            //scheduler.ListenerManager.AddJobListener(myJobListener,
            //OrMatcher<JobKey>.Or(GroupMatcher<JobKey>.GroupEquals("Test"), GroupMatcher<JobKey>.GroupEquals("Test2")));

            ////Adding a JobListener that is interested in all jobs:
            //scheduler.ListenerManager.AddJobListener(myJobListener, GroupMatcher<JobKey>.AnyGroup());
            #endregion
        }

        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown(true);
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }
    }
}

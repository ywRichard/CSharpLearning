using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace _07_MvcOA.Quartz
{
    class Program
    {
        static void Main(string[] args)
        {
            //IScheduler sched;
            //ISchedulerFactory sf = new StdSchedulerFactory();
            //sched = sf.GetScheduler();
            //JobDetail job =new JobDetail("job1","group1",typeof(IndexJob));
            //DateTime ts = TriggerUtils.GetNextGivenSecondDate(null, 5);
            //TimeSpan interval = TimeSpan.FromSeconds(5);
            ////每若干小时运行一次，小时间隔由appsetting中的IndexIntervalHour参数指定
            //var trigger = new SimpleTrigger("trigger1","group1","job1","group1",ts,null,SimpleTrigger.RepeatIndefinitely,interval);

            //sched.AddJob(job,true);
            //sched.ScheduleJob(trigger);
            //sched.Start();
            //Console.ReadKey();
        }
    }
}

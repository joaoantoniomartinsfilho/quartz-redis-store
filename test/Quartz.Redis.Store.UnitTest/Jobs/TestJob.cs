﻿using Common.Logging;

namespace Quartz.Redis.Store.UnitTest.Jobs
{
    [PersistJobDataAfterExecution]
    [DisallowConcurrentExecution]
    [JobCron("0/5 * * * * ?",name:"testjob")]
    public class TestJob : IJob
    {
        protected ILog Logger = LogManager.GetLogger(typeof(TestJob));
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                Logger.Debug(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "TestJob");
            });
        }

    }
}

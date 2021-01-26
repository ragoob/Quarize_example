using Quartz;
using Quartz.Spi;
using System;

public class SingletonJobFactory : IJobFactory
{
    private readonly IServiceProvider _serviceProvider;
    public SingletonJobFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
    {
        try
        {
            return _serviceProvider.GetService(bundle.JobDetail.JobType) as IJob;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message } | {ex.ToString()}");
            return null;
            //throw ex;
        }
    }

    public void ReturnJob(IJob job) { }
}

using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarize
{
    [DisallowConcurrentExecution]
    public class GenerateReportJob : IJob
    {
        public GenerateReportJob()
        {

        }

        public async Task Execute(IJobExecutionContext context)
        {
            // Read data from the table that contains the jobs and move the logic of the report here 
            // you can save the data that you need inside the table for exampl you need some data 
            // request by user such as branches etc you can seralize this paramters when user request the report
            // and inside this function deserlized it and do the logic of generate report and sending emails 
            // the job will run every 5 min you can change it from startup 
            // this line    services.AddSingleton(new JobSchedule(jobType: typeof(GenerateReportJob), intervals: 5,true, 5));

            await Task.FromResult("The Task");

            Console.WriteLine("Do something");
        }
    }
}

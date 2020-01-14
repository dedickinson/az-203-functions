using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace az_203_functions
{
    public static class QueueTriggerFunc
    {
        [FunctionName("QueueTriggerFunc")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "MyQueue")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}

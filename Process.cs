using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MSI
{
    public class Process
    {
        [FunctionName("Process")]
        public void Run([ServiceBusTrigger("myqueue")]string myQueueItem,
        [Blob("payloads/{rand-guid}.txt", Connection = "Payloads")]out string payload,
        ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
            payload = myQueueItem;
        }
    }
}

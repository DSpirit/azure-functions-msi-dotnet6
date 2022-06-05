using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace MSI
{
    public static class Function
    {
        [FunctionName("AddBlob")]
        public static IActionResult AddBlob(
            [HttpTrigger(Route = "blobs")]HttpRequest req,
            [Blob("payloads/{rand-guid}.txt", Connection = "Payloads")]out string payload,
            ILogger log)
        {
            payload = Guid.NewGuid().ToString();

            return new OkResult();
        }


        [FunctionName("AddMessage")]
        public static async Task<IActionResult> AddMessage(
            [HttpTrigger(Route = "messages")]HttpRequest req,
            [ServiceBus("myqueue")] IAsyncCollector<ServiceBusMessage> messages,
            ILogger log)
        {
            string body = await new StreamReader(req.Body).ReadToEndAsync();
            await messages.AddAsync(new ServiceBusMessage(body));

            return new OkResult();
        }
    }
}

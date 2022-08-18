
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class operation
    {
        [FunctionName("operation")]
        public static int Run([HttpTrigger(AuthorizationLevel.Function,"post", Route = null)]HttpRequest req, ILogger log)
        {

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            var data = JsonConvert.DeserializeObject<Numbers>(requestBody);
            var operation = data.Operation;
            var a = data.A;
            var b = data.B;
            int result = -1;

                switch (operation)
                {
                    case "addition":
                        result = addition(a, b);
                        break;
                    case "substraction":
                        result = substraction(a, b);
                        break;
                    default: break;

                }



            return (int)result;
        }
        public static int addition(int a,int b)
        {
            return a + b;
        }
        public static int substraction(int a, int b)
        {
            return a - b;
        }
        public static int division(int a, int b)
        {
            return a - b;
        }
    }
}

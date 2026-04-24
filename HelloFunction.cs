using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MyFunctionApp
{
    public static class HelloFunction
{
    [FunctionName("HelloFunction")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req,
        ILogger log)
    {
        string name = req.Query["name"];
        return new OkObjectResult($"Hello, {name ?? "World"}!");
    }
}
}

using System;
using Microsoft.Extensions.Configuration;

namespace PathfinderIM.CLI.Services
{
    public class ConsoleApplication : IApplication
    {
        private readonly IConfiguration _configuration;
        private readonly ITestService _testService;

        public ConsoleApplication(IConfiguration configuration, ITestService testService)
        {
            _configuration = configuration;
            _testService = testService;
        }

        public void Run()
        {
            Console.WriteLine("Starting run...");

            var location = _configuration.GetValue<string>("Location");
            _testService.DoSomething();
            _testService.SaySomething(location);

            Console.WriteLine("Closing Program...");
        }
    }
}

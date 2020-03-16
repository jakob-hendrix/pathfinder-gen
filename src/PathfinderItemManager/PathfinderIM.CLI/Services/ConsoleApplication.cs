using System;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using PathfinderIM.CLI.DataAccess;

namespace PathfinderIM.CLI.Services
{
    public class ConsoleApplication : IApplication
    {
        private readonly IConfiguration _configuration;
        private readonly SampleDbContext _dbContext;
        private readonly ITestService _testService;

        public ConsoleApplication(IConfiguration configuration, SampleDbContext dbContext, ITestService testService)
        {
            _configuration = configuration;
            _dbContext = dbContext;
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

using System;
using Microsoft.Extensions.Logging;

namespace PathfinderIM.CLI.Services
{
    public class TestService : ITestService
    {
        private readonly ILogger<TestService> _logger;

        public TestService(ILogger<TestService> logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.Log(LogLevel.Information, "Informational Log");
            _logger.Log(LogLevel.Critical, "Critical Log");
            _logger.Log(LogLevel.Debug, "Debug Log");
            _logger.Log(LogLevel.Error, "Error Log");

            Console.WriteLine($"Doing something...");
            Console.WriteLine($"Doing something else...");
        }

        public void SaySomething(string message)
        {
            _logger.LogInformation($"Saying {message}");
            Console.WriteLine($"I do say, \"{message}\".");
        }
    }

    public interface ITestService
    {
        void DoSomething();
        void SaySomething(string message);
    }
}

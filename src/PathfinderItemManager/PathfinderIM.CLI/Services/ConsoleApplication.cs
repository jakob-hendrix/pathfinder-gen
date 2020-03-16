using System;

namespace PathfinderIM.CLI.Services
{
    public class ConsoleApplication : IApplication
    {
        private readonly ITestService _testService;

        public ConsoleApplication(ITestService testService)
        {
            _testService = testService;
        }

        public void Run()
        {
            Console.WriteLine("Starting run...");

            _testService.DoSomething();

            Console.WriteLine("Closing Program...");
        }
    }
}

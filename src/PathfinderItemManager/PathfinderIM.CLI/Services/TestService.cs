using System;

namespace PathfinderIM.CLI.Services
{
    public class TestService : ITestService
    {
        public void DoSomething()
        {
            Console.WriteLine($"Doing something...");
            Console.WriteLine($"Doing something else...");
        }
    }

    public interface ITestService
    {
        void DoSomething();
    }
}

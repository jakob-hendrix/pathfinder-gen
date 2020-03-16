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

        public void SaySomething(string message)
        {
            Console.WriteLine($"I do say, \"{message}\".");
        }
    }

    public interface ITestService
    {
        void DoSomething();
        void SaySomething(string message);
    }
}

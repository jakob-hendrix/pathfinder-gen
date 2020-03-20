using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using PathfinderIM.DataAccess;
using PathfinderIM.Library.Models;

namespace PathfinderIM.CLI.Services
{
    public class ConsoleApplication : IApplication
    {
        private readonly IConfiguration _configuration;
        private readonly PathfinderIMContext _dbContext;
        private readonly ITestService _testService;

        public ConsoleApplication(IConfiguration configuration, PathfinderIMContext dbContext, ITestService testService)
        {
            _configuration = configuration;
            _dbContext = dbContext;
            _testService = testService;
        }

        public void Run()
        {
            Console.WriteLine("Starting run...");


            Console.WriteLine("Closing Program...");
        }

        //temp location - before repository
        private void AddItem()
        {
            var source = new SourceBook
            {
                Id = 1,
                BookName = "Pathfinder RolePlaying Game: Ultimate Equipment",
                License = "OGL",
                Url = "https://paizo.com/products/btpy8tmc?Pathfinder-Roleplaying-Game-Ultimate-Equipment"
            };

            var item = new WondrousItem
            {
                Id = 1,
                Name = "Belt of Tumbling",
                Price = new CurrencyValue { Gold = 400 },
                Slot = ItemSlot.Belt,
                Weight = 1.0m,
                Description = "This thin and flexible cotton cord is meant to be wrapped several times around wearer’s waist. The belt’s wearer gains a +4 competence bonus on Acrobatics checks made to move through a threatened square or through an enemy’s space.",
                Source = source
            };
        }
    }
}

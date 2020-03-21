using System;
using System.Linq;
using PathfinderIM.Data;
using PathfinderIM.Entities.Models;

namespace PathfinderIM.CLI.Services
{
    public class ConsoleApplication : IApplication
    {
        private readonly PathfinderItemContext _context;
  
        public ConsoleApplication(PathfinderItemContext context)
        {
            _context = context;
        }

        public void Run()
        {
            Console.WriteLine("Starting run...");

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            GetItems("Before add: ");
            AddItem();
            GetItems("After add:");

            Console.Write("Press any key...");
            Console.ReadLine();
        }

        //temp location - before repository
        private void AddItem()
        {
            var source = new SourceBook
            {
                BookName = "Pathfinder RolePlaying Game: Ultimate Equipment",
                License = "OGL",
                Url = "https://paizo.com/products/btpy8tmc?Pathfinder-Roleplaying-Game-Ultimate-Equipment"
            };

            var item = new WondrousItem
            { 
                Name = "Belt of Tumbling",
                GoldPrice = 400M,
                Slot = ItemSlot.Belt,
                Weight = 1M,
                Description = "This thin and flexible cotton cord is meant to be wrapped several times around wearer’s waist. The belt’s wearer gains a +4 competence bonus on Acrobatics checks made to move through a threatened square or through an enemy’s space.",
                Source = source
            };

            _context.WondrousItems.Add(item); // in memory at this point

            item = new WondrousItem
            {
                Name = "Shoes of Lightning Leaping",
                GoldPrice = 5250M,
                Slot = ItemSlot.Feet,
                Weight = 1M,
                Description = "These short black shoes fit tightly around the wearer’s feet and bear designs of leaping arcs of lightning and wild winds.\n\nOnce per day on command, a creature wearing these boots can transform into lightning and move up to 50 feet in a straight line, re - materializing at the far end of the lightning bolt.Creatures in the path of the lightning take 6d6 points of electricity damage and objects take damage as per the lightning bolt spell.If the lightning strikes an object or barrier and fails to burst through it, the creature wearing the boots appears next to the impacted object and is staggered for 1 round.Movement while in lightning form does not provoke attacks of opportunity.",
                Source = source
            };

            _context.WondrousItems.Add(item); // in memory at this point
            _context.SaveChanges();  // write to Db
        }

        private void GetItems(string text)
        {
            var items = _context.WondrousItems.ToList();
            Console.WriteLine($"\n{text}: Wondrous Item count is {items.Count}\n");
            foreach (var wondrousItem in items)
            {
                Console.WriteLine($"Id: {wondrousItem.Id}\nName: {wondrousItem.Name}\nDescription: {wondrousItem.Description}\n\n");
            }
        }
    }
}

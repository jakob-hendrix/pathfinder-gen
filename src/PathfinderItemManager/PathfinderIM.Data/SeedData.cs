using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using PathfinderIM.Entities.Models;

namespace PathfinderIM.Data
{
    public static class SeedData
    {
        public static void Initialize(ServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<PathfinderItemContext>();
            if (!context.SourceBooks.Any())
            {
                var source = new SourceBook
                {
                    BookName = "Pathfinder RolePlaying Game: Ultimate Equipment",
                    License = "OGL",
                    Url = "https://paizo.com/products/btpy8tmc?Pathfinder-Roleplaying-Game-Ultimate-Equipment"
                };

                context.SourceBooks.Add(source);
                context.SaveChanges();
            }

            if (!context.WondrousItems.Any())
            {
                var sourceBooks = context.SourceBooks.ToList();
                var sourceBook = sourceBooks
                    .FirstOrDefault(b => b.BookName == "Pathfinder RolePlaying Game: Ultimate Equipment");

                var item = new WondrousItem
                {
                    Name = "Belt of Tumbling",
                    GoldPrice = 400M,
                    Slot = ItemSlot.Belt,
                    Weight = 1M,
                    Description = "This thin and flexible cotton cord is meant to be wrapped several times around wearer’s waist. The belt’s wearer gains a +4 competence bonus on Acrobatics checks made to move through a threatened square or through an enemy’s space.",
                    Source = sourceBook
                };

                context.WondrousItems.Add(item);

                item = new WondrousItem
                {
                    Name = "Shoes of Lightning Leaping",
                    GoldPrice = 5250M,
                    Slot = ItemSlot.Feet,
                    Weight = 1M,
                    Description = "These short black shoes fit tightly around the wearer’s feet and bear designs of leaping arcs of lightning and wild winds.\n\nOnce per day on command, a creature wearing these boots can transform into lightning and move up to 50 feet in a straight line, re - materializing at the far end of the lightning bolt.Creatures in the path of the lightning take 6d6 points of electricity damage and objects take damage as per the lightning bolt spell.If the lightning strikes an object or barrier and fails to burst through it, the creature wearing the boots appears next to the impacted object and is staggered for 1 round.Movement while in lightning form does not provoke attacks of opportunity.",
                    Source = sourceBook
                };

                context.WondrousItems.Add(item);
                context.SaveChanges();
            }
        }
    }
}

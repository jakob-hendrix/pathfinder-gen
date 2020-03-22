using System;
using System.Collections.Generic;
using System.Linq;
using PathfinderIM.Data;

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

            var sourceBooks = _context.SourceBooks.ToList();
            ShowAllItems(sourceBooks);

            var wondrousItems = _context.WondrousItems.ToList();
            ShowAllItems(wondrousItems);

            Console.Write("\nPress any key...");
            Console.ReadLine();
        }

        private void ShowAllItems<T>(List<T> items)
        {
            Console.WriteLine($"\nItem count is {items.Count}\n\n");
            foreach (var item in items)
            {
                Console.WriteLine($"{item}\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using PathfinderTools.Core.Models.Classes;

namespace PathfinderTools.Core.Data
{
    public class InMemoryDataLoader : IDataLoader
    {
        public List<PlayerClass> LoadPlayerClasses()
        {
            var availableClasses = new List<PlayerClass>();

            var fighter = new PlayerClass
            {
                Name = "Fighter"
            };

            availableClasses.Add(fighter);

            return availableClasses;
        }
    }
}

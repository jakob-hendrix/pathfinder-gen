using System.Collections.Generic;
using PathfinderTools.Core.Models.Classes;

namespace PathfinderTools.Core.Data
{
    public interface IDataLoader
    {
        List<PlayerClass> LoadPlayerClasses();
    }
}

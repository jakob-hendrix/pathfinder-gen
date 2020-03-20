using System.Collections.Generic;

namespace PathfinderIM.Library.Models
{
    public class WondrousItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CurrencyValue Price { get; set; }
        public ItemSlot Slot { get; set; }
        public decimal Weight { get; set; }

        public string Description { get; set; }
        public SourceBook Source { get; set; }
        //public string AuraStrength { get; set; }
        //public string AuraType { get; set; }
        //public int CasterLevel { get; set; }
        //public List<ConstructionRequirement> ConstructionRequirements { get; set; }
    }
}

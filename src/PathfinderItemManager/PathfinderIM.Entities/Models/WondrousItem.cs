using System.Collections.Generic;
using PathfinderIM.Entities.Models.Enums;

namespace PathfinderIM.Entities.Models
{
    public class WondrousItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GoldPrice { get; set; }
        public ItemSlot Slot { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public SourceBook Source { get; set; }
        public Aura Aura { get; set; }
        public int CasterLevel { get; set; }
        public List<ConstructionRequirement> ConstructionRequirements { get; set; }
    }
}

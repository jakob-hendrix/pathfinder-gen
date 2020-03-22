using System.Security.Cryptography;

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
        //public string AuraStrength { get; set; }
        //public string AuraType { get; set; }
        //public int CasterLevel { get; set; }

        // how to store - JSON formatted text string deserialized by the data access code
        // XML data type?
        //public List<ConstructionRequirement> ConstructionRequirements { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nDescription:\n{Description}";
        }
    }
}

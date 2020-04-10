using PathfinderIM.Entities.Models.Enums;

namespace PathfinderIM.Entities.Models
{
    public class ConstructionRequirement
    {
        public ConstructionRequirementType Key{ get; set; }
        public object Value { get; set; }
    }
}

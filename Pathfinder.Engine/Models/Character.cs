using System.Collections.Generic;

namespace Pathfinder.Engine.Models
{
    public class Character
    {
        public string Name { get; set; }
        public List<CharacterClass> ClassList { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }

        #region Ability Scores

        public AbilityScore Strength { get; set; }

        #endregion
    }
}

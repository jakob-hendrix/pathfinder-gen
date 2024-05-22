using System.Net.NetworkInformation;

namespace PathfinderCharGen.RulesEngine.DataModels
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Race = "Human";
            Strength = new AbilityScore(10);
            Dexterity = new AbilityScore(10);
            Constitution = new AbilityScore(10);
            Intelligence = new AbilityScore(10);
            Wisdom = new AbilityScore(10);
            Charisma = new AbilityScore(10);
        }

        public string? Name { get; set; }
        public string? Race { get; set; }

        public AbilityScore Strength { get; set; }
        public AbilityScore Dexterity { get; set; }
        public AbilityScore Constitution { get; set; }
        public AbilityScore Intelligence { get; set; }
        public AbilityScore Wisdom { get; set; }
        public AbilityScore Charisma { get; set; }
    }
}

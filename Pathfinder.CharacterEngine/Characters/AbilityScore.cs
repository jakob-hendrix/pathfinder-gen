namespace Pathfinder.CharacterEngine.Characters
{
    /// <summary>
    /// Base class for Ability Scores such as Strength, Dexterity, etc
    /// </summary>
    public class AbilityScore
    {
        public AbilityScore(int baseScore)
        {
            BaseScore = baseScore;
        }

        public int BaseScore { get; set; }

        public int BaseModifier
        {
            get => GetModifier(BaseScore);
        }

        public int? TempScore { get; set; }

        public int TempModifier
        {
            get => GetModifier((int) TempScore);
        }

        private int GetModifier(int abilityScore)
        {
            return 0;
        }
    }
}

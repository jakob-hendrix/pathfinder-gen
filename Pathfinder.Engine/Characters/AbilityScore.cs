using System;

namespace Pathfinder.Engine.Characters
{
    /// <summary>
    /// Base class for Ability Scores such as Strength, Dexterity, etc
    /// </summary>
    public class AbilityScore
    {
        private int _baseScore;

        public AbilityScore(int baseScore)
        {
            BaseScore = baseScore;
        }

        public int BaseScore
        {
            get => _baseScore;
            set => _baseScore = value;
        }

        public int BaseModifier
        {
            get => GetModifier(BaseScore);
        }

        public int? TempScore { get; set; }

        public int? TempModifier
        {
            get
            {
                if (TempScore == null)
                {
                    return null;
                }
                return GetModifier((int)TempScore);
            }
        }

        private int GetModifier(int abilityScore)
        {
            return (int)Math.Floor((double) (abilityScore / 2)) - 5;
        }
    }
}

using System;

namespace PathfinderTools.Core.Models.Character.AbilityScores
{
    public abstract class AbilityScore
    {
        private readonly int _maxNegativeBonus = -5;
        private int _baseScore;

        public AbilityScore()
        {

        }
        public AbilityScore(int maxNegativeBonus)
        {
            _maxNegativeBonus = maxNegativeBonus;
        }

        public int BaseScore
        {
            get => _baseScore;
            set => _baseScore = value < 0 ? 0 : value;
        }

        public int Bonus
        {
            get
            {
                if (_baseScore == 0)
                {
                    return _maxNegativeBonus;
                }

                return (int)Math.Floor((_baseScore - 10) / 2M);
            }
        }
    }
}

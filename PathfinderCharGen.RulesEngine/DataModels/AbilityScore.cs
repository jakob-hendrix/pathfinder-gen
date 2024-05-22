namespace PathfinderCharGen.RulesEngine.DataModels
{
    public class AbilityScore
    {
        public AbilityScore(int baseScore)
        {
            Base = baseScore;
        }

        public int Base { get; set; }

        public int Bonus => (int)Math.Round((Base - 10) / 2m, MidpointRounding.AwayFromZero);
    }
}

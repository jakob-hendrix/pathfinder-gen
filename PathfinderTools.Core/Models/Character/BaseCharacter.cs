using PathfinderTools.Core.Models.Character.AbilityScores;

namespace PathfinderTools.Core.Models.Character
{
    public class BaseCharacter
    {
        public BaseCharacter()
        {
            Strength = new StrengthScore();
            Dexterity = new DexterityScore();
            Constitution = new ConstitutionScore();
            Intelligence = new IntelligenceScore();
            Wisdom = new WisdomScore();
            Charisma = new CharismaScore();
        }

        #region Demographics
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                var name = "";
                if (!string.IsNullOrEmpty(FirstName))
                {
                    name += FirstName;
                }

                if (!string.IsNullOrEmpty(LastName))
                {
                    if (!string.IsNullOrEmpty(name))
                        name += " ";
                    name += LastName;
                }
                return name;
            }
        }

        public string Race { get; set; }
        public Alignment Alignment { get; set; }
        public string Deity { get; set; }
        public string Homeland { get; set; }
        public string Gender { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }

        #endregion

        #region Stats

        public StrengthScore Strength { get; set; }
        public DexterityScore Dexterity { get; set; }
        public ConstitutionScore Constitution { get; set; }
        public IntelligenceScore Intelligence { get; set; }
        public WisdomScore Wisdom { get; set; }
        public CharismaScore Charisma { get; set; }

        #endregion
    }
}

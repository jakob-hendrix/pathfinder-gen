using FluentAssertions;
using PathfinderCharGen.RulesEngine.DataModels;

namespace PathfinderCharGen.RulesEngine.Tests
{
    public class PlayerCharacterTests
    {
        private PlayerCharacter _character;

        public PlayerCharacterTests()
        {
            _character = new PlayerCharacter();
        }

        [Theory]
        [InlineData(1, -5)]
        [InlineData(2, -4)]
        [InlineData(3, -4)]
        [InlineData(4, -3)]
        [InlineData(5, -3)]
        [InlineData(6, -2)]
        [InlineData(7, -2)]
        [InlineData(8, -1)]
        [InlineData(9, -1)]
        [InlineData(10, 0)]
        [InlineData(11, 0)]
        [InlineData(12, 1)]
        [InlineData(13, 1)]
        [InlineData(14, 2)]
        [InlineData(15, 2)]
        [InlineData(16, 3)]
        [InlineData(17, 3)]
        [InlineData(18, 4)]
        [InlineData(19, 4)]
        [InlineData(20, 5)]
        public void TestPlayerStrengthBonusesBasedOnBaseScore(int baseScore, int bonus)
        {
            _character.Strength.Base = baseScore;
            _character.Strength.Bonus.Should().Be(bonus);
        }
    }
}

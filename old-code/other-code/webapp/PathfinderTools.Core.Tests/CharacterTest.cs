using NUnit.Framework;
using PathfinderTools.Core.Models.Character;

namespace PathfinderTools.Core.Tests
{
    [TestFixture]
    public class CharacterTest
    {
        private Character _character;

        [SetUp]
        public void SetUp()
        {
            _character = new Character();
        }

        [Test]
        public void AbilityScoreLessThanZeroIs0()
        {
            _character.Strength.BaseScore = -1;
            Assert.AreEqual(0, _character.Strength.BaseScore);
        }

        [TestCase(0, -5)]
        [TestCase(1, -5)]
        [TestCase(2, -4)]
        [TestCase(3, -4)]
        [TestCase(4, -3)]
        [TestCase(5, -3)]
        [TestCase(6, -2)]
        [TestCase(7, -2)]
        [TestCase(8, -1)]
        [TestCase(9, -1)]
        [TestCase(10, 0)]
        [TestCase(11, 0)]
        [TestCase(12, 1)]
        [TestCase(13, 1)]
        [TestCase(14, 2)]
        [TestCase(15, 2)]
        [TestCase(16, 3)]
        [TestCase(17, 3)]
        [TestCase(18, 4)]
        [TestCase(19, 4)]
        [TestCase(20, 5)]
        [TestCase(100, 45)]
        [TestCase(999, 494)]

        public void StrengthBonusWhenXIsY(int score, int bonus)
        {
            _character.Strength.BaseScore = score;

            Assert.AreEqual(bonus, _character.Strength.Bonus);
        }

        [TestCase(0, -6)]
        [TestCase(1, -5)]
        [TestCase(2, -4)]
        [TestCase(3, -4)]
        [TestCase(4, -3)]
        [TestCase(5, -3)]
        [TestCase(6, -2)]
        [TestCase(7, -2)]
        [TestCase(8, -1)]
        [TestCase(9, -1)]
        [TestCase(10, 0)]
        [TestCase(11, 0)]
        [TestCase(12, 1)]
        [TestCase(13, 1)]
        [TestCase(14, 2)]
        [TestCase(15, 2)]
        [TestCase(16, 3)]
        [TestCase(17, 3)]
        [TestCase(18, 4)]
        [TestCase(19, 4)]
        [TestCase(20, 5)]

        public void DexterityBonusWhenXIsY(int score, int bonus)
        {
            _character.Dexterity.BaseScore = score;

            Assert.AreEqual(bonus, _character.Dexterity.Bonus);
        }
    }
}

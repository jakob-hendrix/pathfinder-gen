using NUnit.Framework;
using Pathfinder.Engine.Models;

namespace Pathfinder.Engine.UnitTests
{
    [TestFixture]
    public class AbilityScoreTests
    {
        [TestCase(1,-5)]
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
        public void BaseModifierCalculatesCorrectly(int inputScore, int expectedModifier)
        {
            int expected = expectedModifier;

            AbilityScore score = new AbilityScore(inputScore);
            int actual = score.BaseModifier;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, null)]
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
        public void TempModifierCalculatesCorrectly(int? inputScore, int? expectedModifier)
        {
            int? expected = expectedModifier;

            AbilityScore score = new AbilityScore(10)
            {
                TempScore = inputScore
            };
            int? actual = score.TempModifier;

            Assert.AreEqual(expected, actual);
        }
    }
}

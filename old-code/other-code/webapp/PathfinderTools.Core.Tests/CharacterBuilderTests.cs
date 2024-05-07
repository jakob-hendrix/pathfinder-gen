using NUnit.Framework;
using PathfinderTools.Core.Builder;
using PathfinderTools.Core.Models;
using PathfinderTools.Core.Models.Character;

namespace PathfinderTools.Core.Tests
{
    public class CharacterBuilderTests
    {
        private readonly GameState _gameState = new GameState();
        private readonly CharacterBuilder _builder = new CharacterBuilder();
        private BaseCharacter _character;

        [SetUp]
        public void Setup()
        {
            _builder.BuildNewCharacter();
            _character = _builder.CurrentCharacter;
        }

        [Test]
        public void BuilderAddsNewCharacterName()
        {
            _character.FirstName = "Test";
            _character.LastName = "Name";

            Assert.AreEqual(_character.FullName, "Test Name");
        }

        [Test]
        public void BuilderAddsOnlyFirstName()
        {
            _character.FirstName = "Bob";
            Assert.AreEqual(_character.FullName, "Bob");
        }

        [Test]
        public void BuilderAddsOnlyLastName()
        {

            _character.LastName = "Jones";
            Assert.AreEqual(_character.FullName, "Jones");
        }
    }
}

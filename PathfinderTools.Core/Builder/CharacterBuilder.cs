using PathfinderTools.Core.Models.Character;

namespace PathfinderTools.Core.Builder
{
    public class CharacterBuilder
    {
        private BaseCharacter _currentCharacter;

        public CharacterBuilder()
        {
            BuildNewCharacter();
        }

        public BaseCharacter CurrentCharacter
        {
            get => _currentCharacter;
        }

        public void BuildNewCharacter()
        {
            _currentCharacter = new BaseCharacter();
        }
    }
}

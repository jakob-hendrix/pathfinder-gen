using Pathfinder.Engine.Models;

namespace Pathfinder.WPF.State
{
    public class CharacterStateManager
    {
        public CharacterEntity CurrentCharacter { get; private set; }

        public CharacterStateManager()
        {
            StartNewCharacter();
        }

        public void StartNewCharacter()
        {
            CurrentCharacter = new CharacterEntity();
        }
    }
}

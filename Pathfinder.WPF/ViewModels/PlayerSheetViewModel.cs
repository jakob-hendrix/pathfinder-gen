using Pathfinder.WPF.State;

namespace Pathfinder.WPF.ViewModels
{
    public class PlayerSheetViewModel : ViewModelBase
    {
        public CharacterStateManager CharacterStateManager { get; }

        public PlayerSheetViewModel(CharacterStateManager characterStateManager)
        {
            CharacterStateManager = characterStateManager;
        }
    }
}

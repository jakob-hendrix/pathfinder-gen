using Pathfinder.WPF.State;

namespace Pathfinder.WPF.ViewModels
{
    public class CharacterEditorViewModel : ViewModelBase
    {
        public CharacterStateManager CharacterStateManager { get; set; }

        public CharacterEditorViewModel(CharacterStateManager characterStateManager)
        {
            CharacterStateManager = characterStateManager;
        }
    }
}

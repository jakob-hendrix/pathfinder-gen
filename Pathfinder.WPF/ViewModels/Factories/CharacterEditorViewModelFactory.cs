using Pathfinder.WPF.State;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.ViewModels.Factories
{
    public class CharacterEditorViewModelFactory : IPathfinderViewModelFactory<CharacterEditorViewModel>
    {
        private readonly CharacterStateManager _characterStateManager;

        public CharacterEditorViewModelFactory(CharacterStateManager characterStateManager)
        {
            _characterStateManager = characterStateManager;
        }

        public CharacterEditorViewModel CreateViewModel()
        {
            return new CharacterEditorViewModel(_characterStateManager);
        }
    }
}

using Pathfinder.WPF.State;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.ViewModels.Factories
{
    public class PlayerSheetViewModelFactory : IPathfinderViewModelFactory<PlayerSheetViewModel>
    {
        private readonly CharacterStateManager _characterStateManager;

        public PlayerSheetViewModelFactory(CharacterStateManager characterStateManager)
        {
            _characterStateManager = characterStateManager;
        }

        public PlayerSheetViewModel CreateViewModel()
        {
            return new PlayerSheetViewModel(_characterStateManager);
        }
    }
}

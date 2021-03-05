using System;
using Pathfinder.WPF.State;
using Pathfinder.WPF.State.Navigators;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.ViewModels.Factories
{
    public class PathfinderViewModelAbstractFactory : IPathfinderViewModelAbstractFactory
    {
        private readonly IPathfinderViewModelFactory<HomeViewModel> _homeViewModelFactory;
        private readonly IPathfinderViewModelFactory<PlayerSheetViewModel> _playerSheetViewModelFactory;
        private readonly IPathfinderViewModelFactory<CharacterEditorViewModel> _characterEditorViewModelFactory;

        public PathfinderViewModelAbstractFactory(
            IPathfinderViewModelFactory<HomeViewModel> homeViewModelFactory,
            IPathfinderViewModelFactory<PlayerSheetViewModel> playerSheetViewModelFactory,
            IPathfinderViewModelFactory<CharacterEditorViewModel> characterEditorViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
            _playerSheetViewModelFactory = playerSheetViewModelFactory;
            _characterEditorViewModelFactory = characterEditorViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                case ViewType.PlayerSheet:
                    return _playerSheetViewModelFactory.CreateViewModel();
                case ViewType.CharacterData:
                    return _characterEditorViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("This ViewType does not have a ViewModel factory", nameof(viewType));
            }
        }
    }
}

using System;
using Pathfinder.WPF.State;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.ViewModels.Factories
{
    public class PathfinderViewModelAbstractFactory : IPathfinderViewModelAbstractFactory
    {
        private readonly IPathfinderViewModelFactory<HomeViewModel> _homeViewModelFactory;

        public PathfinderViewModelAbstractFactory(IPathfinderViewModelFactory<HomeViewModel> homeViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("This ViewType does not have a ViewModel", nameof(viewType));
            }
        }
    }
}

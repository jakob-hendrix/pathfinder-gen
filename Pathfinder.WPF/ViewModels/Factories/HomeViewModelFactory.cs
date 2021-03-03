using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF.ViewModels.Factories
{
    public class HomeViewModelFactory : IPathfinderViewModelFactory<HomeViewModel>
    {
        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel();
        }
    }
}

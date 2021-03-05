using Pathfinder.WPF.State;
using Pathfinder.WPF.State.Navigators;

namespace Pathfinder.WPF.ViewModels.Factories.Common
{
    public interface IPathfinderViewModelAbstractFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}

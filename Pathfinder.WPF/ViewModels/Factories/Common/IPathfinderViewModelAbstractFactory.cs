using Pathfinder.WPF.State;

namespace Pathfinder.WPF.ViewModels.Factories.Common
{
    public interface IPathfinderViewModelAbstractFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}

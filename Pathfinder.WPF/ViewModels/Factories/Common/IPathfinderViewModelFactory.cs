namespace Pathfinder.WPF.ViewModels.Factories.Common
{
    public interface IPathfinderViewModelFactory<T> where T : ViewModelBase
    {
        T CreateViewModel();
    }
}

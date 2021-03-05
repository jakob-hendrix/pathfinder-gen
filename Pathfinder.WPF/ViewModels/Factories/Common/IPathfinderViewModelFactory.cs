namespace Pathfinder.WPF.ViewModels.Factories.Common
{
    public interface IPathfinderViewModelFactory<T>
    {
        T CreateViewModel();
    }
}

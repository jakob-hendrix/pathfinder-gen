using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Pathfinder.WPF.State;
using Pathfinder.WPF.State.Navigators;
using Pathfinder.WPF.ViewModels;
using Pathfinder.WPF.ViewModels.Factories;
using Pathfinder.WPF.ViewModels.Factories.Common;

namespace Pathfinder.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            //Services
            //  Singleton - 1 per app
            services.AddSingleton<CharacterStateManager>();

            // VM Factories - wire up each new ViewModel with its factory here
            services.AddSingleton<IPathfinderViewModelAbstractFactory, PathfinderViewModelAbstractFactory>();
            services.AddSingleton<IPathfinderViewModelFactory<HomeViewModel>, HomeViewModelFactory>();
            services.AddSingleton<IPathfinderViewModelFactory<PlayerSheetViewModel>, PlayerSheetViewModelFactory>();
            services.AddSingleton<IPathfinderViewModelFactory<CharacterEditorViewModel>, CharacterEditorViewModelFactory>();

            //  Transient - new per request
            // none yet


            //  Scoped - new per "scope"
            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<MainViewModel>();

            // Pass in the MainViewModel from our DI container to set the data context of our MainWindow
            services.AddScoped<MainWindow>(
                s => new MainWindow(
                    s.GetRequiredService<MainViewModel>()));


            return services.BuildServiceProvider();
        }
    }
}

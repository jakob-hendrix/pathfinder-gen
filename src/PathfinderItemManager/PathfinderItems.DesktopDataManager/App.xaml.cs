using System;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PathfinderIM.Data;
using PathfinderItems.DesktopDataManager.Services;

namespace PathfinderItems.DesktopDataManager
{
    /// <summary>
    /// Interaction logic for App.xaml (the "Main()" of our WPF app)
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            DataInitializer.InitializeData(ServiceProvider.GetService<PathfinderItemContext>(), true);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }


        /// <summary>
        /// Establish all required services for the program in our DI container
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureServices(IServiceCollection services)
        {
            // add all required services
            var config = new ConfigurationService().GetConfiguration();

            services.AddSingleton(config);
            services.AddDbContext<PathfinderItemContext>
            (
                options => 
                    options.UseSqlServer
                    (
                        config.GetConnectionString(nameof(PathfinderItemContext))
                    )
            );

            // TODO: replace this with our actual shell app - if we change it from MainWindow
            services.AddTransient(typeof(MainWindow));
        }
    }
}

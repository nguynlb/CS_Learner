using Microsoft.Extensions.DependencyInjection;
using NavigationDI.Core;
using NavigationDI.MVVM.ViewModels;
using NavigationDI.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NavigationDI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _provider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            }); ;


            services.AddSingleton<MainViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SettingViewModel>();
            services.AddSingleton<Func<Type, ViewModelBase>>((provider) => viewModelType => (ViewModelBase)provider.GetRequiredService(viewModelType));
            services.AddSingleton<INavigationService, NavigationService>();

            _provider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = _provider.GetRequiredService<MainWindow>();
            mainWindow.Show();

        }



    }
}

using CloneApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace CloneApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //IServiceCollection Container;
        //IServiceProvider Provider;

        public App()
        {
            //Container = new ServiceCollection();
            //Provider = Container.BuildServiceProvider();


            //Container.AddSingleton<MainWindow>();
            //Container.AddSingleton<MainViewModel>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            //MainWindow mainWindow = Provider.GetService<MainWindow>();
            //mainWindow.Show();

            base.OnStartup(e);
        }

    }
}

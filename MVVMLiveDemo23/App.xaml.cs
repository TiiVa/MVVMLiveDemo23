using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using MVVMLiveDemo23.Models;
using MVVMLiveDemo23.Services;
using MVVMLiveDemo23.ViewModels;

namespace MVVMLiveDemo23
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly DemoNavigationService _demoNavigationService;

        public App()
        {
            _demoNavigationService = new DemoNavigationService();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainViewModel = new MainViewModel(_demoNavigationService);

            var mainWindow = new MainWindow(){ DataContext = mainViewModel};

            mainWindow.Show();
        }
    }
}

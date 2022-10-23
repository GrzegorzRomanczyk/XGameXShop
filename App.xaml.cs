using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XGameXShop.Converters;
using XGameXShop.View;
using XGameXShop.ViewModels;

namespace XGameXShop
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            IContainer container = Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                MainWindow mainWindow = scope.Resolve<MainWindow>();
                mainWindow.Show();
            }
        }

        public IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>();
            builder.RegisterType<ViewModelMainWindow>().SingleInstance();
            builder.RegisterType<NewProductWindowViewModel>().SingleInstance();
            builder.RegisterType<ConsoleTypeConverter>().As<IConsoleTypConverter>();
            return builder.Build();
        }
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XGameXShop.View;
using XGameXShop.ViewModels;

namespace XGameXShop
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    MainWindow = new MainWindow();
        //    MainWindow.Show();

        //    base.OnStartup(e);
        //}

        //public App()
        //{
        //}

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
            builder.RegisterType<ViewModelMainWindow>().SingleInstance();
            builder.RegisterType<MainWindow>();
            builder.RegisterType<NewProductWindow>();
            return builder.Build();
        }
    }
}

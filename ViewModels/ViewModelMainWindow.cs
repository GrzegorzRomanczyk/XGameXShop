using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using XGameXShop.Model;
using XGameXShop.View;

namespace XGameXShop.ViewModels
{
    public class ViewModelMainWindow
    {
        public ICommand NewProductWindow { get; }
        public ICommand OpenAbout { get; }
        public ICommand ViewLoaded { get; }

        public ViewModelMainWindow()
        {
            NewProductWindow = new RelayCommand(obj => OnOpenNewProductWindow(obj), obj => true);
            OpenAbout = new RelayCommand(obj => OnOpenAbout(obj), obj => true);
            ViewLoaded = new RelayCommand(obj => OnViewLoaded(obj), obj => true);
        }

        private void OnOpenNewProductWindow(object obj)
        { 
            NewProductWindow newProductWindow = new NewProductWindow();
            newProductWindow.Show();
        }
        private void OnOpenAbout(object obj)
        {
            MessageBox.Show("Migracja pracy inzynierskiej napisanej w Windows Forms do WPF");
        }

        private void OnViewLoaded(object obj)
        {
            // moze kiedys tu cos bedzie zwiazanego z baza danych albo uzytkownikiem
        }
    }
}

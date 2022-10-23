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
        private readonly NewProductWindowViewModel newProductWindoVM;
        public ICommand NewProductWindow { get; }
        public ICommand OpenAbout { get; }
        public ICommand ViewLoaded { get; }

        public ViewModelMainWindow(NewProductWindowViewModel newProductWindoVM)
        {
            NewProductWindow = new RelayCommand(obj => OnOpenNewProductWindow(), obj => true);
            OpenAbout = new RelayCommand(obj => OnOpenAbout(), obj => true);
            ViewLoaded = new RelayCommand(obj => OnViewLoaded(), obj => true);
            this.newProductWindoVM = newProductWindoVM;
        }

        private void OnOpenNewProductWindow()
        {
            newProductWindoVM.SelectedConsoleType = ConsoleEnum.None;
            newProductWindoVM.SelectedPEGIType = PEGIEnum.None;
            NewProductWindow newProductWindow = new NewProductWindow(newProductWindoVM);
            newProductWindow.Show();
        }
        private void OnOpenAbout()
        {
            MessageBox.Show("Migracja pracy inzynierskiej napisanej w Windows Forms do WPF");
        }

        private void OnViewLoaded()
        {
            // moze kiedys tu cos bedzie zwiazanego z baza danych albo uzytkownikiem
        }
    }
}

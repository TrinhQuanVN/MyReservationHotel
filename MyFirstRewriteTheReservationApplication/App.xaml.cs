using MyFirstRewriteTheReservationApplication.Services;
using MyFirstRewriteTheReservationApplication.Store;
using MyFirstRewriteTheReservationApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyFirstRewriteTheReservationApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModel = CreateReservationListingViewModel();
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return ReservationListingViewModel.CreateInstance(new NavigationService<MakeReservationViewModel>(_navigationStore,CreateMakeReservationViewModel));
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(new NavigationService<ReservationListingViewModel>(_navigationStore,CreateReservationListingViewModel));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                
                DataContext = new MainViewModel(_navigationStore) 
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

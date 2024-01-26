using MyFirstRewriteTheReservationApplication.Commands;
using MyFirstRewriteTheReservationApplication.Models;
using MyFirstRewriteTheReservationApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MyFirstRewriteTheReservationApplication.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(NavigationService<MakeReservationViewModel> navigationService)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigationCommand<MakeReservationViewModel>(navigationService);
            UpdateReservationObservator();
        }

        private void UpdateReservationObservator()
        {
            _reservations.Clear();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 1), "Quan0", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 2), "Quan1", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 3), "Quan2", DateTime.Now, DateTime.Now)));

        }

        public static ReservationListingViewModel CreateInstance(NavigationService<MakeReservationViewModel> navigationService)
        {
            return new ReservationListingViewModel(navigationService);
        }
    }
}

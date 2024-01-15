using MyFirstRewriteTheReservationApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRewriteTheReservationApplication.ViewModels
{
    public class ReservationViewModel
    {
        private readonly Reservation _reservation;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
        public string RoomID => _reservation.RoomID.ToString();
        public string Username => _reservation.Username.ToString();
        public string StartDate => _reservation.StartDate.ToString("d");
        public string EndDate => _reservation.EndDate.ToString("d");
    }
}

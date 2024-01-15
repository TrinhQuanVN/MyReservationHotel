using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRewriteTheReservationApplication.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel(ReservationBook reservationBook, string name)
        {
            _reservationBook = reservationBook;
            Name = name;
        }
        public void MakeReservation(Reservation model)
        {
            _reservationBook.AddReservation(model);
        }
        public IEnumerable<Reservation> GetReservations() => _reservationBook.Reservations;
    }
}

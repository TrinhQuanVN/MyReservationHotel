using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRewriteTheReservationApplication.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }
        public void AddReservation(Reservation model)
        {
            //check conflict
            _reservations.Add(model);
        }
        public IEnumerable<Reservation> Reservations => _reservations;
    }
}

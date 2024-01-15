using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRewriteTheReservationApplication.Models
{
    public class RoomID
    {
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public int FloorNumber { get;}
        public int RoomNumber { get; }
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber,RoomNumber);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return obj is RoomID r && FloorNumber==r.FloorNumber && RoomNumber == r.RoomNumber;
        }
    }
}

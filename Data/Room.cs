using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    class Room
    {
        public int RoomID { get; set; }
        public int LocationID { get; set; }
        public int RoomTypeID { get; set; }
        public int BookingID { get; set; }
    }
}

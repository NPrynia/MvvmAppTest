using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Models
{
    public class ReservationBook
    {

        private readonly List<Reservation> _reservation;
        public ReservationBook() 
        {
            _reservation = new List<Reservation>();
        }

        public IEnumerable<Reservation> getReservationForUser(string userName)
        {
            return _reservation.Where(i => i.UserName == userName) ;
        }
        public void addReservation(Reservation reservation)
        {
            _reservation.Add(reservation);
        }
    }
}

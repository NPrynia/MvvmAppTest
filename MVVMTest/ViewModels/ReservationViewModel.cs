using MVVMTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID.ToString();
        public string UserName => _reservation.UserName;
        public DateTime StartTime => _reservation.StrtTime;
        public DateTime EndTime => _reservation.EndTime;

        public ReservationViewModel(Reservation reservation)
        { 
            _reservation = reservation;

        }

    }
}

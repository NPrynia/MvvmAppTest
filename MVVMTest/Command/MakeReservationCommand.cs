using MVVMTest.Models;
using MVVMTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMTest.Command
{
    class MakeReservationCommand : CommandBase
    {
        private Hotel _hotel;
        private MakeReservationViewModel _makeReservationViewModel;
        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel,Hotel hotel) 
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
        }
        public override void Execute(object parametr)
        {

            Reservation reservation = new Reservation(new RoomID(_makeReservationViewModel.FloorID, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartTime,
                _makeReservationViewModel.EndTime);
            _hotel.ReservationBook.addReservation(reservation);
            MessageBox.Show("Ebat");
        }
    }
}

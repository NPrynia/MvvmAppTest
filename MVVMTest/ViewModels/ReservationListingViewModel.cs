using MVVMTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTest.ViewModels
{
    public class ReservationListingViewModel : BaseViewModel
    {

        public ICommand createReservationComand {  get;  }


        private ObservableCollection<ReservationViewModel> _reservations;

        public ObservableCollection<ReservationViewModel> ReservationsList 
        { 
            get 
            {
                return _reservations; 
            }
            set
            {
                _reservations = value;
                onPropertyChanged(nameof(ReservationsList));
            }
        }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2),"Priani",
                new DateTime(2023, 12, 12),
                new DateTime(2023, 12, 20)
                )));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 4),"Priani",
               new DateTime(2023, 12, 1),
               new DateTime(2023, 12, 25)
               )));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 6), "Mishel",
               new DateTime(2023, 12, 2),
               new DateTime(2023, 12, 12)
               )));
        }
    }
}

using MVVMTest.Command;
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


        private ObservableCollection<Reservation> _reservations;

        public ObservableCollection<Reservation> ReservationsList 
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
            
            //_reservations = new ObservableCollection<Reservation>(hotel.ReservationBook.Reservations);
        }
    }
}

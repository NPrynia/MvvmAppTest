using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Models
{
    public class Hotel
    {
        private ReservationBook _reservationBook;

        public ReservationBook ReservationBook 
        { get { return _reservationBook; } 
        }

        private string _name;  
        public string Name
        {
            get 
            { 
                return _name;
            } 
        
        }
        public Hotel(string name, ReservationBook reservationBook) 
        { 
            _name = name;
            _reservationBook = reservationBook;
        } 
    }
}

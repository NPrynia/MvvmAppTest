using MVVMTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Command
{
    class createReservationComand : CommandBase
    {
        private Hotel _hotel;
        public createReservationComand(Hotel hotel) 
        {
            _hotel = hotel;
        }
        public override void Execute(object parametr)
        {

        }
    }
}

using MVVMTest.Command;
using MVVMTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTest.ViewModels
{
        public class MakeReservationViewModel : BaseViewModel
        {
            private string _username;

            public string Username
            {
                get 
                { 
                    return _username;
                }
                set
                { 
                    _username = value;
                    onPropertyChanged(nameof(Username));
                }
            }


        private int _floorID;
        public int FloorID
        {
            get
            {
                return _floorID;
            }
            set
            {
                _floorID = value;
                onPropertyChanged(nameof(FloorID));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                onPropertyChanged(nameof(RoomNumber));
            }
        }


        private DateTime _startTime;
        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
                onPropertyChanged(nameof(StartTime));

            }
        }
        private DateTime _endTime;
        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
                onPropertyChanged(nameof(EndTime));

            }
        }


        public ICommand addReservationCommand {  get; }
        public ICommand cancelReservationCommand {  get; }

        public MakeReservationViewModel(Hotel hotel)
        {
            addReservationCommand = new MakeReservationCommand(this,hotel);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MVVMTest.Models
{
    public class Reservation
    {
        private RoomID _roomID;
        public RoomID RoomID
        {
            get
            {
                return _roomID;
            }
        }
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }


        private DateTime _startTime;
        public DateTime StrtTime
        {
            get
            {
                return _startTime;
            }
        }
        private DateTime _endTime;
        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
        }
        private TimeSpan _lenght => _endTime.Subtract(_startTime);
        public TimeSpan Lenght
        {
            get
            {
                return _lenght;
            }
        }   

        public Reservation(RoomID roomID,string userName, DateTime startTime, DateTime endTime)
        { 
            _userName = userName;
            _roomID = roomID;
            _startTime = startTime;
            _endTime = endTime;
        }
    }
}

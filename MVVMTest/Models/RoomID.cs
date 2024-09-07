using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Models
{
    public class RoomID
    {

        private int _floorID;
        public int FloorID
        {
            get
            {
                return _floorID;
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
        }
        public RoomID(int floorID, int roomNumber)
        {
            _floorID = floorID;
            _roomNumber = roomNumber;
        }


        public override string ToString()
        {
            return $"Floor:{_floorID} Num:{_roomNumber}";
        }
        public override bool Equals(object obj)
        {
            return obj is RoomID roomID &&
                _roomNumber == roomID.RoomNumber &&
                _floorID == roomID.FloorID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_floorID, _roomNumber);
        }
    }
}

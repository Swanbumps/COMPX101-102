using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
	
	class HotelRoom
    {
		public enum RoomType { SingleRoom, QueenStudio, KingStudio, TwoBedroomUnit, LuxurySuite }
		
		private int _roomNumber;
		private int _floor;
		private RoomType _typeOfRoom;
		private bool _riverView;
		private decimal _rate;
		private bool _booked;

		public HotelRoom(int roomNumber,int floor,RoomType typeOfRoom, bool riverView,decimal rate, bool booked)
        {
			_roomNumber = roomNumber;
			_floor = floor;
			_typeOfRoom = typeOfRoom;
			_riverView = riverView;
			_rate = rate;
			_booked = booked;
        }




		public int roomNumber
        {
            get { return _roomNumber; }
        }
		public int floor
		{
			get { return _floor; }
			set
			{
				_floor = value;
			}
		}
		public RoomType typeOfRoom
		{
			get { return _typeOfRoom; }
			set
			{
				_typeOfRoom = value;
			}
		}
		public bool riverView
        {
            get { return _riverView; }
            set { _riverView = value; }
        }
		public decimal rate
        {
			get { return _rate; }
            set { _rate = value; }
        }
		public bool booked
        {
            get { return _booked; }
			set { _booked = value; }
        }
        public override string ToString()
        {
            return roomNumber.ToString().PadRight(5)+floor.ToString().PadRight(5) + typeOfRoom.ToString().PadRight(20) + riverView.ToString().PadRight(7) +rate.ToString().PadRight(7) +booked.ToString().PadRight(7);
        }
    }

}

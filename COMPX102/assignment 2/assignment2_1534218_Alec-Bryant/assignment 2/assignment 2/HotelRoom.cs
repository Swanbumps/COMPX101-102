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
            set {
				if (value > 0)
				{
					_roomNumber = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException
					  ("The value " + value + " is out of range.");
				}
			}
        }
		public int roomNumber
		{
			get { return _roomNumber; }
			set
			{
				if (value > 0)
				{
					_roomNumber = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException
					  ("The value " + value + " is out of range.");
				}
			}
		}
	}
}

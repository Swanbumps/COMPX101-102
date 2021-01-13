using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        const int ROOMS_PER_FLOOR = 5;
        const int NUMBER_OF_FLOORS = 7;

        private BindingList<HotelRoom> _hotelRooms;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            _hotelRooms = new BindingList<HotelRoom>();
            listBox1.DataSource = _hotelRooms;

            // adapted from https://stackoverflow.com/questions/15040872/adding-enum-values-to-a-simple-combobox
            foreach (var item in Enum.GetValues(typeof(HotelRoom.RoomType)))
            {
                comboBoxRoomType.Items.Add(item);
            }

            for(int i = 1; i <= ROOMS_PER_FLOOR*NUMBER_OF_FLOORS; i++)
            {
                HotelRoom room = new HotelRoom((((i-1)/ROOMS_PER_FLOOR)*100)+((i-1)%ROOMS_PER_FLOOR),((i-1)/ROOMS_PER_FLOOR),(HotelRoom.RoomType)rand.Next(0,5),rand.Next(0,2)>0,rand.Next(1,100),rand.Next(0,2)>0);
                _hotelRooms.Add(room);
            }
            

        }
    }
}

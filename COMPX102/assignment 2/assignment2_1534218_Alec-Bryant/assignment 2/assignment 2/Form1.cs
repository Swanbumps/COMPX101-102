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
        private BindingList<HotelRoom> _hotelRooms;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            _hotelRooms = new BindingList<HotelRoom>();
            listBox1.DataSource = _hotelRooms;

            for(int i = 1; i <= 35; i++)
            {
                HotelRoom room = new HotelRoom(i,((i-1)/5),(HotelRoom.RoomType)rand.Next(0,5),rand.Next(0,2)>0,rand.Next(1,100),rand.Next(0,2)>0);
                _hotelRooms.Add(room);
            }
            

        }
    }
}

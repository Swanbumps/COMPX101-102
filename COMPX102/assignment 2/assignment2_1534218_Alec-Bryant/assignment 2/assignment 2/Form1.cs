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
        //################ CONSTANTS ################
        const int ROOMS_PER_FLOOR = 5;
        const int NUMBER_OF_FLOORS = 7;
        //################ INSTANCE VARIABLES ################
        private BindingList<HotelRoom> _hotelRooms;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            _hotelRooms = new BindingList<HotelRoom>();
            listBox1.DataSource = _hotelRooms;

            
            comboBoxRoomType.DataSource = Enum.GetValues(typeof(RoomType));

            for (int i = 1; i <= ROOMS_PER_FLOOR*NUMBER_OF_FLOORS; i++)
            {
                HotelRoom room = new HotelRoom((((i-1)/ROOMS_PER_FLOOR)*100)+((i-1)%ROOMS_PER_FLOOR),((i-1)/ROOMS_PER_FLOOR),(RoomType)rand.Next(0,5),rand.Next(0,2)>0,rand.Next(1,100),rand.Next(0,2)>0);
                _hotelRooms.Add(room);
            }
            updateStatus();


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int roomNumber = (int)numericUpDownRoomNumber.Value;
            // floorNumber = (int)numericUpDownFloorNumber.Value;
            RoomType roomType = (RoomType)comboBoxRoomType.SelectedItem;
            bool riverView = checkBoxRiverView.Checked;
            bool booked = checkBoxBooked.Checked;
            decimal rate = numericUpDownRate.Value;

            foreach(HotelRoom hotelRoom in _hotelRooms)
            {
                if (hotelRoom.roomNumber == roomNumber)
                {
                    return;
                }
            }

            HotelRoom room = new HotelRoom(roomNumber,roomNumber/100,roomType,riverView,rate,false);
            _hotelRooms.Add(room);
            updateStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            HotelRoom room = new HotelRoom(_hotelRooms[listBox1.SelectedIndex].roomNumber, (int)numericUpDownRoomNumber.Value/100, (RoomType)comboBoxRoomType.SelectedItem, checkBoxRiverView.Checked, numericUpDownRate.Value, checkBoxBooked.Checked);
            if(room.roomNumber != _hotelRooms[listBox1.SelectedIndex].roomNumber)
            {
                MessageBox.Show("Room Number was not upated as this is not allowed");
            }
            _hotelRooms[listBox1.SelectedIndex] = room;
            updateStatus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
            HotelRoom room = (HotelRoom) listBox1.SelectedItem;
            numericUpDownRoomNumber.Value = room.roomNumber;
            numericUpDownFloorNumber.Value = room.floor;
            comboBoxRoomType.SelectedItem = room.typeOfRoom;
            checkBoxRiverView.Checked = room.riverView;
            checkBoxBooked.Checked = room.booked;
            numericUpDownRate.Value = room.rate;
            }
        }


        private void numericUpDownRoomNumber_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownFloorNumber.Value = (int)numericUpDownRoomNumber.Value / 100;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<int> listSelected = new List<int>();
            foreach (int index in listBox1.SelectedIndices)
            {
                listSelected.Add(index);
            }
            listSelected.Sort();
            for (int i = listSelected.Count - 1; i >= 0; i--)
            {
                int index = listSelected[i];
                _hotelRooms.RemoveAt(index);
            }
            listBox1.ClearSelected();
            updateStatus();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            decimal invoice = 0;
            bool roomsFree = false;
            List<int> listSelected = new List<int>();
            foreach (int index in listBox1.SelectedIndices)
            {
                if (_hotelRooms[index].booked)
                {
                    roomsFree = true;
                }
            }
            if (!roomsFree)
            {
                foreach (int index in listBox1.SelectedIndices)
                {
                    /*doesn't work cannot figure out why. will randomly skip entries
                    HotelRoom room = _hotelRooms[index];
                    room.booked = true;
                    _hotelRooms[index] = room;
                    */
                    _hotelRooms[index].booked = true;
                    invoice += _hotelRooms[index].rate;

                }
                listBox1.DataSource = null;
                listBox1.DataSource = _hotelRooms;
                updateStatus();
                MessageBox.Show("all rooms booked with a total cost of " + invoice.ToString("c"));
            }
            else
            {
                MessageBox.Show("1 or more of the rooms you selected are already booked");
            }

        }
        private void updateStatus()
        {
            int booked = 0;
            int vacant = 0;
            bool noVacancy = false;
            foreach (HotelRoom hotelRoom in _hotelRooms)
            {
                if (hotelRoom.booked)
                {
                    booked++;
                }
                else
                {
                    vacant++;
                    noVacancy = true;
                }
            }
            labelStatus.Text = "There are " + booked.ToString() + " rooms booked and " + vacant.ToString() + " rooms vacant";
            if (noVacancy)
            {
                labelNoVacancy.BackColor = Color.Black;
            }
            else
            {
                labelNoVacancy.BackColor = Color.Red;
            }
        }
    }
}

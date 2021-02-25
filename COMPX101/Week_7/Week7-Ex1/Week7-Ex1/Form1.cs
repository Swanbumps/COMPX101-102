using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Ex1
{
    public partial class Form1 : Form
    {
        //Name:Alec Bryant
        //Id:1534218

        //The day number that Saturday falls on
        const int SATURDAY = 6;
        //The number of days to display in the planner
        const int NUM_DAYS = 7;
        //The minimum number of hours to display
        const int MIN_HOURS = 1;
        //The maximum number of hours to display
        const int MAX_HOURS = 24;
        //the colour of a weekday appointment (a variable since Color datatype cannot be a const)
        Color WEEK_DAY_COLOR = Color.White;
        //the colour of a weekend appointment (a variable since Color datatype cannot be a const)
        Color WEEK_END_COLOR = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();
        }

        private void MenuDrawPlanner_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen Pen1 = new Pen(Color.Black);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MethodClear();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MethodDrawRow()
        {

        }

        public void MethodClear()
        {
            pictureBoxDisplay.Refresh();
            textBoxHours.Clear();
            textBoxHours.Focus();
        }
        
    }
}

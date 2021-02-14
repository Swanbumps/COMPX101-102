using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Soccer
{
    public partial class Form1 : Form
    {
        private List<Goal> _goals;
        private List<Car> _cars;
        private bool keyPress = false;
        public Form1()
        {
            InitializeComponent();
            _goals = new List<Goal>();
            _cars = new List<Car>();
            _cars.Add(new Player(pictureBox1.Width / 2, pictureBox1.Height / 2, Team.Blue));
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {
            foreach(Car car in _cars)
            {
                car.Advance();
                car.WallCollide(pictureBox1);
                toolStripStatusLabel1.Text = car._turnDirection.ToString();
                toolStripStatusLabel2.Text = car._angle.ToString();
                toolStripStatusLabel3.Text = car._input.ToString();
            }
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyPress)
            {
                foreach (Player player in _cars)
                {
                    player.InputDown(e);
                }
                keyPress = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyPress)
            {
                foreach (Player player in _cars)
                {
                    player.InputUp(e);
                }
                keyPress = false;
            }
        }
        private void Draw(Graphics paper)
        {
            foreach (Car car in _cars)
            {
                car.Draw(paper);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = e.Graphics;
            Draw(paper);
        }
        private double DegToRad(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        
    }
}

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
        public Form1()
        {
            InitializeComponent();
            _goals = new List<Goal>();
            _cars = new List<Car>();
            _cars.Add(new Player(pictureBox1.Width / 2, pictureBox1.Height / 2, Team.Blue));
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            foreach(Player player in _cars)
            {
                player.Input(e);
                
            }
        }
        private void Draw(Graphics paper)
        {
            foreach(Car car in _cars)
            {
                car.Draw(paper);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = e.Graphics;
            Draw(paper);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}

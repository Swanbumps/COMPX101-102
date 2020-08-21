using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveGraphics
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            int size;
            if (e.Button == MouseButtons.Left)
            {
                int noCircles = rand.Next(5, 11);
                int counter = 1;
                while(counter <= noCircles)
                {

                }
                size = rand.Next(0,51);
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen pen1 = new Pen(colorDialog1.Color, 2);
                SolidBrush br = new SolidBrush(Color.Orange);
                br.Color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                //paper.DrawLine(pen1, 625, 325, e.X, e.Y);
                //paper.DrawLine(pen1, rand.Next(pictureBoxDisplay.Width + 1), rand.Next(pictureBoxDisplay.Height + 1), e.X, e.Y);
                paper.FillEllipse(br, e.X, e.Y, size, size);
                paper.DrawEllipse(pen1, e.X, e.Y, size, size);
            }
        }

        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}

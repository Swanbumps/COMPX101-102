using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk_3_ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            //declare points
            Point corner1 = new Point(10, 10);
            Point corner2 = new Point(10, 100);
            Point corner3 = new Point(100, 10);

            //Create pen and paper
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);

            //Draw lines
            paper.DrawLine(pen1, corner1, corner2);
            paper.DrawLine(pen1, corner3, corner2);
            paper.DrawLine(pen1, corner1, corner3);
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            //Declare variables
            int SquareX = 50;
            int SquareY = 80;
            int size = 60;
            //Create pen/paper
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            //Draw rectangle
            paper.DrawRectangle(pen1, SquareX, SquareY, size, size);
        }

        private void buttonErase_Click_1(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
    }
}

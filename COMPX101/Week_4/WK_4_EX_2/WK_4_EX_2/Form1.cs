using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WK_4_EX_2
{
    public partial class Form1 : Form
    {
        const int bars = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFlag_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            SolidBrush blue = new SolidBrush(Color.Blue);
            SolidBrush white = new SolidBrush(Color.White);
            SolidBrush red = new SolidBrush(Color.Red);

            int x = Size.Width / bars;
            int y = Size.Height;
            paper.FillRectangle(blue, 0, 0, x, y);
            paper.FillRectangle(white, x, 0, x, y);
            paper.FillRectangle(red, x * 2, 0, x, y);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

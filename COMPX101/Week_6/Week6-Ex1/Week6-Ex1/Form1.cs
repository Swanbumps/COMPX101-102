using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_Ex1
{
    public partial class Form1 : Form
    {
        //Name:Alec Bryant
        //ID  :1534218

        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320;
        const int DISPLAY_HEIGHT = 460;

        //NOTE: If the display looks wrong in your screen resolution, 
        //please check that the picture box is 400 x 730 pixels in size
        //and adjust the form to be slightly larger than that.
        //Stupid Visual Studio changes the form size based on your screen resolution - gah!

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = Properties.Resources.iPhone;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDrawBalls_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxDisplay.Refresh();
                int RandColour;
                int RowCount = (int)numericUpDownBallsInRow.Value;
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush br = new SolidBrush(Color.Orange);
                Random rand = new Random();

                for (int i = 0; ((i+1) * (GAP_SIZE + BALL_SIZE)) <= DISPLAY_HEIGHT; i++)
                {
                    for (int ii = 0; (ii < RowCount) && (((ii + 1) * (GAP_SIZE + BALL_SIZE)) <= DISPLAY_WIDTH); ii++)
                    {
                        RandColour = rand.Next(0, 41);
                        if (RandColour <= 9 && RandColour >= 0)
                        {
                            br.Color = Color.Blue;
                        } 
                        else if (RandColour >= 10 && RandColour <= 19)
                        {
                            br.Color = Color.Orange;
                        }
                        else if (RandColour >= 20 && RandColour <= 29)
                        {
                            br.Color = Color.Green;
                        }
                        else if (RandColour >= 30 && RandColour <= 39)
                        {
                            br.Color = Color.Red;
                        }
                        else if (RandColour == 40)
                        {
                            br.Color = Color.Purple;
                        }
                        paper.FillEllipse(br, (ii* (GAP_SIZE + BALL_SIZE)) + GAP_SIZE + DISPLAY_LEFT, (i * (GAP_SIZE + BALL_SIZE)) + GAP_SIZE + DISPLAY_TOP, BALL_SIZE, BALL_SIZE);
                    }
                }


                
            }
            catch(Exception ex)
            {
                MessageBox.Show("you idiot\n" + ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            numericUpDownBallsInRow.Value = 0;
            numericUpDownBallsInRow.Focus();
        }
    }
}

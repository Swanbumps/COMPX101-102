using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest2
{
    public partial class Form1 : Form
    {
        //Name:Alec Bryant 
        //ID:1534218

        //Width of a square on the board
        const int SQUARE_WIDTH = 50;
        //Height of a square on the board
        const int SQUARE_HEIGHT = 50;
        //Number of rows and columns of board
        const int BOARD_SIZE = 10;
        //Minimum gap size
        const int MIN_GAP_SIZE = 2;
        //Maximum gap size
        const int MAX_GAP_SIZE = 10;


        /// <summary>
        /// clears textbox and focuses it.
        /// </summary>
        public void ClearTextBox()
        {
            textBoxGapSize.Clear();
            textBoxGapSize.Focus();
        }


        public Form1()
        {
            InitializeComponent();
            textBoxGapSize.Focus();
        }
        /// <summary>
        /// reads input from text box and draw squares evenly spaced by the read value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawBoard_Click(object sender, EventArgs e)
        {
            try
            {
                //make picture box is empty to prevent multilayering
                pictureBoxDisplay.Refresh();
                //read textbox input
                int GapSize = int.Parse(textBoxGapSize.Text);

                //check for invalid gapsize
                if ((GapSize < MIN_GAP_SIZE) || (GapSize > MAX_GAP_SIZE))
                {
                    //trigger catch to clear and focus textbox
                    throw new InvalidGapSize("Gap size out of range");
                }
                //define graphic pen and brush
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen Pen1 = new Pen(Color.Black);
                SolidBrush br = new SolidBrush(Color.Orange);

                //loops to draw each row
                for (int y = 0; y < BOARD_SIZE; y++)
                {

                    //loops to draw each tile on a row
                    for (int x = 0; (x < BOARD_SIZE); x++)
                    {
                        //if first or last row pick blue else pink
                        if (y == 0 || y == 9)
                        {
                            br.Color = Color.LightBlue;
                        }
                        else
                        {
                            br.Color = Color.LightPink;
                        }
                        //draw tile
                        paper.FillRectangle(br, (x * (GapSize + SQUARE_WIDTH)) + GapSize, (y * (GapSize + SQUARE_HEIGHT)) + GapSize, SQUARE_WIDTH, SQUARE_HEIGHT);
                        paper.DrawRectangle(Pen1, (x * (GapSize + SQUARE_WIDTH)) + GapSize, (y * (GapSize + SQUARE_HEIGHT)) + GapSize, SQUARE_WIDTH, SQUARE_HEIGHT);
                    }
                }
            }
            catch (Exception ex)
            {
                //show error
                MessageBox.Show(ex.Message);
                //clear and focus textbox
                ClearTextBox();
                //textBoxGapSize.Clear();
                //textBoxGapSize.Focus();
            }
        }
        //clear drawing and textbox and focus text box
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            ClearTextBox();
            //textBoxGapSize.Clear();
            //textBoxGapSize.Focus();
        }
        //close program
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    //custom exception for out of range gap size
    public class InvalidGapSize : Exception
    {
        public InvalidGapSize(string message)
            : base(message)
        {
        }
    }
}

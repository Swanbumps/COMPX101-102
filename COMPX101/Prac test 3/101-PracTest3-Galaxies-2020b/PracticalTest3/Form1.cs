using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracticalTest3
{
    public partial class Form1 : Form
    {
        //Name:Alec Bryant
        //Id:1534218

        //The number of columns in the grid
        const int NUM_COLUMNS = 26;
        //The number of rows in the grid
        const int NUM_ROWS = 26;
        //The size of each quadrant in the grid
        const int QUADRANT_SIZE = 20;
        //Colors for the various terrain tiles
        Color QUADRANT_COLOR = Color.Black;
        Color SPIRAL_GALAXY_COLOR = Color.Purple;
        Color ELLIPTICAL_GALAXY_COLOR = Color.Orange;
        Color IRREGULAR_GALAXY_COLOR = Color.Yellow;

        const string FILTER = "CSV Files|*.csv|All Files|*.*";

        //Lists to store all the data
        List<string> typeList = new List<string>();
        List<int> blackHolesList = new List<int>();
        List<int> systemsList = new List<int>();
        List<int> columnList = new List<int>();
        List<string> rowList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            listBoxData.Items.Add("Galaxy Type".PadRight(15) + "Black Holes".PadRight(15) + "Systems".PadRight(10) + "Column".PadRight(10) + "Row Letter");
            comboBox1.Items.Add("Spiral");
            comboBox1.Items.Add("Irregular");
            comboBox1.Items.Add("Elliptical");
        }

        /// <summary>
        /// Converts the letter that represents a row into
        /// a y position in the grid.
        /// </summary>
        /// <param name="row">Letter of the row</param>
        /// <returns>The y position of the row in the grid</returns>
        private int CalcYPos(string row)
        {
            int y = (row[0] - 'A') * QUADRANT_SIZE;

            return y;
        }
        
        /// <summary>
        /// Display a qudrant in the grid at the given x and y position in
        /// the given colour.
        /// </summary>
        /// <param name="paper">Where to draw the tile</param>
        /// <param name="x">The x position of the tile</param>
        /// <param name="y">The y position of the tile</param>
        /// <param name="quadrantColor">The colour of the quadrant</param>
        private void DisplayQuadrant(Graphics paper, int x, int y, Color quadrantColor)
        {
            SolidBrush br = new SolidBrush(quadrantColor);
            Pen pen1 = new Pen(Color.White, 1);
            paper.FillRectangle(br, x, y, QUADRANT_SIZE, QUADRANT_SIZE);
            paper.DrawRectangle(pen1, x, y, QUADRANT_SIZE, QUADRANT_SIZE);
        }

        /// <summary>
        /// Display the galaxy at the given x and y value in the given colour.
        /// </summary>
        /// <param name="paper">Where to draw the weapon</param>
        /// <param name="x">The x position of the weapon</param>
        /// <param name="y">The y position of the weapon</param>
        /// <param name="galaxyColor">The colour of the galaxy</param>
        private void DisplayGalaxy(Graphics paper, int x, int y, Color galaxyColor)
        {
            SolidBrush br = new SolidBrush(galaxyColor);

            //Draw the quadrant
            DisplayQuadrant(paper, x, y, QUADRANT_COLOR);
            
            //Draw the galaxy inside the quadrant
            paper.FillEllipse(br, x, y, QUADRANT_SIZE, QUADRANT_SIZE);
        }

        /// <summary>
        /// Display the grid of quadrants.
        /// </summary>
        /// <param name="paper">Where to draw the grid</param>
        private void DisplayGrid(Graphics paper)
        {
            //x and y position of the current quadrant
            int x = 0;
            int y = 0;
            //For each row of quadrants to draw
            for (int row = 1; row <= NUM_ROWS; row++)
            {
                //For each quadrant to draw in the current row
                for (int col = 1; col <= NUM_COLUMNS; col++)
                {
                    //Draw the quadrant at the current x and y position
                    DisplayQuadrant(paper, x, y, QUADRANT_COLOR);
                    //Shift x to the right by width of quadrant
                    x += QUADRANT_SIZE;
                }
                //Shift y down by height of quadrant
                y += QUADRANT_SIZE;
                //Shift x back to start of row
                x = 0;
            }
        }

        /// <summary>
        /// calulates the x position to draw a galaxy at
        /// </summary>
        /// <param name="column">column value</param>
        /// <returns></returns>
        private int CalcXPos(int column)
        {
            int x;
            x = (column - 1) * QUADRANT_SIZE;
            return x;
        }
        /// <summary>
        /// loads data, draw galaxies, saves to  lists and presents in list box
        /// </summary>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;
            string type;
            int blackHoles;
            int systems;
            int column;
            string row;
            int count = 0;
            int linecount = 0;
            Graphics paper = pictureBoxMap.CreateGraphics();


            pictureBoxMap.Refresh();
            listBoxData.Items.Clear();
            DisplayGrid(paper);
            listBoxData.Items.Add("Galaxy Type".PadRight(15) + "Black Holes".PadRight(15) + "Systems".PadRight(10) + "Column".PadRight(10) + "Row Letter");

            //Set the filter
            openFileDialog1.Filter = FILTER;
            //Check if the file is valid
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open file
                reader = File.OpenText(openFileDialog1.FileName);
                //while file not complete
                while (!reader.EndOfStream)
                {
                    linecount++;
                    try
                    {
                        //Read a line
                        line = reader.ReadLine();
                        //Split the values of the line
                        csvArray = line.Split(',');
                        //Check if the array is correct length
                        if (csvArray.Length == 5)
                        {
                            //store values from array
                            type = csvArray[0];
                            blackHoles = int.Parse(csvArray[1]);
                            systems = int.Parse(csvArray[2]);
                            column = int.Parse(csvArray[3]);
                            row = csvArray[4];

                            //Add the values to the listbox
                            listBoxData.Items.Add(type.PadRight(15) + blackHoles.ToString().PadRight(5) + systems.ToString().PadRight(5) + column.ToString().PadRight(5) + row);

                            //Draw galaxies
                            if (type == "Elliptical")
                            {
                                DisplayGalaxy(paper, CalcXPos(column), CalcYPos(row), ELLIPTICAL_GALAXY_COLOR);
                            }
                            else if (type == "Spiral")
                            {
                                DisplayGalaxy(paper, CalcXPos(column), CalcYPos(row), SPIRAL_GALAXY_COLOR);
                            }
                            else if (type == "Irregular")
                            {
                                DisplayGalaxy(paper, CalcXPos(column), CalcYPos(row), IRREGULAR_GALAXY_COLOR);
                            }



                            //store to list
                            typeList.Add(type);
                            blackHolesList.Add(blackHoles);
                            systemsList.Add(systems);
                            columnList.Add(column);
                            rowList.Add(row);

                            //Add 1 to the galaxy count
                            if (type == comboBox1.Text)
                            {
                                count++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error on line " + linecount + ":\n" + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error on line " + linecount + ":\n" + line);
                    }
                }
                //Close the file
                reader.Close();
                MessageBox.Show(count.ToString());
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

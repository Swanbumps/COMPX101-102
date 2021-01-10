using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace run_length
{
    public partial class Form1 : Form
    {

        const int PIXEL_SIZE = 10;
        bool colorstate = true;
        public Form1()
        {
            InitializeComponent();
        }

        public void colorswitch(SolidBrush br)
        {

            colorstate = !colorstate;
            if (colorstate)
            {
                br.Color = Color.Black;
            }
            else
            {
                br.Color = Color.White;
            }
        }

        private void openRunLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                StreamReader reader;

                pictureBoxDisplay.Refresh();
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush br = new SolidBrush(Color.Black);
                string linedata;
                int line;
                int column;
                int count;
                int currentx;
                int currenty;
                bool colorstate = true;
                string[] linearray;
                var list = new List<int> { };
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {                        
                    try
                        {
                        //line count for error
                        line = 0;
                        column = 0;

                        //open file
                        reader = File.OpenText(openFileDialog1.FileName);

                        string[] resolutionstr = reader.ReadLine().Split(',');
                        int WIDTH = int.Parse(resolutionstr[0]);
                        int HEIGHT = int.Parse(resolutionstr[1]);

                        //run through all lines
                        while (!reader.EndOfStream)
                        {
                            linedata = reader.ReadLine();
                            linearray = linedata.Split(',');
                            currentx = 0;
                            colorstate = !true;
                            for (int ii = 0; ii < linearray.Length; ii++)
                            {
                                

                                int temp = int.Parse(linearray[ii]);
                                for (int iii = 0; iii < temp; iii++)
                                {
                                    paper.FillRectangle(br, (currentx * (PIXEL_SIZE)), (line * (PIXEL_SIZE)), PIXEL_SIZE, PIXEL_SIZE);
                                    currentx++;
                                }
                                if (ii < linearray.Length - 1)
                                {
                                    colorswitch(br);
                                }
                                column++;
                            }
                            //read next line
                            line++;

                        }
                            
                        reader.Close();
                        
                    }
                        
                    catch (Exception ex)
                        
                    {
                        MessageBox.Show(ex.Message);
                        pictureBoxDisplay.Refresh();
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("you idiot\n" + ex.Message);
                pictureBoxDisplay.Refresh();
            }
        }
    }
}

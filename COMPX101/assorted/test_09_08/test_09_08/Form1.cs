using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_09_08
{
    public partial class Form1 : Form
    {
        StreamWriter output;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thing = "";
            List<int> rainList = new List<int> { 7, 8, 0, 4, 3, 8, 1 }; 
            rainList.RemoveAt(4);
            int[] rainToday = new int[7] { 1, 9, 2, 4, 3, 7, 5 };
            int weather = 50;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    thing += "x";
                }
                thing += "y" ;
            }
            MessageBox.Show(thing+" ");
            Console.WriteLine("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = "file.txt";
            
            output = File.CreateText(filename);

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    output.Write("x");
                }
                output.WriteLine("y");
            } 
            output.Write("y");
            output.Close();
            StreamReader inStream = File.OpenText(filename);
            string l = inStream.ReadLine();
            int c = 0;
            while (l != null)
            {
                c = c + l.Length;
                l = inStream.ReadLine();
            }
            inStream.Close();
            MessageBox.Show(c.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] table = new int[3, 4];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    table[row, col] = (col + 1) / (row + 1);
                }
            }
            MessageBox.Show(table[2,1].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numsArray = new int[10];
            numsArray[15] = 20;
        }
    }
}

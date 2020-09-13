using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_09_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zzzz = 0;
            for (int i = 0; i < 10; i += 2)
            {
                for (int j = 0; j < 10; j += 3)
                {
                    zzzz++;
                }
            }
            MessageBox.Show(zzzz.ToString()+" ");
            int x = 100;
            do
            {
                x = x + 2;
            } while (x % 2 == 0);
            Console.WriteLine("" + x);
        }
    }
}

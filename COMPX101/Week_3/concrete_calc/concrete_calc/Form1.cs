using System;
using System.Collections.Generic;            
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concrete_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Depth of driveway
            const double DRIVEWAY_DEPTH = 0.5;
            //amount of concrete in one bag
            const double CONCRETE_PER_KG = 1.5;
            //cement bag weight
            const double BAG_WEIGHT = 2.0;
            //Cost of a bag of cement
            const decimal BAG_COST = 15.5m;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxCost.Clear();
            textBoxBags.Clear();
            textBoxVolume.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

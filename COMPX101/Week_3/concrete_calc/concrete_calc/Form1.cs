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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Depth of driveway
            const double DRIVEWAY_DEPTH = 0.5;
            //amount of concrete per 1 kg of cement
            const double CONCRETE_PER_KG = 1.5;
            //cement bag weight
            const double BAG_WEIGHT = 2.0;
            //Cost of a bag of cement
            const decimal BAG_COST = 15.5m;
            textBoxDepth.Text = DRIVEWAY_DEPTH.ToString();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try 
            {
                //Depth of driveway
                const double DRIVEWAY_DEPTH = 0.5;
                //amount of concrete per 1 kg of cement
                const double CONCRETE_PER_KG = 1.5;
                //cement bag weight
                const double BAG_WEIGHT = 2.0;
                //Cost of a bag of cement
                const decimal BAG_COST = 15.5m;
                textBoxDepth.Text = DRIVEWAY_DEPTH.ToString();
                //read values from text boxes
                double Length = double.Parse(textBoxLength.Text);
                double Width = double.Parse(textBoxWidth.Text);
                //calculate/show volume
                double Volume = Length * Width * DRIVEWAY_DEPTH;
                textBoxVolume.Text = Volume.ToString();
                //calculate/show kgs of cement
                double Weight = Volume / CONCRETE_PER_KG;
                textBoxKgs.Text = Weight.ToString();
                //calculate/show bags of cement
                double Bags = Weight / BAG_WEIGHT;
                textBoxBags.Text = Bags.ToString();
                //calculate/show cost
                decimal Cost = (decimal)Bags * BAG_COST;
                textBoxCost.Text = Cost.ToString();
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
            textBoxKgs.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

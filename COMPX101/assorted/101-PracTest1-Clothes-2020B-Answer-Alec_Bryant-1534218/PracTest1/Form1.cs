using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracTest1
{
    public partial class Form1 : Form
    {
        //Name:Alec Bryant
        //ID  :1534218

        //1.9 metres of fabric is required to make 1 t-shirt
        const double FABRIC_PER_SHIRT = 1.9;
        //cost of making 1 metre of hemp fabric is $14.50
        const decimal FABRIC_COST = 14.5m;
        //Amount of square metres of fabric in a roll (for the bonus task)
        const int FABRIC_IN_ROLL = 10;
        //Cost of a roll of fabric (for the bonus task)
        const decimal ROLL_COST = 90;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //read input values
                int tshirts = int.Parse(textBoxShirts.Text);
                double excess = double.Parse(textBoxExcess.Text);
                // calculate/write fabric for tshirts
                double tShirtFabric = tshirts * FABRIC_PER_SHIRT;
                textBoxShirtFabric.Text = Math.Round(tShirtFabric,3).ToString();
                // calculate/write fabric for excess
                double excessFabric = tshirts * FABRIC_PER_SHIRT;
                textBoxExcessFabric.Text = Math.Round(excessFabric, 3).ToString();
                // calculate/write total Fabric
                double totalFabric = tshirts * (FABRIC_PER_SHIRT + (double)excess);
                textBoxTotalFabric.Text = Math.Round(totalFabric,3).ToString();
                // calculate/write cost
                decimal cost = (decimal)totalFabric * FABRIC_COST;
                textBoxCost.Text = cost.ToString("c");

                //calculate/write Rolls
                int rolls = (int)Math.Ceiling(totalFabric / FABRIC_IN_ROLL);
                textBoxRolls.Text = rolls.ToString();
                //calculate/write Rolls Cost
                decimal rollCost = (decimal)rolls * ROLL_COST;
                textBoxRollsCost.Text = rollCost.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show("you idiot\n"+ex.Message);
                textBoxCost.Clear();
                textBoxExcess.Clear();
                textBoxExcessFabric.Clear();
                textBoxShirtFabric.Clear();
                textBoxShirts.Clear();
                textBoxTotalFabric.Clear();
                textBoxRolls.Clear();
                textBoxRollsCost.Clear();
                textBoxShirts.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCost.Clear();
            textBoxExcess.Clear();
            textBoxExcessFabric.Clear();
            textBoxShirtFabric.Clear();
            textBoxShirts.Clear();
            textBoxTotalFabric.Clear();
            textBoxRolls.Clear();
            textBoxRollsCost.Clear();
            textBoxShirts.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

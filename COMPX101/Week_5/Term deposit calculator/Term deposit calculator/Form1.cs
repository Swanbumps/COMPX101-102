// Name: Alec Bryant
// ID: 1534218

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_deposit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            decimal Deposit = decimal.Parse(textBoxDeposit.Text);
            decimal Interest = decimal.Parse(textBoxInterest.Text);
            int Years = int.Parse(textBoxYears.Text);
            if (Deposit > (decimal)0 || Interest > (decimal)0 || Years > 1)
            {
                decimal DepositTotal = Deposit;
                decimal InterestValue;
                for (int Year = 1; Year <= int.Parse(textBoxYears.Text); Year++) 
                {
                    InterestValue = DepositTotal * (Interest / 100);
                    DepositTotal += InterestValue;
                    Console.WriteLine("Year " + Year.ToString() + ": interest = " + InterestValue.ToString("c") + " and deposit = " + DepositTotal.ToString("c"));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WK_4_EX_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if (checkBoxPower.Checked)
            {
                if (radioButtonAND.Checked)
                {
                    if (checkBoxA.Checked && checkBoxB.Checked)
                    {
                        labelLamp.BackColor = Color.Yellow;
                    }
                    else
                    {
                        labelLamp.BackColor = Color.White;
                    }
                }
                else if (radioButtonOR.Checked)
                {
                    if (checkBoxA.Checked || checkBoxB.Checked)
                    {
                        labelLamp.BackColor = Color.Yellow;
                    }
                    else
                    {
                        labelLamp.BackColor = Color.White;
                    }
                }
            }
            else
            {
                labelLamp.BackColor = Color.White;
            }
        }
    }
}

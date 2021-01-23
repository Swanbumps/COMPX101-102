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

namespace knapsackplanner
{
    public partial class Form1 : Form
    {

        private BindingList<Item> _items;
        private BindingList<Container> _containers;
        public Form1()
        {
            InitializeComponent();
            _items = new BindingList<Item>();
            _containers = new BindingList<Container>();
            _dataGridViewItems.DataSource = _items;
            _dataGridViewContainers.DataSource = _containers;
            StreamReader reader;
            string[] lineRead = new string[5];


            try
            {
                //open file
                reader = File.OpenText("knapsack.csv");

                

                //run through all lines
                while (!reader.EndOfStream)
                {
                    //read next line
                    lineRead = reader.ReadLine().Split(',');
                    if (lineRead[0] == "ITEM")
                    {
                        _items.Add(new Item(lineRead[1], double.Parse(lineRead[2]), double.Parse(lineRead[3]), decimal.Parse(lineRead[4])));
                    }
                    else if(lineRead[0] == "CONTAINER")
                    {
                        _containers.Add(new Container(lineRead[1], double.Parse(lineRead[2]), double.Parse(lineRead[3])));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

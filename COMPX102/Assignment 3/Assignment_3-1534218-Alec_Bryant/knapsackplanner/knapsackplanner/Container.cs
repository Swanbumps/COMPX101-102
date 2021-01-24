using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;



namespace knapsackplanner
{
    class Container
    {

        //######################################
        //INSTANCE VARIABLES
        private string _name;
        private double _maxWeight;
        private double _maxVolume;
        private double _totalWeight;
        private double _totalVolume;
        private BindingList<Item> _itemsContained = new BindingList<Item>();

        public Container(string name, double maxWeight, double maxVolume)
        {
            _name = name;
            _maxWeight = maxWeight;
            _maxVolume = maxVolume;
        }



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double MaxWeight
        {
            get { return _maxWeight; }
            set { _maxWeight = value; }
        }
        public double MaxVolume
        {
            get { return _maxVolume; }
            set { _maxVolume = value; }
        }
        public double TotalWeight
        {
            get { return _totalWeight; }
        }
        public double TotalVolume
        {
            get { return _totalVolume; }
        }
        public BindingList<Item> ItemsContained
        {
            get { return _itemsContained; }
            set { _itemsContained = value; }
        }
        public void Bind(DataGridView grid)
        {
            grid.DataSource = _itemsContained;
        }
        public void Update()
        {
            _totalWeight = 0;
            _totalVolume = 0;
            foreach (Item item in _itemsContained)
            {
                _totalWeight += item.Weight;
                _totalVolume += item.Volume;
            }
        }
    }
}

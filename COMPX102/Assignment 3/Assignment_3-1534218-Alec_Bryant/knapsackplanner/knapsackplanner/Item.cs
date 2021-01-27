using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace knapsackplanner
{
    class Item
    {
        //#########################################################################
        //# Instance Variables
        private string _name;
        /// <summary>
        /// Item weight
        /// </summary>
        private double _weight;
        /// <summary>
        /// Item volume
        /// </summary>
        private double _volume;
        /// <summary>
        /// item value
        /// </summary>
        private decimal _value;


        public Item(string name, double weight, double volume, decimal value)
        {
            _name = name;
            _weight = weight;
            _volume = volume;
            _value = value;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public double Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}

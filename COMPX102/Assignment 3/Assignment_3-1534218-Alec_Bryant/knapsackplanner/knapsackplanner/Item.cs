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


        public Item(double weight, double volume, decimal value)
        {
            _weight = weight;
            _volume = volume;
            _value = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace knapsackplanner
{
    class Container
    {

        //######################################
        //INSTANCE VARIABLES
        private double _maxWeight;
        private double _maxVolume;
        private BindingList<Item> _itemsContained;

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

    }
}

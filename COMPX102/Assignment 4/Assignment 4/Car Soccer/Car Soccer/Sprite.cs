using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Soccer
{
    class Sprite
    {
        double _speed;
        int _locX;
        int _locY;
        double _angle;


        public double Speed
        {
            get { return _speed; }
        }
        public int LocX
        {
            get { return _locX; }
        }
        public int LocY
        {
            get { return _locY; }
        }
        private double Angle
        {
            get { return _angle; }
        }
    }
}

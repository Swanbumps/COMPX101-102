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
        internal double _speed;
        internal int _x;
        internal int _y;
        internal double _angle;


        public double Speed
        {
            get { return _speed; }
        }
        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }
        private double Angle
        {
            get { return _angle; }
        }
    }
}

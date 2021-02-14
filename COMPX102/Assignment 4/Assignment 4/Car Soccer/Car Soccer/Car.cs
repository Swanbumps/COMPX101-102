using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Soccer
{
    public enum Team
    {
        Red,
        Blue
    }
    
    class Car : Sprite
    {
        internal Team _team;
        internal bool _input = false;
        internal bool _turnDirection = false;

        public Team Team
        {
            get { return _team; }
        }
        public bool TurnD
        {
            get { return _turnDirection; }
        }
        public bool Input
        {
            get { return _input; }
        }
    }
    
}

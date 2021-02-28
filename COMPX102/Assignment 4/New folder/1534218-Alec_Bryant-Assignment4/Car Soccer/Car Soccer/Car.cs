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
        Blue,
        None
    }

    class Car : Sprite
    {
        internal Team _team;
        internal bool _input = false;
        internal bool _turnDirection = false;


        public override void Accelerate()
        {
            if (!_input)
            {
                if (_speed + 0.15 <= 15)
                {
                    _speed += 0.15;
                }
                else
                {
                    _speed = 15;
                }
            }
            else
            {
                Rotate();
                if (_speed - 0.1 >= 0)
                {
                    _speed -= 0.1;
                }
                else
                {
                    _speed = 0;
                }
            }
        }
        public override void Rotate()
        {
            if (_turnDirection)
            {
                _angle += 2.5;
            }
            else
            {
                _angle -= 2.5;
            }
            _angle %= 360;
            if (_angle < 0)
            {
                _angle += 360;
            }
        }

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

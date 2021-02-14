using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_Soccer
{
    class Player : Car
    {
        
        public Player(int x, int y, Team team)
        {
            _x = x;
            _y = y;
            _team = team;
            if(team == Team.Blue)
            {
                _color = Color.Blue;
            }
            else if (team == Team.Red)
            {
                _color = Color.Red;
            }
            _angle = 135;
        }
        public void InputDown(KeyEventArgs key)
        {
            if(key.KeyCode == Keys.J)
            {
                _input = true;
                _turnDirection = !_turnDirection;
            }
        }
        public void InputUp(KeyEventArgs key)
        {
            if (key.KeyCode == Keys.J)
            {
                _input = false;
            }
        }
        public override void Accelerate()
        {
            if (!_input)
            {
                if (_speed + 0.25 <= 10)
                {
                    _speed += 0.25;
                }
                else
                {
                    _speed = 10;
                }
            }
            else
            {
                Rotate();
                if(_speed - 0.1 >= 0)
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
        }
    }
    
}

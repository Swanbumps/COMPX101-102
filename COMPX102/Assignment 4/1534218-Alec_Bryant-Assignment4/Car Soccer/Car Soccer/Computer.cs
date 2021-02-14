using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Soccer
{
    class Computer : Car
    {
        private double _angleToBall;
        private double _angleDiff;
        private bool _switchD;
        public Computer(int x, int y, Team team, string file)
        {
            _x = x;
            _y = y;
            _team = team;
            if (team == Team.Blue)
            {
                _color = Color.Blue;
            }
            else if (team == Team.Red)
            {
                _color = Color.Red;
            }
            _angle = 315;
            _image = Image.FromFile(file);
        }
        public void Advance(Ball ball)
        {
            bool temp = _input;
            _input = IsFacingBall(ball);
            if (temp != _input)
            {
                if(temp)
                    _turnDirection = !_turnDirection;
            }

            base.Advance();
        }
        public bool IsFacingBall(Ball ball)
        {
            if (_switchD)
            {
                _switchD = false;
                return false;
            }
            else
            {
                float xDiff = _x - ball.X;
                float yDiff = _y - ball.Y;
                _angleToBall = ((Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI) - 90) % 360;
                if (_angleToBall < 0)
                {
                    _angleToBall += 360;
                }
                _angleDiff = Math.Sqrt(Math.Pow((_angle - _angleToBall) % 360,2));
                
                //I made an attempt at making it smart but it occaisionally gets stuck moving upwards
                if (_angleDiff > -5 && _angleDiff < 5)
                {
                    return false;
                }
                else if (_angleDiff > 0 && !_turnDirection)
                {
                    _switchD = true;
                }
                else if (_angleDiff < 0 && _turnDirection)
                {
                    _switchD = true;
                }
                return true;
            }
            
        }
        public double AngleToBall
        {
            get { return _angleToBall; }
        }
        public double AngleDiff
        {
            get { return _angleDiff; }
        }
    }
}

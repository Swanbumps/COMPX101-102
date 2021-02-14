using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Soccer
{
    class Computer : Car
    {
        public Computer(int x, int y, Team team)
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
            _angle = 270;
        }
        public override void Advance()
        {

            base.Advance();
        }
        public void IsFacingBall()
        {
            float xDiff = _ball - x1;
            float yDiff = y2 - y1;
             Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }
    }
}

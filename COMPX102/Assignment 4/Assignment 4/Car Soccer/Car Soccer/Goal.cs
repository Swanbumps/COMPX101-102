using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Soccer
{
    class Goal
    {
        int _x;
        int _y;
        int _sizeX;
        int _sizeY;
        Team _team;
        Point _loc;
        Rectangle _rect;

        public Goal(int x, int y, int sizeX, int sizeY, Team team)
        {
            _x = x;
            _y = y;
            _sizeX = sizeX;
            _sizeY = sizeY;
            _team = team;
            _loc = new Point(x, y);
            _rect = new Rectangle(x, y, sizeX, sizeY);
        }
        public Point Loc
        {
            get { return _loc; }
        }

    }

    

}

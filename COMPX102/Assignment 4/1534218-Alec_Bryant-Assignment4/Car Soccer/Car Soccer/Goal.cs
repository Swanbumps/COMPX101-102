using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        Image _image;

        public Goal(int x, int y, int sizeX, int sizeY, Team team, string file)
        {
            _x = x;
            _y = y;
            _sizeX = sizeX;
            _sizeY = sizeY;
            _team = team;
            _loc = new Point(x, y);
            _rect = new Rectangle(x - sizeX / 2, y - sizeY / 2, sizeX, sizeY);
            _image = Image.FromFile(file);
        }
        public void Draw(Graphics paper)
        {
            Brush br = new SolidBrush(Color.White);
            paper.DrawImage(_image, _x - _sizeX / 2, _y - _sizeY / 2, _sizeX, _sizeY);
            //paper.FillRectangle(_image, _x - _sizeX / 2, _y - _sizeY / 2, _sizeX, _sizeY);

        }
        public Point Loc
        {
            get { return _loc; }
        }
        public Rectangle Rect
        {
            get { return _rect; }
        }
        public Team Team
        {
            get { return _team; }
        }
    }

    

}

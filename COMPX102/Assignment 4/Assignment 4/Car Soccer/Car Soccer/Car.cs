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
        Team _team;
        int _x;
        int _y;

        public void Draw(Graphics paper)
        {
            Brush br = new SolidBrush(Color.Red);
            paper.FillRectangle()
        }

        public Team Team
        {
            get { return _team; }
        }
    }
    
}

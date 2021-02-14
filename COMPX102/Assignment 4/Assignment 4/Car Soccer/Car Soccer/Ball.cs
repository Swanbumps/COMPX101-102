using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Soccer
{
    class Ball : Sprite
    {
        public Ball(PictureBox pictureBox)
        {
            _x = pictureBox.Width / 2;
            _y = pictureBox.Height / 2;
            _speed = 0;
            _angle = 0;
            _color = Color.Gold;
        }
        public void IsInGoal(List<Goal> goals)
        {
            foreach(Goal goal in goals)
            {
                
            }
        }
    }
}

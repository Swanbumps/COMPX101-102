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
        public Team IsInGoal(List<Goal> goals)
        {
            RectangleF rect = new RectangleF(_x - _size / 2, _y - _size / 2, _size, _size);
            foreach (Goal goal in goals)
            { 
                if (rect.IntersectsWith(goal.Rect))
                {
                    if (goal.Team == Team.Blue)
                    {
                        return Team.Red;
                    }
                    else if(goal.Team == Team.Red)
                    {
                        return Team.Blue;
                    }
                }
                else
                {
                    
                }
            }
            return Team.None;
        }
        public void IsCollide(List<Car> cars)
        {
            RectangleF rect = new RectangleF(_x - _size / 2, _y - _size / 2, _size, _size);
            foreach(Car car in cars)
            {
                if (rect.IntersectsWith(new RectangleF(car.X - car.Size / 2, car.Y - car.Size / 2, car.Size, car.Size)))
                {
                    _angle = car.Angle;
                    _speed = car.Speed * 2.5;
                }
            }
        }
        public override void Accelerate()
        {
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
}

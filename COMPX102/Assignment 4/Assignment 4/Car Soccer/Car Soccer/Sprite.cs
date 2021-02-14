using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Soccer
{
    class Sprite
    {
        internal double _speed;
        internal float _x;
        internal float _y;
        internal double _angle;
        internal Color _color;
        internal float _size = 30;
        
        public double Speed
        {
            get { return _speed; }
        }
        public float X
        {
            get { return _x; }
        }
        public float Y
        {
            get { return _y; }
        }
        public double Angle
        {
            get { return _angle; }
        }
        public float Size
        {
            get { return _size; }
        }
        public void Draw(Graphics paper)
        {
            Brush br = new SolidBrush(_color);
            Pen pen = new Pen(Color.Black);
            paper.FillEllipse(br, _x - _size/2, _y - _size/2, _size, _size);
            paper.DrawLine(pen, _x, _y, _x + (float)(_speed * 5F * Math.Cos(DegToRad(_angle - 90))), _y + (float)(_speed * 5F * Math.Sin(DegToRad(_angle - 90))));
            paper.DrawLine(pen, _x, _y, _x + (float)(15 * Math.Cos(DegToRad(_angle - 90))), _y + (float)(15 * Math.Sin(DegToRad(_angle - 90))));
        }
        public virtual void Advance()
        {
            
            Accelerate();
            
            _x += (float)(_speed / 2.5F * Math.Cos(DegToRad(_angle-90)));
            _y += (float)(_speed / 2.5F * Math.Sin(DegToRad(_angle-90)));
            //_x += (float)(_speed/10F);
        }
        public virtual void Accelerate()
        {

        }
        private double DegToRad(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        public virtual void Rotate()
        {

        }
        public void WallCollide(PictureBox pictureBox)
        {

            RectangleF rect = new RectangleF(_x - _size / 2, _y - _size / 2, _size, _size);
            if(rect.IntersectsWith(new RectangleF(0, 0, pictureBox.Width, 0)))
            {
                if (_angle < 90 || _angle > 270)
                {
                    _angle = 270 - (_angle - 270);
                }
            }
            else if (rect.IntersectsWith(new RectangleF(60, 0, 0, pictureBox.Height)))
            {
                if (_angle > 180 && _angle < 360)
                {
                    _angle = 180 - (_angle - 180);
                }
            }
            else if (rect.IntersectsWith(new RectangleF(pictureBox.Width-60, 0, pictureBox.Width, pictureBox.Height)))
            {
                if (_angle < 180 && _angle > 0)
                {
                    _angle = 180 - (_angle - 180);
                }
            }
            else if (rect.IntersectsWith(new RectangleF(0, pictureBox.Height, pictureBox.Width, pictureBox.Height)))
            {
                if (_angle > 90 && _angle < 270)
                {
                    _angle = 270 - (_angle - 270);
                }
            }
            _angle %= 360;
        }
        public void IfOOB(PictureBox pictureBox)
        {
            if (_x < -20 || _x > pictureBox.Width + 20 || _y > pictureBox.Height + 20 || _y < -20)
            {
                Reset(pictureBox);
            }
        }
        public void Reset(PictureBox pictureBox)
        {
            _x = pictureBox.Width / 2;
            _y = pictureBox.Height / 2;
            _speed = 0;
        }
    }
}

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
        internal int _size = 30;
        
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
        private double Angle
        {
            get { return _angle; }
        }
        public void Draw(Graphics paper)
        {
            Brush br = new SolidBrush(_color);
            Pen pen = new Pen(Color.Black);
            paper.FillEllipse(br, _x - _size/2, _y - _size/2, _size, _size);
            paper.DrawLine(pen, _x, _y, _x + (float)(_speed * 5F * Math.Cos(DegToRad(_angle - 90))), _y + (float)(_speed * 5F * Math.Sin(DegToRad(_angle - 90))));
            paper.DrawLine(pen, _x, _y, _x + (float)(15 * Math.Cos(DegToRad(_angle - 90))), _y + (float)(15 * Math.Sin(DegToRad(_angle - 90))));
        }
        public void Advance()
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
            _angle += 2.5;
            _angle %= 360;
        }
        public void WallCollide(PictureBox pictureBox)
        {

            RectangleF rect = new RectangleF(_x - _size / 2, _y - _size / 2, _size, _size);
            if(rect.IntersectsWith(new RectangleF(0, 0, pictureBox.Width, 0)))
            {
                _angle = 270 - (_angle - 270);
            }
            else if (rect.IntersectsWith(new RectangleF(0, 0, 0, pictureBox.Height)))
            {
                _angle = 180 - (_angle - 180);
            }
            else if (rect.IntersectsWith(new RectangleF(pictureBox.Width, 0, pictureBox.Width, pictureBox.Height)))
            {
                _angle = 180 - (_angle - 180);
            }
            else if (rect.IntersectsWith(new RectangleF(0, pictureBox.Height, pictureBox.Width, pictureBox.Height)))
            {
                _angle = 270 - (_angle - 270);
            }
            _angle %= 360;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Soccer
{
    class Sprite
    {
        internal double _speed;
        internal float _x;
        internal float _y;
        internal double _angle;
        internal Color _color;
        
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
            paper.FillRectangle(br, _x - 5, _y - 5, 10, 10);
            paper.DrawLine(pen, _x, _y, _x + (float)(_speed * 5F * Math.Cos(DegToRad(_angle - 90))), _y + (float)(_speed * 5F * Math.Sin(DegToRad(_angle - 90))));
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
        }
    }
}

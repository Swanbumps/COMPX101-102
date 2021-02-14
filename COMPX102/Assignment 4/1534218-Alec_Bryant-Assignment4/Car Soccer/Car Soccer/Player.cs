using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_Soccer
{
    class Player : Car
    {
        
        public Player(int x, int y, Team team, string file)
        {
            _x = x;
            _y = y;
            _team = team;
            if(team == Team.Blue)
            {
                _color = Color.Blue;
            }
            else if (team == Team.Red)
            {
                _color = Color.Red;
            }
            _angle = 90;
            _image = Image.FromFile(file);
        }
        public void InputDown(KeyEventArgs key)
        {
            if(key.KeyCode == Keys.Space)
            {
                _input = true;
                _turnDirection = !_turnDirection;
            }
        }
        public void InputUp(KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Space)
            {
                _input = false;
            }
        }
        
    }
    
}

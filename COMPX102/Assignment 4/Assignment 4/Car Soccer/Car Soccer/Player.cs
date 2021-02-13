using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Soccer
{
    class Player : Car
    {
        bool _turnDirection;
        Team _team;
        public Player(int x, int y, Team team)
        {
            _x = x;
            _y = y;
            _team = team;
        }
        public void Input(KeyEventArgs key)
        {
            if(key.KeyCode == Keys.J)
            {

            }
        }
    }
    
}

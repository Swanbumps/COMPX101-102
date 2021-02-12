using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpaceInvaders
{
  class Bomb : Sprite
  {
    private const int WIDTH = 10;
    private const int HEIGHT = 6;
    private const int SPEED = 5;

    public Bomb(int x, int y)
      : base(x, y, WIDTH, HEIGHT)
    {
    }

    public void Display(Graphics paper)
    {
      paper.FillEllipse(Brushes.Gray, Left, Top, WIDTH, HEIGHT);
    }

    public void Move()
    {
      CentreY += SPEED;
    }
  }
}

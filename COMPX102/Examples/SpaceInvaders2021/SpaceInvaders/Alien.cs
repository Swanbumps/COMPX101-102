using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpaceInvaders
{
  class Alien : Sprite
  {
    private const int WIDTH = 40;
    private const int HEIGHT = 20;
    private const int INITIAL_SPEED = 3;
    private static readonly Bitmap BITMAP = Properties.Resources.alien;

    private int _widthOfScreen;
    private int _speed;

    public Alien(int widthOfScreen, int heightOfScreen)
      : base(widthOfScreen / 2, HEIGHT / 2, WIDTH, HEIGHT)
    {
      _widthOfScreen = widthOfScreen;
      _speed = INITIAL_SPEED;
    }

    public void Display(Graphics paper)
    {
      paper.DrawImage(BITMAP, Left, Top);
    }

    public void Move()
    {
      CentreX += _speed;
      if (Left <= 0 || Right >= _widthOfScreen) {
        _speed = -_speed;
      }
    }

    public Bomb DropBomb()
    {
      return new Bomb(CentreX, CentreY);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpaceInvaders
{
  class Ship : Sprite
  {
    private static readonly Bitmap BITMAP = Properties.Resources.player;
    private static readonly int WIDTH = BITMAP.Width;
    private static readonly int HEIGHT = BITMAP.Height;

    public Ship(int widthOfScreen, int heightOfScreen)
      : base(widthOfScreen / 2, heightOfScreen - HEIGHT / 2, WIDTH, HEIGHT)
    {
    }

    public void Display(Graphics paper)
    {
      paper.DrawImage(BITMAP, Left, Top);
    }
  }
}

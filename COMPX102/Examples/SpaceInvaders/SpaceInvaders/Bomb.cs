using System;
using System.Drawing;

namespace SpaceInvaders
{
  /// <summary>
  /// <para>A bomb dropped by the alien.</para>
  /// <para>This is a subclass of the Sprite class and inherits its methods.</para>
  /// <para>Based on: Douglas Bell and Mike Parr, C# for Students,
  /// Addison-Wesley, 2004.</para>
  /// </summary>
  class Bomb : Sprite
  {
    //########################################################################
    //# Class Constants
    /// <summary>
    /// The width of all bombs, in pixels.
    /// </summary>
    private const int WIDTH = 20;
    /// <summary>
    /// The height of all bombs, in pixels.
    /// </summary>
    private const int HEIGHT = 10;


    //########################################################################
    //# Constructor
    /// <summary>
    /// Creates a new bmb at the indicated position.
    /// </summary>
    /// <param name="x">x-coordinate of the centre of the bomb.</param>
    /// <param name="y">y-coordinate of the centre of the bomb.</param>
    public Bomb(int x, int y)
        : base(x - WIDTH / 2, y - HEIGHT / 2, WIDTH, HEIGHT)
    {
    }


    //########################################################################
    //# Public Methods
    /// <summary>
    /// Moves the bomb downwards by a small amount.
    /// </summary>
    public override void Move()
    {
      Y += 3;
    }

    public override void Display(Graphics paper)
    {
      paper.FillEllipse(Brushes.Gray, X, Y, WIDTH, HEIGHT);
    }
  }
}

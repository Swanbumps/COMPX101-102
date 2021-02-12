using System;
using System.Drawing;

namespace SpaceInvaders
{
  /// <summary>
  /// <para>The player ship of the space invader game.</para>
  /// <para>This is a subclass of the Sprite class and inherits its methods.
  /// The ship is controlled by the mouse and has special methods to move accordingly.</para>
  /// <para>Based on: Douglas Bell and Mike Parr, C# for Students,
  /// Addison-Wesley, 2004.</para>
  /// </summary>
  class Ship : Sprite
  {
    //########################################################################
    //# Class Constants
    /// <summary>
    /// The witdh of the ship, in pixels.
    /// </summary>
    private static readonly int WIDTH = Properties.Resources.player.Width;
    /// <summary>
    /// The height of the ship, in pixels.
    /// </summary>
    private static readonly int HEIGHT = Properties.Resources.player.Height;


    //########################################################################
    //# Constructor
    /// <summary>
    /// Creates a new ship at the left edge of the screen.
    /// </summary>
    /// <param name="y">y-coordinate of the top edge of the ship.</param>
    public Ship(int y)
        : base(0, y - HEIGHT, WIDTH, HEIGHT)
    {
    }


    //########################################################################
    //# Public Methods
    /// <summary>
    /// Moves the ship horizontally to a given position.
    /// </summary>
    /// <param name="newX">The new x-coordinate for the left edge of the ship.</param>
    public void Move(int newX)
    {
      X = newX;
    }

    public override void Move()
    {
    }

    public override void Display(Graphics graphics)
    {
      graphics.DrawImageUnscaled(Properties.Resources.player, X, Y);
    }

  }
}

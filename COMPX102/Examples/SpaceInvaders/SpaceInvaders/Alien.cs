using System;
using System.Drawing;

namespace SpaceInvaders
{
  /// <summary>
  /// <para>The alien moves backwards and forwards across the screen,
  /// gradually moving lower.  It drops bombs randomly.</para>
  /// <para>This is a subclass of the Sprite class and inherits its methods.</para>
  /// <para>Based on: Douglas Bell and Mike Parr, C# for Students,
  /// Addison-Wesley, 2004.</para>
  /// </summary>
  class Alien : Sprite
  {
    //########################################################################
    //# Instance Variables
    /// <summary>
    /// The current direction and speed of the alien.  
    /// Positive moves right, negative moves left.
    /// </summary>
    private int _speed = 3;
    /// <summary>
    /// The width of the picture box in which the alien moves.
    /// Used to change the direction when the edge is reached.
    /// </summary>
    private int _widthOfSpace;

    /// <summary>
    /// A random number generator, used to determine whether or not a bomb
    /// is dropped at sny time. This instance variable is static so that is 
    /// shared by all aliens. This avoid strange effects if there were multiple 
    /// aliens in the game.
    /// </summary>
    private static Random _randomNumberGenerator = new Random();

    //########################################################################
    //# Class Constants
    /// <summary>
    /// The witdh of the alien, used for collion detection.
    /// This is smaller than the image width (Properties.Resources.alien.Width),
    /// making it harder to hit the alien.
    /// </summary>
    private const int WIDTH = 40;
    /// <summary>
    /// The height of the alien, used for collion detection.
    /// This is smaller than the image width (Properties.Resources.alien.Height),
    /// making it harder to hit the alien.
    /// </summary>
    private const int HEIGHT = 20;
    /// <summary>
    /// The amount by which the alien moves downwards each time it hits the
    /// edge of the screen.
    /// </summary>
    private const int ADVANCE = 5;


    //########################################################################
    //# Constructor
    /// <summary>
    /// Creates a new alien at the left edge of the screen.
    /// </summary>
    /// <param name="screenWidth">The widith of the picture box in which the alien moves.</param>
    public Alien(int screenWidth)
        : base(0, 0, WIDTH, HEIGHT)
    {
      _widthOfSpace = screenWidth;
    }


    //########################################################################
    //# Public Methods
    /// <summary>
    /// Moves the alien by a small emount.
    /// The alien moves horizontally based on its speed.
    /// When it reaches the edge of the screen, it reverses its direction and moves downwards by
    /// a small amount.
    /// </summary>
    public override void Move()
    {
      X += _speed;
      if (X < 0 || X + Width > _widthOfSpace) {
        _speed = -_speed;
        Y += ADVANCE;
      }
    }

    public override void Display(Graphics graphics)
    {
      graphics.DrawImageUnscaled(Properties.Resources.alien, X, Y);
    }

    /// <summary>
    /// Chooses whether or not to drop a bomb.
    /// This method determines, using a random number generator, whether the alien drops a bomb.
    /// It either creates a new bomb at the position of the alien and returns it, or does nothing an returns null.
    /// </summary>
    /// <returns>A new bomb, or null.</returns>
    public Bomb LaunchBomb()
    {
      if (_randomNumberGenerator.Next(100) < 5) {
        return new Bomb(X + Width / 2, Y + Height / 2);
      } else {
        return null;
      }
    }
  }
}

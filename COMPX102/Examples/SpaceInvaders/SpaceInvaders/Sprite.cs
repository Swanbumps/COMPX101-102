using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
  /// <summary>
  /// <para>Superclass of all movable objects in the Space Invaders game.</para>
  /// <para>Each spite is defined by a rectangular area on the screen. This abstract
  /// class includes the basic support for display, movement, and collision dectection.</para>
  /// <para>Based on: Douglas Bell and Mike Parr, C# for Students,
  /// Addison-Wesley, 2004.</para>
  /// </summary>
  public abstract class Sprite
  {
    //########################################################################
    //# Instance Variables
    /// <summary>
    /// The x-coordinate of the left edge of the sprite.
    /// </summary>
    private int _x;
    /// <summary>
    /// The y-coordinate of the top edge of the sprite.
    /// </summary>
    private int _y;
    /// <summary>
    /// The width of the sprite, in pixels.
    /// </summary>
    private int _width;
    /// <summary>
    /// The height of the sprite, in pixels.
    /// </summary>
    private int _height;


    //########################################################################
    //# Constructor
    /// <summary>
    /// Creates a new sprite.
    /// </summary>
    /// <param name="x">The x-coordinate of the left edge of the new sprite.</param>
    /// <param name="y">The y-coordinate of the top edge of the new sprite.</param>
    /// <param name="width">The width of the new sprite.</param>
    /// <param name="height">The height of the new sprite.</param>
    public Sprite(int x, int y, int width, int height)
    {
      _x = x;
      _y = y;
      _width = width;
      _height = height;
    }


    //########################################################################
    //# Public Methods
    /// <summary>
    /// Moves the sprite by a small amount.
    /// This method is called periodically using a timer and should move the
    /// sprite according to its speed and/or behaviour. This is an abstract
    /// method with different implementations in every subclass.
    /// </summary>
    public abstract void Move();

    /// <summary>
    /// Displays the sprite in the given graphics context.
    /// This method is called periodically by a paint event handler and should
    /// draw the sprite. It is an abstract method with different implementations 
    /// in every subclass.
    /// </summary>
    public abstract void Display(Graphics graphics);

    /// <summary>
    /// Checks whether this sprite has a collision with another sprite.
    /// This method compares the rectangular regions of two sprites to
    /// check for an overlap.
    /// </summary>
    /// <param name="other">The other sprite to check for collision with.</param>
    /// <returns>true if the two sprites overlap, false otherwise.</returns>
    public bool CollidedWith(Sprite other)
    {
      Rectangle bbox1 = BoundingBox;
      Rectangle bbox2 = other.BoundingBox;
      return bbox1.IntersectsWith(bbox2);
    }


    //########################################################################
    //# Properties
    /// <summary>
    /// The x-coordinate of the left edge of the sprite.
    /// </summary>
    public int X
    {
      get {
        return _x;
      }
      set {
        _x = value;
      }
    }

    /// <summary>
    /// The y-coordinate of the top edge of the sprite.
    /// </summary>
    public int Y
    {
      get {
        return _y;
      }
      set {
        _y = value;
      }
    }

    /// <summary>
    /// The width of the sprite, in pixels.
    /// </summary>
    public int Width {
      get {
        return _width;
      }
    }

    /// <summary>
    /// The height of the sprite, in pixels.
    /// </summary>
    public int Height {
      get {
        return _height;
      }
    }

    /// <summary>
    /// The rectangular area ocupied by the sprite.
    /// </summary>
    public Rectangle BoundingBox
    {
      get {
        return new Rectangle(_x, _y, _width, _height);
      }
    }

  }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
  /// <summary>
  /// <para>A simple game of space invaders.</para>
  /// <para>TODO:
  /// 1. Create a class Laser as a subclass of Sprite with an appropriate constructor
  ///    and implement its Move() and Display() methods. Refer to the Bomb class for
  ///    a template.
  /// 2. Add an instance variable _laser to the Game class (its value will be null or
  ///    the single laser currently in existence). Add code to the timer1_Tick() method to
  ///    move the laser if it exists, and check whether it has collided with the alien.
  ///    Also add code to Game_Paint() to paint the laser if it exists.
  /// 3. Add a method LaunchLaser() to the Ship class, which will be similar to the
  ///    LaunchBomb() method in class Alien (but it will not use a random number generator).
  ///    Then create a handler for the MouseClick event, to call LaunchLaser() when the
  ///    user clicks the mouse and no laser is yet in existence.
  /// 4. Have fun :-)</para>
  /// <para>Based on: Douglas Bell and Mike Parr, C# for Students, Addison-Wesley, 2004.</para>
  /// </summary>
  public partial class Game : Form
  {
    //########################################################################
    //# Instance Variables
    /// <summary>
    /// The player ship.
    /// Displayed at the bottom of the screen and controlled by the mouse.
    /// </summary>
    private Ship _ship;
    /// <summary>
    /// The alien.
    /// Moves left and right at the top of the screen, advancing downwards each
    /// time it hits the edge.
    /// </summary>
    private Alien _alien;
    /// <summary>
    /// List of bombs dropped by the alien and moving downwards.
    /// </summary>
    private List<Bomb> _bombs;

    
    //########################################################################
    //# Constructor
    /// <summary>
    /// Creates and initialises the Space Invaders game.
    /// </summary>
    public Game()
    {
      InitializeComponent();
      MinimumSize = Size;
      MaximumSize = Size;
      _ship = new Ship(_pictureBox.Height);
      _alien = new Alien(Width);
      _bombs = new List<Bomb>();
    }


    //########################################################################
    //# Event Handlers
    /// <summary>
    /// Tick event handler of animation timer.
    /// Moves all sprites by calling the Move() method.
    /// </summary>
    private void AnimationTimerTick(object sender, EventArgs e)
    {
      // Move all bombs.
      // Also remove bombs that are off screen, hence the backwards loop.
      for (int index = _bombs.Count - 1; index >= 0; index--) {
        Bomb bomb = _bombs[index];
        if (bomb.Y >= Height) {
          _bombs.RemoveAt(index);
        } else {
          bomb.Move();
          if (bomb.CollidedWith(_ship)) {
            Win("Alien");
          }
        }
      }
      // Move the alien
      _alien.Move();
      // Ask the alien whether it wants to drop another bomb
      Bomb newBomb = _alien.LaunchBomb();
      if (newBomb != null) {
        _bombs.Add(newBomb);
      }
      // Force repaint. This triggers the GamePaint() handler below.
      Refresh();
    }

    /// <summary>
    /// Mouse handler of picture box.
    /// Moves the player ship to the new mouse position.
    /// </summary>
    private void GameMouseMove(object sender, MouseEventArgs args)
    {
      int x = args.X;
      if (x >= 0 && x + _ship.Width <= _pictureBox.Width) {
        _ship.Move(args.X);
      }
    }

    /// <summary>
    /// Paint event handler of picture box.
    /// Draws all sprites.
    /// </summary>
    private void GamePaint(object sender, PaintEventArgs args)
    {
      Graphics graphics = args.Graphics;
      _alien.Display(graphics);
      _ship.Display(graphics);
      foreach (Bomb bomb in _bombs) {
        bomb.Display(graphics);
      }
    }
    
    
    //########################################################################
    //# Private Methods
    /// <summary>
    /// Stops the game and displays a messge.
    /// </summary>
    /// <param name="winner">The name of the winner, e.g., "Alien".</param>
    private void Win(string winner)
    {
      _animationTimer.Enabled = false;
      MessageBox.Show(winner + " wins!!!");
    }

  }
}
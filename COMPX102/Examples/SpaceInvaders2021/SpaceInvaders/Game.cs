using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
  public partial class Game : Form
  {
    //#####################################################################
    //# Instance Variables
    private const double BOMB_PROBABILITY = 0.05;

    private Alien _alien;
    private Ship _ship;
    private List<Bomb> _bombs;

    private Random _randomNumberGenerator = new Random();
 
    //#####################################################################
    //# Constructor
    public Game()
    {
      InitializeComponent();
      MinimumSize = Size;
      MaximumSize = Size;

      int widthOfScreen = _pictureBox.Width;
      int heightOfScreen = _pictureBox.Height;
      _alien = new Alien(widthOfScreen, heightOfScreen);
      _ship = new Ship(widthOfScreen, heightOfScreen);
      _bombs = new List<Bomb>();
    }


    //#####################################################################
    //# Methods

    //#####################################################################
    //# Event Handlers
    private void _pictureBox_Paint(object sender, PaintEventArgs e)
    {
      Graphics paper = e.Graphics;
      _alien.Display(paper);
      _ship.Display(paper);
      foreach (Bomb bomb in _bombs) {
        bomb.Display(paper);
      }
    }

    private void _animationTimer_Tick(object sender, EventArgs e)
    {
      _alien.Move();
      foreach (Bomb bomb in _bombs) {
        bomb.Move();
      }
      if (_randomNumberGenerator.NextDouble() < BOMB_PROBABILITY) {
        Bomb bomb = _alien.DropBomb();
        _bombs.Add(bomb);
      }
      _pictureBox.Refresh();
    }

    private void _pictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      int mouseX = e.X;
      _ship.CentreX = mouseX;
      _pictureBox.Refresh();
    }
  }
}
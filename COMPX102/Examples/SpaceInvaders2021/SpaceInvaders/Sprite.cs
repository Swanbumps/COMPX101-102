using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpaceInvaders
{
  class Sprite
  {
    //#####################################################################
    //# Instance Variables
    private int _centreX;
    private int _centreY;
    private int _width;
    private int _height;

    //#####################################################################
    //# Constructors
    public Sprite(int x, int y, int width, int height)
    {
      _centreX = x;
      _centreY = y;
      _width = width;
      _height = height;
    }

    //#####################################################################
    //# Methods

    //#####################################################################
    //# Properties
    public int CentreX {
      get { return _centreX; } 
      set { _centreX = value; }
    }

    public int CentreY {
      get { return _centreY; } 
      set { _centreY = value; }
    }

    public int Width { get { return _width; } }
    public int Height { get { return _height; } }
    public int Left { get { return _centreX - _width / 2; } }
    public int Right { get { return _centreX + _width / 2; } }
    public int Bottom { get { return _centreY + _height / 2; } }
    public int Top { get { return _centreY - _height / 2; } }
  }
}

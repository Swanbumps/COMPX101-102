using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Compx102H
{
  /// <summary>
  /// <para>Wind farm designer form for COMPX102-21H Assignment 1.</para>
  /// <para>This starting point implementation allows the user to click
  /// in a picture box to produce grey wind turbines. Your task is to
  /// extend it to produce different kinds of wind turbines and to edit 
  /// them in different ways.</para>
  /// <para>Please see the assignment handout for details. Also please
  /// look at the WindTurbine class, which contains several methods and
  /// properties that will help you to solve this assignment.</para>
  /// <para>Written by Robi Malik, 2020-2021.</para>
  /// </summary>
  public partial class WindFarmForm : Form
  {
    //####################################################################
    //# Instance Variables
    /// <summary>
    /// List of all the turbines currently in the wind farm.
    /// </summary>
    private List<WindTurbine> _turbines;
    //####################################################################
    //# Constructor
    public WindFarmForm()
    {
      _turbines = new List<WindTurbine>();
      InitializeComponent();
    }


    //####################################################################
    //# Auxiliary Methods
    /// <summary>
    /// Displays all the wind turbines in the given graphics context.
    /// </summary>
    private void Draw(Graphics paper)
    {
      foreach (WindTurbine turbine in _turbines) {
        turbine.Draw(paper);
      }
    }


    //####################################################################
    //# Event Handlers
    /// <summary>
    /// Event handler called when the form needs redrawing.
    /// Causes all the wind turbines to be re-displayed.
    /// You do not need to change this method.
    /// </summary>
    private void PictureBoxWindFarmPaint(object sender, PaintEventArgs e)
    {
      Graphics paper = e.Graphics;
      Draw(paper);
    }

    /// <summary>
    /// Mouse-click handler of the picture box.
    /// You need to change this method.
    /// </summary>
    private void PictureBoxWindFarmMouseClick(object sender, MouseEventArgs e)
    {
      // Read mouse-click position
      int x = e.X;
      int y = e.Y;
      int poleHeight = _heightTrackBar.Value;
      decimal capacity = _capacityUpDown.Value;
      int bladeCount = (int)_numberOfBladesUpDown.Value;
      float rotorRadius = ((float)_radiusTrackBar.Value / (float)100);
      bool clockwise = _clockwiseCheckBox.Checked;
      Color poleColour = _poleColorButton.BackColor;
      Color rotorColour = _rotorColorButton.BackColor;


      if (e.Button == MouseButtons.Left) {
        foreach (WindTurbine turbine1 in _turbines) {
          if (turbine1.IsPoleClicked(x, y)) {
            _heightTrackBar.Value = turbine1.PoleHeight;
            _capacityUpDown.Value = turbine1.Capacity;
            _numberOfBladesUpDown.Value = turbine1.NumberOfBlades;
            _radiusTrackBar.Value = (int)(turbine1.RotorRadius * (float) 100);
            _clockwiseCheckBox.Checked = turbine1.Clockwise;
            _poleColorButton.BackColor = turbine1.PoleColor;
            _rotorColorButton.BackColor = turbine1.RotorColor;
            return;
          }
        }

        // Create wind turbine at this position, using "grey" default for attributes
        WindTurbine turbine = new WindTurbine(poleHeight, rotorRadius, bladeCount, clockwise, poleColour, rotorColour, capacity, x, y);
        // Add wind turbine to farm list
        _turbines.Add(turbine);
        // Force redraw of the picture box to show changes
        _pictureBoxWindFarm.Refresh();
      }


      else if(e.Button == MouseButtons.Right) {

        foreach (WindTurbine turbine1 in _turbines) {
          if (turbine1.IsPoleClicked(x, y)) {
            WindTurbine newTurbine = new WindTurbine(poleHeight, rotorRadius, bladeCount, clockwise, poleColour, rotorColour, capacity, (int) turbine1.CentreX, (int) turbine1.CentreY);
            _turbines.Remove(turbine1);
            _turbines.Add(newTurbine);
            return;
          }
        }
      }
      

      

      
    }

    /// <summary>
    /// Tick event handler of animation timer.
    /// This method is called 50 times per second. 
    /// It rotates the rotors of all wind turbines slightly and redraws the picture box,
    /// producing the impression of rotating wind turbines.
    /// You do not need to change this method.
    /// </summary>
    private void AnimationTimerTick(object sender, EventArgs e)
    {
      // Rotate each rotor by 5 degrees
      foreach (WindTurbine turbine in _turbines) {
        turbine.Rotate(5.0f);
      }
      // Force redraw of the picture box to show changes
      _pictureBoxWindFarm.Refresh();

      _statusUpdate(_turbines);
    }

    private void _clearButton_Click(object sender, EventArgs e)
    {
      _turbines.Clear();
      _pictureBoxWindFarm.Refresh();
    }

    private void _pictureBoxWindFarm_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      int x = e.X;
      int y = e.Y;
      foreach (WindTurbine turbine in _turbines) {
        if (turbine.IsPoleClicked(x, y)) {
          _turbines.Remove(turbine);
          _pictureBoxWindFarm.Refresh();
          return;
        }
      }
    }

    private void _statusUpdate(List<WindTurbine> _turbines)
    {
      int count = _turbines.Count;
      decimal totalCapacity = 0;
      foreach(WindTurbine turbine in _turbines) {
        totalCapacity += turbine.Capacity;
      }
      string statusString = "These " + _turbines.Count.ToString() + " wind turbines can generate a total of " + totalCapacity.ToString("f1") + "MW of power";
      _statusLabel.Text = statusString;
    }
  }
}
